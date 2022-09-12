using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("81fe5144-059b-42db-bd3a-f6ce3158d5e9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessiblePivot
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetPositionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPositionAttribute([MarshalAs(UnmanagedType.Interface)] nsIAccessible aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetRootAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetModalRootAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetModalRootAttribute([MarshalAs(UnmanagedType.Interface)] nsIAccessible aModalRoot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStartOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEndOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextRange([MarshalAs(UnmanagedType.Interface)] nsIAccessibleText aTextAccessible, int aStartOffset, int aEndOffset, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MoveNext([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule, [MarshalAs(UnmanagedType.Interface)] nsIAccessible aAnchor, [MarshalAs(UnmanagedType.U1)] bool aIncludeStart, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MovePrevious([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule, [MarshalAs(UnmanagedType.Interface)] nsIAccessible aAnchor, [MarshalAs(UnmanagedType.U1)] bool aIncludeStart, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MoveFirst([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MoveLast([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MoveNextByText(TextBoundaryType aBoundary, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MovePreviousByText(TextBoundaryType aBoundary, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MoveToPoint([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTraversalRule aRule, int aX, int aY, [MarshalAs(UnmanagedType.U1)] bool aIgnoreNoMatch, [MarshalAs(UnmanagedType.U1)] bool aIsFromUserInput, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIAccessiblePivotObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIAccessiblePivotObserver aObserver);
}
