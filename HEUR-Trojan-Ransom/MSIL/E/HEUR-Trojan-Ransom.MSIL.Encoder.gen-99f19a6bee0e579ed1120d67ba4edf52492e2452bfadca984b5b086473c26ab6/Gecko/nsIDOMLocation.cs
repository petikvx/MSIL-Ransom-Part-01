using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("79de76e5-994e-4f6b-81aa-42d9adb6e67e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMLocation
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHashAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHashAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHostAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHostnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHrefAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHref);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHrefAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHref);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPathnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPathname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPathnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPathname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPortAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPortAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProtocolAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProtocol);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProtocolAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProtocol);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSearchAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOriginAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOrigin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reload([MarshalAs(UnmanagedType.U1)] bool forceget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Assign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase url);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMLocation ValueOf();
}
