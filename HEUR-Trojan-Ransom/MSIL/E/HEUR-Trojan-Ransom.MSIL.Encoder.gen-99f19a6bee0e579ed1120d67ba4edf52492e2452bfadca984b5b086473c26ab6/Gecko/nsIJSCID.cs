using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bf5eb086-9eaa-4694-aec3-fe4aac6119bd")]
public interface nsIJSCID : nsIJSID
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	new string GetNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	new string GetNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetValidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIJSID other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string ToString();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Initialize([MarshalAs(UnmanagedType.LPStr)] string idString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetID();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal CreateInstance(ref JsVal iid, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetService(ref JsVal iid, IntPtr jsContext, int argc);
}
