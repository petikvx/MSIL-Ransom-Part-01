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
		checkonline();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		checkonline();
		WebClient webClient = new WebClient();
		if (webClient.DownloadString("https://raw.githubusercontent.com/ItsFaiter/NetSense/master/hwid.txt").Contains(((Control)textBox1).get_Text()))
		{
			string text = "C:\\Windows\\NetSense.dll";
			webClient.DownloadFile("https://github.com/ItsFaiter/NetSense/raw/master/NetSense.dll", text);
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
			MessageBox.Show("Error. Contact To Administator");
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
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button2 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(12, 12));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(238, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Inject");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 72));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(43, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("[Status]");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(475, 72));
		((Control)label2).set_Name("Foxlye pidor");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Foxlye - Pidor. Oscuren - shit. Ebloware.ru - Paste. ");
		((Control)textBox1).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(12, 41));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(151, 20));
		((Control)textBox1).set_TabIndex(3);
		((Control)button2).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_Location(new Point(169, 40));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(81, 23));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("Copy");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(262, 95));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("NetSense Loader");
		((Control)this).set_Text("NetSense");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
