using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1E4F3AE1-B737-431F-A95D-31FA8DA70199")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIExternalHelperAppService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStreamListener DoContent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeContentType, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aContentContext, [MarshalAs(UnmanagedType.U1)] bool aForceSave, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ApplyDecodingForExtension([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aExtension, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aEncodingType);
}
