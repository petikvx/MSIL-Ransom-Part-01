using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public abstract class UnhandledExceptionHandler
{
	public const string ApplicationName = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string CompanyName = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool bool_0;

	private static readonly string string_0;

	private static UnhandledExceptionHandler unhandledExceptionHandler_0;

	internal IWebProxy iwebProxy_0;

	internal EventHandler eventHandler_0;

	internal SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler_0;

	public event EventHandler DebuggerLaunched
	{
		add
		{
			int num = default(int);
			EventHandler eventHandler = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler eventHandler3 = default(EventHandler);
			try
			{
				num = 4;
				eventHandler = eventHandler_0;
				num = 2;
				do
				{
					eventHandler2 = eventHandler;
					eventHandler3 = (EventHandler)WaitSendingReportControl.smethod_3(eventHandler2, value, 904, 904);
					num = 5;
					eventHandler = Interlocked.CompareExchange(ref eventHandler_0, eventHandler3, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, eventHandler, eventHandler2, eventHandler3, num, this, value);
				throw;
			}
		}
		remove
		{
			int num = default(int);
			EventHandler eventHandler = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler eventHandler3 = default(EventHandler);
			try
			{
				num = 1;
				eventHandler = eventHandler_0;
				num = 3;
				do
				{
					eventHandler2 = eventHandler;
					eventHandler3 = (EventHandler)AutoHeightLabel.smethod_2(eventHandler2, value, 373, 295);
					num = 0;
					eventHandler = Interlocked.CompareExchange(ref eventHandler_0, eventHandler3, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, eventHandler, eventHandler2, eventHandler3, num, this, value);
				throw;
			}
		}
	}

	public event SendingReportFeedbackEventHandler SendingReportFeedback
	{
		add
		{
			int num = default(int);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler);
			try
			{
				num = 0;
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
				num = 2;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler)WaitSendingReportControl.smethod_3(sendingReportFeedbackEventHandler2, value, 866, 866);
					num = 6;
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, num, this, value);
				throw;
			}
		}
		remove
		{
			int num = default(int);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler);
			try
			{
				num = 3;
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
				num = 4;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler)AutoHeightLabel.smethod_2(sendingReportFeedbackEventHandler2, value, 22, 68);
					num = 1;
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, num, this, value);
				throw;
			}
		}
	}

	protected abstract void OnReportException(ReportExceptionEventArgs e);

	protected abstract void OnFatalException(FatalExceptionEventArgs e);

	protected abstract void OnSecurityException(SecurityExceptionEventArgs e);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void AttachExceptionHandler(UnhandledExceptionHandler unhandledExceptionHandler)
	{
		int num = default(int);
		try
		{
			num = 3;
			if (unhandledExceptionHandler != null)
			{
				unhandledExceptionHandler_0 = unhandledExceptionHandler;
				UnhandledExceptionHandlerWithUI.smethod_6(Class4.smethod_4(510, 481), unhandledExceptionHandler.method_1, 149, 163);
				num = 6;
				Application.add_ThreadException((ThreadExceptionEventHandler)unhandledExceptionHandler.method_0);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, num, unhandledExceptionHandler);
			throw;
		}
	}

	[SpecialName]
	private static UnhandledExceptionHandler smethod_0()
	{
		int num = default(int);
		Type[] array = default(Type[]);
		int num2 = default(int);
		Type type = default(Type);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			if (unhandledExceptionHandler_0 == null)
			{
				num = 3;
				array = Class22.smethod_8(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_1(279, 383), 415, 463);
				num2 = 0;
				while (true)
				{
					if (num2 < array.Length)
					{
						type = array[num2];
						if ((object)type != null)
						{
							num = 7;
							if ((object)FatalExceptionEventArgs.smethod_4(type, 857, 813) != null)
							{
								num = 4;
								if ((object)FatalExceptionEventArgs.smethod_4(type, 361, 285) == SendingReportFeedbackEventArgs1.smethod_0(typeof(UnhandledExceptionHandler).TypeHandle, 778, 881))
								{
									try
									{
										num3 = 1;
										unhandledExceptionHandler_0 = (UnhandledExceptionHandler)SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_5(type, bool_1: true, 509, 412);
										if (unhandledExceptionHandler_0 != null)
										{
											break;
										}
									}
									catch
									{
									}
								}
							}
						}
						num4 = 5;
						num2++;
						num4 = 1;
						continue;
					}
					num4 = 3;
					break;
				}
			}
			return unhandledExceptionHandler_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, type, array, num2, num, num3, num4);
			throw;
		}
	}

	public static void EntryPointException(Exception exception, object[] objects)
	{
		int num = default(int);
		try
		{
			num = 0;
			if (exception != null)
			{
				num = 7;
				if (exception is SecurityException)
				{
					num = 6;
					if (Class2.smethod_9(string_0, "1", 887, 813))
					{
						num = 1;
						if (smethod_0().method_2((SecurityException)exception))
						{
							num = 2;
							return;
						}
					}
				}
			}
			StackFrameHelper.CreateExceptionN(exception, objects);
			smethod_0().method_3(exception, bool_1: false, bool_2: false);
		}
		catch (Exception exception2)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException4(exception2, num, num2, exception, objects);
			throw;
		}
	}

	public static Exception ReportWebMethodException(Exception exception, object[] objects)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		int num = default(int);
		try
		{
			try
			{
				num = 6;
				if ((object)WaitSendingReportControl.smethod_4(exception, 846, 804) == SendingReportFeedbackEventArgs1.smethod_0(typeof(Exception).TypeHandle, 913, 1002))
				{
					num = 1;
					if (Class2.smethod_9(UsageReportSender.smethod_12(exception, 834, 894), "{report}", 288, 378))
					{
						num = 2;
						exception = DoNotDistributeAttribute.smethod_3(exception, 65, 0);
						num = 4;
						goto IL_006e;
					}
					num = 5;
				}
				else
				{
					num = 5;
				}
				StackFrameHelper.CreateExceptionN(exception, objects);
				goto IL_006e;
				IL_006e:
				smethod_0().method_3(exception, bool_1: true, bool_2: false);
			}
			catch
			{
			}
			return (Exception)new SoapException(exception.Message, SoapException.ServerFaultCode);
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, num, exception, objects);
			throw;
		}
	}

	public static void ReportException(Exception exception, object[] objects)
	{
		int num = default(int);
		try
		{
			try
			{
				num = 2;
				if ((object)WaitSendingReportControl.smethod_4(exception, 490, 384) == SendingReportFeedbackEventArgs1.smethod_0(typeof(Exception).TypeHandle, 477, 422))
				{
					num = 3;
					if (Class2.smethod_9(UsageReportSender.smethod_12(exception, 549, 537), "{report}", 304, 362))
					{
						num = 0;
						exception = DoNotDistributeAttribute.smethod_3(exception, 229, 164);
						num = 6;
						goto IL_0075;
					}
					num = 7;
				}
				else
				{
					num = 7;
				}
				StackFrameHelper.CreateExceptionN(exception, objects);
				goto IL_0075;
				IL_0075:
				smethod_0().method_3(exception, bool_1: true, bool_2: true);
			}
			catch
			{
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, num, exception, objects);
			throw;
		}
	}

	private void method_0(object sender, ThreadExceptionEventArgs e)
	{
		int num = default(int);
		Exception ex = default(Exception);
		Type type = default(Type);
		int num2 = default(int);
		try
		{
			try
			{
				num = 11;
				ex = Class27.smethod_3(e, 353, 305);
				type = WaitSendingReportControl.smethod_4(ex, 436, 478);
				num = 12;
				if (Class2.smethod_9(ConfirmFeatureUsageReportingForm_1.smethod_2(type, 1011, 1013), "UnhandledException", 1023, 933))
				{
					num = 9;
					if (Class2.smethod_9(Class22.smethod_9(type, 173, 224), "SmartAssembly.SmartExceptionsCore", 113, 43))
					{
						num = 4;
						ex = (Exception)SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_3(PoweredBy.smethod_2(type, "PreviousException", 182, 134), ex, 260, 328);
						num = 0;
					}
					else
					{
						num = 0;
					}
				}
				else
				{
					num = 0;
				}
				if (!(ex is SecurityException))
				{
					num = 2;
					goto IL_00e2;
				}
				num = 8;
				if (!(string_0 == "1"))
				{
					num = 2;
					goto IL_00e2;
				}
				num = 10;
				if (!method_2(ex as SecurityException))
				{
					num = 2;
					goto IL_00e2;
				}
				num = 5;
				goto end_IL_0000;
				IL_00e2:
				method_3(ex, bool_1: true, bool_2: false);
				end_IL_0000:;
			}
			catch
			{
			}
			num2 = 1;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, ex, type, num, num2, this, sender, e);
			throw;
		}
	}

	private void method_1(object sender, UnhandledExceptionEventArgs e)
	{
		int num = default(int);
		try
		{
			try
			{
				num = 0;
				if (Class4.smethod_6(e, 601, 631) is SecurityException)
				{
					num = 4;
					if (Class2.smethod_9(string_0, "1", 919, 973))
					{
						num = 3;
						if (method_2(Class4.smethod_6(e, 498, 476) as SecurityException))
						{
							num = 8;
							return;
						}
						num = 6;
					}
					else
					{
						num = 6;
					}
				}
				else
				{
					num = 6;
				}
				if (Class4.smethod_6(e, 1023, 977) is Exception)
				{
					num = 2;
					method_3((Exception)e.ExceptionObject, !e.IsTerminating, bool_2: false);
				}
				else
				{
					num = 9;
				}
			}
			catch
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, this, sender, e);
			throw;
		}
	}

	public void SetProxy(IWebProxy proxy)
	{
		IWebProxy o = default(IWebProxy);
		try
		{
			o = (iwebProxy_0 = proxy);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, o, this, proxy);
			throw;
		}
	}

	protected virtual Guid GetUserID()
	{
		try
		{
			return Guid.Empty;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	private bool method_2(SecurityException securityException_0)
	{
		SecurityExceptionEventArgs securityExceptionEventArgs = default(SecurityExceptionEventArgs);
		int num = default(int);
		try
		{
			securityExceptionEventArgs = new SecurityExceptionEventArgs(securityException_0);
			OnSecurityException(securityExceptionEventArgs);
			if (securityExceptionEventArgs.ReportException)
			{
				num = 7;
				return false;
			}
			num = 0;
			if (!securityExceptionEventArgs.TryToContinue)
			{
				num = 8;
				SimpleZip.Class14.smethod_3(549, 546);
			}
			else
			{
				num = 3;
			}
			return true;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, securityExceptionEventArgs, num, this, securityException_0);
			throw;
		}
	}

	private void method_3(Exception exception_0, bool bool_1, bool bool_2)
	{
		int num = default(int);
		Type type = default(Type);
		bool flag = default(bool);
		int num2 = default(int);
		Class17 @class = default(Class17);
		ReportExceptionEventArgs reportExceptionEventArgs = default(ReportExceptionEventArgs);
		Exception ex3 = default(Exception);
		int num3 = default(int);
		Assembly[] array = default(Assembly[]);
		int num4 = default(int);
		Assembly assembly = default(Assembly);
		int num5 = default(int);
		string text = default(string);
		object obj = default(object);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		try
		{
			num = 8;
			Class38.smethod_0(2u);
			type = WaitSendingReportControl.smethod_4(exception_0, 845, 807);
			if (Class2.smethod_9(ConfirmFeatureUsageReportingForm_1.smethod_2(type, 190, 184), "UnhandledException", 135, 221))
			{
				num = 5;
				if (Class2.smethod_9(Class22.smethod_9(type, 155, 214), "SmartAssembly.SmartExceptionsCore", 450, 408))
				{
					num = 1;
					exception_0 = (Exception)SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_3(PoweredBy.smethod_2(type, "PreviousException", 163, 147), exception_0, 685, 737);
					num = 0;
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 0;
			}
			flag = true;
			if (exception_0 != null)
			{
				num = 6;
				if (exception_0 is ThreadAbortException)
				{
					num = 7;
					return;
				}
				try
				{
					num2 = 2;
					@class = new Class17(GetUserID(), exception_0, iwebProxy_0);
					@class.SendingReportFeedback += method_6;
					num2 = 12;
					@class.method_18(method_5);
					@class.method_16(method_4);
					num2 = 7;
					reportExceptionEventArgs = new ReportExceptionEventArgs(@class, exception_0);
					if (AppPathFinder.ReadInstalledSaPath() != null)
					{
						num2 = 13;
						reportExceptionEventArgs.method_1();
					}
					else
					{
						num2 = 9;
					}
					if (!bool_1)
					{
						num2 = 8;
						reportExceptionEventArgs.method_0(bool_4: false);
						reportExceptionEventArgs.TryToContinue = false;
						num2 = 10;
					}
					else
					{
						num2 = 6;
						if (!bool_2)
						{
							num2 = 3;
							if (!bool_0)
							{
								num2 = 10;
								goto IL_017a;
							}
							num2 = 11;
						}
						else
						{
							num2 = 11;
						}
						reportExceptionEventArgs.method_0(bool_4: false);
						reportExceptionEventArgs.TryToContinue = true;
					}
					goto IL_017a;
					IL_017a:
					OnReportException(reportExceptionEventArgs);
					flag = !reportExceptionEventArgs.TryToContinue;
				}
				catch (ThreadAbortException)
				{
				}
				catch (Exception ex2)
				{
					ex3 = ex2;
					OnFatalException(new FatalExceptionEventArgs(ex3));
				}
				num3 = 3;
				if (flag)
				{
					num3 = 5;
					array = SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_3(Class4.smethod_4(801, 830), 770, 859);
					num4 = 0;
					while (num4 < array.Length)
					{
						assembly = array[num4];
						try
						{
							num5 = 2;
							text = Class36.smethod_9(assembly, 904, 954);
							if (SmartAssembly.License.License.smethod_6(text, "31bf3856ad364e35", 293, 264))
							{
								num5 = 0;
								if (AppNameFinder.smethod_2(text, "PresentationFramework,", 302, 361))
								{
									num5 = 1;
									obj = SendingReportFeedbackEventArgs.smethod_0(Form1.smethod_0(assembly, "System.Windows.Application", 259, 291), "Current", 482, 465).GetGetMethod()!.Invoke(null, null);
									num5 = 6;
									obj.GetType().GetMethod("Shutdown", new Type[0])!.Invoke(obj, null);
									num5 = 5;
								}
								else
								{
									num5 = 5;
								}
							}
							else
							{
								num5 = 5;
							}
						}
						catch
						{
						}
						num6 = 0;
						num4++;
						num6 = 3;
					}
					try
					{
						num7 = 4;
						Application.Exit();
					}
					catch
					{
						try
						{
							num8 = 0;
							Environment.Exit(0);
						}
						catch
						{
						}
						num9 = 0;
					}
				}
				num10 = 4;
			}
			else
			{
				num = 7;
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[23]
			{
				type, flag, @class, reportExceptionEventArgs, ex3, assembly, text, obj, array, num4,
				num, num2, num3, num5, num6, num7, num8, num9, num10, this,
				exception_0, bool_1, bool_2
			});
			throw;
		}
	}

	private void method_4(object sender, FatalExceptionEventArgs e)
	{
		try
		{
			OnFatalException(e);
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
		EventHandler eventHandler = default(EventHandler);
		try
		{
			num = 0;
			eventHandler = eventHandler_0;
			if (eventHandler != null)
			{
				DESCryptoIndirector.smethod_4(eventHandler, sender, e, 587, 579);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, eventHandler, num, this, sender, e);
			throw;
		}
	}

	private void method_6(object sender, SendingReportFeedbackEventArgs e)
	{
		int num = default(int);
		SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler);
		try
		{
			num = 3;
			sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
			sendingReportFeedbackEventHandler?.Invoke(sender, e);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, num, this, sender, e);
			throw;
		}
	}

	protected UnhandledExceptionHandler()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static UnhandledExceptionHandler()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			bool_0 = SendingReportFeedbackEventArgs.smethod_2("False", 571, 581);
			string_0 = "1";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
