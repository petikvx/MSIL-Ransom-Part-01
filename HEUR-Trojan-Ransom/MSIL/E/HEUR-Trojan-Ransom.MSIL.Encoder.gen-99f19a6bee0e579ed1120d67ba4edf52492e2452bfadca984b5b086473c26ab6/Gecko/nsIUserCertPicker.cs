using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("92396323-23f2-49e0-bf98-a25a725231ab")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUserCertPicker
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert PickByUsage([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string selectedNickname, int certUsage, [MarshalAs(UnmanagedType.U1)] bool allowInvalid, [MarshalAs(UnmanagedType.U1)] bool allowDuplicateNicknames, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase emailAddress, [MarshalAs(UnmanagedType.U1)] ref bool canceled);
}
