using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5cfe15bd-5adb-4a7f-9e55-4f5a67d15794")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUploadChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUploadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType, long aContentLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetUploadStreamAttribute();
}
