using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("114744d9-c369-456e-b55a-52fe52880d2d")]
public interface nsIArray
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr QueryElementAt(uint index, ref Guid uuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint IndexOf(uint startIndex, [MarshalAs(UnmanagedType.Interface)] nsISupports element);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator Enumerate();
}
