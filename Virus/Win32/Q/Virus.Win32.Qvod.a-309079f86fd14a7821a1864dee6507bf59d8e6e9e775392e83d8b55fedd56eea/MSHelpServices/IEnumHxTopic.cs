using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("31411195-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(16)]
[InterfaceType(1)]
public interface IEnumHxTopic
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IHxTopic ppIHxTopic, out uint pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] uint celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumHxTopic ppEnum);
}
