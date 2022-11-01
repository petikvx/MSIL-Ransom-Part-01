using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("866738B9-6CF2-4DE8-8767-F794EBE74F4E")]
public interface IShellDispatch5 : IShellDispatch4, IShellDispatch3, IShellDispatch2, IShellDispatch
{
	void _VtblGap1_2();

	[DispId(1610743810)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Folder NameSpace([In][MarshalAs(UnmanagedType.Struct)] object vDir);
}
