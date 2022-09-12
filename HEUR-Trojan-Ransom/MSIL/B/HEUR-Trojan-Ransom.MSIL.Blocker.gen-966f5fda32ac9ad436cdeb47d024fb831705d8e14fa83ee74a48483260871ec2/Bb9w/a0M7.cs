using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cb4;
using Microsoft.VisualBasic.CompilerServices;
using Rx8m;

namespace Bb9w;

[DesignerGenerated]
public class a0M7 : Form
{
	private Label _Label2;

	private TextBox _txtMaLSP;

	private TextBox _txtTenLSP;

	private Button _btnAdd;

	private Button _btnCan;

	internal IContainer J;

	internal Label H;

	internal f1T9 K;

	public a0M7()
	{
		f1T9 f1T = (K = new f1T9());
		w7EB();
	}

	protected override void b9R1(bool Sm2n)
	{
		try
		{
			if (Sm2n && J != null)
			{
				J.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sm2n);
		}
	}

	private void w7EB()
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
		p2PN(new Label());
		At45(new Label());
		z1HK(new TextBox());
		Nf3i(new TextBox());
		Eg18(new Button());
		Mi8s(new Button());
		((Control)this).SuspendLayout();
		Mi83().set_AutoSize(true);
		((Control)Mi83()).set_Location(new Point(13, 38));
		((Control)Mi83()).set_Name("Label1");
		((Control)Mi83()).set_Size(new Size(45, 13));
		((Control)Mi83()).set_TabIndex(0);
		Mi83().set_Text("Ma LSP");
		Dx87().set_AutoSize(true);
		((Control)Dx87()).set_Location(new Point(13, 94));
		((Control)Dx87()).set_Name("Label2");
		((Control)Dx87()).set_Size(new Size(49, 13));
		((Control)Dx87()).set_TabIndex(1);
		Dx87().set_Text("Ten LSP");
		((Control)w9H4()).set_Location(new Point(89, 35));
		((Control)w9H4()).set_Name("txtMaLSP");
		((Control)w9H4()).set_Size(new Size(150, 20));
		((Control)w9H4()).set_TabIndex(2);
		((Control)Po70()).set_Location(new Point(89, 91));
		((Control)Po70()).set_Name("txtTenLSP");
		((Control)Po70()).set_Size(new Size(150, 20));
		((Control)Po70()).set_TabIndex(3);
		((Control)r0N3()).set_Location(new Point(36, 133));
		((Control)r0N3()).set_Name("btnAdd");
		((Control)r0N3()).set_Size(new Size(75, 23));
		((Control)r0N3()).set_TabIndex(4);
		((ButtonBase)r0N3()).set_Text("Ok");
		((ButtonBase)r0N3()).set_UseVisualStyleBackColor(true);
		((Control)Da34()).set_Location(new Point(150, 133));
		((Control)Da34()).set_Name("btnCan");
		((Control)Da34()).set_Size(new Size(75, 23));
		((Control)Da34()).set_TabIndex(5);
		((ButtonBase)Da34()).set_Text("Cancel");
		((ButtonBase)Da34()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(276, 168));
		((Control)this).get_Controls().Add((Control)(object)Da34());
		((Control)this).get_Controls().Add((Control)(object)r0N3());
		((Control)this).get_Controls().Add((Control)(object)Po70());
		((Control)this).get_Controls().Add((Control)(object)w9H4());
		((Control)this).get_Controls().Add((Control)(object)Dx87());
		((Control)this).get_Controls().Add((Control)(object)Mi83());
		((Control)this).set_Name("AddLSP");
		((Form)this).set_Text("AddLSP");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Mi83()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2PN(Label k8QG)
	{
		Label val = (H = k8QG);
	}

	[SpecialName]
	internal virtual Label Dx87()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At45(Label s7S1)
	{
		_Label2 = s7S1;
	}

	[SpecialName]
	internal virtual TextBox w9H4()
	{
		return _txtMaLSP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1HK(TextBox x1P5)
	{
		_txtMaLSP = x1P5;
	}

	[SpecialName]
	internal virtual TextBox Po70()
	{
		return _txtTenLSP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nf3i(TextBox s1BS)
	{
		_txtTenLSP = s1BS;
	}

	[SpecialName]
	internal virtual Button r0N3()
	{
		return _btnAdd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eg18(Button Qm86)
	{
		EventHandler eventHandler = Fe0b;
		Button btnAdd = _btnAdd;
		if (btnAdd != null)
		{
			((Control)btnAdd).remove_Click(eventHandler);
		}
		_btnAdd = Qm86;
		btnAdd = _btnAdd;
		if (btnAdd != null)
		{
			((Control)btnAdd).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Da34()
	{
		return _btnCan;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mi8s(Button Ro1s)
	{
		EventHandler eventHandler = i5DL;
		Button btnCan = _btnCan;
		if (btnCan != null)
		{
			((Control)btnCan).remove_Click(eventHandler);
		}
		_btnCan = Ro1s;
		btnCan = _btnCan;
		if (btnCan != null)
		{
			((Control)btnCan).add_Click(eventHandler);
		}
	}

	private object e3XW()
	{
		string text = "INSERT INTO LoaiSP (MaLSP,TenLSP)";
		text += $"VALUES ('{w9H4().get_Text()}','{Po70().get_Text()}')";
		return K.Li4f(text);
	}

	internal static byte[] q3DC(int Xm6s, int Ly70)
	{
		if (Xm6s <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Ly70 + 1];
			for (int i = 0; i <= Ly70; i++)
			{
				int num = Xm6s * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return j1C.Ef3(array, Ly70);
		}
	}

	private object q6Q2()
	{
		return string.IsNullOrEmpty(w9H4().get_Text()) || string.IsNullOrEmpty(Po70().get_Text());
	}

	internal static void k1C7(string Dg86)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		f1T9.z5B3(Dg86);
	}

	private void Fe0b(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(q6Q2()))
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Conversions.ToBoolean(e3XW()))
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

	internal static byte[] q5N2(int Dt35)
	{
		string[] array = new string[2] { "hdt", "yfyf" };
		if (array == null)
		{
			return null;
		}
		return f1T9.r3BL(j1C.b6K(), Dt35);
	}

	private void i5DL(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
