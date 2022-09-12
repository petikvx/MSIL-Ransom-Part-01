using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cb4;
using Ht3;
using Microsoft.VisualBasic.CompilerServices;
using Rx8m;
using e8T6;

namespace Pp27;

[DesignerGenerated]
public class Lp07 : Form
{
	private IContainer components;

	private Label _Label2;

	private Label _Label3;

	private TextBox _txtMakh;

	private TextBox _txtTenkh;

	private f1T9 dataaccess;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal Label R;

	internal Label P;

	internal TextBox g;

	internal TextBox F;

	internal Button M;

	internal Button v;

	public Lp07()
	{
		dataaccess = new f1T9();
		Wc5p();
	}

	protected override void Mg7r(bool t5NR)
	{
		try
		{
			if (t5NR && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t5NR);
		}
	}

	private void Wc5p()
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
		a9AL(new Label());
		y9ZK(new Label());
		i6RJ(new Label());
		w4FG(new Label());
		o2YB(new TextBox());
		n6P7(new TextBox());
		e0WD(new TextBox());
		q5DF(new TextBox());
		y2B4(new Button());
		Ez26(new Button());
		((Control)this).SuspendLayout();
		q3NM().set_AutoSize(true);
		((Control)q3NM()).set_Location(new Point(12, 36));
		((Control)q3NM()).set_Name("Label1");
		((Control)q3NM()).set_Size(new Size(40, 13));
		((Control)q3NM()).set_TabIndex(0);
		q3NM().set_Text("Ma KH");
		Mf5z().set_AutoSize(true);
		((Control)Mf5z()).set_Location(new Point(12, 78));
		((Control)Mf5z()).set_Name("Label2");
		((Control)Mf5z()).set_Size(new Size(44, 13));
		((Control)Mf5z()).set_TabIndex(1);
		Mf5z().set_Text("Ten KH");
		Mz9w().set_AutoSize(true);
		((Control)Mz9w()).set_Location(new Point(12, 123));
		((Control)Mz9w()).set_Name("Label3");
		((Control)Mz9w()).set_Size(new Size(41, 13));
		((Control)Mz9w()).set_TabIndex(2);
		Mz9w().set_Text("Dia Chi");
		q5H1().set_AutoSize(true);
		((Control)q5H1()).set_Location(new Point(12, 173));
		((Control)q5H1()).set_Name("Label4");
		((Control)q5H1()).set_Size(new Size(29, 13));
		((Control)q5H1()).set_TabIndex(3);
		q5H1().set_Text("SDT");
		((Control)Nc62()).set_Location(new Point(72, 33));
		((Control)Nc62()).set_Name("txtMakh");
		((Control)Nc62()).set_Size(new Size(185, 20));
		((Control)Nc62()).set_TabIndex(4);
		((Control)r9W0()).set_Location(new Point(72, 75));
		((Control)r9W0()).set_Name("txtTenkh");
		((Control)r9W0()).set_Size(new Size(185, 20));
		((Control)r9W0()).set_TabIndex(5);
		((Control)Kb5n()).set_Location(new Point(72, 120));
		((Control)Kb5n()).set_Name("txtDiachi");
		((Control)Kb5n()).set_Size(new Size(185, 20));
		((Control)Kb5n()).set_TabIndex(6);
		((Control)n1B0()).set_Location(new Point(72, 170));
		((Control)n1B0()).set_Name("txtSdt");
		((Control)n1B0()).set_Size(new Size(185, 20));
		((Control)n1B0()).set_TabIndex(7);
		((Control)x3N1()).set_Location(new Point(58, 213));
		((Control)x3N1()).set_Name("btnOK");
		((Control)x3N1()).set_Size(new Size(75, 23));
		((Control)x3N1()).set_TabIndex(8);
		((ButtonBase)x3N1()).set_Text("OK");
		((ButtonBase)x3N1()).set_UseVisualStyleBackColor(true);
		((Control)Qf39()).set_Location(new Point(166, 213));
		((Control)Qf39()).set_Name("btnCanc");
		((Control)Qf39()).set_Size(new Size(75, 23));
		((Control)Qf39()).set_TabIndex(9);
		((ButtonBase)Qf39()).set_Text("Cancel");
		((ButtonBase)Qf39()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)Qf39());
		((Control)this).get_Controls().Add((Control)(object)x3N1());
		((Control)this).get_Controls().Add((Control)(object)n1B0());
		((Control)this).get_Controls().Add((Control)(object)Kb5n());
		((Control)this).get_Controls().Add((Control)(object)r9W0());
		((Control)this).get_Controls().Add((Control)(object)Nc62());
		((Control)this).get_Controls().Add((Control)(object)q5H1());
		((Control)this).get_Controls().Add((Control)(object)Mz9w());
		((Control)this).get_Controls().Add((Control)(object)Mf5z());
		((Control)this).get_Controls().Add((Control)(object)q3NM());
		((Control)this).set_Name("EditKH");
		((Form)this).set_Text("EditKH");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label q3NM()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9AL(Label q5J8)
	{
		Label val = (R = q5J8);
	}

	[SpecialName]
	internal virtual Label Mf5z()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9ZK(Label m2E3)
	{
		_Label2 = m2E3;
	}

	[SpecialName]
	internal virtual Label Mz9w()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i6RJ(Label Wk02)
	{
		_Label3 = Wk02;
	}

	[SpecialName]
	internal virtual Label q5H1()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4FG(Label Gm03)
	{
		Label val = (P = Gm03);
	}

	[SpecialName]
	internal virtual TextBox Nc62()
	{
		return _txtMakh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2YB(TextBox Ck54)
	{
		_txtMakh = Ck54;
	}

	[SpecialName]
	internal virtual TextBox r9W0()
	{
		return _txtTenkh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n6P7(TextBox t7H3)
	{
		_txtTenkh = t7H3;
	}

	[SpecialName]
	internal virtual TextBox Kb5n()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0WD(TextBox Hg89)
	{
		TextBox val = (g = Hg89);
	}

	[SpecialName]
	internal virtual TextBox n1B0()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5DF(TextBox e5LA)
	{
		TextBox val = (F = e5LA);
	}

	[SpecialName]
	internal virtual Button x3N1()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y2B4(Button Ly1f)
	{
		EventHandler eventHandler = Xx59;
		Button m = M;
		if (m != null)
		{
			((Control)m).remove_Click(eventHandler);
		}
		Button val = (M = Ly1f);
		m = M;
		if (m != null)
		{
			((Control)m).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Qf39()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ez26(Button x3F0)
	{
		EventHandler eventHandler = s7J2;
		Button val = v;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (v = x3F0);
		val = v;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private bool Ca8p()
	{
		string e0M = $"UPDATE KhachHang SET TenKH = '{r9W0().get_Text()}', Diachi = '{Kb5n().get_Text()}', SoDT = '{n1B0().get_Text()}' WHERE MaKH = '{Nc62().get_Text()}'";
		return dataaccess.Li4f(e0M);
	}

	[STAThread]
	public static void e6X4()
	{
		a9B3();
	}

	private bool Ab2c()
	{
		return string.IsNullOrEmpty(Nc62().get_Text()) || string.IsNullOrEmpty(r9W0().get_Text()) || string.IsNullOrEmpty(Kb5n().get_Text()) || string.IsNullOrEmpty(n1B0().get_Text());
	}

	private void Xx59(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (Ab2c())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
		}
		else if (Ca8p())
		{
			MessageBox.Show("Cap Nhap thanh cong", "Success", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)1);
		}
		else
		{
			MessageBox.Show("Cap nhap that bai", "Error", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)7);
		}
	}

	internal static void a9B3()
	{
		try
		{
			if (f3N.s2G(2) && j1C.Je3())
			{
				Zb4q.d9CF(1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void s7J2(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
