using System;
using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal struct RpcRequest
{
	[MarshalAs(UnmanagedType.LPWStr)]
	public string Type;

	public int Length;

	public IntPtr Data;
}
