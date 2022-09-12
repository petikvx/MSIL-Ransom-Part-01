using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3801c9d4-8e69-4bfc-9edb-b58278621f8f")]
public interface nsISelectionController : nsISelectionDisplay
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisplaySelection(short toggle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetDisplaySelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISelection GetSelection(short type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollSelectionIntoView(short type, short region, short flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RepaintSelection(short type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCaretEnabled([MarshalAs(UnmanagedType.U1)] bool enabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCaretReadOnly([MarshalAs(UnmanagedType.U1)] bool readOnly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCaretEnabled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCaretVisibleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCaretVisibilityDuringSelection([MarshalAs(UnmanagedType.U1)] bool visibility);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CharacterMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PhysicalMove(short direction, short amount, [MarshalAs(UnmanagedType.U1)] bool extend);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CharacterExtendForDelete();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CharacterExtendForBackspace();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WordMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WordExtendForDelete([MarshalAs(UnmanagedType.U1)] bool forward);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LineMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IntraLineMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PageMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CompleteScroll([MarshalAs(UnmanagedType.U1)] bool forward);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CompleteMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollPage([MarshalAs(UnmanagedType.U1)] bool forward);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollLine([MarshalAs(UnmanagedType.U1)] bool forward);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollCharacter([MarshalAs(UnmanagedType.U1)] bool right);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckVisibility([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node, short startOffset, short endOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckVisibilityContent(IntPtr node, short startOffset, short endOffset);
}
