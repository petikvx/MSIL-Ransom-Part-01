using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RQBV21;

[ComImport]
[InterfaceType(1)]
[Guid("789C1CBF-31EE-11D0-8C39-00C04FD9126B")]
public interface dHu9THhS9K9mI79r1ot66ple30
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Next([In] int celt, [In][Out] ref ArQbjx1DfqTjkrs95SQBTuPg42 rgelt, [In][Out] ref int pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] int celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	dHu9THhS9K9mI79r1ot66ple30 Clone();
}
