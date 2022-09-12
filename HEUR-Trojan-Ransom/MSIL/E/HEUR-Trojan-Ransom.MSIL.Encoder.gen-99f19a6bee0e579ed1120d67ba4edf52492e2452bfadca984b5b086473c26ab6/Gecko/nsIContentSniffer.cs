using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a5772d1b-fc63-495e-a169-96e8d3311af0")]
public interface nsIContentSniffer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMIMETypeFromContent([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aData, uint aLength, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
