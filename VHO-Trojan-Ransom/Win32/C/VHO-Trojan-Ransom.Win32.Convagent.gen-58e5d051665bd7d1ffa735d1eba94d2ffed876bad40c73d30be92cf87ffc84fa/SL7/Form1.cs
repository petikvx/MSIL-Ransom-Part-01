using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SL7;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox Username_txt;

	private TextBox Password_txt;

	private Button button1;

	private Button button2;

	private Label label3;

	private Timer timer1;

	private Label label4;

	private Label label5;

	private Timer timer2;

	private Timer timer3;

	private Button button3;

	public Form1()
	{
		InitializeComponent();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)Username_txt).get_Text() == "SL7")
		{
			if (((Control)Password_txt).get_Text() == "SL7")
			{
				((Control)new Main()).Show();
				MessageBox.Show("FREE TRIAL");
				((Control)this).Hide();
			}
			else
			{
				MessageBox.Show("Error: Please Check Username And Password!");
			}
		}
		else
		{
			MessageBox.Show("Error: Please Check Username And Password!");
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		int alpha = random.Next(0, 255);
		int red = random.Next(0, 255);
		int green = random.Next(0, 255);
		int blue = random.Next(0, 255);
		((Control)label3).set_ForeColor(Color.FromArgb(alpha, red, green, blue));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		new Random();
		timer1.Start();
		timer1.set_Interval(200);
		new Random();
		timer2.Start();
		timer2.set_Interval(200);
		new Random();
		timer3.Start();
		timer3.set_Interval(200);
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		int alpha = random.Next(0, 255);
		int red = random.Next(0, 255);
		int green = random.Next(0, 255);
		int blue = random.Next(0, 255);
		((Control)label4).set_ForeColor(Color.FromArgb(alpha, red, green, blue));
		timer2.Start();
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		int alpha = random.Next(0, 255);
		int red = random.Next(0, 255);
		int green = random.Next(0, 255);
		int blue = random.Next(0, 255);
		((Control)label5).set_ForeColor(Color.FromArgb(alpha, red, green, blue));
		timer3.Start();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		((Control)new Choose()).Show();
		MessageBox.Show("$5 to buy (Tetunus,Ghost,Simba Are WHITELISTED)");
		((Control)this).Hide();
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		Username_txt = new TextBox();
		Password_txt = new TextBox();
		button1 = new Button();
		button2 = new Button();
		label3 = new Label();
		timer1 = new Timer(components);
		label4 = new Label();
		label5 = new Label();
		timer2 = new Timer(components);
		timer3 = new Timer(components);
		button3 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label1).set_Location(new Point(0, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(55, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Username");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label2).set_Location(new Point(326, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Password");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)Username_txt).set_Location(new Point(3, 25));
		((Control)Username_txt).set_Name("Username_txt");
		((Control)Username_txt).set_Size(new Size(100, 20));
		((Control)Username_txt).set_TabIndex(2);
		((Control)Password_txt).set_Location(new Point(279, 25));
		((Control)Password_txt).set_Name("Password_txt");
		((Control)Password_txt).set_Size(new Size(100, 20));
		((Control)Password_txt).set_TabIndex(3);
		((Control)Password_txt).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)button1).set_BackColor(SystemColors.WindowFrame);
		((Control)button1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)button1).set_Location(new Point(154, 4));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("Login");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_BackColor(SystemColors.WindowFrame);
		((Control)button2).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)button2).set_Location(new Point(154, 33));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("Exit");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(SystemColors.GrayText);
		((Control)label3).set_Location(new Point(119, 76));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(141, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("OWNER: SimbaRayGun115");
		((Control)label3).add_Click((EventHandler)label3_Click);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_ForeColor(SystemColors.AppWorkspace);
		((Control)label4).set_Location(new Point(20, 65));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(73, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("BAE: Tetunus");
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_ForeColor(SystemColors.AppWorkspace);
		((Control)label5).set_Location(new Point(293, 64));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(91, 13));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("BAE: GhostWeed");
		((Control)label5).add_Click((EventHandler)label5_Click);
		timer2.add_Tick((EventHandler)timer2_Tick);
		timer3.add_Tick((EventHandler)timer3_Tick);
		((Control)button3).set_Location(new Point(304, 80));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(9);
		((Control)button3).set_Text("Custom");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(382, 107));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)Password_txt);
		((Control)this).get_Controls().Add((Control)(object)Username_txt);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("SL7");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
