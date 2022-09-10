using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using ns1;

namespace ns2;

public class UnhandledExceptionForm : Form
{
	private Timer timer_0;

	private Exception exception_0;

	private IContainer icontainer_0;

	private Label headerLbl;

	private Panel panel1;

	private PictureBox appIcon;

	private Label firstLineLbl;

	private Label secondLineLbl;

	private Button sendErrorReportBtn;

	private Button closeBtn;

	private LinkLabel linkLabel1;

	private BackgroundWorker backgroundWorker_0;

	private PictureBox sendReportPic;

	private Label sendReportLbl;

	public UnhandledExceptionForm()
	{
		method_0();
	}

	private void method_0()
	{
		method_0();
	}

	public UnhandledExceptionForm(Exception exception_1)
	{
		InitializeComponent();
		appIcon.set_Image((Image)(object)Icon.ExtractAssociatedIcon(Application.get_ExecutablePath()).ToBitmap());
		((Form)this).set_Icon(Icon.ExtractAssociatedIcon(Application.get_ExecutablePath()));
		exception_0 = exception_1;
		((Control)headerLbl).set_Text(string.Format(((Control)headerLbl).get_Text(), GClass1.smethod_3()));
		((Control)firstLineLbl).set_Text(string.Format(((Control)firstLineLbl).get_Text(), GClass1.smethod_2()));
		((Control)secondLineLbl).set_Text(string.Format(((Control)secondLineLbl).get_Text(), GClass1.smethod_3()));
	}

	private void sendErrorReportBtn_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		timer_0 = new Timer();
		timer_0.set_Interval(150);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_0.Start();
		((Control)sendReportLbl).set_Visible(true);
		((Control)sendReportLbl).set_Text("Sending error report...");
		backgroundWorker_0.RunWorkerAsync();
	}

	private void closeBtn_Click(object sender, EventArgs e)
	{
		Environment.Exit(1);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		((Control)sendReportPic).set_Visible(!((Control)sendReportPic).get_Visible());
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			timer_0 = null;
		}
		((Control)sendReportLbl).set_Text("Error report sent successfully");
		((Control)sendReportPic).set_Visible(true);
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		GClass1 gClass = new GClass1(exception_0);
		gClass.method_0();
	}

	[Obfuscation]
	public static void r()
	{
		AppDomain.CurrentDomain.UnhandledException += smethod_1;
		Application.add_ThreadException((ThreadExceptionEventHandler)smethod_0);
	}

	private static void smethod_0(object sender, ThreadExceptionEventArgs e)
	{
		smethod_2(e.Exception);
	}

	private static void smethod_1(object sender, UnhandledExceptionEventArgs e)
	{
		smethod_2(e.ExceptionObject as Exception);
	}

	private static void smethod_2(Exception exception_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (exception_1 != null && Environment.UserInteractive)
		{
			UnhandledExceptionForm unhandledExceptionForm = new UnhandledExceptionForm(exception_1);
			((Form)unhandledExceptionForm).ShowDialog();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UnhandledExceptionForm));
		headerLbl = new Label();
		panel1 = new Panel();
		appIcon = new PictureBox();
		firstLineLbl = new Label();
		secondLineLbl = new Label();
		sendErrorReportBtn = new Button();
		closeBtn = new Button();
		linkLabel1 = new LinkLabel();
		backgroundWorker_0 = new BackgroundWorker();
		sendReportPic = new PictureBox();
		sendReportLbl = new Label();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)appIcon).BeginInit();
		((ISupportInitialize)sendReportPic).BeginInit();
		((Control)this).SuspendLayout();
		((Control)headerLbl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)177));
		((Control)headerLbl).set_Location(new Point(14, 10));
		((Control)headerLbl).set_Name("headerLbl");
		((Control)headerLbl).set_Size(new Size(381, 37));
		((Control)headerLbl).set_TabIndex(0);
		((Control)headerLbl).set_Text("{0} has encountered a problem. We are sorry for the inconvenience.");
		((Control)panel1).set_BackColor(Color.White);
		((Control)panel1).get_Controls().Add((Control)(object)appIcon);
		((Control)panel1).get_Controls().Add((Control)(object)headerLbl);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(477, 58));
		((Control)panel1).set_TabIndex(2);
		((Control)appIcon).set_Location(new Point(413, 3));
		((Control)appIcon).set_Name("appIcon");
		((Control)appIcon).set_Size(new Size(54, 50));
		appIcon.set_SizeMode((PictureBoxSizeMode)3);
		appIcon.set_TabIndex(1);
		appIcon.set_TabStop(false);
		((Control)firstLineLbl).set_AutoSize(true);
		((Control)firstLineLbl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)177));
		((Control)firstLineLbl).set_Location(new Point(24, 78));
		((Control)firstLineLbl).set_Name("firstLineLbl");
		((Control)firstLineLbl).set_Size(new Size(199, 13));
		((Control)firstLineLbl).set_TabIndex(3);
		((Control)firstLineLbl).set_Text("Please tell {0} about this problem.");
		((Control)secondLineLbl).set_Location(new Point(24, 102));
		((Control)secondLineLbl).set_Name("secondLineLbl");
		((Control)secondLineLbl).set_Size(new Size(397, 36));
		((Control)secondLineLbl).set_TabIndex(4);
		((Control)secondLineLbl).set_Text("We have created an error report that you can send to help us improve {0}. We will treat this report as confidential and anonymous.");
		((Control)sendErrorReportBtn).set_Location(new Point(280, 204));
		((Control)sendErrorReportBtn).set_Name("sendErrorReportBtn");
		((Control)sendErrorReportBtn).set_Size(new Size(106, 26));
		((Control)sendErrorReportBtn).set_TabIndex(5);
		((Control)sendErrorReportBtn).set_Text("&Send Error Report");
		((ButtonBase)sendErrorReportBtn).set_UseVisualStyleBackColor(true);
		((Control)sendErrorReportBtn).add_Click((EventHandler)sendErrorReportBtn_Click);
		((Control)closeBtn).set_Location(new Point(392, 204));
		((Control)closeBtn).set_Name("closeBtn");
		((Control)closeBtn).set_Size(new Size(75, 26));
		((Control)closeBtn).set_TabIndex(6);
		((Control)closeBtn).set_Text("&Close");
		((ButtonBase)closeBtn).set_UseVisualStyleBackColor(true);
		((Control)closeBtn).add_Click((EventHandler)closeBtn_Click);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Location(new Point(23, 204));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(200, 13));
		((Control)linkLabel1).set_TabIndex(7);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("What data does this error report contain?");
		((Control)linkLabel1).set_Visible(false);
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
		sendReportPic.set_Image((Image)componentResourceManager.GetObject("sendReportPic.Image"));
		((Control)sendReportPic).set_Location(new Point(27, 160));
		((Control)sendReportPic).set_Name("sendReportPic");
		((Control)sendReportPic).set_Size(new Size(20, 20));
		sendReportPic.set_SizeMode((PictureBoxSizeMode)3);
		sendReportPic.set_TabIndex(8);
		sendReportPic.set_TabStop(false);
		((Control)sendReportPic).set_Visible(false);
		((Control)sendReportLbl).set_AutoSize(true);
		((Control)sendReportLbl).set_Location(new Point(53, 163));
		((Control)sendReportLbl).set_Name("sendReportLbl");
		((Control)sendReportLbl).set_Size(new Size(109, 13));
		((Control)sendReportLbl).set_TabIndex(9);
		((Control)sendReportLbl).set_Text("Sending error report...");
		((Control)sendReportLbl).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(477, 239));
		((Control)this).get_Controls().Add((Control)(object)sendReportLbl);
		((Control)this).get_Controls().Add((Control)(object)sendReportPic);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)closeBtn);
		((Control)this).get_Controls().Add((Control)(object)sendErrorReportBtn);
		((Control)this).get_Controls().Add((Control)(object)secondLineLbl);
		((Control)this).get_Controls().Add((Control)(object)firstLineLbl);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("UnhandledExceptionForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("UnhandledExceptionForm");
		((Control)panel1).ResumeLayout(false);
		((ISupportInitialize)appIcon).EndInit();
		((ISupportInitialize)sendReportPic).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
