using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal enum DataModel
{
	[OriginalName("NONE_DataModel")]
	NoneDataModel,
	[OriginalName("DOCUMENT")]
	Document,
	[OriginalName("TABLE")]
	Table
}
