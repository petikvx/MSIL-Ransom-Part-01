using System;

namespace Ionic.Zip;

[Flags]
public enum ZipEntryTimestamp
{
	None = 0,
	DOS = 1,
	Windows = 2,
	Unix = 4,
	InfoZip1 = 8
}
