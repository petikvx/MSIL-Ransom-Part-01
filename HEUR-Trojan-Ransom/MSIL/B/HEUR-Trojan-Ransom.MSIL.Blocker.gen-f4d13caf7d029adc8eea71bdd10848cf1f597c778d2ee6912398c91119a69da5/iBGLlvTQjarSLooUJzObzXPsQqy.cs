using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using Auth0.OidcClient;
using IdentityModel.OidcClient;
using Wheels;

public class iBGLlvTQjarSLooUJzObzXPsQqy : Window, IComponentConnector
{
	private Auth0Client auth0Client_0;

	[CompilerGenerated]
	private AppSettings appSettings_0;

	private string string_0 = "SimShaker User Authorization";

	private string string_1 = "";

	private string string_2 = "101";

	private string string_3 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_1(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_0(Environment.SpecialFolder.CommonApplicationData), "\\recently-used");

	private string string_4 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_1(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_0(Environment.SpecialFolder.CommonApplicationData), "\\SSW\\auth_blockchain.ssw");

	private string string_5 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_1(Utils.SettingsFolder, "\\auth_scrt.ssw");

	private bool bool_0;

	private bool bool_1;

	private LoginResult loginResult_0;

	private string string_6 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_2();

	internal Label label_0;

	internal TextBox textBox_0;

	internal Label label_1;

	internal PasswordBox passwordBox_0;

	internal TextBlock textBlock_0;

	internal Button button_0;

	internal Button button_1;

	internal Label label_2;

	internal Label label_3;

	internal CheckBox checkBox_0;

	internal Button button_2;

	internal CheckBox checkBox_1;

	internal Image image_0;

	internal Image image_1;

	internal Image image_2;

	private bool bool_2;

	private AppSettings AppSettings_0
	{
		[CompilerGenerated]
		get
		{
			return appSettings_0;
		}
		[CompilerGenerated]
		set
		{
			appSettings_0 = value;
		}
	}

	public iBGLlvTQjarSLooUJzObzXPsQqy(AppSettings appSettings_1)
	{
		InitializeComponent();
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_3((UIElement)(object)label_2, (Visibility)1);
		AppSettings_0 = appSettings_1;
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_5(textBox_0, iBGLlvTQjarSLooUJzObzXPsQqy.smethod_4(AppSettings_0));
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_7(passwordBox_0, iBGLlvTQjarSLooUJzObzXPsQqy.smethod_6(AppSettings_0));
		if (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_8(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_4(AppSettings_0)) < 3 && iBGLlvTQjarSLooUJzObzXPsQqy.smethod_8(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_6(AppSettings_0)) < 16)
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_3((UIElement)(object)image_2, (Visibility)0);
		}
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_3((UIElement)(object)button_2, (Visibility)1);
		if (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_9(AppSettings_0))
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_10((ToggleButton)(object)checkBox_1, (bool?)true);
		}
	}

	private void method_0(object sender, RequestNavigateEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_14(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_13(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_12(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_11(e))));
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_15((RoutedEventArgs)(object)e, bool_3: true);
		}
		catch (Exception exception_)
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_17(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_16(exception_));
		}
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_18((Window)(object)this);
	}

	private async void method_2(object sender, RoutedEventArgs e)
	{
		method_3();
		if (Struct0.smethod_1(Struct0.smethod_0("Auth0.OidcClient.dll")) == 15872L)
		{
			Struct0.smethod_2((UIElement)(object)label_2, (Visibility)0);
			Struct0.smethod_3((UIElement)(object)button_0, bool_0: false);
			loginResult_0 = await Struct0.smethod_4(auth0Client_0, (object)null);
			if (Struct0.smethod_5((Result)(object)loginResult_0))
			{
				string_2 = "2";
				string text = (Struct0.smethod_6(AppSettings_0) ? "support@realteus.com" : "simshaker@outlook.com");
				Struct0.smethod_2((UIElement)(object)label_2, (Visibility)1);
				Struct0.smethod_3((UIElement)(object)button_0, bool_0: true);
				Struct0.smethod_8(Struct0.smethod_7("Activation failed. Error code: ", string_2, ". Please contact us via e-mail ", text), string_0, (MessageBoxButton)0, (MessageBoxImage)16);
				return;
			}
			try
			{
				method_4();
				method_5();
			}
			catch (Exception)
			{
				Struct0.smethod_2((UIElement)(object)label_2, (Visibility)1);
				Struct0.smethod_3((UIElement)(object)button_0, bool_0: true);
				Struct0.smethod_8(Struct0.smethod_9("Activation failed. Error code: ", string_2, ". Please contact me via e-mail simshaker@outlook.com"), string_0, (MessageBoxButton)0, (MessageBoxImage)16);
			}
			Struct0.smethod_10(AppSettings_0, bool_0: false);
			Struct0.smethod_8(Struct0.smethod_11("Activation successful \nActivations left: ", string_1), string_0, (MessageBoxButton)0, (MessageBoxImage)64);
			if (Struct0.smethod_6(AppSettings_0))
			{
				Struct0.smethod_12(AppSettings_0, bool_0: true);
				Struct0.smethod_13(AppSettings_0, bool_0: false);
				Struct0.smethod_14(AppSettings_0, bool_0: false);
				Struct0.smethod_15(AppSettings_0);
			}
			Struct0.smethod_16((Window)(object)this);
		}
		else
		{
			string_2 = "11";
			Struct0.smethod_8(Struct0.smethod_9("Activation failed. Error code: ", string_2, ". Please contact me via e-mail simshaker@outlook.com"), string_0, (MessageBoxButton)0, (MessageBoxImage)16);
		}
	}

	private void method_3()
	{
		if (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_9(AppSettings_0))
		{
			Auth0ClientOptions auth0ClientOptions_ = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_19();
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_20(auth0ClientOptions_, "sim-wheels-r.eu.auth0.com");
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_21(auth0ClientOptions_, "totP1V6H8uZm4HfoIe5nJZg9c004x97t");
			auth0Client_0 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_22(auth0ClientOptions_);
		}
		else
		{
			Auth0ClientOptions auth0ClientOptions_2 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_19();
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_20(auth0ClientOptions_2, "simshaker-wheels.auth0.com");
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_21(auth0ClientOptions_2, "lLtG4AlvGIMaRsHaFD5iWA6Sn0Iz8Xmq");
			auth0Client_0 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_22(auth0ClientOptions_2);
		}
	}

	private void method_4()
	{
		string_2 = "3";
		IEnumerator<Claim> enumerator = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_24(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_23(loginResult_0)).GetEnumerator();
		try
		{
			while (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_28((IEnumerator)enumerator))
			{
				Claim current = enumerator.Current;
				if (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_26(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_25(current), "http://ssw/act-left"))
				{
					string_1 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_27(current);
				}
				if (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_26(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_25(current), "http://ssw/options") && iBGLlvTQjarSLooUJzObzXPsQqy.smethod_26(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_27(current), "audio_6ch_allowed"))
				{
					bool_0 = true;
				}
				if (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_26(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_25(current), "http://ssw/options1") && iBGLlvTQjarSLooUJzObzXPsQqy.smethod_26(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_27(current), "forcefeel_allowed"))
				{
					bool_1 = true;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				iBGLlvTQjarSLooUJzObzXPsQqy.smethod_29((IDisposable)enumerator);
			}
		}
		if (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_9(AppSettings_0))
		{
			bool_1 = true;
		}
	}

	private void method_5()
	{
		string_2 = "6";
		SHA384 sHA = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_30();
		try
		{
			byte[] byte_ = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_31(string_3);
			string_2 = "7";
			byte[] byte_2 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_32((HashAlgorithm)sHA, byte_);
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_34(AppSettings_0, iBGLlvTQjarSLooUJzObzXPsQqy.smethod_33(byte_2));
			if (bool_0)
			{
				string_2 = "7a";
				byte_2 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_35((HashAlgorithm)sHA, byte_, 4, 8);
				iBGLlvTQjarSLooUJzObzXPsQqy.smethod_36(AppSettings_0, iBGLlvTQjarSLooUJzObzXPsQqy.smethod_33(byte_2));
			}
			if (bool_1)
			{
				string_2 = "7b";
				byte_2 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_35((HashAlgorithm)sHA, byte_, 10, 8);
				iBGLlvTQjarSLooUJzObzXPsQqy.smethod_37(AppSettings_0, iBGLlvTQjarSLooUJzObzXPsQqy.smethod_33(byte_2));
			}
		}
		finally
		{
			if (sHA != null)
			{
				iBGLlvTQjarSLooUJzObzXPsQqy.smethod_29((IDisposable)sHA);
			}
		}
		DateTime dateTime = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_38(string_3);
		DateTime dateTime2 = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_39(string_3);
		AppSettings_0.set_Offset(Math.Abs(dateTime.GetHashCode()) - Math.Abs(dateTime2.GetHashCode()));
		string_2 = "8";
		AppSettings_0.set_Email(textBox_0.get_Text());
		AppSettings_0.SaveToFile();
		((UIElement)label_2).set_Visibility((Visibility)1);
		AppSettings_0.set_Num(0);
		string_2 = "9f1";
		File.WriteAllText(string_4, AppSettings_0.get_Email() + "_BTvd6KcJW7SNT9LWRXDqqBaEMk4oh2TNEVtm+3cx2z91");
		string_2 = "9f2";
		File.SetAttributes(string_5, FileAttributes.Normal);
		File.WriteAllText(string_5, "3sAVL6Z3APlNeQyc");
		File.SetAttributes(string_5, FileAttributes.Hidden);
		string_2 = "10";
		AppSettings_0.set_Email(textBox_0.get_Text());
		AppSettings_0.SaveToFile();
	}

	private void method_6(object sender, RoutedEventArgs e)
	{
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_40((UIElement)(object)button_0, bool_3: true);
	}

	private void method_7(object sender, RoutedEventArgs e)
	{
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_41(AppSettings_0, bool_3: true);
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_18((Window)(object)this);
	}

	private void method_8(object sender, RoutedEventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		if (iBGLlvTQjarSLooUJzObzXPsQqy.smethod_42((ToggleButton)(object)checkBox_1) != true)
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_44(AppSettings_0, bool_3: false);
		}
		else if ((int)iBGLlvTQjarSLooUJzObzXPsQqy.smethod_43("Are you really sure? This option is suitable only for those who finally have got a VALID key from Realteus and want to use it here. Press NO and let it stay un-checked if you are going to use the key you've got from Andre.", "Are you sure?", (MessageBoxButton)4, (MessageBoxImage)48) == 6)
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_44(AppSettings_0, bool_3: true);
		}
		else
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_10((ToggleButton)(object)checkBox_1, (bool?)false);
		}
		iBGLlvTQjarSLooUJzObzXPsQqy.smethod_45(AppSettings_0);
	}

	private void method_9(object sender, MouseButtonEventArgs e)
	{
		try
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_47(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_46(textBox_0));
		}
		catch (Exception)
		{
		}
	}

	private void method_10(object sender, MouseButtonEventArgs e)
	{
		try
		{
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_47(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_49(iBGLlvTQjarSLooUJzObzXPsQqy.smethod_48(passwordBox_0)));
		}
		catch (Exception)
		{
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bool_2)
		{
			bool_2 = true;
			Uri uri_ = iBGLlvTQjarSLooUJzObzXPsQqy.smethod_50("/SimShaker - Wheels;component/erfiacniavirmihcdtmrnqtcuegr.xaml", UriKind.Relative);
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_51((object)this, uri_);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a8: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			bool_2 = true;
			break;
		case 1:
			label_0 = (Label)target;
			break;
		case 2:
			textBox_0 = (TextBox)target;
			break;
		case 3:
			label_1 = (Label)target;
			break;
		case 4:
			passwordBox_0 = (PasswordBox)target;
			break;
		case 5:
			textBlock_0 = (TextBlock)target;
			break;
		case 6:
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_52((Hyperlink)target, new RequestNavigateEventHandler(method_0));
			break;
		case 7:
			button_0 = (Button)target;
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_53((ButtonBase)(object)button_0, new RoutedEventHandler(method_2));
			break;
		case 8:
			button_1 = (Button)target;
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_53((ButtonBase)(object)button_1, new RoutedEventHandler(method_1));
			break;
		case 9:
			label_2 = (Label)target;
			break;
		case 10:
			label_3 = (Label)target;
			break;
		case 11:
			checkBox_0 = (CheckBox)target;
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_54((ToggleButton)(object)checkBox_0, new RoutedEventHandler(method_6));
			break;
		case 12:
			button_2 = (Button)target;
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_53((ButtonBase)(object)button_2, new RoutedEventHandler(method_7));
			break;
		case 13:
			checkBox_1 = (CheckBox)target;
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_53((ButtonBase)(object)checkBox_1, new RoutedEventHandler(method_8));
			break;
		case 14:
			image_0 = (Image)target;
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_55((UIElement)(object)image_0, new MouseButtonEventHandler(method_9));
			break;
		case 15:
			image_1 = (Image)target;
			iBGLlvTQjarSLooUJzObzXPsQqy.smethod_55((UIElement)(object)image_1, new MouseButtonEventHandler(method_10));
			break;
		case 16:
			image_2 = (Image)target;
			break;
		}
	}

	static string smethod_0(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static string smethod_1(string string_7, string string_8)
	{
		return string_7 + string_8;
	}

	static string smethod_2()
	{
		return Environment.NewLine;
	}

	static void smethod_3(UIElement uielement_0, Visibility visibility_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		uielement_0.set_Visibility(visibility_0);
	}

	static string smethod_4(AppSettings appSettings_1)
	{
		return appSettings_1.get_Email();
	}

	static void smethod_5(TextBox textBox_1, string string_7)
	{
		textBox_1.set_Text(string_7);
	}

	static string smethod_6(AppSettings appSettings_1)
	{
		return appSettings_1.get_Key();
	}

	static void smethod_7(PasswordBox passwordBox_1, string string_7)
	{
		passwordBox_1.set_Password(string_7);
	}

	static int smethod_8(string string_7)
	{
		return string_7.Length;
	}

	static bool smethod_9(AppSettings appSettings_1)
	{
		return appSettings_1.get_RealteusA();
	}

	static void smethod_10(ToggleButton toggleButton_0, bool? nullable_0)
	{
		toggleButton_0.set_IsChecked(nullable_0);
	}

	static Uri smethod_11(RequestNavigateEventArgs requestNavigateEventArgs_0)
	{
		return requestNavigateEventArgs_0.get_Uri();
	}

	static string smethod_12(Uri uri_0)
	{
		return uri_0.AbsoluteUri;
	}

	static ProcessStartInfo smethod_13(string string_7)
	{
		return new ProcessStartInfo(string_7);
	}

	static Process smethod_14(ProcessStartInfo processStartInfo_0)
	{
		return Process.Start(processStartInfo_0);
	}

	static void smethod_15(RoutedEventArgs routedEventArgs_0, bool bool_3)
	{
		routedEventArgs_0.set_Handled(bool_3);
	}

	static string smethod_16(Exception exception_0)
	{
		return exception_0.Message;
	}

	static MessageBoxResult smethod_17(string string_7)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_7);
	}

	static void smethod_18(Window window_0)
	{
		window_0.Close();
	}

	static Auth0ClientOptions smethod_19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Auth0ClientOptions();
	}

	static void smethod_20(Auth0ClientOptions auth0ClientOptions_0, string string_7)
	{
		auth0ClientOptions_0.set_Domain(string_7);
	}

	static void smethod_21(Auth0ClientOptions auth0ClientOptions_0, string string_7)
	{
		auth0ClientOptions_0.set_ClientId(string_7);
	}

	static Auth0Client smethod_22(Auth0ClientOptions auth0ClientOptions_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Auth0Client(auth0ClientOptions_0);
	}

	static ClaimsPrincipal smethod_23(LoginResult loginResult_1)
	{
		return loginResult_1.get_User();
	}

	static IEnumerable<Claim> smethod_24(ClaimsPrincipal claimsPrincipal_0)
	{
		return claimsPrincipal_0.Claims;
	}

	static string smethod_25(Claim claim_0)
	{
		return claim_0.Type;
	}

	static bool smethod_26(string string_7, string string_8)
	{
		return string_7 == string_8;
	}

	static string smethod_27(Claim claim_0)
	{
		return claim_0.Value;
	}

	static bool smethod_28(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_29(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static SHA384Managed smethod_30()
	{
		return new SHA384Managed();
	}

	static byte[] smethod_31(string string_7)
	{
		return File.ReadAllBytes(string_7);
	}

	static byte[] smethod_32(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
	{
		return hashAlgorithm_0.ComputeHash(byte_0);
	}

	static string smethod_33(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	static void smethod_34(AppSettings appSettings_1, string string_7)
	{
		appSettings_1.set_Network(string_7);
	}

	static byte[] smethod_35(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		return hashAlgorithm_0.ComputeHash(byte_0, int_0, int_1);
	}

	static void smethod_36(AppSettings appSettings_1, string string_7)
	{
		appSettings_1.set_Preset(string_7);
	}

	static void smethod_37(AppSettings appSettings_1, string string_7)
	{
		appSettings_1.set_Grids(string_7);
	}

	static DateTime smethod_38(string string_7)
	{
		return File.GetCreationTime(string_7);
	}

	static DateTime smethod_39(string string_7)
	{
		return File.GetLastWriteTime(string_7);
	}

	static void smethod_40(UIElement uielement_0, bool bool_3)
	{
		uielement_0.set_IsEnabled(bool_3);
	}

	static void smethod_41(AppSettings appSettings_1, bool bool_3)
	{
		appSettings_1.set_Deactivated(bool_3);
	}

	static bool? smethod_42(ToggleButton toggleButton_0)
	{
		return toggleButton_0.get_IsChecked();
	}

	static MessageBoxResult smethod_43(string string_7, string string_8, MessageBoxButton messageBoxButton_0, MessageBoxImage messageBoxImage_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_7, string_8, messageBoxButton_0, messageBoxImage_0);
	}

	static void smethod_44(AppSettings appSettings_1, bool bool_3)
	{
		appSettings_1.set_RealteusA(bool_3);
	}

	static bool smethod_45(AppSettings appSettings_1)
	{
		return appSettings_1.SaveToFile();
	}

	static string smethod_46(TextBox textBox_1)
	{
		return textBox_1.get_Text();
	}

	static void smethod_47(string string_7)
	{
		Clipboard.SetText(string_7);
	}

	static string smethod_48(PasswordBox passwordBox_1)
	{
		return passwordBox_1.get_Password();
	}

	static string smethod_49(string string_7)
	{
		return string_7.Trim();
	}

	static Uri smethod_50(string string_7, UriKind uriKind_0)
	{
		return new Uri(string_7, uriKind_0);
	}

	static void smethod_51(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}

	static void smethod_52(Hyperlink hyperlink_0, RequestNavigateEventHandler requestNavigateEventHandler_0)
	{
		hyperlink_0.add_RequestNavigate(requestNavigateEventHandler_0);
	}

	static void smethod_53(ButtonBase buttonBase_0, RoutedEventHandler routedEventHandler_0)
	{
		buttonBase_0.add_Click(routedEventHandler_0);
	}

	static void smethod_54(ToggleButton toggleButton_0, RoutedEventHandler routedEventHandler_0)
	{
		toggleButton_0.add_Checked(routedEventHandler_0);
	}

	static void smethod_55(UIElement uielement_0, MouseButtonEventHandler mouseButtonEventHandler_0)
	{
		uielement_0.add_MouseUp(mouseButtonEventHandler_0);
	}
}
