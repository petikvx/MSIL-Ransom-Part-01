using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hjvyvnzg;

public sealed class e : Form
{
	private IContainer m_a;

	private DataGridView b;

	private DataGridView c;

	private DataGridView d;

	private DataGridView m_e;

	private DataGridView f;

	private DataGridView g;

	private DataGridView h;

	public e()
	{
		a();
	}

	private void a(object sender, EventArgs e)
	{
		Hjvyvnzg.l<string> obj = new Hjvyvnzg.l<string>();
		obj.epl7gd4tymsybyvykmrl8w247ajjz9xuUATc();
		obj.epl7gd4tymsybyvykmrl8w247ajjz9xuUATa();
		obj.epl7gd4tymsybyvykmrl8w247ajjz9xuUATb();
	}

	private void a(object sender, DataGridViewCellEventArgs e)
	{
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		((Form)this).Dispose(a);
	}

	private void a()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		b = new DataGridView();
		c = new DataGridView();
		d = new DataGridView();
		m_e = new DataGridView();
		f = new DataGridView();
		g = new DataGridView();
		h = new DataGridView();
		((ISupportInitialize)b).BeginInit();
		((ISupportInitialize)c).BeginInit();
		((ISupportInitialize)d).BeginInit();
		((ISupportInitialize)m_e).BeginInit();
		((ISupportInitialize)f).BeginInit();
		((ISupportInitialize)g).BeginInit();
		((ISupportInitialize)h).BeginInit();
		((Control)this).SuspendLayout();
		b.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)b).set_Location(new Point(0, 0));
		((Control)b).set_Name("dataGridView1");
		((Control)b).set_Size(new Size(240, 150));
		((Control)b).set_TabIndex(0);
		c.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)c).set_Location(new Point(8, 8));
		((Control)c).set_Name("dataGridView2");
		((Control)c).set_Size(new Size(240, 150));
		((Control)c).set_TabIndex(1);
		d.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)d).set_Location(new Point(16, 16));
		((Control)d).set_Name("dataGridView3");
		((Control)d).set_Size(new Size(240, 150));
		((Control)d).set_TabIndex(2);
		m_e.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)m_e).set_Location(new Point(24, 24));
		((Control)m_e).set_Name("dataGridView4");
		((Control)m_e).set_Size(new Size(240, 150));
		((Control)m_e).set_TabIndex(3);
		f.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)f).set_Location(new Point(32, 32));
		((Control)f).set_Name("dataGridView5");
		((Control)f).set_Size(new Size(240, 150));
		((Control)f).set_TabIndex(4);
		g.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)g).set_Dock((DockStyle)5);
		((Control)g).set_Location(new Point(0, 0));
		((Control)g).set_Name("dataGridView6");
		((Control)g).set_Size(new Size(800, 450));
		((Control)g).set_TabIndex(5);
		g.add_CellContentClick(new DataGridViewCellEventHandler(a));
		h.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)h).set_Location(new Point(522, 226));
		((Control)h).set_Name("dataGridView7");
		((Control)h).set_Size(new Size(240, 150));
		((Control)h).set_TabIndex(6);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)h);
		((Control)this).get_Controls().Add((Control)(object)g);
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).get_Controls().Add((Control)(object)m_e);
		((Control)this).get_Controls().Add((Control)(object)d);
		((Control)this).get_Controls().Add((Control)(object)c);
		((Control)this).get_Controls().Add((Control)(object)b);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)a);
		((ISupportInitialize)b).EndInit();
		((ISupportInitialize)c).EndInit();
		((ISupportInitialize)d).EndInit();
		((ISupportInitialize)m_e).EndInit();
		((ISupportInitialize)f).EndInit();
		((ISupportInitialize)g).EndInit();
		((ISupportInitialize)h).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
