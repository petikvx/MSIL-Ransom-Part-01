using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fe2625ec-b884-4df1-b39c-9e830e47aa94")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINetUtil
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseRequestContentType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTypeHeader, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aCharset, [MarshalAs(UnmanagedType.U1)] ref bool aHadCharset, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseResponseContentType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTypeHeader, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aCharset, [MarshalAs(UnmanagedType.U1)] ref bool aHadCharset, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ProtocolHasFlags([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, uint aFlag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool URIChainHasFlags([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI ToImmutableURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI NewSimpleNestedURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EscapeString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aString, uint aEscapeType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EscapeURL([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aStr, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnescapeString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aStr, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ExtractCharsetFromContentType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTypeHeader, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aCharset, ref int aCharsetStart, ref int aCharsetEnd);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint ParseAttributePolicyString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPolicyString);
}
