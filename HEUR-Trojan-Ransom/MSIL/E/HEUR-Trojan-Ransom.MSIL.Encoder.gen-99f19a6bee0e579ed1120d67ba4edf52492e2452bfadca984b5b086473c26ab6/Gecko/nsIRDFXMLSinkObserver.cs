using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("EB1A5D30-AB33-11D2-8EC6-00805F29F370")]
public interface nsIRDFXMLSinkObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnBeginLoad([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnInterrupt([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnResume([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnEndLoad([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnError([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink, int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aErrorMsg);
}
