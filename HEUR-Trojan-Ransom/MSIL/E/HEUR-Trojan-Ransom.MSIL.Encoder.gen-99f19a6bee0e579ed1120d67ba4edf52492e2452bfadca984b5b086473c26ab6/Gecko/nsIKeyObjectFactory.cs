using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("264eb54d-e20d-49a0-890c-1a5986ea81c4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIKeyObjectFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIKeyObject LookupKeyByName([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIKeyObject UnwrapKey(short aAlgorithm, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aWrappedKey, uint aWrappedKeyLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIKeyObject KeyFromString(short aAlgorithm, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);
}
