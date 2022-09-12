using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace w1G9;

[DesignerGenerated]
public class Bj21 : Form
{
	private PictureBox _PictureBox14;

	private GroupBox _GroupBox3;

	private Label _Label6;

	private TextBox _TextBox1;

	internal IContainer Q;

	internal PictureBox a;

	internal PictureBox h;

	public Bj21()
	{
		x8PQ();
	}

	protected override void s9D6(bool e4Y7)
	{
		try
		{
			if (e4Y7 && Q != null)
			{
				Q.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e4Y7);
		}
	}

	private void x8PQ()
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
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bj21));
		Ho16(new PictureBox());
		Aq07(new PictureBox());
		Zt39(new PictureBox());
		r5QK(new GroupBox());
		Go28(new Label());
		i1F2(new TextBox());
		((ISupportInitialize)De0o()).BeginInit();
		((ISupportInitialize)Jt45()).BeginInit();
		((ISupportInitialize)m3Q1()).BeginInit();
		((Control)y6NF()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)De0o()).set_Location(new Point(389, -1));
		((Control)De0o()).set_Name("PictureBox2");
		((Control)De0o()).set_Size(new Size(296, 384));
		De0o().set_SizeMode((PictureBoxSizeMode)1);
		De0o().set_TabIndex(317);
		De0o().set_TabStop(false);
		((Control)Jt45()).set_Dock((DockStyle)3);
		((Control)Jt45()).set_Location(new Point(0, 0));
		((Control)Jt45()).set_Name("PictureBox1");
		((Control)Jt45()).set_Size(new Size(391, 370));
		Jt45().set_TabIndex(318);
		Jt45().set_TabStop(false);
		((Control)m3Q1()).set_BackColor(Color.Transparent);
		((Control)m3Q1()).set_Location(new Point(19, 19));
		((Control)m3Q1()).set_Name("PictureBox14");
		((Control)m3Q1()).set_Size(new Size(157, 233));
		m3Q1().set_SizeMode((PictureBoxSizeMode)1);
		m3Q1().set_TabIndex(319);
		m3Q1().set_TabStop(false);
		((Control)y6NF()).get_Controls().Add((Control)(object)m3Q1());
		((Control)y6NF()).set_ForeColor(SystemColors.ControlLight);
		((Control)y6NF()).set_Location(new Point(436, 25));
		((Control)y6NF()).set_Name("GroupBox3");
		((Control)y6NF()).set_Size(new Size(200, 271));
		((Control)y6NF()).set_TabIndex(321);
		y6NF().set_TabStop(false);
		y6NF().set_Text("Movie On Display");
		Yf8b().set_AutoSize(true);
		((Control)Yf8b()).set_Font(new Font("Monotype Corsiva", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Yf8b()).set_ForeColor(SystemColors.ControlLight);
		((Control)Yf8b()).set_Location(new Point(94, 65));
		((Control)Yf8b()).set_Name("Label6");
		((Control)Yf8b()).set_Size(new Size(165, 22));
		((Control)Yf8b()).set_TabIndex(323);
		Yf8b().set_Text("MOVIE SYNOPSIS");
		((TextBoxBase)z9HW()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)z9HW()).set_BorderStyle((BorderStyle)0);
		((Control)z9HW()).set_Enabled(false);
		((Control)z9HW()).set_Font(new Font("Monotype Corsiva", 9f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)z9HW()).set_Location(new Point(68, 120));
		z9HW().set_Multiline(true);
		((Control)z9HW()).set_Name("TextBox1");
		((TextBoxBase)z9HW()).set_ReadOnly(true);
		((Control)z9HW()).set_Size(new Size(219, 157));
		((Control)z9HW()).set_TabIndex(324);
		z9HW().set_Text(componentResourceManager.GetString("TextBox1.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(687, 370));
		((Control)this).get_Controls().Add((Control)(object)z9HW());
		((Control)this).get_Controls().Add((Control)(object)Yf8b());
		((Control)this).get_Controls().Add((Control)(object)y6NF());
		((Control)this).get_Controls().Add((Control)(object)Jt45());
		((Control)this).get_Controls().Add((Control)(object)De0o());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MovieSynopsis1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYNOPSIS");
		((ISupportInitialize)De0o()).EndInit();
		((ISupportInitialize)Jt45()).EndInit();
		((ISupportInitialize)m3Q1()).EndInit();
		((Control)y6NF()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox De0o()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ho16(PictureBox Cz16)
	{
		PictureBox val = (a = Cz16);
	}

	[SpecialName]
	internal virtual PictureBox Jt45()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aq07(PictureBox Ci38)
	{
		PictureBox val = (h = Ci38);
	}

	[SpecialName]
	internal virtual PictureBox m3Q1()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zt39(PictureBox Js2p)
	{
		_PictureBox14 = Js2p;
	}

	[SpecialName]
	internal virtual GroupBox y6NF()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5QK(GroupBox b9WB)
	{
		_GroupBox3 = b9WB;
	}

	[SpecialName]
	internal virtual Label Yf8b()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go28(Label t2W8)
	{
		_Label6 = t2W8;
	}

	[SpecialName]
	internal virtual TextBox z9HW()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1F2(TextBox Tc97)
	{
		_TextBox1 = Tc97;
	}
}
