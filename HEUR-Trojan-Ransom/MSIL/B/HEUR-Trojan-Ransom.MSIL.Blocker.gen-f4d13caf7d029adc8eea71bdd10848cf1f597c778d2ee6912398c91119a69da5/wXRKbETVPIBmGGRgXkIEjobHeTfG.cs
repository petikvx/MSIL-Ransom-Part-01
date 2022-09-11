using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;
using Microsoft.Win32;
using NAudio.CoreAudioApi;
using SimShaker___Wheels.Properties;
using Wheels;

public class wXRKbETVPIBmGGRgXkIEjobHeTfG : Window, IComponentConnector
{
	[Flags]
	private enum Enum0
	{
		None = 0,
		Audio6ch = 1,
		Forcefeel = 2
	}

	public delegate void GDelegate2(string str, bool forced = false, int colorCode = 0);

	private bool bool_0;

	private bool bool_1;

	private TabItem tabItem_0;

	private string string_0;

	private string string_1 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_0(Environment.SpecialFolder.CommonApplicationData), "\\recently-used");

	private string string_2 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_0(Environment.SpecialFolder.CommonApplicationData), "\\SSW");

	private string string_3 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_0(Environment.SpecialFolder.CommonApplicationData), "\\SSW\\auth_blockchain.ssw");

	private string string_4 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(Utils.SettingsFolder, "\\auth_scrt.ssw");

	private static string string_5 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_0(Environment.SpecialFolder.ApplicationData), "\\WLS");

	private string string_6 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(string_5, "\\lcc.cfg");

	private Enum0 enum0_0;

	private int int_0 = 9;

	private Process process_0;

	private static string string_7 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(Utils.SettingsFolder, "\\Preset1.xml");

	private static string string_8 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(Utils.SettingsFolder, "\\CommonData.cfg");

	private string string_9 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(Utils.SettingsFolder, "\\PresetToLoad");

	private string string_10;

	private AppSettings appSettings_0 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_2(string_7);

	private AppSettings appSettings_1 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_2(string_8);

	private GClass1 gclass1_0;

	private DispatcherTimer dispatcherTimer_0;

	private string string_11 = "";

	private string string_12 = "JetSeat";

	private bool bool_2;

	private string string_13 = "| Unregistered software, working in DEMO mode";

	private GameChecker gameChecker_0 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_3(2000);

	private MMDevice mmdevice_0;

	private List<Slider> list_0 = new List<Slider>();

	private CoZBLtJvvLTyTbztqsnJRvAwHcTg coZBLtJvvLTyTbztqsnJRvAwHcTg_0;

	internal wXRKbETVPIBmGGRgXkIEjobHeTfG wXRKbETVPIBmGGRgXkIEjobHeTfG_0;

	internal TabControl tabControl_0;

	internal GroupBox groupBox_0;

	internal CheckBox checkBox_0;

	internal Slider slider_0;

	internal Slider slider_1;

	internal Label label_0;

	internal Label label_1;

	internal GroupBox groupBox_1;

	internal CheckBox checkBox_1;

	internal Slider slider_2;

	internal Slider slider_3;

	internal Label label_2;

	internal Label label_3;

	internal Slider slider_4;

	internal Label label_4;

	internal GroupBox groupBox_2;

	internal RadioButton radioButton_0;

	internal CheckBox checkBox_2;

	internal Button button_0;

	internal Button button_1;

	internal RadioButton radioButton_1;

	internal RadioButton radioButton_2;

	internal Button button_2;

	internal Button button_3;

	internal GroupBox groupBox_3;

	internal CheckBox checkBox_3;

	internal Slider slider_5;

	internal Slider slider_6;

	internal Label label_5;

	internal Label label_6;

	internal GroupBox groupBox_4;

	internal CheckBox checkBox_4;

	internal Slider slider_7;

	internal Slider slider_8;

	internal Label label_7;

	internal Label label_8;

	internal GroupBox groupBox_5;

	internal CheckBox checkBox_5;

	internal Slider slider_9;

	internal Slider slider_10;

	internal Label label_9;

	internal Label label_10;

	internal Slider slider_11;

	internal Label label_11;

	internal GroupBox groupBox_6;

	internal TextBox textBox_0;

	internal CheckBox checkBox_6;

	internal Image image_0;

	internal CheckBox checkBox_7;

	internal GroupBox groupBox_7;

	internal Label label_12;

	internal ComboBox comboBox_0;

	internal RadioButton radioButton_3;

	internal RadioButton radioButton_4;

	internal RadioButton radioButton_5;

	internal CheckBox checkBox_8;

	internal CheckBox checkBox_9;

	internal Label label_13;

	internal GroupBox groupBox_8;

	internal CheckBox checkBox_10;

	internal Slider slider_12;

	internal Slider slider_13;

	internal Label label_14;

	internal Label label_15;

	internal GroupBox groupBox_9;

	internal CheckBox checkBox_11;

	internal Slider slider_14;

	internal Slider slider_15;

	internal Label label_16;

	internal Label label_17;

	internal GroupBox groupBox_10;

	internal CheckBox checkBox_12;

	internal Slider slider_16;

	internal Slider slider_17;

	internal Label label_18;

	internal Label label_19;

	internal GroupBox groupBox_11;

	internal CheckBox checkBox_13;

	internal Slider slider_18;

	internal Slider slider_19;

	internal Label label_20;

	internal Label label_21;

	internal Slider slider_20;

	internal Label label_22;

	internal GroupBox groupBox_12;

	internal CheckBox checkBox_14;

	internal Slider slider_21;

	internal Slider slider_22;

	internal Label label_23;

	internal Label label_24;

	internal Slider slider_23;

	internal Label label_25;

	internal GroupBox groupBox_13;

	internal CheckBox checkBox_15;

	internal CheckBox checkBox_16;

	internal GroupBox groupBox_14;

	internal CheckBox checkBox_17;

	internal Slider slider_24;

	internal Label label_26;

	internal Slider slider_25;

	internal Label label_27;

	internal GroupBox groupBox_15;

	internal GroupBox groupBox_16;

	internal CheckBox checkBox_18;

	internal Slider slider_26;

	internal Label label_28;

	internal Slider slider_27;

	internal Label label_29;

	internal GroupBox groupBox_17;

	internal GroupBox groupBox_18;

	internal CheckBox checkBox_19;

	internal Slider slider_28;

	internal Label label_30;

	internal Slider slider_29;

	internal Label label_31;

	internal GroupBox groupBox_19;

	internal CheckBox checkBox_20;

	internal Slider slider_30;

	internal Label label_32;

	internal Slider slider_31;

	internal Label label_33;

	internal GroupBox groupBox_20;

	internal GroupBox groupBox_21;

	internal RadioButton radioButton_6;

	internal RadioButton radioButton_7;

	internal GroupBox groupBox_22;

	internal Button button_4;

	internal GroupBox groupBox_23;

	internal Button button_5;

	internal Button button_6;

	internal Button button_7;

	internal TextBlock textBlock_0;

	internal GroupBox groupBox_24;

	internal ComboBox comboBox_1;

	internal GroupBox groupBox_25;

	internal CheckBox checkBox_21;

	internal GroupBox groupBox_26;

	internal ComboBox comboBox_2;

	internal TextBlock textBlock_1;

	private bool bool_3;

	public string String_0
	{
		get
		{
			object[] array = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_141(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_140(), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_121(typeof(AssemblyTitleAttribute).TypeHandle), bool_4: false);
			if (array.Length != 0)
			{
				AssemblyTitleAttribute assemblyTitleAttribute_ = (AssemblyTitleAttribute)array[0];
				if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_123(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_142(assemblyTitleAttribute_), ""))
				{
					return wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_142(assemblyTitleAttribute_);
				}
			}
			return wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_144(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_143(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_140()));
		}
	}

	public string String_1 => wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_147(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_146(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_145(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_140()))) + "." + Assembly.GetExecutingAssembly().GetName().Version!.Minor;

	public string String_2
	{
		get
		{
			object[] array = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_141(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_140(), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_121(typeof(AssemblyDescriptionAttribute).TypeHandle), bool_4: false);
			if (array.Length != 0)
			{
				return wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_148((AssemblyDescriptionAttribute)array[0]);
			}
			return "";
		}
	}

	public string String_3
	{
		get
		{
			object[] array = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_141(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_140(), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_121(typeof(AssemblyProductAttribute).TypeHandle), bool_4: false);
			if (array.Length == 0)
			{
				return "";
			}
			return wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_149((AssemblyProductAttribute)array[0]);
		}
	}

	public string String_4
	{
		get
		{
			object[] array = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_141(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_140(), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_121(typeof(AssemblyCopyrightAttribute).TypeHandle), bool_4: false);
			if (array.Length == 0)
			{
				return "";
			}
			return wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_150((AssemblyCopyrightAttribute)array[0]);
		}
	}

	public string String_5
	{
		get
		{
			object[] array = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_141(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_140(), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_121(typeof(AssemblyCompanyAttribute).TypeHandle), bool_4: false);
			if (array.Length == 0)
			{
				return "";
			}
			return wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_151((AssemblyCompanyAttribute)array[0]);
		}
	}

	public wXRKbETVPIBmGGRgXkIEjobHeTfG()
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		InitializeComponent();
		this.method_105(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_4(String_0, " | Version ", String_1));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_5((TextBoxBase)(object)textBox_0, (ScrollBarVisibility)1);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_6((EventHandler)method_10);
		GClass1.Event_0 += method_12;
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_7(new TransferString(method_12));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_8(new TransferString(method_12));
		tabItem_0 = (TabItem)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_10((CollectionView)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_9((ItemsControl)(object)tabControl_0), 2);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_11();
		list_0.Add(slider_0);
		list_0.Add(slider_1);
		list_0.Add(slider_5);
		list_0.Add(slider_6);
		list_0.Add(slider_7);
		list_0.Add(slider_8);
		list_0.Add(slider_2);
		list_0.Add(slider_3);
		list_0.Add(slider_4);
		list_0.Add(slider_9);
		list_0.Add(slider_10);
		list_0.Add(slider_11);
		list_0.Add(slider_12);
		list_0.Add(slider_13);
		list_0.Add(slider_14);
		list_0.Add(slider_15);
		list_0.Add(slider_16);
		list_0.Add(slider_17);
		list_0.Add(slider_18);
		list_0.Add(slider_19);
		list_0.Add(slider_24);
		list_0.Add(slider_25);
		list_0.Add(slider_26);
		list_0.Add(slider_27);
		list_0.Add(slider_28);
		list_0.Add(slider_29);
	}

	private void method_0(object sender, EventArgs e)
	{
		if (!gclass1_0.Boolean_0)
		{
			Settings.Default.Setting = Settings.Default.Setting + 1;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_12((SettingsBase)(object)Settings.Default);
			if (Settings.Default.Setting > 5 || Settings.Default.Setting1 > 10)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_13(dispatcherTimer_0, (object)"activate");
			}
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_15("Demo time is over. Please {0} the software to continue.", wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_14(dispatcherTimer_0)), bool_4: true, 1);
		}
		gclass1_0.Boolean_0 = true;
	}

	private void method_1()
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_6, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_16(appSettings_1));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_0, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_18(appSettings_1));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_1, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_19(appSettings_1));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_2, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_20(appSettings_1));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_2, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_21(appSettings_1));
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_21(appSettings_1))
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)groupBox_7, bool_4: false);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_8, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_22(appSettings_1));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_9, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_23(appSettings_1));
			if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_24(appSettings_1) == 1)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_3, (bool?)true);
			}
			else if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_24(appSettings_1) != 2)
			{
				if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_24(appSettings_1) == 6)
				{
					wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_5, (bool?)true);
				}
			}
			else
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_4, (bool?)true);
			}
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_26(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_1, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_28(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_5, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_29(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_6, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_30(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_7, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_31(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_8, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_32(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_2, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_33(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_3, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_34(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_4, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_35(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_9, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_36(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_10, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_37(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_11, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_38(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_18, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_39(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_19, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_40(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_20, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_41(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_15, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_42(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_16, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_43(appSettings_1));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_24, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_44(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_25, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_45(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_26, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_46(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_27, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_47(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_28, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_48(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_29, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_49(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_30, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_50(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_31, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_51(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_12, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_52(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_13, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_53(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_14, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_54(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_15, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_55(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_16, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_56(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_17, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_57(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_21, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_58(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_22, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_59(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_27((RangeBase)(object)slider_23, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_60(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_0, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_61(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_3, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_62(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_4, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_63(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_1, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_64(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_5, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_65(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_10, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_66(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_11, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_67(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_12, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_68(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_13, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_69(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_14, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_70(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_17, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_71(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_18, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_72(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_19, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_73(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_20, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_74(appSettings_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)checkBox_21, (bool?)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_75(appSettings_0));
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_21) == true)
		{
			method_86();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_78((Selector)(object)comboBox_2, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_77(appSettings_0));
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_79(appSettings_0) == 1)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_6, (bool?)true);
		}
		else if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_79(appSettings_0) == 2)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_7, (bool?)true);
		}
	}

	private void method_2(object sender, RoutedEventArgs e)
	{
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		dispatcherTimer_0 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_80();
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_81(dispatcherTimer_0, (EventHandler)method_0);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_13(dispatcherTimer_0, (object)"restart or activate");
		Settings.Default.Setting1++;
		string text = "";
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_82(string_9))
		{
			try
			{
				string_10 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_84(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_83(string_9));
				if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_82(string_10))
				{
					wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_85(appSettings_0, string_10);
					text = "";
				}
				else
				{
					wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_85(appSettings_0, string_7);
					text = "default preset";
				}
			}
			catch (Exception exception_)
			{
				method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_), bool_4: true, 1);
			}
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_85(appSettings_0, string_7);
		}
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_87(appSettings_0))
		{
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_89(new string[5]
			{
				"Got settings from ",
				text,
				" ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_88(appSettings_0),
				".xml"
			}));
			try
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_91(string_9, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_90(appSettings_0));
			}
			catch (Exception exception_2)
			{
				method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_2), bool_4: true, 1);
			}
		}
		else if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_92(Utils.SettingsFolder))
		{
			try
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_93(Utils.SettingsFolder);
				method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1("Added a directory for settings ", Utils.SettingsFolder));
			}
			catch (Exception exception_3)
			{
				method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_3), bool_4: true, 1);
			}
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_85(appSettings_1, string_8);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_87(appSettings_1))
		{
			text = "";
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_89(new string[5]
			{
				"Got common settings from ",
				text,
				" ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_88(appSettings_1),
				".cfg"
			}));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_95((Window)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_94(appSettings_1));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_97((Window)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_96(appSettings_1));
			if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_20(appSettings_1))
			{
				string_12 = "ForceFeel";
			}
		}
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_18(appSettings_1) || wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_19(appSettings_1))
		{
			method_7(Utils.SamplesSubfolders_JS);
			method_8();
		}
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_21(appSettings_1))
		{
			method_7(Utils.SamplesSubfolders_AD);
			method_9();
		}
		gclass1_0 = new GClass1(appSettings_0, appSettings_1);
		string string_ = "SimShaker Initialization";
		try
		{
			string_0 = "1f1";
			if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_92(this.string_2))
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_93(this.string_2);
			}
			if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_82(string_3))
			{
				method_4(string_3);
			}
			else
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_99((Stream)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_98(string_3));
			}
			string_0 = "1f2";
			if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_82(string_4))
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_99((Stream)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_98(string_4));
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_100(string_4, FileAttributes.Hidden);
			}
			else
			{
				method_4(string_4);
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_100(string_4, FileAttributes.Hidden);
			}
			string_0 = "1g";
			string string_2 = Guid.NewGuid().ToString();
			if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_82(string_1))
			{
				string_0 = "2";
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_99((Stream)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_98(string_1));
				string_0 = "3";
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_101(3000);
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_91(string_1, string_2);
				string_0 = "4";
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_100(string_1, FileAttributes.Hidden);
			}
			else if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_103(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_102(string_1)) != 0L)
			{
				string_0 = "1a";
				method_5();
			}
			else
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_100(string_1, FileAttributes.Normal);
				string_0 = "5";
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_91(string_1, string_2);
				string_0 = "6";
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_100(string_1, FileAttributes.Hidden);
			}
			if (!bool_0)
			{
				method_3();
			}
		}
		catch (Exception exception_4)
		{
			if (!bool_0)
			{
				method_3();
			}
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_104(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_4("SimShaker initialization problem. Error code: ", string_0, ". Please copy log content and e-mail it to simshaker@outlook.com"), string_, (MessageBoxButton)0, (MessageBoxImage)16);
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_105(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_4)), bool_4: true, 1);
		}
		method_1();
		method_62();
		method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_106(String_0, " | version ", String_1, " Started"));
		if (appSettings_1.DebugMode)
		{
			process_0 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_107();
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_109(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), "");
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_110(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), "JetSeatHandler.exe");
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_111(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), bool_4: false);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_112(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), (SecureString)null);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_113(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), (Encoding)null);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_114(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), (Encoding)null);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_115(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), "");
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_116(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), ProcessWindowStyle.Minimized);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_117(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_108(process_0), "");
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_118(process_0);
		}
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_119(appSettings_1.PostponedMessageAUD) > 0)
		{
			method_13(appSettings_1.PostponedMessageAUD, bool_4: true, 1);
		}
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_119(appSettings_1.PostponedMessageJS) > 0)
		{
			method_13(appSettings_1.PostponedMessageJS, bool_4: true, 1);
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_120(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_9((ItemsControl)(object)comboBox_1), (object)"Auto");
		string[] array = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_122(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_121(typeof(Games).TypeHandle));
		foreach (string text2 in array)
		{
			if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_123(text2, "None"))
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_120(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_9((ItemsControl)(object)comboBox_1), (object)text2);
			}
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_125((Selector)(object)comboBox_1, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_124(appSettings_1));
		bool_1 = true;
	}

	private void method_3()
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_128((HeaderedContentControl)(object)tabItem_0, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_127(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_126((HeaderedContentControl)(object)tabItem_0), (object)" & Registration"));
		if (Settings.Default.Setting >= 6)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_129(dispatcherTimer_0, TimeSpan.FromSeconds(1.0));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)radioButton_5, bool_4: false);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_5, (bool?)false);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)radioButton_2, bool_4: false);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_17((ToggleButton)(object)radioButton_2, (bool?)false);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_130(appSettings_1, bool_4: false);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_129(dispatcherTimer_0, TimeSpan.FromMinutes(20.0));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)radioButton_5, bool_4: true);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)radioButton_2, bool_4: true);
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_131(dispatcherTimer_0);
	}

	private void method_4(string string_14)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_132(string_14, DateTime.Now);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_133(string_14, DateTime.Now);
	}

	private void method_5()
	{
		method_13("0+");
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_82(string_3) || !wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_82(string_4))
		{
			return;
		}
		method_13("1+");
		if ((wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_134(string_1) & FileAttributes.Hidden) != FileAttributes.Hidden)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_100(string_1, FileAttributes.Hidden);
		}
		method_13("2+");
		DateTime dateTime = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_135(string_1);
		DateTime dateTime2 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_136(string_1);
		int num = Math.Abs(dateTime.GetHashCode());
		int num2 = Math.Abs(dateTime2.GetHashCode());
		if (num - num2 != appSettings_1.get_Offset() && (appSettings_1.get_Num() <= int_0 || !File.Exists(string_6)))
		{
			return;
		}
		method_13("3+");
		using SHA384 sHA = new SHA384Managed();
		byte[] second = Convert.FromBase64String(appSettings_1.get_Network());
		byte[] first = sHA.ComputeHash(File.ReadAllBytes(string_1));
		if (!first.SequenceEqual(second) && (appSettings_1.get_Num() <= int_0 || !File.Exists(string_6)))
		{
			return;
		}
		if (first.SequenceEqual(second))
		{
			method_13("4-");
		}
		if (appSettings_1.get_Num() > int_0 && File.Exists(string_6))
		{
			method_13("4--");
		}
		method_13("4+");
		if (new FileInfo("Auth0.Windows.dll").Length != 25600L)
		{
			return;
		}
		method_13("5+");
		if (!appSettings_1.get_Deactivated())
		{
			((ContentControl)button_4).set_Content((object)"Software is Activated");
			((UIElement)button_4).set_IsEnabled(false);
			bool_0 = true;
			string_13 = "";
			AppSettings obj = appSettings_1;
			obj.set_Num(obj.get_Num() + 1);
			try
			{
				byte[] second2 = Convert.FromBase64String(appSettings_1.get_Preset());
				first = sHA.ComputeHash(File.ReadAllBytes(string_1), 4, 8);
				if (!first.SequenceEqual(second2) && (appSettings_1.get_Num() <= int_0 + 1 || !method_6(Enum0.Audio6ch)))
				{
					if (appSettings_1.get_SelectedMaxAudioChannels() > 2)
					{
						appSettings_1.set_SelectedMaxAudioChannels(2);
						((UIElement)radioButton_5).set_IsEnabled(false);
					}
				}
				else
				{
					if (first.SequenceEqual(second2) && method_6(Enum0.Audio6ch))
					{
						method_13("6-");
					}
					if (appSettings_1.get_Num() > int_0 + 1 && method_6(Enum0.Audio6ch))
					{
						method_13("6--");
					}
					if (first.SequenceEqual(second2))
					{
						method_13("6---");
					}
					enum0_0 |= Enum0.Audio6ch;
					((UIElement)radioButton_5).set_IsEnabled(true);
					method_13("6+");
				}
			}
			catch (Exception ex)
			{
				method_13(Utils.EncryptString(ex.Message));
				if (appSettings_1.get_SelectedMaxAudioChannels() > 2)
				{
					appSettings_1.set_SelectedMaxAudioChannels(2);
				}
			}
			try
			{
				byte[] second3 = Convert.FromBase64String(appSettings_1.get_Grids());
				first = sHA.ComputeHash(File.ReadAllBytes(string_1), 10, 8);
				if (!first.SequenceEqual(second3) && (appSettings_1.get_Num() <= int_0 + 1 || !method_6(Enum0.Forcefeel)))
				{
					appSettings_1.set_EnableForcefeel(false);
					((UIElement)radioButton_2).set_IsEnabled(false);
				}
				else
				{
					if (first.SequenceEqual(second3) && method_6(Enum0.Forcefeel))
					{
						method_13("7-");
					}
					if (appSettings_1.get_Num() > int_0 + 1 && method_6(Enum0.Forcefeel))
					{
						method_13("7--");
					}
					if (first.SequenceEqual(second3))
					{
						method_13("7---");
					}
					enum0_0 |= Enum0.Forcefeel;
					((UIElement)radioButton_2).set_IsEnabled(true);
					method_13("7+");
				}
			}
			catch (Exception ex2)
			{
				method_13(Utils.EncryptString(ex2.Message));
				appSettings_1.set_EnableForcefeel(false);
				((UIElement)radioButton_2).set_IsEnabled(false);
			}
			method_13("8");
			if (appSettings_1.get_Num() != int_0 + 1)
			{
				return;
			}
			try
			{
				Directory.CreateDirectory(string_5);
			}
			catch (Exception ex3)
			{
				method_13(Utils.EncryptString(ex3.Message));
			}
			try
			{
				if (!Directory.Exists(string_5))
				{
					Directory.CreateDirectory(string_5);
				}
				File.WriteAllText(string_6, Convert.ToString((int)enum0_0));
				return;
			}
			catch (Exception ex4)
			{
				method_13(Utils.EncryptString(ex4.Message));
				return;
			}
		}
		((ContentControl)button_4).set_Content((object)"Activate Software");
		appSettings_1.set_ShowDeactivate(false);
		bool_0 = false;
		method_3();
	}

	private bool method_6(Enum0 enum0_1)
	{
		try
		{
			if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_82(string_6) && wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_119(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_83(string_6)) == 1 && ((uint)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_137(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_83(string_6)) & (uint)enum0_1) != 0)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return false;
		}
		return false;
	}

	private void method_7(string[] string_14)
	{
		foreach (string string_15 in string_14)
		{
			string text = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1(Utils.SamplesFolder, string_15);
			if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_92(text))
			{
				try
				{
					wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_93(text);
					method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1("Added a directory for FXs samples ", text));
				}
				catch (Exception exception_)
				{
					method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_), bool_4: true, 1);
				}
			}
		}
	}

	private void method_8()
	{
		foreach (string uwvFiles in Utils.UwvFilesList)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_138(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_4("uwv_files\\", uwvFiles, ".uwv"), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_106(Utils.SamplesFolder, Utils.SamplesSubfolders_JS[2], uwvFiles, ".uwv"));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_138(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_4("uwv_files\\race\\", uwvFiles, ".uwv"), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_106(Utils.SamplesFolder, Utils.SamplesSubfolders_JS[4], uwvFiles, ".uwv"));
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_138("uwv_files\\Description.txt", wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_4(Utils.SamplesFolder, Utils.SamplesSubfolders_JS[2], "Description.txt"));
	}

	private void method_9()
	{
		foreach (string wavFiles in Utils.WavFilesList)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_138(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[5]
			{
				"wav_files\\",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_24(appSettings_1),
				"\\",
				wavFiles,
				".wav"
			}), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[6]
			{
				Utils.SamplesFolder,
				Utils.SamplesSubfolders_AD[2],
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_24(appSettings_1),
				"\\",
				wavFiles,
				".wav"
			}));
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_138("uwv_files\\Description.txt", wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_4(Utils.SamplesFolder, Utils.SamplesSubfolders_AD[2], "Description.txt"));
	}

	private void method_10(object sender, EventArgs e)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Invalid comparison between Unknown and I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Invalid comparison between Unknown and I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Invalid comparison between Unknown and I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Invalid comparison between Unknown and I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Invalid comparison between Unknown and I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Invalid comparison between Unknown and I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Invalid comparison between Unknown and I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Invalid comparison between Unknown and I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Invalid comparison between Unknown and I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Invalid comparison between Unknown and I4
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Invalid comparison between Unknown and I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Invalid comparison between Unknown and I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Invalid comparison between Unknown and I4
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Invalid comparison between Unknown and I4
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Invalid comparison between Unknown and I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Invalid comparison between Unknown and I4
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_153(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_152((DispatcherObject)(object)this)))
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_154(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_152((DispatcherObject)(object)this), (Delegate)new EventHandler(method_10), new object[2] { sender, e });
			return;
		}
		if (gclass1_0 == null || (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_18(appSettings_1) && !wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_19(appSettings_1) && !wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_20(appSettings_1)))
		{
			string_11 = "";
		}
		else
		{
			string_11 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4] { " | ", string_12, " state: ", gclass1_0.JSdeviceState_0 });
		}
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_123(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_124(appSettings_1), "Auto"))
		{
			try
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_158(gameChecker_0, (Games)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_157(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_121(typeof(Games).TypeHandle), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_156(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_155((Selector)(object)comboBox_1))));
			}
			catch (NullReferenceException)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_159(appSettings_1, "Auto");
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_125((Selector)(object)comboBox_1, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_124(appSettings_1));
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_158(gameChecker_0, (Games)0);
			}
			catch (Exception exception_)
			{
				method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1("Game Mode Selector:", wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_)), bool_4: true, 1);
			}
		}
		this.method_105(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[10]
		{
			String_0,
			" | Version ",
			String_1,
			string_13,
			" | Game mode: ",
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_160(gameChecker_0),
			" | Preset in use: ",
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_88(appSettings_0),
			".xml",
			string_11
		}));
		if ((int)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_160(gameChecker_0) != 0 && DateTime.Now.Year <= 2019)
		{
			if (bool_2)
			{
				return;
			}
			method_11();
			gclass1_0.method_3(gameChecker_0.get_GameRunning());
			bool_2 = true;
			if ((int)gameChecker_0.get_GameRunning() != 9 && (int)gameChecker_0.get_GameRunning() != 8)
			{
				if ((int)gameChecker_0.get_GameRunning() != 13 && (int)gameChecker_0.get_GameRunning() != 15 && (int)gameChecker_0.get_GameRunning() != 14)
				{
					if ((int)gameChecker_0.get_GameRunning() != 7)
					{
						if ((int)gameChecker_0.get_GameRunning() != 2)
						{
							if ((int)gameChecker_0.get_GameRunning() == 10 || (int)gameChecker_0.get_GameRunning() == 11 || (int)gameChecker_0.get_GameRunning() == 1 || (int)gameChecker_0.get_GameRunning() == 12)
							{
								((UIElement)groupBox_1).set_IsEnabled(false);
								((HeaderedContentControl)groupBox_1).set_Header((object)"     Not Available");
								((UIElement)groupBox_12).set_IsEnabled(true);
							}
							else if ((int)gameChecker_0.get_GameRunning() != 4 && (int)gameChecker_0.get_GameRunning() != 3)
							{
								if ((int)gameChecker_0.get_GameRunning() == 18)
								{
									((UIElement)groupBox_12).set_IsEnabled(false);
									((HeaderedContentControl)groupBox_12).set_Header((object)"     Not Available");
									((ToggleButton)checkBox_14).set_IsChecked((bool?)false);
								}
								else if ((int)gameChecker_0.get_GameRunning() == 5 || (int)gameChecker_0.get_GameRunning() == 6)
								{
									((UIElement)groupBox_12).set_IsEnabled(false);
									((HeaderedContentControl)groupBox_12).set_Header((object)"     Not Available");
									((ToggleButton)checkBox_14).set_IsChecked((bool?)false);
								}
							}
							else
							{
								((HeaderedContentControl)groupBox_1).set_Header((object)"     Wheel Slip");
								((UIElement)groupBox_12).set_IsEnabled(true);
							}
						}
						else
						{
							((UIElement)groupBox_1).set_IsEnabled(false);
							((HeaderedContentControl)groupBox_1).set_Header((object)"     Not Available");
							((UIElement)groupBox_12).set_IsEnabled(true);
						}
					}
					else
					{
						((UIElement)groupBox_4).set_IsEnabled(false);
						((HeaderedContentControl)groupBox_4).set_Header((object)"     Not Available");
						((UIElement)groupBox_1).set_IsEnabled(true);
						((HeaderedContentControl)groupBox_1).set_Header((object)"     Lateral Slip");
						((UIElement)groupBox_12).set_IsEnabled(false);
						((HeaderedContentControl)groupBox_12).set_Header((object)"     Not Available");
						((ToggleButton)checkBox_14).set_IsChecked((bool?)false);
					}
				}
				else
				{
					((UIElement)groupBox_4).set_IsEnabled(false);
					((HeaderedContentControl)groupBox_4).set_Header((object)"     Not Available");
					((UIElement)groupBox_12).set_IsEnabled(false);
					((HeaderedContentControl)groupBox_12).set_Header((object)"     Not Available");
					((ToggleButton)checkBox_14).set_IsChecked((bool?)false);
				}
			}
			else
			{
				((UIElement)groupBox_1).set_IsEnabled(false);
				((HeaderedContentControl)groupBox_1).set_Header((object)"     Not Available");
				((UIElement)groupBox_12).set_IsEnabled(false);
				((HeaderedContentControl)groupBox_12).set_Header((object)"     Not Available");
				((ToggleButton)checkBox_14).set_IsChecked((bool?)false);
			}
		}
		else
		{
			if (bool_2)
			{
				gclass1_0.method_4();
				bool_2 = false;
			}
			method_11();
		}
	}

	private void method_11()
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)groupBox_4, bool_4: true);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_128((HeaderedContentControl)(object)groupBox_4, (object)"     Damage");
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)groupBox_1, bool_4: true);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_128((HeaderedContentControl)(object)groupBox_1, (object)"     Wheel Slip");
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)groupBox_12, bool_4: false);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_128((HeaderedContentControl)(object)groupBox_12, (object)"     4 Tire Wear");
	}

	private void method_12(string string_14, bool bool_4 = false, int int_1 = 0)
	{
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_153(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_152((DispatcherObject)(object)this)))
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_154(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_152((DispatcherObject)(object)this), (Delegate)new GDelegate2(method_12), new object[3] { string_14, bool_4, int_1 });
		}
		else
		{
			method_13(string_14, bool_4, int_1);
		}
	}

	private void method_13(string string_14, bool bool_4 = false, int int_1 = 0)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_16(appSettings_1) || bool_4)
		{
			((TextBoxBase)textBox_0).AppendText(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + DateTime.Now.Millisecond + " " + string_14 + Environment.NewLine);
			((TextBoxBase)textBox_0).PageDown();
			switch (int_1)
			{
			default:
				((Control)textBox_0).set_Foreground((Brush)(object)Brushes.get_Black());
				break;
			case 1:
				((Control)textBox_0).set_Foreground((Brush)(object)Brushes.get_Red());
				break;
			case 2:
				((Control)textBox_0).set_Foreground((Brush)(object)Brushes.get_Black());
				break;
			case 0:
				break;
			}
		}
	}

	private void method_14(object sender, CancelEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_162(appSettings_1, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_161((Window)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_164(appSettings_1, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_163((Window)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG_0));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_1);
		gclass1_0.method_4();
		gclass1_0.method_5();
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_166();
		try
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_167(process_0);
		}
		catch (Exception)
		{
		}
	}

	private void method_15(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_169(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_0));
		if (label_0 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_0, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_0)),
				"%"
			}));
		}
	}

	private void method_16(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_172(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_1));
		if (label_1 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_1, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_1)), (object)"%"));
		}
	}

	private void method_17(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_174(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_5));
		if (label_5 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_5, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_5)),
				"%"
			}));
		}
	}

	private void method_18(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_175(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_6));
		if (label_6 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_6, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_6)), (object)"%"));
		}
	}

	private void method_19(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_176(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_7));
		if (label_7 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_7, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_7)),
				"%"
			}));
		}
	}

	private void method_20(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_177(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_8));
		if (label_8 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_8, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_8)), (object)"%"));
		}
	}

	private void method_21(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_178(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_2));
		if (label_2 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_2, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_2)),
				"%"
			}));
		}
	}

	private void method_22(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_179(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_3));
		if (label_3 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_3, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_3)), (object)"%"));
		}
	}

	private void method_23(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_180(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_4));
		if (label_4 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_4, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_127((object)"Filtering Threshold ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_4))));
		}
	}

	private void method_24(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_181(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_9));
		if (label_9 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_9, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_9)),
				"%"
			}));
		}
	}

	private void method_25(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_182(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_10));
		if (label_10 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_10, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_10)), (object)"%"));
		}
	}

	private void method_26(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_183(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_11));
		if (label_11 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_11, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_127((object)"Filtering Threshold ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_11))));
		}
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_41(appSettings_0) < wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_38(appSettings_0))
		{
			if (label_22 != null)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)label_22, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_186());
			}
			if (label_11 != null)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)label_11, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_186());
			}
			return;
		}
		if (label_22 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)label_22, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_184());
		}
		if (label_11 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)label_11, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_184());
		}
		method_13("Please, set Road Bumps Filtering Threshold value higher than Road Surface Filtering Threshold", bool_4: true);
	}

	private void method_27(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_187(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_18));
		if (label_20 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_20, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_18)),
				"%"
			}));
		}
	}

	private void method_28(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_188(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_19));
		if (label_21 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_21, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_19)), (object)"%"));
		}
	}

	private void method_29(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_189(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_20));
		if (label_22 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_22, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_127((object)"Filtering Threshold ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_20))));
		}
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_41(appSettings_0) >= wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_38(appSettings_0))
		{
			if (label_22 != null)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)label_22, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_184());
			}
			if (label_11 != null)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)label_11, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_184());
			}
			method_13("Please, set Road Bumps Filtering Threshold value higher than Road Surface Filtering Threshold", bool_4: true);
		}
		else
		{
			if (label_22 != null)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)label_22, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_186());
			}
			if (label_11 != null)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)label_11, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_186());
			}
		}
	}

	private void method_30(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_190((Window)(object)this, bool_4: true);
	}

	private void method_31(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_190((Window)(object)this, bool_4: false);
	}

	private void method_32(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_191(appSettings_0, bool_4: true);
	}

	private void method_33(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_191(appSettings_0, bool_4: false);
	}

	private void method_34(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_192(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_24));
		if (label_26 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_26, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_24)),
				"%"
			}));
		}
	}

	private void method_35(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_193(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_25));
		if (label_27 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_27, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_25)), (object)"%"));
		}
	}

	private void method_36(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_194(appSettings_1, bool_4: true);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_195((Window)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG_0))
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_196(textBox_0, "");
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_185((Control)(object)textBox_0, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_186());
		}
	}

	private void method_37(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_194(appSettings_1, bool_4: false);
	}

	private void method_38(object sender, RequestNavigateEventArgs e)
	{
		try
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_200(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_199(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_198(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_197(e))));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_201((RoutedEventArgs)(object)e, bool_4: true);
		}
		catch (Exception exception_)
		{
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_), bool_4: true, 1);
		}
	}

	private void method_39(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_202(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_26));
		if (label_28 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_28, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_26)),
				"%"
			}));
		}
	}

	private void method_40(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_203(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_27));
		if (label_29 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_29, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_27)), (object)"%"));
		}
	}

	private void method_41(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_204(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_28));
		if (label_30 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_30, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_28)),
				"%"
			}));
		}
	}

	private void method_42(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_205(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_29));
		if (label_31 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_31, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_29)), (object)"%"));
		}
	}

	private void method_43(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_206(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_30));
		if (label_32 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_32, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_30)),
				"%"
			}));
		}
	}

	private void method_44(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_207(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_31));
		if (label_33 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_33, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_31)), (object)"%"));
		}
	}

	private void method_45(object sender, RoutedEventArgs e)
	{
		SaveFileDialog val = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_208();
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_209((FileDialog)(object)val, ".xml");
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_210((FileDialog)(object)val, "SimShaker presets files (.xml)|*.xml");
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_211((FileDialog)(object)val, Utils.SettingsFolder);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_212((CommonDialog)(object)val) == true)
		{
			string string_ = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_213((FileDialog)(object)val);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_85(appSettings_0, string_);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1("Saved settings to ", wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_88(appSettings_0)));
		}
	}

	private void method_46(object sender, RoutedEventArgs e)
	{
		OpenFileDialog val = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_214();
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_209((FileDialog)(object)val, ".xml");
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_210((FileDialog)(object)val, "SimShaker presets files (.xml)|*.xml");
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_211((FileDialog)(object)val, Utils.SettingsFolder);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_215(val, bool_4: false);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_212((CommonDialog)(object)val) != true)
		{
			return;
		}
		string string_ = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_213((FileDialog)(object)val);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_85(appSettings_0, string_);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_87(appSettings_0))
		{
			method_1();
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_1("Got settings from ", wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_88(appSettings_0)));
			try
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_91(string_9, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_90(appSettings_0));
			}
			catch (Exception exception_)
			{
				method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_), bool_4: true, 1);
			}
		}
	}

	private void method_47(object sender, RoutedEventArgs e)
	{
		iBGLlvTQjarSLooUJzObzXPsQqy window_ = new iBGLlvTQjarSLooUJzObzXPsQqy(appSettings_1);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_216((Window)(object)window_, (Window)(object)this);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_217((Window)(object)window_);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_218((Window)(object)window_, (EventHandler)method_48);
	}

	private void method_48(object sender, EventArgs e)
	{
		method_5();
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_49(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)radioButton_0) == true)
		{
			gclass1_0.method_29(0);
		}
	}

	private void method_50(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_2) == true)
		{
			gclass1_0.method_29(1);
		}
	}

	private void method_51(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)radioButton_1) == true)
		{
			gclass1_0.method_29(0);
		}
	}

	private void method_52(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)radioButton_2) == true)
		{
			gclass1_0.method_29(0);
		}
	}

	private void method_53(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_219(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_12));
		if (label_14 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_14, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_12)),
				"%"
			}));
		}
	}

	private void method_54(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_220(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_13));
		if (label_15 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_15, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_13)), (object)"%"));
		}
	}

	private void method_55(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
	}

	private void method_56(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_221(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_14));
		if (label_16 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_16, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_14)),
				"%"
			}));
		}
	}

	private void method_57(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_222(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_15));
		if (label_17 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_17, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_15)), (object)"%"));
		}
	}

	private void method_58(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_223(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_16));
		if (label_18 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_18, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_16)),
				"%"
			}));
		}
	}

	private void method_59(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_224(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_17));
		if (label_19 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_19, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_17)), (object)"%"));
		}
	}

	private void method_60(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_225(appSettings_1, bool_4: true);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)groupBox_7, bool_4: true);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)button_1, bool_4: true);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_226((Window)(object)this))
		{
			method_7(Utils.SamplesSubfolders_AD);
			method_9();
			method_62();
			if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_119(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_227(appSettings_1)) > 0)
			{
				method_68();
			}
		}
	}

	private void method_61(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_225(appSettings_1, bool_4: false);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_125((Selector)(object)comboBox_0, (object)null);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)groupBox_7, bool_4: false);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)button_1, bool_4: false);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_226((Window)(object)this))
		{
			method_68();
		}
	}

	private void method_62()
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_228(appSettings_1))
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_229(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_9((ItemsControl)(object)comboBox_0));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_120(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_9((ItemsControl)(object)comboBox_0), (object)"Select at your ASIO software which card to use");
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_78((Selector)(object)comboBox_0, 0);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)comboBox_0, bool_4: false);
			return;
		}
		MMDeviceEnumerator mmdeviceEnumerator_ = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_230();
		MMDeviceCollection mmdeviceCollection_ = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_231(mmdeviceEnumerator_, (DataFlow)0, (DeviceState)1);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)comboBox_0, bool_4: true);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_229(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_9((ItemsControl)(object)comboBox_0));
		IEnumerator<MMDevice> enumerator = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_232(mmdeviceCollection_);
		try
		{
			while (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_233((IEnumerator)enumerator))
			{
				MMDevice current = enumerator.Current;
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_120(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_9((ItemsControl)(object)comboBox_0), (object)current);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_234((IDisposable)enumerator);
			}
		}
		try
		{
			mmdevice_0 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_235(mmdeviceEnumerator_, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_227(appSettings_1));
			IEnumerator enumerator2 = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_236((IEnumerable)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_9((ItemsControl)(object)comboBox_0));
			try
			{
				while (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_233(enumerator2))
				{
					MMDevice val = (MMDevice)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_237(enumerator2);
					if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_239(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_238(mmdevice_0), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_238(val)))
					{
						wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_125((Selector)(object)comboBox_0, (object)val);
						break;
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable idisposable_)
				{
					wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_234(idisposable_);
				}
			}
		}
		catch (ArgumentException)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_240(appSettings_1, "");
		}
		catch (COMException)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_240(appSettings_1, "");
		}
		catch (Exception exception_)
		{
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_), bool_4: true, 1);
		}
	}

	private void method_63(object sender, SelectionChangedEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_21(appSettings_1) && !wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_228(appSettings_1))
		{
			mmdevice_0 = (MMDevice)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_155((Selector)(object)comboBox_0);
			if (mmdevice_0 != null && wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_226((Window)(object)this) && wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_123(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_238(mmdevice_0), wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_227(appSettings_1)))
			{
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_240(appSettings_1, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_238(mmdevice_0));
				method_68();
			}
		}
	}

	private void method_64(object sender, MouseButtonEventArgs e)
	{
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_241((UIElement)(object)button_4))
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_25((UIElement)(object)button_4, bool_4: true);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_242(appSettings_1, bool_4: true);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)button_4, (object)"Re-activate Software");
		}
	}

	private void method_65(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_243(appSettings_1, bool_4: true);
		method_12("ASIO enabled");
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_244(appSettings_1, 6);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_226((Window)(object)this))
		{
			method_9();
			method_62();
			method_68();
		}
	}

	private void method_66(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_244(appSettings_1, 2);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_226((Window)(object)this))
		{
			method_9();
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_243(appSettings_1, bool_4: false);
			method_12("ASIO disabled");
			method_62();
			method_68();
		}
	}

	private void method_67(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_244(appSettings_1, 1);
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_226((Window)(object)this))
		{
			method_9();
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_243(appSettings_1, bool_4: false);
			method_12("ASIO disabled");
			method_62();
			method_68();
		}
	}

	private void method_68()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_245("Application will restart to apply new settings", String_0);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_248(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_247(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_246()));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_250(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_249());
	}

	private void method_69(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_251(appSettings_1, bool_4: true);
		method_12(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_254("Compressor enabled. Threshold={0}  Factor={1}", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_252(appSettings_1), (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_253(appSettings_1)), bool_4: true);
	}

	private void method_70(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_251(appSettings_1, bool_4: false);
		method_12("Compressor disabled");
	}

	private void method_71(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_248(Utils.SettingsFolder);
	}

	private void method_72(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_0).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_255(appSettings_0, bool_4: true);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_255(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_73(object sender, RoutedEventArgs e)
	{
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_3).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_256(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_256(appSettings_0, bool_4: true);
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_74(object sender, RoutedEventArgs e)
	{
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_4).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_257(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_257(appSettings_0, bool_4: true);
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_75(object sender, RoutedEventArgs e)
	{
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_1).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_258(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_258(appSettings_0, bool_4: true);
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_76(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_5).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_259(appSettings_0, bool_4: true);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_259(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_77(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_10).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_260(appSettings_0, bool_4: true);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_260(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_78(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_11).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_261(appSettings_0, bool_4: true);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_261(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_79(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_12).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_262(appSettings_0, bool_4: true);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_262(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_80(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_13).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_263(appSettings_0, bool_4: true);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_263(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_81(object sender, RoutedEventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_17).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_264(appSettings_0, bool_4: false);
			gclass1_0.method_17();
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_264(appSettings_0, bool_4: true);
			if ((int)appSettings_0.CurrentGame == 3 || (int)appSettings_0.CurrentGame == 4)
			{
				gclass1_0.method_16();
			}
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_82(object sender, RoutedEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_18).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_265(appSettings_0, bool_4: true);
			if ((int)appSettings_0.CurrentGame == 10 || (int)appSettings_0.CurrentGame == 11 || (int)appSettings_0.CurrentGame == 1 || (int)appSettings_0.CurrentGame == 12)
			{
				gclass1_0.method_16();
			}
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_265(appSettings_0, bool_4: false);
			gclass1_0.method_17();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_83(object sender, RoutedEventArgs e)
	{
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_19).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_266(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_266(appSettings_0, bool_4: true);
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_84(object sender, RoutedEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_20).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_267(appSettings_0, bool_4: true);
			if ((int)appSettings_0.CurrentGame == 7)
			{
				gclass1_0.method_16();
			}
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_267(appSettings_0, bool_4: false);
			gclass1_0.method_17();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_85(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_21) == true)
		{
			method_86();
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_268(appSettings_0, bool_4: true);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
			return;
		}
		foreach (Slider item in list_0)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_270((Control)(object)item, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_269());
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_268(appSettings_0, bool_4: false);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_86()
	{
		foreach (Slider item in list_0)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_270((Control)(object)item, (Brush)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_271());
		}
	}

	private void method_87(object sender, MouseButtonEventArgs e)
	{
		if (coZBLtJvvLTyTbztqsnJRvAwHcTg_0 != null)
		{
			coZBLtJvvLTyTbztqsnJRvAwHcTg_0 = null;
		}
		CoZBLtJvvLTyTbztqsnJRvAwHcTg window_ = new CoZBLtJvvLTyTbztqsnJRvAwHcTg(appSettings_0, (Effects)1);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_216((Window)(object)window_, (Window)(object)this);
		coZBLtJvvLTyTbztqsnJRvAwHcTg_0 = window_;
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_217((Window)(object)coZBLtJvvLTyTbztqsnJRvAwHcTg_0);
	}

	private void method_88(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_272(appSettings_1, bool_4: true);
	}

	private void method_89(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_272(appSettings_1, bool_4: false);
	}

	private void method_90(object sender, RoutedEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_160(gameChecker_0) == 4)
		{
			method_68();
		}
	}

	private void method_91(object sender, SelectionChangedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_274(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_273((Selector)(object)comboBox_2));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
		if (bool_1)
		{
			method_68();
		}
		else
		{
			gclass1_0.method_0();
		}
	}

	private void method_92(object sender, RoutedEventArgs e)
	{
		if (wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_14).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_275(appSettings_0, bool_4: true);
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_275(appSettings_0, bool_4: false);
			gclass1_0.method_2();
		}
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
	}

	private void method_93(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_276(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_21));
		if (label_23 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_23, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_21)),
				"%"
			}));
		}
	}

	private void method_94(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_277(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_22));
		if (label_24 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_24, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_173((object)"Bass-Shakers Gain ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_22)), (object)"%"));
		}
	}

	private void method_95(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_278(appSettings_0, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_23));
		if (label_25 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_25, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_127((object)"Filtering Threshold ", (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_23))));
		}
	}

	private void method_96(object sender, RoutedEventArgs e)
	{
		if (!wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_76((ToggleButton)(object)checkBox_9).Value)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_279(appSettings_1, bool_4: false);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_1);
			method_68();
		}
		else
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_279(appSettings_1, bool_4: true);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_1);
			method_68();
		}
	}

	private void method_97(object sender, SelectionChangedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_159(appSettings_1, wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_156(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_155((Selector)(object)comboBox_1)));
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_1);
	}

	private void method_98(object sender, RoutedEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_280(appSettings_0, 1);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
		if ((int)appSettings_0.CurrentGame != 0)
		{
			method_68();
		}
	}

	private void method_99(object sender, RoutedEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_280(appSettings_0, 2);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_165(appSettings_0);
		if ((int)appSettings_0.CurrentGame != 0)
		{
			method_68();
		}
	}

	private void method_100(object sender, MouseButtonEventArgs e)
	{
		try
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_282(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_281(textBox_0));
			method_13("Copied!", bool_4: true);
		}
		catch (Exception exception_)
		{
			method_13(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_86(exception_), bool_4: true, 1);
		}
	}

	private void method_101(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_283(appSettings_1, bool_4: true);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_284(appSettings_1, bool_4: false);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_130(appSettings_1, bool_4: false);
		method_7(Utils.SamplesSubfolders_JS);
		method_68();
	}

	private void method_102(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_283(appSettings_1, bool_4: false);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_284(appSettings_1, bool_4: true);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_130(appSettings_1, bool_4: false);
		method_7(Utils.SamplesSubfolders_JS);
		method_68();
	}

	private void method_103(object sender, RoutedEventArgs e)
	{
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_283(appSettings_1, bool_4: false);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_284(appSettings_1, bool_4: false);
		wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_130(appSettings_1, bool_4: true);
		method_68();
	}

	private void method_104(object sender, RoutedEventArgs e)
	{
		string_12 = "ForceFeel";
		if (label_0 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_0, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_0)),
				"%"
			}));
		}
		if (label_5 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_5, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_5)),
				"%"
			}));
		}
		if (label_7 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_7, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_7)),
				"%"
			}));
		}
		if (label_2 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_2, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_2)),
				"%"
			}));
		}
		if (label_9 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_9, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_9)),
				"%"
			}));
		}
		if (label_14 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_14, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_12)),
				"%"
			}));
		}
		if (label_16 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_16, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_14)),
				"%"
			}));
		}
		if (label_18 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_18, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_16)),
				"%"
			}));
		}
		if (label_20 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_20, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_18)),
				"%"
			}));
		}
		if (label_23 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_23, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_21)),
				"%"
			}));
		}
		if (label_26 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_26, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_24)),
				"%"
			}));
		}
		if (label_28 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_28, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_26)),
				"%"
			}));
		}
		if (label_30 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_30, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_28)),
				"%"
			}));
		}
		if (label_32 != null)
		{
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_171((ContentControl)(object)label_32, (object)wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_139(new object[4]
			{
				string_12,
				" Gain ",
				wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_170(wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_168((RangeBase)(object)slider_30)),
				"%"
			}));
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bool_3)
		{
			bool_3 = true;
			Uri uri_ = wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_285("/SimShaker - Wheels;component/kltidlvmddmafzjtpegdvcuwmajt.xaml", UriKind.Relative);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_286((object)this, uri_);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_033a: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected O, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected O, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected O, but got Unknown
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected O, but got Unknown
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected O, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected O, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected O, but got Unknown
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected O, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected O, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected O, but got Unknown
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected O, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected O, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected O, but got Unknown
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected O, but got Unknown
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Expected O, but got Unknown
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected O, but got Unknown
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected O, but got Unknown
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected O, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected O, but got Unknown
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected O, but got Unknown
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected O, but got Unknown
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected O, but got Unknown
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected O, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected O, but got Unknown
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected O, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected O, but got Unknown
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected O, but got Unknown
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected O, but got Unknown
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected O, but got Unknown
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba4: Expected O, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected O, but got Unknown
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Expected O, but got Unknown
		//IL_0be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected O, but got Unknown
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Expected O, but got Unknown
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected O, but got Unknown
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected O, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected O, but got Unknown
		//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Expected O, but got Unknown
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c68: Expected O, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected O, but got Unknown
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected O, but got Unknown
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected O, but got Unknown
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Expected O, but got Unknown
		//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce8: Expected O, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected O, but got Unknown
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Expected O, but got Unknown
		//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Expected O, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected O, but got Unknown
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Expected O, but got Unknown
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected O, but got Unknown
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected O, but got Unknown
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Expected O, but got Unknown
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d95: Expected O, but got Unknown
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da2: Expected O, but got Unknown
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected O, but got Unknown
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Expected O, but got Unknown
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dea: Expected O, but got Unknown
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Expected O, but got Unknown
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1b: Expected O, but got Unknown
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected O, but got Unknown
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e35: Expected O, but got Unknown
		//IL_0e38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e42: Expected O, but got Unknown
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected O, but got Unknown
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Expected O, but got Unknown
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8a: Expected O, but got Unknown
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected O, but got Unknown
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Expected O, but got Unknown
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Expected O, but got Unknown
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Expected O, but got Unknown
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eec: Expected O, but got Unknown
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef9: Expected O, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Expected O, but got Unknown
		//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2a: Expected O, but got Unknown
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Expected O, but got Unknown
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Expected O, but got Unknown
		//IL_0f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		//IL_0f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Expected O, but got Unknown
		//IL_0f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8c: Expected O, but got Unknown
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f99: Expected O, but got Unknown
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Expected O, but got Unknown
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected O, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Expected O, but got Unknown
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe1: Expected O, but got Unknown
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected O, but got Unknown
		//IL_0ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1005: Expected O, but got Unknown
		//IL_1008: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012: Expected O, but got Unknown
		//IL_101f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Expected O, but got Unknown
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1036: Expected O, but got Unknown
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_104d: Expected O, but got Unknown
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Expected O, but got Unknown
		//IL_1067: Unknown result type (might be due to invalid IL or missing references)
		//IL_1071: Expected O, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Expected O, but got Unknown
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_108c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected O, but got Unknown
		//IL_1096: Expected O, but got Unknown
		//IL_1099: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a3: Expected O, but got Unknown
		//IL_10a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0: Expected O, but got Unknown
		//IL_10bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Expected O, but got Unknown
		//IL_10ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected O, but got Unknown
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Expected O, but got Unknown
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected O, but got Unknown
		//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Expected O, but got Unknown
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_1112: Expected O, but got Unknown
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1129: Expected O, but got Unknown
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			bool_3 = true;
			break;
		case 1:
			wXRKbETVPIBmGGRgXkIEjobHeTfG_0 = (wXRKbETVPIBmGGRgXkIEjobHeTfG)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_287((Window)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG_0, (CancelEventHandler)method_14);
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_288((FrameworkElement)(object)wXRKbETVPIBmGGRgXkIEjobHeTfG_0, new RoutedEventHandler(method_2));
			break;
		case 2:
			tabControl_0 = (TabControl)target;
			break;
		case 3:
			groupBox_0 = (GroupBox)target;
			break;
		case 4:
			checkBox_0 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_0, new RoutedEventHandler(method_72));
			break;
		case 5:
			slider_0 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_0, (RoutedPropertyChangedEventHandler<double>)method_15);
			break;
		case 6:
			slider_1 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_1, (RoutedPropertyChangedEventHandler<double>)method_16);
			break;
		case 7:
			label_0 = (Label)target;
			break;
		case 8:
			label_1 = (Label)target;
			break;
		case 9:
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_291((UIElement)(Label)target, new MouseButtonEventHandler(method_87));
			break;
		case 10:
			groupBox_1 = (GroupBox)target;
			break;
		case 11:
			checkBox_1 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_1, new RoutedEventHandler(method_75));
			break;
		case 12:
			slider_2 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_2, (RoutedPropertyChangedEventHandler<double>)method_21);
			break;
		case 13:
			slider_3 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_3, (RoutedPropertyChangedEventHandler<double>)method_22);
			break;
		case 14:
			label_2 = (Label)target;
			break;
		case 15:
			label_3 = (Label)target;
			break;
		case 16:
			slider_4 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_4, (RoutedPropertyChangedEventHandler<double>)method_23);
			break;
		case 17:
			label_4 = (Label)target;
			break;
		case 18:
			groupBox_2 = (GroupBox)target;
			break;
		case 19:
			radioButton_0 = (RadioButton)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)radioButton_0, new RoutedEventHandler(method_101));
			break;
		case 20:
			checkBox_2 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)checkBox_2, new RoutedEventHandler(method_60));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_293((ToggleButton)(object)checkBox_2, new RoutedEventHandler(method_61));
			break;
		case 21:
			button_0 = (Button)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)button_0, new RoutedEventHandler(method_49));
			break;
		case 22:
			button_1 = (Button)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)button_1, new RoutedEventHandler(method_50));
			break;
		case 23:
			radioButton_1 = (RadioButton)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)radioButton_1, new RoutedEventHandler(method_102));
			break;
		case 24:
			radioButton_2 = (RadioButton)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)radioButton_2, new RoutedEventHandler(method_103));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)radioButton_2, new RoutedEventHandler(method_104));
			break;
		case 25:
			button_2 = (Button)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)button_2, new RoutedEventHandler(method_51));
			break;
		case 26:
			button_3 = (Button)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)button_3, new RoutedEventHandler(method_52));
			break;
		case 27:
			groupBox_3 = (GroupBox)target;
			break;
		case 28:
			checkBox_3 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_3, new RoutedEventHandler(method_73));
			break;
		case 29:
			slider_5 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_5, (RoutedPropertyChangedEventHandler<double>)method_17);
			break;
		case 30:
			slider_6 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_6, (RoutedPropertyChangedEventHandler<double>)method_18);
			break;
		case 31:
			label_5 = (Label)target;
			break;
		case 32:
			label_6 = (Label)target;
			break;
		case 33:
			groupBox_4 = (GroupBox)target;
			break;
		case 34:
			checkBox_4 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_4, new RoutedEventHandler(method_74));
			break;
		case 35:
			slider_7 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_7, (RoutedPropertyChangedEventHandler<double>)method_19);
			break;
		case 36:
			slider_8 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_8, (RoutedPropertyChangedEventHandler<double>)method_20);
			break;
		case 37:
			label_7 = (Label)target;
			break;
		case 38:
			label_8 = (Label)target;
			break;
		case 39:
			groupBox_5 = (GroupBox)target;
			break;
		case 40:
			checkBox_5 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_5, new RoutedEventHandler(method_76));
			break;
		case 41:
			slider_9 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_9, (RoutedPropertyChangedEventHandler<double>)method_24);
			break;
		case 42:
			slider_10 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_10, (RoutedPropertyChangedEventHandler<double>)method_25);
			break;
		case 43:
			label_9 = (Label)target;
			break;
		case 44:
			label_10 = (Label)target;
			break;
		case 45:
			slider_11 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_11, (RoutedPropertyChangedEventHandler<double>)method_26);
			break;
		case 46:
			label_11 = (Label)target;
			break;
		case 47:
			groupBox_6 = (GroupBox)target;
			break;
		case 48:
			textBox_0 = (TextBox)target;
			break;
		case 49:
			checkBox_6 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)checkBox_6, new RoutedEventHandler(method_36));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_293((ToggleButton)(object)checkBox_6, new RoutedEventHandler(method_37));
			break;
		case 50:
			image_0 = (Image)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_294((UIElement)(object)image_0, new MouseButtonEventHandler(method_100));
			break;
		case 51:
			checkBox_7 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)checkBox_7, new RoutedEventHandler(method_30));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_293((ToggleButton)(object)checkBox_7, new RoutedEventHandler(method_31));
			break;
		case 52:
			groupBox_7 = (GroupBox)target;
			break;
		case 53:
			label_12 = (Label)target;
			break;
		case 54:
			comboBox_0 = (ComboBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_295((Selector)(object)comboBox_0, new SelectionChangedEventHandler(method_63));
			break;
		case 55:
			radioButton_3 = (RadioButton)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)radioButton_3, new RoutedEventHandler(method_67));
			break;
		case 56:
			radioButton_4 = (RadioButton)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)radioButton_4, new RoutedEventHandler(method_66));
			break;
		case 57:
			radioButton_5 = (RadioButton)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)radioButton_5, new RoutedEventHandler(method_65));
			break;
		case 58:
			checkBox_8 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)checkBox_8, new RoutedEventHandler(method_69));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_293((ToggleButton)(object)checkBox_8, new RoutedEventHandler(method_70));
			break;
		case 59:
			checkBox_9 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_9, new RoutedEventHandler(method_96));
			break;
		case 60:
			label_13 = (Label)target;
			break;
		case 61:
			groupBox_8 = (GroupBox)target;
			break;
		case 62:
			checkBox_10 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_10, new RoutedEventHandler(method_77));
			break;
		case 63:
			slider_12 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_12, (RoutedPropertyChangedEventHandler<double>)method_53);
			break;
		case 64:
			slider_13 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_13, (RoutedPropertyChangedEventHandler<double>)method_54);
			break;
		case 65:
			label_14 = (Label)target;
			break;
		case 66:
			label_15 = (Label)target;
			break;
		case 67:
			groupBox_9 = (GroupBox)target;
			break;
		case 68:
			checkBox_11 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_11, new RoutedEventHandler(method_78));
			break;
		case 69:
			slider_14 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_14, (RoutedPropertyChangedEventHandler<double>)method_56);
			break;
		case 70:
			slider_15 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_15, (RoutedPropertyChangedEventHandler<double>)method_57);
			break;
		case 71:
			label_16 = (Label)target;
			break;
		case 72:
			label_17 = (Label)target;
			break;
		case 73:
			groupBox_10 = (GroupBox)target;
			break;
		case 74:
			checkBox_12 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_12, new RoutedEventHandler(method_79));
			break;
		case 75:
			slider_16 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_16, (RoutedPropertyChangedEventHandler<double>)method_58);
			break;
		case 76:
			slider_17 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_17, (RoutedPropertyChangedEventHandler<double>)method_59);
			break;
		case 77:
			label_18 = (Label)target;
			break;
		case 78:
			label_19 = (Label)target;
			break;
		case 79:
			groupBox_11 = (GroupBox)target;
			break;
		case 80:
			checkBox_13 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_13, new RoutedEventHandler(method_80));
			break;
		case 81:
			slider_18 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_18, (RoutedPropertyChangedEventHandler<double>)method_27);
			break;
		case 82:
			slider_19 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_19, (RoutedPropertyChangedEventHandler<double>)method_28);
			break;
		case 83:
			label_20 = (Label)target;
			break;
		case 84:
			label_21 = (Label)target;
			break;
		case 85:
			slider_20 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_20, (RoutedPropertyChangedEventHandler<double>)method_29);
			break;
		case 86:
			label_22 = (Label)target;
			break;
		case 87:
			groupBox_12 = (GroupBox)target;
			break;
		case 88:
			checkBox_14 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_14, new RoutedEventHandler(method_92));
			break;
		case 89:
			slider_21 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_21, (RoutedPropertyChangedEventHandler<double>)method_93);
			break;
		case 90:
			slider_22 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_22, (RoutedPropertyChangedEventHandler<double>)method_94);
			break;
		case 91:
			label_23 = (Label)target;
			break;
		case 92:
			label_24 = (Label)target;
			break;
		case 93:
			slider_23 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_23, (RoutedPropertyChangedEventHandler<double>)method_95);
			break;
		case 94:
			label_25 = (Label)target;
			break;
		case 95:
			groupBox_13 = (GroupBox)target;
			break;
		case 96:
			checkBox_15 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)checkBox_15, new RoutedEventHandler(method_32));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_293((ToggleButton)(object)checkBox_15, new RoutedEventHandler(method_33));
			break;
		case 97:
			checkBox_16 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_292((ToggleButton)(object)checkBox_16, new RoutedEventHandler(method_88));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_293((ToggleButton)(object)checkBox_16, new RoutedEventHandler(method_89));
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_16, new RoutedEventHandler(method_90));
			break;
		case 98:
			groupBox_14 = (GroupBox)target;
			break;
		case 99:
			checkBox_17 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_17, new RoutedEventHandler(method_81));
			break;
		case 100:
			slider_24 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_24, (RoutedPropertyChangedEventHandler<double>)method_34);
			break;
		case 101:
			label_26 = (Label)target;
			break;
		case 102:
			slider_25 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_25, (RoutedPropertyChangedEventHandler<double>)method_35);
			break;
		case 103:
			label_27 = (Label)target;
			break;
		case 104:
			groupBox_15 = (GroupBox)target;
			break;
		case 105:
			groupBox_16 = (GroupBox)target;
			break;
		case 106:
			checkBox_18 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_18, new RoutedEventHandler(method_82));
			break;
		case 107:
			slider_26 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_26, (RoutedPropertyChangedEventHandler<double>)method_39);
			break;
		case 108:
			label_28 = (Label)target;
			break;
		case 109:
			slider_27 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_27, (RoutedPropertyChangedEventHandler<double>)method_40);
			break;
		case 110:
			label_29 = (Label)target;
			break;
		case 111:
			groupBox_17 = (GroupBox)target;
			break;
		case 112:
			groupBox_18 = (GroupBox)target;
			break;
		case 113:
			checkBox_19 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_19, new RoutedEventHandler(method_83));
			break;
		case 114:
			slider_28 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_28, (RoutedPropertyChangedEventHandler<double>)method_41);
			break;
		case 115:
			label_30 = (Label)target;
			break;
		case 116:
			slider_29 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_29, (RoutedPropertyChangedEventHandler<double>)method_42);
			break;
		case 117:
			label_31 = (Label)target;
			break;
		case 118:
			groupBox_19 = (GroupBox)target;
			break;
		case 119:
			checkBox_20 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_20, new RoutedEventHandler(method_84));
			break;
		case 120:
			slider_30 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_30, (RoutedPropertyChangedEventHandler<double>)method_43);
			break;
		case 121:
			label_32 = (Label)target;
			break;
		case 122:
			slider_31 = (Slider)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_290((RangeBase)(object)slider_31, (RoutedPropertyChangedEventHandler<double>)method_44);
			break;
		case 123:
			label_33 = (Label)target;
			break;
		case 124:
			groupBox_20 = (GroupBox)target;
			break;
		case 125:
			groupBox_21 = (GroupBox)target;
			break;
		case 126:
			radioButton_6 = (RadioButton)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)radioButton_6, new RoutedEventHandler(method_98));
			break;
		case 127:
			radioButton_7 = (RadioButton)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)radioButton_7, new RoutedEventHandler(method_99));
			break;
		case 128:
			groupBox_22 = (GroupBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_296((UIElement)(object)groupBox_22, new MouseButtonEventHandler(method_64));
			break;
		case 129:
			button_4 = (Button)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)button_4, new RoutedEventHandler(method_47));
			break;
		case 130:
			groupBox_23 = (GroupBox)target;
			break;
		case 131:
			button_5 = (Button)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)button_5, new RoutedEventHandler(method_45));
			break;
		case 132:
			button_6 = (Button)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)button_6, new RoutedEventHandler(method_46));
			break;
		case 133:
			button_7 = (Button)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)button_7, new RoutedEventHandler(method_71));
			break;
		case 134:
			textBlock_0 = (TextBlock)target;
			break;
		case 135:
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_297((Hyperlink)target, new RequestNavigateEventHandler(method_38));
			break;
		case 136:
			groupBox_24 = (GroupBox)target;
			break;
		case 137:
			comboBox_1 = (ComboBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_295((Selector)(object)comboBox_1, new SelectionChangedEventHandler(method_97));
			break;
		case 138:
			groupBox_25 = (GroupBox)target;
			break;
		case 139:
			checkBox_21 = (CheckBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_289((ButtonBase)(object)checkBox_21, new RoutedEventHandler(method_85));
			break;
		case 140:
			groupBox_26 = (GroupBox)target;
			break;
		case 141:
			comboBox_2 = (ComboBox)target;
			wXRKbETVPIBmGGRgXkIEjobHeTfG.smethod_295((Selector)(object)comboBox_2, new SelectionChangedEventHandler(method_91));
			break;
		case 142:
			textBlock_1 = (TextBlock)target;
			break;
		}
	}

	static string smethod_0(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static string smethod_1(string string_14, string string_15)
	{
		return string_14 + string_15;
	}

	static AppSettings smethod_2(string string_14)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new AppSettings(string_14);
	}

	static GameChecker smethod_3(int int_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new GameChecker(int_1);
	}

	static string smethod_4(string string_14, string string_15, string string_16)
	{
		return string_14 + string_15 + string_16;
	}

	void method_105(string string_14)
	{
		((Window)this).set_Title(string_14);
	}

	static void smethod_5(TextBoxBase textBoxBase_0, ScrollBarVisibility scrollBarVisibility_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		textBoxBase_0.set_VerticalScrollBarVisibility(scrollBarVisibility_0);
	}

	static void smethod_6(EventHandler eventHandler_0)
	{
		GameChecker.add_Checked(eventHandler_0);
	}

	static void smethod_7(TransferString transferString_0)
	{
		Utils.add_AddToLog_Utils(transferString_0);
	}

	static void smethod_8(TransferString transferString_0)
	{
		AppSettings.add_AddToLog_Settings(transferString_0);
	}

	static ItemCollection smethod_9(ItemsControl itemsControl_0)
	{
		return itemsControl_0.get_Items();
	}

	static object smethod_10(CollectionView collectionView_0, int int_1)
	{
		return collectionView_0.GetItemAt(int_1);
	}

	static bool smethod_11()
	{
		return Debugger.IsAttached;
	}

	static void smethod_12(SettingsBase settingsBase_0)
	{
		settingsBase_0.Save();
	}

	static void smethod_13(DispatcherTimer dispatcherTimer_1, object object_0)
	{
		dispatcherTimer_1.set_Tag(object_0);
	}

	static object smethod_14(DispatcherTimer dispatcherTimer_1)
	{
		return dispatcherTimer_1.get_Tag();
	}

	static string smethod_15(string string_14, object object_0)
	{
		return string.Format(string_14, object_0);
	}

	static bool smethod_16(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableLogging();
	}

	static void smethod_17(ToggleButton toggleButton_0, bool? nullable_0)
	{
		toggleButton_0.set_IsChecked(nullable_0);
	}

	static bool smethod_18(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableJetSeat();
	}

	static bool smethod_19(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableJetSeatRace();
	}

	static bool smethod_20(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableForcefeel();
	}

	static bool smethod_21(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableAudio();
	}

	static bool smethod_22(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableCompressor();
	}

	static bool smethod_23(AppSettings appSettings_2)
	{
		return appSettings_2.get_ExclusiveSoundcardControl();
	}

	static int smethod_24(AppSettings appSettings_2)
	{
		return appSettings_2.get_SelectedMaxAudioChannels();
	}

	static void smethod_25(UIElement uielement_0, bool bool_4)
	{
		uielement_0.set_IsEnabled(bool_4);
	}

	static double smethod_26(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_1_1();
	}

	static void smethod_27(RangeBase rangeBase_0, double double_0)
	{
		rangeBase_0.set_Value(double_0);
	}

	static double smethod_28(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_1_2();
	}

	static double smethod_29(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_2_1();
	}

	static double smethod_30(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_2_2();
	}

	static double smethod_31(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_3_1();
	}

	static double smethod_32(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_3_2();
	}

	static double smethod_33(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_4_1();
	}

	static double smethod_34(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_4_2();
	}

	static double smethod_35(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_4_3();
	}

	static double smethod_36(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_5_1();
	}

	static double smethod_37(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_5_2();
	}

	static double smethod_38(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_5_3();
	}

	static double smethod_39(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_14_1();
	}

	static double smethod_40(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_14_2();
	}

	static double smethod_41(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_14_3();
	}

	static bool smethod_42(AppSettings appSettings_2)
	{
		return appSettings_2.get_PCARScbox1();
	}

	static bool smethod_43(AppSettings appSettings_2)
	{
		return appSettings_2.get_PCARScbox2();
	}

	static double smethod_44(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_pCARS_1_1();
	}

	static double smethod_45(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_pCARS_1_2();
	}

	static double smethod_46(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_rF2_1_1();
	}

	static double smethod_47(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_rF2_1_2();
	}

	static double smethod_48(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_iR_1_1();
	}

	static double smethod_49(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_iR_1_2();
	}

	static double smethod_50(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_iR_2_1();
	}

	static double smethod_51(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_iR_2_2();
	}

	static double smethod_52(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_10_1();
	}

	static double smethod_53(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_10_2();
	}

	static double smethod_54(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_11_1();
	}

	static double smethod_55(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_11_2();
	}

	static double smethod_56(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_12_1();
	}

	static double smethod_57(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_12_2();
	}

	static double smethod_58(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_15_1();
	}

	static double smethod_59(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_15_2();
	}

	static double smethod_60(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_15_3();
	}

	static bool smethod_61(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled1();
	}

	static bool smethod_62(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled2();
	}

	static bool smethod_63(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled3();
	}

	static bool smethod_64(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled4();
	}

	static bool smethod_65(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled5();
	}

	static bool smethod_66(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled10();
	}

	static bool smethod_67(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled11();
	}

	static bool smethod_68(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled12();
	}

	static bool smethod_69(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled14();
	}

	static bool smethod_70(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled15();
	}

	static bool smethod_71(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxPCARSenabled1();
	}

	static bool smethod_72(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxRF2enabled1();
	}

	static bool smethod_73(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxIRenabled1();
	}

	static bool smethod_74(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxIRenabled2();
	}

	static bool smethod_75(AppSettings appSettings_2)
	{
		return appSettings_2.get_HighlightControls();
	}

	static bool? smethod_76(ToggleButton toggleButton_0)
	{
		return toggleButton_0.get_IsChecked();
	}

	static int smethod_77(AppSettings appSettings_2)
	{
		return appSettings_2.get_SubfolderSelectorIndex();
	}

	static void smethod_78(Selector selector_0, int int_1)
	{
		selector_0.set_SelectedIndex(int_1);
	}

	static int smethod_79(AppSettings appSettings_2)
	{
		return appSettings_2.get_F1UdpPortSelector();
	}

	static DispatcherTimer smethod_80()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DispatcherTimer();
	}

	static void smethod_81(DispatcherTimer dispatcherTimer_1, EventHandler eventHandler_0)
	{
		dispatcherTimer_1.add_Tick(eventHandler_0);
	}

	static bool smethod_82(string string_14)
	{
		return File.Exists(string_14);
	}

	static string smethod_83(string string_14)
	{
		return File.ReadAllText(string_14);
	}

	static string smethod_84(string string_14)
	{
		return Path.GetFullPath(string_14);
	}

	static void smethod_85(AppSettings appSettings_2, string string_14)
	{
		appSettings_2.set_PathToFile(string_14);
	}

	static string smethod_86(Exception exception_0)
	{
		return exception_0.Message;
	}

	static bool smethod_87(AppSettings appSettings_2)
	{
		return appSettings_2.ReadFromFile();
	}

	static string smethod_88(AppSettings appSettings_2)
	{
		return appSettings_2.get_PresetName();
	}

	static string smethod_89(string[] string_14)
	{
		return string.Concat(string_14);
	}

	static string smethod_90(AppSettings appSettings_2)
	{
		return appSettings_2.get_PathToFile();
	}

	static void smethod_91(string string_14, string string_15)
	{
		File.WriteAllText(string_14, string_15);
	}

	static bool smethod_92(string string_14)
	{
		return Directory.Exists(string_14);
	}

	static DirectoryInfo smethod_93(string string_14)
	{
		return Directory.CreateDirectory(string_14);
	}

	static double smethod_94(AppSettings appSettings_2)
	{
		return appSettings_2.get_WindowLeftEdge();
	}

	static void smethod_95(Window window_0, double double_0)
	{
		window_0.set_Left(double_0);
	}

	static double smethod_96(AppSettings appSettings_2)
	{
		return appSettings_2.get_WindowTopEdge();
	}

	static void smethod_97(Window window_0, double double_0)
	{
		window_0.set_Top(double_0);
	}

	static FileStream smethod_98(string string_14)
	{
		return File.Create(string_14);
	}

	static void smethod_99(Stream stream_0)
	{
		stream_0.Close();
	}

	static void smethod_100(string string_14, FileAttributes fileAttributes_0)
	{
		File.SetAttributes(string_14, fileAttributes_0);
	}

	static void smethod_101(int int_1)
	{
		Thread.Sleep(int_1);
	}

	static FileInfo smethod_102(string string_14)
	{
		return new FileInfo(string_14);
	}

	static long smethod_103(FileInfo fileInfo_0)
	{
		return fileInfo_0.Length;
	}

	static MessageBoxResult smethod_104(string string_14, string string_15, MessageBoxButton messageBoxButton_0, MessageBoxImage messageBoxImage_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_14, string_15, messageBoxButton_0, messageBoxImage_0);
	}

	static string smethod_105(string string_14)
	{
		return Utils.EncryptString(string_14);
	}

	static string smethod_106(string string_14, string string_15, string string_16, string string_17)
	{
		return string_14 + string_15 + string_16 + string_17;
	}

	static Process smethod_107()
	{
		return new Process();
	}

	static ProcessStartInfo smethod_108(Process process_1)
	{
		return process_1.StartInfo;
	}

	static void smethod_109(ProcessStartInfo processStartInfo_0, string string_14)
	{
		processStartInfo_0.Domain = string_14;
	}

	static void smethod_110(ProcessStartInfo processStartInfo_0, string string_14)
	{
		processStartInfo_0.FileName = string_14;
	}

	static void smethod_111(ProcessStartInfo processStartInfo_0, bool bool_4)
	{
		processStartInfo_0.LoadUserProfile = bool_4;
	}

	static void smethod_112(ProcessStartInfo processStartInfo_0, SecureString secureString_0)
	{
		processStartInfo_0.Password = secureString_0;
	}

	static void smethod_113(ProcessStartInfo processStartInfo_0, Encoding encoding_0)
	{
		processStartInfo_0.StandardErrorEncoding = encoding_0;
	}

	static void smethod_114(ProcessStartInfo processStartInfo_0, Encoding encoding_0)
	{
		processStartInfo_0.StandardOutputEncoding = encoding_0;
	}

	static void smethod_115(ProcessStartInfo processStartInfo_0, string string_14)
	{
		processStartInfo_0.UserName = string_14;
	}

	static void smethod_116(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		processStartInfo_0.WindowStyle = processWindowStyle_0;
	}

	static void smethod_117(ProcessStartInfo processStartInfo_0, string string_14)
	{
		processStartInfo_0.WorkingDirectory = string_14;
	}

	static bool smethod_118(Process process_1)
	{
		return process_1.Start();
	}

	static int smethod_119(string string_14)
	{
		return string_14.Length;
	}

	static int smethod_120(ItemCollection itemCollection_0, object object_0)
	{
		return itemCollection_0.Add(object_0);
	}

	static Type smethod_121(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static string[] smethod_122(Type type_0)
	{
		return Enum.GetNames(type_0);
	}

	static bool smethod_123(string string_14, string string_15)
	{
		return string_14 != string_15;
	}

	static string smethod_124(AppSettings appSettings_2)
	{
		return appSettings_2.get_GameMode();
	}

	static void smethod_125(Selector selector_0, object object_0)
	{
		selector_0.set_SelectedItem(object_0);
	}

	static object smethod_126(HeaderedContentControl headeredContentControl_0)
	{
		return headeredContentControl_0.get_Header();
	}

	static string smethod_127(object object_0, object object_1)
	{
		return string.Concat(object_0, object_1);
	}

	static void smethod_128(HeaderedContentControl headeredContentControl_0, object object_0)
	{
		headeredContentControl_0.set_Header(object_0);
	}

	static void smethod_129(DispatcherTimer dispatcherTimer_1, TimeSpan timeSpan_0)
	{
		dispatcherTimer_1.set_Interval(timeSpan_0);
	}

	static void smethod_130(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_EnableForcefeel(bool_4);
	}

	static void smethod_131(DispatcherTimer dispatcherTimer_1)
	{
		dispatcherTimer_1.Start();
	}

	static void smethod_132(string string_14, DateTime dateTime_0)
	{
		File.SetCreationTime(string_14, dateTime_0);
	}

	static void smethod_133(string string_14, DateTime dateTime_0)
	{
		File.SetLastWriteTime(string_14, dateTime_0);
	}

	static FileAttributes smethod_134(string string_14)
	{
		return File.GetAttributes(string_14);
	}

	static DateTime smethod_135(string string_14)
	{
		return File.GetCreationTime(string_14);
	}

	static DateTime smethod_136(string string_14)
	{
		return File.GetLastWriteTime(string_14);
	}

	static short smethod_137(string string_14)
	{
		return Convert.ToInt16(string_14);
	}

	static void smethod_138(string string_14, string string_15)
	{
		Utils.ReplaceFileIfDifferent(string_14, string_15);
	}

	static string smethod_139(object[] object_0)
	{
		return string.Concat(object_0);
	}

	static Assembly smethod_140()
	{
		return Assembly.GetExecutingAssembly();
	}

	static object[] smethod_141(Assembly assembly_0, Type type_0, bool bool_4)
	{
		return assembly_0.GetCustomAttributes(type_0, bool_4);
	}

	static string smethod_142(AssemblyTitleAttribute assemblyTitleAttribute_0)
	{
		return assemblyTitleAttribute_0.Title;
	}

	static string smethod_143(Assembly assembly_0)
	{
		return assembly_0.CodeBase;
	}

	static string smethod_144(string string_14)
	{
		return Path.GetFileNameWithoutExtension(string_14);
	}

	static AssemblyName smethod_145(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	static Version smethod_146(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Version;
	}

	static int smethod_147(Version version_0)
	{
		return version_0.Major;
	}

	static string smethod_148(AssemblyDescriptionAttribute assemblyDescriptionAttribute_0)
	{
		return assemblyDescriptionAttribute_0.Description;
	}

	static string smethod_149(AssemblyProductAttribute assemblyProductAttribute_0)
	{
		return assemblyProductAttribute_0.Product;
	}

	static string smethod_150(AssemblyCopyrightAttribute assemblyCopyrightAttribute_0)
	{
		return assemblyCopyrightAttribute_0.Copyright;
	}

	static string smethod_151(AssemblyCompanyAttribute assemblyCompanyAttribute_0)
	{
		return assemblyCompanyAttribute_0.Company;
	}

	static Dispatcher smethod_152(DispatcherObject dispatcherObject_0)
	{
		return dispatcherObject_0.get_Dispatcher();
	}

	static bool smethod_153(Dispatcher dispatcher_0)
	{
		return dispatcher_0.CheckAccess();
	}

	static object smethod_154(Dispatcher dispatcher_0, Delegate delegate_0, object[] object_0)
	{
		return dispatcher_0.Invoke(delegate_0, object_0);
	}

	static object smethod_155(Selector selector_0)
	{
		return selector_0.get_SelectedItem();
	}

	static string smethod_156(object object_0)
	{
		return object_0.ToString();
	}

	static object smethod_157(Type type_0, string string_14)
	{
		return Enum.Parse(type_0, string_14);
	}

	static void smethod_158(GameChecker gameChecker_1, Games games_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		gameChecker_1.set_GameRunning(games_0);
	}

	static void smethod_159(AppSettings appSettings_2, string string_14)
	{
		appSettings_2.set_GameMode(string_14);
	}

	static Games smethod_160(GameChecker gameChecker_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return gameChecker_1.get_GameRunning();
	}

	static double smethod_161(Window window_0)
	{
		return window_0.get_Left();
	}

	static void smethod_162(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_WindowLeftEdge(double_0);
	}

	static double smethod_163(Window window_0)
	{
		return window_0.get_Top();
	}

	static void smethod_164(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_WindowTopEdge(double_0);
	}

	static bool smethod_165(AppSettings appSettings_2)
	{
		return appSettings_2.SaveToFile();
	}

	static void smethod_166()
	{
		JSHandler.CloseForceFeel();
	}

	static bool smethod_167(Process process_1)
	{
		return process_1.CloseMainWindow();
	}

	static double smethod_168(RangeBase rangeBase_0)
	{
		return rangeBase_0.get_Value();
	}

	static void smethod_169(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_1_1(double_0);
	}

	static short smethod_170(double double_0)
	{
		return Convert.ToInt16(double_0);
	}

	static void smethod_171(ContentControl contentControl_0, object object_0)
	{
		contentControl_0.set_Content(object_0);
	}

	static void smethod_172(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_1_2(double_0);
	}

	static string smethod_173(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	static void smethod_174(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_2_1(double_0);
	}

	static void smethod_175(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_2_2(double_0);
	}

	static void smethod_176(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_3_1(double_0);
	}

	static void smethod_177(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_3_2(double_0);
	}

	static void smethod_178(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_4_1(double_0);
	}

	static void smethod_179(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_4_2(double_0);
	}

	static void smethod_180(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_4_3(double_0);
	}

	static void smethod_181(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_5_1(double_0);
	}

	static void smethod_182(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_5_2(double_0);
	}

	static void smethod_183(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_5_3(double_0);
	}

	static SolidColorBrush smethod_184()
	{
		return Brushes.get_Red();
	}

	static void smethod_185(Control control_0, Brush brush_0)
	{
		control_0.set_Foreground(brush_0);
	}

	static SolidColorBrush smethod_186()
	{
		return Brushes.get_Black();
	}

	static void smethod_187(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_14_1(double_0);
	}

	static void smethod_188(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_14_2(double_0);
	}

	static void smethod_189(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_14_3(double_0);
	}

	static void smethod_190(Window window_0, bool bool_4)
	{
		window_0.set_Topmost(bool_4);
	}

	static void smethod_191(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_PCARScbox1(bool_4);
	}

	static void smethod_192(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_pCARS_1_1(double_0);
	}

	static void smethod_193(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_pCARS_1_2(double_0);
	}

	static void smethod_194(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_EnableLogging(bool_4);
	}

	static bool smethod_195(Window window_0)
	{
		return window_0.get_IsActive();
	}

	static void smethod_196(TextBox textBox_1, string string_14)
	{
		textBox_1.set_Text(string_14);
	}

	static Uri smethod_197(RequestNavigateEventArgs requestNavigateEventArgs_0)
	{
		return requestNavigateEventArgs_0.get_Uri();
	}

	static string smethod_198(Uri uri_0)
	{
		return uri_0.AbsoluteUri;
	}

	static ProcessStartInfo smethod_199(string string_14)
	{
		return new ProcessStartInfo(string_14);
	}

	static Process smethod_200(ProcessStartInfo processStartInfo_0)
	{
		return Process.Start(processStartInfo_0);
	}

	static void smethod_201(RoutedEventArgs routedEventArgs_0, bool bool_4)
	{
		routedEventArgs_0.set_Handled(bool_4);
	}

	static void smethod_202(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_rF2_1_1(double_0);
	}

	static void smethod_203(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_rF2_1_2(double_0);
	}

	static void smethod_204(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_iR_1_1(double_0);
	}

	static void smethod_205(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_iR_1_2(double_0);
	}

	static void smethod_206(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_iR_2_1(double_0);
	}

	static void smethod_207(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_iR_2_2(double_0);
	}

	static SaveFileDialog smethod_208()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SaveFileDialog();
	}

	static void smethod_209(FileDialog fileDialog_0, string string_14)
	{
		fileDialog_0.set_DefaultExt(string_14);
	}

	static void smethod_210(FileDialog fileDialog_0, string string_14)
	{
		fileDialog_0.set_Filter(string_14);
	}

	static void smethod_211(FileDialog fileDialog_0, string string_14)
	{
		fileDialog_0.set_InitialDirectory(string_14);
	}

	static bool? smethod_212(CommonDialog commonDialog_0)
	{
		return commonDialog_0.ShowDialog();
	}

	static string smethod_213(FileDialog fileDialog_0)
	{
		return fileDialog_0.get_FileName();
	}

	static OpenFileDialog smethod_214()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OpenFileDialog();
	}

	static void smethod_215(OpenFileDialog openFileDialog_0, bool bool_4)
	{
		openFileDialog_0.set_Multiselect(bool_4);
	}

	static void smethod_216(Window window_0, Window window_1)
	{
		window_0.set_Owner(window_1);
	}

	static void smethod_217(Window window_0)
	{
		window_0.Show();
	}

	static void smethod_218(Window window_0, EventHandler eventHandler_0)
	{
		window_0.add_Closed(eventHandler_0);
	}

	static void smethod_219(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_10_1(double_0);
	}

	static void smethod_220(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_10_2(double_0);
	}

	static void smethod_221(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_11_1(double_0);
	}

	static void smethod_222(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_11_2(double_0);
	}

	static void smethod_223(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_12_1(double_0);
	}

	static void smethod_224(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_12_2(double_0);
	}

	static void smethod_225(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_EnableAudio(bool_4);
	}

	static bool smethod_226(Window window_0)
	{
		return window_0.get_IsActive();
	}

	static string smethod_227(AppSettings appSettings_2)
	{
		return appSettings_2.get_SelectedAudioDeviceId();
	}

	static bool smethod_228(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableASIOaudio();
	}

	static void smethod_229(ItemCollection itemCollection_0)
	{
		itemCollection_0.Clear();
	}

	static MMDeviceEnumerator smethod_230()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new MMDeviceEnumerator();
	}

	static MMDeviceCollection smethod_231(MMDeviceEnumerator mmdeviceEnumerator_0, DataFlow dataFlow_0, DeviceState deviceState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return mmdeviceEnumerator_0.EnumerateAudioEndPoints(dataFlow_0, deviceState_0);
	}

	static IEnumerator<MMDevice> smethod_232(MMDeviceCollection mmdeviceCollection_0)
	{
		return mmdeviceCollection_0.GetEnumerator();
	}

	static bool smethod_233(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_234(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static MMDevice smethod_235(MMDeviceEnumerator mmdeviceEnumerator_0, string string_14)
	{
		return mmdeviceEnumerator_0.GetDevice(string_14);
	}

	static IEnumerator smethod_236(IEnumerable ienumerable_0)
	{
		return ienumerable_0.GetEnumerator();
	}

	static object smethod_237(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static string smethod_238(MMDevice mmdevice_1)
	{
		return mmdevice_1.get_ID();
	}

	static bool smethod_239(string string_14, string string_15)
	{
		return string_14 == string_15;
	}

	static void smethod_240(AppSettings appSettings_2, string string_14)
	{
		appSettings_2.set_SelectedAudioDeviceId(string_14);
	}

	static bool smethod_241(UIElement uielement_0)
	{
		return uielement_0.get_IsEnabled();
	}

	static void smethod_242(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_ShowDeactivate(bool_4);
	}

	static void smethod_243(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_EnableASIOaudio(bool_4);
	}

	static void smethod_244(AppSettings appSettings_2, int int_1)
	{
		appSettings_2.set_SelectedMaxAudioChannels(int_1);
	}

	static MessageBoxResult smethod_245(string string_14, string string_15)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_14, string_15);
	}

	static Assembly smethod_246()
	{
		return Application.get_ResourceAssembly();
	}

	static string smethod_247(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	static Process smethod_248(string string_14)
	{
		return Process.Start(string_14);
	}

	static Application smethod_249()
	{
		return Application.get_Current();
	}

	static void smethod_250(Application application_0)
	{
		application_0.Shutdown();
	}

	static void smethod_251(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_EnableCompressor(bool_4);
	}

	static float smethod_252(AppSettings appSettings_2)
	{
		return appSettings_2.get_CompressorThreshold();
	}

	static float smethod_253(AppSettings appSettings_2)
	{
		return appSettings_2.get_CompressorFactor();
	}

	static string smethod_254(string string_14, object object_0, object object_1)
	{
		return string.Format(string_14, object_0, object_1);
	}

	static void smethod_255(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled1(bool_4);
	}

	static void smethod_256(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled2(bool_4);
	}

	static void smethod_257(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled3(bool_4);
	}

	static void smethod_258(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled4(bool_4);
	}

	static void smethod_259(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled5(bool_4);
	}

	static void smethod_260(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled10(bool_4);
	}

	static void smethod_261(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled11(bool_4);
	}

	static void smethod_262(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled12(bool_4);
	}

	static void smethod_263(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled14(bool_4);
	}

	static void smethod_264(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxPCARSenabled1(bool_4);
	}

	static void smethod_265(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxRF2enabled1(bool_4);
	}

	static void smethod_266(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxIRenabled1(bool_4);
	}

	static void smethod_267(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxIRenabled2(bool_4);
	}

	static void smethod_268(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_HighlightControls(bool_4);
	}

	static SolidColorBrush smethod_269()
	{
		return Brushes.get_Transparent();
	}

	static void smethod_270(Control control_0, Brush brush_0)
	{
		control_0.set_Background(brush_0);
	}

	static SolidColorBrush smethod_271()
	{
		return Brushes.get_YellowGreen();
	}

	static void smethod_272(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_PCARScbox2(bool_4);
	}

	static int smethod_273(Selector selector_0)
	{
		return selector_0.get_SelectedIndex();
	}

	static void smethod_274(AppSettings appSettings_2, int int_1)
	{
		appSettings_2.set_SubfolderSelectorIndex(int_1);
	}

	static void smethod_275(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_FxEnabled15(bool_4);
	}

	static void smethod_276(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_15_1(double_0);
	}

	static void smethod_277(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_15_2(double_0);
	}

	static void smethod_278(AppSettings appSettings_2, double double_0)
	{
		appSettings_2.set_Slider_15_3(double_0);
	}

	static void smethod_279(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_ExclusiveSoundcardControl(bool_4);
	}

	static void smethod_280(AppSettings appSettings_2, int int_1)
	{
		appSettings_2.set_F1UdpPortSelector(int_1);
	}

	static string smethod_281(TextBox textBox_1)
	{
		return textBox_1.get_Text();
	}

	static void smethod_282(string string_14)
	{
		Clipboard.SetText(string_14);
	}

	static void smethod_283(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_EnableJetSeat(bool_4);
	}

	static void smethod_284(AppSettings appSettings_2, bool bool_4)
	{
		appSettings_2.set_EnableJetSeatRace(bool_4);
	}

	static Uri smethod_285(string string_14, UriKind uriKind_0)
	{
		return new Uri(string_14, uriKind_0);
	}

	static void smethod_286(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}

	static void smethod_287(Window window_0, CancelEventHandler cancelEventHandler_0)
	{
		window_0.add_Closing(cancelEventHandler_0);
	}

	static void smethod_288(FrameworkElement frameworkElement_0, RoutedEventHandler routedEventHandler_0)
	{
		frameworkElement_0.add_Loaded(routedEventHandler_0);
	}

	static void smethod_289(ButtonBase buttonBase_0, RoutedEventHandler routedEventHandler_0)
	{
		buttonBase_0.add_Click(routedEventHandler_0);
	}

	static void smethod_290(RangeBase rangeBase_0, RoutedPropertyChangedEventHandler<double> routedPropertyChangedEventHandler_0)
	{
		rangeBase_0.add_ValueChanged(routedPropertyChangedEventHandler_0);
	}

	static void smethod_291(UIElement uielement_0, MouseButtonEventHandler mouseButtonEventHandler_0)
	{
		uielement_0.add_MouseLeftButtonUp(mouseButtonEventHandler_0);
	}

	static void smethod_292(ToggleButton toggleButton_0, RoutedEventHandler routedEventHandler_0)
	{
		toggleButton_0.add_Checked(routedEventHandler_0);
	}

	static void smethod_293(ToggleButton toggleButton_0, RoutedEventHandler routedEventHandler_0)
	{
		toggleButton_0.add_Unchecked(routedEventHandler_0);
	}

	static void smethod_294(UIElement uielement_0, MouseButtonEventHandler mouseButtonEventHandler_0)
	{
		uielement_0.add_MouseUp(mouseButtonEventHandler_0);
	}

	static void smethod_295(Selector selector_0, SelectionChangedEventHandler selectionChangedEventHandler_0)
	{
		selector_0.add_SelectionChanged(selectionChangedEventHandler_0);
	}

	static void smethod_296(UIElement uielement_0, MouseButtonEventHandler mouseButtonEventHandler_0)
	{
		uielement_0.add_MouseRightButtonUp(mouseButtonEventHandler_0);
	}

	static void smethod_297(Hyperlink hyperlink_0, RequestNavigateEventHandler requestNavigateEventHandler_0)
	{
		hyperlink_0.add_RequestNavigate(requestNavigateEventHandler_0);
	}
}
