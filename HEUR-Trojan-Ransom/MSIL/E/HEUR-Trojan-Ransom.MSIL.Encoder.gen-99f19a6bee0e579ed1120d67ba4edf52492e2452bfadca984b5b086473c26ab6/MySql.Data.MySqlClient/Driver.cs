using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security;
using System.Text;
using MySql.Data.Common;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

internal class Driver : IDisposable
{
	protected Encoding encoding;

	protected MySqlConnectionStringBuilder ConnectionString;

	protected DateTime creationTime;

	protected string serverCharSet;

	protected Dictionary<string, string> serverProps;

	internal int timeZoneOffset;

	private bool firstResult;

	protected IDriver handler;

	internal MySqlDataReader reader;

	private bool disposed;

	public DateTime IdleSince { get; set; }

	public int ThreadID => handler.ThreadId;

	public DBVersion Version => handler.Version;

	public MySqlConnectionStringBuilder Settings
	{
		get
		{
			return ConnectionString;
		}
		set
		{
			ConnectionString = value;
		}
	}

	public Encoding Encoding
	{
		get
		{
			return encoding;
		}
		set
		{
			encoding = value;
		}
	}

	public MySqlPromotableTransaction currentTransaction { get; set; }

	public bool IsInActiveUse { get; set; }

	public bool IsOpen { get; protected set; }

	public MySqlPool Pool { get; set; }

	public long MaxPacketSize { get; protected set; }

	protected internal int ConnectionCharSetIndex { get; set; }

	protected internal Dictionary<int, string> CharacterSets { get; protected set; }

	public bool SupportsOutputParameters => Version.isAtLeast(5, 5, 0);

	public bool SupportsBatch => (handler.Flags & ClientFlags.MULTI_STATEMENTS) > (ClientFlags)0uL;

	public bool SupportsConnectAttrs => (handler.Flags & ClientFlags.CONNECT_ATTRS) > (ClientFlags)0uL;

	public bool SupportsPasswordExpiration => (handler.Flags & ClientFlags.CAN_HANDLE_EXPIRED_PASSWORD) > (ClientFlags)0uL;

	public bool IsPasswordExpired { get; internal set; }

	public Driver(MySqlConnectionStringBuilder settings)
	{
		encoding = Encoding.GetEncoding("UTF-8");
		if (encoding == null)
		{
			throw new MySqlException(Resources.DefaultEncodingNotFound);
		}
		ConnectionString = settings;
		serverCharSet = "utf8";
		ConnectionCharSetIndex = -1;
		MaxPacketSize = 1024L;
		handler = new NativeDriver(this);
	}

	~Driver()
	{
		Dispose(disposing: false);
	}

	public string Property(string key)
	{
		return serverProps[key];
	}

	public bool ConnectionLifetimeExpired()
	{
		TimeSpan timeSpan = DateTime.Now.Subtract(creationTime);
		if (Settings.ConnectionLifeTime != 0)
		{
			return timeSpan.TotalSeconds > (double)Settings.ConnectionLifeTime;
		}
		return false;
	}

	public static Driver Create(MySqlConnectionStringBuilder settings)
	{
		Driver driver = null;
		try
		{
			if (MySqlTrace.QueryAnalysisEnabled || settings.Logging || settings.UseUsageAdvisor)
			{
				driver = new TracingDriver(settings);
			}
		}
		catch (TypeInitializationException ex)
		{
			if (!(ex.InnerException is SecurityException))
			{
				throw ex;
			}
		}
		if (driver == null)
		{
			driver = new Driver(settings);
		}
		try
		{
			driver.Open();
			return driver;
		}
		catch
		{
			driver.Dispose();
			throw;
		}
	}

	public bool HasStatus(ServerStatusFlags flag)
	{
		return (handler.ServerStatus & flag) != 0;
	}

	public virtual void Open()
	{
		int num = 0;
		while (true)
		{
			try
			{
				creationTime = DateTime.Now;
				handler.Open();
				IsOpen = true;
				break;
			}
			catch (IOException)
			{
				if (num++ >= 5)
				{
					throw;
				}
			}
		}
	}

	public virtual void Close()
	{
		Dispose();
	}

	public virtual void Configure(MySqlConnection connection)
	{
		bool flag = false;
		if (serverProps == null)
		{
			flag = true;
			try
			{
				if (Pool != null && Settings.CacheServerProperties)
				{
					if (Pool.ServerProperties == null)
					{
						Pool.ServerProperties = LoadServerProperties(connection);
					}
					serverProps = Pool.ServerProperties;
				}
				else
				{
					serverProps = LoadServerProperties(connection);
				}
				LoadCharacterSets(connection);
			}
			catch (MySqlException ex)
			{
				if (ex.Number != 1820)
				{
					throw;
				}
				IsPasswordExpired = true;
				return;
			}
		}
		if (Settings.ConnectionReset || flag)
		{
			string text = ConnectionString.CharacterSet;
			if (string.IsNullOrEmpty(text))
			{
				text = ((ConnectionCharSetIndex < 0 || !CharacterSets.ContainsKey(ConnectionCharSetIndex)) ? serverCharSet : CharacterSets[ConnectionCharSetIndex]);
			}
			if (serverProps.ContainsKey("max_allowed_packet"))
			{
				MaxPacketSize = Convert.ToInt64(serverProps["max_allowed_packet"]);
			}
			MySqlCommand obj = new MySqlCommand("SET character_set_results=NULL", connection)
			{
				InternallyCreated = true
			};
			serverProps.TryGetValue("character_set_client", out var value);
			serverProps.TryGetValue("character_set_connection", out var value2);
			if ((value != null && value.ToString() != text) || (value2 != null && value2.ToString() != text))
			{
				MySqlCommand mySqlCommand = new MySqlCommand("SET NAMES " + text, connection);
				mySqlCommand.InternallyCreated = true;
				mySqlCommand.ExecuteNonQuery();
			}
			obj.ExecuteNonQuery();
			Encoding = CharSetMap.GetEncoding(Version, text ?? "utf-8");
			handler.Configure();
		}
	}

	private Dictionary<string, string> LoadServerProperties(MySqlConnection connection)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		MySqlCommand mySqlCommand = new MySqlCommand("SHOW VARIABLES", connection);
		try
		{
			using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
			{
				while (mySqlDataReader.Read())
				{
					string @string = mySqlDataReader.GetString(0);
					string text = (dictionary[@string] = mySqlDataReader.GetString(1));
				}
			}
			timeZoneOffset = GetTimeZoneOffset(connection);
			return dictionary;
		}
		catch (Exception ex)
		{
			MySqlTrace.LogError(ThreadID, ex.Message);
			throw;
		}
	}

	private int GetTimeZoneOffset(MySqlConnection con)
	{
		TimeSpan? timeSpan = new MySqlCommand("SELECT TIMEDIFF(NOW(), UTC_TIMESTAMP())", con).ExecuteScalar() as TimeSpan?;
		string text = "0:00";
		if (timeSpan.HasValue)
		{
			text = timeSpan.ToString();
		}
		return int.Parse(text.Substring(0, text.IndexOf(':')));
	}

	private void LoadCharacterSets(MySqlConnection connection)
	{
		MySqlCommand mySqlCommand = new MySqlCommand("SHOW COLLATION", connection);
		try
		{
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			CharacterSets = new Dictionary<int, string>();
			while (mySqlDataReader.Read())
			{
				CharacterSets[Convert.ToInt32(mySqlDataReader["id"], NumberFormatInfo.InvariantInfo)] = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("charset"));
			}
		}
		catch (Exception ex)
		{
			MySqlTrace.LogError(ThreadID, ex.Message);
			throw;
		}
	}

	public virtual List<MySqlError> ReportWarnings(MySqlConnection connection)
	{
		List<MySqlError> list = new List<MySqlError>();
		using (MySqlDataReader mySqlDataReader = new MySqlCommand("SHOW WARNINGS", connection)
		{
			InternallyCreated = true
		}.ExecuteReader())
		{
			while (mySqlDataReader.Read())
			{
				list.Add(new MySqlError(mySqlDataReader.GetString(0), mySqlDataReader.GetInt32(1), mySqlDataReader.GetString(2)));
			}
		}
		MySqlInfoMessageEventArgs mySqlInfoMessageEventArgs = new MySqlInfoMessageEventArgs();
		mySqlInfoMessageEventArgs.errors = list.ToArray();
		connection?.OnInfoMessage(mySqlInfoMessageEventArgs);
		return list;
	}

	public virtual void SendQuery(MySqlPacket p)
	{
		handler.SendQuery(p);
		firstResult = true;
	}

	public virtual ResultSet NextResult(int statementId, bool force)
	{
		if (!force && !firstResult && !HasStatus(ServerStatusFlags.MoreResults | ServerStatusFlags.AnotherQuery))
		{
			return null;
		}
		firstResult = false;
		int affectedRows = -1;
		long insertedId = -1L;
		int result = GetResult(statementId, ref affectedRows, ref insertedId);
		if (result == -1)
		{
			return null;
		}
		if (result > 0)
		{
			return new ResultSet(this, statementId, result);
		}
		return new ResultSet(affectedRows, insertedId);
	}

	protected virtual int GetResult(int statementId, ref int affectedRows, ref long insertedId)
	{
		return handler.GetResult(ref affectedRows, ref insertedId);
	}

	public virtual bool FetchDataRow(int statementId, int columns)
	{
		return handler.FetchDataRow(statementId, columns);
	}

	public virtual bool SkipDataRow()
	{
		return FetchDataRow(-1, 0);
	}

	public virtual void ExecuteDirect(string sql)
	{
		MySqlPacket mySqlPacket = new MySqlPacket(Encoding);
		mySqlPacket.WriteString(sql);
		SendQuery(mySqlPacket);
		NextResult(0, force: false);
	}

	public MySqlField[] GetColumns(int count)
	{
		MySqlField[] array = new MySqlField[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = new MySqlField(this);
		}
		handler.GetColumnsData(array);
		return array;
	}

	public virtual int PrepareStatement(string sql, ref MySqlField[] parameters)
	{
		return handler.PrepareStatement(sql, ref parameters);
	}

	public IMySqlValue ReadColumnValue(int index, MySqlField field, IMySqlValue value)
	{
		return handler.ReadColumnValue(index, field, value);
	}

	public void SkipColumnValue(IMySqlValue valObject)
	{
		handler.SkipColumnValue(valObject);
	}

	public void ResetTimeout(int timeoutMilliseconds)
	{
		handler.ResetTimeout(timeoutMilliseconds);
	}

	public bool Ping()
	{
		return handler.Ping();
	}

	public virtual void SetDatabase(string dbName)
	{
		handler.SetDatabase(dbName);
	}

	public virtual void ExecuteStatement(MySqlPacket packetToExecute)
	{
		handler.ExecuteStatement(packetToExecute);
	}

	public virtual void CloseStatement(int id)
	{
		handler.CloseStatement(id);
	}

	public virtual void Reset()
	{
		handler.Reset();
	}

	public virtual void CloseQuery(MySqlConnection connection, int statementId)
	{
		if (handler.WarningCount > 0)
		{
			ReportWarnings(connection);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposed)
		{
			return;
		}
		disposed = true;
		try
		{
			ResetTimeout(1000);
			handler.Close(IsOpen);
			if (ConnectionString.Pooling)
			{
				MySqlPoolManager.RemoveConnection(this);
			}
		}
		catch (Exception ex)
		{
			if (disposing)
			{
				if (!(ex is MySqlException ex2))
				{
					MySqlTrace.LogError(0, ex.GetBaseException().Message);
				}
				else
				{
					MySqlTrace.LogError(ex2.Number, ex.GetBaseException().Message);
				}
			}
		}
		finally
		{
			reader = null;
			IsOpen = false;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
