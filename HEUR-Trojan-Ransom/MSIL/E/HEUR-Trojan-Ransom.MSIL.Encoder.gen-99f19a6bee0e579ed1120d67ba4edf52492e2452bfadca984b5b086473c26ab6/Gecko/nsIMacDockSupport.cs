using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8BE66B0C-5F71-4B74-98CF-6C2551B999B1")]
public interface nsIMacDockSupport
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStandaloneNativeMenu GetDockMenuAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDockMenuAttribute([MarshalAs(UnmanagedType.Interface)] nsIStandaloneNativeMenu aDockMenu);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ActivateApplication([MarshalAs(UnmanagedType.U1)] bool aIgnoreOtherApplications);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBadgeTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBadgeText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBadgeTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBadgeText);
}
