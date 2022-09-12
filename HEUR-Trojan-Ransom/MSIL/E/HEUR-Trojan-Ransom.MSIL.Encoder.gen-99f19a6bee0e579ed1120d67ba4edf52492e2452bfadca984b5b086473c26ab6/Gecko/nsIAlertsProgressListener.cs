using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("df1bd4b0-3a8c-40e6-806a-203f38b0bd9f")]
public interface nsIAlertsProgressListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnProgress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, long progress, long progressMax, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase text);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);
}
