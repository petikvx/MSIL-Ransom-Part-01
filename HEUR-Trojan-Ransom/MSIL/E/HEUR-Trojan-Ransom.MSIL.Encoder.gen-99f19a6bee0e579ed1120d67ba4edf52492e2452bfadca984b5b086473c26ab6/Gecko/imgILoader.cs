using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e61377d2-910e-4c65-a64b-428d150e1fd1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface imgILoader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIRequest LoadImageXPCOM([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aInitialDocumentURL, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrerURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReferrerPolicy, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup, imgINotificationObserver aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports aCX, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsISupports cacheKey, IntPtr aContentPolicyType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIRequest LoadImageWithChannelXPCOM([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, imgINotificationObserver aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports cx, [MarshalAs(UnmanagedType.Interface)] ref nsIStreamListener aListener);
}
