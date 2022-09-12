using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using MySql.Data.common;

namespace MySql.Data.MySqlClient;

public abstract class MySqlBaseConnectionStringBuilder : DbConnectionStringBuilder
{
	internal static readonly MySqlConnectionStringOptionCollection Options;

	internal bool HasProcAccess { get; set; }

	internal Dictionary<string, object> values { get; set; }

	[Category("Connection")]
	[Description("Server to connect to")]
	[RefreshProperties(RefreshProperties.All)]
	public string Server
	{
		get
		{
			return this["server"] as string;
		}
		set
		{
			SetValue("server", value, "Server");
		}
	}

	[Category("Connection")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Database to use initially")]
	public string Database
	{
		get
		{
			return values["database"] as string;
		}
		set
		{
			SetValue("database", value, "Database");
		}
	}

	[DisplayName("Connection Protocol")]
	[Description("Protocol to use for connection to MySQL")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	public MySqlConnectionProtocol ConnectionProtocol
	{
		get
		{
			return (MySqlConnectionProtocol)values["protocol"];
		}
		set
		{
			SetValue("protocol", value, "ConnectionProtocol");
		}
	}

	[Category("Connection")]
	[Description("Port to use for TCP/IP connections")]
	[RefreshProperties(RefreshProperties.All)]
	public uint Port
	{
		get
		{
			return (uint)values["port"];
		}
		set
		{
			SetValue("port", value, "Port");
		}
	}

	[Description("The connection should resolve DNS SRV records.")]
	[Category("Connection")]
	[DisplayName("DNS SRV")]
	[RefreshProperties(RefreshProperties.All)]
	public bool DnsSrv
	{
		get
		{
			return (bool)values["dns-srv"];
		}
		set
		{
			SetValue("dns-srv", value, "DnsSrv");
		}
	}

	[DisplayName("User ID")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Indicates the user ID to be used when connecting to the data source.")]
	[Category("Security")]
	public string UserID
	{
		get
		{
			return (string)values["user id"];
		}
		set
		{
			SetValue("user id", value, "UserID");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Description("Indicates the password to be used when connecting to the data source.")]
	[PasswordPropertyText(true)]
	[Category("Security")]
	public string Password
	{
		get
		{
			return (string)values["password"];
		}
		set
		{
			SetValue("password", value, "Password");
		}
	}

	[Category("Authentication")]
	[Description("Certificate file in PKCS#12 format (.pfx) or path to a local file that contains a list of trusted TLS/SSL CAs (.pem).")]
	[DisplayName("Certificate File")]
	public string CertificateFile
	{
		get
		{
			return (string)values["certificatefile"];
		}
		set
		{
			SetValue("certificatefile", value, "CertificateFile");
		}
	}

	[Description("Password for certificate file")]
	[Category("Authentication")]
	[DisplayName("Certificate Password")]
	public string CertificatePassword
	{
		get
		{
			return (string)values["certificatepassword"];
		}
		set
		{
			SetValue("certificatepassword", value, "CertificatePassword");
		}
	}

	[DefaultValue(MySqlCertificateStoreLocation.None)]
	[Category("Authentication")]
	[DisplayName("Certificate Store Location")]
	[Description("Certificate Store Location for client certificates")]
	public MySqlCertificateStoreLocation CertificateStoreLocation
	{
		get
		{
			return (MySqlCertificateStoreLocation)values["certificatestorelocation"];
		}
		set
		{
			SetValue("certificatestorelocation", value, "CertificateStoreLocation");
		}
	}

	[DisplayName("Certificate Thumbprint")]
	[Category("Authentication")]
	[Description("Certificate thumbprint. Can be used together with Certificate Store Location parameter to uniquely identify the certificate to be used for SSL authentication.")]
	public string CertificateThumbprint
	{
		get
		{
			return (string)values["certificatethumbprint"];
		}
		set
		{
			SetValue("certificatethumbprint", value, "CertificateThumbprint");
		}
	}

	[Category("Authentication")]
	[DisplayName("Ssl Mode")]
	[DefaultValue(MySqlSslMode.None)]
	[Description("SSL properties for connection.")]
	public MySqlSslMode SslMode
	{
		get
		{
			return (MySqlSslMode)values["sslmode"];
		}
		set
		{
			SetValue("sslmode", value, "SslMode");
		}
	}

	[Description("Path to a local file that contains a list of trusted TLS/SSL CAs.")]
	[Category("Authentication")]
	[DisplayName("Ssl Ca")]
	public string SslCa
	{
		get
		{
			return CertificateFile;
		}
		set
		{
			CertificateFile = value;
		}
	}

	[Category("Security")]
	[DisplayName("TLS version")]
	[Description("TLS versions to use in a SSL connection to the server.")]
	public string TlsVersion
	{
		get
		{
			return (string)values["tlsversion"];
		}
		set
		{
			SetValue("tlsversion", value, "TlsVersion");
		}
	}

	[Description("Name of the SSL key file in PEM format to use for establishing an encrypted connection.")]
	[Category("Authentication")]
	[DisplayName("Ssl Key")]
	public string SslKey
	{
		get
		{
			return (string)values["sslkey"];
		}
		set
		{
			SetValue("sslkey", value, "SslKey");
		}
	}

	[Category("Authentication")]
	[Description("Name of the SSL certificate file in PEM format to use for establishing an encrypted connection.")]
	[DisplayName("Ssl Cert")]
	public string SslCert
	{
		get
		{
			return (string)values["sslcert"];
		}
		set
		{
			SetValue("sslcert", value, "SslCert");
		}
	}

	[Description("The name of the SSH server.")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("SSH")]
	[DisplayName("SSH Host Name")]
	public string SshHostName
	{
		get
		{
			return (string)values["sshhostname"];
		}
		set
		{
			SetValue("sshhostname", value, "SshHostName");
		}
	}

	[DisplayName("SSH Port")]
	[Description("Port used to establish a connection using SSH tunneling.")]
	[Category("SSH")]
	[RefreshProperties(RefreshProperties.All)]
	public uint SshPort
	{
		get
		{
			return (uint)values["sshport"];
		}
		set
		{
			SetValue("sshport", value, "SshPort");
		}
	}

	[Description("Indicates the user name to be used when connecting to the SSH server.")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("SSH User Name")]
	[Category("SSH")]
	public string SshUserName
	{
		get
		{
			return (string)values["sshusername"];
		}
		set
		{
			SetValue("sshusername", value, "SshUserName");
		}
	}

	[Category("SSH")]
	[DisplayName("SSH Password")]
	[PasswordPropertyText(true)]
	[Description("Indicates the password to be used when authenticating to the SSH server.")]
	[RefreshProperties(RefreshProperties.All)]
	public string SshPassword
	{
		get
		{
			return (string)values["sshpassword"];
		}
		set
		{
			SetValue("sshpassword", value, "SshPassword");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("SSH")]
	[DisplayName("SSH Key File")]
	[Description("Indicates the path and name of the SSH key file to be used when authenticating to the SSH server.")]
	public string SshKeyFile
	{
		get
		{
			return (string)values["sshkeyfile"];
		}
		set
		{
			SetValue("sshkeyfile", value, "SshKeyFile");
		}
	}

	[DisplayName("SSH Passphrase")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("SSH")]
	[PasswordPropertyText(true)]
	[Description("Indicates the passphrase associated to the key file to be used when authenticating to the SSH server.")]
	public string SshPassphrase
	{
		get
		{
			return (string)values["sshpassphrase"];
		}
		set
		{
			SetValue("sshpassphrase", value, "SshPassphrase");
		}
	}

	[DefaultValue(0)]
	[DisplayName("Keep Alive")]
	[Description("For TCP connections, the idle connection time (in seconds) before the first keepalive packet is sent.A value of 0 indicates that keepalive is not used.")]
	public uint Keepalive
	{
		get
		{
			return (uint)values["keepalive"];
		}
		set
		{
			SetValue("keepalive", value, "Keepalive");
		}
	}

	[DefaultValue("")]
	[DisplayName("Character Set")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	[Description("Character set this connection should use.")]
	public string CharacterSet
	{
		get
		{
			return (string)values["characterset"];
		}
		set
		{
			SetValue("characterset", value, "CharacterSet");
		}
	}

	static MySqlBaseConnectionStringBuilder()
	{
		Options = new MySqlConnectionStringOptionCollection();
		Options.Add(new MySqlConnectionStringOption("server", "host,data source,datasource,address,addr,network address", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("database", "initial catalog", typeof(string), string.Empty, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("protocol", "connection protocol,connectionprotocol", typeof(MySqlConnectionProtocol), MySqlConnectionProtocol.Sockets, obsolete: false, delegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("protocol", value, ".cctor");
		}, (MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConnectionProtocol));
		Options.Add(new MySqlConnectionStringOption("port", null, typeof(uint), 3306u, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("dns-srv", "dnssrv", typeof(bool), false, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("user id", "uid,username,user name,user,userid", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("password", "pwd", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("certificatefile", "certificate file", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("certificatepassword", "certificate password,ssl-ca-pwd", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("certificatestorelocation", "certificate store location", typeof(MySqlCertificateStoreLocation), MySqlCertificateStoreLocation.None, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("certificatethumbprint", "certificate thumb print", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sslmode", "ssl mode,ssl-mode", typeof(MySqlSslMode), MySqlSslMode.Preferred, obsolete: false, delegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			MySqlSslMode mySqlSslMode = (MySqlSslMode)Enum.Parse(typeof(MySqlSslMode), value.ToString(), ignoreCase: true);
			if (mySqlSslMode == MySqlSslMode.None && msb.TlsVersion != null)
			{
				throw new ArgumentException(Resources.InvalidTlsVersionAndSslModeOption, "TlsVersion");
			}
			msb.SetValue("sslmode", mySqlSslMode, ".cctor");
		}, (MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SslMode));
		Options.Add(new MySqlConnectionStringOption("sslca", "ssl-ca", typeof(string), null, obsolete: false, delegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SslCa = value as string;
		}, (MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SslCa));
		Options.Add(new MySqlConnectionStringOption("sslkey", "ssl-key", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sslcert", "ssl-cert", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("tlsversion", "tls-version,tls version", typeof(string), null, obsolete: false, delegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			if (value != null && !string.IsNullOrWhiteSpace((string)value))
			{
				if (msb.SslMode == MySqlSslMode.None)
				{
					throw new ArgumentException(Resources.InvalidTlsVersionAndSslModeOption, "TlsVersion");
				}
				string text = ((string)value).TrimStart('[', '(').TrimEnd(']', ')').Replace(" ", string.Empty);
				if (!string.IsNullOrWhiteSpace(text) && !(text == ","))
				{
					SslProtocols sslProtocols = SslProtocols.None;
					string[] array = text.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
					int num = 0;
					string text3;
					while (true)
					{
						if (num >= array.Length)
						{
							string text2 = ((sslProtocols == SslProtocols.None) ? string.Empty : Enum.Format(typeof(SslProtocols), sslProtocols, "G"));
							text2 = ((value.ToString()!.Equals("Tls13", StringComparison.OrdinalIgnoreCase) || value.ToString()!.Equals("Tlsv1.3", StringComparison.OrdinalIgnoreCase)) ? "Tls13" : text2);
							msb.SetValue("tlsversion", text2, ".cctor");
							return;
						}
						text3 = array[num];
						string text4 = text3.ToLowerInvariant().Replace("v", "").Replace(".", "");
						if (text4.Equals("tls1") || text4.Equals("tls10"))
						{
							text4 = "tls";
						}
						if (!text4.StartsWith("tls", StringComparison.OrdinalIgnoreCase) || (!Enum.TryParse<SslProtocols>(text4, ignoreCase: true, out var result) && !text4.Equals("tls13", StringComparison.OrdinalIgnoreCase)))
						{
							break;
						}
						sslProtocols |= result;
						num++;
					}
					string empty = string.Empty;
					throw new ArgumentException(string.Format(Resources.InvalidTlsVersionOption, text3, empty), "TlsVersion");
				}
				throw new ArgumentException(Resources.TlsVersionNotSupported);
			}
			msb.SetValue("tlsversion", null, ".cctor");
		}, (MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.TlsVersion));
		Options.Add(new MySqlConnectionStringOption("sshhostname", "ssh host name,ssh-host-name", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sshport", "ssh port,ssh-port", typeof(uint), 22u, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sshusername", "ssh user name,ssh-user-name", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sshpassword", "ssh password,ssh-password", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sshkeyfile", "ssh key file,ssh-key-file", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sshpassphrase", "ssh pass phrase,ssh-pass-phrase", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("keepalive", "keep alive", typeof(uint), 0u, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("characterset", "character set,charset", typeof(string), "", obsolete: false));
	}

	internal void AnalyzeConnectionString(string connectionString, bool isXProtocol, bool isDefaultPort = true)
	{
		string[] array = connectionString.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
		List<string> list = new List<string>();
		bool flag = false;
		bool flag2 = false;
		if (array.FirstOrDefault((string q) => q.ToLowerInvariant().Contains("dns-srv=true")) != null || array.FirstOrDefault((string q) => q.ToLowerInvariant().Contains("dnssrv=true")) != null)
		{
			flag2 = true;
		}
		string[] array2 = array;
		int num = 0;
		string[] array3;
		while (true)
		{
			if (num >= array2.Length)
			{
				return;
			}
			string text = array2[num];
			array3 = text.Split(new char[1] { '=' });
			if (array3.Length % 2 == 0)
			{
				string keyword = array3[0].ToLowerInvariant().Trim();
				string text2 = (text.Contains(",") ? text.Replace(keyword, "") : array3[1].ToLowerInvariant());
				MySqlConnectionStringOption mySqlConnectionStringOption = Options.Options.Where((MySqlConnectionStringOption o) => o.Keyword == keyword || (o.Synonyms != null && o.Synonyms.Contains(keyword))).FirstOrDefault();
				if (flag2)
				{
					if (mySqlConnectionStringOption.Keyword == "port" && !isDefaultPort)
					{
						throw new ArgumentException(Resources.DnsSrvInvalidConnOptionPort);
					}
					if (mySqlConnectionStringOption.Keyword == "server" && ((text2.Contains("address") && text2.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries).Length > 2) || text2.Contains(",")))
					{
						throw new ArgumentException(Resources.DnsSrvInvalidConnOptionMultihost);
					}
					if (mySqlConnectionStringOption.Keyword == "protocol" && (text2.ToLowerInvariant().Contains("unix") || text2.ToLowerInvariant().Contains("unixsocket")))
					{
						throw new ArgumentException(Resources.DnsSrvInvalidConnOptionUnixSocket);
					}
				}
				if (mySqlConnectionStringOption != null && (!(mySqlConnectionStringOption.Keyword != "sslmode") || !(mySqlConnectionStringOption.Keyword != "certificatefile") || !(mySqlConnectionStringOption.Keyword != "certificatepassword") || !(mySqlConnectionStringOption.Keyword != "sslcrl") || !(mySqlConnectionStringOption.Keyword != "sslca") || !(mySqlConnectionStringOption.Keyword != "sslcert") || !(mySqlConnectionStringOption.Keyword != "sslkey") || !(mySqlConnectionStringOption.Keyword != "server") || !(mySqlConnectionStringOption.Keyword != "tlsversion") || !(mySqlConnectionStringOption.Keyword != "dns-srv")))
				{
					if (list.Contains(mySqlConnectionStringOption.Keyword) && mySqlConnectionStringOption.Keyword != "server" && mySqlConnectionStringOption.Keyword != "tlsversion" && mySqlConnectionStringOption.Keyword != "dns-srv")
					{
						throw new ArgumentException(string.Format(Resources.DuplicatedSslConnectionOption, keyword));
					}
					if (list.Contains(mySqlConnectionStringOption.Keyword))
					{
						throw new ArgumentException(string.Format(Resources.DuplicatedConnectionOption, keyword));
					}
					if (mySqlConnectionStringOption.Keyword == "sslmode" && (text2 == "none" || text2 == "disabled"))
					{
						flag = true;
					}
					if (flag && (mySqlConnectionStringOption.Keyword == "certificatefile" || mySqlConnectionStringOption.Keyword == "certificatepassword" || mySqlConnectionStringOption.Keyword == "sslcrl" || mySqlConnectionStringOption.Keyword == "sslca" || mySqlConnectionStringOption.Keyword == "sslcert" || mySqlConnectionStringOption.Keyword == "sslkey"))
					{
						throw new ArgumentException(Resources.InvalidOptionWhenSslDisabled);
					}
					if (isXProtocol && mySqlConnectionStringOption.Keyword == "sslmode" && (text2 == "preferred" || text2 == "prefered"))
					{
						break;
					}
					if (!(mySqlConnectionStringOption.Keyword == "sslca") && !(mySqlConnectionStringOption.Keyword == "certificatefile"))
					{
						list.Add(mySqlConnectionStringOption.Keyword);
					}
					else
					{
						list.Add("sslca");
						list.Add("certificatefile");
					}
				}
			}
			num++;
		}
		throw new ArgumentException(string.Format(Resources.InvalidSslMode, array3[1]));
	}

	public string GetConnectionString(bool includePass)
	{
		if (includePass)
		{
			return base.ConnectionString;
		}
		StringBuilder stringBuilder = new StringBuilder();
		string text = "";
		foreach (string key in Keys)
		{
			if (string.Compare(key, "password", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(key, "pwd", StringComparison.OrdinalIgnoreCase) != 0)
			{
				stringBuilder.AppendFormat(CultureInfo.CurrentCulture, "{0}{1}={2}", new object[3]
				{
					text,
					key,
					this[key]
				});
				text = ";";
			}
		}
		return stringBuilder.ToString();
	}

	internal abstract MySqlConnectionStringOption GetOption(string key);

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	internal bool IsSshEnabled()
	{
		if (!string.IsNullOrEmpty(SshUserName))
		{
			if (string.IsNullOrEmpty(SshKeyFile))
			{
				return !string.IsNullOrEmpty(SshPassword);
			}
			return true;
		}
		return false;
	}

	internal void SetValue(string keyword, object value, [CallerMemberName] string callerName = "")
	{
		MySqlConnectionStringOption option = GetOption(keyword);
		if (callerName != ".cctor" && option.IsCustomized)
		{
			this[keyword] = value;
		}
		else
		{
			SetInternalValue(keyword, value);
		}
	}

	internal abstract void SetInternalValue(string keyword, object value);
}
