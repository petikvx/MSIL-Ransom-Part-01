using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("11ba5fd7-8db2-4b1a-9f67-342cfa11afad")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIEventListenerInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCapturingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowsUntrustedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInSystemEventGroupAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetListenerObjectAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToSource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
