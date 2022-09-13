namespace youknowcaliber;

internal class SQLite
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

	private readonly byte[] _sqlDataTypeSize;

	private readonly ulong _dbEncoding;

	private readonly byte[] _fileBytes;

	private readonly ulong _pageSize;

	private string[] _fieldNames;

	private SqliteMasterEntry[] _masterTableEntries;

	private TableEntry[] _tableEntries;

	public extern SQLite(string fileName);

	public extern string GetValue(int rowNum, int field);

	public int GetRowCount()
	{
		_ = (nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
		throw /*Error near IL_0004: ldarg 3 (out-of-bounds)*/;
	}

	private extern bool ReadTableFromOffset(ulong offset);

	private void ReadMasterTable(long offset)
	{
		//Discarded unreachable code: IL_000b, IL_0011, IL_0014, IL_0021, IL_0022
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
			{
			}
		}
	}

	public extern bool ReadTable(string tableName);

	private extern ulong ConvertToULong(int startIndex, int size);

	private extern int Gvl(int startIdx);

	private long Cvl(int startIdx, int endIdx)
	{
		//Discarded unreachable code: IL_0007, IL_000c
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	private static extern bool IsOdd(long value);

	public static extern SQLite ReadTable(string database, string table);
}
