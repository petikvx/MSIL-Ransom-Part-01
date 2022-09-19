using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskLogonType
{
	None,
	Password,
	S4U,
	InteractiveToken,
	Group,
	ServiceAccount,
	InteractiveTokenOrPassword
}
