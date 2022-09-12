using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ae74cda5-cd2f-473f-96f5-f0b7fff62c68")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIX509CertList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddCert([MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteCert([MarshalAs(UnmanagedType.Interface)] nsIX509Cert cert);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetRawCertList();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsIX509CertList other);
}
