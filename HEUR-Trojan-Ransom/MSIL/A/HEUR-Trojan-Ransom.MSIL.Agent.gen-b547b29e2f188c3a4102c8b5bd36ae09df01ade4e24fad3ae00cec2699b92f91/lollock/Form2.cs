using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lollock;

public class Form2 : Form
{
	private IContainer components;

	private Label label1;

	private Timer timer1;

	private Label label2;

	private Timer timer2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Button button1;

	private TextBox textBox1;

	private PictureBox pictureBox1;

	public Form2()
	{
		InitializeComponent();
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		((Control)label2).set_Visible(false);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Control)label2).set_Visible(true);
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
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		label1 = new Label();
		timer1 = new Timer(components);
		label2 = new Label();
		timer2 = new Timer(components);
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		button1 = new Button();
		textBox1 = new TextBox();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Calibri", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(288, 33));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Backdoor Session Started");
		timer1.set_Enabled(true);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Calibri", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(293, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(28, 33));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("_");
		timer2.set_Enabled(true);
		timer2.set_Interval(200);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Calibri", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.LimeGreen);
		((Control)label3).set_Location(new Point(12, 42));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(211, 75));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Started backdoor session...\r\n[+] Spreaded new victim eternalblue...\r\n[+] Opening the ransom lock...\r\n[+] Work lock.\r\n[+] Open secret GUI to victim...");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Calibri", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Red);
		((Control)label4).set_Location(new Point(52, 133));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(227, 15));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("Your files has encypted heres the details");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Calibri", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(11, 156));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(385, 255));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text(componentResourceManager.GetString("label5.Text"));
		((Control)button1).set_Font(new Font("Segoe UI Symbol", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(769, 377));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 27));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("Unlock");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)textBox1).set_Location(new Point(402, 377));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(361, 27));
		((Control)textBox1).set_TabIndex(7);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(402, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(442, 349));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(8);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 19f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(856, 416));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Font(new Font("Segoe Print", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(Color.Lime);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(3, 4, 3, 4));
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Error");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
