using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f607bd66-08e5-4d2e-ad83-9f9f3ca17658")]
public interface nsIWindowProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow ProvideWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, uint aChromeFlags, [MarshalAs(UnmanagedType.U1)] bool aCalledFromJS, [MarshalAs(UnmanagedType.U1)] bool aPositionSpecified, [MarshalAs(UnmanagedType.U1)] bool aSizeSpecified, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFeatures, [MarshalAs(UnmanagedType.U1)] ref bool aWindowIsNew);
}
