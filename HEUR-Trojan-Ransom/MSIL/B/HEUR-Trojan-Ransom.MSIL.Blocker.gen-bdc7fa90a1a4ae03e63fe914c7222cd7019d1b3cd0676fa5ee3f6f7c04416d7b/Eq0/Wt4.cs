using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eq0;

[DesignerGenerated]
public class Wt4 : UserControl
{
	private TabControl _TabControl1;

	private TabPage _TabPage1;

	private TrackBar _TrackBar1;

	private VScrollBar _VScrollBar1;

	internal IContainer g;

	internal StatusStrip Q;

	internal TreeView J;

	internal Splitter l;

	internal TabPage I;

	public Wt4()
	{
		Ca3();
	}

	protected override void Qe1(bool f7K)
	{
		try
		{
			if (f7K && g != null)
			{
				g.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(f7K);
		}
	}

	private void Ca3()
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
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		Xn3(new TabControl());
		Bd8(new TabPage());
		Qa6(new TabPage());
		d6J(new Splitter());
		Fd9(new TreeView());
		Kd3(new VScrollBar());
		Gk0(new TrackBar());
		e8R(new StatusStrip());
		((Control)r6C()).SuspendLayout();
		((Control)r2R()).SuspendLayout();
		((ISupportInitialize)Ce4()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)r6C()).get_Controls().Add((Control)(object)r2R());
		((Control)r6C()).get_Controls().Add((Control)(object)Kr4());
		((Control)r6C()).set_Location(new Point(31, 47));
		((Control)r6C()).set_Name("TabControl1");
		r6C().set_SelectedIndex(0);
		((Control)r6C()).set_Size(new Size(610, 375));
		((Control)r6C()).set_TabIndex(0);
		((Control)r2R()).get_Controls().Add((Control)(object)i0Z());
		((Control)r2R()).get_Controls().Add((Control)(object)Ce4());
		((Control)r2R()).get_Controls().Add((Control)(object)Gw6());
		((Control)r2R()).get_Controls().Add((Control)(object)a9Z());
		((Control)r2R()).get_Controls().Add((Control)(object)b7W());
		r2R().set_Location(new Point(4, 22));
		((Control)r2R()).set_Name("TabPage1");
		((Control)r2R()).set_Padding(new Padding(3));
		((Control)r2R()).set_Size(new Size(602, 349));
		r2R().set_TabIndex(0);
		r2R().set_Text("TabPage1");
		r2R().set_UseVisualStyleBackColor(true);
		Kr4().set_Location(new Point(4, 22));
		((Control)Kr4()).set_Name("TabPage2");
		((Control)Kr4()).set_Padding(new Padding(3));
		((Control)Kr4()).set_Size(new Size(192, 74));
		Kr4().set_TabIndex(1);
		Kr4().set_Text("TabPage2");
		Kr4().set_UseVisualStyleBackColor(true);
		((Control)b7W()).set_Location(new Point(3, 3));
		((Control)b7W()).set_Name("Splitter1");
		((Control)b7W()).set_Size(new Size(3, 343));
		((Control)b7W()).set_TabIndex(0);
		b7W().set_TabStop(false);
		((Control)a9Z()).set_Location(new Point(22, 6));
		((Control)a9Z()).set_Name("TreeView1");
		((Control)a9Z()).set_Size(new Size(121, 97));
		((Control)a9Z()).set_TabIndex(1);
		((Control)Gw6()).set_Location(new Point(560, 118));
		((Control)Gw6()).set_Name("VScrollBar1");
		((Control)Gw6()).set_Size(new Size(17, 80));
		((Control)Gw6()).set_TabIndex(2);
		((Control)Ce4()).set_Location(new Point(217, 16));
		((Control)Ce4()).set_Name("TrackBar1");
		((Control)Ce4()).set_Size(new Size(104, 45));
		((Control)Ce4()).set_TabIndex(3);
		((Control)i0Z()).set_Location(new Point(6, 324));
		((Control)i0Z()).set_Name("StatusStrip1");
		((Control)i0Z()).set_Size(new Size(593, 22));
		((Control)i0Z()).set_TabIndex(4);
		((Control)i0Z()).set_Text("StatusStrip1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)r6C());
		((Control)this).set_Name("UserControl1");
		((Control)this).set_Size(new Size(673, 443));
		((Control)r6C()).ResumeLayout(false);
		((Control)r2R()).ResumeLayout(false);
		((Control)r2R()).PerformLayout();
		((ISupportInitialize)Ce4()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual TabControl r6C()
	{
		return _TabControl1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn3(TabControl Yt1)
	{
		_TabControl1 = Yt1;
	}

	[SpecialName]
	internal virtual TabPage r2R()
	{
		return _TabPage1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd8(TabPage Ks4)
	{
		_TabPage1 = Ks4;
	}

	[SpecialName]
	internal virtual StatusStrip i0Z()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8R(StatusStrip Jf2)
	{
		StatusStrip val = (Q = Jf2);
	}

	[SpecialName]
	internal virtual TrackBar Ce4()
	{
		return _TrackBar1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gk0(TrackBar Jc7)
	{
		_TrackBar1 = Jc7;
	}

	[SpecialName]
	internal virtual VScrollBar Gw6()
	{
		return _VScrollBar1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kd3(VScrollBar r8T)
	{
		_VScrollBar1 = r8T;
	}

	[SpecialName]
	internal virtual TreeView a9Z()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fd9(TreeView c3Y)
	{
		TreeView val = (J = c3Y);
	}

	[SpecialName]
	internal virtual Splitter b7W()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6J(Splitter Fc9)
	{
		Splitter val = (l = Fc9);
	}

	[SpecialName]
	internal virtual TabPage Kr4()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qa6(TabPage Rx3)
	{
		TabPage val = (I = Rx3);
	}
}
