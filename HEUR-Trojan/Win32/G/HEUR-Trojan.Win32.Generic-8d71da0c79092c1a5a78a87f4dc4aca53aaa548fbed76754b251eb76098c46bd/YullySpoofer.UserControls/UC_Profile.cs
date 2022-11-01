using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Properties;

namespace YullySpoofer.UserControls;

public class UC_Profile : UserControl
{
	private IContainer components = null;

	private Panel panel1;

	private Guna2Button guna2Button1;

	private Label lastLogin;

	private Label expiry;

	private Label hwid;

	private Label username;

	private Label label1;

	private Panel panel2;

	private Label label8;

	private RichTextBox richTextBox1;

	private Guna2Button guna2Button2;

	public UC_Profile()
	{
		InitializeComponent();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	public DateTime UnixTimeToDateTime(long unixtime)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(unixtime).ToLocalTime();
	}

	private void guna2Button1_Click(object sender, EventArgs e)
	{
		try
		{
			HardwareReset.ResetUser();
			((TextBoxBase)richTextBox1).AppendText($"  [+] Succesfull Reseted HardwareID\n");
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			string[] array = new string[6] { "ERROR MESSAGE : ", ex2.Message, " | LINE OF CODE : ", ex2.Source, " ", null };
			((TextBoxBase)richTextBox1).AppendText($"  [-] Error on resetting HardwareID");
			MethodBase targetSite = ex2.TargetSite;
			string text = (array[5] = ((!(targetSite != null)) ? null : targetSite.ToString()));
			OnlineErrorReport.SendException(string.Concat(array), Severe: true);
		}
	}

	private void UC_Profile_Load(object sender, EventArgs e)
	{
		((Control)hwid).set_Text("Hwid: " + Program.KeyAuthApp.user_data.hwid);
		((Control)expiry).set_Text("Expiry: " + UnixTimeToDateTime(long.Parse(Program.KeyAuthApp.user_data.subscriptions[0].expiry)));
		((Control)lastLogin).set_Text("Last login: " + UnixTimeToDateTime(long.Parse(Program.KeyAuthApp.user_data.lastlogin)));
		((Control)username).set_Text("Username: " + Program.KeyAuthApp.user_data.username);
		((TextBoxBase)richTextBox1).AppendText($"  [+] Succesfull Loaded Winform\n");
	}

	private void guna2Button2_Click(object sender, EventArgs e)
	{
		((Control)hwid).set_Text("Hwid: " + Program.KeyAuthApp.user_data.hwid);
		((Control)expiry).set_Text("Expiry: " + UnixTimeToDateTime(long.Parse(Program.KeyAuthApp.user_data.subscriptions[0].expiry)));
		((Control)lastLogin).set_Text("Last login: " + UnixTimeToDateTime(long.Parse(Program.KeyAuthApp.user_data.lastlogin)));
		((Control)username).set_Text("Username: " + Program.KeyAuthApp.user_data.username);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
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
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected O, but got Unknown
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected O, but got Unknown
		panel1 = new Panel();
		lastLogin = new Label();
		expiry = new Label();
		hwid = new Label();
		username = new Label();
		label1 = new Label();
		panel2 = new Panel();
		label8 = new Label();
		richTextBox1 = new RichTextBox();
		guna2Button1 = new Guna2Button();
		guna2Button2 = new Guna2Button();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)panel1).get_Controls().Add((Control)(object)guna2Button2);
		((Control)panel1).get_Controls().Add((Control)(object)guna2Button1);
		((Control)panel1).get_Controls().Add((Control)(object)lastLogin);
		((Control)panel1).get_Controls().Add((Control)(object)expiry);
		((Control)panel1).get_Controls().Add((Control)(object)hwid);
		((Control)panel1).get_Controls().Add((Control)(object)username);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Location(new Point(69, 21));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(534, 241));
		((Control)panel1).set_TabIndex(7);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)lastLogin).set_AutoSize(true);
		((Control)lastLogin).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lastLogin).set_ForeColor(Color.FromArgb(127, 60, 126));
		((Control)lastLogin).set_Location(new Point(32, 101));
		((Control)lastLogin).set_Name("lastLogin");
		((Control)lastLogin).set_Size(new Size(70, 17));
		((Control)lastLogin).set_TabIndex(5);
		((Control)lastLogin).set_Text("Last Login:");
		((Control)expiry).set_AutoSize(true);
		((Control)expiry).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)expiry).set_ForeColor(Color.FromArgb(127, 60, 126));
		((Control)expiry).set_Location(new Point(32, 79));
		((Control)expiry).set_Name("expiry");
		((Control)expiry).set_Size(new Size(46, 17));
		((Control)expiry).set_TabIndex(4);
		((Control)expiry).set_Text("Expiry:");
		((Control)hwid).set_AutoSize(true);
		((Control)hwid).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)hwid).set_ForeColor(Color.FromArgb(127, 60, 126));
		((Control)hwid).set_Location(new Point(32, 58));
		((Control)hwid).set_Name("hwid");
		((Control)hwid).set_Size(new Size(44, 17));
		((Control)hwid).set_TabIndex(3);
		((Control)hwid).set_Text("HWID:");
		((Control)username).set_AutoSize(true);
		((Control)username).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)username).set_ForeColor(Color.FromArgb(127, 60, 126));
		((Control)username).set_Location(new Point(32, 39));
		((Control)username).set_Name("username");
		((Control)username).set_Size(new Size(70, 17));
		((Control)username).set_TabIndex(1);
		((Control)username).set_Text("Username:");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(126, 65, 146));
		((Control)label1).set_Location(new Point(14, 11));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(101, 17));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Profile/Control");
		((Control)panel2).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)panel2).get_Controls().Add((Control)(object)richTextBox1);
		((Control)panel2).get_Controls().Add((Control)(object)label8);
		((Control)panel2).set_Location(new Point(69, 268));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(534, 178));
		((Control)panel2).set_TabIndex(10);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.FromArgb(126, 65, 146));
		((Control)label8).set_Location(new Point(14, 11));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(71, 17));
		((Control)label8).set_TabIndex(0);
		((Control)label8).set_Text("Yully Logs");
		((Control)richTextBox1).set_BackColor(Color.FromArgb(14, 14, 14));
		((TextBoxBase)richTextBox1).set_BorderStyle((BorderStyle)0);
		((Control)richTextBox1).set_Font(new Font("Segoe UI Semibold", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_ForeColor(Color.FromArgb(192, 0, 192));
		((Control)richTextBox1).set_Location(new Point(17, 40));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(500, 121));
		((Control)richTextBox1).set_TabIndex(2);
		((Control)richTextBox1).set_Text("");
		guna2Button1.set_Animated(true);
		((Control)guna2Button1).set_BackColor(Color.Transparent);
		guna2Button1.set_BorderColor(Color.FromArgb(10, 10, 10));
		guna2Button1.set_BorderRadius(2);
		guna2Button1.set_BorderThickness(1);
		guna2Button1.get_CheckedState().set_FillColor(Color.FromArgb(14, 14, 14));
		guna2Button1.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button1.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button1.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button1.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button1.set_FillColor(Color.FromArgb(14, 14, 14));
		((Control)guna2Button1).set_Font(new Font("Segoe UI", 9f));
		((Control)guna2Button1).set_ForeColor(Color.Gray);
		guna2Button1.get_HoverState().set_FillColor(Color.FromArgb(14, 14, 14));
		guna2Button1.set_Image((Image)(object)Resources.Neues_Projekt2);
		guna2Button1.set_ImageOffset(new Point(-89, -1));
		guna2Button1.set_ImageSize(new Size(23, 23));
		((Control)guna2Button1).set_Location(new Point(17, 190));
		((Control)guna2Button1).set_Name("guna2Button1");
		((Control)guna2Button1).set_Size(new Size(500, 34));
		((Control)guna2Button1).set_TabIndex(7);
		((Control)guna2Button1).set_Text("Reset HardwareID");
		guna2Button1.set_TextOffset(new Point(-87, -1));
		((Control)guna2Button1).add_Click((EventHandler)guna2Button1_Click);
		guna2Button2.set_Animated(true);
		((Control)guna2Button2).set_BackColor(Color.Transparent);
		guna2Button2.set_BorderColor(Color.FromArgb(10, 10, 10));
		guna2Button2.set_BorderRadius(2);
		guna2Button2.set_BorderThickness(1);
		guna2Button2.get_CheckedState().set_FillColor(Color.FromArgb(14, 14, 14));
		guna2Button2.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button2.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button2.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button2.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button2.set_FillColor(Color.FromArgb(14, 14, 14));
		((Control)guna2Button2).set_Font(new Font("Segoe UI", 9f));
		((Control)guna2Button2).set_ForeColor(Color.Gray);
		guna2Button2.get_HoverState().set_FillColor(Color.FromArgb(14, 14, 14));
		guna2Button2.set_ImageOffset(new Point(-89, -1));
		guna2Button2.set_ImageSize(new Size(23, 23));
		((Control)guna2Button2).set_Location(new Point(17, 150));
		((Control)guna2Button2).set_Name("guna2Button2");
		((Control)guna2Button2).set_Size(new Size(500, 34));
		((Control)guna2Button2).set_TabIndex(8);
		((Control)guna2Button2).set_Text("Refresh");
		guna2Button2.set_TextOffset(new Point(-220, -1));
		((Control)guna2Button2).add_Click((EventHandler)guna2Button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("UC_Profile");
		((Control)this).set_Size(new Size(690, 574));
		((UserControl)this).add_Load((EventHandler)UC_Profile_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
