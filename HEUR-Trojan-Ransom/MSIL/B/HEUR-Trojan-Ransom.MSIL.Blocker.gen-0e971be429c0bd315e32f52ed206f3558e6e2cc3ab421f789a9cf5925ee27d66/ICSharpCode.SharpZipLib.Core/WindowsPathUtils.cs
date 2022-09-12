namespace ICSharpCode.SharpZipLib.Core;

public abstract class WindowsPathUtils
{
	internal WindowsPathUtils()
	{
	}

	public static string DropPathRoot(string path)
	{
		if (path == null || path.Length <= 0)
		{
			return path;
		}
		if (path[0] != '\\' && path[0] != '/')
		{
			if (path.Length <= 1 || path[1] != ':')
			{
				return path;
			}
			int count = 2;
			if (path.Length > 2 && (path[2] == '\\' || path[2] == '/'))
			{
				count = 3;
			}
			return path.Remove(0, count);
		}
		if (path.Length <= 1 || (path[1] != '\\' && path[1] != '/'))
		{
			return path;
		}
		int i = 2;
		int num = 2;
		for (; i <= path.Length; i++)
		{
			if ((path[i] == '\\' || path[i] == '/') && --num <= 0)
			{
				break;
			}
		}
		i++;
		if (i >= path.Length)
		{
			return "";
		}
		return path.Substring(i);
	}
}
