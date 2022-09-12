using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("464484f0-568d-11d3-baf8-00805f8a5dd7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISupportsVoid : nsISupportsPrimitive
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataAttribute(IntPtr aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string ToString();
}
