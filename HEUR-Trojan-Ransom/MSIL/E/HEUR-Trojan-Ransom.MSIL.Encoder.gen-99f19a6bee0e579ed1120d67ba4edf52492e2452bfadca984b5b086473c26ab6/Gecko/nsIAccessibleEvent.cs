using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("20c69a40-6c2c-42a3-a578-6f4473aab9dd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleEvent
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEventTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetAccessibleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleDocument GetAccessibleDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetDOMNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsFromUserInputAttribute();
}
