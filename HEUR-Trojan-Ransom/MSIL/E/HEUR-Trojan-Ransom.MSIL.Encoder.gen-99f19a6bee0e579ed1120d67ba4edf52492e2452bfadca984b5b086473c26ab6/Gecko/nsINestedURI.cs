using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6de2c874-796c-46bf-b57f-0d7bd7d6cab0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINestedURI
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetInnerURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetInnermostURIAttribute();
}
