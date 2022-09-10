using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("31411202-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxRegTitle
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(73984)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxRegTitlePropId propid);
}
