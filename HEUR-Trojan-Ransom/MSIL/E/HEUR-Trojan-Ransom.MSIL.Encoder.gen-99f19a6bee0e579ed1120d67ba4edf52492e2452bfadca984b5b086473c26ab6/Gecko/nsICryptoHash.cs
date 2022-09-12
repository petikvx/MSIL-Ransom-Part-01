using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1e5b7c43-4688-45ce-92e1-77ed931e3bbe")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICryptoHash
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(uint aAlgorithm);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAlgorithm);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Update([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] aData, uint aLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, uint aLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Finish([MarshalAs(UnmanagedType.U1)] bool aASCII, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
