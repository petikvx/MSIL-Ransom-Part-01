using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c847f90e-b8f3-49db-a4df-8867831f2800")]
public interface nsIControllerCommandTable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void MakeImmutable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsIControllerCommand aCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsIControllerCommand aCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIControllerCommand FindCommandHandler([MarshalAs(UnmanagedType.LPStr)] string aCommandName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateCommandState([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SupportsCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommandParams([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aParam, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCommandState([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aParam, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandRefCon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSupportedCommands(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref string[] commands);
}
