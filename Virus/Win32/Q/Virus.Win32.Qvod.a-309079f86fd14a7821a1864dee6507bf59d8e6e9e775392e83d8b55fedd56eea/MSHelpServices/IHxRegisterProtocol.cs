using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("31411227-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxRegisterProtocol
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	void Register();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743809)]
	void Unregister();
}
