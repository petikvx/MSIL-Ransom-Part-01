using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8bb35ed9-e332-462d-9155-4a002ab5c958")]
public interface nsIServiceManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetService(ref Guid aClass, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetServiceByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsServiceInstantiated(ref Guid aClass, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsServiceInstantiatedByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref Guid aIID);
}
