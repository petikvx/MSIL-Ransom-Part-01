using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace ihnJiSFftJkwOJDnTenHoeEHgqjCYHTfbSohbv;

public abstract class cdwiwaguDrqjUYokeHVkiQDwmNHAPMGvGekbtfI
{
	public sealed class Methods
	{
		private const string KERNEL32 = "kernel32";

		[DllImport("kernel32", SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr bTJESYajEeLmqOuJSwpVWejKLwpZkLZmEVfmC);

		[DllImport("kernel32")]
		public static extern IntPtr GetProcAddress(SafeLibraryHandle bTJESYajEeLmqOuJSwpVWejKLwpZkLZmEVfmC, string rEHdKMdGBRKLdAiiuLKLWqKkHebTtAXgZSZre);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern SafeLibraryHandle LoadLibrary(string CgOEZDQHOUpBpwISvlEoimKTpnuhetZmZGX);
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

	public Delegate VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE(string SehEtSOQaMKmLOaMavrgTdcpiqdomKpuxASEeu, string RxmYDxShqBYwwmXxnxqRAnVcQSOnLrWdepahc, Type WnQGlnOMrIXBdCmaAZZKIgjaWuaqSEJlSfYAB)
	{
		string cgOEZDQHOUpBpwISvlEoimKTpnuhetZmZGX = rahhxxKgaPgRBxpNfxIJJfHamopZUZOdqGPnbW.UhvTkxtIxusHidEIuHRiMCUnXRCeXhmaXKJa(SehEtSOQaMKmLOaMavrgTdcpiqdomKpuxASEeu);
		string rEHdKMdGBRKLdAiiuLKLWqKkHebTtAXgZSZre = rahhxxKgaPgRBxpNfxIJJfHamopZUZOdqGPnbW.UhvTkxtIxusHidEIuHRiMCUnXRCeXhmaXKJa(RxmYDxShqBYwwmXxnxqRAnVcQSOnLrWdepahc);
		SafeLibraryHandle safeLibraryHandle = Methods.LoadLibrary(cgOEZDQHOUpBpwISvlEoimKTpnuhetZmZGX);
		Delegate result = null;
		if (!safeLibraryHandle.IsInvalid && !safeLibraryHandle.IsClosed)
		{
			result = Marshal.GetDelegateForFunctionPointer(Methods.GetProcAddress(safeLibraryHandle, rEHdKMdGBRKLdAiiuLKLWqKkHebTtAXgZSZre), WnQGlnOMrIXBdCmaAZZKIgjaWuaqSEJlSfYAB);
			safeLibraryHandle.Close();
		}
		return result;
	}
}
