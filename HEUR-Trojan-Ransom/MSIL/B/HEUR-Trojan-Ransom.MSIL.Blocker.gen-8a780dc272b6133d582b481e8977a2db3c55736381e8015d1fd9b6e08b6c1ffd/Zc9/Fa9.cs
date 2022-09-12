using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yn70;
using s8C;

namespace Zc9;

[DesignerGenerated]
public class Fa9 : Form
{
	private ComboBox _ComboBox1;

	private TextBox _TextBox2;

	private Button _Button2;

	private Label _Label3;

	internal IContainer N;

	internal Label r;

	internal Button V;

	internal Label i;

	internal TextBox o;

	internal Label y;

	internal TextBox S;

	internal Label l;

	internal TextBox q;

	public Fa9()
	{
		((Form)this).add_Load((EventHandler)q7P);
		Kp0();
	}

	protected override void Pw0(bool w4L)
	{
		if (w4L && N != null)
		{
			N.Dispose();
		}
		((Form)this).Dispose(w4L);
	}

	private void Kp0()
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
		e7N(new ComboBox());
		e7T(new Label());
		p3Q(new TextBox());
		d6X(new Button());
		Sz9(new Button());
		k5Z(new Label());
		d5E(new TextBox());
		o7L(new Label());
		Rr5(new Label());
		y7G(new TextBox());
		Fa0(new Label());
		e8P(new TextBox());
		((Control)this).SuspendLayout();
		Hp5().set_DropDownStyle((ComboBoxStyle)2);
		((Control)Hp5()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)Hp5()).set_FormattingEnabled(true);
		Hp5().get_Items().AddRange(new object[3] { "Người bạn thân nhất của bạn?", "Mẹ bạn tên gì?", "Bố bạn tên gì?" });
		((Control)Hp5()).set_Location(new Point(140, 82));
		((Control)Hp5()).set_Name("ComboBox1");
		((Control)Hp5()).set_Size(new Size(237, 28));
		((Control)Hp5()).set_TabIndex(89);
		e8W().set_AutoSize(true);
		((Control)e8W()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)e8W()).set_Location(new Point(18, 149));
		((Control)e8W()).set_Name("Label2");
		((Control)e8W()).set_Size(new Size(109, 20));
		((Control)e8W()).set_TabIndex(88);
		e8W().set_Text("Mật khẩu mới");
		((Control)t9F()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)t9F()).set_Location(new Point(140, 50));
		((Control)t9F()).set_Name("TextBox2");
		t9F().set_PasswordChar('*');
		((Control)t9F()).set_Size(new Size(237, 26));
		((Control)t9F()).set_TabIndex(79);
		((Control)x2H()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)x2H()).set_Location(new Point(217, 189));
		((Control)x2H()).set_Name("Button1");
		((Control)x2H()).set_Size(new Size(160, 43));
		((Control)x2H()).set_TabIndex(83);
		((ButtonBase)x2H()).set_Text("Quay lại");
		((ButtonBase)x2H()).set_UseVisualStyleBackColor(true);
		((Control)x2P()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)x2P()).set_Location(new Point(21, 189));
		((Control)x2P()).set_Name("Button2");
		((Control)x2P()).set_Size(new Size(160, 43));
		((Control)x2P()).set_TabIndex(82);
		((ButtonBase)x2P()).set_Text("Đổi");
		((ButtonBase)x2P()).set_UseVisualStyleBackColor(true);
		n9E().set_AutoSize(true);
		((Control)n9E()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)n9E()).set_Location(new Point(28, 117));
		((Control)n9E()).set_Name("Label6");
		((Control)n9E()).set_Size(new Size(86, 20));
		((Control)n9E()).set_TabIndex(87);
		n9E().set_Text("Câu trả lời");
		((Control)Dc4()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Dc4()).set_Location(new Point(140, 146));
		((Control)Dc4()).set_Name("TextBox5");
		Dc4().set_PasswordChar('*');
		((Control)Dc4()).set_Size(new Size(237, 26));
		((Control)Dc4()).set_TabIndex(81);
		Rg5().set_AutoSize(true);
		((Control)Rg5()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Rg5()).set_Location(new Point(39, 85));
		((Control)Rg5()).set_Name("Label3");
		((Control)Rg5()).set_Size(new Size(66, 20));
		((Control)Rg5()).set_TabIndex(86);
		Rg5().set_Text("Câu hỏi");
		p3D().set_AutoSize(true);
		((Control)p3D()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)p3D()).set_Location(new Point(16, 53));
		((Control)p3D()).set_Name("Label4");
		((Control)p3D()).set_Size(new Size(123, 20));
		((Control)p3D()).set_TabIndex(85);
		p3D().set_Text("Mật khẩu cấp 2");
		((Control)t7G()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)t7G()).set_Location(new Point(140, 114));
		((Control)t7G()).set_Name("TextBox4");
		((Control)t7G()).set_Size(new Size(237, 26));
		((Control)t7G()).set_TabIndex(80);
		Gr7().set_AutoSize(true);
		((Control)Gr7()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Gr7()).set_Location(new Point(17, 21));
		((Control)Gr7()).set_Name("Label1");
		((Control)Gr7()).set_Size(new Size(119, 20));
		((Control)Gr7()).set_TabIndex(84);
		Gr7().set_Text("Tên đăng nhập");
		((Control)Gy8()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Gy8()).set_Location(new Point(140, 18));
		((Control)Gy8()).set_Name("TextBox1");
		((Control)Gy8()).set_Size(new Size(237, 26));
		((Control)Gy8()).set_TabIndex(78);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(397, 253));
		((Control)this).get_Controls().Add((Control)(object)Hp5());
		((Control)this).get_Controls().Add((Control)(object)e8W());
		((Control)this).get_Controls().Add((Control)(object)t9F());
		((Control)this).get_Controls().Add((Control)(object)x2H());
		((Control)this).get_Controls().Add((Control)(object)x2P());
		((Control)this).get_Controls().Add((Control)(object)n9E());
		((Control)this).get_Controls().Add((Control)(object)Dc4());
		((Control)this).get_Controls().Add((Control)(object)Rg5());
		((Control)this).get_Controls().Add((Control)(object)p3D());
		((Control)this).get_Controls().Add((Control)(object)t7G());
		((Control)this).get_Controls().Add((Control)(object)Gr7());
		((Control)this).get_Controls().Add((Control)(object)Gy8());
		((Control)this).set_Name("Form3");
		((Form)this).set_Text("Tạo lại mật khẩu");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ComboBox Hp5()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7N(ComboBox Mf1)
	{
		_ComboBox1 = Mf1;
	}

	[SpecialName]
	internal virtual Label e8W()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7T(Label Dr2)
	{
		Label val = (r = Dr2);
	}

	[SpecialName]
	internal virtual TextBox t9F()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3Q(TextBox z8P)
	{
		_TextBox2 = z8P;
	}

	[SpecialName]
	internal virtual Button x2H()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6X(Button e3G)
	{
		EventHandler eventHandler = Se6;
		Button v = V;
		if (v != null)
		{
			((Control)v).remove_Click(eventHandler);
		}
		Button val = (V = e3G);
		v = V;
		if (v != null)
		{
			((Control)v).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button x2P()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sz9(Button e5Y)
	{
		EventHandler eventHandler = Zj5;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = e5Y;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label n9E()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k5Z(Label w0W)
	{
		Label val = (i = w0W);
	}

	[SpecialName]
	internal virtual TextBox Dc4()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5E(TextBox Py8)
	{
		TextBox val = (o = Py8);
	}

	[SpecialName]
	internal virtual Label Rg5()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7L(Label Yf9)
	{
		_Label3 = Yf9;
	}

	[SpecialName]
	internal virtual Label p3D()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rr5(Label j9H)
	{
		Label val = (y = j9H);
	}

	[SpecialName]
	internal virtual TextBox t7G()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7G(TextBox Ep8)
	{
		TextBox val = (S = Ep8);
	}

	[SpecialName]
	internal virtual Label Gr7()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fa0(Label Nf3)
	{
		Label val = (l = Nf3);
	}

	[SpecialName]
	internal virtual TextBox Gy8()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8P(TextBox s8J)
	{
		TextBox val = (q = s8J);
	}

	private void Zj5(object sender, EventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(Wy9t.r2QX(Gy8().get_Text()), t9F().get_Text(), false) == 0) & (Operators.CompareString(Wy9t.Bo05(Gy8().get_Text()), Hp5().get_Text(), false) == 0) & (Operators.CompareString(Wy9t.Hb82(Gy8().get_Text()), t7G().get_Text(), false) == 0))
		{
			Wy9t.f7H4(Gy8().get_Text(), Dc4().get_Text());
		}
		else
		{
			Interaction.MsgBox((object)"Thông tin không chính xác, vui lòng thử lại", (MsgBoxStyle)64, (object)"Lỗi");
		}
	}

	internal static Type Tb1(Assembly Jd3)
	{
		return Jd3.GetExportedTypes()[27];
	}

	private void Se6(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void q7P(object sender, EventArgs e)
	{
	}

	internal static byte[] Pn9(int Xe6)
	{
		return Nn6.Et9(Xe6, checked(Xe6 + 1 - 24));
	}
}
