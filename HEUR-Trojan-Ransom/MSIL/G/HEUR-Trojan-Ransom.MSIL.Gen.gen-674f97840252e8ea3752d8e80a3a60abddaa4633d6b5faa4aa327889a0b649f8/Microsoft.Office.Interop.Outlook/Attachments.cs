using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook;

[ComImport]
[DefaultMember("Item")]
[Guid("0006303C-0000-0000-C000-000000000046")]
[CompilerGenerated]
[TypeIdentifier]
public interface Attachments : IEnumerable
{
	void _VtblGap1_6();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(101)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Attachment Add([In][MarshalAs(UnmanagedType.Struct)] object Source, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Type, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Position, [Optional][In][MarshalAs(UnmanagedType.Struct)] object DisplayName);
}
