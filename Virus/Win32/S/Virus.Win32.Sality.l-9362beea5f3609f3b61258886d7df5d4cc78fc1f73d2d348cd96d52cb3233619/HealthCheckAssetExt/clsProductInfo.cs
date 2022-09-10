using System;
using System.IO;
using Microsoft.Win32;

namespace HealthCheckAssetExt;

internal class clsProductInfo
{
	private clsCommon com = new clsCommon();

	private string strCpcPrimaryBrand;

	internal void addProductInfo(string strClassName, string strGuid, string strFileName)
	{
		try
		{
			string text = "";
			string text2 = "<PROPERTY NAME=\"CPCServiceID\" TYPE=\"string\"><VALUE>" + getCpcServiceID() + "</VALUE></PROPERTY><PROPERTY NAME=\"CPCModelNumber\" TYPE=\"string\"><VALUE>" + getCPCModelNumber() + "</VALUE></PROPERTY><PROPERTY NAME=\"NPCServiceID\" TYPE=\"string\"><VALUE>" + getNpcServiceID() + "</VALUE></PROPERTY><PROPERTY NAME=\"CPCSoftwareBuild\" TYPE=\"string\"><VALUE>" + getCpcSoftwareBuild() + "</VALUE></PROPERTY><PROPERTY NAME=\"CPCPrimaryBrand\" TYPE=\"string\"><VALUE>" + strCpcPrimaryBrand + "</VALUE></PROPERTY><PROPERTY NAME=\"SystemFirstBootDate\" TYPE=\"string\"><VALUE>" + determineSystemFirstBootDate() + "</VALUE></PROPERTY>";
			text = "<SIMPLEREQ><IMETHODCALL NAME=\"CreateInstance\"><LOCALNAMESPACEPATH><NAMESPACE NAME=\"root\" /><NAMESPACE NAME=\"cimv2\" /></LOCALNAMESPACEPATH><IPARAMVALUE NAME=\"NewInstance\"><INSTANCE CLASSNAME=\"" + strClassName + "\"><QUALIFIER NAME=\"ModTime\" TYPE=\"datetime\"><VALUE>20060608114719.538000+180</VALUE></QUALIFIER><PROPERTY NAME=\"Index\" TYPE=\"uint32\"><VALUE>0</VALUE></PROPERTY><PROPERTY NAME=\"GUID\" TYPE=\"string\"><VALUE>" + strGuid + "</VALUE></PROPERTY>" + text2 + "</INSTANCE></IPARAMVALUE></IMETHODCALL></SIMPLEREQ>";
			com.writeXML(text, strFileName);
		}
		catch
		{
		}
	}

	private string getCPCModelNumber()
	{
		string result = "";
		try
		{
			RegistryKey registryKey = Registry.Users.OpenSubKey(".DEFAULT\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders\\HPQware");
			if (registryKey != null)
			{
				string path = (string)registryKey.GetValue("RStonePost");
				if (File.Exists(path))
				{
					using (StreamReader streamReader = new StreamReader(path))
					{
						string text;
						while ((text = streamReader.ReadLine()) != null)
						{
							if (text.StartsWith("ModelNumber="))
							{
								result = text.Replace("ModelNumber=", "");
							}
							if (text.StartsWith("PCBRAND="))
							{
								strCpcPrimaryBrand = text.Replace("PCBRAND=", "").ToUpper();
								if (strCpcPrimaryBrand == "PAVILION")
								{
									strCpcPrimaryBrand = "HP";
								}
								else if (strCpcPrimaryBrand == "PRESARIO")
								{
									strCpcPrimaryBrand = "CPQ";
								}
								else
								{
									strCpcPrimaryBrand = "";
								}
							}
						}
						return result;
					}
				}
				return result;
			}
			return result;
		}
		catch
		{
			return "";
		}
	}

	private string getCpcServiceID()
	{
		string result = "";
		try
		{
			if (File.Exists(Environment.SystemDirectory + "\\hpsysdrv.dat"))
			{
				using (StreamReader streamReader = new StreamReader(Environment.SystemDirectory + "\\hpsysdrv.dat"))
				{
					string text;
					while ((text = streamReader.ReadLine()) != null)
					{
						if (text.StartsWith("HPServiceID="))
						{
							result = text.Replace("HPServiceID=", "");
						}
					}
					return result;
				}
			}
			return result;
		}
		catch
		{
			return "";
		}
	}

	private string getCpcSoftwareBuild()
	{
		string result = "";
		try
		{
			if (File.Exists("c:\\hp\\support\\build.txt"))
			{
				result = File.ReadAllText("c:\\hp\\support\\build.txt");
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	private string getNpcServiceID()
	{
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\" + com.set64BitPath() + "Hewlett-Packard\\HPActiveSupport\\HPSI");
			if (registryKey != null)
			{
				object value = registryKey.GetValue("ServiceID");
				text = (string)value;
				if (text == null || text == "")
				{
					text = encodeBootDate(determineSystemFirstBootDate());
					Registry.LocalMachine.OpenSubKey("Software\\" + com.set64BitPath() + "Hewlett-Packard\\HPActiveSupport\\HPSI", writable: true)!.SetValue("ServiceID", text);
				}
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	private string encodeBootDate(string strFirstBootDate)
	{
		try
		{
			DateTime dateTime = DateTime.Parse(strFirstBootDate);
			int num = dateTime.Year - 1990;
			return string.Concat(str1: ((dateTime.Month - 1) * 30 + dateTime.Day).ToString().PadLeft(3, '0'), str0: num.ToString().PadLeft(2, '0'));
		}
		catch
		{
			return "";
		}
	}

	private string determineSystemFirstBootDate()
	{
		string text = ",";
		DateTime dateTime = default(DateTime);
		try
		{
			char[] separator = text.ToCharArray();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\";
			string[] array = null;
			string searchPattern = "103C_HP*.MRK";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			_ = directoryInfo.GetFileSystemInfos(searchPattern).Length;
			FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos(searchPattern);
			int num = 0;
			if (0 >= fileSystemInfos.Length)
			{
				return "";
			}
			FileSystemInfo fileSystemInfo = fileSystemInfos[num];
			using (StreamReader streamReader = new StreamReader(fileSystemInfo.FullName))
			{
				string text2 = streamReader.ReadToEnd();
				array = text2.Split(separator);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == "BornOnDate")
					{
						return array[i + 1].Substring(0, 10);
					}
				}
			}
			return fileSystemInfo.CreationTime.ToShortDateString();
		}
		catch
		{
			return "";
		}
	}
}
