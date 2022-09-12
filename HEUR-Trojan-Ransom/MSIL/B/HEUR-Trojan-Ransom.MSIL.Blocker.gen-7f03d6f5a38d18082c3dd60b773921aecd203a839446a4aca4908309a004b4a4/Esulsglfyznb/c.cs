using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Esulsglfyznb;

public sealed class c : Form
{
	private IContainer m_a;

	private CheckBox b;

	private CheckBox m_c;

	private CheckBox d;

	private CheckedListBox e;

	private CheckedListBox f;

	private CheckedListBox g;

	private ComboBox h;

	private ComboBox i;

	private Label j;

	private Label k;

	private Label l;

	private LinkLabel m;

	private LinkLabel n;

	private LinkLabel o;

	private RichTextBox p;

	private RichTextBox q;

	private RichTextBox r;

	private RichTextBox s;

	private TextBox t;

	private TextBox u;

	private TextBox v;

	public c()
	{
		a();
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		b = new CheckBox();
		m_c = new CheckBox();
		d = new CheckBox();
		e = new CheckedListBox();
		f = new CheckedListBox();
		g = new CheckedListBox();
		h = new ComboBox();
		i = new ComboBox();
		j = new Label();
		k = new Label();
		l = new Label();
		m = new LinkLabel();
		n = new LinkLabel();
		o = new LinkLabel();
		p = new RichTextBox();
		q = new RichTextBox();
		r = new RichTextBox();
		s = new RichTextBox();
		t = new TextBox();
		u = new TextBox();
		v = new TextBox();
		((Control)this).SuspendLayout();
		((Control)b).set_AutoSize(true);
		((Control)b).set_Dock((DockStyle)1);
		((Control)b).set_Location(new Point(0, 0));
		((Control)b).set_Name("checkBox1");
		((Control)b).set_Size(new Size(678, 17));
		((Control)b).set_TabIndex(0);
		((Control)b).set_Text("checkBox1");
		((ButtonBase)b).set_UseVisualStyleBackColor(true);
		((Control)m_c).set_AutoSize(true);
		((Control)m_c).set_Dock((DockStyle)1);
		((Control)m_c).set_Location(new Point(0, 17));
		((Control)m_c).set_Name("checkBox2");
		((Control)m_c).set_Size(new Size(678, 17));
		((Control)m_c).set_TabIndex(1);
		((Control)m_c).set_Text("checkBox2");
		((ButtonBase)m_c).set_UseVisualStyleBackColor(true);
		((Control)d).set_AutoSize(true);
		((Control)d).set_Dock((DockStyle)1);
		((Control)d).set_Location(new Point(0, 34));
		((Control)d).set_Name("checkBox3");
		((Control)d).set_Size(new Size(678, 17));
		((Control)d).set_TabIndex(2);
		((Control)d).set_Text("checkBox3");
		((ButtonBase)d).set_UseVisualStyleBackColor(true);
		((Control)e).set_Dock((DockStyle)1);
		((ListControl)e).set_FormattingEnabled(true);
		((Control)e).set_Location(new Point(0, 51));
		((Control)e).set_Name("checkedListBox1");
		((Control)e).set_Size(new Size(678, 94));
		((Control)e).set_TabIndex(3);
		((Control)f).set_Dock((DockStyle)1);
		((ListControl)f).set_FormattingEnabled(true);
		((Control)f).set_Location(new Point(0, 145));
		((Control)f).set_Name("checkedListBox2");
		((Control)f).set_Size(new Size(678, 94));
		((Control)f).set_TabIndex(4);
		((Control)g).set_Dock((DockStyle)1);
		((ListControl)g).set_FormattingEnabled(true);
		((Control)g).set_Location(new Point(0, 239));
		((Control)g).set_Name("checkedListBox3");
		((Control)g).set_Size(new Size(678, 94));
		((Control)g).set_TabIndex(5);
		((Control)h).set_Dock((DockStyle)1);
		((ListControl)h).set_FormattingEnabled(true);
		((Control)h).set_Location(new Point(0, 333));
		((Control)h).set_Name("comboBox1");
		((Control)h).set_Size(new Size(678, 21));
		((Control)h).set_TabIndex(6);
		((Control)i).set_Dock((DockStyle)1);
		((ListControl)i).set_FormattingEnabled(true);
		((Control)i).set_Location(new Point(0, 354));
		((Control)i).set_Name("comboBox2");
		((Control)i).set_Size(new Size(678, 21));
		((Control)i).set_TabIndex(7);
		((Control)j).set_AutoSize(true);
		((Control)j).set_Dock((DockStyle)1);
		((Control)j).set_Location(new Point(0, 375));
		((Control)j).set_Name("label1");
		((Control)j).set_Size(new Size(35, 13));
		((Control)j).set_TabIndex(8);
		((Control)j).set_Text("label1");
		((Control)k).set_AutoSize(true);
		((Control)k).set_Dock((DockStyle)1);
		((Control)k).set_Location(new Point(0, 388));
		((Control)k).set_Name("label2");
		((Control)k).set_Size(new Size(35, 13));
		((Control)k).set_TabIndex(9);
		((Control)k).set_Text("label2");
		((Control)l).set_AutoSize(true);
		((Control)l).set_Dock((DockStyle)1);
		((Control)l).set_Location(new Point(0, 401));
		((Control)l).set_Name("label3");
		((Control)l).set_Size(new Size(35, 13));
		((Control)l).set_TabIndex(10);
		((Control)l).set_Text("label3");
		((Control)m).set_AutoSize(true);
		((Control)m).set_Dock((DockStyle)1);
		((Control)m).set_Location(new Point(0, 414));
		((Control)m).set_Name("linkLabel1");
		((Control)m).set_Size(new Size(55, 13));
		((Control)m).set_TabIndex(11);
		m.set_TabStop(true);
		((Control)m).set_Text("linkLabel1");
		((Control)n).set_AutoSize(true);
		((Control)n).set_Dock((DockStyle)1);
		((Control)n).set_Location(new Point(0, 427));
		((Control)n).set_Name("linkLabel2");
		((Control)n).set_Size(new Size(55, 13));
		((Control)n).set_TabIndex(12);
		n.set_TabStop(true);
		((Control)n).set_Text("linkLabel2");
		((Control)o).set_AutoSize(true);
		((Control)o).set_Dock((DockStyle)1);
		((Control)o).set_Location(new Point(0, 440));
		((Control)o).set_Name("linkLabel3");
		((Control)o).set_Size(new Size(55, 13));
		((Control)o).set_TabIndex(13);
		o.set_TabStop(true);
		((Control)o).set_Text("linkLabel3");
		((Control)p).set_Dock((DockStyle)1);
		((Control)p).set_Location(new Point(0, 453));
		((Control)p).set_Name("richTextBox1");
		((Control)p).set_Size(new Size(678, 96));
		((Control)p).set_TabIndex(14);
		((Control)p).set_Text("");
		((Control)q).set_Dock((DockStyle)1);
		((Control)q).set_Location(new Point(0, 549));
		((Control)q).set_Name("richTextBox2");
		((Control)q).set_Size(new Size(678, 96));
		((Control)q).set_TabIndex(15);
		((Control)q).set_Text("");
		((Control)r).set_Dock((DockStyle)1);
		((Control)r).set_Location(new Point(0, 645));
		((Control)r).set_Name("richTextBox3");
		((Control)r).set_Size(new Size(678, 96));
		((Control)r).set_TabIndex(16);
		((Control)r).set_Text("");
		((Control)s).set_Dock((DockStyle)1);
		((Control)s).set_Location(new Point(0, 741));
		((Control)s).set_Name("richTextBox4");
		((Control)s).set_Size(new Size(678, 96));
		((Control)s).set_TabIndex(17);
		((Control)s).set_Text("");
		((Control)t).set_Dock((DockStyle)1);
		((Control)t).set_Location(new Point(0, 837));
		((Control)t).set_Name("textBox1");
		((Control)t).set_Size(new Size(678, 20));
		((Control)t).set_TabIndex(18);
		((Control)u).set_Dock((DockStyle)1);
		((Control)u).set_Location(new Point(0, 857));
		((Control)u).set_Name("textBox2");
		((Control)u).set_Size(new Size(678, 20));
		((Control)u).set_TabIndex(19);
		((Control)v).set_Dock((DockStyle)1);
		((Control)v).set_Location(new Point(0, 877));
		((Control)v).set_Name("textBox3");
		((Control)v).set_Size(new Size(678, 20));
		((Control)v).set_TabIndex(20);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(678, 386));
		((Control)this).get_Controls().Add((Control)(object)v);
		((Control)this).get_Controls().Add((Control)(object)u);
		((Control)this).get_Controls().Add((Control)(object)t);
		((Control)this).get_Controls().Add((Control)(object)s);
		((Control)this).get_Controls().Add((Control)(object)r);
		((Control)this).get_Controls().Add((Control)(object)q);
		((Control)this).get_Controls().Add((Control)(object)p);
		((Control)this).get_Controls().Add((Control)(object)o);
		((Control)this).get_Controls().Add((Control)(object)n);
		((Control)this).get_Controls().Add((Control)(object)m);
		((Control)this).get_Controls().Add((Control)(object)l);
		((Control)this).get_Controls().Add((Control)(object)k);
		((Control)this).get_Controls().Add((Control)(object)j);
		((Control)this).get_Controls().Add((Control)(object)i);
		((Control)this).get_Controls().Add((Control)(object)h);
		((Control)this).get_Controls().Add((Control)(object)g);
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).get_Controls().Add((Control)(object)e);
		((Control)this).get_Controls().Add((Control)(object)d);
		((Control)this).get_Controls().Add((Control)(object)m_c);
		((Control)this).get_Controls().Add((Control)(object)b);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
