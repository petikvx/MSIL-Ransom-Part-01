using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("995ea724-1dd1-11b2-9211-c21bdd3e7ed0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISupportsInterfacePointer : nsISupportsPrimitive
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetDataIIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataIIDAttribute(IntPtr aDataIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string ToString();
}
