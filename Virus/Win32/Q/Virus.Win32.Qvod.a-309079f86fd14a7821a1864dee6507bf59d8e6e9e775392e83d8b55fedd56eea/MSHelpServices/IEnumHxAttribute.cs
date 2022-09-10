using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111AD-A502-11D2-BBCA-00C04F8EC294")]
[InterfaceType(1)]
[TypeLibType(16)]
public interface IEnumHxAttribute
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IHxAttribute ppIHxAttribute, out uint pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] uint celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumHxAttribute ppEnum);
}
