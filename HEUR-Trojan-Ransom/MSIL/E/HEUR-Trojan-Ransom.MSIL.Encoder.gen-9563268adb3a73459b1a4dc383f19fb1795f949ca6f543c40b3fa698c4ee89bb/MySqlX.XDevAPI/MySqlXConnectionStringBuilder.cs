using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.common;

namespace MySqlX.XDevAPI;

public sealed class MySqlXConnectionStringBuilder : MySqlBaseConnectionStringBuilder
{
	internal new static readonly MySqlConnectionStringOptionCollection Options;

	[Description("The length of time (in milliseconds) to wait for a connection to the server before terminating the attempt and generating an error.")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Connect Timeout")]
	[Category("Connection")]
	public uint ConnectTimeout
	{
		get
		{
			return (uint)base.values["connect-timeout"];
		}
		set
		{
			uint num = Math.Min(value, 2147483647u);
			if (num != value)
			{
				string[] obj = new string[5]
				{
					"Connection timeout value too large (",
					value.ToString(),
					" milliseconds). Changed to max. possible value",
					null,
					null
				};
				uint num2 = num;
				obj[3] = num2.ToString();
				obj[4] = " milliseconds)";
				MySqlTrace.LogWarning(-1, string.Concat(obj));
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
			return (string)base.values["connection-attributes"];
		}
		set
		{
			SetValue("connection-attributes", value, "ConnectionAttributes");
		}
	}

	[Category("Authentication")]
	[DisplayName("Auth")]
	[Description("Authentication mechanism")]
	[DefaultValue(MySqlAuthenticationMode.Default)]
	public MySqlAuthenticationMode Auth
	{
		get
		{
			return (MySqlAuthenticationMode)base.values["auth"];
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

	[Description("Compression type")]
	[DefaultValue(CompressionType.Preferred)]
	[DisplayName("Compression Type")]
	[Category("Server")]
	public CompressionType Compression
	{
		get
		{
			return (CompressionType)base.values["compression"];
		}
		set
		{
			SetValue("compression", value, "Compression");
		}
	}

	public override object this[string keyword]
	{
		get
		{
			MySqlConnectionStringOption option = GetOption(keyword);
			if (option.XGetter != null)
			{
				return option.XGetter(this, option);
			}
			if (option.Getter == null)
			{
				throw new ArgumentException(Resources.KeywordNotSupported, keyword);
			}
			return option.Getter(this, option);
		}
		set
		{
			MySqlConnectionStringOption option = GetOption(keyword);
			if (option.XSetter != null)
			{
				option.XSetter(this, option, value);
				return;
			}
			if (option.Setter == null)
			{
				throw new ArgumentException(Resources.KeywordNotSupported, keyword);
			}
			option.Setter(this, option, value);
		}
	}

	static MySqlXConnectionStringBuilder()
	{
		Options = MySqlBaseConnectionStringBuilder.Options.Clone();
		Options.Add(new MySqlConnectionStringOption("connect-timeout", "connecttimeout", typeof(uint), 10000u, obsolete: false, delegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object Value)
		{
			sender.ValidateValue(ref Value, sender.Keyword);
			uint num = (uint)Convert.ChangeType(Value, sender.BaseType);
			uint num2 = Math.Min(num, 2147483647u);
			if (num2 != num)
			{
				string[] obj = new string[5]
				{
					"Connection timeout value too large (",
					num.ToString(),
					" milliseconds). Changed to max. possible value ",
					null,
					null
				};
				uint num3 = num2;
				obj[3] = num3.ToString();
				obj[4] = " milliseconds)";
				MySqlTrace.LogWarning(-1, string.Concat(obj));
			}
			msb.SetValue("connect-timeout", num2, ".cctor");
		}, (MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender) => (uint)msb.values["connect-timeout"]));
		Options.Add(new MySqlConnectionStringOption("connection-attributes", "connectionattributes", typeof(string), "true", obsolete: false, delegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("connection-attributes", value, ".cctor");
		}, (MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConnectionAttributes));
		Options.Add(new MySqlConnectionStringOption("compression", "use-compression", typeof(CompressionType), CompressionType.Preferred, obsolete: false, delegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("compression", value, ".cctor");
		}, (MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.Compression));
		Options.Add(new MySqlConnectionStringOption("auth", null, typeof(MySqlAuthenticationMode), MySqlAuthenticationMode.Default, obsolete: false, delegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("auth", value, ".cctor");
		}, (MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.Auth));
		Options.Add(new MySqlConnectionStringOption("sslcrl", "ssl-crl", typeof(string), null, obsolete: false, delegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SslCrl = value as string;
		}, (MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SslCrl));
	}

	public MySqlXConnectionStringBuilder()
	{
		base.values = new Dictionary<string, object>();
		base.HasProcAccess = true;
		lock (this)
		{
			foreach (MySqlConnectionStringOption option in Options.Options)
			{
				base.values[option.Keyword] = option.DefaultValue;
			}
		}
	}

	public MySqlXConnectionStringBuilder(string connectionString, bool isDefaultPort = true)
		: this()
	{
		AnalyzeConnectionString(connectionString, isXProtocol: true, isDefaultPort);
		lock (this)
		{
			base.ConnectionString = connectionString;
		}
		if (base.SslMode == MySqlSslMode.Preferred)
		{
			base.SslMode = MySqlSslMode.Required;
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
					base.values[option.Keyword] = option.DefaultValue;
				}
				else
				{
					base.values[option.Keyword] = null;
				}
			}
		}
	}

	public override bool ContainsKey(string keyword)
	{
		return Options.Get(keyword) != null;
	}

	public override bool Equals(object obj)
	{
		MySqlXConnectionStringBuilder mySqlXConnectionStringBuilder = obj as MySqlXConnectionStringBuilder;
		if (obj == null)
		{
			return false;
		}
		if (base.values.Count != mySqlXConnectionStringBuilder.values.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, object> value in base.values)
		{
			if (mySqlXConnectionStringBuilder.values.ContainsKey(value.Key))
			{
				object obj2 = mySqlXConnectionStringBuilder.values[value.Key];
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

	internal override MySqlConnectionStringOption GetOption(string key)
	{
		MySqlConnectionStringOption mySqlConnectionStringOption = Options.Get(key);
		if (mySqlConnectionStringOption == null)
		{
			throw new ArgumentException(Resources.KeywordNotSupported, key);
		}
		return mySqlConnectionStringOption;
	}

	internal override void SetInternalValue(string keyword, object value)
	{
		MySqlConnectionStringOption option = GetOption(keyword);
		option.ValidateValue(ref value, keyword, isXProtocol: true);
		option.Clean(this);
		if (value != null)
		{
			lock (this)
			{
				base.values[option.Keyword] = value;
				base[keyword] = value;
			}
		}
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
			base.values[option.Keyword] = option.DefaultValue;
		}
		return true;
	}
}
