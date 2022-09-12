using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Sandbox;

public class Form1 : Form
{
	private IContainer components = null;

	private Button button1;

	public Form1()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		MessageBox.Show("Loaded!");
		WebClient webClient = new WebClient();
		webClient.DownloadString("https://google.com/");
	}

	private void button1_Click(object sender, EventArgs e)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(165, 163));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(425, 165));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
