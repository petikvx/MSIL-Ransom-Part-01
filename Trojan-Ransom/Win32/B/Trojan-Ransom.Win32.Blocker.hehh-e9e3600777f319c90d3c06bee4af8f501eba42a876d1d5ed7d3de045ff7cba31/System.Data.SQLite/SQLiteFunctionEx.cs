namespace System.Data.SQLite;

public class SQLiteFunctionEx : SQLiteFunction
{
	protected CollationSequence GetCollationSequence()
	{
		return _base.GetCollationSequence(this, _context);
	}
}
