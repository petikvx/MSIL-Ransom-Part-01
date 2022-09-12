using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8FEB4C7C-1641-4a7b-BC6D-1964E2099497")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICryptoHMAC
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(uint aAlgorithm, [MarshalAs(UnmanagedType.Interface)] nsIKeyObject aKeyObject);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Update([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] aData, uint aLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, uint aLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Finish([MarshalAs(UnmanagedType.U1)] bool aASCII, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();
}
