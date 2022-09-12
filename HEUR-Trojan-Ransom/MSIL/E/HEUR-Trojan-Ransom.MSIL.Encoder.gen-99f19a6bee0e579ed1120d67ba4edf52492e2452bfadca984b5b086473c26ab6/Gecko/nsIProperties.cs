using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("78650582-4e93-4b60-8e85-26ebd3eb14ca")]
public interface nsIProperties
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr Get([MarshalAs(UnmanagedType.LPStr)] string prop, ref Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Set([MarshalAs(UnmanagedType.LPStr)] string prop, [MarshalAs(UnmanagedType.Interface)] nsISupports value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Has([MarshalAs(UnmanagedType.LPStr)] string prop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Undefine([MarshalAs(UnmanagedType.LPStr)] string prop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeys(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref string[] keys);
}
