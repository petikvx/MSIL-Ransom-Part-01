using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("68067eb5-ad8d-43cb-a043-1cc85ebe06e7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIEffectiveTLDService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPublicSuffix([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBaseDomain([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, uint aAdditionalParts, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPublicSuffixFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBaseDomainFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, uint aAdditionalParts, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNextSubDomain([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
