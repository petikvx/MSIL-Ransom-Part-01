using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e5ffe335-078e-4b25-87f1-02429bd2e458")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINetworkManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterNetworkInterface([MarshalAs(UnmanagedType.Interface)] nsINetworkInterface network);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateNetworkInterface([MarshalAs(UnmanagedType.Interface)] nsINetworkInterface network);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterNetworkInterface([MarshalAs(UnmanagedType.Interface)] nsINetworkInterface network);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetAllNetworkInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPreferredNetworkTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPreferredNetworkTypeAttribute(int aPreferredNetworkType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINetworkInfo GetActiveNetworkInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int OverrideActive([MarshalAs(UnmanagedType.Interface)] nsINetworkInterface network);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal AddHostRoute([MarshalAs(UnmanagedType.Interface)] nsINetworkInfo network, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase host);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal RemoveHostRoute([MarshalAs(UnmanagedType.Interface)] nsINetworkInfo network, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase host);
}
