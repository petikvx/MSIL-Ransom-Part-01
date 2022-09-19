using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler;

[ComImport]
[Guid("EAEC7A8F-27A0-4DDC-8675-14726A01A38A")]
[SuppressUnmanagedCodeSecurity]
[ComVisible(false)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ITaskHandlerStatus
{
	void UpdateStatus([In] short percentComplete, [In][MarshalAs(UnmanagedType.BStr)] string statusMessage);

	void TaskCompleted([In][MarshalAs(UnmanagedType.Error)] int taskErrCode);
}
