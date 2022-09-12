using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c85e5c82-b70f-4621-9528-beb2aa47fb44")]
public interface nsIFaviconDataCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnComplete([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, uint aDataLen, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] aData, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMimeType);
}
