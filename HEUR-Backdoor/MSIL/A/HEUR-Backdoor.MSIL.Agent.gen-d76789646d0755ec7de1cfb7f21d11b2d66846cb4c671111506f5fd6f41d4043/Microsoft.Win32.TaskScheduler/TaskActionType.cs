using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskActionType
{
	ComHandler = 5,
	Execute = 0,
	SendEmail = 6,
	ShowMessage = 7
}
