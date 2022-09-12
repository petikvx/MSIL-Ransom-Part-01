using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a9c81797-9133-4823-b55f-3646e67cfd41")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIAsyncFavicons
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAndFetchFaviconForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.U1)] bool aForceReload, uint aFaviconLoadType, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceFaviconData([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aData, uint aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMimeType, long aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceFaviconDataFromDataURL([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDataURL, long aExpiration, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFaviconURLForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFaviconDataForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);
}
