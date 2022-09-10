using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[Guid("0002094B-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface Columns : IEnumerable
{
	[DispId(2)]
	int Count
	{
		[DispId(2)]
		get;
	}

	[DispId(0)]
	Column this[[In] int Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_1();

	void _VtblGap2_10();
}
