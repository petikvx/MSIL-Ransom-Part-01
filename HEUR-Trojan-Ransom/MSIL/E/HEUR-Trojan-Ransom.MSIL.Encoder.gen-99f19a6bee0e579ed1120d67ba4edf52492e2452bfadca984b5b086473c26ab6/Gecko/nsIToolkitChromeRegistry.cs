using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8727651c-9530-45a0-b81e-0e0690c30c50")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIToolkitChromeRegistry : nsIChromeRegistry, nsIXULChromeRegistry
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
	new void ReloadChrome();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetSelectedLocale([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase packageName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsLocaleRTL([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase package);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RefreshSkins();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool AllowScriptsForPackage([MarshalAs(UnmanagedType.Interface)] nsIURI url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool AllowContentToAccess([MarshalAs(UnmanagedType.Interface)] nsIURI url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool CanLoadURLRemotely([MarshalAs(UnmanagedType.Interface)] nsIURI url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool MustLoadURLRemotely([MarshalAs(UnmanagedType.Interface)] nsIURI url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckForOSAccessibility();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUTF8StringEnumerator GetLocalesForPackage([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPackage);
}
