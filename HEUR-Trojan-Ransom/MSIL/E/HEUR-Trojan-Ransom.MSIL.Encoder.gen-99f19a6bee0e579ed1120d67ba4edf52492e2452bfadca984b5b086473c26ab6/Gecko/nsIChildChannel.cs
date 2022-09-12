using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c45b92ae-4f07-41dd-b0ef-aa044eeabb1e")]
public interface nsIChildChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConnectParent(uint id);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CompleteRedirectSetup([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
}
