using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl0 : UserControl
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

	private Label label_8;

	private Label label_9;

	private TextBox textBox_8;

	private TextBox textBox_9;

	private Label label_10;

	public ListBox listBox_0;

	public ComboBox comboBox_0;

	private Label label_11;

	private Label label_12;

	public GControl0()
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

	public void method_2(string string_0)
	{
		((Control)textBox_6).set_Text(string_0);
	}

	public string method_3()
	{
		return ((Control)textBox_6).get_Text();
	}

	public void method_4(string string_0)
	{
		((Control)textBox_7).set_Text(string_0);
	}

	public string method_5()
	{
		return ((Control)textBox_7).get_Text();
	}

	public void method_6(string string_0)
	{
		((Control)textBox_3).set_Text(string_0);
	}

	public string method_7()
	{
		return ((Control)textBox_3).get_Text();
	}

	public void method_8(string string_0)
	{
		((Control)textBox_4).set_Text(string_0);
	}

	public string method_9()
	{
		return ((Control)textBox_4).get_Text();
	}

	public void method_10(string string_0)
	{
		((Control)textBox_5).set_Text(string_0);
	}

	public string method_11()
	{
		return ((Control)textBox_5).get_Text();
	}

	public void method_12(string string_0)
	{
		((Control)textBox_1).set_Text(string_0);
	}

	public string method_13()
	{
		string text = comboBox_0.get_SelectedItem().ToString();
		string[] array = text.Split(new char[1] { ' ' });
		return array[1];
	}

	public void method_14(string string_0)
	{
		((Control)comboBox_0).set_Text(string_0);
	}

	public string method_15()
	{
		string text = comboBox_0.get_SelectedItem().ToString();
		string[] array = text.Split(new char[1] { ' ' });
		return array[0];
	}

	public void method_16(string string_0)
	{
		((Control)textBox_2).set_Text(string_0);
	}

	public string method_17()
	{
		return ((Control)textBox_2).get_Text();
	}

	public void method_18(string string_0)
	{
		((Control)textBox_0).set_Text(string_0);
	}

	public void method_19(string string_0)
	{
		((Control)textBox_9).set_Text(string_0);
	}

	public string method_20()
	{
		return ((Control)textBox_9).get_Text();
	}

	public void method_21()
	{
		method_2(string.Empty);
		method_4(string.Empty);
		method_6(string.Empty);
		method_8(string.Empty);
		method_12(string.Empty);
		method_10(string.Empty);
		method_16(string.Empty);
		method_18(string.Empty);
		method_19(string.Empty);
		listBox_0.get_Items().Clear();
	}

	public void method_22()
	{
		((TextBoxBase)textBox_6).set_ReadOnly(true);
		((TextBoxBase)textBox_7).set_ReadOnly(true);
		((TextBoxBase)textBox_3).set_ReadOnly(true);
		((TextBoxBase)textBox_4).set_ReadOnly(true);
		((TextBoxBase)textBox_5).set_ReadOnly(true);
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((TextBoxBase)textBox_9).set_ReadOnly(true);
	}

	public void method_23()
	{
		((TextBoxBase)textBox_6).set_ReadOnly(false);
		((TextBoxBase)textBox_7).set_ReadOnly(false);
		((TextBoxBase)textBox_3).set_ReadOnly(false);
		((TextBoxBase)textBox_4).set_ReadOnly(false);
		((TextBoxBase)textBox_5).set_ReadOnly(false);
		((TextBoxBase)textBox_1).set_ReadOnly(false);
		((TextBoxBase)textBox_2).set_ReadOnly(false);
		((TextBoxBase)textBox_9).set_ReadOnly(false);
	}

	public void method_24()
	{
		((Control)textBox_1).set_Visible(false);
		((Control)comboBox_0).set_Visible(true);
		((Control)textBox_0).set_Visible(true);
		((Control)label_0).set_Visible(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((Control)textBox_9).set_Visible(true);
		((TextBoxBase)textBox_9).set_ReadOnly(true);
		((Control)label_10).set_Visible(true);
		((TextBoxBase)textBox_4).set_ReadOnly(true);
	}

	public void method_25()
	{
		((Control)textBox_1).set_Visible(false);
		((TextBoxBase)textBox_4).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((Control)label_0).set_Visible(true);
		((Control)comboBox_0).set_Visible(true);
	}

	public void method_26()
	{
		((Control)comboBox_0).set_Visible(false);
		((Control)textBox_1).set_Visible(true);
		((Control)textBox_0).set_Visible(true);
		((Control)label_0).set_Visible(true);
	}

	public void method_27()
	{
		method_22();
		((TextBoxBase)textBox_4).set_ReadOnly(false);
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
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
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
		listBox_0 = new ListBox();
		label_8 = new Label();
		label_9 = new Label();
		textBox_8 = new TextBox();
		textBox_9 = new TextBox();
		label_10 = new Label();
		comboBox_0 = new ComboBox();
		label_11 = new Label();
		label_12 = new Label();
		((Control)this).SuspendLayout();
		((Control)textBox_0).set_Location(new Point(190, 137));
		((Control)textBox_0).set_Name(Class9.smethod_0(-860104279));
		((Control)textBox_0).set_Size(new Size(236, 22));
		((Control)textBox_0).set_TabIndex(71);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(187, 117));
		((Control)label_0).set_Name(Class9.smethod_0(-860104265));
		((Control)label_0).set_Size(new Size(118, 17));
		((Control)label_0).set_TabIndex(70);
		((Control)label_0).set_Text(Class9.smethod_0(-860104296));
		((Control)textBox_1).set_Location(new Point(6, 80));
		((Control)textBox_1).set_Name(Class9.smethod_0(-860104606));
		((Control)textBox_1).set_Size(new Size(222, 22));
		((Control)textBox_1).set_TabIndex(69);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(3, 60));
		((Control)label_1).set_Name(Class9.smethod_0(-860104632));
		((Control)label_1).set_Size(new Size(124, 17));
		((Control)label_1).set_TabIndex(68);
		((Control)label_1).set_Text(Class9.smethod_0(-860104623));
		((Control)textBox_2).set_Location(new Point(326, 26));
		((Control)textBox_2).set_Name(Class9.smethod_0(-860104645));
		((Control)textBox_2).set_Size(new Size(100, 22));
		((Control)textBox_2).set_TabIndex(67);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(323, 6));
		((Control)label_2).set_Name(Class9.smethod_0(-860094723));
		((Control)label_2).set_Size(new Size(38, 17));
		((Control)label_2).set_TabIndex(66);
		((Control)label_2).set_Text(Class9.smethod_0(-860101683));
		((Control)textBox_3).set_Location(new Point(448, 26));
		((Control)textBox_3).set_Name(Class9.smethod_0(-860104696));
		((Control)textBox_3).set_Size(new Size(147, 22));
		((Control)textBox_3).set_TabIndex(65);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Location(new Point(445, 6));
		((Control)label_3).set_Name(Class9.smethod_0(-860096083));
		((Control)label_3).set_Size(new Size(72, 17));
		((Control)label_3).set_TabIndex(64);
		((Control)label_3).set_Text(Class9.smethod_0(-860104676));
		((Control)textBox_4).set_Location(new Point(190, 26));
		((Control)textBox_4).set_Name(Class9.smethod_0(-860104453));
		((Control)textBox_4).set_Size(new Size(116, 22));
		((Control)textBox_4).set_TabIndex(63);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Location(new Point(187, 6));
		((Control)label_4).set_Name(Class9.smethod_0(-860095944));
		((Control)label_4).set_Size(new Size(104, 17));
		((Control)label_4).set_TabIndex(62);
		((Control)label_4).set_Text(Class9.smethod_0(-860104499));
		((Control)textBox_5).set_Location(new Point(448, 80));
		((Control)textBox_5).set_Name(Class9.smethod_0(-860104496));
		((Control)textBox_5).set_Size(new Size(147, 22));
		((Control)textBox_5).set_TabIndex(61);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Location(new Point(445, 60));
		((Control)label_5).set_Name(Class9.smethod_0(-860095531));
		((Control)label_5).set_Size(new Size(36, 17));
		((Control)label_5).set_TabIndex(60);
		((Control)label_5).set_Text(Class9.smethod_0(-860096343));
		((Control)textBox_6).set_Location(new Point(248, 80));
		((Control)textBox_6).set_Name(Class9.smethod_0(-860104539));
		((Control)textBox_6).set_Size(new Size(178, 22));
		((Control)textBox_6).set_TabIndex(59);
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Location(new Point(245, 60));
		((Control)label_6).set_Name(Class9.smethod_0(-860095892));
		((Control)label_6).set_Size(new Size(64, 17));
		((Control)label_6).set_TabIndex(58);
		((Control)label_6).set_Text(Class9.smethod_0(-860096183));
		((Control)textBox_7).set_Location(new Point(6, 26));
		((Control)textBox_7).set_Name(Class9.smethod_0(-860104562));
		((Control)textBox_7).set_Size(new Size(162, 22));
		((Control)textBox_7).set_TabIndex(57);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Location(new Point(3, 6));
		((Control)label_7).set_Name(Class9.smethod_0(-860095739));
		((Control)label_7).set_Size(new Size(91, 17));
		((Control)label_7).set_TabIndex(56);
		((Control)label_7).set_Text(Class9.smethod_0(-860097944));
		((ListControl)listBox_0).set_FormattingEnabled(true);
		listBox_0.set_ItemHeight(16);
		((Control)listBox_0).set_Location(new Point(661, 26));
		((Control)listBox_0).set_Name(Class9.smethod_0(-860096201));
		((Control)listBox_0).set_Size(new Size(207, 180));
		((Control)listBox_0).set_TabIndex(72);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Location(new Point(658, 6));
		((Control)label_8).set_Name(Class9.smethod_0(-860097767));
		((Control)label_8).set_Size(new Size(89, 17));
		((Control)label_8).set_TabIndex(73);
		((Control)label_8).set_Text(Class9.smethod_0(-860104557));
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Location(new Point(1039, 92));
		((Control)label_9).set_Name(Class9.smethod_0(-860095845));
		((Control)label_9).set_Size(new Size(67, 17));
		((Control)label_9).set_TabIndex(54);
		((Control)label_9).set_Text(Class9.smethod_0(-860102816));
		((Control)label_9).set_Visible(false);
		((Control)textBox_8).set_Location(new Point(1042, 112));
		((Control)textBox_8).set_Name(Class9.smethod_0(-860102800));
		((Control)textBox_8).set_Size(new Size(118, 22));
		((Control)textBox_8).set_TabIndex(55);
		((Control)textBox_8).set_Visible(false);
		((Control)textBox_9).set_Location(new Point(6, 137));
		((Control)textBox_9).set_Name(Class9.smethod_0(-860102823));
		((Control)textBox_9).set_Size(new Size(162, 22));
		((Control)textBox_9).set_TabIndex(77);
		((Control)label_10).set_AutoSize(true);
		((Control)label_10).set_Location(new Point(3, 118));
		((Control)label_10).set_Name(Class9.smethod_0(-860102875));
		((Control)label_10).set_Size(new Size(131, 17));
		((Control)label_10).set_TabIndex(76);
		((Control)label_10).set_Text(Class9.smethod_0(-860102900));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(6, 78));
		((Control)comboBox_0).set_Name(Class9.smethod_0(-860102892));
		((Control)comboBox_0).set_Size(new Size(222, 24));
		((Control)comboBox_0).set_TabIndex(78);
		((Control)comboBox_0).set_Visible(false);
		((Control)label_11).set_AutoSize(true);
		((Control)label_11).set_Location(new Point(3, 216));
		((Control)label_11).set_Name(Class9.smethod_0(-860102659));
		((Control)label_11).set_Size(new Size(480, 17));
		((Control)label_11).set_TabIndex(89);
		((Control)label_11).set_Text(Class9.smethod_0(-860102712));
		((Control)label_12).set_AutoSize(true);
		((Control)label_12).set_Location(new Point(3, 189));
		((Control)label_12).set_Name(Class9.smethod_0(-860094945));
		((Control)label_12).set_Size(new Size(634, 17));
		((Control)label_12).set_TabIndex(90);
		((Control)label_12).set_Text(Class9.smethod_0(-860102758));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label_12);
		((Control)this).get_Controls().Add((Control)(object)label_11);
		((Control)this).get_Controls().Add((Control)(object)comboBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_8);
		((Control)this).get_Controls().Add((Control)(object)listBox_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)label_2);
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
		((Control)this).get_Controls().Add((Control)(object)label_9);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_9);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)label_10);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).set_Name(Class9.smethod_0(-860096197));
		((Control)this).set_Size(new Size(891, 259));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
