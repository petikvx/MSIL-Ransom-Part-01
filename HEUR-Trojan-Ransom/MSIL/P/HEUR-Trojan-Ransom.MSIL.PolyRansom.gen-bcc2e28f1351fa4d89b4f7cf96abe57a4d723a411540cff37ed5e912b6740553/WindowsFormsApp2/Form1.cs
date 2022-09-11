using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;
using SimpleLoader;

namespace WindowsFormsApp2;

public class Form1 : Form
{
	private string HWID;

	private IContainer components;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private PictureBox pictureBox5;

	private Label label3;

	private Label label4;

	private PictureBox pictureBox6;

	private Button button2;

	private PictureBox pictureBox7;

	private Button button1;

	private PictureBox pictureBox8;

	private Label label5;

	private Label label8;

	private Label label7;

	private Label label6;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		HWID = WindowsIdentity.GetCurrent().User!.Value;
		((Control)textBox1).set_Text(HWID);
		((TextBoxBase)textBox1).set_ReadOnly(true);
		checkonline();
	}

	private void checkonline()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("https://google.com/"))
			{
				((Control)label1).set_ForeColor(Color.Green);
				((Control)label1).set_Text("Online");
			}
		}
		catch
		{
			((Control)label1).set_ForeColor(Color.Red);
			((Control)label1).set_Text("Offline");
			Application.Exit();
		}
	}

	private void pictureBox3_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox2_Click_1(object sender, EventArgs e)
	{
	}

	private void groupBox1_Enter(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox4_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox5_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox6_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		checkonline();
		string text = new WebClient().DownloadString("https://pastebin.com/raw/7UKQrA1q");
		string text2 = "csgo";
		Process.GetProcessesByName(text2).FirstOrDefault();
		if (text.Contains(((Control)textBox1).get_Text()))
		{
			string processName = text2;
			if (!Process.GetProcesses().Any((Process p) => p.ProcessName == processName))
			{
				MessageBox.Show("Counter-Strike: Global Offensive not found.");
				Application.Exit();
			}
			else
			{
				((Control)this).Hide();
				((Control)new Form2()).Show();
			}
		}
		else
		{
			Clipboard.SetText(HWID);
			MessageBox.Show("HWID Incorrect.");
			Application.Exit();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void label8_Click_1(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		((Control)pictureBox8).set_Location(new Point(41, 222));
		((Control)label8).set_BackColor(Color.FromArgb(18, 19, 17));
		((Control)label8).set_ForeColor(Color.FromArgb(160, 200, 70));
		((Control)label8).set_Font(new Font("Verdana", 6.25f, (FontStyle)1));
		((Control)label7).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label7).set_ForeColor(Color.Gainsboro);
		((Control)label7).set_Font(new Font("Verdana", 6.25f));
		((Control)label6).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label6).set_ForeColor(Color.Gainsboro);
		((Control)label6).set_Font(new Font("Verdana", 6.25f));
		((Control)label5).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label5).set_ForeColor(Color.Gainsboro);
		((Control)label5).set_Font(new Font("Verdana", 6.25f));
	}

	private void pictureBox8_Click(object sender, EventArgs e)
	{
	}

	private void label7_Click_1(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		((Control)pictureBox8).set_Location(new Point(41, 207));
		((Control)label7).set_BackColor(Color.FromArgb(18, 19, 17));
		((Control)label7).set_ForeColor(Color.FromArgb(160, 200, 70));
		((Control)label7).set_Font(new Font("Verdana", 6.25f, (FontStyle)1));
		((Control)label8).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label8).set_ForeColor(Color.Gainsboro);
		((Control)label8).set_Font(new Font("Verdana", 6.25f));
		((Control)label6).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label6).set_ForeColor(Color.Gainsboro);
		((Control)label6).set_Font(new Font("Verdana", 6.25f));
		((Control)label5).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label5).set_ForeColor(Color.Gainsboro);
		((Control)label5).set_Font(new Font("Verdana", 6.25f));
	}

	private void label6_Click_1(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		((Control)pictureBox8).set_Location(new Point(41, 192));
		((Control)label6).set_BackColor(Color.FromArgb(18, 19, 17));
		((Control)label6).set_ForeColor(Color.FromArgb(160, 200, 70));
		((Control)label6).set_Font(new Font("Verdana", 6.25f, (FontStyle)1));
		((Control)label7).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label7).set_ForeColor(Color.Gainsboro);
		((Control)label7).set_Font(new Font("Verdana", 6.25f));
		((Control)label5).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label5).set_ForeColor(Color.Gainsboro);
		((Control)label5).set_Font(new Font("Verdana", 6.25f));
		((Control)label8).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label8).set_ForeColor(Color.Gainsboro);
		((Control)label8).set_Font(new Font("Verdana", 6.25f));
	}

	private void label5_Click_2(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		((Control)pictureBox8).set_Location(new Point(41, 177));
		((Control)label5).set_BackColor(Color.FromArgb(18, 19, 17));
		((Control)label5).set_ForeColor(Color.FromArgb(160, 200, 70));
		((Control)label5).set_Font(new Font("Verdana", 6.25f, (FontStyle)1));
		((Control)label7).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label7).set_ForeColor(Color.Gainsboro);
		((Control)label7).set_Font(new Font("Verdana", 6.25f));
		((Control)label6).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label6).set_ForeColor(Color.Gainsboro);
		((Control)label6).set_Font(new Font("Verdana", 6.25f));
		((Control)label8).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label8).set_ForeColor(Color.Gainsboro);
		((Control)label8).set_Font(new Font("Verdana", 6.25f));
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void pictureBox3_Click_1(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox7_Click(object sender, EventArgs e)
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
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected O, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected O, but got Unknown
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Expected O, but got Unknown
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Expected O, but got Unknown
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Expected O, but got Unknown
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Expected O, but got Unknown
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected O, but got Unknown
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edd: Expected O, but got Unknown
		//IL_1062: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox5 = new PictureBox();
		label3 = new Label();
		label4 = new Label();
		pictureBox6 = new PictureBox();
		button2 = new Button();
		pictureBox7 = new PictureBox();
		button1 = new Button();
		pictureBox8 = new PictureBox();
		label5 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox7).BeginInit();
		((ISupportInitialize)pictureBox8).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(800, 300));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(43, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("[Status]");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(800, 75));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("label2");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)textBox1).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(800, 297));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(151, 20));
		((Control)textBox1).set_TabIndex(3);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)pictureBox1).set_Anchor((AnchorStyles)1);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(784, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(41, 14));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox1.set_TabIndex(5);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)pictureBox2).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage"));
		pictureBox2.set_ErrorImage((Image)null);
		pictureBox2.set_InitialImage((Image)null);
		((Control)pictureBox2).set_Location(new Point(6, 6));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(472, 4));
		pictureBox2.set_TabIndex(6);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click_1);
		((Control)pictureBox3).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox3.BackgroundImage"));
		pictureBox3.set_ErrorImage((Image)null);
		pictureBox3.set_InitialImage((Image)null);
		((Control)pictureBox3).set_Location(new Point(12, 150));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(460, 202));
		pictureBox3.set_TabIndex(7);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox3).add_Click((EventHandler)pictureBox3_Click_1);
		((Control)pictureBox4).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox4.BackgroundImage"));
		pictureBox4.set_ErrorImage((Image)null);
		pictureBox4.set_InitialImage((Image)null);
		((Control)pictureBox4).set_Location(new Point(23, 23));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(257, 116));
		pictureBox4.set_TabIndex(8);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox4).add_Click((EventHandler)pictureBox4_Click);
		((Control)pictureBox5).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox5.BackgroundImage"));
		pictureBox5.set_ErrorImage((Image)null);
		pictureBox5.set_InitialImage((Image)null);
		((Control)pictureBox5).set_Location(new Point(29, 30));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(27, 27));
		pictureBox5.set_TabIndex(9);
		pictureBox5.set_TabStop(false);
		((Control)pictureBox5).add_Click((EventHandler)pictureBox5_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.FromArgb(20, 20, 20));
		((Control)label3).set_Font(new Font("Verdana", 6.25f, (FontStyle)1));
		((Control)label3).set_ForeColor(Color.FromArgb(160, 200, 70));
		label3.set_ImageAlign((ContentAlignment)64);
		((Control)label3).set_Location(new Point(62, 30));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(169, 12));
		((Control)label3).set_TabIndex(10);
		((Control)label3).set_Text("Counter-Strike: Global Offensive");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.FromArgb(20, 20, 20));
		((Control)label4).set_Font(new Font("Verdana", 8f, (FontStyle)0, (GraphicsUnit)2));
		((Control)label4).set_ForeColor(Color.Gainsboro);
		label4.set_ImageAlign((ContentAlignment)64);
		((Control)label4).set_Location(new Point(62, 42));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(125, 10));
		((Control)label4).set_TabIndex(11);
		((Control)label4).set_Text("Updated 23.5.2020 12:25 AM");
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)pictureBox6).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox6.BackgroundImage"));
		pictureBox6.set_ErrorImage((Image)null);
		pictureBox6.set_InitialImage((Image)null);
		((Control)pictureBox6).set_Location(new Point(293, 21));
		((Control)pictureBox6).set_Name("pictureBox6");
		((Control)pictureBox6).set_Size(new Size(168, 118));
		pictureBox6.set_TabIndex(12);
		pictureBox6.set_TabStop(false);
		((Control)pictureBox6).add_Click((EventHandler)pictureBox6_Click);
		((Control)button2).set_BackColor(Color.FromArgb(50, 50, 50));
		((Control)button2).set_BackgroundImage((Image)componentResourceManager.GetObject("button2.BackgroundImage"));
		((Control)button2).set_BackgroundImageLayout((ImageLayout)0);
		((ButtonBase)button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button2).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(50, 50, 50));
		((ButtonBase)button2).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(50, 50, 50));
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_ForeColor(Color.Black);
		((Control)button2).set_Location(new Point(313, 48));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(128, 29));
		((Control)button2).set_TabIndex(14);
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)pictureBox7).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox7.BackgroundImage"));
		pictureBox7.set_ErrorImage((Image)null);
		pictureBox7.set_InitialImage((Image)null);
		((Control)pictureBox7).set_Location(new Point(39, 175));
		((Control)pictureBox7).set_Name("pictureBox7");
		((Control)pictureBox7).set_Size(new Size(402, 153));
		pictureBox7.set_TabIndex(20);
		pictureBox7.set_TabStop(false);
		((Control)pictureBox7).add_Click((EventHandler)pictureBox7_Click);
		((Control)button1).set_BackColor(Color.FromArgb(50, 50, 50));
		((Control)button1).set_BackgroundImage((Image)componentResourceManager.GetObject("button1.BackgroundImage"));
		((Control)button1).set_BackgroundImageLayout((ImageLayout)0);
		((ButtonBase)button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button1).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(50, 50, 50));
		((ButtonBase)button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(50, 50, 50));
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.Black);
		((Control)button1).set_Location(new Point(313, 83));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(128, 29));
		((Control)button1).set_TabIndex(26);
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click_1);
		((Control)pictureBox8).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox8.BackgroundImage"));
		pictureBox8.set_ErrorImage((Image)null);
		pictureBox8.set_InitialImage((Image)null);
		((Control)pictureBox8).set_Location(new Point(41, 222));
		((Control)pictureBox8).set_Name("pictureBox8");
		((Control)pictureBox8).set_Size(new Size(398, 14));
		pictureBox8.set_TabIndex(27);
		pictureBox8.set_TabStop(false);
		((Control)pictureBox8).add_Click((EventHandler)pictureBox8_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label5).set_Font(new Font("Verdana", 6.25f));
		((Control)label5).set_ForeColor(Color.Gainsboro);
		label5.set_ImageAlign((ContentAlignment)64);
		((Control)label5).set_Location(new Point(52, 178));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(59, 12));
		((Control)label5).set_TabIndex(31);
		((Control)label5).set_Text("Connected");
		((Control)label5).add_Click((EventHandler)label5_Click_2);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_BackColor(Color.FromArgb(18, 19, 17));
		((Control)label8).set_Font(new Font("Verdana", 6.25f, (FontStyle)1));
		((Control)label8).set_ForeColor(Color.FromArgb(160, 200, 70));
		label8.set_ImageAlign((ContentAlignment)64);
		((Control)label8).set_Location(new Point(52, 222));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(170, 12));
		((Control)label8).set_TabIndex(30);
		((Control)label8).set_Text("Your session expires in 3 minutes");
		((Control)label8).add_Click((EventHandler)label8_Click_1);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label7).set_Font(new Font("Verdana", 6.25f));
		((Control)label7).set_ForeColor(Color.Gainsboro);
		label7.set_ImageAlign((ContentAlignment)64);
		((Control)label7).set_Location(new Point(52, 208));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(309, 12));
		((Control)label7).set_TabIndex(29);
		((Control)label7).set_Text("Added Counter-Strike: Global Offensive (29 days remaining)");
		((Control)label7).add_Click((EventHandler)label7_Click_1);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_BackColor(Color.FromArgb(29, 30, 28));
		((Control)label6).set_Font(new Font("Verdana", 6.25f));
		((Control)label6).set_ForeColor(Color.Gainsboro);
		label6.set_ImageAlign((ContentAlignment)64);
		((Control)label6).set_Location(new Point(52, 193));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(133, 12));
		((Control)label6).set_TabIndex(28);
		((Control)label6).set_Text("Welcome back, ilum1nate");
		((Control)label6).add_Click((EventHandler)label6_Click_1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(5, 5, 5));
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(484, 364));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)pictureBox8);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox7);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox6);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox5);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_ForeColor(Color.FromArgb(255, 128, 128));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("s");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox7).EndInit();
		((ISupportInitialize)pictureBox8).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
