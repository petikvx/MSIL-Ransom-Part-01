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
		HashSet<string>.Enumerator enumerator_ = Delegate80.smethod_0(Class7.smethod_1());
		try
		{
			while (Delegate181.smethod_0(ref enumerator_))
			{
				string text = Delegate103.smethod_0(ref enumerator_);
				if (Delegate156.smethod_0(Delegate127.smethod_0(text, ".payrms")))
				{
					Delegate145.smethod_0(Delegate19.smethod_0(dataGridView_0), new object[2] { "", text });
				}
				else
				{
					Delegate145.smethod_0(Delegate19.smethod_0(dataGridView_0), new object[2] { "YES", text });
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
			Delegate73.smethod_0(icontainer_0);
		}
		Delegate175.smethod_0(this, disposing);
	}

	private void method_1()
	{
		dataGridView_0 = Delegate214.smethod_0();
		dataGridViewTextBoxColumn_0 = Delegate171.smethod_0();
		dataGridViewTextBoxColumn_1 = Delegate171.smethod_0();
		Delegate211.smethod_0(dataGridView_0);
		Delegate146.smethod_0(this);
		Delegate212.smethod_0(dataGridView_0, (DataGridViewColumnHeadersHeightSizeMode)2);
		Delegate59.smethod_0(Delegate226.smethod_0(dataGridView_0), (DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn_0,
			(DataGridViewColumn)dataGridViewTextBoxColumn_1
		});
		Delegate60.smethod_0(dataGridView_0, (DockStyle)5);
		Delegate23.smethod_0(dataGridView_0, new Point(0, 0));
		Delegate66.smethod_1(dataGridView_0, "dataGridViewEncryptedFiles");
		Delegate52.smethod_0(dataGridView_0, new Size(594, 326));
		Delegate82.smethod_0(dataGridView_0, 0);
		Delegate149.smethod_0(dataGridViewTextBoxColumn_0, "Deleted");
		Delegate130.smethod_0(dataGridViewTextBoxColumn_0, "ColumnDeleted");
		Delegate205.smethod_0(dataGridViewTextBoxColumn_0, bool_0: true);
		Delegate132.smethod_0(dataGridViewTextBoxColumn_0, 50);
		Delegate149.smethod_0(dataGridViewTextBoxColumn_1, "Path");
		Delegate130.smethod_0(dataGridViewTextBoxColumn_1, "ColumnPath");
		Delegate205.smethod_0(dataGridViewTextBoxColumn_1, bool_0: true);
		Delegate132.smethod_0(dataGridViewTextBoxColumn_1, 500);
		Delegate115.smethod_0(this, new SizeF(6f, 13f));
		Delegate58.smethod_0(this, (AutoScaleMode)1);
		Delegate122.smethod_0(this, new Size(594, 326));
		Delegate108.smethod_0(Delegate107.smethod_0(this), (Control)(object)dataGridView_0);
		Delegate66.smethod_0(this, "FormEncryptedFiles");
		Delegate131.smethod_0(this, "EncryptedFiles");
		Delegate144.smethod_0(this, method_0);
		Delegate142.smethod_0(dataGridView_0);
		Delegate185.smethod_0(this, bool_0: false);
	}
}
