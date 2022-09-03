using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0;

[ComImport]
[Guid("789C1CBF-31EE-11D0-8C39-00C04FD9126B")]
[InterfaceType(1)]
public interface HqpGuhPn9LV8LNT3Nt30
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Next([In] int celt, [In][Out] ref tAS0h4aRlkCM52XPTX42 rgelt, [In][Out] ref int pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] int celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	HqpGuhPn9LV8LNT3Nt30 Clone();
}
