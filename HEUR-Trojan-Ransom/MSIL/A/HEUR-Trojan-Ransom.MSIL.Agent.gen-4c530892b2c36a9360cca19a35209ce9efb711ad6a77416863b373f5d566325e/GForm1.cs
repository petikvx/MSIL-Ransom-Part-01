using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm1 : Form
{
	private IContainer icontainer_0 = null;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	public GForm1()
	{
		method_0();
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GForm1.smethod_0((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		label_0 = GForm1.smethod_1();
		label_1 = GForm1.smethod_1();
		label_2 = GForm1.smethod_1();
		label_3 = GForm1.smethod_1();
		GForm1.smethod_2((Control)(object)this);
		GForm1.smethod_3((Control)(object)label_0, bool_0: true);
		GForm1.smethod_5((Control)(object)label_0, GForm1.smethod_4("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm1.smethod_6((Control)(object)label_0, new Point(54, 18));
		GForm1.smethod_7((Control)(object)label_0, "rightButtonLabel");
		GForm1.smethod_8((Control)(object)label_0, new Size(146, 18));
		GForm1.smethod_9((Control)(object)label_0, 0);
		GForm1.smethod_10((Control)(object)label_0, "Поворот вправо - D");
		GForm1.smethod_3((Control)(object)label_1, bool_0: true);
		GForm1.smethod_5((Control)(object)label_1, GForm1.smethod_4("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm1.smethod_6((Control)(object)label_1, new Point(59, 53));
		GForm1.smethod_7((Control)(object)label_1, "leftButtonLabel");
		GForm1.smethod_8((Control)(object)label_1, new Size(137, 18));
		GForm1.smethod_9((Control)(object)label_1, 1);
		GForm1.smethod_10((Control)(object)label_1, "Поворот влево - A");
		GForm1.smethod_3((Control)(object)label_2, bool_0: true);
		GForm1.smethod_5((Control)(object)label_2, GForm1.smethod_4("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm1.smethod_6((Control)(object)label_2, new Point(40, 89));
		GForm1.smethod_7((Control)(object)label_2, "pauseButtonLabel");
		GForm1.smethod_8((Control)(object)label_2, new Size(174, 18));
		GForm1.smethod_9((Control)(object)label_2, 2);
		GForm1.smethod_10((Control)(object)label_2, "Пауза / Продолжить - P");
		GForm1.smethod_3((Control)(object)label_3, bool_0: true);
		GForm1.smethod_5((Control)(object)label_3, GForm1.smethod_4("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		GForm1.smethod_6((Control)(object)label_3, new Point(40, 124));
		GForm1.smethod_7((Control)(object)label_3, "switchMusicButtonLabel");
		GForm1.smethod_8((Control)(object)label_3, new Size(175, 18));
		GForm1.smethod_9((Control)(object)label_3, 3);
		GForm1.smethod_10((Control)(object)label_3, "Выкл. / Вкл. музыку - M");
		GForm1.smethod_11((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm1.smethod_12((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm1.smethod_13((Form)(object)this, new Size(254, 162));
		GForm1.smethod_15(GForm1.smethod_14((Control)(object)this), (Control)(object)label_3);
		GForm1.smethod_15(GForm1.smethod_14((Control)(object)this), (Control)(object)label_2);
		GForm1.smethod_15(GForm1.smethod_14((Control)(object)this), (Control)(object)label_1);
		GForm1.smethod_15(GForm1.smethod_14((Control)(object)this), (Control)(object)label_0);
		GForm1.smethod_16((Form)(object)this, bool_0: false);
		GForm1.smethod_17((Control)(object)this, "controlForm");
		GForm1.smethod_10((Control)(object)this, "Управление");
		GForm1.smethod_18((Control)(object)this, bool_0: false);
		GForm1.smethod_19((Control)(object)this);
	}

	static void smethod_0(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_2(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_3(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static Font smethod_4(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_5(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_6(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_7(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_8(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_9(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_10(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_11(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_12(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_13(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_14(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_15(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_16(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_17(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_18(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_19(Control control_0)
	{
		control_0.PerformLayout();
	}
}
