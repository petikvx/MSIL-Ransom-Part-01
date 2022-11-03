using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;
using ManualMapInjection.Injection;

namespace WindowsFormsApp2;

public class Form1 : Form
{
	private string HWID;

	private IContainer components;

	private Button button1;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button2;

	private ColorDialog colorDialog1;

	private Button button3;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		HWID = WindowsIdentity.GetCurrent().User!.Value;
		((Control)textBox1).set_Text(HWID);
		((TextBoxBase)textBox1).set_ReadOnly(true);
		checkonline();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		checkonline();
		WebClient webClient = new WebClient();
		if (webClient.DownloadString("http://raw.githubusercontent.com/zabor4k/nixware.loader/master/HWID.txt").Contains(((Control)textBox1).get_Text()))
		{
			string text = "C:\\Windows\\random.dll";
			webClient.DownloadFile("https://github.com/zabor4k/nixware.loader/raw/master/lux.dll", text);
			Process p = Process.GetProcessesByName("csgo").FirstOrDefault();
			byte[] buffer = File.ReadAllBytes(text);
			if (!File.Exists(text))
			{
				MessageBox.Show("Error: DLL not found");
				return;
			}
			ManualMapInjector manualMapInjector = new ManualMapInjector(p)
			{
				AsyncInjection = true
			};
			((Control)label2).set_Text($"hmodule = 0x{manualMapInjector.Inject(buffer).ToInt64():x8}");
			if (File.Exists(text))
			{
				File.Delete(text);
			}
		}
		else
		{
			MessageBox.Show("HWID Incorrect");
		}
	}

	private void checkonline()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("https://google.com/"))
			{
				((Control)label1).set_ForeColor(Color.Green);
				((Control)label1).set_Text("Online");
			}
		}
		catch
		{
			((Control)label1).set_ForeColor(Color.Red);
			((Control)label1).set_Text("Offline");
			Application.Exit();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(HWID);
		((Control)button2).set_Enabled(false);
		((Control)button2).set_Text("");
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void gh2g2g45_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void label6_Click(object sender, EventArgs e)
	{
	}

	private void label6_Click_1(object sender, EventArgs e)
	{
	}

	private void pictureBox24_Click(object sender, EventArgs e)
	{
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button2 = new Button();
		colorDialog1 = new ColorDialog();
		button3 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_BackgroundImage((Image)componentResourceManager.GetObject("button1.BackgroundImage"));
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((ButtonBase)button1).set_Image((Image)componentResourceManager.GetObject("button1.Image"));
		((Control)button1).set_Location(new Point(37, 43));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(40, 25));
		((Control)button1).set_TabIndex(0);
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(302, 300));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(43, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("[Status]");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(475, 72));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("label2");
		((Control)textBox1).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(145, 297));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(151, 20));
		((Control)textBox1).set_TabIndex(3);
		((Control)button2).set_BackColor(Color.FromArgb(0, 0, 0, 0));
		((Control)button2).set_BackgroundImage((Image)componentResourceManager.GetObject("button2.BackgroundImage"));
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.FromArgb(0, 0, 0, 0));
		((Control)button2).set_Location(new Point(37, 25));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(175, 21));
		((Control)button2).set_TabIndex(4);
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 6f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)button3).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)button3).set_Location(new Point(231, -1));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(20, 20));
		((Control)button3).set_TabIndex(5);
		((Control)button3).set_Text("X");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)gh2g2g45_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(249, 195));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("onetap");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
