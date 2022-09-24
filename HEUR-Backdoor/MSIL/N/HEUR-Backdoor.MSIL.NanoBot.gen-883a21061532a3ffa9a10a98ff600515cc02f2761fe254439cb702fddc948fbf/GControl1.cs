using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl1 : UserControl
{
	private int int_0;

	private IContainer icontainer_0 = null;

	private TextBox textBox_0;

	private Label label_0;

	private TextBox textBox_1;

	private Label label_1;

	private Label label_2;

	private TextBox textBox_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	public ComboBox comboBox_0;

	public GControl1()
	{
		method_17();
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
		((Control)textBox_2).set_Text(string_0);
	}

	public void method_3(string string_0)
	{
		((Control)textBox_1).set_Text(string_0);
	}

	public void method_4(string string_0)
	{
		((Control)textBox_0).set_Text(string_0);
	}

	public void method_5(string string_0)
	{
		((Control)comboBox_0).set_Text(string_0);
	}

	public string method_6()
	{
		return ((Control)textBox_2).get_Text();
	}

	public string method_7()
	{
		return ((Control)textBox_1).get_Text();
	}

	public string method_8()
	{
		string text = comboBox_0.get_SelectedItem().ToString();
		string[] array = text.Split(new char[1] { ' ' });
		return array[1];
	}

	public string method_9()
	{
		string text = comboBox_0.get_SelectedItem().ToString();
		string[] array = text.Split(new char[1] { ' ' });
		return array[0];
	}

	public void method_10()
	{
		method_2(string.Empty);
		method_3(string.Empty);
		method_4(string.Empty);
	}

	public void method_11()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((Control)label_0).set_Visible(true);
		((Control)textBox_0).set_Visible(true);
		((Control)comboBox_0).set_Visible(false);
	}

	public void method_12()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(false);
		((TextBoxBase)textBox_1).set_ReadOnly(false);
		((TextBoxBase)textBox_0).set_ReadOnly(false);
	}

	public void method_13()
	{
		((Control)textBox_0).set_Visible(false);
		((Control)comboBox_0).set_Visible(true);
		((Control)label_0).set_Visible(true);
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((Control)comboBox_0).set_Text(string.Empty);
	}

	public void method_14()
	{
		((Control)textBox_0).set_Visible(false);
		((Control)comboBox_0).set_Visible(true);
		((Control)label_0).set_Visible(true);
		((TextBoxBase)textBox_2).set_ReadOnly(true);
	}

	public void method_15()
	{
		method_11();
	}

	public void method_16()
	{
		method_11();
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

	private void method_17()
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
		textBox_0 = new TextBox();
		label_0 = new Label();
		textBox_1 = new TextBox();
		label_1 = new Label();
		label_2 = new Label();
		textBox_2 = new TextBox();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		comboBox_0 = new ComboBox();
		((Control)this).SuspendLayout();
		((Control)textBox_0).set_Location(new Point(6, 79));
		((Control)textBox_0).set_Name(Class9.smethod_0(-860095633));
		((Control)textBox_0).set_Size(new Size(150, 22));
		((Control)textBox_0).set_TabIndex(45);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(3, 57));
		((Control)label_0).set_Name(Class9.smethod_0(-860095680));
		((Control)label_0).set_Size(new Size(95, 17));
		((Control)label_0).set_TabIndex(44);
		((Control)label_0).set_Text(Class9.smethod_0(-860095660));
		((Control)textBox_1).set_Location(new Point(3, 22));
		((Control)textBox_1).set_Name(Class9.smethod_0(-860095688));
		((Control)textBox_1).set_Size(new Size(150, 22));
		((Control)textBox_1).set_TabIndex(39);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(0, 2));
		((Control)label_1).set_Name(Class9.smethod_0(-860095739));
		((Control)label_1).set_Size(new Size(98, 17));
		((Control)label_1).set_TabIndex(38);
		((Control)label_1).set_Text(Class9.smethod_0(-860095728));
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(527, 108));
		((Control)label_2).set_Name(Class9.smethod_0(-860095515));
		((Control)label_2).set_Size(new Size(21, 17));
		((Control)label_2).set_TabIndex(36);
		((Control)label_2).set_Text(Class9.smethod_0(-860095497));
		((Control)label_2).set_Visible(false);
		((Control)textBox_2).set_Location(new Point(530, 128));
		((Control)textBox_2).set_Name(Class9.smethod_0(-860095538));
		((Control)textBox_2).set_Size(new Size(118, 22));
		((Control)textBox_2).set_TabIndex(37);
		((Control)textBox_2).set_Visible(false);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Location(new Point(3, 213));
		((Control)label_3).set_Name(Class9.smethod_0(-860095531));
		((Control)label_3).set_Size(new Size(375, 17));
		((Control)label_3).set_TabIndex(93);
		((Control)label_3).set_Text(Class9.smethod_0(-860095584));
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Location(new Point(3, 191));
		((Control)label_4).set_Name(Class9.smethod_0(-860095892));
		((Control)label_4).set_Size(new Size(397, 17));
		((Control)label_4).set_TabIndex(92);
		((Control)label_4).set_Text(Class9.smethod_0(-860095873));
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Location(new Point(3, 168));
		((Control)label_5).set_Name(Class9.smethod_0(-860095944));
		((Control)label_5).set_Size(new Size(363, 17));
		((Control)label_5).set_TabIndex(91);
		((Control)label_5).set_Text(Class9.smethod_0(-860095989));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(6, 77));
		((Control)comboBox_0).set_Name(Class9.smethod_0(-860095760));
		((Control)comboBox_0).set_Size(new Size(150, 24));
		((Control)comboBox_0).set_TabIndex(94);
		((Control)comboBox_0).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)comboBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)label_5);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).set_Name(Class9.smethod_0(-860095827));
		((Control)this).set_Size(new Size(416, 241));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
