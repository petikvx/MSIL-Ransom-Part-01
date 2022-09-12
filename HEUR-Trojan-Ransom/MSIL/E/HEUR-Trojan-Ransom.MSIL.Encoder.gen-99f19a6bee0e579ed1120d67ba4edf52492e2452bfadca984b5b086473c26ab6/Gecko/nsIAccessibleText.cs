using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("93ad2ca1-f12b-4ab9-a793-95d9fa9d1774")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleText
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCaretOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCaretOffsetAttribute(int aCaretOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCharacterCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectionCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetText(int startOffset, int endOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTextAfterOffset(int offset, AccessibleTextBoundary boundaryType, ref int startOffset, ref int endOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTextAtOffset(int offset, AccessibleTextBoundary boundaryType, ref int startOffset, ref int endOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTextBeforeOffset(int offset, AccessibleTextBoundary boundaryType, ref int startOffset, ref int endOffset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	char GetCharacterAtOffset(int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPersistentProperties GetTextAttributes([MarshalAs(UnmanagedType.U1)] bool includeDefAttrs, int offset, ref int rangeStartOffset, ref int rangeEndOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPersistentProperties GetDefaultTextAttributesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCharacterExtents(int offset, ref int x, ref int y, ref int width, ref int height, uint coordType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRangeExtents(int startOffset, int endOffset, ref int x, ref int y, ref int width, ref int height, uint coordType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetOffsetAtPoint(int x, int y, uint coordType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSelectionBounds(int selectionNum, ref int startOffset, ref int endOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionBounds(int selectionNum, int startOffset, int endOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSelection(int startOffset, int endOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSelection(int selectionNum);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollSubstringTo(int startIndex, int endIndex, uint scrollType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollSubstringToPoint(int startIndex, int endIndex, uint coordinateType, int x, int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleTextRange GetEnclosingRangeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetSelectionRangesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetVisibleRangesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleTextRange GetRangeByChild([MarshalAs(UnmanagedType.Interface)] nsIAccessible child);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleTextRange GetRangeAtPoint(int x, int y);
}
