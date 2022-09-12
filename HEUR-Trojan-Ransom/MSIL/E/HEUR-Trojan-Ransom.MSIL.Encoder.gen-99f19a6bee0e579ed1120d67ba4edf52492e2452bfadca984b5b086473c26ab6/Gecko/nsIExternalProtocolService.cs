using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("70f93b7a-3ec6-4bcb-b093-92d9984c9f83")]
public interface nsIExternalProtocolService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ExternalProtocolHandlerExists([MarshalAs(UnmanagedType.LPStr)] string aProtocolScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsExposedProtocol([MarshalAs(UnmanagedType.LPStr)] string aProtocolScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIHandlerInfo GetProtocolHandlerInfo([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocolScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIHandlerInfo GetProtocolHandlerInfoFromOS([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocolScheme, [MarshalAs(UnmanagedType.U1)] ref bool aFound);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProtocolHandlerDefaults([MarshalAs(UnmanagedType.Interface)] nsIHandlerInfo aHandlerInfo, [MarshalAs(UnmanagedType.U1)] bool aOSHandlerExists);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadUrl([MarshalAs(UnmanagedType.Interface)] nsIURI aURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetApplicationDescription([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aScheme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
