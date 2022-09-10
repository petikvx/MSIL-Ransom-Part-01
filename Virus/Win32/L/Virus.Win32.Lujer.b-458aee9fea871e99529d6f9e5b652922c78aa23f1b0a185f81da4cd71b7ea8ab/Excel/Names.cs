using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[DefaultMember("_Default")]
[Guid("000208B8-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface Names : IEnumerable
{
	[DispId(118)]
	int Count
	{
		[PreserveSig]
		[DispId(118)]
		get;
	}

	void _VtblGap1_3();

	[PreserveSig]
	[DispId(181)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Name Add([Optional][In][MarshalAs(UnmanagedType.Struct)] object Name, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RefersTo, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Visible, [Optional][In][MarshalAs(UnmanagedType.Struct)] object MacroType, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ShortcutKey, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Category, [Optional][In][MarshalAs(UnmanagedType.Struct)] object NameLocal, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RefersToLocal, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CategoryLocal, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RefersToR1C1, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RefersToR1C1Local);

	void _VtblGap2_1();

	[PreserveSig]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Name _Default([Optional][In][MarshalAs(UnmanagedType.Struct)] object Index, [Optional][In][MarshalAs(UnmanagedType.Struct)] object IndexLocal, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RefersTo);

	[PreserveSig]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	new IEnumerator GetEnumerator();
}
