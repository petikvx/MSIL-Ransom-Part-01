using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public sealed class GForm1 : Form
{
	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GroupBox groupBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GroupBox groupBox_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NumericUpDown numericUpDown_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NumericUpDown numericUpDown_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NumericUpDown numericUpDown_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NumericUpDown numericUpDown_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GroupBox groupBox_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_9;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_10;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GroupBox groupBox_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_11;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_12;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_13;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GroupBox groupBox_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_14;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_15;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RadioButton radioButton_16;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NumericUpDown numericUpDown_4;

	public GForm1()
	{
		((Form)this).add_Load((EventHandler)GForm1_Load);
		method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	internal virtual GroupBox vmethod_0()
	{
		return groupBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_1(GroupBox groupBox_5)
	{
		groupBox_0 = groupBox_5;
	}

	internal virtual GroupBox vmethod_2()
	{
		return groupBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_3(GroupBox groupBox_5)
	{
		groupBox_1 = groupBox_5;
	}

	internal virtual Button vmethod_4()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_5(Button button_1)
	{
		EventHandler eventHandler = method_1;
		Button val = button_0;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_0 = button_1;
		val = button_0;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_6()
	{
		return radioButton_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_7(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_3;
		RadioButton val = radioButton_0;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_0 = radioButton_17;
		val = radioButton_0;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_8()
	{
		return radioButton_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_9(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_4;
		RadioButton val = radioButton_1;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_1 = radioButton_17;
		val = radioButton_1;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_10()
	{
		return radioButton_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_11(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_2;
		RadioButton val = radioButton_2;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_2 = radioButton_17;
		val = radioButton_2;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_12()
	{
		return radioButton_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_13(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_6;
		RadioButton val = radioButton_3;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_3 = radioButton_17;
		val = radioButton_3;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual NumericUpDown vmethod_14()
	{
		return numericUpDown_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_15(NumericUpDown numericUpDown_5)
	{
		EventHandler eventHandler = method_8;
		NumericUpDown val = numericUpDown_0;
		if (val != null)
		{
			val.remove_ValueChanged(eventHandler);
		}
		numericUpDown_0 = numericUpDown_5;
		val = numericUpDown_0;
		if (val != null)
		{
			val.add_ValueChanged(eventHandler);
		}
	}

	internal virtual NumericUpDown vmethod_16()
	{
		return numericUpDown_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_17(NumericUpDown numericUpDown_5)
	{
		EventHandler eventHandler = method_9;
		NumericUpDown val = numericUpDown_1;
		if (val != null)
		{
			val.remove_ValueChanged(eventHandler);
		}
		numericUpDown_1 = numericUpDown_5;
		val = numericUpDown_1;
		if (val != null)
		{
			val.add_ValueChanged(eventHandler);
		}
	}

	internal virtual NumericUpDown vmethod_18()
	{
		return numericUpDown_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_19(NumericUpDown numericUpDown_5)
	{
		EventHandler eventHandler = method_7;
		NumericUpDown val = numericUpDown_2;
		if (val != null)
		{
			val.remove_ValueChanged(eventHandler);
		}
		numericUpDown_2 = numericUpDown_5;
		val = numericUpDown_2;
		if (val != null)
		{
			val.add_ValueChanged(eventHandler);
		}
	}

	internal virtual NumericUpDown vmethod_20()
	{
		return numericUpDown_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_21(NumericUpDown numericUpDown_5)
	{
		EventHandler eventHandler = method_11;
		NumericUpDown val = numericUpDown_3;
		if (val != null)
		{
			val.remove_ValueChanged(eventHandler);
		}
		numericUpDown_3 = numericUpDown_5;
		val = numericUpDown_3;
		if (val != null)
		{
			val.add_ValueChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_22()
	{
		return radioButton_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_23(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_5;
		RadioButton val = radioButton_4;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_4 = radioButton_17;
		val = radioButton_4;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual Label vmethod_24()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_25(Label label_4)
	{
		EventHandler eventHandler = method_24;
		Label val = label_0;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		label_0 = label_4;
		val = label_0;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_26()
	{
		return radioButton_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_27(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_14;
		RadioButton val = radioButton_5;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_5 = radioButton_17;
		val = radioButton_5;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_28()
	{
		return radioButton_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_29(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_13;
		RadioButton val = radioButton_6;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_6 = radioButton_17;
		val = radioButton_6;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_30()
	{
		return radioButton_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_31(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_12;
		RadioButton val = radioButton_7;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_7 = radioButton_17;
		val = radioButton_7;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual GroupBox vmethod_32()
	{
		return groupBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_33(GroupBox groupBox_5)
	{
		groupBox_2 = groupBox_5;
	}

	internal virtual Label vmethod_34()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_35(Label label_4)
	{
		EventHandler eventHandler = method_25;
		Label val = label_1;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		label_1 = label_4;
		val = label_1;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_36()
	{
		return radioButton_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_37(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_17;
		RadioButton val = radioButton_8;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_8 = radioButton_17;
		val = radioButton_8;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_38()
	{
		return radioButton_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_39(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_16;
		RadioButton val = radioButton_9;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_9 = radioButton_17;
		val = radioButton_9;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_40()
	{
		return radioButton_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_41(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_15;
		RadioButton val = radioButton_10;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_10 = radioButton_17;
		val = radioButton_10;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual GroupBox vmethod_42()
	{
		return groupBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_43(GroupBox groupBox_5)
	{
		groupBox_3 = groupBox_5;
	}

	internal virtual Label vmethod_44()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_45(Label label_4)
	{
		EventHandler eventHandler = method_26;
		Label val = label_2;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		label_2 = label_4;
		val = label_2;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_46()
	{
		return radioButton_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_47(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_20;
		RadioButton val = radioButton_11;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_11 = radioButton_17;
		val = radioButton_11;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_48()
	{
		return radioButton_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_49(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_19;
		RadioButton val = radioButton_12;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_12 = radioButton_17;
		val = radioButton_12;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_50()
	{
		return radioButton_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_51(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_18;
		RadioButton val = radioButton_13;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_13 = radioButton_17;
		val = radioButton_13;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual GroupBox vmethod_52()
	{
		return groupBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_53(GroupBox groupBox_5)
	{
		groupBox_4 = groupBox_5;
	}

	internal virtual Label vmethod_54()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_55(Label label_4)
	{
		EventHandler eventHandler = method_27;
		Label val = label_3;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		label_3 = label_4;
		val = label_3;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_56()
	{
		return radioButton_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_57(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_23;
		RadioButton val = radioButton_14;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_14 = radioButton_17;
		val = radioButton_14;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_58()
	{
		return radioButton_15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_59(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_22;
		RadioButton val = radioButton_15;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_15 = radioButton_17;
		val = radioButton_15;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual RadioButton vmethod_60()
	{
		return radioButton_16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_61(RadioButton radioButton_17)
	{
		EventHandler eventHandler = method_21;
		RadioButton val = radioButton_16;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		radioButton_16 = radioButton_17;
		val = radioButton_16;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	internal virtual NumericUpDown vmethod_62()
	{
		return numericUpDown_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_63(NumericUpDown numericUpDown_5)
	{
		EventHandler eventHandler = method_10;
		NumericUpDown val = numericUpDown_4;
		if (val != null)
		{
			val.remove_ValueChanged(eventHandler);
		}
		numericUpDown_4 = numericUpDown_5;
		val = numericUpDown_4;
		if (val != null)
		{
			val.add_ValueChanged(eventHandler);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
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
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		vmethod_1(new GroupBox());
		vmethod_25(new Label());
		vmethod_27(new RadioButton());
		vmethod_29(new RadioButton());
		vmethod_31(new RadioButton());
		vmethod_3(new GroupBox());
		vmethod_21(new NumericUpDown());
		vmethod_23(new RadioButton());
		vmethod_63(new NumericUpDown());
		vmethod_19(new NumericUpDown());
		vmethod_17(new NumericUpDown());
		vmethod_15(new NumericUpDown());
		vmethod_13(new RadioButton());
		vmethod_11(new RadioButton());
		vmethod_9(new RadioButton());
		vmethod_7(new RadioButton());
		vmethod_5(new Button());
		vmethod_33(new GroupBox());
		vmethod_35(new Label());
		vmethod_37(new RadioButton());
		vmethod_39(new RadioButton());
		vmethod_41(new RadioButton());
		vmethod_43(new GroupBox());
		vmethod_45(new Label());
		vmethod_47(new RadioButton());
		vmethod_49(new RadioButton());
		vmethod_51(new RadioButton());
		vmethod_53(new GroupBox());
		vmethod_55(new Label());
		vmethod_57(new RadioButton());
		vmethod_59(new RadioButton());
		vmethod_61(new RadioButton());
		((Control)vmethod_0()).SuspendLayout();
		((Control)vmethod_2()).SuspendLayout();
		((ISupportInitialize)vmethod_20()).BeginInit();
		((ISupportInitialize)vmethod_62()).BeginInit();
		((ISupportInitialize)vmethod_18()).BeginInit();
		((ISupportInitialize)vmethod_16()).BeginInit();
		((ISupportInitialize)vmethod_14()).BeginInit();
		((Control)vmethod_32()).SuspendLayout();
		((Control)vmethod_42()).SuspendLayout();
		((Control)vmethod_52()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)vmethod_0()).set_BackColor(SystemColors.ControlDark);
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_24());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_26());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_28());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_30());
		((Control)vmethod_0()).set_Location(new Point(12, 12));
		((Control)vmethod_0()).set_Name(Class16.smethod_0(-561801170));
		((Control)vmethod_0()).set_Size(new Size(250, 61));
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_0().set_TabStop(false);
		vmethod_0().set_Text(Class16.smethod_0(-561801154));
		((Control)vmethod_24()).set_Location(new Point(9, 34));
		((Control)vmethod_24()).set_Name(Class16.smethod_0(-561801139));
		((Control)vmethod_24()).set_Size(new Size(235, 24));
		((Control)vmethod_24()).set_TabIndex(5);
		vmethod_24().set_TextAlign((ContentAlignment)32);
		((ButtonBase)vmethod_26()).set_AutoSize(true);
		((Control)vmethod_26()).set_Location(new Point(183, 16));
		((Control)vmethod_26()).set_Name(Class16.smethod_0(-561801123));
		((Control)vmethod_26()).set_Size(new Size(51, 17));
		((Control)vmethod_26()).set_TabIndex(2);
		vmethod_26().set_TabStop(true);
		((ButtonBase)vmethod_26()).set_Text(Class16.smethod_0(-561801106));
		((ButtonBase)vmethod_26()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_28()).set_AutoSize(true);
		((Control)vmethod_28()).set_Location(new Point(100, 16));
		((Control)vmethod_28()).set_Name(Class16.smethod_0(-561801095));
		((Control)vmethod_28()).set_Size(new Size(35, 17));
		((Control)vmethod_28()).set_TabIndex(1);
		vmethod_28().set_TabStop(true);
		((ButtonBase)vmethod_28()).set_Text(Class16.smethod_0(-561801077));
		((ButtonBase)vmethod_28()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_30()).set_AutoSize(true);
		((Control)vmethod_30()).set_Location(new Point(12, 17));
		((Control)vmethod_30()).set_Name(Class16.smethod_0(-561801068));
		((Control)vmethod_30()).set_Size(new Size(59, 17));
		((Control)vmethod_30()).set_TabIndex(0);
		vmethod_30().set_TabStop(true);
		((ButtonBase)vmethod_30()).set_Text(Class16.smethod_0(-561801050));
		((ButtonBase)vmethod_30()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_2()).set_BackColor(SystemColors.ControlDark);
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_20());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_22());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_62());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_18());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_16());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_14());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_12());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_10());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_8());
		((Control)vmethod_2()).get_Controls().Add((Control)(object)vmethod_6());
		((Control)vmethod_2()).set_Location(new Point(280, 12));
		((Control)vmethod_2()).set_Name(Class16.smethod_0(-561801038));
		((Control)vmethod_2()).set_Size(new Size(184, 218));
		((Control)vmethod_2()).set_TabIndex(1);
		vmethod_2().set_TabStop(false);
		vmethod_2().set_Text(Class16.smethod_0(-561801022));
		vmethod_20().set_Increment(new decimal(new int[4] { 3, 0, 0, 0 }));
		((Control)vmethod_20()).set_Location(new Point(96, 19));
		vmethod_20().set_Maximum(new decimal(new int[4] { 10000, 0, 0, 0 }));
		vmethod_20().set_Minimum(new decimal(new int[4] { 15, 0, 0, 0 }));
		((Control)vmethod_20()).set_Name(Class16.smethod_0(-561801006));
		((Control)vmethod_20()).set_Size(new Size(72, 20));
		((Control)vmethod_20()).set_TabIndex(9);
		((UpDownBase)vmethod_20()).set_TextAlign((HorizontalAlignment)2);
		vmethod_20().set_Value(new decimal(new int[4] { 100, 0, 0, 0 }));
		((Control)vmethod_22()).set_Location(new Point(16, 174));
		((Control)vmethod_22()).set_Name(Class16.smethod_0(-561800992));
		((Control)vmethod_22()).set_Size(new Size(72, 24));
		((Control)vmethod_22()).set_TabIndex(8);
		((ButtonBase)vmethod_22()).set_Text(Class16.smethod_0(-561800974));
		vmethod_62().set_Increment(new decimal(new int[4] { 5, 0, 0, 0 }));
		((Control)vmethod_62()).set_Location(new Point(96, 174));
		vmethod_62().set_Maximum(new decimal(new int[4] { 1000, 0, 0, 0 }));
		vmethod_62().set_Minimum(new decimal(new int[4] { 15, 0, 0, 0 }));
		((Control)vmethod_62()).set_Name(Class16.smethod_0(-561800446));
		((Control)vmethod_62()).set_Size(new Size(72, 20));
		((Control)vmethod_62()).set_TabIndex(7);
		((UpDownBase)vmethod_62()).set_TextAlign((HorizontalAlignment)2);
		vmethod_62().set_Value(new decimal(new int[4] { 100, 0, 0, 0 }));
		vmethod_18().set_Increment(new decimal(new int[4] { 100, 0, 0, 0 }));
		((Control)vmethod_18()).set_Location(new Point(96, 56));
		vmethod_18().set_Maximum(new decimal(new int[4] { 100000, 0, 0, 0 }));
		vmethod_18().set_Minimum(new decimal(new int[4] { 100, 0, 0, 0 }));
		((Control)vmethod_18()).set_Name(Class16.smethod_0(-561800427));
		((Control)vmethod_18()).set_Size(new Size(72, 20));
		((Control)vmethod_18()).set_TabIndex(6);
		((UpDownBase)vmethod_18()).set_TextAlign((HorizontalAlignment)2);
		vmethod_18().set_Value(new decimal(new int[4] { 1000, 0, 0, 0 }));
		vmethod_16().set_Increment(new decimal(new int[4] { 10, 0, 0, 0 }));
		((Control)vmethod_16()).set_Location(new Point(96, 134));
		vmethod_16().set_Maximum(new decimal(new int[4] { 10000, 0, 0, 0 }));
		vmethod_16().set_Minimum(new decimal(new int[4] { 10, 0, 0, 0 }));
		((Control)vmethod_16()).set_Name(Class16.smethod_0(-561800412));
		((Control)vmethod_16()).set_Size(new Size(72, 20));
		((Control)vmethod_16()).set_TabIndex(5);
		((UpDownBase)vmethod_16()).set_TextAlign((HorizontalAlignment)2);
		vmethod_16().set_Value(new decimal(new int[4] { 250, 0, 0, 0 }));
		((Control)vmethod_14()).set_Location(new Point(96, 94));
		vmethod_14().set_Minimum(new decimal(new int[4] { 3, 0, 0, 0 }));
		((Control)vmethod_14()).set_Name(Class16.smethod_0(-561800392));
		((Control)vmethod_14()).set_Size(new Size(72, 20));
		((Control)vmethod_14()).set_TabIndex(4);
		((UpDownBase)vmethod_14()).set_TextAlign((HorizontalAlignment)2);
		vmethod_14().set_Value(new decimal(new int[4] { 15, 0, 0, 0 }));
		((Control)vmethod_12()).set_Location(new Point(16, 19));
		((Control)vmethod_12()).set_Name(Class16.smethod_0(-561800373));
		((Control)vmethod_12()).set_Size(new Size(64, 24));
		((Control)vmethod_12()).set_TabIndex(3);
		((ButtonBase)vmethod_12()).set_Text(Class16.smethod_0(-561800360));
		((Control)vmethod_10()).set_Location(new Point(16, 56));
		((Control)vmethod_10()).set_Name(Class16.smethod_0(-561800349));
		((Control)vmethod_10()).set_Size(new Size(64, 24));
		((Control)vmethod_10()).set_TabIndex(2);
		((ButtonBase)vmethod_10()).set_Text(Class16.smethod_0(-561800335));
		((Control)vmethod_8()).set_Location(new Point(16, 134));
		((Control)vmethod_8()).set_Name(Class16.smethod_0(-561800323));
		((Control)vmethod_8()).set_Size(new Size(80, 24));
		((Control)vmethod_8()).set_TabIndex(1);
		((ButtonBase)vmethod_8()).set_Text(Class16.smethod_0(-561800304));
		((Control)vmethod_6()).set_Location(new Point(16, 94));
		((Control)vmethod_6()).set_Name(Class16.smethod_0(-561800287));
		((Control)vmethod_6()).set_Size(new Size(64, 24));
		((Control)vmethod_6()).set_TabIndex(0);
		((ButtonBase)vmethod_6()).set_Text(Class16.smethod_0(-561800269));
		((Control)vmethod_4()).set_Location(new Point(280, 239));
		((Control)vmethod_4()).set_Name(Class16.smethod_0(-561800253));
		((Control)vmethod_4()).set_Size(new Size(184, 45));
		((Control)vmethod_4()).set_TabIndex(4);
		((ButtonBase)vmethod_4()).set_Text(Class16.smethod_0(-561800239));
		((Control)vmethod_32()).set_BackColor(SystemColors.ControlDark);
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_34());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_36());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_38());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_40());
		((Control)vmethod_32()).set_Location(new Point(12, 82));
		((Control)vmethod_32()).set_Name(Class16.smethod_0(-561800227));
		((Control)vmethod_32()).set_Size(new Size(250, 61));
		((Control)vmethod_32()).set_TabIndex(6);
		vmethod_32().set_TabStop(false);
		vmethod_32().set_Text(Class16.smethod_0(-561800211));
		((Control)vmethod_34()).set_Location(new Point(9, 34));
		((Control)vmethod_34()).set_Name(Class16.smethod_0(-561800196));
		((Control)vmethod_34()).set_Size(new Size(235, 24));
		((Control)vmethod_34()).set_TabIndex(5);
		vmethod_34().set_TextAlign((ContentAlignment)32);
		((ButtonBase)vmethod_36()).set_AutoSize(true);
		((Control)vmethod_36()).set_Location(new Point(183, 16));
		((Control)vmethod_36()).set_Name(Class16.smethod_0(-561800692));
		((Control)vmethod_36()).set_Size(new Size(51, 17));
		((Control)vmethod_36()).set_TabIndex(2);
		vmethod_36().set_TabStop(true);
		((ButtonBase)vmethod_36()).set_Text(Class16.smethod_0(-561801106));
		((ButtonBase)vmethod_36()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_38()).set_AutoSize(true);
		((Control)vmethod_38()).set_Location(new Point(100, 16));
		((Control)vmethod_38()).set_Name(Class16.smethod_0(-561800675));
		((Control)vmethod_38()).set_Size(new Size(35, 17));
		((Control)vmethod_38()).set_TabIndex(1);
		vmethod_38().set_TabStop(true);
		((ButtonBase)vmethod_38()).set_Text(Class16.smethod_0(-561801077));
		((ButtonBase)vmethod_38()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_40()).set_AutoSize(true);
		((Control)vmethod_40()).set_Location(new Point(12, 17));
		((Control)vmethod_40()).set_Name(Class16.smethod_0(-561800657));
		((Control)vmethod_40()).set_Size(new Size(59, 17));
		((Control)vmethod_40()).set_TabIndex(0);
		vmethod_40().set_TabStop(true);
		((ButtonBase)vmethod_40()).set_Text(Class16.smethod_0(-561801050));
		((ButtonBase)vmethod_40()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_42()).set_BackColor(SystemColors.ControlDark);
		((Control)vmethod_42()).get_Controls().Add((Control)(object)vmethod_44());
		((Control)vmethod_42()).get_Controls().Add((Control)(object)vmethod_46());
		((Control)vmethod_42()).get_Controls().Add((Control)(object)vmethod_48());
		((Control)vmethod_42()).get_Controls().Add((Control)(object)vmethod_50());
		((Control)vmethod_42()).set_Location(new Point(12, 152));
		((Control)vmethod_42()).set_Name(Class16.smethod_0(-561800639));
		((Control)vmethod_42()).set_Size(new Size(250, 61));
		((Control)vmethod_42()).set_TabIndex(7);
		vmethod_42().set_TabStop(false);
		vmethod_42().set_Text(Class16.smethod_0(-561800623));
		((Control)vmethod_44()).set_Location(new Point(9, 34));
		((Control)vmethod_44()).set_Name(Class16.smethod_0(-561800608));
		((Control)vmethod_44()).set_Size(new Size(235, 24));
		((Control)vmethod_44()).set_TabIndex(5);
		vmethod_44().set_TextAlign((ContentAlignment)32);
		((ButtonBase)vmethod_46()).set_AutoSize(true);
		((Control)vmethod_46()).set_Location(new Point(183, 16));
		((Control)vmethod_46()).set_Name(Class16.smethod_0(-561800592));
		((Control)vmethod_46()).set_Size(new Size(51, 17));
		((Control)vmethod_46()).set_TabIndex(2);
		vmethod_46().set_TabStop(true);
		((ButtonBase)vmethod_46()).set_Text(Class16.smethod_0(-561801106));
		((ButtonBase)vmethod_46()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_48()).set_AutoSize(true);
		((Control)vmethod_48()).set_Location(new Point(100, 16));
		((Control)vmethod_48()).set_Name(Class16.smethod_0(-561800575));
		((Control)vmethod_48()).set_Size(new Size(35, 17));
		((Control)vmethod_48()).set_TabIndex(1);
		vmethod_48().set_TabStop(true);
		((ButtonBase)vmethod_48()).set_Text(Class16.smethod_0(-561801077));
		((ButtonBase)vmethod_48()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_50()).set_AutoSize(true);
		((Control)vmethod_50()).set_Location(new Point(12, 17));
		((Control)vmethod_50()).set_Name(Class16.smethod_0(-561800557));
		((Control)vmethod_50()).set_Size(new Size(59, 17));
		((Control)vmethod_50()).set_TabIndex(0);
		vmethod_50().set_TabStop(true);
		((ButtonBase)vmethod_50()).set_Text(Class16.smethod_0(-561801050));
		((ButtonBase)vmethod_50()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_52()).set_BackColor(SystemColors.ControlDark);
		((Control)vmethod_52()).get_Controls().Add((Control)(object)vmethod_54());
		((Control)vmethod_52()).get_Controls().Add((Control)(object)vmethod_56());
		((Control)vmethod_52()).get_Controls().Add((Control)(object)vmethod_58());
		((Control)vmethod_52()).get_Controls().Add((Control)(object)vmethod_60());
		((Control)vmethod_52()).set_Location(new Point(12, 222));
		((Control)vmethod_52()).set_Name(Class16.smethod_0(-561800539));
		((Control)vmethod_52()).set_Size(new Size(250, 61));
		((Control)vmethod_52()).set_TabIndex(8);
		vmethod_52().set_TabStop(false);
		vmethod_52().set_Text(Class16.smethod_0(-561800523));
		((Control)vmethod_54()).set_Location(new Point(9, 34));
		((Control)vmethod_54()).set_Name(Class16.smethod_0(-561800508));
		((Control)vmethod_54()).set_Size(new Size(235, 24));
		((Control)vmethod_54()).set_TabIndex(5);
		vmethod_54().set_TextAlign((ContentAlignment)32);
		((ButtonBase)vmethod_56()).set_AutoSize(true);
		((Control)vmethod_56()).set_Location(new Point(183, 16));
		((Control)vmethod_56()).set_Name(Class16.smethod_0(-561800492));
		((Control)vmethod_56()).set_Size(new Size(51, 17));
		((Control)vmethod_56()).set_TabIndex(2);
		vmethod_56().set_TabStop(true);
		((ButtonBase)vmethod_56()).set_Text(Class16.smethod_0(-561801106));
		((ButtonBase)vmethod_56()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_58()).set_AutoSize(true);
		((Control)vmethod_58()).set_Location(new Point(100, 16));
		((Control)vmethod_58()).set_Name(Class16.smethod_0(-561800475));
		((Control)vmethod_58()).set_Size(new Size(35, 17));
		((Control)vmethod_58()).set_TabIndex(1);
		vmethod_58().set_TabStop(true);
		((ButtonBase)vmethod_58()).set_Text(Class16.smethod_0(-561801077));
		((ButtonBase)vmethod_58()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_60()).set_AutoSize(true);
		((Control)vmethod_60()).set_Location(new Point(12, 17));
		((Control)vmethod_60()).set_Name(Class16.smethod_0(-561800457));
		((Control)vmethod_60()).set_Size(new Size(59, 17));
		((Control)vmethod_60()).set_TabIndex(0);
		vmethod_60().set_TabStop(true);
		((ButtonBase)vmethod_60()).set_Text(Class16.smethod_0(-561801050));
		((ButtonBase)vmethod_60()).set_UseVisualStyleBackColor(true);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(475, 296));
		((Control)this).get_Controls().Add((Control)(object)vmethod_52());
		((Control)this).get_Controls().Add((Control)(object)vmethod_42());
		((Control)this).get_Controls().Add((Control)(object)vmethod_32());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name(Class16.smethod_0(-561814263));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(Class16.smethod_0(-561814263));
		((Control)vmethod_0()).ResumeLayout(false);
		((Control)vmethod_0()).PerformLayout();
		((Control)vmethod_2()).ResumeLayout(false);
		((ISupportInitialize)vmethod_20()).EndInit();
		((ISupportInitialize)vmethod_62()).EndInit();
		((ISupportInitialize)vmethod_18()).EndInit();
		((ISupportInitialize)vmethod_16()).EndInit();
		((ISupportInitialize)vmethod_14()).EndInit();
		((Control)vmethod_32()).ResumeLayout(false);
		((Control)vmethod_32()).PerformLayout();
		((Control)vmethod_42()).ResumeLayout(false);
		((Control)vmethod_42()).PerformLayout();
		((Control)vmethod_52()).ResumeLayout(false);
		((Control)vmethod_52()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void GForm1_Load(object sender, EventArgs e)
	{
		Class24.list_0.Clear();
		int num = 0;
		do
		{
			GClass93 item = new GClass93(num);
			Class24.list_0.Add(item);
			num = checked(num + 1);
		}
		while (num <= 3);
		vmethod_30().set_Checked(true);
		vmethod_38().set_Checked(true);
		vmethod_46().set_Checked(true);
		vmethod_56().set_Checked(true);
		vmethod_12().set_Checked(true);
	}

	private void method_1(object sender, EventArgs e)
	{
		switch (Class24.int_0)
		{
		case 0:
			Class24.int_1 = Convert.ToInt32(vmethod_18().get_Value());
			break;
		case 1:
			Class24.int_1 = Convert.ToInt32(vmethod_14().get_Value());
			break;
		case 2:
			Class24.int_1 = Convert.ToInt32(vmethod_16().get_Value());
			break;
		case 3:
			Class24.int_1 = Convert.ToInt32(vmethod_62().get_Value());
			break;
		case 4:
			Class24.int_1 = Convert.ToInt32(vmethod_20().get_Value());
			break;
		}
		((Form)this).set_DialogResult((DialogResult)1);
		((Form)this).Close();
	}

	private void method_2(object sender, EventArgs e)
	{
		Class24.int_0 = 0;
		Class24.int_1 = Convert.ToInt32(vmethod_18().get_Value());
	}

	private void method_3(object sender, EventArgs e)
	{
		Class24.int_0 = 1;
		Class24.int_1 = Convert.ToInt32(vmethod_14().get_Value());
	}

	private void method_4(object sender, EventArgs e)
	{
		Class24.int_0 = 2;
		Class24.int_1 = Convert.ToInt32(vmethod_16().get_Value());
	}

	private void method_5(object sender, EventArgs e)
	{
		Class24.int_0 = 3;
		Class24.int_1 = Convert.ToInt32(vmethod_20().get_Value());
	}

	private void method_6(object sender, EventArgs e)
	{
		Class24.int_0 = 4;
		Class24.int_1 = Convert.ToInt32(vmethod_20().get_Value());
	}

	private void method_7(object sender, EventArgs e)
	{
		if (Class24.int_0 == 0)
		{
			Class24.int_1 = Convert.ToInt32(vmethod_18().get_Value());
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		if (Class24.int_0 == 1)
		{
			Class24.int_1 = Convert.ToInt32(vmethod_14().get_Value());
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		if (Class24.int_0 == 2)
		{
			Class24.int_1 = Convert.ToInt32(vmethod_16().get_Value());
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		if (Class24.int_0 == 3)
		{
			Class24.int_1 = Convert.ToInt32(vmethod_62().get_Value());
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		if (Class24.int_0 == 4)
		{
			Class24.int_1 = Convert.ToInt32(vmethod_20().get_Value());
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		method_28(0, 1);
	}

	private void method_13(object sender, EventArgs e)
	{
		method_28(0, 2);
	}

	private void method_14(object sender, EventArgs e)
	{
		method_28(0, 0);
	}

	private void method_15(object sender, EventArgs e)
	{
		method_28(1, 1);
	}

	private void method_16(object sender, EventArgs e)
	{
		method_28(1, 2);
	}

	private void method_17(object sender, EventArgs e)
	{
		method_28(1, 0);
	}

	private void method_18(object sender, EventArgs e)
	{
		method_28(2, 1);
	}

	private void method_19(object sender, EventArgs e)
	{
		method_28(2, 2);
	}

	private void method_20(object sender, EventArgs e)
	{
		method_28(2, 0);
	}

	private void method_21(object sender, EventArgs e)
	{
		method_28(3, 1);
	}

	private void method_22(object sender, EventArgs e)
	{
		method_28(3, 2);
	}

	private void method_23(object sender, EventArgs e)
	{
		method_28(3, 0);
	}

	private void method_24(object sender, EventArgs e)
	{
		method_29(0);
	}

	private void method_25(object sender, EventArgs e)
	{
		method_29(1);
	}

	private void method_26(object sender, EventArgs e)
	{
		method_29(2);
	}

	private void method_27(object sender, EventArgs e)
	{
		method_29(3);
	}

	private void method_28(int int_0, int int_1)
	{
		GClass93 gclass93_ = Class24.list_0[int_0];
		gclass93_.int_0 = int_1;
		method_30(ref gclass93_);
		int num = 0;
		int num2 = 0;
		checked
		{
			do
			{
				if (Class24.list_0[num2].int_0 != 0)
				{
					num++;
				}
				num2++;
			}
			while (num2 <= 3);
			if (num > 0)
			{
				((Control)vmethod_4()).set_Enabled(true);
			}
			else
			{
				((Control)vmethod_4()).set_Enabled(false);
			}
		}
	}

	private void method_29(int int_0)
	{
		GClass93 gclass93_ = Class24.list_0[int_0];
		method_30(ref gclass93_);
	}

	private void method_30(ref GClass93 gclass93_0)
	{
		string text = string.Empty;
		if (gclass93_0.int_0 == 2)
		{
			gclass93_0.method_0();
			text = gclass93_0.gclass5_0.ToString();
		}
		switch (gclass93_0.int_1)
		{
		case 0:
			vmethod_24().set_Text(text);
			break;
		case 1:
			vmethod_34().set_Text(text);
			break;
		case 2:
			vmethod_44().set_Text(text);
			break;
		case 3:
			vmethod_54().set_Text(text);
			break;
		}
	}
}
