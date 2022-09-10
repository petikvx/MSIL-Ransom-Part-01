using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns2;

namespace ns0;

internal class Form1 : Form
{
	private IContainer icontainer_0;

	private GroupBox groupBox_0;

	private CheckBox checkBox_0;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private Button button_0;

	private ProgressBar progressBar_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
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

	private void InitializeComponent()
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
		vmethod_1(new GroupBox());
		vmethod_11(new ProgressBar());
		vmethod_9(new Button());
		vmethod_7(new RadioButton());
		vmethod_5(new RadioButton());
		vmethod_3(new CheckBox());
		((Control)vmethod_0()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_2());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_4());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_6());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_8());
		((Control)vmethod_0()).get_Controls().Add((Control)(object)vmethod_10());
		GroupBox obj = vmethod_0();
		Point location = new Point(1, 2);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("GroupBox1");
		GroupBox obj2 = vmethod_0();
		Size size = new Size(373, 80);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_0().set_TabStop(false);
		vmethod_0().set_Text("GroupBox1");
		ProgressBar obj3 = vmethod_10();
		location = new Point(12, 63);
		((Control)obj3).set_Location(location);
		((Control)vmethod_10()).set_Name("ProgressBar1");
		ProgressBar obj4 = vmethod_10();
		size = new Size(352, 11);
		((Control)obj4).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(0);
		Button obj5 = vmethod_8();
		location = new Point(254, 20);
		((Control)obj5).set_Location(location);
		((Control)vmethod_8()).set_Name("Button1");
		Button obj6 = vmethod_8();
		size = new Size(75, 23);
		((Control)obj6).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(1);
		((ButtonBase)vmethod_8()).set_Text("Button1");
		((ButtonBase)vmethod_8()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_6()).set_AutoSize(true);
		RadioButton obj7 = vmethod_6();
		location = new Point(50, 20);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("RadioButton1");
		RadioButton obj8 = vmethod_6();
		size = new Size(90, 17);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(2);
		vmethod_6().set_TabStop(true);
		((ButtonBase)vmethod_6()).set_Text("RadioButton1");
		((ButtonBase)vmethod_6()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_4()).set_AutoSize(true);
		RadioButton obj9 = vmethod_4();
		location = new Point(50, 40);
		((Control)obj9).set_Location(location);
		((Control)vmethod_4()).set_Name("RadioButton2");
		RadioButton obj10 = vmethod_4();
		size = new Size(90, 17);
		((Control)obj10).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(3);
		vmethod_4().set_TabStop(true);
		((ButtonBase)vmethod_4()).set_Text("RadioButton2");
		((ButtonBase)vmethod_4()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_2()).set_AutoSize(true);
		CheckBox obj11 = vmethod_2();
		location = new Point(156, 28);
		((Control)obj11).set_Location(location);
		((Control)vmethod_2()).set_Name("CheckBox1");
		CheckBox obj12 = vmethod_2();
		size = new Size(81, 17);
		((Control)obj12).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(4);
		((ButtonBase)vmethod_2()).set_Text("CheckBox1");
		((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(377, 84);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Control)vmethod_0()).ResumeLayout(false);
		((Control)vmethod_0()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual GroupBox vmethod_0()
	{
		return groupBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(GroupBox groupBox_1)
	{
		groupBox_0 = groupBox_1;
	}

	[SpecialName]
	internal virtual CheckBox vmethod_2()
	{
		return checkBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(CheckBox checkBox_1)
	{
		checkBox_0 = checkBox_1;
	}

	[SpecialName]
	internal virtual RadioButton vmethod_4()
	{
		return radioButton_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(RadioButton radioButton_2)
	{
		radioButton_0 = radioButton_2;
	}

	[SpecialName]
	internal virtual RadioButton vmethod_6()
	{
		return radioButton_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(RadioButton radioButton_2)
	{
		radioButton_1 = radioButton_2;
	}

	[SpecialName]
	internal virtual Button vmethod_8()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Button button_1)
	{
		EventHandler eventHandler = method_0;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		button_0 = button_1;
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_10()
	{
		return progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(ProgressBar progressBar_1)
	{
		progressBar_0 = progressBar_1;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		Class5.smethod_0(null);
	}

	private void method_0(object sender, EventArgs e)
	{
	}
}
