using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5e0adf7d-9785-45c3-a193-04f25a75da8f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStreamTransportService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransport CreateInputTransport([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, long aStartOffset, long aReadLimit, [MarshalAs(UnmanagedType.U1)] bool aCloseWhenDone);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransport CreateOutputTransport([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream, long aStartOffset, long aWriteLimit, [MarshalAs(UnmanagedType.U1)] bool aCloseWhenDone);
}
