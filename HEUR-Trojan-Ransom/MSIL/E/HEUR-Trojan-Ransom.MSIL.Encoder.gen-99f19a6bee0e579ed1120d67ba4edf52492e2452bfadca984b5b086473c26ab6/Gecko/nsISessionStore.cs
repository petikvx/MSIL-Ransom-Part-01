using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4580f5eb-693d-423d-b0ce-2cb20a962e4d")]
public interface nsISessionStore
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanRestoreLastSessionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCanRestoreLastSessionAttribute([MarshalAs(UnmanagedType.U1)] bool aCanRestoreLastSession);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RestoreLastSession();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBrowserState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBrowserState([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWindowState([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWindowState([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState, [MarshalAs(UnmanagedType.U1)] bool aOverwrite);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTabState([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTabState([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode DuplicateTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, int aDelta);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetClosedTabCount([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetClosedTabData([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode UndoCloseTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode ForgetClosedTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetClosedWindowCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetClosedWindowData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow UndoCloseWindow(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode ForgetClosedWindow(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWindowValue([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWindowValue([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey, ref JsVal aStringValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteWindowValue([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey, ref JsVal aStringValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGlobalValue([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetGlobalValue([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey, ref JsVal aStringValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteGlobalValue([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PersistTabAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
}
