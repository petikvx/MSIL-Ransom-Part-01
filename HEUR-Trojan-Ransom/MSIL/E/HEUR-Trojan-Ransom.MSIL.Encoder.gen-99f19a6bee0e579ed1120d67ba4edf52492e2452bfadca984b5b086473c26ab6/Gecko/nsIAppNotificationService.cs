using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("50cb17d2-dc8a-4aa6-bcd3-94d76af14e20")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAppNotificationService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowAppNotification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase imageUrl, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase text, [MarshalAs(UnmanagedType.Interface)] nsIObserver alertListener, ref JsVal details);
}
