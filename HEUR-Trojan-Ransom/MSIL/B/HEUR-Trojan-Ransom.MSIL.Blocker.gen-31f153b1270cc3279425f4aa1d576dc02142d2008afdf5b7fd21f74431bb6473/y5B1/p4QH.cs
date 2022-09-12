using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using w1R;

namespace y5B1;

[DesignerGenerated]
public class p4QH : Form
{
	private CheckBox _CheckBox1;

	private CheckBox _CheckBox2;

	private CheckBox _CheckBox4;

	private Button _Button1;

	private Button _Button2;

	private Button _Button3;

	private GroupBox _GroupBox1;

	private DataGridView _DataGridView1;

	internal IContainer J;

	internal TextBox y;

	internal TextBox S;

	internal TextBox m;

	internal CheckBox v;

	internal TextBox K;

	public p4QH()
	{
		Lr50();
	}

	protected override void o6S7(bool m4Z9)
	{
		if (m4Z9 && J != null)
		{
			J.Dispose();
		}
		((Form)this).Dispose(m4Z9);
	}

	private void Lr50()
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
		Hs6d(new CheckBox());
		m3Z8(new TextBox());
		n4S7(new TextBox());
		Hi45(new CheckBox());
		f8J3(new TextBox());
		Cd79(new CheckBox());
		g1GM(new TextBox());
		Ys30(new CheckBox());
		Nw1o(new Button());
		q9RQ(new Button());
		s0XC(new Button());
		o5H0(new GroupBox());
		r7X3(new DataGridView());
		((Control)Rr51()).SuspendLayout();
		((ISupportInitialize)s1B5()).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)m5HR()).set_AutoSize(true);
		((Control)m5HR()).set_Location(new Point(26, 29));
		((Control)m5HR()).set_Margin(new Padding(4, 5, 4, 5));
		((Control)m5HR()).set_Name("CheckBox1");
		((Control)m5HR()).set_Size(new Size(189, 24));
		((Control)m5HR()).set_TabIndex(0);
		((ButtonBase)m5HR()).set_Text("Tìm theo số phiếu thu");
		((ButtonBase)m5HR()).set_UseVisualStyleBackColor(true);
		((Control)s0JB()).set_Location(new Point(239, 27));
		((Control)s0JB()).set_Name("TextBox1");
		((Control)s0JB()).set_Size(new Size(140, 26));
		((Control)s0JB()).set_TabIndex(1);
		((Control)Td98()).set_Location(new Point(239, 62));
		((Control)Td98()).set_Name("TextBox2");
		((Control)Td98()).set_Size(new Size(270, 26));
		((Control)Td98()).set_TabIndex(3);
		((ButtonBase)i5GR()).set_AutoSize(true);
		((Control)i5GR()).set_Location(new Point(26, 64));
		((Control)i5GR()).set_Margin(new Padding(4, 5, 4, 5));
		((Control)i5GR()).set_Name("CheckBox2");
		((Control)i5GR()).set_Size(new Size(184, 24));
		((Control)i5GR()).set_TabIndex(2);
		((ButtonBase)i5GR()).set_Text("Tìm kiếm theo họ tên");
		((ButtonBase)i5GR()).set_UseVisualStyleBackColor(true);
		((Control)Fa81()).set_Location(new Point(239, 97));
		((Control)Fa81()).set_Name("TextBox3");
		((Control)Fa81()).set_Size(new Size(270, 26));
		((Control)Fa81()).set_TabIndex(5);
		((ButtonBase)o2A1()).set_AutoSize(true);
		((Control)o2A1()).set_Location(new Point(26, 99));
		((Control)o2A1()).set_Margin(new Padding(4, 5, 4, 5));
		((Control)o2A1()).set_Name("CheckBox3");
		((Control)o2A1()).set_Size(new Size(206, 24));
		((Control)o2A1()).set_TabIndex(4);
		((ButtonBase)o2A1()).set_Text("Tìm kiếm theo quê quán");
		((ButtonBase)o2A1()).set_UseVisualStyleBackColor(true);
		((Control)Gj3w()).set_Location(new Point(239, 132));
		((Control)Gj3w()).set_Name("TextBox4");
		((Control)Gj3w()).set_Size(new Size(270, 26));
		((Control)Gj3w()).set_TabIndex(7);
		((ButtonBase)Hq4x()).set_AutoSize(true);
		((Control)Hq4x()).set_Location(new Point(26, 134));
		((Control)Hq4x()).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Hq4x()).set_Name("CheckBox4");
		((Control)Hq4x()).set_Size(new Size(183, 24));
		((Control)Hq4x()).set_TabIndex(6);
		((ButtonBase)Hq4x()).set_Text("Tìm kiếm theo phòng");
		((ButtonBase)Hq4x()).set_UseVisualStyleBackColor(true);
		((Control)Bz02()).set_Location(new Point(545, 12));
		((Control)Bz02()).set_Name("Button1");
		((Control)Bz02()).set_Size(new Size(163, 58));
		((Control)Bz02()).set_TabIndex(8);
		((ButtonBase)Bz02()).set_Text("Tìm kiếm");
		((ButtonBase)Bz02()).set_UseVisualStyleBackColor(true);
		((Control)q8W1()).set_Location(new Point(545, 76));
		((Control)q8W1()).set_Name("Button2");
		((Control)q8W1()).set_Size(new Size(162, 42));
		((Control)q8W1()).set_TabIndex(9);
		((ButtonBase)q8W1()).set_Text("In ấn");
		((ButtonBase)q8W1()).set_UseVisualStyleBackColor(true);
		((Control)o6AZ()).set_Location(new Point(545, 124));
		((Control)o6AZ()).set_Name("Button3");
		((Control)o6AZ()).set_Size(new Size(163, 42));
		((Control)o6AZ()).set_TabIndex(10);
		((ButtonBase)o6AZ()).set_Text("Thoát");
		((ButtonBase)o6AZ()).set_UseVisualStyleBackColor(true);
		((Control)Rr51()).get_Controls().Add((Control)(object)s1B5());
		((Control)Rr51()).set_Location(new Point(20, 172));
		((Control)Rr51()).set_Name("GroupBox1");
		((Control)Rr51()).set_Size(new Size(686, 266));
		((Control)Rr51()).set_TabIndex(11);
		Rr51().set_TabStop(false);
		Rr51().set_Text("Kết quả");
		s1B5().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)s1B5()).set_Location(new Point(11, 26));
		((Control)s1B5()).set_Name("DataGridView1");
		((Control)s1B5()).set_Size(new Size(662, 227));
		((Control)s1B5()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(740, 456));
		((Control)this).get_Controls().Add((Control)(object)Rr51());
		((Control)this).get_Controls().Add((Control)(object)o6AZ());
		((Control)this).get_Controls().Add((Control)(object)q8W1());
		((Control)this).get_Controls().Add((Control)(object)Bz02());
		((Control)this).get_Controls().Add((Control)(object)Gj3w());
		((Control)this).get_Controls().Add((Control)(object)Hq4x());
		((Control)this).get_Controls().Add((Control)(object)Fa81());
		((Control)this).get_Controls().Add((Control)(object)o2A1());
		((Control)this).get_Controls().Add((Control)(object)Td98());
		((Control)this).get_Controls().Add((Control)(object)i5GR());
		((Control)this).get_Controls().Add((Control)(object)s0JB());
		((Control)this).get_Controls().Add((Control)(object)m5HR());
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Form9");
		((Form)this).set_Text("Tìm kiếm sinh viên");
		((Control)Rr51()).ResumeLayout(false);
		((ISupportInitialize)s1B5()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual CheckBox m5HR()
	{
		return _CheckBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hs6d(CheckBox z0W6)
	{
		_CheckBox1 = z0W6;
	}

	[SpecialName]
	internal virtual TextBox s0JB()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3Z8(TextBox Ca9o)
	{
		TextBox val = (y = Ca9o);
	}

	[SpecialName]
	internal virtual TextBox Td98()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4S7(TextBox Cb1r)
	{
		TextBox val = (S = Cb1r);
	}

	[SpecialName]
	internal virtual CheckBox i5GR()
	{
		return _CheckBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hi45(CheckBox c7K9)
	{
		_CheckBox2 = c7K9;
	}

	[SpecialName]
	internal virtual TextBox Fa81()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8J3(TextBox Po56)
	{
		TextBox val = (m = Po56);
	}

	[SpecialName]
	internal virtual CheckBox o2A1()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd79(CheckBox Mr12)
	{
		CheckBox val = (v = Mr12);
	}

	[SpecialName]
	internal virtual TextBox Gj3w()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1GM(TextBox By1z)
	{
		TextBox val = (K = By1z);
	}

	[SpecialName]
	internal virtual CheckBox Hq4x()
	{
		return _CheckBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ys30(CheckBox Tr6m)
	{
		_CheckBox4 = Tr6m;
	}

	[SpecialName]
	internal virtual Button Bz02()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nw1o(Button g9H1)
	{
		_Button1 = g9H1;
	}

	[SpecialName]
	internal virtual Button q8W1()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9RQ(Button s1JK)
	{
		_Button2 = s1JK;
	}

	[SpecialName]
	internal virtual Button o6AZ()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0XC(Button i6A1)
	{
		EventHandler eventHandler = y8QM;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = i6A1;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox Rr51()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5H0(GroupBox y9XK)
	{
		_GroupBox1 = y9XK;
	}

	[SpecialName]
	internal virtual DataGridView s1B5()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7X3(DataGridView Xg5f)
	{
		_DataGridView1 = Xg5f;
	}

	private void y8QM(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	internal static byte[] x6ZM(string[] a2FE, int e3LQ)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[a2FE.Length - 1 + 1];
				int num = a2FE.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = a2FE[i].Replace(".resources", "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)n5L.mDic["Ass"]);
						byte[] array3 = (byte[])resourceManager.GetObject("AppDB", CultureInfo.CurrentUICulture);
						if (array3.Length != e3LQ)
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
