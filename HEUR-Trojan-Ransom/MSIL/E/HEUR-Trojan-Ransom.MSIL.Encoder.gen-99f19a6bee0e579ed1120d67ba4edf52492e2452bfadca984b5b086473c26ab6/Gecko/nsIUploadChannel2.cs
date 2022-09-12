using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2f712b52-19c5-4e0c-9e8f-b5c7c3b67049")]
public interface nsIUploadChannel2
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExplicitSetUploadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType, long aContentLength, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMethod, [MarshalAs(UnmanagedType.U1)] bool aStreamHasHeaders);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUploadStreamHasHeadersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnsureUploadStreamIsCloneable([MarshalAs(UnmanagedType.Interface)] nsIRunnable aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream CloneUploadStream();
}
