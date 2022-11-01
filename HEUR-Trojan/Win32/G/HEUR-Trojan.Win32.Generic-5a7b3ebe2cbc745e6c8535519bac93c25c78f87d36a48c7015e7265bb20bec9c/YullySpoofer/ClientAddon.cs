using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;

namespace YullySpoofer;

public class ClientAddon : Form
{
	private IContainer components;

	private GunaElipsePanel gunaElipsePanel3;

	private Label label1;

	private Label label2;

	private Label label3;

	private SiticoneSeparator siticoneSeparator1;

	private SiticoneSeparator siticoneSeparator2;

	private SiticoneButton siticoneButton8;

	private Label label4;

	private Label Logs;

	public ClientAddon()
	{
		InitializeComponent();
	}

	private void ClientAddon_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DllImport("DwmApi")]
	private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ClientAddon));
		gunaElipsePanel3 = new GunaElipsePanel();
		label4 = new Label();
		Logs = new Label();
		siticoneButton8 = new SiticoneButton();
		siticoneSeparator2 = new SiticoneSeparator();
		label3 = new Label();
		siticoneSeparator1 = new SiticoneSeparator();
		label1 = new Label();
		label2 = new Label();
		((Control)gunaElipsePanel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((ScrollableControl)gunaElipsePanel3).set_AutoScroll(true);
		((Control)gunaElipsePanel3).set_BackColor(Color.Transparent);
		gunaElipsePanel3.set_BaseColor(Color.FromArgb(10, 10, 10));
		((Control)gunaElipsePanel3).get_Controls().Add((Control)(object)label4);
		((Control)gunaElipsePanel3).get_Controls().Add((Control)(object)Logs);
		((Control)gunaElipsePanel3).get_Controls().Add((Control)(object)siticoneButton8);
		((Control)gunaElipsePanel3).get_Controls().Add((Control)(object)siticoneSeparator2);
		((Control)gunaElipsePanel3).get_Controls().Add((Control)(object)label3);
		((Control)gunaElipsePanel3).get_Controls().Add((Control)(object)siticoneSeparator1);
		((Control)gunaElipsePanel3).get_Controls().Add((Control)(object)label1);
		((Control)gunaElipsePanel3).get_Controls().Add((Control)(object)label2);
		((Control)gunaElipsePanel3).set_Location(new Point(45, 37));
		((Control)gunaElipsePanel3).set_Name("gunaElipsePanel3");
		((Control)gunaElipsePanel3).set_Size(new Size(509, 413));
		((Control)gunaElipsePanel3).set_TabIndex(4);
		((Control)gunaElipsePanel3).add_Paint(new PaintEventHandler(gunaElipsePanel3_Paint));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)label4).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(40, 107));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(290, 51));
		((Control)label4).set_TabIndex(19);
		((Control)label4).set_Text("Yully Permanent Spoofer, this is Public, thats why\r\nit is an addon, but its still an Permanent Unban.\r\nThis got tested on Eac.\r\n");
		((Control)Logs).set_AutoSize(true);
		((Control)Logs).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)Logs).set_Font(new Font("Segoe UI Semibold", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Logs).set_ForeColor(Color.White);
		((Control)Logs).set_Location(new Point(42, 368));
		((Control)Logs).set_Name("Logs");
		((Control)Logs).set_Size(new Size(122, 17));
		((Control)Logs).set_TabIndex(18);
		((Control)Logs).set_Text("Waiting for Spoof...");
		siticoneButton8.set_BorderColor(Color.FromArgb(12, 12, 12));
		siticoneButton8.set_BorderRadius(2);
		siticoneButton8.set_BorderThickness(1);
		siticoneButton8.get_CheckedState().set_BorderColor(Color.FromArgb(12, 12, 12));
		siticoneButton8.get_CheckedState().set_FillColor(Color.FromArgb(12, 12, 12));
		siticoneButton8.get_CheckedState().set_Parent((CustomButtonBase)(object)siticoneButton8);
		siticoneButton8.get_CustomImages().set_Parent((CustomButtonBase)(object)siticoneButton8);
		siticoneButton8.set_FillColor(Color.FromArgb(12, 12, 12));
		((Control)siticoneButton8).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)siticoneButton8).set_ForeColor(Color.White);
		siticoneButton8.get_HoveredState().set_BorderColor(Color.FromArgb(12, 12, 12));
		siticoneButton8.get_HoveredState().set_FillColor(Color.FromArgb(12, 12, 12));
		siticoneButton8.get_HoveredState().set_Parent((CustomButtonBase)(object)siticoneButton8);
		((Control)siticoneButton8).set_Location(new Point(41, 314));
		((Control)siticoneButton8).set_Name("siticoneButton8");
		siticoneButton8.get_ShadowDecoration().set_Parent((Control)(object)siticoneButton8);
		((Control)siticoneButton8).set_Size(new Size(441, 43));
		((Control)siticoneButton8).set_TabIndex(17);
		((Control)siticoneButton8).set_Text("LAUNCH");
		((Control)siticoneButton8).add_Click((EventHandler)siticoneButton8_Click);
		siticoneSeparator2.set_FillColor(Color.FromArgb(14, 14, 14));
		((Control)siticoneSeparator2).set_Location(new Point(40, 292));
		((Control)siticoneSeparator2).set_Name("siticoneSeparator2");
		((Control)siticoneSeparator2).set_Size(new Size(444, 12));
		((Control)siticoneSeparator2).set_TabIndex(16);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)label3).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Yellow);
		((Control)label3).set_Location(new Point(48, 207));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(290, 68));
		((Control)label3).set_TabIndex(15);
		((Control)label3).set_Text("Warning\r\n   This can cause your pc to blue screen.\r\n   If your mobo is unsupported this will happen.\r\n   If you blue screen just turn your pc off and on.");
		siticoneSeparator1.set_FillColor(Color.FromArgb(14, 14, 14));
		((Control)siticoneSeparator1).set_Location(new Point(40, 182));
		((Control)siticoneSeparator1).set_Name("siticoneSeparator1");
		((Control)siticoneSeparator1).set_Size(new Size(444, 12));
		((Control)siticoneSeparator1).set_TabIndex(14);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(49, 64));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 16));
		((Control)label1).set_TabIndex(13);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(206, 66, 220));
		((Control)label2).set_Location(new Point(12, 40));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(212, 20));
		((Control)label2).set_TabIndex(12);
		((Control)label2).set_Text(" Permanent Spoofer (Addon)");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(596, 502));
		((Control)this).get_Controls().Add((Control)(object)gunaElipsePanel3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ClientAddon");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)ClientAddon_Load);
		((Control)gunaElipsePanel3).ResumeLayout(false);
		((Control)gunaElipsePanel3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (DwmSetWindowAttribute(((Control)this).get_Handle(), 19, new int[1] { 1 }, 4) != 0)
		{
			DwmSetWindowAttribute(((Control)this).get_Handle(), 20, new int[1] { 1 }, 4);
		}
	}

	private async void siticoneButton8_Click(object sender, EventArgs e)
	{
	}

	private void gunaElipsePanel3_Paint(object sender, PaintEventArgs e)
	{
	}
}
