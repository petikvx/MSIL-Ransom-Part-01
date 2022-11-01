using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[Guid("317EE249-F12E-11D2-B1E4-00C04F8EEB3E")]
[CompilerGenerated]
[TypeIdentifier]
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
}
