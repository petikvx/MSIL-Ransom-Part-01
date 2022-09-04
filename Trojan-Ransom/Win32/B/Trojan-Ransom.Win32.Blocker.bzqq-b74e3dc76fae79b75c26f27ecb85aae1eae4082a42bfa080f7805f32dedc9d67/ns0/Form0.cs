using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using My;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

[DesignerCategory("Code")]
internal sealed class Form0 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2426)]
	private struct Struct26
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3022)]
	private struct Struct27
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly char[] char_2;

	private static readonly char[] char_3;

	private static readonly string[] string_1;

	internal static byte byte_1/* Not supported: data(00) */;

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
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		int num = default(int);
		Control[] array = default(Control[]);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = 50;
			UnhandledExceptionHandlerWithUI.smethod_2((Control)(object)panel_0, 83, 71);
			UnhandledExceptionHandlerWithUI.smethod_2((Control)(object)panel_1, 339, 327);
			num = 33;
			UnhandledExceptionHandlerWithUI.smethod_2((Control)(object)this, 241, 226);
			headerControl_0.IconState = IconState.Error;
			num = 46;
			headerControl_1.IconState = IconState.Error;
			WaitSendingReportControl.smethod_1((Control)(object)checkBox_0, (AnchorStyles)6, 399, 404);
			num = 36;
			SimpleZip.Class14.smethod_2((ButtonBase)(object)checkBox_0, (FlatStyle)3, 766, 733);
			Class21.smethod_1((Control)(object)checkBox_0, new Point(22, 98), 1011, 984);
			num = 30;
			Class27.smethod_0((Control)(object)checkBox_0, new Size(226, 16), 557, 539);
			num = 59;
			WaitSendingReportControl.smethod_0((Control)(object)checkBox_0, 13, 810, 849);
			SmartAssembly.License.License.smethod_4((Control)(object)checkBox_0, "Ignore this error and attempt to &continue.", 617, 574);
			num = 22;
			Win32.smethod_12(checkBox_0, method_7, 208, 159);
			num = 3;
			WaitSendingReportControl.smethod_1((Control)(object)label_0, (AnchorStyles)14, 289, 314);
			FeedbackControl.smethod_2(label_0, (FlatStyle)3, 246, 206);
			num = 2;
			Class16.smethod_1((Control)(object)label_0, new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0), 670, 689);
			num = 5;
			Class21.smethod_1((Control)(object)label_0, new Point(20, 124), 338, 377);
			num = 70;
			Class27.smethod_0((Control)(object)label_0, new Size(381, 16), 28, 42);
			num = 53;
			SmartAssembly.License.License.smethod_4((Control)(object)label_0, SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0("Please tell {0} about this problem.", "[Unknown company]", 692, 742), 370, 293);
			num = 19;
			WaitSendingReportControl.smethod_1((Control)(object)button_0, (AnchorStyles)10, 37, 62);
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_0, (FlatStyle)3, 766, 733);
			num = 56;
			Class27.smethod_0((Control)(object)button_0, new Size(75, 24), 654, 696);
			num = 28;
			Class21.smethod_1((Control)(object)button_0, new Point(400 - Class33.smethod_5((Control)(object)button_0, 329, 377), 205), 461, 486);
			num = 38;
			WaitSendingReportControl.smethod_0((Control)(object)button_0, 4, 687, 724);
			SmartAssembly.License.License.smethod_4((Control)(object)button_0, "&Don't Send", 567, 608);
			num = 4;
			DESCryptoIndirector.smethod_2((Control)(object)button_0, method_4, 830, 848);
			num = 26;
			WaitSendingReportControl.smethod_1((Control)(object)button_1, (AnchorStyles)10, 919, 908);
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_1, (FlatStyle)3, 558, 525);
			num = 69;
			Class27.smethod_0((Control)(object)button_1, new Size(105, 24), 406, 416);
			num = 7;
			Class21.smethod_1((Control)(object)button_1, new Point(Class27.smethod_1((Control)(object)button_0, 462, 393) - Class33.smethod_5((Control)(object)button_1, 481, 465) - 6, 205), 419, 392);
			num = 45;
			WaitSendingReportControl.smethod_0((Control)(object)button_1, 3, 81, 42);
			SmartAssembly.License.License.smethod_4((Control)(object)button_1, "&Send Error Report", 78, 25);
			num = 21;
			DESCryptoIndirector.smethod_2((Control)(object)button_1, method_2, 349, 307);
			num = 12;
			WaitSendingReportControl.smethod_1((Control)(object)button_6, (AnchorStyles)10, 733, 710);
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_6, (FlatStyle)3, 509, 478);
			num = 16;
			Class27.smethod_0((Control)(object)button_6, new Size(64, 24), 73, 127);
			num = 15;
			Class21.smethod_1((Control)(object)button_6, new Point(Class27.smethod_1((Control)(object)button_1, 491, 428) - Class33.smethod_5((Control)(object)button_6, 45, 29) - 6, 205), 442, 401);
			num = 9;
			WaitSendingReportControl.smethod_0((Control)(object)button_6, 14, 114, 9);
			SmartAssembly.License.License.smethod_4((Control)(object)button_6, "De&bug", 439, 480);
			num = 23;
			DoNotPruneTypeAttribute.smethod_5((Control)(object)button_6, bool_0: false, 203, 183);
			DESCryptoIndirector.smethod_2((Control)(object)button_6, method_14, 656, 766);
			num = 18;
			WaitSendingReportControl.smethod_1((Control)(object)label_1, (AnchorStyles)14, 111, 116);
			FeedbackControl.smethod_2(label_1, (FlatStyle)3, 682, 658);
			num = 20;
			Class21.smethod_1((Control)(object)label_1, new Point(20, 140), 95, 116);
			num = 64;
			Class27.smethod_0((Control)(object)label_1, new Size(381, 55), 122, 76);
			num = 61;
			SmartAssembly.License.License.smethod_4((Control)(object)label_1, SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "[Unknown company]", 49, 99), 219, 140);
			num = 41;
			WaitSendingReportControl.smethod_1((Control)(object)autoHeightLabel_0, (AnchorStyles)13, 491, 496);
			Class21.smethod_1((Control)(object)autoHeightLabel_0, new Point(20, 69), 783, 804);
			num = 52;
			Class27.smethod_0((Control)(object)autoHeightLabel_0, new Size(381, 13), 402, 420);
			num = 44;
			WaitSendingReportControl.smethod_1((Control)(object)button_2, (AnchorStyles)10, 394, 401);
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_2, (FlatStyle)3, 712, 747);
			num = 54;
			Class27.smethod_0((Control)(object)button_2, new Size(80, 24), 418, 404);
			num = 40;
			Class21.smethod_1((Control)(object)button_2, new Point(400 - Class33.smethod_5((Control)(object)button_2, 450, 498), 205), 658, 697);
			num = 34;
			WaitSendingReportControl.smethod_0((Control)(object)button_2, 7, 97, 26);
			SmartAssembly.License.License.smethod_4((Control)(object)button_2, "&Cancel", 899, 980);
			num = 55;
			DESCryptoIndirector.smethod_2((Control)(object)button_2, method_5, 570, 596);
			num = 29;
			WaitSendingReportControl.smethod_1((Control)(object)button_3, (AnchorStyles)10, 273, 266);
			UsageReportSender.smethod_13((Control)(object)button_3, bool_0: false, 945, 901);
			num = 47;
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_3, (FlatStyle)3, 843, 872);
			Class27.smethod_0((Control)(object)button_3, new Size(105, 24), 388, 434);
			num = 6;
			Class21.smethod_1((Control)(object)button_3, new Point(Class27.smethod_1((Control)(object)button_2, 195, 132) - Class33.smethod_5((Control)(object)button_3, 522, 570) - 6, 205), 82, 121);
			num = 25;
			WaitSendingReportControl.smethod_0((Control)(object)button_3, 6, 107, 16);
			SmartAssembly.License.License.smethod_4((Control)(object)button_3, "&OK", 440, 495);
			num = 17;
			DESCryptoIndirector.smethod_2((Control)(object)button_3, method_6, 24, 118);
			num = 35;
			WaitSendingReportControl.smethod_1((Control)(object)button_4, (AnchorStyles)10, 504, 483);
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_4, (FlatStyle)3, 589, 622);
			num = 49;
			Class21.smethod_1((Control)(object)button_4, _003CPrivateImplementationDetails_003E.smethod_1((Control)(object)button_3, 914, 989), 366, 325);
			num = 0;
			Class27.smethod_0((Control)(object)button_4, SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_2((Control)(object)button_3, 610, 524), 590, 632);
			num = 14;
			WaitSendingReportControl.smethod_0((Control)(object)button_4, 5, 331, 304);
			SmartAssembly.License.License.smethod_4((Control)(object)button_4, "&Retry", 115, 36);
			num = 11;
			DoNotPruneTypeAttribute.smethod_5((Control)(object)button_4, bool_0: false, 384, 508);
			DESCryptoIndirector.smethod_2((Control)(object)button_4, method_12, 73, 39);
			num = 27;
			WaitSendingReportControl.smethod_1((Control)(object)button_5, (AnchorStyles)10, 618, 625);
			SimpleZip.Class14.smethod_2((ButtonBase)(object)button_5, (FlatStyle)3, 808, 779);
			num = 65;
			Class21.smethod_1((Control)(object)button_5, _003CPrivateImplementationDetails_003E.smethod_1((Control)(object)button_3, 17, 94), 563, 536);
			num = 32;
			Class27.smethod_0((Control)(object)button_5, SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_2((Control)(object)button_3, 235, 133), 141, 187);
			num = 48;
			WaitSendingReportControl.smethod_0((Control)(object)button_5, 5, 702, 709);
			SmartAssembly.License.License.smethod_4((Control)(object)button_5, "Save Report", 243, 164);
			num = 63;
			DoNotPruneTypeAttribute.smethod_5((Control)(object)button_5, bool_0: false, 238, 146);
			DESCryptoIndirector.smethod_2((Control)(object)button_5, method_1, 190, 208);
			num = 58;
			Class21.smethod_1((Control)(object)waitSendingReportControl_0, new Point(87, 146), 863, 884);
			num = 67;
			DoNotPruneTypeAttribute.smethod_5((Control)(object)waitSendingReportControl_0, bool_0: false, 731, 679);
			SecurityExceptionEventArgs.smethod_4((Control)(object)feedbackControl_0, 24, 72, 368, 16, 384, 401);
			num = 57;
			SecurityExceptionEventArgs.smethod_4((Control)(object)feedbackControl_1, 24, 96, 368, 16, 342, 327);
			num = 68;
			SecurityExceptionEventArgs.smethod_4((Control)(object)feedbackControl_2, 24, 120, 368, 16, 377, 360);
			num = 8;
			SecurityExceptionEventArgs.smethod_4((Control)(object)feedbackControl_3, 24, 144, 368, 16, 913, 896);
			num = 39;
			WaitSendingReportControl.smethod_1((Control)(object)poweredBy_0, (AnchorStyles)6, 122, 97);
			SecurityExceptionEventArgs.smethod_4((Control)(object)poweredBy_0, 20, 444, 120, 32, 214, 199);
			num = 10;
			ControlCollection controls = ((Control)panel_0).get_Controls();
			array = (Control[])(object)new Control[8]
			{
				(Control)button_6,
				(Control)checkBox_0,
				(Control)label_0,
				(Control)button_0,
				(Control)button_1,
				(Control)label_1,
				(Control)autoHeightLabel_0,
				headerControl_0
			};
			controls.AddRange(array);
			num = 31;
			((Control)panel_0).set_Size(new Size(413, 240));
			((Control)panel_0).set_TabIndex(0);
			num = 37;
			ControlCollection controls2 = ((Control)panel_1).get_Controls();
			array = (Control[])(object)new Control[10]
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
			};
			controls2.AddRange(array);
			num = 1;
			((Control)panel_1).set_Size(new Size(413, 240));
			((Control)panel_1).set_TabIndex(2);
			num = 43;
			((Control)panel_1).set_Visible(false);
			((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
			num = 24;
			((Form)this).set_ClientSize(new Size(434, 488));
			((Form)this).set_ControlBox(false);
			ControlCollection controls3 = ((Control)this).get_Controls();
			array = (Control[])(object)new Control[3]
			{
				poweredBy_0,
				(Control)panel_0,
				(Control)panel_1
			};
			controls3.AddRange(array);
			num = 51;
			((Form)this).set_FormBorderStyle((FormBorderStyle)1);
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_MinimizeBox(false);
			((Form)this).set_MaximizeBox(false);
			num = 62;
			((Form)this).set_StartPosition((FormStartPosition)1);
			((Control)this).set_Text("server1");
			if (((Control)this).get_Text().Length == 0)
			{
				num = 60;
				((Control)this).set_Text("Error Reporting");
			}
			try
			{
				num2 = 4;
				((Form)this).set_TopMost(true);
			}
			catch
			{
			}
			num3 = 6;
			((Control)panel_0).ResumeLayout(false);
			((Control)panel_1).ResumeLayout(false);
			num3 = 0;
			((Control)this).ResumeLayout(false);
			((Control)button_4).BringToFront();
			((Control)button_5).BringToFront();
			num3 = 2;
			((Form)this).set_Size(new Size(419, 264));
			((Control)panel_1).set_Dock((DockStyle)5);
			num3 = 1;
			((Control)panel_0).set_Dock((DockStyle)5);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, array, num, num2, num3, this);
			throw;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		int num = default(int);
		SaveFileDialog val = default(SaveFileDialog);
		try
		{
			num = 3;
			val = new SaveFileDialog();
			MyComputer.smethod_1((FileDialog)(object)val, "Save Report", 533, 524);
			num = 7;
			Attribute0.smethod_1((FileDialog)(object)val, "saencryptedreport", 373, 320);
			FeedbackControl.smethod_3((FileDialog)(object)val, "SmartAssembly Encrypted Exception Report|*.saencryptedreport", 3, 89);
			num = 1;
			if ((int)Attribute0.smethod_2((CommonDialog)(object)val, 90, 127) == 1)
			{
				reportExceptionEventArgs_0.SaveEncryptedReport(((FileDialog)val).get_FileName());
				((Form)this).Close();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, val, num, this, sender, e);
			throw;
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			try
			{
				num = 6;
				DoNotPruneTypeAttribute.smethod_5((Control)(object)panel_0, bool_0: false, 900, 1016);
				DoNotPruneTypeAttribute.smethod_5((Control)(object)panel_1, bool_0: true, 812, 848);
				num = 5;
				DoNotPruneTypeAttribute.smethod_5((Control)(object)poweredBy_0, bool_0: true, 363, 279);
				if (reportExceptionEventArgs_0 != null)
				{
					method_3(method_13);
				}
			}
			catch
			{
			}
			num2 = 3;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, num2, this, sender, e);
			throw;
		}
	}

	private void method_3(ThreadStart threadStart_0)
	{
		Thread o = default(Thread);
		try
		{
			o = (thread_0 = new Thread(threadStart_0));
			UsageReportSender.smethod_14(thread_0, 442, 436);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, o, this, threadStart_0);
			throw;
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		try
		{
			WaitSendingReportControl.smethod_5((Form)(object)this, 841, 892);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		int num = default(int);
		try
		{
			try
			{
				num = 5;
				if (thread_0 != null)
				{
					DESCryptoIndirector.smethod_3(thread_0, 977, 975);
				}
			}
			catch
			{
			}
			((Form)this).Close();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, this, sender, e);
			throw;
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		try
		{
			WaitSendingReportControl.smethod_5((Form)(object)this, 225, 212);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		try
		{
			reportExceptionEventArgs_0.TryToContinue = Class35.smethod_4(checkBox_0, 783, 847);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	private void method_8(object sender, SendingReportFeedbackEventArgs e)
	{
		object[] array = default(object[]);
		try
		{
			try
			{
				SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = method_10;
				array = new object[2] { sender, e };
				((Control)this).Invoke((Delegate)sendingReportFeedbackEventHandler, array);
			}
			catch (InvalidOperationException)
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, array, this, sender, e);
			throw;
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		object[] array = default(object[]);
		try
		{
			try
			{
				EventHandler eventHandler = method_11;
				array = new object[2] { sender, e };
				((Control)this).Invoke((Delegate)eventHandler, array);
			}
			catch (InvalidOperationException)
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, array, this, sender, e);
			throw;
		}
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		int num = default(int);
		try
		{
			num = 3;
			if (thread_0 != null)
			{
				num = 1;
				if (Class2.smethod_10(thread_0, 236, 239))
				{
					num = 0;
					DESCryptoIndirector.smethod_3(thread_0, 274, 268);
				}
				else
				{
					num = 2;
				}
			}
			else
			{
				num = 2;
			}
			((Form)this).OnClosing(e);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, this, e);
			throw;
		}
	}

	private void method_10(object sender, SendingReportFeedbackEventArgs e)
	{
		int num = default(int);
		Button val = default(Button);
		SendingReportStep step = default(SendingReportStep);
		int num2 = default(int);
		try
		{
			num = 2;
			Button obj;
			if (bool_0)
			{
				num = 4;
				if (SendingReportFeedbackEventArgs1.smethod_5(DoNotObfuscateTypeAttribute.smethod_4(135, 204), 862, 783) == ApartmentState.STA)
				{
					num = 6;
					obj = button_5;
					goto IL_0042;
				}
				num = 1;
			}
			else
			{
				num = 1;
			}
			obj = button_4;
			goto IL_0042;
			IL_0042:
			val = obj;
			step = e.Step;
			switch (step)
			{
			default:
				num = 5;
				break;
			case SendingReportStep.PreparingReport:
				if (e.Failed)
				{
					num2 = 19;
					feedbackControl_0.Stop(e.ErrorMessage);
					DoNotPruneTypeAttribute.smethod_5((Control)(object)val, bool_0: true, 293, 345);
					num2 = 7;
					PoweredByAttribute1.smethod_1((Control)(object)val, 589, 583);
				}
				else
				{
					num2 = 16;
					feedbackControl_0.Start();
				}
				break;
			case SendingReportStep.ConnectingToServer:
				if (e.Failed)
				{
					num2 = 12;
					feedbackControl_1.Stop(e.ErrorMessage);
					DoNotPruneTypeAttribute.smethod_5((Control)(object)val, bool_0: true, 550, 602);
					num2 = 0;
					PoweredByAttribute1.smethod_1((Control)(object)val, 236, 230);
				}
				else
				{
					num2 = 5;
					feedbackControl_0.Stop();
					feedbackControl_1.Start();
				}
				break;
			case SendingReportStep.Transfering:
				if (e.Failed)
				{
					num2 = 11;
					DoNotPruneTypeAttribute.smethod_5((Control)(object)waitSendingReportControl_0, bool_0: false, 255, 131);
					feedbackControl_2.Stop(e.ErrorMessage);
					num2 = 18;
					DoNotPruneTypeAttribute.smethod_5((Control)(object)val, bool_0: true, 1010, 910);
					PoweredByAttribute1.smethod_1((Control)(object)val, 606, 596);
				}
				else
				{
					num2 = 10;
					feedbackControl_1.Stop();
					feedbackControl_2.Start();
					num2 = 9;
					DoNotPruneTypeAttribute.smethod_5((Control)(object)waitSendingReportControl_0, bool_0: true, 156, 224);
				}
				break;
			case SendingReportStep.Finished:
				((Control)waitSendingReportControl_0).set_Visible(false);
				feedbackControl_2.Stop();
				num2 = 8;
				feedbackControl_3.Stop();
				((Control)button_3).set_Enabled(true);
				num2 = 3;
				((Control)button_3).Focus();
				((Control)button_2).set_Enabled(false);
				break;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, val, step, num, num2, this, sender, e);
			throw;
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		try
		{
			WaitSendingReportControl.smethod_5((Form)(object)this, 898, 951);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		int num = default(int);
		bool flag = default(bool);
		try
		{
			num = 4;
			flag = true;
			bool_0 = true;
			DoNotPruneTypeAttribute.smethod_5((Control)(object)button_4, bool_0: false, 803, 863);
			num = 0;
			feedbackControl_0.Init();
			feedbackControl_1.Init();
			num = 3;
			feedbackControl_2.Init();
			if (reportExceptionEventArgs_0 != null)
			{
				method_3(method_13);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, flag, num, this, sender, e);
			throw;
		}
	}

	private void method_13()
	{
		try
		{
			reportExceptionEventArgs_0.SendReport();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		int num = default(int);
		try
		{
			num = 2;
			if (reportExceptionEventArgs_0 != null)
			{
				method_3(reportExceptionEventArgs_0.LaunchDebugger);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, this, sender, e);
			throw;
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
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
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
		HeaderControl headerControl = (headerControl_0 = new HeaderControl(SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0("{0} has encountered a problem.\nWe are sorry for the inconvenience.", "server1", 87, 5)));
		HeaderControl headerControl2 = (headerControl_1 = new HeaderControl(Class5.smethod_4("Please wait while {0} is sending the report to {1} through the Internet.", "server1", "[Unknown company]", 660, 735)));
		PoweredBy poweredBy = (poweredBy_0 = new PoweredBy());
		Button val12 = (button_6 = new Button());
		((Form)this)._002Ector();
		int num = default(int);
		ReportExceptionEventArgs reportExceptionEventArgs = default(ReportExceptionEventArgs);
		try
		{
			method_0();
			num = Class33.smethod_3((Control)(object)this, 502, 429);
			reportExceptionEventArgs = (reportExceptionEventArgs_0 = reportExceptionEventArgs_1);
			SmartAssembly.License.License.smethod_4((Control)(object)autoHeightLabel_0, UsageReportSender.smethod_12(reportExceptionEventArgs_1.Exception, 766, 706), 263, 336);
			num += SimpleZip.Class14.smethod_0((Control)(object)autoHeightLabel_0, 407, 450) - ((Control)this).get_FontHeight();
			if (!reportExceptionEventArgs_1.ShowContinueCheckbox)
			{
				DoNotPruneTypeAttribute.smethod_5((Control)(object)checkBox_0, bool_0: false, 539, 615);
				num -= SimpleZip.Class14.smethod_0((Control)(object)checkBox_0, 280, 333);
			}
			if (num > Class33.smethod_3((Control)(object)this, 870, 829))
			{
				Class4.smethod_5((Control)(object)this, num, 88, 23);
			}
			if (reportExceptionEventArgs_1.CanDebug)
			{
				unhandledExceptionHandler_0.DebuggerLaunched += method_9;
				DoNotPruneTypeAttribute.smethod_5((Control)(object)button_6, bool_0: true, 724, 680);
				if (Class27.smethod_1((Control)(object)button_6, 865, 806) < ((Control)poweredBy_0).get_Right())
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
			unhandledExceptionHandler_0.SendingReportFeedback += method_8;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[26]
			{
				num, val, val2, val3, val4, val5, autoHeightLabel, val6, val7, val8,
				waitSendingReportControl, feedbackControl, feedbackControl2, feedbackControl3, feedbackControl4, val9, val10, val11, headerControl, headerControl2,
				poweredBy, val12, reportExceptionEventArgs, this, unhandledExceptionHandler_0, reportExceptionEventArgs_1
			});
			throw;
		}
	}

	static Form0()
	{
		int num = default(int);
		char[] array = default(char[]);
		char[] array2 = default(char[]);
		try
		{
			num = 0;
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			char_3 = new char[1511];
			array = new char[8];
			num = 4;
			array[4] = 'ም';
			array[1] = '㳂';
			array[3] = '㍘';
			num = 3;
			array[7] = 'ᓘ';
			array[0] = 'ሀ';
			array[2] = 'ዯ';
			num = 1;
			array[5] = 'ԣ';
			array[6] = '\u0654';
			string_1 = new string[47];
			num = 10;
			char_2 = array;
			char_1 = new char[1213];
			array2 = new char[8];
			num = 6;
			array2[5] = 'ԣ';
			array2[0] = 'ሀ';
			array2[1] = '㳂';
			num = 8;
			array2[6] = '\u0654';
			array2[7] = 'ᓘ';
			array2[2] = 'ዯ';
			num = 11;
			array2[4] = 'ም';
			array2[3] = '㍘';
			string_0 = new string[48];
			num = 7;
			char_0 = array2;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, array2, array, num);
			throw;
		}
	}

	internal static object smethod_0(RegistryKey registryKey_0, string string_2, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					return registryKey_0.GetValue(string_2);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, registryKey_0, string_2, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_1(string string_2, string string_3, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 50:
					return string_2 + string_3;
				case 51:
					return Path.Combine(string_2, string_3);
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_2, string_3, int_0, int_1);
			throw;
		}
	}

	internal static ParameterInfo[] smethod_2(MethodBase methodBase_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 38:
					return methodBase_0.GetParameters();
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, methodBase_0, int_0, int_1);
			throw;
		}
	}

	internal static ServicePoint smethod_3(HttpWebRequest httpWebRequest_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 119:
					return httpWebRequest_0.ServicePoint;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, httpWebRequest_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_4(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 75:
					return type_0.IsArray;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}

	internal static object smethod_5(AppDomain appDomain_0, string string_2, int int_0, int int_1)
	{
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return appDomain_0.GetData(string_2);
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, appDomain_0, string_2, int_0, int_1);
			throw;
		}
	}
}
