using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Publisher.Utility;

internal class Protect
{
	[Flags]
	public enum ProcessAccessRights
	{
		PROCESS_CREATE_PROCESS = 0x80,
		PROCESS_CREATE_THREAD = 2,
		PROCESS_DUP_HANDLE = 0x40,
		PROCESS_QUERY_INFORMATION = 0x400,
		PROCESS_QUERY_LIMITED_INFORMATION = 0x1000,
		PROCESS_SET_INFORMATION = 0x200,
		PROCESS_SET_QUOTA = 0x100,
		PROCESS_SUSPEND_RESUME = 0x800,
		PROCESS_TERMINATE = 1,
		PROCESS_VM_OPERATION = 8,
		PROCESS_VM_READ = 0x10,
		PROCESS_VM_WRITE = 0x20,
		DELETE = 0x10000,
		READ_CONTROL = 0x20000,
		SYNCHRONIZE = 0x100000,
		WRITE_DAC = 0x40000,
		WRITE_OWNER = 0x80000,
		STANDARD_RIGHTS_REQUIRED = 0xF0000,
		PROCESS_ALL_ACCESS = 0x1F0FFF
	}

	public static RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
	{
		byte[] pSecurityDescriptor = new byte[0];
		GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor, 0u, out var lpnLengthNeeded);
		_ = 1;
		if (!xeKBd8Ncxg3OfdyAe3P())
		{
		}
		if ((long)lpnLengthNeeded > 32767L)
		{
			throw new Win32Exception();
		}
		if (!GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(pSecurityDescriptor, 0);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	public static void SetProcessSecurityDescriptor(IntPtr processHandle, RawSecurityDescriptor dacl)
	{
		bool flag = default(bool);
		while (true)
		{
			byte[] array = new byte[ysNdBQNI4oaZFDetYHh(dacl)];
			while (true)
			{
				aS6itxN1E1USKqMnn7l(dacl, array, 0);
				_ = 0;
				if (AlsMLdNXl89EHJK0vQH())
				{
					if (AlsMLdNXl89EHJK0vQH())
					{
						switch (1)
						{
						case 0:
							break;
						case 4:
							goto end_IL_0003;
						case 1:
						case 2:
							flag = !SetKernelObjectSecurity(processHandle, 4, array);
							goto IL_0063;
						default:
							goto IL_0063;
						case 6:
							goto IL_0066;
						}
						continue;
					}
				}
				goto IL_0063;
				IL_0063:
				if (!flag)
				{
					return;
				}
				goto IL_0066;
				IL_0066:
				throw new Win32Exception();
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	public static void Doprotection()
	{
		_ = 0;
		if (!AlsMLdNXl89EHJK0vQH())
		{
			goto IL_000c;
		}
		goto IL_0042;
		IL_000c:
		IntPtr currentProcess = default(IntPtr);
		while (true)
		{
			RawSecurityDescriptor processSecurityDescriptor = GetProcessSecurityDescriptor(currentProcess);
			if (AlsMLdNXl89EHJK0vQH())
			{
				switch (5)
				{
				case 1:
				case 4:
					break;
				case 0:
				case 2:
					goto end_IL_000c;
				case 5:
					goto IL_004b;
				default:
					goto IL_006c;
				case 6:
					return;
				}
				continue;
			}
			goto IL_004b;
			IL_006c:
			mQYb55NgWdsqIitAO7j(currentProcess, processSecurityDescriptor);
			return;
			IL_004b:
			qrwHTGNSvv3Lp9g1cjm(processSecurityDescriptor.DiscretionaryAcl, 0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			goto IL_006c;
			continue;
			end_IL_000c:
			break;
		}
		goto IL_0042;
		IL_0042:
		currentProcess = GetCurrentProcess();
		goto IL_000c;
	}

	public Protect()
	{
		hnhAJVNfcunplAFxqOI(this);
	}

	internal static bool AlsMLdNXl89EHJK0vQH()
	{
		return true;
	}

	internal static bool xeKBd8Ncxg3OfdyAe3P()
	{
		return false;
	}

	internal static int ysNdBQNI4oaZFDetYHh(object object_0)
	{
		return ((GenericSecurityDescriptor)object_0).BinaryLength;
	}

	internal static void aS6itxN1E1USKqMnn7l(object object_0, object object_1, int int_0)
	{
		((GenericSecurityDescriptor)object_0).GetBinaryForm((byte[])object_1, int_0);
	}

	internal static void qrwHTGNSvv3Lp9g1cjm(object object_0, int int_0, object object_1)
	{
		((RawAcl)object_0).InsertAce(int_0, (GenericAce)object_1);
	}

	internal static void mQYb55NgWdsqIitAO7j(IntPtr processHandle, object object_0)
	{
		SetProcessSecurityDescriptor(processHandle, (RawSecurityDescriptor)object_0);
	}

	internal static void hnhAJVNfcunplAFxqOI(object object_0)
	{
		object_0._002Ector();
	}
}
