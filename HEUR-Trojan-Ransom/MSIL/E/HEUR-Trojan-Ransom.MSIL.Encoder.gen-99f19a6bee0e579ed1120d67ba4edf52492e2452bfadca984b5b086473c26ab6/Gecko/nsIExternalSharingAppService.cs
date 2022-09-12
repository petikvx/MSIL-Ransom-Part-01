using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("cf7d04e5-3892-482e-81bb-073dc1c83f76")]
public interface nsIExternalSharingAppService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShareWithDefault([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mime, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSharingApps([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMIMEType, ref uint aLen, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsISharingHandlerApp[] handlerApps);
}
