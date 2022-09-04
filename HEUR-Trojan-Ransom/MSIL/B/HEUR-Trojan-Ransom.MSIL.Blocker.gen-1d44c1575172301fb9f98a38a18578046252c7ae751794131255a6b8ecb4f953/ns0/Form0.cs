using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;

namespace ns0;

[DesignerCategory("Code")]
internal sealed class Form0 : Form
{
	private CheckBox checkBox_0 = new CheckBox();

	private Button button_0;

	private Label label_0;

	private AutoHeightLabel autoHeightLabel_0;

	private Panel panel_0;

	private FeedbackControl feedbackControl_0;

	private FeedbackControl feedbackControl_1;

	private FeedbackControl feedbackControl_2;

	private Button button_1;

	private Button button_2;

	private HeaderControl headerControl_0;

	private PoweredBy poweredBy_0;

	private Button button_3;

	private bool bool_0;

	internal ReportExceptionEventArgs reportExceptionEventArgs_0;

	internal Thread thread_0;

	internal Label label_1;

	internal Button button_4;

	internal Panel panel_1;

	internal Button button_5;

	internal WaitSendingReportControl waitSendingReportControl_0;

	internal FeedbackControl feedbackControl_3;

	internal Button button_6;

	internal HeaderControl headerControl_1;

	private void method_0()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)panel_0).SuspendLayout();
		((Control)panel_1).SuspendLayout();
		((Control)this).SuspendLayout();
		headerControl_1.IconState = IconState.Error;
		headerControl_0.IconState = IconState.Error;
		((Control)checkBox_0).set_Anchor((AnchorStyles)6);
		((ButtonBase)checkBox_0).set_FlatStyle((FlatStyle)3);
		((Control)checkBox_0).set_Location(new Point(22, 98));
		((Control)checkBox_0).set_Size(new Size(226, 16));
		((Control)checkBox_0).set_TabIndex(13);
		((Control)checkBox_0).set_Text("Ignore this error and attempt to &continue.");
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		((Control)label_1).set_Anchor((AnchorStyles)14);
		label_1.set_FlatStyle((FlatStyle)3);
		((Control)label_1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(20, 124));
		((Control)label_1).set_Size(new Size(381, 16));
		((Control)label_1).set_Text(string.Format("Please tell {0} about this problem.", "ybgcy1txEhE"));
		((Control)button_4).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_4).set_FlatStyle((FlatStyle)3);
		((Control)button_4).set_Size(new Size(75, 24));
		((Control)button_4).set_Location(new Point(400 - ((Control)button_4).get_Width(), 205));
		((Control)button_4).set_TabIndex(4);
		((Control)button_4).set_Text("&Don't Send");
		((Control)button_4).add_Click((EventHandler)button_4_Click);
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(105, 24));
		((Control)button_0).set_Location(new Point(((Control)button_4).get_Left() - ((Control)button_0).get_Width() - 6, 205));
		((Control)button_0).set_TabIndex(3);
		((Control)button_0).set_Text("&Send Error Report");
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_3).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_3).set_FlatStyle((FlatStyle)3);
		((Control)button_3).set_Size(new Size(64, 24));
		((Control)button_3).set_Location(new Point(((Control)button_0).get_Left() - ((Control)button_3).get_Width() - 6, 205));
		((Control)button_3).set_TabIndex(14);
		((Control)button_3).set_Text("De&bug");
		((Control)button_3).set_Visible(false);
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)label_0).set_Anchor((AnchorStyles)14);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Location(new Point(20, 140));
		((Control)label_0).set_Size(new Size(381, 55));
		((Control)label_0).set_Text(string.Format("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "ybgcy1txEhE"));
		((Control)autoHeightLabel_0).set_Anchor((AnchorStyles)13);
		((Control)autoHeightLabel_0).set_Location(new Point(20, 69));
		((Control)autoHeightLabel_0).set_Size(new Size(381, 13));
		((Control)button_5).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_5).set_FlatStyle((FlatStyle)3);
		((Control)button_5).set_Size(new Size(80, 24));
		((Control)button_5).set_Location(new Point(400 - ((Control)button_5).get_Width(), 205));
		((Control)button_5).set_TabIndex(7);
		((Control)button_5).set_Text("&Cancel");
		((Control)button_5).add_Click((EventHandler)button_5_Click);
		((Control)button_1).set_Anchor((AnchorStyles)10);
		((Control)button_1).set_Enabled(false);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)3);
		((Control)button_1).set_Size(new Size(105, 24));
		((Control)button_1).set_Location(new Point(((Control)button_5).get_Left() - ((Control)button_1).get_Width() - 6, 205));
		((Control)button_1).set_TabIndex(6);
		((Control)button_1).set_Text("&OK");
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_2).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)3);
		((Control)button_2).set_Location(((Control)button_1).get_Location());
		((Control)button_2).set_Size(((Control)button_1).get_Size());
		((Control)button_2).set_TabIndex(5);
		((Control)button_2).set_Text("&Retry");
		((Control)button_2).set_Visible(false);
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)button_6).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_6).set_FlatStyle((FlatStyle)3);
		((Control)button_6).set_Location(((Control)button_1).get_Location());
		((Control)button_6).set_Size(((Control)button_1).get_Size());
		((Control)button_6).set_TabIndex(5);
		((Control)button_6).set_Text("Save Report");
		((Control)button_6).set_Visible(false);
		((Control)button_6).add_Click((EventHandler)button_6_Click);
		((Control)waitSendingReportControl_0).set_Location(new Point(87, 146));
		((Control)waitSendingReportControl_0).set_Visible(false);
		((Control)feedbackControl_0).SetBounds(24, 72, 368, 16);
		((Control)feedbackControl_1).SetBounds(24, 96, 368, 16);
		((Control)feedbackControl_3).SetBounds(24, 120, 368, 16);
		((Control)feedbackControl_2).SetBounds(24, 144, 368, 16);
		((Control)poweredBy_0).set_Anchor((AnchorStyles)6);
		((Control)poweredBy_0).SetBounds(20, 444, 120, 32);
		((Control)panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)button_3,
			(Control)checkBox_0,
			(Control)label_1,
			(Control)button_4,
			(Control)button_0,
			(Control)label_0,
			(Control)autoHeightLabel_0,
			headerControl_1
		});
		((Control)panel_0).set_Size(new Size(413, 240));
		((Control)panel_0).set_TabIndex(0);
		((Control)panel_1).get_Controls().AddRange((Control[])(object)new Control[10]
		{
			(Control)button_5,
			(Control)button_1,
			(Control)button_2,
			(Control)button_6,
			waitSendingReportControl_0,
			headerControl_0,
			feedbackControl_0,
			feedbackControl_1,
			feedbackControl_3,
			feedbackControl_2
		});
		((Control)panel_1).set_Size(new Size(413, 240));
		((Control)panel_1).set_TabIndex(2);
		((Control)panel_1).set_Visible(false);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(434, 488));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			poweredBy_0,
			(Control)panel_0,
			(Control)panel_1
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("ybgcy1txEhE");
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
		((Control)panel_0).ResumeLayout(false);
		((Control)panel_1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)button_2).BringToFront();
		((Control)button_6).BringToFront();
		((Form)this).set_Size(new Size(419, 264));
		((Control)panel_1).set_Dock((DockStyle)5);
		((Control)panel_0).set_Dock((DockStyle)5);
	}

	private void button_6_Click(object sender, EventArgs e)
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
			reportExceptionEventArgs_0.SaveEncryptedReport(((FileDialog)val).get_FileName());
			((Form)this).Close();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)panel_0).set_Visible(false);
			((Control)panel_1).set_Visible(true);
			((Control)poweredBy_0).set_Visible(true);
			if (reportExceptionEventArgs_0 != null)
			{
				method_1(method_6);
			}
		}
		catch
		{
		}
	}

	private void method_1(ThreadStart threadStart_0)
	{
		Thread thread = (thread_0 = new Thread(threadStart_0));
		thread_0.Start();
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_5_Click(object sender, EventArgs e)
	{
		try
		{
			if (thread_0 != null)
			{
				thread_0.Abort();
			}
		}
		catch
		{
		}
		((Form)this).Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		reportExceptionEventArgs_0.TryToContinue = checkBox_0.get_Checked();
	}

	private void method_2(object sender, SendingReportFeedbackEventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new SendingReportFeedbackEventHandler(method_4), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new EventHandler(method_5), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		if (thread_0 != null && thread_0.IsAlive)
		{
			thread_0.Abort();
		}
		((Form)this).OnClosing(e);
	}

	private void method_4(object sender, SendingReportFeedbackEventArgs e)
	{
		Button val = ((!bool_0 || Thread.CurrentThread.ApartmentState != 0) ? button_2 : button_6);
		switch (e.Step)
		{
		case SendingReportStep.PreparingReport:
			if (e.Failed)
			{
				feedbackControl_0.Stop(e.ErrorMessage);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				feedbackControl_0.Start();
			}
			break;
		case SendingReportStep.ConnectingToServer:
			if (e.Failed)
			{
				feedbackControl_1.Stop(e.ErrorMessage);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				feedbackControl_0.Stop();
				feedbackControl_1.Start();
			}
			break;
		case SendingReportStep.Transfering:
			if (e.Failed)
			{
				((Control)waitSendingReportControl_0).set_Visible(false);
				feedbackControl_3.Stop(e.ErrorMessage);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				feedbackControl_1.Stop();
				feedbackControl_3.Start();
				((Control)waitSendingReportControl_0).set_Visible(true);
			}
			break;
		case SendingReportStep.Finished:
			((Control)waitSendingReportControl_0).set_Visible(false);
			feedbackControl_3.Stop();
			feedbackControl_2.Stop();
			((Control)button_1).set_Enabled(true);
			((Control)button_1).Focus();
			((Control)button_5).set_Enabled(false);
			break;
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		((Control)button_2).set_Visible(false);
		feedbackControl_0.Init();
		feedbackControl_1.Init();
		feedbackControl_3.Init();
		if (reportExceptionEventArgs_0 != null)
		{
			method_1(method_6);
		}
	}

	private void method_6()
	{
		reportExceptionEventArgs_0.SendReport();
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		if (reportExceptionEventArgs_0 != null)
		{
			method_1(reportExceptionEventArgs_0.LaunchDebugger);
		}
	}

	public Form0(UnhandledExceptionHandler unhandledExceptionHandler_0, ReportExceptionEventArgs reportExceptionEventArgs_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		Label val = (label_1 = new Label());
		Button val2 = (button_4 = new Button());
		button_0 = new Button();
		label_0 = new Label();
		autoHeightLabel_0 = new AutoHeightLabel();
		panel_0 = new Panel();
		Panel val3 = (panel_1 = new Panel());
		Button val4 = (button_5 = new Button());
		WaitSendingReportControl waitSendingReportControl = (waitSendingReportControl_0 = new WaitSendingReportControl());
		feedbackControl_0 = new FeedbackControl("Preparing the error report.");
		feedbackControl_1 = new FeedbackControl("Connecting to server.");
		FeedbackControl feedbackControl = (feedbackControl_3 = new FeedbackControl("Transferring report."));
		feedbackControl_2 = new FeedbackControl("Error reporting completed. Thank you.");
		button_1 = new Button();
		button_2 = new Button();
		Button val5 = (button_6 = new Button());
		HeaderControl headerControl = (headerControl_1 = new HeaderControl(string.Format("{0} has encountered a problem.\nWe are sorry for the inconvenience.", "ybgcy1txEhE")));
		headerControl_0 = new HeaderControl(string.Format("Please wait while {0} is sending the report to {1} through the Internet.", "ybgcy1txEhE", "ybgcy1txEhE"));
		poweredBy_0 = new PoweredBy();
		button_3 = new Button();
		((Form)this)._002Ector();
		method_0();
		int height = ((Control)this).get_Height();
		ReportExceptionEventArgs reportExceptionEventArgs = (reportExceptionEventArgs_0 = reportExceptionEventArgs_1);
		((Control)autoHeightLabel_0).set_Text(reportExceptionEventArgs_1.Exception.Message);
		height += ((Control)autoHeightLabel_0).get_Height() - ((Control)this).get_FontHeight();
		if (!reportExceptionEventArgs_1.ShowContinueCheckbox)
		{
			((Control)checkBox_0).set_Visible(false);
			height -= ((Control)checkBox_0).get_Height();
		}
		if (height > ((Control)this).get_Height())
		{
			((Control)this).set_Height(height);
		}
		if (reportExceptionEventArgs_1.CanDebug)
		{
			unhandledExceptionHandler_0.DebuggerLaunched += method_3;
			((Control)button_3).set_Visible(true);
			if (((Control)button_3).get_Left() < ((Control)poweredBy_0).get_Right())
			{
				((Control)poweredBy_0).set_Visible(false);
			}
		}
		if (!reportExceptionEventArgs_1.CanSendReport)
		{
			((Control)button_0).set_Enabled(false);
			if (((Control)button_4).get_CanFocus())
			{
				((Control)button_4).Focus();
			}
		}
		unhandledExceptionHandler_0.SendingReportFeedback += method_2;
	}
}
