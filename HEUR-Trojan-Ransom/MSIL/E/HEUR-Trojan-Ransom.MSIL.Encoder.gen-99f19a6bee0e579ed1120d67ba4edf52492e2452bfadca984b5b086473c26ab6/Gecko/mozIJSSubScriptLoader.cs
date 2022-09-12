using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("19533e7b-f321-4ef1-bc59-6e812dc2a733")]
public interface mozIJSSubScriptLoader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal LoadSubScript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase url, ref JsVal obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase charset, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal LoadSubScriptWithOptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase url, ref JsVal options, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrecompileScript([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.Interface)] nsIObserver observer);
}
