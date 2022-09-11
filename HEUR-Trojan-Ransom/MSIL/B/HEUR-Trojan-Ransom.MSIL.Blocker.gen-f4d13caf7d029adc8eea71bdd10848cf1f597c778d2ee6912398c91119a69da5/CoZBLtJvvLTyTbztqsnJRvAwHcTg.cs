using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Wheels;

public class CoZBLtJvvLTyTbztqsnJRvAwHcTg : Window, IComponentConnector
{
	private AppSettings appSettings_0;

	private Effects effects_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	internal Label label_0;

	internal Slider slider_0;

	internal Label label_1;

	internal Slider slider_1;

	internal Button button_0;

	internal Button button_1;

	internal CheckBox checkBox_0;

	private bool bool_0;

	public CoZBLtJvvLTyTbztqsnJRvAwHcTg(AppSettings appSettings_1, Effects effects_1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		appSettings_0 = appSettings_1;
		effects_0 = effects_1;
	}

	private void method_0(object sender, RoutedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		method_2(effects_0);
		CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_0((Window)(object)this);
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
		CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_0((Window)(object)this);
	}

	private void method_2(Effects effects_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		if ((int)effects_1 != 0 && (int)effects_1 == 1)
		{
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_2(appSettings_0, CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_1((RangeBase)(object)slider_0));
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_3(appSettings_0, CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_1((RangeBase)(object)slider_1));
			if (CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_4((ToggleButton)(object)checkBox_0).HasValue)
			{
				CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_5(appSettings_0, CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_4((ToggleButton)(object)checkBox_0).Value);
			}
		}
		CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_6(appSettings_0);
	}

	private void method_3(Effects effects_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)effects_1 != 0 && (int)effects_1 == 1)
		{
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_8((RangeBase)(object)slider_0, CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_7(appSettings_0));
			string_0 = "Start Effect at ";
			string_2 = " % of Max RPM";
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_9((RangeBase)(object)slider_0, 0.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_10((RangeBase)(object)slider_0, 100.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_13(slider_0, (CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_11((RangeBase)(object)slider_0) - CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_12((RangeBase)(object)slider_0)) / 10.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_15((RangeBase)(object)slider_0, CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_14(slider_0) / 10.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_16((RangeBase)(object)slider_0, CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_14(slider_0));
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_8((RangeBase)(object)slider_1, CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_17(appSettings_0));
			string_1 = "Start Extra Tone at ";
			string_3 = " % of Max RPM";
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_9((RangeBase)(object)slider_1, 85.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_10((RangeBase)(object)slider_1, 100.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_13(slider_1, (CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_11((RangeBase)(object)slider_1) - CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_12((RangeBase)(object)slider_1)) / 10.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_15((RangeBase)(object)slider_1, 1.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_16((RangeBase)(object)slider_1, 5.0);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_19((ToggleButton)(object)checkBox_0, (bool?)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_18(appSettings_0));
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_20((ContentControl)(object)checkBox_0, (object)"Add Extra Tone (for bass-shakers)");
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_21((UIElement)(object)checkBox_0, (Visibility)0);
		}
		CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_20((ContentControl)(object)label_0, (object)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_23((object)string_0, (object)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_22(CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_1((RangeBase)(object)slider_0), 0), (object)string_2));
		CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_20((ContentControl)(object)label_1, (object)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_23((object)string_1, (object)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_22(CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_1((RangeBase)(object)slider_1), 0), (object)string_3));
	}

	private void method_4(object sender, RoutedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		method_3(effects_0);
	}

	private void method_5(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_20((ContentControl)(object)label_0, (object)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_23((object)string_0, (object)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_22(CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_1((RangeBase)(object)slider_0), 0), (object)string_2));
	}

	private void method_6(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_20((ContentControl)(object)label_1, (object)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_23((object)string_1, (object)CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_22(CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_1((RangeBase)(object)slider_1), 0), (object)string_3));
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!bool_0)
		{
			bool_0 = true;
			Uri uri_ = CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_24("/SimShaker - Wheels;component/zpzbxltjjphzudnsdgmmzgnmfbuka.xaml", UriKind.Relative);
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_25((object)this, uri_);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			bool_0 = true;
			break;
		case 1:
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_26((FrameworkElement)(object)(CoZBLtJvvLTyTbztqsnJRvAwHcTg)target, new RoutedEventHandler(method_4));
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_27((Window)(object)(CoZBLtJvvLTyTbztqsnJRvAwHcTg)target, (EventHandler)method_7);
			break;
		case 2:
			label_0 = (Label)target;
			break;
		case 3:
			slider_0 = (Slider)target;
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_28((RangeBase)(object)slider_0, (RoutedPropertyChangedEventHandler<double>)method_5);
			break;
		case 4:
			label_1 = (Label)target;
			break;
		case 5:
			slider_1 = (Slider)target;
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_28((RangeBase)(object)slider_1, (RoutedPropertyChangedEventHandler<double>)method_6);
			break;
		case 6:
			button_0 = (Button)target;
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_29((ButtonBase)(object)button_0, new RoutedEventHandler(method_0));
			break;
		case 7:
			button_1 = (Button)target;
			CoZBLtJvvLTyTbztqsnJRvAwHcTg.smethod_29((ButtonBase)(object)button_1, new RoutedEventHandler(method_1));
			break;
		case 8:
			checkBox_0 = (CheckBox)target;
			break;
		}
	}

	static void smethod_0(Window window_0)
	{
		window_0.Close();
	}

	static double smethod_1(RangeBase rangeBase_0)
	{
		return rangeBase_0.get_Value();
	}

	static void smethod_2(AppSettings appSettings_1, double double_0)
	{
		appSettings_1.set_EngineBeatStart(double_0);
	}

	static void smethod_3(AppSettings appSettings_1, double double_0)
	{
		appSettings_1.set_EngineBeatStartExtra(double_0);
	}

	static bool? smethod_4(ToggleButton toggleButton_0)
	{
		return toggleButton_0.get_IsChecked();
	}

	static void smethod_5(AppSettings appSettings_1, bool bool_1)
	{
		appSettings_1.set_EngineBeatExtraTone(bool_1);
	}

	static bool smethod_6(AppSettings appSettings_1)
	{
		return appSettings_1.SaveToFile();
	}

	static double smethod_7(AppSettings appSettings_1)
	{
		return appSettings_1.get_EngineBeatStart();
	}

	static void smethod_8(RangeBase rangeBase_0, double double_0)
	{
		rangeBase_0.set_Value(double_0);
	}

	static void smethod_9(RangeBase rangeBase_0, double double_0)
	{
		rangeBase_0.set_Minimum(double_0);
	}

	static void smethod_10(RangeBase rangeBase_0, double double_0)
	{
		rangeBase_0.set_Maximum(double_0);
	}

	static double smethod_11(RangeBase rangeBase_0)
	{
		return rangeBase_0.get_Maximum();
	}

	static double smethod_12(RangeBase rangeBase_0)
	{
		return rangeBase_0.get_Minimum();
	}

	static void smethod_13(Slider slider_2, double double_0)
	{
		slider_2.set_TickFrequency(double_0);
	}

	static double smethod_14(Slider slider_2)
	{
		return slider_2.get_TickFrequency();
	}

	static void smethod_15(RangeBase rangeBase_0, double double_0)
	{
		rangeBase_0.set_SmallChange(double_0);
	}

	static void smethod_16(RangeBase rangeBase_0, double double_0)
	{
		rangeBase_0.set_LargeChange(double_0);
	}

	static double smethod_17(AppSettings appSettings_1)
	{
		return appSettings_1.get_EngineBeatStartExtra();
	}

	static bool smethod_18(AppSettings appSettings_1)
	{
		return appSettings_1.get_EngineBeatExtraTone();
	}

	static void smethod_19(ToggleButton toggleButton_0, bool? nullable_0)
	{
		toggleButton_0.set_IsChecked(nullable_0);
	}

	static void smethod_20(ContentControl contentControl_0, object object_0)
	{
		contentControl_0.set_Content(object_0);
	}

	static void smethod_21(UIElement uielement_0, Visibility visibility_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		uielement_0.set_Visibility(visibility_0);
	}

	static double smethod_22(double double_0, int int_0)
	{
		return Math.Round(double_0, int_0);
	}

	static string smethod_23(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	static Uri smethod_24(string string_4, UriKind uriKind_0)
	{
		return new Uri(string_4, uriKind_0);
	}

	static void smethod_25(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}

	static void smethod_26(FrameworkElement frameworkElement_0, RoutedEventHandler routedEventHandler_0)
	{
		frameworkElement_0.add_Loaded(routedEventHandler_0);
	}

	static void smethod_27(Window window_0, EventHandler eventHandler_0)
	{
		window_0.add_Closed(eventHandler_0);
	}

	static void smethod_28(RangeBase rangeBase_0, RoutedPropertyChangedEventHandler<double> routedPropertyChangedEventHandler_0)
	{
		rangeBase_0.add_ValueChanged(routedPropertyChangedEventHandler_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, RoutedEventHandler routedEventHandler_0)
	{
		buttonBase_0.add_Click(routedEventHandler_0);
	}
}
