using System.Runtime.InteropServices;

[ComImport]
[Guid("B196B28B-BAB4-101A-B69C-00AA00341D07")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface Interface19
{
	[PreserveSig]
	int GetPages(out Struct19 pPages);
}
