using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0eae9a46-1dd2-11b2-aca0-9176f05fe9db")]
public interface nsIControllerCommand
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCommandStateParams([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aParams, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommandParams([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aParams, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);
}
