using System;

namespace Alphaleonis.Win32.Filesystem;

[Flags]
public enum DosDeviceAttributes
{
	None = 0,
	RawTargetPath = 1,
	RemoveDefinition = 2,
	ExactMatchOnRemove = 4,
	NoBroadcastSystem = 8
}
