using System;

namespace ns0;

[Flags]
public enum GEnum7 : ulong
{
	FileShareRead = 1uL,
	FileShareWrite = 2uL,
	FileShareDelete = 4uL
}
