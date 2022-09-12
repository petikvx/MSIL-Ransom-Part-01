using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using d1Y;

namespace k7D;

[DesignerGenerated]
public class Sx0 : Form
{
	private IContainer i;

	[AccessedThroughProperty("O")]
	private VScrollBar D;

	[AccessedThroughProperty("f")]
	private TreeView q;

	[AccessedThroughProperty("r")]
	private Timer P;

	[AccessedThroughProperty("G")]
	private TextBox c;

	[AccessedThroughProperty("X")]
	private TextBox w;

	[AccessedThroughProperty("h")]
	private TextBox A;

	[AccessedThroughProperty("T")]
	private TabPage N;

	private q1S.Jy4 m_h;

	internal virtual VScrollBar O
	{
		get
		{
			return D;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			D = value;
		}
	}

	internal virtual TreeView f
	{
		get
		{
			return q;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			q = value;
		}
	}

	internal virtual TrackBar W
	{
		get
		{
			return this.m_h.Y;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_h.Y = ((value is TrackBar) ? value : null);
		}
	}

	internal virtual Timer r
	{
		get
		{
			return P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			P = value;
		}
	}

	internal virtual TextBox G
	{
		get
		{
			return c;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			c = value;
		}
	}

	internal virtual TextBox C
	{
		get
		{
			return this.m_h.v;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			this.m_h.v = value;
		}
	}

	internal virtual TextBox X
	{
		get
		{
			return w;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			w = value;
		}
	}

	internal virtual TextBox b
	{
		get
		{
			return this.m_h.a;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_h.a = ((value is TextBox) ? value : null);
		}
	}

	internal virtual TextBox V
	{
		get
		{
			return this.m_h.i;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_h.i = ((value is TextBox) ? value : null);
		}
	}

	internal virtual TextBox l
	{
		get
		{
			return this.m_h.N;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_h.N = ((value is TextBox) ? value : null);
		}
	}

	internal virtual TextBox h
	{
		get
		{
			return A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			A = value;
		}
	}

	internal virtual TabControl k
	{
		get
		{
			return this.m_h.j;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_h.j = ((value is TabControl) ? value : null);
		}
	}

	internal virtual TabPage T
	{
		get
		{
			return N;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			N = value;
		}
	}

	internal virtual TabPage Q
	{
		get
		{
			return this.m_h.f;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_h.f = ((value is TabPage) ? value : null);
		}
	}

	public Sx0()
	{
		Sj5();
	}

	protected override void De9(bool bool_0)
	{
		try
		{
			if (bool_0 && i != null)
			{
				i.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(bool_0);
		}
	}

	private void Sj5()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		i = new Container();
		O = new VScrollBar();
		f = new TreeView();
		W = new TrackBar();
		r = new Timer(i);
		G = new TextBox();
		C = new TextBox();
		X = new TextBox();
		b = new TextBox();
		V = new TextBox();
		l = new TextBox();
		h = new TextBox();
		k = new TabControl();
		T = new TabPage();
		Q = new TabPage();
		((ISupportInitialize)W).BeginInit();
		((Control)k).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)O).set_Location(new Point(651, 241));
		((Control)O).set_Name("VScrollBar1");
		((Control)O).set_Size(new Size(17, 80));
		((Control)O).set_TabIndex(0);
		((Control)f).set_Location(new Point(467, 36));
		((Control)f).set_Name("TreeView1");
		((Control)f).set_Size(new Size(121, 97));
		((Control)f).set_TabIndex(1);
		((Control)W).set_Location(new Point(607, 130));
		((Control)W).set_Name("TrackBar1");
		((Control)W).set_Size(new Size(104, 45));
		((Control)W).set_TabIndex(2);
		((Control)G).set_Location(new Point(13, 13));
		((Control)G).set_Name("TextBox1");
		((Control)G).set_Size(new Size(100, 20));
		((Control)G).set_TabIndex(3);
		((Control)C).set_Location(new Point(350, 215));
		((Control)C).set_Name("TextBox2");
		((Control)C).set_Size(new Size(100, 20));
		((Control)C).set_TabIndex(4);
		((Control)X).set_Location(new Point(358, 223));
		((Control)X).set_Name("TextBox3");
		((Control)X).set_Size(new Size(100, 20));
		((Control)X).set_TabIndex(5);
		((Control)b).set_Location(new Point(366, 231));
		((Control)b).set_Name("TextBox4");
		((Control)b).set_Size(new Size(100, 20));
		((Control)b).set_TabIndex(6);
		((Control)V).set_Location(new Point(374, 239));
		((Control)V).set_Name("TextBox5");
		((Control)V).set_Size(new Size(100, 20));
		((Control)V).set_TabIndex(7);
		((Control)l).set_Location(new Point(382, 247));
		((Control)l).set_Name("TextBox6");
		((Control)l).set_Size(new Size(100, 20));
		((Control)l).set_TabIndex(8);
		((Control)h).set_Location(new Point(390, 255));
		((Control)h).set_Name("TextBox7");
		((Control)h).set_Size(new Size(100, 20));
		((Control)h).set_TabIndex(9);
		((Control)k).get_Controls().Add((Control)(object)T);
		((Control)k).get_Controls().Add((Control)(object)Q);
		((Control)k).set_Location(new Point(68, 130));
		((Control)k).set_Name("TabControl1");
		k.set_SelectedIndex(0);
		((Control)k).set_Size(new Size(200, 100));
		((Control)k).set_TabIndex(10);
		T.set_Location(new Point(4, 22));
		((Control)T).set_Name("TabPage1");
		((Control)T).set_Padding(new Padding(3));
		((Control)T).set_Size(new Size(192, 74));
		T.set_TabIndex(0);
		T.set_Text("TabPage1");
		T.set_UseVisualStyleBackColor(true);
		Q.set_Location(new Point(4, 22));
		((Control)Q).set_Name("TabPage2");
		((Control)Q).set_Padding(new Padding(3));
		((Control)Q).set_Size(new Size(192, 74));
		Q.set_TabIndex(1);
		Q.set_Text("TabPage2");
		Q.set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)k);
		((Control)this).get_Controls().Add((Control)(object)h);
		((Control)this).get_Controls().Add((Control)(object)l);
		((Control)this).get_Controls().Add((Control)(object)V);
		((Control)this).get_Controls().Add((Control)(object)b);
		((Control)this).get_Controls().Add((Control)(object)X);
		((Control)this).get_Controls().Add((Control)(object)C);
		((Control)this).get_Controls().Add((Control)(object)G);
		((Control)this).get_Controls().Add((Control)(object)W);
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).get_Controls().Add((Control)(object)O);
		((Control)this).set_Name("g");
		((Form)this).set_Text("Form2");
		((ISupportInitialize)W).EndInit();
		((Control)k).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	internal static int a9()
	{
		while (true)
		{
			try
			{
				object obj = new WebClient();
				try
				{
					IDisposable disposable = (obj as WebClient).OpenRead("https://www.google.com");
					try
					{
						return 100;
					}
					finally
					{
						if ((Stream)disposable != null)
						{
							((IDisposable)(Stream)disposable).Dispose();
						}
					}
				}
				finally
				{
					if (obj is WebClient)
					{
						((IDisposable)(WebClient)obj).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
