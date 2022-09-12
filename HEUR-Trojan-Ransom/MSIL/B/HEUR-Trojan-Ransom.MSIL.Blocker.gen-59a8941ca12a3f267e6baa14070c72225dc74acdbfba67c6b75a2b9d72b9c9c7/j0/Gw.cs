using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ma2;
using Microsoft.VisualBasic.CompilerServices;

namespace j0;

[DesignerGenerated]
public class Gw : Form
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Qd
	{
		internal object Y;

		internal string v;

		internal object a;
	}

	[AccessedThroughProperty("O")]
	private TableLayoutPanel S;

	[AccessedThroughProperty("r")]
	private RadioButton N;

	[AccessedThroughProperty("G")]
	private RadioButton o;

	[AccessedThroughProperty("X")]
	private RadioButton l;

	private Fr7.Pd6 i = new Fr7.Pd6();

	internal virtual TableLayoutPanel O
	{
		get
		{
			return S;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			S = value;
		}
	}

	internal virtual SaveFileDialog f
	{
		get
		{
			return i.W;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			i.W = ((value is SaveFileDialog) ? value : null);
		}
	}

	internal virtual RichTextBox W
	{
		get
		{
			return i.q;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			i.q = ((value is RichTextBox) ? value : null);
		}
	}

	internal virtual RadioButton r
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

	internal virtual RadioButton G
	{
		get
		{
			return o;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			o = value;
		}
	}

	internal virtual RadioButton C
	{
		get
		{
			return i.y;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			i.y = value;
		}
	}

	internal virtual RadioButton X
	{
		get
		{
			return l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			l = value;
		}
	}

	public Gw()
	{
		Yk();
	}

	protected override void Qc(bool bool_0)
	{
		try
		{
			if (bool_0 && i.x != null)
			{
				i.x.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(bool_0);
		}
	}

	private void Yk()
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
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		O = new TableLayoutPanel();
		f = new SaveFileDialog();
		W = new RichTextBox();
		r = new RadioButton();
		G = new RadioButton();
		C = new RadioButton();
		X = new RadioButton();
		((Control)this).SuspendLayout();
		O.set_ColumnCount(2);
		O.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		O.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		((Control)O).set_Location(new Point(539, 30));
		((Control)O).set_Name("TableLayoutPanel1");
		O.set_RowCount(2);
		O.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		O.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)O).set_Size(new Size(200, 100));
		((Control)O).set_TabIndex(0);
		((Control)W).set_Location(new Point(47, 13));
		((Control)W).set_Name("RichTextBox1");
		((Control)W).set_Size(new Size(460, 279));
		((Control)W).set_TabIndex(1);
		W.set_Text("");
		((ButtonBase)r).set_AutoSize(true);
		((Control)r).set_Location(new Point(563, 158));
		((Control)r).set_Name("RadioButton1");
		((Control)r).set_Size(new Size(90, 17));
		((Control)r).set_TabIndex(2);
		r.set_TabStop(true);
		((ButtonBase)r).set_Text("RadioButton1");
		((ButtonBase)r).set_UseVisualStyleBackColor(true);
		((ButtonBase)G).set_AutoSize(true);
		((Control)G).set_Location(new Point(355, 217));
		((Control)G).set_Name("RadioButton2");
		((Control)G).set_Size(new Size(90, 17));
		((Control)G).set_TabIndex(3);
		G.set_TabStop(true);
		((ButtonBase)G).set_Text("RadioButton2");
		((ButtonBase)G).set_UseVisualStyleBackColor(true);
		((ButtonBase)C).set_AutoSize(true);
		((Control)C).set_Location(new Point(363, 225));
		((Control)C).set_Name("RadioButton3");
		((Control)C).set_Size(new Size(90, 17));
		((Control)C).set_TabIndex(4);
		C.set_TabStop(true);
		((ButtonBase)C).set_Text("RadioButton3");
		((ButtonBase)C).set_UseVisualStyleBackColor(true);
		((ButtonBase)X).set_AutoSize(true);
		((Control)X).set_Location(new Point(371, 233));
		((Control)X).set_Name("RadioButton4");
		((Control)X).set_Size(new Size(90, 17));
		((Control)X).set_TabIndex(5);
		X.set_TabStop(true);
		((ButtonBase)X).set_Text("RadioButton4");
		((ButtonBase)X).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)X);
		((Control)this).get_Controls().Add((Control)(object)C);
		((Control)this).get_Controls().Add((Control)(object)G);
		((Control)this).get_Controls().Add((Control)(object)r);
		((Control)this).get_Controls().Add((Control)(object)W);
		((Control)this).get_Controls().Add((Control)(object)O);
		((Control)this).set_Name("f");
		((Form)this).set_Text("Form3");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
