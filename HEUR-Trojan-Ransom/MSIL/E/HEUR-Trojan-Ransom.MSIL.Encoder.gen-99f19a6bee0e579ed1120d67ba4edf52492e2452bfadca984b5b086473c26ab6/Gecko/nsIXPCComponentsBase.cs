using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("eeeada2f-86c0-4609-b2bf-4bf2351b1ce6")]
public interface nsIXPCComponentsBase
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPCComponents_Interfaces GetInterfacesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPCComponents_InterfacesByID GetInterfacesByIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetResultsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSuccessCode(int result);
}
