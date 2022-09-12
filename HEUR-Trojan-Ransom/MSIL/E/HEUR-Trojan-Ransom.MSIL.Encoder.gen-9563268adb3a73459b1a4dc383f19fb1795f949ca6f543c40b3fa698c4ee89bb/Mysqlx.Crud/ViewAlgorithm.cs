using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal enum ViewAlgorithm
{
	[OriginalName("NONE_ViewAlgorithm")]
	NoneViewAlgorithm,
	[OriginalName("UNDEFINED")]
	Undefined,
	[OriginalName("MERGE")]
	Merge,
	[OriginalName("TEMPTABLE")]
	Temptable
}
