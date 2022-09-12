using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9fbac05a-fb27-470d-8e5f-028b2dc54ad0")]
public interface nsIDOMXULRelatedElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetRelatedElement([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aElement);
}
