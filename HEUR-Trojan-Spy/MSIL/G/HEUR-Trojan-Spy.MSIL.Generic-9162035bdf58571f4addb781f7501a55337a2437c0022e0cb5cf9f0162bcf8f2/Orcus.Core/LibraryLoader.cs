using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Orcus.Config;
using Orcus.Shared.Connection;
using Orcus.Shared.Utilities;

namespace Orcus.Core;

public class LibraryLoader
{
	private class PortableLibraryMatch
	{
		public Match Match { get; }

		public FileInfo FileInfo { get; }

		public PortableLibraryMatch(Match match, FileInfo fileInfo)
		{
			Match = match;
			FileInfo = fileInfo;
		}
	}

	private static LibraryLoader _current;

	public static LibraryLoader Current => _current ?? (_current = new LibraryLoader());

	public PortableLibrary LoadedLibraries { get; private set; }

	public LibraryLoader()
	{
		CleanupLibraries();
	}

	public void LoadLibrary(PortableLibrary portableLibrary, Stream sourceStream, int length)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		string libraryPath = GetLibraryPath(portableLibrary);
		using (FileStream fileStream = new FileStream(libraryPath, FileMode.CreateNew, FileAccess.Write))
		{
			StreamExtensions.CopyToEx(sourceStream, (Stream)fileStream, length);
		}
		LoadLibrary(libraryPath, portableLibrary);
	}

	private static void CleanupLibraries()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.LibrariesDirectory);
		if (!directoryInfo.Exists)
		{
			return;
		}
		Regex regex = new Regex("^(?<name>(.+?))(_(?<number>([0-9]{1,2})))?\\.dll");
		foreach (IGrouping<string, PortableLibraryMatch> item in from x in directoryInfo.GetFiles("*.dll", SearchOption.TopDirectoryOnly)
			select new PortableLibraryMatch(regex.Match(x.Name), x) into x
			group x by x.Match.Groups["name"].Value)
		{
			List<PortableLibraryMatch> list = item.ToList();
			if (list.Count == 1 && string.IsNullOrEmpty(list[0].Match.Groups["number"].Value))
			{
				break;
			}
			PortableLibraryMatch superiorFile = (from x in list
				where !string.IsNullOrEmpty(x.Match.Groups["number"].Value)
				orderby int.Parse(x.Match.Groups["number"].Value) descending
				select x).First();
			foreach (PortableLibraryMatch item2 in list.Where((PortableLibraryMatch x) => x != superiorFile))
			{
				try
				{
					item2.FileInfo.Delete();
				}
				catch (Exception)
				{
				}
			}
			FileInfo fileInfo = new FileInfo(Path.Combine(Consts.LibrariesDirectory, superiorFile.Match.Groups["name"].Value + ".dll"));
			if (!fileInfo.Exists)
			{
				try
				{
					superiorFile.FileInfo.MoveTo(fileInfo.FullName);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private static string GetLibraryPath(PortableLibrary library)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		string filenameByLibrary = GetFilenameByLibrary(library);
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.LibrariesDirectory);
		if (!directoryInfo.Exists)
		{
			directoryInfo.Create();
			return Path.Combine(directoryInfo.FullName, filenameByLibrary);
		}
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filenameByLibrary);
		Regex regex = new Regex("^" + fileNameWithoutExtension + "(_(?<number>([0-9]{1,2})))?\\.dll");
		List<PortableLibraryMatch> list = (from x in directoryInfo.GetFiles(fileNameWithoutExtension + "*.dll", SearchOption.TopDirectoryOnly)
			select new PortableLibraryMatch(regex.Match(x.Name), x)).ToList();
		if (list.Count > 0)
		{
			for (int num = list.Count - 1; num >= 0; num--)
			{
				try
				{
					list[num].FileInfo.Delete();
					list.RemoveAt(num);
				}
				catch (Exception)
				{
				}
			}
			FileInfo fileInfo = new FileInfo(Path.Combine(Consts.LibrariesDirectory, filenameByLibrary));
			if (!fileInfo.Exists)
			{
				return fileInfo.FullName;
			}
			int num2 = (from x in list
				where !string.IsNullOrEmpty(x.Match.Groups["number"].Value)
				select int.Parse(x.Match.Groups["number"].Value) into x
				orderby x descending
				select x).First();
			num2++;
			return Path.Combine(Consts.LibrariesDirectory, fileNameWithoutExtension + "_" + num2 + ".dll");
		}
		return Path.Combine(Consts.LibrariesDirectory, filenameByLibrary);
	}

	public PortableLibrary CheckLibraries(PortableLibrary libraries, List<byte[]> hashes)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.LibrariesDirectory);
		if (!directoryInfo.Exists)
		{
			return libraries;
		}
		PortableLibrary val = (PortableLibrary)0;
		List<PortableLibrary> list = (from x in EnumHelper.GetUniqueFlags<PortableLibrary>((Enum)(object)libraries)
			where (int)x > 0
			select x).ToList();
		Regex regex = new Regex("^(?<name>(.+?))(_(?<number>([0-9]{1,2})))?\\.dll");
		List<PortableLibraryMatch> source = (from x in directoryInfo.GetFiles("*.dll", SearchOption.TopDirectoryOnly)
			select new PortableLibraryMatch(regex.Match(x.Name), x)).ToList();
		using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		for (int i = 0; i < list.Count; i++)
		{
			PortableLibrary library = list[i];
			string libraryName = GetFilenameByLibrary(library);
			List<PortableLibraryMatch> list2 = source.Where((PortableLibraryMatch x) => x.Match.Groups["name"].Value + ".dll" == libraryName).ToList();
			if (list2.Count > 0)
			{
				string path = ((list2.Count != 1) ? (from x in list2
					where !string.IsNullOrEmpty(x.Match.Groups["number"].Value)
					orderby int.Parse(x.Match.Groups["number"].Value) descending
					select x).First().FileInfo.FullName : list2[0].FileInfo.FullName);
				using FileStream inputStream = new FileStream(path, FileMode.Open, FileAccess.Read);
				if (mD5CryptoServiceProvider.ComputeHash(inputStream).SequenceEqual(hashes[i]))
				{
					try
					{
						LoadLibrary(path, library);
					}
					catch (Exception)
					{
						goto end_IL_016a;
					}
					continue;
				}
				end_IL_016a:;
			}
			val = (PortableLibrary)(val | list[i]);
		}
		return val;
	}

	private void LoadLibrary(string path, PortableLibrary library)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		LoadedLibraries = (PortableLibrary)(LoadedLibraries | library);
		Assembly.LoadFile(path);
	}

	private static string GetFilenameByLibrary(PortableLibrary library)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		PortableLibraryNameAttribute attributeOfType = EnumHelper.GetAttributeOfType<PortableLibraryNameAttribute>((Enum)(object)library);
		if (attributeOfType == null)
		{
			return null;
		}
		return attributeOfType.get_Name();
	}
}
