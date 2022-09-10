using System;

namespace Microsoft.InfoCards;

[Flags]
internal enum QueryDetails
{
	None = 0,
	Identifiers = 1,
	Header = 2,
	DataBlob = 4,
	IndexData = 8,
	FullHeader = 3,
	FullRow = 7,
	FullRowAndIndexes = 0xF
}
