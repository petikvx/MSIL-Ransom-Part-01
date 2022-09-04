using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[TypeLibType(4288)]
[Guid("ADDA3D55-6F72-4319-BFF9-18600A539B10")]
public interface Interface10
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744809)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Interface21 Method5([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In] uint A_2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744812)]
	int Method4([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In] uint A_2, [In][MarshalAs(UnmanagedType.IUnknown)] object A_3);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744813)]
	void Method3([In] int A_1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744814)]
	void Method2([In] int A_1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744811)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Interface19 Method1([In][MarshalAs(UnmanagedType.BStr)] string A_1);
}
