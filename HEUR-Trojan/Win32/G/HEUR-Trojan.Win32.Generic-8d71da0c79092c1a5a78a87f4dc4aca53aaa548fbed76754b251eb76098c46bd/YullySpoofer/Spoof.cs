using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Properties;

namespace YullySpoofer;

public class Spoof : Form
{
	private int w = Screen.get_PrimaryScreen().get_Bounds().Width;

	private int h = Screen.get_PrimaryScreen().get_Bounds().Height;

	private IContainer components = null;

	private Timer timer1;

	private Timer timer2;

	private Timer fadeOutTimer;

	private Timer fadeInTimer;

	private Timer timer3;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private Guna2ProgressBar guna2ProgressBar1;

	private Guna2ProgressBar guna2ProgressBar2;

	private Timer timer4;

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern void BlockInput([In][MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

	[DllImport("Gdi32.dll")]
	private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

	public Spoof()
	{
		InitializeComponent();
	}

	private void Spoof_Load(object sender, EventArgs e)
	{
		fadeOutTimer.set_Enabled(false);
		fadeInTimer.set_Enabled(true);
		timer1.Start();
		((Form)this).set_Location(new Point(0, 0));
		((Form)this).set_Size(new Size(w, h));
		BlockInput(fBlockIt: true);
		Cursor.Hide();
		timer4.Start();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
	}

	private void fadeInTimer_Tick(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(((Form)this).get_Opacity() + 0.025);
		if (((Form)this).get_Opacity() >= 1.0)
		{
			fadeInTimer.Stop();
		}
	}

	private void fadeOutTimer_Tick(object sender, EventArgs e)
	{
		if (((Form)this).get_Opacity() == 1.0)
		{
			fadeOutTimer.Stop();
		}
		((Form)this).set_Opacity(((Form)this).get_Opacity() + 0.2);
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		Guna2ProgressBar obj = guna2ProgressBar1;
		obj.set_Value(obj.get_Value() + 1);
		if (guna2ProgressBar1.get_Value() >= 15)
		{
			((Control)label4).set_Text("Spoofing Cpu...");
			BlockInput(fBlockIt: true);
		}
		if (guna2ProgressBar1.get_Value() >= 25)
		{
			((Control)label5).set_Text("Spoofing Bios...");
			BlockInput(fBlockIt: true);
		}
		if (guna2ProgressBar1.get_Value() >= 35)
		{
			((Control)label6).set_Text("Spoofing BaseBoard...");
			BlockInput(fBlockIt: true);
		}
		if (guna2ProgressBar1.get_Value() >= 50)
		{
			((Control)label7).set_Text("Spoofing VolumeID...");
			BlockInput(fBlockIt: true);
		}
		if (guna2ProgressBar1.get_Value() >= 150)
		{
			((Control)label8).set_Text("Succesfully Spoofed");
			BlockInput(fBlockIt: true);
		}
		if (guna2ProgressBar1.get_Value() == 250)
		{
			((Control)label8).set_Text("Closing...");
			timer3.set_Enabled(false);
			BlockInput(fBlockIt: false);
			Cursor.Show();
			fadeOutTimer.set_Enabled(false);
			((Form)this).Close();
		}
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		Guna2ProgressBar obj = guna2ProgressBar1;
		obj.set_Value(obj.get_Value() + 1);
		if (guna2ProgressBar2.get_Value() >= 50)
		{
			Driver.SpoofVolumeID();
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
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Spoof));
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		fadeOutTimer = new Timer(components);
		fadeInTimer = new Timer(components);
		timer3 = new Timer(components);
		pictureBox2 = new PictureBox();
		pictureBox3 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		guna2ProgressBar1 = new Guna2ProgressBar();
		guna2ProgressBar2 = new Guna2ProgressBar();
		timer4 = new Timer(components);
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.add_Tick((EventHandler)timer2_Tick);
		fadeOutTimer.set_Enabled(true);
		fadeOutTimer.set_Interval(20);
		fadeOutTimer.add_Tick((EventHandler)fadeOutTimer_Tick);
		fadeInTimer.set_Enabled(true);
		fadeInTimer.set_Interval(10);
		fadeInTimer.add_Tick((EventHandler)fadeInTimer_Tick);
		timer3.set_Enabled(true);
		timer3.add_Tick((EventHandler)timer3_Tick);
		pictureBox2.set_Image((Image)(object)Resources.logo);
		((Control)pictureBox2).set_Location(new Point(790, 280));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(322, 297));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		pictureBox3.set_Image((Image)(object)Resources.loading_2c3a6d2a99277f9fe6d59a_unscreen);
		((Control)pictureBox3).set_Location(new Point(866, 552));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(203, 153));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox3.set_TabIndex(2);
		pictureBox3.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)label1).set_Location(new Point(704, 508));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(542, 30));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Please wait a few seconds while we are spofing your PC...");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Green);
		((Control)label2).set_Location(new Point(13, 32));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(273, 20));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("--------------------------------------------");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Green);
		((Control)label3).set_Location(new Point(51, 14));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(176, 17));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Yully Spoofer | Hwid Spoofer");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Yu Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(14, 65));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(0, 16));
		((Control)label4).set_TabIndex(6);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Yu Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(14, 90));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(0, 16));
		((Control)label5).set_TabIndex(7);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Yu Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.White);
		((Control)label6).set_Location(new Point(14, 116));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(0, 16));
		((Control)label6).set_TabIndex(8);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Yu Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.White);
		((Control)label7).set_Location(new Point(14, 142));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(0, 16));
		((Control)label7).set_TabIndex(9);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Yu Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.White);
		((Control)label8).set_Location(new Point(14, 170));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(0, 16));
		((Control)label8).set_TabIndex(10);
		guna2ProgressBar1.set_BorderColor(Color.FromArgb(4, 4, 4));
		guna2ProgressBar1.set_FillColor(Color.FromArgb(4, 4, 4));
		((Control)guna2ProgressBar1).set_ForeColor(Color.FromArgb(4, 4, 4));
		((Control)guna2ProgressBar1).set_Location(new Point(-307, 204));
		guna2ProgressBar1.set_Maximum(250);
		((Control)guna2ProgressBar1).set_Name("guna2ProgressBar1");
		guna2ProgressBar1.set_ProgressColor(Color.FromArgb(4, 4, 4));
		guna2ProgressBar1.set_ProgressColor2(Color.FromArgb(4, 4, 4));
		guna2ProgressBar1.get_ShadowDecoration().set_Color(Color.FromArgb(4, 4, 4));
		((Control)guna2ProgressBar1).set_Size(new Size(304, 30));
		((Control)guna2ProgressBar1).set_TabIndex(11);
		((Control)guna2ProgressBar1).set_Text("guna2ProgressBar1");
		guna2ProgressBar1.set_TextRenderingHint((TextRenderingHint)0);
		guna2ProgressBar2.set_BorderColor(Color.FromArgb(4, 4, 4));
		guna2ProgressBar2.set_FillColor(Color.FromArgb(4, 4, 4));
		((Control)guna2ProgressBar2).set_ForeColor(Color.FromArgb(4, 4, 4));
		((Control)guna2ProgressBar2).set_Location(new Point(-308, 534));
		guna2ProgressBar2.set_Maximum(50);
		((Control)guna2ProgressBar2).set_Name("guna2ProgressBar2");
		guna2ProgressBar2.set_ProgressColor(Color.FromArgb(4, 4, 4));
		guna2ProgressBar2.set_ProgressColor2(Color.FromArgb(4, 4, 4));
		guna2ProgressBar2.get_ShadowDecoration().set_Color(Color.FromArgb(4, 4, 4));
		((Control)guna2ProgressBar2).set_Size(new Size(304, 30));
		((Control)guna2ProgressBar2).set_TabIndex(12);
		((Control)guna2ProgressBar2).set_Text("guna2ProgressBar2");
		guna2ProgressBar2.set_TextRenderingHint((TextRenderingHint)0);
		timer4.set_Enabled(true);
		timer4.add_Tick((EventHandler)timer4_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(4, 4, 4));
		((Form)this).set_ClientSize(new Size(1920, 1080));
		((Control)this).get_Controls().Add((Control)(object)guna2ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)guna2ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Spoof");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Spoof");
		((Form)this).add_Load((EventHandler)Spoof_Load);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
