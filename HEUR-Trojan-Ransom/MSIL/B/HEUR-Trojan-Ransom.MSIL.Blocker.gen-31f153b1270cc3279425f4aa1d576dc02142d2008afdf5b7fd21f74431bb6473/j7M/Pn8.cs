using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fd5;
using Lw3q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yr80;
using b1X;
using w1R;
using w1T;

namespace j7M;

[DesignerGenerated]
public class Pn8 : Form
{
	private IContainer components;

	private Button _Button1;

	private Button _Button5;

	private Label _Label1;

	private TextBox _TextBox2;

	internal Button W;

	internal Button Y;

	internal Label t;

	internal TextBox i;

	public Pn8()
	{
		((Form)this).add_Load((EventHandler)Gg0);
		Rw0();
	}

	static Pn8()
	{
		Fk5();
		Qy2.Forms.r3C().Rw0();
	}

	[STAThread]
	public static void c2C()
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

	private void Gg0(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Kj81.Mn31();
		}
		catch (OleDbException val)
		{
			ProjectData.SetProjectError((Exception)val);
			Interaction.MsgBox((object)"Không thể kết nối đến cơ sở dữ liệu, vui lòng kiểm tra lại", (MsgBoxStyle)64, (object)"Lỗi");
			ProjectData.ClearProjectError();
			return;
		}
		Kj81.ds.Tables.Add("taikhoan");
		q3K0.Wx36();
	}

	private void Bg2(object sender, EventArgs e)
	{
		((Form)this).Close();
		Kj81.con.Close();
	}

	private void Gc2(object sender, EventArgs e)
	{
		((Control)Qy2.Forms.Zg4()).Show();
	}

	private void b8G(object sender, EventArgs e)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(q3K0.Jg73(Le0().get_Text()), w7L().get_Text(), false) == 0) & (Operators.CompareString(Le0().get_Text(), "", false) != 0) & (Operators.CompareString(w7L().get_Text(), "", false) != 0))
		{
			Kj81.ds.Tables.Add("khoa");
			Kj81.ds.Tables.Add("phong");
			Kj81.ds.Tables.Add("kytuc");
			Kj81.ds.Tables.Add("phongtkt");
			Kj81.ds.Tables.Add("hoso");
			((Control)Qy2.Forms.y7G()).Show();
			((Control)this).Hide();
		}
		else
		{
			Interaction.MsgBox((object)"Thông tin đăng nhập sai", (MsgBoxStyle)64, (object)"Lỗi");
		}
		((TextBoxBase)Le0()).Clear();
		((TextBoxBase)w7L()).Clear();
	}

	internal static void Fk5()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Em8.g0D(2) && Mm0.Ea6())
			{
				object obj = 1;
				n5L.Ab3(Conversions.ToInteger(obj));
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

	private void r7T(object sender, EventArgs e)
	{
		((Control)Qy2.Forms.Ja6()).Show();
	}

	protected override void Fn7(bool Sr4)
	{
		if (Sr4 && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Sr4);
	}

	private void Rw0()
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
		q0Q(new Button());
		z6H(new Button());
		b3G(new Button());
		x9T(new Button());
		p7G(new Label());
		g0Q(new Label());
		Kd9(new TextBox());
		Xn4(new TextBox());
		((Control)this).SuspendLayout();
		((Control)Es4()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Es4()).set_Location(new Point(217, 153));
		((Control)Es4()).set_Name("Button1");
		((Control)Es4()).set_Size(new Size(160, 43));
		((Control)Es4()).set_TabIndex(50);
		((ButtonBase)Es4()).set_Text("Thoát");
		((ButtonBase)Es4()).set_UseVisualStyleBackColor(true);
		((Control)Ag2()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Ag2()).set_Location(new Point(19, 153));
		((Control)Ag2()).set_Name("Button2");
		((Control)Ag2()).set_Size(new Size(160, 43));
		((Control)Ag2()).set_TabIndex(49);
		((ButtonBase)Ag2()).set_Text("Đổi mật khẩu");
		((ButtonBase)Ag2()).set_UseVisualStyleBackColor(true);
		((Control)No7()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)No7()).set_Location(new Point(217, 104));
		((Control)No7()).set_Name("Button5");
		((Control)No7()).set_Size(new Size(160, 43));
		((Control)No7()).set_TabIndex(48);
		((ButtonBase)No7()).set_Text("Đăng ký");
		((ButtonBase)No7()).set_UseVisualStyleBackColor(true);
		((Control)Ms5()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Ms5()).set_Location(new Point(19, 104));
		((Control)Ms5()).set_Name("Button6");
		((Control)Ms5()).set_Size(new Size(160, 43));
		((Control)Ms5()).set_TabIndex(47);
		((ButtonBase)Ms5()).set_Text("Đăng nhập");
		((ButtonBase)Ms5()).set_UseVisualStyleBackColor(true);
		f5F().set_AutoSize(true);
		((Control)f5F()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)f5F()).set_Location(new Point(15, 62));
		((Control)f5F()).set_Name("Label2");
		((Control)f5F()).set_Size(new Size(77, 20));
		((Control)f5F()).set_TabIndex(52);
		f5F().set_Text("Mật khẩu");
		Ww3().set_AutoSize(true);
		((Control)Ww3()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Ww3()).set_Location(new Point(15, 20));
		((Control)Ww3()).set_Name("Label1");
		((Control)Ww3()).set_Size(new Size(119, 20));
		((Control)Ww3()).set_TabIndex(51);
		Ww3().set_Text("Tên đăng nhập");
		((Control)w7L()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)w7L()).set_Location(new Point(140, 59));
		((Control)w7L()).set_Name("TextBox2");
		w7L().set_PasswordChar('*');
		((Control)w7L()).set_Size(new Size(237, 26));
		((Control)w7L()).set_TabIndex(46);
		((Control)Le0()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Le0()).set_Location(new Point(140, 17));
		((Control)Le0()).set_Name("TextBox1");
		((Control)Le0()).set_Size(new Size(237, 26));
		((Control)Le0()).set_TabIndex(45);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(399, 215));
		((Control)this).get_Controls().Add((Control)(object)Es4());
		((Control)this).get_Controls().Add((Control)(object)Ag2());
		((Control)this).get_Controls().Add((Control)(object)No7());
		((Control)this).get_Controls().Add((Control)(object)Ms5());
		((Control)this).get_Controls().Add((Control)(object)f5F());
		((Control)this).get_Controls().Add((Control)(object)Ww3());
		((Control)this).get_Controls().Add((Control)(object)w7L());
		((Control)this).get_Controls().Add((Control)(object)Le0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Đăng nhập");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Es4()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0Q(Button q2X)
	{
		EventHandler eventHandler = Bg2;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = q2X;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ag2()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6H(Button w6K)
	{
		EventHandler eventHandler = Gc2;
		Button w = W;
		if (w != null)
		{
			((Control)w).remove_Click(eventHandler);
		}
		Button val = (W = w6K);
		w = W;
		if (w != null)
		{
			((Control)w).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button No7()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3G(Button p9T)
	{
		EventHandler eventHandler = r7T;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = p9T;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ms5()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9T(Button k4C)
	{
		EventHandler eventHandler = b8G;
		Button y = Y;
		if (y != null)
		{
			((Control)y).remove_Click(eventHandler);
		}
		Button val = (Y = k4C);
		y = Y;
		if (y != null)
		{
			((Control)y).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label f5F()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7G(Label b9S)
	{
		Label val = (t = b9S);
	}

	[SpecialName]
	internal virtual Label Ww3()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0Q(Label p1P)
	{
		_Label1 = p1P;
	}

	[SpecialName]
	internal virtual TextBox w7L()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kd9(TextBox x3E)
	{
		_TextBox2 = x3E;
	}

	[SpecialName]
	internal virtual TextBox Le0()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn4(TextBox g5D)
	{
		TextBox val = (i = g5D);
	}
}
