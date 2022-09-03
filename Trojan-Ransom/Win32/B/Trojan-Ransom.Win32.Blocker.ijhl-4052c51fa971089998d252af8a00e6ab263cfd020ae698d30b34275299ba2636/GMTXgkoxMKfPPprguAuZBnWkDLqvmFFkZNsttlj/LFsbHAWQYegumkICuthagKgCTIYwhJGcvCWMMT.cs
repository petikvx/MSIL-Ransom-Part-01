using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace GMTXgkoxMKfPPprguAuZBnWkDLqvmFFkZNsttlj;

public abstract class LFsbHAWQYegumkICuthagKgCTIYwhJGcvCWMMT
{
	public sealed class Methods
	{
		private const string KERNEL32 = "kernel32";

		[DllImport("kernel32", SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr FImYbxeCQBlKSuRcZPkVlaIMuTdGfCeVFeRu);

		[DllImport("kernel32")]
		public static extern IntPtr GetProcAddress(SafeLibraryHandle FImYbxeCQBlKSuRcZPkVlaIMuTdGfCeVFeRu, string toDgaALwUUaenHaOWHbUdGTQDPmMdpLtcGkS);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern SafeLibraryHandle LoadLibrary(string MpSIHcWACIjBOPmDaGiLolimjZTDfxovkjVYFw);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	public sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		private SafeLibraryHandle()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return Methods.FreeLibrary(handle);
		}
	}

	public Delegate uCHkOiOwxIqsRApAvvavaZIRYVOSQFmdVkaNdjU(string icrSHQupRidoJtbNBXqFxXYePVBukOulbxxwk, string WhXOHLETveRkVkULpLENAkPvFAjnNKudYGBJdj, Type KXuYVavoHRNFmpXnkSaGHXMDiimMMjLgGtsl)
	{
		string mpSIHcWACIjBOPmDaGiLolimjZTDfxovkjVYFw = wqLGGWZMfRGmOLpGBtLnopaCfEWfPPkJHhZ.IcNbGlYsHAulrpCjvQKoWbCYVdMJLMlrdwqle(icrSHQupRidoJtbNBXqFxXYePVBukOulbxxwk);
		string toDgaALwUUaenHaOWHbUdGTQDPmMdpLtcGkS = wqLGGWZMfRGmOLpGBtLnopaCfEWfPPkJHhZ.IcNbGlYsHAulrpCjvQKoWbCYVdMJLMlrdwqle(WhXOHLETveRkVkULpLENAkPvFAjnNKudYGBJdj);
		SafeLibraryHandle safeLibraryHandle = Methods.LoadLibrary(mpSIHcWACIjBOPmDaGiLolimjZTDfxovkjVYFw);
		Delegate result = null;
		if (!safeLibraryHandle.IsInvalid && !safeLibraryHandle.IsClosed)
		{
			result = Marshal.GetDelegateForFunctionPointer(Methods.GetProcAddress(safeLibraryHandle, toDgaALwUUaenHaOWHbUdGTQDPmMdpLtcGkS), KXuYVavoHRNFmpXnkSaGHXMDiimMMjLgGtsl);
			safeLibraryHandle.Close();
		}
		return result;
	}
}
