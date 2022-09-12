using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MySql.Data.MySqlClient;

public abstract class MySqlBaseConnectionStringBuilder : DbConnectionStringBuilder
{
	internal Dictionary<string, object> values = new Dictionary<string, object>();

	internal static readonly MySqlConnectionStringOptionCollection Options;

	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[Description("Server to connect to")]
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

	[Description("Database to use initially")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
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

	[RefreshProperties(RefreshProperties.All)]
	[Description("Port to use for TCP/IP connections")]
	[Category("Connection")]
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

	[RefreshProperties(RefreshProperties.All)]
	[Description("Indicates the user ID to be used when connecting to the data source.")]
	[Category("Security")]
	[DisplayName("User ID")]
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

	[Category("Security")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Indicates the password to be used when connecting to the data source.")]
	[PasswordPropertyText(true)]
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

	[Description("Certificate file in PKCS#12 format (.pfx)")]
	[Category("Authentication")]
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

	[Category("Authentication")]
	[Description("Password for certificate file")]
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

	[Description("Certificate Store Location for client certificates")]
	[DefaultValue(MySqlCertificateStoreLocation.None)]
	[Category("Authentication")]
	[DisplayName("Certificate Store Location")]
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

	[Description("SSL properties for connection.")]
	[DefaultValue(MySqlSslMode.None)]
	[Category("Security")]
	[DisplayName("Ssl Mode")]
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

	[DisplayName("Character Set")]
	[Category("Advanced")]
	[DefaultValue("")]
	[RefreshProperties(RefreshProperties.All)]
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

	[Description("Path to a local file that contains a list of trusted TLS/SSL CAs")]
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

	[Description("Name of the SSL key file in PEM format to use for establishing an encrypted connection.")]
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

	[Description("Name of the SSL certificate file in PEM format to use for establishing an encrypted connection.")]
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

	internal bool HasProcAccess { get; set; }

	public override object this[string keyword]
	{
		get
		{
			MySqlConnectionStringOption option = GetOption(keyword);
			return option.BaseGetter(this, option);
		}
		set
		{
			MySqlConnectionStringOption option = GetOption(keyword);
			option.BaseSetter(this, option, value);
		}
	}

	static MySqlBaseConnectionStringBuilder()
	{
		Options = new MySqlConnectionStringOptionCollection();
		Options.Add(new MySqlConnectionStringOption("server", "host,data source,datasource,address,addr,network address", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("database", "initial catalog", typeof(string), string.Empty, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("protocol", "connection protocol, connectionprotocol", typeof(MySqlConnectionProtocol), MySqlConnectionProtocol.Sockets, obsolete: false, delegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("protocol", value, ".cctor");
		}, (MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConnectionProtocol));
		Options.Add(new MySqlConnectionStringOption("port", null, typeof(uint), 3306u, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("user id", "uid,username,user name,user,userid", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("password", "pwd", typeof(string), "", obsolete: false));
		Options.Add(new MySqlConnectionStringOption("certificatefile", "certificate file", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("certificatepassword", "certificate password,ssl-ca-pwd", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("certificatestorelocation", "certificate store location", typeof(MySqlCertificateStoreLocation), MySqlCertificateStoreLocation.None, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("certificatethumbprint", "certificate thumb print", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sslmode", "ssl mode,ssl-mode", typeof(MySqlSslMode), MySqlSslMode.Preferred, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sslca", "ssl-ca", typeof(string), null, obsolete: false, delegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SslCa = value as string;
		}, (MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SslCa));
		Options.Add(new MySqlConnectionStringOption("sslkey", "ssl-key", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("sslcert", "ssl-cert", typeof(string), null, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("keepalive", "keep alive", typeof(uint), 0u, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("characterset", "character set,charset", typeof(string), "", obsolete: false));
	}

	public MySqlBaseConnectionStringBuilder()
	{
		HasProcAccess = true;
		lock (this)
		{
			foreach (MySqlConnectionStringOption option in Options.Options)
			{
				values[option.Keyword] = option.DefaultValue;
			}
		}
	}

	public MySqlBaseConnectionStringBuilder(string connStr, bool isXProtocol)
		: this()
	{
		AnalyzeConnectionString(connStr, isXProtocol);
		lock (this)
		{
			base.ConnectionString = connStr;
		}
	}

	public override void Clear()
	{
		base.Clear();
		lock (this)
		{
			foreach (MySqlConnectionStringOption option in Options.Options)
			{
				if (option.DefaultValue != null)
				{
					values[option.Keyword] = option.DefaultValue;
				}
				else
				{
					values[option.Keyword] = null;
				}
			}
		}
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

	internal void SetInternalValue(string keyword, object value)
	{
		MySqlConnectionStringOption option = GetOption(keyword);
		option.ValidateValue(ref value);
		option.Clean(this);
		if (value != null)
		{
			lock (this)
			{
				values[option.Keyword] = value;
				base[keyword] = value;
			}
		}
	}

	internal MySqlConnectionStringOption GetOption(string key)
	{
		MySqlConnectionStringOption mySqlConnectionStringOption = Options.Get(key);
		if (mySqlConnectionStringOption == null)
		{
			throw new ArgumentException(Resources.KeywordNotSupported, key);
		}
		return mySqlConnectionStringOption;
	}

	public override bool ContainsKey(string keyword)
	{
		return Options.Get(keyword) != null;
	}

	public override bool Remove(string keyword)
	{
		bool flag = false;
		lock (this)
		{
			flag = base.Remove(keyword);
		}
		if (!flag)
		{
			return false;
		}
		MySqlConnectionStringOption option = GetOption(keyword);
		lock (this)
		{
			values[option.Keyword] = option.DefaultValue;
		}
		return true;
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

	public override bool Equals(object obj)
	{
		MySqlBaseConnectionStringBuilder mySqlBaseConnectionStringBuilder = obj as MySqlBaseConnectionStringBuilder;
		if (obj == null)
		{
			return false;
		}
		if (values.Count != mySqlBaseConnectionStringBuilder.values.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, object> value in values)
		{
			if (mySqlBaseConnectionStringBuilder.values.ContainsKey(value.Key))
			{
				object obj2 = mySqlBaseConnectionStringBuilder.values[value.Key];
				if (obj2 != null || value.Value == null)
				{
					if (value.Value != null || obj2 == null)
					{
						if (value.Value != null || obj2 != null)
						{
							if (!obj2.Equals(value.Value))
							{
								return false;
							}
							continue;
						}
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	internal void AnalyzeConnectionString(string connectionString, bool isXProtocol)
	{
		string[] array = connectionString.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
		List<string> list = new List<string>();
		bool flag = false;
		string[] array2 = array;
		int num = 0;
		string[] array3;
		while (true)
		{
			if (num >= array2.Length)
			{
				return;
			}
			string obj = array2[num];
			array3 = obj.Split(new char[1] { '=' });
			if (array3.Length % 2 == 0)
			{
				string keyword = array3[0].ToLowerInvariant().Trim();
				string text = array3[1].ToLowerInvariant();
				MySqlConnectionStringOption mySqlConnectionStringOption = Options.Options.Where((MySqlConnectionStringOption o) => o.Keyword == keyword || (o.Synonyms != null && o.Synonyms.Contains(keyword))).FirstOrDefault();
				if (mySqlConnectionStringOption != null && (!(mySqlConnectionStringOption.Keyword != "sslmode") || !(mySqlConnectionStringOption.Keyword != "certificatefile") || !(mySqlConnectionStringOption.Keyword != "certificatepassword") || !(mySqlConnectionStringOption.Keyword != "sslcrl") || !(mySqlConnectionStringOption.Keyword != "sslca") || !(mySqlConnectionStringOption.Keyword != "sslcert") || !(mySqlConnectionStringOption.Keyword != "sslkey")))
				{
					if (list.Contains(mySqlConnectionStringOption.Keyword))
					{
						throw new ArgumentException(string.Format(Resources.DuplicatedSslConnectionOption, keyword));
					}
					if (mySqlConnectionStringOption.Keyword == "sslmode" && (text == "none" || text == "disabled"))
					{
						flag = true;
					}
					if (flag && (mySqlConnectionStringOption.Keyword == "certificatefile" || mySqlConnectionStringOption.Keyword == "certificatepassword" || mySqlConnectionStringOption.Keyword == "sslcrl" || mySqlConnectionStringOption.Keyword == "sslca" || mySqlConnectionStringOption.Keyword == "sslcert" || mySqlConnectionStringOption.Keyword == "sslkey"))
					{
						throw new ArgumentException(Resources.InvalidOptionWhenSslDisabled);
					}
					if (isXProtocol && mySqlConnectionStringOption.Keyword == "sslmode" && (text == "preferred" || text == "prefered"))
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
}
