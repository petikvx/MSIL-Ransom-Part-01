using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fuil.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using x;

namespace Fuil;

[DesignerGenerated]
public class Foll : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox checkedListBox_0;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar progressBar_0;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton radioButton_0;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton radioButton_1;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[AccessedThroughProperty("Label2")]
	private Label label_1;

	[AccessedThroughProperty("Label3")]
	private Label label_2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel linkLabel_0;

	[AccessedThroughProperty("Label4")]
	private Label label_3;

	[AccessedThroughProperty("Button2")]
	private Button button_1;

	public static Assembly asm = Assembly.Load(Resources.x);

	public Foll()
	{
		((Form)this).add_Load((EventHandler)Foll_Load);
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
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Foll));
		vmethod_1(new Button());
		vmethod_3(new CheckedListBox());
		vmethod_5(new ProgressBar());
		vmethod_7(new PictureBox());
		vmethod_9(new PictureBox());
		vmethod_11(new RadioButton());
		vmethod_13(new RadioButton());
		vmethod_15(new Label());
		vmethod_17(new Label());
		vmethod_19(new Label());
		vmethod_21(new LinkLabel());
		vmethod_23(new Label());
		vmethod_25(new Button());
		((ISupportInitialize)vmethod_6()).BeginInit();
		((ISupportInitialize)vmethod_8()).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = vmethod_0();
		Point location = new Point(11, 36);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("Button1");
		Button obj2 = vmethod_0();
		Size size = new Size(75, 23);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		((ButtonBase)vmethod_0()).set_Text("Button1");
		((ButtonBase)vmethod_0()).set_UseVisualStyleBackColor(true);
		((ListControl)vmethod_2()).set_FormattingEnabled(true);
		CheckedListBox obj3 = vmethod_2();
		location = new Point(-35, 97);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("CheckedListBox1");
		CheckedListBox obj4 = vmethod_2();
		size = new Size(120, 94);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		ProgressBar obj5 = vmethod_4();
		location = new Point(186, 188);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("ProgressBar1");
		ProgressBar obj6 = vmethod_4();
		size = new Size(100, 23);
		((Control)obj6).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(2);
		PictureBox obj7 = vmethod_6();
		location = new Point(206, 91);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("PictureBox1");
		PictureBox obj8 = vmethod_6();
		size = new Size(100, 50);
		((Control)obj8).set_Size(size);
		vmethod_6().set_TabIndex(3);
		vmethod_6().set_TabStop(false);
		PictureBox obj9 = vmethod_8();
		location = new Point(110, 45);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("PictureBox2");
		PictureBox obj10 = vmethod_8();
		size = new Size(100, 50);
		((Control)obj10).set_Size(size);
		vmethod_8().set_TabIndex(4);
		vmethod_8().set_TabStop(false);
		((ButtonBase)vmethod_10()).set_AutoSize(true);
		RadioButton obj11 = vmethod_10();
		location = new Point(253, 38);
		((Control)obj11).set_Location(location);
		((Control)vmethod_10()).set_Name("RadioButton1");
		RadioButton obj12 = vmethod_10();
		size = new Size(90, 17);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(5);
		vmethod_10().set_TabStop(true);
		((ButtonBase)vmethod_10()).set_Text("RadioButton1");
		((ButtonBase)vmethod_10()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_12()).set_AutoSize(true);
		RadioButton obj13 = vmethod_12();
		location = new Point(258, 74);
		((Control)obj13).set_Location(location);
		((Control)vmethod_12()).set_Name("RadioButton2");
		RadioButton obj14 = vmethod_12();
		size = new Size(90, 17);
		((Control)obj14).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(6);
		vmethod_12().set_TabStop(true);
		((ButtonBase)vmethod_12()).set_Text("RadioButton2");
		((ButtonBase)vmethod_12()).set_UseVisualStyleBackColor(true);
		vmethod_14().set_AutoSize(true);
		Label obj15 = vmethod_14();
		location = new Point(84, 1);
		((Control)obj15).set_Location(location);
		((Control)vmethod_14()).set_Name("Label1");
		Label obj16 = vmethod_14();
		size = new Size(39, 13);
		((Control)obj16).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(7);
		vmethod_14().set_Text("Label1");
		vmethod_16().set_AutoSize(true);
		Label obj17 = vmethod_16();
		location = new Point(186, 27);
		((Control)obj17).set_Location(location);
		((Control)vmethod_16()).set_Name("Label2");
		Label obj18 = vmethod_16();
		size = new Size(39, 13);
		((Control)obj18).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(8);
		vmethod_16().set_Text("Label2");
		vmethod_18().set_AutoSize(true);
		Label obj19 = vmethod_18();
		location = new Point(98, 157);
		((Control)obj19).set_Location(location);
		((Control)vmethod_18()).set_Name("Label3");
		Label obj20 = vmethod_18();
		size = new Size(39, 13);
		((Control)obj20).set_Size(size);
		((Control)vmethod_18()).set_TabIndex(9);
		vmethod_18().set_Text("Label3");
		((Label)vmethod_20()).set_AutoSize(true);
		LinkLabel obj21 = vmethod_20();
		location = new Point(330, 19);
		((Control)obj21).set_Location(location);
		((Control)vmethod_20()).set_Name("LinkLabel1");
		LinkLabel obj22 = vmethod_20();
		size = new Size(59, 13);
		((Control)obj22).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(10);
		((Label)vmethod_20()).set_TabStop(true);
		vmethod_20().set_Text("LinkLabel1");
		vmethod_22().set_AutoSize(true);
		Label obj23 = vmethod_22();
		location = new Point(328, 160);
		((Control)obj23).set_Location(location);
		((Control)vmethod_22()).set_Name("Label4");
		Label obj24 = vmethod_22();
		size = new Size(39, 13);
		((Control)obj24).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(11);
		vmethod_22().set_Text("Label4");
		Button obj25 = vmethod_24();
		location = new Point(155, 12);
		((Control)obj25).set_Location(location);
		((Control)vmethod_24()).set_Name("Button2");
		Button obj26 = vmethod_24();
		size = new Size(75, 23);
		((Control)obj26).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(12);
		((ButtonBase)vmethod_24()).set_Text("Button2");
		((ButtonBase)vmethod_24()).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(116, 0);
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
		((Control)this).set_Name("Foll");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((ISupportInitialize)vmethod_6()).EndInit();
		((ISupportInitialize)vmethod_8()).EndInit();
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
	internal virtual CheckedListBox vmethod_2()
	{
		return checkedListBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(CheckedListBox WithEventsValue)
	{
		checkedListBox_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_4()
	{
		return progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(ProgressBar WithEventsValue)
	{
		progressBar_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_6()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(PictureBox WithEventsValue)
	{
		pictureBox_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_8()
	{
		return pictureBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(PictureBox WithEventsValue)
	{
		pictureBox_1 = WithEventsValue;
	}

	[SpecialName]
	internal virtual RadioButton vmethod_10()
	{
		return radioButton_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(RadioButton WithEventsValue)
	{
		radioButton_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual RadioButton vmethod_12()
	{
		return radioButton_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(RadioButton WithEventsValue)
	{
		radioButton_1 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_14()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(Label WithEventsValue)
	{
		label_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_16()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_17(Label WithEventsValue)
	{
		label_1 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_18()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_19(Label WithEventsValue)
	{
		label_2 = WithEventsValue;
	}

	[SpecialName]
	internal virtual LinkLabel vmethod_20()
	{
		return linkLabel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_21(LinkLabel WithEventsValue)
	{
		linkLabel_0 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Label vmethod_22()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_23(Label WithEventsValue)
	{
		label_3 = WithEventsValue;
	}

	[SpecialName]
	internal virtual Button vmethod_24()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_25(Button WithEventsValue)
	{
		button_1 = WithEventsValue;
	}

	public void Gr0wlit_EM89y7F7v3c0u11y()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		for (double num = 0.2697316; num <= 0.05559349; num += 1.0)
		{
		}
		double num2 = 0.00024122;
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
			num2 += 1.0;
		}
		while (num2 <= 0.5367941);
	}

	public void Gr0wlit_SGyyy5()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(1706353337L);
			ProjectData.ClearProjectError();
		}
		double num = 0.6808194;
		do
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				new decimal(-529576829L);
				ProjectData.ClearProjectError();
			}
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				new decimal(-1325196863L);
				ProjectData.ClearProjectError();
			}
			num += 1.0;
		}
		while (num <= 0.8866001);
	}

	public void Gr0wlit_R29G45qBf59h3ZE()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Gr0wlit_Dwy4iDsSkM1vL()
	{
		for (double num = 0.8042672; num <= 0.6748261; num += 1.0)
		{
		}
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Foll_Load(object sender, EventArgs e)
	{
		x.X();
	}

	public object U94TFCVRKuzf4C()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)" o0‡*VG\u008f\u008dO%\\D>^/\u007fJ*wlNUs Žm‹%-„W2mxiI‡.C[+Wsn)n_.\u008f0p„ktd9P‡/{O‰\u007f]aIiX‡y‹;z;`Št$‰?.})\u0090", (MsgBoxStyle)0, (object)null);
		Interaction.MsgBox((object)"YZcQD", (MsgBoxStyle)0, (object)null);
		return 218;
	}

	public object FP75TxaWi8Wt3F2346a0k95XLas3()
	{
		while (true)
		{
		}
	}
}
