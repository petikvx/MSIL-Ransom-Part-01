namespace System.Data.SQLite;

internal struct SQLiteTypeNames
{
	internal string typeName;

	internal DbType dataType;

	internal SQLiteTypeNames(string newtypeName, DbType newdataType)
	{
		typeName = newtypeName;
		dataType = newdataType;
	}
}
