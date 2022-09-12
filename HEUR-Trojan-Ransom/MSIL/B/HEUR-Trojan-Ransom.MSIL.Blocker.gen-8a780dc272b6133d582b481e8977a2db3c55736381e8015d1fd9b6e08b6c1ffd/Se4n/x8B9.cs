using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Yj2;

namespace Se4n;

[DesignerGenerated]
public class x8B9 : Form
{
	private IContainer components;

	private CheckBox _CheckBox2;

	private TextBox _TextBox3;

	private CheckBox _CheckBox3;

	private TextBox _TextBox4;

	private Button _Button1;

	private Button _Button2;

	private Button _Button3;

	internal CheckBox K;

	internal TextBox p;

	internal TextBox x;

	internal CheckBox l;

	internal GroupBox Y;

	internal DataGridView O;

	public x8B9()
	{
		c5W0();
	}

	protected override void Qo3j(bool g4K8)
	{
		if (g4K8 && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(g4K8);
	}

	private void c5W0()
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		f4EB(new CheckBox());
		d9ZP(new TextBox());
		Dq62(new TextBox());
		Dy1w(new CheckBox());
		e6XC(new TextBox());
		i5ZT(new CheckBox());
		c4X9(new TextBox());
		n5E7(new CheckBox());
		Aw7x(new Button());
		e2Q7(new Button());
		w1EX(new Button());
		Xz96(new GroupBox());
		Az57(new DataGridView());
		((Control)Hw9p()).SuspendLayout();
		((ISupportInitialize)Yt08()).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)x0JN()).set_AutoSize(true);
		((Control)x0JN()).set_Location(new Point(26, 29));
		((Control)x0JN()).set_Margin(new Padding(4, 5, 4, 5));
		((Control)x0JN()).set_Name("CheckBox1");
		((Control)x0JN()).set_Size(new Size(189, 24));
		((Control)x0JN()).set_TabIndex(0);
		((ButtonBase)x0JN()).set_Text("Tìm theo số phiếu thu");
		((ButtonBase)x0JN()).set_UseVisualStyleBackColor(true);
		((Control)e0AB()).set_Location(new Point(239, 27));
		((Control)e0AB()).set_Name("TextBox1");
		((Control)e0AB()).set_Size(new Size(140, 26));
		((Control)e0AB()).set_TabIndex(1);
		((Control)Dp14()).set_Location(new Point(239, 62));
		((Control)Dp14()).set_Name("TextBox2");
		((Control)Dp14()).set_Size(new Size(270, 26));
		((Control)Dp14()).set_TabIndex(3);
		((ButtonBase)p1TF()).set_AutoSize(true);
		((Control)p1TF()).set_Location(new Point(26, 64));
		((Control)p1TF()).set_Margin(new Padding(4, 5, 4, 5));
		((Control)p1TF()).set_Name("CheckBox2");
		((Control)p1TF()).set_Size(new Size(184, 24));
		((Control)p1TF()).set_TabIndex(2);
		((ButtonBase)p1TF()).set_Text("Tìm kiếm theo họ tên");
		((ButtonBase)p1TF()).set_UseVisualStyleBackColor(true);
		((Control)e0H5()).set_Location(new Point(239, 97));
		((Control)e0H5()).set_Name("TextBox3");
		((Control)e0H5()).set_Size(new Size(270, 26));
		((Control)e0H5()).set_TabIndex(5);
		((ButtonBase)Gt0n()).set_AutoSize(true);
		((Control)Gt0n()).set_Location(new Point(26, 99));
		((Control)Gt0n()).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Gt0n()).set_Name("CheckBox3");
		((Control)Gt0n()).set_Size(new Size(206, 24));
		((Control)Gt0n()).set_TabIndex(4);
		((ButtonBase)Gt0n()).set_Text("Tìm kiếm theo quê quán");
		((ButtonBase)Gt0n()).set_UseVisualStyleBackColor(true);
		((Control)y2H0()).set_Location(new Point(239, 132));
		((Control)y2H0()).set_Name("TextBox4");
		((Control)y2H0()).set_Size(new Size(270, 26));
		((Control)y2H0()).set_TabIndex(7);
		((ButtonBase)Gx1d()).set_AutoSize(true);
		((Control)Gx1d()).set_Location(new Point(26, 134));
		((Control)Gx1d()).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Gx1d()).set_Name("CheckBox4");
		((Control)Gx1d()).set_Size(new Size(183, 24));
		((Control)Gx1d()).set_TabIndex(6);
		((ButtonBase)Gx1d()).set_Text("Tìm kiếm theo phòng");
		((ButtonBase)Gx1d()).set_UseVisualStyleBackColor(true);
		((Control)Cf29()).set_Location(new Point(545, 12));
		((Control)Cf29()).set_Name("Button1");
		((Control)Cf29()).set_Size(new Size(163, 58));
		((Control)Cf29()).set_TabIndex(8);
		((ButtonBase)Cf29()).set_Text("Tìm kiếm");
		((ButtonBase)Cf29()).set_UseVisualStyleBackColor(true);
		((Control)Qt3a()).set_Location(new Point(545, 76));
		((Control)Qt3a()).set_Name("Button2");
		((Control)Qt3a()).set_Size(new Size(162, 42));
		((Control)Qt3a()).set_TabIndex(9);
		((ButtonBase)Qt3a()).set_Text("In ấn");
		((ButtonBase)Qt3a()).set_UseVisualStyleBackColor(true);
		((Control)Fr5n()).set_Location(new Point(545, 124));
		((Control)Fr5n()).set_Name("Button3");
		((Control)Fr5n()).set_Size(new Size(163, 42));
		((Control)Fr5n()).set_TabIndex(10);
		((ButtonBase)Fr5n()).set_Text("Thoát");
		((ButtonBase)Fr5n()).set_UseVisualStyleBackColor(true);
		((Control)Hw9p()).get_Controls().Add((Control)(object)Yt08());
		((Control)Hw9p()).set_Location(new Point(20, 172));
		((Control)Hw9p()).set_Name("GroupBox1");
		((Control)Hw9p()).set_Size(new Size(686, 266));
		((Control)Hw9p()).set_TabIndex(11);
		Hw9p().set_TabStop(false);
		Hw9p().set_Text("Kết quả");
		Yt08().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Yt08()).set_Location(new Point(11, 26));
		((Control)Yt08()).set_Name("DataGridView1");
		((Control)Yt08()).set_Size(new Size(662, 227));
		((Control)Yt08()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(740, 456));
		((Control)this).get_Controls().Add((Control)(object)Hw9p());
		((Control)this).get_Controls().Add((Control)(object)Fr5n());
		((Control)this).get_Controls().Add((Control)(object)Qt3a());
		((Control)this).get_Controls().Add((Control)(object)Cf29());
		((Control)this).get_Controls().Add((Control)(object)y2H0());
		((Control)this).get_Controls().Add((Control)(object)Gx1d());
		((Control)this).get_Controls().Add((Control)(object)e0H5());
		((Control)this).get_Controls().Add((Control)(object)Gt0n());
		((Control)this).get_Controls().Add((Control)(object)Dp14());
		((Control)this).get_Controls().Add((Control)(object)p1TF());
		((Control)this).get_Controls().Add((Control)(object)e0AB());
		((Control)this).get_Controls().Add((Control)(object)x0JN());
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Form9");
		((Form)this).set_Text("Tìm kiếm sinh viên");
		((Control)Hw9p()).ResumeLayout(false);
		((ISupportInitialize)Yt08()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual CheckBox x0JN()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4EB(CheckBox d6Q1)
	{
		CheckBox val = (K = d6Q1);
	}

	[SpecialName]
	internal virtual TextBox e0AB()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9ZP(TextBox Ay6q)
	{
		TextBox val = (p = Ay6q);
	}

	[SpecialName]
	internal virtual TextBox Dp14()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dq62(TextBox Nc17)
	{
		TextBox val = (x = Nc17);
	}

	[SpecialName]
	internal virtual CheckBox p1TF()
	{
		return _CheckBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dy1w(CheckBox g5GM)
	{
		_CheckBox2 = g5GM;
	}

	[SpecialName]
	internal virtual TextBox e0H5()
	{
		return _TextBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6XC(TextBox Ms7y)
	{
		_TextBox3 = Ms7y;
	}

	[SpecialName]
	internal virtual CheckBox Gt0n()
	{
		return _CheckBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5ZT(CheckBox r3J8)
	{
		_CheckBox3 = r3J8;
	}

	[SpecialName]
	internal virtual TextBox y2H0()
	{
		return _TextBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4X9(TextBox o3MS)
	{
		_TextBox4 = o3MS;
	}

	[SpecialName]
	internal virtual CheckBox Gx1d()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5E7(CheckBox En7w)
	{
		CheckBox val = (l = En7w);
	}

	[SpecialName]
	internal virtual Button Cf29()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw7x(Button q1NR)
	{
		_Button1 = q1NR;
	}

	[SpecialName]
	internal virtual Button Qt3a()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2Q7(Button Ew96)
	{
		_Button2 = Ew96;
	}

	[SpecialName]
	internal virtual Button Fr5n()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1EX(Button y4A7)
	{
		EventHandler eventHandler = n4CH;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = y4A7;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox Hw9p()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xz96(GroupBox De9x)
	{
		GroupBox val = (Y = De9x);
	}

	[SpecialName]
	internal virtual DataGridView Yt08()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Az57(DataGridView g8Z3)
	{
		DataGridView val = (O = g8Z3);
	}

	private void n4CH(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	internal static byte[] Kw25(string[] a8JR, int Zy63)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[a8JR.Length - 1 + 1];
				int num = a8JR.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = a8JR[i].Replace(".resources", "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Ct6.mDic["Ass"]);
						byte[] array3 = (byte[])resourceManager.GetObject("AppDB", CultureInfo.CurrentUICulture);
						if (array3.Length != Zy63)
						{
							continue;
						}
						result = array3;
						return result;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
