using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

internal class Class20 : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static Class20 Class20_0
	{
		get
		{
			Class20 result = default(Class20);
			while (true)
			{
				int num = -155594072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEE93E4B4u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = new Class20(IntPtr.Zero);
					num = (int)(num2 * 1643177007) ^ -2003342959;
				}
			}
		}
	}

	private Class20()
		: base(ownsHandle: true)
	{
		while (true)
		{
			int num = -50969181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC882B83Fu) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1534731205) ^ -1363934468;
			}
		}
	}

	internal Class20(IntPtr intptr_0)
		: base(ownsHandle: true)
	{
		SetHandle(intptr_0);
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	bool SafeHandle.ReleaseHandle()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 72884167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51D1A541u) % 4u)
				{
				case 2u:
					result = CloseHandle(handle);
					num = (int)((num2 * 259559372) ^ 0x4C7B6E50);
					continue;
				case 1u:
					num = ((int)num2 * -1506863609) ^ 0xF4A4BE5;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
