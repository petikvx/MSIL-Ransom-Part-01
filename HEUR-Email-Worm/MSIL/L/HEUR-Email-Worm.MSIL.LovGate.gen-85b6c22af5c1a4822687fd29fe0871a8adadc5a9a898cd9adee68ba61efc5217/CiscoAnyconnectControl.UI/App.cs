#define TRACE
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using CiscoAnyconnectControl.Model;
using CiscoAnyconnectControl.UI.Utility;
using CiscoAnyconnectControl.UI.View;
using CiscoAnyconnectControl.Utility;

namespace CiscoAnyconnectControl.UI;

public class App : Application
{
	private enum ErrorCode
	{
		FailedIpc = -1,
		NotFirstInstance = -2,
		CiscoAutostartDetected = -3,
		NotElevated = -4
	}

	private Mutex _mutex;

	private EventWaitHandle _evtShowWindow;

	private readonly CancellationTokenSource _ctsExiting = App.smethod_29();

	private bool _contentLoaded;

	private string EventWaitHandleShowWindowName => "jannesp.ciscoanyconnectcontrol.evt_showwindow";

	protected override void OnStartup(StartupEventArgs e)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Invalid comparison between Unknown and I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		bool flag = false;
		bool flag2 = CheckIfFirstInstance();
		bool flag3 = OSUtil.Instance.IsElevatedProcess();
		bool flag4 = false;
		try
		{
			ServiceUtil.Uninstall("CiscoAnyconnectControlServer");
		}
		catch (Exception)
		{
		}
		string[] array = App.smethod_0(e);
		foreach (string text in array)
		{
			App.smethod_1("Parsing arg: {0} ...", new object[1] { text });
			string text2 = text;
			string string_ = text2;
			if (App.smethod_2(string_, "-tray"))
			{
				if (flag2)
				{
					OSUtil.Instance.ShowTrayIcon();
				}
				flag = true;
			}
			else if (!App.smethod_2(string_, "-unsafeRunAsUser"))
			{
				App.smethod_1("Arg: \"{0}\" is not implemented and got ignored.", new object[1] { text });
			}
			else
			{
				flag4 = true;
			}
		}
		if (!flag2)
		{
			try
			{
				_evtShowWindow = App.smethod_3(EventWaitHandleShowWindowName);
				App.smethod_4(_evtShowWindow);
				App.smethod_5((WaitHandle)_evtShowWindow);
				_evtShowWindow = null;
				App.smethod_6("Showed existing instance and exiting ...");
			}
			catch (Exception ex2)
			{
				Util.TraceException("Error showing existing instance", ex2);
				App.smethod_7("Another instance is already running but there was an error showing that.");
			}
			App.smethod_9(App.smethod_8(), -2);
			return;
		}
		try
		{
			bool bool_ = default(bool);
			_evtShowWindow = App.smethod_10(bool_0: false, EventResetMode.ManualReset, EventWaitHandleShowWindowName, ref bool_);
			if (!bool_)
			{
				App.smethod_4(_evtShowWindow);
				App.smethod_9(App.smethod_8(), 0);
				return;
			}
		}
		catch (Exception ex3)
		{
			Util.TraceException("Error creating mutex for showwindow", ex3);
		}
		if (!flag3)
		{
			if (!flag4)
			{
				App.smethod_7("This program 'needs' to be run as administrator.\nContact me if you really need to run it without.");
				App.smethod_9(App.smethod_8(), -4);
				return;
			}
			App.smethod_11("Starting without elevated permissions.");
		}
		if (flag3 && OSUtil.Instance.IsCiscoAutostartEnabled())
		{
			MessageBoxResult val = App.smethod_12("Cisco UI Autostart found. This doesn't work together with this program.\nDo you want to disable it? This program will exit if you don't.", "CiscoAnyconnectControl", (MessageBoxButton)4);
			if ((int)val != 6)
			{
				App.smethod_6("User denied disabling of cisco autostart. Exiting ...");
				App.smethod_9(App.smethod_8(), -3);
				return;
			}
			OSUtil.Instance.DisableCiscoAutostart();
		}
		if (!flag)
		{
			CreateAndOrShowMainWindow();
			OSUtil.Instance.ShowTrayIcon();
		}
		App.smethod_13(App.smethod_8(), (ShutdownMode)2);
		App.smethod_14(App.smethod_8(), new DispatcherUnhandledExceptionEventHandler(Current_DispatcherUnhandledException));
		OSUtil.Instance.TrayIconDoubleClick += App_TrayIconDoubleClick;
		OSUtil.Instance.TrayExitClick += App_TrayExitClick;
		((Application)this).OnStartup(e);
	}

	private void App_TrayExitClick(object sender, EventArgs e)
	{
		App.smethod_9(App.smethod_8(), 0);
	}

	private void CreateAndOrShowMainWindow()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (App.smethod_15(App.smethod_8()) != null)
		{
			if ((int)App.smethod_19(App.smethod_15(App.smethod_8())) == 1)
			{
				App.smethod_20(App.smethod_15(App.smethod_8()), (WindowState)0);
			}
			App.smethod_21(App.smethod_15(App.smethod_8()));
		}
		else
		{
			MainWindow window_ = new MainWindow();
			App.smethod_16((Window)(object)window_);
			App.smethod_17((Window)(object)window_, (EventHandler)Window_Closed);
			App.smethod_18(App.smethod_8(), (Window)(object)window_);
		}
	}

	private void App_TrayIconDoubleClick(object sender, EventArgs e)
	{
		CreateAndOrShowMainWindow();
	}

	private bool CheckIfFirstInstance()
	{
		_mutex = App.smethod_22(bool_0: false, "e35d4009-816a-454f-80cc-190e27f95384");
		try
		{
			if (!App.smethod_23((WaitHandle)_mutex, 0, bool_0: false))
			{
				return false;
			}
		}
		catch (Exception ex)
		{
			Util.TraceException("Exception creating mutex.", ex);
		}
		return true;
	}

	private void Current_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
	{
		try
		{
			OSUtil.Instance.HideTrayIcon();
		}
		catch (Exception ex)
		{
			Util.TraceException("Unhandled exception in unhandled exception handler.", ex);
		}
		finally
		{
			((App)(object)_mutex)?.method_0();
			_mutex = null;
		}
	}

	private void Window_Closed(object sender, EventArgs e)
	{
	}

	protected override void OnExit(ExitEventArgs e)
	{
		OSUtil.Instance.HideTrayIcon();
		App.smethod_24(_ctsExiting);
		EventWaitHandle evtShowWindow = _evtShowWindow;
		if (evtShowWindow != null)
		{
			App.smethod_25(evtShowWindow);
		}
		((App)(object)_mutex)?.method_0();
		_mutex = null;
		((App)(object)_evtShowWindow)?.method_0();
		_evtShowWindow = null;
		((App)(object)_ctsExiting)?.method_1();
		VpnStatusModel.Instance.Dispose();
		((Application)this).OnExit(e);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri_ = App.smethod_26("/Int32ArrayTypeI;component/app.xaml", UriKind.Relative);
			App.smethod_27((object)this, uri_);
		}
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		App.smethod_28((Application)(object)app);
	}

	static string[] smethod_0(StartupEventArgs startupEventArgs_0)
	{
		return startupEventArgs_0.get_Args();
	}

	static void smethod_1(string string_0, object[] object_0)
	{
		Trace.TraceInformation(string_0, object_0);
	}

	static bool smethod_2(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static EventWaitHandle smethod_3(string string_0)
	{
		return EventWaitHandle.OpenExisting(string_0);
	}

	static bool smethod_4(EventWaitHandle eventWaitHandle_0)
	{
		return eventWaitHandle_0.Set();
	}

	static void smethod_5(WaitHandle waitHandle_0)
	{
		waitHandle_0.Dispose();
	}

	static void smethod_6(string string_0)
	{
		Trace.TraceInformation(string_0);
	}

	static MessageBoxResult smethod_7(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static Application smethod_8()
	{
		return Application.get_Current();
	}

	static void smethod_9(Application application_0, int int_0)
	{
		application_0.Shutdown(int_0);
	}

	static EventWaitHandle smethod_10(bool bool_0, EventResetMode eventResetMode_0, string string_0, ref bool bool_1)
	{
		return new EventWaitHandle(bool_0, eventResetMode_0, string_0, out bool_1);
	}

	static void smethod_11(string string_0)
	{
		Trace.TraceWarning(string_0);
	}

	static MessageBoxResult smethod_12(string string_0, string string_1, MessageBoxButton messageBoxButton_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButton_0);
	}

	static void smethod_13(Application application_0, ShutdownMode shutdownMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		application_0.set_ShutdownMode(shutdownMode_0);
	}

	static void smethod_14(Application application_0, DispatcherUnhandledExceptionEventHandler dispatcherUnhandledExceptionEventHandler_0)
	{
		application_0.add_DispatcherUnhandledException(dispatcherUnhandledExceptionEventHandler_0);
	}

	static Window smethod_15(Application application_0)
	{
		return application_0.get_MainWindow();
	}

	static void smethod_16(Window window_0)
	{
		window_0.Show();
	}

	static void smethod_17(Window window_0, EventHandler eventHandler_0)
	{
		window_0.add_Closed(eventHandler_0);
	}

	static void smethod_18(Application application_0, Window window_0)
	{
		application_0.set_MainWindow(window_0);
	}

	static WindowState smethod_19(Window window_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return window_0.get_WindowState();
	}

	static void smethod_20(Window window_0, WindowState windowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		window_0.set_WindowState(windowState_0);
	}

	static bool smethod_21(Window window_0)
	{
		return window_0.Activate();
	}

	static Mutex smethod_22(bool bool_0, string string_0)
	{
		return new Mutex(bool_0, string_0);
	}

	static bool smethod_23(WaitHandle waitHandle_0, int int_0, bool bool_0)
	{
		return waitHandle_0.WaitOne(int_0, bool_0);
	}

	void method_0()
	{
		((WaitHandle)this).Dispose();
	}

	static void smethod_24(CancellationTokenSource cancellationTokenSource_0)
	{
		cancellationTokenSource_0.Cancel();
	}

	static bool smethod_25(EventWaitHandle eventWaitHandle_0)
	{
		return eventWaitHandle_0.Set();
	}

	void method_1()
	{
		((CancellationTokenSource)this).Dispose();
	}

	static Uri smethod_26(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static void smethod_27(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}

	static int smethod_28(Application application_0)
	{
		return application_0.Run();
	}

	static CancellationTokenSource smethod_29()
	{
		return new CancellationTokenSource();
	}
}
