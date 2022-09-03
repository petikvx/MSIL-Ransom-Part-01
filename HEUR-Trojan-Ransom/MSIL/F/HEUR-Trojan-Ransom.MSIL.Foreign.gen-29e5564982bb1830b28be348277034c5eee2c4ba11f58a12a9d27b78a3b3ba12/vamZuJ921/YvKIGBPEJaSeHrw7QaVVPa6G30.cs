using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace vamZuJ921;

[ComImport]
[Guid("789C1CBF-31EE-11D0-8C39-00C04FD9126B")]
[InterfaceType(1)]
public interface YvKIGBPEJaSeHrw7QaVVPa6G30
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Next([In] int celt, [In][Out] ref N2SNJDzncUu1NXZzBL66bnff42 rgelt, [In][Out] ref int pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] int celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	YvKIGBPEJaSeHrw7QaVVPa6G30 Clone();
}
