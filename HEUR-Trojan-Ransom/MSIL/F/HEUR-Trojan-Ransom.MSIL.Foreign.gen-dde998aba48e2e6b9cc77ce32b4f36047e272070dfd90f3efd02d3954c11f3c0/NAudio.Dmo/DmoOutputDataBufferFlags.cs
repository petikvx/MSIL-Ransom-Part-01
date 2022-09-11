using System;

namespace NAudio.Dmo;

[Flags]
public enum DmoOutputDataBufferFlags
{
	None = 0,
	SyncPoint = 1,
	Time = 2,
	TimeLength = 4,
	Incomplete = 0x1000000
}
