using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Publisher.Utility;

internal class SystemUtility
{
	public static bool addToStarup(string valueName, string path)
	{
		try
		{
			RegistryKey object_ = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			_ = 0;
			if (eQJFfuNjKFFQ8gZPEJN())
			{
				if (!khKR7qNL6pSSRn5gadZ())
				{
					switch (2)
					{
					default:
						goto end_IL_0001;
					case 0:
					case 2:
						break;
					case 1:
					case 3:
						goto end_IL_0001;
					}
				}
				r5n36gNY0Qixi4YLXL6(object_, valueName, path);
			}
			end_IL_0001:;
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public static bool Is64BitOperatingSystem()
	{
		bool flag = UeP27MNduUHt5TccVHM() == 8;
		_ = 1;
		bool wow64Process = default(bool);
		if (!khKR7qNL6pSSRn5gadZ() && !flag)
		{
			return BABGodNwZdqfCbt8AjD("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out wow64Process) && wow64Process;
		}
		return true;
	}

	private static bool DoesWin32MethodExist(string moduleName, string methodName)
	{
		IntPtr moduleHandle = GetModuleHandle(moduleName);
		khKR7qNL6pSSRn5gadZ();
		if (eQJFfuNjKFFQ8gZPEJN())
		{
			if (U37FpgNVq9EmjX06JxP(moduleHandle, IntPtr.Zero))
			{
				return false;
			}
			return pp0rchNTsNcDIv9SnYO(GetProcAddress(moduleHandle, methodName), IntPtr.Zero);
		}
		bool result = default(bool);
		return result;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string procName);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);

	public SystemUtility()
	{
		Ac2qeYN2LWIhfvcjL4q(this);
	}

	internal static void r5n36gNY0Qixi4YLXL6(object object_0, object object_1, object object_2)
	{
		((RegistryKey)object_0).SetValue((string?)object_1, object_2);
	}

	internal static bool eQJFfuNjKFFQ8gZPEJN()
	{
		return true;
	}

	internal static bool khKR7qNL6pSSRn5gadZ()
	{
		return false;
	}

	internal static int UeP27MNduUHt5TccVHM()
	{
		return IntPtr.Size;
	}

	internal static bool BABGodNwZdqfCbt8AjD(object object_0, object object_1)
	{
		return DoesWin32MethodExist((string)object_0, (string)object_1);
	}

	internal static bool U37FpgNVq9EmjX06JxP(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 == intptr_1;
	}

	internal static bool pp0rchNTsNcDIv9SnYO(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 != intptr_1;
	}

	internal static void Ac2qeYN2LWIhfvcjL4q(object object_0)
	{
		object_0._002Ector();
	}
}
