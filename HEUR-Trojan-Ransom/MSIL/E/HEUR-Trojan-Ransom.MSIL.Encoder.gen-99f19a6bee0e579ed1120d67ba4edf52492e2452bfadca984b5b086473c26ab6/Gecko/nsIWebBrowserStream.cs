using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("86d02f0e-219b-4cfc-9c88-bd98d2cce0b8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebBrowserStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenStream([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendToStream([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] aData, uint aLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseStream();
}
