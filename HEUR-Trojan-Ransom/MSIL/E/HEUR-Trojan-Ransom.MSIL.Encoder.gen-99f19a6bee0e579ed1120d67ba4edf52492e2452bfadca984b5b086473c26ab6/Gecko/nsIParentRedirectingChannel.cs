using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3ed1d288-5324-46ee-8a98-33ac37d1080b")]
public interface nsIParentRedirectingChannel : nsIStreamListener, nsIRequestObserver, nsIParentChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetParentListener(IntPtr listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NotifyTrackingProtectionDisabled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Delete();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartRedirect(uint newChannelId, [MarshalAs(UnmanagedType.Interface)] nsIChannel newChannel, uint redirectFlags, [MarshalAs(UnmanagedType.Interface)] nsIAsyncVerifyRedirectCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CompleteRedirect([MarshalAs(UnmanagedType.U1)] bool succeeded);
}
