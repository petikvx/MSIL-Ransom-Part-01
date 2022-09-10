using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111F0-A502-11D2-BBCA-00C04F8EC294")]
[ClassInterface(0)]
[TypeLibType(2)]
public class HxRegistryWalkerClass
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern HxRegistryWalkerClass();
}
