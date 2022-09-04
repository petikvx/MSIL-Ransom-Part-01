using System.IO;

namespace Bytelocker.UI;

internal class TruncateFilePath
{
	public static string ShrinkPath(string file_path, int max, string delim = "…")
	{
		string fileName = Path.GetFileName(file_path);
		int length = fileName.Length;
		int length2 = file_path.Length;
		string text = file_path.Substring(0, length2 - length);
		int length3 = delim.Length;
		int num = length + length3;
		string text2 = ((file_path.IndexOf("/") > -1) ? "/" : "\\");
		if (max < num)
		{
			return delim + fileName.Substring(0, max - 2 * length3) + delim;
		}
		if (max == num)
		{
			return delim + fileName;
		}
		return text.Substring(0, max - (num + 1)) + delim + text2 + file_path;
	}
}
