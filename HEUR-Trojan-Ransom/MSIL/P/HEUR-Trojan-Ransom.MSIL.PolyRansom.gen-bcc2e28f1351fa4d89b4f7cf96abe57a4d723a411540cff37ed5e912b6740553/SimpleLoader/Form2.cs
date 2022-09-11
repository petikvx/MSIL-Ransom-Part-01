using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ManualMapInjection.Injection;

namespace SimpleLoader;

public class Form2 : Form
{
	private IContainer components;

	private PictureBox pictureBox2;

	private Label label4;

	private Timer timer1;

	public Form2()
	{
		InitializeComponent();
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click_1(object sender, EventArgs e)
	{
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		WebClient webClient = new WebClient();
		string text = "C:\\Windows\\SAHGSDADAWSEDA.dll";
		webClient.DownloadFile("DLL URL", text);
		Process? p = Process.GetProcessesByName("csgo").FirstOrDefault();
		string path = text;
		byte[] buffer = File.ReadAllBytes(path);
		ManualMapInjector manualMapInjector = new ManualMapInjector(p)
		{
			AsyncInjection = true
		};
		((Control)label4).set_Text($"hmodule = 0x{manualMapInjector.Inject(buffer).ToInt64():x8}");
		if (!File.Exists(path))
		{
			MessageBox.Show("Error: DLL not found");
			Application.Exit();
		}
		else if (File.Exists(text))
		{
			File.Delete(text);
			Application.Exit();
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		pictureBox2 = new PictureBox();
		label4 = new Label();
		timer1 = new Timer(components);
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox2).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage"));
		pictureBox2.set_ErrorImage((Image)null);
		pictureBox2.set_InitialImage((Image)null);
		((Control)pictureBox2).set_Location(new Point(6, 6));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(288, 4));
		pictureBox2.set_TabIndex(7);
		pictureBox2.set_TabStop(false);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.FromArgb(15, 15, 15));
		((Control)label4).set_Font(new Font("Verdana", 7.25f));
		((Control)label4).set_ForeColor(Color.Gainsboro);
		label4.set_ImageAlign((ContentAlignment)64);
		((Control)label4).set_Location(new Point(120, 99));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(61, 12));
		((Control)label4).set_TabIndex(15);
		((Control)label4).set_Text("Loading...");
		((Control)label4).add_Click((EventHandler)label4_Click_1);
		timer1.set_Enabled(true);
		timer1.set_Interval(1);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(15, 15, 15));
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(300, 210));
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form2");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form2_Load);
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
