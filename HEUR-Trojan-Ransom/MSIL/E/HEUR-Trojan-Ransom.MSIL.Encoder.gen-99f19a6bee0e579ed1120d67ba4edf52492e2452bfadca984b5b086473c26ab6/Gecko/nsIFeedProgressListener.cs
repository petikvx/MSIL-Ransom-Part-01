using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ebfd5de5-713c-40c0-ad7c-f095117fa580")]
public interface nsIFeedProgressListener : nsIFeedResultListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleResult([MarshalAs(UnmanagedType.Interface)] nsIFeedResult result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReportError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase errorText, int lineNumber, [MarshalAs(UnmanagedType.U1)] bool bozo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleStartFeed([MarshalAs(UnmanagedType.Interface)] nsIFeedResult result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleFeedAtFirstEntry([MarshalAs(UnmanagedType.Interface)] nsIFeedResult result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEntry([MarshalAs(UnmanagedType.Interface)] nsIFeedEntry entry, [MarshalAs(UnmanagedType.Interface)] nsIFeedResult result);
}
