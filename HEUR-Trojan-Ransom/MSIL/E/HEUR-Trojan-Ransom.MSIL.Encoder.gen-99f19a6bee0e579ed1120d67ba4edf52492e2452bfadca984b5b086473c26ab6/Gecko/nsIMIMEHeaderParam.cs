using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9c9252a1-fdaf-40a2-9c2b-a3dc45e28dde")]
public interface nsIMIMEHeaderParam
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetParameter([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeaderVal, [MarshalAs(UnmanagedType.LPStr)] string aParamName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFallbackCharset, [MarshalAs(UnmanagedType.U1)] bool aTryLocaleCharset, [MarshalAs(UnmanagedType.LPStr)] ref string aLang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetParameterHTTP([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeaderVal, [MarshalAs(UnmanagedType.LPStr)] string aParamName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFallbackCharset, [MarshalAs(UnmanagedType.U1)] bool aTryLocaleCharset, [MarshalAs(UnmanagedType.LPStr)] ref string aLang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DecodeRFC5987Param([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParamVal, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aLang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetParameterInternal([MarshalAs(UnmanagedType.LPStr)] string aHeaderVal, [MarshalAs(UnmanagedType.LPStr)] string aParamName, [MarshalAs(UnmanagedType.LPStr)] ref string aCharset, [MarshalAs(UnmanagedType.LPStr)] ref string aLang);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DecodeRFC2047Header([MarshalAs(UnmanagedType.LPStr)] string aHeaderVal, [MarshalAs(UnmanagedType.LPStr)] string aDefaultCharset, [MarshalAs(UnmanagedType.U1)] bool aOverrideCharset, [MarshalAs(UnmanagedType.U1)] bool aEatContinuation, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DecodeParameter([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParamValue, [MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.LPStr)] string aDefaultCharset, [MarshalAs(UnmanagedType.U1)] bool aOverrideCharset, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
