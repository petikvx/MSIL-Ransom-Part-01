using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Qm3;

namespace Zt6;

[DesignerGenerated]
public class g9L : Form
{
	private IContainer components;

	private Button _Button2;

	private PictureBox _PictureBox3;

	internal PictureBox C;

	internal PictureBox b;

	internal Button G;

	internal PictureBox H;

	public g9L()
	{
		y3E();
	}

	protected override void Tw4(bool Tw8)
	{
		try
		{
			if (Tw8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Tw8);
		}
	}

	private void y3E()
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
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(g9L));
		c6M(new PictureBox());
		o5J(new PictureBox());
		n2S(new Button());
		b0R(new Button());
		Kw9(new PictureBox());
		Mo9(new PictureBox());
		((ISupportInitialize)Mr3()).BeginInit();
		((ISupportInitialize)Pg6()).BeginInit();
		((ISupportInitialize)Ca5()).BeginInit();
		((ISupportInitialize)b9B()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Mr3()).set_Anchor((AnchorStyles)15);
		((Control)Mr3()).set_BackColor(Color.Transparent);
		((Control)Mr3()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Mr3()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Mr3()).set_Location(new Point(79, 94));
		((Control)Mr3()).set_Name("PictureBox1");
		((Control)Mr3()).set_Size(new Size(443, 78));
		Mr3().set_TabIndex(0);
		Mr3().set_TabStop(false);
		((Control)Pg6()).set_Anchor((AnchorStyles)15);
		((Control)Pg6()).set_BackColor(Color.Transparent);
		((Control)Pg6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Pg6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Pg6()).set_Location(new Point(62, 12));
		((Control)Pg6()).set_Name("PictureBox2");
		((Control)Pg6()).set_Size(new Size(127, 102));
		Pg6().set_TabIndex(1);
		Pg6().set_TabStop(false);
		((Control)i6S()).set_Anchor((AnchorStyles)15);
		((ButtonBase)i6S()).set_BackColor(Color.LightCyan);
		((Control)i6S()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)i6S()).set_Cursor(Cursors.get_Arrow());
		((ButtonBase)i6S()).set_FlatStyle((FlatStyle)1);
		((Control)i6S()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)i6S()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)i6S()).set_Location(new Point(79, 241));
		((Control)i6S()).set_Name("Button2");
		((Control)i6S()).set_Size(new Size(210, 27));
		((Control)i6S()).set_TabIndex(11);
		((ButtonBase)i6S()).set_Text("Add other &Expenses");
		((ButtonBase)i6S()).set_UseVisualStyleBackColor(false);
		((Control)Dn9()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Dn9()).set_BackColor(Color.LightCyan);
		((Control)Dn9()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Dn9()).set_Cursor(Cursors.get_Arrow());
		((ButtonBase)Dn9()).set_FlatStyle((FlatStyle)1);
		((Control)Dn9()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Dn9()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Dn9()).set_Location(new Point(369, 308));
		((Control)Dn9()).set_Name("Button1");
		((Control)Dn9()).set_Size(new Size(210, 27));
		((Control)Dn9()).set_TabIndex(12);
		((ButtonBase)Dn9()).set_Text(" Go Back To &Main Menu");
		((ButtonBase)Dn9()).set_UseVisualStyleBackColor(false);
		((Control)Ca5()).set_Anchor((AnchorStyles)15);
		((Control)Ca5()).set_BackColor(Color.Transparent);
		((Control)Ca5()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Ca5()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ca5()).set_Location(new Point(320, 294));
		((Control)Ca5()).set_Name("PictureBox3");
		((Control)Ca5()).set_Size(new Size(74, 54));
		Ca5().set_TabIndex(13);
		Ca5().set_TabStop(false);
		((Control)b9B()).set_Anchor((AnchorStyles)15);
		((Control)b9B()).set_BackColor(Color.Transparent);
		((Control)b9B()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)b9B()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)b9B()).set_Location(new Point(40, 228));
		((Control)b9B()).set_Name("PictureBox4");
		((Control)b9B()).set_Size(new Size(74, 54));
		b9B().set_TabIndex(14);
		b9B().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(631, 366));
		((Control)this).get_Controls().Add((Control)(object)b9B());
		((Control)this).get_Controls().Add((Control)(object)Ca5());
		((Control)this).get_Controls().Add((Control)(object)Dn9());
		((Control)this).get_Controls().Add((Control)(object)i6S());
		((Control)this).get_Controls().Add((Control)(object)Pg6());
		((Control)this).get_Controls().Add((Control)(object)Mr3());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form10");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Expense Manager");
		((ISupportInitialize)Mr3()).EndInit();
		((ISupportInitialize)Pg6()).EndInit();
		((ISupportInitialize)Ca5()).EndInit();
		((ISupportInitialize)b9B()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual PictureBox Mr3()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6M(PictureBox Gw9)
	{
		PictureBox val = (C = Gw9);
	}

	[SpecialName]
	internal virtual PictureBox Pg6()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5J(PictureBox Cw4)
	{
		PictureBox val = (b = Cw4);
	}

	[SpecialName]
	internal virtual Button i6S()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2S(Button w6D)
	{
		EventHandler eventHandler = Am6;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = w6D;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Dn9()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0R(Button m4C)
	{
		EventHandler eventHandler = j4F;
		Button g = G;
		if (g != null)
		{
			((Control)g).remove_Click(eventHandler);
		}
		Button val = (G = m4C);
		g = G;
		if (g != null)
		{
			((Control)g).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Ca5()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kw9(PictureBox x1G)
	{
		EventHandler eventHandler = n9Y;
		PictureBox pictureBox = _PictureBox3;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox3 = x1G;
		pictureBox = _PictureBox3;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox b9B()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mo9(PictureBox i9P)
	{
		PictureBox val = (H = i9P);
	}

	private void j4F(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Ft0()).Show();
		((Form)this).Close();
	}

	private void n9Y(object sender, EventArgs e)
	{
	}

	private void Am6(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Wq3()).Show();
		((Form)this).Close();
	}

	internal static bool Zm9(int Tq1)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Tq1 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Tq1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Tq1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Tq1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}
}
