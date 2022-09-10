using System;
using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal struct RpcResponse
{
	public int Length;

	public IntPtr Data;

	public IntPtr Marshal()
	{
		return Create(Data, Length);
	}

	public static IntPtr Create(IntPtr data, int length)
	{
		RpcResponse rpcResponse = default(RpcResponse);
		IntPtr intPtr = System.Runtime.InteropServices.Marshal.AllocHGlobal(System.Runtime.InteropServices.Marshal.SizeOf(typeof(RpcResponse)));
		try
		{
			rpcResponse.Length = length;
			rpcResponse.Data = data;
			System.Runtime.InteropServices.Marshal.StructureToPtr((object)rpcResponse, intPtr, fDeleteOld: false);
			return intPtr;
		}
		catch
		{
			System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
			throw;
		}
	}
}
