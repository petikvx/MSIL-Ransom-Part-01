using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using s8Z;

namespace r5W;

[DesignerGenerated]
public class p8B : Form
{
	private IContainer components;

	private Label _Label1;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	internal Button V;

	internal PictureBox B;

	public p8B()
	{
		s7M();
	}

	protected override void o7G(bool He1)
	{
		try
		{
			if (He1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(He1);
		}
	}

	private void s7M()
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
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(p8B));
		p7R(new Label());
		t2J(new PictureBox());
		Qg8(new PictureBox());
		Gt6(new Button());
		b3E(new PictureBox());
		((ISupportInitialize)e6H()).BeginInit();
		((ISupportInitialize)i8B()).BeginInit();
		((ISupportInitialize)Mc8()).BeginInit();
		((Control)this).SuspendLayout();
		c9H().set_AutoSize(true);
		((Control)c9H()).set_Location(new Point(86, 73));
		((Control)c9H()).set_Name("Label1");
		((Control)c9H()).set_Size(new Size(0, 13));
		((Control)c9H()).set_TabIndex(0);
		((Control)e6H()).set_Anchor((AnchorStyles)15);
		((Control)e6H()).set_BackColor(Color.Transparent);
		((Control)e6H()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)e6H()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)e6H()).set_Location(new Point(12, 23));
		((Control)e6H()).set_Name("PictureBox1");
		((Control)e6H()).set_Size(new Size(761, 47));
		e6H().set_TabIndex(1);
		e6H().set_TabStop(false);
		((Control)i8B()).set_Anchor((AnchorStyles)15);
		((Control)i8B()).set_BackColor(Color.Transparent);
		((Control)i8B()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)i8B()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)i8B()).set_Location(new Point(203, 99));
		((Control)i8B()).set_Name("PictureBox2");
		((Control)i8B()).set_Size(new Size(125, 106));
		i8B().set_TabIndex(2);
		i8B().set_TabStop(false);
		((Control)Dg7()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Dg7()).set_BackColor(Color.Transparent);
		((Control)Dg7()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button1.BackgroundImage"));
		((Control)Dg7()).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)Dg7()).set_FlatStyle((FlatStyle)1);
		((Control)Dg7()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Dg7()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Dg7()).set_Location(new Point(224, 262));
		((Control)Dg7()).set_Name("Button1");
		((Control)Dg7()).set_Size(new Size(148, 36));
		((Control)Dg7()).set_TabIndex(3);
		((ButtonBase)Dg7()).set_UseVisualStyleBackColor(false);
		((Control)Mc8()).set_Anchor((AnchorStyles)15);
		((Control)Mc8()).set_BackColor(Color.Transparent);
		((Control)Mc8()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox5.BackgroundImage"));
		((Control)Mc8()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Mc8()).set_Location(new Point(160, 262));
		((Control)Mc8()).set_Name("PictureBox5");
		((Control)Mc8()).set_Size(new Size(58, 40));
		Mc8().set_TabIndex(13);
		Mc8().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(557, 330));
		((Control)this).get_Controls().Add((Control)(object)Mc8());
		((Control)this).get_Controls().Add((Control)(object)Dg7());
		((Control)this).get_Controls().Add((Control)(object)i8B());
		((Control)this).get_Controls().Add((Control)(object)e6H());
		((Control)this).get_Controls().Add((Control)(object)c9H());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form9");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Account");
		((ISupportInitialize)e6H()).EndInit();
		((ISupportInitialize)i8B()).EndInit();
		((ISupportInitialize)Mc8()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label c9H()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7R(Label Et7)
	{
		_Label1 = Et7;
	}

	[SpecialName]
	internal virtual PictureBox e6H()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2J(PictureBox Xn0)
	{
		_PictureBox1 = Xn0;
	}

	[SpecialName]
	internal virtual PictureBox i8B()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qg8(PictureBox Ks2)
	{
		_PictureBox2 = Ks2;
	}

	[SpecialName]
	internal virtual Button Dg7()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gt6(Button Dy8)
	{
		EventHandler eventHandler = Qr9;
		Button v = V;
		if (v != null)
		{
			((Control)v).remove_Click(eventHandler);
		}
		Button val = (V = Dy8);
		v = V;
		if (v != null)
		{
			((Control)v).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Mc8()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3E(PictureBox y6C)
	{
		EventHandler eventHandler = p1K;
		PictureBox b = B;
		if (b != null)
		{
			((Control)b).remove_Click(eventHandler);
		}
		PictureBox val = (B = y6C);
		b = B;
		if (b != null)
		{
			((Control)b).add_Click(eventHandler);
		}
	}

	private void Qr9(object sender, EventArgs e)
	{
		((Control)i1B.Forms.y1Y()).Show();
		((Form)this).Close();
	}

	private void p1K(object sender, EventArgs e)
	{
		((Control)i1B.Forms.y1Y()).Show();
		((Form)this).Close();
	}
}
