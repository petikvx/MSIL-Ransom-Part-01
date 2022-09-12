using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("cea8812e-faa6-4013-9396-f9936cbb74ec")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpServer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Start(int port);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Stop([MarshalAs(UnmanagedType.Interface)] nsIHttpServerStoppedCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterFile([MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.Interface)] nsIFile file);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterPathHandler([MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterPrefixHandler([MarshalAs(UnmanagedType.LPStr)] string prefix, [MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterErrorHandler(uint code, [MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterDirectory([MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.Interface)] nsIFile dir);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterContentType([MarshalAs(UnmanagedType.LPStr)] string extension, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIndexHandler([MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIHttpServerIdentity GetIdentityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSharedState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSharedState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetObjectState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetObjectState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase key, [MarshalAs(UnmanagedType.Interface)] nsISupports value);
}
