using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("31411221-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxRegFilter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75520)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxRegFilterPropId propid);
}
