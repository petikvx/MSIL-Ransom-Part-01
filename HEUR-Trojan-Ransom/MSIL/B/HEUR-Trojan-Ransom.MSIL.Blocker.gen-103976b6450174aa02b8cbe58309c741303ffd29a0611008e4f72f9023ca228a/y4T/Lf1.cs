using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace y4T;

[DesignerGenerated]
public class Lf1 : Form
{
	private IContainer components;

	private PictureBox _PictureBox1;

	internal PictureBox R;

	internal AxWindowsMediaPlayer E;

	public Lf1()
	{
		t7S();
	}

	protected override void m5J(bool Gq6)
	{
		try
		{
			if (Gq6 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gq6);
		}
	}

	private void t7S()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Lf1));
		Gn3(new PictureBox());
		i0B(new PictureBox());
		y1D(new AxWindowsMediaPlayer());
		((ISupportInitialize)Nx1()).BeginInit();
		((ISupportInitialize)j1G()).BeginInit();
		((ISupportInitialize)Zm3()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Nx1()).set_BackColor(Color.Transparent);
		((Control)Nx1()).set_Location(new Point(586, 35));
		((Control)Nx1()).set_Name("PictureBox2");
		((Control)Nx1()).set_Size(new Size(163, 235));
		Nx1().set_SizeMode((PictureBoxSizeMode)1);
		Nx1().set_TabIndex(9);
		Nx1().set_TabStop(false);
		((Control)j1G()).set_BackColor(Color.Transparent);
		((Control)j1G()).set_Dock((DockStyle)4);
		((Control)j1G()).set_Location(new Point(553, 0));
		((Control)j1G()).set_Name("PictureBox1");
		((Control)j1G()).set_Size(new Size(234, 377));
		j1G().set_TabIndex(8);
		j1G().set_TabStop(false);
		((AxHost)Zm3()).set_Enabled(true);
		((Control)Zm3()).set_Location(new Point(3, 10));
		((Control)Zm3()).set_Name("AxWindowsMediaPlayer1");
		((AxHost)Zm3()).set_OcxState((State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"));
		((Control)Zm3()).set_Size(new Size(535, 356));
		((Control)Zm3()).set_TabIndex(11);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 377));
		((Control)this).get_Controls().Add((Control)(object)Nx1());
		((Control)this).get_Controls().Add((Control)(object)j1G());
		((Control)this).get_Controls().Add((Control)(object)Zm3());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Trailer_3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TRAILER");
		((ISupportInitialize)Nx1()).EndInit();
		((ISupportInitialize)j1G()).EndInit();
		((ISupportInitialize)Zm3()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual PictureBox Nx1()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gn3(PictureBox Kk5)
	{
		PictureBox val = (R = Kk5);
	}

	[SpecialName]
	internal virtual PictureBox j1G()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0B(PictureBox Er4)
	{
		_PictureBox1 = Er4;
	}

	[SpecialName]
	internal virtual AxWindowsMediaPlayer Zm3()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1D(AxWindowsMediaPlayer Yk9)
	{
		AxWindowsMediaPlayer val = (E = Yk9);
	}
}
