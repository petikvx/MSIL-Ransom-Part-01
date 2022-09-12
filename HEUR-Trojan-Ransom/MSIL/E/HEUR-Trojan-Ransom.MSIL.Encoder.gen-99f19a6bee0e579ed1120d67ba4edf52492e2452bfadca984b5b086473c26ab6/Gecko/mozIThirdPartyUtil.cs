using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b711bd7f-0674-49be-ae77-f221db5f7b6c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIThirdPartyUtil
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsThirdPartyURI([MarshalAs(UnmanagedType.Interface)] nsIURI aFirstURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aSecondURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsThirdPartyWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsThirdPartyChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBaseDomain([MarshalAs(UnmanagedType.Interface)] nsIURI aHostURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURIFromWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetTopWindowForChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
}
