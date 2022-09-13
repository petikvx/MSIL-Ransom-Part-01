using System.Runtime.InteropServices;

namespace youknowcaliber;

public class Files
{
	public static int count;

	public static extern void GetFiles();

	private static extern long GetDirSize(string path, [Optional] long size);

	public static extern void CopyDirectory(string source, string target, string pattern, long maxSize);

	public extern Files();
}
