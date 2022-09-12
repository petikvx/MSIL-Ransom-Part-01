using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4f94b21f-2920-4bd9-8251-5fb60fb054b2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface xpcIJSModuleLoader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal Import([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aResourceURI, ref JsVal targetObj, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr ImportInto([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aResourceURI, IntPtr targetObj, IntPtr cc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Unload([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aResourceURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsModuleLoaded([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aResourceURI);
}
