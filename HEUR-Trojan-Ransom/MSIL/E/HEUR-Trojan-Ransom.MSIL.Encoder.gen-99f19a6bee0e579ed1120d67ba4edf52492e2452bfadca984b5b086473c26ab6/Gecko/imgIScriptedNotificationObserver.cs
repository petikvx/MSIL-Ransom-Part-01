using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("10be55b3-2029-41a7-a975-538efed250ed")]
public interface imgIScriptedNotificationObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SizeAvailable(imgIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FrameUpdate(imgIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FrameComplete(imgIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadComplete(imgIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DecodeComplete(imgIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Discard(imgIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IsAnimated(imgIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HasTransparency(imgIRequest aRequest);
}
