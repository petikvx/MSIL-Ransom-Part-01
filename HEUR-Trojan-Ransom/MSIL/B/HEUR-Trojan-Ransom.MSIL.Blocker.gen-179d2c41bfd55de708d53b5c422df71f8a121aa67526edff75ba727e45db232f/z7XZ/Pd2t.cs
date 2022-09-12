using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Lt35;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using e4PA;
using t4AQ;
using z2SR;

namespace z7XZ;

[DesignerGenerated]
public class Pd2t : Form
{
	private GroupBox _GroupBox1;

	private TextBox _TextBox2;

	private Label _Label2;

	private Label _Label1;

	private Button _Button2;

	private TextBox _TextBox4;

	private Label _Label3;

	internal IContainer x;

	internal TextBox l;

	internal Button Q;

	internal Button G;

	internal TextBox u;

	internal GroupBox d;

	internal Button C;

	internal Button a;

	internal Button F;

	internal Label T;

	public Pd2t()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(d8GE));
		Zg5b();
	}

	protected override void x5NW(bool Hd47)
	{
		try
		{
			if (Hd47 && x != null)
			{
				x.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Hd47);
		}
	}

	private void Zg5b()
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
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Pd2t));
		c5N9(new GroupBox());
		e6Z4(new Button());
		Pt6y(new Button());
		Jw96(new Button());
		n5TQ(new Label());
		o1F2(new TextBox());
		Hs69(new TextBox());
		o5H1(new Label());
		Fo31(new GroupBox());
		Dk26(new Button());
		Nj5p(new Button());
		Rz4g(new Button());
		Bg60(new TextBox());
		m3QK(new TextBox());
		x7RL(new Label());
		y0B2(new Label());
		((Control)i3A4()).SuspendLayout();
		((Control)f6A1()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)i3A4()).set_BackgroundImage((Image)componentResourceManager.GetObject("GroupBox2.BackgroundImage"));
		((Control)i3A4()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)i3A4()).get_Controls().Add((Control)(object)g5SZ());
		((Control)i3A4()).get_Controls().Add((Control)(object)Lp3c());
		((Control)i3A4()).get_Controls().Add((Control)(object)t6WM());
		((Control)i3A4()).get_Controls().Add((Control)(object)Bb6x());
		((Control)i3A4()).get_Controls().Add((Control)(object)c5T8());
		((Control)i3A4()).get_Controls().Add((Control)(object)f3D8());
		((Control)i3A4()).get_Controls().Add((Control)(object)k3R5());
		((Control)i3A4()).set_Location(new Point(400, 13));
		((Control)i3A4()).set_Name("GroupBox2");
		((Control)i3A4()).set_Size(new Size(340, 271));
		((Control)i3A4()).set_TabIndex(5);
		i3A4().set_TabStop(false);
		i3A4().set_Text("Student Login");
		((Control)g5SZ()).set_Location(new Point(236, 180));
		((Control)g5SZ()).set_Name("Button6");
		((Control)g5SZ()).set_Size(new Size(87, 37));
		((Control)g5SZ()).set_TabIndex(8);
		((ButtonBase)g5SZ()).set_Text("Close");
		((ButtonBase)g5SZ()).set_UseVisualStyleBackColor(true);
		((Control)Lp3c()).set_Location(new Point(131, 180));
		((Control)Lp3c()).set_Name("Button5");
		((Control)Lp3c()).set_Size(new Size(89, 37));
		((Control)Lp3c()).set_TabIndex(7);
		((ButtonBase)Lp3c()).set_Text("Clear");
		((ButtonBase)Lp3c()).set_UseVisualStyleBackColor(true);
		((Control)t6WM()).set_Location(new Point(25, 180));
		((Control)t6WM()).set_Name("Button4");
		((Control)t6WM()).set_Size(new Size(91, 38));
		((Control)t6WM()).set_TabIndex(6);
		((ButtonBase)t6WM()).set_Text("Login");
		((ButtonBase)t6WM()).set_UseVisualStyleBackColor(true);
		Bb6x().set_AutoSize(true);
		((Control)Bb6x()).set_BackColor(Color.Transparent);
		((Control)Bb6x()).set_ForeColor(Color.Black);
		((Control)Bb6x()).set_Location(new Point(19, 126));
		((Control)Bb6x()).set_Name("Label4");
		((Control)Bb6x()).set_Size(new Size(53, 13));
		((Control)Bb6x()).set_TabIndex(5);
		Bb6x().set_Text("Password");
		((Control)c5T8()).set_Location(new Point(103, 123));
		((Control)c5T8()).set_Name("TextBox4");
		c5T8().set_PasswordChar('*');
		((Control)c5T8()).set_Size(new Size(208, 20));
		((Control)c5T8()).set_TabIndex(1);
		((Control)f3D8()).set_Location(new Point(103, 64));
		((Control)f3D8()).set_Name("TextBox3");
		((Control)f3D8()).set_Size(new Size(208, 20));
		((Control)f3D8()).set_TabIndex(4);
		k3R5().set_AutoSize(true);
		((Control)k3R5()).set_BackColor(Color.Transparent);
		((Control)k3R5()).set_ForeColor(Color.Black);
		((Control)k3R5()).set_Location(new Point(19, 67));
		((Control)k3R5()).set_Name("Label3");
		((Control)k3R5()).set_Size(new Size(60, 13));
		((Control)k3R5()).set_TabIndex(0);
		k3R5().set_Text("User Name");
		((Control)f6A1()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)f6A1()).get_Controls().Add((Control)(object)Xc05());
		((Control)f6A1()).get_Controls().Add((Control)(object)m5TC());
		((Control)f6A1()).get_Controls().Add((Control)(object)o0QY());
		((Control)f6A1()).get_Controls().Add((Control)(object)Zi7k());
		((Control)f6A1()).get_Controls().Add((Control)(object)Mk6g());
		((Control)f6A1()).get_Controls().Add((Control)(object)Br59());
		((Control)f6A1()).get_Controls().Add((Control)(object)x4XZ());
		((Control)f6A1()).set_Location(new Point(13, 13));
		((Control)f6A1()).set_Name("GroupBox1");
		((Control)f6A1()).set_Size(new Size(349, 271));
		((Control)f6A1()).set_TabIndex(0);
		f6A1().set_TabStop(false);
		f6A1().set_Text("Staff Login");
		((Control)Xc05()).set_Location(new Point(226, 180));
		((Control)Xc05()).set_Name("Button3");
		((Control)Xc05()).set_Size(new Size(89, 39));
		((Control)Xc05()).set_TabIndex(6);
		((ButtonBase)Xc05()).set_Text("Close");
		((ButtonBase)Xc05()).set_UseVisualStyleBackColor(true);
		((Control)m5TC()).set_Location(new Point(117, 180));
		((Control)m5TC()).set_Name("Button2");
		((Control)m5TC()).set_Size(new Size(90, 39));
		((Control)m5TC()).set_TabIndex(5);
		((ButtonBase)m5TC()).set_Text("Clear");
		((ButtonBase)m5TC()).set_UseVisualStyleBackColor(true);
		((Control)o0QY()).set_Location(new Point(13, 180));
		((Control)o0QY()).set_Name("Button1");
		((Control)o0QY()).set_Size(new Size(89, 39));
		((Control)o0QY()).set_TabIndex(4);
		((ButtonBase)o0QY()).set_Text("Login");
		((ButtonBase)o0QY()).set_UseVisualStyleBackColor(true);
		((Control)Zi7k()).set_Location(new Point(107, 123));
		((Control)Zi7k()).set_Name("TextBox2");
		Zi7k().set_PasswordChar('*');
		((Control)Zi7k()).set_Size(new Size(196, 20));
		((Control)Zi7k()).set_TabIndex(3);
		((Control)Mk6g()).set_Location(new Point(107, 64));
		((Control)Mk6g()).set_Name("TextBox1");
		((Control)Mk6g()).set_Size(new Size(196, 20));
		((Control)Mk6g()).set_TabIndex(2);
		Br59().set_AutoSize(true);
		((Control)Br59()).set_BackColor(Color.Transparent);
		((Control)Br59()).set_ForeColor(Color.Black);
		((Control)Br59()).set_Location(new Point(23, 126));
		((Control)Br59()).set_Name("Label2");
		((Control)Br59()).set_Size(new Size(53, 13));
		((Control)Br59()).set_TabIndex(1);
		Br59().set_Text("Password");
		x4XZ().set_AutoSize(true);
		((Control)x4XZ()).set_BackColor(Color.Transparent);
		((Control)x4XZ()).set_ForeColor(Color.Black);
		((Control)x4XZ()).set_Location(new Point(20, 67));
		((Control)x4XZ()).set_Name("Label1");
		((Control)x4XZ()).set_Size(new Size(60, 13));
		((Control)x4XZ()).set_TabIndex(0);
		x4XZ().set_Text("User Name");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.SteelBlue);
		((Form)this).set_ClientSize(new Size(752, 303));
		((Control)this).get_Controls().Add((Control)(object)i3A4());
		((Control)this).get_Controls().Add((Control)(object)f6A1());
		((Control)this).set_Name("Form2");
		((Form)this).set_Text("Student and Staff Login");
		((Control)i3A4()).ResumeLayout(false);
		((Control)i3A4()).PerformLayout();
		((Control)f6A1()).ResumeLayout(false);
		((Control)f6A1()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual GroupBox f6A1()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo31(GroupBox z5R7)
	{
		_GroupBox1 = z5R7;
	}

	[SpecialName]
	internal virtual TextBox Zi7k()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bg60(TextBox y3YT)
	{
		_TextBox2 = y3YT;
	}

	[SpecialName]
	internal virtual TextBox Mk6g()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3QK(TextBox Qs24)
	{
		TextBox val = (l = Qs24);
	}

	[SpecialName]
	internal virtual Label Br59()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7RL(Label Jz16)
	{
		_Label2 = Jz16;
	}

	[SpecialName]
	internal virtual Label x4XZ()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0B2(Label Mb08)
	{
		_Label1 = Mb08;
	}

	[SpecialName]
	internal virtual Button Xc05()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dk26(Button Gr7o)
	{
		EventHandler eventHandler = Eq1p;
		Button q = Q;
		if (q != null)
		{
			((Control)q).remove_Click(eventHandler);
		}
		Button val = (Q = Gr7o);
		q = Q;
		if (q != null)
		{
			((Control)q).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button m5TC()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj5p(Button Ws6r)
	{
		EventHandler eventHandler = Wr32;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = Ws6r;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button o0QY()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rz4g(Button Ab85)
	{
		EventHandler eventHandler = An73;
		Button g = G;
		if (g != null)
		{
			((Control)g).remove_Click(eventHandler);
		}
		Button val = (G = Ab85);
		g = G;
		if (g != null)
		{
			((Control)g).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox f3D8()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hs69(TextBox b5QH)
	{
		TextBox val = (u = b5QH);
	}

	[SpecialName]
	internal virtual GroupBox i3A4()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5N9(GroupBox Fi20)
	{
		GroupBox val = (d = Fi20);
	}

	[SpecialName]
	internal virtual TextBox c5T8()
	{
		return _TextBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o1F2(TextBox Zn79)
	{
		_TextBox4 = Zn79;
	}

	[SpecialName]
	internal virtual Label k3R5()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5H1(Label q8GH)
	{
		_Label3 = q8GH;
	}

	[SpecialName]
	internal virtual Button g5SZ()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6Z4(Button Dg1m)
	{
		EventHandler eventHandler = Sy78;
		Button c = C;
		if (c != null)
		{
			((Control)c).remove_Click(eventHandler);
		}
		Button val = (C = Dg1m);
		c = C;
		if (c != null)
		{
			((Control)c).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Lp3c()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pt6y(Button d7AB)
	{
		EventHandler eventHandler = r7TD;
		Button val = a;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (a = d7AB);
		val = a;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button t6WM()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jw96(Button Xp6s)
	{
		EventHandler eventHandler = g3TN;
		Button f = F;
		if (f != null)
		{
			((Control)f).remove_Click(eventHandler);
		}
		Button val = (F = Xp6s);
		f = F;
		if (f != null)
		{
			((Control)f).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Bb6x()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5TQ(Label e2K5)
	{
		Label val = (T = e2K5);
	}

	private void Wr32(object sender, EventArgs e)
	{
		Mk6g().set_Text("");
		Zi7k().set_Text("");
	}

	private void r7TD(object sender, EventArgs e)
	{
		f3D8().set_Text("");
		c5T8().set_Text("");
	}

	private void Eq1p(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"Are you sure you want to close?", (MsgBoxStyle)4, (object)"Closing Form") == 6)
		{
			((Control)this).Hide();
			((Control)Fb9z.Forms.Ad5o()).Show();
		}
	}

	private void Sy78(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"Are you sure you want to close?", (MsgBoxStyle)4, (object)"Closing Form") == 6)
		{
			((Control)this).Hide();
			((Control)Fb9z.Forms.Ad5o()).Show();
		}
	}

	private void An73(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		string text;
		if (Operators.CompareString(Mk6g().get_Text(), "", false) == 0)
		{
			text = Interaction.InputBox("Please Enter User ID", "User ID missing", "", -1, -1);
			Mk6g().set_Text(text);
		}
		if (Operators.CompareString(Zi7k().get_Text(), "", false) == 0 && (int)Interaction.MsgBox((object)"Please enter your password", (MsgBoxStyle)20, (object)"Error Password File Missing") == 6)
		{
			((Control)this).Hide();
			((Control)Fb9z.Forms.Ad5o()).Show();
		}
		text = Mk6g().get_Text().ToUpper();
		string text2 = Zi7k().get_Text();
		string text3 = "select lpassword from leactureliblogin where luserid='" + text + "'";
		try
		{
			SqlCommand val = new SqlCommand(text3, Eb3s.con);
			string text4 = Conversions.ToString(val.ExecuteScalar());
			if (Operators.CompareString(text4, text2, false) == 0)
			{
				val = new SqlCommand("select lname from leactureliblogin where luserid='" + text + "'", Eb3s.con);
				string text5 = Conversions.ToString(val.ExecuteScalar());
				Fb9z.Forms.Mr4f().g9S5().set_Text(text.ToUpper());
				Fb9z.Forms.Mr4f().Wc9n().set_Text("staff");
				Fb9z.Forms.Mr4f().Jf96().set_Text(text5);
				Lp3c().PerformClick();
				((Control)this).Hide();
				((Control)Fb9z.Forms.Mr4f()).Show();
			}
			else
			{
				Interaction.MsgBox((object)"Invalid Username and Password", (MsgBoxStyle)16, (object)"Error");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void g3TN(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		string text;
		if (Operators.CompareString(f3D8().get_Text(), "", false) == 0)
		{
			text = Interaction.InputBox("Please Enter User ID", "User ID missing", "", -1, -1);
			Mk6g().set_Text(text);
		}
		if (Operators.CompareString(c5T8().get_Text(), "", false) == 0 && (int)Interaction.MsgBox((object)"Please enter your password", (MsgBoxStyle)20, (object)"Error Password File Missing") == 6)
		{
			((Control)this).Hide();
			((Control)Fb9z.Forms.Ad5o()).Show();
		}
		text = f3D8().get_Text().ToUpper();
		string text2 = c5T8().get_Text();
		string text3 = "select stdpassword from studentliblogin where stduserid='" + text + "'";
		try
		{
			SqlCommand val = new SqlCommand(text3, Eb3s.con);
			string text4 = Conversions.ToString(val.ExecuteScalar());
			if (Operators.CompareString(text4, text2, false) == 0)
			{
				val = new SqlCommand("select stdname from studentliblogin where stduserid='" + text + "'", Eb3s.con);
				string text5 = Conversions.ToString(val.ExecuteScalar());
				Fb9z.Forms.Mr4f().g9S5().set_Text(text.ToUpper());
				Fb9z.Forms.Mr4f().Wc9n().set_Text("student");
				Fb9z.Forms.Mr4f().Jf96().set_Text(text5);
				m5TC().PerformClick();
				((Control)this).Hide();
				((Control)Fb9z.Forms.Mr4f()).Show();
			}
			else
			{
				Interaction.MsgBox((object)"Invalid Username and Password", (MsgBoxStyle)48, (object)"Warning");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static byte[] w9TE(int Rg42)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return m8Q3.k9AT(Tb17.Km72(), Rg42);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void d8GE(object sender, FormClosedEventArgs e)
	{
		((Control)Fb9z.Forms.Ad5o()).Show();
	}
}
