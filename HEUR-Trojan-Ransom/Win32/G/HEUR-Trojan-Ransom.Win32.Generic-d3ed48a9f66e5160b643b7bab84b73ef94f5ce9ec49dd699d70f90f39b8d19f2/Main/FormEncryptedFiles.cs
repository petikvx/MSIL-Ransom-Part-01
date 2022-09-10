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
		HashSet<string>.Enumerator enumerator_ = Delegate34.smethod_0(Class7.smethod_1());
		try
		{
			while (Delegate103.smethod_0(ref enumerator_))
			{
				string text = Delegate98.smethod_0(ref enumerator_);
				if (Delegate192.smethod_0(Delegate173.smethod_0(text, ".payms")))
				{
					Delegate135.smethod_0(Delegate23.smethod_0(dataGridView_0), new object[2] { "", text });
				}
				else
				{
					Delegate135.smethod_0(Delegate23.smethod_0(dataGridView_0), new object[2] { "YES", text });
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
			Delegate133.smethod_0(icontainer_0);
		}
		Delegate193.smethod_0(this, disposing);
	}

	private void method_1()
	{
		dataGridView_0 = Delegate51.smethod_0();
		dataGridViewTextBoxColumn_0 = Delegate180.smethod_0();
		dataGridViewTextBoxColumn_1 = Delegate180.smethod_0();
		Delegate24.smethod_0(dataGridView_0);
		Delegate19.smethod_0(this);
		Delegate49.smethod_0(dataGridView_0, (DataGridViewColumnHeadersHeightSizeMode)2);
		Delegate226.smethod_0(Delegate140.smethod_0(dataGridView_0), (DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn_0,
			(DataGridViewColumn)dataGridViewTextBoxColumn_1
		});
		Delegate63.smethod_0(dataGridView_0, (DockStyle)5);
		Delegate11.smethod_0(dataGridView_0, new Point(0, 0));
		Delegate94.smethod_1(dataGridView_0, "dataGridViewEncryptedFiles");
		Delegate101.smethod_0(dataGridView_0, new Size(594, 326));
		Delegate16.smethod_0(dataGridView_0, 0);
		Delegate91.smethod_0(dataGridViewTextBoxColumn_0, "Deleted");
		Delegate66.smethod_0(dataGridViewTextBoxColumn_0, "ColumnDeleted");
		Delegate195.smethod_0(dataGridViewTextBoxColumn_0, bool_0: true);
		Delegate43.smethod_0(dataGridViewTextBoxColumn_0, 50);
		Delegate91.smethod_0(dataGridViewTextBoxColumn_1, "Path");
		Delegate66.smethod_0(dataGridViewTextBoxColumn_1, "ColumnPath");
		Delegate195.smethod_0(dataGridViewTextBoxColumn_1, bool_0: true);
		Delegate43.smethod_0(dataGridViewTextBoxColumn_1, 500);
		Delegate62.smethod_0(this, new SizeF(6f, 13f));
		Delegate83.smethod_0(this, (AutoScaleMode)1);
		Delegate86.smethod_0(this, new Size(594, 326));
		Delegate102.smethod_0(Delegate95.smethod_0(this), (Control)(object)dataGridView_0);
		Delegate94.smethod_0(this, "FormEncryptedFiles");
		Delegate167.smethod_0(this, "EncryptedFiles");
		Delegate242.smethod_0(this, method_0);
		Delegate74.smethod_0(dataGridView_0);
		Delegate155.smethod_0(this, bool_0: false);
	}
}
