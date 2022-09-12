using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace f4L7;

[DesignerGenerated]
public class q4LT : Form
{
	private IContainer components;

	internal PictureBox g;

	internal PictureBox u;

	internal AxWindowsMediaPlayer k;

	public q4LT()
	{
		Yq23();
	}

	protected override void k6FS(bool Fg87)
	{
		try
		{
			if (Fg87 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fg87);
		}
	}

	private void Yq23()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(q4LT));
		z4SC(new PictureBox());
		f2X3(new PictureBox());
		n3S2(new AxWindowsMediaPlayer());
		((ISupportInitialize)e7DW()).BeginInit();
		((ISupportInitialize)e6S2()).BeginInit();
		((ISupportInitialize)Jt8b()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)e7DW()).set_BackColor(Color.Transparent);
		((Control)e7DW()).set_Location(new Point(588, 35));
		((Control)e7DW()).set_Name("PictureBox2");
		((Control)e7DW()).set_Size(new Size(163, 235));
		e7DW().set_SizeMode((PictureBoxSizeMode)1);
		e7DW().set_TabIndex(5);
		e7DW().set_TabStop(false);
		((Control)e6S2()).set_BackColor(Color.Transparent);
		((Control)e6S2()).set_Dock((DockStyle)4);
		((Control)e6S2()).set_Location(new Point(553, 0));
		((Control)e6S2()).set_Name("PictureBox1");
		((Control)e6S2()).set_Size(new Size(234, 377));
		e6S2().set_TabIndex(4);
		e6S2().set_TabStop(false);
		((AxHost)Jt8b()).set_Enabled(true);
		((Control)Jt8b()).set_Location(new Point(6, 10));
		((Control)Jt8b()).set_Name("AxWindowsMediaPlayer1");
		((AxHost)Jt8b()).set_OcxState((State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"));
		((Control)Jt8b()).set_Size(new Size(535, 356));
		((Control)Jt8b()).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 377));
		((Control)this).get_Controls().Add((Control)(object)e7DW());
		((Control)this).get_Controls().Add((Control)(object)e6S2());
		((Control)this).get_Controls().Add((Control)(object)Jt8b());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Trailer_2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TRAILER");
		((ISupportInitialize)e7DW()).EndInit();
		((ISupportInitialize)e6S2()).EndInit();
		((ISupportInitialize)Jt8b()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual PictureBox e7DW()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4SC(PictureBox Ts3d)
	{
		PictureBox val = (g = Ts3d);
	}

	[SpecialName]
	internal virtual PictureBox e6S2()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2X3(PictureBox s4X5)
	{
		PictureBox val = (u = s4X5);
	}

	[SpecialName]
	internal virtual AxWindowsMediaPlayer Jt8b()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3S2(AxWindowsMediaPlayer Pa85)
	{
		AxWindowsMediaPlayer val = (k = Pa85);
	}
}
