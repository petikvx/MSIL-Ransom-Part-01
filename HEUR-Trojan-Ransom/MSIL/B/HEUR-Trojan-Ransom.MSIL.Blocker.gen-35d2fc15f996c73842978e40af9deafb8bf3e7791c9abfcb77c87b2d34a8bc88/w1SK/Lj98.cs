using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace w1SK;

[DesignerGenerated]
public class Lj98 : Form
{
	private IContainer components;

	private GroupBox _GroupBox3;

	private PictureBox _PictureBox16;

	internal TextBox M;

	internal Label A;

	internal PictureBox C;

	internal PictureBox D;

	public Lj98()
	{
		Xb79();
	}

	protected override void o9XQ(bool Ta3j)
	{
		try
		{
			if (Ta3j && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ta3j);
		}
	}

	private void Xb79()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Lj98));
		Cr21(new GroupBox());
		Bt10(new PictureBox());
		d2A5(new TextBox());
		Zr3n(new Label());
		Xe4n(new PictureBox());
		o3T5(new PictureBox());
		((Control)r9P7()).SuspendLayout();
		((ISupportInitialize)n1RN()).BeginInit();
		((ISupportInitialize)d9XF()).BeginInit();
		((ISupportInitialize)t2MJ()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)r9P7()).get_Controls().Add((Control)(object)n1RN());
		((Control)r9P7()).set_ForeColor(SystemColors.ControlLight);
		((Control)r9P7()).set_Location(new Point(437, 19));
		((Control)r9P7()).set_Name("GroupBox3");
		((Control)r9P7()).set_Size(new Size(200, 271));
		((Control)r9P7()).set_TabIndex(327);
		r9P7().set_TabStop(false);
		r9P7().set_Text("Movie On Display");
		((Control)n1RN()).set_BackColor(Color.Transparent);
		((Control)n1RN()).set_Location(new Point(22, 21));
		((Control)n1RN()).set_Name("PictureBox16");
		((Control)n1RN()).set_Size(new Size(162, 229));
		n1RN().set_SizeMode((PictureBoxSizeMode)1);
		n1RN().set_TabIndex(76);
		n1RN().set_TabStop(false);
		((TextBoxBase)Jn39()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)Jn39()).set_BorderStyle((BorderStyle)0);
		((Control)Jn39()).set_Enabled(false);
		((Control)Jn39()).set_Font(new Font("Monotype Corsiva", 9f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Jn39()).set_Location(new Point(69, 114));
		Jn39().set_Multiline(true);
		((Control)Jn39()).set_Name("TextBox1");
		((TextBoxBase)Jn39()).set_ReadOnly(true);
		((Control)Jn39()).set_Size(new Size(219, 157));
		((Control)Jn39()).set_TabIndex(329);
		Jn39().set_Text(componentResourceManager.GetString("TextBox1.Text"));
		Yz5p().set_AutoSize(true);
		((Control)Yz5p()).set_Font(new Font("Monotype Corsiva", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Yz5p()).set_ForeColor(SystemColors.ControlLight);
		((Control)Yz5p()).set_Location(new Point(95, 59));
		((Control)Yz5p()).set_Name("Label6");
		((Control)Yz5p()).set_Size(new Size(165, 22));
		((Control)Yz5p()).set_TabIndex(328);
		Yz5p().set_Text("MOVIE SYNOPSIS");
		((Control)d9XF()).set_Dock((DockStyle)3);
		((Control)d9XF()).set_Location(new Point(0, 0));
		((Control)d9XF()).set_Name("PictureBox1");
		((Control)d9XF()).set_Size(new Size(391, 370));
		d9XF().set_TabIndex(326);
		d9XF().set_TabStop(false);
		((Control)t2MJ()).set_Location(new Point(390, -7));
		((Control)t2MJ()).set_Name("PictureBox2");
		((Control)t2MJ()).set_Size(new Size(296, 384));
		t2MJ().set_SizeMode((PictureBoxSizeMode)1);
		t2MJ().set_TabIndex(325);
		t2MJ().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(687, 370));
		((Control)this).get_Controls().Add((Control)(object)r9P7());
		((Control)this).get_Controls().Add((Control)(object)Jn39());
		((Control)this).get_Controls().Add((Control)(object)Yz5p());
		((Control)this).get_Controls().Add((Control)(object)d9XF());
		((Control)this).get_Controls().Add((Control)(object)t2MJ());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MovieSynopsis4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYNOPSIS");
		((Control)r9P7()).ResumeLayout(false);
		((ISupportInitialize)n1RN()).EndInit();
		((ISupportInitialize)d9XF()).EndInit();
		((ISupportInitialize)t2MJ()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox r9P7()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cr21(GroupBox x8CN)
	{
		_GroupBox3 = x8CN;
	}

	[SpecialName]
	internal virtual TextBox Jn39()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2A5(TextBox s6XZ)
	{
		TextBox val = (M = s6XZ);
	}

	[SpecialName]
	internal virtual Label Yz5p()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zr3n(Label Lz9a)
	{
		Label val = (A = Lz9a);
	}

	[SpecialName]
	internal virtual PictureBox d9XF()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xe4n(PictureBox f5F0)
	{
		PictureBox val = (C = f5F0);
	}

	[SpecialName]
	internal virtual PictureBox t2MJ()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3T5(PictureBox Hp64)
	{
		PictureBox val = (D = Hp64);
	}

	[SpecialName]
	internal virtual PictureBox n1RN()
	{
		return _PictureBox16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt10(PictureBox q9BK)
	{
		_PictureBox16 = q9BK;
	}
}
