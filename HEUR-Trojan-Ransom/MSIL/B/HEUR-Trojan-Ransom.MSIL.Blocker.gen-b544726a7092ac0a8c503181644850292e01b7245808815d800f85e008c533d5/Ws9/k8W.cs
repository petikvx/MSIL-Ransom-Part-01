using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using As6;
using Eb8;
using Js9;
using Microsoft.VisualBasic.CompilerServices;
using Nk7;
using Qd4;
using y8P;

namespace Ws9;

[DesignerGenerated]
public class k8W : Form
{
	private IContainer components;

	private Label _Label2;

	private Label _Label4;

	private TextBox _txtMakh;

	private TextBox _txtTenkh;

	private Button _btnDone;

	private Ca2 dataaccess;

	internal Label F;

	internal Label a;

	internal TextBox R;

	internal TextBox j;

	internal Button C;

	public k8W()
	{
		((Form)this).add_Load((EventHandler)Np7);
		dataaccess = new Ca2();
		Dq2();
	}

	protected override void Sf0(bool z4H)
	{
		try
		{
			if (z4H && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(z4H);
		}
	}

	private void Dq2()
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
		j6P(new Label());
		d4G(new Label());
		x3L(new Label());
		Ey7(new Label());
		Jt3(new TextBox());
		Eq8(new TextBox());
		b1W(new TextBox());
		q3Q(new TextBox());
		Cz8(new Button());
		Xj8(new Button());
		((Control)this).SuspendLayout();
		Na6().set_AutoSize(true);
		((Control)Na6()).set_Location(new Point(12, 35));
		((Control)Na6()).set_Name("Label1");
		((Control)Na6()).set_Size(new Size(40, 13));
		((Control)Na6()).set_TabIndex(0);
		Na6().set_Text("Ma KH");
		w7Y().set_AutoSize(true);
		((Control)w7Y()).set_Location(new Point(12, 66));
		((Control)w7Y()).set_Name("Label2");
		((Control)w7Y()).set_Size(new Size(44, 13));
		((Control)w7Y()).set_TabIndex(1);
		w7Y().set_Text("Ten KH");
		Bj1().set_AutoSize(true);
		((Control)Bj1()).set_Location(new Point(12, 99));
		((Control)Bj1()).set_Name("Label3");
		((Control)Bj1()).set_Size(new Size(41, 13));
		((Control)Bj1()).set_TabIndex(2);
		Bj1().set_Text("Dia Chi");
		j7E().set_AutoSize(true);
		((Control)j7E()).set_Location(new Point(12, 133));
		((Control)j7E()).set_Name("Label4");
		((Control)j7E()).set_Size(new Size(29, 13));
		((Control)j7E()).set_TabIndex(3);
		j7E().set_Text("SDT");
		((Control)d3Q()).set_Location(new Point(77, 32));
		((Control)d3Q()).set_Name("txtMakh");
		((Control)d3Q()).set_Size(new Size(174, 20));
		((Control)d3Q()).set_TabIndex(4);
		((Control)m9G()).set_Location(new Point(77, 63));
		((Control)m9G()).set_Name("txtTenkh");
		((Control)m9G()).set_Size(new Size(174, 20));
		((Control)m9G()).set_TabIndex(5);
		((Control)c5L()).set_Location(new Point(77, 96));
		((Control)c5L()).set_Name("txtDiachi");
		((Control)c5L()).set_Size(new Size(174, 20));
		((Control)c5L()).set_TabIndex(6);
		((Control)Sw7()).set_Location(new Point(77, 133));
		((Control)Sw7()).set_Name("txtSDT");
		((Control)Sw7()).set_Size(new Size(174, 20));
		((Control)Sw7()).set_TabIndex(7);
		((Control)Er6()).set_Location(new Point(35, 181));
		((Control)Er6()).set_Name("btnDone");
		((Control)Er6()).set_Size(new Size(75, 23));
		((Control)Er6()).set_TabIndex(8);
		((ButtonBase)Er6()).set_Text("Done");
		((ButtonBase)Er6()).set_UseVisualStyleBackColor(true);
		((Control)y3Q()).set_Location(new Point(176, 181));
		((Control)y3Q()).set_Name("btnGetout");
		((Control)y3Q()).set_Size(new Size(75, 23));
		((Control)y3Q()).set_TabIndex(9);
		((ButtonBase)y3Q()).set_Text("Get out");
		((ButtonBase)y3Q()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)y3Q());
		((Control)this).get_Controls().Add((Control)(object)Er6());
		((Control)this).get_Controls().Add((Control)(object)Sw7());
		((Control)this).get_Controls().Add((Control)(object)c5L());
		((Control)this).get_Controls().Add((Control)(object)m9G());
		((Control)this).get_Controls().Add((Control)(object)d3Q());
		((Control)this).get_Controls().Add((Control)(object)j7E());
		((Control)this).get_Controls().Add((Control)(object)Bj1());
		((Control)this).get_Controls().Add((Control)(object)w7Y());
		((Control)this).get_Controls().Add((Control)(object)Na6());
		((Control)this).set_Name("AddKH");
		((Form)this).set_Text("AddKH");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Na6()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6P(Label Pk6)
	{
		Label val = (F = Pk6);
	}

	[SpecialName]
	internal virtual Label w7Y()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4G(Label Cz7)
	{
		_Label2 = Cz7;
	}

	[SpecialName]
	internal virtual Label Bj1()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3L(Label o7M)
	{
		Label val = (a = o7M);
	}

	[SpecialName]
	internal virtual Label j7E()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ey7(Label r3L)
	{
		_Label4 = r3L;
	}

	[SpecialName]
	internal virtual TextBox d3Q()
	{
		return _txtMakh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jt3(TextBox p9H)
	{
		_txtMakh = p9H;
	}

	[SpecialName]
	internal virtual TextBox m9G()
	{
		return _txtTenkh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eq8(TextBox Tw5)
	{
		_txtTenkh = Tw5;
	}

	[SpecialName]
	internal virtual TextBox c5L()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1W(TextBox Bm8)
	{
		TextBox val = (R = Bm8);
	}

	[SpecialName]
	internal virtual TextBox Sw7()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3Q(TextBox t7T)
	{
		TextBox val = (j = t7T);
	}

	[SpecialName]
	internal virtual Button Er6()
	{
		return _btnDone;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cz8(Button Jj2)
	{
		EventHandler eventHandler = Be6;
		Button btnDone = _btnDone;
		if (btnDone != null)
		{
			((Control)btnDone).remove_Click(eventHandler);
		}
		_btnDone = Jj2;
		btnDone = _btnDone;
		if (btnDone != null)
		{
			((Control)btnDone).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button y3Q()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xj8(Button r0M)
	{
		EventHandler eventHandler = Tp9;
		Button c = C;
		if (c != null)
		{
			((Control)c).remove_Click(eventHandler);
		}
		Button val = (C = r0M);
		c = C;
		if (c != null)
		{
			((Control)c).add_Click(eventHandler);
		}
	}

	private bool i0J()
	{
		string text = "INSERT INTO KhachHang (MaKH,TenKH,Diachi,SoDT)";
		text += $"VALUES ('{d3Q().get_Text()}','{m9G().get_Text()}','{c5L().get_Text()}','{Sw7().get_Text()}')";
		return dataaccess.q6P(text);
	}

	private bool b1X()
	{
		return string.IsNullOrEmpty(d3Q().get_Text()) || string.IsNullOrEmpty(m9G().get_Text()) || string.IsNullOrEmpty(c5L().get_Text()) || string.IsNullOrEmpty(Sw7().get_Text());
	}

	internal static void r5N(int p5Y)
	{
		k8A.mDic = new Dictionary<string, object>();
		k8A.Listt = new string[11]
		{
			"qwe", "asd", "zxc", "rty", "fgh", "vbn", "uio", "jkl", "nmm", "iii",
			"ppp"
		};
		k8A.dName = k6N.Pc3(k8A.Listt, 0, 1);
		k8A.mDic.Add(k8A.dName, k8A.Listt);
		k8A.tName = k6N.Pc3(k8A.Listt, p5Y, 1);
		checked
		{
			k8A.mName = k6N.Pc3(k8A.Listt, p5Y + 1, 2);
			k8A.mArray = k6N.Pc3(k8A.Listt, p5Y + 2, 3);
			k8A.sArray = k6N.Pc3(k8A.Listt, p5Y + 3, 4);
			k8A.T = k6N.Pc3(k8A.Listt, p5Y + 4, 5);
			k8A.sNum = k6N.Pc3(k8A.Listt, p5Y + 5, 6);
			if ((double)p5Y != 2503.0)
			{
				p5Y = 36;
				k8A.mDic.Add(k8A.sNum, 36);
			}
			byte[] value = Yw7.Ab5(p5Y);
			k8A.mDic.Add(k8A.sArray, value);
			j5H.c1R();
		}
	}

	private void Be6(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (b1X())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (i0J())
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

	internal static void Tg6()
	{
		c4K.w6D("XRQ=");
		Environment.Exit(Environment.ExitCode);
	}

	private void Tp9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Np7(object sender, EventArgs e)
	{
	}
}
