using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace g6HE;

[DesignerGenerated]
public class Xj5a : Form
{
	private IContainer components;

	internal PictureBox g;

	internal PictureBox u;

	internal AxWindowsMediaPlayer k;

	public Xj5a()
	{
		Bn9d();
	}

	protected override void e8PQ(bool Fa5e)
	{
		try
		{
			if (Fa5e && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fa5e);
		}
	}

	private void Bn9d()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Xj5a));
		Rp09(new PictureBox());
		x7G8(new PictureBox());
		Dq0p(new AxWindowsMediaPlayer());
		((ISupportInitialize)a3LZ()).BeginInit();
		((ISupportInitialize)c7GE()).BeginInit();
		((ISupportInitialize)n1KD()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)a3LZ()).set_BackColor(Color.Transparent);
		((Control)a3LZ()).set_Dock((DockStyle)4);
		((Control)a3LZ()).set_Location(new Point(553, 0));
		((Control)a3LZ()).set_Name("PictureBox1");
		((Control)a3LZ()).set_Size(new Size(234, 377));
		a3LZ().set_TabIndex(0);
		a3LZ().set_TabStop(false);
		((Control)c7GE()).set_BackColor(Color.Transparent);
		((Control)c7GE()).set_Location(new Point(584, 45));
		((Control)c7GE()).set_Name("PictureBox2");
		((Control)c7GE()).set_Size(new Size(163, 235));
		c7GE().set_SizeMode((PictureBoxSizeMode)1);
		c7GE().set_TabIndex(1);
		c7GE().set_TabStop(false);
		((AxHost)n1KD()).set_Enabled(true);
		((Control)n1KD()).set_Location(new Point(12, 10));
		((Control)n1KD()).set_Name("AxWindowsMediaPlayer1");
		((AxHost)n1KD()).set_OcxState((State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"));
		((Control)n1KD()).set_Size(new Size(535, 356));
		((Control)n1KD()).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 377));
		((Control)this).get_Controls().Add((Control)(object)n1KD());
		((Control)this).get_Controls().Add((Control)(object)c7GE());
		((Control)this).get_Controls().Add((Control)(object)a3LZ());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Trailer_1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TRAILER");
		((ISupportInitialize)a3LZ()).EndInit();
		((ISupportInitialize)c7GE()).EndInit();
		((ISupportInitialize)n1KD()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual PictureBox a3LZ()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rp09(PictureBox Dg26)
	{
		PictureBox val = (g = Dg26);
	}

	[SpecialName]
	internal virtual PictureBox c7GE()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7G8(PictureBox Ao5x)
	{
		PictureBox val = (u = Ao5x);
	}

	[SpecialName]
	internal virtual AxWindowsMediaPlayer n1KD()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dq0p(AxWindowsMediaPlayer Ji0e)
	{
		AxWindowsMediaPlayer val = (k = Ji0e);
	}
}
