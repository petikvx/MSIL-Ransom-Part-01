using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fd5;
using Gz7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yr80;
using q9A4;

namespace w1R;

[DesignerGenerated]
public class n5L : Form
{
	private ComboBox _ComboBox1;

	private Button _Button2;

	private Label _Label6;

	private Label _Label3;

	private TextBox _TextBox4;

	private TextBox _TextBox1;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal IContainer U;

	internal Button c;

	internal TextBox N;

	internal Label H;

	internal Label P;

	internal Label J;

	internal TextBox R;

	public n5L()
	{
		((Form)this).add_Load((EventHandler)Ny9);
		z2R();
	}

	protected override void Wb7(bool d8D)
	{
		if (d8D && U != null)
		{
			U.Dispose();
		}
		((Form)this).Dispose(d8D);
	}

	private void z2R()
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		o8Z(new ComboBox());
		p1F(new Button());
		this.Ey5(new Button());
		t2Y(new Label());
		o0H(new TextBox());
		Rq0(new Label());
		this.Ey5(new Label());
		Nf5(new TextBox());
		Fd9(new Label());
		o3D(new Label());
		b5Z(new TextBox());
		w4P(new TextBox());
		((Control)this).SuspendLayout();
		Ca1().set_DropDownStyle((ComboBoxStyle)2);
		((Control)Ca1()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)Ca1()).set_FormattingEnabled(true);
		Ca1().get_Items().AddRange(new object[3] { "Người bạn thân nhất của bạn?", "Mẹ bạn tên gì?", "Bố bạn tên gì?" });
		((Control)Ca1()).set_Location(new Point(138, 108));
		((Control)Ca1()).set_Name("ComboBox1");
		((Control)Ca1()).set_Size(new Size(237, 28));
		((Control)Ca1()).set_TabIndex(75);
		((Control)j6F()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)j6F()).set_Location(new Point(215, 183));
		((Control)j6F()).set_Name("Button1");
		((Control)j6F()).set_Size(new Size(160, 43));
		((Control)j6F()).set_TabIndex(69);
		((ButtonBase)j6F()).set_Text("Quay lại");
		((ButtonBase)j6F()).set_UseVisualStyleBackColor(true);
		((Control)a5M()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)a5M()).set_Location(new Point(19, 183));
		((Control)a5M()).set_Name("Button2");
		((Control)a5M()).set_Size(new Size(160, 43));
		((Control)a5M()).set_TabIndex(68);
		((ButtonBase)a5M()).set_Text("Đăng ký");
		((ButtonBase)a5M()).set_UseVisualStyleBackColor(true);
		Fc2().set_AutoSize(true);
		((Control)Fc2()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Fc2()).set_Location(new Point(24, 143));
		((Control)Fc2()).set_Name("Label6");
		((Control)Fc2()).set_Size(new Size(86, 20));
		((Control)Fc2()).set_TabIndex(74);
		Fc2().set_Text("Câu trả lời");
		((Control)Ko5()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Ko5()).set_Location(new Point(138, 141));
		((Control)Ko5()).set_Name("TextBox6");
		((Control)Ko5()).set_Size(new Size(237, 26));
		((Control)Ko5()).set_TabIndex(67);
		s5L().set_AutoSize(true);
		((Control)s5L()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)s5L()).set_Location(new Point(34, 111));
		((Control)s5L()).set_Name("Label3");
		((Control)s5L()).set_Size(new Size(71, 20));
		((Control)s5L()).set_TabIndex(73);
		s5L().set_Text("Cẩu hỏi ");
		w3E().set_AutoSize(true);
		((Control)w3E()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)w3E()).set_Location(new Point(15, 79));
		((Control)w3E()).set_Name("Label4");
		((Control)w3E()).set_Size(new Size(123, 20));
		((Control)w3E()).set_TabIndex(72);
		w3E().set_Text("Mật khẩu cấp 2");
		((Control)Se4()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Se4()).set_Location(new Point(138, 77));
		((Control)Se4()).set_Name("TextBox4");
		Se4().set_PasswordChar('*');
		((Control)Se4()).set_Size(new Size(237, 26));
		((Control)Se4()).set_TabIndex(66);
		z5B().set_AutoSize(true);
		((Control)z5B()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)z5B()).set_Location(new Point(29, 47));
		((Control)z5B()).set_Name("Label2");
		((Control)z5B()).set_Size(new Size(77, 20));
		((Control)z5B()).set_TabIndex(71);
		z5B().set_Text("Mật khẩu");
		d3P().set_AutoSize(true);
		((Control)d3P()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)d3P()).set_Location(new Point(17, 15));
		((Control)d3P()).set_Name("Label1");
		((Control)d3P()).set_Size(new Size(119, 20));
		((Control)d3P()).set_TabIndex(70);
		d3P().set_Text("Tên đăng nhập");
		((Control)o1G()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)o1G()).set_Location(new Point(138, 46));
		((Control)o1G()).set_Name("TextBox2");
		o1G().set_PasswordChar('*');
		((Control)o1G()).set_Size(new Size(237, 26));
		((Control)o1G()).set_TabIndex(65);
		((Control)w6Z()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)w6Z()).set_Location(new Point(138, 15));
		((Control)w6Z()).set_Name("TextBox1");
		((Control)w6Z()).set_Size(new Size(237, 26));
		((Control)w6Z()).set_TabIndex(64);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(398, 244));
		((Control)this).get_Controls().Add((Control)(object)Ca1());
		((Control)this).get_Controls().Add((Control)(object)j6F());
		((Control)this).get_Controls().Add((Control)(object)a5M());
		((Control)this).get_Controls().Add((Control)(object)Fc2());
		((Control)this).get_Controls().Add((Control)(object)Ko5());
		((Control)this).get_Controls().Add((Control)(object)s5L());
		((Control)this).get_Controls().Add((Control)(object)w3E());
		((Control)this).get_Controls().Add((Control)(object)Se4());
		((Control)this).get_Controls().Add((Control)(object)z5B());
		((Control)this).get_Controls().Add((Control)(object)d3P());
		((Control)this).get_Controls().Add((Control)(object)o1G());
		((Control)this).get_Controls().Add((Control)(object)w6Z());
		((Control)this).set_Name("Form2");
		((Form)this).set_Text("Tạo tài khoản");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ComboBox Ca1()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8Z(ComboBox Nm8)
	{
		_ComboBox1 = Nm8;
	}

	[SpecialName]
	internal virtual Button j6F()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1F(Button Zs3)
	{
		EventHandler eventHandler = b2Y;
		Button val = c;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (c = Zs3);
		val = c;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button a5M()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ey5(Button m5J)
	{
		EventHandler eventHandler = e5W;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = m5J;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Fc2()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2Y(Label m8M)
	{
		_Label6 = m8M;
	}

	[SpecialName]
	internal virtual TextBox Ko5()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0H(TextBox Ew0)
	{
		TextBox val = (N = Ew0);
	}

	[SpecialName]
	internal virtual Label s5L()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rq0(Label s2W)
	{
		_Label3 = s2W;
	}

	[SpecialName]
	internal virtual Label w3E()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ey5(Label Bw2)
	{
		Label val = (H = Bw2);
	}

	[SpecialName]
	internal virtual TextBox Se4()
	{
		return _TextBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nf5(TextBox r6A)
	{
		_TextBox4 = r6A;
	}

	[SpecialName]
	internal virtual Label z5B()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fd9(Label q5Q)
	{
		Label val = (P = q5Q);
	}

	[SpecialName]
	internal virtual Label d3P()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3D(Label x1A)
	{
		Label val = (J = x1A);
	}

	[SpecialName]
	internal virtual TextBox o1G()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5Z(TextBox Mk3)
	{
		TextBox val = (R = Mk3);
	}

	[SpecialName]
	internal virtual TextBox w6Z()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4P(TextBox z7P)
	{
		_TextBox1 = z7P;
	}

	private void e5W(object sender, EventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(q3K0.Jg73(w6Z().get_Text()), "", false) == 0)
		{
			q3K0.t3W5(w6Z().get_Text(), o1G().get_Text(), Se4().get_Text(), Ca1().get_Text(), Ko5().get_Text());
			Interaction.MsgBox((object)"Thành công", (MsgBoxStyle)64, (object)"Chúc mừng");
		}
		else
		{
			Interaction.MsgBox((object)"Tài khoản đã tồn tại", (MsgBoxStyle)64, (object)"Lỗi");
		}
		((TextBoxBase)w6Z()).Clear();
		((TextBoxBase)o1G()).Clear();
		((TextBoxBase)Se4()).Clear();
		((TextBoxBase)Ko5()).Clear();
		((Control)Ca1()).Refresh();
	}

	internal static void Ab3(int x0H)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"qwe", "asd", "zxc", "rty", "fgh", "vbn", "uio", "jkl", "nmm", "iii",
			"ppp"
		};
		dName = Em8.c0D(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = Em8.c0D(Listt, x0H, 1);
		checked
		{
			mName = Em8.c0D(Listt, x0H + 1, 2);
			mArray = Em8.c0D(Listt, x0H + 2, 3);
			sArray = Em8.c0D(Listt, x0H + 3, 4);
			T = Em8.c0D(Listt, x0H + 4, 5);
			sNum = Em8.c0D(Listt, x0H + 5, 6);
			if ((double)x0H != 2503.0)
			{
				x0H = 38;
				mDic.Add(sNum, 38);
			}
			byte[] value = e3S.Rw7(x0H);
			mDic.Add(sArray, value);
			j5Q4.t1Z5();
		}
	}

	private void b2Y(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void Ny9(object sender, EventArgs e)
	{
	}
}
