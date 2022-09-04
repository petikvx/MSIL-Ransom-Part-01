using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[TypeIdentifier]
[DefaultMember("Title")]
[CompilerGenerated]
[Guid("BBCBDE60-C3FF-11CE-8350-444553540000")]
public interface Folder
{
	void _VtblGap1_4();

	[DispId(1610743812)]
	[return: MarshalAs(UnmanagedType.Interface)]
	FolderItems Items();
}
