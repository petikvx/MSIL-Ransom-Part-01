using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("314111EF-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxRegistryWalker
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(72960)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegNamespaceList RegisteredNamespaceList(string bstrStart);
}
