using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace Fe9;

[DesignerGenerated]
public class m8Q : Form
{
	private IContainer components;

	internal PictureBox J;

	internal PictureBox t;

	internal AxWindowsMediaPlayer D;

	public m8Q()
	{
		Yt0();
	}

	protected override void Kg0(bool Bt8)
	{
		try
		{
			if (Bt8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Bt8);
		}
	}

	private void Yt0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(m8Q));
		j6X(new PictureBox());
		Gp4(new PictureBox());
		Zs9(new AxWindowsMediaPlayer());
		((ISupportInitialize)g1Y()).BeginInit();
		((ISupportInitialize)k4C()).BeginInit();
		((ISupportInitialize)Mr9()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)g1Y()).set_BackColor(Color.Transparent);
		((Control)g1Y()).set_Dock((DockStyle)4);
		((Control)g1Y()).set_Location(new Point(553, 0));
		((Control)g1Y()).set_Name("PictureBox1");
		((Control)g1Y()).set_Size(new Size(234, 377));
		g1Y().set_TabIndex(0);
		g1Y().set_TabStop(false);
		((Control)k4C()).set_BackColor(Color.Transparent);
		((Control)k4C()).set_Location(new Point(584, 45));
		((Control)k4C()).set_Name("PictureBox2");
		((Control)k4C()).set_Size(new Size(163, 235));
		k4C().set_SizeMode((PictureBoxSizeMode)1);
		k4C().set_TabIndex(1);
		k4C().set_TabStop(false);
		((AxHost)Mr9()).set_Enabled(true);
		((Control)Mr9()).set_Location(new Point(12, 10));
		((Control)Mr9()).set_Name("AxWindowsMediaPlayer1");
		((AxHost)Mr9()).set_OcxState((State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"));
		((Control)Mr9()).set_Size(new Size(535, 356));
		((Control)Mr9()).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 377));
		((Control)this).get_Controls().Add((Control)(object)Mr9());
		((Control)this).get_Controls().Add((Control)(object)k4C());
		((Control)this).get_Controls().Add((Control)(object)g1Y());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Trailer_1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TRAILER");
		((ISupportInitialize)g1Y()).EndInit();
		((ISupportInitialize)k4C()).EndInit();
		((ISupportInitialize)Mr9()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual PictureBox g1Y()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6X(PictureBox c7B)
	{
		PictureBox val = (J = c7B);
	}

	[SpecialName]
	internal virtual PictureBox k4C()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gp4(PictureBox c0K)
	{
		PictureBox val = (t = c0K);
	}

	[SpecialName]
	internal virtual AxWindowsMediaPlayer Mr9()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zs9(AxWindowsMediaPlayer x7E)
	{
		AxWindowsMediaPlayer val = (D = x7E);
	}
}
