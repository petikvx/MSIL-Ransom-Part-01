using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Lt35;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Qs7b;

[DesignerGenerated]
public sealed class o9ZJ : Form
{
	private Label _Copyright;

	private IContainer components;

	internal Label H;

	internal Label i;

	internal TableLayoutPanel G;

	internal TableLayoutPanel c;

	public o9ZJ()
	{
		((Form)this).add_Load((EventHandler)y1A0);
		r8EN();
	}

	protected override void r5FS(bool Yy8a)
	{
		try
		{
			if (Yy8a && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Yy8a);
		}
	}

	[SpecialName]
	internal virtual Label Gm80()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9D8(Label Me6g)
	{
		Label val = (H = Me6g);
	}

	[SpecialName]
	internal virtual Label Ca5o()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o1B0(Label a5SF)
	{
		Label val = (i = a5SF);
	}

	[SpecialName]
	internal virtual Label Gc0f()
	{
		return _Copyright;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6J8(Label t8WZ)
	{
		_Copyright = t8WZ;
	}

	[SpecialName]
	internal virtual TableLayoutPanel Wa21()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ka0p(TableLayoutPanel m0ZT)
	{
		TableLayoutPanel val = (G = m0ZT);
	}

	[SpecialName]
	internal virtual TableLayoutPanel Wt1c()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2F8(TableLayoutPanel r4S5)
	{
		TableLayoutPanel val = (c = r4S5);
	}

	private void r8EN()
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(o9ZJ));
		Ka0p(new TableLayoutPanel());
		f2F8(new TableLayoutPanel());
		o1B0(new Label());
		f6J8(new Label());
		b9D8(new Label());
		((Control)Wa21()).SuspendLayout();
		((Control)Wt1c()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Wa21()).set_BackgroundImage((Image)componentResourceManager.GetObject("MainLayoutPanel.BackgroundImage"));
		((Control)Wa21()).set_BackgroundImageLayout((ImageLayout)3);
		Wa21().set_ColumnCount(2);
		Wa21().get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 243f));
		Wa21().get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 100f));
		Wa21().get_Controls().Add((Control)(object)Wt1c(), 1, 1);
		Wa21().get_Controls().Add((Control)(object)Gm80(), 1, 0);
		((Control)Wa21()).set_Dock((DockStyle)5);
		((Control)Wa21()).set_Location(new Point(0, 0));
		((Control)Wa21()).set_Name("MainLayoutPanel");
		Wa21().get_RowStyles().Add(new RowStyle((SizeType)1, 218f));
		Wa21().get_RowStyles().Add(new RowStyle((SizeType)1, 38f));
		((Control)Wa21()).set_Size(new Size(496, 303));
		((Control)Wa21()).set_TabIndex(0);
		((Control)Wt1c()).set_Anchor((AnchorStyles)0);
		((Control)Wt1c()).set_BackColor(Color.Transparent);
		Wt1c().set_ColumnCount(1);
		Wt1c().get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 247f));
		Wt1c().get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 142f));
		Wt1c().get_Controls().Add((Control)(object)Ca5o(), 0, 0);
		Wt1c().get_Controls().Add((Control)(object)Gc0f(), 0, 1);
		((Control)Wt1c()).set_Location(new Point(246, 221));
		((Control)Wt1c()).set_Name("DetailsLayoutPanel");
		Wt1c().get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		Wt1c().get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		((Control)Wt1c()).set_Size(new Size(247, 79));
		((Control)Wt1c()).set_TabIndex(1);
		((Control)Ca5o()).set_Anchor((AnchorStyles)0);
		((Control)Ca5o()).set_BackColor(Color.Transparent);
		((Control)Ca5o()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ca5o()).set_Location(new Point(3, 9));
		((Control)Ca5o()).set_Name("Version");
		((Control)Ca5o()).set_Size(new Size(241, 20));
		((Control)Ca5o()).set_TabIndex(1);
		Ca5o().set_Text("Version {0}.{1:00}");
		((Control)Gc0f()).set_Anchor((AnchorStyles)0);
		((Control)Gc0f()).set_BackColor(Color.Transparent);
		((Control)Gc0f()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Gc0f()).set_Location(new Point(3, 39));
		((Control)Gc0f()).set_Name("Copyright");
		((Control)Gc0f()).set_Size(new Size(241, 40));
		((Control)Gc0f()).set_TabIndex(2);
		Gc0f().set_Text("Copyright");
		((Control)Gm80()).set_Anchor((AnchorStyles)0);
		((Control)Gm80()).set_BackColor(Color.Transparent);
		((Control)Gm80()).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Gm80()).set_Location(new Point(246, 3));
		((Control)Gm80()).set_Name("ApplicationTitle");
		((Control)Gm80()).set_Size(new Size(247, 212));
		((Control)Gm80()).set_TabIndex(0);
		Gm80().set_Text("Application Title");
		Gm80().set_TextAlign((ContentAlignment)256);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(496, 303));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Wa21());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("SplashScreen1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)Wa21()).ResumeLayout(false);
		((Control)Wt1c()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void y1A0(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ApplicationBase)Fb9z.Application).get_Info().get_Title(), "", false) != 0)
		{
			Gm80().set_Text(((ApplicationBase)Fb9z.Application).get_Info().get_Title());
		}
		else
		{
			Gm80().set_Text(Path.GetFileNameWithoutExtension(((ApplicationBase)Fb9z.Application).get_Info().get_AssemblyName()));
		}
		Ca5o().set_Text(string.Format(Ca5o().get_Text(), ((ApplicationBase)Fb9z.Application).get_Info().get_Version().Major, ((ApplicationBase)Fb9z.Application).get_Info().get_Version().Minor));
		Gc0f().set_Text(((ApplicationBase)Fb9z.Application).get_Info().get_Copyright());
	}
}
