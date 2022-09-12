using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace f8HN;

[DesignerGenerated]
public class Cm80 : Form
{
	private IContainer components;

	private PictureBox _PictureBox1;

	internal Label I;

	internal GroupBox g;

	internal PictureBox c;

	internal TextBox S;

	internal TextBox v;

	internal PictureBox b;

	public Cm80()
	{
		c5LM();
	}

	protected override void Nk42(bool y3KC)
	{
		try
		{
			if (y3KC && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(y3KC);
		}
	}

	private void c5LM()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cm80));
		Zr54(new Label());
		a8A5(new GroupBox());
		s4E2(new PictureBox());
		Ss04(new PictureBox());
		Kf91(new PictureBox());
		Pq3m(new TextBox());
		x6X8(new TextBox());
		((Control)z5CP()).SuspendLayout();
		((ISupportInitialize)Zb51()).BeginInit();
		((ISupportInitialize)x7AZ()).BeginInit();
		((ISupportInitialize)Jw0o()).BeginInit();
		((Control)this).SuspendLayout();
		p3NT().set_AutoSize(true);
		((Control)p3NT()).set_Font(new Font("Monotype Corsiva", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)p3NT()).set_ForeColor(SystemColors.ControlLight);
		((Control)p3NT()).set_Location(new Point(102, 76));
		((Control)p3NT()).set_Name("Label6");
		((Control)p3NT()).set_Size(new Size(165, 22));
		((Control)p3NT()).set_TabIndex(331);
		p3NT().set_Text("MOVIE SYNOPSIS");
		((Control)z5CP()).get_Controls().Add((Control)(object)Zb51());
		((Control)z5CP()).set_ForeColor(SystemColors.ControlLight);
		((Control)z5CP()).set_Location(new Point(444, 36));
		((Control)z5CP()).set_Name("GroupBox3");
		((Control)z5CP()).set_Size(new Size(200, 271));
		((Control)z5CP()).set_TabIndex(330);
		z5CP().set_TabStop(false);
		z5CP().set_Text("Movie On Display");
		((Control)Zb51()).set_BackColor(Color.Transparent);
		((Control)Zb51()).set_Location(new Point(19, 23));
		((Control)Zb51()).set_Name("PictureBox17");
		((Control)Zb51()).set_Size(new Size(163, 224));
		Zb51().set_SizeMode((PictureBoxSizeMode)1);
		Zb51().set_TabIndex(28);
		Zb51().set_TabStop(false);
		((Control)x7AZ()).set_Dock((DockStyle)3);
		((Control)x7AZ()).set_Location(new Point(0, 0));
		((Control)x7AZ()).set_Name("PictureBox1");
		((Control)x7AZ()).set_Size(new Size(391, 370));
		x7AZ().set_TabIndex(329);
		x7AZ().set_TabStop(false);
		((Control)Jw0o()).set_Location(new Point(390, -7));
		((Control)Jw0o()).set_Name("PictureBox2");
		((Control)Jw0o()).set_Size(new Size(296, 384));
		Jw0o().set_SizeMode((PictureBoxSizeMode)1);
		Jw0o().set_TabIndex(328);
		Jw0o().set_TabStop(false);
		((TextBoxBase)o6ZQ()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)o6ZQ()).set_BorderStyle((BorderStyle)0);
		((Control)o6ZQ()).set_Enabled(false);
		((Control)o6ZQ()).set_Font(new Font("Monotype Corsiva", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)o6ZQ()).set_Location(new Point(81, 121));
		o6ZQ().set_Multiline(true);
		((Control)o6ZQ()).set_Name("TextBox1");
		((TextBoxBase)o6ZQ()).set_ReadOnly(true);
		((Control)o6ZQ()).set_Size(new Size(219, 157));
		((Control)o6ZQ()).set_TabIndex(332);
		o6ZQ().set_Text(componentResourceManager.GetString("TextBox1.Text"));
		((TextBoxBase)m8C0()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)m8C0()).set_BorderStyle((BorderStyle)0);
		((Control)m8C0()).set_Enabled(false);
		((Control)m8C0()).set_Font(new Font("Monotype Corsiva", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)m8C0()).set_Location(new Point(81, 121));
		m8C0().set_Multiline(true);
		((Control)m8C0()).set_Name("TextBox2");
		((TextBoxBase)m8C0()).set_ReadOnly(true);
		((Control)m8C0()).set_Size(new Size(219, 174));
		((Control)m8C0()).set_TabIndex(333);
		m8C0().set_Text(componentResourceManager.GetString("TextBox2.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(687, 370));
		((Control)this).get_Controls().Add((Control)(object)m8C0());
		((Control)this).get_Controls().Add((Control)(object)p3NT());
		((Control)this).get_Controls().Add((Control)(object)z5CP());
		((Control)this).get_Controls().Add((Control)(object)x7AZ());
		((Control)this).get_Controls().Add((Control)(object)Jw0o());
		((Control)this).get_Controls().Add((Control)(object)o6ZQ());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MovieSynopsis3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYNOPSIS");
		((Control)z5CP()).ResumeLayout(false);
		((ISupportInitialize)Zb51()).EndInit();
		((ISupportInitialize)x7AZ()).EndInit();
		((ISupportInitialize)Jw0o()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label p3NT()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zr54(Label Pr60)
	{
		Label val = (I = Pr60);
	}

	[SpecialName]
	internal virtual GroupBox z5CP()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8A5(GroupBox Hd5j)
	{
		GroupBox val = (g = Hd5j);
	}

	[SpecialName]
	internal virtual PictureBox x7AZ()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ss04(PictureBox Si5f)
	{
		_PictureBox1 = Si5f;
	}

	[SpecialName]
	internal virtual PictureBox Jw0o()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kf91(PictureBox b5L7)
	{
		PictureBox val = (c = b5L7);
	}

	[SpecialName]
	internal virtual TextBox o6ZQ()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pq3m(TextBox y4M1)
	{
		TextBox val = (S = y4M1);
	}

	[SpecialName]
	internal virtual TextBox m8C0()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6X8(TextBox n7H9)
	{
		TextBox val = (v = n7H9);
	}

	[SpecialName]
	internal virtual PictureBox Zb51()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4E2(PictureBox Sf92)
	{
		PictureBox val = (b = Sf92);
	}
}
