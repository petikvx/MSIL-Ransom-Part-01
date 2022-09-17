using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CiscoAnyconnectControl.UI;

public class DialogBox : Form
{
	private Form1 mainform;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Button button1;

	private Button button2;

	public NumericUpDown numericUpDown1 = DialogBox.smethod_0();

	public NumericUpDown numericUpDown2 = DialogBox.smethod_0();

	public DialogBox(Form1 _mainform)
	{
		mainform = _mainform;
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		mainform.lives = int.Parse(DialogBox.smethod_1((Control)(object)numericUpDown1));
		ToolStripStatusLabel toolStripStatusLabel = mainform.toolStripStatusLabel1;
		int lives = mainform.lives;
		DialogBox.smethod_3((ToolStripItem)(object)toolStripStatusLabel, DialogBox.smethod_2("Lives: ", lives.ToString()));
		mainform.time = int.Parse(DialogBox.smethod_1((Control)(object)numericUpDown2)) * 1000;
		DialogBox.smethod_4((Form)(object)this);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		DialogBox.smethod_4((Form)(object)this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			DialogBox.smethod_5((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		label1 = DialogBox.smethod_6();
		label2 = DialogBox.smethod_6();
		button1 = DialogBox.smethod_7();
		button2 = DialogBox.smethod_7();
		numericUpDown1 = DialogBox.smethod_0();
		numericUpDown2 = DialogBox.smethod_0();
		DialogBox.smethod_8((ISupportInitialize)numericUpDown1);
		DialogBox.smethod_8((ISupportInitialize)numericUpDown2);
		DialogBox.smethod_9((Control)(object)this);
		DialogBox.smethod_10((Control)(object)label1, bool_0: true);
		DialogBox.smethod_11((Control)(object)label1, new Point(33, 26));
		DialogBox.smethod_12((Control)(object)label1, "label1");
		DialogBox.smethod_13((Control)(object)label1, new Size(35, 13));
		DialogBox.smethod_14((Control)(object)label1, 0);
		DialogBox.smethod_15((Control)(object)label1, "Lives:");
		DialogBox.smethod_10((Control)(object)label2, bool_0: true);
		DialogBox.smethod_11((Control)(object)label2, new Point(33, 79));
		DialogBox.smethod_12((Control)(object)label2, "label2");
		DialogBox.smethod_13((Control)(object)label2, new Size(47, 13));
		DialogBox.smethod_14((Control)(object)label2, 1);
		DialogBox.smethod_15((Control)(object)label2, "Time [s]:");
		DialogBox.smethod_11((Control)(object)button1, new Point(129, 135));
		DialogBox.smethod_12((Control)(object)button1, "button1");
		DialogBox.smethod_13((Control)(object)button1, new Size(79, 24));
		DialogBox.smethod_14((Control)(object)button1, 4);
		DialogBox.smethod_15((Control)(object)button1, "OK");
		DialogBox.smethod_16((ButtonBase)(object)button1, bool_0: true);
		DialogBox.smethod_17((Control)(object)button1, (EventHandler)button1_Click);
		DialogBox.smethod_18(button2, (DialogResult)2);
		DialogBox.smethod_11((Control)(object)button2, new Point(36, 135));
		DialogBox.smethod_12((Control)(object)button2, "button2");
		DialogBox.smethod_13((Control)(object)button2, new Size(79, 24));
		DialogBox.smethod_14((Control)(object)button2, 5);
		DialogBox.smethod_15((Control)(object)button2, "Cancel");
		DialogBox.smethod_16((ButtonBase)(object)button2, bool_0: true);
		DialogBox.smethod_17((Control)(object)button2, (EventHandler)button2_Click);
		DialogBox.smethod_11((Control)(object)numericUpDown1, new Point(100, 26));
		DialogBox.smethod_19(numericUpDown1, new decimal(new int[4] { 10, 0, 0, 0 }));
		DialogBox.smethod_20(numericUpDown1, new decimal(new int[4] { 1, 0, 0, 0 }));
		DialogBox.smethod_12((Control)(object)numericUpDown1, "numericUpDown1");
		DialogBox.smethod_13((Control)(object)numericUpDown1, new Size(108, 20));
		DialogBox.smethod_14((Control)(object)numericUpDown1, 6);
		DialogBox.smethod_21(numericUpDown1, new decimal(new int[4] { 1, 0, 0, 0 }));
		DialogBox.smethod_11((Control)(object)numericUpDown2, new Point(100, 79));
		DialogBox.smethod_20(numericUpDown2, new decimal(new int[4] { 1, 0, 0, 0 }));
		DialogBox.smethod_12((Control)(object)numericUpDown2, "numericUpDown2");
		DialogBox.smethod_13((Control)(object)numericUpDown2, new Size(108, 20));
		DialogBox.smethod_14((Control)(object)numericUpDown2, 7);
		DialogBox.smethod_21(numericUpDown2, new decimal(new int[4] { 1, 0, 0, 0 }));
		DialogBox.smethod_22((Form)(object)this, (IButtonControl)(object)button1);
		DialogBox.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
		DialogBox.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
		DialogBox.smethod_25((Form)(object)this, (IButtonControl)(object)button2);
		DialogBox.smethod_26((Form)(object)this, new Size(240, 178));
		DialogBox.smethod_27((Form)(object)this, bool_0: false);
		DialogBox.smethod_29(DialogBox.smethod_28((Control)(object)this), (Control)(object)numericUpDown2);
		DialogBox.smethod_29(DialogBox.smethod_28((Control)(object)this), (Control)(object)numericUpDown1);
		DialogBox.smethod_29(DialogBox.smethod_28((Control)(object)this), (Control)(object)button2);
		DialogBox.smethod_29(DialogBox.smethod_28((Control)(object)this), (Control)(object)button1);
		DialogBox.smethod_29(DialogBox.smethod_28((Control)(object)this), (Control)(object)label2);
		DialogBox.smethod_29(DialogBox.smethod_28((Control)(object)this), (Control)(object)label1);
		DialogBox.smethod_30((Form)(object)this, (FormBorderStyle)3);
		DialogBox.smethod_31((Form)(object)this, bool_0: false);
		DialogBox.smethod_32((Form)(object)this, bool_0: false);
		DialogBox.smethod_33((Control)(object)this, "DialogBox");
		DialogBox.smethod_34((Form)(object)this, bool_0: false);
		DialogBox.smethod_35((Form)(object)this, (FormStartPosition)4);
		DialogBox.smethod_15((Control)(object)this, "Settings");
		DialogBox.smethod_36((ISupportInitialize)numericUpDown1);
		DialogBox.smethod_36((ISupportInitialize)numericUpDown2);
		DialogBox.smethod_37((Control)(object)this, bool_0: false);
		DialogBox.smethod_38((Control)(object)this);
	}

	static NumericUpDown smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new NumericUpDown();
	}

	static string smethod_1(Control control_0)
	{
		return control_0.get_Text();
	}

	static string smethod_2(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_3(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Text(string_0);
	}

	static void smethod_4(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_5(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Button smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_8(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_9(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_10(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_11(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_12(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_13(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_14(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_15(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_16(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_17(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_18(Button button_0, DialogResult dialogResult_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		button_0.set_DialogResult(dialogResult_0);
	}

	static void smethod_19(NumericUpDown numericUpDown_0, decimal decimal_0)
	{
		numericUpDown_0.set_Maximum(decimal_0);
	}

	static void smethod_20(NumericUpDown numericUpDown_0, decimal decimal_0)
	{
		numericUpDown_0.set_Minimum(decimal_0);
	}

	static void smethod_21(NumericUpDown numericUpDown_0, decimal decimal_0)
	{
		numericUpDown_0.set_Value(decimal_0);
	}

	static void smethod_22(Form form_0, IButtonControl ibuttonControl_0)
	{
		form_0.set_AcceptButton(ibuttonControl_0);
	}

	static void smethod_23(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_24(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_25(Form form_0, IButtonControl ibuttonControl_0)
	{
		form_0.set_CancelButton(ibuttonControl_0);
	}

	static void smethod_26(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static void smethod_27(Form form_0, bool bool_0)
	{
		form_0.set_ControlBox(bool_0);
	}

	static ControlCollection smethod_28(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_29(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_30(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_31(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_32(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_33(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_34(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_35(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_36(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_37(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_38(Control control_0)
	{
		control_0.PerformLayout();
	}
}
