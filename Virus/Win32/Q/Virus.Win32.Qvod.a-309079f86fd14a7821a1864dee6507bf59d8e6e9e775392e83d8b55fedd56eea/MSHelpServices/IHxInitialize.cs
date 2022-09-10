using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111AE-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxInitialize
{
	[DispId(72193)]
	string filter
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(72193)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(72193)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(72192)]
	void Initialize([In][MarshalAs(UnmanagedType.BStr)] string InitString, [In] int options);
}
