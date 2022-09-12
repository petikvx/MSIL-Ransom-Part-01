using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7F7201EB-510C-4CEF-BDF0-04A15A7A4A8C")]
public interface nsIStandaloneNativeMenu
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aDOMElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MenuWillOpen();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetNativeMenuAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ActivateNativeMenuItemAt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase anIndexString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceUpdateNativeMenuAt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase anIndexString);
}
