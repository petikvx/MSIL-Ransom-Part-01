using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("21f112df-d96f-47da-bfcb-5331273003d1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDocumentEncoder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMimeType, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NativeInit(IntPtr aDocument, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMimeType, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aRange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNativeNode(IntPtr aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContainerNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aContainer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNativeContainerNode(IntPtr aContainer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCharset([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWrapColumn(uint aWrapColumn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMimeTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMimeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EncodeToStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EncodeToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EncodeToStringWithContext([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContextString, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInfoString, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EncodeToStringWithMaxLength(uint aMaxLength, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNodeFixup([MarshalAs(UnmanagedType.Interface)] nsIDocumentEncoderNodeFixup aFixup);
}
