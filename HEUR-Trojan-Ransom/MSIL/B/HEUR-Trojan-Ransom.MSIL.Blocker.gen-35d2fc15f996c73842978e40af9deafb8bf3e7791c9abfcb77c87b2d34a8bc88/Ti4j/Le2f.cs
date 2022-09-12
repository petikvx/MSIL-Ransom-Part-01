using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ti4j;

[DesignerGenerated]
public class Le2f : Form
{
	private IContainer components;

	private PictureBox _PictureBox1;

	private GroupBox _GroupBox3;

	private TextBox _TextBox1;

	internal PictureBox h;

	internal Label U;

	internal PictureBox n;

	public Le2f()
	{
		Cz7s();
	}

	protected override void f8CB(bool Xo8m)
	{
		try
		{
			if (Xo8m && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Xo8m);
		}
	}

	private void Cz7s()
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Le2f));
		o7QA(new PictureBox());
		t6BA(new PictureBox());
		g6N7(new Label());
		z7A6(new GroupBox());
		Lx0y(new PictureBox());
		De1w(new TextBox());
		((ISupportInitialize)Tk83()).BeginInit();
		((ISupportInitialize)y9A6()).BeginInit();
		((Control)p5B1()).SuspendLayout();
		((ISupportInitialize)Ka5t()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Tk83()).set_Dock((DockStyle)3);
		((Control)Tk83()).set_Location(new Point(0, 0));
		((Control)Tk83()).set_Name("PictureBox1");
		((Control)Tk83()).set_Size(new Size(391, 370));
		Tk83().set_TabIndex(320);
		Tk83().set_TabStop(false);
		((Control)y9A6()).set_Location(new Point(390, -7));
		((Control)y9A6()).set_Name("PictureBox2");
		((Control)y9A6()).set_Size(new Size(296, 384));
		y9A6().set_SizeMode((PictureBoxSizeMode)1);
		y9A6().set_TabIndex(319);
		y9A6().set_TabStop(false);
		a1MC().set_AutoSize(true);
		((Control)a1MC()).set_Font(new Font("Monotype Corsiva", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)a1MC()).set_ForeColor(SystemColors.ControlLight);
		((Control)a1MC()).set_Location(new Point(102, 76));
		((Control)a1MC()).set_Name("Label6");
		((Control)a1MC()).set_Size(new Size(165, 22));
		((Control)a1MC()).set_TabIndex(326);
		a1MC().set_Text("MOVIE SYNOPSIS");
		((Control)p5B1()).get_Controls().Add((Control)(object)Ka5t());
		((Control)p5B1()).set_ForeColor(SystemColors.ControlLight);
		((Control)p5B1()).set_Location(new Point(444, 36));
		((Control)p5B1()).set_Name("GroupBox3");
		((Control)p5B1()).set_Size(new Size(200, 271));
		((Control)p5B1()).set_TabIndex(325);
		p5B1().set_TabStop(false);
		p5B1().set_Text("Movie On Display");
		((Control)Ka5t()).set_BackColor(Color.Transparent);
		((Control)Ka5t()).set_Location(new Point(18, 28));
		((Control)Ka5t()).set_Name("PictureBox15");
		((Control)Ka5t()).set_Size(new Size(158, 224));
		Ka5t().set_SizeMode((PictureBoxSizeMode)1);
		Ka5t().set_TabIndex(26);
		Ka5t().set_TabStop(false);
		((TextBoxBase)Bd2i()).set_BackColor(SystemColors.ActiveCaption);
		((TextBoxBase)Bd2i()).set_BorderStyle((BorderStyle)0);
		((Control)Bd2i()).set_Enabled(false);
		((Control)Bd2i()).set_Font(new Font("Monotype Corsiva", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Bd2i()).set_Location(new Point(81, 121));
		Bd2i().set_Multiline(true);
		((Control)Bd2i()).set_Name("TextBox1");
		((TextBoxBase)Bd2i()).set_ReadOnly(true);
		((Control)Bd2i()).set_Size(new Size(219, 157));
		((Control)Bd2i()).set_TabIndex(327);
		Bd2i().set_Text(componentResourceManager.GetString("TextBox1.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(687, 370));
		((Control)this).get_Controls().Add((Control)(object)Bd2i());
		((Control)this).get_Controls().Add((Control)(object)a1MC());
		((Control)this).get_Controls().Add((Control)(object)p5B1());
		((Control)this).get_Controls().Add((Control)(object)Tk83());
		((Control)this).get_Controls().Add((Control)(object)y9A6());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MoviesSynopsis2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYNOPSIS");
		((ISupportInitialize)Tk83()).EndInit();
		((ISupportInitialize)y9A6()).EndInit();
		((Control)p5B1()).ResumeLayout(false);
		((ISupportInitialize)Ka5t()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox Tk83()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7QA(PictureBox r7LC)
	{
		_PictureBox1 = r7LC;
	}

	[SpecialName]
	internal virtual PictureBox y9A6()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6BA(PictureBox Ka9z)
	{
		PictureBox val = (h = Ka9z);
	}

	[SpecialName]
	internal virtual Label a1MC()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6N7(Label Jj95)
	{
		Label val = (U = Jj95);
	}

	[SpecialName]
	internal virtual GroupBox p5B1()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7A6(GroupBox i0DG)
	{
		_GroupBox3 = i0DG;
	}

	[SpecialName]
	internal virtual PictureBox Ka5t()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lx0y(PictureBox w0FZ)
	{
		PictureBox val = (n = w0FZ);
	}

	[SpecialName]
	internal virtual TextBox Bd2i()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void De1w(TextBox g0F2)
	{
		_TextBox1 = g0F2;
	}
}
