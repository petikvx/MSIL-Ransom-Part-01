using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[Guid("00020968-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
[DefaultMember("Name")]
public interface Bookmark
{
	[DispId(0)]
	string Name
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
