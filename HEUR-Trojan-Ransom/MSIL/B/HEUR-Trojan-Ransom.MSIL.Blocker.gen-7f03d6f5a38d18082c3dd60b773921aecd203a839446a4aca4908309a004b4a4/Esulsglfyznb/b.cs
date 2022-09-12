using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Esulsglfyznb;

public sealed class b : Form
{
	private sealed class a
	{
		public int a;

		internal void a()
		{
			Console.WriteLine(this.a.ToString());
		}
	}

	private IContainer m_a;

	private PictureBox m_b;

	private Button m_c;

	private Button d;

	private Button e;

	private CheckBox f;

	private CheckBox g;

	private CheckBox h;

	private CheckBox i;

	private Label j;

	private Label k;

	private Label l;

	private ComboBox m;

	private ComboBox n;

	private CheckedListBox o;

	private CheckedListBox p;

	private DateTimePicker q;

	private DateTimePicker r;

	public b()
	{
		a();
	}

	private void a(object sender, EventArgs e)
	{
	}

	private void b(object sender, EventArgs e)
	{
		a a2 = new a();
		a2.a = 0;
		while (a2.a < 10)
		{
			new Thread(a2.a).Start();
			a2.a++;
		}
		for (int j = 0; j < 22; j++)
		{
			Thread.Sleep(1000);
		}
		e obj = new e();
		obj.a(c);
		obj.Add(1);
		obj.Clear();
	}

	private void c(object sender, EventArgs e)
	{
		Console.WriteLine("Item Added in my List");
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
		this.m_b = new PictureBox();
		this.m_c = new Button();
		d = new Button();
		e = new Button();
		f = new CheckBox();
		g = new CheckBox();
		h = new CheckBox();
		i = new CheckBox();
		j = new Label();
		k = new Label();
		l = new Label();
		m = new ComboBox();
		n = new ComboBox();
		o = new CheckedListBox();
		p = new CheckedListBox();
		q = new DateTimePicker();
		r = new DateTimePicker();
		((ISupportInitialize)this.m_b).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).set_Dock((DockStyle)5);
		this.m_b.set_Image((Image)(object)Esulsglfyznb.g.b());
		((Control)this.m_b).set_Location(new Point(0, 0));
		((Control)this.m_b).set_Name("pictureBox1");
		((Control)this.m_b).set_Size(new Size(484, 339));
		this.m_b.set_SizeMode((PictureBoxSizeMode)1);
		this.m_b.set_TabIndex(0);
		this.m_b.set_TabStop(false);
		((Control)this.m_b).add_Click((EventHandler)a);
		((Control)this.m_c).set_Location(new Point(0, 0));
		((Control)this.m_c).set_Name("button1");
		((Control)this.m_c).set_Size(new Size(75, 23));
		((Control)this.m_c).set_TabIndex(1);
		((Control)this.m_c).set_Text("button1");
		((ButtonBase)this.m_c).set_UseVisualStyleBackColor(true);
		((Control)d).set_Location(new Point(8, 8));
		((Control)d).set_Name("button2");
		((Control)d).set_Size(new Size(75, 23));
		((Control)d).set_TabIndex(2);
		((Control)d).set_Text("button2");
		((ButtonBase)d).set_UseVisualStyleBackColor(true);
		((Control)e).set_Location(new Point(16, 16));
		((Control)e).set_Name("button3");
		((Control)e).set_Size(new Size(75, 23));
		((Control)e).set_TabIndex(3);
		((Control)e).set_Text("button3");
		((ButtonBase)e).set_UseVisualStyleBackColor(true);
		((Control)f).set_AutoSize(true);
		((Control)f).set_Location(new Point(24, 24));
		((Control)f).set_Name("checkBox1");
		((Control)f).set_Size(new Size(80, 17));
		((Control)f).set_TabIndex(4);
		((Control)f).set_Text("checkBox1");
		((ButtonBase)f).set_UseVisualStyleBackColor(true);
		((Control)g).set_AutoSize(true);
		((Control)g).set_Location(new Point(32, 32));
		((Control)g).set_Name("checkBox2");
		((Control)g).set_Size(new Size(80, 17));
		((Control)g).set_TabIndex(5);
		((Control)g).set_Text("checkBox2");
		((ButtonBase)g).set_UseVisualStyleBackColor(true);
		((Control)h).set_AutoSize(true);
		((Control)h).set_Location(new Point(40, 40));
		((Control)h).set_Name("checkBox3");
		((Control)h).set_Size(new Size(80, 17));
		((Control)h).set_TabIndex(6);
		((Control)h).set_Text("checkBox3");
		((ButtonBase)h).set_UseVisualStyleBackColor(true);
		((Control)i).set_AutoSize(true);
		((Control)i).set_Location(new Point(48, 48));
		((Control)i).set_Name("checkBox4");
		((Control)i).set_Size(new Size(80, 17));
		((Control)i).set_TabIndex(7);
		((Control)i).set_Text("checkBox4");
		((ButtonBase)i).set_UseVisualStyleBackColor(true);
		((Control)j).set_AutoSize(true);
		((Control)j).set_Location(new Point(56, 56));
		((Control)j).set_Name("label1");
		((Control)j).set_Size(new Size(35, 13));
		((Control)j).set_TabIndex(8);
		((Control)j).set_Text("label1");
		((Control)k).set_AutoSize(true);
		((Control)k).set_Location(new Point(64, 64));
		((Control)k).set_Name("label2");
		((Control)k).set_Size(new Size(35, 13));
		((Control)k).set_TabIndex(9);
		((Control)k).set_Text("label2");
		((Control)l).set_AutoSize(true);
		((Control)l).set_Location(new Point(72, 72));
		((Control)l).set_Name("label3");
		((Control)l).set_Size(new Size(35, 13));
		((Control)l).set_TabIndex(10);
		((Control)l).set_Text("label3");
		((ListControl)m).set_FormattingEnabled(true);
		((Control)m).set_Location(new Point(80, 80));
		((Control)m).set_Name("comboBox1");
		((Control)m).set_Size(new Size(121, 21));
		((Control)m).set_TabIndex(11);
		((ListControl)n).set_FormattingEnabled(true);
		((Control)n).set_Location(new Point(88, 88));
		((Control)n).set_Name("comboBox2");
		((Control)n).set_Size(new Size(121, 21));
		((Control)n).set_TabIndex(12);
		((ListControl)o).set_FormattingEnabled(true);
		((Control)o).set_Location(new Point(96, 96));
		((Control)o).set_Name("checkedListBox1");
		((Control)o).set_Size(new Size(120, 94));
		((Control)o).set_TabIndex(13);
		((ListControl)p).set_FormattingEnabled(true);
		((Control)p).set_Location(new Point(104, 104));
		((Control)p).set_Name("checkedListBox2");
		((Control)p).set_Size(new Size(120, 94));
		((Control)p).set_TabIndex(14);
		((Control)q).set_Location(new Point(112, 112));
		((Control)q).set_Name("dateTimePicker1");
		((Control)q).set_Size(new Size(200, 20));
		((Control)q).set_TabIndex(15);
		((Control)r).set_Location(new Point(124, 170));
		((Control)r).set_Name("dateTimePicker2");
		((Control)r).set_Size(new Size(200, 20));
		((Control)r).set_TabIndex(16);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(484, 339));
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
		((Control)this).get_Controls().Add((Control)(object)this.m_c);
		((Control)this).get_Controls().Add((Control)(object)this.m_b);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)b);
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
