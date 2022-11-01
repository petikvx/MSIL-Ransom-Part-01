using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Properties;

namespace YullySpoofer.UserControls;

public class UC_Settings : UserControl
{
	private string current;

	private IContainer components = null;

	private Guna2Button guna2Button5;

	private Guna2Button guna2Button6;

	private PictureBox pictureBox3;

	private Guna2Button guna2Button3;

	private Guna2Button guna2Button4;

	private PictureBox pictureBox2;

	private Guna2Button guna2Button2;

	private Guna2Button guna2Button1;

	private PictureBox pictureBox1;

	private Guna2Button guna2Button7;

	private Label label1;

	public UC_Settings()
	{
		InitializeComponent();
	}

	private void pictureBox5_Click(object sender, EventArgs e)
	{
	}

	private async void LoadButton(string current)
	{
		await Task.Delay(5000);
		Stream.Load(Program.KeyAuthApp.download("511292"), current, "");
	}

	private async void guna2Button1_Click(object sender, EventArgs e, string current)
	{
	}

	private void guna2Button4_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Please select an Option on the Valorant Config Form.", "Yully Spoofer | Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void guna2Button6_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Please select an Option on the Cod Config Form.", "Yully Spoofer | Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void guna2Button2_Click(object sender, EventArgs e)
	{
	}

	private async void guna2Button1_Click(object sender, EventArgs e)
	{
		Spoof niggggg = new Spoof();
		((Control)niggggg).Show();
	}

	private void guna2Button7_Click(object sender, EventArgs e)
	{
		ClientAddon clientAddon = new ClientAddon();
		((Control)clientAddon).Show();
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected O, but got Unknown
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected O, but got Unknown
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Expected O, but got Unknown
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UC_Settings));
		guna2Button6 = new Guna2Button();
		guna2Button4 = new Guna2Button();
		guna2Button1 = new Guna2Button();
		guna2Button5 = new Guna2Button();
		pictureBox3 = new PictureBox();
		guna2Button3 = new Guna2Button();
		pictureBox2 = new PictureBox();
		guna2Button2 = new Guna2Button();
		pictureBox1 = new PictureBox();
		guna2Button7 = new Guna2Button();
		label1 = new Label();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		guna2Button6.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button6.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button6.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button6.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button6.set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button6).set_Font(new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)guna2Button6).set_ForeColor(Color.White);
		guna2Button6.get_HoverState().set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button6).set_Location(new Point(432, 130));
		((Control)guna2Button6).set_Name("guna2Button6");
		((Control)guna2Button6).set_Size(new Size(135, 45));
		((Control)guna2Button6).set_TabIndex(25);
		((Control)guna2Button6).set_Text("LAUNCH");
		guna2Button6.set_TextOffset(new Point(-20, 0));
		((Control)guna2Button6).add_Click((EventHandler)guna2Button6_Click);
		guna2Button4.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button4.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button4.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button4.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button4.set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button4).set_Font(new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)guna2Button4).set_ForeColor(Color.White);
		guna2Button4.get_HoverState().set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button4).set_Location(new Point(259, 130));
		((Control)guna2Button4).set_Name("guna2Button4");
		((Control)guna2Button4).set_Size(new Size(135, 45));
		((Control)guna2Button4).set_TabIndex(22);
		((Control)guna2Button4).set_Text("LAUNCH");
		guna2Button4.set_TextOffset(new Point(-20, 0));
		((Control)guna2Button4).add_Click((EventHandler)guna2Button4_Click);
		guna2Button1.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button1.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button1.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button1.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button1.set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button1).set_Font(new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)guna2Button1).set_ForeColor(Color.White);
		guna2Button1.get_HoverState().set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button1).set_Location(new Point(86, 130));
		((Control)guna2Button1).set_Name("guna2Button1");
		((Control)guna2Button1).set_Size(new Size(135, 45));
		((Control)guna2Button1).set_TabIndex(19);
		((Control)guna2Button1).set_Text("LAUNCH");
		guna2Button1.set_TextOffset(new Point(-20, 0));
		((Control)guna2Button1).add_Click((EventHandler)guna2Button1_Click);
		guna2Button5.set_Animated(true);
		guna2Button5.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button5.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button5.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button5.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button5.set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button5).set_Font(new Font("Segoe UI", 9f));
		((Control)guna2Button5).set_ForeColor(Color.White);
		guna2Button5.get_HoverState().set_FillColor(Color.FromArgb(8, 8, 8));
		guna2Button5.get_HoverState().set_Image((Image)componentResourceManager.GetObject("resource.Image"));
		guna2Button5.set_Image((Image)componentResourceManager.GetObject("guna2Button5.Image"));
		guna2Button5.set_ImageSize(new Size(13, 13));
		((Control)guna2Button5).set_Location(new Point(561, 130));
		((Control)guna2Button5).set_Name("guna2Button5");
		((Control)guna2Button5).set_Size(new Size(35, 45));
		((Control)guna2Button5).set_TabIndex(26);
		pictureBox3.set_Image((Image)(object)Resources._447016);
		((Control)pictureBox3).set_Location(new Point(432, -27));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(167, 221));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox3.set_TabIndex(24);
		pictureBox3.set_TabStop(false);
		guna2Button3.set_Animated(true);
		guna2Button3.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button3.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button3.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button3.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button3.set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button3).set_Font(new Font("Segoe UI", 9f));
		((Control)guna2Button3).set_ForeColor(Color.White);
		guna2Button3.get_HoverState().set_FillColor(Color.FromArgb(8, 8, 8));
		guna2Button3.get_HoverState().set_Image((Image)componentResourceManager.GetObject("resource.Image1"));
		guna2Button3.set_Image((Image)componentResourceManager.GetObject("guna2Button3.Image"));
		guna2Button3.set_ImageSize(new Size(13, 13));
		((Control)guna2Button3).set_Location(new Point(388, 130));
		((Control)guna2Button3).set_Name("guna2Button3");
		((Control)guna2Button3).set_Size(new Size(35, 45));
		((Control)guna2Button3).set_TabIndex(23);
		pictureBox2.set_Image((Image)(object)Resources.OIP__4_2);
		((Control)pictureBox2).set_Location(new Point(259, -27));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(167, 221));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox2.set_TabIndex(21);
		pictureBox2.set_TabStop(false);
		guna2Button2.set_Animated(true);
		guna2Button2.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button2.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button2.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button2.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button2.set_FillColor(Color.FromArgb(8, 8, 8));
		((Control)guna2Button2).set_Font(new Font("Segoe UI", 9f));
		((Control)guna2Button2).set_ForeColor(Color.White);
		guna2Button2.get_HoverState().set_FillColor(Color.FromArgb(8, 8, 8));
		guna2Button2.get_HoverState().set_Image((Image)componentResourceManager.GetObject("resource.Image2"));
		guna2Button2.set_Image((Image)componentResourceManager.GetObject("guna2Button2.Image"));
		guna2Button2.set_ImageSize(new Size(13, 13));
		((Control)guna2Button2).set_Location(new Point(215, 130));
		((Control)guna2Button2).set_Name("guna2Button2");
		((Control)guna2Button2).set_Size(new Size(35, 45));
		((Control)guna2Button2).set_TabIndex(20);
		((Control)guna2Button2).add_Click((EventHandler)guna2Button2_Click);
		pictureBox1.set_Image((Image)(object)Resources.R__1_2);
		((Control)pictureBox1).set_Location(new Point(86, -27));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(167, 221));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(18);
		pictureBox1.set_TabStop(false);
		guna2Button7.set_Animated(true);
		((Control)guna2Button7).set_BackColor(Color.Transparent);
		guna2Button7.set_BorderColor(Color.FromArgb(14, 14, 14));
		guna2Button7.set_BorderRadius(2);
		guna2Button7.set_BorderThickness(1);
		guna2Button7.get_CheckedState().set_FillColor(Color.FromArgb(14, 14, 14));
		guna2Button7.get_DisabledState().set_BorderColor(Color.DarkGray);
		guna2Button7.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		guna2Button7.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		guna2Button7.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		guna2Button7.set_FillColor(Color.FromArgb(14, 14, 14));
		((Control)guna2Button7).set_Font(new Font("Segoe UI", 9f));
		((Control)guna2Button7).set_ForeColor(Color.Gray);
		guna2Button7.get_HoverState().set_FillColor(Color.FromArgb(14, 14, 14));
		guna2Button7.set_ImageOffset(new Point(-89, -1));
		guna2Button7.set_ImageSize(new Size(23, 23));
		((Control)guna2Button7).set_Location(new Point(86, 200));
		((Control)guna2Button7).set_Name("guna2Button7");
		((Control)guna2Button7).set_Size(new Size(513, 34));
		((Control)guna2Button7).set_TabIndex(27);
		((Control)guna2Button7).set_Text("PERMANENT SPOOFER (ADDON)");
		guna2Button7.set_TextOffset(new Point(-155, -1));
		((Control)guna2Button7).add_Click((EventHandler)guna2Button7_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Fuchsia);
		((Control)label1).set_Location(new Point(256, 259));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(145, 17));
		((Control)label1).set_TabIndex(28);
		((Control)label1).set_Text("SOON 3 MORE GAMES");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)guna2Button7);
		((Control)this).get_Controls().Add((Control)(object)guna2Button5);
		((Control)this).get_Controls().Add((Control)(object)guna2Button6);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)guna2Button3);
		((Control)this).get_Controls().Add((Control)(object)guna2Button4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)guna2Button2);
		((Control)this).get_Controls().Add((Control)(object)guna2Button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Name("UC_Settings");
		((Control)this).set_Size(new Size(690, 574));
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
