using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ey8t;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yj2;
using a7J;
using k0P9;
using s8C;

namespace n6EF;

[DesignerGenerated]
public class k7N3 : Form
{
	private IContainer components;

	private Button _Button1;

	private Button _Button5;

	private Button _Button6;

	internal Label J;

	internal Label S;

	internal TextBox h;

	internal DataGridView P;

	internal Label E;

	internal ComboBox Q;

	internal ComboBox a;

	public k7N3()
	{
		((Form)this).add_Load((EventHandler)Mn6i);
		Ym12();
	}

	protected override void Le86(bool Qs0c)
	{
		if (Qs0c && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Qs0c);
	}

	private void Ym12()
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
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		o4NR(new Button());
		Fo3b(new Button());
		g6K3(new Button());
		x2JP(new Label());
		Qg1q(new Label());
		Zs6f(new TextBox());
		b2MR(new DataGridView());
		f2A0(new Label());
		e3NA(new ComboBox());
		b8JT(new ComboBox());
		((ISupportInitialize)Gr3o()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)He26()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)He26()).set_Location(new Point(334, 168));
		((Control)He26()).set_Name("Button1");
		((Control)He26()).set_Size(new Size(127, 33));
		((Control)He26()).set_TabIndex(68);
		((ButtonBase)He26()).set_Text("Thoát");
		((ButtonBase)He26()).set_UseVisualStyleBackColor(true);
		((Control)w4J9()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)w4J9()).set_Location(new Point(172, 168));
		((Control)w4J9()).set_Name("Button5");
		((Control)w4J9()).set_Size(new Size(127, 33));
		((Control)w4J9()).set_TabIndex(67);
		((ButtonBase)w4J9()).set_Text("Xóa");
		((ButtonBase)w4J9()).set_UseVisualStyleBackColor(true);
		((Control)i5CQ()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)i5CQ()).set_Location(new Point(13, 168));
		((Control)i5CQ()).set_Name("Button6");
		((Control)i5CQ()).set_Size(new Size(127, 33));
		((Control)i5CQ()).set_TabIndex(66);
		((ButtonBase)i5CQ()).set_Text("Cập nhật");
		((ButtonBase)i5CQ()).set_UseVisualStyleBackColor(true);
		Hr9j().set_AutoSize(true);
		((Control)Hr9j()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Hr9j()).set_Location(new Point(22, 61));
		((Control)Hr9j()).set_Name("Label2");
		((Control)Hr9j()).set_Size(new Size(82, 20));
		((Control)Hr9j()).set_TabIndex(65);
		Hr9j().set_Text("Mã phòng");
		Fd70().set_AutoSize(true);
		((Control)Fd70()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Fd70()).set_Location(new Point(22, 18));
		((Control)Fd70()).set_Name("Label1");
		((Control)Fd70()).set_Size(new Size(81, 20));
		((Control)Fd70()).set_TabIndex(64);
		Fd70().set_Text("Mã ký túc");
		((Control)Kz18()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Kz18()).set_Location(new Point(147, 55));
		((Control)Kz18()).set_Name("TextBox2");
		((Control)Kz18()).set_Size(new Size(101, 26));
		((Control)Kz18()).set_TabIndex(63);
		Gr3o().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Gr3o()).set_Location(new Point(13, 219));
		((Control)Gr3o()).set_Name("DataGridView1");
		((Control)Gr3o()).set_Size(new Size(448, 309));
		((Control)Gr3o()).set_TabIndex(61);
		Sq9y().set_AutoSize(true);
		((Control)Sq9y()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Sq9y()).set_Location(new Point(22, 105));
		((Control)Sq9y()).set_Name("Label3");
		((Control)Sq9y()).set_Size(new Size(91, 20));
		((Control)Sq9y()).set_TabIndex(72);
		Sq9y().set_Text("Loại phòng");
		Yq36().set_DropDownStyle((ComboBoxStyle)2);
		((Control)Yq36()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)Yq36()).set_FormattingEnabled(true);
		((Control)Yq36()).set_Location(new Point(147, 15));
		((Control)Yq36()).set_Name("cbomkt");
		((Control)Yq36()).set_Size(new Size(99, 28));
		((Control)Yq36()).set_TabIndex(76);
		j1P8().set_DropDownStyle((ComboBoxStyle)2);
		((Control)j1P8()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)j1P8()).set_FormattingEnabled(true);
		j1P8().get_Items().AddRange(new object[2] { "Nam", "Nữ" });
		((Control)j1P8()).set_Location(new Point(147, 102));
		((Control)j1P8()).set_Name("ComboBox1");
		((Control)j1P8()).set_Size(new Size(99, 28));
		((Control)j1P8()).set_TabIndex(79);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(475, 558));
		((Control)this).get_Controls().Add((Control)(object)j1P8());
		((Control)this).get_Controls().Add((Control)(object)Yq36());
		((Control)this).get_Controls().Add((Control)(object)Sq9y());
		((Control)this).get_Controls().Add((Control)(object)He26());
		((Control)this).get_Controls().Add((Control)(object)w4J9());
		((Control)this).get_Controls().Add((Control)(object)i5CQ());
		((Control)this).get_Controls().Add((Control)(object)Hr9j());
		((Control)this).get_Controls().Add((Control)(object)Fd70());
		((Control)this).get_Controls().Add((Control)(object)Kz18());
		((Control)this).get_Controls().Add((Control)(object)Gr3o());
		((Control)this).set_Name("Form6");
		((Form)this).set_Text("Danh sách phòng");
		((ISupportInitialize)Gr3o()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button He26()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4NR(Button Qy07)
	{
		EventHandler eventHandler = Xy97;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Qy07;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button w4J9()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo3b(Button Pr7m)
	{
		EventHandler eventHandler = y1W9;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = Pr7m;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button i5CQ()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6K3(Button c1K2)
	{
		EventHandler eventHandler = Mk08;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = c1K2;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Hr9j()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2JP(Label Zb43)
	{
		Label val = (J = Zb43);
	}

	[SpecialName]
	internal virtual Label Fd70()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qg1q(Label s4P6)
	{
		Label val = (S = s4P6);
	}

	[SpecialName]
	internal virtual TextBox Kz18()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zs6f(TextBox n5FJ)
	{
		TextBox val = (h = n5FJ);
	}

	[SpecialName]
	internal virtual DataGridView Gr3o()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b2MR(DataGridView j4HR)
	{
		DataGridView val = (P = j4HR);
	}

	[SpecialName]
	internal virtual Label Sq9y()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2A0(Label e0C5)
	{
		Label val = (E = e0C5);
	}

	[SpecialName]
	internal virtual ComboBox Yq36()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3NA(ComboBox x6Z1)
	{
		ComboBox val = (Q = x6Z1);
	}

	[SpecialName]
	internal virtual ComboBox j1P8()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8JT(ComboBox r1B4)
	{
		ComboBox val = (a = r1B4);
	}

	private void Mn6i(object sender, EventArgs e)
	{
		t5TN.Ft29();
		Gr3o().set_DataSource((object)Nn6.ds.Tables["phong"]);
		Qx2i();
	}

	private void Qx2i()
	{
		d0N.Wk01();
		Yq36().get_Items().Clear();
		checked
		{
			int num = Nn6.ds.Tables["kytuc"]!.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Yq36().get_Items().Add(RuntimeHelpers.GetObjectValue(Nn6.ds.Tables["kytuc"]!.Rows[i][0]));
			}
		}
	}

	private void Mk08(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(Yq36().get_Text(), "", false) == 0) | (Operators.CompareString(Kz18().get_Text(), "", false) == 0) | (Operators.CompareString(j1P8().get_Text(), "", false) == 0))
		{
			Interaction.MsgBox((object)"Bạn cần nhập đủ thông tin", (MsgBoxStyle)64, (object)"Thông Báo");
		}
		else if (Operators.CompareString(j1P8().get_Text(), "Nam", false) == 0)
		{
			if (t5TN.q6PB(Kz18().get_Text(), Yq36().get_Text()) == 0)
			{
				t5TN.m3AK(Kz18().get_Text(), Yq36().get_Text(), x0ES: true);
				return;
			}
			long num = (long)Interaction.MsgBox((object)"Đã tồn tại, bạn muốn sủa không", (MsgBoxStyle)1, (object)"thông báo");
			if (num == 1L)
			{
				t5TN.d2C1(Kz18().get_Text(), Yq36().get_Text(), Ha9b: true);
			}
			else
			{
				num = 2L;
			}
		}
		else
		{
			if (Operators.CompareString(j1P8().get_Text(), "Nữ", false) != 0)
			{
				return;
			}
			if (t5TN.q6PB(Kz18().get_Text(), Yq36().get_Text()) == 0)
			{
				t5TN.m3AK(Kz18().get_Text(), Yq36().get_Text(), x0ES: false);
				return;
			}
			long num = (long)Interaction.MsgBox((object)"Đã tồn tại, bạn muốn sủa không", (MsgBoxStyle)1, (object)"thông báo");
			if (num == 1L)
			{
				t5TN.d2C1(Kz18().get_Text(), Yq36().get_Text(), Ha9b: false);
			}
			else
			{
				num = 2L;
			}
		}
	}

	internal static void j6JL()
	{
		string[] hf = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Mq8.q8R(hf, 0, 3);
		string value2 = Mq8.q8R(hf, 4, 7);
		Ct6.mDic.Add(Ct6.tName, value);
		Ct6.mDic.Add(Ct6.mName, value2);
	}

	private void y1W9(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (t5TN.q6PB(Kz18().get_Text(), Yq36().get_Text()) == 0)
		{
			Interaction.MsgBox((object)"Không có mã  này , không xóa được", (MsgBoxStyle)64, (object)"Thông báo");
		}
		else
		{
			t5TN.r2P6(Kz18().get_Text(), Yq36().get_Text());
		}
	}

	private void Xy97(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}
}
