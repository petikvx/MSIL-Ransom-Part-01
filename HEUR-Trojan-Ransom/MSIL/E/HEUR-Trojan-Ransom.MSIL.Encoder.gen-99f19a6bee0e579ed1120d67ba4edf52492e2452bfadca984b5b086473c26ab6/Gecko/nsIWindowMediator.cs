using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("30cda5a1-a6df-4f32-9a73-0e59a32928c5")]
public interface nsIWindowMediator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetEnumerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetXULWindowEnumerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetZOrderDOMWindowEnumerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType, [MarshalAs(UnmanagedType.U1)] bool aFrontToBack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetZOrderXULWindowEnumerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType, [MarshalAs(UnmanagedType.U1)] bool aFrontToBack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetMostRecentWindow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetOuterWindowWithId(ulong aOuterWindowID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetCurrentInnerWindowWithId(ulong aInnerWindowID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateWindowTimeStamp([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateWindowTitle([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string inTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CalculateZPosition([MarshalAs(UnmanagedType.Interface)] nsIXULWindow inWindow, uint inPosition, IntPtr inBelow, ref uint outPosition, ref IntPtr outBelow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetZPosition([MarshalAs(UnmanagedType.Interface)] nsIXULWindow inWindow, uint inPosition, [MarshalAs(UnmanagedType.Interface)] nsIXULWindow inBelow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetZLevel([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetZLevel([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow, uint aZLevel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddListener([MarshalAs(UnmanagedType.Interface)] nsIWindowMediatorListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIWindowMediatorListener aListener);
}
