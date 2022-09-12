using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal enum ViewCheckOption
{
	[OriginalName("NONE_ViewCheckOption")]
	NoneViewCheckOption,
	[OriginalName("LOCAL")]
	Local,
	[OriginalName("CASCADED")]
	Cascaded
}
