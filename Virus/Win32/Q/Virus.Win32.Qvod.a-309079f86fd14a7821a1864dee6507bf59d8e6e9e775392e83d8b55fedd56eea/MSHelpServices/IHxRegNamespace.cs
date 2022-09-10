using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111F1-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxRegNamespace
{
	[DispId(73216)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(73216)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(73217)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxRegNamespacePropId propid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(73218)]
	bool IsTitle([In][MarshalAs(UnmanagedType.BStr)] string bstrTitle);
}
