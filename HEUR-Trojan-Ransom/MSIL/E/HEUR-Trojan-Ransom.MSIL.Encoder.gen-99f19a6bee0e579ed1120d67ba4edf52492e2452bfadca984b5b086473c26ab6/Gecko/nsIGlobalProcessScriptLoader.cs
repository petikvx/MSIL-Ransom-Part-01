using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5b390753-abb3-49b0-ae3b-b803dab58144")]
public interface nsIGlobalProcessScriptLoader : nsIProcessScriptLoader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void LoadProcessScript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL, [MarshalAs(UnmanagedType.U1)] bool aAllowDelayedLoad);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveDelayedProcessScript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new JsVal GetDelayedProcessScripts(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetInitialProcessDataAttribute(IntPtr jsContext);
}
