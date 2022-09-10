using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[TypeIdentifier]
[Guid("0002093A-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface Shading
{
	[DispId(5)]
	WdColor BackgroundPatternColor
	{
		[DispId(5)]
		get;
		[DispId(5)]
		[param: In]
		set;
	}

	[DispId(4)]
	WdColor ForegroundPatternColor
	{
		[DispId(4)]
		get;
		[DispId(4)]
		[param: In]
		set;
	}

	[DispId(3)]
	WdTextureIndex Texture
	{
		[DispId(3)]
		get;
		[DispId(3)]
		[param: In]
		set;
	}

	void _VtblGap1_7();
}
