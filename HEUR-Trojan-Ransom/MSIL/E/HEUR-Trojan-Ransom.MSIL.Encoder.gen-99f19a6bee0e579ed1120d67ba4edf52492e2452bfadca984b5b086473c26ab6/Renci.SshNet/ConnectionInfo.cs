using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Authentication;
using Renci.SshNet.Messages.Connection;
using Renci.SshNet.Security;
using Renci.SshNet.Security.Cryptography.Ciphers;
using Renci.SshNet.Security.Cryptography.Ciphers.Modes;

namespace Renci.SshNet;

public class ConnectionInfo : IConnectionInfoInternal, IConnectionInfo
{
	internal static int DefaultPort = 22;

	public IDictionary<string, Type> KeyExchangeAlgorithms { get; private set; }

	public IDictionary<string, CipherInfo> Encryptions { get; private set; }

	public IDictionary<string, HashInfo> HmacAlgorithms { get; private set; }

	public IDictionary<string, Func<byte[], KeyHostAlgorithm>> HostKeyAlgorithms { get; private set; }

	public IList<AuthenticationMethod> AuthenticationMethods { get; private set; }

	public IDictionary<string, Type> CompressionAlgorithms { get; private set; }

	public IDictionary<string, RequestInfo> ChannelRequests { get; private set; }

	public bool IsAuthenticated { get; private set; }

	public string Host { get; private set; }

	public int Port { get; private set; }

	public string Username { get; private set; }

	public ProxyTypes ProxyType { get; private set; }

	public string ProxyHost { get; private set; }

	public int ProxyPort { get; private set; }

	public string ProxyUsername { get; private set; }

	public string ProxyPassword { get; private set; }

	public TimeSpan Timeout { get; set; }

	public Encoding Encoding { get; set; }

	public int RetryAttempts { get; set; }

	public int MaxSessions { get; set; }

	public string CurrentKeyExchangeAlgorithm { get; internal set; }

	public string CurrentServerEncryption { get; internal set; }

	public string CurrentClientEncryption { get; internal set; }

	public string CurrentServerHmacAlgorithm { get; internal set; }

	public string CurrentClientHmacAlgorithm { get; internal set; }

	public string CurrentHostKeyAlgorithm { get; internal set; }

	public string CurrentServerCompressionAlgorithm { get; internal set; }

	public string ServerVersion { get; internal set; }

	public string ClientVersion { get; internal set; }

	public string CurrentClientCompressionAlgorithm { get; internal set; }

	IList<IAuthenticationMethod> IConnectionInfoInternal.AuthenticationMethods => AuthenticationMethods.Cast<IAuthenticationMethod>().ToList();

	public event EventHandler<AuthenticationBannerEventArgs> AuthenticationBanner;

	public ConnectionInfo(string host, string username, params AuthenticationMethod[] authenticationMethods)
		: this(host, DefaultPort, username, ProxyTypes.None, null, 0, null, null, authenticationMethods)
	{
	}

	public ConnectionInfo(string host, int port, string username, params AuthenticationMethod[] authenticationMethods)
		: this(host, port, username, ProxyTypes.None, null, 0, null, null, authenticationMethods)
	{
	}

	public ConnectionInfo(string host, int port, string username, ProxyTypes proxyType, string proxyHost, int proxyPort, string proxyUsername, string proxyPassword, params AuthenticationMethod[] authenticationMethods)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		port.ValidatePort("port");
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		if (username.All(char.IsWhiteSpace))
		{
			throw new ArgumentException("Cannot be empty or contain only whitespace.", "username");
		}
		if (proxyType != 0)
		{
			if (proxyHost == null)
			{
				throw new ArgumentNullException("proxyHost");
			}
			proxyPort.ValidatePort("proxyPort");
		}
		if (authenticationMethods == null)
		{
			throw new ArgumentNullException("authenticationMethods");
		}
		if (authenticationMethods.Length == 0)
		{
			throw new ArgumentException("At least one authentication method should be specified.", "authenticationMethods");
		}
		Timeout = TimeSpan.FromSeconds(30.0);
		RetryAttempts = 10;
		MaxSessions = 10;
		Encoding = Encoding.UTF8;
		KeyExchangeAlgorithms = new Dictionary<string, Type>
		{
			{
				"diffie-hellman-group-exchange-sha256",
				typeof(KeyExchangeDiffieHellmanGroupExchangeSha256)
			},
			{
				"diffie-hellman-group-exchange-sha1",
				typeof(KeyExchangeDiffieHellmanGroupExchangeSha1)
			},
			{
				"diffie-hellman-group14-sha1",
				typeof(KeyExchangeDiffieHellmanGroup14Sha1)
			},
			{
				"diffie-hellman-group1-sha1",
				typeof(KeyExchangeDiffieHellmanGroup1Sha1)
			}
		};
		Encryptions = new Dictionary<string, CipherInfo>
		{
			{
				"aes256-ctr",
				new CipherInfo(256, (byte[] key, byte[] iv) => new AesCipher(key, new CtrCipherMode(iv), null))
			},
			{
				"3des-cbc",
				new CipherInfo(192, (byte[] key, byte[] iv) => new TripleDesCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"aes128-cbc",
				new CipherInfo(128, (byte[] key, byte[] iv) => new AesCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"aes192-cbc",
				new CipherInfo(192, (byte[] key, byte[] iv) => new AesCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"aes256-cbc",
				new CipherInfo(256, (byte[] key, byte[] iv) => new AesCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"blowfish-cbc",
				new CipherInfo(128, (byte[] key, byte[] iv) => new BlowfishCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"twofish-cbc",
				new CipherInfo(256, (byte[] key, byte[] iv) => new TwofishCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"twofish192-cbc",
				new CipherInfo(192, (byte[] key, byte[] iv) => new TwofishCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"twofish128-cbc",
				new CipherInfo(128, (byte[] key, byte[] iv) => new TwofishCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"twofish256-cbc",
				new CipherInfo(256, (byte[] key, byte[] iv) => new TwofishCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"arcfour",
				new CipherInfo(128, (byte[] key, byte[] iv) => new Arc4Cipher(key, dischargeFirstBytes: false))
			},
			{
				"arcfour128",
				new CipherInfo(128, (byte[] key, byte[] iv) => new Arc4Cipher(key, dischargeFirstBytes: true))
			},
			{
				"arcfour256",
				new CipherInfo(256, (byte[] key, byte[] iv) => new Arc4Cipher(key, dischargeFirstBytes: true))
			},
			{
				"cast128-cbc",
				new CipherInfo(128, (byte[] key, byte[] iv) => new CastCipher(key, new CbcCipherMode(iv), null))
			},
			{
				"aes128-ctr",
				new CipherInfo(128, (byte[] key, byte[] iv) => new AesCipher(key, new CtrCipherMode(iv), null))
			},
			{
				"aes192-ctr",
				new CipherInfo(192, (byte[] key, byte[] iv) => new AesCipher(key, new CtrCipherMode(iv), null))
			}
		};
		HmacAlgorithms = new Dictionary<string, HashInfo>
		{
			{
				"hmac-md5",
				new HashInfo(128, CryptoAbstraction.CreateHMACMD5)
			},
			{
				"hmac-md5-96",
				new HashInfo(128, (byte[] key) => CryptoAbstraction.CreateHMACMD5(key, 96))
			},
			{
				"hmac-sha1",
				new HashInfo(160, CryptoAbstraction.CreateHMACSHA1)
			},
			{
				"hmac-sha1-96",
				new HashInfo(160, (byte[] key) => CryptoAbstraction.CreateHMACSHA1(key, 96))
			},
			{
				"hmac-sha2-256",
				new HashInfo(256, CryptoAbstraction.CreateHMACSHA256)
			},
			{
				"hmac-sha2-256-96",
				new HashInfo(256, (byte[] key) => CryptoAbstraction.CreateHMACSHA256(key, 96))
			},
			{
				"hmac-sha2-512",
				new HashInfo(512, CryptoAbstraction.CreateHMACSHA512)
			},
			{
				"hmac-sha2-512-96",
				new HashInfo(512, (byte[] key) => CryptoAbstraction.CreateHMACSHA512(key, 96))
			},
			{
				"hmac-ripemd160",
				new HashInfo(160, CryptoAbstraction.CreateHMACRIPEMD160)
			},
			{
				"hmac-ripemd160@openssh.com",
				new HashInfo(160, CryptoAbstraction.CreateHMACRIPEMD160)
			}
		};
		HostKeyAlgorithms = new Dictionary<string, Func<byte[], KeyHostAlgorithm>>
		{
			{
				"ssh-rsa",
				(byte[] data) => new KeyHostAlgorithm("ssh-rsa", new RsaKey(), data)
			},
			{
				"ssh-dss",
				(byte[] data) => new KeyHostAlgorithm("ssh-dss", new DsaKey(), data)
			}
		};
		CompressionAlgorithms = new Dictionary<string, Type> { { "none", null } };
		ChannelRequests = new Dictionary<string, RequestInfo>
		{
			{
				"env",
				new EnvironmentVariableRequestInfo()
			},
			{
				"exec",
				new ExecRequestInfo()
			},
			{
				"exit-signal",
				new ExitSignalRequestInfo()
			},
			{
				"exit-status",
				new ExitStatusRequestInfo()
			},
			{
				"pty-req",
				new PseudoTerminalRequestInfo()
			},
			{
				"shell",
				new ShellRequestInfo()
			},
			{
				"signal",
				new SignalRequestInfo()
			},
			{
				"subsystem",
				new SubsystemRequestInfo()
			},
			{
				"window-change",
				new WindowChangeRequestInfo()
			},
			{
				"x11-req",
				new X11ForwardingRequestInfo()
			},
			{
				"xon-xoff",
				new XonXoffRequestInfo()
			},
			{
				"eow@openssh.com",
				new EndOfWriteRequestInfo()
			},
			{
				"keepalive@openssh.com",
				new KeepAliveRequestInfo()
			}
		};
		Host = host;
		Port = port;
		Username = username;
		ProxyType = proxyType;
		ProxyHost = proxyHost;
		ProxyPort = proxyPort;
		ProxyUsername = proxyUsername;
		ProxyPassword = proxyPassword;
		AuthenticationMethods = authenticationMethods;
	}

	internal void Authenticate(ISession session, IServiceFactory serviceFactory)
	{
		if (serviceFactory == null)
		{
			throw new ArgumentNullException("serviceFactory");
		}
		IsAuthenticated = false;
		serviceFactory.CreateClientAuthentication().Authenticate(this, session);
		IsAuthenticated = true;
	}

	void IConnectionInfoInternal.UserAuthenticationBannerReceived(object sender, MessageEventArgs<BannerMessage> e)
	{
		this.AuthenticationBanner?.Invoke(this, new AuthenticationBannerEventArgs(Username, e.Message.Message, e.Message.Language));
	}

	IAuthenticationMethod IConnectionInfoInternal.CreateNoneAuthenticationMethod()
	{
		return new NoneAuthenticationMethod(Username);
	}
}
