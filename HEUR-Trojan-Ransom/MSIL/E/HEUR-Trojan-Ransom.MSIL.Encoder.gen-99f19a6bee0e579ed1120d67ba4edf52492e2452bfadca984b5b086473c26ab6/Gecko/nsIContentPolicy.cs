using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("caad4f1f-d047-46ac-ae9d-dc598e4fb91b")]
public interface nsIContentPolicy : nsIContentPolicyBase
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	short ShouldLoad(IntPtr aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeTypeGuess, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aRequestPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short ShouldProcess(IntPtr aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aRequestPrincipal);
}
