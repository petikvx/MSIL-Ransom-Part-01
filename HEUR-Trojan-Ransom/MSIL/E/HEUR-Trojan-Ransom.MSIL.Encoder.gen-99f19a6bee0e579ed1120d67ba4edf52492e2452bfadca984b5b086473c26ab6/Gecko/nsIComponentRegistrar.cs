using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2417cbfe-65ad-48a6-b4b6-eb84db174392")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIComponentRegistrar
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AutoRegister([MarshalAs(UnmanagedType.Interface)] nsIFile aSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AutoUnregister([MarshalAs(UnmanagedType.Interface)] nsIFile aSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterFactory(ref Guid aClass, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aContractID, [MarshalAs(UnmanagedType.Interface)] nsIFactory aFactory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterFactory(ref Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsIFactory aFactory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterFactoryLocation(ref Guid aClass, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aContractID, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile, [MarshalAs(UnmanagedType.LPStr)] string aLoaderStr, [MarshalAs(UnmanagedType.LPStr)] string aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterFactoryLocation(ref Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCIDRegistered(ref Guid aClass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsContractIDRegistered([MarshalAs(UnmanagedType.LPStr)] string aContractID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator EnumerateCIDs();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator EnumerateContractIDs();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string CIDToContractID(ref Guid aClass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr ContractIDToCID([MarshalAs(UnmanagedType.LPStr)] string aContractID);
}
