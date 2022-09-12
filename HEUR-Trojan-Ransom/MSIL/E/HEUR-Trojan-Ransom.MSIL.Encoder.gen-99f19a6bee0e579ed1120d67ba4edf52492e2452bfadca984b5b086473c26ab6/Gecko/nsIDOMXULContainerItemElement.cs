using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("800a68c7-b854-4597-a436-3055ce5c5c96")]
public interface nsIDOMXULContainerItemElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMXULContainerElement GetParentContainerAttribute();
}
