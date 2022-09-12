using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace RunDll_4;

internal class Win32
{
	[DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string localName, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder remoteName, ref int length);

	public static string GetUNCPath(string originalPath)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		int length = stringBuilder.Capacity;
		if (originalPath.Length > 2 && originalPath[1] == ':')
		{
			char c = originalPath[0];
			if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) && WNetGetConnection(originalPath.Substring(0, 2), stringBuilder, ref length) == 0)
			{
				new DirectoryInfo(originalPath);
				string path = Path.GetFullPath(originalPath).Substring(Path.GetPathRoot(originalPath)!.Length);
				return Path.Combine(stringBuilder.ToString().TrimEnd(new char[0]), path);
			}
		}
		return originalPath;
	}
}
