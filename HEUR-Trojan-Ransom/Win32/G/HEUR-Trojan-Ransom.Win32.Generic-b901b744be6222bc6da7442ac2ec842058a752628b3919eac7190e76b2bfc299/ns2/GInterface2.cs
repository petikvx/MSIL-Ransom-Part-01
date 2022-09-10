using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns2;

[ComImport]
[InterfaceType(1)]
[Guid("789C1CBF-31EE-11D0-8C39-00C04FD9126B")]
public interface GInterface2
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Next([In] int celt, [In][Out] ref Guid rgelt, [In][Out] ref int pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] int celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface2 Clone();
}
