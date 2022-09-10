using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("0002094D-0000-0000-C000-000000000046")]
public interface Tables : IEnumerable
{
	[DispId(2)]
	int Count
	{
		[DispId(2)]
		get;
	}

	[DispId(0)]
	Table this[[In] int Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	new IEnumerator GetEnumerator();

	void _VtblGap1_3();

	void _VtblGap2_1();

	[DispId(200)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Table Add([In][MarshalAs(UnmanagedType.Interface)] Range Range, [In] int NumRows, [In] int NumColumns, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object DefaultTableBehavior, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object AutoFitBehavior);
}
