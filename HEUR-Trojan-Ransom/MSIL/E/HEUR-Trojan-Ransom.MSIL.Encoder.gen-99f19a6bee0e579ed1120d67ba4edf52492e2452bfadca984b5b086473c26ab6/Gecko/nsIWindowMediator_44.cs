using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("88b54988-7f3c-40d2-a625-7e42a9c196c2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWindowMediator_44 : nsIWindowMediator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetEnumerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetXULWindowEnumerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetZOrderDOMWindowEnumerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType, [MarshalAs(UnmanagedType.U1)] bool aFrontToBack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetZOrderXULWindowEnumerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType, [MarshalAs(UnmanagedType.U1)] bool aFrontToBack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMWindow GetMostRecentWindow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMWindow GetOuterWindowWithId(ulong aOuterWindowID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMWindow GetCurrentInnerWindowWithId(ulong aInnerWindowID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RegisterWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void UnregisterWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void UpdateWindowTimeStamp([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void UpdateWindowTitle([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string inTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool CalculateZPosition([MarshalAs(UnmanagedType.Interface)] nsIXULWindow inWindow, uint inPosition, IntPtr inBelow, ref uint outPosition, ref IntPtr outBelow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetZPosition([MarshalAs(UnmanagedType.Interface)] nsIXULWindow inWindow, uint inPosition, [MarshalAs(UnmanagedType.Interface)] nsIXULWindow inBelow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetZLevel([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetZLevel([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow, uint aZLevel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddListener([MarshalAs(UnmanagedType.Interface)] nsIWindowMediatorListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIWindowMediatorListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetMostRecentNonPBWindow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowType);
}
