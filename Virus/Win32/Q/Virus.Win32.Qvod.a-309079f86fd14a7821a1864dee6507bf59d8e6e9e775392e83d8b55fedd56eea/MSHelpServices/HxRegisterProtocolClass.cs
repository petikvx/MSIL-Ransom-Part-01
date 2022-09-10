using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(2)]
[Guid("31411228-A502-11D2-BBCA-00C04F8EC294")]
[ClassInterface(0)]
public class HxRegisterProtocolClass
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern HxRegisterProtocolClass();
}
