using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;

namespace n2G9;

[DesignerGenerated]
public class Xc2g : Form
{
	private IContainer components;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox1;

	private AxWindowsMediaPlayer _AxWindowsMediaPlayer1;

	public Xc2g()
	{
		Nk52();
	}

	protected override void a9TN(bool b7ND)
	{
		try
		{
			if (b7ND && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b7ND);
		}
	}

	private void Nk52()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Xc2g));
		Nm3d(new PictureBox());
		Lo80(new PictureBox());
		j8Q9(new AxWindowsMediaPlayer());
		((ISupportInitialize)Wb9i()).BeginInit();
		((ISupportInitialize)Lo1c()).BeginInit();
		((ISupportInitialize)z9GH()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Wb9i()).set_BackColor(Color.Transparent);
		((Control)Wb9i()).set_Location(new Point(586, 35));
		((Control)Wb9i()).set_Name("PictureBox2");
		((Control)Wb9i()).set_Size(new Size(163, 235));
		Wb9i().set_SizeMode((PictureBoxSizeMode)1);
		Wb9i().set_TabIndex(9);
		Wb9i().set_TabStop(false);
		((Control)Lo1c()).set_BackColor(Color.Transparent);
		((Control)Lo1c()).set_Dock((DockStyle)4);
		((Control)Lo1c()).set_Location(new Point(553, 0));
		((Control)Lo1c()).set_Name("PictureBox1");
		((Control)Lo1c()).set_Size(new Size(234, 377));
		Lo1c().set_TabIndex(8);
		Lo1c().set_TabStop(false);
		((AxHost)z9GH()).set_Enabled(true);
		((Control)z9GH()).set_Location(new Point(3, 10));
		((Control)z9GH()).set_Name("AxWindowsMediaPlayer1");
		((AxHost)z9GH()).set_OcxState((State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState"));
		((Control)z9GH()).set_Size(new Size(535, 356));
		((Control)z9GH()).set_TabIndex(11);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 377));
		((Control)this).get_Controls().Add((Control)(object)Wb9i());
		((Control)this).get_Controls().Add((Control)(object)Lo1c());
		((Control)this).get_Controls().Add((Control)(object)z9GH());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Trailer_3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("TRAILER");
		((ISupportInitialize)Wb9i()).EndInit();
		((ISupportInitialize)Lo1c()).EndInit();
		((ISupportInitialize)z9GH()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual PictureBox Wb9i()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nm3d(PictureBox j6SY)
	{
		_PictureBox2 = j6SY;
	}

	[SpecialName]
	internal virtual PictureBox Lo1c()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo80(PictureBox Xg6i)
	{
		_PictureBox1 = Xg6i;
	}

	[SpecialName]
	internal virtual AxWindowsMediaPlayer z9GH()
	{
		return _AxWindowsMediaPlayer1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8Q9(AxWindowsMediaPlayer Xb0r)
	{
		_AxWindowsMediaPlayer1 = Xb0r;
	}
}
