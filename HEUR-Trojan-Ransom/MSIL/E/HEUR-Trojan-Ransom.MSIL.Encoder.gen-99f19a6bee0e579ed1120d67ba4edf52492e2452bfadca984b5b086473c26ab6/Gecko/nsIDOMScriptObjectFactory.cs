using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2a50e17c-46ff-4150-bb46-d807b336deab")]
public interface nsIDOMScriptObjectFactory
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIClassInfo DONTUSE_GetClassInfoInstance(uint aID);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports DONTUSE_GetExternalClassInfoInstance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterDOMClassInfo(string aName, IntPtr aConstructorFptr, Guid aProtoChainInterface, ref Guid aInterfaces, uint aScriptableFlags, bool aHasClassInterface, Guid aConstructorCID);
}
