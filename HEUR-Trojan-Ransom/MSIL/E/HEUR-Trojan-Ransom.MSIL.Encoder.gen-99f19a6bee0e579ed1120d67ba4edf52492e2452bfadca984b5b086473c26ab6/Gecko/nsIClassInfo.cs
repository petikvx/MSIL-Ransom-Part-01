using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a60569d7-d401-4677-ba63-2aa5971af25d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIClassInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInterfaces(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref Guid[] array);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPCScriptable GetScriptableHelper();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetContractIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetClassDescriptionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClassIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClassIDNoAllocAttribute();
}
