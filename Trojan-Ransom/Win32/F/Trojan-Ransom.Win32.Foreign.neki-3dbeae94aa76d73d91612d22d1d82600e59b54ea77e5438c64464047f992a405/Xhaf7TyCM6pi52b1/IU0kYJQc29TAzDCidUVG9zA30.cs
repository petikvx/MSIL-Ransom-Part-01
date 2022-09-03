using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Xhaf7TyCM6pi52b1;

[ComImport]
[InterfaceType(1)]
[Guid("789C1CBF-31EE-11D0-8C39-00C04FD9126B")]
public interface IU0kYJQc29TAzDCidUVG9zA30
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Next([In] int celt, [In][Out] ref SAvYx91r2YtNjgGhe2WHZJd42 rgelt, [In][Out] ref int pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] int celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IU0kYJQc29TAzDCidUVG9zA30 Clone();
}
