using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[Flags]
[ComVisible(false)]
public enum WhichWeek : short
{
	FirstWeek = 1,
	SecondWeek = 2,
	ThirdWeek = 4,
	FourthWeek = 8,
	LastWeek = 0x10,
	AllWeeks = 0x1F
}
