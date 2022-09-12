using System;
using System.ComponentModel;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlX.XDevAPI;

public sealed class MySqlXConnectionStringBuilder : MySqlBaseConnectionStringBuilder
{
	[DisplayName("Connect Timeout")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("The length of time (in milliseconds) to wait for a connection to the server before terminating the attempt and generating an error.")]
	[Category("Connection")]
	public uint ConnectTimeout
	{
		get
		{
			return (uint)values["connect-timeout"];
		}
		set
		{
			uint num = Math.Min(value, 2147483647u);
			if (num != value)
			{
				MySqlTrace.LogWarning(-1, "Connection timeout value too large (" + value + " milliseconds). Changed to max. possible value" + num + " milliseconds)");
			}
			SetValue("connect-timeout", num, "ConnectTimeout");
		}
	}

	[DisplayName("Connection Attributes")]
	[Description("Gets or sets a comma-delimited list of key-value pairs (in addition to standard XProtocol predefined keys) to be passed to MySQL Serverfor display as connection attributes.")]
	[Category("Connection")]
	public string ConnectionAttributes
	{
		get
		{
			return (string)values["connection-attributes"];
		}
		set
		{
			SetValue("connection-attributes", value, "ConnectionAttributes");
		}
	}

	[Category("Authentication")]
	[Description("Authentication mechanism")]
	[DisplayName("Auth")]
	[DefaultValue(MySqlAuthenticationMode.Default)]
	public MySqlAuthenticationMode Auth
	{
		get
		{
			return (MySqlAuthenticationMode)values["auth"];
		}
		set
		{
			SetValue("auth", value, "Auth");
		}
	}

	[Description("Path to a local file containing certificate revocation lists")]
	public string SslCrl
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public override object this[string keyword]
	{
		get
		{
			MySqlConnectionStringOption option = GetOption(keyword);
			if (option.BaseSetter != null)
			{
				return option.BaseGetter(this, option);
			}
			if (option.XGetter == null)
			{
				throw new ArgumentException(Resources.KeywordNotSupported, keyword);
			}
			return option.XGetter(this, option);
		}
		set
		{
			MySqlConnectionStringOption option = GetOption(keyword);
			if (option.BaseSetter != null)
			{
				option.BaseSetter(this, option, value);
				return;
			}
			if (option.XSetter == null)
			{
				throw new ArgumentException(Resources.KeywordNotSupported, keyword);
			}
			option.XSetter(this, option, value);
		}
	}

	static MySqlXConnectionStringBuilder()
	{
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("connect-timeout", "connecttimeout", typeof(uint), 10000u, obsolete: false, delegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object Value)
		{
			sender.ValidateValue(ref Value, sender.Keyword);
			uint num = (uint)Convert.ChangeType(Value, sender.BaseType);
			uint num2 = Math.Min(num, 2147483647u);
			if (num2 != num)
			{
				MySqlTrace.LogWarning(-1, "Connection timeout value too large (" + num + " milliseconds). Changed to max. possible value " + num2 + " milliseconds)");
			}
			msb.SetValue("connect-timeout", num2, ".cctor");
		}, (MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender) => (uint)msb.values["connect-timeout"]));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("connection-attributes", "connectionattributes", typeof(string), "true", obsolete: false));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("auth", null, typeof(MySqlAuthenticationMode), MySqlAuthenticationMode.Default, obsolete: false));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("sslcrl", "ssl-crl", typeof(string), null, obsolete: false, delegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SslCrl = value as string;
		}, (MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SslCrl));
	}

	public MySqlXConnectionStringBuilder()
	{
		if (base.SslMode == MySqlSslMode.Preferred)
		{
			base.SslMode = MySqlSslMode.Required;
		}
	}

	public MySqlXConnectionStringBuilder(string connStr)
		: base(connStr, isXProtocol: true)
	{
		if (base.SslMode == MySqlSslMode.Preferred)
		{
			base.SslMode = MySqlSslMode.Required;
		}
	}
}
