using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[CompilerGenerated]
[Guid("744129E0-CBE5-11CE-8350-444553540000")]
[TypeIdentifier]
public interface FolderItems : IEnumerable
{
	void _VtblGap1_3();

	[DispId(1610743811)]
	[return: MarshalAs(UnmanagedType.Interface)]
	FolderItem Item([Optional][In][MarshalAs(UnmanagedType.Struct)] object index);
}
