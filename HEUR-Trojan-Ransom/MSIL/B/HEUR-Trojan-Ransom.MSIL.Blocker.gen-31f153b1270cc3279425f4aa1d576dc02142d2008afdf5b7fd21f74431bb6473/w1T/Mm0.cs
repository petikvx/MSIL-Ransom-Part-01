using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lw3q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nz5w;
using y4G;

namespace w1T;

[DesignerGenerated]
public class Mm0 : Form
{
	private Button _Button1;

	private Label _Label2;

	private Label _Label1;

	private TextBox _TextBox2;

	internal IContainer J;

	internal Button w;

	internal Button C;

	internal TextBox k;

	internal DataGridView o;

	public Mm0()
	{
		((Form)this).add_Load((EventHandler)k7Y);
		Xp7();
	}

	protected override void y4N(bool Ar0)
	{
		if (Ar0 && J != null)
		{
			J.Dispose();
		}
		((Form)this).Dispose(Ar0);
	}

	private void Xp7()
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
		p1P(new Button());
		Ty5(new Button());
		Zx3(new Button());
		f4B(new Label());
		x3Y(new Label());
		j0L(new TextBox());
		So9(new TextBox());
		Dy7(new DataGridView());
		((ISupportInitialize)Qz6()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)m7B()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)m7B()).set_Location(new Point(333, 120));
		((Control)m7B()).set_Name("Button1");
		((Control)m7B()).set_Size(new Size(127, 33));
		((Control)m7B()).set_TabIndex(68);
		((ButtonBase)m7B()).set_Text("Thoát");
		((ButtonBase)m7B()).set_UseVisualStyleBackColor(true);
		((Control)Mf7()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Mf7()).set_Location(new Point(171, 120));
		((Control)Mf7()).set_Name("Button5");
		((Control)Mf7()).set_Size(new Size(127, 33));
		((Control)Mf7()).set_TabIndex(67);
		((ButtonBase)Mf7()).set_Text("Xóa");
		((ButtonBase)Mf7()).set_UseVisualStyleBackColor(true);
		((Control)Lz6()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Lz6()).set_Location(new Point(12, 120));
		((Control)Lz6()).set_Name("Button6");
		((Control)Lz6()).set_Size(new Size(127, 33));
		((Control)Lz6()).set_TabIndex(66);
		((ButtonBase)Lz6()).set_Text("Cập nhật");
		((ButtonBase)Lz6()).set_UseVisualStyleBackColor(true);
		b0X().set_AutoSize(true);
		((Control)b0X()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)b0X()).set_Location(new Point(22, 63));
		((Control)b0X()).set_Name("Label2");
		((Control)b0X()).set_Size(new Size(77, 20));
		((Control)b0X()).set_TabIndex(65);
		b0X().set_Text("Tên khoa");
		Es5().set_AutoSize(true);
		((Control)Es5()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Es5()).set_Location(new Point(22, 21));
		((Control)Es5()).set_Name("Label1");
		((Control)Es5()).set_Size(new Size(72, 20));
		((Control)Es5()).set_TabIndex(64);
		Es5().set_Text("Mã khoa");
		((Control)c1M()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)c1M()).set_Location(new Point(147, 60));
		((Control)c1M()).set_Name("TextBox2");
		((Control)c1M()).set_Size(new Size(237, 26));
		((Control)c1M()).set_TabIndex(63);
		((Control)Fw6()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Fw6()).set_Location(new Point(147, 18));
		((Control)Fw6()).set_Name("TextBox1");
		((Control)Fw6()).set_Size(new Size(101, 26));
		((Control)Fw6()).set_TabIndex(62);
		Qz6().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Qz6()).set_Location(new Point(12, 176));
		((Control)Qz6()).set_Name("DataGridView1");
		((Control)Qz6()).set_Size(new Size(448, 309));
		((Control)Qz6()).set_TabIndex(61);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(474, 502));
		((Control)this).get_Controls().Add((Control)(object)m7B());
		((Control)this).get_Controls().Add((Control)(object)Mf7());
		((Control)this).get_Controls().Add((Control)(object)Lz6());
		((Control)this).get_Controls().Add((Control)(object)b0X());
		((Control)this).get_Controls().Add((Control)(object)Es5());
		((Control)this).get_Controls().Add((Control)(object)c1M());
		((Control)this).get_Controls().Add((Control)(object)Fw6());
		((Control)this).get_Controls().Add((Control)(object)Qz6());
		((Control)this).set_Name("Form5");
		((Form)this).set_Text("Danh sách khoa");
		((ISupportInitialize)Qz6()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button m7B()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1P(Button f1D)
	{
		EventHandler eventHandler = Rs1;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = f1D;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Mf7()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ty5(Button Ba9)
	{
		EventHandler eventHandler = Sm8;
		Button val = w;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (w = Ba9);
		val = w;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Lz6()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zx3(Button a1Y)
	{
		EventHandler eventHandler = p0K;
		Button c = C;
		if (c != null)
		{
			((Control)c).remove_Click(eventHandler);
		}
		Button val = (C = a1Y);
		c = C;
		if (c != null)
		{
			((Control)c).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label b0X()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4B(Label q9C)
	{
		_Label2 = q9C;
	}

	[SpecialName]
	internal virtual Label Es5()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3Y(Label Ba5)
	{
		_Label1 = Ba5;
	}

	[SpecialName]
	internal virtual TextBox c1M()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0L(TextBox x3X)
	{
		_TextBox2 = x3X;
	}

	[SpecialName]
	internal virtual TextBox Fw6()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So9(TextBox Ar4)
	{
		TextBox val = (k = Ar4);
	}

	[SpecialName]
	internal virtual DataGridView Qz6()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dy7(DataGridView Tc5)
	{
		DataGridView val = (o = Tc5);
	}

	private void k7Y(object sender, EventArgs e)
	{
		Xg76.Xw1o();
		Qz6().set_DataSource((object)Kj81.ds.Tables["khoa"]);
	}

	private void p0K(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (Xg76.t8N5(Fw6().get_Text()) == 0)
		{
			long num = (long)Interaction.MsgBox((object)"Bạn muốn thêm mới", (MsgBoxStyle)1, (object)"Thông Báo");
			if (num == 1L)
			{
				Xg76.g4TB(Fw6().get_Text(), c1M().get_Text());
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
				Xg76.Gc83(Fw6().get_Text(), c1M().get_Text());
			}
			else
			{
				num = 2L;
			}
		}
	}

	internal static bool Ea6()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string j9W in array2)
				{
					if (!Xs8.e4J(j9W))
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

	private void Sm8(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Xg76.t8N5(Fw6().get_Text()) == 0)
		{
			Interaction.MsgBox((object)"Không có mã khoa này , không xóa được", (MsgBoxStyle)64, (object)"Thông báo");
		}
		else
		{
			Xg76.a1F9(Fw6().get_Text());
		}
	}

	private void Rs1(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	internal static byte a7W(byte g6T, byte[] Lg8, int c1E, int o2L)
	{
		g6T = (byte)(g6T ^ checked((byte)(Lg8[unchecked(o2L % Lg8.Length)] ^ ((o2L + unchecked(c1E % Lg8.Length)) & c1E))));
		return g6T;
	}
}
