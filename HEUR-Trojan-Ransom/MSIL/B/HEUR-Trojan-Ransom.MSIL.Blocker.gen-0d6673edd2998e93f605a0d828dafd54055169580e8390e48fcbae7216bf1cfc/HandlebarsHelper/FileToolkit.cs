using System.IO;

namespace HandlebarsHelper;

public class FileToolkit
{
	public static string PathDifference(string filePath, string directory)
	{
		string fileName = Path.GetFileName(filePath);
		string text = filePath.Substring(directory.Length);
		return text.Substring(0, text.Length - fileName.Length);
	}
}
