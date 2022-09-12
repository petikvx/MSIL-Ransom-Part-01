using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1a3ef88a-e4d1-11e4-8512-176220f2b32b")]
public interface nsIRadioInterface
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetupDataCallByType(int networkType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeactivateDataCallByType(int networkType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetDataCallStateByType(int networkType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateRILNetworkInterface();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendWorkerMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, ref JsVal message, [MarshalAs(UnmanagedType.Interface)] nsIRilSendWorkerMessageCallback callback);
}
