using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[CompilerGenerated]
[Guid("000209B7-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface Options
{
	[DispId(344)]
	WdColor DefaultBorderColor
	{
		[DispId(344)]
		get;
		[DispId(344)]
		[param: In]
		set;
	}

	[DispId(275)]
	WdLineStyle DefaultBorderLineStyle
	{
		[DispId(275)]
		get;
		[DispId(275)]
		[param: In]
		set;
	}

	[DispId(284)]
	WdLineWidth DefaultBorderLineWidth
	{
		[DispId(284)]
		get;
		[DispId(284)]
		[param: In]
		set;
	}

	void _VtblGap1_166();

	void _VtblGap2_16();

	void _VtblGap3_99();
}
