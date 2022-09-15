using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tls;

internal class DtlsReliableHandshake
{
	internal class Message
	{
		private readonly int m_message_seq;

		private readonly short m_msg_type;

		private readonly byte[] m_body;

		public int Seq => m_message_seq;

		public short Type => m_msg_type;

		public byte[] Body => m_body;

		internal Message(int message_seq, short msg_type, byte[] body)
		{
			m_message_seq = message_seq;
			m_msg_type = msg_type;
			m_body = body;
		}
	}

	internal class RecordLayerBuffer : MemoryStream
	{
		internal RecordLayerBuffer(int size)
			: base(size)
		{
		}

		internal void SendToRecordLayer(DtlsRecordLayer recordLayer)
		{
			byte[] buffer = GetBuffer();
			int len = (int)Length;
			recordLayer.Send(buffer, 0, len);
			Platform.Dispose(this);
		}
	}

	internal class Retransmit : DtlsHandshakeRetransmit
	{
		private readonly DtlsReliableHandshake m_outer;

		internal Retransmit(DtlsReliableHandshake outer)
		{
			m_outer = outer;
		}

		public void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len)
		{
			m_outer.ProcessRecord(0, epoch, buf, off, len);
		}
	}

	private const int MAX_RECEIVE_AHEAD = 16;

	private const int MESSAGE_HEADER_LENGTH = 12;

	internal const int INITIAL_RESEND_MILLIS = 1000;

	private const int MAX_RESEND_MILLIS = 60000;

	private DtlsRecordLayer m_recordLayer;

	private Timeout m_handshakeTimeout;

	private TlsHandshakeHash m_handshakeHash;

	private IDictionary m_currentInboundFlight = Platform.CreateHashtable();

	private IDictionary m_previousInboundFlight;

	private IList m_outboundFlight = Platform.CreateArrayList();

	private int m_resendMillis = -1;

	private Timeout m_resendTimeout;

	private int m_next_send_seq;

	private int m_next_receive_seq;

	internal TlsHandshakeHash HandshakeHash => m_handshakeHash;

	internal static DtlsRequest ReadClientRequest(byte[] data, int dataOff, int dataLen, Stream dtlsOutput)
	{
		byte[] array = DtlsRecordLayer.ReceiveClientHelloRecord(data, dataOff, dataLen);
		if (array != null && array.Length >= 12)
		{
			long recordSeq = TlsUtilities.ReadUint48(data, dataOff + 5);
			short num = TlsUtilities.ReadUint8(array, 0);
			if (1 != num)
			{
				return null;
			}
			int num2 = TlsUtilities.ReadUint24(array, 1);
			if (array.Length != 12 + num2)
			{
				return null;
			}
			if (TlsUtilities.ReadUint24(array, 6) != 0)
			{
				return null;
			}
			int num3 = TlsUtilities.ReadUint24(array, 9);
			if (num2 != num3)
			{
				return null;
			}
			ClientHello clientHello = ClientHello.Parse(new MemoryStream(array, 12, num2, writable: false), dtlsOutput);
			return new DtlsRequest(recordSeq, array, clientHello);
		}
		return null;
	}

	internal static void SendHelloVerifyRequest(DatagramSender sender, long recordSeq, byte[] cookie)
	{
		TlsUtilities.CheckUint8(cookie.Length);
		int num = 3 + cookie.Length;
		byte[] array = new byte[12 + num];
		TlsUtilities.WriteUint8((short)3, array, 0);
		TlsUtilities.WriteUint24(num, array, 1);
		TlsUtilities.WriteUint24(num, array, 9);
		TlsUtilities.WriteVersion(ProtocolVersion.DTLSv10, array, 12);
		TlsUtilities.WriteOpaque8(cookie, array, 14);
		DtlsRecordLayer.SendHelloVerifyRequestRecord(sender, recordSeq, array);
	}

	internal DtlsReliableHandshake(TlsContext context, DtlsRecordLayer transport, int timeoutMillis, DtlsRequest request)
	{
		m_recordLayer = transport;
		m_handshakeHash = new DeferredHash(context);
		m_handshakeTimeout = Timeout.ForWaitMillis(timeoutMillis);
		if (request != null)
		{
			m_resendMillis = 1000;
			m_resendTimeout = new Timeout(m_resendMillis);
			long recordSeq = request.RecordSeq;
			int messageSeq = request.MessageSeq;
			byte[] message = request.Message;
			m_recordLayer.ResetAfterHelloVerifyRequestServer(recordSeq);
			DtlsReassembler value = new DtlsReassembler(1, message.Length - 12);
			m_currentInboundFlight[messageSeq] = value;
			m_next_send_seq = 1;
			m_next_receive_seq = messageSeq + 1;
			m_handshakeHash.Update(message, 0, message.Length);
		}
	}

	internal void ResetAfterHelloVerifyRequestClient()
	{
		m_currentInboundFlight = Platform.CreateHashtable();
		m_previousInboundFlight = null;
		m_outboundFlight = Platform.CreateArrayList();
		m_resendMillis = -1;
		m_resendTimeout = null;
		m_next_receive_seq = 1;
		m_handshakeHash.Reset();
	}

	internal TlsHandshakeHash PrepareToFinish()
	{
		TlsHandshakeHash handshakeHash = m_handshakeHash;
		m_handshakeHash = m_handshakeHash.StopTracking();
		return handshakeHash;
	}

	internal void SendMessage(short msg_type, byte[] body)
	{
		TlsUtilities.CheckUint24(body.Length);
		if (m_resendTimeout != null)
		{
			CheckInboundFlight();
			m_resendMillis = -1;
			m_resendTimeout = null;
			m_outboundFlight.Clear();
		}
		Message message = new Message(m_next_send_seq++, msg_type, body);
		m_outboundFlight.Add(message);
		WriteMessage(message);
		UpdateHandshakeMessagesDigest(message);
	}

	internal byte[] ReceiveMessageBody(short msg_type)
	{
		Message message = ReceiveMessage();
		if (message.Type != msg_type)
		{
			throw new TlsFatalAlert(10);
		}
		return message.Body;
	}

	internal Message ReceiveMessage()
	{
		long currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
		if (m_resendTimeout == null)
		{
			m_resendMillis = 1000;
			m_resendTimeout = new Timeout(m_resendMillis, currentTimeMillis);
			PrepareInboundFlight(Platform.CreateHashtable());
		}
		byte[] array = null;
		Message pendingMessage;
		while (true)
		{
			if (!m_recordLayer.IsClosed)
			{
				pendingMessage = GetPendingMessage();
				if (pendingMessage != null)
				{
					break;
				}
				if (!Timeout.HasExpired(m_handshakeTimeout, currentTimeMillis))
				{
					int waitMillis = Timeout.GetWaitMillis(m_handshakeTimeout, currentTimeMillis);
					waitMillis = Timeout.ConstrainWaitMillis(waitMillis, m_resendTimeout, currentTimeMillis);
					if (waitMillis < 1)
					{
						waitMillis = 1;
					}
					int receiveLimit = m_recordLayer.GetReceiveLimit();
					if (array == null || array.Length < receiveLimit)
					{
						array = new byte[receiveLimit];
					}
					int num = m_recordLayer.Receive(array, 0, receiveLimit, waitMillis);
					if (num < 0)
					{
						ResendOutboundFlight();
					}
					else
					{
						ProcessRecord(16, m_recordLayer.ReadEpoch, array, 0, num);
					}
					currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
					continue;
				}
				throw new TlsTimeoutException("Handshake timed out");
			}
			throw new TlsFatalAlert(90);
		}
		return pendingMessage;
	}

	internal void Finish()
	{
		DtlsHandshakeRetransmit retransmit = null;
		if (m_resendTimeout != null)
		{
			CheckInboundFlight();
		}
		else
		{
			PrepareInboundFlight(null);
			if (m_previousInboundFlight != null)
			{
				retransmit = new Retransmit(this);
			}
		}
		m_recordLayer.HandshakeSuccessful(retransmit);
	}

	internal static int BackOff(int timeoutMillis)
	{
		return System.Math.Min(timeoutMillis * 2, 60000);
	}

	private void CheckInboundFlight()
	{
		foreach (int key in m_currentInboundFlight.Keys)
		{
			_ = key;
		}
	}

	private Message GetPendingMessage()
	{
		DtlsReassembler dtlsReassembler = (DtlsReassembler)m_currentInboundFlight[m_next_receive_seq];
		if (dtlsReassembler != null)
		{
			byte[] bodyIfComplete = dtlsReassembler.GetBodyIfComplete();
			if (bodyIfComplete != null)
			{
				m_previousInboundFlight = null;
				return UpdateHandshakeMessagesDigest(new Message(m_next_receive_seq++, dtlsReassembler.MsgType, bodyIfComplete));
			}
		}
		return null;
	}

	private void PrepareInboundFlight(IDictionary nextFlight)
	{
		ResetAll(m_currentInboundFlight);
		m_previousInboundFlight = m_currentInboundFlight;
		m_currentInboundFlight = nextFlight;
	}

	private void ProcessRecord(int windowSize, int epoch, byte[] buf, int off, int len)
	{
		bool flag = false;
		while (len >= 12)
		{
			int num = TlsUtilities.ReadUint24(buf, off + 9);
			int num2 = num + 12;
			if (len < num2)
			{
				break;
			}
			int num3 = TlsUtilities.ReadUint24(buf, off + 1);
			int num4 = TlsUtilities.ReadUint24(buf, off + 6);
			if (num4 + num > num3)
			{
				break;
			}
			short num5 = TlsUtilities.ReadUint8(buf, off);
			int num6 = ((num5 == 20) ? 1 : 0);
			if (epoch != num6)
			{
				break;
			}
			int num7 = TlsUtilities.ReadUint16(buf, off + 4);
			if (num7 < m_next_receive_seq + windowSize)
			{
				if (num7 >= m_next_receive_seq)
				{
					DtlsReassembler dtlsReassembler = (DtlsReassembler)m_currentInboundFlight[num7];
					if (dtlsReassembler == null)
					{
						dtlsReassembler = new DtlsReassembler(num5, num3);
						m_currentInboundFlight[num7] = dtlsReassembler;
					}
					dtlsReassembler.ContributeFragment(num5, num3, buf, off + 12, num4, num);
				}
				else if (m_previousInboundFlight != null)
				{
					DtlsReassembler dtlsReassembler2 = (DtlsReassembler)m_previousInboundFlight[num7];
					if (dtlsReassembler2 != null)
					{
						dtlsReassembler2.ContributeFragment(num5, num3, buf, off + 12, num4, num);
						flag = true;
					}
				}
			}
			off += num2;
			len -= num2;
		}
		if (flag && CheckAll(m_previousInboundFlight))
		{
			ResendOutboundFlight();
			ResetAll(m_previousInboundFlight);
		}
	}

	private void ResendOutboundFlight()
	{
		m_recordLayer.ResetWriteEpoch();
		foreach (Message item in m_outboundFlight)
		{
			WriteMessage(item);
		}
		m_resendMillis = BackOff(m_resendMillis);
		m_resendTimeout = new Timeout(m_resendMillis);
	}

	private Message UpdateHandshakeMessagesDigest(Message message)
	{
		short type = message.Type;
		if (type != 0 && (uint)(type - 3) > 1u && type != 24)
		{
			byte[] body = message.Body;
			byte[] array = new byte[12];
			TlsUtilities.WriteUint8(type, array, 0);
			TlsUtilities.WriteUint24(body.Length, array, 1);
			TlsUtilities.WriteUint16(message.Seq, array, 4);
			TlsUtilities.WriteUint24(0, array, 6);
			TlsUtilities.WriteUint24(body.Length, array, 9);
			m_handshakeHash.Update(array, 0, array.Length);
			m_handshakeHash.Update(body, 0, body.Length);
		}
		return message;
	}

	private void WriteMessage(Message message)
	{
		int num = m_recordLayer.GetSendLimit() - 12;
		if (num < 1)
		{
			throw new TlsFatalAlert(80);
		}
		int num2 = message.Body.Length;
		int num3 = 0;
		do
		{
			int num4 = System.Math.Min(num2 - num3, num);
			WriteHandshakeFragment(message, num3, num4);
			num3 += num4;
		}
		while (num3 < num2);
	}

	private void WriteHandshakeFragment(Message message, int fragment_offset, int fragment_length)
	{
		RecordLayerBuffer recordLayerBuffer = new RecordLayerBuffer(12 + fragment_length);
		TlsUtilities.WriteUint8(message.Type, recordLayerBuffer);
		TlsUtilities.WriteUint24(message.Body.Length, recordLayerBuffer);
		TlsUtilities.WriteUint16(message.Seq, recordLayerBuffer);
		TlsUtilities.WriteUint24(fragment_offset, recordLayerBuffer);
		TlsUtilities.WriteUint24(fragment_length, recordLayerBuffer);
		recordLayerBuffer.Write(message.Body, fragment_offset, fragment_length);
		recordLayerBuffer.SendToRecordLayer(m_recordLayer);
	}

	private static bool CheckAll(IDictionary inboundFlight)
	{
		foreach (DtlsReassembler value in inboundFlight.Values)
		{
			if (value.GetBodyIfComplete() == null)
			{
				return false;
			}
		}
		return true;
	}

	private static void ResetAll(IDictionary inboundFlight)
	{
		foreach (DtlsReassembler value in inboundFlight.Values)
		{
			value.Reset();
		}
	}
}
