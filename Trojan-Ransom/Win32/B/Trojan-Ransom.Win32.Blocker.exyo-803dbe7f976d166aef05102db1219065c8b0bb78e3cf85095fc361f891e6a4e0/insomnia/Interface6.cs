using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[Guid("11D1C1B2-7DAA-4C9E-9595-7F82ED206D1E")]
[TypeLibType(4288)]
public interface Interface6
{
	[DispId(-525)]
	int Property56
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-525)]
		get;
	}

	[DispId(1610748311)]
	int Property55
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610748311)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748309)]
	void Method5([In][MarshalAs(UnmanagedType.BStr)] string A_1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748310)]
	void Method4([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In][MarshalAs(UnmanagedType.IUnknown)] object A_2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748312)]
	void Method3();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748313)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Interface19 Method2();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748314)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Interface19 Method1([In][MarshalAs(UnmanagedType.BStr)] string A_1);
}
