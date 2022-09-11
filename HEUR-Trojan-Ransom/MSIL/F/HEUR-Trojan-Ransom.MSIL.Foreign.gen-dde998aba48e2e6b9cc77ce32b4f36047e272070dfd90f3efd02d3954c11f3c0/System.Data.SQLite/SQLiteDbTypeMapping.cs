namespace System.Data.SQLite;

internal sealed class SQLiteDbTypeMapping
{
	internal string typeName;

	internal DbType dataType;

	internal bool primary;

	internal SQLiteDbTypeMapping(string newTypeName, DbType newDataType, bool newPrimary)
	{
		typeName = newTypeName;
		dataType = newDataType;
		primary = newPrimary;
	}
}
