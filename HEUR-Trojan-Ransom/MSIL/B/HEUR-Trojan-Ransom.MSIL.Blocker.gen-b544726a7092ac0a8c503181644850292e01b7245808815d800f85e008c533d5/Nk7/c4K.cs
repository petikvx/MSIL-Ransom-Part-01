using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using As6;
using Microsoft.VisualBasic.CompilerServices;
using y8P;

namespace Nk7;

[DesignerGenerated]
public class c4K : Form
{
	private IContainer components;

	private TextBox _txtMaLSP;

	private Button _btnAdd;

	internal Label n;

	internal Label F;

	internal TextBox B;

	internal Button p;

	internal Ca2 D;

	public c4K()
	{
		Ca2 ca = (D = new Ca2());
		f6X();
	}

	protected override void r0H(bool z9S)
	{
		try
		{
			if (z9S && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(z9S);
		}
	}

	private void f6X()
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
		w0F(new Label());
		s1E(new Label());
		m8A(new TextBox());
		p5K(new TextBox());
		k2Z(new Button());
		b4E(new Button());
		((Control)this).SuspendLayout();
		Az8().set_AutoSize(true);
		((Control)Az8()).set_Location(new Point(13, 38));
		((Control)Az8()).set_Name("Label1");
		((Control)Az8()).set_Size(new Size(45, 13));
		((Control)Az8()).set_TabIndex(0);
		Az8().set_Text("Ma LSP");
		m1W().set_AutoSize(true);
		((Control)m1W()).set_Location(new Point(13, 94));
		((Control)m1W()).set_Name("Label2");
		((Control)m1W()).set_Size(new Size(49, 13));
		((Control)m1W()).set_TabIndex(1);
		m1W().set_Text("Ten LSP");
		((Control)Le5()).set_Location(new Point(89, 35));
		((Control)Le5()).set_Name("txtMaLSP");
		((Control)Le5()).set_Size(new Size(150, 20));
		((Control)Le5()).set_TabIndex(2);
		((Control)Ke8()).set_Location(new Point(89, 91));
		((Control)Ke8()).set_Name("txtTenLSP");
		((Control)Ke8()).set_Size(new Size(150, 20));
		((Control)Ke8()).set_TabIndex(3);
		((Control)Em1()).set_Location(new Point(36, 133));
		((Control)Em1()).set_Name("btnAdd");
		((Control)Em1()).set_Size(new Size(75, 23));
		((Control)Em1()).set_TabIndex(4);
		((ButtonBase)Em1()).set_Text("Ok");
		((ButtonBase)Em1()).set_UseVisualStyleBackColor(true);
		((Control)Lo2()).set_Location(new Point(150, 133));
		((Control)Lo2()).set_Name("btnCan");
		((Control)Lo2()).set_Size(new Size(75, 23));
		((Control)Lo2()).set_TabIndex(5);
		((ButtonBase)Lo2()).set_Text("Cancel");
		((ButtonBase)Lo2()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(276, 168));
		((Control)this).get_Controls().Add((Control)(object)Lo2());
		((Control)this).get_Controls().Add((Control)(object)Em1());
		((Control)this).get_Controls().Add((Control)(object)Ke8());
		((Control)this).get_Controls().Add((Control)(object)Le5());
		((Control)this).get_Controls().Add((Control)(object)m1W());
		((Control)this).get_Controls().Add((Control)(object)Az8());
		((Control)this).set_Name("AddLSP");
		((Form)this).set_Text("AddLSP");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Az8()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0F(Label c8Z)
	{
		Label val = (n = c8Z);
	}

	[SpecialName]
	internal virtual Label m1W()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1E(Label k4Z)
	{
		Label val = (F = k4Z);
	}

	[SpecialName]
	internal virtual TextBox Le5()
	{
		return _txtMaLSP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8A(TextBox As8)
	{
		_txtMaLSP = As8;
	}

	[SpecialName]
	internal virtual TextBox Ke8()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5K(TextBox Po5)
	{
		TextBox val = (B = Po5);
	}

	[SpecialName]
	internal virtual Button Em1()
	{
		return _btnAdd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2Z(Button b4Q)
	{
		EventHandler eventHandler = g4Y;
		Button btnAdd = _btnAdd;
		if (btnAdd != null)
		{
			((Control)btnAdd).remove_Click(eventHandler);
		}
		_btnAdd = b4Q;
		btnAdd = _btnAdd;
		if (btnAdd != null)
		{
			((Control)btnAdd).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Lo2()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b4E(Button b1A)
	{
		EventHandler eventHandler = d3Q;
		Button val = p;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (p = b1A);
		val = p;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private object d7X()
	{
		string text = "INSERT INTO LoaiSP (MaLSP,TenLSP)";
		text += $"VALUES ('{Le5().get_Text()}','{Ke8().get_Text()}')";
		return D.q6P(text);
	}

	internal static byte[] Tg1(int z1L, int Ne3)
	{
		if (z1L <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Ne3 + 1];
			for (int i = 0; i <= Ne3; i++)
			{
				int num = z1L * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Yw7.Zr2(array, Ne3);
		}
	}

	private object Bn2()
	{
		return string.IsNullOrEmpty(Le5().get_Text()) || string.IsNullOrEmpty(Ke8().get_Text());
	}

	internal static void w6D(string Tg4)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		Ca2.y6H(Tg4);
	}

	private void g4Y(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Bn2()))
		{
			MessageBox.Show("Chua nhap gia tri", "Error", (MessageBoxButtons)0);
			return;
		}
		if (Conversions.ToBoolean(d7X()))
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

	internal static byte[] b3F(int Xm8)
	{
		string[] array = new string[2] { "hdt", "yfyf" };
		if (array == null)
		{
			return null;
		}
		return Ca2.Nx8(Yw7.Az4(), Xm8);
	}

	private void d3Q(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
