using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("31411198-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(2)]
[ClassInterface(0)]
[ComSourceInterfaces("MSHelpServices.IHxSessionEvents\0")]
public class HxSessionClass
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern HxSessionClass();
}
