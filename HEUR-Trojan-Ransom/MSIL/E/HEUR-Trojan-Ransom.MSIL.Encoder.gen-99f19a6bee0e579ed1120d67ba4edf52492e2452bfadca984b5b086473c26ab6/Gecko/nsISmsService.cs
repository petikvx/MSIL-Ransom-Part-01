using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c8ca5f06-ad76-44b0-a324-9e2910fd37da")]
public interface nsISmsService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSmsDefaultServiceIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSegmentInfoForText([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase text, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Send(uint serviceId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase message, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSilentNumber([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSilentNumber([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSmscAddress(uint serviceId, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSmscAddress(uint serviceId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, uint typeOfNumber, uint numberPlanIdentification, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);
}
