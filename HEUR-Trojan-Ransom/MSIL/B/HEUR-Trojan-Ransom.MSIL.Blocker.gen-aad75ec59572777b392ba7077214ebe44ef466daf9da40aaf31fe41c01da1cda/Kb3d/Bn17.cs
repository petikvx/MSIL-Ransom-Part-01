using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Qm3;

namespace Kb3d;

[DesignerGenerated]
public class Bn17 : Form
{
	private IContainer components;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	internal Label j;

	internal Button g;

	internal PictureBox s;

	public Bn17()
	{
		Eg8m();
	}

	protected override void Tr8b(bool Ts7r)
	{
		try
		{
			if (Ts7r && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ts7r);
		}
	}

	private void Eg8m()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bn17));
		r6BD(new Label());
		Zk3j(new PictureBox());
		r5N8(new PictureBox());
		r2M6(new Button());
		g5C8(new PictureBox());
		((ISupportInitialize)a7T6()).BeginInit();
		((ISupportInitialize)Ww37()).BeginInit();
		((ISupportInitialize)a0P5()).BeginInit();
		((Control)this).SuspendLayout();
		Ns25().set_AutoSize(true);
		((Control)Ns25()).set_Location(new Point(86, 73));
		((Control)Ns25()).set_Name("Label1");
		((Control)Ns25()).set_Size(new Size(0, 13));
		((Control)Ns25()).set_TabIndex(0);
		((Control)a7T6()).set_Anchor((AnchorStyles)15);
		((Control)a7T6()).set_BackColor(Color.Transparent);
		((Control)a7T6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)a7T6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)a7T6()).set_Location(new Point(12, 23));
		((Control)a7T6()).set_Name("PictureBox1");
		((Control)a7T6()).set_Size(new Size(761, 47));
		a7T6().set_TabIndex(1);
		a7T6().set_TabStop(false);
		((Control)Ww37()).set_Anchor((AnchorStyles)15);
		((Control)Ww37()).set_BackColor(Color.Transparent);
		((Control)Ww37()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Ww37()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ww37()).set_Location(new Point(203, 99));
		((Control)Ww37()).set_Name("PictureBox2");
		((Control)Ww37()).set_Size(new Size(125, 106));
		Ww37().set_TabIndex(2);
		Ww37().set_TabStop(false);
		((Control)b6S2()).set_Anchor((AnchorStyles)15);
		((ButtonBase)b6S2()).set_BackColor(Color.Transparent);
		((Control)b6S2()).set_BackgroundImage((Image)componentResourceManager.GetObject("Button1.BackgroundImage"));
		((Control)b6S2()).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)b6S2()).set_FlatStyle((FlatStyle)1);
		((Control)b6S2()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)b6S2()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)b6S2()).set_Location(new Point(224, 262));
		((Control)b6S2()).set_Name("Button1");
		((Control)b6S2()).set_Size(new Size(148, 36));
		((Control)b6S2()).set_TabIndex(3);
		((ButtonBase)b6S2()).set_UseVisualStyleBackColor(false);
		((Control)a0P5()).set_Anchor((AnchorStyles)15);
		((Control)a0P5()).set_BackColor(Color.Transparent);
		((Control)a0P5()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox5.BackgroundImage"));
		((Control)a0P5()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)a0P5()).set_Location(new Point(160, 262));
		((Control)a0P5()).set_Name("PictureBox5");
		((Control)a0P5()).set_Size(new Size(58, 40));
		a0P5().set_TabIndex(13);
		a0P5().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(557, 330));
		((Control)this).get_Controls().Add((Control)(object)a0P5());
		((Control)this).get_Controls().Add((Control)(object)b6S2());
		((Control)this).get_Controls().Add((Control)(object)Ww37());
		((Control)this).get_Controls().Add((Control)(object)a7T6());
		((Control)this).get_Controls().Add((Control)(object)Ns25());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form9");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Account");
		((ISupportInitialize)a7T6()).EndInit();
		((ISupportInitialize)Ww37()).EndInit();
		((ISupportInitialize)a0P5()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Ns25()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6BD(Label Sq0a)
	{
		Label val = (j = Sq0a);
	}

	[SpecialName]
	internal virtual PictureBox a7T6()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk3j(PictureBox c8BT)
	{
		_PictureBox1 = c8BT;
	}

	[SpecialName]
	internal virtual PictureBox Ww37()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5N8(PictureBox Tt8p)
	{
		_PictureBox2 = Tt8p;
	}

	[SpecialName]
	internal virtual Button b6S2()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2M6(Button Be8y)
	{
		EventHandler eventHandler = Bw84;
		Button val = g;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (g = Be8y);
		val = g;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox a0P5()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5C8(PictureBox Wt0f)
	{
		EventHandler eventHandler = m9Z3;
		PictureBox val = s;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		PictureBox val2 = (s = Wt0f);
		val = s;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void Bw84(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Ek3()).Show();
		((Form)this).Close();
	}

	private void m9Z3(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Ek3()).Show();
		((Form)this).Close();
	}
}
