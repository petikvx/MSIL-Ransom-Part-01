using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("3141120A-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxRegPlugIn
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(74752)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxRegPlugInPropId propid);
}
