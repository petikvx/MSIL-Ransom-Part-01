using System;
using System.IO;
using System.Net;

internal class UpdateProgram
{
	private string Url;

	private string UrlAlternative;

	private string WorkspacePath;

	private string CurrentVersion;

	public UpdateProgram(string DownloadUrl, string urlAlternative, string Workspace_Path, string ProgramCurrentVersion)
	{
		Url = DownloadUrl;
		WorkspacePath = Workspace_Path;
		CurrentVersion = ProgramCurrentVersion;
		UrlAlternative = urlAlternative;
	}

	private void DownloadFile(string Url, string SavePath)
	{
		WebClient webClient = new WebClient();
		Uri address = new Uri(Url);
		webClient.DownloadFile(address, SavePath);
	}

	public bool Update()
	{
		try
		{
			File.Delete(WorkspacePath + "\\update_info.txt");
			try
			{
				DownloadFile(Url, WorkspacePath + "\\update_info.txt");
			}
			catch
			{
				File.Delete(WorkspacePath + "\\update_info.txt");
				DownloadFile(UrlAlternative, WorkspacePath + "\\update_info.txt");
			}
			StreamReader streamReader = new StreamReader(WorkspacePath + "\\update_info.txt");
			string text = streamReader.ReadLine();
			string text2 = streamReader.ReadLine();
			streamReader.Close();
			File.Delete(WorkspacePath + "\\update_info.txt");
			if (text != CurrentVersion && text2.Length > 0)
			{
				File.Delete(WorkspacePath + "\\handyware_newversion.exe");
				DownloadFile(text2, WorkspacePath + "\\handyware_newversion.exe");
				return true;
			}
			return false;
		}
		catch (SystemException)
		{
			return false;
		}
	}
}
