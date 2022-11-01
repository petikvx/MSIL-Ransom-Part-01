using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[CompilerGenerated]
[DefaultMember("Title")]
[Guid("BBCBDE60-C3FF-11CE-8350-444553540000")]
[TypeIdentifier]
public interface Folder
{
	void _VtblGap1_4();

	[DispId(1610743812)]
	[return: MarshalAs(UnmanagedType.Interface)]
	FolderItems Items();

	[DispId(1610743813)]
	[return: MarshalAs(UnmanagedType.Interface)]
	FolderItem ParseName([In][MarshalAs(UnmanagedType.BStr)] string bName);

	void _VtblGap2_2();

	[DispId(1610743816)]
	void CopyHere([In][MarshalAs(UnmanagedType.Struct)] object vItem, [Optional][In][MarshalAs(UnmanagedType.Struct)] object vOptions);
}
