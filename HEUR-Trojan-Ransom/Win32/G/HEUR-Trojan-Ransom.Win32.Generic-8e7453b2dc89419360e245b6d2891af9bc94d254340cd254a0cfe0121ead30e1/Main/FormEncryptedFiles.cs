using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace Main;

public class FormEncryptedFiles : Form
{
	private IContainer icontainer_0;

	private DataGridView dataGridView_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	public FormEncryptedFiles()
	{
		method_1();
	}

	private void method_0(object sender, EventArgs e)
	{
		HashSet<string>.Enumerator enumerator_ = Delegate225.smethod_0(Class7.smethod_1());
		try
		{
			while (Delegate172.smethod_0(ref enumerator_))
			{
				string text = Delegate22.smethod_0(ref enumerator_);
				if (Delegate49.smethod_0(Delegate117.smethod_0(text, ".paymts")))
				{
					Delegate169.smethod_0(Delegate107.smethod_0(dataGridView_0), new object[2] { "", text });
				}
				else
				{
					Delegate169.smethod_0(Delegate107.smethod_0(dataGridView_0), new object[2] { "YES", text });
				}
			}
		}
		finally
		{
			((IDisposable)enumerator_).Dispose();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Delegate27.smethod_0(icontainer_0);
		}
		Delegate210.smethod_0(this, disposing);
	}

	private void method_1()
	{
		dataGridView_0 = Delegate158.smethod_0();
		dataGridViewTextBoxColumn_0 = Delegate101.smethod_0();
		dataGridViewTextBoxColumn_1 = Delegate101.smethod_0();
		Delegate54.smethod_0(dataGridView_0);
		Delegate29.smethod_0(this);
		Delegate116.smethod_0(dataGridView_0, (DataGridViewColumnHeadersHeightSizeMode)2);
		Delegate127.smethod_0(Delegate35.smethod_0(dataGridView_0), (DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn_0,
			(DataGridViewColumn)dataGridViewTextBoxColumn_1
		});
		Delegate69.smethod_0(dataGridView_0, (DockStyle)5);
		Delegate229.smethod_0(dataGridView_0, new Point(0, 0));
		Delegate73.smethod_1(dataGridView_0, "dataGridViewEncryptedFiles");
		Delegate71.smethod_0(dataGridView_0, new Size(594, 326));
		Delegate72.smethod_0(dataGridView_0, 0);
		Delegate17.smethod_0(dataGridViewTextBoxColumn_0, "Deleted");
		Delegate10.smethod_0(dataGridViewTextBoxColumn_0, "ColumnDeleted");
		Delegate142.smethod_0(dataGridViewTextBoxColumn_0, bool_0: true);
		Delegate45.smethod_0(dataGridViewTextBoxColumn_0, 50);
		Delegate17.smethod_0(dataGridViewTextBoxColumn_1, "Path");
		Delegate10.smethod_0(dataGridViewTextBoxColumn_1, "ColumnPath");
		Delegate142.smethod_0(dataGridViewTextBoxColumn_1, bool_0: true);
		Delegate45.smethod_0(dataGridViewTextBoxColumn_1, 500);
		Delegate241.smethod_0(this, new SizeF(6f, 13f));
		Delegate81.smethod_0(this, (AutoScaleMode)1);
		Delegate205.smethod_0(this, new Size(594, 326));
		Delegate34.smethod_0(Delegate179.smethod_0(this), (Control)(object)dataGridView_0);
		Delegate73.smethod_0(this, "FormEncryptedFiles");
		Delegate96.smethod_0(this, "EncryptedFiles");
		Delegate112.smethod_0(this, method_0);
		Delegate195.smethod_0(dataGridView_0);
		Delegate221.smethod_0(this, bool_0: false);
	}
}
