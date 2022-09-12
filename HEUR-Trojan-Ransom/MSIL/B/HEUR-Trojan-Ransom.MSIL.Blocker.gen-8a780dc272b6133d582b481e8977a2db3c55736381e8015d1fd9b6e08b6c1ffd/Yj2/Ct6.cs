using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ey8t;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yn70;
using Zc9;
using a7J;

namespace Yj2;

[DesignerGenerated]
public class Ct6 : Form
{
	private ComboBox _ComboBox1;

	private Label _Label6;

	private Label _Label4;

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

	internal IContainer y;

	internal Button e;

	internal Button C;

	internal TextBox f;

	internal Label w;

	internal TextBox x;

	internal Label i;

	internal Label s;

	internal TextBox O;

	public Ct6()
	{
		((Form)this).add_Load((EventHandler)Kq7);
		Za6();
	}

	protected override void Pd6(bool Mc5)
	{
		if (Mc5 && y != null)
		{
			y.Dispose();
		}
		((Form)this).Dispose(Mc5);
	}

	private void Za6()
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
		g3C(new ComboBox());
		Qw0(new Button());
		Bd4(new Button());
		o8F(new Label());
		s2A(new TextBox());
		Cw7(new Label());
		Dg9(new Label());
		Pg1(new TextBox());
		Zt1(new Label());
		Zg5(new Label());
		k0K(new TextBox());
		Cg2(new TextBox());
		((Control)this).SuspendLayout();
		p1Q().set_DropDownStyle((ComboBoxStyle)2);
		((Control)p1Q()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)p1Q()).set_FormattingEnabled(true);
		p1Q().get_Items().AddRange(new object[3] { "Người bạn thân nhất của bạn?", "Mẹ bạn tên gì?", "Bố bạn tên gì?" });
		((Control)p1Q()).set_Location(new Point(138, 108));
		((Control)p1Q()).set_Name("ComboBox1");
		((Control)p1Q()).set_Size(new Size(237, 28));
		((Control)p1Q()).set_TabIndex(75);
		((Control)Pf0()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Pf0()).set_Location(new Point(215, 183));
		((Control)Pf0()).set_Name("Button1");
		((Control)Pf0()).set_Size(new Size(160, 43));
		((Control)Pf0()).set_TabIndex(69);
		((ButtonBase)Pf0()).set_Text("Quay lại");
		((ButtonBase)Pf0()).set_UseVisualStyleBackColor(true);
		((Control)n9Y()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)n9Y()).set_Location(new Point(19, 183));
		((Control)n9Y()).set_Name("Button2");
		((Control)n9Y()).set_Size(new Size(160, 43));
		((Control)n9Y()).set_TabIndex(68);
		((ButtonBase)n9Y()).set_Text("Đăng ký");
		((ButtonBase)n9Y()).set_UseVisualStyleBackColor(true);
		Yj2().set_AutoSize(true);
		((Control)Yj2()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Yj2()).set_Location(new Point(24, 143));
		((Control)Yj2()).set_Name("Label6");
		((Control)Yj2()).set_Size(new Size(86, 20));
		((Control)Yj2()).set_TabIndex(74);
		Yj2().set_Text("Câu trả lời");
		((Control)Pq8()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Pq8()).set_Location(new Point(138, 141));
		((Control)Pq8()).set_Name("TextBox6");
		((Control)Pq8()).set_Size(new Size(237, 26));
		((Control)Pq8()).set_TabIndex(67);
		e7M().set_AutoSize(true);
		((Control)e7M()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)e7M()).set_Location(new Point(34, 111));
		((Control)e7M()).set_Name("Label3");
		((Control)e7M()).set_Size(new Size(71, 20));
		((Control)e7M()).set_TabIndex(73);
		e7M().set_Text("Cẩu hỏi ");
		q2K().set_AutoSize(true);
		((Control)q2K()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)q2K()).set_Location(new Point(15, 79));
		((Control)q2K()).set_Name("Label4");
		((Control)q2K()).set_Size(new Size(123, 20));
		((Control)q2K()).set_TabIndex(72);
		q2K().set_Text("Mật khẩu cấp 2");
		((Control)d6K()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)d6K()).set_Location(new Point(138, 77));
		((Control)d6K()).set_Name("TextBox4");
		d6K().set_PasswordChar('*');
		((Control)d6K()).set_Size(new Size(237, 26));
		((Control)d6K()).set_TabIndex(66);
		t3L().set_AutoSize(true);
		((Control)t3L()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)t3L()).set_Location(new Point(29, 47));
		((Control)t3L()).set_Name("Label2");
		((Control)t3L()).set_Size(new Size(77, 20));
		((Control)t3L()).set_TabIndex(71);
		t3L().set_Text("Mật khẩu");
		An9().set_AutoSize(true);
		((Control)An9()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)An9()).set_Location(new Point(17, 15));
		((Control)An9()).set_Name("Label1");
		((Control)An9()).set_Size(new Size(119, 20));
		((Control)An9()).set_TabIndex(70);
		An9().set_Text("Tên đăng nhập");
		((Control)Sz3()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Sz3()).set_Location(new Point(138, 46));
		((Control)Sz3()).set_Name("TextBox2");
		Sz3().set_PasswordChar('*');
		((Control)Sz3()).set_Size(new Size(237, 26));
		((Control)Sz3()).set_TabIndex(65);
		((Control)c3B()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)c3B()).set_Location(new Point(138, 15));
		((Control)c3B()).set_Name("TextBox1");
		((Control)c3B()).set_Size(new Size(237, 26));
		((Control)c3B()).set_TabIndex(64);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(398, 244));
		((Control)this).get_Controls().Add((Control)(object)p1Q());
		((Control)this).get_Controls().Add((Control)(object)Pf0());
		((Control)this).get_Controls().Add((Control)(object)n9Y());
		((Control)this).get_Controls().Add((Control)(object)Yj2());
		((Control)this).get_Controls().Add((Control)(object)Pq8());
		((Control)this).get_Controls().Add((Control)(object)e7M());
		((Control)this).get_Controls().Add((Control)(object)q2K());
		((Control)this).get_Controls().Add((Control)(object)d6K());
		((Control)this).get_Controls().Add((Control)(object)t3L());
		((Control)this).get_Controls().Add((Control)(object)An9());
		((Control)this).get_Controls().Add((Control)(object)Sz3());
		((Control)this).get_Controls().Add((Control)(object)c3B());
		((Control)this).set_Name("Form2");
		((Form)this).set_Text("Tạo tài khoản");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ComboBox p1Q()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3C(ComboBox Xp6)
	{
		_ComboBox1 = Xp6;
	}

	[SpecialName]
	internal virtual Button Pf0()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qw0(Button Jn5)
	{
		EventHandler eventHandler = Kf8;
		Button val = e;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (e = Jn5);
		val = e;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button n9Y()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd4(Button Yz0)
	{
		EventHandler eventHandler = Bk2;
		Button c = C;
		if (c != null)
		{
			((Control)c).remove_Click(eventHandler);
		}
		Button val = (C = Yz0);
		c = C;
		if (c != null)
		{
			((Control)c).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Yj2()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8F(Label Ey8)
	{
		_Label6 = Ey8;
	}

	[SpecialName]
	internal virtual TextBox Pq8()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2A(TextBox Ay7)
	{
		TextBox val = (f = Ay7);
	}

	[SpecialName]
	internal virtual Label e7M()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cw7(Label Kr2)
	{
		Label val = (w = Kr2);
	}

	[SpecialName]
	internal virtual Label q2K()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dg9(Label s4M)
	{
		_Label4 = s4M;
	}

	[SpecialName]
	internal virtual TextBox d6K()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg1(TextBox o7A)
	{
		TextBox val = (x = o7A);
	}

	[SpecialName]
	internal virtual Label t3L()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zt1(Label En4)
	{
		Label val = (i = En4);
	}

	[SpecialName]
	internal virtual Label An9()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg5(Label Ag5)
	{
		Label val = (s = Ag5);
	}

	[SpecialName]
	internal virtual TextBox Sz3()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0K(TextBox Xp3)
	{
		TextBox val = (O = Xp3);
	}

	[SpecialName]
	internal virtual TextBox c3B()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cg2(TextBox Cw0)
	{
		_TextBox1 = Cw0;
	}

	private void Bk2(object sender, EventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Wy9t.w5J2(c3B().get_Text()), "", false) == 0)
		{
			Wy9t.n3C2(c3B().get_Text(), Sz3().get_Text(), d6K().get_Text(), p1Q().get_Text(), Pq8().get_Text());
			Interaction.MsgBox((object)"Thành công", (MsgBoxStyle)64, (object)"Chúc mừng");
		}
		else
		{
			Interaction.MsgBox((object)"Tài khoản đã tồn tại", (MsgBoxStyle)64, (object)"Lỗi");
		}
		((TextBoxBase)c3B()).Clear();
		((TextBoxBase)Sz3()).Clear();
		((TextBoxBase)d6K()).Clear();
		((TextBoxBase)Pq8()).Clear();
		((Control)p1Q()).Refresh();
	}

	internal static void k8B(int g3R)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"qwe", "asd", "zxc", "rty", "fgh", "vbn", "uio", "jkl", "nmm", "iii",
			"ppp"
		};
		dName = Mq8.q8R(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = Mq8.q8R(Listt, g3R, 1);
		checked
		{
			mName = Mq8.q8R(Listt, g3R + 1, 2);
			mArray = Mq8.q8R(Listt, g3R + 2, 3);
			sArray = Mq8.q8R(Listt, g3R + 3, 4);
			T = Mq8.q8R(Listt, g3R + 4, 5);
			sNum = Mq8.q8R(Listt, g3R + 5, 6);
			if ((double)g3R != 2503.0)
			{
				g3R = 38;
				mDic.Add(sNum, 38);
			}
			byte[] value = Fa9.Pn9(g3R);
			mDic.Add(sArray, value);
			d0N.f8H5();
		}
	}

	private void Kf8(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void Kq7(object sender, EventArgs e)
	{
	}
}
