using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using CiscoAnyconnectControl.UI.ViewModel;

namespace CiscoAnyconnectControl.UI.View;

public class MainWindow : Window, IComponentConnector
{
	private VpnDataViewModel _vpnDataViewModel = null;

	private VpnStatusViewModel _vpnStatusViewModel = null;

	private SettingsViewModel _settingsViewModel = null;

	private PasswordBox _pwdBox = null;

	internal ResourceDictionary ResDict;

	internal PasswordBox PwdVpnPassword;

	internal Canvas CanvasStatus;

	internal Button BtnAction;

	internal CheckBox CbSavePassword;

	private bool _contentLoaded;

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		_vpnDataViewModel = (VpnDataViewModel)MainWindow.smethod_0((FrameworkElement)(object)this, (object)"VpnData");
		_vpnStatusViewModel = (VpnStatusViewModel)MainWindow.smethod_0((FrameworkElement)(object)this, (object)"VpnStatus");
		_settingsViewModel = (SettingsViewModel)MainWindow.smethod_0((FrameworkElement)(object)this, (object)"Settings");
		_pwdBox = (PasswordBox)MainWindow.smethod_1((FrameworkElement)(object)this, "PwdVpnPassword");
		if (_pwdBox != null)
		{
			MainWindow.smethod_2(_pwdBox, _vpnDataViewModel.Password);
		}
	}

	private void PwdVpnPassword_PasswordChanged(object sender, RoutedEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		_vpnDataViewModel.SecurePassword = MainWindow.smethod_3((PasswordBox)sender);
	}

	private void BtnAction_Click(object sender, RoutedEventArgs e)
	{
		_vpnDataViewModel.SaveToModel.Execute();
		_vpnStatusViewModel?.CurrentActionCommand?.Execute();
	}

	private void Window_Closing(object sender, CancelEventArgs e)
	{
		_settingsViewModel.CommandSaveToPersistentStorage.Execute();
	}

	private void CbSavePassword_Unchecked(object sender, RoutedEventArgs e)
	{
		MainWindow.smethod_2(_pwdBox, "");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri_ = MainWindow.smethod_4("/Int32ArrayTypeI;component/view/mainwindow.xaml", UriKind.Relative);
			MainWindow.smethod_5((object)this, uri_);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return MainWindow.smethod_6(delegateType, (object)this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			MainWindow.smethod_7((FrameworkElement)(object)(MainWindow)target, new RoutedEventHandler(Window_Loaded));
			MainWindow.smethod_8((Window)(object)(MainWindow)target, (CancelEventHandler)Window_Closing);
			break;
		case 2:
			ResDict = (ResourceDictionary)target;
			break;
		case 3:
			PwdVpnPassword = (PasswordBox)target;
			MainWindow.smethod_9(PwdVpnPassword, new RoutedEventHandler(PwdVpnPassword_PasswordChanged));
			break;
		case 4:
			CanvasStatus = (Canvas)target;
			break;
		case 5:
			BtnAction = (Button)target;
			MainWindow.smethod_10((ButtonBase)(object)BtnAction, new RoutedEventHandler(BtnAction_Click));
			break;
		case 6:
			CbSavePassword = (CheckBox)target;
			MainWindow.smethod_11((ToggleButton)(object)CbSavePassword, new RoutedEventHandler(CbSavePassword_Unchecked));
			break;
		}
	}

	static object smethod_0(FrameworkElement frameworkElement_0, object object_0)
	{
		return frameworkElement_0.FindResource(object_0);
	}

	static object smethod_1(FrameworkElement frameworkElement_0, string string_0)
	{
		return frameworkElement_0.FindName(string_0);
	}

	static void smethod_2(PasswordBox passwordBox_0, string string_0)
	{
		passwordBox_0.set_Password(string_0);
	}

	static SecureString smethod_3(PasswordBox passwordBox_0)
	{
		return passwordBox_0.get_SecurePassword();
	}

	static Uri smethod_4(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static void smethod_5(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}

	static Delegate smethod_6(Type type_0, object object_0, string string_0)
	{
		return Delegate.CreateDelegate(type_0, object_0, string_0);
	}

	static void smethod_7(FrameworkElement frameworkElement_0, RoutedEventHandler routedEventHandler_0)
	{
		frameworkElement_0.add_Loaded(routedEventHandler_0);
	}

	static void smethod_8(Window window_0, CancelEventHandler cancelEventHandler_0)
	{
		window_0.add_Closing(cancelEventHandler_0);
	}

	static void smethod_9(PasswordBox passwordBox_0, RoutedEventHandler routedEventHandler_0)
	{
		passwordBox_0.add_PasswordChanged(routedEventHandler_0);
	}

	static void smethod_10(ButtonBase buttonBase_0, RoutedEventHandler routedEventHandler_0)
	{
		buttonBase_0.add_Click(routedEventHandler_0);
	}

	static void smethod_11(ToggleButton toggleButton_0, RoutedEventHandler routedEventHandler_0)
	{
		toggleButton_0.add_Unchecked(routedEventHandler_0);
	}
}
