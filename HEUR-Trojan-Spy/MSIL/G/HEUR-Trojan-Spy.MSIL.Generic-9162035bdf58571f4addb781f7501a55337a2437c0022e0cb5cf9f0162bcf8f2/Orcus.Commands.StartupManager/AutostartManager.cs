using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Orcus.Shared.Commands.StartupManager;
using Orcus.Utilities;

namespace Orcus.Commands.StartupManager;

public static class AutostartManager
{
	public static List<AutostartProgramInfo> GetAllAutostartPrograms()
	{
		List<AutostartProgramInfo> list = new List<AutostartProgramInfo>();
		list.AddRange(RegistryAutostart.GetAutostartProgramsFromRegistryKey((AutostartLocation)0, isEnabled: true));
		list.AddRange(RegistryAutostart.GetAutostartProgramsFromRegistryKey((AutostartLocation)0, isEnabled: false));
		list.AddRange(RegistryAutostart.GetAutostartProgramsFromRegistryKey((AutostartLocation)1, isEnabled: true));
		list.AddRange(RegistryAutostart.GetAutostartProgramsFromRegistryKey((AutostartLocation)1, isEnabled: false));
		list.AddRange(RegistryAutostart.GetAutostartProgramsFromRegistryKey((AutostartLocation)2, isEnabled: true));
		list.AddRange(RegistryAutostart.GetAutostartProgramsFromRegistryKey((AutostartLocation)2, isEnabled: false));
		list.AddRange(FolderAutostart.GetAutostartProgramsFromFolder((AutostartLocation)100, isEnabled: true));
		list.AddRange(FolderAutostart.GetAutostartProgramsFromFolder((AutostartLocation)100, isEnabled: false));
		list.AddRange(FolderAutostart.GetAutostartProgramsFromFolder((AutostartLocation)101, isEnabled: true));
		list.AddRange(FolderAutostart.GetAutostartProgramsFromFolder((AutostartLocation)101, isEnabled: false));
		return list;
	}

	public static void ChangeAutostartEntry(AutostartLocation autostartLocation, string name, bool isEnabled)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)autostartLocation < 100)
		{
			RegistryAutostart.ChangeAutostartEntry(autostartLocation, name, isEnabled);
		}
		else
		{
			FolderAutostart.ChangeAutostartEntry(autostartLocation, name, isEnabled);
		}
	}

	public static void RemoveAutostartEntry(AutostartLocation autostartLocation, string name, bool isEnabled)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)autostartLocation < 100)
		{
			RegistryAutostart.RemoveAutostartEntry(autostartLocation, name, isEnabled);
		}
		else
		{
			FolderAutostart.RemoveAutostartEntry(autostartLocation, name, isEnabled);
		}
	}

	internal static AutostartProgramInfo CompleteAutostartProgramInfo(AutostartProgramInfo autostartProgramInfo)
	{
		FileInfo fileInfo = null;
		try
		{
			fileInfo = new FileInfo(autostartProgramInfo.get_CommandLine().Contains("\"") ? autostartProgramInfo.get_CommandLine().Split(new char[1] { '"' }, StringSplitOptions.RemoveEmptyEntries)[0] : Regex.Match(autostartProgramInfo.get_CommandLine(), "^[^\\/]+?(\\.... |\\z)").Value);
			if (!fileInfo.Exists)
			{
				autostartProgramInfo.set_EntryStatus((EntryStatus)2);
			}
			else
			{
				autostartProgramInfo.set_Filename(fileInfo.FullName);
			}
		}
		catch (Exception)
		{
			autostartProgramInfo.set_EntryStatus((EntryStatus)2);
		}
		if (fileInfo != null && fileInfo.Exists)
		{
			try
			{
				autostartProgramInfo.set_Icon(FileUtilities.GetIconFromProcess(fileInfo.FullName));
			}
			catch (Exception)
			{
			}
			try
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(fileInfo.FullName);
				autostartProgramInfo.set_Publisher(versionInfo.CompanyName);
				autostartProgramInfo.set_Description(versionInfo.FileDescription);
				if (string.IsNullOrEmpty(autostartProgramInfo.get_Publisher()))
				{
					if (string.IsNullOrEmpty(autostartProgramInfo.get_Description()))
					{
						autostartProgramInfo.set_EntryStatus((EntryStatus)1);
						return autostartProgramInfo;
					}
					return autostartProgramInfo;
				}
				return autostartProgramInfo;
			}
			catch (Exception)
			{
				autostartProgramInfo.set_EntryStatus((EntryStatus)1);
				return autostartProgramInfo;
			}
		}
		return autostartProgramInfo;
	}
}
