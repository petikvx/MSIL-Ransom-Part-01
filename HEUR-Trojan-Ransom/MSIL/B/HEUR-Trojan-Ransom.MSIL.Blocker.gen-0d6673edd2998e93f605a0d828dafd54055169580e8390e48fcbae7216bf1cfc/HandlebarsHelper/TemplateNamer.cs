using System;
using System.IO;

namespace HandlebarsHelper;

public class TemplateNamer : ITemplateNamer
{
	private readonly char[] DirectorySeparator;

	public TemplateNamer()
	{
		DirectorySeparator = new char[1] { Path.DirectorySeparatorChar };
	}

	public string GenerateName(string bundleRelativePath, string fileName)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
		string[] value = bundleRelativePath.Split(DirectorySeparator, StringSplitOptions.RemoveEmptyEntries);
		string text = string.Join("/", value);
		if (!text.EndsWith(fileNameWithoutExtension))
		{
			if (!string.IsNullOrEmpty(text))
			{
				text += "/";
			}
			text += fileNameWithoutExtension;
		}
		return text;
	}
}
