using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("fae4e9a8-1dd1-11b2-b53c-8f3aa1bbf8f5")]
public interface nsIDirIndexListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnIndexAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt, [MarshalAs(UnmanagedType.Interface)] nsIDirIndex aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnInformationAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInfo);
}
