using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fd5;
using Lo1j;
using Lw3q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using q9A4;
using w1R;

namespace Dc16;

[DesignerGenerated]
public class Tw3o : Form
{
	private IContainer components;

	private Button _Button6;

	private Label _Label2;

	private Label _Label1;

	private TextBox _TextBox2;

	private DataGridView _DataGridView1;

	internal Button o;

	internal Button F;

	internal Label h;

	internal ComboBox J;

	internal ComboBox a;

	public Tw3o()
	{
		((Form)this).add_Load((EventHandler)w6RA);
		t3YC();
	}

	protected override void m4DE(bool q2SR)
	{
		if (q2SR && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(q2SR);
	}

	private void t3YC()
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
		e8Q5(new Button());
		Tr5p(new Button());
		i3F5(new Button());
		t2Z8(new Label());
		j5BL(new Label());
		b7MJ(new TextBox());
		Ay9i(new DataGridView());
		g9AT(new Label());
		Wm9y(new ComboBox());
		i5SH(new ComboBox());
		((ISupportInitialize)b9N6()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)n5CG()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)n5CG()).set_Location(new Point(334, 168));
		((Control)n5CG()).set_Name("Button1");
		((Control)n5CG()).set_Size(new Size(127, 33));
		((Control)n5CG()).set_TabIndex(68);
		((ButtonBase)n5CG()).set_Text("Thoát");
		((ButtonBase)n5CG()).set_UseVisualStyleBackColor(true);
		((Control)Lq30()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Lq30()).set_Location(new Point(172, 168));
		((Control)Lq30()).set_Name("Button5");
		((Control)Lq30()).set_Size(new Size(127, 33));
		((Control)Lq30()).set_TabIndex(67);
		((ButtonBase)Lq30()).set_Text("Xóa");
		((ButtonBase)Lq30()).set_UseVisualStyleBackColor(true);
		((Control)j3HA()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)j3HA()).set_Location(new Point(13, 168));
		((Control)j3HA()).set_Name("Button6");
		((Control)j3HA()).set_Size(new Size(127, 33));
		((Control)j3HA()).set_TabIndex(66);
		((ButtonBase)j3HA()).set_Text("Cập nhật");
		((ButtonBase)j3HA()).set_UseVisualStyleBackColor(true);
		i5NJ().set_AutoSize(true);
		((Control)i5NJ()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)i5NJ()).set_Location(new Point(22, 61));
		((Control)i5NJ()).set_Name("Label2");
		((Control)i5NJ()).set_Size(new Size(82, 20));
		((Control)i5NJ()).set_TabIndex(65);
		i5NJ().set_Text("Mã phòng");
		Cj20().set_AutoSize(true);
		((Control)Cj20()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Cj20()).set_Location(new Point(22, 18));
		((Control)Cj20()).set_Name("Label1");
		((Control)Cj20()).set_Size(new Size(81, 20));
		((Control)Cj20()).set_TabIndex(64);
		Cj20().set_Text("Mã ký túc");
		((Control)Nx4c()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Nx4c()).set_Location(new Point(147, 55));
		((Control)Nx4c()).set_Name("TextBox2");
		((Control)Nx4c()).set_Size(new Size(101, 26));
		((Control)Nx4c()).set_TabIndex(63);
		b9N6().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)b9N6()).set_Location(new Point(13, 219));
		((Control)b9N6()).set_Name("DataGridView1");
		((Control)b9N6()).set_Size(new Size(448, 309));
		((Control)b9N6()).set_TabIndex(61);
		Sx83().set_AutoSize(true);
		((Control)Sx83()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Sx83()).set_Location(new Point(22, 105));
		((Control)Sx83()).set_Name("Label3");
		((Control)Sx83()).set_Size(new Size(91, 20));
		((Control)Sx83()).set_TabIndex(72);
		Sx83().set_Text("Loại phòng");
		x7W5().set_DropDownStyle((ComboBoxStyle)2);
		((Control)x7W5()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)x7W5()).set_FormattingEnabled(true);
		((Control)x7W5()).set_Location(new Point(147, 15));
		((Control)x7W5()).set_Name("cbomkt");
		((Control)x7W5()).set_Size(new Size(99, 28));
		((Control)x7W5()).set_TabIndex(76);
		Gy83().set_DropDownStyle((ComboBoxStyle)2);
		((Control)Gy83()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)Gy83()).set_FormattingEnabled(true);
		Gy83().get_Items().AddRange(new object[2] { "Nam", "Nữ" });
		((Control)Gy83()).set_Location(new Point(147, 102));
		((Control)Gy83()).set_Name("ComboBox1");
		((Control)Gy83()).set_Size(new Size(99, 28));
		((Control)Gy83()).set_TabIndex(79);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(475, 558));
		((Control)this).get_Controls().Add((Control)(object)Gy83());
		((Control)this).get_Controls().Add((Control)(object)x7W5());
		((Control)this).get_Controls().Add((Control)(object)Sx83());
		((Control)this).get_Controls().Add((Control)(object)n5CG());
		((Control)this).get_Controls().Add((Control)(object)Lq30());
		((Control)this).get_Controls().Add((Control)(object)j3HA());
		((Control)this).get_Controls().Add((Control)(object)i5NJ());
		((Control)this).get_Controls().Add((Control)(object)Cj20());
		((Control)this).get_Controls().Add((Control)(object)Nx4c());
		((Control)this).get_Controls().Add((Control)(object)b9N6());
		((Control)this).set_Name("Form6");
		((Form)this).set_Text("Danh sách phòng");
		((ISupportInitialize)b9N6()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button n5CG()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8Q5(Button Ga9i)
	{
		EventHandler eventHandler = Tt5n;
		Button val = o;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (o = Ga9i);
		val = o;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Lq30()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tr5p(Button j8Q7)
	{
		EventHandler eventHandler = Ss65;
		Button f = F;
		if (f != null)
		{
			((Control)f).remove_Click(eventHandler);
		}
		Button val = (F = j8Q7);
		f = F;
		if (f != null)
		{
			((Control)f).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button j3HA()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3F5(Button j5Y2)
	{
		EventHandler eventHandler = i9EA;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = j5Y2;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label i5NJ()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2Z8(Label Gs67)
	{
		_Label2 = Gs67;
	}

	[SpecialName]
	internal virtual Label Cj20()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5BL(Label b3FJ)
	{
		_Label1 = b3FJ;
	}

	[SpecialName]
	internal virtual TextBox Nx4c()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7MJ(TextBox t7RQ)
	{
		_TextBox2 = t7RQ;
	}

	[SpecialName]
	internal virtual DataGridView b9N6()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ay9i(DataGridView Zf89)
	{
		_DataGridView1 = Zf89;
	}

	[SpecialName]
	internal virtual Label Sx83()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9AT(Label Pc8b)
	{
		Label val = (h = Pc8b);
	}

	[SpecialName]
	internal virtual ComboBox x7W5()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wm9y(ComboBox Hb8q)
	{
		ComboBox val = (J = Hb8q);
	}

	[SpecialName]
	internal virtual ComboBox Gy83()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5SH(ComboBox w8Y4)
	{
		ComboBox val = (a = w8Y4);
	}

	private void w6RA(object sender, EventArgs e)
	{
		q5C4.w0TP();
		b9N6().set_DataSource((object)Kj81.ds.Tables["phong"]);
		Gm7q();
	}

	private void Gm7q()
	{
		j5Q4.q6GS();
		x7W5().get_Items().Clear();
		checked
		{
			int num = Kj81.ds.Tables["kytuc"]!.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				x7W5().get_Items().Add(RuntimeHelpers.GetObjectValue(Kj81.ds.Tables["kytuc"]!.Rows[i][0]));
			}
		}
	}

	private void i9EA(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(x7W5().get_Text(), "", false) == 0) | (Operators.CompareString(Nx4c().get_Text(), "", false) == 0) | (Operators.CompareString(Gy83().get_Text(), "", false) == 0))
		{
			Interaction.MsgBox((object)"Bạn cần nhập đủ thông tin", (MsgBoxStyle)64, (object)"Thông Báo");
		}
		else if (Operators.CompareString(Gy83().get_Text(), "Nam", false) == 0)
		{
			if (q5C4.i4W3(Nx4c().get_Text(), x7W5().get_Text()) == 0)
			{
				q5C4.w7A8(Nx4c().get_Text(), x7W5().get_Text(), Wc09: true);
				return;
			}
			long num = (long)Interaction.MsgBox((object)"Đã tồn tại, bạn muốn sủa không", (MsgBoxStyle)1, (object)"thông báo");
			if (num == 1L)
			{
				q5C4.m4X9(Nx4c().get_Text(), x7W5().get_Text(), d7B9: true);
			}
			else
			{
				num = 2L;
			}
		}
		else
		{
			if (Operators.CompareString(Gy83().get_Text(), "Nữ", false) != 0)
			{
				return;
			}
			if (q5C4.i4W3(Nx4c().get_Text(), x7W5().get_Text()) == 0)
			{
				q5C4.w7A8(Nx4c().get_Text(), x7W5().get_Text(), Wc09: false);
				return;
			}
			long num = (long)Interaction.MsgBox((object)"Đã tồn tại, bạn muốn sủa không", (MsgBoxStyle)1, (object)"thông báo");
			if (num == 1L)
			{
				q5C4.m4X9(Nx4c().get_Text(), x7W5().get_Text(), d7B9: false);
			}
			else
			{
				num = 2L;
			}
		}
	}

	internal static void Tx40()
	{
		string[] w5R = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Em8.c0D(w5R, 0, 3);
		string value2 = Em8.c0D(w5R, 4, 7);
		n5L.mDic.Add(n5L.tName, value);
		n5L.mDic.Add(n5L.mName, value2);
	}

	private void Ss65(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (q5C4.i4W3(Nx4c().get_Text(), x7W5().get_Text()) == 0)
		{
			Interaction.MsgBox((object)"Không có mã  này , không xóa được", (MsgBoxStyle)64, (object)"Thông báo");
		}
		else
		{
			q5C4.Em1k(Nx4c().get_Text(), x7W5().get_Text());
		}
	}

	private void Tt5n(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}
}
