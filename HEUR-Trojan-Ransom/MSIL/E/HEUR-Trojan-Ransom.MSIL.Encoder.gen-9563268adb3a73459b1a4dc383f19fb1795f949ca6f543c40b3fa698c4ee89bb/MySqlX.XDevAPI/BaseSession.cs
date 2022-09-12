using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.Failover;
using MySql.Data.MySqlClient;
using MySql.Data.common;
using MySqlX.Common;
using MySqlX.Sessions;
using MySqlX.XDevAPI.Relational;

namespace MySqlX.XDevAPI;

public abstract class BaseSession : IDisposable
{
	private InternalSession _internalSession;

	private string _connectionString;

	private bool _isDefaultPort = true;

	private const uint X_PROTOCOL_DEFAULT_PORT = 33060u;

	private const char CONNECTION_DATA_KEY_SEPARATOR = ';';

	private const char CONNECTION_DATA_VALUE_SEPARATOR = '=';

	private const string PORT_CONNECTION_OPTION_KEYWORD = "port";

	private const string SERVER_CONNECTION_OPTION_KEYWORD = "server";

	private const string CONNECT_TIMEOUT_CONNECTION_OPTION_KEYWORD = "connect-timeout";

	private const string CONNECTION_ATTRIBUTES_CONNECTION_OPTION_KEYWORD = "connection-attributes";

	private const string DNS_SRV_CONNECTION_OPTION_KEYWORD = "dns-srv";

	private const string DNS_SRV_URI_SCHEME = "mysqlx+srv";

	private const string MYSQLX_URI_SCHEME = "mysqlx";

	private const string SSH_URI_SCHEME = "mysqlx+ssh";

	internal QueueTaskScheduler _scheduler = new QueueTaskScheduler();

	protected readonly Client _client;

	private DBVersion? _version;

	private int? _threadId;

	private bool disposedValue;

	internal InternalSession InternalSession
	{
		get
		{
			if (_internalSession == null)
			{
				throw new MySqlException(ResourcesX.InvalidSession);
			}
			return _internalSession;
		}
	}

	internal XInternalSession XSession => InternalSession as XInternalSession;

	internal DateTime IdleSince { get; set; }

	internal DBVersion Version
	{
		get
		{
			DBVersion? version = _version;
			if (!version.HasValue)
			{
				DBVersion? dBVersion = (_version = XSession.GetServerVersion());
				return dBVersion.Value;
			}
			return version.GetValueOrDefault();
		}
	}

	internal int ThreadId
	{
		get
		{
			int? threadId = _threadId;
			if (!threadId.HasValue)
			{
				int? num = (_threadId = XSession.GetThreadId());
				return num.Value;
			}
			return threadId.GetValueOrDefault();
		}
	}

	internal bool SupportsPreparedStatements { get; set; } = true;


	public MySqlXConnectionStringBuilder Settings { get; private set; }

	public Schema Schema { get; protected set; }

	public Schema DefaultSchema { get; private set; }

	public string Uri
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(string.Format("mysqlx://{0}:{1}{2}?", Settings.Server, Settings.Port, string.IsNullOrEmpty(Settings.Database) ? string.Empty : ("/" + Settings.Database)));
			bool flag = false;
			bool flag2 = false;
			foreach (KeyValuePair<string, object> item in Settings.values)
			{
				if (item.Key == "server" || item.Key == "database" || item.Key == "port" || ((item.Key == "certificatefile" || item.Key == "sslca") && flag2))
				{
					continue;
				}
				try
				{
					object obj = Settings[item.Key];
					object defaultValue = MySqlXConnectionStringBuilder.Options.Values.First((MySqlConnectionStringOption o) => o.Keyword == item.Key || (o.Synonyms != null && o.Synonyms.Contains(item.Key))).DefaultValue;
					if (obj != null && (defaultValue == null || obj.ToString() != defaultValue.ToString()))
					{
						if (!flag)
						{
							flag = true;
						}
						else
						{
							stringBuilder.Append("&");
						}
						if (!(item.Key == "certificatefile") && !(item.Key == "sslca"))
						{
							stringBuilder.Append(item.Key);
						}
						else
						{
							flag2 = true;
							stringBuilder.Append("sslca");
						}
						stringBuilder.Append("=");
						stringBuilder.Append((obj is bool) ? obj.ToString()!.ToLower() : obj.ToString());
					}
				}
				catch (NotSupportedException)
				{
				}
				catch (ArgumentException)
				{
				}
			}
			return stringBuilder.ToString();
		}
	}

	internal BaseSession(string connectionString, Client client = null)
		: this()
	{
		if (string.IsNullOrWhiteSpace(connectionString))
		{
			throw new ArgumentNullException("connectionString");
		}
		_client = client;
		_connectionString = ParseConnectionData(connectionString, client);
		if (FailoverManager.FailoverGroup != null)
		{
			List<FailoverServer> hosts = FailoverManager.FailoverGroup.Hosts;
			if (hosts != null && hosts.Count > 1)
			{
				_internalSession = FailoverManager.AttemptConnectionXProtocol(_connectionString, out _connectionString, _isDefaultPort, client);
				Settings.ConnectionString = _connectionString;
				Settings.AnalyzeConnectionString(_connectionString, isXProtocol: true, _isDefaultPort);
				goto IL_0190;
			}
		}
		Settings.ConnectionString = _connectionString;
		if (!_connectionString.Contains("sslmode") && !_connectionString.Contains("ssl mode") && !_connectionString.Contains("ssl-mode"))
		{
			Settings.SslMode = MySqlSslMode.Required;
		}
		Settings.AnalyzeConnectionString(_connectionString, isXProtocol: true, _isDefaultPort);
		if (Settings.DnsSrv)
		{
			FailoverManager.SetHostList(DnsResolver.GetDnsSrvRecords(Settings.Server).ConvertAll((DnsSrvRecord r) => new FailoverServer(r.Target, r.Port, r.Priority)), FailoverMethod.Sequential);
			_internalSession = FailoverManager.AttemptConnectionXProtocol(_connectionString, out _connectionString, _isDefaultPort, client);
			Settings.ConnectionString = _connectionString;
		}
		else
		{
			_internalSession = InternalSession.GetSession(Settings);
		}
		goto IL_0190;
		IL_0190:
		if (!string.IsNullOrWhiteSpace(Settings.Database))
		{
			DefaultSchema = GetSchema(Settings.Database);
		}
	}

	internal BaseSession(object connectionData, Client client = null)
		: this()
	{
		if (connectionData == null)
		{
			throw new ArgumentNullException("connectionData");
		}
		_client = client;
		if (client == null)
		{
			FailoverManager.Reset();
		}
		Dictionary<string, object> dictionaryFromAnonymous = Tools.GetDictionaryFromAnonymous(connectionData);
		if (!dictionaryFromAnonymous.Keys.Any((string s) => s.ToLowerInvariant() == "port"))
		{
			dictionaryFromAnonymous.Add("port", 33060u);
		}
		bool flag = false;
		foreach (KeyValuePair<string, object> item in dictionaryFromAnonymous)
		{
			if (Settings.ContainsKey(item.Key))
			{
				Settings.SetValue(item.Key, item.Value, ".ctor");
				if (flag || string.IsNullOrEmpty(Settings["server"].ToString()))
				{
					continue;
				}
				string text = item.Value.ToString();
				if (IsUnixSocket(text))
				{
					Settings.SetValue(item.Key, text = NormalizeUnixSocket(text), ".ctor");
				}
				FailoverManager.ParseHostList(text, isXProtocol: true, connectionDataIsUri: false);
				if (FailoverManager.FailoverGroup != null)
				{
					List<FailoverServer> hosts = FailoverManager.FailoverGroup.Hosts;
					if (hosts != null && hosts.Count > 1)
					{
						Settings["server"] = null;
						goto IL_017f;
					}
				}
				if (FailoverManager.FailoverGroup != null)
				{
					Settings["server"] = FailoverManager.FailoverGroup.Hosts[0].Host;
				}
				goto IL_017f;
			}
			throw new KeyNotFoundException(string.Format(ResourcesX.InvalidConnectionStringAttribute, item.Key));
			IL_017f:
			flag = true;
		}
		_connectionString = Settings.ToString();
		Settings.AnalyzeConnectionString(_connectionString, isXProtocol: true, _isDefaultPort);
		if (FailoverManager.FailoverGroup != null)
		{
			List<FailoverServer> hosts2 = FailoverManager.FailoverGroup.Hosts;
			if (hosts2 != null && hosts2.Count > 1)
			{
				_internalSession = FailoverManager.AttemptConnectionXProtocol(_connectionString, out _connectionString, _isDefaultPort, client);
				Settings.ConnectionString = _connectionString;
				goto IL_02be;
			}
		}
		if (Settings.DnsSrv)
		{
			FailoverManager.SetHostList(DnsResolver.GetDnsSrvRecords(Settings.Server).ConvertAll((DnsSrvRecord r) => new FailoverServer(r.Target, r.Port, null)), FailoverMethod.Sequential);
			_internalSession = FailoverManager.AttemptConnectionXProtocol(_connectionString, out _connectionString, _isDefaultPort, client);
			Settings.ConnectionString = _connectionString;
		}
		else
		{
			_internalSession = InternalSession.GetSession(Settings);
		}
		goto IL_02be;
		IL_02be:
		if (!string.IsNullOrWhiteSpace(Settings.Database))
		{
			DefaultSchema = GetSchema(Settings.Database);
		}
	}

	internal BaseSession(InternalSession internalSession, Client client)
	{
		_internalSession = internalSession;
		Settings = internalSession.Settings;
		_client = client;
	}

	internal BaseSession()
	{
		Settings = new MySqlXConnectionStringBuilder();
	}

	public void DropSchema(string schema)
	{
		if (string.IsNullOrWhiteSpace(schema))
		{
			throw new ArgumentNullException("schema");
		}
		if (GetSchema(schema).ExistsInDatabase())
		{
			InternalSession.ExecuteSqlNonQuery("DROP DATABASE `" + schema + "`");
		}
	}

	public Schema CreateSchema(string schema)
	{
		InternalSession.ExecuteSqlNonQuery("CREATE DATABASE `" + schema + "`");
		return new Schema(this, schema);
	}

	public Schema GetSchema(string schema)
	{
		Schema = new Schema(this, schema);
		return Schema;
	}

	public List<Schema> GetSchemas()
	{
		RowResult sqlRowResult = XSession.GetSqlRowResult("select * from information_schema.schemata");
		sqlRowResult.FetchAll();
		return sqlRowResult.Rows.Select((Row row) => new Schema(this, row.GetString("schema_name"))).ToList();
	}

	public void StartTransaction()
	{
		InternalSession.ExecuteSqlNonQuery("START TRANSACTION");
	}

	public void Commit()
	{
		InternalSession.ExecuteSqlNonQuery("COMMIT");
	}

	public void Rollback()
	{
		InternalSession.ExecuteSqlNonQuery("ROLLBACK");
	}

	public void Close()
	{
		if (XSession.SessionState != 0)
		{
			if (_client == null)
			{
				CloseFully();
				return;
			}
			_client.ReleaseSession(this);
			XSession.SetState(SessionState.Closed, broadcast: false);
			_internalSession = null;
		}
	}

	internal void CloseFully()
	{
		XSession.Close();
	}

	internal void Reset()
	{
		XSession.ResetSession();
	}

	public string SetSavepoint()
	{
		return SetSavepoint("savepoint_" + Guid.NewGuid().ToString().Replace("-", "_"));
	}

	public string SetSavepoint(string name)
	{
		InternalSession.ExecuteSqlNonQuery("SAVEPOINT " + name);
		return name;
	}

	public void ReleaseSavepoint(string name)
	{
		InternalSession.ExecuteSqlNonQuery("RELEASE SAVEPOINT " + name);
	}

	public void RollbackTo(string name)
	{
		InternalSession.ExecuteSqlNonQuery("ROLLBACK TO " + name);
	}

	protected internal string ParseConnectionData(string connectionData, Client client = null)
	{
		if (client == null)
		{
			FailoverManager.Reset();
		}
		if (Regex.IsMatch(connectionData, "^mysqlx(\\+\\w+)?://.*", RegexOptions.IgnoreCase))
		{
			return ParseConnectionUri(connectionData);
		}
		return ParseConnectionString(connectionData);
	}

	private string ParseConnectionUri(string connectionUri)
	{
		Uri uri = null;
		string text = null;
		bool flag = false;
		string text2 = null;
		try
		{
			uri = new Uri(connectionUri);
		}
		catch (UriFormatException ex)
		{
			if (ex.Message != "Invalid URI: The hostname could not be parsed.")
			{
				throw ex;
			}
			string[] array = connectionUri.Split('@', '?');
			if (array.Length == 1)
			{
				throw ex;
			}
			text2 = array[1];
			string text3 = string.Empty;
			flag = IsUnixSocket(text2);
			bool flag2 = text2.StartsWith("[") && text2.Contains("]");
			if ((!flag && text2.Contains("/") && !flag2) || (flag && text2.Contains(")/")) || (text2.StartsWith("[") && text2.Contains("]/") && flag2))
			{
				text3 = text2.Substring(text2.LastIndexOf('/') + 1);
				text2 = text2.Substring(0, text2.Length - text3.Length - 1);
			}
			if (flag)
			{
				text = array[0] + "@localhost" + ((text3 != string.Empty) ? ("/" + text3) : string.Empty) + ((array.Length > 2) ? ("?" + array[2]) : string.Empty);
			}
			else if (flag2)
			{
				text2 = text2.Substring(1, text2.Length - 2);
				int num = FailoverManager.ParseHostList(text2, isXProtocol: true);
				if (FailoverManager.FailoverGroup != null)
				{
					text2 = FailoverManager.FailoverGroup.ActiveHost.Host;
					flag = IsUnixSocket(FailoverManager.FailoverGroup.ActiveHost.Host);
					text = array[0] + "@" + (flag ? "localhost" : text2) + ((FailoverManager.FailoverGroup.ActiveHost.Port != -1) ? (":" + FailoverManager.FailoverGroup.ActiveHost.Port) : string.Empty) + ((text3 != string.Empty) ? ("/" + text3) : string.Empty) + ((array.Length == 3) ? ("?" + array[2]) : string.Empty);
				}
				else
				{
					if (num != 1)
					{
						throw ex;
					}
					text = array[0] + "@" + text2 + ((text3 != string.Empty) ? ("/" + text3) : string.Empty) + ((array.Length == 3) ? ("?" + array[2]) : string.Empty);
				}
			}
		}
		if (uri == null)
		{
			uri = ((text == null) ? new Uri(connectionUri) : new Uri(text));
		}
		if (uri.Scheme == "mysqlx+srv")
		{
			if (FailoverManager.FailoverGroup != null)
			{
				List<FailoverServer> hosts = FailoverManager.FailoverGroup.Hosts;
				if (hosts != null && hosts.Count > 1)
				{
					throw new ArgumentException(Resources.DnsSrvInvalidConnOptionMultihost);
				}
			}
			if (!uri.IsDefaultPort)
			{
				throw new ArgumentException(Resources.DnsSrvInvalidConnOptionPort);
			}
			if (flag)
			{
				throw new ArgumentException(Resources.DnsSrvInvalidConnOptionUnixSocket);
			}
		}
		else if (uri.Scheme != "mysqlx" && uri.Scheme != "mysqlx+ssh")
		{
			throw new ArgumentException(string.Format(ResourcesX.DnsSrvInvalidScheme, uri.Scheme));
		}
		return ConvertToConnectionString(uri, text2, flag, uri.Scheme == "mysqlx+srv");
	}

	internal static bool IsUnixSocket(string unixSocket)
	{
		if (!unixSocket.StartsWith(".") && !unixSocket.StartsWith("/") && !unixSocket.StartsWith("(.") && !unixSocket.StartsWith("(/") && !unixSocket.StartsWith("%2") && !unixSocket.StartsWith("(%2"))
		{
			return false;
		}
		return true;
	}

	private string ConvertToConnectionString(Uri uri, string unixSocketPath, bool parseServerAsUnixSocket, bool isDnsSrvScheme)
	{
		List<string> list = new List<string>();
		if (string.IsNullOrWhiteSpace(uri.Host))
		{
			throw new UriFormatException(ResourcesX.InvalidUriData + "host");
		}
		list.Add("server=" + (parseServerAsUnixSocket ? NormalizeUnixSocket(unixSocketPath) : uri.Host));
		list.Add("port=" + ((uri.Port == -1) ? 33060 : uri.Port));
		_isDefaultPort = uri.IsDefaultPort;
		if (uri.Scheme == "mysqlx+srv")
		{
			list.Add("dns-srv=true");
		}
		if (!string.IsNullOrWhiteSpace(uri.UserInfo))
		{
			string[] array = uri.UserInfo.Split(new char[1] { ':' });
			if (array.Length > 2)
			{
				throw new UriFormatException(ResourcesX.InvalidUriData + "user info");
			}
			list.Add("uid=" + System.Uri.UnescapeDataString(array[0]));
			if (array.Length > 1)
			{
				list.Add("password=" + System.Uri.UnescapeDataString(array[1]));
			}
		}
		if (uri.Segments.Length > 2)
		{
			throw new UriFormatException(ResourcesX.InvalidUriData + "segments");
		}
		if (uri.Segments.Length > 1)
		{
			list.Add("database=" + System.Uri.UnescapeDataString(uri.Segments[1]));
		}
		if (!string.IsNullOrWhiteSpace(uri.Query))
		{
			string[] array2 = System.Uri.UnescapeDataString(uri.Query).Substring(1).Split(new char[1] { '&' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string text in array2)
			{
				string[] array3 = text.Replace(";", string.Empty).Split(new char[1] { '=' });
				MySqlConnectionStringOption mySqlConnectionStringOption = MySqlXConnectionStringBuilder.Options.Options.First((MySqlConnectionStringOption item) => item.Keyword == "connection-attributes");
				MySqlConnectionStringOption mySqlConnectionStringOption2 = MySqlXConnectionStringBuilder.Options.Options.First((MySqlConnectionStringOption item) => item.Keyword == "dns-srv");
				string item2;
				if (!(mySqlConnectionStringOption.Keyword == array3[0]) && (!mySqlConnectionStringOption.Synonyms.Contains(array3[0]) || array3.Count() <= 2))
				{
					if (array3.Length > 2)
					{
						throw new ArgumentException(ResourcesX.InvalidUriQuery + ":" + array3[0]);
					}
					MySqlConnectionStringOption mySqlConnectionStringOption3 = MySqlXConnectionStringBuilder.Options.Options.First((MySqlConnectionStringOption item) => item.Keyword == "connect-timeout");
					if ((mySqlConnectionStringOption3.Keyword == array3[0] || mySqlConnectionStringOption3.Synonyms.Contains(array3[0])) && string.IsNullOrWhiteSpace(array3[1]))
					{
						throw new FormatException(ResourcesX.InvalidConnectionTimeoutValue);
					}
					item2 = array3[0] + "=" + ((array3.Length == 2) ? array3[1] : "true").Replace("(", string.Empty).Replace(")", string.Empty);
				}
				else
				{
					if (array3[1] == string.Empty)
					{
						throw new MySqlException(ResourcesX.InvalidUriQuery + ": " + array3[0]);
					}
					item2 = array3[0] + "=" + text.Replace(array3[0] + "=", string.Empty);
				}
				if (!isDnsSrvScheme || (!(mySqlConnectionStringOption2.Keyword == array3[0]) && !mySqlConnectionStringOption2.Synonyms.Contains(array3[0])) || Convert.ToBoolean(array3[1]))
				{
					if (!isDnsSrvScheme || (!(mySqlConnectionStringOption2.Keyword == array3[0]) && !mySqlConnectionStringOption2.Synonyms.Contains(array3[0])))
					{
						list.Add(item2);
					}
					continue;
				}
				throw new ArgumentException(string.Format(ResourcesX.DnsSrvConflictingOptions, mySqlConnectionStringOption2.Keyword));
			}
		}
		return string.Join("; ", list);
	}

	private string ParseConnectionString(string connectionString)
	{
		string text = string.Empty;
		bool flag = false;
		bool flag2 = false;
		Dictionary<string, string> dictionary = (from item in connectionString.Split(new char[1] { ';' })
			select item.Split(new char[1] { '=' }, 2) into item
			where item.Length == 2
			select item).ToDictionary((string[] item) => item[0], (string[] item) => item[1]);
		MySqlConnectionStringOption mySqlConnectionStringOption = MySqlXConnectionStringBuilder.Options.Options.First((MySqlConnectionStringOption item) => item.Keyword == "server");
		MySqlConnectionStringOption mySqlConnectionStringOption2 = MySqlXConnectionStringBuilder.Options.Options.First((MySqlConnectionStringOption item) => item.Keyword == "connect-timeout");
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			if (!(item.Value == "=") && !(item.Value == "\""))
			{
				if (item.Key != mySqlConnectionStringOption.Keyword && !mySqlConnectionStringOption.Synonyms.Contains(item.Key))
				{
					if ((mySqlConnectionStringOption2.Keyword == item.Key || mySqlConnectionStringOption2.Synonyms.Contains(item.Key)) && string.IsNullOrWhiteSpace(item.Value))
					{
						throw new FormatException(ResourcesX.InvalidConnectionTimeoutValue);
					}
					if (item.Key == "port")
					{
						flag = true;
					}
					if (item.Key == "dns-srv")
					{
						flag2 = Convert.ToBoolean(item.Value);
					}
					text += $"{item.Key}{'='}{item.Value}{';'}";
				}
				else
				{
					string text2 = item.Value;
					if (IsUnixSocket(item.Value))
					{
						text2 = NormalizeUnixSocket(item.Value);
					}
					if (FailoverManager.ParseHostList(text2, isXProtocol: true, connectionDataIsUri: false) == 1 && FailoverManager.FailoverGroup == null)
					{
						text = string.Format("{0}{1}{2}{3}{4}", "server", '=', text2, ';', text);
					}
				}
				continue;
			}
			throw new MySqlException(string.Format(Resources.InvalidConnectionStringValue, (item.Value == "\"") ? ";" : "=", item.Key));
		}
		if (flag2)
		{
			if (flag)
			{
				throw new ArgumentException(Resources.DnsSrvInvalidConnOptionPort);
			}
			if (FailoverManager.FailoverGroup != null)
			{
				throw new ArgumentException(Resources.DnsSrvInvalidConnOptionMultihost);
			}
		}
		if (FailoverManager.FailoverGroup == null)
		{
			if (!flag)
			{
				return string.Format("{0}{1}{2}{3}{4}", text, ';', "port", '=', 33060u);
			}
			return text;
		}
		return string.Format("{0}{1}{2}{3}", "server", '=', FailoverManager.FailoverGroup.ActiveHost.Host, ';') + ((!flag) ? string.Format("{0}{1}{2}{3}", "port", '=', 33060u, ';') : string.Empty) + text;
	}

	internal static string NormalizeUnixSocket(string unixSocket)
	{
		unixSocket = unixSocket.Replace("%2F", "/");
		if (unixSocket.StartsWith("(") && unixSocket.EndsWith(")"))
		{
			unixSocket = unixSocket.Substring(1, unixSocket.Length - 2);
		}
		return unixSocket;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue)
		{
			if (disposing)
			{
				Close();
			}
			disposedValue = true;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}
}
