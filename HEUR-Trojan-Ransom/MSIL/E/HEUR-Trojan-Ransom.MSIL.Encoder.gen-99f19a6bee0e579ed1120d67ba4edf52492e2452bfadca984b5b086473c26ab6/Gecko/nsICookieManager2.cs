using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("daf0caa7-b431-4b4d-ba51-08c179bb9dfe")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICookieManager2 : nsICookieManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetEnumeratorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Remove([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath, [MarshalAs(UnmanagedType.U1)] bool aBlocked);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Add([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aValue, [MarshalAs(UnmanagedType.U1)] bool aIsSecure, [MarshalAs(UnmanagedType.U1)] bool aIsHttpOnly, [MarshalAs(UnmanagedType.U1)] bool aIsSession, long aExpiry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CookieExists([MarshalAs(UnmanagedType.Interface)] nsICookie2 aCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint CountCookiesFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetCookiesFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportCookies([MarshalAs(UnmanagedType.Interface)] nsIFile aCookieFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetCookiesForApp(uint appId, [MarshalAs(UnmanagedType.U1)] bool onlyBrowserElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveCookiesForApp(uint appId, [MarshalAs(UnmanagedType.U1)] bool onlyBrowserElement);
}
