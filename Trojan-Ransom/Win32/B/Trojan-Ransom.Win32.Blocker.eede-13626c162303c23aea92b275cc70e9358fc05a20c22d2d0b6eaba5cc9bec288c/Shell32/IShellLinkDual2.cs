using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("317EE249-F12E-11D2-B1E4-00C04F8EEB3E")]
public interface IShellLinkDual2 : IShellLinkDual
{
	string Path
	{
		[DispId(1610743808)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(1610743808)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string WorkingDirectory
	{
		[DispId(1610743812)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(1610743812)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string Arguments
	{
		[DispId(1610743814)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(1610743814)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_2();

	void _VtblGap2_7();

	[DispId(1610743823)]
	void Save([Optional][In][MarshalAs(UnmanagedType.Struct)] object vWhere);
}
