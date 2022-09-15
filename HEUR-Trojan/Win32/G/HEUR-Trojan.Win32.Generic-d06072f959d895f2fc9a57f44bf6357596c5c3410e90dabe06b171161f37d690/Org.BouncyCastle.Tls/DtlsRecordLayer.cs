using System;
using System.IO;
using System.Net.Sockets;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tls;

internal class DtlsRecordLayer : DatagramReceiver, DatagramSender, DatagramTransport, TlsCloseable
{
	private const int RECORD_HEADER_LENGTH = 13;

	private const int MAX_FRAGMENT_LENGTH = 16384;

	private const long TCP_MSL = 120000L;

	private const long RETRANSMIT_TIMEOUT = 240000L;

	private readonly TlsContext m_context;

	private readonly TlsPeer m_peer;

	private readonly DatagramTransport m_transport;

	private readonly ByteQueue m_recordQueue = new ByteQueue();

	private readonly object m_writeLock = new object();

	private volatile bool m_closed;

	private volatile bool m_failed;

	private volatile ProtocolVersion m_readVersion;

	private volatile ProtocolVersion m_writeVersion;

	private volatile bool m_inConnection;

	private volatile bool m_inHandshake;

	private volatile int m_plaintextLimit;

	private DtlsEpoch m_currentEpoch;

	private DtlsEpoch m_pendingEpoch;

	private DtlsEpoch m_readEpoch;

	private DtlsEpoch m_writeEpoch;

	private DtlsHandshakeRetransmit m_retransmit;

	private DtlsEpoch m_retransmitEpoch;

	private Timeout m_retransmitTimeout;

	private TlsHeartbeat m_heartbeat;

	private bool m_heartBeatResponder;

	private HeartbeatMessage m_heartbeatInFlight;

	private Timeout m_heartbeatTimeout;

	private int m_heartbeatResendMillis = -1;

	private Timeout m_heartbeatResendTimeout;

	internal virtual bool IsClosed => m_closed;

	internal virtual int ReadEpoch => m_readEpoch.Epoch;

	internal virtual ProtocolVersion ReadVersion
	{
		get
		{
			return m_readVersion;
		}
		set
		{
			m_readVersion = value;
		}
	}

	internal static byte[] ReceiveClientHelloRecord(byte[] data, int dataOff, int dataLen)
	{
		if (dataLen < 13)
		{
			return null;
		}
		short num = TlsUtilities.ReadUint8(data, dataOff);
		if (22 != num)
		{
			return null;
		}
		ProtocolVersion version = TlsUtilities.ReadVersion(data, dataOff + 1);
		if (!ProtocolVersion.DTLSv10.IsEqualOrEarlierVersionOf(version))
		{
			return null;
		}
		if (TlsUtilities.ReadUint16(data, dataOff + 3) != 0)
		{
			return null;
		}
		int num2 = TlsUtilities.ReadUint16(data, dataOff + 11);
		if (dataLen < 13 + num2)
		{
			return null;
		}
		if (num2 > 16384)
		{
			return null;
		}
		return TlsUtilities.CopyOfRangeExact(data, dataOff + 13, dataOff + 13 + num2);
	}

	internal static void SendHelloVerifyRequestRecord(DatagramSender sender, long recordSeq, byte[] message)
	{
		TlsUtilities.CheckUint16(message.Length);
		byte[] array = new byte[13 + message.Length];
		TlsUtilities.WriteUint8((short)22, array, 0);
		TlsUtilities.WriteVersion(ProtocolVersion.DTLSv10, array, 1);
		TlsUtilities.WriteUint16(0, array, 3);
		TlsUtilities.WriteUint48(recordSeq, array, 5);
		TlsUtilities.WriteUint16(message.Length, array, 11);
		Array.Copy(message, 0, array, 13, message.Length);
		SendDatagram(sender, array, 0, array.Length);
	}

	private static void SendDatagram(DatagramSender sender, byte[] buf, int off, int len)
	{
		sender.Send(buf, off, len);
	}

	internal DtlsRecordLayer(TlsContext context, TlsPeer peer, DatagramTransport transport)
	{
		m_context = context;
		m_peer = peer;
		m_transport = transport;
		m_inHandshake = true;
		m_currentEpoch = new DtlsEpoch(0, TlsNullNullCipher.Instance);
		m_pendingEpoch = null;
		m_readEpoch = m_currentEpoch;
		m_writeEpoch = m_currentEpoch;
		SetPlaintextLimit(16384);
	}

	internal virtual void ResetAfterHelloVerifyRequestServer(long recordSeq)
	{
		m_inConnection = true;
		m_currentEpoch.SequenceNumber = recordSeq;
		m_currentEpoch.ReplayWindow.Reset(recordSeq);
	}

	internal virtual void SetPlaintextLimit(int plaintextLimit)
	{
		m_plaintextLimit = plaintextLimit;
	}

	internal virtual void SetWriteVersion(ProtocolVersion writeVersion)
	{
		m_writeVersion = writeVersion;
	}

	internal virtual void InitPendingEpoch(TlsCipher pendingCipher)
	{
		if (m_pendingEpoch != null)
		{
			throw new InvalidOperationException();
		}
		m_pendingEpoch = new DtlsEpoch(m_writeEpoch.Epoch + 1, pendingCipher);
	}

	internal virtual void HandshakeSuccessful(DtlsHandshakeRetransmit retransmit)
	{
		if (m_readEpoch != m_currentEpoch && m_writeEpoch != m_currentEpoch)
		{
			if (retransmit != null)
			{
				m_retransmit = retransmit;
				m_retransmitEpoch = m_currentEpoch;
				m_retransmitTimeout = new Timeout(240000L);
			}
			m_inHandshake = false;
			m_currentEpoch = m_pendingEpoch;
			m_pendingEpoch = null;
			return;
		}
		throw new InvalidOperationException();
	}

	internal virtual void InitHeartbeat(TlsHeartbeat heartbeat, bool heartbeatResponder)
	{
		if (m_inHandshake)
		{
			throw new InvalidOperationException();
		}
		m_heartbeat = heartbeat;
		m_heartBeatResponder = heartbeatResponder;
		if (heartbeat != null)
		{
			ResetHeartbeat();
		}
	}

	internal virtual void ResetWriteEpoch()
	{
		if (m_retransmitEpoch != null)
		{
			m_writeEpoch = m_retransmitEpoch;
		}
		else
		{
			m_writeEpoch = m_currentEpoch;
		}
	}

	public virtual int GetReceiveLimit()
	{
		return System.Math.Min(m_plaintextLimit, m_readEpoch.Cipher.GetPlaintextLimit(m_transport.GetReceiveLimit() - 13));
	}

	public virtual int GetSendLimit()
	{
		return System.Math.Min(m_plaintextLimit, m_writeEpoch.Cipher.GetPlaintextLimit(m_transport.GetSendLimit() - 13));
	}

	public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
	{
		long currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
		Timeout timeout = Timeout.ForWaitMillis(waitMillis, currentTimeMillis);
		byte[] array = null;
		int num2;
		while (true)
		{
			if (waitMillis >= 0)
			{
				if (m_retransmitTimeout != null && m_retransmitTimeout.RemainingMillis(currentTimeMillis) < 1L)
				{
					m_retransmit = null;
					m_retransmitEpoch = null;
					m_retransmitTimeout = null;
				}
				if (Timeout.HasExpired(m_heartbeatTimeout, currentTimeMillis))
				{
					if (m_heartbeatInFlight != null)
					{
						throw new TlsTimeoutException("Heartbeat timed out");
					}
					m_heartbeatInFlight = HeartbeatMessage.Create(m_context, 1, m_heartbeat.GeneratePayload());
					m_heartbeatTimeout = new Timeout(m_heartbeat.TimeoutMillis, currentTimeMillis);
					m_heartbeatResendMillis = 1000;
					m_heartbeatResendTimeout = new Timeout(m_heartbeatResendMillis, currentTimeMillis);
					SendHeartbeatMessage(m_heartbeatInFlight);
				}
				else if (Timeout.HasExpired(m_heartbeatResendTimeout, currentTimeMillis))
				{
					m_heartbeatResendMillis = DtlsReliableHandshake.BackOff(m_heartbeatResendMillis);
					m_heartbeatResendTimeout = new Timeout(m_heartbeatResendMillis, currentTimeMillis);
					SendHeartbeatMessage(m_heartbeatInFlight);
				}
				waitMillis = Timeout.ConstrainWaitMillis(waitMillis, m_heartbeatTimeout, currentTimeMillis);
				waitMillis = Timeout.ConstrainWaitMillis(waitMillis, m_heartbeatResendTimeout, currentTimeMillis);
				if (waitMillis < 0)
				{
					waitMillis = 1;
				}
				int num = System.Math.Min(len, GetReceiveLimit()) + 13;
				if (array == null || array.Length < num)
				{
					array = new byte[num];
				}
				int received = ReceiveRecord(array, 0, num, waitMillis);
				num2 = ProcessRecord(received, array, buf, off);
				if (num2 >= 0)
				{
					break;
				}
				currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
				waitMillis = Timeout.GetWaitMillis(timeout, currentTimeMillis);
				continue;
			}
			return -1;
		}
		return num2;
	}

	public virtual void Send(byte[] buf, int off, int len)
	{
		short contentType = 23;
		if (m_inHandshake || m_writeEpoch == m_retransmitEpoch)
		{
			contentType = 22;
			if (TlsUtilities.ReadUint8(buf, off) == 20)
			{
				DtlsEpoch dtlsEpoch = null;
				if (m_inHandshake)
				{
					dtlsEpoch = m_pendingEpoch;
				}
				else if (m_writeEpoch == m_retransmitEpoch)
				{
					dtlsEpoch = m_currentEpoch;
				}
				if (dtlsEpoch == null)
				{
					throw new InvalidOperationException();
				}
				byte[] array = new byte[1] { 1 };
				SendRecord(20, array, 0, array.Length);
				m_writeEpoch = dtlsEpoch;
			}
		}
		SendRecord(contentType, buf, off, len);
	}

	public virtual void Close()
	{
		if (!m_closed)
		{
			if (m_inHandshake && m_inConnection)
			{
				Warn(90, "User canceled handshake");
			}
			CloseTransport();
		}
	}

	internal virtual void Fail(short alertDescription)
	{
		if (m_closed)
		{
			return;
		}
		if (m_inConnection)
		{
			try
			{
				RaiseAlert(2, alertDescription, null, null);
			}
			catch (Exception)
			{
			}
		}
		m_failed = true;
		CloseTransport();
	}

	internal virtual void Failed()
	{
		if (!m_closed)
		{
			m_failed = true;
			CloseTransport();
		}
	}

	internal virtual void Warn(short alertDescription, string message)
	{
		RaiseAlert(1, alertDescription, message, null);
	}

	private void CloseTransport()
	{
		if (m_closed)
		{
			return;
		}
		try
		{
			if (!m_failed)
			{
				Warn(0, null);
			}
			m_transport.Close();
		}
		catch (Exception)
		{
		}
		m_closed = true;
	}

	private void RaiseAlert(short alertLevel, short alertDescription, string message, Exception cause)
	{
		m_peer.NotifyAlertRaised(alertLevel, alertDescription, message, cause);
		SendRecord(21, new byte[2]
		{
			(byte)alertLevel,
			(byte)alertDescription
		}, 0, 2);
	}

	private int ReceiveDatagram(byte[] buf, int off, int len, int waitMillis)
	{
		try
		{
			return m_transport.Receive(buf, off, len, waitMillis);
		}
		catch (TlsTimeoutException)
		{
			return -1;
		}
		catch (SocketException ex2)
		{
			if (!TlsUtilities.IsTimeout(ex2))
			{
				throw ex2;
			}
			return -1;
		}
	}

	private int ProcessRecord(int received, byte[] record, byte[] buf, int off)
	{
		if (received < 13)
		{
			return -1;
		}
		int num = TlsUtilities.ReadUint16(record, 11);
		if (received != num + 13)
		{
			return -1;
		}
		short num2 = TlsUtilities.ReadUint8(record, 0);
		if ((uint)(num2 - 20) > 4u)
		{
			return -1;
		}
		int num3 = TlsUtilities.ReadUint16(record, 3);
		DtlsEpoch dtlsEpoch = null;
		if (num3 == m_readEpoch.Epoch)
		{
			dtlsEpoch = m_readEpoch;
		}
		else if (num2 == 22 && m_retransmitEpoch != null && num3 == m_retransmitEpoch.Epoch)
		{
			dtlsEpoch = m_retransmitEpoch;
		}
		if (dtlsEpoch == null)
		{
			return -1;
		}
		long num4 = TlsUtilities.ReadUint48(record, 5);
		if (dtlsEpoch.ReplayWindow.ShouldDiscard(num4))
		{
			return -1;
		}
		ProtocolVersion protocolVersion = TlsUtilities.ReadVersion(record, 1);
		if (!protocolVersion.IsDtls)
		{
			return -1;
		}
		if (m_readVersion != null && !m_readVersion.Equals(protocolVersion) && (ReadEpoch != 0 || num <= 0 || 22 != num2 || 1 != TlsUtilities.ReadUint8(record, 13)))
		{
			return -1;
		}
		long macSequenceNumber = GetMacSequenceNumber(dtlsEpoch.Epoch, num4);
		TlsDecodeResult tlsDecodeResult = dtlsEpoch.Cipher.DecodeCiphertext(macSequenceNumber, num2, protocolVersion, record, 13, num);
		dtlsEpoch.ReplayWindow.ReportAuthenticated(num4);
		if (tlsDecodeResult.len > m_plaintextLimit)
		{
			return -1;
		}
		if (tlsDecodeResult.len < 1 && tlsDecodeResult.contentType != 23)
		{
			return -1;
		}
		if (m_readVersion == null)
		{
			if (ReadEpoch == 0 && num > 0 && 22 == num2 && 3 == TlsUtilities.ReadUint8(record, 13))
			{
				if (!ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(protocolVersion))
				{
					return -1;
				}
			}
			else
			{
				m_readVersion = protocolVersion;
			}
		}
		switch (tlsDecodeResult.contentType)
		{
		default:
			return -1;
		case 20:
		{
			for (int i = 0; i < tlsDecodeResult.len; i++)
			{
				if (TlsUtilities.ReadUint8(tlsDecodeResult.buf, tlsDecodeResult.off + i) == 1 && m_pendingEpoch != null)
				{
					m_readEpoch = m_pendingEpoch;
				}
			}
			return -1;
		}
		case 21:
			if (tlsDecodeResult.len == 2)
			{
				short num5 = TlsUtilities.ReadUint8(tlsDecodeResult.buf, tlsDecodeResult.off);
				short num6 = TlsUtilities.ReadUint8(tlsDecodeResult.buf, tlsDecodeResult.off + 1);
				m_peer.NotifyAlertReceived(num5, num6);
				if (num5 == 2)
				{
					Failed();
					throw new TlsFatalAlert(num6);
				}
				if (num6 == 0)
				{
					CloseTransport();
				}
			}
			return -1;
		case 22:
			if (!m_inHandshake)
			{
				if (m_retransmit != null)
				{
					m_retransmit.ReceivedHandshakeRecord(num3, tlsDecodeResult.buf, tlsDecodeResult.off, tlsDecodeResult.len);
				}
				return -1;
			}
			goto IL_0292;
		case 23:
			if (m_inHandshake)
			{
				return -1;
			}
			goto IL_0292;
		case 24:
			{
				if (m_heartbeatInFlight != null || m_heartBeatResponder)
				{
					try
					{
						HeartbeatMessage heartbeatMessage = HeartbeatMessage.Parse(new MemoryStream(tlsDecodeResult.buf, tlsDecodeResult.off, tlsDecodeResult.len, writable: false));
						if (heartbeatMessage != null)
						{
							switch (heartbeatMessage.Type)
							{
							case 2:
								if (m_heartbeatInFlight != null && Arrays.AreEqual(heartbeatMessage.Payload, m_heartbeatInFlight.Payload))
								{
									ResetHeartbeat();
								}
								break;
							case 1:
								if (m_heartBeatResponder)
								{
									HeartbeatMessage heartbeatMessage2 = HeartbeatMessage.Create(m_context, 2, heartbeatMessage.Payload);
									SendHeartbeatMessage(heartbeatMessage2);
								}
								break;
							}
						}
					}
					catch (Exception)
					{
					}
				}
				return -1;
			}
			IL_0292:
			if (!m_inHandshake && m_retransmit != null)
			{
				m_retransmit = null;
				m_retransmitEpoch = null;
				m_retransmitTimeout = null;
			}
			Array.Copy(tlsDecodeResult.buf, tlsDecodeResult.off, buf, off, tlsDecodeResult.len);
			return tlsDecodeResult.len;
		}
	}

	private int ReceiveRecord(byte[] buf, int off, int len, int waitMillis)
	{
		if (m_recordQueue.Available > 0)
		{
			int num = 0;
			if (m_recordQueue.Available >= 13)
			{
				byte[] buf2 = new byte[2];
				m_recordQueue.Read(buf2, 0, 2, 11);
				num = TlsUtilities.ReadUint16(buf2, 0);
			}
			int num2 = System.Math.Min(m_recordQueue.Available, 13 + num);
			m_recordQueue.RemoveData(buf, off, num2, 0);
			return num2;
		}
		int num3 = ReceiveDatagram(buf, off, len, waitMillis);
		if (num3 >= 13)
		{
			m_inConnection = true;
			int num4 = TlsUtilities.ReadUint16(buf, off + 11);
			int num5 = 13 + num4;
			if (num3 > num5)
			{
				m_recordQueue.AddData(buf, off + num5, num3 - num5);
				num3 = num5;
			}
		}
		return num3;
	}

	private void ResetHeartbeat()
	{
		m_heartbeatInFlight = null;
		m_heartbeatResendMillis = -1;
		m_heartbeatResendTimeout = null;
		m_heartbeatTimeout = new Timeout(m_heartbeat.IdleMillis);
	}

	private void SendHeartbeatMessage(HeartbeatMessage heartbeatMessage)
	{
		MemoryStream memoryStream = new MemoryStream();
		heartbeatMessage.Encode(memoryStream);
		byte[] array = memoryStream.ToArray();
		SendRecord(24, array, 0, array.Length);
	}

	private void SendRecord(short contentType, byte[] buf, int off, int len)
	{
		if (m_writeVersion == null)
		{
			return;
		}
		if (len > m_plaintextLimit)
		{
			throw new TlsFatalAlert(80);
		}
		if (len < 1 && contentType != 23)
		{
			throw new TlsFatalAlert(80);
		}
		lock (m_writeLock)
		{
			int epoch = m_writeEpoch.Epoch;
			long num = m_writeEpoch.AllocateSequenceNumber();
			long macSequenceNumber = GetMacSequenceNumber(epoch, num);
			ProtocolVersion writeVersion = m_writeVersion;
			TlsEncodeResult tlsEncodeResult = m_writeEpoch.Cipher.EncodePlaintext(macSequenceNumber, contentType, writeVersion, 13, buf, off, len);
			int i = tlsEncodeResult.len - 13;
			TlsUtilities.CheckUint16(i);
			TlsUtilities.WriteUint8(tlsEncodeResult.recordType, tlsEncodeResult.buf, tlsEncodeResult.off);
			TlsUtilities.WriteVersion(writeVersion, tlsEncodeResult.buf, tlsEncodeResult.off + 1);
			TlsUtilities.WriteUint16(epoch, tlsEncodeResult.buf, tlsEncodeResult.off + 3);
			TlsUtilities.WriteUint48(num, tlsEncodeResult.buf, tlsEncodeResult.off + 5);
			TlsUtilities.WriteUint16(i, tlsEncodeResult.buf, tlsEncodeResult.off + 11);
			SendDatagram(m_transport, tlsEncodeResult.buf, tlsEncodeResult.off, tlsEncodeResult.len);
		}
	}

	private static long GetMacSequenceNumber(int epoch, long sequence_number)
	{
		return ((epoch & 0xFFFFFFFFL) << 48) | sequence_number;
	}
}
