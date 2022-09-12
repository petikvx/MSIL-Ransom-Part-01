using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("82b24a20-6701-4d40-a0f9-f5dc7321b555")]
public interface nsIDomainPolicy
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDomainSet GetBlacklistAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDomainSet GetSuperBlacklistAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDomainSet GetWhitelistAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDomainSet GetSuperWhitelistAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Deactivate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloneDomainPolicy(IntPtr aClone);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ApplyClone(IntPtr aClone);
}
