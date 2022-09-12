using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace An0z;

[DesignerGenerated]
public class Wj1q : Form
{
	private PictureBox _PictureBox1;

	private AxWindowsMediaPlayer _AxWindowsMediaPlayer1;

	internal IContainer i;

	internal PictureBox g;

	public Wj1q()
	{
		Ms84();
	}

	protected override void Aw6r(bool Pd69)
	{
		try
		{
			if (Pd69 && i != null)
			{
				i.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pd69);
		}
	}

	private void Ms84()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Wj1q));
		p3L4(new PictureBox());
		Zb84(new PictureBox());
		k4R8(new AxWindowsMediaPlayer());
		((ISupportInitialize)Gg9a()).BeginInit();
		((ISupportInitialize)t3W8()).BeginInit();
		((ISupportInitialize)Mx79()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Gg9a()).set_BackColor(Color.Transparent);
		((Control)Gg9a()).set_Location(new Point(588, 35));
		((Control)Gg9a()).set_Name("PictureBox2");
		((Control)Gg9a()).set_Size(new Size(163, 235));
		Gg9a().set_SizeMode((PictureBoxSizeMode)1);
		Gg9a().set_TabIndex(5);
		Gg9a().set_TabStop(false);
		((Control)t3W8()).set_BackColor(Color.Transparent);
		((Control)t3W8()).set_Dock((DockStyle)4);
		((Control)t3W8()).set_Location(new Point(553, 0));
		((Control)t3W8()).set_Name("PictureBox1");
		((Control)t3W8()).set_Size(new Size(234, 377));
		t3W8().set_TabIndex(4);
		t3W8().set_TabStop(false);
		((AxHost)Mx79()).set_Enabled(true);
		((Control)Mx79()).set_Location(new Point(6, 10));
		((Control)Mx79()).set_Name("AxWindowsMediaPlayer1");
		((AxHost)Mx79()).set_OcxState((State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"));
		((Control)Mx79()).set_Size(new Size(535, 356));
		((Control)Mx79()).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 377));
		((Control)this).get_Controls().Add((Control)(object)Gg9a());
		((Control)this).get_Controls().Add((Control)(object)t3W8());
		((Control)this).get_Controls().Add((Control)(object)Mx79());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Trailer_2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TRAILER");
		((ISupportInitialize)Gg9a()).EndInit();
		((ISupportInitialize)t3W8()).EndInit();
		((ISupportInitialize)Mx79()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual PictureBox Gg9a()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3L4(PictureBox r1B4)
	{
		PictureBox val = (g = r1B4);
	}

	[SpecialName]
	internal virtual PictureBox t3W8()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb84(PictureBox w0YE)
	{
		_PictureBox1 = w0YE;
	}

	[SpecialName]
	internal virtual AxWindowsMediaPlayer Mx79()
	{
		return _AxWindowsMediaPlayer1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4R8(AxWindowsMediaPlayer Bk18)
	{
		_AxWindowsMediaPlayer1 = Bk18;
	}
}
