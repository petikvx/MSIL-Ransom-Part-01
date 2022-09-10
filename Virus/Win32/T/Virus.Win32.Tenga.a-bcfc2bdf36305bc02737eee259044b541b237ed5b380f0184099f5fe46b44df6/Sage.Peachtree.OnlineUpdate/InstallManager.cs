using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Sage.Peachtree.OnlineUpdate;

internal class InstallManager
{
	private UpdateProgramInfoCollection m_UpdateProgramInfoCollection;

	private bool m_NeedToFillInfoCollection;

	private bool m_OneFailedToInstall;

	public InstallManager(UpdateProgramInfoCollection collection)
	{
		m_NeedToFillInfoCollection = collection == null;
		if (m_NeedToFillInfoCollection)
		{
			m_UpdateProgramInfoCollection = new UpdateProgramInfoCollection();
		}
		else
		{
			m_UpdateProgramInfoCollection = collection;
		}
	}

	public bool Run()
	{
		if (m_NeedToFillInfoCollection)
		{
			GetInfoCollection();
		}
		InstallProgramsInCollection();
		return !m_OneFailedToInstall;
	}

	private void InstallProgramsInCollection()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		ArrayList sortedArrayList = m_UpdateProgramInfoCollection.GetSortedArrayList();
		if (sortedArrayList.Count > 0 && OnlineUpdateApp.Instance.TerminalServices)
		{
			MessageBox.Show("There is a program update ready to be installed.  Please have an administrator log in and install the updates on the machine that is hosting Peachtree.", "Peachtree", (MessageBoxButtons)0, (MessageBoxIcon)64);
			m_OneFailedToInstall = true;
			return;
		}
		bool runDBConversions = GetRunDBConversions();
		bool flag = false;
		m_OneFailedToInstall = false;
		foreach (UpdateProgramInfo item in sortedArrayList)
		{
			if (WindowsVersion.IsVistaOrLater || OnlineUpdateApp.Instance.HasAdminRights || !item.RequiresAdminRights)
			{
				if (item.IsServerPatch && ServerInstallRequired())
				{
					MessageBox.Show($"There is a program update ready to be installed. The file {item.ShortDescription} must be installed on the Peachtree server before it can be installed on your computer.\n\nIf you do not have access rights to the Peachtree server, please contact your network administrator.", "Peachtree", (MessageBoxButtons)0, (MessageBoxIcon)64);
					continue;
				}
				if (item.RequiresDBConversion)
				{
					if (!HasUpdateBeenInstalledByAnyone(item))
					{
						if (!runDBConversions || flag)
						{
							continue;
						}
						if ((int)MessageBox.Show("A program update is available that requires a conversion of your Peachtree company data.  Do you want to install this update now?", "Peachtree", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
						{
							flag = true;
							RegistrySettings.WriteStringValue("Software\\Peachtree\\Online Update\\OUPaw", "DBConversionReminderStartDate", DateTime.Now.ToShortDateString());
							continue;
						}
					}
					RegistrySettings.WriteStringValue("Software\\Peachtree\\Online Update\\OUPaw", "DBConversionReminderStartDate", string.Empty);
				}
				InstallUpdateProgram(item);
				break;
			}
			MessageBox.Show("There are program updates available that require administrator rights to install.  Please have an administrator restart Peachtree to install these updates.", "Peachtree", (MessageBoxButtons)0, (MessageBoxIcon)64);
			m_OneFailedToInstall = true;
			break;
		}
	}

	private void InstallUpdateProgram(UpdateProgramInfo item)
	{
		try
		{
			string downloadFileNameFromURL = GetDownloadFileNameFromURL(item.URL);
			using Process process = new Process();
			process.StartInfo.FileName = downloadFileNameFromURL;
			if (WindowsVersion.IsVistaOrLater)
			{
				process.StartInfo.Verb = "runas";
			}
			process.Start();
		}
		catch (ArgumentException)
		{
		}
		catch (Win32Exception)
		{
		}
		catch (ObjectDisposedException)
		{
		}
	}

	private bool IsUpdateProgramInstalled(UpdateProgramInfo item)
	{
		return ProductVersionChecker.IsProductVersionInstalled(item.Section, item.Version);
	}

	private bool ValidUpdateProgramInfoForInstall(string section, string version, string url, bool isTaxUpdate)
	{
		if (isTaxUpdate)
		{
			if (!ProductVersionChecker.IsTaxUpdateInstalled(section, version))
			{
				return FileAvailableForInstall(url);
			}
			return false;
		}
		if (!ProductVersionChecker.IsProductVersionInstalled(section, version))
		{
			return FileAvailableForInstall(url);
		}
		return false;
	}

	public static bool VerifyCertificate(string filename)
	{
		bool result = false;
		X509Certificate x509Certificate = null;
		try
		{
			x509Certificate = X509Certificate.CreateFromSignedFile(filename);
			if (x509Certificate.Subject.Contains("Sage Software") || x509Certificate.Subject.Contains("Best Software") || x509Certificate.Subject.Contains("Peachtree Software"))
			{
				result = true;
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private bool FileAvailableForInstall(string url)
	{
		string downloadFileNameFromURL = GetDownloadFileNameFromURL(url);
		if (File.Exists(downloadFileNameFromURL))
		{
			return VerifyCertificate(downloadFileNameFromURL);
		}
		return false;
	}

	private string GetDownloadFileNameFromURL(string url)
	{
		string fileName = Path.GetFileName(url);
		return OnlineUpdateApp.Instance.UpdatePath + fileName;
	}

	private void GetInfoCollection()
	{
		UpdateProgramInfoCollection.FillCollectionFromINI(m_UpdateProgramInfoCollection, OnlineUpdateApp.Instance.INIFile, ValidUpdateProgramInfoForInstall);
	}

	private void AddLogFileForInstall(UpdateProgramInfo info)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(info.URL);
		fileNameWithoutExtension = OnlineUpdateApp.Instance.UpdatePath + fileNameWithoutExtension + ".log";
		if (!File.Exists(fileNameWithoutExtension))
		{
			using (StreamWriter streamWriter = File.CreateText(fileNameWithoutExtension))
			{
				streamWriter.WriteLine("-- Installed: {0}", DateTime.Now);
			}
		}
	}

	private bool GetRunDBConversions()
	{
		bool result = true;
		string text = RegistrySettings.ReadStringValue("Software\\Peachtree\\Online Update\\OUPaw", "DBConversionReminderStartDate");
		if (text != string.Empty)
		{
			try
			{
				if (DateTime.Parse(text).AddDays(15.0).CompareTo(DateTime.Today) <= 0)
				{
					return result;
				}
				result = false;
				return result;
			}
			catch (FormatException)
			{
				return result;
			}
		}
		return result;
	}

	private bool HasUpdateBeenInstalledByAnyone(UpdateProgramInfo info)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(info.URL);
		fileNameWithoutExtension = OnlineUpdateApp.Instance.UpdatePath + fileNameWithoutExtension + ".log";
		return File.Exists(fileNameWithoutExtension);
	}

	private bool ServerInstallRequired()
	{
		string lpFileName = $"{OnlineUpdateApp.Instance.DataPath}verinfo.ini";
		StringBuilder stringBuilder = new StringBuilder(1024);
		Win32.GetPrivateProfileStringA("VerInfo", "ServerType", "FULLSERVERORSTANDALONE", stringBuilder, 1024, lpFileName);
		if (stringBuilder.ToString().ToUpper().CompareTo("FULLSERVERORSTANDALONE") == 0)
		{
			return false;
		}
		Win32.GetPrivateProfileStringA("VerInfo", "Ver", "14.0.01", stringBuilder, 1024, lpFileName);
		string text = stringBuilder.ToString();
		string text2 = string.Empty;
		foreach (UpdateProgramInfo item in m_UpdateProgramInfoCollection)
		{
			if (!item.IsTaxUpdate)
			{
				text2 = item.Version;
			}
		}
		if (text2 == string.Empty)
		{
			return false;
		}
		if (text.CompareTo(text2.ToString()) != 0)
		{
			char[] array = text.ToCharArray();
			char[] array2 = text2.ToString().ToCharArray();
			int num = ((array.GetLength(0) > array2.GetLength(0)) ? array2.GetLength(0) : array.GetLength(0));
			int num2 = 0;
			while (true)
			{
				if (num2 < num)
				{
					if (array[num2].CompareTo(array2[num2]) < 0)
					{
						break;
					}
					num2++;
					continue;
				}
				return array.GetLength(0) > array2.GetLength(0);
			}
			return true;
		}
		return false;
	}
}
