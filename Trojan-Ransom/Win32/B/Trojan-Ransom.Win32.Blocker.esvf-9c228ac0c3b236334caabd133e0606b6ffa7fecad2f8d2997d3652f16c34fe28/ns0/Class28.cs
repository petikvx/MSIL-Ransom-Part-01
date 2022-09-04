using System;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class28
{
	internal enum Enum13
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

	internal static bool smethod_0(string string_0, string string_1, string string_2, bool bool_0, bool bool_1, string string_3, Enum13 enum13_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		int num15 = default(int);
		bool flag = default(bool);
		Exception ex2 = default(Exception);
		try
		{
			num = 2;
			num2 = 16;
			num3 = 1;
			num4 = 983040;
			num5 = 1;
			num6 = 2;
			num7 = 4;
			num8 = 8;
			num9 = 16;
			num10 = 32;
			num11 = 64;
			num12 = 128;
			num13 = 256;
			num14 = num4 | num5 | num6 | num7 | num8 | num9 | num10 | num11 | num12 | num13;
			try
			{
				intPtr = OpenSCManager(null, null, num);
				if (intPtr.ToInt32() != 0)
				{
					intPtr2 = CreateService(intPtr, string_1, string_2, num14, num2, (int)enum13_0, num3, string_0, null, 0, null, null, null);
					if (intPtr2.ToInt32() != 0)
					{
						if (string_3 != Class38.smethod_0(1004690139, 250733958, 13254868) && !smethod_2(string_1, string_3))
						{
							smethod_4(Class38.smethod_0(204214563, 250734024, 13254806), bool_1);
						}
						if (bool_0)
						{
							num15 = StartService(intPtr2, 0, null);
							if (num15 == 0)
							{
								smethod_4(Class38.smethod_0(1333491993, 250734070, 13254906), bool_1);
							}
						}
						smethod_5(Class38.smethod_0(1405893956, 250733874, 13254888), bool_1);
						CloseServiceHandle(intPtr);
						flag = true;
						return flag;
					}
					smethod_3(Class38.smethod_0(881161303, 250733958, 13254884), bool_1);
					CloseServiceHandle(intPtr);
				}
				else
				{
					smethod_3(Class38.smethod_0(298277231, 250733950, 13254808), bool_1);
				}
			}
			catch (Exception ex)
			{
				ex2 = ex;
				smethod_3(ex2.ToString(), bool_1);
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[26]
			{
				string_0, string_1, string_2, bool_0, bool_1, string_3, enum13_0, num, num2, num3,
				num4, num5, num6, num7, num8, num9, num10, num11, num12, num13,
				num14, intPtr, intPtr2, num15, ex2, flag
			});
			throw;
		}
	}

	internal static bool smethod_1(string string_0, bool bool_0)
	{
		int num = default(int);
		IntPtr intPtr = default(IntPtr);
		int num2 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		int num3 = default(int);
		bool flag = default(bool);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				num = 1073741824;
				intPtr = OpenSCManager(null, null, num);
				if (intPtr.ToInt32() != 0)
				{
					num2 = 65536;
					intPtr2 = OpenService(intPtr, string_0, num2);
					if (intPtr2.ToInt32() != 0)
					{
						num3 = DeleteService(intPtr2);
						if (num3 != 0)
						{
							smethod_5(Class38.smethod_0(15486745, 250733724, 13254804), bool_0);
							CloseServiceHandle(intPtr);
							flag = true;
							return flag;
						}
						smethod_3(Class38.smethod_0(739483489, 250733778, 13254882), bool_0);
						CloseServiceHandle(intPtr);
						flag = false;
						return flag;
					}
					smethod_3(Class38.smethod_0(1166205209, 250733578, 13254892), bool_0);
				}
				else
				{
					smethod_3(Class38.smethod_0(149285580, 250733654, 13254808), bool_0);
				}
			}
			catch (Exception ex)
			{
				ex2 = ex;
				smethod_3(ex2.ToString(), bool_0);
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class14.smethod_30(exception_, string_0, bool_0, num, intPtr, num2, intPtr2, num3, ex2, flag);
			throw;
		}
	}

	internal static bool smethod_2(string string_0, string string_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		Class21.Struct10 struct10_ = default(Class21.Struct10);
		bool flag2 = default(bool);
		try
		{
			if (string_1 == Class38.smethod_0(1761631202, 250734428, 13254868))
			{
				return true;
			}
			num = 0;
			num2 = 0;
			num3 = 0;
			flag = false;
			struct10_.string_0 = string_1;
			try
			{
				num = Class21.OpenSCManagerA(null, null, Class21.Enum8.const_6);
				if (num < 1)
				{
					flag2 = false;
					return flag2;
				}
				num2 = Class21.LockServiceDatabase(num);
				if (num2 < 1)
				{
					flag2 = false;
					return flag2;
				}
				num3 = Class21.OpenServiceA(num, string_0, Class21.Enum9.const_9);
				if (num3 < 1)
				{
					flag2 = false;
					return flag2;
				}
				flag2 = (flag = Class21.ChangeServiceConfig2A(num3, Class21.Enum11.const_0, ref struct10_));
				return flag2;
			}
			catch
			{
			}
			finally
			{
				if (num3 > 0)
				{
					Class21.CloseServiceHandle(num3);
				}
				if (num2 > 0)
				{
					Class21.UnlockServiceDatabase(num2);
				}
				if (num != 0)
				{
					Class21.CloseServiceHandle(num);
				}
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class14.smethod_29(exception_, string_0, string_1, num, num2, num3, flag, struct10_, flag2);
			throw;
		}
	}

	internal static void smethod_3(string string_0, bool bool_0)
	{
		try
		{
			smethod_5(Class38.smethod_0(1957614629, 250734428, 13254874) + string_0, bool_0);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, string_0, bool_0);
			throw;
		}
	}

	internal static void smethod_4(string string_0, bool bool_0)
	{
		try
		{
			smethod_5(Class38.smethod_0(1857293450, 250734414, 13254854) + string_0, bool_0);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, string_0, bool_0);
			throw;
		}
	}

	internal static void smethod_5(string string_0, bool bool_0)
	{
		try
		{
			if (!bool_0)
			{
				Console.WriteLine(string_0);
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, string_0, bool_0);
			throw;
		}
	}
}
