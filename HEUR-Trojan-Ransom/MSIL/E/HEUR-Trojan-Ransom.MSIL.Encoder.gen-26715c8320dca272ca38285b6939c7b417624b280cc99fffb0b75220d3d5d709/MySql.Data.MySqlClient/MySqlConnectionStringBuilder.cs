using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using MySql.Data.Common;
using MySql.Data.common;

namespace MySql.Data.MySqlClient;

public sealed class MySqlConnectionStringBuilder : MySqlBaseConnectionStringBuilder
{
	internal new static readonly MySqlConnectionStringOptionCollection Options;

	[DisplayName("Pipe Name")]
	[Description("Name of pipe to use when connecting with named pipes (Win32 only)")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	public string PipeName
	{
		get
		{
			return (string)base.values["pipe"];
		}
		set
		{
			SetValue("pipe", value, "PipeName");
		}
	}

	[Description("Should the connection use compression")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[DisplayName("Use Compression")]
	public bool UseCompression
	{
		get
		{
			return (bool)base.values["compress"];
		}
		set
		{
			SetValue("compress", value, "UseCompression");
		}
	}

	[Description("Allows execution of multiple SQL commands in a single statement")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[DisplayName("Allow Batch")]
	public bool AllowBatch
	{
		get
		{
			return (bool)base.values["allowbatch"];
		}
		set
		{
			SetValue("allowbatch", value, "AllowBatch");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Description("Enables output of diagnostic messages")]
	[Category("Connection")]
	public bool Logging
	{
		get
		{
			return (bool)base.values["logging"];
		}
		set
		{
			SetValue("logging", value, "Logging");
		}
	}

	[Description("Name of the shared memory object to use")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[DisplayName("Shared Memory Name")]
	public string SharedMemoryName
	{
		get
		{
			return (string)base.values["sharedmemoryname"];
		}
		set
		{
			SetValue("sharedmemoryname", value, "SharedMemoryName");
		}
	}

	[Description("The default timeout that MySqlCommand objects will use\n                     unless changed.")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[DisplayName("Default Command Timeout")]
	public uint DefaultCommandTimeout
	{
		get
		{
			return (uint)base.values["defaultcommandtimeout"];
		}
		set
		{
			SetValue("defaultcommandtimeout", value, "DefaultCommandTimeout");
		}
	}

	[Description("The length of time (in seconds) to wait for a connection to the server before terminating the attempt and generating an error.")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[DisplayName("Connect Timeout")]
	public uint ConnectionTimeout
	{
		get
		{
			return (uint)base.values["connectiontimeout"];
		}
		set
		{
			uint num = Math.Min(value, 2147483u);
			if (num != value)
			{
				string[] obj = new string[5]
				{
					"Connection timeout value too large (",
					value.ToString(),
					" seconds). Changed to max. possible value",
					null,
					null
				};
				uint num2 = num;
				obj[3] = num2.ToString();
				obj[4] = " seconds)";
				MySqlTrace.LogWarning(-1, string.Concat(obj));
			}
			SetValue("connectiontimeout", num, "ConnectionTimeout");
		}
	}

	[Description("Allows reading data from a text file.")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[DisplayName("Allow Load Data Local Infile")]
	public bool AllowLoadLocalInfile
	{
		get
		{
			return (bool)base.values["allowloadlocalinfile"];
		}
		set
		{
			SetValue("allowloadlocalinfile", value, "AllowLoadLocalInfile");
		}
	}

	[Description("When false, security-sensitive information, such as the password, is not returned as part of the connection if the connection is open or has ever been in an open state.")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Security")]
	[DisplayName("Persist Security Info")]
	public bool PersistSecurityInfo
	{
		get
		{
			return (bool)base.values["persistsecurityinfo"];
		}
		set
		{
			SetValue("persistsecurityinfo", value, "PersistSecurityInfo");
		}
	}

	[DefaultValue(false)]
	[Category("Authentication")]
	[DisplayName("Integrated Security")]
	[Description("Use windows authentication when connecting to server")]
	public bool IntegratedSecurity
	{
		get
		{
			return (bool)base.values["integratedsecurity"];
		}
		set
		{
			SetValue("integratedsecurity", value, "IntegratedSecurity");
		}
	}

	[DefaultValue(false)]
	[Category("Authentication")]
	[DisplayName("AllowPublicKeyRetrieval")]
	[Description("Allow retrieval of RSA public keys from server when SSL is disabled.")]
	public bool AllowPublicKeyRetrieval
	{
		get
		{
			return (bool)base.values["allowpublickeyretrieval"];
		}
		set
		{
			SetValue("allowpublickeyretrieval", value, "AllowPublicKeyRetrieval");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Allow Zero Datetime")]
	[Description("Should zero datetimes be supported")]
	[DefaultValue(false)]
	[Category("Advanced")]
	public bool AllowZeroDateTime
	{
		get
		{
			return (bool)base.values["allowzerodatetime"];
		}
		set
		{
			SetValue("allowzerodatetime", value, "AllowZeroDateTime");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Convert Zero Datetime")]
	[Description("Should illegal datetime values be converted to DateTime.MinValue")]
	[DefaultValue(false)]
	[Category("Advanced")]
	public bool ConvertZeroDateTime
	{
		get
		{
			return (bool)base.values["convertzerodatetime"];
		}
		set
		{
			SetValue("convertzerodatetime", value, "ConvertZeroDateTime");
		}
	}

	[Description("Logs inefficient database operations")]
	[DisplayName("Use Usage Advisor")]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	public bool UseUsageAdvisor
	{
		get
		{
			return (bool)base.values["useusageadvisor"];
		}
		set
		{
			SetValue("useusageadvisor", value, "UseUsageAdvisor");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Description("Indicates how many stored procedures can be cached at one time. A value of 0 effectively disables the procedure cache.")]
	[Category("Advanced")]
	[DefaultValue(25)]
	[DisplayName("Procedure Cache Size")]
	public uint ProcedureCacheSize
	{
		get
		{
			return (uint)base.values["procedurecachesize"];
		}
		set
		{
			SetValue("procedurecachesize", value, "ProcedureCacheSize");
		}
	}

	[Category("Advanced")]
	[Description("Indicates that performance counters should be updated during execution.")]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Use Performance Monitor")]
	public bool UsePerformanceMonitor
	{
		get
		{
			return (bool)base.values["useperformancemonitor"];
		}
		set
		{
			SetValue("useperformancemonitor", value, "UsePerformanceMonitor");
		}
	}

	[DefaultValue(false)]
	[Category("Advanced")]
	[Description("Instructs the provider to ignore any attempts to prepare a command.")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Ignore Prepare")]
	public bool IgnorePrepare
	{
		get
		{
			return (bool)base.values["ignoreprepare"];
		}
		set
		{
			SetValue("ignoreprepare", value, "IgnorePrepare");
		}
	}

	[Description("Should the connetion automatically enlist in the active connection, if there are any.")]
	[DefaultValue(true)]
	[Category("Advanced")]
	[DisplayName("Auto Enlist")]
	[RefreshProperties(RefreshProperties.All)]
	public bool AutoEnlist
	{
		get
		{
			return (bool)base.values["autoenlist"];
		}
		set
		{
			SetValue("autoenlist", value, "AutoEnlist");
		}
	}

	[Category("Advanced")]
	[DefaultValue(false)]
	[Description("Include security asserts to support Medium Trust")]
	[DisplayName("Include Security Asserts")]
	public bool IncludeSecurityAsserts
	{
		get
		{
			return (bool)base.values["includesecurityasserts"];
		}
		set
		{
			SetValue("includesecurityasserts", value, "IncludeSecurityAsserts");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	[DefaultValue(true)]
	[DisplayName("Respect Binary Flags")]
	[Description("Should binary flags on column metadata be respected.")]
	public bool RespectBinaryFlags
	{
		get
		{
			return (bool)base.values["respectbinaryflags"];
		}
		set
		{
			SetValue("respectbinaryflags", value, "RespectBinaryFlags");
		}
	}

	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Treat Tiny As Boolean")]
	[DefaultValue(true)]
	[Description("Should the provider treat TINYINT(1) columns as boolean.")]
	public bool TreatTinyAsBoolean
	{
		get
		{
			return (bool)base.values["treattinyasboolean"];
		}
		set
		{
			SetValue("treattinyasboolean", value, "TreatTinyAsBoolean");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Description("Should the provider expect user variables to appear in the SQL.")]
	[Category("Advanced")]
	[DefaultValue(false)]
	[DisplayName("Allow User Variables")]
	public bool AllowUserVariables
	{
		get
		{
			return (bool)base.values["allowuservariables"];
		}
		set
		{
			SetValue("allowuservariables", value, "AllowUserVariables");
		}
	}

	[Description("Should this session be considered interactive?")]
	[DefaultValue(false)]
	[DisplayName("Interactive Session")]
	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	public bool InteractiveSession
	{
		get
		{
			return (bool)base.values["interactivesession"];
		}
		set
		{
			SetValue("interactivesession", value, "InteractiveSession");
		}
	}

	[DefaultValue(false)]
	[Category("Advanced")]
	[DisplayName("Functions Return String")]
	[Description("Should all server functions be treated as returning string?")]
	public bool FunctionsReturnString
	{
		get
		{
			return (bool)base.values["functionsreturnstring"];
		}
		set
		{
			SetValue("functionsreturnstring", value, "FunctionsReturnString");
		}
	}

	[DisplayName("Use Affected Rows")]
	[Category("Advanced")]
	[DefaultValue(false)]
	[Description("Should the returned affected row count reflect affected rows instead of found rows?")]
	public bool UseAffectedRows
	{
		get
		{
			return (bool)base.values["useaffectedrows"];
		}
		set
		{
			SetValue("useaffectedrows", value, "UseAffectedRows");
		}
	}

	[Description("Treat binary(16) columns as guids")]
	[DefaultValue(false)]
	[DisplayName("Old Guids")]
	[Category("Advanced")]
	public bool OldGuids
	{
		get
		{
			return (bool)base.values["oldguids"];
		}
		set
		{
			SetValue("oldguids", value, "OldGuids");
		}
	}

	[Description("Allow Sql Server syntax.  A value of yes allows symbols to be enclosed with [] instead of ``.  This does incur a performance hit so only use when necessary.")]
	[Category("Advanced")]
	[DisplayName("Sql Server Mode")]
	[DefaultValue(false)]
	public bool SqlServerMode
	{
		get
		{
			return (bool)base.values["sqlservermode"];
		}
		set
		{
			SetValue("sqlservermode", value, "SqlServerMode");
		}
	}

	[Category("Advanced")]
	[DefaultValue(false)]
	[Description("Enables or disables caching of TableDirect command.  \n            A value of yes enables the cache while no disables it.")]
	[DisplayName("Table Cache")]
	public bool TableCaching
	{
		get
		{
			return (bool)base.values["tablecaching"];
		}
		set
		{
			SetValue("tablecaching", value, "TableCaching");
		}
	}

	[Description("Specifies how long a TableDirect result should be cached in seconds.")]
	[DefaultValue(60)]
	[DisplayName("Default Table Cache Age")]
	[Category("Advanced")]
	public int DefaultTableCacheAge
	{
		get
		{
			return (int)base.values["defaulttablecacheage"];
		}
		set
		{
			SetValue("defaulttablecacheage", value, "DefaultTableCacheAge");
		}
	}

	[DisplayName("Check Parameters")]
	[Category("Advanced")]
	[Description("Indicates if stored routine parameters should be checked against the server.")]
	[DefaultValue(true)]
	public bool CheckParameters
	{
		get
		{
			return (bool)base.values["checkparameters"];
		}
		set
		{
			SetValue("checkparameters", value, "CheckParameters");
		}
	}

	[Description("Indicates if this connection is to use replicated servers.")]
	[DefaultValue(false)]
	[DisplayName("Replication")]
	[Category("Advanced")]
	public bool Replication
	{
		get
		{
			return (bool)base.values["replication"];
		}
		set
		{
			SetValue("replication", value, "Replication");
		}
	}

	[Description("The list of interceptors that can triage thrown MySqlExceptions.")]
	[DisplayName("Exception Interceptors")]
	[Category("Advanced")]
	public string ExceptionInterceptors
	{
		get
		{
			return (string)base.values["exceptioninterceptors"];
		}
		set
		{
			SetValue("exceptioninterceptors", value, "ExceptionInterceptors");
		}
	}

	[Category("Advanced")]
	[Description("The list of interceptors that can intercept command operations.")]
	[DisplayName("Command Interceptors")]
	public string CommandInterceptors
	{
		get
		{
			return (string)base.values["commandinterceptors"];
		}
		set
		{
			SetValue("commandinterceptors", value, "CommandInterceptors");
		}
	}

	[DisplayName("Connection Lifetime")]
	[Category("Pooling")]
	[DefaultValue(0)]
	[Description("The minimum amount of time (in seconds) for this connection to live in the pool before being destroyed.")]
	[RefreshProperties(RefreshProperties.All)]
	public uint ConnectionLifeTime
	{
		get
		{
			return (uint)base.values["connectionlifetime"];
		}
		set
		{
			SetValue("connectionlifetime", value, "ConnectionLifeTime");
		}
	}

	[Category("Pooling")]
	[Description("When true, the connection object is drawn from the appropriate pool, or if necessary, is created and added to the appropriate pool.")]
	[DefaultValue(true)]
	[RefreshProperties(RefreshProperties.All)]
	public bool Pooling
	{
		get
		{
			return (bool)base.values["pooling"];
		}
		set
		{
			SetValue("pooling", value, "Pooling");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Pooling")]
	[DisplayName("Minimum Pool Size")]
	[Description("The minimum number of connections allowed in the pool.")]
	[DefaultValue(0)]
	public uint MinimumPoolSize
	{
		get
		{
			return (uint)base.values["minpoolsize"];
		}
		set
		{
			SetValue("minpoolsize", value, "MinimumPoolSize");
		}
	}

	[Category("Pooling")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("The maximum number of connections allowed in the pool.")]
	[DefaultValue(100)]
	[DisplayName("Maximum Pool Size")]
	public uint MaximumPoolSize
	{
		get
		{
			return (uint)base.values["maxpoolsize"];
		}
		set
		{
			SetValue("maxpoolsize", value, "MaximumPoolSize");
		}
	}

	[DefaultValue(false)]
	[DisplayName("Connection Reset")]
	[Category("Pooling")]
	[Description("When true, indicates the connection state is reset when removed from the pool.")]
	[RefreshProperties(RefreshProperties.All)]
	public bool ConnectionReset
	{
		get
		{
			return (bool)base.values["connectionreset"];
		}
		set
		{
			SetValue("connectionreset", value, "ConnectionReset");
		}
	}

	[DefaultValue(false)]
	[Category("Pooling")]
	[Description("When true, server properties will be cached after the first server in the pool is created")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Cache Server Properties")]
	public bool CacheServerProperties
	{
		get
		{
			return (bool)base.values["cacheserverproperties"];
		}
		set
		{
			SetValue("cacheserverproperties", value, "CacheServerProperties");
		}
	}

	[DisplayName("Treat Blobs As UTF8")]
	[DefaultValue(false)]
	[Description("Should binary blobs be treated as UTF8")]
	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	public bool TreatBlobsAsUTF8
	{
		get
		{
			return (bool)base.values["treatblobsasutf8"];
		}
		set
		{
			SetValue("treatblobsasutf8", value, "TreatBlobsAsUTF8");
		}
	}

	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Pattern that matches columns that should be treated as UTF8")]
	public string BlobAsUTF8IncludePattern
	{
		get
		{
			return (string)base.values["blobasutf8includepattern"];
		}
		set
		{
			SetValue("blobasutf8includepattern", value, "BlobAsUTF8IncludePattern");
		}
	}

	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Pattern that matches columns that should not be treated as UTF8")]
	public string BlobAsUTF8ExcludePattern
	{
		get
		{
			return (string)base.values["blobasutf8excludepattern"];
		}
		set
		{
			SetValue("blobasutf8excludepattern", value, "BlobAsUTF8ExcludePattern");
		}
	}

	[DisplayName("Use Default Command Timeout For EF")]
	[Category("Backwards Compatibility")]
	[Description("Enforces the command timeout of EFMySqlCommand to the value provided in 'DefaultCommandTimeout' property")]
	[DefaultValue(false)]
	public bool UseDefaultCommandTimeoutForEF
	{
		get
		{
			return (bool)base.values["usedefaultcommandtimeoutforef"];
		}
		set
		{
			SetValue("usedefaultcommandtimeoutforef", value, "UseDefaultCommandTimeoutForEF");
		}
	}

	public override object this[string keyword]
	{
		get
		{
			MySqlConnectionStringOption option = GetOption(keyword);
			if (option.ClassicGetter != null)
			{
				return option.ClassicGetter(this, option);
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
			if (option.ClassicSetter != null)
			{
				option.ClassicSetter(this, option, value);
				return;
			}
			if (option.Setter == null)
			{
				throw new ArgumentException(Resources.KeywordNotSupported, keyword);
			}
			option.Setter(this, option, value);
		}
	}

	static MySqlConnectionStringBuilder()
	{
		Options = MySqlBaseConnectionStringBuilder.Options.Clone();
		Options.Add(new MySqlConnectionStringOption("pipe", "pipe name,pipename", typeof(string), "MYSQL", obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("pipe", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.PipeName));
		Options.Add(new MySqlConnectionStringOption("compress", "use compression,usecompression", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("compress", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UseCompression));
		Options.Add(new MySqlConnectionStringOption("allowbatch", "allow batch", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("allowbatch", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AllowBatch));
		Options.Add(new MySqlConnectionStringOption("logging", null, typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("logging", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.Logging));
		Options.Add(new MySqlConnectionStringOption("sharedmemoryname", "shared memory name", typeof(string), "MYSQL", obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("sharedmemoryname", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SharedMemoryName));
		Options.Add(new MySqlConnectionStringOption("defaultcommandtimeout", "command timeout,default command timeout", typeof(uint), 30u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("defaultcommandtimeout", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.DefaultCommandTimeout));
		Options.Add(new MySqlConnectionStringOption("usedefaultcommandtimeoutforef", "use default command timeout for ef", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("usedefaultcommandtimeoutforef", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UseDefaultCommandTimeoutForEF));
		Options.Add(new MySqlConnectionStringOption("connectiontimeout", "connection timeout,connect timeout", typeof(uint), 15u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object Value)
		{
			uint num = (uint)Convert.ChangeType(Value, sender.BaseType);
			uint num2 = Math.Min(num, 2147483u);
			if (num2 != num)
			{
				string[] obj = new string[5]
				{
					"Connection timeout value too large (",
					num.ToString(),
					" seconds). Changed to max. possible value",
					null,
					null
				};
				uint num3 = num2;
				obj[3] = num3.ToString();
				obj[4] = " seconds)";
				MySqlTrace.LogWarning(-1, string.Concat(obj));
			}
			msb.SetValue("connectiontimeout", num2, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => (uint)msb.values["connectiontimeout"]));
		Options.Add(new MySqlConnectionStringOption("allowloadlocalinfile", "allow load local infile", typeof(bool), false, obsolete: false));
		Options.Add(new MySqlConnectionStringOption("persistsecurityinfo", "persist security info", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("persistsecurityinfo", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.PersistSecurityInfo));
		Options.Add(new MySqlConnectionStringOption("integratedsecurity", "integrated security", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			if (!Platform.IsWindows())
			{
				throw new MySqlException("IntegratedSecurity is supported on Windows only");
			}
			msb.SetValue("Integrated Security", value.ToString()!.Equals("SSPI", StringComparison.OrdinalIgnoreCase) ? ((object)true) : value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => (bool)msb.values["integratedsecurity"]));
		Options.Add(new MySqlConnectionStringOption("allowpublickeyretrieval", null, typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("allowpublickeyretrieval", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AllowPublicKeyRetrieval));
		Options.Add(new MySqlConnectionStringOption("autoenlist", "auto enlist", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("autoenlist", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AutoEnlist));
		Options.Add(new MySqlConnectionStringOption("includesecurityasserts", "include security asserts", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("includesecurityasserts", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.IncludeSecurityAsserts));
		Options.Add(new MySqlConnectionStringOption("allowzerodatetime", "allow zero datetime", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("allowzerodatetime", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AllowZeroDateTime));
		Options.Add(new MySqlConnectionStringOption("convertzerodatetime", "convert zero datetime", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("convertzerodatetime", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConvertZeroDateTime));
		Options.Add(new MySqlConnectionStringOption("useusageadvisor", "use usage advisor,usage advisor", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("useusageadvisor", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UseUsageAdvisor));
		Options.Add(new MySqlConnectionStringOption("procedurecachesize", "procedure cache size,procedure cache,procedurecache", typeof(uint), 25u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("procedurecachesize", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ProcedureCacheSize));
		Options.Add(new MySqlConnectionStringOption("useperformancemonitor", "use performance monitor,useperfmon,perfmon", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("useperformancemonitor", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UsePerformanceMonitor));
		Options.Add(new MySqlConnectionStringOption("ignoreprepare", "ignore prepare", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("ignoreprepare", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.IgnorePrepare));
		Options.Add(new MySqlConnectionStringOption("respectbinaryflags", "respect binary flags", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("respectbinaryflags", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.RespectBinaryFlags));
		Options.Add(new MySqlConnectionStringOption("treattinyasboolean", "treat tiny as boolean", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("treattinyasboolean", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.TreatTinyAsBoolean));
		Options.Add(new MySqlConnectionStringOption("allowuservariables", "allow user variables", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("allowuservariables", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AllowUserVariables));
		Options.Add(new MySqlConnectionStringOption("interactivesession", "interactive session,interactive", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("interactivesession", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.InteractiveSession));
		Options.Add(new MySqlConnectionStringOption("functionsreturnstring", "functions return string", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("functionsreturnstring", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.FunctionsReturnString));
		Options.Add(new MySqlConnectionStringOption("useaffectedrows", "use affected rows", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("useaffectedrows", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UseAffectedRows));
		Options.Add(new MySqlConnectionStringOption("oldguids", "old guids", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("oldguids", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.OldGuids));
		Options.Add(new MySqlConnectionStringOption("sqlservermode", "sql server mode", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("sqlservermode", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SqlServerMode));
		Options.Add(new MySqlConnectionStringOption("tablecaching", "table cache,tablecache", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("tablecaching", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.TableCaching));
		Options.Add(new MySqlConnectionStringOption("defaulttablecacheage", "default table cache age", typeof(int), 60, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("defaulttablecacheage", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.DefaultTableCacheAge));
		Options.Add(new MySqlConnectionStringOption("checkparameters", "check parameters", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("checkparameters", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.CheckParameters));
		Options.Add(new MySqlConnectionStringOption("replication", null, typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("replication", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.Replication));
		Options.Add(new MySqlConnectionStringOption("exceptioninterceptors", "exception interceptors", typeof(string), null, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("exceptioninterceptors", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ExceptionInterceptors));
		Options.Add(new MySqlConnectionStringOption("commandinterceptors", "command interceptors", typeof(string), null, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("commandinterceptors", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.CommandInterceptors));
		Options.Add(new MySqlConnectionStringOption("connectionlifetime", "connection lifetime", typeof(uint), 0u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("connectionlifetime", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConnectionLifeTime));
		Options.Add(new MySqlConnectionStringOption("pooling", null, typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("pooling", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.Pooling));
		Options.Add(new MySqlConnectionStringOption("minpoolsize", "minimumpoolsize,min pool size,minimum pool size", typeof(uint), 0u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("minpoolsize", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.MinimumPoolSize));
		Options.Add(new MySqlConnectionStringOption("maxpoolsize", "maximumpoolsize,max pool size,maximum pool size", typeof(uint), 100u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("maxpoolsize", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.MaximumPoolSize));
		Options.Add(new MySqlConnectionStringOption("connectionreset", "connection reset", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("connectionreset", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConnectionReset));
		Options.Add(new MySqlConnectionStringOption("cacheserverproperties", "cache server properties", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("cacheserverproperties", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.CacheServerProperties));
		Options.Add(new MySqlConnectionStringOption("treatblobsasutf8", "treat blobs as utf8", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("treatblobsasutf8", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.TreatBlobsAsUTF8));
		Options.Add(new MySqlConnectionStringOption("blobasutf8includepattern", null, typeof(string), "", obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("blobasutf8includepattern", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.BlobAsUTF8IncludePattern));
		Options.Add(new MySqlConnectionStringOption("blobasutf8excludepattern", null, typeof(string), "", obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("blobasutf8excludepattern", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.BlobAsUTF8ExcludePattern));
	}

	public MySqlConnectionStringBuilder()
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

	public MySqlConnectionStringBuilder(string connectionString)
		: this()
	{
		AnalyzeConnectionString(connectionString, isXProtocol: false);
		lock (this)
		{
			base.ConnectionString = connectionString;
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
		MySqlConnectionStringBuilder mySqlConnectionStringBuilder = obj as MySqlConnectionStringBuilder;
		if (obj == null)
		{
			return false;
		}
		if (base.values.Count != mySqlConnectionStringBuilder.values.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, object> value in base.values)
		{
			if (mySqlConnectionStringBuilder.values.ContainsKey(value.Key))
			{
				object obj2 = mySqlConnectionStringBuilder.values[value.Key];
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

	internal Regex GetBlobAsUTF8IncludeRegex()
	{
		if (string.IsNullOrEmpty(BlobAsUTF8IncludePattern))
		{
			return null;
		}
		return new Regex(BlobAsUTF8IncludePattern);
	}

	internal Regex GetBlobAsUTF8ExcludeRegex()
	{
		if (string.IsNullOrEmpty(BlobAsUTF8ExcludePattern))
		{
			return null;
		}
		return new Regex(BlobAsUTF8ExcludePattern);
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

	internal override void SetInternalValue(string keyword, object value)
	{
		MySqlConnectionStringOption option = GetOption(keyword);
		option.ValidateValue(ref value);
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
}
