namespace MySql.Data.MySqlClient;

public enum UsageAdvisorWarningFlags
{
	NoIndex = 1,
	BadIndex,
	SkippedRows,
	SkippedColumns,
	FieldConversion
}
