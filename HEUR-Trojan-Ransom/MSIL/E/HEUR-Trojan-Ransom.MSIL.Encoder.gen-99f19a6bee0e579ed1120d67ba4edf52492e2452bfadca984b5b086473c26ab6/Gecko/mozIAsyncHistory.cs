using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1643EFD2-A329-4733-A39D-17069C8D3B2D")]
public interface mozIAsyncHistory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlacesInfo(ref JsVal aPlaceIdentifiers, mozIVisitInfoCallback aCallback, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdatePlaces(ref JsVal aPlaceInfo, mozIVisitInfoCallback aCallback, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IsURIVisited([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, mozIVisitedStatusCallback aCallback);
}
