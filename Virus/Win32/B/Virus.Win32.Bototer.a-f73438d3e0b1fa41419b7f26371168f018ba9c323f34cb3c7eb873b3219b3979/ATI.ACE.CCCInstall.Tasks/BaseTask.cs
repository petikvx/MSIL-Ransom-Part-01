using System;
using System.IO;
using System.Xml;

namespace ATI.ACE.CCCInstall.Tasks;

internal abstract class BaseTask
{
	protected CCCInstallLog Logger;

	public BaseTask(CCCInstallLog log)
	{
		Logger = log;
	}

	protected XmlDocument LoadXmlDocument(string path)
	{
		XmlDocument xmlDocument = null;
		try
		{
			xmlDocument = new XmlDocument();
			xmlDocument.Load(path);
			return xmlDocument;
		}
		catch (Exception e)
		{
			Logger.LogException(e, "Error loading XML file: " + path);
			return xmlDocument;
		}
	}

	protected string MassagePath(string path)
	{
		string empty = string.Empty;
		empty = path.Replace("/", "\\");
		char[] trimChars = new char[1] { '"' };
		empty = empty.Trim(trimChars);
		if (!Path.IsPathRooted(empty))
		{
			empty = Path.GetFullPath(empty);
		}
		if (!File.Exists(empty))
		{
			throw new FileNotFoundException("Could not find " + empty, path);
		}
		return empty;
	}
}
