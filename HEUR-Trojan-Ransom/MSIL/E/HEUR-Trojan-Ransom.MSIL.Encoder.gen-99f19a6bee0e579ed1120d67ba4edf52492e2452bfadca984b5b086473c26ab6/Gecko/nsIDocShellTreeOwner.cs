using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0e3dc4b1-4cea-4a37-af71-79f0afd07574")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDocShellTreeOwner
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string name, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ContentShellAdded([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aContentShell, [MarshalAs(UnmanagedType.U1)] bool aPrimary, [MarshalAs(UnmanagedType.U1)] bool aTargetable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ContentShellRemoved([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aContentShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem GetPrimaryContentShellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TabParentAdded([MarshalAs(UnmanagedType.Interface)] nsITabParent aTab, [MarshalAs(UnmanagedType.U1)] bool aPrimary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TabParentRemoved([MarshalAs(UnmanagedType.Interface)] nsITabParent aTab);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITabParent GetPrimaryTabParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SizeShellTo([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem shell, int cx, int cy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPersistence([MarshalAs(UnmanagedType.U1)] bool aPersistPosition, [MarshalAs(UnmanagedType.U1)] bool aPersistSize, [MarshalAs(UnmanagedType.U1)] bool aPersistSizeMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPersistence([MarshalAs(UnmanagedType.U1)] ref bool aPersistPosition, [MarshalAs(UnmanagedType.U1)] ref bool aPersistSize, [MarshalAs(UnmanagedType.U1)] ref bool aPersistSizeMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTargetableShellCountAttribute();
}
