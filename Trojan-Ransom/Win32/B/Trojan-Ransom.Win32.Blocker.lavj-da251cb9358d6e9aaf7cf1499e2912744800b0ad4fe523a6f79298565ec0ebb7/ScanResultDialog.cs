using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class ScanResultDialog : Form
{
	private IContainer icontainer_0;

	private Label label1;

	private Panel panel1;

	private Label lblCompStatus;

	private Button button2;

	private Panel panel3;

	private Label label2;

	private PictureBox pictureBox4;

	private PictureBox pictureBox3;

	private Label label12;

	private Label label11;

	private Label label10;

	private Label label9;

	private PictureBox pictureBox2;

	private Label label4;

	private Label label3;

	private Label label5;

	private PictureBox pictureBox1;

	public ScanResultDialog()
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		label1 = new Label();
		panel1 = new Panel();
		lblCompStatus = new Label();
		button2 = new Button();
		panel3 = new Panel();
		label2 = new Label();
		pictureBox4 = new PictureBox();
		pictureBox3 = new PictureBox();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		pictureBox2 = new PictureBox();
		label4 = new Label();
		label3 = new Label();
		label5 = new Label();
		pictureBox1 = new PictureBox();
		((Control)panel1).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(475, 35));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(188, 50));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Scan Complete!\r\nInfections Found");
		((Control)panel1).set_BackgroundImage((Image)(object)Class3.smethod_23());
		((Control)panel1).get_Controls().Add((Control)(object)lblCompStatus);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(697, 26));
		((Control)panel1).set_TabIndex(3);
		((Control)panel1).add_Click((EventHandler)lblCompStatus_Click);
		((Control)lblCompStatus).set_AutoSize(true);
		((Control)lblCompStatus).set_BackColor(Color.Transparent);
		((Control)lblCompStatus).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCompStatus).set_ForeColor(Color.White);
		((Control)lblCompStatus).set_Location(new Point(19, 5));
		((Control)lblCompStatus).set_Name("lblCompStatus");
		((Control)lblCompStatus).set_Size(new Size(459, 16));
		((Control)lblCompStatus).set_TabIndex(0);
		((Control)lblCompStatus).set_Text("Computer Status - Unprotected! Click here to protect your computer.");
		((Control)lblCompStatus).add_Click((EventHandler)lblCompStatus_Click);
		((Control)button2).set_BackColor(Color.Transparent);
		((Control)button2).set_BackgroundImage((Image)(object)Class3.smethod_7());
		((Control)button2).set_Font(new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.Transparent);
		((Control)button2).set_Location(new Point(462, 221));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(219, 49));
		((Control)button2).set_TabIndex(21);
		((Control)button2).set_Text("Activate now");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)panel3).set_BackColor(Color.White);
		((Control)panel3).get_Controls().Add((Control)(object)label2);
		((Control)panel3).get_Controls().Add((Control)(object)pictureBox4);
		((Control)panel3).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panel3).get_Controls().Add((Control)(object)label12);
		((Control)panel3).get_Controls().Add((Control)(object)label11);
		((Control)panel3).get_Controls().Add((Control)(object)label10);
		((Control)panel3).get_Controls().Add((Control)(object)label9);
		((Control)panel3).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel3).get_Controls().Add((Control)(object)label4);
		((Control)panel3).get_Controls().Add((Control)(object)label3);
		((Control)panel3).get_Controls().Add((Control)(object)label5);
		((Control)panel3).set_Location(new Point(22, 37));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(429, 224));
		((Control)panel3).set_TabIndex(22);
		((Control)panel3).add_Paint(new PaintEventHandler(panel3_Paint));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(28, 71, 126));
		((Control)label2).set_Location(new Point(21, 11));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(222, 19));
		((Control)label2).set_TabIndex(29);
		((Control)label2).set_Text("Key Features and Benefits");
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
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_ForeColor(SystemColors.ControlText);
		((Control)label5).set_Location(new Point(56, 48));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(237, 13));
		((Control)label5).set_TabIndex(19);
		((Control)label5).set_Text("Real-time protection against viruses and spyware");
		pictureBox1.set_Image((Image)(object)Class3.smethod_24());
		((Control)pictureBox1).set_Location(new Point(497, 90));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(142, 125));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(23);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(697, 293));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ScanResultDialog");
		((Control)this).set_Text("Scan Results");
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void lblCompStatus_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
	}

	private void panel3_Paint(object sender, PaintEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Pen val = new Pen(Color.FromArgb(207, 207, 207));
		e.get_Graphics().DrawRectangle(val, e.get_ClipRectangle().Left, e.get_ClipRectangle().Top, e.get_ClipRectangle().Width - 1, e.get_ClipRectangle().Height - 1);
		((Form)this).OnPaint(e);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		ActivateForm activateForm = new ActivateForm();
		((Control)activateForm).Show();
	}
}
