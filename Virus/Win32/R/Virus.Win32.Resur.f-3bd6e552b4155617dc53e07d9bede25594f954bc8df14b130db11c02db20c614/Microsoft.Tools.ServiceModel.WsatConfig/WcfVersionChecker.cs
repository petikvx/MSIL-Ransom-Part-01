using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class WcfVersionChecker
{
	private static readonly List<Version> SupportedVersions = new List<Version>(new Version[2]
	{
		new Version("3.0"),
		new Version("3.5")
	});

	private string machineName;

	public WcfVersionChecker(string machineName)
	{
		this.machineName = machineName;
	}

	private List<Version> GetAllInstalledWinFXs()
	{
		List<Version> list = new List<Version>();
		StdRegProviderWrapper stdRegProviderWrapper = new StdRegProviderWrapper(RegistryHive.LocalMachine, "Software\\Microsoft\\NET Framework Setup\\NDP\\", machineName);
		using (stdRegProviderWrapper)
		{
			string[] subKeyNames = stdRegProviderWrapper.GetSubKeyNames();
			if (subKeyNames != null)
			{
				string[] array = subKeyNames;
				foreach (string text in array)
				{
					string version = text.Substring(1);
					try
					{
						list.Add(new Version(version));
					}
					catch (ArgumentException)
					{
					}
					catch (FormatException)
					{
					}
				}
				return list;
			}
			return list;
		}
	}

	public void EnsureWcfVersionIsExpected()
	{
		List<Version> allInstalledWinFXs = GetAllInstalledWinFXs();
		if (allInstalledWinFXs.Count == 0)
		{
			string errMessage = ((!Utilities.IsLocalMachineName(machineName)) ? SR.GetString("ErrorCanNotFindWcfInstalledOnRemoteMachine") : SR.GetString("ErrorCanNotFindWcfInstalled"));
			throw new WsatAdminException(WsatAdminErrorCode.WRONG_WCF_INSTALLED, errMessage);
		}
		Version version = allInstalledWinFXs[0];
		for (int i = 1; i < allInstalledWinFXs.Count; i++)
		{
			if (allInstalledWinFXs[i] > version)
			{
				version = allInstalledWinFXs[i];
			}
		}
		if (!SupportedVersions.Contains(version))
		{
			string errMessage2 = ((!Utilities.IsLocalMachineName(machineName)) ? SR.GetString("ErrorWcfVersionMismatchOnRemoteMachine", machineName) : SR.GetString("ErrorWcfVersionMismatch"));
			throw new WsatAdminException(WsatAdminErrorCode.WRONG_WCF_INSTALLED, errMessage2);
		}
	}
}
