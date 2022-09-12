using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("95309fd2-7b3a-47fb-97f3-5c460d9473cd")]
public interface nsIFeedResultService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetForcePreviewPageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetForcePreviewPageAttribute([MarshalAs(UnmanagedType.U1)] bool aForcePreviewPage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddToClientReader([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase subtitle, uint feedType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase feedReader);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddFeedResult([MarshalAs(UnmanagedType.Interface)] nsIFeedResult feedResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFeedResult GetFeedResult([MarshalAs(UnmanagedType.Interface)] nsIURI uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFeedResult([MarshalAs(UnmanagedType.Interface)] nsIURI uri);
}
