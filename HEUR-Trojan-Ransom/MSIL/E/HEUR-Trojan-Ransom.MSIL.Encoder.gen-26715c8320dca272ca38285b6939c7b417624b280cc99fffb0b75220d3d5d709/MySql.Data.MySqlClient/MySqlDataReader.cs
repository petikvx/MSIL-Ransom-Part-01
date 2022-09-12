using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Threading;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

public sealed class MySqlDataReader : DbDataReader, IDisposable, IDataReader, IDataRecord
{
	private bool _isOpen = true;

	internal long affectedRows;

	internal Driver driver;

	private readonly bool _disableZeroAffectedRows;

	private MySqlConnection _connection;

	internal PreparableStatement Statement { get; }

	internal MySqlCommand Command { get; private set; }

	internal ResultSet ResultSet { get; private set; }

	internal CommandBehavior CommandBehavior { get; private set; }

	public override int FieldCount => ResultSet?.Size ?? 0;

	public override bool HasRows => ResultSet?.HasRows ?? false;

	public override bool IsClosed => !_isOpen;

	public override int RecordsAffected
	{
		get
		{
			if (!_disableZeroAffectedRows)
			{
				return (int)affectedRows;
			}
			if (affectedRows == 0L)
			{
				return -1;
			}
			return (int)affectedRows;
		}
	}

	public override object this[int i] => GetValue(i);

	public override object this[string name] => this[GetOrdinal(name)];

	public override int Depth => 0;

	internal MySqlDataReader(MySqlCommand cmd, PreparableStatement statement, CommandBehavior behavior)
	{
		Command = cmd;
		_connection = Command.Connection;
		CommandBehavior = behavior;
		driver = _connection.driver;
		affectedRows = -1L;
		Statement = statement;
		if (cmd.CommandType == CommandType.StoredProcedure && cmd.UpdatedRowSource == UpdateRowSource.FirstReturnedRecord)
		{
			_disableZeroAffectedRows = true;
		}
	}

	public override void Close()
	{
		if (!_isOpen)
		{
			return;
		}
		bool flag = (CommandBehavior & CommandBehavior.CloseConnection) != 0;
		CommandBehavior commandBehavior = CommandBehavior;
		try
		{
			if (!commandBehavior.Equals(CommandBehavior.SchemaOnly))
			{
				CommandBehavior = CommandBehavior.Default;
			}
			while (NextResult())
			{
			}
		}
		catch (MySqlException ex)
		{
			if (!ex.IsQueryAborted)
			{
				bool flag2 = false;
				Exception ex2 = ex;
				while (ex2 != null)
				{
					if (!(ex2 is IOException))
					{
						ex2 = ex2.InnerException;
						continue;
					}
					flag2 = true;
					break;
				}
				if (!flag2)
				{
					throw;
				}
			}
		}
		catch (IOException)
		{
		}
		finally
		{
			_connection.Reader = null;
			CommandBehavior = commandBehavior;
		}
		Command.Close(this);
		CommandBehavior = CommandBehavior.Default;
		if (Command.Canceled && _connection.driver.Version.isAtLeast(5, 1, 0))
		{
			ClearKillFlag();
		}
		if (flag)
		{
			_connection.Close();
		}
		Command = null;
		_connection.IsInUse = false;
		_connection = null;
		_isOpen = false;
	}

	public bool GetBoolean(string name)
	{
		return GetBoolean(GetOrdinal(name));
	}

	public override bool GetBoolean(int i)
	{
		object value = GetValue(i);
		if (int.TryParse(value as string, out var result))
		{
			return Convert.ToBoolean(result);
		}
		return Convert.ToBoolean(value);
	}

	public byte GetByte(string name)
	{
		return GetByte(GetOrdinal(name));
	}

	public override byte GetByte(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: false);
		if (fieldValue is MySqlUByte mySqlUByte)
		{
			return mySqlUByte.Value;
		}
		return (byte)((MySqlByte)(object)fieldValue).Value;
	}

	public sbyte GetSByte(string name)
	{
		return GetSByte(GetOrdinal(name));
	}

	public sbyte GetSByte(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: false);
		return ((MySqlByte)(object)fieldValue).Value;
	}

	public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
	{
		if (i >= FieldCount)
		{
			Throw(new IndexOutOfRangeException());
		}
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: false);
		if (!(fieldValue is MySqlBinary) && !(fieldValue is MySqlGuid))
		{
			Throw(new MySqlException("GetBytes can only be called on binary or guid columns"));
		}
		byte[] array = null;
		array = ((!(fieldValue is MySqlBinary mySqlBinary)) ? ((MySqlGuid)(object)fieldValue).Bytes : mySqlBinary.Value);
		if (buffer == null)
		{
			return array.Length;
		}
		if (bufferoffset >= buffer.Length || bufferoffset < 0)
		{
			Throw(new IndexOutOfRangeException("Buffer index must be a valid index in buffer"));
		}
		if (buffer.Length < bufferoffset + length)
		{
			Throw(new ArgumentException("Buffer is not large enough to hold the requested data"));
		}
		if (fieldOffset < 0L || ((ulong)fieldOffset >= (ulong)array.Length && (ulong)array.Length > 0uL))
		{
			Throw(new IndexOutOfRangeException("Data index must be a valid index in the field"));
		}
		if ((ulong)array.Length < (ulong)(fieldOffset + length))
		{
			length = (int)(array.Length - fieldOffset);
		}
		Buffer.BlockCopy(array, (int)fieldOffset, buffer, bufferoffset, length);
		return length;
	}

	private object ChangeType(IMySqlValue value, int fieldIndex, Type newType)
	{
		ResultSet.Fields[fieldIndex].AddTypeConversion(newType);
		return Convert.ChangeType(value.Value, newType, CultureInfo.InvariantCulture);
	}

	public char GetChar(string name)
	{
		return GetChar(GetOrdinal(name));
	}

	public override char GetChar(int i)
	{
		return GetString(i)[0];
	}

	public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
	{
		if (i >= FieldCount)
		{
			Throw(new IndexOutOfRangeException());
		}
		string @string = GetString(i);
		if (buffer == null)
		{
			return @string.Length;
		}
		if (bufferoffset >= buffer.Length || bufferoffset < 0)
		{
			Throw(new IndexOutOfRangeException("Buffer index must be a valid index in buffer"));
		}
		if (buffer.Length < bufferoffset + length)
		{
			Throw(new ArgumentException("Buffer is not large enough to hold the requested data"));
		}
		if (fieldoffset < 0L || fieldoffset >= @string.Length)
		{
			Throw(new IndexOutOfRangeException("Field offset must be a valid index in the field"));
		}
		if (@string.Length < length)
		{
			length = @string.Length;
		}
		@string.CopyTo((int)fieldoffset, buffer, bufferoffset, length);
		return length;
	}

	public override string GetDataTypeName(int i)
	{
		if (!_isOpen)
		{
			Throw(new Exception("No current query in data reader"));
		}
		if (i >= FieldCount)
		{
			Throw(new IndexOutOfRangeException());
		}
		return ResultSet.Values[i].MySqlTypeName;
	}

	public MySqlDateTime GetMySqlDateTime(string column)
	{
		return GetMySqlDateTime(GetOrdinal(column));
	}

	public MySqlDateTime GetMySqlDateTime(int column)
	{
		return (MySqlDateTime)(object)GetFieldValue(column, checkNull: true);
	}

	public DateTime GetDateTime(string column)
	{
		return GetDateTime(GetOrdinal(column));
	}

	public override DateTime GetDateTime(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: true);
		MySqlDateTime mySqlDateTime = ((!(fieldValue is MySqlDateTime)) ? MySqlDateTime.Parse(GetString(i)) : ((MySqlDateTime)(object)fieldValue));
		mySqlDateTime.TimezoneOffset = driver.timeZoneOffset;
		if (_connection.Settings.ConvertZeroDateTime && !mySqlDateTime.IsValidDateTime)
		{
			return DateTime.MinValue;
		}
		return mySqlDateTime.GetDateTime();
	}

	public MySqlDecimal GetMySqlDecimal(string column)
	{
		return GetMySqlDecimal(GetOrdinal(column));
	}

	public MySqlDecimal GetMySqlDecimal(int i)
	{
		return (MySqlDecimal)(object)GetFieldValue(i, checkNull: false);
	}

	public decimal GetDecimal(string column)
	{
		return GetDecimal(GetOrdinal(column));
	}

	public override decimal GetDecimal(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: true);
		if (fieldValue is MySqlDecimal mySqlDecimal)
		{
			return mySqlDecimal.Value;
		}
		return Convert.ToDecimal(fieldValue.Value);
	}

	public double GetDouble(string column)
	{
		return GetDouble(GetOrdinal(column));
	}

	public override double GetDouble(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: true);
		if (fieldValue is MySqlDouble mySqlDouble)
		{
			return mySqlDouble.Value;
		}
		return Convert.ToDouble(fieldValue.Value);
	}

	public Type GetFieldType(string column)
	{
		return GetFieldType(GetOrdinal(column));
	}

	public override Type GetFieldType(int i)
	{
		if (!_isOpen)
		{
			Throw(new Exception("No current query in data reader"));
		}
		if (i >= FieldCount)
		{
			Throw(new IndexOutOfRangeException());
		}
		IMySqlValue mySqlValue = ResultSet.Values[i];
		if (mySqlValue is MySqlDateTime)
		{
			if (!_connection.Settings.AllowZeroDateTime)
			{
				return typeof(DateTime);
			}
			return typeof(MySqlDateTime);
		}
		return mySqlValue.SystemType;
	}

	public float GetFloat(string column)
	{
		return GetFloat(GetOrdinal(column));
	}

	public override float GetFloat(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: true);
		if (fieldValue is MySqlSingle mySqlSingle)
		{
			return mySqlSingle.Value;
		}
		return Convert.ToSingle(fieldValue.Value);
	}

	public string GetBodyDefinition(string column)
	{
		return GetValue(GetOrdinal(column)).ToString();
	}

	public Guid GetGuid(string column)
	{
		return GetGuid(GetOrdinal(column));
	}

	public override Guid GetGuid(int i)
	{
		object value = GetValue(i);
		if (value is Guid)
		{
			return (Guid)value;
		}
		if (value is string)
		{
			return new Guid(value as string);
		}
		if (value is byte[])
		{
			byte[] array = (byte[])value;
			if (array.Length == 16)
			{
				return new Guid(array);
			}
		}
		Throw(new MySqlException(Resources.ValueNotSupportedForGuid));
		return Guid.Empty;
	}

	public short GetInt16(string column)
	{
		return GetInt16(GetOrdinal(column));
	}

	public override short GetInt16(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: true);
		if (fieldValue is MySqlInt16 mySqlInt)
		{
			return mySqlInt.Value;
		}
		return (short)ChangeType(fieldValue, i, typeof(short));
	}

	public int GetInt32(string column)
	{
		return GetInt32(GetOrdinal(column));
	}

	public override int GetInt32(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: true);
		if (fieldValue is MySqlInt32 mySqlInt)
		{
			return mySqlInt.Value;
		}
		return (int)ChangeType(fieldValue, i, typeof(int));
	}

	public long GetInt64(string column)
	{
		return GetInt64(GetOrdinal(column));
	}

	public override long GetInt64(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: true);
		if (fieldValue is MySqlInt64 mySqlInt)
		{
			return mySqlInt.Value;
		}
		return (long)ChangeType(fieldValue, i, typeof(long));
	}

	public override string GetName(int i)
	{
		if (!_isOpen)
		{
			Throw(new Exception("No current query in data reader"));
		}
		if (i >= FieldCount)
		{
			Throw(new IndexOutOfRangeException());
		}
		return ResultSet.Fields[i].ColumnName;
	}

	public override int GetOrdinal(string name)
	{
		if (!_isOpen || ResultSet == null)
		{
			Throw(new Exception("No current query in data reader"));
		}
		return ResultSet.GetOrdinal(name);
	}

	public string GetString(string column)
	{
		return GetString(GetOrdinal(column));
	}

	public override string GetString(int i)
	{
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: true);
		if (fieldValue is MySqlBinary mySqlBinary)
		{
			byte[] value = mySqlBinary.Value;
			return ResultSet.Fields[i].Encoding.GetString(value, 0, value.Length);
		}
		return fieldValue.Value.ToString();
	}

	public TimeSpan GetTimeSpan(string column)
	{
		return GetTimeSpan(GetOrdinal(column));
	}

	public TimeSpan GetTimeSpan(int column)
	{
		return ((MySqlTimeSpan)(object)GetFieldValue(column, checkNull: true)).Value;
	}

	public override object GetValue(int i)
	{
		if (!_isOpen)
		{
			Throw(new Exception("No current query in data reader"));
		}
		if (i >= FieldCount)
		{
			Throw(new IndexOutOfRangeException());
		}
		IMySqlValue fieldValue = GetFieldValue(i, checkNull: false);
		if (fieldValue.IsNull && (fieldValue.MySqlDbType != MySqlDbType.Time || !(fieldValue.Value.ToString() == "00:00:00")))
		{
			return DBNull.Value;
		}
		if (fieldValue is MySqlDateTime mySqlDateTime)
		{
			if (!mySqlDateTime.IsValidDateTime && _connection.Settings.ConvertZeroDateTime)
			{
				return DateTime.MinValue;
			}
			if (_connection.Settings.AllowZeroDateTime)
			{
				return fieldValue;
			}
			return mySqlDateTime.GetDateTime();
		}
		return fieldValue.Value;
	}

	public override int GetValues(object[] values)
	{
		int num = Math.Min(values.Length, FieldCount);
		for (int i = 0; i < num; i++)
		{
			values[i] = GetValue(i);
		}
		return num;
	}

	public ushort GetUInt16(string column)
	{
		return GetUInt16(GetOrdinal(column));
	}

	public ushort GetUInt16(int column)
	{
		IMySqlValue fieldValue = GetFieldValue(column, checkNull: true);
		if (fieldValue is MySqlUInt16 mySqlUInt)
		{
			return mySqlUInt.Value;
		}
		return (ushort)ChangeType(fieldValue, column, typeof(ushort));
	}

	public uint GetUInt32(string column)
	{
		return GetUInt32(GetOrdinal(column));
	}

	public uint GetUInt32(int column)
	{
		IMySqlValue fieldValue = GetFieldValue(column, checkNull: true);
		if (fieldValue is MySqlUInt32 mySqlUInt)
		{
			return mySqlUInt.Value;
		}
		return (uint)ChangeType(fieldValue, column, typeof(uint));
	}

	public ulong GetUInt64(string column)
	{
		return GetUInt64(GetOrdinal(column));
	}

	public ulong GetUInt64(int column)
	{
		IMySqlValue fieldValue = GetFieldValue(column, checkNull: true);
		if (fieldValue is MySqlUInt64 mySqlUInt)
		{
			return mySqlUInt.Value;
		}
		return (ulong)ChangeType(fieldValue, column, typeof(ulong));
	}

	IDataReader IDataRecord.GetData(int i)
	{
		return GetData(i);
	}

	public override bool IsDBNull(int i)
	{
		return DBNull.Value == GetValue(i);
	}

	public override bool NextResult()
	{
		if (!_isOpen)
		{
			Throw(new MySqlException(Resources.NextResultIsClosed));
		}
		bool flag = Command.CommandType == CommandType.TableDirect && Command.EnableCaching && (CommandBehavior & CommandBehavior.SequentialAccess) == 0;
		if (ResultSet != null)
		{
			ResultSet.Close();
			if (flag)
			{
				TableCache.AddToCache(Command.CommandText, ResultSet);
			}
		}
		if (ResultSet != null && ((CommandBehavior & CommandBehavior.SingleResult) != 0 || flag))
		{
			return false;
		}
		try
		{
			do
			{
				ResultSet = null;
				if (flag)
				{
					ResultSet = TableCache.RetrieveFromCache(Command.CommandText, Command.CacheAge);
				}
				if (ResultSet == null)
				{
					ResultSet = driver.NextResult(Statement.StatementId, force: false);
					if (ResultSet == null)
					{
						return false;
					}
					if (ResultSet.IsOutputParameters && Command.CommandType == CommandType.StoredProcedure)
					{
						StoredProcedure storedProcedure = Statement as StoredProcedure;
						storedProcedure.ProcessOutputParameters(this);
						ResultSet.Close();
						for (int i = 0; i < ResultSet.Fields.Length; i++)
						{
							if (ResultSet.Fields[i].ColumnName.StartsWith("@_cnet_param_", StringComparison.OrdinalIgnoreCase))
							{
								ResultSet = null;
								break;
							}
						}
						if (!storedProcedure.ServerProvidingOutputParameters)
						{
							return false;
						}
						ResultSet = driver.NextResult(Statement.StatementId, force: true);
					}
					ResultSet.Cached = flag;
				}
				if (ResultSet.Size == 0)
				{
					Command.LastInsertedId = ResultSet.InsertedId;
					if (affectedRows == -1L)
					{
						affectedRows = ResultSet.AffectedRows;
					}
					else
					{
						affectedRows += ResultSet.AffectedRows;
					}
				}
			}
			while (ResultSet.Size == 0);
			return true;
		}
		catch (MySqlException ex)
		{
			if (ex.IsFatal)
			{
				_connection.Abort();
			}
			if (ex.Number == 0)
			{
				throw new MySqlException(Resources.FatalErrorReadingResult, ex);
			}
			if ((CommandBehavior & CommandBehavior.CloseConnection) != 0)
			{
				Close();
			}
			throw;
		}
	}

	public override bool Read()
	{
		if (!_isOpen)
		{
			Throw(new MySqlException("Invalid attempt to Read when reader is closed."));
		}
		if (ResultSet == null)
		{
			return false;
		}
		try
		{
			return ResultSet.NextRow(CommandBehavior);
		}
		catch (TimeoutException ex)
		{
			_connection.HandleTimeoutOrThreadAbort(ex);
			throw;
		}
		catch (ThreadAbortException ex2)
		{
			_connection.HandleTimeoutOrThreadAbort(ex2);
			throw;
		}
		catch (MySqlException ex3)
		{
			if (ex3.IsFatal)
			{
				_connection.Abort();
			}
			if (ex3.IsQueryAborted)
			{
				throw;
			}
			throw new MySqlException(Resources.FatalErrorDuringRead, ex3);
		}
	}

	public MySqlGeometry GetMySqlGeometry(int i)
	{
		try
		{
			IMySqlValue fieldValue = GetFieldValue(i, checkNull: false);
			if (fieldValue is MySqlGeometry || fieldValue is MySqlBinary)
			{
				return new MySqlGeometry(MySqlDbType.Geometry, (byte[])fieldValue.Value);
			}
		}
		catch
		{
			Throw(new Exception("Can't get MySqlGeometry from value"));
		}
		return new MySqlGeometry(isNull: true);
	}

	public MySqlGeometry GetMySqlGeometry(string column)
	{
		return GetMySqlGeometry(GetOrdinal(column));
	}

	public override IEnumerator GetEnumerator()
	{
		return new DbEnumerator((IDataReader)this, (CommandBehavior & CommandBehavior.CloseConnection) != 0);
	}

	private IMySqlValue GetFieldValue(int index, bool checkNull)
	{
		if (index < 0 || index >= FieldCount)
		{
			Throw(new ArgumentException(Resources.InvalidColumnOrdinal));
		}
		IMySqlValue mySqlValue = ResultSet[index];
		if ((mySqlValue.MySqlDbType != MySqlDbType.Time || !(mySqlValue.Value.ToString() == "00:00:00")) && checkNull && mySqlValue.IsNull)
		{
			throw new SqlNullValueException();
		}
		return mySqlValue;
	}

	private void ClearKillFlag()
	{
		MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM bogus_table LIMIT 0", _connection)
		{
			InternallyCreated = true
		};
		try
		{
			mySqlCommand.ExecuteReader();
		}
		catch (MySqlException ex)
		{
			if (ex.Number != 1146)
			{
				throw;
			}
		}
	}

	private void ProcessOutputParameters()
	{
		if (!driver.SupportsOutputParameters || !Command.IsPrepared)
		{
			AdjustOutputTypes();
		}
		if ((CommandBehavior & CommandBehavior.SchemaOnly) != 0)
		{
			return;
		}
		ResultSet.NextRow(CommandBehavior);
		string text = "@_cnet_param_";
		for (int i = 0; i < FieldCount; i++)
		{
			string text2 = GetName(i);
			if (text2.StartsWith(text))
			{
				text2 = text2.Remove(0, text.Length);
			}
			Command.Parameters.GetParameterFlexible(text2, throwOnNotFound: true).Value = GetValue(i);
		}
	}

	private void AdjustOutputTypes()
	{
		for (int i = 0; i < FieldCount; i++)
		{
			string name = GetName(i);
			name = name.Remove(0, "_cnet_param_".Length + 1);
			IMySqlValue iMySqlValue = MySqlField.GetIMySqlValue(Command.Parameters.GetParameterFlexible(name, throwOnNotFound: true).MySqlDbType);
			if (iMySqlValue is MySqlBit mySqlBit)
			{
				mySqlBit.ReadAsString = true;
				ResultSet.SetValueObject(i, mySqlBit);
			}
			else
			{
				ResultSet.SetValueObject(i, iMySqlValue);
			}
		}
	}

	public override T GetFieldValue<T>(int ordinal)
	{
		if (typeof(T).Equals(typeof(DateTimeOffset)))
		{
			DateTime result = default(DateTime);
			return (T)Convert.ChangeType(new DateTimeOffset(DateTime.TryParse(GetValue(ordinal).ToString(), out result) ? result : DateTime.MinValue), typeof(T));
		}
		return base.GetFieldValue<T>(ordinal);
	}

	private void Throw(Exception ex)
	{
		_connection?.Throw(ex);
		throw ex;
	}

	public new void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	internal new void Dispose(bool disposing)
	{
		if (disposing)
		{
			Close();
		}
	}

	~MySqlDataReader()
	{
		Dispose(disposing: false);
	}

	public override DataTable GetSchemaTable()
	{
		if (FieldCount == 0)
		{
			return null;
		}
		DataTable dataTable = new DataTable("SchemaTable");
		dataTable.Columns.Add("ColumnName", typeof(string));
		dataTable.Columns.Add("ColumnOrdinal", typeof(int));
		dataTable.Columns.Add("ColumnSize", typeof(int));
		dataTable.Columns.Add("NumericPrecision", typeof(int));
		dataTable.Columns.Add("NumericScale", typeof(int));
		dataTable.Columns.Add("IsUnique", typeof(bool));
		dataTable.Columns.Add("IsKey", typeof(bool));
		dataTable.Columns["IsKey"]!.AllowDBNull = true;
		dataTable.Columns.Add("BaseCatalogName", typeof(string));
		dataTable.Columns.Add("BaseColumnName", typeof(string));
		dataTable.Columns.Add("BaseSchemaName", typeof(string));
		dataTable.Columns.Add("BaseTableName", typeof(string));
		dataTable.Columns.Add("DataType", typeof(Type));
		dataTable.Columns.Add("AllowDBNull", typeof(bool));
		dataTable.Columns.Add("ProviderType", typeof(int));
		dataTable.Columns.Add("IsAliased", typeof(bool));
		dataTable.Columns.Add("IsExpression", typeof(bool));
		dataTable.Columns.Add("IsIdentity", typeof(bool));
		dataTable.Columns.Add("IsAutoIncrement", typeof(bool));
		dataTable.Columns.Add("IsRowVersion", typeof(bool));
		dataTable.Columns.Add("IsHidden", typeof(bool));
		dataTable.Columns.Add("IsLong", typeof(bool));
		dataTable.Columns.Add("IsReadOnly", typeof(bool));
		int num = 1;
		for (int i = 0; i < FieldCount; i++)
		{
			MySqlField mySqlField = ResultSet.Fields[i];
			DataRow dataRow = dataTable.NewRow();
			dataRow["ColumnName"] = mySqlField.ColumnName;
			dataRow["ColumnOrdinal"] = num++;
			dataRow["ColumnSize"] = (mySqlField.IsTextField ? (mySqlField.ColumnLength / mySqlField.MaxLength) : mySqlField.ColumnLength);
			int precision = mySqlField.Precision;
			int scale = mySqlField.Scale;
			dataRow["NumericPrecision"] = (short)precision;
			dataRow["NumericScale"] = (short)scale;
			dataRow["DataType"] = GetFieldType(i);
			dataRow["ProviderType"] = (int)mySqlField.Type;
			dataRow["IsLong"] = mySqlField.IsBlob && (mySqlField.ColumnLength > 255 || mySqlField.ColumnLength == -1);
			dataRow["AllowDBNull"] = mySqlField.AllowsNull;
			dataRow["IsReadOnly"] = false;
			dataRow["IsRowVersion"] = false;
			dataRow["IsUnique"] = false;
			dataRow["IsKey"] = mySqlField.IsPrimaryKey;
			dataRow["IsAutoIncrement"] = mySqlField.IsAutoIncrement;
			dataRow["BaseSchemaName"] = mySqlField.DatabaseName;
			dataRow["BaseCatalogName"] = null;
			dataRow["BaseTableName"] = mySqlField.RealTableName;
			dataRow["BaseColumnName"] = mySqlField.OriginalColumnName;
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}
}
