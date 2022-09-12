using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1e94e283-2811-4f43-b947-d22b1549d824")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICookieService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetCookieString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetCookieStringFromHttp([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFirstURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCookieString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIPrompt aPrompt, [MarshalAs(UnmanagedType.LPStr)] string aCookie, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCookieStringFromHttp([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFirstURI, [MarshalAs(UnmanagedType.Interface)] nsIPrompt aPrompt, [MarshalAs(UnmanagedType.LPStr)] string aCookie, [MarshalAs(UnmanagedType.LPStr)] string aServerTime, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
}
