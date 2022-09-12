using Alphaleonis.Win32.Filesystem;

namespace FileUtils;

public static class PathChecker
{
	public static PathType GetPathType(string path)
	{
		if (File.Exists(path))
		{
			return PathType.File;
		}
		if (Directory.Exists(path))
		{
			return PathType.Directory;
		}
		return PathType.NonExisting;
	}
}
