using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace f0W8;

[DesignerGenerated]
public class Tr68 : Form
{
	private PictureBox _PictureBox1;

	internal IContainer E;

	internal AxWindowsMediaPlayer a;

	internal PictureBox q;

	public Tr68()
	{
		Ag31();
	}

	protected override void Lb26(bool y8G4)
	{
		try
		{
			if (y8G4 && E != null)
			{
				E.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(y8G4);
		}
	}

	private void Ag31()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Tr68));
		a5AS(new AxWindowsMediaPlayer());
		b7G1(new PictureBox());
		Fw20(new PictureBox());
		((ISupportInitialize)q9W8()).BeginInit();
		((ISupportInitialize)r5SH()).BeginInit();
		((ISupportInitialize)w4DX()).BeginInit();
		((Control)this).SuspendLayout();
		((AxHost)q9W8()).set_Enabled(true);
		((Control)q9W8()).set_Location(new Point(1, 10));
		((Control)q9W8()).set_Name("AxWindowsMediaPlayer1");
		((AxHost)q9W8()).set_OcxState((State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"));
		((Control)q9W8()).set_Size(new Size(535, 356));
		((Control)q9W8()).set_TabIndex(15);
		((Control)r5SH()).set_BackColor(Color.Transparent);
		((Control)r5SH()).set_Location(new Point(572, 12));
		((Control)r5SH()).set_Name("PictureBox2");
		((Control)r5SH()).set_Size(new Size(163, 235));
		r5SH().set_SizeMode((PictureBoxSizeMode)1);
		r5SH().set_TabIndex(13);
		r5SH().set_TabStop(false);
		((Control)w4DX()).set_BackColor(Color.Transparent);
		((Control)w4DX()).set_Dock((DockStyle)4);
		((Control)w4DX()).set_Location(new Point(553, 0));
		((Control)w4DX()).set_Name("PictureBox1");
		((Control)w4DX()).set_Size(new Size(234, 377));
		w4DX().set_TabIndex(12);
		w4DX().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 377));
		((Control)this).get_Controls().Add((Control)(object)q9W8());
		((Control)this).get_Controls().Add((Control)(object)r5SH());
		((Control)this).get_Controls().Add((Control)(object)w4DX());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Trailer_4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TRAILER");
		((ISupportInitialize)q9W8()).EndInit();
		((ISupportInitialize)r5SH()).EndInit();
		((ISupportInitialize)w4DX()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual AxWindowsMediaPlayer q9W8()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5AS(AxWindowsMediaPlayer j8N9)
	{
		AxWindowsMediaPlayer val = (a = j8N9);
	}

	[SpecialName]
	internal virtual PictureBox r5SH()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7G1(PictureBox o9PM)
	{
		PictureBox val = (q = o9PM);
	}

	[SpecialName]
	internal virtual PictureBox w4DX()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fw20(PictureBox f6W5)
	{
		_PictureBox1 = f6W5;
	}
}
