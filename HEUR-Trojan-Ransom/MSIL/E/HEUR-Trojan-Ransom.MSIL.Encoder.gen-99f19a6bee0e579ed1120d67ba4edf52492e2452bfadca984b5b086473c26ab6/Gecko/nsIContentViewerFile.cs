using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("564a3276-6228-401e-9b5c-d82cb382a60f")]
public interface nsIContentViewerFile
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrintableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Print([MarshalAs(UnmanagedType.U1)] bool aSilent, IntPtr aDebugFile, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);
}
