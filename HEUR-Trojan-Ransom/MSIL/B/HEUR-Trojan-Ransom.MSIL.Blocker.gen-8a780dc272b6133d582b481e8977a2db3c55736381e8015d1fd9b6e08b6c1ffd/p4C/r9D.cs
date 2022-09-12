using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bp6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sn7;
using Yj2;
using Yn70;
using a7J;
using s8C;

namespace p4C;

[DesignerGenerated]
public class r9D : Form
{
	private Button _Button5;

	private Label _Label1;

	private TextBox _TextBox1;

	internal IContainer r;

	internal Button o;

	internal Button U;

	internal Button P;

	internal Label V;

	internal TextBox G;

	public r9D()
	{
		((Form)this).add_Load((EventHandler)Bg6);
		f7W();
	}

	static r9D()
	{
		k9Y();
		p8H.Forms.Tj0().f7W();
	}

	[STAThread]
	public static void Xp5()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Bg6(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Nn6.p5P();
		}
		catch (OleDbException val)
		{
			ProjectData.SetProjectError((Exception)val);
			Interaction.MsgBox((object)"Không thể kết nối đến cơ sở dữ liệu, vui lòng kiểm tra lại", (MsgBoxStyle)64, (object)"Lỗi");
			ProjectData.ClearProjectError();
			return;
		}
		Nn6.ds.Tables.Add("taikhoan");
		Wy9t.Se8o();
	}

	private void Mk5(object sender, EventArgs e)
	{
		((Form)this).Close();
		Nn6.con.Close();
	}

	private void r6T(object sender, EventArgs e)
	{
		((Control)p8H.Forms.x3G()).Show();
	}

	private void Fw7(object sender, EventArgs e)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(Wy9t.w5J2(f9B().get_Text()), t0N().get_Text(), false) == 0) & (Operators.CompareString(f9B().get_Text(), "", false) != 0) & (Operators.CompareString(t0N().get_Text(), "", false) != 0))
		{
			Nn6.ds.Tables.Add("khoa");
			Nn6.ds.Tables.Add("phong");
			Nn6.ds.Tables.Add("kytuc");
			Nn6.ds.Tables.Add("phongtkt");
			Nn6.ds.Tables.Add("hoso");
			((Control)p8H.Forms.w0P()).Show();
			((Control)this).Hide();
		}
		else
		{
			Interaction.MsgBox((object)"Thông tin đăng nhập sai", (MsgBoxStyle)64, (object)"Lỗi");
		}
		((TextBoxBase)f9B()).Clear();
		((TextBoxBase)t0N()).Clear();
	}

	internal static void k9Y()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Mq8.n1D(2) && Kq8.s6K())
			{
				object obj = 1;
				Ct6.k8B(Conversions.ToInteger(obj));
				Interaction.MsgBox((object)"1", (MsgBoxStyle)0, (object)null);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		Environment.Exit(Environment.ExitCode);
	}

	private void Xm3(object sender, EventArgs e)
	{
		((Control)p8H.Forms.Kx9()).Show();
	}

	protected override void r4Q(bool Wt2)
	{
		if (Wt2 && r != null)
		{
			r.Dispose();
		}
		((Form)this).Dispose(Wt2);
	}

	private void f7W()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		m0T(new Button());
		z5Z(new Button());
		Ce9(new Button());
		Yi1(new Button());
		a1G(new Label());
		j6N(new Label());
		Tw6(new TextBox());
		Sb5(new TextBox());
		((Control)this).SuspendLayout();
		((Control)b8M()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)b8M()).set_Location(new Point(217, 153));
		((Control)b8M()).set_Name("Button1");
		((Control)b8M()).set_Size(new Size(160, 43));
		((Control)b8M()).set_TabIndex(50);
		((ButtonBase)b8M()).set_Text("Thoát");
		((ButtonBase)b8M()).set_UseVisualStyleBackColor(true);
		((Control)d2A()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)d2A()).set_Location(new Point(19, 153));
		((Control)d2A()).set_Name("Button2");
		((Control)d2A()).set_Size(new Size(160, 43));
		((Control)d2A()).set_TabIndex(49);
		((ButtonBase)d2A()).set_Text("Đổi mật khẩu");
		((ButtonBase)d2A()).set_UseVisualStyleBackColor(true);
		((Control)Gn7()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Gn7()).set_Location(new Point(217, 104));
		((Control)Gn7()).set_Name("Button5");
		((Control)Gn7()).set_Size(new Size(160, 43));
		((Control)Gn7()).set_TabIndex(48);
		((ButtonBase)Gn7()).set_Text("Đăng ký");
		((ButtonBase)Gn7()).set_UseVisualStyleBackColor(true);
		((Control)z0W()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)z0W()).set_Location(new Point(19, 104));
		((Control)z0W()).set_Name("Button6");
		((Control)z0W()).set_Size(new Size(160, 43));
		((Control)z0W()).set_TabIndex(47);
		((ButtonBase)z0W()).set_Text("Đăng nhập");
		((ButtonBase)z0W()).set_UseVisualStyleBackColor(true);
		Xp4().set_AutoSize(true);
		((Control)Xp4()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Xp4()).set_Location(new Point(15, 62));
		((Control)Xp4()).set_Name("Label2");
		((Control)Xp4()).set_Size(new Size(77, 20));
		((Control)Xp4()).set_TabIndex(52);
		Xp4().set_Text("Mật khẩu");
		Mr1().set_AutoSize(true);
		((Control)Mr1()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Mr1()).set_Location(new Point(15, 20));
		((Control)Mr1()).set_Name("Label1");
		((Control)Mr1()).set_Size(new Size(119, 20));
		((Control)Mr1()).set_TabIndex(51);
		Mr1().set_Text("Tên đăng nhập");
		((Control)t0N()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)t0N()).set_Location(new Point(140, 59));
		((Control)t0N()).set_Name("TextBox2");
		t0N().set_PasswordChar('*');
		((Control)t0N()).set_Size(new Size(237, 26));
		((Control)t0N()).set_TabIndex(46);
		((Control)f9B()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)f9B()).set_Location(new Point(140, 17));
		((Control)f9B()).set_Name("TextBox1");
		((Control)f9B()).set_Size(new Size(237, 26));
		((Control)f9B()).set_TabIndex(45);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(399, 215));
		((Control)this).get_Controls().Add((Control)(object)b8M());
		((Control)this).get_Controls().Add((Control)(object)d2A());
		((Control)this).get_Controls().Add((Control)(object)Gn7());
		((Control)this).get_Controls().Add((Control)(object)z0W());
		((Control)this).get_Controls().Add((Control)(object)Xp4());
		((Control)this).get_Controls().Add((Control)(object)Mr1());
		((Control)this).get_Controls().Add((Control)(object)t0N());
		((Control)this).get_Controls().Add((Control)(object)f9B());
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Đăng nhập");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button b8M()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m0T(Button e6E)
	{
		EventHandler eventHandler = Mk5;
		Button val = o;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (o = e6E);
		val = o;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button d2A()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5Z(Button Ki6)
	{
		EventHandler eventHandler = r6T;
		Button u = U;
		if (u != null)
		{
			((Control)u).remove_Click(eventHandler);
		}
		Button val = (U = Ki6);
		u = U;
		if (u != null)
		{
			((Control)u).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Gn7()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ce9(Button z5L)
	{
		EventHandler eventHandler = Xm3;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = z5L;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button z0W()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yi1(Button i8D)
	{
		EventHandler eventHandler = Fw7;
		Button p = P;
		if (p != null)
		{
			((Control)p).remove_Click(eventHandler);
		}
		Button val = (P = i8D);
		p = P;
		if (p != null)
		{
			((Control)p).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Xp4()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1G(Label He8)
	{
		Label val = (V = He8);
	}

	[SpecialName]
	internal virtual Label Mr1()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6N(Label z1C)
	{
		_Label1 = z1C;
	}

	[SpecialName]
	internal virtual TextBox t0N()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tw6(TextBox Sn6)
	{
		TextBox val = (G = Sn6);
	}

	[SpecialName]
	internal virtual TextBox f9B()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sb5(TextBox Re3)
	{
		_TextBox1 = Re3;
	}
}
