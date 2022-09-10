using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

[DesignerCategory("Code")]
internal sealed class Form0 : Form
{
	internal ReportExceptionEventArgs reportExceptionEventArgs_0;

	internal Thread thread_0;

	internal CheckBox checkBox_0;

	internal Label label_0;

	internal Button button_0;

	internal Button button_1;

	internal Label label_1;

	internal AutoHeightLabel autoHeightLabel_0;

	internal Panel panel_0;

	internal Panel panel_1;

	internal Button button_2;

	internal WaitSendingReportControl waitSendingReportControl_0;

	internal FeedbackControl feedbackControl_0;

	internal FeedbackControl feedbackControl_1;

	internal FeedbackControl feedbackControl_2;

	internal FeedbackControl feedbackControl_3;

	internal Button button_3;

	internal Button button_4;

	internal Button button_5;

	internal HeaderControl headerControl_0;

	internal HeaderControl headerControl_1;

	internal PoweredBy poweredBy_0;

	internal Button button_6;

	internal bool bool_0;

	private void method_0()
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		((Control)panel_0).SuspendLayout();
		((Control)panel_1).SuspendLayout();
		((Control)this).SuspendLayout();
		headerControl_0.IconState = IconState.Error;
		headerControl_1.IconState = IconState.Error;
		((Control)checkBox_0).set_Anchor((AnchorStyles)6);
		((ButtonBase)checkBox_0).set_FlatStyle((FlatStyle)3);
		((Control)checkBox_0).set_Location(new Point(22, 98));
		((Control)checkBox_0).set_Size(new Size(226, 16));
		UsageCounts.smethod_2((Control)(object)checkBox_0, 13, 571, 541);
		Class24.smethod_0((Control)(object)checkBox_0, "Ignore this error and attempt to &continue.", 1023, 1010);
		ReportSender1.smethod_0(checkBox_0, method_2, 758, 721);
		((Control)label_0).set_Anchor((AnchorStyles)14);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(20, 124));
		((Control)label_0).set_Size(new Size(381, 16));
		Class24.smethod_0((Control)(object)label_0, string.Format("Please tell {0} about this problem.", "x3S5NtHe"), 571, 566);
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(75, 24));
		((Control)button_0).set_Location(new Point(400 - ((Control)button_0).get_Width(), 205));
		UsageCounts.smethod_2((Control)(object)button_0, 4, 316, 282);
		Class24.smethod_0((Control)(object)button_0, "&Don't Send", 212, 217);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)3);
		((Control)button_1).set_Size(new Size(105, 24));
		((Control)button_1).set_Location(new Point(((Control)button_0).get_Left() - ((Control)button_1).get_Width() - 6, 205));
		UsageCounts.smethod_2((Control)(object)button_1, 3, 265, 303);
		Class24.smethod_0((Control)(object)button_1, "&Send Error Report", 74, 71);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_6).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_6).set_FlatStyle((FlatStyle)3);
		((Control)button_6).set_Size(new Size(64, 24));
		((Control)button_6).set_Location(new Point(((Control)button_1).get_Left() - ((Control)button_6).get_Width() - 6, 205));
		UsageCounts.smethod_2((Control)(object)button_6, 14, 697, 671);
		Class24.smethod_0((Control)(object)button_6, "De&bug", 889, 884);
		Class37.smethod_4((Control)(object)button_6, bool_0: false, 39, 94);
		((Control)button_6).add_Click((EventHandler)button_6_Click);
		((Control)label_1).set_Anchor((AnchorStyles)14);
		label_1.set_FlatStyle((FlatStyle)3);
		((Control)label_1).set_Location(new Point(20, 140));
		((Control)label_1).set_Size(new Size(381, 55));
		Class24.smethod_0((Control)(object)label_1, string.Format("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "x3S5NtHe"), 185, 180);
		((Control)autoHeightLabel_0).set_Anchor((AnchorStyles)13);
		((Control)autoHeightLabel_0).set_Location(new Point(20, 69));
		((Control)autoHeightLabel_0).set_Size(new Size(381, 13));
		((Control)button_2).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)3);
		((Control)button_2).set_Size(new Size(80, 24));
		((Control)button_2).set_Location(new Point(400 - ((Control)button_2).get_Width(), 205));
		UsageCounts.smethod_2((Control)(object)button_2, 7, 536, 574);
		Class24.smethod_0((Control)(object)button_2, "&Cancel", 580, 585);
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)button_3).set_Anchor((AnchorStyles)10);
		((Control)button_3).set_Enabled(false);
		((ButtonBase)button_3).set_FlatStyle((FlatStyle)3);
		((Control)button_3).set_Size(new Size(105, 24));
		((Control)button_3).set_Location(new Point(((Control)button_2).get_Left() - ((Control)button_3).get_Width() - 6, 205));
		UsageCounts.smethod_2((Control)(object)button_3, 6, 635, 605);
		Class24.smethod_0((Control)(object)button_3, "&OK", 244, 249);
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)button_4).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_4).set_FlatStyle((FlatStyle)3);
		((Control)button_4).set_Location(((Control)button_3).get_Location());
		((Control)button_4).set_Size(Attribute0.smethod_1((Control)(object)button_3, 762, 737));
		UsageCounts.smethod_2((Control)(object)button_4, 5, 213, 243);
		Class24.smethod_0((Control)(object)button_4, "&Retry", 913, 924);
		Class37.smethod_4((Control)(object)button_4, bool_0: false, 11, 114);
		((Control)button_4).add_Click((EventHandler)button_4_Click);
		((Control)button_5).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_5).set_FlatStyle((FlatStyle)3);
		((Control)button_5).set_Location(((Control)button_3).get_Location());
		((Control)button_5).set_Size(Attribute0.smethod_1((Control)(object)button_3, 601, 578));
		UsageCounts.smethod_2((Control)(object)button_5, 5, 437, 403);
		Class24.smethod_0((Control)(object)button_5, "Save Report", 909, 896);
		Class37.smethod_4((Control)(object)button_5, bool_0: false, 606, 551);
		((Control)button_5).add_Click((EventHandler)button_5_Click);
		((Control)waitSendingReportControl_0).set_Location(new Point(87, 146));
		Class37.smethod_4((Control)(object)waitSendingReportControl_0, bool_0: false, 673, 728);
		((Control)feedbackControl_0).SetBounds(24, 72, 368, 16);
		((Control)feedbackControl_1).SetBounds(24, 96, 368, 16);
		((Control)feedbackControl_2).SetBounds(24, 120, 368, 16);
		((Control)feedbackControl_3).SetBounds(24, 144, 368, 16);
		((Control)poweredBy_0).set_Anchor((AnchorStyles)6);
		((Control)poweredBy_0).SetBounds(20, 444, 120, 32);
		((Control)panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)button_6,
			(Control)checkBox_0,
			(Control)label_0,
			(Control)button_0,
			(Control)button_1,
			(Control)label_1,
			(Control)autoHeightLabel_0,
			headerControl_0
		});
		((Control)panel_0).set_Size(new Size(413, 240));
		((Control)panel_0).set_TabIndex(0);
		((Control)panel_1).get_Controls().AddRange((Control[])(object)new Control[10]
		{
			(Control)button_2,
			(Control)button_3,
			(Control)button_4,
			(Control)button_5,
			waitSendingReportControl_0,
			headerControl_1,
			feedbackControl_0,
			feedbackControl_1,
			feedbackControl_2,
			feedbackControl_3
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
		((Control)this).set_Text("Nc0j6W1Ag");
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
		((Control)button_4).BringToFront();
		((Control)button_5).BringToFront();
		((Form)this).set_Size(new Size(419, 264));
		((Control)panel_1).set_Dock((DockStyle)5);
		((Control)panel_0).set_Dock((DockStyle)5);
	}

	private void button_5_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_Title("Save Report");
		((FileDialog)val).set_DefaultExt("saencryptedreport");
		((FileDialog)val).set_Filter("SmartAssembly Encrypted Exception Report|*.saencryptedreport");
		if ((int)UsageCounts.smethod_4((CommonDialog)(object)val, 246, 217) == 1)
		{
			reportExceptionEventArgs_0.SaveEncryptedReport(((FileDialog)val).get_FileName());
			((Form)this).Close();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			Class37.smethod_4((Control)(object)panel_0, bool_0: false, 131, 250);
			Class37.smethod_4((Control)(object)panel_1, bool_0: true, 650, 755);
			Class37.smethod_4((Control)(object)poweredBy_0, bool_0: true, 567, 590);
			if (reportExceptionEventArgs_0 != null)
			{
				method_1(method_7);
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

	private void button_0_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_2_Click(object sender, EventArgs e)
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

	private void button_3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_2(object sender, EventArgs e)
	{
		reportExceptionEventArgs_0.TryToContinue = checkBox_0.get_Checked();
	}

	private void method_3(object sender, SendingReportFeedbackEventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new SendingReportFeedbackEventHandler(method_5), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new EventHandler(method_6), new object[2] { sender, e });
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

	private void method_5(object sender, SendingReportFeedbackEventArgs e)
	{
		Button val = ((!bool_0 || Thread.CurrentThread.ApartmentState != 0) ? button_4 : button_5);
		switch (e.Step)
		{
		case SendingReportStep.PreparingReport:
			if (e.Failed)
			{
				feedbackControl_0.Stop(e.ErrorMessage);
				Class37.smethod_4((Control)(object)val, bool_0: true, 813, 852);
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
				Class37.smethod_4((Control)(object)val, bool_0: true, 796, 869);
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
				Class37.smethod_4((Control)(object)waitSendingReportControl_0, bool_0: false, 38, 95);
				feedbackControl_2.Stop(e.ErrorMessage);
				Class37.smethod_4((Control)(object)val, bool_0: true, 670, 743);
				((Control)val).Focus();
			}
			else
			{
				feedbackControl_1.Stop();
				feedbackControl_2.Start();
				Class37.smethod_4((Control)(object)waitSendingReportControl_0, bool_0: true, 295, 350);
			}
			break;
		case SendingReportStep.Finished:
			((Control)waitSendingReportControl_0).set_Visible(false);
			feedbackControl_2.Stop();
			feedbackControl_3.Stop();
			((Control)button_3).set_Enabled(true);
			((Control)button_3).Focus();
			((Control)button_2).set_Enabled(false);
			break;
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		Class37.smethod_4((Control)(object)button_4, bool_0: false, 401, 488);
		feedbackControl_0.Init();
		feedbackControl_1.Init();
		feedbackControl_2.Init();
		if (reportExceptionEventArgs_0 != null)
		{
			method_1(method_7);
		}
	}

	private void method_7()
	{
		reportExceptionEventArgs_0.SendReport();
	}

	private void button_6_Click(object sender, EventArgs e)
	{
		if (reportExceptionEventArgs_0 != null)
		{
			method_1(reportExceptionEventArgs_0.LaunchDebugger);
		}
	}

	public Form0(UnhandledExceptionHandler unhandledExceptionHandler_0, ReportExceptionEventArgs reportExceptionEventArgs_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		CheckBox val = (checkBox_0 = new CheckBox());
		Label val2 = (label_0 = new Label());
		Button val3 = (button_0 = new Button());
		Button val4 = (button_1 = new Button());
		Label val5 = (label_1 = new Label());
		AutoHeightLabel autoHeightLabel = (autoHeightLabel_0 = new AutoHeightLabel());
		Panel val6 = (panel_0 = new Panel());
		Panel val7 = (panel_1 = new Panel());
		Button val8 = (button_2 = new Button());
		WaitSendingReportControl waitSendingReportControl = (waitSendingReportControl_0 = new WaitSendingReportControl());
		FeedbackControl feedbackControl = (feedbackControl_0 = new FeedbackControl("Preparing the error report."));
		FeedbackControl feedbackControl2 = (feedbackControl_1 = new FeedbackControl("Connecting to server."));
		FeedbackControl feedbackControl3 = (feedbackControl_2 = new FeedbackControl("Transferring report."));
		FeedbackControl feedbackControl4 = (feedbackControl_3 = new FeedbackControl("Error reporting completed. Thank you."));
		Button val9 = (button_3 = new Button());
		Button val10 = (button_4 = new Button());
		Button val11 = (button_5 = new Button());
		HeaderControl headerControl = (headerControl_0 = new HeaderControl(string.Format("{0} has encountered a problem.\nWe are sorry for the inconvenience.", "Nc0j6W1Ag")));
		HeaderControl headerControl2 = (headerControl_1 = new HeaderControl(SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_4("Please wait while {0} is sending the report to {1} through the Internet.", "Nc0j6W1Ag", "x3S5NtHe", 931, 962)));
		PoweredBy poweredBy = (poweredBy_0 = new PoweredBy());
		Button val12 = (button_6 = new Button());
		((Form)this)._002Ector();
		method_0();
		int height = ((Control)this).get_Height();
		ReportExceptionEventArgs reportExceptionEventArgs = (reportExceptionEventArgs_0 = reportExceptionEventArgs_1);
		Class24.smethod_0((Control)(object)autoHeightLabel_0, AutoHeightLabel.smethod_1(reportExceptionEventArgs_1.Exception, 73, 48), 188, 177);
		height += ((Control)autoHeightLabel_0).get_Height() - ((Control)this).get_FontHeight();
		if (!reportExceptionEventArgs_1.ShowContinueCheckbox)
		{
			Class37.smethod_4((Control)(object)checkBox_0, bool_0: false, 486, 415);
			height -= ((Control)checkBox_0).get_Height();
		}
		if (height > ((Control)this).get_Height())
		{
			((Control)this).set_Height(height);
		}
		if (reportExceptionEventArgs_1.CanDebug)
		{
			unhandledExceptionHandler_0.DebuggerLaunched += method_4;
			Class37.smethod_4((Control)(object)button_6, bool_0: true, 680, 721);
			if (((Control)button_6).get_Left() < ((Control)poweredBy_0).get_Right())
			{
				((Control)poweredBy_0).set_Visible(false);
			}
		}
		if (!reportExceptionEventArgs_1.CanSendReport)
		{
			((Control)button_1).set_Enabled(false);
			if (((Control)button_0).get_CanFocus())
			{
				((Control)button_0).Focus();
			}
		}
		unhandledExceptionHandler_0.SendingReportFeedback += method_3;
	}

	static Form0()
	{
		DESCryptoIndirector.smethod_0();
	}
}
