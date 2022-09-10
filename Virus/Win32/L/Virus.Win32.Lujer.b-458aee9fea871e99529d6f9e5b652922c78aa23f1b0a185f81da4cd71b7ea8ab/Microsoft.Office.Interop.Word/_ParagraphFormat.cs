using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[Guid("00020953-0000-0000-C000-000000000046")]
[CompilerGenerated]
[TypeIdentifier]
public interface _ParagraphFormat
{
	[DispId(101)]
	WdParagraphAlignment Alignment
	{
		[DispId(101)]
		get;
		[DispId(101)]
		[param: In]
		set;
	}

	void _VtblGap1_6();
}
