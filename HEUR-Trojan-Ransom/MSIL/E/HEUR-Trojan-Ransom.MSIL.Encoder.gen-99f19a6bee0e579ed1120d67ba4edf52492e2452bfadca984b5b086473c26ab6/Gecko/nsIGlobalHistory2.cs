using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("cf777d42-1270-4b34-be7b-2931c93feda5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGlobalHistory2
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.U1)] bool aRedirect, [MarshalAs(UnmanagedType.U1)] bool aToplevel, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsVisited([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPageTitle([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);
}
