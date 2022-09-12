using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D5B61B82-1DA4-11d3-BF87-00105A1B0627")]
public interface nsIController
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string command);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SupportsCommand([MarshalAs(UnmanagedType.LPStr)] string command);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommand([MarshalAs(UnmanagedType.LPStr)] string command);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnEvent([MarshalAs(UnmanagedType.LPStr)] string eventName);
}
