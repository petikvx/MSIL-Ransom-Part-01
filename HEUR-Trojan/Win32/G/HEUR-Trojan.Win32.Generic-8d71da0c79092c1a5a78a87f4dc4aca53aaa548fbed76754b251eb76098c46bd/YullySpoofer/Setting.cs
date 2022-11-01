using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Anti_DebugNET.AntiDebugTools;
using Guna.UI2.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;

namespace YullySpoofer;

public class Setting : Form
{
	private IContainer components;

	private SiticonePanel siticonePanel1;

	private SiticoneSeparator siticoneSeparator1;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private SiticoneButton siticoneButton1;

	private SiticoneCustomCheckBox beta;

	private SiticoneCustomCheckBox netspoof;

	private SiticoneCustomCheckBox clean;

	private SiticoneCustomCheckBox volume;

	private Guna2AnimateWindow guna2AnimateWindow1;

	private Label label5;

	public Setting(string game)
	{
		InitializeComponent();
		((Control)label1).set_Text(game + " | CONFIG");
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected O, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Expected O, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Setting));
		siticonePanel1 = new SiticonePanel();
		volume = new SiticoneCustomCheckBox();
		label5 = new Label();
		beta = new SiticoneCustomCheckBox();
		netspoof = new SiticoneCustomCheckBox();
		clean = new SiticoneCustomCheckBox();
		siticoneButton1 = new SiticoneButton();
		siticoneSeparator1 = new SiticoneSeparator();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		guna2AnimateWindow1 = new Guna2AnimateWindow(components);
		((Control)siticonePanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)siticonePanel1).set_BackColor(Color.FromArgb(10, 10, 10));
		((Control)siticonePanel1).get_Controls().Add((Control)(object)volume);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)label5);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)beta);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)netspoof);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)clean);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)siticoneButton1);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)siticoneSeparator1);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)label4);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)label3);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)label2);
		((Control)siticonePanel1).get_Controls().Add((Control)(object)label1);
		((Control)siticonePanel1).set_Location(new Point(44, 31));
		((Control)siticonePanel1).set_Name("siticonePanel1");
		siticonePanel1.get_ShadowDecoration().set_Parent((Control)(object)siticonePanel1);
		((Control)siticonePanel1).set_Size(new Size(299, 257));
		((Control)siticonePanel1).set_TabIndex(0);
		((Control)volume).set_BackColor(Color.FromArgb(16, 13, 14));
		volume.get_CheckedState().set_BorderRadius(0);
		volume.get_CheckedState().set_BorderThickness(0);
		volume.get_CheckedState().set_Parent((CustomCheckBox)(object)volume);
		((Control)volume).set_Location(new Point(255, 147));
		((Control)volume).set_Name("volume");
		volume.get_ShadowDecoration().set_Parent((Control)(object)volume);
		((Control)volume).set_Size(new Size(20, 20));
		((Control)volume).set_TabIndex(15);
		volume.get_UncheckedState().set_BorderRadius(0);
		volume.get_UncheckedState().set_BorderThickness(0);
		volume.get_UncheckedState().set_Parent((CustomCheckBox)(object)volume);
		((CustomCheckBox)volume).add_CheckedChanged((EventHandler)siticoneCustomCheckBox4_CheckedChanged_1);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.Transparent);
		((Control)label5).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(20, 147));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(159, 17));
		((Control)label5).set_TabIndex(14);
		((Control)label5).set_Text("Disable VolumeID Spoof");
		((Control)beta).set_BackColor(Color.FromArgb(16, 13, 14));
		beta.get_CheckedState().set_BorderRadius(0);
		beta.get_CheckedState().set_BorderThickness(0);
		beta.get_CheckedState().set_Parent((CustomCheckBox)(object)beta);
		((Control)beta).set_Location(new Point(255, 115));
		((Control)beta).set_Name("beta");
		beta.get_ShadowDecoration().set_Parent((Control)(object)beta);
		((Control)beta).set_Size(new Size(20, 20));
		((Control)beta).set_TabIndex(13);
		beta.get_UncheckedState().set_BorderRadius(0);
		beta.get_UncheckedState().set_BorderThickness(0);
		beta.get_UncheckedState().set_Parent((CustomCheckBox)(object)beta);
		((Control)netspoof).set_BackColor(Color.FromArgb(16, 13, 14));
		netspoof.get_CheckedState().set_BorderRadius(0);
		netspoof.get_CheckedState().set_BorderThickness(0);
		netspoof.get_CheckedState().set_Parent((CustomCheckBox)(object)netspoof);
		((Control)netspoof).set_Location(new Point(255, 84));
		((Control)netspoof).set_Name("netspoof");
		netspoof.get_ShadowDecoration().set_Parent((Control)(object)netspoof);
		((Control)netspoof).set_Size(new Size(20, 20));
		((Control)netspoof).set_TabIndex(12);
		netspoof.get_UncheckedState().set_BorderRadius(0);
		netspoof.get_UncheckedState().set_BorderThickness(0);
		netspoof.get_UncheckedState().set_Parent((CustomCheckBox)(object)netspoof);
		((Control)clean).set_BackColor(Color.FromArgb(16, 13, 14));
		clean.get_CheckedState().set_BorderRadius(0);
		clean.get_CheckedState().set_BorderThickness(0);
		clean.get_CheckedState().set_Parent((CustomCheckBox)(object)clean);
		((Control)clean).set_Location(new Point(255, 53));
		((Control)clean).set_Name("clean");
		clean.get_ShadowDecoration().set_Parent((Control)(object)clean);
		((Control)clean).set_Size(new Size(20, 20));
		((Control)clean).set_TabIndex(11);
		clean.get_UncheckedState().set_BorderRadius(0);
		clean.get_UncheckedState().set_BorderThickness(0);
		clean.get_UncheckedState().set_Parent((CustomCheckBox)(object)clean);
		siticoneButton1.set_BorderColor(Color.FromArgb(10, 10, 10));
		siticoneButton1.set_BorderRadius(2);
		siticoneButton1.set_BorderThickness(1);
		siticoneButton1.get_CheckedState().set_BorderColor(Color.FromArgb(13, 13, 13));
		siticoneButton1.get_CheckedState().set_FillColor(Color.FromArgb(13, 13, 13));
		siticoneButton1.get_CheckedState().set_Parent((CustomButtonBase)(object)siticoneButton1);
		siticoneButton1.get_CustomImages().set_Parent((CustomButtonBase)(object)siticoneButton1);
		siticoneButton1.set_FillColor(Color.FromArgb(12, 12, 12));
		((Control)siticoneButton1).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)siticoneButton1).set_ForeColor(Color.FromArgb(224, 224, 224));
		siticoneButton1.get_HoveredState().set_BorderColor(Color.FromArgb(13, 13, 13));
		siticoneButton1.get_HoveredState().set_FillColor(Color.FromArgb(13, 13, 13));
		siticoneButton1.get_HoveredState().set_Parent((CustomButtonBase)(object)siticoneButton1);
		((Control)siticoneButton1).set_Location(new Point(20, 198));
		((Control)siticoneButton1).set_Name("siticoneButton1");
		siticoneButton1.get_ShadowDecoration().set_Parent((Control)(object)siticoneButton1);
		((Control)siticoneButton1).set_Size(new Size(255, 33));
		((Control)siticoneButton1).set_TabIndex(10);
		((Control)siticoneButton1).set_Text("SPOOF");
		siticoneButton1.set_TextOffset(new Point(-94, 0));
		((Control)siticoneButton1).add_Click((EventHandler)siticoneButton1_Click);
		((Control)siticoneSeparator1).set_BackColor(Color.Transparent);
		siticoneSeparator1.set_FillColor(Color.FromArgb(17, 17, 17));
		((Control)siticoneSeparator1).set_Location(new Point(21, 182));
		((Control)siticoneSeparator1).set_Name("siticoneSeparator1");
		((Control)siticoneSeparator1).set_Size(new Size(258, 10));
		((Control)siticoneSeparator1).set_TabIndex(7);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(20, 115));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(120, 17));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Enable Beta Spoof");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(20, 84));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(145, 17));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Enable Network Spoof");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(20, 53));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(87, 17));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Enable Clean");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Segoe UI", 11.25f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(203, 59, 219));
		((Control)label1).set_Location(new Point(15, 20));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(150, 20));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("FORTNITE | CONFIG");
		guna2AnimateWindow1.set_AnimationType((AnimateWindowType)524288);
		guna2AnimateWindow1.set_Interval(1000);
		guna2AnimateWindow1.set_TargetForm((Form)(object)this);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(382, 324));
		((Control)this).get_Controls().Add((Control)(object)siticonePanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Setting");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("se");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Setting_Load);
		((Control)siticonePanel1).ResumeLayout(false);
		((Control)siticonePanel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void label5_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("This is a beta spoofing only use this is you're getting banned with normal spoofing.", "Yully Spoofer");
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (DwmSetWindowAttribute(((Control)this).get_Handle(), 19, new int[1] { 1 }, 4) != 0)
		{
			DwmSetWindowAttribute(((Control)this).get_Handle(), 20, new int[1] { 1 }, 4);
		}
	}

	private void Setting_Load(object sender, EventArgs e)
	{
		Scanner.ScanAndKill();
	}

	private void siticoneButton1_Click(object sender, EventArgs e)
	{
		if (volume.get_Checked() && clean.get_Checked() && netspoof.get_Checked() && beta.get_Checked())
		{
			Driver.SpoofVolumeID();
		}
		if (!volume.get_Checked())
		{
		}
		if (!clean.get_Checked() || !netspoof.get_Checked())
		{
		}
		if (!clean.get_Checked() || !beta.get_Checked())
		{
		}
		if (volume.get_Checked() && beta.get_Checked() && clean.get_Checked())
		{
			Driver.SpoofVolumeID();
		}
		if (!netspoof.get_Checked() || !beta.get_Checked() || !clean.get_Checked())
		{
		}
		if (beta.get_Checked())
		{
			Spoof69.SpoofRegistry();
		}
		if (beta.get_Checked() && volume.get_Checked())
		{
			Driver.SpoofVolumeID();
		}
	}

	private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (((Control)label1).get_Text() == "CALL OF DUTY | CONFIG")
		{
		}
	}

	private void siticoneCustomCheckBox2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void siticoneCustomCheckBox3_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void siticoneCustomCheckBox4_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void siticoneCustomCheckBox4_CheckedChanged_1(object sender, EventArgs e)
	{
	}
}
