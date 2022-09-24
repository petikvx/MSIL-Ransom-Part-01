using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl5 : UserControl
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

	public GControl5()
	{
		method_18();
	}

	public string method_0()
	{
		return ((Control)textBox_2).get_Text();
	}

	public string method_1()
	{
		if (((Control)textBox_0).get_Text() == string.Empty)
		{
			return null;
		}
		return ((Control)textBox_0).get_Text();
	}

	public string method_2()
	{
		if (((Control)textBox_4).get_Text() == string.Empty)
		{
			return DateTime.Today.Day + Class9.smethod_0(-860096477) + DateTime.Today.Month + Class9.smethod_0(-860096477) + DateTime.Today.Year;
		}
		return ((Control)textBox_4).get_Text();
	}

	public string method_3()
	{
		if (((Control)textBox_3).get_Text() == string.Empty)
		{
			return DateTime.Today.Day + Class9.smethod_0(-860096477) + DateTime.Today.Month + Class9.smethod_0(-860096477) + DateTime.Today.Year;
		}
		return ((Control)textBox_3).get_Text();
	}

	public string method_4()
	{
		return Class9.smethod_0(-860096453);
	}

	public string method_5(string string_0)
	{
		return string_0 + Class9.smethod_0(-860096501);
	}

	public void method_6(string string_0)
	{
		((Control)textBox_2).set_Text(string_0);
	}

	public void method_7(string string_0)
	{
		((Control)textBox_0).set_Text(string_0);
	}

	public void method_8(string string_0)
	{
		((Control)textBox_1).set_Text(string_0);
	}

	public void method_9(string string_0)
	{
		((Control)textBox_4).set_Text(string_0);
	}

	public void method_10(string string_0)
	{
		((Control)textBox_3).set_Text(string_0);
	}

	public void method_11()
	{
		method_6(string.Empty);
		method_7(string.Empty);
		method_8(string.Empty);
		method_9(string.Empty);
		method_10(string.Empty);
	}

	public void method_12()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((TextBoxBase)textBox_4).set_ReadOnly(true);
		((TextBoxBase)textBox_3).set_ReadOnly(true);
	}

	public void method_13()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(false);
		((TextBoxBase)textBox_0).set_ReadOnly(false);
		((TextBoxBase)textBox_1).set_ReadOnly(false);
		((TextBoxBase)textBox_4).set_ReadOnly(false);
		((TextBoxBase)textBox_3).set_ReadOnly(false);
	}

	public void method_14()
	{
		((Control)textBox_1).set_Visible(true);
		((Control)textBox_1).set_Text(Class9.smethod_0(-860096453));
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((Control)label_1).set_Visible(true);
	}

	public void method_15()
	{
		((Control)textBox_1).set_Visible(true);
		((Control)textBox_1).set_Text(Class9.smethod_0(-860096453));
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((Control)label_1).set_Visible(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
	}

	public void method_16()
	{
		((Control)textBox_1).set_Visible(true);
		((Control)label_1).set_Visible(true);
	}

	public void method_17()
	{
		method_12();
		((TextBoxBase)textBox_0).set_ReadOnly(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_18()
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
		((Control)textBox_0).set_Location(new Point(5, 22));
		((Control)textBox_0).set_Name(Class9.smethod_0(-860096509));
		((Control)textBox_0).set_Size(new Size(328, 22));
		((Control)textBox_0).set_TabIndex(49);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(2, 2));
		((Control)label_0).set_Name(Class9.smethod_0(-860095845));
		((Control)label_0).set_Size(new Size(45, 17));
		((Control)label_0).set_TabIndex(48);
		((Control)label_0).set_Text(Class9.smethod_0(-860095850));
		((Control)textBox_1).set_Location(new Point(179, 135));
		((Control)textBox_1).set_Name(Class9.smethod_0(-860096490));
		((Control)textBox_1).set_Size(new Size(154, 22));
		((Control)textBox_1).set_TabIndex(51);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(176, 115));
		((Control)label_1).set_Name(Class9.smethod_0(-860096271));
		((Control)label_1).set_Size(new Size(98, 17));
		((Control)label_1).set_TabIndex(50);
		((Control)label_1).set_Text(Class9.smethod_0(-860095728));
		((Control)textBox_2).set_Location(new Point(5, 135));
		((Control)textBox_2).set_Name(Class9.smethod_0(-860096314));
		((Control)textBox_2).set_Size(new Size(154, 22));
		((Control)textBox_2).set_TabIndex(53);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(2, 115));
		((Control)label_2).set_Name(Class9.smethod_0(-860095892));
		((Control)label_2).set_Size(new Size(36, 17));
		((Control)label_2).set_TabIndex(52);
		((Control)label_2).set_Text(Class9.smethod_0(-860096343));
		((Control)textBox_3).set_Location(new Point(179, 81));
		((Control)textBox_3).set_Name(Class9.smethod_0(-860096346));
		((Control)textBox_3).set_Size(new Size(154, 22));
		((Control)textBox_3).set_TabIndex(55);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Location(new Point(176, 61));
		((Control)label_3).set_Name(Class9.smethod_0(-860095531));
		((Control)label_3).set_Size(new Size(80, 17));
		((Control)label_3).set_TabIndex(54);
		((Control)label_3).set_Text(Class9.smethod_0(-860096374));
		((Control)textBox_4).set_Location(new Point(5, 81));
		((Control)textBox_4).set_Name(Class9.smethod_0(-860096360));
		((Control)textBox_4).set_Size(new Size(154, 22));
		((Control)textBox_4).set_TabIndex(57);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Location(new Point(2, 61));
		((Control)label_4).set_Name(Class9.smethod_0(-860095944));
		((Control)label_4).set_Size(new Size(94, 17));
		((Control)label_4).set_TabIndex(56);
		((Control)label_4).set_Text(Class9.smethod_0(-860094623));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)textBox_4);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)textBox_3);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).set_Location(new Point(210, 0));
		((Control)this).set_Name(Class9.smethod_0(-860094604));
		((Control)this).set_Size(new Size(348, 168));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
