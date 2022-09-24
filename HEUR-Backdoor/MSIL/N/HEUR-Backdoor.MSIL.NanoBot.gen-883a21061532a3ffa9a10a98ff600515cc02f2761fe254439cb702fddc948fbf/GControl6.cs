using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl6 : UserControl
{
	private int int_0;

	private IContainer icontainer_0 = null;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	public TextBox textBox_0;

	public TextBox textBox_1;

	public TextBox textBox_2;

	public TextBox textBox_3;

	public TextBox textBox_4;

	private Label label_6;

	public TextBox textBox_5;

	private Label label_7;

	public TextBox textBox_6;

	public TextBox textBox_7;

	private Label label_8;

	public TextBox textBox_8;

	private Label label_9;

	private Label label_10;

	public GControl6()
	{
		method_28();
	}

	public int method_0()
	{
		return int_0;
	}

	public void method_1(int int_1)
	{
		int_0 = int_1;
	}

	public void method_2()
	{
		int_0++;
	}

	public void method_3(string string_0)
	{
		((Control)textBox_2).set_Text(string_0);
	}

	public void method_4(string string_0)
	{
		((Control)textBox_5).set_Text(string_0);
	}

	public void method_5(string string_0)
	{
		((Control)textBox_7).set_Text(string_0);
	}

	public void method_6(string string_0)
	{
		((Control)textBox_0).set_Text(string_0);
	}

	public void method_7(string string_0)
	{
		((Control)textBox_6).set_Text(string_0);
	}

	public void method_8(string string_0)
	{
		((Control)textBox_1).set_Text(string_0);
	}

	public void method_9(string string_0)
	{
		((Control)textBox_3).set_Text(string_0);
	}

	public void method_10(string string_0)
	{
		((Control)textBox_8).set_Text(string_0);
	}

	public void method_11(string string_0)
	{
		((Control)textBox_4).set_Text(string_0);
	}

	public string method_12()
	{
		return ((Control)textBox_2).get_Text();
	}

	public string method_13()
	{
		return ((Control)textBox_5).get_Text();
	}

	public string method_14()
	{
		return ((Control)textBox_7).get_Text();
	}

	public string method_15()
	{
		if (((Control)textBox_0).get_Text() == string.Empty)
		{
			return Class9.smethod_0(-860094592);
		}
		return ((Control)textBox_0).get_Text();
	}

	public string method_16()
	{
		if (((Control)textBox_6).get_Text() == string.Empty)
		{
			return Class9.smethod_0(-860094592);
		}
		return ((Control)textBox_6).get_Text();
	}

	public string method_17()
	{
		if (((Control)textBox_1).get_Text() == string.Empty)
		{
			return Class9.smethod_0(-860103402);
		}
		int num = int.Parse(((Control)textBox_1).get_Text());
		if (num < 1801)
		{
			return Class9.smethod_0(-860103402);
		}
		if (num > 2499)
		{
			return Class9.smethod_0(-860103197);
		}
		return ((Control)textBox_1).get_Text();
	}

	public string method_18()
	{
		return ((Control)textBox_3).get_Text();
	}

	public string method_19()
	{
		return ((Control)textBox_8).get_Text();
	}

	public string method_20()
	{
		return ((Control)textBox_4).get_Text();
	}

	public void method_21()
	{
		method_3(string.Empty);
		method_4(string.Empty);
		method_5(string.Empty);
		method_6(string.Empty);
		method_7(string.Empty);
		method_8(string.Empty);
		method_9(string.Empty);
		method_11(string.Empty);
		method_10(string.Empty);
	}

	public void method_22()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_5).set_ReadOnly(true);
		((TextBoxBase)textBox_7).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((TextBoxBase)textBox_6).set_ReadOnly(true);
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((TextBoxBase)textBox_3).set_ReadOnly(true);
		((TextBoxBase)textBox_4).set_ReadOnly(true);
		((TextBoxBase)textBox_8).set_ReadOnly(true);
	}

	public void method_23()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(false);
		((TextBoxBase)textBox_5).set_ReadOnly(false);
		((TextBoxBase)textBox_7).set_ReadOnly(false);
		((TextBoxBase)textBox_0).set_ReadOnly(false);
		((TextBoxBase)textBox_6).set_ReadOnly(false);
		((TextBoxBase)textBox_1).set_ReadOnly(false);
		((TextBoxBase)textBox_3).set_ReadOnly(false);
		((TextBoxBase)textBox_4).set_ReadOnly(false);
		((TextBoxBase)textBox_8).set_ReadOnly(false);
	}

	public void method_24()
	{
		((TextBoxBase)textBox_4).set_ReadOnly(true);
		((TextBoxBase)textBox_5).set_ReadOnly(true);
		method_4(method_0().ToString());
	}

	public void method_25()
	{
		((TextBoxBase)textBox_4).set_ReadOnly(true);
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_5).set_ReadOnly(true);
	}

	public void method_26()
	{
		((Control)textBox_4).set_Visible(true);
		((Control)label_5).set_Visible(true);
	}

	public void method_27()
	{
		method_22();
		((TextBoxBase)textBox_2).set_ReadOnly(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_28()
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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		label_0 = new Label();
		textBox_0 = new TextBox();
		label_1 = new Label();
		textBox_1 = new TextBox();
		label_2 = new Label();
		textBox_2 = new TextBox();
		label_3 = new Label();
		textBox_3 = new TextBox();
		label_4 = new Label();
		textBox_4 = new TextBox();
		label_5 = new Label();
		label_6 = new Label();
		textBox_5 = new TextBox();
		label_7 = new Label();
		textBox_6 = new TextBox();
		textBox_7 = new TextBox();
		label_8 = new Label();
		textBox_8 = new TextBox();
		label_9 = new Label();
		label_10 = new Label();
		((Control)this).SuspendLayout();
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(348, 1));
		((Control)label_0).set_Name(Class9.smethod_0(-860097953));
		((Control)label_0).set_Size(new Size(64, 17));
		((Control)label_0).set_TabIndex(78);
		((Control)label_0).set_Text(Class9.smethod_0(-860096183));
		((Control)textBox_0).set_Location(new Point(3, 83));
		((Control)textBox_0).set_Name(Class9.smethod_0(-860103176));
		((Control)textBox_0).set_Size(new Size(150, 22));
		((Control)textBox_0).set_TabIndex(77);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(0, 63));
		((Control)label_1).set_Name(Class9.smethod_0(-860097854));
		((Control)label_1).set_Size(new Size(101, 17));
		((Control)label_1).set_TabIndex(76);
		((Control)label_1).set_Text(Class9.smethod_0(-860097828));
		((Control)textBox_1).set_Location(new Point(351, 83));
		((Control)textBox_1).set_Name(Class9.smethod_0(-860103202));
		((Control)textBox_1).set_Size(new Size(149, 22));
		((Control)textBox_1).set_TabIndex(75);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(348, 63));
		((Control)label_2).set_Name(Class9.smethod_0(-860097917));
		((Control)label_2).set_Size(new Size(74, 17));
		((Control)label_2).set_TabIndex(74);
		((Control)label_2).set_Text(Class9.smethod_0(-860097891));
		((Control)textBox_2).set_Location(new Point(3, 21));
		((Control)textBox_2).set_Name(Class9.smethod_0(-860103239));
		((Control)textBox_2).set_Size(new Size(149, 22));
		((Control)textBox_2).set_TabIndex(69);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Location(new Point(0, 1));
		((Control)label_3).set_Name(Class9.smethod_0(-860098090));
		((Control)label_3).set_Size(new Size(29, 17));
		((Control)label_3).set_TabIndex(68);
		((Control)label_3).set_Text(Class9.smethod_0(-860096211));
		((Control)textBox_3).set_Location(new Point(3, 146));
		((Control)textBox_3).set_Name(Class9.smethod_0(-860103296));
		((Control)textBox_3).set_Size(new Size(149, 22));
		((Control)textBox_3).set_TabIndex(81);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Location(new Point(0, 126));
		((Control)label_4).set_Name(Class9.smethod_0(-860097767));
		((Control)label_4).set_Size(new Size(39, 17));
		((Control)label_4).set_TabIndex(80);
		((Control)label_4).set_Text(Class9.smethod_0(-860097557));
		((Control)textBox_4).set_Location(new Point(351, 146));
		((Control)textBox_4).set_Name(Class9.smethod_0(-860103570));
		((Control)textBox_4).set_Size(new Size(150, 22));
		((Control)textBox_4).set_TabIndex(85);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Location(new Point(348, 126));
		((Control)label_5).set_Name(Class9.smethod_0(-860095739));
		((Control)label_5).set_Size(new Size(98, 17));
		((Control)label_5).set_TabIndex(84);
		((Control)label_5).set_Text(Class9.smethod_0(-860095728));
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Location(new Point(174, 1));
		((Control)label_6).set_Name(Class9.smethod_0(-860098287));
		((Control)label_6).set_Size(new Size(152, 17));
		((Control)label_6).set_TabIndex(70);
		((Control)label_6).set_Text(Class9.smethod_0(-860098077));
		((Control)textBox_5).set_Location(new Point(177, 21));
		((Control)textBox_5).set_Name(Class9.smethod_0(-860103604));
		((Control)textBox_5).set_Size(new Size(150, 22));
		((Control)textBox_5).set_TabIndex(71);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Location(new Point(174, 63));
		((Control)label_7).set_Name(Class9.smethod_0(-860098216));
		((Control)label_7).set_Size(new Size(88, 17));
		((Control)label_7).set_TabIndex(72);
		((Control)label_7).set_Text(Class9.smethod_0(-860098262));
		((Control)textBox_6).set_Location(new Point(177, 83));
		((Control)textBox_6).set_Name(Class9.smethod_0(-860103643));
		((Control)textBox_6).set_Size(new Size(150, 22));
		((Control)textBox_6).set_TabIndex(73);
		((Control)textBox_7).set_Location(new Point(351, 21));
		((Control)textBox_7).set_Name(Class9.smethod_0(-860103675));
		((Control)textBox_7).set_Size(new Size(149, 22));
		((Control)textBox_7).set_TabIndex(79);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Location(new Point(174, 126));
		((Control)label_8).set_Name(Class9.smethod_0(-860095845));
		((Control)label_8).set_Size(new Size(85, 17));
		((Control)label_8).set_TabIndex(82);
		((Control)label_8).set_Text(Class9.smethod_0(-860103449));
		((Control)textBox_8).set_Location(new Point(177, 146));
		((Control)textBox_8).set_Name(Class9.smethod_0(-860103436));
		((Control)textBox_8).set_Size(new Size(150, 22));
		((Control)textBox_8).set_TabIndex(83);
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Location(new Point(0, 189));
		((Control)label_9).set_Name(Class9.smethod_0(-860095892));
		((Control)label_9).set_Size(new Size(698, 17));
		((Control)label_9).set_TabIndex(86);
		((Control)label_9).set_Text(Class9.smethod_0(-860103510));
		((Control)label_10).set_AutoSize(true);
		((Control)label_10).set_Location(new Point(0, 214));
		((Control)label_10).set_Name(Class9.smethod_0(-860095531));
		((Control)label_10).set_Size(new Size(668, 21));
		((Control)label_10).set_TabIndex(87);
		((Control)label_10).set_Text(Class9.smethod_0(-860105914));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label_10);
		((Control)this).get_Controls().Add((Control)(object)label_9);
		((Control)this).get_Controls().Add((Control)(object)textBox_4);
		((Control)this).get_Controls().Add((Control)(object)label_5);
		((Control)this).get_Controls().Add((Control)(object)textBox_8);
		((Control)this).get_Controls().Add((Control)(object)label_8);
		((Control)this).get_Controls().Add((Control)(object)textBox_3);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)textBox_7);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)textBox_6);
		((Control)this).get_Controls().Add((Control)(object)label_7);
		((Control)this).get_Controls().Add((Control)(object)textBox_5);
		((Control)this).get_Controls().Add((Control)(object)label_6);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).set_Name(Class9.smethod_0(-860105746));
		((Control)this).set_Size(new Size(757, 253));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
