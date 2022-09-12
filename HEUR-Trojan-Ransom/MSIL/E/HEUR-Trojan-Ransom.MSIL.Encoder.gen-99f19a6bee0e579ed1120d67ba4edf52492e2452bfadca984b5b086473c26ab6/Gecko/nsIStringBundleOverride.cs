using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("965eb278-5678-456b-82a7-20a0c86a803c")]
public interface nsIStringBundleOverride
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStringFromName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase url, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator EnumerateKeysInBundle([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase url);
}
