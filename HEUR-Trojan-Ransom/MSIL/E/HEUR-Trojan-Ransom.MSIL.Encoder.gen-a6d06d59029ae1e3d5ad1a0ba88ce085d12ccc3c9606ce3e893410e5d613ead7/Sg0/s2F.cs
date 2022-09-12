using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using s8Z;

namespace Sg0;

[DesignerGenerated]
public class s2F : Form
{
	private PictureBox _PictureBox1;

	private Button _Button2;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox4;

	internal IContainer b;

	internal PictureBox e;

	internal Button X;

	public s2F()
	{
		e6T0();
	}

	protected override void m3Z(bool Gr7)
	{
		try
		{
			if (Gr7 && b != null)
			{
				b.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gr7);
		}
	}

	private void e6T0()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(s2F));
		z6K0(new PictureBox());
		y3Z5(new PictureBox());
		j7EJ(new Button());
		g5N9(new Button());
		p3G0(new PictureBox());
		Sn5i(new PictureBox());
		((ISupportInitialize)r4FS()).BeginInit();
		((ISupportInitialize)Ga0f()).BeginInit();
		((ISupportInitialize)Yp61()).BeginInit();
		((ISupportInitialize)Lg1m()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)r4FS()).set_Anchor((AnchorStyles)15);
		((Control)r4FS()).set_BackColor(Color.Transparent);
		((Control)r4FS()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)r4FS()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)r4FS()).set_Location(new Point(79, 94));
		((Control)r4FS()).set_Name("PictureBox1");
		((Control)r4FS()).set_Size(new Size(443, 78));
		r4FS().set_TabIndex(0);
		r4FS().set_TabStop(false);
		((Control)Ga0f()).set_Anchor((AnchorStyles)15);
		((Control)Ga0f()).set_BackColor(Color.Transparent);
		((Control)Ga0f()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Ga0f()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ga0f()).set_Location(new Point(62, 12));
		((Control)Ga0f()).set_Name("PictureBox2");
		((Control)Ga0f()).set_Size(new Size(127, 102));
		Ga0f().set_TabIndex(1);
		Ga0f().set_TabStop(false);
		((Control)Nm6f()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Nm6f()).set_BackColor(Color.LightCyan);
		((Control)Nm6f()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Nm6f()).set_Cursor(Cursors.get_Arrow());
		((ButtonBase)Nm6f()).set_FlatStyle((FlatStyle)1);
		((Control)Nm6f()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Nm6f()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Nm6f()).set_Location(new Point(79, 241));
		((Control)Nm6f()).set_Name("Button2");
		((Control)Nm6f()).set_Size(new Size(210, 27));
		((Control)Nm6f()).set_TabIndex(11);
		((ButtonBase)Nm6f()).set_Text("Add other &Expenses");
		((ButtonBase)Nm6f()).set_UseVisualStyleBackColor(false);
		((Control)Ti04()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Ti04()).set_BackColor(Color.LightCyan);
		((Control)Ti04()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ti04()).set_Cursor(Cursors.get_Arrow());
		((ButtonBase)Ti04()).set_FlatStyle((FlatStyle)1);
		((Control)Ti04()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ti04()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Ti04()).set_Location(new Point(369, 308));
		((Control)Ti04()).set_Name("Button1");
		((Control)Ti04()).set_Size(new Size(210, 27));
		((Control)Ti04()).set_TabIndex(12);
		((ButtonBase)Ti04()).set_Text(" Go Back To &Main Menu");
		((ButtonBase)Ti04()).set_UseVisualStyleBackColor(false);
		((Control)Yp61()).set_Anchor((AnchorStyles)15);
		((Control)Yp61()).set_BackColor(Color.Transparent);
		((Control)Yp61()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Yp61()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Yp61()).set_Location(new Point(320, 294));
		((Control)Yp61()).set_Name("PictureBox3");
		((Control)Yp61()).set_Size(new Size(74, 54));
		Yp61().set_TabIndex(13);
		Yp61().set_TabStop(false);
		((Control)Lg1m()).set_Anchor((AnchorStyles)15);
		((Control)Lg1m()).set_BackColor(Color.Transparent);
		((Control)Lg1m()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)Lg1m()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Lg1m()).set_Location(new Point(40, 228));
		((Control)Lg1m()).set_Name("PictureBox4");
		((Control)Lg1m()).set_Size(new Size(74, 54));
		Lg1m().set_TabIndex(14);
		Lg1m().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(631, 366));
		((Control)this).get_Controls().Add((Control)(object)Lg1m());
		((Control)this).get_Controls().Add((Control)(object)Yp61());
		((Control)this).get_Controls().Add((Control)(object)Ti04());
		((Control)this).get_Controls().Add((Control)(object)Nm6f());
		((Control)this).get_Controls().Add((Control)(object)Ga0f());
		((Control)this).get_Controls().Add((Control)(object)r4FS());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form10");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Expense Manager");
		((ISupportInitialize)r4FS()).EndInit();
		((ISupportInitialize)Ga0f()).EndInit();
		((ISupportInitialize)Yp61()).EndInit();
		((ISupportInitialize)Lg1m()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual PictureBox r4FS()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6K0(PictureBox r8GD)
	{
		_PictureBox1 = r8GD;
	}

	[SpecialName]
	internal virtual PictureBox Ga0f()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3Z5(PictureBox d3ZN)
	{
		PictureBox val = (e = d3ZN);
	}

	[SpecialName]
	internal virtual Button Nm6f()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7EJ(Button Kp14)
	{
		EventHandler eventHandler = z5YL;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = Kp14;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ti04()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5N9(Button n5T4)
	{
		EventHandler eventHandler = Nn59;
		Button x = X;
		if (x != null)
		{
			((Control)x).remove_Click(eventHandler);
		}
		Button val = (X = n5T4);
		x = X;
		if (x != null)
		{
			((Control)x).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Yp61()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3G0(PictureBox g8FH)
	{
		EventHandler eventHandler = Fw05;
		PictureBox pictureBox = _PictureBox3;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox3 = g8FH;
		pictureBox = _PictureBox3;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Lg1m()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sn5i(PictureBox k5LT)
	{
		_PictureBox4 = k5LT;
	}

	private void Nn59(object sender, EventArgs e)
	{
		((Control)i1B.Forms.i5C()).Show();
		((Form)this).Close();
	}

	private void Fw05(object sender, EventArgs e)
	{
	}

	private void z5YL(object sender, EventArgs e)
	{
		((Control)i1B.Forms.g5X()).Show();
		((Form)this).Close();
	}

	internal static bool Ri41(int Nc5)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Nc5 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Nc5 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Nc5 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Nc5 = -1;
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
