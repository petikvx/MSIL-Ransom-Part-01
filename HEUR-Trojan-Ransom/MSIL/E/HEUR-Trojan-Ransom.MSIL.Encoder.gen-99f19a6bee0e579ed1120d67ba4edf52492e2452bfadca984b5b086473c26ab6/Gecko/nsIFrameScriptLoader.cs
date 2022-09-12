using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bf61446b-ba24-4b1d-88c7-4f94724b9ce1")]
public interface nsIFrameScriptLoader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadFrameScript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL, [MarshalAs(UnmanagedType.U1)] bool aAllowDelayedLoad, [MarshalAs(UnmanagedType.U1)] bool aRunInGlobalScope);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDelayedFrameScript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetDelayedFrameScripts(IntPtr jsContext);
}
