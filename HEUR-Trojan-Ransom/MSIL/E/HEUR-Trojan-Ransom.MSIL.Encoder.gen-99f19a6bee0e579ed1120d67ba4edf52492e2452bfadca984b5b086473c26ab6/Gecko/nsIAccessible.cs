using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("de2869d9-563c-4943-996b-31a4daa4d097")]
public interface nsIAccessible
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetNextSiblingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetPreviousSiblingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetFirstChildAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetLastChildAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetChildrenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetChildCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexInParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetDOMNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleDocument GetDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleDocument GetRootDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLanguageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLanguage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAccessKeyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAccessKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeyboardShortcutAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeyboardShortcut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRoleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetState(ref uint aState, ref uint aExtraState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHelpAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHelp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetFocusedChildAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPersistentProperties GetAttributesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GroupPosition(ref int aGroupLevel, ref int aSimilarItemsInGroup, ref int aPositionInGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetChildAtPoint(int x, int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetDeepestChildAtPoint(int x, int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetChildAt(int aChildIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleRelation GetRelationByType(uint aRelationType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetRelations();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBounds(ref int x, ref int y, ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelected([MarshalAs(UnmanagedType.U1)] bool isSelected);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TakeSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TakeFocus();

	[MethodImpl(MethodImplOptions.InternalCall)]
	byte GetActionCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetActionName(byte index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetActionDescription(byte aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoAction(byte index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollTo(uint aScrollType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollToPoint(uint coordinateType, int x, int y);
}
