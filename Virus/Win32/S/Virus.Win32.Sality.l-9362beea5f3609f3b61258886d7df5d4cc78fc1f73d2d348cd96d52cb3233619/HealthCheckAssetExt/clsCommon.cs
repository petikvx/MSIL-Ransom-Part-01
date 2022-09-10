using System;
using System.IO;
using System.Text;
using Microsoft.Win32;

namespace HealthCheckAssetExt;

internal class clsCommon
{
	internal void writeXML(string strXMLNet, string strFileName)
	{
		StreamWriter streamWriter = null;
		StreamWriter streamWriter2 = null;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\" + set64BitPath() + "Hewlett-Packard\\CPSS\\HPAsset");
			string text = (string)registryKey.GetValue("Path");
			streamWriter = File.CreateText(text + strFileName);
			streamWriter.Close();
			streamWriter.Dispose();
			streamWriter = null;
			streamWriter2 = new StreamWriter(text + strFileName, append: false, Encoding.UTF8);
			streamWriter2.Write(strXMLNet);
			streamWriter2.Close();
			streamWriter2.Dispose();
			streamWriter2 = null;
		}
		catch
		{
			try
			{
				if (streamWriter != null)
				{
					streamWriter.Close();
					streamWriter.Dispose();
				}
			}
			catch
			{
			}
			try
			{
				if (streamWriter2 != null)
				{
					streamWriter2.Close();
					streamWriter2.Dispose();
				}
			}
			catch
			{
			}
		}
	}

	internal string set64BitPath()
	{
		try
		{
			string result = "";
			if (Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Hewlett-Packard\\HPActiveSupport") != null)
			{
				result = "Wow6432Node\\";
			}
			return result;
		}
		catch
		{
			return "";
		}
	}

	internal bool IsNumeric(object num)
	{
		try
		{
			Convert.ToDouble(num);
			return true;
		}
		catch
		{
			return false;
		}
	}
}
