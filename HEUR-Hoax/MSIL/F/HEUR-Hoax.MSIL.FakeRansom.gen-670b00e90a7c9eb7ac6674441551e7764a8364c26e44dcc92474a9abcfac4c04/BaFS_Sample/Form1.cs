using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace BaFS_Sample;

public class Form1 : Form
{
	private DateTime countDown = new DateTime(2016, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified);

	private CultureInfo ci = CultureInfo.InvariantCulture;

	private IContainer components;

	private PictureBox pictureBox1;

	private Timer progressBarTimer;

	private Button button1;

	private Label label1;

	private Label label2;

	public ProgressBar progressBar1;

	private Timer countdowntimer;

	private Label label3;

	private Button button2;

	private Button button3;

	private TextBox textBox1;

	public Form1()
	{
		InitializeComponent();
		((Control)label2).set_Text("Encrypting Hard Drive");
		progressBarTimer.add_Tick((EventHandler)timer1_tick);
		progressBarTimer.set_Interval(100);
		progressBarTimer.set_Enabled(true);
		progressBarTimer.Start();
		countDown.AddHours(24.0);
		((Control)label1).set_Text(countDown.ToString("HH:mm:ss", ci));
		((Control)label1).Update();
		countdowntimer.add_Tick((EventHandler)timer2_tick);
		countdowntimer.set_Interval(10);
		countdowntimer.set_Enabled(true);
		countdowntimer.Start();
		progressBar1.set_Minimum(1);
		progressBar1.set_Maximum(1000);
		progressBar1.set_Step(1);
	}

	private void timer1_tick(object sender, EventArgs e)
	{
		progressBar1.PerformStep();
	}

	private void timer2_tick(object sender, EventArgs e)
	{
		countDown = countDown.AddMilliseconds(-7.0);
		((Control)label1).set_Text(countDown.ToString("HH:mm:ss", ci));
		((Control)label1).Update();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("This is just a demo file, not actual malware!", "DEMO FILE");
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void progressBar1_Click(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Process.Start(new ProcessStartInfo("https://demo.wd.microsoft.com/"));
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
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
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		pictureBox1 = new PictureBox();
		progressBarTimer = new Timer(components);
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		progressBar1 = new ProgressBar();
		countdowntimer = new Timer(components);
		label3 = new Label();
		button2 = new Button();
		button3 = new Button();
		textBox1 = new TextBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(340, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(303, 434));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		progressBarTimer.set_Enabled(true);
		progressBarTimer.set_Interval(5000);
		progressBarTimer.add_Tick((EventHandler)timer1_tick);
		((Control)button1).set_BackColor(Color.SeaShell);
		((ButtonBase)button1).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)button1).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(255, 255, 192));
		((Control)button1).set_Location(new Point(222, 408));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(93, 38));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Pay Now");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Black);
		((Control)label1).set_Font(new Font("Consolas", 26.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(10, 52));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(170, 41));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("24:00:00");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Black);
		((Control)label2).set_Font(new Font("Consolas", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(12, 152));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(77, 28));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Label");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)progressBar1).set_ForeColor(Color.Red);
		((Control)progressBar1).set_Location(new Point(17, 183));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(251, 23));
		progressBar1.set_Step(1);
		((Control)progressBar1).set_TabIndex(4);
		((Control)progressBar1).add_Click((EventHandler)progressBar1_Click);
		countdowntimer.add_Tick((EventHandler)timer2_tick);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Black);
		((Control)label3).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(14, 24));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(301, 15));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Your files will be permanently deleted in:");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)button2).set_BackColor(Color.SeaShell);
		((ButtonBase)button2).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)button2).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(255, 255, 192));
		((Control)button2).set_Location(new Point(17, 408));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(93, 38));
		((Control)button2).set_TabIndex(6);
		((Control)button2).set_Text("Contact Us");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_BackColor(Color.SeaShell);
		((ButtonBase)button3).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)button3).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(255, 255, 192));
		((Control)button3).set_Location(new Point(17, 222));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(83, 23));
		((Control)button3).set_TabIndex(7);
		((Control)button3).set_Text("Decrypt Files");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)textBox1).set_BackColor(Color.Black);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Red);
		((Control)textBox1).set_Location(new Point(17, 251));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(208, 63));
		((Control)textBox1).set_TabIndex(8);
		((Control)textBox1).set_Text("Requires encryption key. Click \"Pay Now\" to buy your key.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(655, 474));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("File \"Protection\" Service 2018");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
