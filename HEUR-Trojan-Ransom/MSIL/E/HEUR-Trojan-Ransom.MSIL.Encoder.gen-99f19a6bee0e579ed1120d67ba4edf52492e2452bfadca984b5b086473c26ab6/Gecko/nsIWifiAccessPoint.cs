using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E28E614F-8F86-44FF-BCF5-5F18225834A0")]
public interface nsIWifiAccessPoint
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMacAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMac);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSsidAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSsid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRawSSIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRawSSID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSignalAttribute();
}
