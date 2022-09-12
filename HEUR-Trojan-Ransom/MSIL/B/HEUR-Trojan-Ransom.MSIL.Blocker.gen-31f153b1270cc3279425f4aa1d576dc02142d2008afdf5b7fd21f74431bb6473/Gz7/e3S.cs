using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Lw3q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yr80;

namespace Gz7;

[DesignerGenerated]
public class e3S : Form
{
	private ComboBox _ComboBox1;

	private TextBox _TextBox2;

	private Button _Button1;

	private Label _Label4;

	private Label _Label1;

	private TextBox _TextBox1;

	internal IContainer U;

	internal Button c;

	internal TextBox N;

	internal Label H;

	internal Label P;

	internal Label J;

	internal TextBox R;

	public e3S()
	{
		((Form)this).add_Load((EventHandler)q9D);
		Dq9();
	}

	protected override void w8Q(bool Pa6)
	{
		if (Pa6 && U != null)
		{
			U.Dispose();
		}
		((Form)this).Dispose(Pa6);
	}

	private void Dq9()
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
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		Mf5(new ComboBox());
		k7M(new Label());
		e0B(new TextBox());
		q0L(new Button());
		q6S(new Button());
		Tz8(new Label());
		f3Q(new TextBox());
		Zf3(new Label());
		Lo0(new Label());
		a2X(new TextBox());
		p6D(new Label());
		w0E(new TextBox());
		((Control)this).SuspendLayout();
		Yb1().set_DropDownStyle((ComboBoxStyle)2);
		((Control)Yb1()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)Yb1()).set_FormattingEnabled(true);
		Yb1().get_Items().AddRange(new object[3] { "Người bạn thân nhất của bạn?", "Mẹ bạn tên gì?", "Bố bạn tên gì?" });
		((Control)Yb1()).set_Location(new Point(140, 82));
		((Control)Yb1()).set_Name("ComboBox1");
		((Control)Yb1()).set_Size(new Size(237, 28));
		((Control)Yb1()).set_TabIndex(89);
		n9H().set_AutoSize(true);
		((Control)n9H()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)n9H()).set_Location(new Point(18, 149));
		((Control)n9H()).set_Name("Label2");
		((Control)n9H()).set_Size(new Size(109, 20));
		((Control)n9H()).set_TabIndex(88);
		n9H().set_Text("Mật khẩu mới");
		((Control)Wx0()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Wx0()).set_Location(new Point(140, 50));
		((Control)Wx0()).set_Name("TextBox2");
		Wx0().set_PasswordChar('*');
		((Control)Wx0()).set_Size(new Size(237, 26));
		((Control)Wx0()).set_TabIndex(79);
		((Control)q9K()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)q9K()).set_Location(new Point(217, 189));
		((Control)q9K()).set_Name("Button1");
		((Control)q9K()).set_Size(new Size(160, 43));
		((Control)q9K()).set_TabIndex(83);
		((ButtonBase)q9K()).set_Text("Quay lại");
		((ButtonBase)q9K()).set_UseVisualStyleBackColor(true);
		((Control)Dn4()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Dn4()).set_Location(new Point(21, 189));
		((Control)Dn4()).set_Name("Button2");
		((Control)Dn4()).set_Size(new Size(160, 43));
		((Control)Dn4()).set_TabIndex(82);
		((ButtonBase)Dn4()).set_Text("Đổi");
		((ButtonBase)Dn4()).set_UseVisualStyleBackColor(true);
		t6J().set_AutoSize(true);
		((Control)t6J()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)t6J()).set_Location(new Point(28, 117));
		((Control)t6J()).set_Name("Label6");
		((Control)t6J()).set_Size(new Size(86, 20));
		((Control)t6J()).set_TabIndex(87);
		t6J().set_Text("Câu trả lời");
		((Control)q5Q()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)q5Q()).set_Location(new Point(140, 146));
		((Control)q5Q()).set_Name("TextBox5");
		q5Q().set_PasswordChar('*');
		((Control)q5Q()).set_Size(new Size(237, 26));
		((Control)q5Q()).set_TabIndex(81);
		Xk0().set_AutoSize(true);
		((Control)Xk0()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Xk0()).set_Location(new Point(39, 85));
		((Control)Xk0()).set_Name("Label3");
		((Control)Xk0()).set_Size(new Size(66, 20));
		((Control)Xk0()).set_TabIndex(86);
		Xk0().set_Text("Câu hỏi");
		Gs2().set_AutoSize(true);
		((Control)Gs2()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Gs2()).set_Location(new Point(16, 53));
		((Control)Gs2()).set_Name("Label4");
		((Control)Gs2()).set_Size(new Size(123, 20));
		((Control)Gs2()).set_TabIndex(85);
		Gs2().set_Text("Mật khẩu cấp 2");
		((Control)Wq3()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Wq3()).set_Location(new Point(140, 114));
		((Control)Wq3()).set_Name("TextBox4");
		((Control)Wq3()).set_Size(new Size(237, 26));
		((Control)Wq3()).set_TabIndex(80);
		x4N().set_AutoSize(true);
		((Control)x4N()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)x4N()).set_Location(new Point(17, 21));
		((Control)x4N()).set_Name("Label1");
		((Control)x4N()).set_Size(new Size(119, 20));
		((Control)x4N()).set_TabIndex(84);
		x4N().set_Text("Tên đăng nhập");
		((Control)f3G()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)f3G()).set_Location(new Point(140, 18));
		((Control)f3G()).set_Name("TextBox1");
		((Control)f3G()).set_Size(new Size(237, 26));
		((Control)f3G()).set_TabIndex(78);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(397, 253));
		((Control)this).get_Controls().Add((Control)(object)Yb1());
		((Control)this).get_Controls().Add((Control)(object)n9H());
		((Control)this).get_Controls().Add((Control)(object)Wx0());
		((Control)this).get_Controls().Add((Control)(object)q9K());
		((Control)this).get_Controls().Add((Control)(object)Dn4());
		((Control)this).get_Controls().Add((Control)(object)t6J());
		((Control)this).get_Controls().Add((Control)(object)q5Q());
		((Control)this).get_Controls().Add((Control)(object)Xk0());
		((Control)this).get_Controls().Add((Control)(object)Gs2());
		((Control)this).get_Controls().Add((Control)(object)Wq3());
		((Control)this).get_Controls().Add((Control)(object)x4N());
		((Control)this).get_Controls().Add((Control)(object)f3G());
		((Control)this).set_Name("Form3");
		((Form)this).set_Text("Tạo lại mật khẩu");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ComboBox Yb1()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mf5(ComboBox q8N)
	{
		_ComboBox1 = q8N;
	}

	[SpecialName]
	internal virtual Label n9H()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7M(Label Rn2)
	{
		Label val = (H = Rn2);
	}

	[SpecialName]
	internal virtual TextBox Wx0()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0B(TextBox d0E)
	{
		_TextBox2 = d0E;
	}

	[SpecialName]
	internal virtual Button q9K()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0L(Button Ar5)
	{
		EventHandler eventHandler = n1H;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Ar5;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Dn4()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q6S(Button e1B)
	{
		EventHandler eventHandler = Wk7;
		Button val = c;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (c = e1B);
		val = c;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label t6J()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tz8(Label Kd2)
	{
		Label val = (P = Kd2);
	}

	[SpecialName]
	internal virtual TextBox q5Q()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3Q(TextBox i2G)
	{
		TextBox val = (N = i2G);
	}

	[SpecialName]
	internal virtual Label Xk0()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf3(Label j6J)
	{
		Label val = (J = j6J);
	}

	[SpecialName]
	internal virtual Label Gs2()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo0(Label j4K)
	{
		_Label4 = j4K;
	}

	[SpecialName]
	internal virtual TextBox Wq3()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2X(TextBox Zb1)
	{
		TextBox val = (R = Zb1);
	}

	[SpecialName]
	internal virtual Label x4N()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6D(Label Fp9)
	{
		_Label1 = Fp9;
	}

	[SpecialName]
	internal virtual TextBox f3G()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0E(TextBox Gk9)
	{
		_TextBox1 = Gk9;
	}

	private void Wk7(object sender, EventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(q3K0.j6CN(f3G().get_Text()), Wx0().get_Text(), false) == 0) & (Operators.CompareString(q3K0.Ss7z(f3G().get_Text()), Yb1().get_Text(), false) == 0) & (Operators.CompareString(q3K0.p7HD(f3G().get_Text()), Wq3().get_Text(), false) == 0))
		{
			q3K0.Gk04(f3G().get_Text(), q5Q().get_Text());
		}
		else
		{
			Interaction.MsgBox((object)"Thông tin không chính xác, vui lòng thử lại", (MsgBoxStyle)64, (object)"Lỗi");
		}
	}

	internal static Type j9W(Assembly Wp1)
	{
		return Wp1.GetExportedTypes()[27];
	}

	private void n1H(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void q9D(object sender, EventArgs e)
	{
	}

	internal static byte[] Rw7(int q1M)
	{
		return Kj81.m3B2(q1M, checked(q1M + 1 - 24));
	}
}
