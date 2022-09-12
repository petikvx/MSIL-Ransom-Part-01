using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("40c78026-36dc-40ca-9221-de73267e9e99")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLAreaElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAltAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAltAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCoordsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCoords);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCoordsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCoords);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetShapeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aShape);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShapeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aShape);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHrefAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHref);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHrefAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHref);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPingAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPing);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPingAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPing);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDownloadAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDownload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDownloadAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDownload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProtocolAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProtocol);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProtocolAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProtocol);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHostAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHostnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPortAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPortAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPathnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPathname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPathnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPathname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSearchAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHashAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHashAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetNoHrefAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNoHrefAttribute([MarshalAs(UnmanagedType.U1)] bool aNoHref);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
