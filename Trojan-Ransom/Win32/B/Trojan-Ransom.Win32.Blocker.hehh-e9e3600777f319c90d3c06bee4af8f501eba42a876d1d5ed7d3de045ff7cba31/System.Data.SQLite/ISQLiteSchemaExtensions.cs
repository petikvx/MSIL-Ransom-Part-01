namespace System.Data.SQLite;

internal interface ISQLiteSchemaExtensions
{
	void BuildTempSchema(SQLiteConnection cnn);
}
