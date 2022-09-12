using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("555e2f8a-a1f6-41dd-88ca-ed4ed6b98a22")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILoadContextInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsPrivateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsAnonymousAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOriginAttributesAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr BinaryOriginAttributesPtr();
}
