using System;
using MySql.Data.MySqlClient;
using ns22;

namespace ns14;

internal interface Interface0
{
	bool IsNull { get; }

	MySqlDbType MySqlDbType { get; }

	object Value { get; }

	Type SystemType { get; }

	string MySqlTypeName { get; }

	void imethod_0(Class167 class167_0, bool bool_0, object object_0, int int_0);

	Interface0 imethod_1(Class167 class167_0, long long_0, bool bool_0);

	void imethod_2(Class167 class167_0);
}
