using MySql.Data.Common;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

internal interface IDriver
{
	int ThreadId { get; }

	DBVersion Version { get; }

	ServerStatusFlags ServerStatus { get; }

	ClientFlags Flags { get; }

	int WarningCount { get; }

	void Configure();

	void Open();

	void SendQuery(MySqlPacket packet);

	void Close(bool isOpen);

	bool Ping();

	int GetResult(ref int affectedRows, ref long insertedId);

	bool FetchDataRow(int statementId, int columns);

	int PrepareStatement(string sql, ref MySqlField[] parameters);

	void ExecuteStatement(MySqlPacket packet);

	void CloseStatement(int statementId);

	void SetDatabase(string dbName);

	void Reset();

	IMySqlValue ReadColumnValue(int index, MySqlField field, IMySqlValue valObject);

	void SkipColumnValue(IMySqlValue valueObject);

	void GetColumnsData(MySqlField[] columns);

	void ResetTimeout(int timeout);
}
