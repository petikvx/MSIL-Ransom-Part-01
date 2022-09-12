using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("D5C0D1F9-22D7-47DC-BF91-D9AC6E1251A6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISOCKSSocketInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetDestinationAddrAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDestinationAddrAttribute(IntPtr aDestinationAddr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetExternalProxyAddrAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExternalProxyAddrAttribute(IntPtr aExternalProxyAddr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetInternalProxyAddrAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInternalProxyAddrAttribute(IntPtr aInternalProxyAddr);
}
