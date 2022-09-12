using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("edb99640-8378-4106-8673-e701a086eb1c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDocShellTreeItem
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool NameEquals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetItemTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemTypeAttribute(int aItemType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int ItemType();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem GetSameTypeParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem GetRootTreeItemAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem GetSameTypeRootTreeItemAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string name, [MarshalAs(UnmanagedType.Interface)] nsISupports aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeOwner GetTreeOwnerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTreeOwner([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeOwner treeOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetChildCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddChild([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem child);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem child);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem GetChildAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem FindChildWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.U1)] bool aRecurse, [MarshalAs(UnmanagedType.U1)] bool aSameType, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetWindow();
}
