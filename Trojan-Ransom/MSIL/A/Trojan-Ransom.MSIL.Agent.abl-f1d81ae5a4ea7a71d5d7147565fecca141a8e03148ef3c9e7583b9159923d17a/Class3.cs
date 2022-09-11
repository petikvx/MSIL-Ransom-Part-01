using System;
using System.Runtime.InteropServices;

internal class Class3
{
	private string string_0;

	private string string_1;

	private string string_2;

	[DllImport("advapi32.dll")]
	public static extern IntPtr OpenSCManager(string string_3, string string_4, int int_0);

	[DllImport("advapi32.dll")]
	public static extern IntPtr CreateService(IntPtr intptr_0, string string_3, string string_4, int int_0, int int_1, int int_2, int int_3, string string_5, string string_6, int int_4, string string_7, string string_8, string string_9);

	[DllImport("advapi32.dll")]
	public static extern void CloseServiceHandle(IntPtr intptr_0);

	[DllImport("advapi32.dll")]
	public static extern int StartService(IntPtr intptr_0, int int_0, string string_3);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern IntPtr OpenService(IntPtr intptr_0, string string_3, int int_0);

	[DllImport("advapi32.dll")]
	public static extern int DeleteService(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern int GetLastError();

	public bool method_0(string string_3, string string_4, string string_5)
	{
		int int_ = 2;
		int int_2 = 16;
		int int_3 = 1;
		int int_4 = 983551;
		int int_5 = 2;
		try
		{
			IntPtr intptr_ = OpenSCManager(null, null, int_);
			if (intptr_.ToInt32() != 0)
			{
				IntPtr intptr_2 = CreateService(intptr_, string_4, string_5, int_4, int_2, int_5, int_3, string_3, null, 0, null, null, null);
				if (intptr_2.ToInt32() == 0)
				{
					CloseServiceHandle(intptr_);
					return false;
				}
				if (StartService(intptr_2, 0, null) == 0)
				{
					return false;
				}
				CloseServiceHandle(intptr_);
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public bool method_1(string string_3)
	{
		IntPtr intptr_ = OpenSCManager(null, null, 1073741824);
		if (intptr_.ToInt32() != 0)
		{
			IntPtr intptr_2 = OpenService(intptr_, string_3, 65536);
			if (intptr_2.ToInt32() != 0)
			{
				if (DeleteService(intptr_2) != 0)
				{
					CloseServiceHandle(intptr_);
					return true;
				}
				CloseServiceHandle(intptr_);
				return false;
			}
			return false;
		}
		return false;
	}

	public Class3()
	{
		Class6.s8ZQibUzDcdOO();
		base._002Ector();
	}
}
