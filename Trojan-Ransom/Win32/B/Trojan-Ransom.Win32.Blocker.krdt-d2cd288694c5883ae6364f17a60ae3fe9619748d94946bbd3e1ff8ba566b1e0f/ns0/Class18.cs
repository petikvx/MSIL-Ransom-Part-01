using System;
using System.Runtime.InteropServices;
using ns1;

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
					if (string_3 != Class27.smethod_0(375558960, 1521531077, 915766426) && !smethod_2(string_1, string_3))
					{
						smethod_4(Class27.smethod_0(1601351864, 1521531019, 915766488), bool_1);
					}
					if (bool_0 && StartService(intptr_2, 0, null) == 0)
					{
						smethod_4(Class27.smethod_0(2123013, 1521531061, 915766452), bool_1);
					}
					smethod_5(Class27.smethod_0(1746121688, 1521530993, 915766438), bool_1);
					CloseServiceHandle(intptr_);
					return true;
				}
				smethod_3(Class27.smethod_0(411995474, 1521531077, 915766442), bool_1);
				CloseServiceHandle(intptr_);
			}
			else
			{
				smethod_3(Class27.smethod_0(572236195, 1521530941, 915766486), bool_1);
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
						smethod_5(Class27.smethod_0(1739707374, 1521531359, 915766490), bool_0);
						CloseServiceHandle(intptr_);
						return true;
					}
					smethod_3(Class27.smethod_0(1217058347, 1521531281, 915766444), bool_0);
					CloseServiceHandle(intptr_);
					return false;
				}
				smethod_3(Class27.smethod_0(1791445932, 1521531209, 915766434), bool_0);
			}
			else
			{
				smethod_3(Class27.smethod_0(1270687801, 1521531157, 915766486), bool_0);
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
		if (string_1 == Class27.smethod_0(891135057, 1521531423, 915766426))
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
		smethod_5(Class27.smethod_0(24069625, 1521531423, 915766420) + string_0, bool_0);
	}

	internal static void smethod_4(string string_0, bool bool_0)
	{
		smethod_5(Class27.smethod_0(1614802639, 1521531405, 915766408) + string_0, bool_0);
	}

	internal static void smethod_5(string string_0, bool bool_0)
	{
		if (!bool_0)
		{
			Console.WriteLine(string_0);
		}
	}
}
