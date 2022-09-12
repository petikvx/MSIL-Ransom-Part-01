using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7392D032-5371-11d3-994E-00805FD26FEE")]
public interface nsIModule
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClassObject([MarshalAs(UnmanagedType.Interface)] nsIComponentManager aCompMgr, ref Guid aClass, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterSelf([MarshalAs(UnmanagedType.Interface)] nsIComponentManager aCompMgr, [MarshalAs(UnmanagedType.Interface)] nsIFile aLocation, [MarshalAs(UnmanagedType.LPStr)] string aLoaderStr, [MarshalAs(UnmanagedType.LPStr)] string aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterSelf([MarshalAs(UnmanagedType.Interface)] nsIComponentManager aCompMgr, [MarshalAs(UnmanagedType.Interface)] nsIFile aLocation, [MarshalAs(UnmanagedType.LPStr)] string aLoaderStr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanUnload([MarshalAs(UnmanagedType.Interface)] nsIComponentManager aCompMgr);
}
