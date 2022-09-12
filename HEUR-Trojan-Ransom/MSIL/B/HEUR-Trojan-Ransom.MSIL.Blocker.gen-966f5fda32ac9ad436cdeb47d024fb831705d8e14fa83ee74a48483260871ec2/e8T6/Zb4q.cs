using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bb9w;
using Cb4;
using Ht3;
using Microsoft.VisualBasic.CompilerServices;
using Pp27;
using Rx8m;
using r9JD;

namespace e8T6;

[DesignerGenerated]
public class Zb4q : Form
{
	private Label _Label1;

	private Label _Label2;

	private Button _btnDone;

	internal IContainer f;

	internal Label d;

	internal Label x;

	internal TextBox g;

	internal TextBox W;

	internal TextBox I;

	internal TextBox q;

	internal Button M;

	internal f1T9 R;

	public Zb4q()
	{
		((Form)this).add_Load((EventHandler)Mz54);
		f1T9 f1T = (R = new f1T9());
		z0RS();
	}

	protected override void Hw60(bool g0QS)
	{
		try
		{
			if (g0QS && f != null)
			{
				f.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g0QS);
		}
	}

	private void z0RS()
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
		d4ZL(new Label());
		x8KX(new Label());
		k2GC(new Label());
		r4W1(new Label());
		k1P4(new TextBox());
		Xo7b(new TextBox());
		Yj53(new TextBox());
		Me5i(new TextBox());
		Ms6p(new Button());
		w4GB(new Button());
		((Control)this).SuspendLayout();
		a4K1().set_AutoSize(true);
		((Control)a4K1()).set_Location(new Point(12, 35));
		((Control)a4K1()).set_Name("Label1");
		((Control)a4K1()).set_Size(new Size(40, 13));
		((Control)a4K1()).set_TabIndex(0);
		a4K1().set_Text("Ma KH");
		Dd09().set_AutoSize(true);
		((Control)Dd09()).set_Location(new Point(12, 66));
		((Control)Dd09()).set_Name("Label2");
		((Control)Dd09()).set_Size(new Size(44, 13));
		((Control)Dd09()).set_TabIndex(1);
		Dd09().set_Text("Ten KH");
		d6XG().set_AutoSize(true);
		((Control)d6XG()).set_Location(new Point(12, 99));
		((Control)d6XG()).set_Name("Label3");
		((Control)d6XG()).set_Size(new Size(41, 13));
		((Control)d6XG()).set_TabIndex(2);
		d6XG().set_Text("Dia Chi");
		i1F4().set_AutoSize(true);
		((Control)i1F4()).set_Location(new Point(12, 133));
		((Control)i1F4()).set_Name("Label4");
		((Control)i1F4()).set_Size(new Size(29, 13));
		((Control)i1F4()).set_TabIndex(3);
		i1F4().set_Text("SDT");
		((Control)b6S9()).set_Location(new Point(77, 32));
		((Control)b6S9()).set_Name("txtMakh");
		((Control)b6S9()).set_Size(new Size(174, 20));
		((Control)b6S9()).set_TabIndex(4);
		((Control)He0r()).set_Location(new Point(77, 63));
		((Control)He0r()).set_Name("txtTenkh");
		((Control)He0r()).set_Size(new Size(174, 20));
		((Control)He0r()).set_TabIndex(5);
		((Control)z5X9()).set_Location(new Point(77, 96));
		((Control)z5X9()).set_Name("txtDiachi");
		((Control)z5X9()).set_Size(new Size(174, 20));
		((Control)z5X9()).set_TabIndex(6);
		((Control)o0E1()).set_Location(new Point(77, 133));
		((Control)o0E1()).set_Name("txtSDT");
		((Control)o0E1()).set_Size(new Size(174, 20));
		((Control)o0E1()).set_TabIndex(7);
		((Control)Zb23()).set_Location(new Point(35, 181));
		((Control)Zb23()).set_Name("btnDone");
		((Control)Zb23()).set_Size(new Size(75, 23));
		((Control)Zb23()).set_TabIndex(8);
		((ButtonBase)Zb23()).set_Text("Done");
		((ButtonBase)Zb23()).set_UseVisualStyleBackColor(true);
		((Control)t7X3()).set_Location(new Point(176, 181));
		((Control)t7X3()).set_Name("btnGetout");
		((Control)t7X3()).set_Size(new Size(75, 23));
		((Control)t7X3()).set_TabIndex(9);
		((ButtonBase)t7X3()).set_Text("Get out");
		((ButtonBase)t7X3()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)t7X3());
		((Control)this).get_Controls().Add((Control)(object)Zb23());
		((Control)this).get_Controls().Add((Control)(object)o0E1());
		((Control)this).get_Controls().Add((Control)(object)z5X9());
		((Control)this).get_Controls().Add((Control)(object)He0r());
		((Control)this).get_Controls().Add((Control)(object)b6S9());
		((Control)this).get_Controls().Add((Control)(object)i1F4());
		((Control)this).get_Controls().Add((Control)(object)d6XG());
		((Control)this).get_Controls().Add((Control)(object)Dd09());
		((Control)this).get_Controls().Add((Control)(object)a4K1());
		((Control)this).set_Name("AddKH");
		((Form)this).set_Text("AddKH");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label a4K1()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4ZL(Label w9TR)
	{
		_Label1 = w9TR;
	}

	[SpecialName]
	internal virtual Label Dd09()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8KX(Label Gj6w)
	{
		_Label2 = Gj6w;
	}

	[SpecialName]
	internal virtual Label d6XG()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2GC(Label Do47)
	{
		Label val = (d = Do47);
	}

	[SpecialName]
	internal virtual Label i1F4()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4W1(Label g5YW)
	{
		Label val = (x = g5YW);
	}

	[SpecialName]
	internal virtual TextBox b6S9()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1P4(TextBox Dr6i)
	{
		TextBox val = (g = Dr6i);
	}

	[SpecialName]
	internal virtual TextBox He0r()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xo7b(TextBox q8D6)
	{
		TextBox val = (W = q8D6);
	}

	[SpecialName]
	internal virtual TextBox z5X9()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yj53(TextBox c2SB)
	{
		TextBox val = (I = c2SB);
	}

	[SpecialName]
	internal virtual TextBox o0E1()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Me5i(TextBox g5M3)
	{
		TextBox val = (q = g5M3);
	}

	[SpecialName]
	internal virtual Button Zb23()
	{
		return _btnDone;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ms6p(Button Gq32)
	{
		EventHandler eventHandler = w4FN;
		Button btnDone = _btnDone;
		if (btnDone != null)
		{
			((Control)btnDone).remove_Click(eventHandler);
		}
		_btnDone = Gq32;
		btnDone = _btnDone;
		if (btnDone != null)
		{
			((Control)btnDone).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button t7X3()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4GB(Button Lo8z)
	{
		EventHandler eventHandler = e2LN;
		Button m = M;
		if (m != null)
		{
			((Control)m).remove_Click(eventHandler);
		}
		Button val = (M = Lo8z);
		m = M;
		if (m != null)
		{
			((Control)m).add_Click(eventHandler);
		}
	}

	private bool Bg7j()
	{
		string text = "INSERT INTO KhachHang (MaKH,TenKH,Diachi,SoDT)";
		text += $"VALUES ('{b6S9().get_Text()}','{He0r().get_Text()}','{z5X9().get_Text()}','{o0E1().get_Text()}')";
		return R.Li4f(text);
	}

	private bool Ng6f()
	{
		return string.IsNullOrEmpty(b6S9().get_Text()) || string.IsNullOrEmpty(He0r().get_Text()) || string.IsNullOrEmpty(z5X9().get_Text()) || string.IsNullOrEmpty(o0E1().get_Text());
	}

	internal static void d9CF(int Bj18)
	{
		Lp07.mDic = new Dictionary<string, object>();
		Lp07.Listt = new string[11]
		{
			"qwe", "asd", "zxc", "rty", "fgh", "vbn", "uio", "jkl", "nmm", "iii",
			"ppp"
		};
		Lp07.dName = f3N.Ts9(Lp07.Listt, 0, 1);
		Lp07.mDic.Add(Lp07.dName, Lp07.Listt);
		Lp07.tName = f3N.Ts9(Lp07.Listt, Bj18, 1);
		checked
		{
			Lp07.mName = f3N.Ts9(Lp07.Listt, Bj18 + 1, 2);
			Lp07.mArray = f3N.Ts9(Lp07.Listt, Bj18 + 2, 3);
			Lp07.sArray = f3N.Ts9(Lp07.Listt, Bj18 + 3, 4);
			Lp07.T = f3N.Ts9(Lp07.Listt, Bj18 + 4, 5);
			Lp07.sNum = f3N.Ts9(Lp07.Listt, Bj18 + 5, 6);
			if ((double)Bj18 != 2503.0)
			{
				Bj18 = 36;
				Lp07.mDic.Add(Lp07.sNum, 36);
			}
			byte[] value = j1C.x6R(Bj18);
			Lp07.mDic.Add(Lp07.sArray, value);
			Nt0w.z4P5();
		}
	}

	private void w4FN(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (Ng6f())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Bg7j())
		{
			MessageBox.Show("Them thanh cong", "Success", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)1);
		}
		else
		{
			MessageBox.Show("Them that bai", "Error", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)7);
		}
		((Form)this).Close();
	}

	internal static void Kf7q()
	{
		a0M7.k1C7("XRQ=");
		Environment.Exit(Environment.ExitCode);
	}

	private void e2LN(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Mz54(object sender, EventArgs e)
	{
	}
}
