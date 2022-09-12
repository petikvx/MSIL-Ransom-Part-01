using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c2982b39-2e48-429e-92b7-99348a1633c5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUnicharStreamLoaderObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnDetermineCharset([MarshalAs(UnmanagedType.Interface)] nsIUnicharStreamLoader aLoader, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSegment, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStreamComplete([MarshalAs(UnmanagedType.Interface)] nsIUnicharStreamLoader aLoader, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBuffer);
}
