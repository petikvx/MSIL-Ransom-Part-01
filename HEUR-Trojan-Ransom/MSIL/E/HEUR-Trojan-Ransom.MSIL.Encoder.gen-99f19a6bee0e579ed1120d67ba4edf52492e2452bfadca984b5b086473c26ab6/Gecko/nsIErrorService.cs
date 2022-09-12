using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("afe1f190-a3c2-11e3-a5e2-0800200c9a66")]
public interface nsIErrorService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterErrorStringBundle(short errorModule, [MarshalAs(UnmanagedType.LPStr)] string stringBundleURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterErrorStringBundle(short errorModule);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetErrorStringBundle(short errorModule);
}
