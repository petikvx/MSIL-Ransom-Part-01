using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl3 : UserControl
{
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

	public GControl3()
	{
		method_15();
	}

	public void method_0(string string_0)
	{
		((Control)textBox_3).set_Text(string_0);
	}

	public void method_1(string string_0)
	{
		((Control)textBox_2).set_Text(string_0);
	}

	public void method_2(string string_0)
	{
		((Control)textBox_0).set_Text(string_0);
	}

	public void method_3(string string_0)
	{
		if (string_0 == string.Empty)
		{
			((Control)textBox_1).set_Text(Class9.smethod_0(-860094592));
		}
		else if (string_0 == Class9.smethod_0(-860094592))
		{
			((Control)textBox_1).set_Text(Class9.smethod_0(-860094592));
		}
		else if (string_0 == Class9.smethod_0(-860103157))
		{
			((Control)textBox_1).set_Text(Class9.smethod_0(-860094592));
		}
		else
		{
			((Control)textBox_1).set_Text(string_0);
		}
	}

	public void method_4(string string_0)
	{
		((Control)textBox_4).set_Text(string_0);
	}

	public string method_5()
	{
		if (((Control)textBox_3).get_Text() == string.Empty)
		{
			return null;
		}
		return ((Control)textBox_3).get_Text();
	}

	public string method_6()
	{
		if (((Control)textBox_2).get_Text() == string.Empty)
		{
			return Class9.smethod_0(-860094592);
		}
		return ((Control)textBox_2).get_Text();
	}

	public string method_7()
	{
		if (((Control)textBox_0).get_Text() == string.Empty)
		{
			return Class9.smethod_0(-860094592);
		}
		return ((Control)textBox_0).get_Text();
	}

	public string method_8()
	{
		if (((Control)textBox_1).get_Text().Equals(Class9.smethod_0(-860094592)))
		{
			return Class9.smethod_0(-860103157);
		}
		if (((Control)textBox_1).get_Text().Equals(string.Empty))
		{
			return Class9.smethod_0(-860103157);
		}
		return ((Control)textBox_1).get_Text();
	}

	public string method_9()
	{
		return ((Control)textBox_4).get_Text();
	}

	public void method_10()
	{
		method_0(string.Empty);
		method_1(string.Empty);
		method_2(string.Empty);
		method_3(Class9.smethod_0(-860096477));
		method_4(string.Empty);
	}

	public void method_11()
	{
		((TextBoxBase)textBox_3).set_ReadOnly(true);
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((TextBoxBase)textBox_4).set_ReadOnly(true);
	}

	public void method_12()
	{
		((TextBoxBase)textBox_3).set_ReadOnly(false);
		((TextBoxBase)textBox_2).set_ReadOnly(false);
		((TextBoxBase)textBox_0).set_ReadOnly(false);
		((TextBoxBase)textBox_1).set_ReadOnly(false);
		((TextBoxBase)textBox_4).set_ReadOnly(false);
	}

	public void method_13()
	{
		((TextBoxBase)textBox_3).set_ReadOnly(true);
	}

	public void method_14()
	{
		method_11();
		((TextBoxBase)textBox_3).set_ReadOnly(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_15()
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
		textBox_2 = new TextBox();
		label_2 = new Label();
		textBox_3 = new TextBox();
		label_3 = new Label();
		textBox_4 = new TextBox();
		label_4 = new Label();
		((Control)this).SuspendLayout();
		((Control)textBox_0).set_Location(new Point(7, 84));
		((Control)textBox_0).set_Name(Class9.smethod_0(-860103165));
		((Control)textBox_0).set_Size(new Size(300, 22));
		((Control)textBox_0).set_TabIndex(53);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(4, 64));
		((Control)label_0).set_Name(Class9.smethod_0(-860095944));
		((Control)label_0).set_Size(new Size(137, 17));
		((Control)label_0).set_TabIndex(52);
		((Control)label_0).set_Text(Class9.smethod_0(-860102936));
		((Control)textBox_1).set_Location(new Point(7, 143));
		((Control)textBox_1).set_Name(Class9.smethod_0(-860102921));
		((Control)textBox_1).set_Size(new Size(134, 22));
		((Control)textBox_1).set_TabIndex(51);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(4, 123));
		((Control)label_1).set_Name(Class9.smethod_0(-860095892));
		((Control)label_1).set_Size(new Size(102, 17));
		((Control)label_1).set_TabIndex(50);
		((Control)label_1).set_Text(Class9.smethod_0(-860102946));
		((Control)textBox_2).set_Location(new Point(170, 24));
		((Control)textBox_2).set_Name(Class9.smethod_0(-860103006));
		((Control)textBox_2).set_Size(new Size(137, 22));
		((Control)textBox_2).set_TabIndex(49);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(167, 4));
		((Control)label_2).set_Name(Class9.smethod_0(-860095739));
		((Control)label_2).set_Size(new Size(55, 17));
		((Control)label_2).set_TabIndex(48);
		((Control)label_2).set_Text(Class9.smethod_0(-860103025));
		((Control)textBox_3).set_Location(new Point(7, 24));
		((Control)textBox_3).set_Name(Class9.smethod_0(-860103015));
		((Control)textBox_3).set_Size(new Size(134, 22));
		((Control)textBox_3).set_TabIndex(47);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Location(new Point(4, 4));
		((Control)label_3).set_Name(Class9.smethod_0(-860095845));
		((Control)label_3).set_Size(new Size(29, 17));
		((Control)label_3).set_TabIndex(46);
		((Control)label_3).set_Text(Class9.smethod_0(-860096211));
		((Control)textBox_4).set_Location(new Point(170, 143));
		((Control)textBox_4).set_Name(Class9.smethod_0(-860103326));
		((Control)textBox_4).set_Size(new Size(137, 22));
		((Control)textBox_4).set_TabIndex(55);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Location(new Point(174, 123));
		((Control)label_4).set_Name(Class9.smethod_0(-860095531));
		((Control)label_4).set_Size(new Size(115, 17));
		((Control)label_4).set_TabIndex(54);
		((Control)label_4).set_Text(Class9.smethod_0(-860103351));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)textBox_4);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)textBox_3);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).set_Name(Class9.smethod_0(-860103390));
		((Control)this).set_Size(new Size(327, 187));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
