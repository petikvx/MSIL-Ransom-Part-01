using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("87d55fba-cb7e-4f38-84c1-5c6c2b2a55e9")]
public interface nsIProgressEventSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnProgress([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, long aProgress, long aProgressMax);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStatus([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aStatusArg);
}
