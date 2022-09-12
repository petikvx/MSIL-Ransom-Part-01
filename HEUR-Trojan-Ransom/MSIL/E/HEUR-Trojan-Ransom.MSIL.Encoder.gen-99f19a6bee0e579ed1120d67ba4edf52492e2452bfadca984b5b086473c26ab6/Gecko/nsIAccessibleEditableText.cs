using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("28915cca-3366-4034-ba1d-b7afb9b37639")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleEditableText
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextContents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase text);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertText([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase text, int position);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyText(int startPos, int endPos);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CutText(int startPos, int endPos);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteText(int startPos, int endPos);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PasteText(int position);
}
