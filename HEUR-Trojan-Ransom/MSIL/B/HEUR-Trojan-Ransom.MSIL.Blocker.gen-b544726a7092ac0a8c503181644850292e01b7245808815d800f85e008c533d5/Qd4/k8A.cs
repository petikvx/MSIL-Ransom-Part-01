using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using As6;
using Eb8;
using Microsoft.VisualBasic.CompilerServices;
using Ws9;
using y8P;

namespace Qd4;

[DesignerGenerated]
public class k8A : Form
{
	private Label _Label1;

	private Label _Label2;

	private Label _Label3;

	private TextBox _txtMakh;

	private Button _btnOK;

	private Button _btnCanc;

	private Ca2 dataaccess;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal IContainer f;

	internal Label X;

	internal TextBox d;

	internal TextBox R;

	internal TextBox N;

	public k8A()
	{
		dataaccess = new Ca2();
		g2W();
	}

	protected override void c7K(bool So9)
	{
		try
		{
			if (So9 && f != null)
			{
				f.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(So9);
		}
	}

	private void g2W()
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
		x8F(new Label());
		d9A(new Label());
		Sx1(new Label());
		Fm6(new Label());
		o9P(new TextBox());
		Rn0(new TextBox());
		Bm1(new TextBox());
		o5K(new TextBox());
		Ld8(new Button());
		Qo7(new Button());
		((Control)this).SuspendLayout();
		Wa5().set_AutoSize(true);
		((Control)Wa5()).set_Location(new Point(12, 36));
		((Control)Wa5()).set_Name("Label1");
		((Control)Wa5()).set_Size(new Size(40, 13));
		((Control)Wa5()).set_TabIndex(0);
		Wa5().set_Text("Ma KH");
		Dc9().set_AutoSize(true);
		((Control)Dc9()).set_Location(new Point(12, 78));
		((Control)Dc9()).set_Name("Label2");
		((Control)Dc9()).set_Size(new Size(44, 13));
		((Control)Dc9()).set_TabIndex(1);
		Dc9().set_Text("Ten KH");
		Ys9().set_AutoSize(true);
		((Control)Ys9()).set_Location(new Point(12, 123));
		((Control)Ys9()).set_Name("Label3");
		((Control)Ys9()).set_Size(new Size(41, 13));
		((Control)Ys9()).set_TabIndex(2);
		Ys9().set_Text("Dia Chi");
		Ns3().set_AutoSize(true);
		((Control)Ns3()).set_Location(new Point(12, 173));
		((Control)Ns3()).set_Name("Label4");
		((Control)Ns3()).set_Size(new Size(29, 13));
		((Control)Ns3()).set_TabIndex(3);
		Ns3().set_Text("SDT");
		((Control)m6N()).set_Location(new Point(72, 33));
		((Control)m6N()).set_Name("txtMakh");
		((Control)m6N()).set_Size(new Size(185, 20));
		((Control)m6N()).set_TabIndex(4);
		((Control)Cc3()).set_Location(new Point(72, 75));
		((Control)Cc3()).set_Name("txtTenkh");
		((Control)Cc3()).set_Size(new Size(185, 20));
		((Control)Cc3()).set_TabIndex(5);
		((Control)w9P()).set_Location(new Point(72, 120));
		((Control)w9P()).set_Name("txtDiachi");
		((Control)w9P()).set_Size(new Size(185, 20));
		((Control)w9P()).set_TabIndex(6);
		((Control)Dc3()).set_Location(new Point(72, 170));
		((Control)Dc3()).set_Name("txtSdt");
		((Control)Dc3()).set_Size(new Size(185, 20));
		((Control)Dc3()).set_TabIndex(7);
		((Control)Br2()).set_Location(new Point(58, 213));
		((Control)Br2()).set_Name("btnOK");
		((Control)Br2()).set_Size(new Size(75, 23));
		((Control)Br2()).set_TabIndex(8);
		((ButtonBase)Br2()).set_Text("OK");
		((ButtonBase)Br2()).set_UseVisualStyleBackColor(true);
		((Control)x9F()).set_Location(new Point(166, 213));
		((Control)x9F()).set_Name("btnCanc");
		((Control)x9F()).set_Size(new Size(75, 23));
		((Control)x9F()).set_TabIndex(9);
		((ButtonBase)x9F()).set_Text("Cancel");
		((ButtonBase)x9F()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)x9F());
		((Control)this).get_Controls().Add((Control)(object)Br2());
		((Control)this).get_Controls().Add((Control)(object)Dc3());
		((Control)this).get_Controls().Add((Control)(object)w9P());
		((Control)this).get_Controls().Add((Control)(object)Cc3());
		((Control)this).get_Controls().Add((Control)(object)m6N());
		((Control)this).get_Controls().Add((Control)(object)Ns3());
		((Control)this).get_Controls().Add((Control)(object)Ys9());
		((Control)this).get_Controls().Add((Control)(object)Dc9());
		((Control)this).get_Controls().Add((Control)(object)Wa5());
		((Control)this).set_Name("EditKH");
		((Form)this).set_Text("EditKH");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Wa5()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8F(Label m0A)
	{
		_Label1 = m0A;
	}

	[SpecialName]
	internal virtual Label Dc9()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9A(Label Hf8)
	{
		_Label2 = Hf8;
	}

	[SpecialName]
	internal virtual Label Ys9()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sx1(Label Jp2)
	{
		_Label3 = Jp2;
	}

	[SpecialName]
	internal virtual Label Ns3()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fm6(Label o7R)
	{
		Label val = (X = o7R);
	}

	[SpecialName]
	internal virtual TextBox m6N()
	{
		return _txtMakh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o9P(TextBox Bz2)
	{
		_txtMakh = Bz2;
	}

	[SpecialName]
	internal virtual TextBox Cc3()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn0(TextBox c9F)
	{
		TextBox val = (d = c9F);
	}

	[SpecialName]
	internal virtual TextBox w9P()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bm1(TextBox i7H)
	{
		TextBox val = (R = i7H);
	}

	[SpecialName]
	internal virtual TextBox Dc3()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5K(TextBox Di5)
	{
		TextBox val = (N = Di5);
	}

	[SpecialName]
	internal virtual Button Br2()
	{
		return _btnOK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ld8(Button Lg9)
	{
		EventHandler eventHandler = r1F;
		Button btnOK = _btnOK;
		if (btnOK != null)
		{
			((Control)btnOK).remove_Click(eventHandler);
		}
		_btnOK = Lg9;
		btnOK = _btnOK;
		if (btnOK != null)
		{
			((Control)btnOK).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button x9F()
	{
		return _btnCanc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qo7(Button t2T)
	{
		EventHandler eventHandler = Dc9;
		Button btnCanc = _btnCanc;
		if (btnCanc != null)
		{
			((Control)btnCanc).remove_Click(eventHandler);
		}
		_btnCanc = t2T;
		btnCanc = _btnCanc;
		if (btnCanc != null)
		{
			((Control)btnCanc).add_Click(eventHandler);
		}
	}

	private bool e2K()
	{
		string ha = $"UPDATE KhachHang SET TenKH = '{Cc3().get_Text()}', Diachi = '{w9P().get_Text()}', SoDT = '{Dc3().get_Text()}' WHERE MaKH = '{m6N().get_Text()}'";
		return dataaccess.q6P(ha);
	}

	[STAThread]
	public static void Sb2()
	{
		i4R();
	}

	private bool Lz5()
	{
		return string.IsNullOrEmpty(m6N().get_Text()) || string.IsNullOrEmpty(Cc3().get_Text()) || string.IsNullOrEmpty(w9P().get_Text()) || string.IsNullOrEmpty(Dc3().get_Text());
	}

	private void r1F(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (Lz5())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
		}
		else if (e2K())
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

	internal static void i4R()
	{
		try
		{
			if (k6N.My9(2) && Yw7.g3H())
			{
				k8W.r5N(1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Dc9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
