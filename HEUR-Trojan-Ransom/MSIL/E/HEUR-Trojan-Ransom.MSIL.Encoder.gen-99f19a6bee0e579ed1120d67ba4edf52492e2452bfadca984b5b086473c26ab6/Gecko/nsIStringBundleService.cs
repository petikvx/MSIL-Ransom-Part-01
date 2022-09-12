using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("D85A17C0-AA7C-11d2-9B8C-00805F8A16D9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStringBundleService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStringBundle CreateBundle([MarshalAs(UnmanagedType.LPStr)] string aURLSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStringBundle CreateExtensibleBundle([MarshalAs(UnmanagedType.LPStr)] string aRegistryKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string FormatStatusMessage(int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aStatusArg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FlushBundles();
}
