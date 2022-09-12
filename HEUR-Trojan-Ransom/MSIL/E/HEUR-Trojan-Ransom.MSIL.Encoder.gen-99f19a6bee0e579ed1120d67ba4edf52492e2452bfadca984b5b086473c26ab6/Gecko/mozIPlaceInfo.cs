using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ad83e137-c92a-4b7b-b67e-0a318811f91e")]
public interface mozIPlaceInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetPlaceIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetFrecencyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetVisitsAttribute(IntPtr jsContext);
}
