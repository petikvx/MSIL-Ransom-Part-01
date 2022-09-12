using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal enum ViewSqlSecurity
{
	[OriginalName("NONE_ViewSqlSecurity")]
	NoneViewSqlSecurity,
	[OriginalName("INVOKER")]
	Invoker,
	[OriginalName("DEFINER")]
	Definer
}
