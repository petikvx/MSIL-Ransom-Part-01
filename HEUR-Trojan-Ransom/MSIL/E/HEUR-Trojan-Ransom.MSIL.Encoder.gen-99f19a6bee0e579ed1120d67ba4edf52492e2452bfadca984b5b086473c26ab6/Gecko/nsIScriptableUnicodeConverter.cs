using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f36ee324-5c1c-437f-ba10-2b4db7a18031")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIScriptableUnicodeConverter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertFromUnicode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Finish([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertToUnicode([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSrc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertFromByteArray([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] aData, uint aCount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertToByteArray([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString, ref uint aLen, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref byte[] aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream ConvertToInputStream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetCharsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCharsetAttribute([MarshalAs(UnmanagedType.LPStr)] string aCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInternalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsInternalAttribute([MarshalAs(UnmanagedType.U1)] bool aIsInternal);
}
