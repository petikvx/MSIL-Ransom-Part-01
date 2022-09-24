using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl2 : UserControl
{
	private int int_0;

	private IContainer icontainer_0 = null;

	private TextBox textBox_0;

	private Label label_0;

	private TextBox textBox_1;

	private Label label_1;

	private TextBox textBox_2;

	private Label label_2;

	private TextBox textBox_3;

	private Label label_3;

	private TextBox textBox_4;

	private Label label_4;

	private TextBox textBox_5;

	private Label label_5;

	private TextBox textBox_6;

	private Label label_6;

	private TextBox textBox_7;

	private Label label_7;

	private TextBox textBox_8;

	private Label label_8;

	private TextBox textBox_9;

	private Label label_9;

	public ComboBox comboBox_0;

	public GControl2()
	{
		method_32();
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
		((Control)textBox_9).set_Text(string_0);
	}

	public void method_4(string string_0)
	{
		((Control)textBox_8).set_Text(string_0);
	}

	public void method_5(string string_0)
	{
		((Control)textBox_3).set_Text(string_0);
	}

	public void method_6(string string_0)
	{
		((Control)textBox_1).set_Text(string_0);
	}

	public void method_7(string string_0)
	{
		((Control)textBox_4).set_Text(string_0);
	}

	public void method_8(string string_0)
	{
		((Control)textBox_2).set_Text(string_0);
	}

	public void method_9(string string_0)
	{
		((Control)comboBox_0).set_Text(string_0);
	}

	public string method_10()
	{
		string text = comboBox_0.get_SelectedItem().ToString();
		string[] array = text.Split(new char[1] { ' ' });
		return array[0];
	}

	public void method_11(string string_0)
	{
		((Control)textBox_5).set_Text(string_0);
	}

	public void method_12(string string_0)
	{
		((Control)textBox_7).set_Text(string_0);
	}

	public void method_13(string string_0)
	{
		((Control)textBox_6).set_Text(string_0);
	}

	public void method_14(string string_0)
	{
		((Control)textBox_0).set_Text(string_0);
	}

	public string method_15()
	{
		if (((Control)textBox_9).get_Text() == string.Empty)
		{
			return null;
		}
		return ((Control)textBox_9).get_Text();
	}

	public string method_16()
	{
		return ((Control)textBox_8).get_Text();
	}

	public string method_17()
	{
		return ((Control)textBox_3).get_Text();
	}

	public string method_18()
	{
		return ((Control)textBox_1).get_Text();
	}

	public string method_19()
	{
		if (((Control)textBox_4).get_Text() == string.Empty)
		{
			return DateTime.Today.Day + Class9.smethod_0(-860096477) + DateTime.Today.Month + Class9.smethod_0(-860096477) + DateTime.Today.Year;
		}
		return ((Control)textBox_4).get_Text();
	}

	public string method_20()
	{
		string text = comboBox_0.get_SelectedItem().ToString();
		string[] array = text.Split(new char[1] { ' ' });
		return array[1];
	}

	public string method_21()
	{
		if (((Control)textBox_5).get_Text() == string.Empty)
		{
			return Class9.smethod_0(-860094592);
		}
		return ((Control)textBox_5).get_Text();
	}

	public string method_22()
	{
		if (((Control)textBox_7).get_Text() == string.Empty)
		{
			return Class9.smethod_0(-860094592);
		}
		return ((Control)textBox_7).get_Text();
	}

	public string method_23()
	{
		if (((Control)textBox_6).get_Text() == string.Empty)
		{
			return Class9.smethod_0(-860097752);
		}
		int num = int.Parse(((Control)textBox_6).get_Text());
		if (num < 801)
		{
			return Class9.smethod_0(-860097752);
		}
		if (num > 1799)
		{
			return Class9.smethod_0(-860097754);
		}
		return ((Control)textBox_6).get_Text();
	}

	public string method_24()
	{
		return ((Control)textBox_0).get_Text();
	}

	public void method_25()
	{
		method_3(string.Empty);
		method_4(string.Empty);
		method_5(string.Empty);
		method_6(Class9.smethod_0(-860096477));
		method_7(string.Empty);
		method_8(string.Empty);
		method_11(string.Empty);
		method_12(string.Empty);
		method_13(string.Empty);
		method_14(string.Empty);
		method_9(string.Empty);
	}

	public void method_26()
	{
		((TextBoxBase)textBox_9).set_ReadOnly(true);
		((TextBoxBase)textBox_8).set_ReadOnly(true);
		((TextBoxBase)textBox_3).set_ReadOnly(true);
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((TextBoxBase)textBox_4).set_ReadOnly(true);
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_5).set_ReadOnly(true);
		((TextBoxBase)textBox_7).set_ReadOnly(true);
		((TextBoxBase)textBox_6).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((Control)comboBox_0).set_Visible(false);
	}

	public void method_27()
	{
		((TextBoxBase)textBox_9).set_ReadOnly(false);
		((TextBoxBase)textBox_8).set_ReadOnly(false);
		((TextBoxBase)textBox_3).set_ReadOnly(false);
		((TextBoxBase)textBox_1).set_ReadOnly(false);
		((TextBoxBase)textBox_4).set_ReadOnly(false);
		((TextBoxBase)textBox_5).set_ReadOnly(false);
		((TextBoxBase)textBox_7).set_ReadOnly(false);
		((TextBoxBase)textBox_6).set_ReadOnly(false);
		((TextBoxBase)textBox_0).set_ReadOnly(false);
	}

	public void method_28()
	{
		((Control)textBox_2).set_Visible(false);
		((TextBoxBase)textBox_8).set_ReadOnly(true);
		method_4(method_0().ToString());
		((Control)comboBox_0).set_Visible(true);
		((Control)comboBox_0).set_Text(string.Empty);
	}

	public void method_29()
	{
		((Control)textBox_2).set_Visible(false);
		((Control)comboBox_0).set_Visible(true);
		((TextBoxBase)textBox_9).set_ReadOnly(true);
		((TextBoxBase)textBox_8).set_ReadOnly(true);
	}

	public void method_30()
	{
		method_26();
		((Control)textBox_2).set_Visible(true);
	}

	public void method_31()
	{
		method_26();
		((TextBoxBase)textBox_5).set_ReadOnly(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_32()
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
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		textBox_0 = new TextBox();
		label_0 = new Label();
		textBox_1 = new TextBox();
		label_1 = new Label();
		textBox_2 = new TextBox();
		label_2 = new Label();
		textBox_3 = new TextBox();
		label_3 = new Label();
		textBox_4 = new TextBox();
		label_4 = new Label();
		textBox_5 = new TextBox();
		label_5 = new Label();
		textBox_6 = new TextBox();
		label_6 = new Label();
		textBox_7 = new TextBox();
		label_7 = new Label();
		textBox_8 = new TextBox();
		label_8 = new Label();
		textBox_9 = new TextBox();
		label_9 = new Label();
		comboBox_0 = new ComboBox();
		((Control)this).SuspendLayout();
		((Control)textBox_0).set_Location(new Point(349, 153));
		((Control)textBox_0).set_Name(Class9.smethod_0(-860097741));
		((Control)textBox_0).set_Size(new Size(149, 22));
		((Control)textBox_0).set_TabIndex(73);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(346, 133));
		((Control)label_0).set_Name(Class9.smethod_0(-860097767));
		((Control)label_0).set_Size(new Size(39, 17));
		((Control)label_0).set_TabIndex(72);
		((Control)label_0).set_Text(Class9.smethod_0(-860097557));
		((Control)textBox_1).set_Location(new Point(7, 153));
		((Control)textBox_1).set_Name(Class9.smethod_0(-860097568));
		((Control)textBox_1).set_Size(new Size(149, 22));
		((Control)textBox_1).set_TabIndex(71);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(4, 133));
		((Control)label_1).set_Name(Class9.smethod_0(-860097595));
		((Control)label_1).set_Size(new Size(110, 17));
		((Control)label_1).set_TabIndex(70);
		((Control)label_1).set_Text(Class9.smethod_0(-860097577));
		((Control)textBox_2).set_Location(new Point(6, 213));
		((Control)textBox_2).set_Name(Class9.smethod_0(-860097606));
		((Control)textBox_2).set_Size(new Size(258, 22));
		((Control)textBox_2).set_TabIndex(69);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(3, 193));
		((Control)label_2).set_Name(Class9.smethod_0(-860097660));
		((Control)label_2).set_Size(new Size(91, 17));
		((Control)label_2).set_TabIndex(68);
		((Control)label_2).set_Text(Class9.smethod_0(-860097944));
		((Control)textBox_3).set_Location(new Point(349, 26));
		((Control)textBox_3).set_Name(Class9.smethod_0(-860097923));
		((Control)textBox_3).set_Size(new Size(150, 22));
		((Control)textBox_3).set_TabIndex(67);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Location(new Point(346, 6));
		((Control)label_3).set_Name(Class9.smethod_0(-860097953));
		((Control)label_3).set_Size(new Size(64, 17));
		((Control)label_3).set_TabIndex(66);
		((Control)label_3).set_Text(Class9.smethod_0(-860096183));
		((Control)textBox_4).set_Location(new Point(177, 153));
		((Control)textBox_4).set_Name(Class9.smethod_0(-860098007));
		((Control)textBox_4).set_Size(new Size(150, 22));
		((Control)textBox_4).set_TabIndex(65);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Location(new Point(174, 133));
		((Control)label_4).set_Name(Class9.smethod_0(-860098040));
		((Control)label_4).set_Size(new Size(111, 17));
		((Control)label_4).set_TabIndex(64);
		((Control)label_4).set_Text(Class9.smethod_0(-860098022));
		((Control)textBox_5).set_Location(new Point(7, 88));
		((Control)textBox_5).set_Name(Class9.smethod_0(-860097812));
		((Control)textBox_5).set_Size(new Size(149, 22));
		((Control)textBox_5).set_TabIndex(63);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Location(new Point(4, 68));
		((Control)label_5).set_Name(Class9.smethod_0(-860097854));
		((Control)label_5).set_Size(new Size(101, 17));
		((Control)label_5).set_TabIndex(62);
		((Control)label_5).set_Text(Class9.smethod_0(-860097828));
		((Control)textBox_6).set_Location(new Point(349, 88));
		((Control)textBox_6).set_Name(Class9.smethod_0(-860097888));
		((Control)textBox_6).set_Size(new Size(149, 22));
		((Control)textBox_6).set_TabIndex(61);
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Location(new Point(346, 68));
		((Control)label_6).set_Name(Class9.smethod_0(-860097917));
		((Control)label_6).set_Size(new Size(74, 17));
		((Control)label_6).set_TabIndex(60);
		((Control)label_6).set_Text(Class9.smethod_0(-860097891));
		((Control)textBox_7).set_Location(new Point(177, 88));
		((Control)textBox_7).set_Name(Class9.smethod_0(-860098184));
		((Control)textBox_7).set_Size(new Size(150, 22));
		((Control)textBox_7).set_TabIndex(59);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Location(new Point(174, 68));
		((Control)label_7).set_Name(Class9.smethod_0(-860098216));
		((Control)label_7).set_Size(new Size(88, 17));
		((Control)label_7).set_TabIndex(58);
		((Control)label_7).set_Text(Class9.smethod_0(-860098262));
		((Control)textBox_8).set_Location(new Point(177, 26));
		((Control)textBox_8).set_Name(Class9.smethod_0(-860098248));
		((Control)textBox_8).set_Size(new Size(150, 22));
		((Control)textBox_8).set_TabIndex(57);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Location(new Point(174, 6));
		((Control)label_8).set_Name(Class9.smethod_0(-860098287));
		((Control)label_8).set_Size(new Size(152, 17));
		((Control)label_8).set_TabIndex(56);
		((Control)label_8).set_Text(Class9.smethod_0(-860098077));
		((Control)textBox_9).set_Location(new Point(7, 26));
		((Control)textBox_9).set_Name(Class9.smethod_0(-860098097));
		((Control)textBox_9).set_Size(new Size(149, 22));
		((Control)textBox_9).set_TabIndex(55);
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Location(new Point(4, 6));
		((Control)label_9).set_Name(Class9.smethod_0(-860098090));
		((Control)label_9).set_Size(new Size(29, 17));
		((Control)label_9).set_TabIndex(54);
		((Control)label_9).set_Text(Class9.smethod_0(-860096211));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(8, 213));
		((Control)comboBox_0).set_Name(Class9.smethod_0(-860098144));
		((Control)comboBox_0).set_Size(new Size(258, 24));
		((Control)comboBox_0).set_TabIndex(76);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)comboBox_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_3);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)textBox_4);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)textBox_5);
		((Control)this).get_Controls().Add((Control)(object)label_5);
		((Control)this).get_Controls().Add((Control)(object)textBox_6);
		((Control)this).get_Controls().Add((Control)(object)label_6);
		((Control)this).get_Controls().Add((Control)(object)textBox_7);
		((Control)this).get_Controls().Add((Control)(object)label_7);
		((Control)this).get_Controls().Add((Control)(object)textBox_8);
		((Control)this).get_Controls().Add((Control)(object)label_8);
		((Control)this).get_Controls().Add((Control)(object)textBox_9);
		((Control)this).get_Controls().Add((Control)(object)label_9);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).set_Name(Class9.smethod_0(-860098124));
		((Control)this).set_Size(new Size(534, 252));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
