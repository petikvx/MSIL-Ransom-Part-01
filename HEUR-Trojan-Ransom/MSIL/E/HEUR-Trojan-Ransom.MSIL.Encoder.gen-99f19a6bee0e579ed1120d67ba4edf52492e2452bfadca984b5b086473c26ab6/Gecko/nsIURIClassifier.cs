using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("596620cc-76e3-4133-9d90-360e59a794cf")]
public interface nsIURIClassifier
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Classify([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.U1)] bool aTrackingProtectionEnabled, [MarshalAs(UnmanagedType.Interface)] nsIURIClassifierCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClassifyLocalWithTables([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aTables, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
