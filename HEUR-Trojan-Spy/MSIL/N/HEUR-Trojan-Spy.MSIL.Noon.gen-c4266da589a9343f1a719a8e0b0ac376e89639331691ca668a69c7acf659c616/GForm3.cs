using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm3 : Form
{
	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label3")]
	private Label label_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label2")]
	[CompilerGenerated]
	private Label label_1;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txbxUserName")]
	private TextBox textBox_0;

	[AccessedThroughProperty("txbxPassword")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnEnter")]
	private Button button_0;

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

	internal virtual Label Label_1
	{
		[CompilerGenerated]
		get
		{
			return label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_1 = value;
		}
	}

	internal virtual Label Label_2
	{
		[CompilerGenerated]
		get
		{
			return label_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_2 = value;
		}
	}

	internal virtual TextBox TextBox_0
	{
		[CompilerGenerated]
		get
		{
			return textBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			textBox_0 = value;
		}
	}

	internal virtual TextBox TextBox_1
	{
		[CompilerGenerated]
		get
		{
			return textBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			textBox_1 = value;
		}
	}

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
				GForm3.smethod_31((Control)(object)val, eventHandler_);
			}
			button_0 = value;
			val = button_0;
			if (val != null)
			{
				GForm3.smethod_32((Control)(object)val, eventHandler_);
			}
		}
	}

	public GForm3()
	{
		GForm3.smethod_0((Form)(object)this, (EventHandler)method_1);
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				GForm3.smethod_1((IDisposable)icontainer_0);
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
		Label_0 = GForm3.smethod_2();
		Label_1 = GForm3.smethod_2();
		Label_2 = GForm3.smethod_2();
		TextBox_0 = GForm3.smethod_3();
		TextBox_1 = GForm3.smethod_3();
		Button_0 = GForm3.smethod_4();
		GForm3.smethod_5((Control)(object)this);
		GForm3.smethod_6((Control)(object)Label_0, Color.Transparent);
		GForm3.smethod_8((Control)(object)Label_0, GForm3.smethod_7("Script MT Bold", 21.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		GForm3.smethod_9((Control)(object)Label_0, new Point(23, 21));
		GForm3.smethod_10((Control)(object)Label_0, "Label3");
		GForm3.smethod_11((Control)(object)Label_0, new Size(296, 80));
		GForm3.smethod_12((Control)(object)Label_0, 12);
		GForm3.smethod_13(Label_0, "Inter-American university ponce");
		GForm3.smethod_14(Label_0, (ContentAlignment)32);
		GForm3.smethod_15(Label_1, bool_0: true);
		GForm3.smethod_6((Control)(object)Label_1, Color.Transparent);
		GForm3.smethod_8((Control)(object)Label_1, GForm3.smethod_7("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GForm3.smethod_9((Control)(object)Label_1, new Point(83, 125));
		GForm3.smethod_10((Control)(object)Label_1, "Label2");
		GForm3.smethod_11((Control)(object)Label_1, new Size(89, 20));
		GForm3.smethod_12((Control)(object)Label_1, 11);
		GForm3.smethod_13(Label_1, "User Name");
		GForm3.smethod_15(Label_2, bool_0: true);
		GForm3.smethod_6((Control)(object)Label_2, Color.Transparent);
		GForm3.smethod_8((Control)(object)Label_2, GForm3.smethod_7("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GForm3.smethod_9((Control)(object)Label_2, new Point(83, 174));
		GForm3.smethod_10((Control)(object)Label_2, "Label1");
		GForm3.smethod_11((Control)(object)Label_2, new Size(78, 20));
		GForm3.smethod_12((Control)(object)Label_2, 10);
		GForm3.smethod_13(Label_2, "Password");
		GForm3.smethod_16(TextBox_0, bool_0: true);
		GForm3.smethod_8((Control)(object)TextBox_0, GForm3.smethod_7("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GForm3.smethod_9((Control)(object)TextBox_0, new Point(179, 122));
		GForm3.smethod_10((Control)(object)TextBox_0, "txbxUserName");
		GForm3.smethod_11((Control)(object)TextBox_0, new Size(100, 26));
		GForm3.smethod_12((Control)(object)TextBox_0, 9);
		GForm3.smethod_8((Control)(object)TextBox_1, GForm3.smethod_7("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GForm3.smethod_9((Control)(object)TextBox_1, new Point(179, 174));
		GForm3.smethod_10((Control)(object)TextBox_1, "txbxPassword");
		GForm3.smethod_17(TextBox_1, '*');
		GForm3.smethod_11((Control)(object)TextBox_1, new Size(100, 26));
		GForm3.smethod_12((Control)(object)TextBox_1, 8);
		GForm3.smethod_8((Control)(object)Button_0, GForm3.smethod_7("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GForm3.smethod_9((Control)(object)Button_0, new Point(132, 236));
		GForm3.smethod_10((Control)(object)Button_0, "btnEnter");
		GForm3.smethod_11((Control)(object)Button_0, new Size(83, 44));
		GForm3.smethod_12((Control)(object)Button_0, 7);
		GForm3.smethod_18((ButtonBase)(object)Button_0, "Enter");
		GForm3.smethod_19((ButtonBase)(object)Button_0, bool_0: true);
		GForm3.smethod_20((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm3.smethod_21((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm3.smethod_22((Form)(object)this, new Size(362, 297));
		GForm3.smethod_23((Form)(object)this, bool_0: false);
		GForm3.smethod_25(GForm3.smethod_24((Control)(object)this), (Control)(object)Label_0);
		GForm3.smethod_25(GForm3.smethod_24((Control)(object)this), (Control)(object)Label_1);
		GForm3.smethod_25(GForm3.smethod_24((Control)(object)this), (Control)(object)Label_2);
		GForm3.smethod_25(GForm3.smethod_24((Control)(object)this), (Control)(object)TextBox_0);
		GForm3.smethod_25(GForm3.smethod_24((Control)(object)this), (Control)(object)TextBox_1);
		GForm3.smethod_25(GForm3.smethod_24((Control)(object)this), (Control)(object)Button_0);
		GForm3.smethod_26((Control)(object)this, "LogIN");
		GForm3.smethod_27((Form)(object)this, (FormStartPosition)1);
		GForm3.smethod_28((Form)(object)this, "LogIN");
		GForm3.smethod_29((Control)(object)this, bool_0: false);
		GForm3.smethod_30((Control)(object)this);
	}

	private void method_1(object sender, EventArgs e)
	{
		GForm3.smethod_33((Control)(object)TextBox_0);
	}

	private void method_2(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if ((GForm3.smethod_35(GForm3.smethod_34(TextBox_0), "user", bool_0: false) == 0) & (GForm3.smethod_35(GForm3.smethod_34(TextBox_1), "password", bool_0: false) == 0))
		{
			GForm3.smethod_36((Control)(object)this);
			GForm3.smethod_37((Control)(object)Class1.Class2_0.GForm4_0);
		}
		else
		{
			GForm3.smethod_38((object)"Wrong password", (MsgBoxStyle)0, (object)null);
			GForm3.smethod_39((Control)(object)TextBox_1);
			GForm3.smethod_33((Control)(object)TextBox_1);
		}
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_5(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_6(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static Font smethod_7(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_8(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_9(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_10(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_11(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_12(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_13(Label label_3, string string_0)
	{
		label_3.set_Text(string_0);
	}

	static void smethod_14(Label label_3, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_3.set_TextAlign(contentAlignment_0);
	}

	static void smethod_15(Label label_3, bool bool_0)
	{
		label_3.set_AutoSize(bool_0);
	}

	static void smethod_16(TextBox textBox_2, bool bool_0)
	{
		textBox_2.set_AcceptsReturn(bool_0);
	}

	static void smethod_17(TextBox textBox_2, char char_0)
	{
		textBox_2.set_PasswordChar(char_0);
	}

	static void smethod_18(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_19(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_20(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_21(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_22(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static void smethod_23(Form form_0, bool bool_0)
	{
		form_0.set_ControlBox(bool_0);
	}

	static ControlCollection smethod_24(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_25(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_26(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_27(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_28(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_29(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_30(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_31(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_32(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static bool smethod_33(Control control_0)
	{
		return control_0.Focus();
	}

	static string smethod_34(TextBox textBox_2)
	{
		return textBox_2.get_Text();
	}

	static int smethod_35(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static void smethod_36(Control control_0)
	{
		control_0.Hide();
	}

	static void smethod_37(Control control_0)
	{
		control_0.Show();
	}

	static MsgBoxResult smethod_38(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	static void smethod_39(Control control_0)
	{
		control_0.ResetText();
	}
}
