using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("78bdcb41-1efa-409f-aaba-70842213f80f")]
public interface nsIDOMChromeWindow
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetWindowStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIBrowserDOMWindow GetBrowserDOMWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBrowserDOMWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIBrowserDOMWindow aBrowserDOMWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAttention();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAttentionWithCycleCount(int aCycleCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase cursor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Maximize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Minimize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Restore();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyDefaultButtonLoaded([MarshalAs(UnmanagedType.Interface)] nsIDOMElement defaultButton);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMessageBroadcaster GetMessageManagerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMessageBroadcaster GetGroupMessageManager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase group);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginWindowMove([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent mouseDownEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement panel);
}
