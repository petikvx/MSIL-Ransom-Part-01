using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security;
using System.Text;
using MySql.Data.Common;
using MySql.Data.MySqlClient.Authentication;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

internal class NativeDriver : IDriver
{
	private DBVersion version;

	private int threadId;

	protected byte[] encryptionSeed;

	protected ServerStatusFlags serverStatus;

	protected MySqlStream stream;

	protected Stream baseStream;

	private BitArray nullMap;

	private MySqlPacket packet;

	private ClientFlags connectionFlags;

	private Driver owner;

	private int warnings;

	private MySqlAuthenticationPlugin authPlugin;

	private const string AuthenticationWindowsPlugin = "authentication_windows_client";

	private const string AuthenticationWindowsUser = "auth_windows";

	public ClientFlags Flags => connectionFlags;

	public int ThreadId => threadId;

	public DBVersion Version => version;

	public ServerStatusFlags ServerStatus => serverStatus;

	public int WarningCount => warnings;

	public MySqlPacket Packet => packet;

	internal MySqlConnectionStringBuilder Settings => owner.Settings;

	internal Encoding Encoding => owner.Encoding;

	public NativeDriver(Driver owner)
	{
		this.owner = owner;
		threadId = -1;
	}

	private void HandleException(MySqlException ex)
	{
		if (ex.IsFatal)
		{
			owner.Close();
		}
	}

	internal void SendPacket(MySqlPacket p)
	{
		stream.SendPacket(p);
	}

	internal void SendEmptyPacket()
	{
		byte[] buffer = new byte[4];
		stream.SendEntirePacketDirectly(buffer, 0);
	}

	internal MySqlPacket ReadPacket()
	{
		return packet = stream.ReadPacket();
	}

	internal void ReadOk(bool read)
	{
		try
		{
			if (read)
			{
				packet = stream.ReadPacket();
			}
			if (packet.ReadByte() != 0)
			{
				throw new MySqlException("Out of sync with server", isFatal: true, null);
			}
			packet.ReadFieldLength();
			packet.ReadFieldLength();
			if (packet.HasMoreData)
			{
				serverStatus = (ServerStatusFlags)packet.ReadInteger(2);
				packet.ReadInteger(2);
				if (packet.HasMoreData)
				{
					packet.ReadLenString();
				}
			}
		}
		catch (MySqlException ex)
		{
			HandleException(ex);
			throw;
		}
	}

	public void SetDatabase(string dbName)
	{
		byte[] bytes = Encoding.GetBytes(dbName);
		packet.Clear();
		packet.WriteByte(2);
		packet.Write(bytes);
		ExecutePacket(packet);
		ReadOk(read: true);
	}

	public void Configure()
	{
		stream.MaxPacketSize = (ulong)owner.MaxPacketSize;
		stream.Encoding = Encoding;
	}

	public void Open()
	{
		try
		{
			baseStream = StreamCreator.GetStream(Settings);
			if (Settings.IncludeSecurityAsserts)
			{
				MySqlSecurityPermission.CreatePermissionSet(includeReflectionPermission: false).Assert();
			}
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception inner)
		{
			throw new MySqlException(Resources.UnableToConnectToHost, 1042, inner);
		}
		if (baseStream == null)
		{
			throw new MySqlException(Resources.UnableToConnectToHost, 1042);
		}
		int num = 16581375;
		stream = new MySqlStream(baseStream, Encoding, compress: false);
		stream.ResetTimeout((int)(Settings.ConnectionTimeout * 1000));
		packet = stream.ReadPacket();
		if (packet.ReadByte() != 10)
		{
			throw new MySqlException("Unsupported protocol version.");
		}
		string versionString = packet.ReadString();
		version = DBVersion.Parse(versionString);
		threadId = packet.ReadInteger(4);
		byte[] array = packet.ReadStringAsBytes();
		num = 16777215;
		ClientFlags clientFlags = (ClientFlags)0uL;
		if (packet.HasMoreData)
		{
			clientFlags = (ClientFlags)packet.ReadInteger(2);
		}
		owner.ConnectionCharSetIndex = packet.ReadByte();
		serverStatus = (ServerStatusFlags)packet.ReadInteger(2);
		uint num2 = (uint)packet.ReadInteger(2);
		clientFlags = (ClientFlags)((ulong)clientFlags | (ulong)(num2 << 16));
		packet.Position += 11;
		byte[] array2 = packet.ReadStringAsBytes();
		encryptionSeed = new byte[array.Length + array2.Length];
		array.CopyTo(encryptionSeed, 0);
		array2.CopyTo(encryptionSeed, array.Length);
		string text = "";
		text = (((clientFlags & ClientFlags.PLUGIN_AUTH) == (ClientFlags)0uL) ? "mysql_native_password" : packet.ReadString());
		SetConnectionFlags(clientFlags);
		packet.Clear();
		packet.WriteInteger((int)connectionFlags, 4);
		packet.WriteInteger(num, 4);
		packet.WriteByte(33);
		packet.Write(new byte[23]);
		if ((clientFlags & ClientFlags.SSL) == (ClientFlags)0uL)
		{
			if (Settings.SslMode != 0 && Settings.SslMode != MySqlSslMode.Preferred)
			{
				throw new MySqlException(string.Format(Resources.NoServerSSLSupport, Settings.Server));
			}
		}
		else if (Settings.SslMode != 0)
		{
			stream.SendPacket(packet);
			stream = new Ssl(Settings.Server, Settings.SslMode, Settings.CertificateFile, Settings.CertificateStoreLocation, Settings.CertificatePassword, Settings.CertificateThumbprint, Settings.SslCa, Settings.SslCert, Settings.SslKey).StartSSL(ref baseStream, Encoding, Settings.ToString());
			packet.Clear();
			packet.WriteInteger((int)connectionFlags, 4);
			packet.WriteInteger(num, 4);
			packet.WriteByte(33);
			packet.Write(new byte[23]);
		}
		Authenticate(text, reset: false);
		if ((connectionFlags & ClientFlags.COMPRESS) != (ClientFlags)0uL)
		{
			stream = new MySqlStream(baseStream, Encoding, compress: true);
		}
		packet.Version = version;
		stream.MaxBlockSize = num;
	}

	private void SetConnectionFlags(ClientFlags serverCaps)
	{
		ClientFlags clientFlags = ClientFlags.MULTI_RESULTS;
		if (Settings.AllowLoadLocalInfile)
		{
			clientFlags |= ClientFlags.LOCAL_FILES;
		}
		if (!Settings.UseAffectedRows)
		{
			clientFlags |= ClientFlags.FOUND_ROWS;
		}
		clientFlags |= ClientFlags.PROTOCOL_41;
		clientFlags |= ClientFlags.TRANSACTIONS;
		if (Settings.AllowBatch)
		{
			clientFlags |= ClientFlags.MULTI_STATEMENTS;
		}
		if ((serverCaps & ClientFlags.LONG_FLAG) != (ClientFlags)0uL)
		{
			clientFlags |= ClientFlags.LONG_FLAG;
		}
		if ((serverCaps & ClientFlags.COMPRESS) != (ClientFlags)0uL && Settings.UseCompression)
		{
			clientFlags |= ClientFlags.COMPRESS;
		}
		clientFlags |= ClientFlags.LONG_PASSWORD;
		if (Settings.InteractiveSession)
		{
			clientFlags |= ClientFlags.INTERACTIVE;
		}
		if ((serverCaps & ClientFlags.CONNECT_WITH_DB) != (ClientFlags)0uL && Settings.Database != null && Settings.Database.Length > 0)
		{
			clientFlags |= ClientFlags.CONNECT_WITH_DB;
		}
		if ((serverCaps & ClientFlags.SECURE_CONNECTION) != (ClientFlags)0uL)
		{
			clientFlags |= ClientFlags.SECURE_CONNECTION;
		}
		if ((serverCaps & ClientFlags.SSL) != (ClientFlags)0uL && Settings.SslMode != 0)
		{
			clientFlags |= ClientFlags.SSL;
		}
		if ((serverCaps & ClientFlags.PS_MULTI_RESULTS) != (ClientFlags)0uL)
		{
			clientFlags |= ClientFlags.PS_MULTI_RESULTS;
		}
		if ((serverCaps & ClientFlags.PLUGIN_AUTH) != (ClientFlags)0uL)
		{
			clientFlags |= ClientFlags.PLUGIN_AUTH;
		}
		if ((serverCaps & ClientFlags.CONNECT_ATTRS) != (ClientFlags)0uL)
		{
			clientFlags |= ClientFlags.CONNECT_ATTRS;
		}
		if ((serverCaps & ClientFlags.CAN_HANDLE_EXPIRED_PASSWORD) != (ClientFlags)0uL)
		{
			clientFlags |= ClientFlags.CAN_HANDLE_EXPIRED_PASSWORD;
		}
		connectionFlags = clientFlags;
	}

	public void Authenticate(string authMethod, bool reset)
	{
		if (authMethod != null)
		{
			if (Settings.IntegratedSecurity)
			{
				authMethod = "authentication_windows_client";
			}
			authPlugin = MySqlAuthenticationPlugin.GetPlugin(authMethod, this, encryptionSeed);
		}
		authPlugin.Authenticate(reset);
	}

	public void Reset()
	{
		warnings = 0;
		stream.Encoding = Encoding;
		stream.SequenceByte = 0;
		packet.Clear();
		packet.WriteByte(17);
		Authenticate(null, reset: true);
	}

	public void SendQuery(MySqlPacket queryPacket)
	{
		warnings = 0;
		queryPacket.SetByte(4L, 3);
		ExecutePacket(queryPacket);
		serverStatus |= ServerStatusFlags.AnotherQuery;
	}

	public void Close(bool isOpen)
	{
		try
		{
			if (isOpen)
			{
				try
				{
					packet.Clear();
					packet.WriteByte(1);
					ExecutePacket(packet);
				}
				catch (Exception ex)
				{
					MySqlTrace.LogError(ThreadId, ex.ToString());
				}
			}
			if (stream != null)
			{
				stream.Close();
			}
			stream = null;
		}
		catch (Exception)
		{
		}
	}

	public bool Ping()
	{
		try
		{
			packet.Clear();
			packet.WriteByte(14);
			ExecutePacket(packet);
			ReadOk(read: true);
			return true;
		}
		catch (Exception)
		{
			owner.Close();
			return false;
		}
	}

	public int GetResult(ref int affectedRow, ref long insertedId)
	{
		try
		{
			packet = stream.ReadPacket();
		}
		catch (TimeoutException)
		{
			throw;
		}
		catch (Exception)
		{
			serverStatus &= ~(ServerStatusFlags.MoreResults | ServerStatusFlags.AnotherQuery);
			throw;
		}
		int num = (int)packet.ReadFieldLength();
		if (-1 == num)
		{
			if (Settings.AllowLoadLocalInfile)
			{
				string filename = packet.ReadString();
				SendFileToServer(filename);
				return GetResult(ref affectedRow, ref insertedId);
			}
			stream.Close();
			throw new MySqlException(Resources.LocalInfileDisabled);
		}
		if (num == 0)
		{
			serverStatus &= ~(ServerStatusFlags.MoreResults | ServerStatusFlags.AnotherQuery);
			affectedRow = (int)packet.ReadFieldLength();
			insertedId = packet.ReadFieldLength();
			serverStatus = (ServerStatusFlags)packet.ReadInteger(2);
			warnings += packet.ReadInteger(2);
			if (packet.HasMoreData)
			{
				packet.ReadLenString();
			}
		}
		return num;
	}

	private void SendFileToServer(string filename)
	{
		byte[] buffer = new byte[8196];
		long num = 0L;
		try
		{
			using FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			num = fileStream.Length;
			while (num > 0L)
			{
				int num2 = fileStream.Read(buffer, 4, (int)((num > 8192L) ? 8192L : num));
				stream.SendEntirePacketDirectly(buffer, num2);
				num -= num2;
			}
			stream.SendEntirePacketDirectly(buffer, 0);
		}
		catch (Exception ex)
		{
			throw new MySqlException("Error during LOAD DATA LOCAL INFILE", ex);
		}
	}

	private void ReadNullMap(int fieldCount)
	{
		nullMap = null;
		byte[] array = new byte[(fieldCount + 9) / 8];
		packet.ReadByte();
		packet.Read(array, 0, array.Length);
		nullMap = new BitArray(array);
	}

	public IMySqlValue ReadColumnValue(int index, MySqlField field, IMySqlValue valObject)
	{
		long num = -1L;
		bool isNull;
		if (nullMap != null)
		{
			isNull = nullMap[index + 2];
		}
		else
		{
			num = packet.ReadFieldLength();
			isNull = num == -1L;
		}
		packet.Encoding = field.Encoding;
		packet.Version = version;
		IMySqlValue mySqlValue = valObject.ReadValue(packet, num, isNull);
		if (mySqlValue is MySqlDateTime mySqlDateTime)
		{
			mySqlDateTime.TimezoneOffset = field.driver.timeZoneOffset;
			return mySqlDateTime;
		}
		return mySqlValue;
	}

	public void SkipColumnValue(IMySqlValue valObject)
	{
		int num = -1;
		if (nullMap == null)
		{
			num = (int)packet.ReadFieldLength();
			if (num == -1)
			{
				return;
			}
		}
		if (num > -1)
		{
			packet.Position += num;
		}
		else
		{
			valObject.SkipValue(packet);
		}
	}

	public void GetColumnsData(MySqlField[] columns)
	{
		for (int i = 0; i < columns.Length; i++)
		{
			GetColumnData(columns[i]);
		}
		ReadEOF();
	}

	private void GetColumnData(MySqlField field)
	{
		stream.Encoding = Encoding;
		packet = stream.ReadPacket();
		field.Encoding = Encoding;
		field.CatalogName = packet.ReadLenString();
		field.DatabaseName = packet.ReadLenString();
		field.TableName = packet.ReadLenString();
		field.RealTableName = packet.ReadLenString();
		field.ColumnName = packet.ReadLenString();
		field.OriginalColumnName = packet.ReadLenString();
		packet.ReadByte();
		field.CharacterSetIndex = packet.ReadInteger(2);
		field.ColumnLength = packet.ReadInteger(4);
		MySqlDbType mySqlDbType = (MySqlDbType)packet.ReadByte();
		ColumnFlags columnFlags = (ColumnFlags)(((connectionFlags & ClientFlags.LONG_FLAG) == (ClientFlags)0uL) ? packet.ReadByte() : packet.ReadInteger(2));
		field.Scale = packet.ReadByte();
		if (packet.HasMoreData)
		{
			packet.ReadInteger(2);
		}
		if (mySqlDbType == MySqlDbType.Decimal || mySqlDbType == MySqlDbType.NewDecimal)
		{
			field.Precision = (((columnFlags & ColumnFlags.UNSIGNED) != 0) ? ((byte)field.ColumnLength) : ((byte)(field.ColumnLength - 1)));
			if (field.Scale != 0)
			{
				field.Precision--;
			}
		}
		field.SetTypeAndFlags(mySqlDbType, columnFlags);
	}

	private void ExecutePacket(MySqlPacket packetToExecute)
	{
		try
		{
			warnings = 0;
			stream.SequenceByte = 0;
			stream.SendPacket(packetToExecute);
		}
		catch (MySqlException ex)
		{
			HandleException(ex);
			throw;
		}
	}

	public void ExecuteStatement(MySqlPacket packetToExecute)
	{
		warnings = 0;
		packetToExecute.SetByte(4L, 23);
		ExecutePacket(packetToExecute);
		serverStatus |= ServerStatusFlags.AnotherQuery;
	}

	private void CheckEOF()
	{
		if (!packet.IsLastPacket)
		{
			throw new MySqlException("Expected end of data packet");
		}
		packet.ReadByte();
		if (packet.HasMoreData)
		{
			warnings += packet.ReadInteger(2);
			serverStatus = (ServerStatusFlags)packet.ReadInteger(2);
		}
	}

	private void ReadEOF()
	{
		packet = stream.ReadPacket();
		CheckEOF();
	}

	public int PrepareStatement(string sql, ref MySqlField[] parameters)
	{
		packet.Length = sql.Length * 4 + 5;
		byte[] buffer = packet.Buffer;
		int bytes = Encoding.GetBytes(sql, 0, sql.Length, packet.Buffer, 5);
		packet.Position = bytes + 5;
		buffer[4] = 22;
		ExecutePacket(packet);
		packet = stream.ReadPacket();
		if (packet.ReadByte() != 0)
		{
			throw new MySqlException("Expected prepared statement marker");
		}
		int result = packet.ReadInteger(4);
		int num = packet.ReadInteger(2);
		int num2 = packet.ReadInteger(2);
		packet.ReadInteger(3);
		if (num2 > 0)
		{
			parameters = owner.GetColumns(num2);
			for (int i = 0; i < parameters.Length; i++)
			{
				parameters[i].Encoding = Encoding;
			}
		}
		if (num > 0)
		{
			while (num-- > 0)
			{
				packet = stream.ReadPacket();
			}
			ReadEOF();
		}
		return result;
	}

	public bool FetchDataRow(int statementId, int columns)
	{
		packet = stream.ReadPacket();
		if (packet.IsLastPacket)
		{
			CheckEOF();
			return false;
		}
		nullMap = null;
		if (statementId > 0)
		{
			ReadNullMap(columns);
		}
		return true;
	}

	public void CloseStatement(int statementId)
	{
		packet.Clear();
		packet.WriteByte(25);
		packet.WriteInteger(statementId, 4);
		stream.SequenceByte = 0;
		stream.SendPacket(packet);
	}

	public void ResetTimeout(int timeout)
	{
		if (stream != null)
		{
			stream.ResetTimeout(timeout);
		}
	}

	internal void SetConnectAttrs()
	{
		if ((connectionFlags & ClientFlags.CONNECT_ATTRS) == (ClientFlags)0uL)
		{
			return;
		}
		string text = string.Empty;
		MySqlConnectAttrs mySqlConnectAttrs = new MySqlConnectAttrs();
		PropertyInfo[] properties = mySqlConnectAttrs.GetType().GetProperties();
		foreach (PropertyInfo obj in properties)
		{
			string text2 = obj.Name;
			object[] customAttributes = obj.GetCustomAttributes(typeof(DisplayNameAttribute), inherit: false);
			if (customAttributes.Length != 0)
			{
				text2 = (customAttributes[0] as DisplayNameAttribute).DisplayName;
			}
			string text3 = (string)obj.GetValue(mySqlConnectAttrs, null);
			text += $"{(char)text2.Length}{text2}";
			text += $"{(char)text3.Length}{text3}";
		}
		packet.WriteLenString(text);
	}
}
