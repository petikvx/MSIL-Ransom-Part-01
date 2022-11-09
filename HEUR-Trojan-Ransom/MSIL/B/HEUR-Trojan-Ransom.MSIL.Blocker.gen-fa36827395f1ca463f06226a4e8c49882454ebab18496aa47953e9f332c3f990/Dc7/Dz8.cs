using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Tk89;
using Xz8;
using g6WL;
using p4T;
using t0B;

namespace Dc7;

[DesignerGenerated]
public class Dz8 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 15472)]
	private struct Hc1
	{
	}

	private TextBox _txtUsername;

	private CheckBox _CheckBox1;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	private static readonly Array s;

	private static readonly object n;

	private static readonly Array W;

	internal static byte R/* Not supported: data(00) */;

	internal IContainer Q;

	internal TextBox r;

	internal Button e;

	internal Label i;

	public Dz8()
	{
		((Form)this).add_Load((EventHandler)n2P);
		Mn3();
	}

	protected override void Zq4(bool y2Y)
	{
		try
		{
			if (y2Y && Q != null)
			{
				Q.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(y2Y);
		}
	}

	private void Mn3()
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Dz8));
		s5N(new TextBox());
		e1G(new TextBox());
		p8A(new Button());
		Zk3(new Label());
		Bm6(new CheckBox());
		e6Q(new PictureBox());
		t0X(new PictureBox());
		((ISupportInitialize)Nj1()).BeginInit();
		((ISupportInitialize)Mx9()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Wx8()).set_Cursor(Cursors.get_IBeam());
		((Control)Wx8()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Wx8()).set_ForeColor(Color.DarkGray);
		((Control)Wx8()).set_Location(new Point(168, 97));
		((Control)Wx8()).set_Name("txtUsername");
		((Control)Wx8()).set_Size(new Size(223, 30));
		((Control)Wx8()).set_TabIndex(0);
		Wx8().set_Text("Username");
		((Control)Gp8()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Gp8()).set_ForeColor(Color.DarkGray);
		((Control)Gp8()).set_Location(new Point(168, 143));
		((Control)Gp8()).set_Name("txtPassword");
		((Control)Gp8()).set_Size(new Size(223, 30));
		((Control)Gp8()).set_TabIndex(1);
		Gp8().set_Text("Password");
		((ButtonBase)Lr8()).set_BackColor(Color.DarkTurquoise);
		((Control)Lr8()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Lr8()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Lr8()).set_FlatStyle((FlatStyle)0);
		((Control)Lr8()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Lr8()).set_ForeColor(Color.White);
		((Control)Lr8()).set_Location(new Point(168, 225));
		((Control)Lr8()).set_Name("Button1");
		((Control)Lr8()).set_Size(new Size(223, 38));
		((Control)Lr8()).set_TabIndex(4);
		((ButtonBase)Lr8()).set_Text("Login");
		((ButtonBase)Lr8()).set_UseVisualStyleBackColor(false);
		p9X().set_AutoSize(true);
		((Control)p9X()).set_BackColor(Color.Transparent);
		((Control)p9X()).set_Font(new Font("Comic Sans MS", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p9X()).set_ForeColor(Color.White);
		((Control)p9X()).set_Location(new Point(233, 36));
		((Control)p9X()).set_Name("Label3");
		((Control)p9X()).set_Size(new Size(84, 29));
		((Control)p9X()).set_TabIndex(5);
		p9X().set_Text("LOGIN");
		((ButtonBase)d1L()).set_AutoSize(true);
		((ButtonBase)d1L()).set_BackColor(Color.Transparent);
		((Control)d1L()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)d1L()).set_ForeColor(Color.White);
		((Control)d1L()).set_Location(new Point(270, 179));
		((Control)d1L()).set_Name("CheckBox1");
		((Control)d1L()).set_Size(new Size(121, 22));
		((Control)d1L()).set_TabIndex(6);
		((ButtonBase)d1L()).set_Text("Show Password");
		((ButtonBase)d1L()).set_UseVisualStyleBackColor(false);
		((Control)Nj1()).set_BackColor(Color.Transparent);
		Nj1().set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)Nj1()).set_Location(new Point(132, 97));
		((Control)Nj1()).set_Name("PictureBox1");
		((Control)Nj1()).set_Size(new Size(30, 30));
		Nj1().set_SizeMode((PictureBoxSizeMode)1);
		Nj1().set_TabIndex(7);
		Nj1().set_TabStop(false);
		((Control)Mx9()).set_BackColor(Color.Transparent);
		Mx9().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)Mx9()).set_Location(new Point(132, 143));
		((Control)Mx9()).set_Name("PictureBox2");
		((Control)Mx9()).set_Size(new Size(30, 30));
		Mx9().set_SizeMode((PictureBoxSizeMode)1);
		Mx9().set_TabIndex(8);
		Mx9().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Wi3.y6B());
		((Form)this).set_ClientSize(new Size(560, 372));
		((Control)this).get_Controls().Add((Control)(object)Mx9());
		((Control)this).get_Controls().Add((Control)(object)Nj1());
		((Control)this).get_Controls().Add((Control)(object)d1L());
		((Control)this).get_Controls().Add((Control)(object)p9X());
		((Control)this).get_Controls().Add((Control)(object)Lr8());
		((Control)this).get_Controls().Add((Control)(object)Gp8());
		((Control)this).get_Controls().Add((Control)(object)Wx8());
		((Form)this).set_MaximumSize(new Size(576, 411));
		((Form)this).set_MinimumSize(new Size(576, 411));
		((Control)this).set_Name("Login");
		((Form)this).set_Text("Login");
		((ISupportInitialize)Nj1()).EndInit();
		((ISupportInitialize)Mx9()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox Wx8()
	{
		return _txtUsername;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5N(TextBox Jf5)
	{
		EventHandler eventHandler = Cw4;
		EventHandler eventHandler2 = Zp1;
		TextBox txtUsername = _txtUsername;
		if (txtUsername != null)
		{
			((Control)txtUsername).remove_Enter(eventHandler);
			((Control)txtUsername).remove_Leave(eventHandler2);
		}
		_txtUsername = Jf5;
		txtUsername = _txtUsername;
		if (txtUsername != null)
		{
			((Control)txtUsername).add_Enter(eventHandler);
			((Control)txtUsername).add_Leave(eventHandler2);
		}
	}

	[SpecialName]
	internal virtual TextBox Gp8()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1G(TextBox Mq4)
	{
		EventHandler eventHandler = n9J;
		TextBox val = r;
		if (val != null)
		{
			((Control)val).remove_Enter(eventHandler);
		}
		TextBox val2 = (r = Mq4);
		val = r;
		if (val != null)
		{
			((Control)val).add_Enter(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Lr8()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p8A(Button z6R)
	{
		EventHandler eventHandler = Dp4;
		Button val = e;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (e = z6R);
		val = e;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label p9X()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk3(Label Fq2)
	{
		Label val = (i = Fq2);
	}

	[SpecialName]
	internal virtual CheckBox d1L()
	{
		return _CheckBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bm6(CheckBox z3F)
	{
		EventHandler eventHandler = Em8;
		CheckBox checkBox = _CheckBox1;
		if (checkBox != null)
		{
			checkBox.remove_CheckedChanged(eventHandler);
		}
		_CheckBox1 = z3F;
		checkBox = _CheckBox1;
		if (checkBox != null)
		{
			checkBox.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Nj1()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6Q(PictureBox o6P)
	{
		_PictureBox1 = o6P;
	}

	[SpecialName]
	internal virtual PictureBox Mx9()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0X(PictureBox Ts7)
	{
		_PictureBox2 = Ts7;
	}

	private void Dp4(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		string text = Wx8().get_Text();
		string text2 = Gp8().get_Text();
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		string text3 = "SELECT * FROM Users WHERE UserName = '" + text + "' AND Password = '" + p3S8.s4G1(text2, text) + "'";
		OleDbCommand val2 = new OleDbCommand(text3, val);
		val.Open();
		OleDbDataReader val3 = val2.ExecuteReader();
		if ((Operators.CompareString(Gp8().get_Text().Trim(), text2, false) == 0) & (Operators.CompareString(Wx8().get_Text().Trim(), text, false) == 0))
		{
			if (val3.Read())
			{
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(val3.get_Item("Designation"), (object)"Staff", false), Operators.CompareObjectEqual(val3.get_Item("Designation"), (object)"Admin", false))))
				{
					m2A.Forms.y3X().UserName = Conversions.ToString(val3.get_Item("UserName"));
					m2A.Forms.y3X().Designation = Conversions.ToString(val3.get_Item("Designation"));
					((Control)m2A.Forms.y3X()).Show();
					Wx8().set_Text("");
					Gp8().set_Text("");
					((Form)this).Close();
					((Control)m2A.Forms.At0()).Hide();
				}
				else
				{
					m2A.Forms.r0M().UserName = Conversions.ToString(val3.get_Item("UserName"));
					((Control)m2A.Forms.r0M()).Show();
					Wx8().set_Text("");
					Gp8().set_Text("");
					((Form)this).Close();
					((Control)m2A.Forms.At0()).Hide();
				}
			}
			else
			{
				MessageBox.Show("Incorrect username or password");
			}
		}
		else
		{
			MessageBox.Show("Incorrect username or password");
		}
		val.Close();
	}

	private void Cw4(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if (Operators.CompareString(Wx8().get_Text(), "Username", false) == 0)
		{
			Wx8().set_Text("");
			Font font = new Font("Comic Sans MS", 12f, (FontStyle)0);
			((Control)Wx8()).set_Font(font);
			((TextBoxBase)Wx8()).set_ForeColor(Color.Black);
		}
	}

	private void Zp1(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		if (Operators.CompareString(Wx8().get_Text(), "", false) == 0)
		{
			Font font = new Font("Comic Sans MS", 12f, (FontStyle)2);
			((Control)Wx8()).set_Font(font);
			((TextBoxBase)Wx8()).set_ForeColor(Color.DarkGray);
			Wx8().set_Text("Username");
		}
	}

	private void n9J(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (Operators.CompareString(Gp8().get_Text(), "Password", false) == 0)
		{
			Gp8().set_UseSystemPasswordChar(true);
			Gp8().set_Text("");
			Font font = new Font("Comic Sans MS", 12f, (FontStyle)0);
			((Control)Gp8()).set_Font(font);
			((TextBoxBase)Gp8()).set_ForeColor(Color.Black);
		}
	}

	private void Em8(object sender, EventArgs e)
	{
		if (d1L().get_Checked())
		{
			Gp8().set_UseSystemPasswordChar(false);
		}
		else
		{
			Gp8().set_UseSystemPasswordChar(true);
		}
	}

	internal static byte[] Tb8(int j7A)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return Gc0.Gk5(Kk03.Fr79(), j7A);
	}

	private void n2P(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		IEnumerable<TextBox> enumerable = ((IEnumerable)((Control)this).get_Controls()).OfType<TextBox>();
		foreach (TextBox item in enumerable)
		{
			TextBox val = item;
			((Control)val).add_KeyDown(new KeyEventHandler(Jz5));
		}
	}

	public void Jz5(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			SendKeys.Send("{Tab}");
		}
	}

	static Dz8()
	{
		n = new char[7736];
		char[] array = new char[8];
		array[2] = '㨱';
		array[1] = '\u20f9';
		array[7] = '⡾';
		array[6] = 'ḩ';
		array[4] = '\u200a';
		array[0] = '♴';
		array[3] = 'ఘ';
		array[5] = '㘫';
		W = new string[219];
		s = array;
	}
}
