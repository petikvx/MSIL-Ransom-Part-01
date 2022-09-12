using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6f30b676-3710-4c2c-80b1-0395fb26516e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebPageDescriptor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadPage([MarshalAs(UnmanagedType.Interface)] nsISupports aPageDescriptor, uint aDisplayType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetCurrentDescriptorAttribute();
}
