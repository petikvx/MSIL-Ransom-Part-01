using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace sexas;

public class Sqlite
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

	private byte[] db_bytes;

	private ulong encoding;

	private string[] field_names;

	private sqlite_master_entry[] master_table_entries;

	private ushort page_size;

	private byte[] SQLDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

	private table_entry[] table_entries;

	public Sqlite(string baseName)
	{
		if (File.Exists(baseName))
		{
			FileSystem.FileOpen(1, baseName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			string s = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref s, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			db_bytes = Encoding.Default.GetBytes(s);
			if (Encoding.Default.GetString(db_bytes, 0, 15).CompareTo("SQLite format 3") != 0)
			{
				throw new Exception("Not a valid SQLite 3 Database File");
			}
			if (db_bytes[52] != 0)
			{
				throw new Exception("Auto-vacuum capable database is not supported");
			}
			page_size = (ushort)ConvertToInteger(16, 2);
			encoding = ConvertToInteger(56, 4);
			if (decimal.Compare(new decimal(encoding), 0m) == 0)
			{
				encoding = 1uL;
			}
			ReadMasterTable(100uL);
		}
	}

	private ulong ConvertToInteger(int startIndex, int Size)
	{
		if (Size > 8 || Size == 0)
		{
			return 0uL;
		}
		ulong num = 0uL;
		int num2 = Size - 1;
		for (int i = 0; i <= num2; i++)
		{
			num = (num << 8) | db_bytes[startIndex + i];
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
			array[0] = (byte)(db_bytes[startIndex] & 0x7Fu);
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
			array[0] = db_bytes[endIndex - 1];
			endIndex--;
			num4 = 1;
		}
		for (int i = endIndex - 1; i >= startIndex; i += -1)
		{
			if (i - 1 >= startIndex)
			{
				array[num4] = (byte)(((byte)(db_bytes[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(db_bytes[i - 1] << (num3 & 7)));
				num2++;
				num4++;
				num3--;
			}
			else if (!flag)
			{
				array[num4] = (byte)((byte)(db_bytes[i] >> ((num2 - 1) & 7)) & (255 >> num2));
			}
		}
		return BitConverter.ToInt64(array, 0);
	}

	public int GetRowCount()
	{
		return table_entries.Length;
	}

	public string[] GetTableNames()
	{
		string[] array = null;
		int num = 0;
		int num2 = master_table_entries.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (master_table_entries[i].item_type == "table")
			{
				array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
				array[num] = master_table_entries[i].item_name;
				num++;
			}
		}
		return array;
	}

	public string GetValue(int row_num, int field)
	{
		if (row_num >= table_entries.Length)
		{
			return null;
		}
		if (field >= table_entries[row_num].content.Length)
		{
			return null;
		}
		return table_entries[row_num].content[field];
	}

	public string GetValue(int row_num, string field)
	{
		int num = -1;
		int num2 = field_names.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (field_names[i].ToLower().CompareTo(field.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return GetValue(row_num, num);
	}

	private int GVL(int startIndex)
	{
		if (startIndex > db_bytes.Length)
		{
			return 0;
		}
		int num = startIndex + 8;
		int num2 = startIndex;
		while (true)
		{
			if (num2 <= num)
			{
				if (num2 <= db_bytes.Length - 1)
				{
					if ((db_bytes[num2] & 0x80) != 128)
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

	private void ReadMasterTable(ulong Offset)
	{
		if (db_bytes[(uint)Offset] == 13)
		{
			ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
			int num2 = 0;
			if (master_table_entries != null)
			{
				num2 = master_table_entries.Length;
				master_table_entries = (sqlite_master_entry[])Utils.CopyArray((Array)master_table_entries, (Array)new sqlite_master_entry[master_table_entries.Length + num + 1]);
			}
			else
			{
				master_table_entries = new sqlite_master_entry[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 8m), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(Offset), 100m) != 0)
				{
					num4 += Offset;
				}
				int num5 = GVL((int)num4);
				CVL((int)num4, num5);
				int num6 = GVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
				master_table_entries[num2 + i].row_id = CVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
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
						array[num7] = SQLDataTypeSize[(int)array[num7]];
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
				if (decimal.Compare(new decimal(encoding), 1m) == 0)
				{
					master_table_entries[num2 + i].item_type = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(encoding), 2m) == 0)
				{
					master_table_entries[num2 + i].item_type = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(encoding), 3m) == 0)
				{
					master_table_entries[num2 + i].item_type = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				if (decimal.Compare(new decimal(encoding), 1m) == 0)
				{
					master_table_entries[num2 + i].item_name = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(encoding), 2m) == 0)
				{
					master_table_entries[num2 + i].item_name = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(encoding), 3m) == 0)
				{
					master_table_entries[num2 + i].item_name = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				master_table_entries[num2 + i].root_num = (long)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
				if (decimal.Compare(new decimal(encoding), 1m) == 0)
				{
					master_table_entries[num2 + i].sql_statement = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(encoding), 2m) == 0)
				{
					master_table_entries[num2 + i].sql_statement = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(encoding), 3m) == 0)
				{
					master_table_entries[num2 + i].sql_statement = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
			}
		}
		else
		{
			if (db_bytes[(uint)Offset] != 5)
			{
				return;
			}
			int num8 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
			for (int j = 0; j <= num8; j++)
			{
				ushort num9 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 12m), new decimal(j * 2))), 2);
				if (decimal.Compare(new decimal(Offset), 100m) == 0)
				{
					ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(num9, 4)), 1m), new decimal(page_size))));
				}
				else
				{
					ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(Offset + num9), 4)), 1m), new decimal(page_size))));
				}
			}
			ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 8m)), 4)), 1m), new decimal(page_size))));
		}
	}

	public bool ReadTable(string TableName)
	{
		int num = -1;
		int num2 = master_table_entries.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (master_table_entries[i].item_name.ToLower().CompareTo(TableName.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return false;
		}
		string[] array = master_table_entries[num].sql_statement.Substring(master_table_entries[num].sql_statement.IndexOf("(") + 1).Split(new char[1] { ',' });
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
			field_names = (string[])Utils.CopyArray((Array)field_names, (Array)new string[j + 1]);
			field_names[j] = array[j];
		}
		return ReadTableFromOffset((ulong)((master_table_entries[num].root_num - 1L) * page_size));
	}

	private bool ReadTableFromOffset(ulong Offset)
	{
		if (db_bytes[(uint)Offset] == 13)
		{
			int num = Convert.ToInt32(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
			int num2 = 0;
			if (table_entries != null)
			{
				num2 = table_entries.Length;
				table_entries = (table_entry[])Utils.CopyArray((Array)table_entries, (Array)new table_entry[table_entries.Length + num + 1]);
			}
			else
			{
				table_entries = new table_entry[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				record_header_field[] array = null;
				ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 8m), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(Offset), 100m) != 0)
				{
					num4 += Offset;
				}
				int num5 = GVL((int)num4);
				CVL((int)num4, num5);
				int num6 = GVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
				table_entries[num2 + i].row_id = CVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
				num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
				num5 = GVL((int)num4);
				num6 = num5;
				long num7 = CVL((int)num4, num5);
				long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
				int num9 = 0;
				while (num8 < num7)
				{
					array = (record_header_field[])Utils.CopyArray((Array)array, (Array)new record_header_field[num9 + 1]);
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
						array[num9].size = SQLDataTypeSize[(int)array[num9].type];
					}
					num8 = num8 + (num6 - num5) + 1L;
					num9++;
				}
				table_entries[num2 + i].content = new string[array.Length - 1 + 1];
				int num10 = 0;
				int num11 = array.Length - 1;
				for (int j = 0; j <= num11; j++)
				{
					if (array[j].type > 9L)
					{
						if (!IsOdd(array[j].type))
						{
							if (decimal.Compare(new decimal(encoding), 1m) == 0)
							{
								table_entries[num2 + i].content[j] = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
							}
							else if (decimal.Compare(new decimal(encoding), 2m) == 0)
							{
								table_entries[num2 + i].content[j] = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
							}
							else if (decimal.Compare(new decimal(encoding), 3m) == 0)
							{
								table_entries[num2 + i].content[j] = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
							}
						}
						else
						{
							table_entries[num2 + i].content[j] = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
						}
					}
					else
					{
						table_entries[num2 + i].content[j] = Conversions.ToString(ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size));
					}
					num10 += (int)array[j].size;
				}
			}
		}
		else if (db_bytes[(uint)Offset] == 5)
		{
			int num12 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
			for (int k = 0; k <= num12; k++)
			{
				ushort num13 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 12m), new decimal(k * 2))), 2);
				ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(Offset + num13), 4)), 1m), new decimal(page_size))));
			}
			ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 8m)), 4)), 1m), new decimal(page_size))));
		}
		return true;
	}
}
