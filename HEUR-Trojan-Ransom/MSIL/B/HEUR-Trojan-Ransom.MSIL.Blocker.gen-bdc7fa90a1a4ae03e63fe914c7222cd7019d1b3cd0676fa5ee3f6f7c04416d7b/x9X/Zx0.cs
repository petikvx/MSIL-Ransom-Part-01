using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using d0E;
using y4S;

namespace x9X;

[DesignerGenerated]
public class Zx0 : Form
{
	private IContainer components;

	private MenuStrip _MenuStrip1;

	private ToolStripMenuItem _SALESToolStripMenuItem;

	private ToolStripMenuItem _STOCKToolStripMenuItem;

	internal ToolStripMenuItem D;

	internal Panel b;

	internal Label E;

	internal DataGridView X;

	public Zx0()
	{
		Gt5();
	}

	protected override void x9D(bool Ay8)
	{
		try
		{
			if (Ay8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ay8);
		}
	}

	private void Gt5()
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
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		p9S(new MenuStrip());
		d3J(new ToolStripMenuItem());
		Eb2(new ToolStripMenuItem());
		j2T(new ToolStripMenuItem());
		Fk6(new Panel());
		o2K(new Label());
		Bb6(new DataGridView());
		((Control)Gz2()).SuspendLayout();
		((Control)Ym2()).SuspendLayout();
		((ISupportInitialize)b5Q()).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStrip)Gz2()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)b6T(),
			(ToolStripItem)w3R(),
			(ToolStripItem)Zd6()
		});
		((Control)Gz2()).set_Location(new Point(0, 0));
		((Control)Gz2()).set_Name("MenuStrip1");
		((Control)Gz2()).set_Size(new Size(1370, 24));
		((Control)Gz2()).set_TabIndex(0);
		((Control)Gz2()).set_Text("MenuStrip1");
		((ToolStripItem)b6T()).set_Name("ADMINToolStripMenuItem");
		((ToolStripItem)b6T()).set_Size(new Size(58, 20));
		((ToolStripItem)b6T()).set_Text("ADMIN");
		((ToolStripItem)w3R()).set_Name("SALESToolStripMenuItem");
		((ToolStripItem)w3R()).set_Size(new Size(51, 20));
		((ToolStripItem)w3R()).set_Text("SALES");
		((ToolStripItem)Zd6()).set_Name("STOCKToolStripMenuItem");
		((ToolStripItem)Zd6()).set_Size(new Size(55, 20));
		((ToolStripItem)Zd6()).set_Text("STOCK");
		((Control)Ym2()).get_Controls().Add((Control)(object)b5Q());
		((Control)Ym2()).get_Controls().Add((Control)(object)s1W());
		((Control)Ym2()).set_Location(new Point(0, 27));
		((Control)Ym2()).set_Name("Panel1");
		((Control)Ym2()).set_Size(new Size(1370, 721));
		((Control)Ym2()).set_TabIndex(1);
		s1W().set_AutoSize(true);
		((Control)s1W()).set_BackColor(Color.Transparent);
		((Control)s1W()).set_Font(new Font("Times New Roman", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)s1W()).set_ForeColor(Color.Lime);
		((Control)s1W()).set_Location(new Point(571, 29));
		((Control)s1W()).set_Name("lblSales");
		((Control)s1W()).set_Size(new Size(331, 73));
		((Control)s1W()).set_TabIndex(2);
		s1W().set_Text("Sales Menu");
		b5Q().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)b5Q()).set_Location(new Point(384, 139));
		((Control)b5Q()).set_Name("DataGridView1");
		((Control)b5Q()).set_Size(new Size(736, 522));
		((Control)b5Q()).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1370, 749));
		((Control)this).get_Controls().Add((Control)(object)Ym2());
		((Control)this).get_Controls().Add((Control)(object)Gz2());
		((Form)this).set_MainMenuStrip(Gz2());
		((Control)this).set_Name("Form2");
		((Form)this).set_Text("Form2");
		((Control)Gz2()).ResumeLayout(false);
		((Control)Gz2()).PerformLayout();
		((Control)Ym2()).ResumeLayout(false);
		((Control)Ym2()).PerformLayout();
		((ISupportInitialize)b5Q()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual MenuStrip Gz2()
	{
		return _MenuStrip1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9S(MenuStrip Xr9)
	{
		_MenuStrip1 = Xr9;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem b6T()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d3J(ToolStripMenuItem d3A)
	{
		EventHandler eventHandler = z6Q;
		ToolStripMenuItem d = D;
		if (d != null)
		{
			((ToolStripItem)d).remove_Click(eventHandler);
		}
		ToolStripMenuItem val = (D = d3A);
		d = D;
		if (d != null)
		{
			((ToolStripItem)d).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem w3R()
	{
		return _SALESToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb2(ToolStripMenuItem n1A)
	{
		_SALESToolStripMenuItem = n1A;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Zd6()
	{
		return _STOCKToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2T(ToolStripMenuItem Zp5)
	{
		_STOCKToolStripMenuItem = Zp5;
	}

	[SpecialName]
	internal virtual Panel Ym2()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fk6(Panel Gk0)
	{
		Panel val = (b = Gk0);
	}

	[SpecialName]
	internal virtual Label s1W()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2K(Label z4S)
	{
		Label val = (E = z4S);
	}

	[SpecialName]
	internal virtual DataGridView b5Q()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bb6(DataGridView Dn1)
	{
		DataGridView val = (X = Dn1);
	}

	private void z6Q(object sender, EventArgs e)
	{
		((Control)Ym2()).set_Visible(false);
	}

	internal static void Tg7()
	{
		int num = 0;
		num = 20;
		Cj0.mDic.Add(Cj0.sNum, 20);
		if (20 != Convert.ToInt32(RuntimeHelpers.GetObjectValue(Cj0.mDic[Cj0.sNum])))
		{
			num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Cj0.mDic[Cj0.sNum]));
		}
		byte[] value = Xw9.Qi5(num);
		Cj0.mDic.Add(Cj0.sArray, value);
	}

	public static byte a2E(byte k0K, byte[] Xk3, int Yy9, int z4Y)
	{
		checked
		{
			k0K = Cj0.f6B(k0K, (byte)(Xk3[unchecked(z4Y % Xk3.Length)] ^ ((z4Y + unchecked(Yy9 % Xk3.Length)) & Yy9)));
			return k0K;
		}
	}
}
