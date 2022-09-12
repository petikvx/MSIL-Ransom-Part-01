using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace q2H;

[DesignerGenerated]
public class Fy2 : Form
{
	private IContainer components;

	private TextBox _TextBox1;

	internal Label O;

	internal GroupBox m;

	internal PictureBox u;

	internal PictureBox p;

	internal TextBox C;

	internal PictureBox K;

	public Fy2()
	{
		f8F();
	}

	protected override void Jz1(bool Mi3)
	{
		try
		{
			if (Mi3 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Mi3);
		}
	}

	private void f8F()
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Fy2));
		Kk3(new Label());
		z9M(new GroupBox());
		f3A(new PictureBox());
		Qy7(new PictureBox());
		Gz3(new PictureBox());
		b8X(new TextBox());
		r1W(new TextBox());
		((Control)Co9()).SuspendLayout();
		((ISupportInitialize)j7L()).BeginInit();
		((ISupportInitialize)q3J()).BeginInit();
		((ISupportInitialize)f1N()).BeginInit();
		((Control)this).SuspendLayout();
		Bf1().set_AutoSize(true);
		((Control)Bf1()).set_Font(new Font("Monotype Corsiva", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Bf1()).set_ForeColor(SystemColors.ControlLight);
		((Control)Bf1()).set_Location(new Point(102, 76));
		((Control)Bf1()).set_Name("Label6");
		((Control)Bf1()).set_Size(new Size(165, 22));
		((Control)Bf1()).set_TabIndex(331);
		Bf1().set_Text("MOVIE SYNOPSIS");
		((Control)Co9()).get_Controls().Add((Control)(object)j7L());
		((Control)Co9()).set_ForeColor(SystemColors.ControlLight);
		((Control)Co9()).set_Location(new Point(444, 36));
		((Control)Co9()).set_Name("GroupBox3");
		((Control)Co9()).set_Size(new Size(200, 271));
		((Control)Co9()).set_TabIndex(330);
		Co9().set_TabStop(false);
		Co9().set_Text("Movie On Display");
		((Control)j7L()).set_BackColor(Color.Transparent);
		((Control)j7L()).set_Location(new Point(19, 23));
		((Control)j7L()).set_Name("PictureBox17");
		((Control)j7L()).set_Size(new Size(163, 224));
		j7L().set_SizeMode((PictureBoxSizeMode)1);
		j7L().set_TabIndex(28);
		j7L().set_TabStop(false);
		((Control)q3J()).set_Dock((DockStyle)3);
		((Control)q3J()).set_Location(new Point(0, 0));
		((Control)q3J()).set_Name("PictureBox1");
		((Control)q3J()).set_Size(new Size(391, 370));
		q3J().set_TabIndex(329);
		q3J().set_TabStop(false);
		((Control)f1N()).set_Location(new Point(390, -7));
		((Control)f1N()).set_Name("PictureBox2");
		((Control)f1N()).set_Size(new Size(296, 384));
		f1N().set_SizeMode((PictureBoxSizeMode)1);
		f1N().set_TabIndex(328);
		f1N().set_TabStop(false);
		((TextBoxBase)Dx8()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)Dx8()).set_BorderStyle((BorderStyle)0);
		((Control)Dx8()).set_Enabled(false);
		((Control)Dx8()).set_Font(new Font("Monotype Corsiva", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Dx8()).set_Location(new Point(81, 121));
		Dx8().set_Multiline(true);
		((Control)Dx8()).set_Name("TextBox1");
		((TextBoxBase)Dx8()).set_ReadOnly(true);
		((Control)Dx8()).set_Size(new Size(219, 157));
		((Control)Dx8()).set_TabIndex(332);
		Dx8().set_Text(componentResourceManager.GetString("TextBox1.Text"));
		((TextBoxBase)b6H()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)b6H()).set_BorderStyle((BorderStyle)0);
		((Control)b6H()).set_Enabled(false);
		((Control)b6H()).set_Font(new Font("Monotype Corsiva", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)b6H()).set_Location(new Point(81, 121));
		b6H().set_Multiline(true);
		((Control)b6H()).set_Name("TextBox2");
		((TextBoxBase)b6H()).set_ReadOnly(true);
		((Control)b6H()).set_Size(new Size(219, 174));
		((Control)b6H()).set_TabIndex(333);
		b6H().set_Text(componentResourceManager.GetString("TextBox2.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(687, 370));
		((Control)this).get_Controls().Add((Control)(object)b6H());
		((Control)this).get_Controls().Add((Control)(object)Bf1());
		((Control)this).get_Controls().Add((Control)(object)Co9());
		((Control)this).get_Controls().Add((Control)(object)q3J());
		((Control)this).get_Controls().Add((Control)(object)f1N());
		((Control)this).get_Controls().Add((Control)(object)Dx8());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MovieSynopsis3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYNOPSIS");
		((Control)Co9()).ResumeLayout(false);
		((ISupportInitialize)j7L()).EndInit();
		((ISupportInitialize)q3J()).EndInit();
		((ISupportInitialize)f1N()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Bf1()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kk3(Label i0Q)
	{
		Label val = (O = i0Q);
	}

	[SpecialName]
	internal virtual GroupBox Co9()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z9M(GroupBox Ak6)
	{
		GroupBox val = (m = Ak6);
	}

	[SpecialName]
	internal virtual PictureBox q3J()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qy7(PictureBox Ps3)
	{
		PictureBox val = (u = Ps3);
	}

	[SpecialName]
	internal virtual PictureBox f1N()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gz3(PictureBox j9K)
	{
		PictureBox val = (p = j9K);
	}

	[SpecialName]
	internal virtual TextBox Dx8()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8X(TextBox Dx8)
	{
		_TextBox1 = Dx8;
	}

	[SpecialName]
	internal virtual TextBox b6H()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1W(TextBox t6Z)
	{
		TextBox val = (C = t6Z);
	}

	[SpecialName]
	internal virtual PictureBox j7L()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3A(PictureBox n0F)
	{
		PictureBox val = (K = n0F);
	}
}
