using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;
using HP.SupportFramework.Common.HPSAIssues;

public class GClass8
{
	private enum Enum0
	{
		const_0 = 1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14,
		const_15,
		const_16
	}

	private struct Struct0
	{
		public IntPtr intptr_0;

		public int int_0;
	}

	internal class Class7
	{
		private readonly string string_0;

		private readonly int int_0;

		public string String_0 => (string)Class28.smethod_0(4831771, this, null);

		public int Int32_0 => (int)Class28.smethod_0(4831778, this, null);

		public bool Boolean_0 => (bool)Class28.smethod_0(4831817, this, null);

		public bool Boolean_1 => (bool)Class28.smethod_0(4831848, this, null);

		public Class7(IntPtr intptr_0, int int_1)
		{
			IntPtr intptr_ = default(IntPtr);
			if (!Delegate63.smethod_0(intptr_0, ref intptr_) && 0 == 0)
			{
				throw new Win32Exception();
			}
			string_0 = Marshal.PtrToStringAuto(intptr_);
			int num = GClass6.smethod_0(46);
			int num2 = -6;
			num2 = -55;
			while (true)
			{
				num ^= 0x3A;
				num2 = GClass6.smethod_0(35);
				while (true)
				{
					switch (num2 ^ 0x33)
					{
					case -58:
						switch (num)
						{
						default:
							num2 = ActionItemBase.smethod_0(28);
							continue;
						case -58:
							Delegate64.smethod_0(intptr_);
							num = -14;
							break;
						case -57:
							num = -3;
							break;
						case -56:
							int_0 = int_1;
							num = ActionItemBase.smethod_0(30);
							break;
						case -55:
							return;
						}
						break;
					default:
						num2 = GClass6.smethod_0(35);
						continue;
					case -56:
						num = GClass6.smethod_0(46);
						num2 = -6;
						num2 = -55;
						break;
					case -55:
						break;
					case -57:
						while (true)
						{
							num2 = -12;
							num2 = -57;
						}
					}
					break;
				}
			}
		}

		internal static IEnumerable<Class7> smethod_0(IntPtr intptr_0)
		{
			return (IEnumerable<Class7>)Class28.smethod_0(4832649, null, intptr_0);
		}
	}

	private const int int_0 = 122;

	private const int int_1 = 4;

	private const int int_2 = 16;

	public static bool Boolean_0 => (bool)Class28.smethod_0(4831373, null, null);

	[DllImport("advapi32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ConvertSidToStringSid(IntPtr intptr_0, out IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LocalFree(IntPtr intptr_0);

	[DllImport("advapi32", SetLastError = true)]
	private static extern bool GetTokenInformation(IntPtr intptr_0, Enum0 enum0_0, IntPtr intptr_1, int int_3, out int int_4);

	private static bool smethod_0(WindowsPrincipal windowsPrincipal_0)
	{
		return (bool)Class28.smethod_0(4831445, null, windowsPrincipal_0);
	}

	private static bool smethod_1(IntPtr intptr_0)
	{
		return (bool)Class28.smethod_0(4831257, null, intptr_0);
	}

	private static IntPtr smethod_2(IntPtr intptr_0)
	{
		return (IntPtr)Class28.smethod_0(4832052, null, intptr_0);
	}

	private static void smethod_3(IntPtr intptr_0)
	{
		Class28.smethod_0(4831984, null, intptr_0);
	}
}
