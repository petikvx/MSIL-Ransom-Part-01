using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[InterfaceType(1)]
[Guid("314111D6-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(16)]
public interface IEnumHxAttrValue
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IHxAttrValue ppIHxAttrValue, out uint pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] uint celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumHxAttrValue ppEnum);
}
