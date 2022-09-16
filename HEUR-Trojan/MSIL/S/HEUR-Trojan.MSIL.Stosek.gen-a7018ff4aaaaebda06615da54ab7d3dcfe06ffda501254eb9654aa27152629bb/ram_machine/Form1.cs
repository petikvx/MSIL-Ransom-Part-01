using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace ram_machine;

public class Form1 : Form
{
	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			Form1.smethod_0((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = Form1.smethod_2(Form1.smethod_1(typeof(Form1).TypeHandle));
		Form1.smethod_3((Control)(object)this);
		Form1.smethod_4((ContainerControl)(object)this, new SizeF(6f, 13f));
		Form1.smethod_5((ContainerControl)(object)this, (AutoScaleMode)1);
		Form1.smethod_6((Form)(object)this, new Size(284, 261));
		Form1.smethod_8((Form)(object)this, (Icon)Form1.smethod_7((ResourceManager)resourceManager_, "$this.Icon"));
		Form1.smethod_9((Control)(object)this, "Form1");
		Form1.smethod_10((Control)(object)this, "Form1");
		Form1.smethod_11((Control)(object)this, bool_0: false);
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

	static void smethod_4(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_5(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_6(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static object smethod_7(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_8(Form form_0, Icon icon_0)
	{
		form_0.set_Icon(icon_0);
	}

	static void smethod_9(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_10(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_11(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
