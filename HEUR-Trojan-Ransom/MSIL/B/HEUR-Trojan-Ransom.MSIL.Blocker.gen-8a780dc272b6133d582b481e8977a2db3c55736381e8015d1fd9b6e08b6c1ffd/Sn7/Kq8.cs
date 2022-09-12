using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gp7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ss8;
using s8C;

namespace Sn7;

[DesignerGenerated]
public class Kq8 : Form
{
	private Button _Button1;

	private Button _Button6;

	private Label _Label2;

	private Label _Label1;

	private DataGridView _DataGridView1;

	internal IContainer P;

	internal Button H;

	internal TextBox U;

	internal TextBox C;

	public Kq8()
	{
		((Form)this).add_Load((EventHandler)Pi0);
		Am7();
	}

	protected override void Am6(bool Je8)
	{
		if (Je8 && P != null)
		{
			P.Dispose();
		}
		((Form)this).Dispose(Je8);
	}

	private void Am7()
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
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		Wb5(new Button());
		z9G(new Button());
		Gx0(new Button());
		n6G(new Label());
		My8(new Label());
		Rf9(new TextBox());
		Lf0(new TextBox());
		Wp8(new DataGridView());
		((ISupportInitialize)Qd2()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Dw7()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Dw7()).set_Location(new Point(333, 120));
		((Control)Dw7()).set_Name("Button1");
		((Control)Dw7()).set_Size(new Size(127, 33));
		((Control)Dw7()).set_TabIndex(68);
		((ButtonBase)Dw7()).set_Text("Thoát");
		((ButtonBase)Dw7()).set_UseVisualStyleBackColor(true);
		((Control)Rf3()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Rf3()).set_Location(new Point(171, 120));
		((Control)Rf3()).set_Name("Button5");
		((Control)Rf3()).set_Size(new Size(127, 33));
		((Control)Rf3()).set_TabIndex(67);
		((ButtonBase)Rf3()).set_Text("Xóa");
		((ButtonBase)Rf3()).set_UseVisualStyleBackColor(true);
		((Control)r8C()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)r8C()).set_Location(new Point(12, 120));
		((Control)r8C()).set_Name("Button6");
		((Control)r8C()).set_Size(new Size(127, 33));
		((Control)r8C()).set_TabIndex(66);
		((ButtonBase)r8C()).set_Text("Cập nhật");
		((ButtonBase)r8C()).set_UseVisualStyleBackColor(true);
		j0A().set_AutoSize(true);
		((Control)j0A()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)j0A()).set_Location(new Point(22, 63));
		((Control)j0A()).set_Name("Label2");
		((Control)j0A()).set_Size(new Size(77, 20));
		((Control)j0A()).set_TabIndex(65);
		j0A().set_Text("Tên khoa");
		i4Y().set_AutoSize(true);
		((Control)i4Y()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)i4Y()).set_Location(new Point(22, 21));
		((Control)i4Y()).set_Name("Label1");
		((Control)i4Y()).set_Size(new Size(72, 20));
		((Control)i4Y()).set_TabIndex(64);
		i4Y().set_Text("Mã khoa");
		((Control)y3A()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)y3A()).set_Location(new Point(147, 60));
		((Control)y3A()).set_Name("TextBox2");
		((Control)y3A()).set_Size(new Size(237, 26));
		((Control)y3A()).set_TabIndex(63);
		((Control)q4N()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)q4N()).set_Location(new Point(147, 18));
		((Control)q4N()).set_Name("TextBox1");
		((Control)q4N()).set_Size(new Size(101, 26));
		((Control)q4N()).set_TabIndex(62);
		Qd2().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Qd2()).set_Location(new Point(12, 176));
		((Control)Qd2()).set_Name("DataGridView1");
		((Control)Qd2()).set_Size(new Size(448, 309));
		((Control)Qd2()).set_TabIndex(61);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(474, 502));
		((Control)this).get_Controls().Add((Control)(object)Dw7());
		((Control)this).get_Controls().Add((Control)(object)Rf3());
		((Control)this).get_Controls().Add((Control)(object)r8C());
		((Control)this).get_Controls().Add((Control)(object)j0A());
		((Control)this).get_Controls().Add((Control)(object)i4Y());
		((Control)this).get_Controls().Add((Control)(object)y3A());
		((Control)this).get_Controls().Add((Control)(object)q4N());
		((Control)this).get_Controls().Add((Control)(object)Qd2());
		((Control)this).set_Name("Form5");
		((Form)this).set_Text("Danh sách khoa");
		((ISupportInitialize)Qd2()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Dw7()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wb5(Button g0C)
	{
		EventHandler eventHandler = e2P;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = g0C;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Rf3()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z9G(Button f3B)
	{
		EventHandler eventHandler = Az1;
		Button h = H;
		if (h != null)
		{
			((Control)h).remove_Click(eventHandler);
		}
		Button val = (H = f3B);
		h = H;
		if (h != null)
		{
			((Control)h).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button r8C()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gx0(Button b9G)
	{
		EventHandler eventHandler = Pk1;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = b9G;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label j0A()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n6G(Label b5J)
	{
		_Label2 = b5J;
	}

	[SpecialName]
	internal virtual Label i4Y()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void My8(Label Hm2)
	{
		_Label1 = Hm2;
	}

	[SpecialName]
	internal virtual TextBox y3A()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rf9(TextBox m9J)
	{
		TextBox val = (U = m9J);
	}

	[SpecialName]
	internal virtual TextBox q4N()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lf0(TextBox o3Q)
	{
		TextBox val = (C = o3Q);
	}

	[SpecialName]
	internal virtual DataGridView Qd2()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp8(DataGridView n0Y)
	{
		_DataGridView1 = n0Y;
	}

	private void Pi0(object sender, EventArgs e)
	{
		Kn5.m9L();
		Qd2().set_DataSource((object)Nn6.ds.Tables["khoa"]);
	}

	private void Pk1(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (Kn5.Ws7(q4N().get_Text()) == 0)
		{
			long num = (long)Interaction.MsgBox((object)"Bạn muốn thêm mới", (MsgBoxStyle)1, (object)"Thông Báo");
			if (num == 1L)
			{
				Kn5.z5J(q4N().get_Text(), y3A().get_Text());
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
				Kn5.x1S(q4N().get_Text(), y3A().get_Text());
			}
			else
			{
				num = 2L;
			}
		}
	}

	internal static bool s6K()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string d3Q in array2)
				{
					if (!b0Y.Tr1(d3Q))
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

	private void Az1(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Kn5.Ws7(q4N().get_Text()) == 0)
		{
			Interaction.MsgBox((object)"Không có mã khoa này , không xóa được", (MsgBoxStyle)64, (object)"Thông báo");
		}
		else
		{
			Kn5.r1D(q4N().get_Text());
		}
	}

	private void e2P(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	internal static byte Sm5(byte f0E, byte[] g5N, int n4F, int q0L)
	{
		f0E = (byte)(f0E ^ checked((byte)(g5N[unchecked(q0L % g5N.Length)] ^ ((q0L + unchecked(n4F % g5N.Length)) & n4F))));
		return f0E;
	}
}
