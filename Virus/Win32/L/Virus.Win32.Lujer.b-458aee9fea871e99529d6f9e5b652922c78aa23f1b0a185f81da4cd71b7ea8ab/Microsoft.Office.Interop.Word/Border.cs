using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[DefaultMember("Visible")]
[TypeIdentifier]
[CompilerGenerated]
[Guid("0002093B-0000-0000-C000-000000000046")]
public interface Border
{
	[DispId(3)]
	WdLineStyle LineStyle
	{
		[DispId(3)]
		get;
		[DispId(3)]
		[param: In]
		set;
	}

	[DispId(0)]
	bool Visible
	{
		[DispId(0)]
		get;
		[DispId(0)]
		[param: In]
		set;
	}

	void _VtblGap1_3();

	void _VtblGap2_3();
}
