namespace MySql.Data.MySqlClient;

public enum MySqlTraceEventType
{
	ConnectionOpened = 1,
	ConnectionClosed,
	QueryOpened,
	ResultOpened,
	ResultClosed,
	QueryClosed,
	StatementPrepared,
	StatementExecuted,
	StatementClosed,
	NonQuery,
	UsageAdvisorWarning,
	Warning,
	Error,
	QueryNormalized
}
