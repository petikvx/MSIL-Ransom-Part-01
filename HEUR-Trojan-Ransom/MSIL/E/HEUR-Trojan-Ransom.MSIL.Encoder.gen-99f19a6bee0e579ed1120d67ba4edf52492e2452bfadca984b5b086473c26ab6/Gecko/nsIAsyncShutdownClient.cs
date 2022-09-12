using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d2031049-b990-43a2-95be-59f8a3ca5954")]
public interface nsIAsyncShutdownClient
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddBlocker([MarshalAs(UnmanagedType.Interface)] nsIAsyncShutdownBlocker aBlocker, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFileName, int aLineNumber, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveBlocker([MarshalAs(UnmanagedType.Interface)] nsIAsyncShutdownBlocker aBlocker);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetJsclientAttribute();
}
