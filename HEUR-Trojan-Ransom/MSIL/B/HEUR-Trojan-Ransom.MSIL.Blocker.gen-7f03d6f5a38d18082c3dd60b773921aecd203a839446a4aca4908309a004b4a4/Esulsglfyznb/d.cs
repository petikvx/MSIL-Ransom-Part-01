using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Esulsglfyznb;

public sealed class d : Form
{
	private IContainer m_a;

	private TextBox b;

	private TextBox c;

	private TextBox m_d;

	private RichTextBox e;

	private RichTextBox f;

	private RichTextBox g;

	private RichTextBox h;

	private LinkLabel i;

	private LinkLabel j;

	private LinkLabel k;

	private Label l;

	private Label m;

	private Label n;

	private ComboBox o;

	private ComboBox p;

	private CheckedListBox q;

	private CheckedListBox r;

	private CheckedListBox s;

	private CheckBox t;

	private CheckBox u;

	private CheckBox v;

	public d()
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
		b = new TextBox();
		c = new TextBox();
		m_d = new TextBox();
		e = new RichTextBox();
		f = new RichTextBox();
		g = new RichTextBox();
		h = new RichTextBox();
		i = new LinkLabel();
		j = new LinkLabel();
		k = new LinkLabel();
		l = new Label();
		m = new Label();
		n = new Label();
		o = new ComboBox();
		p = new ComboBox();
		q = new CheckedListBox();
		r = new CheckedListBox();
		s = new CheckedListBox();
		t = new CheckBox();
		u = new CheckBox();
		v = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)b).set_Dock((DockStyle)3);
		((Control)b).set_Location(new Point(1712, 0));
		((Control)b).set_Name("textBox3");
		((Control)b).set_Size(new Size(100, 20));
		((Control)b).set_TabIndex(41);
		((Control)c).set_Dock((DockStyle)3);
		((Control)c).set_Location(new Point(1612, 0));
		((Control)c).set_Name("textBox2");
		((Control)c).set_Size(new Size(100, 20));
		((Control)c).set_TabIndex(40);
		((Control)m_d).set_Dock((DockStyle)3);
		((Control)m_d).set_Location(new Point(1512, 0));
		((Control)m_d).set_Name("textBox1");
		((Control)m_d).set_Size(new Size(100, 20));
		((Control)m_d).set_TabIndex(39);
		((Control)e).set_Dock((DockStyle)3);
		((Control)e).set_Location(new Point(1412, 0));
		((Control)e).set_Name("richTextBox4");
		((Control)e).set_Size(new Size(100, 357));
		((Control)e).set_TabIndex(38);
		((Control)e).set_Text("");
		((Control)f).set_Dock((DockStyle)3);
		((Control)f).set_Location(new Point(1312, 0));
		((Control)f).set_Name("richTextBox3");
		((Control)f).set_Size(new Size(100, 357));
		((Control)f).set_TabIndex(37);
		((Control)f).set_Text("");
		((Control)g).set_Dock((DockStyle)3);
		((Control)g).set_Location(new Point(1212, 0));
		((Control)g).set_Name("richTextBox2");
		((Control)g).set_Size(new Size(100, 357));
		((Control)g).set_TabIndex(36);
		((Control)g).set_Text("");
		((Control)h).set_Dock((DockStyle)3);
		((Control)h).set_Location(new Point(1112, 0));
		((Control)h).set_Name("richTextBox1");
		((Control)h).set_Size(new Size(100, 357));
		((Control)h).set_TabIndex(35);
		((Control)h).set_Text("");
		((Control)i).set_AutoSize(true);
		((Control)i).set_Dock((DockStyle)3);
		((Control)i).set_Location(new Point(1057, 0));
		((Control)i).set_Name("linkLabel3");
		((Control)i).set_Size(new Size(55, 13));
		((Control)i).set_TabIndex(34);
		i.set_TabStop(true);
		((Control)i).set_Text("linkLabel3");
		((Control)j).set_AutoSize(true);
		((Control)j).set_Dock((DockStyle)3);
		((Control)j).set_Location(new Point(1002, 0));
		((Control)j).set_Name("linkLabel2");
		((Control)j).set_Size(new Size(55, 13));
		((Control)j).set_TabIndex(33);
		j.set_TabStop(true);
		((Control)j).set_Text("linkLabel2");
		((Control)k).set_AutoSize(true);
		((Control)k).set_Dock((DockStyle)3);
		((Control)k).set_Location(new Point(947, 0));
		((Control)k).set_Name("linkLabel1");
		((Control)k).set_Size(new Size(55, 13));
		((Control)k).set_TabIndex(32);
		k.set_TabStop(true);
		((Control)k).set_Text("linkLabel1");
		((Control)l).set_AutoSize(true);
		((Control)l).set_Dock((DockStyle)3);
		((Control)l).set_Location(new Point(912, 0));
		((Control)l).set_Name("label3");
		((Control)l).set_Size(new Size(35, 13));
		((Control)l).set_TabIndex(31);
		((Control)l).set_Text("label3");
		((Control)m).set_AutoSize(true);
		((Control)m).set_Dock((DockStyle)3);
		((Control)m).set_Location(new Point(877, 0));
		((Control)m).set_Name("label2");
		((Control)m).set_Size(new Size(35, 13));
		((Control)m).set_TabIndex(30);
		((Control)m).set_Text("label2");
		((Control)n).set_AutoSize(true);
		((Control)n).set_Dock((DockStyle)3);
		((Control)n).set_Location(new Point(842, 0));
		((Control)n).set_Name("label1");
		((Control)n).set_Size(new Size(35, 13));
		((Control)n).set_TabIndex(29);
		((Control)n).set_Text("label1");
		((Control)o).set_Dock((DockStyle)3);
		((ListControl)o).set_FormattingEnabled(true);
		((Control)o).set_Location(new Point(721, 0));
		((Control)o).set_Name("comboBox2");
		((Control)o).set_Size(new Size(121, 21));
		((Control)o).set_TabIndex(28);
		((Control)p).set_Dock((DockStyle)3);
		((ListControl)p).set_FormattingEnabled(true);
		((Control)p).set_Location(new Point(600, 0));
		((Control)p).set_Name("comboBox1");
		((Control)p).set_Size(new Size(121, 21));
		((Control)p).set_TabIndex(27);
		((Control)q).set_Dock((DockStyle)3);
		((ListControl)q).set_FormattingEnabled(true);
		((Control)q).set_Location(new Point(480, 0));
		((Control)q).set_Name("checkedListBox3");
		((Control)q).set_Size(new Size(120, 357));
		((Control)q).set_TabIndex(26);
		((Control)r).set_Dock((DockStyle)3);
		((ListControl)r).set_FormattingEnabled(true);
		((Control)r).set_Location(new Point(360, 0));
		((Control)r).set_Name("checkedListBox2");
		((Control)r).set_Size(new Size(120, 357));
		((Control)r).set_TabIndex(25);
		((Control)s).set_Dock((DockStyle)3);
		((ListControl)s).set_FormattingEnabled(true);
		((Control)s).set_Location(new Point(240, 0));
		((Control)s).set_Name("checkedListBox1");
		((Control)s).set_Size(new Size(120, 357));
		((Control)s).set_TabIndex(24);
		((Control)t).set_AutoSize(true);
		((Control)t).set_Dock((DockStyle)3);
		((Control)t).set_Location(new Point(160, 0));
		((Control)t).set_Name("checkBox3");
		((Control)t).set_Size(new Size(80, 357));
		((Control)t).set_TabIndex(23);
		((Control)t).set_Text("checkBox3");
		((ButtonBase)t).set_UseVisualStyleBackColor(true);
		((Control)u).set_AutoSize(true);
		((Control)u).set_Dock((DockStyle)3);
		((Control)u).set_Location(new Point(80, 0));
		((Control)u).set_Name("checkBox2");
		((Control)u).set_Size(new Size(80, 357));
		((Control)u).set_TabIndex(22);
		((Control)u).set_Text("checkBox2");
		((ButtonBase)u).set_UseVisualStyleBackColor(true);
		((Control)v).set_AutoSize(true);
		((Control)v).set_Dock((DockStyle)3);
		((Control)v).set_Location(new Point(0, 0));
		((Control)v).set_Name("checkBox1");
		((Control)v).set_Size(new Size(80, 357));
		((Control)v).set_TabIndex(21);
		((Control)v).set_Text("checkBox1");
		((ButtonBase)v).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(664, 357));
		((Control)this).get_Controls().Add((Control)(object)b);
		((Control)this).get_Controls().Add((Control)(object)c);
		((Control)this).get_Controls().Add((Control)(object)m_d);
		((Control)this).get_Controls().Add((Control)(object)e);
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).get_Controls().Add((Control)(object)g);
		((Control)this).get_Controls().Add((Control)(object)h);
		((Control)this).get_Controls().Add((Control)(object)i);
		((Control)this).get_Controls().Add((Control)(object)j);
		((Control)this).get_Controls().Add((Control)(object)k);
		((Control)this).get_Controls().Add((Control)(object)l);
		((Control)this).get_Controls().Add((Control)(object)m);
		((Control)this).get_Controls().Add((Control)(object)n);
		((Control)this).get_Controls().Add((Control)(object)o);
		((Control)this).get_Controls().Add((Control)(object)p);
		((Control)this).get_Controls().Add((Control)(object)q);
		((Control)this).get_Controls().Add((Control)(object)r);
		((Control)this).get_Controls().Add((Control)(object)s);
		((Control)this).get_Controls().Add((Control)(object)t);
		((Control)this).get_Controls().Add((Control)(object)u);
		((Control)this).get_Controls().Add((Control)(object)v);
		((Control)this).set_Name("Form3");
		((Control)this).set_Text("Form3");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
