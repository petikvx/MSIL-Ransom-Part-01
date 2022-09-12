using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("EEC0B435-7F53-44FE-B00A-CF3EED65C01A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICommandController
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCommandStateWithParams([MarshalAs(UnmanagedType.LPStr)] string command, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aCommandParams);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommandWithParams([MarshalAs(UnmanagedType.LPStr)] string command, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aCommandParams);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSupportedCommands(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref string[] commands);
}
