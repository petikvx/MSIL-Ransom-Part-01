using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public interface ITriggerDelay
{
	TimeSpan Delay { get; set; }
}
