using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

public sealed class MySqlConnectionStringBuilder : MySqlBaseConnectionStringBuilder
{
	[Description("Name of pipe to use when connecting with named pipes (Win32 only)")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[DisplayName("Pipe Name")]
	public string PipeName
	{
		get
		{
			return (string)values["pipe"];
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
			return (bool)values["compress"];
		}
		set
		{
			SetValue("compress", value, "UseCompression");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[Description("Allows execution of multiple SQL commands in a single statement")]
	[DisplayName("Allow Batch")]
	public bool AllowBatch
	{
		get
		{
			return (bool)values["allowbatch"];
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
			return (bool)values["logging"];
		}
		set
		{
			SetValue("logging", value, "Logging");
		}
	}

	[Category("Connection")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Name of the shared memory object to use")]
	[DisplayName("Shared Memory Name")]
	public string SharedMemoryName
	{
		get
		{
			return (string)values["sharedmemoryname"];
		}
		set
		{
			SetValue("sharedmemoryname", value, "SharedMemoryName");
		}
	}

	[Category("Connection")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Default Command Timeout")]
	[Description("The default timeout that MySqlCommand objects will use\n                     unless changed.")]
	public uint DefaultCommandTimeout
	{
		get
		{
			return (uint)values["defaultcommandtimeout"];
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
			return (uint)values["connectiontimeout"];
		}
		set
		{
			uint num = Math.Min(value, 2147483u);
			if (num != value)
			{
				MySqlTrace.LogWarning(-1, "Connection timeout value too large (" + value + " seconds). Changed to max. possible value" + num + " seconds)");
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
			return (bool)values["allowloadlocalinfile"];
		}
		set
		{
			SetValue("allowloadlocalinfile", value, "AllowLoadLocalInfile");
		}
	}

	[DisplayName("Persist Security Info")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("When false, security-sensitive information, such as the password, is not returned as part of the connection if the connection is open or has ever been in an open state.")]
	[Category("Security")]
	public bool PersistSecurityInfo
	{
		get
		{
			return (bool)values["persistsecurityinfo"];
		}
		set
		{
			SetValue("persistsecurityinfo", value, "PersistSecurityInfo");
		}
	}

	[DefaultValue(false)]
	[Description("Use windows authentication when connecting to server")]
	[DisplayName("Integrated Security")]
	[Category("Authentication")]
	public bool IntegratedSecurity
	{
		get
		{
			return (bool)values["integratedsecurity"];
		}
		set
		{
			SetValue("integratedsecurity", value, "IntegratedSecurity");
		}
	}

	[DefaultValue(false)]
	[Description("Allow retrieval of RSA public keys from server when SSL is disabled.")]
	[DisplayName("AllowPublicKeyRetrieval")]
	[Category("Authentication")]
	public bool AllowPublicKeyRetrieval
	{
		get
		{
			return (bool)values["allowpublickeyretrieval"];
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
			return (bool)values["allowzerodatetime"];
		}
		set
		{
			SetValue("allowzerodatetime", value, "AllowZeroDateTime");
		}
	}

	[DisplayName("Convert Zero Datetime")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Should illegal datetime values be converted to DateTime.MinValue")]
	[DefaultValue(false)]
	[Category("Advanced")]
	public bool ConvertZeroDateTime
	{
		get
		{
			return (bool)values["convertzerodatetime"];
		}
		set
		{
			SetValue("convertzerodatetime", value, "ConvertZeroDateTime");
		}
	}

	[DisplayName("Use Usage Advisor")]
	[Description("Logs inefficient database operations")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	[DefaultValue(false)]
	public bool UseUsageAdvisor
	{
		get
		{
			return (bool)values["useusageadvisor"];
		}
		set
		{
			SetValue("useusageadvisor", value, "UseUsageAdvisor");
		}
	}

	[DefaultValue(25)]
	[DisplayName("Procedure Cache Size")]
	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Indicates how many stored procedures can be cached at one time. A value of 0 effectively disables the procedure cache.")]
	public uint ProcedureCacheSize
	{
		get
		{
			return (uint)values["procedurecachesize"];
		}
		set
		{
			SetValue("procedurecachesize", value, "ProcedureCacheSize");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(false)]
	[Category("Advanced")]
	[Description("Indicates that performance counters should be updated during execution.")]
	[DisplayName("Use Performance Monitor")]
	public bool UsePerformanceMonitor
	{
		get
		{
			return (bool)values["useperformancemonitor"];
		}
		set
		{
			SetValue("useperformancemonitor", value, "UsePerformanceMonitor");
		}
	}

	[DefaultValue(false)]
	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Ignore Prepare")]
	[Description("Instructs the provider to ignore any attempts to prepare a command.")]
	public bool IgnorePrepare
	{
		get
		{
			return (bool)values["ignoreprepare"];
		}
		set
		{
			SetValue("ignoreprepare", value, "IgnorePrepare");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Auto Enlist")]
	[Category("Advanced")]
	[Description("Should the connetion automatically enlist in the active connection, if there are any.")]
	[DefaultValue(true)]
	public bool AutoEnlist
	{
		get
		{
			return (bool)values["autoenlist"];
		}
		set
		{
			SetValue("autoenlist", value, "AutoEnlist");
		}
	}

	[DefaultValue(false)]
	[Category("Advanced")]
	[DisplayName("Include Security Asserts")]
	[Description("Include security asserts to support Medium Trust")]
	public bool IncludeSecurityAsserts
	{
		get
		{
			return (bool)values["includesecurityasserts"];
		}
		set
		{
			SetValue("includesecurityasserts", value, "IncludeSecurityAsserts");
		}
	}

	[DisplayName("Respect Binary Flags")]
	[Category("Advanced")]
	[Description("Should binary flags on column metadata be respected.")]
	[DefaultValue(true)]
	[RefreshProperties(RefreshProperties.All)]
	public bool RespectBinaryFlags
	{
		get
		{
			return (bool)values["respectbinaryflags"];
		}
		set
		{
			SetValue("respectbinaryflags", value, "RespectBinaryFlags");
		}
	}

	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(true)]
	[DisplayName("Treat Tiny As Boolean")]
	[Description("Should the provider treat TINYINT(1) columns as boolean.")]
	public bool TreatTinyAsBoolean
	{
		get
		{
			return (bool)values["treattinyasboolean"];
		}
		set
		{
			SetValue("treattinyasboolean", value, "TreatTinyAsBoolean");
		}
	}

	[Category("Advanced")]
	[Description("Should the provider expect user variables to appear in the SQL.")]
	[DisplayName("Allow User Variables")]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	public bool AllowUserVariables
	{
		get
		{
			return (bool)values["allowuservariables"];
		}
		set
		{
			SetValue("allowuservariables", value, "AllowUserVariables");
		}
	}

	[DefaultValue(false)]
	[DisplayName("Interactive Session")]
	[Description("Should this session be considered interactive?")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	public bool InteractiveSession
	{
		get
		{
			return (bool)values["interactivesession"];
		}
		set
		{
			SetValue("interactivesession", value, "InteractiveSession");
		}
	}

	[DisplayName("Functions Return String")]
	[Description("Should all server functions be treated as returning string?")]
	[DefaultValue(false)]
	[Category("Advanced")]
	public bool FunctionsReturnString
	{
		get
		{
			return (bool)values["functionsreturnstring"];
		}
		set
		{
			SetValue("functionsreturnstring", value, "FunctionsReturnString");
		}
	}

	[Description("Should the returned affected row count reflect affected rows instead of found rows?")]
	[DefaultValue(false)]
	[DisplayName("Use Affected Rows")]
	[Category("Advanced")]
	public bool UseAffectedRows
	{
		get
		{
			return (bool)values["useaffectedrows"];
		}
		set
		{
			SetValue("useaffectedrows", value, "UseAffectedRows");
		}
	}

	[DisplayName("Old Guids")]
	[Category("Advanced")]
	[Description("Treat binary(16) columns as guids")]
	[DefaultValue(false)]
	public bool OldGuids
	{
		get
		{
			return (bool)values["oldguids"];
		}
		set
		{
			SetValue("oldguids", value, "OldGuids");
		}
	}

	[Description("Allow Sql Server syntax.  A value of yes allows symbols to be enclosed with [] instead of ``.  This does incur a performance hit so only use when necessary.")]
	[DisplayName("Sql Server Mode")]
	[Category("Advanced")]
	[DefaultValue(false)]
	public bool SqlServerMode
	{
		get
		{
			return (bool)values["sqlservermode"];
		}
		set
		{
			SetValue("sqlservermode", value, "SqlServerMode");
		}
	}

	[Description("Enables or disables caching of TableDirect command.  \n            A value of yes enables the cache while no disables it.")]
	[DefaultValue(false)]
	[DisplayName("Table Cache")]
	[Category("Advanced")]
	public bool TableCaching
	{
		get
		{
			return (bool)values["tablecaching"];
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
			return (int)values["defaulttablecacheage"];
		}
		set
		{
			SetValue("defaulttablecacheage", value, "DefaultTableCacheAge");
		}
	}

	[Description("Indicates if stored routine parameters should be checked against the server.")]
	[DefaultValue(true)]
	[DisplayName("Check Parameters")]
	[Category("Advanced")]
	public bool CheckParameters
	{
		get
		{
			return (bool)values["checkparameters"];
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
			return (bool)values["replication"];
		}
		set
		{
			SetValue("replication", value, "Replication");
		}
	}

	[DisplayName("Exception Interceptors")]
	[Description("The list of interceptors that can triage thrown MySqlExceptions.")]
	[Category("Advanced")]
	public string ExceptionInterceptors
	{
		get
		{
			return (string)values["exceptioninterceptors"];
		}
		set
		{
			SetValue("exceptioninterceptors", value, "ExceptionInterceptors");
		}
	}

	[DisplayName("Command Interceptors")]
	[Description("The list of interceptors that can intercept command operations.")]
	[Category("Advanced")]
	public string CommandInterceptors
	{
		get
		{
			return (string)values["commandinterceptors"];
		}
		set
		{
			SetValue("commandinterceptors", value, "CommandInterceptors");
		}
	}

	[Description("The minimum amount of time (in seconds) for this connection to live in the pool before being destroyed.")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(0)]
	[Category("Pooling")]
	[DisplayName("Connection Lifetime")]
	public uint ConnectionLifeTime
	{
		get
		{
			return (uint)values["connectionlifetime"];
		}
		set
		{
			SetValue("connectionlifetime", value, "ConnectionLifeTime");
		}
	}

	[Description("When true, the connection object is drawn from the appropriate pool, or if necessary, is created and added to the appropriate pool.")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(true)]
	[Category("Pooling")]
	public bool Pooling
	{
		get
		{
			return (bool)values["pooling"];
		}
		set
		{
			SetValue("pooling", value, "Pooling");
		}
	}

	[DefaultValue(0)]
	[Category("Pooling")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("The minimum number of connections allowed in the pool.")]
	[DisplayName("Minimum Pool Size")]
	public uint MinimumPoolSize
	{
		get
		{
			return (uint)values["minpoolsize"];
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
			return (uint)values["maxpoolsize"];
		}
		set
		{
			SetValue("maxpoolsize", value, "MaximumPoolSize");
		}
	}

	[Category("Pooling")]
	[Description("When true, indicates the connection state is reset when removed from the pool.")]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Connection Reset")]
	public bool ConnectionReset
	{
		get
		{
			return (bool)values["connectionreset"];
		}
		set
		{
			SetValue("connectionreset", value, "ConnectionReset");
		}
	}

	[Description("When true, server properties will be cached after the first server in the pool is created")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Pooling")]
	[DisplayName("Cache Server Properties")]
	[DefaultValue(false)]
	public bool CacheServerProperties
	{
		get
		{
			return (bool)values["cacheserverproperties"];
		}
		set
		{
			SetValue("cacheserverproperties", value, "CacheServerProperties");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Description("Should binary blobs be treated as UTF8")]
	[DefaultValue(false)]
	[DisplayName("Treat Blobs As UTF8")]
	[Category("Advanced")]
	public bool TreatBlobsAsUTF8
	{
		get
		{
			return (bool)values["treatblobsasutf8"];
		}
		set
		{
			SetValue("treatblobsasutf8", value, "TreatBlobsAsUTF8");
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Description("Pattern that matches columns that should be treated as UTF8")]
	[Category("Advanced")]
	public string BlobAsUTF8IncludePattern
	{
		get
		{
			return (string)values["blobasutf8includepattern"];
		}
		set
		{
			SetValue("blobasutf8includepattern", value, "BlobAsUTF8IncludePattern");
		}
	}

	[Description("Pattern that matches columns that should not be treated as UTF8")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	public string BlobAsUTF8ExcludePattern
	{
		get
		{
			return (string)values["blobasutf8excludepattern"];
		}
		set
		{
			SetValue("blobasutf8excludepattern", value, "BlobAsUTF8ExcludePattern");
		}
	}

	[DefaultValue(false)]
	[Category("Backwards Compatibility")]
	[DisplayName("Use Default Command Timeout For EF")]
	[Description("Enforces the command timeout of EFMySqlCommand to the value provided in 'DefaultCommandTimeout' property")]
	public bool UseDefaultCommandTimeoutForEF
	{
		get
		{
			return (bool)values["usedefaultcommandtimeoutforef"];
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
			if (option.BaseGetter != null)
			{
				return option.BaseGetter(this, option);
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
			if (option.BaseSetter != null)
			{
				option.BaseSetter(this, option, value);
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
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("pipe", "pipe name,pipename", typeof(string), "MYSQL", obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("pipe", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.PipeName));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("compress", "use compression,usecompression", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("compress", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UseCompression));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("allowbatch", "allow batch", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("allowbatch", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AllowBatch));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("logging", null, typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("logging", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.Logging));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("sharedmemoryname", "shared memory name", typeof(string), "MYSQL", obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("sharedmemoryname", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SharedMemoryName));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("defaultcommandtimeout", "command timeout,default command timeout", typeof(uint), 30u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("defaultcommandtimeout", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.DefaultCommandTimeout));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("usedefaultcommandtimeoutforef", "use default command timeout for ef", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("usedefaultcommandtimeoutforef", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UseDefaultCommandTimeoutForEF));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("connectiontimeout", "connection timeout,connect timeout", typeof(uint), 15u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object Value)
		{
			uint num = (uint)Convert.ChangeType(Value, sender.BaseType);
			uint num2 = Math.Min(num, 2147483u);
			if (num2 != num)
			{
				MySqlTrace.LogWarning(-1, "Connection timeout value too large (" + num + " seconds). Changed to max. possible value" + num2 + " seconds)");
			}
			msb.SetValue("connectiontimeout", num2, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => (uint)msb.values["connectiontimeout"]));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("allowloadlocalinfile", "allow load local infile", typeof(bool), false, obsolete: false));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("persistsecurityinfo", "persist security info", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("persistsecurityinfo", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.PersistSecurityInfo));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("integratedsecurity", "integrated security", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			if (!Platform.IsWindows())
			{
				throw new MySqlException("IntegratedSecurity is supported on Windows only");
			}
			msb.SetValue("Integrated Security", value.ToString()!.Equals("SSPI", StringComparison.OrdinalIgnoreCase) ? ((object)true) : value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => (bool)msb.values["integratedsecurity"]));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("allowpublickeyretrieval", null, typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("allowpublickeyretrieval", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AllowPublicKeyRetrieval));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("autoenlist", "auto enlist", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("autoenlist", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AutoEnlist));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("includesecurityasserts", "include security asserts", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("includesecurityasserts", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.IncludeSecurityAsserts));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("allowzerodatetime", "allow zero datetime", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("allowzerodatetime", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AllowZeroDateTime));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("convertzerodatetime", "convert zero datetime", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("convertzerodatetime", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConvertZeroDateTime));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("useusageadvisor", "use usage advisor,usage advisor", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("useusageadvisor", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UseUsageAdvisor));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("procedurecachesize", "procedure cache size,procedure cache,procedurecache", typeof(uint), 25u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("procedurecachesize", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ProcedureCacheSize));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("useperformancemonitor", "use performance monitor,useperfmon,perfmon", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("useperformancemonitor", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UsePerformanceMonitor));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("ignoreprepare", "ignore prepare", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("ignoreprepare", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.IgnorePrepare));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("respectbinaryflags", "respect binary flags", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("respectbinaryflags", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.RespectBinaryFlags));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("treattinyasboolean", "treat tiny as boolean", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("treattinyasboolean", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.TreatTinyAsBoolean));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("allowuservariables", "allow user variables", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("allowuservariables", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.AllowUserVariables));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("interactivesession", "interactive session,interactive", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("interactivesession", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.InteractiveSession));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("functionsreturnstring", "functions return string", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("functionsreturnstring", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.FunctionsReturnString));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("useaffectedrows", "use affected rows", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("useaffectedrows", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.UseAffectedRows));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("oldguids", "old guids", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("oldguids", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.OldGuids));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("sqlservermode", "sql server mode", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("sqlservermode", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.SqlServerMode));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("tablecaching", "table cache,tablecache", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("tablecaching", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.TableCaching));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("defaulttablecacheage", "default table cache age", typeof(int), 60, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("defaulttablecacheage", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.DefaultTableCacheAge));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("checkparameters", "check parameters", typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("checkparameters", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.CheckParameters));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("replication", null, typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("replication", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.Replication));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("exceptioninterceptors", "exception interceptors", typeof(string), null, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("exceptioninterceptors", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ExceptionInterceptors));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("commandinterceptors", "command interceptors", typeof(string), null, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("commandinterceptors", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.CommandInterceptors));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("connectionlifetime", "connection lifetime", typeof(uint), 0u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("connectionlifetime", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConnectionLifeTime));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("pooling", null, typeof(bool), true, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("pooling", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.Pooling));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("minpoolsize", "minimumpoolsize,min pool size,minimum pool size", typeof(uint), 0u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("minpoolsize", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.MinimumPoolSize));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("maxpoolsize", "maximumpoolsize,max pool size,maximum pool size", typeof(uint), 100u, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("maxpoolsize", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.MaximumPoolSize));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("connectionreset", "connection reset", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("connectionreset", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.ConnectionReset));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("cacheserverproperties", "cache server properties", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("cacheserverproperties", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.CacheServerProperties));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("treatblobsasutf8", "treat blobs as utf8", typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("treatblobsasutf8", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.TreatBlobsAsUTF8));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("blobasutf8includepattern", null, typeof(string), "", obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("blobasutf8includepattern", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.BlobAsUTF8IncludePattern));
		MySqlBaseConnectionStringBuilder.Options.Add(new MySqlConnectionStringOption("blobasutf8excludepattern", null, typeof(string), "", obsolete: false, delegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			msb.SetValue("blobasutf8excludepattern", value, ".cctor");
		}, (MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.BlobAsUTF8ExcludePattern));
	}

	public MySqlConnectionStringBuilder()
	{
	}

	public MySqlConnectionStringBuilder(string connStr)
		: base(connStr, isXProtocol: false)
	{
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
}
