using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("770f7d84-c917-42d7-bf8d-d1b70649e733")]
public interface nsIImageLoadingContent : imgINotificationObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Notify(imgIRequest aProxy, int aType, [MarshalAs(UnmanagedType.Interface)] nsIntRect aRect);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLoadingEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aLoadingEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetImageBlockingStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver(imgINotificationObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver(imgINotificationObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIRequest GetRequest(int aRequestType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CurrentRequestHasSize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FrameCreated(IntPtr aFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FrameDestroyed(IntPtr aFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRequestType(imgIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetCurrentURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStreamListener LoadImageWithChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceReload([MarshalAs(UnmanagedType.U1)] bool aNotify, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceImageState([MarshalAs(UnmanagedType.U1)] bool aForce, ulong aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNaturalWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNaturalHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IncrementVisibleCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DecrementVisibleCount(uint aNonvisibleAction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetVisibleCount();
}
