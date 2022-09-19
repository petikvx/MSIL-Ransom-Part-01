using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[Guid("2C05C3F0-6EED-4c05-A15F-ED7D7A98A369")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[SuppressUnmanagedCodeSecurity]
internal interface ITaskSettings2
{
	bool DisallowStartOnRemoteAppSession
	{
		get; [param: In]
		set;
	}

	bool UseUnifiedSchedulingEngine
	{
		get; [param: In]
		set;
	}
}
