using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace e8Z;

[DesignerGenerated]
public class Gx1 : Form
{
	private IContainer components;

	private PictureBox _PictureBox1;

	private Label _Label6;

	private TextBox _TextBox1;

	internal PictureBox v;

	internal PictureBox S;

	internal GroupBox U;

	public Gx1()
	{
		j8M();
	}

	protected override void Fn3(bool e9M)
	{
		try
		{
			if (e9M && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e9M);
		}
	}

	private void j8M()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gx1));
		j6Z(new PictureBox());
		r6C(new PictureBox());
		m2P(new PictureBox());
		i9K(new GroupBox());
		x3C(new Label());
		Xz7(new TextBox());
		((ISupportInitialize)m6M()).BeginInit();
		((ISupportInitialize)Zy6()).BeginInit();
		((ISupportInitialize)p1R()).BeginInit();
		((Control)n3D()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)m6M()).set_Location(new Point(389, -1));
		((Control)m6M()).set_Name("PictureBox2");
		((Control)m6M()).set_Size(new Size(296, 384));
		m6M().set_SizeMode((PictureBoxSizeMode)1);
		m6M().set_TabIndex(317);
		m6M().set_TabStop(false);
		((Control)Zy6()).set_Dock((DockStyle)3);
		((Control)Zy6()).set_Location(new Point(0, 0));
		((Control)Zy6()).set_Name("PictureBox1");
		((Control)Zy6()).set_Size(new Size(391, 370));
		Zy6().set_TabIndex(318);
		Zy6().set_TabStop(false);
		((Control)p1R()).set_BackColor(Color.Transparent);
		((Control)p1R()).set_Location(new Point(19, 19));
		((Control)p1R()).set_Name("PictureBox14");
		((Control)p1R()).set_Size(new Size(157, 233));
		p1R().set_SizeMode((PictureBoxSizeMode)1);
		p1R().set_TabIndex(319);
		p1R().set_TabStop(false);
		((Control)n3D()).get_Controls().Add((Control)(object)p1R());
		((Control)n3D()).set_ForeColor(SystemColors.ControlLight);
		((Control)n3D()).set_Location(new Point(436, 25));
		((Control)n3D()).set_Name("GroupBox3");
		((Control)n3D()).set_Size(new Size(200, 271));
		((Control)n3D()).set_TabIndex(321);
		n3D().set_TabStop(false);
		n3D().set_Text("Movie On Display");
		Mo9().set_AutoSize(true);
		((Control)Mo9()).set_Font(new Font("Monotype Corsiva", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Mo9()).set_ForeColor(SystemColors.ControlLight);
		((Control)Mo9()).set_Location(new Point(94, 65));
		((Control)Mo9()).set_Name("Label6");
		((Control)Mo9()).set_Size(new Size(165, 22));
		((Control)Mo9()).set_TabIndex(323);
		Mo9().set_Text("MOVIE SYNOPSIS");
		((TextBoxBase)r7X()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)r7X()).set_BorderStyle((BorderStyle)0);
		((Control)r7X()).set_Enabled(false);
		((Control)r7X()).set_Font(new Font("Monotype Corsiva", 9f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)r7X()).set_Location(new Point(68, 120));
		r7X().set_Multiline(true);
		((Control)r7X()).set_Name("TextBox1");
		((TextBoxBase)r7X()).set_ReadOnly(true);
		((Control)r7X()).set_Size(new Size(219, 157));
		((Control)r7X()).set_TabIndex(324);
		r7X().set_Text(componentResourceManager.GetString("TextBox1.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(687, 370));
		((Control)this).get_Controls().Add((Control)(object)r7X());
		((Control)this).get_Controls().Add((Control)(object)Mo9());
		((Control)this).get_Controls().Add((Control)(object)n3D());
		((Control)this).get_Controls().Add((Control)(object)Zy6());
		((Control)this).get_Controls().Add((Control)(object)m6M());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MovieSynopsis1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYNOPSIS");
		((ISupportInitialize)m6M()).EndInit();
		((ISupportInitialize)Zy6()).EndInit();
		((ISupportInitialize)p1R()).EndInit();
		((Control)n3D()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox m6M()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6Z(PictureBox m4Q)
	{
		PictureBox val = (v = m4Q);
	}

	[SpecialName]
	internal virtual PictureBox Zy6()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6C(PictureBox Ys9)
	{
		_PictureBox1 = Ys9;
	}

	[SpecialName]
	internal virtual PictureBox p1R()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2P(PictureBox o8R)
	{
		PictureBox val = (S = o8R);
	}

	[SpecialName]
	internal virtual GroupBox n3D()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9K(GroupBox Kd0)
	{
		GroupBox val = (U = Kd0);
	}

	[SpecialName]
	internal virtual Label Mo9()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3C(Label Ta4)
	{
		_Label6 = Ta4;
	}

	[SpecialName]
	internal virtual TextBox r7X()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xz7(TextBox x2R)
	{
		_TextBox1 = x2R;
	}
}
