using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns15;
using ns20;
using ns21;
using ns24;
using ns6;

namespace MySql.Data.MySqlClient;

[DefaultMember("Item")]
public sealed class MySqlConnectionStringBuilder : DbConnectionStringBuilder
{
	[CompilerGenerated]
	private sealed class Class162
	{
		public string string_0;

		internal bool method_0(MySqlConnectionStringOption mySqlConnectionStringOption_0)
		{
			if (!(mySqlConnectionStringOption_0.Keyword == string_0))
			{
				if (mySqlConnectionStringOption_0.Synonyms != null)
				{
					return mySqlConnectionStringOption_0.Synonyms.Contains(string_0);
				}
				return false;
			}
			return true;
		}
	}

	internal Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private static readonly Class164 class164_0;

	[CompilerGenerated]
	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	[Category("Connection")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Server to connect to")]
	public string Server
	{
		get
		{
			return this[getString_0(107410428)] as string;
		}
		set
		{
			method_2(getString_0(107410428), value, getString_0(107376882));
		}
	}

	[Description("Database to use initially")]
	[Category("Connection")]
	[RefreshProperties(RefreshProperties.All)]
	public string Database
	{
		get
		{
			return dictionary_0[getString_0(107380204)] as string;
		}
		set
		{
			method_2(getString_0(107380204), value, getString_0(107350363));
		}
	}

	[DisplayName("Connection Protocol")]
	[Description("Protocol to use for connection to MySQL")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	public Enum41 ConnectionProtocol
	{
		get
		{
			return (Enum41)dictionary_0[getString_0(107380170)];
		}
		set
		{
			method_2(getString_0(107380170), value, getString_0(107376841));
		}
	}

	[Description("Name of pipe to use when connecting with named pipes (Win32 only)")]
	[Category("Connection")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Pipe Name")]
	public string PipeName
	{
		get
		{
			return (string)dictionary_0[getString_0(107380104)];
		}
		set
		{
			method_2(getString_0(107380104), value, getString_0(107376816));
		}
	}

	[DisplayName("Use Compression")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[Description("Should the connection use compression")]
	public bool UseCompression
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379581)];
		}
		set
		{
			method_2(getString_0(107379581), value, getString_0(107376803));
		}
	}

	[Category("Connection")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Allows execution of multiple SQL commands in a single statement")]
	[DisplayName("Allow Batch")]
	public bool AllowBatch
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379495)];
		}
		set
		{
			method_2(getString_0(107379495), value, getString_0(107376782));
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[Description("Enables output of diagnostic messages")]
	public bool Logging
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379461)];
		}
		set
		{
			method_2(getString_0(107379461), value, getString_0(107376797));
		}
	}

	[DisplayName("Shared Memory Name")]
	[Category("Connection")]
	[Description("Name of the shared memory object to use")]
	[RefreshProperties(RefreshProperties.All)]
	public string SharedMemoryName
	{
		get
		{
			return (string)dictionary_0[getString_0(107379480)];
		}
		set
		{
			method_2(getString_0(107379480), value, getString_0(107377264));
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[Description("Port to use for TCP/IP connections")]
	public uint Port
	{
		get
		{
			return (uint)dictionary_0[getString_0(107410414)];
		}
		set
		{
			method_2(getString_0(107410414), value, getString_0(107377271));
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[Description("The length of time (in seconds) to wait for a connection to the server before terminating the attempt and generating an error.")]
	[DisplayName("Connect Timeout")]
	public uint ConnectionTimeout
	{
		get
		{
			return (uint)dictionary_0[getString_0(107379398)];
		}
		set
		{
			uint num = Math.Min(value, 2147483u);
			if (num != value)
			{
				MySqlTrace.smethod_3(-1, getString_0(107377230) + value + getString_0(107377213) + num + getString_0(107354963));
			}
			method_2(getString_0(107379398), num, getString_0(107377124));
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Connection")]
	[DisplayName("Default Command Timeout")]
	[Description("The default timeout that MySqlCommand objects will use\n                     unless changed.")]
	public uint DefaultCommandTimeout
	{
		get
		{
			return (uint)dictionary_0[getString_0(107379356)];
		}
		set
		{
			method_2(getString_0(107379356), value, getString_0(107377099));
		}
	}

	[DisplayName("User Id")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Indicates the user ID to be used when connecting to the data source.")]
	[Category("Security")]
	public string UserID
	{
		get
		{
			return (string)dictionary_0[getString_0(107379664)];
		}
		set
		{
			method_2(getString_0(107379664), value, getString_0(107377070));
		}
	}

	[Category("Security")]
	[Description("Indicates the password to be used when connecting to the data source.")]
	[PasswordPropertyText(true)]
	[RefreshProperties(RefreshProperties.All)]
	public string Password
	{
		get
		{
			return (string)dictionary_0[getString_0(107353787)];
		}
		set
		{
			method_2(getString_0(107353787), value, getString_0(107377061));
		}
	}

	[DisplayName("Persist Security Info")]
	[Category("Security")]
	[Description("When false, security-sensitive information, such as the password, is not returned as part of the connection if the connection is open or has ever been in an open state.")]
	[RefreshProperties(RefreshProperties.All)]
	public bool PersistSecurityInfo
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379597)];
		}
		set
		{
			method_2(getString_0(107379597), value, getString_0(107377080));
		}
	}

	[Category("Authentication")]
	[Description("Should the connection use SSL.")]
	[Obsolete("Use Ssl Mode instead.")]
	internal bool Encrypt
	{
		get
		{
			return SslMode != Enum42.const_0;
		}
		set
		{
			method_2(getString_0(107377051), value ? Enum42.const_1 : Enum42.const_0, getString_0(107376494));
		}
	}

	[DisplayName("Certificate File")]
	[Description("Certificate file in PKCS#12 format (.pfx)")]
	[Category("Authentication")]
	public string CertificateFile
	{
		get
		{
			return (string)dictionary_0[getString_0(107379014)];
		}
		set
		{
			method_2(getString_0(107379014), value, getString_0(107376481));
		}
	}

	[Category("Authentication")]
	[DisplayName("Certificate Password")]
	[Description("Password for certificate file")]
	public string CertificatePassword
	{
		get
		{
			return (string)dictionary_0[getString_0(107379000)];
		}
		set
		{
			method_2(getString_0(107379000), value, getString_0(107376460));
		}
	}

	[DefaultValue(Enum44.const_0)]
	[Description("Certificate Store Location for client certificates")]
	[Category("Authentication")]
	[DisplayName("Certificate Store Location")]
	public Enum44 CertificateStoreLocation
	{
		get
		{
			return (Enum44)dictionary_0[getString_0(107378894)];
		}
		set
		{
			method_2(getString_0(107378894), value, getString_0(107376431));
		}
	}

	[Description("Certificate thumbprint. Can be used together with Certificate Store Location parameter to uniquely identify certificate to be used for SSL authentication.")]
	[Category("Authentication")]
	[DisplayName("Certificate Thumbprint")]
	public string CertificateThumbprint
	{
		get
		{
			return (string)dictionary_0[getString_0(107378824)];
		}
		set
		{
			method_2(getString_0(107378824), value, getString_0(107376398));
		}
	}

	[DisplayName("Integrated Security")]
	[Category("Authentication")]
	[DefaultValue(false)]
	[Description("Use windows authentication when connecting to server")]
	public bool IntegratedSecurity
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379274)];
		}
		set
		{
			method_2(getString_0(107379274), value, getString_0(107376401));
		}
	}

	[Description("Authentication mechanism")]
	[DefaultValue(MySqlAuthenticationMode.Default)]
	[Category("Authentication")]
	[DisplayName("Auth")]
	public MySqlAuthenticationMode Auth
	{
		get
		{
			return (MySqlAuthenticationMode)dictionary_0[getString_0(107379252)];
		}
		set
		{
			method_2(getString_0(107379252), value, getString_0(107353829));
		}
	}

	[DefaultValue(false)]
	[Description("Allow retrieval of RSA public keys when SSL is disabled")]
	[DisplayName("AllowPublicKeyRetrieval")]
	[Category("Authentication")]
	public bool AllowPublicKeyRetrieval
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379211)];
		}
		set
		{
			method_2(getString_0(107379211), value, getString_0(107376376));
		}
	}

	[DefaultValue(false)]
	[DisplayName("Allow Zero Datetime")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	[Description("Should zero datetimes be supported")]
	public bool AllowZeroDateTime
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379078)];
		}
		set
		{
			method_2(getString_0(107379078), value, getString_0(107376343));
		}
	}

	[DisplayName("Convert Zero Datetime")]
	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(false)]
	[Description("Should illegal datetime values be converted to DateTime.MinValue")]
	public bool ConvertZeroDateTime
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378512)];
		}
		set
		{
			method_2(getString_0(107378512), value, getString_0(107376318));
		}
	}

	[Description("Logs inefficient database operations")]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	[DisplayName("Use Usage Advisor")]
	public bool UseUsageAdvisor
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378486)];
		}
		set
		{
			method_2(getString_0(107378486), value, getString_0(107376257));
		}
	}

	[DisplayName("Procedure Cache Size")]
	[Category("Advanced")]
	[DefaultValue(25)]
	[Description("Indicates how many stored procedures can be cached at one time. A value of 0 effectively disables the procedure cache.")]
	[RefreshProperties(RefreshProperties.All)]
	public uint ProcedureCacheSize
	{
		get
		{
			return (uint)dictionary_0[getString_0(107378420)];
		}
		set
		{
			method_2(getString_0(107378420), value, getString_0(107376748));
		}
	}

	[DefaultValue(false)]
	[DisplayName("Use Performance Monitor")]
	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Indicates that performance counters should be updated during execution.")]
	public bool UsePerformanceMonitor
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378326)];
		}
		set
		{
			method_2(getString_0(107378326), value, getString_0(107376755));
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	[DefaultValue(false)]
	[Description("Instructs the provider to ignore any attempts to prepare a command.")]
	[DisplayName("Ignore Prepare")]
	public bool IgnorePrepare
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378752)];
		}
		set
		{
			method_2(getString_0(107378752), value, getString_0(107376726));
		}
	}

	[Category("Advanced")]
	[Description("Should the connetion automatically enlist in the active connection, if there are any.")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(true)]
	[DisplayName("Auto Enlist")]
	public bool AutoEnlist
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379178)];
		}
		set
		{
			method_2(getString_0(107379178), value, getString_0(107376673));
		}
	}

	[Description("Include security asserts to support Medium Trust")]
	[DisplayName("Include Security Asserts")]
	[DefaultValue(false)]
	[Category("Advanced")]
	public bool IncludeSecurityAsserts
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379144)];
		}
		set
		{
			method_2(getString_0(107379144), value, getString_0(107376656));
		}
	}

	[DefaultValue(true)]
	[Description("Should binary flags on column metadata be respected.")]
	[DisplayName("Respect Binary Flags")]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Advanced")]
	public bool RespectBinaryFlags
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378710)];
		}
		set
		{
			method_2(getString_0(107378710), value, getString_0(107376623));
		}
	}

	[Category("Advanced")]
	[DefaultValue(true)]
	[Description("Should the provider treat TINYINT(1) columns as boolean.")]
	[DisplayName("Treat Tiny As Boolean")]
	[RefreshProperties(RefreshProperties.All)]
	public bool TreatTinyAsBoolean
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378656)];
		}
		set
		{
			method_2(getString_0(107378656), value, getString_0(107376630));
		}
	}

	[DisplayName("Allow User Variables")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(false)]
	[Description("Should the provider expect user variables to appear in the SQL.")]
	[Category("Advanced")]
	public bool AllowUserVariables
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378570)];
		}
		set
		{
			method_2(getString_0(107378570), value, getString_0(107376605));
		}
	}

	[Description("Should this session be considered interactive?")]
	[Category("Advanced")]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Interactive Session")]
	public bool InteractiveSession
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378036)];
		}
		set
		{
			method_2(getString_0(107378036), value, getString_0(107376548));
		}
	}

	[DefaultValue(false)]
	[Description("Should all server functions be treated as returning string?")]
	[Category("Advanced")]
	[DisplayName("Functions Return String")]
	public bool FunctionsReturnString
	{
		get
		{
			return (bool)dictionary_0[getString_0(107377934)];
		}
		set
		{
			method_2(getString_0(107377934), value, getString_0(107376523));
		}
	}

	[Description("Should the returned affected row count reflect affected rows instead of found rows?")]
	[DisplayName("Use Affected Rows")]
	[Category("Advanced")]
	[DefaultValue(false)]
	public bool UseAffectedRows
	{
		get
		{
			return (bool)dictionary_0[getString_0(107377872)];
		}
		set
		{
			method_2(getString_0(107377872), value, getString_0(107375982));
		}
	}

	[Category("Advanced")]
	[Description("Treat binary(16) columns as guids")]
	[DefaultValue(false)]
	[DisplayName("Old Guids")]
	public bool OldGuids
	{
		get
		{
			return (bool)dictionary_0[getString_0(107377826)];
		}
		set
		{
			method_2(getString_0(107377826), value, getString_0(107375993));
		}
	}

	[DisplayName("Keep Alive")]
	[DefaultValue(0)]
	[Description("For TCP connections, idle connection time measured in seconds, before the first keepalive packet is sent.A value of 0 indicates that keepalive is not used.")]
	public uint Keepalive
	{
		get
		{
			return (uint)dictionary_0[getString_0(107377800)];
		}
		set
		{
			method_2(getString_0(107377800), value, getString_0(107375948));
		}
	}

	[DisplayName("Sql Server Mode")]
	[DefaultValue(false)]
	[Description("Allow Sql Server syntax.  A value of yes allows symbols to be enclosed with [] instead of ``.  This does incur a performance hit so only use when necessary.")]
	[Category("Advanced")]
	public bool SqlServerMode
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378282)];
		}
		set
		{
			method_2(getString_0(107378282), value, getString_0(107375967));
		}
	}

	[Description("Enables or disables caching of TableDirect command.  \n            A value of yes enables the cache while no disables it.")]
	[DisplayName("Table Cache")]
	[DefaultValue(false)]
	[Category("Advanced")]
	public bool TableCaching
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378272)];
		}
		set
		{
			method_2(getString_0(107375914), value, getString_0(107375929));
		}
	}

	[Category("Advanced")]
	[DisplayName("Default Table Cache Age")]
	[DefaultValue(60)]
	[Description("Specifies how long a TableDirect result should be cached in seconds.")]
	public int DefaultTableCacheAge
	{
		get
		{
			return (int)dictionary_0[getString_0(107378190)];
		}
		set
		{
			method_2(getString_0(107378190), value, getString_0(107375880));
		}
	}

	[DisplayName("Check Parameters")]
	[Description("Indicates if stored routine parameters should be checked against the server.")]
	[DefaultValue(true)]
	[Category("Advanced")]
	public bool CheckParameters
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378128)];
		}
		set
		{
			method_2(getString_0(107378128), value, getString_0(107375851));
		}
	}

	[DefaultValue(false)]
	[DisplayName("Replication")]
	[Category("Advanced")]
	[Description("Indicates if this connection is to use replicated servers.")]
	public bool Replication
	{
		get
		{
			return (bool)dictionary_0[getString_0(107378082)];
		}
		set
		{
			method_2(getString_0(107378082), value, getString_0(107351610));
		}
	}

	[Category("Advanced")]
	[DisplayName("Exception Interceptors")]
	[Description("The list of interceptors that can triage thrown MySqlExceptions.")]
	public string ExceptionInterceptors
	{
		get
		{
			return (string)dictionary_0[getString_0(107378097)];
		}
		set
		{
			method_2(getString_0(107378097), value, getString_0(107351185));
		}
	}

	[Description("The list of interceptors that can intercept command operations.")]
	[Category("Advanced")]
	[DisplayName("Command Interceptors")]
	public string CommandInterceptors
	{
		get
		{
			return (string)dictionary_0[getString_0(107377523)];
		}
		set
		{
			method_2(getString_0(107377523), value, getString_0(107351668));
		}
	}

	[DefaultValue(0)]
	[RefreshProperties(RefreshProperties.All)]
	[Category("Pooling")]
	[Description("The minimum amount of time (in seconds) for this connection to live in the pool before being destroyed.")]
	[DisplayName("Connection Lifetime")]
	public uint ConnectionLifeTime
	{
		get
		{
			return (uint)dictionary_0[getString_0(107377465)];
		}
		set
		{
			method_2(getString_0(107377465), value, getString_0(107375862));
		}
	}

	[Category("Pooling")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("When true, the connection object is drawn from the appropriate pool, or if necessary, is created and added to the appropriate pool.")]
	[DefaultValue(true)]
	public bool Pooling
	{
		get
		{
			return (bool)dictionary_0[getString_0(107377379)];
		}
		set
		{
			method_2(getString_0(107377379), value, getString_0(107375837));
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Pooling")]
	[Description("The minimum number of connections allowed in the pool.")]
	[DisplayName("Minimum Pool Size")]
	[DefaultValue(0)]
	public uint MinimumPoolSize
	{
		get
		{
			return (uint)dictionary_0[getString_0(107377398)];
		}
		set
		{
			method_2(getString_0(107377398), value, getString_0(107375792));
		}
	}

	[Category("Pooling")]
	[DisplayName("Maximum Pool Size")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(100)]
	[Description("The maximum number of connections allowed in the pool.")]
	public uint MaximumPoolSize
	{
		get
		{
			return (uint)dictionary_0[getString_0(107377284)];
		}
		set
		{
			method_2(getString_0(107377284), value, getString_0(107375803));
		}
	}

	[Description("When true, indicates the connection state is reset when removed from the pool.")]
	[DefaultValue(false)]
	[Category("Pooling")]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Connection Reset")]
	public bool ConnectionReset
	{
		get
		{
			return (bool)dictionary_0[getString_0(107377746)];
		}
		set
		{
			method_2(getString_0(107377746), value, getString_0(107375750));
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Category("Pooling")]
	[Description("When true, server properties will be cached after the first server in the pool is created")]
	[DefaultValue(false)]
	[DisplayName("Cache Server Properties")]
	public bool CacheServerProperties
	{
		get
		{
			return (bool)dictionary_0[getString_0(107377668)];
		}
		set
		{
			method_2(getString_0(107377668), value, getString_0(107375761));
		}
	}

	[DefaultValue("")]
	[Category("Advanced")]
	[DisplayName("Character Set")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Character set this connection should use")]
	public string CharacterSet
	{
		get
		{
			return (string)dictionary_0[getString_0(107377606)];
		}
		set
		{
			method_2(getString_0(107377606), value, getString_0(107376244));
		}
	}

	[Category("Advanced")]
	[Description("Should binary blobs be treated as UTF8")]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	[DisplayName("Treat Blobs As UTF8")]
	public bool TreatBlobsAsUTF8
	{
		get
		{
			return (bool)dictionary_0[getString_0(107377592)];
		}
		set
		{
			method_2(getString_0(107377592), value, getString_0(107376195));
		}
	}

	[Category("Advanced")]
	[Description("Pattern that matches columns that should be treated as UTF8")]
	[RefreshProperties(RefreshProperties.All)]
	public string BlobAsUTF8IncludePattern
	{
		get
		{
			return (string)dictionary_0[getString_0(107376994)];
		}
		set
		{
			method_2(getString_0(107376994), value, getString_0(107376170));
		}
	}

	[Category("Advanced")]
	[RefreshProperties(RefreshProperties.All)]
	[Description("Pattern that matches columns that should not be treated as UTF8")]
	public string BlobAsUTF8ExcludePattern
	{
		get
		{
			return (string)dictionary_0[getString_0(107376961)];
		}
		set
		{
			method_2(getString_0(107376961), value, getString_0(107376137));
		}
	}

	[Description("SSL properties for connection")]
	[Category("Security")]
	[DisplayName("Ssl Mode")]
	[DefaultValue(Enum42.const_0)]
	public Enum42 SslMode
	{
		get
		{
			return (Enum42)dictionary_0[getString_0(107376960)];
		}
		set
		{
			method_2(getString_0(107376960), value, getString_0(107376104));
		}
	}

	[DisplayName("Use Default Command Timeout For EF")]
	[Description("Enforces the command timeout of EFMySqlCommand to the value provided in 'DefaultCommandTimeout' property")]
	[Category("Backwards Compatibility")]
	[DefaultValue(false)]
	public bool UseDefaultCommandTimeoutForEF
	{
		get
		{
			return (bool)dictionary_0[getString_0(107379754)];
		}
		set
		{
			method_2(getString_0(107379754), value, getString_0(107376123));
		}
	}

	[Description("X DevApi: path to a local file that contains a list of trusted TLS/SSL CAs")]
	public string SslCa
	{
		get
		{
			return CertificateFile;
		}
		set
		{
			SslMode = Enum42.const_1;
			CertificateFile = value;
		}
	}

	[Description("X DevApi: path to a local file containing certificate revocation lists")]
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

	internal bool HasProcAccess
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	object DbConnectionStringBuilder.this[string keyword]
	{
		get
		{
			MySqlConnectionStringOption mySqlConnectionStringOption = method_4(keyword);
			return mySqlConnectionStringOption.Getter(this, mySqlConnectionStringOption);
		}
		set
		{
			MySqlConnectionStringOption mySqlConnectionStringOption = method_4(keyword);
			mySqlConnectionStringOption.Setter(this, mySqlConnectionStringOption, value);
		}
	}

	static MySqlConnectionStringBuilder()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlConnectionStringBuilder));
		class164_0 = new Class164();
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107410428), getString_0(107380313), typeof(string), getString_0(107398276), obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107380204), getString_0(107380223), typeof(string), string.Empty, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107380170), getString_0(107380189), typeof(Enum41), Enum41.const_0, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107380172), object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.ConnectionProtocol));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107410414), null, typeof(uint), 3306u, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107380104), getString_0(107380127), typeof(string), getString_0(107379558), obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107380106), object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.PipeName));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379581), getString_0(107379536), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379495), getString_0(107379510), typeof(bool), true, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379461), null, typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107379463), object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.Logging));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379480), getString_0(107379455), typeof(string), getString_0(107379558), obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107379482), object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.SharedMemoryName));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379398), getString_0(107379373), typeof(uint), 15u, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			uint num = (uint)Convert.ChangeType(object_0, mySqlConnectionStringOption_0.BaseType);
			uint num2 = Math.Min(num, 2147483u);
			if (num2 != num)
			{
				MySqlTrace.smethod_3(-1, _003C_003Ec.getString_0(107377232) + num + _003C_003Ec.getString_0(107377215) + num2 + _003C_003Ec.getString_0(107354965));
			}
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107379400), num2, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => (uint)mySqlConnectionStringBuilder_0.dictionary_0[_003C_003Ec.getString_0(107379400)]));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379356), getString_0(107379839), typeof(uint), 30u, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379754), getString_0(107379713), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379664), getString_0(107379651), typeof(string), getString_0(107398276), obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107353787), getString_0(107379634), typeof(string), getString_0(107398276), obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379597), getString_0(107379056), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379059), null, typeof(bool), false, obsolete: true, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringOption_0.method_2(ref object_0);
			MySqlTrace.smethod_3(-1, _003C_003Ec.getString_0(107376004));
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107377053), ((bool)object_0) ? Enum42.const_1 : Enum42.const_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.SslMode != Enum42.const_0));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379014), getString_0(107379025), typeof(string), null, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379000), getString_0(107378971), typeof(string), null, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378894), getString_0(107378861), typeof(Enum44), Enum44.const_0, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378824), getString_0(107379307), typeof(string), null, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379274), getString_0(107379281), typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			if (!Class131.smethod_0())
			{
				throw new MySqlException(_003C_003Ec.getString_0(107375431));
			}
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107375366), object_0.ToString()!.Equals(_003C_003Ec.getString_0(107375337), StringComparison.OrdinalIgnoreCase) ? ((object)true) : object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => (bool)mySqlConnectionStringBuilder_0.dictionary_0[_003C_003Ec.getString_0(107375366)]));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379252), null, typeof(MySqlAuthenticationMode), MySqlAuthenticationMode.Default, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379211), null, typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379178), getString_0(107379193), typeof(bool), true, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379144), getString_0(107379111), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107379078), getString_0(107378541), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378512), getString_0(107378515), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378486), getString_0(107378433), typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107378488), object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.UseUsageAdvisor));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378420), getString_0(107378395), typeof(uint), 25u, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378326), getString_0(107378809), typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107378328), object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.UsePerformanceMonitor));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378752), getString_0(107378699), typeof(bool), true, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378710), getString_0(107378685), typeof(bool), true, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378656), getString_0(107378599), typeof(bool), true, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378570), getString_0(107378577), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378036), getString_0(107378011), typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107378038), object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.InteractiveSession));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377934), getString_0(107377937), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377872), getString_0(107377883), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377826), getString_0(107377845), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377800), getString_0(107377819), typeof(uint), 0u, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378282), getString_0(107378293), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378272), getString_0(107378223), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378190), getString_0(107378193), typeof(int), 60, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378128), getString_0(107378139), typeof(bool), true, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378082), null, typeof(bool), false, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.method_2(_003C_003Ec.getString_0(107378084), object_0, _003C_003Ec.getString_0(107376084));
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.Replication));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107378097), getString_0(107378068), typeof(string), null, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377523), getString_0(107377494), typeof(string), null, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377465), getString_0(107377440), typeof(uint), 0u, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377379), null, typeof(bool), true, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377398), getString_0(107377349), typeof(uint), 0u, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377284), getString_0(107377299), typeof(uint), 100u, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377746), getString_0(107377725), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377668), getString_0(107377639), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377606), getString_0(107377621), typeof(string), getString_0(107398276), obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107377592), getString_0(107377567), typeof(bool), false, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107376994), null, typeof(string), getString_0(107398276), obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107376961), null, typeof(string), getString_0(107398276), obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107376960), getString_0(107376947), typeof(Enum42), Enum42.const_1, obsolete: false));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107376922), getString_0(107376913), typeof(string), null, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.SslCa = object_0 as string;
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.SslCa));
		class164_0.Add(new MySqlConnectionStringOption(getString_0(107376872), getString_0(107376895), typeof(string), null, obsolete: false, delegate(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0, object object_0)
		{
			mySqlConnectionStringBuilder_0.SslCrl = object_0 as string;
		}, (MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringBuilder_0.SslCrl));
	}

	public MySqlConnectionStringBuilder()
	{
		HasProcAccess = true;
		lock (this)
		{
			foreach (MySqlConnectionStringOption option in class164_0.Options)
			{
				dictionary_0[option.Keyword] = option.DefaultValue;
			}
		}
	}

	public MySqlConnectionStringBuilder(string connStr)
		: this()
	{
		method_6(connStr);
		lock (this)
		{
			base.ConnectionString = connStr;
		}
	}

	internal Regex method_0()
	{
		if (string.IsNullOrEmpty(BlobAsUTF8IncludePattern))
		{
			return null;
		}
		return new Regex(BlobAsUTF8IncludePattern);
	}

	internal Regex method_1()
	{
		if (string.IsNullOrEmpty(BlobAsUTF8ExcludePattern))
		{
			return null;
		}
		return new Regex(BlobAsUTF8ExcludePattern);
	}

	void DbConnectionStringBuilder.Clear()
	{
		base.Clear();
		lock (this)
		{
			foreach (MySqlConnectionStringOption option in class164_0.Options)
			{
				if (option.DefaultValue != null)
				{
					dictionary_0[option.Keyword] = option.DefaultValue;
				}
				else
				{
					dictionary_0[option.Keyword] = null;
				}
			}
		}
	}

	internal void method_2(string string_0, object object_0, [CallerMemberName] string string_1 = "")
	{
		MySqlConnectionStringOption mySqlConnectionStringOption = method_4(string_0);
		if (string_1 != getString_0(107376082) && mySqlConnectionStringOption.IsCustomized)
		{
			this[string_0] = object_0;
		}
		else
		{
			method_3(string_0, object_0);
		}
	}

	internal void method_3(string string_0, object object_0)
	{
		MySqlConnectionStringOption mySqlConnectionStringOption = method_4(string_0);
		mySqlConnectionStringOption.method_2(ref object_0);
		mySqlConnectionStringOption.method_1(this);
		if (object_0 != null)
		{
			lock (this)
			{
				dictionary_0[mySqlConnectionStringOption.Keyword] = object_0;
				base[string_0] = object_0;
			}
		}
	}

	private MySqlConnectionStringOption method_4(string string_0)
	{
		MySqlConnectionStringOption mySqlConnectionStringOption = class164_0.method_0(string_0);
		if (mySqlConnectionStringOption == null)
		{
			throw new ArgumentException(Class121.KeywordNotSupported, string_0);
		}
		return mySqlConnectionStringOption;
	}

	bool DbConnectionStringBuilder.ContainsKey(string keyword)
	{
		return class164_0.method_0(keyword) != null;
	}

	bool DbConnectionStringBuilder.Remove(string keyword)
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
		MySqlConnectionStringOption mySqlConnectionStringOption = method_4(keyword);
		lock (this)
		{
			dictionary_0[mySqlConnectionStringOption.Keyword] = mySqlConnectionStringOption.DefaultValue;
		}
		return true;
	}

	public string method_5(bool bool_1)
	{
		if (bool_1)
		{
			return base.ConnectionString;
		}
		StringBuilder stringBuilder = new StringBuilder();
		string text = getString_0(107398276);
		foreach (string key in Keys)
		{
			if (string.Compare(key, getString_0(107353787), StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(key, getString_0(107379634), StringComparison.OrdinalIgnoreCase) != 0)
			{
				stringBuilder.AppendFormat(CultureInfo.CurrentCulture, getString_0(107376041), new object[3]
				{
					text,
					key,
					this[key]
				});
				text = getString_0(107409227);
			}
		}
		return stringBuilder.ToString();
	}

	bool object.Equals(object obj)
	{
		MySqlConnectionStringBuilder mySqlConnectionStringBuilder = obj as MySqlConnectionStringBuilder;
		if (obj == null)
		{
			return false;
		}
		if (dictionary_0.Count != mySqlConnectionStringBuilder.dictionary_0.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, object> item in dictionary_0)
		{
			if (mySqlConnectionStringBuilder.dictionary_0.ContainsKey(item.Key))
			{
				object obj2 = mySqlConnectionStringBuilder.dictionary_0[item.Key];
				if (obj2 != null || item.Value == null)
				{
					if (item.Value != null || obj2 == null)
					{
						if (item.Value != null || obj2 != null)
						{
							if (!obj2.Equals(item.Value))
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

	int object.GetHashCode()
	{
		return base.GetHashCode();
	}

	private void method_6(string string_0)
	{
		string[] array = string_0.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
		List<string> list = new List<string>();
		bool flag = false;
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num >= array2.Length)
			{
				return;
			}
			string obj = array2[num];
			string[] array3 = obj.Split(new char[1] { '=' });
			if (array3.Length % 2 == 0)
			{
				string string_ = array3[0].ToLowerInvariant().Trim();
				string text = array3[1].ToLowerInvariant();
				MySqlConnectionStringOption mySqlConnectionStringOption = class164_0.Options.Where((MySqlConnectionStringOption mySqlConnectionStringOption_0) => mySqlConnectionStringOption_0.Keyword == string_ || (mySqlConnectionStringOption_0.Synonyms != null && mySqlConnectionStringOption_0.Synonyms.Contains(string_))).FirstOrDefault();
				if (mySqlConnectionStringOption != null && (!(mySqlConnectionStringOption.Keyword != getString_0(107376960)) || !(mySqlConnectionStringOption.Keyword != getString_0(107379000)) || !(mySqlConnectionStringOption.Keyword != getString_0(107376872)) || !(mySqlConnectionStringOption.Keyword != getString_0(107376922))))
				{
					if (list.Contains(mySqlConnectionStringOption.Keyword))
					{
						throw new ArgumentException(string.Format(Class121.DuplicatedSslConnectionOption, string_));
					}
					if (mySqlConnectionStringOption.Keyword == getString_0(107376960) && (text == getString_0(107376056) || text == getString_0(107376015)))
					{
						flag = true;
					}
					if (flag && (mySqlConnectionStringOption.Keyword == getString_0(107379000) || mySqlConnectionStringOption.Keyword == getString_0(107376872) || mySqlConnectionStringOption.Keyword == getString_0(107376922)))
					{
						break;
					}
					list.Add(mySqlConnectionStringOption.Keyword);
				}
			}
			num++;
		}
		throw new ArgumentException(Class121.InvalidOptionWhenSslDisabled);
	}
}
