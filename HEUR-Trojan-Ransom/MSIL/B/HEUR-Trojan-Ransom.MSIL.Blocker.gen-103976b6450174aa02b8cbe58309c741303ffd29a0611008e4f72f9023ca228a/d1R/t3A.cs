using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace d1R;

[DesignerGenerated]
public class t3A : Form
{
	internal IContainer U;

	internal GroupBox N;

	internal TextBox r;

	internal Label A;

	internal PictureBox V;

	internal PictureBox E;

	internal PictureBox t;

	public t3A()
	{
		Jm4();
	}

	protected override void b2X(bool Fy3)
	{
		try
		{
			if (Fy3 && U != null)
			{
				U.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fy3);
		}
	}

	private void Jm4()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(t3A));
		Ha2(new GroupBox());
		d1Y(new PictureBox());
		o4Z(new TextBox());
		w3H(new Label());
		x1X(new PictureBox());
		o7P(new PictureBox());
		((Control)Dy3()).SuspendLayout();
		((ISupportInitialize)We0()).BeginInit();
		((ISupportInitialize)Bp4()).BeginInit();
		((ISupportInitialize)t6P()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Dy3()).get_Controls().Add((Control)(object)We0());
		((Control)Dy3()).set_ForeColor(SystemColors.ControlLight);
		((Control)Dy3()).set_Location(new Point(437, 19));
		((Control)Dy3()).set_Name("GroupBox3");
		((Control)Dy3()).set_Size(new Size(200, 271));
		((Control)Dy3()).set_TabIndex(327);
		Dy3().set_TabStop(false);
		Dy3().set_Text("Movie On Display");
		((Control)We0()).set_BackColor(Color.Transparent);
		((Control)We0()).set_Location(new Point(22, 21));
		((Control)We0()).set_Name("PictureBox16");
		((Control)We0()).set_Size(new Size(162, 229));
		We0().set_SizeMode((PictureBoxSizeMode)1);
		We0().set_TabIndex(76);
		We0().set_TabStop(false);
		((TextBoxBase)k1L()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)k1L()).set_BorderStyle((BorderStyle)0);
		((Control)k1L()).set_Enabled(false);
		((Control)k1L()).set_Font(new Font("Monotype Corsiva", 9f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)k1L()).set_Location(new Point(69, 114));
		k1L().set_Multiline(true);
		((Control)k1L()).set_Name("TextBox1");
		((TextBoxBase)k1L()).set_ReadOnly(true);
		((Control)k1L()).set_Size(new Size(219, 157));
		((Control)k1L()).set_TabIndex(329);
		k1L().set_Text(componentResourceManager.GetString("TextBox1.Text"));
		Qz6().set_AutoSize(true);
		((Control)Qz6()).set_Font(new Font("Monotype Corsiva", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Qz6()).set_ForeColor(SystemColors.ControlLight);
		((Control)Qz6()).set_Location(new Point(95, 59));
		((Control)Qz6()).set_Name("Label6");
		((Control)Qz6()).set_Size(new Size(165, 22));
		((Control)Qz6()).set_TabIndex(328);
		Qz6().set_Text("MOVIE SYNOPSIS");
		((Control)Bp4()).set_Dock((DockStyle)3);
		((Control)Bp4()).set_Location(new Point(0, 0));
		((Control)Bp4()).set_Name("PictureBox1");
		((Control)Bp4()).set_Size(new Size(391, 370));
		Bp4().set_TabIndex(326);
		Bp4().set_TabStop(false);
		((Control)t6P()).set_Location(new Point(390, -7));
		((Control)t6P()).set_Name("PictureBox2");
		((Control)t6P()).set_Size(new Size(296, 384));
		t6P().set_SizeMode((PictureBoxSizeMode)1);
		t6P().set_TabIndex(325);
		t6P().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(687, 370));
		((Control)this).get_Controls().Add((Control)(object)Dy3());
		((Control)this).get_Controls().Add((Control)(object)k1L());
		((Control)this).get_Controls().Add((Control)(object)Qz6());
		((Control)this).get_Controls().Add((Control)(object)Bp4());
		((Control)this).get_Controls().Add((Control)(object)t6P());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MovieSynopsis4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYNOPSIS");
		((Control)Dy3()).ResumeLayout(false);
		((ISupportInitialize)We0()).EndInit();
		((ISupportInitialize)Bp4()).EndInit();
		((ISupportInitialize)t6P()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox Dy3()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ha2(GroupBox a3S)
	{
		GroupBox val = (N = a3S);
	}

	[SpecialName]
	internal virtual TextBox k1L()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4Z(TextBox Lc3)
	{
		TextBox val = (r = Lc3);
	}

	[SpecialName]
	internal virtual Label Qz6()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3H(Label g4F)
	{
		Label val = (A = g4F);
	}

	[SpecialName]
	internal virtual PictureBox Bp4()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1X(PictureBox r6Z)
	{
		PictureBox val = (V = r6Z);
	}

	[SpecialName]
	internal virtual PictureBox t6P()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7P(PictureBox Xy4)
	{
		PictureBox val = (E = Xy4);
	}

	[SpecialName]
	internal virtual PictureBox We0()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1Y(PictureBox o5Z)
	{
		PictureBox val = (t = o5Z);
	}
}
