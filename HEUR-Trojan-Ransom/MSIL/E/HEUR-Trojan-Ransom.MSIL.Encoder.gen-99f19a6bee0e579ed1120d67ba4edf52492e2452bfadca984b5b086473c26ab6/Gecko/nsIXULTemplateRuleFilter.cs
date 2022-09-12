using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("819cd1ed-8010-42e1-a8b9-778b726a1ff3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXULTemplateRuleFilter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Match([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aRef, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRule);
}
