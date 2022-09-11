using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SL7;

public class Main : Form
{
	private IContainer components = null;

	private TextBox TextBox;

	private Button Com;

	private Button Exe;

	private Button Clear;

	private Timer timer1;

	private Timer timer2;

	private Timer timer3;

	private Timer timer4;

	private PictureBox pictureBox1;

	public Main()
	{
		InitializeComponent();
	}

	private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		int alpha = random.Next(0, 255);
		int red = random.Next(0, 255);
		int green = random.Next(0, 255);
		int blue = random.Next(0, 255);
		((Control)Com).set_ForeColor(Color.FromArgb(alpha, red, green, blue));
		timer1.Start();
	}

	private void Main_Load(object sender, EventArgs e)
	{
		new Random();
		timer2.Start();
		timer2.set_Interval(200);
		new Random();
		timer1.Start();
		timer1.set_Interval(200);
		new Random();
		timer3.Start();
		timer3.set_Interval(200);
		new Random();
		timer4.Start();
		timer4.set_Interval(200);
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		int alpha = random.Next(0, 255);
		int red = random.Next(0, 255);
		int green = random.Next(0, 255);
		int blue = random.Next(0, 255);
		((Control)Exe).set_ForeColor(Color.FromArgb(alpha, red, green, blue));
		timer2.Start();
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		int alpha = random.Next(0, 255);
		int red = random.Next(0, 255);
		int green = random.Next(0, 255);
		int blue = random.Next(0, 255);
		((Control)Clear).set_ForeColor(Color.FromArgb(alpha, red, green, blue));
		timer3.Start();
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		int alpha = random.Next(0, 255);
		int red = random.Next(0, 255);
		int green = random.Next(0, 255);
		int blue = random.Next(0, 255);
		((Control)TextBox).set_ForeColor(Color.FromArgb(alpha, red, green, blue));
		timer4.Start();
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
		TextBox = new TextBox();
		Com = new Button();
		Exe = new Button();
		Clear = new Button();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		timer3 = new Timer(components);
		timer4 = new Timer(components);
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TextBox).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)TextBox).set_Location(new Point(12, 12));
		((TextBoxBase)TextBox).set_Multiline(true);
		((Control)TextBox).set_Name("TextBox");
		TextBox.set_ScrollBars((ScrollBars)3);
		((Control)TextBox).set_Size(new Size(510, 281));
		((Control)TextBox).set_TabIndex(0);
		((Control)TextBox).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)Com).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)Com).set_ForeColor(SystemColors.GrayText);
		((Control)Com).set_Location(new Point(12, 319));
		((Control)Com).set_Name("Com");
		((Control)Com).set_Size(new Size(171, 57));
		((Control)Com).set_TabIndex(1);
		((Control)Com).set_Text("Commands");
		((ButtonBase)Com).set_UseVisualStyleBackColor(false);
		((Control)Com).add_Click((EventHandler)button1_Click);
		((Control)Exe).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)Exe).set_ForeColor(SystemColors.GrayText);
		((Control)Exe).set_Location(new Point(189, 319));
		((Control)Exe).set_Name("Exe");
		((Control)Exe).set_Size(new Size(170, 57));
		((Control)Exe).set_TabIndex(2);
		((Control)Exe).set_Text("Execute");
		((ButtonBase)Exe).set_UseVisualStyleBackColor(false);
		((Control)Exe).add_Click((EventHandler)button2_Click);
		((Control)Clear).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)Clear).set_ForeColor(SystemColors.GrayText);
		((Control)Clear).set_Location(new Point(365, 319));
		((Control)Clear).set_Name("Clear");
		((Control)Clear).set_Size(new Size(170, 54));
		((Control)Clear).set_TabIndex(3);
		((Control)Clear).set_Text("Clear");
		((ButtonBase)Clear).set_UseVisualStyleBackColor(false);
		((Control)Clear).add_Click((EventHandler)button3_Click);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.add_Tick((EventHandler)timer2_Tick);
		timer3.add_Tick((EventHandler)timer3_Tick);
		timer4.add_Tick((EventHandler)timer4_Tick);
		((Control)pictureBox1).set_BackColor(SystemColors.ScrollBar);
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_Location(new Point(238, 393));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(57, 39));
		pictureBox1.set_TabIndex(4);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.WindowFrame);
		((Form)this).set_ClientSize(new Size(534, 428));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Clear);
		((Control)this).get_Controls().Add((Control)(object)Exe);
		((Control)this).get_Controls().Add((Control)(object)Com);
		((Control)this).get_Controls().Add((Control)(object)TextBox);
		((Control)this).set_ForeColor(SystemColors.WindowFrame);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Main");
		((Control)this).set_Text("SL7");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Main_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
