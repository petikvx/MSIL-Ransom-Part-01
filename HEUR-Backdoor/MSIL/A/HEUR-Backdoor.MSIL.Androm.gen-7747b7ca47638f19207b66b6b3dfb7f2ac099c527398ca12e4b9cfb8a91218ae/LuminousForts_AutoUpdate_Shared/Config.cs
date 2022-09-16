using System;
using System.Collections.Generic;
using System.IO;

namespace LuminousForts_AutoUpdate_Shared;

public class Config
{
	private string ConfigFile = "config.txt";

	private Dictionary<string, string> props;

	public string SVNPath => AddDirectoryEnding(props["svn_path"]);

	public string LuminousFortsPath => AddDirectoryEnding(props["game_folder"]);

	public string HLDSCommand => props["hlds_command"];

	public string HLDSWorkDir => AddDirectoryEnding(props["hlds_workdir"]);

	public int UpdateInterval => int.Parse(props["update_interval"]);

	public Dictionary<string, string> Properties
	{
		get
		{
			return props;
		}
		set
		{
			props = value;
		}
	}

	public Config()
	{
		props = new Dictionary<string, string>();
	}

	public void LoadConfig()
	{
		StreamReader streamReader = new StreamReader(ConfigFile);
		string text = streamReader.ReadToEnd();
		streamReader.Close();
		string[] array = text.Split(new char[1] { '\n' });
		foreach (string text2 in array)
		{
			string[] array2 = text2.Split(":".ToCharArray(), 2, StringSplitOptions.None);
			if (!props.ContainsKey(array2[0]))
			{
				if (array2.Length >= 2)
				{
					props.Add(array2[0].Trim(), array2[1].Trim());
				}
				else if (array2.Length == 1)
				{
					props.Add(array2[0].Trim(), "");
				}
			}
		}
		props["svn_path"] = SVNPath;
		props["game_folder"] = LuminousFortsPath;
		props["hlds_workdir"] = HLDSWorkDir;
	}

	public void WriteConfig()
	{
		StreamWriter streamWriter = new StreamWriter(ConfigFile);
		foreach (KeyValuePair<string, string> prop in props)
		{
			streamWriter.WriteLine(prop.Key + ":" + prop.Value);
		}
		streamWriter.Close();
	}

	private static string AddDirectoryEnding(string path)
	{
		string text = path.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar);
		string text2 = text;
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		if (!text2.EndsWith(directorySeparatorChar.ToString()))
		{
			string text3 = text;
			directorySeparatorChar = Path.DirectorySeparatorChar;
			text = text3 + directorySeparatorChar;
		}
		return text;
	}
}
