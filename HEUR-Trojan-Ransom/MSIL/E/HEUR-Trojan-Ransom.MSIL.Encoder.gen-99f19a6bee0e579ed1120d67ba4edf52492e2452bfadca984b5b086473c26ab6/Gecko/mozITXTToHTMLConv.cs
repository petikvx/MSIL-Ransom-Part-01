using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("77c0e42a-1dd2-11b2-8ebf-edc6606f2f4b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozITXTToHTMLConv : nsIStreamConverter, nsIStreamListener, nsIRequestObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIInputStream Convert([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, [MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AsyncConvertData([MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string ScanTXT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, uint whattodo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string ScanHTML([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, uint whattodo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint CiteLevelTXT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string line, ref uint logLineStart);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FindURLInPlaintext([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, int aLength, int aPos, ref int aStartPos, ref int aEndPos);
}
