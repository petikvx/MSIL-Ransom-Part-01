using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("887a0614-a0f0-4c0e-80e0-cf31e6d4e286")]
public interface nsIWorkerTest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void PostMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Terminate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWorkerTestCallback GetCallbackAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCallbackAttribute([MarshalAs(UnmanagedType.Interface)] nsIWorkerTestCallback aCallback);
}
