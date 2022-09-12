using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("70b9600e-8622-4c93-9ad8-22c28058dc44")]
public interface nsIDOMParser
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument ParseFromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string str, [MarshalAs(UnmanagedType.LPStr)] string contentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument ParseFromBuffer([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] buf, uint bufLen, [MarshalAs(UnmanagedType.LPStr)] string contentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, int contentLength, [MarshalAs(UnmanagedType.LPStr)] string contentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.Interface)] nsIURI documentURI, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI, IntPtr scriptObject);
}
