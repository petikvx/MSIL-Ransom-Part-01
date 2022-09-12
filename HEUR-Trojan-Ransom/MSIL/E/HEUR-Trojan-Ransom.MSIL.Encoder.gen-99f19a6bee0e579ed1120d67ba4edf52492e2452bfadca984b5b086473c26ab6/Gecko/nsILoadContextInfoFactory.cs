using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c1c7023d-4318-4f99-8307-b5ccf0558793")]
public interface nsILoadContextInfoFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadContextInfo GetDefaultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadContextInfo GetPrivateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadContextInfo GetAnonymousAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadContextInfo Custom([MarshalAs(UnmanagedType.U1)] bool aPrivate, [MarshalAs(UnmanagedType.U1)] bool aAnonymous, ref JsVal aOriginAttributes, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadContextInfo FromLoadContext([MarshalAs(UnmanagedType.Interface)] nsILoadContext aLoadContext, [MarshalAs(UnmanagedType.U1)] bool aAnonymous);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadContextInfo FromWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.U1)] bool aAnonymous);
}
