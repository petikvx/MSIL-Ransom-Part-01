using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;
using Renci.SshNet.Compression;
using Renci.SshNet.Messages;
using Renci.SshNet.Messages.Authentication;
using Renci.SshNet.Messages.Connection;
using Renci.SshNet.Messages.Transport;
using Renci.SshNet.Security;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet;

public class Session : IDisposable, ISession
{
	private const byte Null = 0;

	private const byte CarriageReturn = 13;

	internal const byte LineFeed = 10;

	internal static readonly TimeSpan InfiniteTimeSpan = new TimeSpan(0, 0, 0, 0, -1);

	internal static readonly int Infinite = -1;

	private const int MaximumSshPacketSize = 68536;

	private const int InitialLocalWindowSize = int.MaxValue;

	private const int LocalChannelDataPacketSize = 65536;

	private static readonly Regex ServerVersionRe = new Regex("^SSH-(?<protoversion>[^-]+)-(?<softwareversion>.+)( SP.+)?$", RegexOptions.Compiled);

	private static readonly SemaphoreLight AuthenticationConnection = new SemaphoreLight(3);

	private SshMessageFactory _sshMessageFactory;

	private EventWaitHandle _messageListenerCompleted;

	private volatile uint _outboundPacketSequence;

	private uint _inboundPacketSequence;

	private EventWaitHandle _serviceAccepted = new AutoResetEvent(initialState: false);

	private EventWaitHandle _exceptionWaitHandle = new ManualResetEvent(initialState: false);

	private EventWaitHandle _keyExchangeCompletedWaitHandle = new ManualResetEvent(initialState: false);

	private bool _keyExchangeInProgress;

	private Exception _exception;

	private bool _isAuthenticated;

	private bool _isDisconnecting;

	private IKeyExchange _keyExchange;

	private HashAlgorithm _serverMac;

	private HashAlgorithm _clientMac;

	private Cipher _clientCipher;

	private Cipher _serverCipher;

	private Compressor _serverDecompression;

	private Compressor _clientCompression;

	private SemaphoreLight _sessionSemaphore;

	private readonly IServiceFactory _serviceFactory;

	private Socket _socket;

	private readonly object _socketReadLock = new object();

	private readonly object _socketWriteLock = new object();

	private readonly object _socketDisposeLock = new object();

	private bool _isDisconnectMessageSent;

	private uint _nextChannelNumber;

	private Message _clientInitMessage;

	private bool _disposed;

	public SemaphoreLight SessionSemaphore
	{
		get
		{
			if (_sessionSemaphore == null)
			{
				lock (this)
				{
					if (_sessionSemaphore == null)
					{
						_sessionSemaphore = new SemaphoreLight(ConnectionInfo.MaxSessions);
					}
				}
			}
			return _sessionSemaphore;
		}
	}

	private uint NextChannelNumber
	{
		get
		{
			lock (this)
			{
				return _nextChannelNumber++;
			}
		}
	}

	public bool IsConnected
	{
		get
		{
			if (!_disposed && !_isDisconnectMessageSent && _isAuthenticated)
			{
				if (_messageListenerCompleted != null && !_messageListenerCompleted.WaitOne(0))
				{
					return IsSocketConnected();
				}
				return false;
			}
			return false;
		}
	}

	public byte[] SessionId { get; private set; }

	public Message ClientInitMessage
	{
		get
		{
			if (_clientInitMessage == null)
			{
				_clientInitMessage = new KeyExchangeInitMessage
				{
					KeyExchangeAlgorithms = ConnectionInfo.KeyExchangeAlgorithms.Keys.ToArray(),
					ServerHostKeyAlgorithms = ConnectionInfo.HostKeyAlgorithms.Keys.ToArray(),
					EncryptionAlgorithmsClientToServer = ConnectionInfo.Encryptions.Keys.ToArray(),
					EncryptionAlgorithmsServerToClient = ConnectionInfo.Encryptions.Keys.ToArray(),
					MacAlgorithmsClientToServer = ConnectionInfo.HmacAlgorithms.Keys.ToArray(),
					MacAlgorithmsServerToClient = ConnectionInfo.HmacAlgorithms.Keys.ToArray(),
					CompressionAlgorithmsClientToServer = ConnectionInfo.CompressionAlgorithms.Keys.ToArray(),
					CompressionAlgorithmsServerToClient = ConnectionInfo.CompressionAlgorithms.Keys.ToArray(),
					LanguagesClientToServer = new string[1] { string.Empty },
					LanguagesServerToClient = new string[1] { string.Empty },
					FirstKexPacketFollows = false,
					Reserved = 0u
				};
			}
			return _clientInitMessage;
		}
	}

	public string ServerVersion { get; private set; }

	public string ClientVersion { get; private set; }

	public ConnectionInfo ConnectionInfo { get; private set; }

	IConnectionInfo ISession.ConnectionInfo => ConnectionInfo;

	WaitHandle ISession.MessageListenerCompleted => _messageListenerCompleted;

	public event EventHandler<ExceptionEventArgs> ErrorOccured;

	public event EventHandler<EventArgs> Disconnected;

	public event EventHandler<HostKeyEventArgs> HostKeyReceived;

	public event EventHandler<MessageEventArgs<BannerMessage>> UserAuthenticationBannerReceived;

	internal event EventHandler<MessageEventArgs<InformationRequestMessage>> UserAuthenticationInformationRequestReceived;

	internal event EventHandler<MessageEventArgs<PasswordChangeRequiredMessage>> UserAuthenticationPasswordChangeRequiredReceived;

	internal event EventHandler<MessageEventArgs<PublicKeyMessage>> UserAuthenticationPublicKeyReceived;

	internal event EventHandler<MessageEventArgs<KeyExchangeDhGroupExchangeGroup>> KeyExchangeDhGroupExchangeGroupReceived;

	internal event EventHandler<MessageEventArgs<KeyExchangeDhGroupExchangeReply>> KeyExchangeDhGroupExchangeReplyReceived;

	internal event EventHandler<MessageEventArgs<DisconnectMessage>> DisconnectReceived;

	internal event EventHandler<MessageEventArgs<IgnoreMessage>> IgnoreReceived;

	internal event EventHandler<MessageEventArgs<UnimplementedMessage>> UnimplementedReceived;

	internal event EventHandler<MessageEventArgs<DebugMessage>> DebugReceived;

	internal event EventHandler<MessageEventArgs<ServiceRequestMessage>> ServiceRequestReceived;

	internal event EventHandler<MessageEventArgs<ServiceAcceptMessage>> ServiceAcceptReceived;

	internal event EventHandler<MessageEventArgs<KeyExchangeInitMessage>> KeyExchangeInitReceived;

	internal event EventHandler<MessageEventArgs<KeyExchangeDhReplyMessage>> KeyExchangeDhReplyMessageReceived;

	internal event EventHandler<MessageEventArgs<KeyExchangeEcdhReplyMessage>> KeyExchangeEcdhReplyMessageReceived;

	internal event EventHandler<MessageEventArgs<NewKeysMessage>> NewKeysReceived;

	internal event EventHandler<MessageEventArgs<RequestMessage>> UserAuthenticationRequestReceived;

	internal event EventHandler<MessageEventArgs<FailureMessage>> UserAuthenticationFailureReceived;

	internal event EventHandler<MessageEventArgs<SuccessMessage>> UserAuthenticationSuccessReceived;

	internal event EventHandler<MessageEventArgs<GlobalRequestMessage>> GlobalRequestReceived;

	public event EventHandler<MessageEventArgs<RequestSuccessMessage>> RequestSuccessReceived;

	public event EventHandler<MessageEventArgs<RequestFailureMessage>> RequestFailureReceived;

	public event EventHandler<MessageEventArgs<ChannelOpenMessage>> ChannelOpenReceived;

	public event EventHandler<MessageEventArgs<ChannelOpenConfirmationMessage>> ChannelOpenConfirmationReceived;

	public event EventHandler<MessageEventArgs<ChannelOpenFailureMessage>> ChannelOpenFailureReceived;

	public event EventHandler<MessageEventArgs<ChannelWindowAdjustMessage>> ChannelWindowAdjustReceived;

	public event EventHandler<MessageEventArgs<ChannelDataMessage>> ChannelDataReceived;

	public event EventHandler<MessageEventArgs<ChannelExtendedDataMessage>> ChannelExtendedDataReceived;

	public event EventHandler<MessageEventArgs<ChannelEofMessage>> ChannelEofReceived;

	public event EventHandler<MessageEventArgs<ChannelCloseMessage>> ChannelCloseReceived;

	public event EventHandler<MessageEventArgs<ChannelRequestMessage>> ChannelRequestReceived;

	public event EventHandler<MessageEventArgs<ChannelSuccessMessage>> ChannelSuccessReceived;

	public event EventHandler<MessageEventArgs<ChannelFailureMessage>> ChannelFailureReceived;

	internal Session(ConnectionInfo connectionInfo, IServiceFactory serviceFactory)
	{
		if (connectionInfo == null)
		{
			throw new ArgumentNullException("connectionInfo");
		}
		if (serviceFactory == null)
		{
			throw new ArgumentNullException("serviceFactory");
		}
		ClientVersion = "SSH-2.0-Renci.SshNet.SshClient.0.0.1";
		ConnectionInfo = connectionInfo;
		_serviceFactory = serviceFactory;
		_messageListenerCompleted = new ManualResetEvent(initialState: true);
	}

	public void Connect()
	{
		if (IsConnected)
		{
			return;
		}
		try
		{
			AuthenticationConnection.Wait();
			if (IsConnected)
			{
				return;
			}
			lock (this)
			{
				if (IsConnected)
				{
					return;
				}
				Reset();
				_sshMessageFactory = new SshMessageFactory();
				switch (ConnectionInfo.ProxyType)
				{
				case ProxyTypes.None:
					SocketConnect(ConnectionInfo.Host, ConnectionInfo.Port);
					break;
				case ProxyTypes.Socks4:
					SocketConnect(ConnectionInfo.ProxyHost, ConnectionInfo.ProxyPort);
					ConnectSocks4(_socket, ConnectionInfo);
					break;
				case ProxyTypes.Socks5:
					SocketConnect(ConnectionInfo.ProxyHost, ConnectionInfo.ProxyPort);
					ConnectSocks5(_socket, ConnectionInfo);
					break;
				case ProxyTypes.Http:
					SocketConnect(ConnectionInfo.ProxyHost, ConnectionInfo.ProxyPort);
					ConnectHttp(_socket, ConnectionInfo);
					break;
				}
				SocketAbstraction.Send(_socket, Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "{0}\r\n", new object[1] { ClientVersion })));
				string text;
				Match match;
				do
				{
					text = SocketReadLine(_socket, ConnectionInfo.Timeout);
					if (text != null)
					{
						match = ServerVersionRe.Match(text);
						continue;
					}
					throw new SshConnectionException("Server response does not contain SSH protocol identification.", DisconnectReason.ProtocolError);
				}
				while (!match.Success);
				ServerVersion = text;
				ConnectionInfo.ServerVersion = ServerVersion;
				ConnectionInfo.ClientVersion = ClientVersion;
				string text2 = match.Result("${protoversion}");
				match.Result("${softwareversion}");
				if (!text2.Equals("2.0") && !text2.Equals("1.99"))
				{
					throw new SshConnectionException(string.Format(CultureInfo.CurrentCulture, "Server version '{0}' is not supported.", new object[1] { text2 }), DisconnectReason.ProtocolVersionNotSupported);
				}
				RegisterMessage("SSH_MSG_DISCONNECT");
				RegisterMessage("SSH_MSG_IGNORE");
				RegisterMessage("SSH_MSG_UNIMPLEMENTED");
				RegisterMessage("SSH_MSG_DEBUG");
				RegisterMessage("SSH_MSG_SERVICE_ACCEPT");
				RegisterMessage("SSH_MSG_KEXINIT");
				RegisterMessage("SSH_MSG_NEWKEYS");
				RegisterMessage("SSH_MSG_USERAUTH_BANNER");
				_messageListenerCompleted.Reset();
				ThreadAbstraction.ExecuteThread(delegate
				{
					MessageListener();
				});
				WaitOnHandle(_keyExchangeCompletedWaitHandle);
				if (SessionId == null)
				{
					Disconnect();
					return;
				}
				SendMessage(new ServiceRequestMessage(ServiceName.UserAuthentication));
				WaitOnHandle(_serviceAccepted);
				if (string.IsNullOrEmpty(ConnectionInfo.Username))
				{
					throw new SshException("Username is not specified.");
				}
				RegisterMessage("SSH_MSG_GLOBAL_REQUEST");
				ConnectionInfo.Authenticate(this, _serviceFactory);
				_isAuthenticated = true;
				RegisterMessage("SSH_MSG_REQUEST_SUCCESS");
				RegisterMessage("SSH_MSG_REQUEST_FAILURE");
				RegisterMessage("SSH_MSG_CHANNEL_OPEN_CONFIRMATION");
				RegisterMessage("SSH_MSG_CHANNEL_OPEN_FAILURE");
				RegisterMessage("SSH_MSG_CHANNEL_WINDOW_ADJUST");
				RegisterMessage("SSH_MSG_CHANNEL_EXTENDED_DATA");
				RegisterMessage("SSH_MSG_CHANNEL_REQUEST");
				RegisterMessage("SSH_MSG_CHANNEL_SUCCESS");
				RegisterMessage("SSH_MSG_CHANNEL_FAILURE");
				RegisterMessage("SSH_MSG_CHANNEL_DATA");
				RegisterMessage("SSH_MSG_CHANNEL_EOF");
				RegisterMessage("SSH_MSG_CHANNEL_CLOSE");
			}
		}
		finally
		{
			AuthenticationConnection.Release();
		}
	}

	public void Disconnect()
	{
		Disconnect(DisconnectReason.ByApplication, "Connection terminated by the client.");
		if (_messageListenerCompleted != null)
		{
			_messageListenerCompleted.WaitOne();
		}
	}

	private void Disconnect(DisconnectReason reason, string message)
	{
		_isDisconnecting = true;
		if (IsConnected)
		{
			TrySendDisconnect(reason, message);
		}
		SocketDisconnectAndDispose();
	}

	void ISession.WaitOnHandle(WaitHandle waitHandle)
	{
		WaitOnHandle(waitHandle, ConnectionInfo.Timeout);
	}

	void ISession.WaitOnHandle(WaitHandle waitHandle, TimeSpan timeout)
	{
		WaitOnHandle(waitHandle, timeout);
	}

	internal void WaitOnHandle(WaitHandle waitHandle)
	{
		WaitOnHandle(waitHandle, ConnectionInfo.Timeout);
	}

	WaitResult ISession.TryWait(WaitHandle waitHandle, TimeSpan timeout)
	{
		Exception exception;
		return TryWait(waitHandle, timeout, out exception);
	}

	WaitResult ISession.TryWait(WaitHandle waitHandle, TimeSpan timeout, out Exception exception)
	{
		return TryWait(waitHandle, timeout, out exception);
	}

	private WaitResult TryWait(WaitHandle waitHandle, TimeSpan timeout, out Exception exception)
	{
		if (waitHandle == null)
		{
			throw new ArgumentNullException("waitHandle");
		}
		switch (WaitHandle.WaitAny(new WaitHandle[3] { _exceptionWaitHandle, _messageListenerCompleted, waitHandle }, timeout))
		{
		default:
			throw new InvalidOperationException("Unexpected result.");
		case 258:
			exception = null;
			return WaitResult.TimedOut;
		case 0:
			if (_exception is SshConnectionException)
			{
				exception = null;
				return WaitResult.Disconnected;
			}
			exception = _exception;
			return WaitResult.Failed;
		case 1:
			exception = null;
			return WaitResult.Disconnected;
		case 2:
			exception = null;
			return WaitResult.Success;
		}
	}

	internal void WaitOnHandle(WaitHandle waitHandle, TimeSpan timeout)
	{
		if (waitHandle == null)
		{
			throw new ArgumentNullException("waitHandle");
		}
		switch (WaitHandle.WaitAny(new WaitHandle[3] { _exceptionWaitHandle, _messageListenerCompleted, waitHandle }, timeout))
		{
		case 258:
			if (!_isDisconnecting)
			{
				throw new SshOperationTimeoutException("Session operation has timed out");
			}
			break;
		case 1:
			throw new SshConnectionException("Client not connected.");
		case 0:
			throw _exception;
		}
	}

	internal void SendMessage(Message message)
	{
		if (!_socket.CanWrite())
		{
			throw new SshConnectionException("Client not connected.");
		}
		if (_keyExchangeInProgress && !(message is IKeyExchangedAllowed))
		{
			WaitOnHandle(_keyExchangeCompletedWaitHandle);
		}
		byte paddingMultiplier = (byte)((_clientCipher == null) ? 8 : Math.Max((byte)8, _serverCipher.MinimumSize));
		byte[] array = message.GetPacket(paddingMultiplier, _clientCompression);
		lock (_socketWriteLock)
		{
			byte[] array2 = null;
			int num = 4;
			if (_clientMac != null)
			{
				Pack.UInt32ToBigEndian(_outboundPacketSequence, array);
				array2 = _clientMac.ComputeHash(array);
			}
			if (_clientCipher != null)
			{
				array = _clientCipher.Encrypt(array, num, array.Length - num);
				num = 0;
			}
			if (array.Length > 68536)
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "Packet is too big. Maximum packet size is {0} bytes.", new object[1] { 68536 }));
			}
			int num2 = array.Length - num;
			if (array2 == null)
			{
				SendPacket(array, num, num2);
			}
			else
			{
				byte[] array3 = new byte[num2 + array2.Length];
				Buffer.BlockCopy(array, num, array3, 0, num2);
				Buffer.BlockCopy(array2, 0, array3, num2, array2.Length);
				SendPacket(array3, 0, array3.Length);
			}
			_outboundPacketSequence++;
		}
	}

	private void SendPacket(byte[] packet, int offset, int length)
	{
		lock (_socketDisposeLock)
		{
			if (!_socket.IsConnected())
			{
				throw new SshConnectionException("Client not connected.");
			}
			SocketAbstraction.Send(_socket, packet, offset, length);
		}
	}

	private bool TrySendMessage(Message message)
	{
		try
		{
			SendMessage(message);
			return true;
		}
		catch (SshException)
		{
			return false;
		}
		catch (SocketException)
		{
			return false;
		}
	}

	private Message ReceiveMessage(Socket socket)
	{
		byte b = (byte)((_serverCipher == null) ? 8 : Math.Max((byte)8, _serverCipher.MinimumSize));
		int num = ((_serverMac != null) ? (_serverMac.HashSize / 8) : 0);
		uint num2;
		byte[] array2;
		lock (_socketReadLock)
		{
			byte[] array = new byte[b];
			if (TrySocketRead(socket, array, 0, b) == 0)
			{
				return null;
			}
			if (_serverCipher != null)
			{
				array = _serverCipher.Decrypt(array);
			}
			num2 = Pack.BigEndianToUInt32(array);
			if (num2 < Math.Max((byte)16, b) - 4 || num2 > 68532)
			{
				throw new SshConnectionException(string.Format(CultureInfo.CurrentCulture, "Bad packet length: {0}.", new object[1] { num2 }), DisconnectReason.ProtocolError);
			}
			int num3 = (int)(num2 - (b - 4)) + num;
			array2 = new byte[num3 + b + 4];
			Pack.UInt32ToBigEndian(_inboundPacketSequence, array2);
			Buffer.BlockCopy(array, 0, array2, 4, array.Length);
			if (num3 > 0 && TrySocketRead(socket, array2, b + 4, num3) == 0)
			{
				return null;
			}
		}
		if (_serverCipher != null)
		{
			int num4 = array2.Length - (b + 4 + num);
			if (num4 > 0)
			{
				byte[] array3 = _serverCipher.Decrypt(array2, b + 4, num4);
				Buffer.BlockCopy(array3, 0, array2, b + 4, array3.Length);
			}
		}
		byte b2 = array2[8];
		int num5 = (int)(num2 - b2 - 1);
		int offset = 9;
		if (_serverMac != null)
		{
			byte[] right = _serverMac.ComputeHash(array2, 0, array2.Length - num);
			if (!array2.Take(array2.Length - num, num).IsEqualTo(right))
			{
				throw new SshConnectionException("MAC error", DisconnectReason.MacError);
			}
		}
		if (_serverDecompression != null)
		{
			array2 = _serverDecompression.Decompress(array2, offset, num5);
			offset = 0;
			num5 = array2.Length;
		}
		_inboundPacketSequence++;
		return LoadMessage(array2, offset, num5);
	}

	private void TrySendDisconnect(DisconnectReason reasonCode, string message)
	{
		DisconnectMessage message2 = new DisconnectMessage(reasonCode, message);
		TrySendMessage(message2);
		_isDisconnectMessageSent = true;
	}

	internal void OnDisconnectReceived(DisconnectMessage message)
	{
		_isDisconnecting = true;
		_exception = new SshConnectionException(string.Format(CultureInfo.InvariantCulture, "The connection was closed by the server: {0} ({1}).", new object[2] { message.Description, message.ReasonCode }), message.ReasonCode);
		_exceptionWaitHandle.Set();
		this.DisconnectReceived?.Invoke(this, new MessageEventArgs<DisconnectMessage>(message));
		this.Disconnected?.Invoke(this, new EventArgs());
		SocketDisconnectAndDispose();
	}

	internal void OnIgnoreReceived(IgnoreMessage message)
	{
		this.IgnoreReceived?.Invoke(this, new MessageEventArgs<IgnoreMessage>(message));
	}

	internal void OnUnimplementedReceived(UnimplementedMessage message)
	{
		this.UnimplementedReceived?.Invoke(this, new MessageEventArgs<UnimplementedMessage>(message));
	}

	internal void OnDebugReceived(DebugMessage message)
	{
		this.DebugReceived?.Invoke(this, new MessageEventArgs<DebugMessage>(message));
	}

	internal void OnServiceRequestReceived(ServiceRequestMessage message)
	{
		this.ServiceRequestReceived?.Invoke(this, new MessageEventArgs<ServiceRequestMessage>(message));
	}

	internal void OnServiceAcceptReceived(ServiceAcceptMessage message)
	{
		this.ServiceAcceptReceived?.Invoke(this, new MessageEventArgs<ServiceAcceptMessage>(message));
		_serviceAccepted.Set();
	}

	internal void OnKeyExchangeDhGroupExchangeGroupReceived(KeyExchangeDhGroupExchangeGroup message)
	{
		this.KeyExchangeDhGroupExchangeGroupReceived?.Invoke(this, new MessageEventArgs<KeyExchangeDhGroupExchangeGroup>(message));
	}

	internal void OnKeyExchangeDhGroupExchangeReplyReceived(KeyExchangeDhGroupExchangeReply message)
	{
		this.KeyExchangeDhGroupExchangeReplyReceived?.Invoke(this, new MessageEventArgs<KeyExchangeDhGroupExchangeReply>(message));
	}

	internal void OnKeyExchangeInitReceived(KeyExchangeInitMessage message)
	{
		_keyExchangeInProgress = true;
		_keyExchangeCompletedWaitHandle.Reset();
		_sshMessageFactory.DisableNonKeyExchangeMessages();
		_keyExchange = _serviceFactory.CreateKeyExchange(ConnectionInfo.KeyExchangeAlgorithms, message.KeyExchangeAlgorithms);
		ConnectionInfo.CurrentKeyExchangeAlgorithm = _keyExchange.Name;
		_keyExchange.HostKeyReceived += KeyExchange_HostKeyReceived;
		_keyExchange.Start(this, message);
		this.KeyExchangeInitReceived?.Invoke(this, new MessageEventArgs<KeyExchangeInitMessage>(message));
	}

	internal void OnKeyExchangeDhReplyMessageReceived(KeyExchangeDhReplyMessage message)
	{
		this.KeyExchangeDhReplyMessageReceived?.Invoke(this, new MessageEventArgs<KeyExchangeDhReplyMessage>(message));
	}

	internal void OnKeyExchangeEcdhReplyMessageReceived(KeyExchangeEcdhReplyMessage message)
	{
		this.KeyExchangeEcdhReplyMessageReceived?.Invoke(this, new MessageEventArgs<KeyExchangeEcdhReplyMessage>(message));
	}

	internal void OnNewKeysReceived(NewKeysMessage message)
	{
		if (SessionId == null)
		{
			SessionId = _keyExchange.ExchangeHash;
		}
		if (_serverMac != null)
		{
			_serverMac.Dispose();
			_serverMac = null;
		}
		if (_clientMac != null)
		{
			_clientMac.Dispose();
			_clientMac = null;
		}
		_serverCipher = _keyExchange.CreateServerCipher();
		_clientCipher = _keyExchange.CreateClientCipher();
		_serverMac = _keyExchange.CreateServerHash();
		_clientMac = _keyExchange.CreateClientHash();
		_clientCompression = _keyExchange.CreateCompressor();
		_serverDecompression = _keyExchange.CreateDecompressor();
		if (_keyExchange != null)
		{
			_keyExchange.HostKeyReceived -= KeyExchange_HostKeyReceived;
			_keyExchange.Dispose();
			_keyExchange = null;
		}
		_sshMessageFactory.EnableActivatedMessages();
		this.NewKeysReceived?.Invoke(this, new MessageEventArgs<NewKeysMessage>(message));
		_keyExchangeCompletedWaitHandle.Set();
		_keyExchangeInProgress = false;
	}

	void ISession.OnDisconnecting()
	{
		_isDisconnecting = true;
	}

	internal void OnUserAuthenticationRequestReceived(RequestMessage message)
	{
		this.UserAuthenticationRequestReceived?.Invoke(this, new MessageEventArgs<RequestMessage>(message));
	}

	internal void OnUserAuthenticationFailureReceived(FailureMessage message)
	{
		this.UserAuthenticationFailureReceived?.Invoke(this, new MessageEventArgs<FailureMessage>(message));
	}

	internal void OnUserAuthenticationSuccessReceived(SuccessMessage message)
	{
		this.UserAuthenticationSuccessReceived?.Invoke(this, new MessageEventArgs<SuccessMessage>(message));
	}

	internal void OnUserAuthenticationBannerReceived(BannerMessage message)
	{
		this.UserAuthenticationBannerReceived?.Invoke(this, new MessageEventArgs<BannerMessage>(message));
	}

	internal void OnUserAuthenticationInformationRequestReceived(InformationRequestMessage message)
	{
		this.UserAuthenticationInformationRequestReceived?.Invoke(this, new MessageEventArgs<InformationRequestMessage>(message));
	}

	internal void OnUserAuthenticationPasswordChangeRequiredReceived(PasswordChangeRequiredMessage message)
	{
		this.UserAuthenticationPasswordChangeRequiredReceived?.Invoke(this, new MessageEventArgs<PasswordChangeRequiredMessage>(message));
	}

	internal void OnUserAuthenticationPublicKeyReceived(PublicKeyMessage message)
	{
		this.UserAuthenticationPublicKeyReceived?.Invoke(this, new MessageEventArgs<PublicKeyMessage>(message));
	}

	internal void OnGlobalRequestReceived(GlobalRequestMessage message)
	{
		this.GlobalRequestReceived?.Invoke(this, new MessageEventArgs<GlobalRequestMessage>(message));
	}

	internal void OnRequestSuccessReceived(RequestSuccessMessage message)
	{
		this.RequestSuccessReceived?.Invoke(this, new MessageEventArgs<RequestSuccessMessage>(message));
	}

	internal void OnRequestFailureReceived(RequestFailureMessage message)
	{
		this.RequestFailureReceived?.Invoke(this, new MessageEventArgs<RequestFailureMessage>(message));
	}

	internal void OnChannelOpenReceived(ChannelOpenMessage message)
	{
		this.ChannelOpenReceived?.Invoke(this, new MessageEventArgs<ChannelOpenMessage>(message));
	}

	internal void OnChannelOpenConfirmationReceived(ChannelOpenConfirmationMessage message)
	{
		this.ChannelOpenConfirmationReceived?.Invoke(this, new MessageEventArgs<ChannelOpenConfirmationMessage>(message));
	}

	internal void OnChannelOpenFailureReceived(ChannelOpenFailureMessage message)
	{
		this.ChannelOpenFailureReceived?.Invoke(this, new MessageEventArgs<ChannelOpenFailureMessage>(message));
	}

	internal void OnChannelWindowAdjustReceived(ChannelWindowAdjustMessage message)
	{
		this.ChannelWindowAdjustReceived?.Invoke(this, new MessageEventArgs<ChannelWindowAdjustMessage>(message));
	}

	internal void OnChannelDataReceived(ChannelDataMessage message)
	{
		this.ChannelDataReceived?.Invoke(this, new MessageEventArgs<ChannelDataMessage>(message));
	}

	internal void OnChannelExtendedDataReceived(ChannelExtendedDataMessage message)
	{
		this.ChannelExtendedDataReceived?.Invoke(this, new MessageEventArgs<ChannelExtendedDataMessage>(message));
	}

	internal void OnChannelEofReceived(ChannelEofMessage message)
	{
		this.ChannelEofReceived?.Invoke(this, new MessageEventArgs<ChannelEofMessage>(message));
	}

	internal void OnChannelCloseReceived(ChannelCloseMessage message)
	{
		this.ChannelCloseReceived?.Invoke(this, new MessageEventArgs<ChannelCloseMessage>(message));
	}

	internal void OnChannelRequestReceived(ChannelRequestMessage message)
	{
		this.ChannelRequestReceived?.Invoke(this, new MessageEventArgs<ChannelRequestMessage>(message));
	}

	internal void OnChannelSuccessReceived(ChannelSuccessMessage message)
	{
		this.ChannelSuccessReceived?.Invoke(this, new MessageEventArgs<ChannelSuccessMessage>(message));
	}

	internal void OnChannelFailureReceived(ChannelFailureMessage message)
	{
		this.ChannelFailureReceived?.Invoke(this, new MessageEventArgs<ChannelFailureMessage>(message));
	}

	private void KeyExchange_HostKeyReceived(object sender, HostKeyEventArgs e)
	{
		this.HostKeyReceived?.Invoke(this, e);
	}

	public void RegisterMessage(string messageName)
	{
		_sshMessageFactory.EnableAndActivateMessage(messageName);
	}

	public void UnRegisterMessage(string messageName)
	{
		_sshMessageFactory.DisableAndDeactivateMessage(messageName);
	}

	private Message LoadMessage(byte[] data, int offset, int count)
	{
		byte messageNumber = data[offset];
		Message message = _sshMessageFactory.Create(messageNumber);
		message.Load(data, offset + 1, count - 1);
		return message;
	}

	private static string ToHex(byte[] bytes, int offset)
	{
		int num = bytes.Length - offset;
		StringBuilder stringBuilder = new StringBuilder(bytes.Length * 2);
		for (int i = offset; i < num; i++)
		{
			byte b = bytes[i];
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	internal static string ToHex(byte[] bytes)
	{
		if (bytes == null)
		{
			return null;
		}
		return ToHex(bytes, 0);
	}

	private void SocketConnect(string host, int port)
	{
		IPEndPoint remoteEndpoint = new IPEndPoint(DnsAbstraction.GetHostAddresses(host)[0], port);
		_socket = SocketAbstraction.Connect(remoteEndpoint, ConnectionInfo.Timeout);
		_socket.SendBufferSize = 137072;
		_socket.ReceiveBufferSize = 137072;
	}

	private static int SocketRead(Socket socket, byte[] buffer, int offset, int length)
	{
		int num = SocketAbstraction.Read(socket, buffer, offset, length, InfiniteTimeSpan);
		if (num == 0)
		{
			throw new SshConnectionException("An established connection was aborted by the server.", DisconnectReason.ConnectionLost);
		}
		return num;
	}

	private bool IsSocketConnected()
	{
		lock (_socketDisposeLock)
		{
			if (_socket.IsConnected())
			{
				lock (_socketReadLock)
				{
					return !_socket.Poll(0, SelectMode.SelectRead) || _socket.Available != 0;
				}
			}
			return false;
		}
	}

	private static int TrySocketRead(Socket socket, byte[] buffer, int offset, int length)
	{
		return SocketAbstraction.Read(socket, buffer, offset, length, InfiniteTimeSpan);
	}

	private static string SocketReadLine(Socket socket, TimeSpan timeout)
	{
		Encoding ascii = SshData.Ascii;
		List<byte> list = new List<byte>();
		byte[] array = new byte[1];
		while (SocketAbstraction.Read(socket, array, 0, array.Length, timeout) != 0)
		{
			list.Add(array[0]);
			if (list.Count > 0 && (list[list.Count - 1] == 10 || list[list.Count - 1] == 0))
			{
				break;
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		if (list.Count == 1 && list[list.Count - 1] == 0)
		{
			return string.Empty;
		}
		if (list.Count > 1 && list[list.Count - 2] == 13)
		{
			return ascii.GetString(list.ToArray(), 0, list.Count - 2);
		}
		if (list.Count > 1 && list[list.Count - 1] == 10)
		{
			return ascii.GetString(list.ToArray(), 0, list.Count - 1);
		}
		return ascii.GetString(list.ToArray(), 0, list.Count);
	}

	private void SocketDisconnectAndDispose()
	{
		if (_socket == null)
		{
			return;
		}
		lock (_socketDisposeLock)
		{
			if (_socket == null)
			{
				return;
			}
			if (_socket.Connected)
			{
				try
				{
					_socket.Shutdown(SocketShutdown.Send);
				}
				catch (SocketException)
				{
				}
			}
			_socket.Dispose();
			_socket = null;
		}
	}

	private void MessageListener()
	{
		try
		{
			while (true)
			{
				Socket socket = _socket;
				if (socket == null || !socket.Connected)
				{
					break;
				}
				try
				{
					if (socket.Poll(-1, SelectMode.SelectRead) && socket.Available == 0)
					{
						break;
					}
				}
				catch (ObjectDisposedException)
				{
					break;
				}
				Message message = ReceiveMessage(socket);
				if (message == null)
				{
					break;
				}
				message.Process(this);
			}
			RaiseError(CreateConnectionAbortedByServerException());
		}
		catch (SocketException ex2)
		{
			RaiseError(new SshConnectionException(ex2.Message, DisconnectReason.ConnectionLost, ex2));
		}
		catch (Exception exp)
		{
			RaiseError(exp);
		}
		finally
		{
			_messageListenerCompleted.Set();
		}
	}

	private static byte SocketReadByte(Socket socket)
	{
		byte[] array = new byte[1];
		SocketRead(socket, array, 0, 1);
		return array[0];
	}

	private static void ConnectSocks4(Socket socket, ConnectionInfo connectionInfo)
	{
		byte[] data = CreateSocks4ConnectionRequest(connectionInfo.Host, (ushort)connectionInfo.Port, connectionInfo.ProxyUsername);
		SocketAbstraction.Send(socket, data);
		if (SocketReadByte(socket) != 0)
		{
			throw new ProxyException("SOCKS4: Null is expected.");
		}
		switch (SocketReadByte(socket))
		{
		default:
			throw new ProxyException("SOCKS4: Not valid response.");
		case 91:
			throw new ProxyException("SOCKS4: Connection rejected.");
		case 92:
			throw new ProxyException("SOCKS4: Client is not running identd or not reachable from the server.");
		case 93:
			throw new ProxyException("SOCKS4: Client's identd could not confirm the user ID string in the request.");
		case 90:
		{
			byte[] buffer = new byte[6];
			SocketRead(socket, buffer, 0, 6);
			break;
		}
		}
	}

	private static void ConnectSocks5(Socket socket, ConnectionInfo connectionInfo)
	{
		byte[] data = new byte[4] { 5, 2, 0, 2 };
		SocketAbstraction.Send(socket, data);
		byte b = SocketReadByte(socket);
		if (b != 5)
		{
			throw new ProxyException($"SOCKS Version '{b}' is not supported.");
		}
		switch (SocketReadByte(socket))
		{
		case byte.MaxValue:
			throw new ProxyException("SOCKS5: No acceptable authentication methods were offered.");
		case 2:
		{
			byte[] data2 = CreateSocks5UserNameAndPasswordAuthenticationRequest(connectionInfo.ProxyUsername, connectionInfo.ProxyPassword);
			SocketAbstraction.Send(socket, data2);
			byte[] array = SocketAbstraction.Read(socket, 2, connectionInfo.Timeout);
			if (array[0] != 1)
			{
				throw new ProxyException("SOCKS5: Server authentication version is not valid.");
			}
			if (array[1] != 0)
			{
				throw new ProxyException("SOCKS5: Username/Password authentication failed.");
			}
			break;
		}
		}
		byte[] data3 = CreateSocks5ConnectionRequest(connectionInfo.Host, (ushort)connectionInfo.Port);
		SocketAbstraction.Send(socket, data3);
		if (SocketReadByte(socket) != 5)
		{
			throw new ProxyException("SOCKS5: Version 5 is expected.");
		}
		switch (SocketReadByte(socket))
		{
		default:
			throw new ProxyException("SOCKS5: Not valid response.");
		case 0:
		{
			if (SocketReadByte(socket) != 0)
			{
				throw new ProxyException("SOCKS5: 0 byte is expected.");
			}
			byte b2 = SocketReadByte(socket);
			switch (b2)
			{
			default:
				throw new ProxyException($"Address type '{b2}' is not supported.");
			case 4:
			{
				byte[] buffer2 = new byte[16];
				SocketRead(socket, buffer2, 0, 16);
				break;
			}
			case 1:
			{
				byte[] buffer = new byte[4];
				SocketRead(socket, buffer, 0, 4);
				break;
			}
			}
			byte[] buffer3 = new byte[2];
			SocketRead(socket, buffer3, 0, 2);
			break;
		}
		case 1:
			throw new ProxyException("SOCKS5: General failure.");
		case 2:
			throw new ProxyException("SOCKS5: Connection not allowed by ruleset.");
		case 3:
			throw new ProxyException("SOCKS5: Network unreachable.");
		case 4:
			throw new ProxyException("SOCKS5: Host unreachable.");
		case 5:
			throw new ProxyException("SOCKS5: Connection refused by destination host.");
		case 6:
			throw new ProxyException("SOCKS5: TTL expired.");
		case 7:
			throw new ProxyException("SOCKS5: Command not supported or protocol error.");
		case 8:
			throw new ProxyException("SOCKS5: Address type not supported.");
		}
	}

	private static byte[] CreateSocks5UserNameAndPasswordAuthenticationRequest(string username, string password)
	{
		if (username.Length > 255)
		{
			throw new ProxyException("Proxy username is too long.");
		}
		if (password.Length > 255)
		{
			throw new ProxyException("Proxy password is too long.");
		}
		byte[] array = new byte[2 + username.Length + 1 + password.Length];
		int num = 0;
		num = 1;
		array[0] = 1;
		num = 2;
		array[1] = (byte)username.Length;
		SshData.Ascii.GetBytes(username, 0, username.Length, array, 2);
		num = 2 + username.Length;
		array[num++] = (byte)password.Length;
		SshData.Ascii.GetBytes(password, 0, password.Length, array, num);
		return array;
	}

	private static byte[] CreateSocks4ConnectionRequest(string hostname, ushort port, string username)
	{
		byte[] socks4DestinationAddress = GetSocks4DestinationAddress(hostname);
		byte[] array = new byte[4 + socks4DestinationAddress.Length + username.Length + 1];
		int num = 0;
		num = 1;
		array[0] = 4;
		num = 2;
		array[1] = 1;
		Pack.UInt16ToBigEndian(port, array, 2);
		num = 4;
		Buffer.BlockCopy(socks4DestinationAddress, 0, array, 4, socks4DestinationAddress.Length);
		num = 4 + socks4DestinationAddress.Length;
		array[num] = 0;
		return array;
	}

	private static byte[] CreateSocks5ConnectionRequest(string hostname, ushort port)
	{
		byte addressType;
		byte[] socks5DestinationAddress = GetSocks5DestinationAddress(hostname, out addressType);
		byte[] array = new byte[4 + socks5DestinationAddress.Length + 2];
		int num = 0;
		num = 1;
		array[0] = 5;
		num = 2;
		array[1] = 1;
		num = 3;
		array[2] = 0;
		num = 4;
		array[3] = addressType;
		Buffer.BlockCopy(socks5DestinationAddress, 0, array, 4, socks5DestinationAddress.Length);
		num = 4 + socks5DestinationAddress.Length;
		Pack.UInt16ToBigEndian(port, array, num);
		return array;
	}

	private static byte[] GetSocks4DestinationAddress(string hostname)
	{
		IPAddress[] hostAddresses = DnsAbstraction.GetHostAddresses(hostname);
		int num = 0;
		IPAddress iPAddress;
		while (true)
		{
			if (num < hostAddresses.Length)
			{
				iPAddress = hostAddresses[num];
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					break;
				}
				num++;
				continue;
			}
			throw new ProxyException($"SOCKS4 only supports IPv4. No such address found for '{hostname}'.");
		}
		return iPAddress.GetAddressBytes();
	}

	private static byte[] GetSocks5DestinationAddress(string hostname, out byte addressType)
	{
		IPAddress iPAddress = DnsAbstraction.GetHostAddresses(hostname)[0];
		switch (iPAddress.AddressFamily)
		{
		default:
			throw new ProxyException($"SOCKS5: IP address '{iPAddress}' is not supported.");
		case AddressFamily.InterNetworkV6:
			addressType = 4;
			return iPAddress.GetAddressBytes();
		case AddressFamily.InterNetwork:
			addressType = 1;
			return iPAddress.GetAddressBytes();
		}
	}

	private static void ConnectHttp(Socket socket, ConnectionInfo connectionInfo)
	{
		Regex regex = new Regex("HTTP/(?<version>\\d[.]\\d) (?<statusCode>\\d{3}) (?<reasonPhrase>.+)$");
		Regex regex2 = new Regex("(?<fieldName>[^\\[\\]()<>@,;:\\\"/?={} \\t]+):(?<fieldValue>.+)?");
		SocketAbstraction.Send(socket, SshData.Ascii.GetBytes($"CONNECT {connectionInfo.Host}:{connectionInfo.Port} HTTP/1.0\r\n"));
		if (!string.IsNullOrEmpty(connectionInfo.ProxyUsername))
		{
			string s = $"Proxy-Authorization: Basic {Convert.ToBase64String(SshData.Ascii.GetBytes($"{connectionInfo.ProxyUsername}:{connectionInfo.ProxyPassword}"))}\r\n";
			SocketAbstraction.Send(socket, SshData.Ascii.GetBytes(s));
		}
		SocketAbstraction.Send(socket, SshData.Ascii.GetBytes("\r\n"));
		HttpStatusCode? httpStatusCode = null;
		int num = 0;
		while (true)
		{
			string text = SocketReadLine(socket, connectionInfo.Timeout);
			if (text == null)
			{
				break;
			}
			if (!httpStatusCode.HasValue)
			{
				Match match = regex.Match(text);
				if (match.Success)
				{
					string text2 = match.Result("${statusCode}");
					httpStatusCode = (HttpStatusCode)int.Parse(text2);
					if (httpStatusCode != HttpStatusCode.OK)
					{
						string arg = match.Result("${reasonPhrase}");
						throw new ProxyException($"HTTP: Status code {text2}, \"{arg}\"");
					}
				}
				continue;
			}
			Match match2 = regex2.Match(text);
			if (match2.Success)
			{
				if (match2.Result("${fieldName}").Equals("Content-Length", StringComparison.OrdinalIgnoreCase))
				{
					num = int.Parse(match2.Result("${fieldValue}"));
				}
			}
			else if (text.Length == 0)
			{
				if (num > 0)
				{
					byte[] buffer = new byte[num];
					SocketRead(socket, buffer, 0, num);
				}
				break;
			}
		}
		if (!httpStatusCode.HasValue)
		{
			throw new ProxyException("HTTP response does not contain status line.");
		}
	}

	private void RaiseError(Exception exp)
	{
		SshConnectionException ex = exp as SshConnectionException;
		if (!_isDisconnecting || (ex == null && (!(exp is SocketException ex2) || ex2.SocketErrorCode != SocketError.TimedOut)))
		{
			_exception = exp;
			_exceptionWaitHandle.Set();
			this.ErrorOccured?.Invoke(this, new ExceptionEventArgs(exp));
			if (ex != null)
			{
				Disconnect(ex.DisconnectReason, exp.ToString());
			}
		}
	}

	private void Reset()
	{
		if (_exceptionWaitHandle != null)
		{
			_exceptionWaitHandle.Reset();
		}
		if (_keyExchangeCompletedWaitHandle != null)
		{
			_keyExchangeCompletedWaitHandle.Reset();
		}
		if (_messageListenerCompleted != null)
		{
			_messageListenerCompleted.Set();
		}
		SessionId = null;
		_isDisconnectMessageSent = false;
		_isDisconnecting = false;
		_isAuthenticated = false;
		_exception = null;
		_keyExchangeInProgress = false;
	}

	private static SshConnectionException CreateConnectionAbortedByServerException()
	{
		return new SshConnectionException("An established connection was aborted by the server.", DisconnectReason.ConnectionLost);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed && disposing)
		{
			Disconnect();
			EventWaitHandle serviceAccepted = _serviceAccepted;
			if (serviceAccepted != null)
			{
				serviceAccepted.Dispose();
				_serviceAccepted = null;
			}
			EventWaitHandle exceptionWaitHandle = _exceptionWaitHandle;
			if (exceptionWaitHandle != null)
			{
				exceptionWaitHandle.Dispose();
				_exceptionWaitHandle = null;
			}
			EventWaitHandle keyExchangeCompletedWaitHandle = _keyExchangeCompletedWaitHandle;
			if (keyExchangeCompletedWaitHandle != null)
			{
				keyExchangeCompletedWaitHandle.Dispose();
				_keyExchangeCompletedWaitHandle = null;
			}
			HashAlgorithm serverMac = _serverMac;
			if (serverMac != null)
			{
				serverMac.Dispose();
				_serverMac = null;
			}
			HashAlgorithm clientMac = _clientMac;
			if (clientMac != null)
			{
				clientMac.Dispose();
				_clientMac = null;
			}
			IKeyExchange keyExchange = _keyExchange;
			if (keyExchange != null)
			{
				keyExchange.HostKeyReceived -= KeyExchange_HostKeyReceived;
				keyExchange.Dispose();
				_keyExchange = null;
			}
			EventWaitHandle messageListenerCompleted = _messageListenerCompleted;
			if (messageListenerCompleted != null)
			{
				messageListenerCompleted.Dispose();
				_messageListenerCompleted = null;
			}
			_disposed = true;
		}
	}

	~Session()
	{
		Dispose(disposing: false);
	}

	IChannelSession ISession.CreateChannelSession()
	{
		return new ChannelSession(this, NextChannelNumber, 2147483647u, 65536u);
	}

	IChannelDirectTcpip ISession.CreateChannelDirectTcpip()
	{
		return new ChannelDirectTcpip(this, NextChannelNumber, 2147483647u, 65536u);
	}

	IChannelForwardedTcpip ISession.CreateChannelForwardedTcpip(uint remoteChannelNumber, uint remoteWindowSize, uint remoteChannelDataPacketSize)
	{
		return new ChannelForwardedTcpip(this, NextChannelNumber, 2147483647u, 65536u, remoteChannelNumber, remoteWindowSize, remoteChannelDataPacketSize);
	}

	void ISession.SendMessage(Message message)
	{
		SendMessage(message);
	}

	bool ISession.TrySendMessage(Message message)
	{
		return TrySendMessage(message);
	}
}
