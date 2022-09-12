using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pf;
using b8;

namespace Jg5;

[DesignerGenerated]
public class Cf7 : Form
{
	public class Xq4
	{
		private Assembly m_x;

		private string C;

		private string G;

		private int S;

		internal static Nj t/* Not supported: data(44 55 C9 15 72 A1 E2 1B 7F 15 82 46 7C C1 61 49 31 07 13 02 B8 77 2A 7A 4F 2E 06 5D FA A0 D1 E6 93 E6 03 28 3D 46 1D 2E 8A E7 CD 40 80 5A 35 69 40 DD AA A8 4D 7D D3 EC 05 4A C8 7F 34 E9 F4 B3 B1 38 C3 A0 58 5E C4 6D 8A 83 F5 4F 7C 81 0E 7E 69 E4 40 39 09 FA D7 FF 12 0C 6D 8D A1 C3 31 78 2F 9F 5A 72 B0 BA 72 B5 6C 5B 35 7A 0E 6C 77 14 48 BB 3C 38 A0 3E D4 6C 34 C9 A7 D4 5A FF 68 87 DE 18 C3 C3 79 41 8B 8D AD FE 36 33 46 63 9E 96 86 A6 2E C8 B3 49 49 AE C2 46 A8 5A 23 5D D3 4F 07 E5 1C 05 A4 4D AA D7 16 C5 C1 33 88 58 7A BE B4 34 E1 49 7A B2 4E 4B 54 11 A8 14 D9 B4 C1 0F E4 39 A1 72 F8 E6 4E 48 F4 4B 16 36 83 79 F8 6B 13 0F 12 24 EC 0E 3D 93 81 30 C4 BD B4 CD A0 60 18 DB CC EE CB 87 18 C4 02 87 B0 27 51 C2 1C E5 3B 6B FD 82 D6 58 CC B4 BB 80 F8 17 49 85 DE 91 54 13 F2 39 64 74 20 D4 AE 73 D4 14 DF 03 F1 AE 97 8B AB E1 96 C8 03 A1 D5 24 49 C5 F8 8D EF 76 2B 7C D9 51 35 70 86 22 DB 8C C0 F0 BD 88 34 12 4F B0 DC 01 12 DD F5 C8 3E DD B6 C4 3C EB 1A F7 C7 9E 0C 7D E8 7F 8E F6 5F 49 93 F9 F1 EC 43 C6 ED EA D8 D8 80 38 56 A5 18 5F 4D 21 46 C0 F0 A5 03 F5 E5 E1 A0 38 E1 2E C2 A7 C3 62 02 05 93 22 33 B1 30 62) */;

		internal static char[] X;

		private a0.Kz m_c = new a0.Kz();

		public int O
		{
			get
			{
				return this.m_c.Y;
			}
			set
			{
				this.m_c.Y = value;
			}
		}

		public Assembly x
		{
			get
			{
				return this.m_x;
			}
			set
			{
				this.m_x = value;
			}
		}

		public string[] x
		{
			get
			{
				return this.m_c.v;
			}
			set
			{
				this.m_c.v = value as string[];
			}
		}

		public byte[] h
		{
			get
			{
				return this.m_c.a;
			}
			set
			{
				this.m_c.a = value as byte[];
			}
		}

		public byte[] c
		{
			get
			{
				return this.m_c.i;
			}
			set
			{
				this.m_c.i = value as byte[];
			}
		}

		public string Y
		{
			get
			{
				return C;
			}
			set
			{
				C = value;
			}
		}

		public string v
		{
			get
			{
				return G;
			}
			set
			{
				G = value;
			}
		}

		public int f
		{
			get
			{
				return S;
			}
			set
			{
				S = value;
			}
		}

		public int W
		{
			get
			{
				return this.m_c.N;
			}
			set
			{
				this.m_c.N = value;
			}
		}

		public string a
		{
			get
			{
				return this.m_c.j;
			}
			set
			{
				this.m_c.j = value;
			}
		}
	}

	private IContainer q;

	[AccessedThroughProperty("V")]
	private Button j;

	[AccessedThroughProperty("l")]
	private Button e;

	[AccessedThroughProperty("J")]
	private HScrollBar y;

	private a0.Dg a = new a0.Dg();

	internal virtual BackgroundWorker O
	{
		get
		{
			return a.g;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a.g = value;
		}
	}

	internal virtual Button f
	{
		get
		{
			return a.d;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			a.d = value;
		}
	}

	internal virtual Button W
	{
		get
		{
			return a.n;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			a.n = value;
		}
	}

	internal virtual Button r
	{
		get
		{
			return a.L;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			a.L = value;
		}
	}

	internal virtual Button G
	{
		get
		{
			return a.e;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			a.e = value;
		}
	}

	internal virtual Button C
	{
		get
		{
			return a.C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			a.C = value;
		}
	}

	internal virtual Button X
	{
		get
		{
			return a.h;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a.h = ((value is Button) ? value : null);
		}
	}

	internal virtual Button b
	{
		get
		{
			return a.o;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a.o = ((value is Button) ? value : null);
		}
	}

	internal virtual Button V
	{
		get
		{
			return j;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			j = value;
		}
	}

	internal virtual Button l
	{
		get
		{
			return e;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			e = value;
		}
	}

	internal virtual Button h
	{
		get
		{
			return a.u;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a.u = ((value is Button) ? value : null);
		}
	}

	internal virtual DataGridView k
	{
		get
		{
			return a.w;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a.w = ((value is DataGridView) ? value : null);
		}
	}

	internal virtual ComboBox T
	{
		get
		{
			return a.F;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a.F = ((value is ComboBox) ? value : null);
		}
	}

	internal virtual GroupBox Q
	{
		get
		{
			return a.v;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			a.v = value;
		}
	}

	internal virtual HScrollBar J
	{
		get
		{
			return y;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			y = value;
		}
	}

	public Cf7()
	{
		k8B();
	}

	protected override void x9Y(bool bool_0)
	{
		try
		{
			if (bool_0 && q != null)
			{
				q.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(bool_0);
		}
	}

	private void k8B()
	{
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
		O = new BackgroundWorker();
		f = new Button();
		W = new Button();
		r = new Button();
		G = new Button();
		C = new Button();
		X = new Button();
		b = new Button();
		V = new Button();
		l = new Button();
		h = new Button();
		k = new DataGridView();
		T = new ComboBox();
		Q = new GroupBox();
		J = new HScrollBar();
		((ISupportInitialize)k).BeginInit();
		((Control)this).SuspendLayout();
		((Control)f).set_Location(new Point(44, 13));
		((Control)f).set_Name("Button1");
		((Control)f).set_Size(new Size(75, 23));
		((Control)f).set_TabIndex(0);
		((ButtonBase)f).set_Text("Button1");
		((ButtonBase)f).set_UseVisualStyleBackColor(true);
		((Control)W).set_Location(new Point(363, 214));
		((Control)W).set_Name("Button2");
		((Control)W).set_Size(new Size(75, 23));
		((Control)W).set_TabIndex(1);
		((ButtonBase)W).set_Text("Button2");
		((ButtonBase)W).set_UseVisualStyleBackColor(true);
		((Control)r).set_Location(new Point(371, 222));
		((Control)r).set_Name("Button3");
		((Control)r).set_Size(new Size(75, 23));
		((Control)r).set_TabIndex(2);
		((ButtonBase)r).set_Text("Button3");
		((ButtonBase)r).set_UseVisualStyleBackColor(true);
		((Control)G).set_Location(new Point(379, 230));
		((Control)G).set_Name("Button4");
		((Control)G).set_Size(new Size(75, 23));
		((Control)G).set_TabIndex(3);
		((ButtonBase)G).set_Text("Button4");
		((ButtonBase)G).set_UseVisualStyleBackColor(true);
		((Control)C).set_Location(new Point(387, 238));
		((Control)C).set_Name("Button5");
		((Control)C).set_Size(new Size(75, 23));
		((Control)C).set_TabIndex(4);
		((ButtonBase)C).set_Text("Button5");
		((ButtonBase)C).set_UseVisualStyleBackColor(true);
		((Control)X).set_Location(new Point(395, 246));
		((Control)X).set_Name("Button6");
		((Control)X).set_Size(new Size(75, 23));
		((Control)X).set_TabIndex(5);
		((ButtonBase)X).set_Text("Button6");
		((ButtonBase)X).set_UseVisualStyleBackColor(true);
		((Control)b).set_Location(new Point(403, 254));
		((Control)b).set_Name("Button7");
		((Control)b).set_Size(new Size(75, 23));
		((Control)b).set_TabIndex(6);
		((ButtonBase)b).set_Text("Button7");
		((ButtonBase)b).set_UseVisualStyleBackColor(true);
		((Control)V).set_Location(new Point(411, 262));
		((Control)V).set_Name("Button8");
		((Control)V).set_Size(new Size(75, 23));
		((Control)V).set_TabIndex(7);
		((ButtonBase)V).set_Text("Button8");
		((ButtonBase)V).set_UseVisualStyleBackColor(true);
		((Control)l).set_Location(new Point(419, 270));
		((Control)l).set_Name("Button9");
		((Control)l).set_Size(new Size(75, 23));
		((Control)l).set_TabIndex(8);
		((ButtonBase)l).set_Text("Button9");
		((ButtonBase)l).set_UseVisualStyleBackColor(true);
		((Control)h).set_Location(new Point(427, 278));
		((Control)h).set_Name("Button10");
		((Control)h).set_Size(new Size(75, 23));
		((Control)h).set_TabIndex(9);
		((ButtonBase)h).set_Text("Button10");
		((ButtonBase)h).set_UseVisualStyleBackColor(true);
		k.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)k).set_Location(new Point(205, 85));
		((Control)k).set_Name("DataGridView1");
		((Control)k).set_Size(new Size(240, 150));
		((Control)k).set_TabIndex(10);
		((ListControl)T).set_FormattingEnabled(true);
		((Control)T).set_Location(new Point(519, 46));
		((Control)T).set_Name("ComboBox1");
		((Control)T).set_Size(new Size(121, 21));
		((Control)T).set_TabIndex(11);
		((Control)Q).set_Location(new Point(439, 173));
		((Control)Q).set_Name("GroupBox1");
		((Control)Q).set_Size(new Size(200, 100));
		((Control)Q).set_TabIndex(12);
		Q.set_TabStop(false);
		Q.set_Text("GroupBox1");
		((Control)J).set_Location(new Point(379, 368));
		((Control)J).set_Name("HScrollBar1");
		((Control)J).set_Size(new Size(80, 17));
		((Control)J).set_TabIndex(13);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)J);
		((Control)this).get_Controls().Add((Control)(object)Q);
		((Control)this).get_Controls().Add((Control)(object)T);
		((Control)this).get_Controls().Add((Control)(object)k);
		((Control)this).get_Controls().Add((Control)(object)h);
		((Control)this).get_Controls().Add((Control)(object)l);
		((Control)this).get_Controls().Add((Control)(object)V);
		((Control)this).get_Controls().Add((Control)(object)b);
		((Control)this).get_Controls().Add((Control)(object)X);
		((Control)this).get_Controls().Add((Control)(object)C);
		((Control)this).get_Controls().Add((Control)(object)G);
		((Control)this).get_Controls().Add((Control)(object)r);
		((Control)this).get_Controls().Add((Control)(object)W);
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).set_Name("a");
		((Form)this).set_Text("Form1");
		((ISupportInitialize)k).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
