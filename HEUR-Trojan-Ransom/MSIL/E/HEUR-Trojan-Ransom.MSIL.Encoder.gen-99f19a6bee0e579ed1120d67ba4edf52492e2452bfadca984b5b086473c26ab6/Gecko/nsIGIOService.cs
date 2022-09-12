using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("eda22a30-84e1-4e16-9ca0-cd1553c2b34a")]
public interface nsIGIOService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMimeTypeFromExtension([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase extension, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIGIOMimeApp GetAppForURIScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURIScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIGIOMimeApp GetAppForMimeType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase mimeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIGIOMimeApp CreateAppFromCommand([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase cmd, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase appName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDescriptionForMimeType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase mimeType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowURIForInput([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OrgFreedesktopFileManager1ShowItems([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase path);
}
