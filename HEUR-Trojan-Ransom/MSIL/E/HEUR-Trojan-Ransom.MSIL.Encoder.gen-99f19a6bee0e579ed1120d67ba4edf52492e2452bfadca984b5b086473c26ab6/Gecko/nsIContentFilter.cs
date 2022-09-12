using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c18c49a8-62f0-4045-9884-4aa91e388f14")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContentFilter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyOfInsertion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mimeType, [MarshalAs(UnmanagedType.Interface)] nsIURL contentSourceURL, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocument sourceDocument, [MarshalAs(UnmanagedType.U1)] bool willDeleteSelection, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMNode docFragment, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMNode contentStartNode, ref int contentStartOffset, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMNode contentEndNode, ref int contentEndOffset, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMNode insertionPointNode, ref int insertionPointOffset, [MarshalAs(UnmanagedType.U1)] ref bool continueWithInsertion);
}
