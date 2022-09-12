using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3820e663-8e22-4789-b470-56bcf7083f2b")]
public interface nsIInterfaceInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetNameAttribute();

	Guid GetInterfaceIIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsScriptable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsBuiltinClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceInfo GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetMethodCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetConstantCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetMethodInfo(ushort index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetMethodInfoForName([MarshalAs(UnmanagedType.LPStr)] string methodName, ref ushort index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetConstant(ushort index, ref MutableJSVal constant, [MarshalAs(UnmanagedType.LPStr)] ref string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceInfo GetInfoForParam(ushort methodIndex, IntPtr param);

	Guid GetIIDForParam(ushort methodIndex, IntPtr param);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetTypeForParam(ushort methodIndex, IntPtr param, ushort dimension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	byte GetSizeIsArgNumberForParam(ushort methodIndex, IntPtr param, ushort dimension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	byte GetInterfaceIsArgNumberForParam(ushort methodIndex, IntPtr param);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsIID(Guid IID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetNameShared();

	Guid GetIIDShared();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsFunction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasAncestor(Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIIDForParamNoAlloc(ushort methodIndex, IntPtr param, ref Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsMainProcessScriptableOnly();
}
