using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace Lt8;

[DesignerGenerated]
public class Rd1 : Form
{
	internal IContainer C;

	internal AxWindowsMediaPlayer E;

	internal PictureBox J;

	internal PictureBox T;

	public Rd1()
	{
		c5T();
	}

	protected override void Cp0(bool Tt1)
	{
		try
		{
			if (Tt1 && C != null)
			{
				C.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Tt1);
		}
	}

	private void c5T()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Rd1));
		i8F(new AxWindowsMediaPlayer());
		Pr1(new PictureBox());
		Ti5(new PictureBox());
		((ISupportInitialize)Bf8()).BeginInit();
		((ISupportInitialize)n0E()).BeginInit();
		((ISupportInitialize)Jn9()).BeginInit();
		((Control)this).SuspendLayout();
		((AxHost)Bf8()).set_Enabled(true);
		((Control)Bf8()).set_Location(new Point(1, 10));
		((Control)Bf8()).set_Name("AxWindowsMediaPlayer1");
		((AxHost)Bf8()).set_OcxState((State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"));
		((Control)Bf8()).set_Size(new Size(535, 356));
		((Control)Bf8()).set_TabIndex(15);
		((Control)n0E()).set_BackColor(Color.Transparent);
		((Control)n0E()).set_Location(new Point(572, 12));
		((Control)n0E()).set_Name("PictureBox2");
		((Control)n0E()).set_Size(new Size(163, 235));
		n0E().set_SizeMode((PictureBoxSizeMode)1);
		n0E().set_TabIndex(13);
		n0E().set_TabStop(false);
		((Control)Jn9()).set_BackColor(Color.Transparent);
		((Control)Jn9()).set_Dock((DockStyle)4);
		((Control)Jn9()).set_Location(new Point(553, 0));
		((Control)Jn9()).set_Name("PictureBox1");
		((Control)Jn9()).set_Size(new Size(234, 377));
		Jn9().set_TabIndex(12);
		Jn9().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 377));
		((Control)this).get_Controls().Add((Control)(object)Bf8());
		((Control)this).get_Controls().Add((Control)(object)n0E());
		((Control)this).get_Controls().Add((Control)(object)Jn9());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Trailer_4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TRAILER");
		((ISupportInitialize)Bf8()).EndInit();
		((ISupportInitialize)n0E()).EndInit();
		((ISupportInitialize)Jn9()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual AxWindowsMediaPlayer Bf8()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8F(AxWindowsMediaPlayer i1J)
	{
		AxWindowsMediaPlayer val = (E = i1J);
	}

	[SpecialName]
	internal virtual PictureBox n0E()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pr1(PictureBox Zr6)
	{
		PictureBox val = (J = Zr6);
	}

	[SpecialName]
	internal virtual PictureBox Jn9()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ti5(PictureBox p9J)
	{
		PictureBox val = (T = p9J);
	}
}
