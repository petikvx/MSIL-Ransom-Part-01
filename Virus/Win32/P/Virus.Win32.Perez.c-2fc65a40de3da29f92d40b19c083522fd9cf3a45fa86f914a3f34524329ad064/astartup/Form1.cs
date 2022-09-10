using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace astartup;

public class Form1 : Form
{
	private Container components = null;

	public Form1()
	{
		InitializeComponent();
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
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(320, 38));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
	}

	[DllImport("acdb16.dll")]
	private static extern int acdbGetMainThreadId();

	[STAThread]
	private static void Main()
	{
		NameTable nameTable = new NameTable();
		nameTable = nameTable;
		Application.Run((Form)(object)new Form1());
	}

	protected override void OnLoad(EventArgs e)
	{
		Application.Exit();
	}
}
