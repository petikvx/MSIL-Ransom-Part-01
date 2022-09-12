using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("df58d5d6-4b02-4e4c-9b29-adbff06c6206")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMRequestService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDOMRequest CreateRequest([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDOMCursor CreateCursor([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.Interface)] nsICursorContinueCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FireSuccess([MarshalAs(UnmanagedType.Interface)] nsIDOMDOMRequest request, ref JsVal result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FireError([MarshalAs(UnmanagedType.Interface)] nsIDOMDOMRequest request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FireDetailedError([MarshalAs(UnmanagedType.Interface)] nsIDOMDOMRequest request, [MarshalAs(UnmanagedType.Interface)] nsISupports error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FireSuccessAsync([MarshalAs(UnmanagedType.Interface)] nsIDOMDOMRequest request, ref JsVal result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FireErrorAsync([MarshalAs(UnmanagedType.Interface)] nsIDOMDOMRequest request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FireDone([MarshalAs(UnmanagedType.Interface)] nsIDOMDOMCursor cursor);
}
