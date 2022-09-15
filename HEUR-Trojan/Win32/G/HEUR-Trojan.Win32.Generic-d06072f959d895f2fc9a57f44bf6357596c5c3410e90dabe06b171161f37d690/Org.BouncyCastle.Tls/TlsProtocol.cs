using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class TlsProtocol : TlsCloseable
{
	protected const short CS_START = 0;

	protected const short CS_CLIENT_HELLO = 1;

	protected const short CS_SERVER_HELLO_RETRY_REQUEST = 2;

	protected const short CS_CLIENT_HELLO_RETRY = 3;

	protected const short CS_SERVER_HELLO = 4;

	protected const short CS_SERVER_ENCRYPTED_EXTENSIONS = 5;

	protected const short CS_SERVER_SUPPLEMENTAL_DATA = 6;

	protected const short CS_SERVER_CERTIFICATE = 7;

	protected const short CS_SERVER_CERTIFICATE_STATUS = 8;

	protected const short CS_SERVER_CERTIFICATE_VERIFY = 9;

	protected const short CS_SERVER_KEY_EXCHANGE = 10;

	protected const short CS_SERVER_CERTIFICATE_REQUEST = 11;

	protected const short CS_SERVER_HELLO_DONE = 12;

	protected const short CS_CLIENT_END_OF_EARLY_DATA = 13;

	protected const short CS_CLIENT_SUPPLEMENTAL_DATA = 14;

	protected const short CS_CLIENT_CERTIFICATE = 15;

	protected const short CS_CLIENT_KEY_EXCHANGE = 16;

	protected const short CS_CLIENT_CERTIFICATE_VERIFY = 17;

	protected const short CS_CLIENT_FINISHED = 18;

	protected const short CS_SERVER_SESSION_TICKET = 19;

	protected const short CS_SERVER_FINISHED = 20;

	protected const short CS_END = 21;

	protected const short ADS_MODE_1_Nsub1 = 0;

	protected const short ADS_MODE_0_N = 1;

	protected const short ADS_MODE_0_N_FIRSTONLY = 2;

	private readonly ByteQueue m_applicationDataQueue = new ByteQueue(0);

	private readonly ByteQueue m_alertQueue = new ByteQueue(2);

	private readonly ByteQueue m_handshakeQueue = new ByteQueue(0);

	internal readonly RecordStream m_recordStream;

	internal readonly object m_recordWriteLock = new object();

	private int m_maxHandshakeMessageSize = -1;

	internal TlsHandshakeHash m_handshakeHash;

	private TlsStream m_tlsStream;

	private volatile bool m_closed;

	private volatile bool m_failedWithError;

	private volatile bool m_appDataReady;

	private volatile bool m_appDataSplitEnabled = true;

	private volatile bool m_keyUpdateEnabled;

	private volatile bool m_keyUpdatePendingSend;

	private volatile bool m_resumableHandshake;

	private volatile int m_appDataSplitMode;

	protected TlsSession m_tlsSession;

	protected SessionParameters m_sessionParameters;

	protected TlsSecret m_sessionMasterSecret;

	protected byte[] m_retryCookie;

	protected int m_retryGroup = -1;

	protected IDictionary m_clientExtensions;

	protected IDictionary m_serverExtensions;

	protected short m_connectionState;

	protected bool m_resumedSession;

	protected bool m_selectedPsk13;

	protected bool m_receivedChangeCipherSpec;

	protected bool m_expectSessionTicket;

	protected readonly bool m_blocking;

	protected readonly ByteQueueInputStream m_inputBuffers;

	protected readonly ByteQueueOutputStream m_outputBuffer;

	protected abstract TlsContext Context { get; }

	internal abstract AbstractTlsContext ContextAdmin { get; }

	protected abstract TlsPeer Peer { get; }

	public virtual int ApplicationDataAvailable => m_applicationDataQueue.Available;

	public virtual int AppDataSplitMode
	{
		get
		{
			return m_appDataSplitMode;
		}
		set
		{
			if (value < 0 || value > 2)
			{
				throw new InvalidOperationException("Illegal appDataSplitMode mode: " + value);
			}
			m_appDataSplitMode = value;
		}
	}

	public virtual bool IsResumableHandshake
	{
		get
		{
			return m_resumableHandshake;
		}
		set
		{
			m_resumableHandshake = value;
		}
	}

	public virtual Stream Stream
	{
		get
		{
			if (!m_blocking)
			{
				throw new InvalidOperationException("Cannot use Stream in non-blocking mode! Use OfferInput()/OfferOutput() instead.");
			}
			return m_tlsStream;
		}
	}

	public virtual int ApplicationDataLimit => m_recordStream.PlaintextLimit;

	internal bool IsApplicationDataReady => m_appDataReady;

	public virtual bool IsClosed => m_closed;

	public virtual bool IsConnected
	{
		get
		{
			if (m_closed)
			{
				return false;
			}
			return ContextAdmin?.IsConnected ?? false;
		}
	}

	public virtual bool IsHandshaking
	{
		get
		{
			if (m_closed)
			{
				return false;
			}
			return ContextAdmin?.IsHandshaking ?? false;
		}
	}

	protected bool IsLegacyConnectionState()
	{
		switch (m_connectionState)
		{
		default:
			return false;
		case 0:
		case 1:
		case 4:
		case 6:
		case 7:
		case 8:
		case 10:
		case 11:
		case 12:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
			return true;
		}
	}

	protected bool IsTlsV13ConnectionState()
	{
		switch (m_connectionState)
		{
		default:
			return false;
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 7:
		case 9:
		case 11:
		case 13:
		case 15:
		case 17:
		case 18:
		case 20:
		case 21:
			return true;
		}
	}

	protected TlsProtocol()
	{
		m_blocking = false;
		m_inputBuffers = new ByteQueueInputStream();
		m_outputBuffer = new ByteQueueOutputStream();
		m_recordStream = new RecordStream(this, m_inputBuffers, m_outputBuffer);
	}

	public TlsProtocol(Stream stream)
		: this(stream, stream)
	{
	}

	public TlsProtocol(Stream input, Stream output)
	{
		m_blocking = true;
		m_inputBuffers = null;
		m_outputBuffer = null;
		m_recordStream = new RecordStream(this, input, output);
	}

	public virtual void ResumeHandshake()
	{
		if (!m_blocking)
		{
			throw new InvalidOperationException("Cannot use ResumeHandshake() in non-blocking mode!");
		}
		if (!IsHandshaking)
		{
			throw new InvalidOperationException("No handshake in progress");
		}
		BlockForHandshake();
	}

	protected virtual void CloseConnection()
	{
		m_recordStream.Close();
	}

	protected virtual void HandleAlertMessage(short alertLevel, short alertDescription)
	{
		Peer.NotifyAlertReceived(alertLevel, alertDescription);
		if (alertLevel != 1)
		{
			HandleFailure();
			throw new TlsFatalAlertReceived(alertDescription);
		}
		HandleAlertWarningMessage(alertDescription);
	}

	protected virtual void HandleAlertWarningMessage(short alertDescription)
	{
		switch (alertDescription)
		{
		case 100:
			throw new TlsFatalAlert(40);
		case 41:
			throw new TlsFatalAlert(10);
		case 0:
			if (!m_appDataReady)
			{
				throw new TlsFatalAlert(40);
			}
			HandleClose(user_canceled: false);
			break;
		}
	}

	protected virtual void HandleChangeCipherSpecMessage()
	{
	}

	protected virtual void HandleClose(bool user_canceled)
	{
		if (m_closed)
		{
			return;
		}
		m_closed = true;
		if (!m_appDataReady)
		{
			CleanupHandshake();
			if (user_canceled)
			{
				RaiseAlertWarning(90, "User canceled handshake");
			}
		}
		RaiseAlertWarning(0, "Connection closed");
		CloseConnection();
	}

	protected virtual void HandleException(short alertDescription, string message, Exception e)
	{
		if (!m_closed)
		{
			RaiseAlertFatal(alertDescription, message, e);
			HandleFailure();
		}
	}

	protected virtual void HandleFailure()
	{
		m_closed = true;
		m_failedWithError = true;
		InvalidateSession();
		if (!m_appDataReady)
		{
			CleanupHandshake();
		}
		CloseConnection();
	}

	protected abstract void HandleHandshakeMessage(short type, HandshakeMessageInput buf);

	protected virtual void ApplyMaxFragmentLengthExtension(short maxFragmentLength)
	{
		if (maxFragmentLength >= 0)
		{
			if (!MaxFragmentLength.IsValid(maxFragmentLength))
			{
				throw new TlsFatalAlert(80);
			}
			int plaintextLimit = 1 << 8 + maxFragmentLength;
			m_recordStream.SetPlaintextLimit(plaintextLimit);
		}
	}

	protected virtual void CheckReceivedChangeCipherSpec(bool expected)
	{
		if (expected != m_receivedChangeCipherSpec)
		{
			throw new TlsFatalAlert(10);
		}
	}

	protected virtual void BlockForHandshake()
	{
		while (true)
		{
			if (m_connectionState != 21)
			{
				if (IsClosed)
				{
					break;
				}
				SafeReadRecord();
				continue;
			}
			return;
		}
		throw new TlsFatalAlert(80);
	}

	protected virtual void BeginHandshake()
	{
		AbstractTlsContext contextAdmin = ContextAdmin;
		TlsPeer peer = Peer;
		m_maxHandshakeMessageSize = System.Math.Max(1024, peer.GetMaxHandshakeMessageSize());
		m_handshakeHash = new DeferredHash(contextAdmin);
		m_connectionState = 0;
		m_resumedSession = false;
		m_selectedPsk13 = false;
		contextAdmin.HandshakeBeginning(peer);
		contextAdmin.SecurityParameters.m_extendedPadding = peer.ShouldUseExtendedPadding();
	}

	protected virtual void CleanupHandshake()
	{
		Context?.SecurityParameters?.Clear();
		m_tlsSession = null;
		m_sessionParameters = null;
		m_sessionMasterSecret = null;
		m_retryCookie = null;
		m_retryGroup = -1;
		m_clientExtensions = null;
		m_serverExtensions = null;
		m_resumedSession = false;
		m_selectedPsk13 = false;
		m_receivedChangeCipherSpec = false;
		m_expectSessionTicket = false;
	}

	protected virtual void CompleteHandshake()
	{
		try
		{
			AbstractTlsContext contextAdmin = ContextAdmin;
			SecurityParameters securityParameters = contextAdmin.SecurityParameters;
			if (contextAdmin.IsHandshaking && securityParameters.LocalVerifyData != null && securityParameters.PeerVerifyData != null)
			{
				m_recordStream.FinaliseHandshake();
				m_connectionState = 21;
				m_handshakeHash = new DeferredHash(contextAdmin);
				m_alertQueue.Shrink();
				m_handshakeQueue.Shrink();
				ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
				m_appDataSplitEnabled = !TlsUtilities.IsTlsV11(negotiatedVersion);
				m_appDataReady = true;
				m_keyUpdateEnabled = TlsUtilities.IsTlsV13(negotiatedVersion);
				if (m_blocking)
				{
					m_tlsStream = new TlsStream(this);
				}
				if (m_sessionParameters == null)
				{
					m_sessionMasterSecret = securityParameters.MasterSecret;
					m_sessionParameters = new SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate)
						.SetMasterSecret(contextAdmin.Crypto.AdoptSecret(m_sessionMasterSecret))
						.SetNegotiatedVersion(securityParameters.NegotiatedVersion)
						.SetPeerCertificate(securityParameters.PeerCertificate)
						.SetPskIdentity(securityParameters.PskIdentity)
						.SetSrpIdentity(securityParameters.SrpIdentity)
						.SetServerExtensions(m_serverExtensions)
						.Build();
					m_tlsSession = TlsUtilities.ImportSession(m_tlsSession.SessionID, m_sessionParameters);
				}
				else
				{
					securityParameters.m_localCertificate = m_sessionParameters.LocalCertificate;
					securityParameters.m_peerCertificate = m_sessionParameters.PeerCertificate;
					securityParameters.m_pskIdentity = m_sessionParameters.PskIdentity;
					securityParameters.m_srpIdentity = m_sessionParameters.SrpIdentity;
				}
				contextAdmin.HandshakeComplete(Peer, m_tlsSession);
				return;
			}
			throw new TlsFatalAlert(80);
		}
		finally
		{
			CleanupHandshake();
		}
	}

	internal void ProcessRecord(short protocol, byte[] buf, int off, int len)
	{
		switch (protocol)
		{
		default:
			throw new TlsFatalAlert(10);
		case 20:
			ProcessChangeCipherSpec(buf, off, len);
			break;
		case 21:
			m_alertQueue.AddData(buf, off, len);
			ProcessAlertQueue();
			break;
		case 22:
		{
			if (m_handshakeQueue.Available > 0)
			{
				m_handshakeQueue.AddData(buf, off, len);
				ProcessHandshakeQueue(m_handshakeQueue);
				break;
			}
			ByteQueue byteQueue = new ByteQueue(buf, off, len);
			ProcessHandshakeQueue(byteQueue);
			int available = byteQueue.Available;
			if (available > 0)
			{
				m_handshakeQueue.AddData(buf, off + len - available, available);
			}
			break;
		}
		case 23:
			if (!m_appDataReady)
			{
				throw new TlsFatalAlert(10);
			}
			m_applicationDataQueue.AddData(buf, off, len);
			ProcessApplicationDataQueue();
			break;
		}
	}

	private void ProcessHandshakeQueue(ByteQueue queue)
	{
		while (queue.Available >= 4)
		{
			int num = queue.ReadInt32();
			short num2 = (short)((uint)num >> 24);
			if (HandshakeType.IsRecognized(num2))
			{
				int num3 = num & 0xFFFFFF;
				if (num3 <= m_maxHandshakeMessageSize)
				{
					int num4 = 4 + num3;
					if (queue.Available < num4)
					{
						break;
					}
					if (num2 != 0)
					{
						ProtocolVersion serverVersion = Context.ServerVersion;
						if (serverVersion == null || !TlsUtilities.IsTlsV13(serverVersion))
						{
							CheckReceivedChangeCipherSpec(20 == num2);
						}
					}
					HandshakeMessageInput handshakeMessageInput = queue.ReadHandshakeMessage(num4);
					switch (num2)
					{
					default:
						handshakeMessageInput.UpdateHash(m_handshakeHash);
						break;
					case 0:
					case 1:
					case 2:
					case 4:
					case 15:
					case 20:
					case 24:
						break;
					}
					handshakeMessageInput.Seek(4L, SeekOrigin.Current);
					HandleHandshakeMessage(num2, handshakeMessageInput);
					continue;
				}
				throw new TlsFatalAlert(80, "Handshake message length exceeds the maximum: " + HandshakeType.GetText(num2) + ", " + num3 + " > " + m_maxHandshakeMessageSize);
			}
			throw new TlsFatalAlert(10, "Handshake message of unrecognized type: " + num2);
		}
	}

	private void ProcessApplicationDataQueue()
	{
	}

	private void ProcessAlertQueue()
	{
		while (m_alertQueue.Available >= 2)
		{
			byte[] array = m_alertQueue.RemoveData(2, 0);
			short alertLevel = array[0];
			short alertDescription = array[1];
			HandleAlertMessage(alertLevel, alertDescription);
		}
	}

	private void ProcessChangeCipherSpec(byte[] buf, int off, int len)
	{
		ProtocolVersion serverVersion = Context.ServerVersion;
		if (serverVersion != null && !TlsUtilities.IsTlsV13(serverVersion))
		{
			int num = 0;
			while (true)
			{
				if (num < len)
				{
					if (TlsUtilities.ReadUint8(buf, off + num) == 1)
					{
						if (m_receivedChangeCipherSpec || m_alertQueue.Available > 0 || m_handshakeQueue.Available > 0)
						{
							break;
						}
						m_recordStream.NotifyChangeCipherSpecReceived();
						m_receivedChangeCipherSpec = true;
						HandleChangeCipherSpecMessage();
						num++;
						continue;
					}
					throw new TlsFatalAlert(50);
				}
				return;
			}
			throw new TlsFatalAlert(10);
		}
		throw new TlsFatalAlert(10);
	}

	public virtual int ReadApplicationData(byte[] buf, int off, int len)
	{
		if (len < 1)
		{
			return 0;
		}
		while (true)
		{
			if (m_applicationDataQueue.Available == 0)
			{
				if (!m_closed)
				{
					if (!m_appDataReady)
					{
						break;
					}
					SafeReadRecord();
					continue;
				}
				if (m_failedWithError)
				{
					throw new IOException("Cannot read application data on failed TLS connection");
				}
				return -1;
			}
			len = System.Math.Min(len, m_applicationDataQueue.Available);
			m_applicationDataQueue.RemoveData(buf, off, len, 0);
			return len;
		}
		throw new InvalidOperationException("Cannot read application data until initial handshake completed.");
	}

	protected virtual RecordPreview SafePreviewRecordHeader(byte[] recordHeader)
	{
		try
		{
			return m_recordStream.PreviewRecordHeader(recordHeader);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			HandleException(tlsFatalAlert.AlertDescription, "Failed to read record", tlsFatalAlert);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			HandleException(80, "Failed to read record", ex);
			throw ex;
		}
		catch (Exception ex2)
		{
			HandleException(80, "Failed to read record", ex2);
			throw new TlsFatalAlert(80, ex2);
		}
	}

	protected virtual void SafeReadRecord()
	{
		try
		{
			if (m_recordStream.ReadRecord())
			{
				return;
			}
			if (!m_appDataReady)
			{
				throw new TlsFatalAlert(40);
			}
			if (!Peer.RequiresCloseNotify())
			{
				HandleClose(user_canceled: false);
				return;
			}
		}
		catch (TlsFatalAlertReceived tlsFatalAlertReceived)
		{
			throw tlsFatalAlertReceived;
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			HandleException(tlsFatalAlert.AlertDescription, "Failed to read record", tlsFatalAlert);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			HandleException(80, "Failed to read record", ex);
			throw ex;
		}
		catch (Exception ex2)
		{
			HandleException(80, "Failed to read record", ex2);
			throw new TlsFatalAlert(80, ex2);
		}
		HandleFailure();
		throw new TlsNoCloseNotifyException();
	}

	protected virtual bool SafeReadFullRecord(byte[] input, int inputOff, int inputLen)
	{
		try
		{
			return m_recordStream.ReadFullRecord(input, inputOff, inputLen);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			HandleException(tlsFatalAlert.AlertDescription, "Failed to process record", tlsFatalAlert);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			HandleException(80, "Failed to process record", ex);
			throw ex;
		}
		catch (Exception ex2)
		{
			HandleException(80, "Failed to process record", ex2);
			throw new TlsFatalAlert(80, ex2);
		}
	}

	protected virtual void SafeWriteRecord(short type, byte[] buf, int offset, int len)
	{
		try
		{
			m_recordStream.WriteRecord(type, buf, offset, len);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			HandleException(tlsFatalAlert.AlertDescription, "Failed to write record", tlsFatalAlert);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			HandleException(80, "Failed to write record", ex);
			throw ex;
		}
		catch (Exception ex2)
		{
			HandleException(80, "Failed to write record", ex2);
			throw new TlsFatalAlert(80, ex2);
		}
	}

	public virtual void WriteApplicationData(byte[] buf, int off, int len)
	{
		if (!m_appDataReady)
		{
			throw new InvalidOperationException("Cannot write application data until initial handshake completed.");
		}
		lock (m_recordWriteLock)
		{
			while (true)
			{
				if (len <= 0)
				{
					return;
				}
				if (m_closed)
				{
					break;
				}
				if (m_appDataSplitEnabled)
				{
					switch (m_appDataSplitMode)
					{
					default:
						if (len > 1)
						{
							SafeWriteRecord(23, buf, off, 1);
							off++;
							len--;
						}
						break;
					case 1:
						SafeWriteRecord(23, TlsUtilities.EmptyBytes, 0, 0);
						break;
					case 2:
						m_appDataSplitEnabled = false;
						SafeWriteRecord(23, TlsUtilities.EmptyBytes, 0, 0);
						break;
					}
				}
				else if (m_keyUpdateEnabled)
				{
					if (m_keyUpdatePendingSend)
					{
						Send13KeyUpdate(updateRequested: false);
					}
					else if (m_recordStream.NeedsKeyUpdate())
					{
						Send13KeyUpdate(updateRequested: true);
					}
				}
				int num = System.Math.Min(len, m_recordStream.PlaintextLimit);
				SafeWriteRecord(23, buf, off, num);
				off += num;
				len -= num;
			}
			throw new IOException("Cannot write application data on closed/failed TLS connection");
		}
	}

	internal void WriteHandshakeMessage(byte[] buf, int off, int len)
	{
		if (len < 4)
		{
			throw new TlsFatalAlert(80);
		}
		switch (TlsUtilities.ReadUint8(buf, off))
		{
		default:
			m_handshakeHash.Update(buf, off, len);
			break;
		case 0:
		case 1:
		case 4:
		case 24:
			break;
		}
		int num = 0;
		do
		{
			int num2 = System.Math.Min(len - num, m_recordStream.PlaintextLimit);
			SafeWriteRecord(22, buf, off + num, num2);
			num += num2;
		}
		while (num < len);
	}

	public virtual void CloseInput()
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use CloseInput() in blocking mode!");
		}
		if (!m_closed)
		{
			if (m_inputBuffers.Available > 0)
			{
				throw new EndOfStreamException();
			}
			if (!m_appDataReady)
			{
				throw new TlsFatalAlert(40);
			}
			if (Peer.RequiresCloseNotify())
			{
				HandleFailure();
				throw new TlsNoCloseNotifyException();
			}
			HandleClose(user_canceled: false);
		}
	}

	public virtual RecordPreview PreviewInputRecord(byte[] recordHeader)
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use PreviewInputRecord() in blocking mode!");
		}
		if (m_inputBuffers.Available != 0)
		{
			throw new InvalidOperationException("Can only use PreviewInputRecord() for record-aligned input.");
		}
		if (m_closed)
		{
			throw new IOException("Connection is closed, cannot accept any more input");
		}
		return SafePreviewRecordHeader(recordHeader);
	}

	public virtual RecordPreview PreviewOutputRecord(int applicationDataSize)
	{
		if (!m_appDataReady)
		{
			throw new InvalidOperationException("Cannot use PreviewOutputRecord() until initial handshake completed.");
		}
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use PreviewOutputRecord() in blocking mode!");
		}
		if (m_outputBuffer.Buffer.Available != 0)
		{
			throw new InvalidOperationException("Can only use PreviewOutputRecord() for record-aligned output.");
		}
		if (m_closed)
		{
			throw new IOException("Connection is closed, cannot produce any more output");
		}
		if (applicationDataSize < 1)
		{
			return new RecordPreview(0, 0);
		}
		if (m_appDataSplitEnabled)
		{
			int appDataSplitMode = m_appDataSplitMode;
			if (appDataSplitMode != 0 && (uint)(appDataSplitMode - 1) <= 1u)
			{
				RecordPreview a = m_recordStream.PreviewOutputRecord(0);
				RecordPreview b = m_recordStream.PreviewOutputRecord(applicationDataSize);
				return RecordPreview.CombineAppData(a, b);
			}
			RecordPreview recordPreview = m_recordStream.PreviewOutputRecord(1);
			if (applicationDataSize > 1)
			{
				RecordPreview b2 = m_recordStream.PreviewOutputRecord(applicationDataSize - 1);
				recordPreview = RecordPreview.CombineAppData(recordPreview, b2);
			}
			return recordPreview;
		}
		RecordPreview recordPreview2 = m_recordStream.PreviewOutputRecord(applicationDataSize);
		if (m_keyUpdateEnabled && (m_keyUpdatePendingSend || m_recordStream.NeedsKeyUpdate()))
		{
			int length = HandshakeMessageOutput.GetLength(1);
			int recordSize = m_recordStream.PreviewOutputRecordSize(length);
			recordPreview2 = RecordPreview.ExtendRecordSize(recordPreview2, recordSize);
		}
		return recordPreview2;
	}

	public virtual void OfferInput(byte[] input)
	{
		OfferInput(input, 0, input.Length);
	}

	public virtual void OfferInput(byte[] input, int inputOff, int inputLen)
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use OfferInput() in blocking mode! Use Stream instead.");
		}
		if (m_closed)
		{
			throw new IOException("Connection is closed, cannot accept any more input");
		}
		if (m_inputBuffers.Available == 0 && SafeReadFullRecord(input, inputOff, inputLen))
		{
			if (m_closed && !m_appDataReady)
			{
				throw new TlsFatalAlert(80);
			}
			return;
		}
		m_inputBuffers.AddBytes(input, inputOff, inputLen);
		while (m_inputBuffers.Available >= 5)
		{
			byte[] array = new byte[5];
			if (5 == m_inputBuffers.Peek(array))
			{
				RecordPreview recordPreview = SafePreviewRecordHeader(array);
				if (m_inputBuffers.Available < recordPreview.RecordSize)
				{
					break;
				}
				SafeReadRecord();
				if (m_closed)
				{
					if (!m_appDataReady)
					{
						throw new TlsFatalAlert(80);
					}
					break;
				}
				continue;
			}
			throw new TlsFatalAlert(80);
		}
	}

	public virtual int GetAvailableInputBytes()
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use GetAvailableInputBytes() in blocking mode!");
		}
		return ApplicationDataAvailable;
	}

	public virtual int ReadInput(byte[] buf, int off, int len)
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use ReadInput() in blocking mode! Use Stream instead.");
		}
		len = System.Math.Min(len, ApplicationDataAvailable);
		if (len < 1)
		{
			return 0;
		}
		m_applicationDataQueue.RemoveData(buf, off, len, 0);
		return len;
	}

	public virtual int GetAvailableOutputBytes()
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use GetAvailableOutputBytes() in blocking mode! Use Stream instead.");
		}
		return m_outputBuffer.Buffer.Available;
	}

	public virtual int ReadOutput(byte[] buffer, int offset, int length)
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use ReadOutput() in blocking mode! Use 'Stream() instead.");
		}
		int num = System.Math.Min(GetAvailableOutputBytes(), length);
		m_outputBuffer.Buffer.RemoveData(buffer, offset, num, 0);
		return num;
	}

	protected virtual bool EstablishSession(TlsSession sessionToResume)
	{
		m_tlsSession = null;
		m_sessionParameters = null;
		m_sessionMasterSecret = null;
		if (sessionToResume != null && sessionToResume.IsResumable)
		{
			SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
			if (sessionParameters == null)
			{
				return false;
			}
			if (!sessionParameters.IsExtendedMasterSecret)
			{
				TlsPeer peer = Peer;
				if (!peer.AllowLegacyResumption() || peer.RequiresExtendedMasterSecret())
				{
					return false;
				}
			}
			TlsSecret sessionMasterSecret = TlsUtilities.GetSessionMasterSecret(Context.Crypto, sessionParameters.MasterSecret);
			if (sessionMasterSecret == null)
			{
				return false;
			}
			m_tlsSession = sessionToResume;
			m_sessionParameters = sessionParameters;
			m_sessionMasterSecret = sessionMasterSecret;
			return true;
		}
		return false;
	}

	protected virtual void InvalidateSession()
	{
		if (m_sessionMasterSecret != null)
		{
			m_sessionMasterSecret.Destroy();
			m_sessionMasterSecret = null;
		}
		if (m_sessionParameters != null)
		{
			m_sessionParameters.Clear();
			m_sessionParameters = null;
		}
		if (m_tlsSession != null)
		{
			m_tlsSession.Invalidate();
			m_tlsSession = null;
		}
	}

	protected virtual void ProcessFinishedMessage(MemoryStream buf)
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		bool isServer = context.IsServer;
		byte[] b = TlsUtilities.ReadFully(securityParameters.VerifyDataLength, buf);
		AssertEmpty(buf);
		byte[] array = TlsUtilities.CalculateVerifyData(context, m_handshakeHash, !isServer);
		if (!Arrays.ConstantTimeAreEqual(array, b))
		{
			throw new TlsFatalAlert(51);
		}
		securityParameters.m_peerVerifyData = array;
		if ((!m_resumedSession || securityParameters.IsExtendedMasterSecret) && securityParameters.LocalVerifyData == null)
		{
			securityParameters.m_tlsUnique = array;
		}
	}

	protected virtual void Process13FinishedMessage(MemoryStream buf)
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		bool isServer = context.IsServer;
		byte[] b = TlsUtilities.ReadFully(securityParameters.VerifyDataLength, buf);
		AssertEmpty(buf);
		byte[] array = TlsUtilities.CalculateVerifyData(context, m_handshakeHash, !isServer);
		if (!Arrays.ConstantTimeAreEqual(array, b))
		{
			throw new TlsFatalAlert(51);
		}
		securityParameters.m_peerVerifyData = array;
		securityParameters.m_tlsUnique = null;
	}

	protected virtual void RaiseAlertFatal(short alertDescription, string message, Exception cause)
	{
		Peer.NotifyAlertRaised(2, alertDescription, message, cause);
		byte[] plaintext = new byte[2]
		{
			2,
			(byte)alertDescription
		};
		try
		{
			m_recordStream.WriteRecord(21, plaintext, 0, 2);
		}
		catch (Exception)
		{
		}
	}

	protected virtual void RaiseAlertWarning(short alertDescription, string message)
	{
		Peer.NotifyAlertRaised(1, alertDescription, message, null);
		byte[] buf = new byte[2]
		{
			1,
			(byte)alertDescription
		};
		SafeWriteRecord(21, buf, 0, 2);
	}

	protected virtual void Receive13KeyUpdate(MemoryStream buf)
	{
		if (m_appDataReady && m_keyUpdateEnabled)
		{
			short num = TlsUtilities.ReadUint8(buf);
			AssertEmpty(buf);
			if (!KeyUpdateRequest.IsValid(num))
			{
				throw new TlsFatalAlert(47);
			}
			bool flag = 1 == num;
			TlsUtilities.Update13TrafficSecretPeer(Context);
			m_recordStream.NotifyKeyUpdateReceived();
			m_keyUpdatePendingSend |= flag;
			return;
		}
		throw new TlsFatalAlert(10);
	}

	protected virtual void SendCertificateMessage(Certificate certificate, Stream endPointHash)
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		if (securityParameters.LocalCertificate != null)
		{
			throw new TlsFatalAlert(80);
		}
		if (certificate == null)
		{
			certificate = Certificate.EmptyChain;
		}
		if (certificate.IsEmpty && !context.IsServer && securityParameters.NegotiatedVersion.IsSsl)
		{
			string message = "SSLv3 client didn't provide credentials";
			RaiseAlertWarning(41, message);
		}
		else
		{
			HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(11);
			certificate.Encode(context, handshakeMessageOutput, endPointHash);
			handshakeMessageOutput.Send(this);
		}
		securityParameters.m_localCertificate = certificate;
	}

	protected virtual void Send13CertificateMessage(Certificate certificate)
	{
		if (certificate == null)
		{
			throw new TlsFatalAlert(80);
		}
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		if (securityParameters.LocalCertificate != null)
		{
			throw new TlsFatalAlert(80);
		}
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(11);
		certificate.Encode(context, handshakeMessageOutput, null);
		handshakeMessageOutput.Send(this);
		securityParameters.m_localCertificate = certificate;
	}

	protected virtual void Send13CertificateVerifyMessage(DigitallySigned certificateVerify)
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(15);
		certificateVerify.Encode(handshakeMessageOutput);
		handshakeMessageOutput.Send(this);
	}

	protected virtual void SendChangeCipherSpec()
	{
		SendChangeCipherSpecMessage();
		m_recordStream.EnablePendingCipherWrite();
	}

	protected virtual void SendChangeCipherSpecMessage()
	{
		byte[] array = new byte[1] { 1 };
		SafeWriteRecord(20, array, 0, array.Length);
	}

	protected virtual void SendFinishedMessage()
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		byte[] array = (securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(isServer: context.IsServer, context: context, handshakeHash: m_handshakeHash));
		if ((!m_resumedSession || securityParameters.IsExtendedMasterSecret) && securityParameters.PeerVerifyData == null)
		{
			securityParameters.m_tlsUnique = array;
		}
		HandshakeMessageOutput.Send(this, 20, array);
	}

	protected virtual void Send13FinishedMessage()
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		byte[] body = (securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(isServer: context.IsServer, context: context, handshakeHash: m_handshakeHash));
		securityParameters.m_tlsUnique = null;
		HandshakeMessageOutput.Send(this, 20, body);
	}

	protected virtual void Send13KeyUpdate(bool updateRequested)
	{
		if (!m_appDataReady || !m_keyUpdateEnabled)
		{
			throw new TlsFatalAlert(80);
		}
		short u = (short)(updateRequested ? 1 : 0);
		HandshakeMessageOutput.Send(this, 24, TlsUtilities.EncodeUint8(u));
		TlsUtilities.Update13TrafficSecretLocal(Context);
		m_recordStream.NotifyKeyUpdateSent();
		m_keyUpdatePendingSend &= updateRequested;
	}

	protected virtual void SendSupplementalDataMessage(IList supplementalData)
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(23);
		WriteSupplementalData(handshakeMessageOutput, supplementalData);
		handshakeMessageOutput.Send(this);
	}

	public virtual void Close()
	{
		HandleClose(user_canceled: true);
	}

	public virtual void Flush()
	{
	}

	protected virtual short ProcessMaxFragmentLengthExtension(IDictionary clientExtensions, IDictionary serverExtensions, short alertDescription)
	{
		short maxFragmentLengthExtension = TlsExtensionsUtilities.GetMaxFragmentLengthExtension(serverExtensions);
		if (maxFragmentLengthExtension >= 0 && (!MaxFragmentLength.IsValid(maxFragmentLengthExtension) || (!m_resumedSession && maxFragmentLengthExtension != TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions))))
		{
			throw new TlsFatalAlert(alertDescription);
		}
		return maxFragmentLengthExtension;
	}

	protected virtual void RefuseRenegotiation()
	{
		if (TlsUtilities.IsSsl(Context))
		{
			throw new TlsFatalAlert(40);
		}
		RaiseAlertWarning(100, "Renegotiation not supported");
	}

	internal static void AssertEmpty(MemoryStream buf)
	{
		if (buf.Position < buf.Length)
		{
			throw new TlsFatalAlert(50);
		}
	}

	internal static byte[] CreateRandomBlock(bool useGmtUnixTime, TlsContext context)
	{
		byte[] array = context.NonceGenerator.GenerateNonce(32);
		if (useGmtUnixTime)
		{
			TlsUtilities.WriteGmtUnixTime(array, 0);
		}
		return array;
	}

	internal static byte[] CreateRenegotiationInfo(byte[] renegotiated_connection)
	{
		return TlsUtilities.EncodeOpaque8(renegotiated_connection);
	}

	internal static void EstablishMasterSecret(TlsContext context, TlsKeyExchange keyExchange)
	{
		TlsSecret tlsSecret = keyExchange.GeneratePreMasterSecret();
		if (tlsSecret == null)
		{
			throw new TlsFatalAlert(80);
		}
		try
		{
			context.SecurityParameters.m_masterSecret = TlsUtilities.CalculateMasterSecret(context, tlsSecret);
		}
		finally
		{
			tlsSecret.Destroy();
		}
	}

	internal static IDictionary ReadExtensions(MemoryStream input)
	{
		if (input.Position >= input.Length)
		{
			return null;
		}
		byte[] extBytes = TlsUtilities.ReadOpaque16(input);
		AssertEmpty(input);
		return ReadExtensionsData(extBytes);
	}

	internal static IDictionary ReadExtensionsData(byte[] extBytes)
	{
		IDictionary dictionary = Platform.CreateHashtable();
		if (extBytes.Length != 0)
		{
			MemoryStream memoryStream = new MemoryStream(extBytes, writable: false);
			do
			{
				int num = TlsUtilities.ReadUint16(memoryStream);
				byte[] value = TlsUtilities.ReadOpaque16(memoryStream);
				int num2 = num;
				if (!dictionary.Contains(num2))
				{
					dictionary.Add(num2, value);
					continue;
				}
				throw new TlsFatalAlert(47, "Repeated extension: " + ExtensionType.GetText(num));
			}
			while (memoryStream.Position < memoryStream.Length);
		}
		return dictionary;
	}

	internal static IDictionary ReadExtensionsData13(int handshakeType, byte[] extBytes)
	{
		IDictionary dictionary = Platform.CreateHashtable();
		if (extBytes.Length != 0)
		{
			MemoryStream memoryStream = new MemoryStream(extBytes, writable: false);
			do
			{
				int num = TlsUtilities.ReadUint16(memoryStream);
				if (TlsUtilities.IsPermittedExtensionType13(handshakeType, num))
				{
					byte[] value = TlsUtilities.ReadOpaque16(memoryStream);
					int num2 = num;
					if (!dictionary.Contains(num2))
					{
						dictionary.Add(num2, value);
						continue;
					}
					throw new TlsFatalAlert(47, "Repeated extension: " + ExtensionType.GetText(num));
				}
				throw new TlsFatalAlert(47, "Invalid extension: " + ExtensionType.GetText(num));
			}
			while (memoryStream.Position < memoryStream.Length);
		}
		return dictionary;
	}

	internal static IDictionary ReadExtensionsDataClientHello(byte[] extBytes)
	{
		IDictionary dictionary = Platform.CreateHashtable();
		if (extBytes.Length != 0)
		{
			MemoryStream memoryStream = new MemoryStream(extBytes, writable: false);
			bool flag = false;
			int num;
			do
			{
				num = TlsUtilities.ReadUint16(memoryStream);
				byte[] value = TlsUtilities.ReadOpaque16(memoryStream);
				int num2 = num;
				if (!dictionary.Contains(num2))
				{
					dictionary.Add(num2, value);
					flag = flag || 41 == num;
					continue;
				}
				throw new TlsFatalAlert(47, "Repeated extension: " + ExtensionType.GetText(num));
			}
			while (memoryStream.Position < memoryStream.Length);
			if (flag && 41 != num)
			{
				throw new TlsFatalAlert(47, "'pre_shared_key' MUST be last in ClientHello");
			}
		}
		return dictionary;
	}

	internal static IList ReadSupplementalDataMessage(MemoryStream input)
	{
		byte[] buffer = TlsUtilities.ReadOpaque24(input, 1);
		AssertEmpty(input);
		MemoryStream memoryStream = new MemoryStream(buffer, writable: false);
		IList list = Platform.CreateArrayList();
		while (memoryStream.Position < memoryStream.Length)
		{
			int dataType = TlsUtilities.ReadUint16(memoryStream);
			byte[] data = TlsUtilities.ReadOpaque16(memoryStream);
			list.Add(new SupplementalDataEntry(dataType, data));
		}
		return list;
	}

	internal static void WriteExtensions(Stream output, IDictionary extensions)
	{
		WriteExtensions(output, extensions, 0);
	}

	internal static void WriteExtensions(Stream output, IDictionary extensions, int bindersSize)
	{
		if (extensions != null && extensions.Count >= 1)
		{
			byte[] array = WriteExtensionsData(extensions, bindersSize);
			int i = array.Length + bindersSize;
			TlsUtilities.CheckUint16(i);
			TlsUtilities.WriteUint16(i, output);
			output.Write(array, 0, array.Length);
		}
	}

	internal static byte[] WriteExtensionsData(IDictionary extensions)
	{
		return WriteExtensionsData(extensions, 0);
	}

	internal static byte[] WriteExtensionsData(IDictionary extensions, int bindersSize)
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteExtensionsData(extensions, memoryStream, bindersSize);
		return memoryStream.ToArray();
	}

	internal static void WriteExtensionsData(IDictionary extensions, MemoryStream buf)
	{
		WriteExtensionsData(extensions, buf, 0);
	}

	internal static void WriteExtensionsData(IDictionary extensions, MemoryStream buf, int bindersSize)
	{
		WriteSelectedExtensions(buf, extensions, selectEmpty: true);
		WriteSelectedExtensions(buf, extensions, selectEmpty: false);
		WritePreSharedKeyExtension(buf, extensions, bindersSize);
	}

	internal static void WritePreSharedKeyExtension(MemoryStream buf, IDictionary extensions, int bindersSize)
	{
		byte[] array = (byte[])extensions[41];
		if (array != null)
		{
			TlsUtilities.CheckUint16(41);
			TlsUtilities.WriteUint16(41, buf);
			int i = array.Length + bindersSize;
			TlsUtilities.CheckUint16(i);
			TlsUtilities.WriteUint16(i, buf);
			buf.Write(array, 0, array.Length);
		}
	}

	internal static void WriteSelectedExtensions(Stream output, IDictionary extensions, bool selectEmpty)
	{
		foreach (int key in extensions.Keys)
		{
			int num2 = key;
			if (41 != num2)
			{
				byte[] array = (byte[])extensions[key];
				if (selectEmpty == (array.Length == 0))
				{
					TlsUtilities.CheckUint16(num2);
					TlsUtilities.WriteUint16(num2, output);
					TlsUtilities.WriteOpaque16(array, output);
				}
			}
		}
	}

	internal static void WriteSupplementalData(Stream output, IList supplementalData)
	{
		MemoryStream memoryStream = new MemoryStream();
		foreach (SupplementalDataEntry supplementalDatum in supplementalData)
		{
			int dataType = supplementalDatum.DataType;
			TlsUtilities.CheckUint16(dataType);
			TlsUtilities.WriteUint16(dataType, memoryStream);
			TlsUtilities.WriteOpaque16(supplementalDatum.Data, memoryStream);
		}
		TlsUtilities.WriteOpaque24(memoryStream.ToArray(), output);
	}
}
