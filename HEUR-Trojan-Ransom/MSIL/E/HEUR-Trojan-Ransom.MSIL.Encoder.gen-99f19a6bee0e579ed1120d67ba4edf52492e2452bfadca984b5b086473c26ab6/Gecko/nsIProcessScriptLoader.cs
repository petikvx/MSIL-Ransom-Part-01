using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7e1e1a20-b24f-11e4-ab27-0800200c9a66")]
public interface nsIProcessScriptLoader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadProcessScript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL, [MarshalAs(UnmanagedType.U1)] bool aAllowDelayedLoad);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDelayedProcessScript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetDelayedProcessScripts(IntPtr jsContext);
}
