using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e795239e-9d3c-47c4-b063-9e600fb3b287")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDocumentLoaderFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIContentViewer CreateInstance([MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType, [MarshalAs(UnmanagedType.Interface)] nsIDocShell aContainer, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtraInfo, [MarshalAs(UnmanagedType.Interface)] ref nsIStreamListener aDocListenerResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIContentViewer CreateInstanceForDocument([MarshalAs(UnmanagedType.Interface)] nsISupports aContainer, IntPtr aDocument, [MarshalAs(UnmanagedType.LPStr)] string aCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr CreateBlankDocument([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
}
