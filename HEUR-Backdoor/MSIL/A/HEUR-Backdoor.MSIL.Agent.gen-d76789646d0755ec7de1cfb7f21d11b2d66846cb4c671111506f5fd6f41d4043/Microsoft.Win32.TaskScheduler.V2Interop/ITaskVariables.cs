using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3E4C9351-D966-4B8B-BB87-CEBA68BB0107")]
internal interface ITaskVariables
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetInput();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOutput([In][MarshalAs(UnmanagedType.BStr)] string input);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetContext();
}
