using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("652B9EC5-D159-45D7-9127-50BB559486CD")]
public interface nsINetAddr
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetFamilyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAddress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFlowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetScopeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsV4MappedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetNetAddr();
}
