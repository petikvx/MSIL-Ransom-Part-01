using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal interface IMySqlValue
{
	bool IsNull { get; }

	MySqlDbType MySqlDbType { get; }

	object Value { get; }

	Type SystemType { get; }

	string MySqlTypeName { get; }

	void WriteValue(MySqlPacket packet, bool binary, object value, int length);

	IMySqlValue ReadValue(MySqlPacket packet, long length, bool isNull);

	void SkipValue(MySqlPacket packet);
}
