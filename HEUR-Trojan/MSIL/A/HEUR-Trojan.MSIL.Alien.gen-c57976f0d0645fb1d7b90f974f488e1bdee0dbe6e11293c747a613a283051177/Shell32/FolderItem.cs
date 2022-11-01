using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[CompilerGenerated]
[DefaultMember("Name")]
[Guid("FAC32C80-CBE4-11CE-8350-444553540000")]
[TypeIdentifier]
public interface FolderItem
{
	object GetLink
	{
		[DispId(1610743813)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	void _VtblGap1_5();
}
