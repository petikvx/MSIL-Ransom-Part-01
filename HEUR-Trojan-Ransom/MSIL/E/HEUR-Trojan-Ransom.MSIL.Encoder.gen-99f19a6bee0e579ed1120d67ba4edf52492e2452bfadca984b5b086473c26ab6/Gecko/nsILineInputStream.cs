using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c97b466c-1e6e-4773-a4ab-2b2b3190a7a6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILineInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ReadLine([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aLine);
}
