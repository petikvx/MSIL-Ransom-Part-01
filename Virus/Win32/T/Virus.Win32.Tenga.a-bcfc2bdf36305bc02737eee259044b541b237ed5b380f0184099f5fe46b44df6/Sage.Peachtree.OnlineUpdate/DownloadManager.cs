using System;
using System.IO;
using System.Net;
using Microsoft.VisualBasic;

namespace Sage.Peachtree.OnlineUpdate;

internal class DownloadManager
{
	private UpdateProgramInfo m_CurrentDownloadItem;

	private UpdateProgramInfoCollection m_UpdateProgramInfoCollection;

	public UpdateProgramInfoCollection Collection => m_UpdateProgramInfoCollection;

	public DownloadManager()
	{
		m_UpdateProgramInfoCollection = new UpdateProgramInfoCollection();
	}

	public bool Run()
	{
		DownloadINIFile();
		LoadDownloadInfoForFlavor();
		DownloadFilesFromInfo();
		return true;
	}

	private bool DownloadFile(string urlToDownload, string destinationFile)
	{
		if (File.Exists(destinationFile))
		{
			File.Delete(destinationFile);
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(urlToDownload);
		httpWebRequest.KeepAlive = true;
		try
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			try
			{
				byte[] buffer = new byte[1024];
				Stream responseStream = httpWebResponse.GetResponseStream();
				if (File.Exists(destinationFile))
				{
					File.Delete(destinationFile);
				}
				Stream stream = File.OpenWrite(destinationFile);
				int num;
				while ((num = (num = responseStream.Read(buffer, 0, 1024))) > 0)
				{
					stream.Write(buffer, 0, num);
				}
				responseStream.Close();
				stream.Close();
			}
			finally
			{
				httpWebResponse.Close();
			}
			return File.Exists(destinationFile) && InstallManager.VerifyCertificate(destinationFile);
		}
		catch (WebException)
		{
			return false;
		}
	}

	private string PTEncryptString(string sSource, string sKey)
	{
		string text = string.Empty;
		int length = sSource.Length;
		int length2 = sKey.Length;
		for (int i = 0; i < length; i++)
		{
			int startIndex = i % length2;
			text += Strings.Chr(Strings.Asc(sSource.Substring(i, 1)) ^ Strings.Asc(sKey.Substring(startIndex, 1)));
		}
		return text;
	}

	private string QAUrl(string url)
	{
		string result = url;
		string text = RegistrySettings.ReadStringValue("Software\\Peachtree\\Online Update\\OUPaw", "QA");
		string text2 = "";
		if (text.Length > 0)
		{
			for (int i = 0; i < text.Length - 1; i += 2)
			{
				int num = (Strings.Asc("@") - Strings.Asc(text.Substring(i, 1))) * 16;
				num = num + Strings.Asc("t") - Strings.Asc(text.Substring(i + 1, 1));
				text2 += Strings.Chr(num);
			}
			string sKey = DateTime.Now.ToString("ddMMyy");
			text2 = PTEncryptString(text2, sKey);
			if (Strings.Right(text2, 1) == "/" && Strings.Left(text2, 7) == "http://")
			{
				result = text2;
				url = url.Substring(7);
				url = url.Substring(Strings.InStr(url, "/", (CompareMethod)0));
				result += url;
			}
		}
		return result;
	}

	private void DownloadINIFile()
	{
		string text = QAUrl($"http://updates.peachtree.com/oupaw{OnlineUpdateApp.Instance.MajorBuildNumber}.ini");
		string text2 = OnlineUpdateApp.Instance.UpdatePath + Path.GetFileNameWithoutExtension(text) + ".ini";
		if (File.Exists(text2))
		{
			string text3 = OnlineUpdateApp.Instance.UpdatePath + $"{Path.GetFileNameWithoutExtension(text)}.old";
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			File.Move(text2, text3);
		}
		DownloadFile(text, text2);
	}

	private void LoadDownloadInfoForFlavor()
	{
		m_UpdateProgramInfoCollection.Clear();
		UpdateProgramInfoCollection.FillCollectionFromINI(m_UpdateProgramInfoCollection, OnlineUpdateApp.Instance.INIFile, ValidUpdateProgramInfoForDownload);
	}

	private bool ValidUpdateProgramInfoForDownload(string section, string version, string url, bool isTaxUpdate)
	{
		if (isTaxUpdate)
		{
			return !ProductVersionChecker.IsTaxUpdateInstalled(section, version);
		}
		return !ProductVersionChecker.IsProductVersionInstalled(section, version);
	}

	private void PostDownloadItem(bool successfulDownload)
	{
		UpdateINIFileDownload(successfulDownload);
		NotifyDownloadTracking(successfulDownload);
	}

	private void UpdateINIFileDownload(bool successfulDownload)
	{
		if (successfulDownload)
		{
			Win32.WritePrivateProfileStringA(m_CurrentDownloadItem.Section, "Downloaded", "1", OnlineUpdateApp.Instance.INIFile);
		}
		else
		{
			Win32.WritePrivateProfileStringA(m_CurrentDownloadItem.Section, "Downloaded", "0", OnlineUpdateApp.Instance.INIFile);
		}
	}

	private void NotifyDownloadTracking(bool successfulDownload)
	{
		UpdateTracker updateTracker = new UpdateTracker(OnlineUpdateApp.Instance.Flavor, OnlineUpdateApp.Instance.BuildNumber, m_CurrentDownloadItem.ShortDescription);
		if (successfulDownload)
		{
			updateTracker.PostUpdateProgramDownloadSuccessfull();
		}
		else
		{
			updateTracker.PostUpdateProgramDownloadFailed();
		}
	}

	private void DownloadFilesFromInfo()
	{
		foreach (UpdateProgramInfo item in m_UpdateProgramInfoCollection)
		{
			UpdateProgramInfo updateProgramInfo = (m_CurrentDownloadItem = item);
			if (!updateProgramInfo.IsTaxUpdate || OnlineUpdateApp.Instance.RegisteredForTaxUpdates)
			{
				string fileName = Path.GetFileName(updateProgramInfo.URL);
				string text = OnlineUpdateApp.Instance.UpdatePath + fileName;
				if (!File.Exists(text))
				{
					PostDownloadItem(DownloadFile(updateProgramInfo.URL, text));
				}
			}
		}
	}
}
