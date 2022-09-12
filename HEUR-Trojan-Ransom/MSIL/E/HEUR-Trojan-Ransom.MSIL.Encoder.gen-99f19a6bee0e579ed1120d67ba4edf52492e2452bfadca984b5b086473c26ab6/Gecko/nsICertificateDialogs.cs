using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("da871dab-f69e-4173-ab26-99fcd47b0e85")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICertificateDialogs
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ConfirmDownloadCACert([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert, ref uint trust);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyCACertExists([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SetPKCS12FilePassword([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPKCS12FilePassword([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ViewCert([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert);
}
