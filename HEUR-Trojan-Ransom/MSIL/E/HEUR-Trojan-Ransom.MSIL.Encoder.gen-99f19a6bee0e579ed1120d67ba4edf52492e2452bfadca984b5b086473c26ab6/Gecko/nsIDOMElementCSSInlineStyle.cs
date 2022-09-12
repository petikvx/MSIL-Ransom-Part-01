using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("99715845-95fc-4a56-aa53-214b65c26e22")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMElementCSSInlineStyle
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMCSSStyleDeclaration GetStyleAttribute();
}
