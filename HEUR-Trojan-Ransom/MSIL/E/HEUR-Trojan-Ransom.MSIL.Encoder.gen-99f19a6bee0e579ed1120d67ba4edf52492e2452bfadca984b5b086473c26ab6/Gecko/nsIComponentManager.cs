using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d604ffc3-1ba3-4f6c-b65f-1ed4199364c3")]
public interface nsIComponentManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClassObject(ref Guid aClass, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClassObjectByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr CreateInstance(ref Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsISupports aDelegate, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr CreateInstanceByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, [MarshalAs(UnmanagedType.Interface)] nsISupports aDelegate, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddBootstrappedManifestLocation([MarshalAs(UnmanagedType.Interface)] nsIFile aLocation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveBootstrappedManifestLocation([MarshalAs(UnmanagedType.Interface)] nsIFile aLocation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetManifestLocations();
}
