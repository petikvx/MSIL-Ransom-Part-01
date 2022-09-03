using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace xiHyV7WnrxWEyGOfttfj1;

[ComImport]
[InterfaceType(1)]
[Guid("5A6F1EBF-2DB1-11D0-8C39-00C04FD9126B")]
public interface LcDeZ6S06jyaCDjr29
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Next([In] int celt, [In][Out] ref int rgelt, [In][Out] ref int pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] int celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	LcDeZ6S06jyaCDjr29 Clone();
}
