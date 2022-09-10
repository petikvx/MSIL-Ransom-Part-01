using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[Guid("0002096C-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface Documents : IEnumerable
{
	[DispId(0)]
	Document this[[In][MarshalAs(UnmanagedType.Struct)] ref object Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_5();

	[DispId(1105)]
	void Close([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object SaveChanges, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object OriginalFormat, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object RouteDocument);

	void _VtblGap2_3();

	[DispId(14)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Document Add([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Template, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object NewTemplate, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object DocumentType, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Visible);

	void _VtblGap3_4();

	[DispId(19)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Document Open([In][MarshalAs(UnmanagedType.Struct)] ref object FileName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object ConfirmConversions, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object ReadOnly, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object AddToRecentFiles, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PasswordDocument, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PasswordTemplate, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Revert, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object WritePasswordDocument, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object WritePasswordTemplate, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Format, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Encoding, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Visible, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object OpenAndRepair, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object DocumentDirection, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object NoEncodingDialog, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object XMLTransform);
}
