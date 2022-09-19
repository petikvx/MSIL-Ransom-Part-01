using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

[SuppressUnmanagedCodeSecurity]
[Guid("148BD52B-A2AB-11CE-B11F-00AA00530503")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITaskTrigger
{
	void SetTrigger([In][Out][MarshalAs(UnmanagedType.Struct)] ref TaskTrigger Trigger);

	[return: MarshalAs(UnmanagedType.Struct)]
	TaskTrigger GetTrigger();

	CoTaskMemString GetTriggerString();
}
