using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6f54214c-7175-498d-9d2d-0429e38c2869")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXMLHttpRequest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel GetChannelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetResponseXMLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetResponseTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aResponseText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetResponseTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aResponseType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResponseTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aResponseType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetResponseAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aStatusText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Abort();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAllResponseHeaders([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase header, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Open([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase method, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase url, [MarshalAs(UnmanagedType.U1)] bool async, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase user, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase password, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Send([MarshalAs(UnmanagedType.Interface)] nsIVariant body);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase header, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTimeoutAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTimeoutAttribute(uint aTimeout);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetReadyStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OverrideMimeType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mimetype);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozBackgroundRequestAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMozBackgroundRequestAttribute([MarshalAs(UnmanagedType.U1)] bool aMozBackgroundRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWithCredentialsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWithCredentialsAttribute([MarshalAs(UnmanagedType.U1)] bool aWithCredentials);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, IntPtr scriptContext, IntPtr globalObject, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI, [MarshalAs(UnmanagedType.Interface)] nsILoadGroup loadGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXMLHttpRequestUpload GetUploadAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnreadystatechangeAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnreadystatechangeAttribute(JsVal aOnreadystatechange, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozAnonAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozSystemAttribute();
}
