namespace Renci.SshNet.Common;

internal class PosixPath
{
	public static string GetFileName(string path)
	{
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
}
