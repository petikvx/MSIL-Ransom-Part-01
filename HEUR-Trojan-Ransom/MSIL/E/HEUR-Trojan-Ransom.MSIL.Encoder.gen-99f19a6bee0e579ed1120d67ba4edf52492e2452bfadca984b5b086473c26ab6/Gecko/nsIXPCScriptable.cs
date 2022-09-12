using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("19b70b26-7c3f-437f-a04a-2a8f9e28b617")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXPCScriptable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetClassNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetScriptableFlags();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PreCreate([MarshalAs(UnmanagedType.Interface)] nsISupports nativeObj, IntPtr cx, IntPtr globalObj, ref IntPtr parentObj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AddProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj, IntPtr id, ref JsVal val);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj, IntPtr id, IntPtr vp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SetProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj, IntPtr id, IntPtr vp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Enumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool NewEnumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj, IntPtr properties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Resolve([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj, IntPtr id, [MarshalAs(UnmanagedType.U1)] ref bool resolvedp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Finalize([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr fop, IntPtr obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Call([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj, IntPtr args);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Construct([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj, IntPtr args);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasInstance([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, IntPtr cx, IntPtr obj, ref JsVal val, [MarshalAs(UnmanagedType.U1)] ref bool bp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PostCreatePrototype(IntPtr cx, IntPtr proto);
}
