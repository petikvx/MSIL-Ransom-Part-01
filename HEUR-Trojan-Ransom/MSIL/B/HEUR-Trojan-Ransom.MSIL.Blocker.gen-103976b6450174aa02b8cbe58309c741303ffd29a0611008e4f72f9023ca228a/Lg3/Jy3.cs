using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Lg3;

[DesignerGenerated]
public class Jy3 : Form
{
	private PictureBox _PictureBox2;

	private Label _Label6;

	private PictureBox _PictureBox15;

	private TextBox _TextBox1;

	internal IContainer x;

	internal PictureBox l;

	internal GroupBox c;

	public Jy3()
	{
		r1T();
	}

	protected override void Go6(bool z7C)
	{
		try
		{
			if (z7C && x != null)
			{
				x.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(z7C);
		}
	}

	private void r1T()
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
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Jy3));
		Xx4(new PictureBox());
		Qm0(new PictureBox());
		Hc8(new Label());
		Jw8(new GroupBox());
		Da0(new PictureBox());
		d7A(new TextBox());
		((ISupportInitialize)Df0()).BeginInit();
		((ISupportInitialize)Ja3()).BeginInit();
		((Control)Fx4()).SuspendLayout();
		((ISupportInitialize)Ka1()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Df0()).set_Dock((DockStyle)3);
		((Control)Df0()).set_Location(new Point(0, 0));
		((Control)Df0()).set_Name("PictureBox1");
		((Control)Df0()).set_Size(new Size(391, 370));
		Df0().set_TabIndex(320);
		Df0().set_TabStop(false);
		((Control)Ja3()).set_Location(new Point(390, -7));
		((Control)Ja3()).set_Name("PictureBox2");
		((Control)Ja3()).set_Size(new Size(296, 384));
		Ja3().set_SizeMode((PictureBoxSizeMode)1);
		Ja3().set_TabIndex(319);
		Ja3().set_TabStop(false);
		q4G().set_AutoSize(true);
		((Control)q4G()).set_Font(new Font("Monotype Corsiva", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)q4G()).set_ForeColor(SystemColors.ControlLight);
		((Control)q4G()).set_Location(new Point(102, 76));
		((Control)q4G()).set_Name("Label6");
		((Control)q4G()).set_Size(new Size(165, 22));
		((Control)q4G()).set_TabIndex(326);
		q4G().set_Text("MOVIE SYNOPSIS");
		((Control)Fx4()).get_Controls().Add((Control)(object)Ka1());
		((Control)Fx4()).set_ForeColor(SystemColors.ControlLight);
		((Control)Fx4()).set_Location(new Point(444, 36));
		((Control)Fx4()).set_Name("GroupBox3");
		((Control)Fx4()).set_Size(new Size(200, 271));
		((Control)Fx4()).set_TabIndex(325);
		Fx4().set_TabStop(false);
		Fx4().set_Text("Movie On Display");
		((Control)Ka1()).set_BackColor(Color.Transparent);
		((Control)Ka1()).set_Location(new Point(18, 28));
		((Control)Ka1()).set_Name("PictureBox15");
		((Control)Ka1()).set_Size(new Size(158, 224));
		Ka1().set_SizeMode((PictureBoxSizeMode)1);
		Ka1().set_TabIndex(26);
		Ka1().set_TabStop(false);
		((TextBoxBase)m1C()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)m1C()).set_BorderStyle((BorderStyle)0);
		((Control)m1C()).set_Enabled(false);
		((Control)m1C()).set_Font(new Font("Monotype Corsiva", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)m1C()).set_Location(new Point(81, 121));
		m1C().set_Multiline(true);
		((Control)m1C()).set_Name("TextBox1");
		((TextBoxBase)m1C()).set_ReadOnly(true);
		((Control)m1C()).set_Size(new Size(219, 157));
		((Control)m1C()).set_TabIndex(327);
		m1C().set_Text(componentResourceManager.GetString("TextBox1.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(687, 370));
		((Control)this).get_Controls().Add((Control)(object)m1C());
		((Control)this).get_Controls().Add((Control)(object)q4G());
		((Control)this).get_Controls().Add((Control)(object)Fx4());
		((Control)this).get_Controls().Add((Control)(object)Df0());
		((Control)this).get_Controls().Add((Control)(object)Ja3());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MoviesSynopsis2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYNOPSIS");
		((ISupportInitialize)Df0()).EndInit();
		((ISupportInitialize)Ja3()).EndInit();
		((Control)Fx4()).ResumeLayout(false);
		((ISupportInitialize)Ka1()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox Df0()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xx4(PictureBox c0G)
	{
		PictureBox val = (l = c0G);
	}

	[SpecialName]
	internal virtual PictureBox Ja3()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm0(PictureBox Jd1)
	{
		_PictureBox2 = Jd1;
	}

	[SpecialName]
	internal virtual Label q4G()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hc8(Label Bt5)
	{
		_Label6 = Bt5;
	}

	[SpecialName]
	internal virtual GroupBox Fx4()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jw8(GroupBox y9H)
	{
		GroupBox val = (c = y9H);
	}

	[SpecialName]
	internal virtual PictureBox Ka1()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Da0(PictureBox Pf6)
	{
		_PictureBox15 = Pf6;
	}

	[SpecialName]
	internal virtual TextBox m1C()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7A(TextBox s8Q)
	{
		_TextBox1 = s8Q;
	}
}
