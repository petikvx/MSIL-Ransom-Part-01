using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[InterfaceType(1)]
[Guid("314111D0-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(16)]
public interface IEnumHxAttrName
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IHxAttrName ppIHxAttrName, out uint pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] uint celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumHxAttrName ppEnum);
}
