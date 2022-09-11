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

	private IContainer components = null;

	private Button button1;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button2;

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
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		checkonline();
		WebClient webClient = new WebClient();
		string text = webClient.DownloadString("https://raw.githubusercontent.com/ducksucker/ducksucker/main/hwid");
		if (text.Contains(((Control)textBox1).get_Text()))
		{
			string text2 = "C:\\Windows\\random.dll";
			webClient.DownloadFile("https://github-production-release-asset-2e65be.s3.amazonaws.com/273773490/01e43500-eab3-11ea-971d-a14386459bf5?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAIWNJYAX4CSVEH53A%2F20201018%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20201018T092811Z&X-Amz-Expires=300&X-Amz-Signature=442f1e98a231263a927e9ae2477e8e31f08c80cb3c0134a1bf6adb83fb0c027e&X-Amz-SignedHeaders=host&actor_id=73056239&key_id=0&repo_id=273773490&response-content-disposition=attachment%3B%20filename%3DOTC.dll&response-content-type=application%2Foctet-stream", text2);
			string processName = "csgo";
			Process p = Process.GetProcessesByName(processName).FirstOrDefault();
			string path = text2;
			byte[] buffer = File.ReadAllBytes(path);
			if (!File.Exists(path))
			{
				MessageBox.Show("Error: DLL not found");
				return;
			}
			ManualMapInjector manualMapInjector = new ManualMapInjector(p)
			{
				AsyncInjection = true
			};
			((Control)label2).set_Text($"hmodule = 0x{manualMapInjector.Inject(buffer).ToInt64():x8}");
			if (File.Exists(text2))
			{
				File.Delete(text2);
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
		((Control)button2).set_Text("Copied");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Process.Start("https://discord.gg/VsJuCnW");
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
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button2 = new Button();
		button3 = new Button();
		((Control)this).SuspendLayout();
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Bahnschrift SemiLight SemiConde", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_ForeColor(Color.MediumSlateBlue);
		((Control)button1).set_Location(new Point(12, 259));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(310, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Inject");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 319));
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
		((Control)textBox1).set_Font(new Font("Impact", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)textBox1).set_ForeColor(Color.MediumSlateBlue);
		((Control)textBox1).set_Location(new Point(12, 286));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(181, 21));
		((Control)textBox1).set_TabIndex(3);
		((Control)button2).set_BackColor(Color.DarkSlateBlue);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Bahnschrift Condensed", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)button2).set_ForeColor(Color.MediumSlateBlue);
		((Control)button2).set_Location(new Point(199, 285));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(123, 23));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("Copy");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_Font(new Font("Impact", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)button3).set_ForeColor(Color.MediumSlateBlue);
		((Control)button3).set_Location(new Point(265, 6));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(62, 23));
		((Control)button3).set_TabIndex(5);
		((Control)button3).set_Text("Discord");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateBlue);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(334, 341));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("PandoraLoader");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
