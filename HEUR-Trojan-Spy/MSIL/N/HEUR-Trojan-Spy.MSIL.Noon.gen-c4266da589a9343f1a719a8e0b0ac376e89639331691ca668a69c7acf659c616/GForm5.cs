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
public sealed class GForm5 : Form
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ApplicationTitle")]
	private Label label_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MainLayoutPanel")]
	private TableLayoutPanel tableLayoutPanel_0;

	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label1")]
	private Label label_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DetailsLayoutPanel")]
	private TableLayoutPanel tableLayoutPanel_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Version")]
	private Label label_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label2")]
	private Label label_3;

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
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			MouseEventHandler mouseEventHandler_ = new MouseEventHandler(method_2);
			MouseEventHandler mouseEventHandler_2 = new MouseEventHandler(method_3);
			EventHandler eventHandler_ = method_4;
			EventHandler eventHandler_2 = method_5;
			TableLayoutPanel val = tableLayoutPanel_0;
			if (val != null)
			{
				GForm5.smethod_2((Control)(object)val, mouseEventHandler_);
				GForm5.smethod_3((Control)(object)val, mouseEventHandler_2);
				GForm5.smethod_4((Control)(object)val, eventHandler_);
				GForm5.smethod_5((Control)(object)val, eventHandler_2);
			}
			tableLayoutPanel_0 = value;
			val = tableLayoutPanel_0;
			if (val != null)
			{
				GForm5.smethod_6((Control)(object)val, mouseEventHandler_);
				GForm5.smethod_7((Control)(object)val, mouseEventHandler_2);
				GForm5.smethod_8((Control)(object)val, eventHandler_);
				GForm5.smethod_9((Control)(object)val, eventHandler_2);
			}
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

	internal virtual TableLayoutPanel TableLayoutPanel_1
	{
		[CompilerGenerated]
		get
		{
			return tableLayoutPanel_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			tableLayoutPanel_1 = value;
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

	public GForm5()
	{
		GForm5.smethod_0((Form)(object)this, (EventHandler)method_1);
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GForm5.smethod_1((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = GForm5.smethod_11(GForm5.smethod_10(typeof(GForm5).TypeHandle));
		TableLayoutPanel_0 = GForm5.smethod_12();
		TableLayoutPanel_1 = GForm5.smethod_12();
		Label_2 = GForm5.smethod_13();
		Label_1 = GForm5.smethod_13();
		Label_3 = GForm5.smethod_13();
		Label_0 = GForm5.smethod_13();
		PictureBox_0 = GForm5.smethod_14();
		GForm5.smethod_15((Control)(object)TableLayoutPanel_0);
		GForm5.smethod_15((Control)(object)TableLayoutPanel_1);
		GForm5.smethod_16((ISupportInitialize)PictureBox_0);
		GForm5.smethod_17((Control)(object)this);
		GForm5.smethod_18((Control)(object)TableLayoutPanel_0, Color.White);
		GForm5.smethod_19((Control)(object)TableLayoutPanel_0, (ImageLayout)0);
		GForm5.smethod_20(TableLayoutPanel_0, 2);
		GForm5.smethod_23(GForm5.smethod_21(TableLayoutPanel_0), GForm5.smethod_22((SizeType)1, 243f));
		GForm5.smethod_23(GForm5.smethod_21(TableLayoutPanel_0), GForm5.smethod_22((SizeType)1, 100f));
		GForm5.smethod_25(GForm5.smethod_24(TableLayoutPanel_0), (Control)(object)TableLayoutPanel_1, 1, 1);
		GForm5.smethod_25(GForm5.smethod_24(TableLayoutPanel_0), (Control)(object)Label_0, 1, 0);
		GForm5.smethod_25(GForm5.smethod_24(TableLayoutPanel_0), (Control)(object)PictureBox_0, 0, 0);
		GForm5.smethod_26((Control)(object)TableLayoutPanel_0, (DockStyle)5);
		GForm5.smethod_27((Control)(object)TableLayoutPanel_0, new Point(0, 0));
		GForm5.smethod_28((Control)(object)TableLayoutPanel_0, "MainLayoutPanel");
		GForm5.smethod_29(TableLayoutPanel_0, 3);
		GForm5.smethod_32(GForm5.smethod_30(TableLayoutPanel_0), GForm5.smethod_31((SizeType)1, 218f));
		GForm5.smethod_32(GForm5.smethod_30(TableLayoutPanel_0), GForm5.smethod_31((SizeType)1, 67f));
		GForm5.smethod_32(GForm5.smethod_30(TableLayoutPanel_0), GForm5.smethod_31((SizeType)1, 18f));
		GForm5.smethod_33((Control)(object)TableLayoutPanel_0, new Size(496, 303));
		GForm5.smethod_34((Control)(object)TableLayoutPanel_0, 0);
		GForm5.smethod_35((Control)(object)TableLayoutPanel_1, (AnchorStyles)0);
		GForm5.smethod_18((Control)(object)TableLayoutPanel_1, Color.Transparent);
		GForm5.smethod_20(TableLayoutPanel_1, 1);
		GForm5.smethod_23(GForm5.smethod_21(TableLayoutPanel_1), GForm5.smethod_22((SizeType)1, 247f));
		GForm5.smethod_23(GForm5.smethod_21(TableLayoutPanel_1), GForm5.smethod_22((SizeType)1, 142f));
		GForm5.smethod_25(GForm5.smethod_24(TableLayoutPanel_1), (Control)(object)Label_2, 0, 0);
		GForm5.smethod_25(GForm5.smethod_24(TableLayoutPanel_1), (Control)(object)Label_1, 0, 1);
		GForm5.smethod_25(GForm5.smethod_24(TableLayoutPanel_1), (Control)(object)Label_3, 0, 2);
		GForm5.smethod_27((Control)(object)TableLayoutPanel_1, new Point(246, 221));
		GForm5.smethod_28((Control)(object)TableLayoutPanel_1, "DetailsLayoutPanel");
		GForm5.smethod_29(TableLayoutPanel_1, 3);
		GForm5.smethod_32(GForm5.smethod_30(TableLayoutPanel_1), GForm5.smethod_31((SizeType)2, 33f));
		GForm5.smethod_32(GForm5.smethod_30(TableLayoutPanel_1), GForm5.smethod_31((SizeType)2, 33f));
		GForm5.smethod_32(GForm5.smethod_30(TableLayoutPanel_1), GForm5.smethod_31((SizeType)1, 20f));
		GForm5.smethod_33((Control)(object)TableLayoutPanel_1, new Size(247, 61));
		GForm5.smethod_34((Control)(object)TableLayoutPanel_1, 1);
		GForm5.smethod_35((Control)(object)Label_2, (AnchorStyles)0);
		GForm5.smethod_18((Control)(object)Label_2, Color.Transparent);
		GForm5.smethod_37((Control)(object)Label_2, GForm5.smethod_36("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm5.smethod_27((Control)(object)Label_2, new Point(3, 0));
		GForm5.smethod_28((Control)(object)Label_2, "Version");
		GForm5.smethod_33((Control)(object)Label_2, new Size(241, 20));
		GForm5.smethod_34((Control)(object)Label_2, 1);
		GForm5.smethod_38(Label_2, "Version {0}.{1:00}");
		GForm5.smethod_35((Control)(object)Label_1, (AnchorStyles)6);
		GForm5.smethod_37((Control)(object)Label_1, GForm5.smethod_36("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm5.smethod_27((Control)(object)Label_1, new Point(3, 20));
		GForm5.smethod_28((Control)(object)Label_1, "Label1");
		GForm5.smethod_33((Control)(object)Label_1, new Size(237, 20));
		GForm5.smethod_34((Control)(object)Label_1, 3);
		GForm5.smethod_38(Label_1, "By Russell \"Codey\" Mazonde");
		GForm5.smethod_35((Control)(object)Label_3, (AnchorStyles)6);
		GForm5.smethod_37((Control)(object)Label_3, GForm5.smethod_36("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm5.smethod_27((Control)(object)Label_3, new Point(3, 40));
		GForm5.smethod_28((Control)(object)Label_3, "Label2");
		GForm5.smethod_33((Control)(object)Label_3, new Size(237, 21));
		GForm5.smethod_34((Control)(object)Label_3, 3);
		GForm5.smethod_38(Label_3, "The Genius Behind GenuS");
		GForm5.smethod_35((Control)(object)Label_0, (AnchorStyles)0);
		GForm5.smethod_18((Control)(object)Label_0, Color.Transparent);
		GForm5.smethod_37((Control)(object)Label_0, GForm5.smethod_36("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GForm5.smethod_27((Control)(object)Label_0, new Point(246, 3));
		GForm5.smethod_28((Control)(object)Label_0, "ApplicationTitle");
		GForm5.smethod_33((Control)(object)Label_0, new Size(247, 212));
		GForm5.smethod_34((Control)(object)Label_0, 0);
		GForm5.smethod_38(Label_0, "Russell's Notebook");
		GForm5.smethod_39(Label_0, (ContentAlignment)256);
		GForm5.smethod_41(PictureBox_0, (Image)GForm5.smethod_40((ResourceManager)resourceManager_, "PictureBox1.Image"));
		GForm5.smethod_27((Control)(object)PictureBox_0, new Point(3, 3));
		GForm5.smethod_28((Control)(object)PictureBox_0, "PictureBox1");
		GForm5.smethod_33((Control)(object)PictureBox_0, new Size(237, 212));
		GForm5.smethod_42(PictureBox_0, (PictureBoxSizeMode)1);
		GForm5.smethod_43(PictureBox_0, 2);
		GForm5.smethod_44(PictureBox_0, bool_0: false);
		GForm5.smethod_45((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm5.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm5.smethod_47((Form)(object)this, new Size(496, 303));
		GForm5.smethod_48((Form)(object)this, bool_0: false);
		GForm5.smethod_50(GForm5.smethod_49((Control)(object)this), (Control)(object)TableLayoutPanel_0);
		GForm5.smethod_51((Form)(object)this, (FormBorderStyle)1);
		GForm5.smethod_52((Form)(object)this, bool_0: false);
		GForm5.smethod_53((Form)(object)this, bool_0: false);
		GForm5.smethod_54((Control)(object)this, "Russell");
		GForm5.smethod_55((Form)(object)this, bool_0: false);
		GForm5.smethod_56((Form)(object)this, (FormStartPosition)1);
		GForm5.smethod_57((Control)(object)TableLayoutPanel_0, bool_0: false);
		GForm5.smethod_57((Control)(object)TableLayoutPanel_1, bool_0: false);
		GForm5.smethod_58((ISupportInitialize)PictureBox_0);
		GForm5.smethod_59((Control)(object)this, bool_0: false);
	}

	private void method_1(object sender, EventArgs e)
	{
		if (GForm5.smethod_62(GForm5.smethod_61(GForm5.smethod_60((ApplicationBase)(object)Class1.Form0_0)), "", bool_0: false) != 0)
		{
			GForm5.smethod_38(Label_0, GForm5.smethod_61(GForm5.smethod_60((ApplicationBase)(object)Class1.Form0_0)));
		}
		else
		{
			GForm5.smethod_38(Label_0, GForm5.smethod_64(GForm5.smethod_63(GForm5.smethod_60((ApplicationBase)(object)Class1.Form0_0))));
		}
		GForm5.smethod_38(Label_2, GForm5.smethod_69(GForm5.smethod_65(Label_2), (object)GForm5.smethod_67(GForm5.smethod_66(GForm5.smethod_60((ApplicationBase)(object)Class1.Form0_0))), (object)GForm5.smethod_68(GForm5.smethod_66(GForm5.smethod_60((ApplicationBase)(object)Class1.Form0_0)))));
	}

	private void method_2(object sender, MouseEventArgs e)
	{
	}

	private void method_3(object sender, MouseEventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_2(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.remove_MouseClick(mouseEventHandler_0);
	}

	static void smethod_3(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.remove_MouseDoubleClick(mouseEventHandler_0);
	}

	static void smethod_4(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseEnter(eventHandler_0);
	}

	static void smethod_5(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseHover(eventHandler_0);
	}

	static void smethod_6(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseClick(mouseEventHandler_0);
	}

	static void smethod_7(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseDoubleClick(mouseEventHandler_0);
	}

	static void smethod_8(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseEnter(eventHandler_0);
	}

	static void smethod_9(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseHover(eventHandler_0);
	}

	static Type smethod_10(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_11(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static TableLayoutPanel smethod_12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TableLayoutPanel();
	}

	static Label smethod_13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static PictureBox smethod_14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_15(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_16(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_17(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_18(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_19(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_20(TableLayoutPanel tableLayoutPanel_2, int int_0)
	{
		tableLayoutPanel_2.set_ColumnCount(int_0);
	}

	static TableLayoutColumnStyleCollection smethod_21(TableLayoutPanel tableLayoutPanel_2)
	{
		return tableLayoutPanel_2.get_ColumnStyles();
	}

	static ColumnStyle smethod_22(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ColumnStyle(sizeType_0, float_0);
	}

	static int smethod_23(TableLayoutColumnStyleCollection tableLayoutColumnStyleCollection_0, ColumnStyle columnStyle_0)
	{
		return tableLayoutColumnStyleCollection_0.Add(columnStyle_0);
	}

	static TableLayoutControlCollection smethod_24(TableLayoutPanel tableLayoutPanel_2)
	{
		return tableLayoutPanel_2.get_Controls();
	}

	static void smethod_25(TableLayoutControlCollection tableLayoutControlCollection_0, Control control_0, int int_0, int int_1)
	{
		tableLayoutControlCollection_0.Add(control_0, int_0, int_1);
	}

	static void smethod_26(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static void smethod_27(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_28(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_29(TableLayoutPanel tableLayoutPanel_2, int int_0)
	{
		tableLayoutPanel_2.set_RowCount(int_0);
	}

	static TableLayoutRowStyleCollection smethod_30(TableLayoutPanel tableLayoutPanel_2)
	{
		return tableLayoutPanel_2.get_RowStyles();
	}

	static RowStyle smethod_31(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new RowStyle(sizeType_0, float_0);
	}

	static int smethod_32(TableLayoutRowStyleCollection tableLayoutRowStyleCollection_0, RowStyle rowStyle_0)
	{
		return tableLayoutRowStyleCollection_0.Add(rowStyle_0);
	}

	static void smethod_33(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_34(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_35(Control control_0, AnchorStyles anchorStyles_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Anchor(anchorStyles_0);
	}

	static Font smethod_36(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_37(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_38(Label label_4, string string_0)
	{
		label_4.set_Text(string_0);
	}

	static void smethod_39(Label label_4, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_4.set_TextAlign(contentAlignment_0);
	}

	static object smethod_40(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_41(PictureBox pictureBox_1, Image image_0)
	{
		pictureBox_1.set_Image(image_0);
	}

	static void smethod_42(PictureBox pictureBox_1, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_1.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_43(PictureBox pictureBox_1, int int_0)
	{
		pictureBox_1.set_TabIndex(int_0);
	}

	static void smethod_44(PictureBox pictureBox_1, bool bool_0)
	{
		pictureBox_1.set_TabStop(bool_0);
	}

	static void smethod_45(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_46(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_47(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static void smethod_48(Form form_0, bool bool_0)
	{
		form_0.set_ControlBox(bool_0);
	}

	static ControlCollection smethod_49(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_50(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_51(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_52(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_53(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_54(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_55(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_56(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_57(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_58(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_59(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static AssemblyInfo smethod_60(ApplicationBase applicationBase_0)
	{
		return applicationBase_0.get_Info();
	}

	static string smethod_61(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_Title();
	}

	static int smethod_62(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static string smethod_63(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_AssemblyName();
	}

	static string smethod_64(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	static string smethod_65(Label label_4)
	{
		return label_4.get_Text();
	}

	static Version smethod_66(AssemblyInfo assemblyInfo_0)
	{
		return assemblyInfo_0.get_Version();
	}

	static int smethod_67(Version version_0)
	{
		return version_0.Major;
	}

	static int smethod_68(Version version_0)
	{
		return version_0.Minor;
	}

	static string smethod_69(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}
}
