using System;

namespace Renci.SshNet.Common;

internal class PosixPath
{
	public string Directory { get; private set; }

	public string File { get; private set; }

	public static PosixPath CreateAbsoluteOrRelativeFilePath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		PosixPath posixPath = new PosixPath();
		int num = path.LastIndexOf('/');
		switch (num)
		{
		case -1:
			if (path.Length == 0)
			{
				throw new ArgumentException("The path is a zero-length string.", "path");
			}
			posixPath.Directory = ".";
			posixPath.File = path;
			break;
		case 0:
			posixPath.Directory = "/";
			if (path.Length > 1)
			{
				posixPath.File = path.Substring(num + 1);
			}
			break;
		default:
			posixPath.Directory = path.Substring(0, num);
			if (num < path.Length - 1)
			{
				posixPath.File = path.Substring(num + 1);
			}
			break;
		}
		return posixPath;
	}

	public static string GetFileName(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		int num = path.LastIndexOf('/');
		if (num == -1)
		{
			return path;
		}
		if (num == path.Length - 1)
		{
			return string.Empty;
		}
		return path.Substring(num + 1);
	}

	public static string GetDirectoryName(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		int num = path.LastIndexOf('/');
		switch (num)
		{
		case -1:
			return ".";
		case 0:
			return "/";
		default:
			_ = path.Length - 1;
			return path.Substring(0, num);
		}
	}
}
