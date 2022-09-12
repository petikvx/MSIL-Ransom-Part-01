using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("00063001-0000-0000-C000-000000000046")]
public interface _Application
{
	[DispId(61451)]
	NameSpace Session
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(61451)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_2();

	void _VtblGap2_7();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(267)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object CreateItemFromTemplate([In][MarshalAs(UnmanagedType.BStr)] string TemplatePath, [Optional][In][MarshalAs(UnmanagedType.Struct)] object InFolder);

	void _VtblGap3_2();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(275)]
	void Quit();
}
