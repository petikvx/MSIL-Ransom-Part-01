using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d6d7a014-e28d-4c9d-8727-1cf6d870619b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXULWindow
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShell GetDocShellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIntrinsicallySizedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIntrinsicallySizedAttribute([MarshalAs(UnmanagedType.U1)] bool aIntrinsicallySized);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem GetPrimaryContentShellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITabParent GetPrimaryTabParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TabParentAdded([MarshalAs(UnmanagedType.Interface)] nsITabParent aTab, [MarshalAs(UnmanagedType.U1)] bool aPrimary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TabParentRemoved([MarshalAs(UnmanagedType.Interface)] nsITabParent aTab);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem GetContentShellById([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string ID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddChildWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aChild);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveChildWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aChild);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Center([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aRelative, [MarshalAs(UnmanagedType.U1)] bool aScreen, [MarshalAs(UnmanagedType.U1)] bool aAlert);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowModal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetZLevelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetZLevelAttribute(uint aZLevel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetContextFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContextFlagsAttribute(uint aContextFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetChromeFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChromeFlagsAttribute(uint aChromeFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AssumeChromeFlagsAreFrozen();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULWindow CreateNewWindow(int aChromeFlags, [MarshalAs(UnmanagedType.Interface)] nsITabParent aOpeningTab);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULBrowserWindow GetXULBrowserWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetXULBrowserWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIXULBrowserWindow aXULBrowserWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ApplyChromeFlags();
}
