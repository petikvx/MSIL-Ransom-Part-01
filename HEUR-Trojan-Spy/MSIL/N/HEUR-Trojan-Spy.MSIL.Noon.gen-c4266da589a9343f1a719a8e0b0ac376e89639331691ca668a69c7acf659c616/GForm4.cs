using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm4 : Form
{
	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnnewrecord")]
	private Button button_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnviewrecord")]
	private Button button_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnexit")]
	private Button button_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label1")]
	private Label label_0;

	internal virtual Button Button_0
	{
		[CompilerGenerated]
		get
		{
			return button_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_2;
			Button val = button_0;
			if (val != null)
			{
				GForm4.smethod_29((Control)(object)val, eventHandler_);
			}
			button_0 = value;
			val = button_0;
			if (val != null)
			{
				GForm4.smethod_30((Control)(object)val, eventHandler_);
			}
		}
	}

	internal virtual Button Button_1
	{
		[CompilerGenerated]
		get
		{
			return button_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_3;
			Button val = button_1;
			if (val != null)
			{
				GForm4.smethod_29((Control)(object)val, eventHandler_);
			}
			button_1 = value;
			val = button_1;
			if (val != null)
			{
				GForm4.smethod_30((Control)(object)val, eventHandler_);
			}
		}
	}

	internal virtual Button Button_2
	{
		[CompilerGenerated]
		get
		{
			return button_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_4;
			Button val = button_2;
			if (val != null)
			{
				GForm4.smethod_29((Control)(object)val, eventHandler_);
			}
			button_2 = value;
			val = button_2;
			if (val != null)
			{
				GForm4.smethod_30((Control)(object)val, eventHandler_);
			}
		}
	}

	internal virtual Label Label_0
	{
		[CompilerGenerated]
		get
		{
			return label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_0 = value;
		}
	}

	public GForm4()
	{
		GForm4.smethod_0((Form)(object)this, (EventHandler)method_1);
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				GForm4.smethod_1((IDisposable)icontainer_0);
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		Button_0 = GForm4.smethod_2();
		Button_1 = GForm4.smethod_2();
		Button_2 = GForm4.smethod_2();
		Label_0 = GForm4.smethod_3();
		GForm4.smethod_4((Control)(object)this);
		GForm4.smethod_6((Control)(object)Button_0, GForm4.smethod_5("Copperplate Gothic Light", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GForm4.smethod_7((Control)(object)Button_0, new Point(642, 15));
		GForm4.smethod_8((Control)(object)Button_0, new Padding(7, 6, 7, 6));
		GForm4.smethod_9((Control)(object)Button_0, "btnnewrecord");
		GForm4.smethod_10((Control)(object)Button_0, new Size(199, 68));
		GForm4.smethod_11((Control)(object)Button_0, 0);
		GForm4.smethod_12((ButtonBase)(object)Button_0, "Enter a New Record");
		GForm4.smethod_13((ButtonBase)(object)Button_0, bool_0: true);
		GForm4.smethod_6((Control)(object)Button_1, GForm4.smethod_5("Copperplate Gothic Light", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GForm4.smethod_7((Control)(object)Button_1, new Point(642, 110));
		GForm4.smethod_8((Control)(object)Button_1, new Padding(7, 6, 7, 6));
		GForm4.smethod_9((Control)(object)Button_1, "btnviewrecord");
		GForm4.smethod_10((Control)(object)Button_1, new Size(199, 69));
		GForm4.smethod_11((Control)(object)Button_1, 1);
		GForm4.smethod_12((ButtonBase)(object)Button_1, "View a Record");
		GForm4.smethod_13((ButtonBase)(object)Button_1, bool_0: true);
		GForm4.smethod_14((ButtonBase)(object)Button_2, Color.Red);
		GForm4.smethod_6((Control)(object)Button_2, GForm4.smethod_5("Engravers MT", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm4.smethod_7((Control)(object)Button_2, new Point(678, 211));
		GForm4.smethod_8((Control)(object)Button_2, new Padding(7, 6, 7, 6));
		GForm4.smethod_9((Control)(object)Button_2, "btnexit");
		GForm4.smethod_10((Control)(object)Button_2, new Size(133, 59));
		GForm4.smethod_11((Control)(object)Button_2, 3);
		GForm4.smethod_12((ButtonBase)(object)Button_2, "Exit");
		GForm4.smethod_13((ButtonBase)(object)Button_2, bool_0: false);
		GForm4.smethod_15((Control)(object)Label_0, Color.Transparent);
		GForm4.smethod_6((Control)(object)Label_0, GForm4.smethod_5("Lucida Calligraphy", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm4.smethod_7((Control)(object)Label_0, new Point(282, 54));
		GForm4.smethod_9((Control)(object)Label_0, "Label1");
		GForm4.smethod_10((Control)(object)Label_0, new Size(340, 100));
		GForm4.smethod_11((Control)(object)Label_0, 4);
		GForm4.smethod_16(Label_0, "        Welcome to \r\n     Student Registry");
		GForm4.smethod_17((ContainerControl)(object)this, new SizeF(16f, 27f));
		GForm4.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm4.smethod_19((Control)(object)this, (ImageLayout)3);
		GForm4.smethod_20((Form)(object)this, new Size(857, 298));
		GForm4.smethod_21((Form)(object)this, bool_0: false);
		GForm4.smethod_23(GForm4.smethod_22((Control)(object)this), (Control)(object)Label_0);
		GForm4.smethod_23(GForm4.smethod_22((Control)(object)this), (Control)(object)Button_2);
		GForm4.smethod_23(GForm4.smethod_22((Control)(object)this), (Control)(object)Button_1);
		GForm4.smethod_23(GForm4.smethod_22((Control)(object)this), (Control)(object)Button_0);
		((Control)this).set_DoubleBuffered(true);
		GForm4.smethod_6((Control)(object)this, GForm4.smethod_5("Lucida Calligraphy", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm4.smethod_24((Form)(object)this, new Padding(7, 6, 7, 6));
		GForm4.smethod_25((Control)(object)this, "Main_Menu");
		GForm4.smethod_26((Form)(object)this, (FormStartPosition)1);
		GForm4.smethod_27((Form)(object)this, "Registry Menu");
		GForm4.smethod_28((Control)(object)this, bool_0: false);
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
		GForm4.smethod_31((Control)(object)this);
		GForm4.smethod_32((Control)(object)Class1.Class2_0.GForm1_0);
	}

	private void method_3(object sender, EventArgs e)
	{
		GForm4.smethod_31((Control)(object)this);
		GForm4.smethod_32((Control)(object)Class1.Class2_0.GForm6_0);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_4(object sender, EventArgs e)
	{
		GForm4.smethod_33();
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Button smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Label smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_4(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Font smethod_5(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_6(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_7(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_8(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_9(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_10(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_11(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_12(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_13(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_14(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_15(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_16(Label label_1, string string_0)
	{
		label_1.set_Text(string_0);
	}

	static void smethod_17(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_18(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_19(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_20(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static void smethod_21(Form form_0, bool bool_0)
	{
		form_0.set_ControlBox(bool_0);
	}

	static ControlCollection smethod_22(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_23(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_24(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_25(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_26(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_27(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_28(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_29(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_30(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_31(Control control_0)
	{
		control_0.Hide();
	}

	static void smethod_32(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_33()
	{
		ProjectData.EndApp();
	}
}
