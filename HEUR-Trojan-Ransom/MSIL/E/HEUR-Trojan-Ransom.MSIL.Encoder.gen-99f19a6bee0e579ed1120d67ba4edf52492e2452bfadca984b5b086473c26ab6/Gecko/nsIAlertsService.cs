using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9d0284bf-db40-42da-8f0d-c2769dbde7aa")]
public interface nsIAlertsService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowAlertNotification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase imageUrl, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase text, [MarshalAs(UnmanagedType.U1)] bool textClickable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase cookie, [MarshalAs(UnmanagedType.Interface)] nsIObserver alertListener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase dir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase lang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.U1)] bool inPrivateBrowsing);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseAlert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal);
}
