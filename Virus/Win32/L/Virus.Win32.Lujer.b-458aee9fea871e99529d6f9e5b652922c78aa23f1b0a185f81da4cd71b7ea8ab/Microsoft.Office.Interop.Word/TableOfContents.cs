using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[TypeIdentifier]
[Guid("00020913-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface TableOfContents
{
	[DispId(10)]
	WdTabLeader TabLeader
	{
		[DispId(10)]
		get;
		[DispId(10)]
		[param: In]
		set;
	}

	void _VtblGap1_19();
}
