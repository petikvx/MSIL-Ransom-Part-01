using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4bb27cb7-8984-4cee-8ce7-9b014c3d091b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProtectedAuthThread
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Login([MarshalAs(UnmanagedType.Interface)] nsIObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPKCS11Slot GetSlotAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTokenName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
