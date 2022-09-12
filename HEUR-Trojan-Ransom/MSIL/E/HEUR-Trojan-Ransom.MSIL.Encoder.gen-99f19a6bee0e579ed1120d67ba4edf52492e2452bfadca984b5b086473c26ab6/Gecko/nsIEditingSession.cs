using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("24f3f4da-18a4-448d-876d-7360fefac029")]
public interface nsIEditingSession
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEditorStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MakeWindowEditable([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.LPStr)] string aEditorType, [MarshalAs(UnmanagedType.U1)] bool doAfterUriLoad, [MarshalAs(UnmanagedType.U1)] bool aMakeWholeDocumentEditable, [MarshalAs(UnmanagedType.U1)] bool aInteractive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WindowIsEditable([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEditor GetEditorForWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetupEditorOnWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TearDownEditorOnWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEditorOnControllers([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIEditor aEditor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisableJSAndPlugins([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RestoreJSAndPlugins([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DetachFromWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReattachToWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetJsAndPluginsDisabledAttribute();
}
