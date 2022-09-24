using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl4 : UserControl
{
	private IContainer icontainer_0 = null;

	private TextBox textBox_0;

	private Label label_0;

	private TextBox textBox_1;

	private Label label_1;

	private TextBox textBox_2;

	private Label label_2;

	private Label label_3;

	public ListBox listBox_0;

	private Label label_4;

	private Label label_5;

	public GControl4()
	{
		method_11();
	}

	public void method_0(string string_0)
	{
		((Control)textBox_2).set_Text(string_0);
	}

	public string method_1()
	{
		return ((Control)textBox_2).get_Text();
	}

	public void method_2(string string_0)
	{
		((Control)textBox_0).set_Text(string_0);
	}

	public string method_3()
	{
		return ((Control)textBox_0).get_Text();
	}

	public void method_4(string string_0)
	{
		((Control)textBox_1).set_Text(string_0);
	}

	public string method_5()
	{
		return ((Control)textBox_1).get_Text();
	}

	public void method_6()
	{
		method_0(string.Empty);
		method_2(string.Empty);
		method_4(string.Empty);
		listBox_0.get_Items().Clear();
	}

	public void method_7()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((TextBoxBase)textBox_1).set_ReadOnly(true);
	}

	public void method_8()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(false);
		((TextBoxBase)textBox_0).set_ReadOnly(false);
		((TextBoxBase)textBox_1).set_ReadOnly(false);
	}

	public void method_9()
	{
		((TextBoxBase)textBox_2).set_ReadOnly(true);
		((TextBoxBase)textBox_0).set_ReadOnly(false);
		((TextBoxBase)textBox_1).set_ReadOnly(false);
	}

	public void method_10()
	{
		method_7();
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

	private void method_11()
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
		label_3 = new Label();
		listBox_0 = new ListBox();
		label_4 = new Label();
		label_5 = new Label();
		((Control)this).SuspendLayout();
		((Control)textBox_0).set_Location(new Point(6, 25));
		((Control)textBox_0).set_Name(Class9.smethod_0(-860095823));
		((Control)textBox_0).set_Size(new Size(225, 22));
		((Control)textBox_0).set_TabIndex(49);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(3, 5));
		((Control)label_0).set_Name(Class9.smethod_0(-860095845));
		((Control)label_0).set_Size(new Size(45, 17));
		((Control)label_0).set_TabIndex(48);
		((Control)label_0).set_Text(Class9.smethod_0(-860095850));
		((Control)textBox_1).set_Location(new Point(6, 130));
		((Control)textBox_1).set_Name(Class9.smethod_0(-860096157));
		((Control)textBox_1).set_Size(new Size(225, 22));
		((Control)textBox_1).set_TabIndex(51);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(3, 110));
		((Control)label_1).set_Name(Class9.smethod_0(-860095739));
		((Control)label_1).set_Size(new Size(64, 17));
		((Control)label_1).set_TabIndex(50);
		((Control)label_1).set_Text(Class9.smethod_0(-860096183));
		((Control)textBox_2).set_Location(new Point(6, 78));
		((Control)textBox_2).set_Name(Class9.smethod_0(-860096166));
		((Control)textBox_2).set_Size(new Size(225, 22));
		((Control)textBox_2).set_TabIndex(53);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(3, 58));
		((Control)label_2).set_Name(Class9.smethod_0(-860095892));
		((Control)label_2).set_Size(new Size(29, 17));
		((Control)label_2).set_TabIndex(52);
		((Control)label_2).set_Text(Class9.smethod_0(-860096211));
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Location(new Point(254, 5));
		((Control)label_3).set_Name(Class9.smethod_0(-860095531));
		((Control)label_3).set_Size(new Size(42, 17));
		((Control)label_3).set_TabIndex(57);
		((Control)label_3).set_Text(Class9.smethod_0(-860096197));
		((ListControl)listBox_0).set_FormattingEnabled(true);
		listBox_0.set_ItemHeight(16);
		((Control)listBox_0).set_Location(new Point(257, 25));
		((Control)listBox_0).set_Name(Class9.smethod_0(-860096201));
		((Control)listBox_0).set_Size(new Size(201, 132));
		((Control)listBox_0).set_TabIndex(56);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Location(new Point(3, 185));
		((Control)label_4).set_Name(Class9.smethod_0(-860095944));
		((Control)label_4).set_Size(new Size(568, 17));
		((Control)label_4).set_TabIndex(87);
		((Control)label_4).set_Text(Class9.smethod_0(-860096256));
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Location(new Point(3, 211));
		((Control)label_5).set_Name(Class9.smethod_0(-860096083));
		((Control)label_5).set_Size(new Size(663, 17));
		((Control)label_5).set_TabIndex(88);
		((Control)label_5).set_Text(Class9.smethod_0(-860096072));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label_5);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)listBox_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).set_Name(Class9.smethod_0(-860096430));
		((Control)this).set_Size(new Size(686, 259));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
