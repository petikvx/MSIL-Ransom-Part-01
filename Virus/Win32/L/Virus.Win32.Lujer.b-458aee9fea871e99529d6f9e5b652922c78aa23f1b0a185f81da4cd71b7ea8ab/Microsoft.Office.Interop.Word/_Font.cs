using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[Guid("00020952-0000-0000-C000-000000000046")]
[CompilerGenerated]
[TypeIdentifier]
public interface _Font
{
	[DispId(159)]
	WdColor Color
	{
		[DispId(159)]
		get;
		[DispId(159)]
		[param: In]
		set;
	}

	[DispId(141)]
	float Size
	{
		[DispId(141)]
		get;
		[DispId(141)]
		[param: In]
		set;
	}

	void _VtblGap1_26();

	void _VtblGap2_37();
}
