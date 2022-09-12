using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("72f8bb14-2810-4f38-8d0d-290c5401f54e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICookiePromptService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int CookieDialog([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)] nsICookie cookie, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase hostname, int cookiesFromHost, [MarshalAs(UnmanagedType.U1)] bool changingCookie, [MarshalAs(UnmanagedType.U1)] ref bool rememberDecision);
}
