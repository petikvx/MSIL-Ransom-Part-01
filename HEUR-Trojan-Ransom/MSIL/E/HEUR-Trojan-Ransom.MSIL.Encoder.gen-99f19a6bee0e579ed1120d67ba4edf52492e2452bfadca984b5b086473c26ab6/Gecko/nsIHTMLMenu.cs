using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d3d068d8-e223-4228-ba39-4d6df21ba616")]
public interface nsIHTMLMenu
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendShowEvent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMenuBuilder CreateBuilder();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Build([MarshalAs(UnmanagedType.Interface)] nsIMenuBuilder aBuilder);
}
