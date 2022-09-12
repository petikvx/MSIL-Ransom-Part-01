using Google.Protobuf.Reflection;

namespace Mysqlx.Resultset;

internal enum ContentType_BYTES
{
	[OriginalName("CBNONE")]
	Cbnone,
	[OriginalName("GEOMETRY")]
	Geometry,
	[OriginalName("JSON")]
	Json,
	[OriginalName("XML")]
	Xml
}
