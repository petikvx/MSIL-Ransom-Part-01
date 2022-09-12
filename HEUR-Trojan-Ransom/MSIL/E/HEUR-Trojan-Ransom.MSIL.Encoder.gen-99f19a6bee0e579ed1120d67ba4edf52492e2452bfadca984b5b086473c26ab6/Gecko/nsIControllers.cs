using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f36e3ec1-9197-4ad8-8d4c-d3b1927fd6df")]
public interface nsIControllers
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIController GetControllerForCommand([MarshalAs(UnmanagedType.LPStr)] string command);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertControllerAt(uint index, [MarshalAs(UnmanagedType.Interface)] nsIController controller);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIController RemoveControllerAt(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIController GetControllerAt(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendController([MarshalAs(UnmanagedType.Interface)] nsIController controller);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveController([MarshalAs(UnmanagedType.Interface)] nsIController controller);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetControllerId([MarshalAs(UnmanagedType.Interface)] nsIController controller);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIController GetControllerById(uint controllerID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetControllerCount();
}
