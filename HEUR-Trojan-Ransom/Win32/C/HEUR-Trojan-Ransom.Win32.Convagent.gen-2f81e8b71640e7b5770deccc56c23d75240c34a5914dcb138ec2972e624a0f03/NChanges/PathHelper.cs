using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NChanges;

public static class PathHelper
{
	public static IEnumerable<string> ExpandPaths(IEnumerable<string> paths)
	{
		return paths.SelectMany((string p) => ExpandPath(p));
	}

	public static IEnumerable<string> ExpandPath(string path)
	{
		string path2 = ".";
		string searchPattern = path;
		if (Enumerable.Contains(path, Path.DirectorySeparatorChar) || Enumerable.Contains(path, Path.AltDirectorySeparatorChar))
		{
			path2 = Path.GetDirectoryName(path);
			searchPattern = Path.GetFileName(path);
		}
		return Directory.GetFiles(path2, searchPattern);
	}

	public static string FormatPath(string output, AssemblyInfo assembly)
	{
		return output.Replace("%name%", assembly.Name).Replace("%version%", assembly.Version);
	}

	public static void EnsureFolderExists(string outputPath)
	{
		string directoryName = Path.GetDirectoryName(outputPath);
		if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
	}
}
