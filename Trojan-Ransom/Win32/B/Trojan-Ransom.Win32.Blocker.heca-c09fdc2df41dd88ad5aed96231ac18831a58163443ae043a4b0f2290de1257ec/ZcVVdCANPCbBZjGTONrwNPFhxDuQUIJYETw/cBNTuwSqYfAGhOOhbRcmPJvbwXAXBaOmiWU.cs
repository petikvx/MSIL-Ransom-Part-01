using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace ZcVVdCANPCbBZjGTONrwNPFhxDuQUIJYETw;

public abstract class cBNTuwSqYfAGhOOhbRcmPJvbwXAXBaOmiWU
{
	public sealed class Methods
	{
		private const string KERNEL32 = "kernel32";

		[DllImport("kernel32", SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr JFvgvCWsahoYRhMCrlhcZnccRVHLKFilEIOblox);

		[DllImport("kernel32")]
		public static extern IntPtr GetProcAddress(SafeLibraryHandle JFvgvCWsahoYRhMCrlhcZnccRVHLKFilEIOblox, string kgcOYTpMZVqqtpwbQXgiZuxvkgmKtBOfglHIU);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern SafeLibraryHandle LoadLibrary(string JWZVcOcGSBxlUZVIurwWhbmvWaRnYbpBkGsk);
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

	public Delegate WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX(string rOaWDTYZteJwqdwboClQEkVXttptRJTIsGoKmG, string ugTgPOxcWcitgjEBHrDYFcaIkIBEhnjnfRmf, Type BDGrOQRhLlUlFeRjgbSDLrHNqqhoqLMsUQDlscm)
	{
		string jWZVcOcGSBxlUZVIurwWhbmvWaRnYbpBkGsk = CHtQZAquInpurBOFUorBmIFYXjDJiuIRkdkCOO.mdGAxAXHMvfndYCoBEjdjFaqRqZJsCiqaRD(rOaWDTYZteJwqdwboClQEkVXttptRJTIsGoKmG);
		string kgcOYTpMZVqqtpwbQXgiZuxvkgmKtBOfglHIU = CHtQZAquInpurBOFUorBmIFYXjDJiuIRkdkCOO.mdGAxAXHMvfndYCoBEjdjFaqRqZJsCiqaRD(ugTgPOxcWcitgjEBHrDYFcaIkIBEhnjnfRmf);
		SafeLibraryHandle safeLibraryHandle = Methods.LoadLibrary(jWZVcOcGSBxlUZVIurwWhbmvWaRnYbpBkGsk);
		Delegate result = null;
		if (!safeLibraryHandle.IsInvalid && !safeLibraryHandle.IsClosed)
		{
			result = Marshal.GetDelegateForFunctionPointer(Methods.GetProcAddress(safeLibraryHandle, kgcOYTpMZVqqtpwbQXgiZuxvkgmKtBOfglHIU), BDGrOQRhLlUlFeRjgbSDLrHNqqhoqLMsUQDlscm);
			safeLibraryHandle.Close();
		}
		return result;
	}
}
