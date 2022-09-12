using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("93251ddf-5e85-4172-ac2a-31780562974f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXULChromeRegistry : nsIChromeRegistry
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI ConvertChromeURL([MarshalAs(UnmanagedType.Interface)] nsIURI aChromeURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CheckForNewChrome();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool WrappersEnabled([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReloadChrome();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSelectedLocale([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase packageName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsLocaleRTL([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase package);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RefreshSkins();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AllowScriptsForPackage([MarshalAs(UnmanagedType.Interface)] nsIURI url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AllowContentToAccess([MarshalAs(UnmanagedType.Interface)] nsIURI url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanLoadURLRemotely([MarshalAs(UnmanagedType.Interface)] nsIURI url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MustLoadURLRemotely([MarshalAs(UnmanagedType.Interface)] nsIURI url);
}
