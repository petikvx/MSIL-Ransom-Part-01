using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fdf23301-4a94-11d3-9ce4-9960496c41bc")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIEditorMailSupport
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void PasteAsQuotation(int aSelectionType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode InsertAsQuotation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aQuotedText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertTextWithQuotations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStringToInsert);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PasteAsCitedQuotation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCitation, int aSelectionType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode InsertAsCitedQuotation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aQuotedText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCitation, [MarshalAs(UnmanagedType.U1)] bool aInsertHTML);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Rewrap([MarshalAs(UnmanagedType.U1)] bool aRespectNewlines);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StripCites();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray GetEmbeddedObjects();
}
