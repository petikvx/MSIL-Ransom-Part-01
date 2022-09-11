using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public sealed class GForm0 : Form
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TableLayoutPanel")]
	[CompilerGenerated]
	private TableLayoutPanel tableLayoutPanel_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LogoPictureBox")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("LabelProductName")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LabelVersion")]
	private Label label_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LabelCompanyName")]
	[CompilerGenerated]
	private Label label_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBoxDescription")]
	private TextBox textBox_0;

	[AccessedThroughProperty("OKButton")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[AccessedThroughProperty("LabelCopyright")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_3;

	private IContainer icontainer_0;

	internal virtual TableLayoutPanel TableLayoutPanel_0
	{
		[CompilerGenerated]
		get
		{
			return tableLayoutPanel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			tableLayoutPanel_0 = value;
		}
	}

	internal virtual PictureBox PictureBox_0
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
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
				GForm0.smethod_2((Control)(object)val, eventHandler_);
			}
			button_0 = value;
			val = button_0;
			if (val != null)
			{
				GForm0.smethod_3((Control)(object)val, eventHandler_);
			}
		}
	}

	internal virtual Label Label_3
	{
		[CompilerGenerated]
		get
		{
			return label_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_3 = value;
		}
	}

	public GForm0()
	{
		GForm0.smethod_0((Form)(object)this, (EventHandler)method_1);
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GForm0.smethod_1((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager resourceManager_ = GForm0.smethod_5(GForm0.smethod_4(typeof(GForm0).TypeHandle));
		TableLayoutPanel_0 = GForm0.smethod_6();
		PictureBox_0 = GForm0.smethod_7();
		Label_0 = GForm0.smethod_8();
		Label_1 = GForm0.smethod_8();
		Label_3 = GForm0.smethod_8();
		Label_2 = GForm0.smethod_8();
		TextBox_0 = GForm0.smethod_9();
		Button_0 = GForm0.smethod_10();
		GForm0.smethod_11((Control)(object)TableLayoutPanel_0);
		GForm0.smethod_12((ISupportInitialize)PictureBox_0);
		GForm0.smethod_13((Control)(object)this);
		GForm0.smethod_14(TableLayoutPanel_0, 2);
		GForm0.smethod_17(GForm0.smethod_15(TableLayoutPanel_0), GForm0.smethod_16((SizeType)2, 33f));
		GForm0.smethod_17(GForm0.smethod_15(TableLayoutPanel_0), GForm0.smethod_16((SizeType)2, 67f));
		GForm0.smethod_19(GForm0.smethod_18(TableLayoutPanel_0), (Control)(object)PictureBox_0, 0, 0);
		GForm0.smethod_19(GForm0.smethod_18(TableLayoutPanel_0), (Control)(object)Label_0, 1, 0);
		GForm0.smethod_19(GForm0.smethod_18(TableLayoutPanel_0), (Control)(object)Label_1, 1, 1);
		GForm0.smethod_19(GForm0.smethod_18(TableLayoutPanel_0), (Control)(object)Label_3, 1, 2);
		GForm0.smethod_19(GForm0.smethod_18(TableLayoutPanel_0), (Control)(object)Label_2, 1, 3);
		GForm0.smethod_19(GForm0.smethod_18(TableLayoutPanel_0), (Control)(object)TextBox_0, 1, 4);
		GForm0.smethod_19(GForm0.smethod_18(TableLayoutPanel_0), (Control)(object)Button_0, 1, 5);
		GForm0.smethod_20((Control)(object)TableLayoutPanel_0, (DockStyle)5);
		GForm0.smethod_21((Control)(object)TableLayoutPanel_0, new Point(9, 9));
		GForm0.smethod_22((Control)(object)TableLayoutPanel_0, "TableLayoutPanel");
		GForm0.smethod_23(TableLayoutPanel_0, 6);
		GForm0.smethod_26(GForm0.smethod_24(TableLayoutPanel_0), GForm0.smethod_25((SizeType)2, 10f));
		GForm0.smethod_26(GForm0.smethod_24(TableLayoutPanel_0), GForm0.smethod_25((SizeType)2, 10f));
		GForm0.smethod_26(GForm0.smethod_24(TableLayoutPanel_0), GForm0.smethod_25((SizeType)2, 10f));
		GForm0.smethod_26(GForm0.smethod_24(TableLayoutPanel_0), GForm0.smethod_25((SizeType)2, 10f));
		GForm0.smethod_26(GForm0.smethod_24(TableLayoutPanel_0), GForm0.smethod_25((SizeType)2, 50f));
		GForm0.smethod_26(GForm0.smethod_24(TableLayoutPanel_0), GForm0.smethod_25((SizeType)2, 10f));
		GForm0.smethod_27((Control)(object)TableLayoutPanel_0, new Size(396, 258));
		GForm0.smethod_28((Control)(object)TableLayoutPanel_0, 0);
		GForm0.smethod_20((Control)(object)PictureBox_0, (DockStyle)5);
		GForm0.smethod_30(PictureBox_0, (Image)GForm0.smethod_29((ResourceManager)resourceManager_, "LogoPictureBox.Image"));
		GForm0.smethod_21((Control)(object)PictureBox_0, new Point(3, 3));
		GForm0.smethod_22((Control)(object)PictureBox_0, "LogoPictureBox");
		GForm0.smethod_31(TableLayoutPanel_0, (Control)(object)PictureBox_0, 6);
		GForm0.smethod_27((Control)(object)PictureBox_0, new Size(124, 252));
		GForm0.smethod_32(PictureBox_0, (PictureBoxSizeMode)3);
		GForm0.smethod_33(PictureBox_0, 0);
		GForm0.smethod_34(PictureBox_0, bool_0: false);
		GForm0.smethod_20((Control)(object)Label_0, (DockStyle)5);
		GForm0.smethod_36((Control)(object)Label_0, GForm0.smethod_35("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm0.smethod_21((Control)(object)Label_0, new Point(136, 0));
		GForm0.smethod_37((Control)(object)Label_0, new Padding(6, 0, 3, 0));
		GForm0.smethod_38((Control)(object)Label_0, new Size(0, 17));
		GForm0.smethod_22((Control)(object)Label_0, "LabelProductName");
		GForm0.smethod_27((Control)(object)Label_0, new Size(257, 17));
		GForm0.smethod_28((Control)(object)Label_0, 0);
		GForm0.smethod_39(Label_0, "Product Name");
		GForm0.smethod_40(Label_0, (ContentAlignment)16);
		GForm0.smethod_20((Control)(object)Label_1, (DockStyle)5);
		GForm0.smethod_36((Control)(object)Label_1, GForm0.smethod_35("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm0.smethod_21((Control)(object)Label_1, new Point(136, 25));
		GForm0.smethod_37((Control)(object)Label_1, new Padding(6, 0, 3, 0));
		GForm0.smethod_38((Control)(object)Label_1, new Size(0, 17));
		GForm0.smethod_22((Control)(object)Label_1, "LabelVersion");
		GForm0.smethod_27((Control)(object)Label_1, new Size(257, 17));
		GForm0.smethod_28((Control)(object)Label_1, 0);
		GForm0.smethod_39(Label_1, "Version");
		GForm0.smethod_40(Label_1, (ContentAlignment)16);
		GForm0.smethod_20((Control)(object)Label_3, (DockStyle)5);
		GForm0.smethod_36((Control)(object)Label_3, GForm0.smethod_35("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm0.smethod_21((Control)(object)Label_3, new Point(136, 50));
		GForm0.smethod_37((Control)(object)Label_3, new Padding(6, 0, 3, 0));
		GForm0.smethod_38((Control)(object)Label_3, new Size(0, 17));
		GForm0.smethod_22((Control)(object)Label_3, "LabelCopyright");
		GForm0.smethod_27((Control)(object)Label_3, new Size(257, 17));
		GForm0.smethod_28((Control)(object)Label_3, 0);
		GForm0.smethod_39(Label_3, "Copyright");
		GForm0.smethod_40(Label_3, (ContentAlignment)16);
		GForm0.smethod_20((Control)(object)Label_2, (DockStyle)5);
		GForm0.smethod_36((Control)(object)Label_2, GForm0.smethod_35("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm0.smethod_21((Control)(object)Label_2, new Point(136, 75));
		GForm0.smethod_37((Control)(object)Label_2, new Padding(6, 0, 3, 0));
		GForm0.smethod_38((Control)(object)Label_2, new Size(0, 17));
		GForm0.smethod_22((Control)(object)Label_2, "LabelCompanyName");
		GForm0.smethod_27((Control)(object)Label_2, new Size(257, 17));
		GForm0.smethod_28((Control)(object)Label_2, 0);
		GForm0.smethod_39(Label_2, "Company Name");
		GForm0.smethod_40(Label_2, (ContentAlignment)16);
		GForm0.smethod_20((Control)(object)TextBox_0, (DockStyle)5);
		GForm0.smethod_36((Control)(object)TextBox_0, GForm0.smethod_35("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm0.smethod_21((Control)(object)TextBox_0, new Point(136, 103));
		GForm0.smethod_37((Control)(object)TextBox_0, new Padding(6, 3, 3, 3));
		GForm0.smethod_41(TextBox_0, bool_0: true);
		GForm0.smethod_22((Control)(object)TextBox_0, "TextBoxDescription");
		GForm0.smethod_42((TextBoxBase)(object)TextBox_0, bool_0: true);
		GForm0.smethod_43(TextBox_0, (ScrollBars)3);
		GForm0.smethod_27((Control)(object)TextBox_0, new Size(257, 123));
		GForm0.smethod_28((Control)(object)TextBox_0, 0);
		GForm0.smethod_44((Control)(object)TextBox_0, bool_0: false);
		GForm0.smethod_46(TextBox_0, GForm0.smethod_45((ResourceManager)resourceManager_, "TextBoxDescription.Text"));
		GForm0.smethod_47((Control)(object)Button_0, (AnchorStyles)10);
		GForm0.smethod_48(Button_0, (DialogResult)2);
		GForm0.smethod_36((Control)(object)Button_0, GForm0.smethod_35("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm0.smethod_21((Control)(object)Button_0, new Point(318, 232));
		GForm0.smethod_22((Control)(object)Button_0, "OKButton");
		GForm0.smethod_27((Control)(object)Button_0, new Size(75, 23));
		GForm0.smethod_28((Control)(object)Button_0, 0);
		GForm0.smethod_49((ButtonBase)(object)Button_0, "&OK");
		GForm0.smethod_50((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm0.smethod_51((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm0.smethod_52((Form)(object)this, (IButtonControl)(object)Button_0);
		GForm0.smethod_53((Form)(object)this, new Size(414, 276));
		GForm0.smethod_55(GForm0.smethod_54((Control)(object)this), (Control)(object)TableLayoutPanel_0);
		GForm0.smethod_56((Form)(object)this, (FormBorderStyle)3);
		GForm0.smethod_57((Form)(object)this, bool_0: false);
		GForm0.smethod_58((Form)(object)this, bool_0: false);
		GForm0.smethod_59((Control)(object)this, "frmAbout");
		GForm0.smethod_60((Control)(object)this, new Padding(9));
		GForm0.smethod_61((Form)(object)this, bool_0: false);
		GForm0.smethod_62((Form)(object)this, (FormStartPosition)4);
		GForm0.smethod_63((Form)(object)this, "About");
		GForm0.smethod_64((Control)(object)TableLayoutPanel_0, bool_0: false);
		GForm0.smethod_65((Control)(object)TableLayoutPanel_0);
		GForm0.smethod_66((ISupportInitialize)PictureBox_0);
		GForm0.smethod_67((Control)(object)this, bool_0: false);
	}

	private void method_1(object sender, EventArgs e)
	{
		string object_ = ((GForm0.smethod_70(GForm0.smethod_69(GForm0.smethod_68((ApplicationBase)(object)Class1.Form0_0)), "", bool_0: false) == 0) ? GForm0.smethod_72(GForm0.smethod_71(GForm0.smethod_68((ApplicationBase)(object)Class1.Form0_0))) : GForm0.smethod_69(GForm0.smethod_68((ApplicationBase)(object)Class1.Form0_0)));
		GForm0.smethod_63((Form)(object)this, GForm0.smethod_73("About {0}", (object)object_));
		GForm0.smethod_39(Label_0, GForm0.smethod_74(GForm0.smethod_68((ApplicationBase)(object)Class1.Form0_0)));
		GForm0.smethod_39(Label_1, GForm0.smethod_73("Version {0}", (object)GForm0.smethod_76(GForm0.smethod_75(GForm0.smethod_68((ApplicationBase)(object)Class1.Form0_0)))));
		GForm0.smethod_39(Label_3, GForm0.smethod_77(GForm0.smethod_68((ApplicationBase)(object)Class1.Form0_0)));
		GForm0.smethod_39(Label_2, GForm0.smethod_78(GForm0.smethod_68((ApplicationBase)(object)Class1.Form0_0)));
		GForm0.smethod_46(TextBox_0, GForm0.smethod_79(GForm0.smethod_68((ApplicationBase)(object)Class1.Form0_0)));
	}

	private void method_2(object sender, EventArgs e)
	{
		GForm0.smethod_80((Form)(object)this);
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_2(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_3(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_5(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static TableLayoutPanel smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TableLayoutPanel();
	}

	static PictureBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Label smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_13(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_14(TableLayoutPanel tableLayoutPanel_1, int int_0)
	{
		tableLayoutPanel_1.set_ColumnCount(int_0);
	}

	static TableLayoutColumnStyleCollection smethod_15(TableLayoutPanel tableLayoutPanel_1)
	{
		return tableLayoutPanel_1.get_ColumnStyles();
	}

	static ColumnStyle smethod_16(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ColumnStyle(sizeType_0, float_0);
	}

	static int smethod_17(TableLayoutColumnStyleCollection tableLayoutColumnStyleCollection_0, ColumnStyle columnStyle_0)
	{
		return tableLayoutColumnStyleCollection_0.Add(columnStyle_0);
	}

	static TableLayoutControlCollection smethod_18(TableLayoutPanel tableLayoutPanel_1)
	{
		return tableLayoutPanel_1.get_Controls();
	}

	static void smethod_19(TableLayoutControlCollection tableLayoutControlCollection_0, Control control_0, int int_0, int int_1)
	{
		tableLayoutControlCollection_0.Add(control_0, int_0, int_1);
	}

	static void smethod_20(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static void smethod_21(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_22(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_23(TableLayoutPanel tableLayoutPanel_1, int int_0)
	{
		tableLayoutPanel_1.set_RowCount(int_0);
	}

	static TableLayoutRowStyleCollection smethod_24(TableLayoutPanel tableLayoutPanel_1)
	{
		return tableLayoutPanel_1.get_RowStyles();
	}

	static RowStyle smethod_25(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new RowStyle(sizeType_0, float_0);
	}

	static int smethod_26(TableLayoutRowStyleCollection tableLayoutRowStyleCollection_0, RowStyle rowStyle_0)
	{
		return tableLayoutRowStyleCollection_0.Add(rowStyle_0);
	}

	static void smethod_27(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_28(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static object smethod_29(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_30(PictureBox pictureBox_1, Image image_0)
	{
		pictureBox_1.set_Image(image_0);
	}

	static void smethod_31(TableLayoutPanel tableLayoutPanel_1, Control control_0, int int_0)
	{
		tableLayoutPanel_1.SetRowSpan(control_0, int_0);
	}

	static void smethod_32(PictureBox pictureBox_1, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_1.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_33(PictureBox pictureBox_1, int int_0)
	{
		pictureBox_1.set_TabIndex(int_0);
	}

	static void smethod_34(PictureBox pictureBox_1, bool bool_0)
	{
		pictureBox_1.set_TabStop(bool_0);
	}

	static Font smethod_35(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_36(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_37(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_38(Control control_0, Size size_0)
	{
		control_0.set_MaximumSize(size_0);
	}

	static void smethod_39(Label label_4, string string_0)
	{
		label_4.set_Text(string_0);
	}

	static void smethod_40(Label label_4, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_4.set_TextAlign(contentAlignment_0);
	}

	static void smethod_41(TextBox textBox_1, bool bool_0)
	{
		textBox_1.set_Multiline(bool_0);
	}

	static void smethod_42(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_43(TextBox textBox_1, ScrollBars scrollBars_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		textBox_1.set_ScrollBars(scrollBars_0);
	}

	static void smethod_44(Control control_0, bool bool_0)
	{
		control_0.set_TabStop(bool_0);
	}

	static string smethod_45(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetString(string_0);
	}

	static void smethod_46(TextBox textBox_1, string string_0)
	{
		textBox_1.set_Text(string_0);
	}

	static void smethod_47(Control control_0, AnchorStyles anchorStyles_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Anchor(anchorStyles_0);
	}

	static void smethod_48(Button button_1, DialogResult dialogResult_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		button_1.set_DialogResult(dialogResult_0);
	}

	static void smethod_49(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_50(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_51(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_52(Form form_0, IButtonControl ibuttonControl_0)
	{
		form_0.set_CancelButton(ibuttonControl_0);
	}

	static void smethod_53(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_54(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_55(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_56(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_57(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_58(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_59(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_60(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Padding(padding_0);
	}

	static void smethod_61(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_62(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_63(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_64(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_65(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_66(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_67(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static AssemblyInfo smethod_68(ApplicationBase applicationBase_0)
	{
		return applicationBase_0.get_Info();
	}

	static string smethod_69(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_Title();
	}

	static int smethod_70(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static string smethod_71(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_AssemblyName();
	}

	static string smethod_72(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	static string smethod_73(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static string smethod_74(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_ProductName();
	}

	static Version smethod_75(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_Version();
	}

	static string smethod_76(Version version_0)
	{
		return version_0.ToString();
	}

	static string smethod_77(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_Copyright();
	}

	static string smethod_78(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_CompanyName();
	}

	static string smethod_79(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_Description();
	}

	static void smethod_80(Form form_0)
	{
		form_0.Close();
	}
}
