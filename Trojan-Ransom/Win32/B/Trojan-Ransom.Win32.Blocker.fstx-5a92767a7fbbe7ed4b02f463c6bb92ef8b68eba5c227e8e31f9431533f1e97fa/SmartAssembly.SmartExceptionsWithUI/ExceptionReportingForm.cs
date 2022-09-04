using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;

namespace SmartAssembly.SmartExceptionsWithUI;

internal class ExceptionReportingForm : Form
{
	private ReportExceptionEventArgs reportExceptionEventArgs;

	private Thread workingThread;

	private CheckBox continueCheckBox = new CheckBox();

	private Label pleaseTellTitle = new Label();

	private Button dontSendReport = new Button();

	private Button sendReport = new Button();

	private Label pleaseTellMessage = new Label();

	private AutoHeightLabel errorMessage = new AutoHeightLabel();

	private Panel panelInformation = new Panel();

	private Panel panelSending = new Panel();

	private Button cancelSending = new Button();

	private WaitSendingReportControl waitSendingReport = new WaitSendingReportControl();

	private FeedbackControl preparingFeedback = new FeedbackControl("Preparing the error report.");

	private FeedbackControl connectingFeedback = new FeedbackControl("Connecting to server.");

	private FeedbackControl transferingFeedback = new FeedbackControl("Transferring report.");

	private FeedbackControl completedFeedback = new FeedbackControl("Error reporting completed. Thank you.");

	private Button ok = new Button();

	private Button retrySending = new Button();

	private Button saveReport = new Button();

	private HeaderControl headerControl1 = new HeaderControl(string.Format("{0} has encountered a problem.\nWe are sorry for the inconvenience.", "aGbuBtagEyu"));

	private HeaderControl headerControl2 = new HeaderControl(string.Format("Please wait while {0} is sending the report to {1} through the Internet.", "aGbuBtagEyu", "am07VwJBLgj3"));

	private PoweredBy powered = new PoweredBy();

	private Button debug = new Button();

	private bool alreadyRetried;

	private void InitializeComponent()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)panelInformation).SuspendLayout();
		((Control)panelSending).SuspendLayout();
		((Control)this).SuspendLayout();
		headerControl1.IconState = IconState.Error;
		headerControl2.IconState = IconState.Error;
		((Control)continueCheckBox).set_Anchor((AnchorStyles)6);
		((ButtonBase)continueCheckBox).set_FlatStyle((FlatStyle)3);
		((Control)continueCheckBox).set_Location(new Point(22, 98));
		((Control)continueCheckBox).set_Size(new Size(226, 16));
		((Control)continueCheckBox).set_TabIndex(13);
		((Control)continueCheckBox).set_Text("Ignore this error and attempt to &continue.");
		continueCheckBox.add_CheckedChanged((EventHandler)OnContinueCheckedChanged);
		((Control)pleaseTellTitle).set_Anchor((AnchorStyles)14);
		pleaseTellTitle.set_FlatStyle((FlatStyle)3);
		((Control)pleaseTellTitle).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)pleaseTellTitle).set_Location(new Point(20, 124));
		((Control)pleaseTellTitle).set_Size(new Size(381, 16));
		((Control)pleaseTellTitle).set_Text(string.Format("Please tell {0} about this problem.", "am07VwJBLgj3"));
		((Control)dontSendReport).set_Anchor((AnchorStyles)10);
		((ButtonBase)dontSendReport).set_FlatStyle((FlatStyle)3);
		((Control)dontSendReport).set_Size(new Size(75, 24));
		((Control)dontSendReport).set_Location(new Point(400 - ((Control)dontSendReport).get_Width(), 205));
		((Control)dontSendReport).set_TabIndex(4);
		((Control)dontSendReport).set_Text("&Don't Send");
		((Control)dontSendReport).add_Click((EventHandler)OnDontSendReportClick);
		((Control)sendReport).set_Anchor((AnchorStyles)10);
		((ButtonBase)sendReport).set_FlatStyle((FlatStyle)3);
		((Control)sendReport).set_Size(new Size(105, 24));
		((Control)sendReport).set_Location(new Point(((Control)dontSendReport).get_Left() - ((Control)sendReport).get_Width() - 6, 205));
		((Control)sendReport).set_TabIndex(3);
		((Control)sendReport).set_Text("&Send Error Report");
		((Control)sendReport).add_Click((EventHandler)OnSendReportClick);
		((Control)debug).set_Anchor((AnchorStyles)10);
		((ButtonBase)debug).set_FlatStyle((FlatStyle)3);
		((Control)debug).set_Size(new Size(64, 24));
		((Control)debug).set_Location(new Point(((Control)sendReport).get_Left() - ((Control)debug).get_Width() - 6, 205));
		((Control)debug).set_TabIndex(14);
		((Control)debug).set_Text("De&bug");
		((Control)debug).set_Visible(false);
		((Control)debug).add_Click((EventHandler)OnDebugClick);
		((Control)pleaseTellMessage).set_Anchor((AnchorStyles)14);
		pleaseTellMessage.set_FlatStyle((FlatStyle)3);
		((Control)pleaseTellMessage).set_Location(new Point(20, 140));
		((Control)pleaseTellMessage).set_Size(new Size(381, 55));
		((Control)pleaseTellMessage).set_Text(string.Format("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "am07VwJBLgj3"));
		((Control)errorMessage).set_Anchor((AnchorStyles)13);
		((Control)errorMessage).set_Location(new Point(20, 69));
		((Control)errorMessage).set_Size(new Size(381, 13));
		((Control)cancelSending).set_Anchor((AnchorStyles)10);
		((ButtonBase)cancelSending).set_FlatStyle((FlatStyle)3);
		((Control)cancelSending).set_Size(new Size(80, 24));
		((Control)cancelSending).set_Location(new Point(400 - ((Control)cancelSending).get_Width(), 205));
		((Control)cancelSending).set_TabIndex(7);
		((Control)cancelSending).set_Text("&Cancel");
		((Control)cancelSending).add_Click((EventHandler)OnCancelSending);
		((Control)ok).set_Anchor((AnchorStyles)10);
		((Control)ok).set_Enabled(false);
		((ButtonBase)ok).set_FlatStyle((FlatStyle)3);
		((Control)ok).set_Size(new Size(105, 24));
		((Control)ok).set_Location(new Point(((Control)cancelSending).get_Left() - ((Control)ok).get_Width() - 6, 205));
		((Control)ok).set_TabIndex(6);
		((Control)ok).set_Text("&OK");
		((Control)ok).add_Click((EventHandler)OnOK);
		((Control)retrySending).set_Anchor((AnchorStyles)10);
		((ButtonBase)retrySending).set_FlatStyle((FlatStyle)3);
		((Control)retrySending).set_Location(((Control)ok).get_Location());
		((Control)retrySending).set_Size(((Control)ok).get_Size());
		((Control)retrySending).set_TabIndex(5);
		((Control)retrySending).set_Text("&Retry");
		((Control)retrySending).set_Visible(false);
		((Control)retrySending).add_Click((EventHandler)OnRetry);
		((Control)saveReport).set_Anchor((AnchorStyles)10);
		((ButtonBase)saveReport).set_FlatStyle((FlatStyle)3);
		((Control)saveReport).set_Location(((Control)ok).get_Location());
		((Control)saveReport).set_Size(((Control)ok).get_Size());
		((Control)saveReport).set_TabIndex(5);
		((Control)saveReport).set_Text("Save Report");
		((Control)saveReport).set_Visible(false);
		((Control)saveReport).add_Click((EventHandler)OnSaveReport);
		((Control)waitSendingReport).set_Location(new Point(87, 146));
		((Control)waitSendingReport).set_Visible(false);
		((Control)preparingFeedback).SetBounds(24, 72, 368, 16);
		((Control)connectingFeedback).SetBounds(24, 96, 368, 16);
		((Control)transferingFeedback).SetBounds(24, 120, 368, 16);
		((Control)completedFeedback).SetBounds(24, 144, 368, 16);
		((Control)powered).set_Anchor((AnchorStyles)6);
		((Control)powered).SetBounds(20, 444, 120, 32);
		((Control)panelInformation).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)debug,
			(Control)continueCheckBox,
			(Control)pleaseTellTitle,
			(Control)dontSendReport,
			(Control)sendReport,
			(Control)pleaseTellMessage,
			(Control)errorMessage,
			headerControl1
		});
		((Control)panelInformation).set_Size(new Size(413, 240));
		((Control)panelInformation).set_TabIndex(0);
		((Control)panelSending).get_Controls().AddRange((Control[])(object)new Control[10]
		{
			(Control)cancelSending,
			(Control)ok,
			(Control)retrySending,
			(Control)saveReport,
			waitSendingReport,
			headerControl2,
			preparingFeedback,
			connectingFeedback,
			transferingFeedback,
			completedFeedback
		});
		((Control)panelSending).set_Size(new Size(413, 240));
		((Control)panelSending).set_TabIndex(2);
		((Control)panelSending).set_Visible(false);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(434, 488));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			powered,
			(Control)panelInformation,
			(Control)panelSending
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("aGbuBtagEyu");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("Error Reporting");
		}
		try
		{
			((Form)this).set_TopMost(true);
		}
		catch
		{
		}
		((Control)panelInformation).ResumeLayout(false);
		((Control)panelSending).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)retrySending).BringToFront();
		((Control)saveReport).BringToFront();
		((Form)this).set_Size(new Size(419, 264));
		((Control)panelSending).set_Dock((DockStyle)5);
		((Control)panelInformation).set_Dock((DockStyle)5);
	}

	private void OnSaveReport(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_Title("Save Report");
		((FileDialog)val).set_DefaultExt("saencryptedreport");
		((FileDialog)val).set_Filter("SmartAssembly Encrypted Exception Report|*.saencryptedreport");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			reportExceptionEventArgs.SaveEncryptedReport(((FileDialog)val).get_FileName());
			((Form)this).Close();
		}
	}

	private void OnSendReportClick(object sender, EventArgs e)
	{
		try
		{
			((Control)panelInformation).set_Visible(false);
			((Control)panelSending).set_Visible(true);
			((Control)powered).set_Visible(true);
			if (reportExceptionEventArgs != null)
			{
				StartWorkingThread(StartSendReport);
			}
		}
		catch
		{
		}
	}

	private void StartWorkingThread(ThreadStart threadStart_0)
	{
		workingThread = new Thread(threadStart_0);
		workingThread.Start();
	}

	private void OnDontSendReportClick(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void OnCancelSending(object sender, EventArgs e)
	{
		try
		{
			if (workingThread != null)
			{
				workingThread.Abort();
			}
		}
		catch
		{
		}
		((Form)this).Close();
	}

	private void OnOK(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void OnContinueCheckedChanged(object sender, EventArgs e)
	{
		reportExceptionEventArgs.TryToContinue = continueCheckBox.get_Checked();
	}

	private void OnFeedback(object sender, SendingReportFeedbackEventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new SendingReportFeedbackEventHandler(Feedback), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void OnDebuggerLaunched(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new EventHandler(DebuggerLaunched), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		if (workingThread != null && workingThread.IsAlive)
		{
			workingThread.Abort();
		}
		((Form)this).OnClosing(e);
	}

	private void Feedback(object sender, SendingReportFeedbackEventArgs e)
	{
		Button val = ((!alreadyRetried || Thread.CurrentThread.ApartmentState != 0) ? retrySending : saveReport);
		switch (e.Step)
		{
		case SendingReportStep.PreparingReport:
			if (e.Failed)
			{
				preparingFeedback.Stop(e.ErrorMessage);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				preparingFeedback.Start();
			}
			break;
		case SendingReportStep.ConnectingToServer:
			if (e.Failed)
			{
				connectingFeedback.Stop(e.ErrorMessage);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				preparingFeedback.Stop();
				connectingFeedback.Start();
			}
			break;
		case SendingReportStep.Transfering:
			if (e.Failed)
			{
				((Control)waitSendingReport).set_Visible(false);
				transferingFeedback.Stop(e.ErrorMessage);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				connectingFeedback.Stop();
				transferingFeedback.Start();
				((Control)waitSendingReport).set_Visible(true);
			}
			break;
		case SendingReportStep.Finished:
			((Control)waitSendingReport).set_Visible(false);
			transferingFeedback.Stop();
			completedFeedback.Stop();
			((Control)ok).set_Enabled(true);
			((Control)ok).Focus();
			((Control)cancelSending).set_Enabled(false);
			break;
		}
	}

	private void DebuggerLaunched(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void OnRetry(object sender, EventArgs e)
	{
		alreadyRetried = true;
		((Control)retrySending).set_Visible(false);
		preparingFeedback.Init();
		connectingFeedback.Init();
		transferingFeedback.Init();
		if (reportExceptionEventArgs != null)
		{
			StartWorkingThread(StartSendReport);
		}
	}

	private void StartSendReport()
	{
		reportExceptionEventArgs.SendReport();
	}

	private void OnDebugClick(object sender, EventArgs e)
	{
		if (reportExceptionEventArgs != null)
		{
			StartWorkingThread(reportExceptionEventArgs.LaunchDebugger);
		}
	}

	public ExceptionReportingForm(UnhandledExceptionHandler unhandledExceptionHandler_0, ReportExceptionEventArgs reportExceptionEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		InitializeComponent();
		int height = ((Control)this).get_Height();
		reportExceptionEventArgs = reportExceptionEventArgs_0;
		((Control)errorMessage).set_Text(reportExceptionEventArgs_0.Exception.Message);
		height += ((Control)errorMessage).get_Height() - ((Control)this).get_FontHeight();
		if (!reportExceptionEventArgs_0.ShowContinueCheckbox)
		{
			((Control)continueCheckBox).set_Visible(false);
			height -= ((Control)continueCheckBox).get_Height();
		}
		if (height > ((Control)this).get_Height())
		{
			((Control)this).set_Height(height);
		}
		if (reportExceptionEventArgs_0.CanDebug)
		{
			unhandledExceptionHandler_0.DebuggerLaunched += OnDebuggerLaunched;
			((Control)debug).set_Visible(true);
			if (((Control)debug).get_Left() < ((Control)powered).get_Right())
			{
				((Control)powered).set_Visible(false);
			}
		}
		if (!reportExceptionEventArgs_0.CanSendReport)
		{
			((Control)sendReport).set_Enabled(false);
			if (((Control)dontSendReport).get_CanFocus())
			{
				((Control)dontSendReport).Focus();
			}
		}
		unhandledExceptionHandler_0.SendingReportFeedback += OnFeedback;
	}
}
