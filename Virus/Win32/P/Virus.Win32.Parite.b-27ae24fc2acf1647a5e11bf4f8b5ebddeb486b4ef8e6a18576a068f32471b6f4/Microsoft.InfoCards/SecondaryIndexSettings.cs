using System;

namespace Microsoft.InfoCards;

[Flags]
internal enum SecondaryIndexSettings
{
	None = 0,
	Nullable = 1,
	Unique = 2
}
