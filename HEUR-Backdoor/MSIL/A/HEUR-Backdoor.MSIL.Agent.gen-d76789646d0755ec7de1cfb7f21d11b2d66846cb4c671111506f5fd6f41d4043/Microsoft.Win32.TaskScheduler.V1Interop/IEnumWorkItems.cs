using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[SuppressUnmanagedCodeSecurity]
[Guid("148BD528-A2AB-11CE-B11F-00AA00530503")]
internal interface IEnumWorkItems
{
	[PreserveSig]
	int Next([In] uint RequestCount, out IntPtr Names, out uint Fetched);

	void Skip([In] uint Count);

	void Reset();

	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumWorkItems Clone();
}
