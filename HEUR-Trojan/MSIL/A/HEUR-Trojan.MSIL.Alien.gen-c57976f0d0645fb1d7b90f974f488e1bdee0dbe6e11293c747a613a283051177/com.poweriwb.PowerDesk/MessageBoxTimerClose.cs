using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;

namespace com.poweriwb.PowerDesk;

public class MessageBoxTimerClose : Window, IComponentConnector
{
	private static bool isPreLoaded = false;

	public string msg = "";

	public int nShowTimeSec = 4;

	public bool bShowCancel = false;

	public bool bShowNo = false;

	public int retVal = 0;

	private bool isFirst = true;

	private DispatcherTimer CloseTimer;

	internal Image image1;

	internal Button btnOk;

	internal Button btnCancel;

	internal TextBox txtMsg;

	private bool _contentLoaded;

	private MessageBoxTimerClose()
	{
		InitializeComponent();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		ShowCaptionAndButtonState();
		CloseTimer = new DispatcherTimer();
		CloseTimer.add_Tick((EventHandler)positionTimer_Tick);
		CloseTimer.set_Interval(TimeSpan.FromMilliseconds(1000.0));
		CloseTimer.Start();
		isPreLoaded = true;
	}

	private void positionTimer_Tick(object sender, EventArgs e)
	{
		if (isFirst)
		{
			ShowCaptionAndButtonState();
		}
		if (nShowTimeSec-- <= 0)
		{
			CloseTimer.Stop();
			CloseTimer.remove_Tick((EventHandler)positionTimer_Tick);
			CloseTimer = null;
			((Window)this).Hide();
		}
		else
		{
			string text = "{0}초 후 자동으로 닫힙니다.";
			((Window)this).set_Title(string.Format(text + "[{1}]", nShowTimeSec, Process.GetCurrentProcess().ProcessName));
		}
	}

	private void ShowCaptionAndButtonState()
	{
		isFirst = false;
		txtMsg.set_Text(msg);
		if (!bShowCancel && !bShowNo)
		{
			((UIElement)btnCancel).set_Visibility((Visibility)2);
			Grid.SetColumnSpan((UIElement)(object)btnOk, 2);
		}
		else if (bShowCancel)
		{
			((ContentControl)btnCancel).set_Content((object)"Cancel");
		}
		else
		{
			((ContentControl)btnCancel).set_Content((object)"No");
		}
	}

	public MessageBoxTimerClose(string strMsg, int timeoutSec = 4, bool ShowCancel = false, bool ShowNo = false)
	{
		if (isPreLoaded && -1 < Utils.GetComputerName().IndexOf("PGS", StringComparison.CurrentCultureIgnoreCase))
		{
			throw new Exception("이 전 호출에서 Unload되지 않았습니다.");
		}
		try
		{
			InitializeComponent();
			loaded_sub(bDoWork: true, strMsg, timeoutSec, ShowCancel, ShowNo);
		}
		catch (InvalidOperationException ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
	}

	private void loaded_sub(bool bDoWork, string strMsg, int timeoutSec, bool ShowCancel, bool ShowNo)
	{
		if (bDoWork)
		{
			msg = strMsg;
			((Window)this).set_Title("PowerHealthChecker");
			nShowTimeSec = timeoutSec;
			bShowCancel = ShowCancel;
			bShowNo = ShowNo;
		}
	}

	private void btnOk_Click(object sender, RoutedEventArgs e)
	{
		if (CloseTimer != null)
		{
			CloseTimer.Start();
			CloseTimer.remove_Tick((EventHandler)positionTimer_Tick);
			CloseTimer = null;
		}
		retVal = 1;
		((Window)this).set_DialogResult((bool?)true);
	}

	private void btnCancel_Click(object sender, RoutedEventArgs e)
	{
		if (CloseTimer != null)
		{
			CloseTimer.Stop();
			CloseTimer.remove_Tick((EventHandler)positionTimer_Tick);
			CloseTimer = null;
		}
		retVal = 2;
		((Window)this).set_DialogResult((bool?)false);
	}

	private void Window_Unloaded(object sender, RoutedEventArgs e)
	{
		if (CloseTimer != null)
		{
			CloseTimer.Stop();
			CloseTimer.remove_Tick((EventHandler)positionTimer_Tick);
			CloseTimer = null;
		}
		isPreLoaded = false;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/PowerHealthChecker;component/messageboxtimerclose.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			((FrameworkElement)(MessageBoxTimerClose)target).add_Loaded(new RoutedEventHandler(Window_Loaded));
			((FrameworkElement)(MessageBoxTimerClose)target).add_Unloaded(new RoutedEventHandler(Window_Unloaded));
			break;
		case 2:
			image1 = (Image)target;
			break;
		case 3:
			btnOk = (Button)target;
			((ButtonBase)btnOk).add_Click(new RoutedEventHandler(btnOk_Click));
			break;
		case 4:
			btnCancel = (Button)target;
			((ButtonBase)btnCancel).add_Click(new RoutedEventHandler(btnCancel_Click));
			break;
		case 5:
			txtMsg = (TextBox)target;
			break;
		}
	}
}
