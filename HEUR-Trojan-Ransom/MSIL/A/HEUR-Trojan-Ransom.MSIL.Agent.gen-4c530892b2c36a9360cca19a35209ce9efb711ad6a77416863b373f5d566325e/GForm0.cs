using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

public class GForm0 : Form
{
	private IContainer icontainer_0 = null;

	private GControl0 gcontrol0_0;

	public GForm0()
	{
		method_0();
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GForm0.smethod_0((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = GForm0.smethod_2(GForm0.smethod_1(typeof(GForm0).TypeHandle));
		gcontrol0_0 = new GControl0();
		GForm0.smethod_3((Control)(object)this);
		GForm0.smethod_4((Control)(object)gcontrol0_0, Color.Black);
		GForm0.smethod_5((Control)(object)gcontrol0_0, new Point(12, 12));
		GForm0.smethod_6((Control)(object)gcontrol0_0, "snakeGame1");
		GForm0.smethod_7((Control)(object)gcontrol0_0, new Size(222, 222));
		GForm0.smethod_8((Control)(object)gcontrol0_0, 0);
		GForm0.smethod_9((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm0.smethod_10((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm0.smethod_4((Control)(object)this, Color.Black);
		GForm0.smethod_11((Form)(object)this, new Size(248, 248));
		GForm0.smethod_13(GForm0.smethod_12((Control)(object)this), (Control)(object)gcontrol0_0);
		GForm0.smethod_15((Form)(object)this, (Icon)GForm0.smethod_14((ResourceManager)resourceManager_, "$this.Icon"));
		GForm0.smethod_16((Form)(object)this, bool_0: false);
		GForm0.smethod_17((Form)(object)this, bool_0: false);
		GForm0.smethod_18((Control)(object)this, "FormSnakeVolume");
		GForm0.smethod_19((Form)(object)this, bool_0: false);
		GForm0.smethod_20((Control)(object)this, "Snake Volume Slider");
		GForm0.smethod_21((Control)(object)this, bool_0: false);
	}

	static void smethod_0(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_2(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static void smethod_3(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_4(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_5(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_6(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_7(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_8(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_9(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_10(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_11(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_12(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_13(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static object smethod_14(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_15(Form form_0, Icon icon_0)
	{
		form_0.set_Icon(icon_0);
	}

	static void smethod_16(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_17(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_18(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_19(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_20(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_21(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
