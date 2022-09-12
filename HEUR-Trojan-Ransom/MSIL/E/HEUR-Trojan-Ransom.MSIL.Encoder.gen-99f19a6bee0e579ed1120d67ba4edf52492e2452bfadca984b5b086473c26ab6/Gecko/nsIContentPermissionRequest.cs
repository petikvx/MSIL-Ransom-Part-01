using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("408c8fcd-1420-4aff-94d8-39bf74d79219")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContentPermissionRequest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetTypesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIContentPermissionRequester GetRequesterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Allow(ref JsVal choices);
}
