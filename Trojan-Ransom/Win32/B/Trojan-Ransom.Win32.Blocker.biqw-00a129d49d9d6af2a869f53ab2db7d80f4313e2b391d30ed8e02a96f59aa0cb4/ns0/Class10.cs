using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using ns1;

namespace ns0;

internal class Class10
{
	internal struct Struct8
	{
		public string string_0;

		public Version version_0;

		public string string_1;

		public string string_2;

		public string method_0(bool bool_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string_0);
			if (bool_0 && version_0 != null)
			{
				stringBuilder.Append(GClass4.smethod_0("&ĩɞ\u0362Ѵն٭ݬ\u086c\u093c"));
				stringBuilder.Append(version_0);
			}
			stringBuilder.Append(GClass4.smethod_0("&ĩɋͲѪձٱݱࡧ\u093c"));
			stringBuilder.Append((string_1.Length == 0) ? GClass4.smethod_0("iţɰͰѱգ٭") : string_1);
			stringBuilder.Append(GClass4.smethod_0("=İɟͻѯՠ٢ݩࡂ७\u0a7e\u0b52౪൯\u0e66ཬ\u103c"));
			stringBuilder.Append((string_2.Length == 0) ? GClass4.smethod_0("jŶɮ\u036d") : string_2);
			return stringBuilder.ToString();
		}

		public Struct8(string string_3)
		{
			version_0 = null;
			string_1 = string.Empty;
			string_2 = string.Empty;
			string_0 = string.Empty;
			string[] array = string_3.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith(GClass4.smethod_0("^ŢɴͶѭլ٬\u073c")))
				{
					version_0 = new Version(text2.Substring(8));
				}
				else if (text2.StartsWith(GClass4.smethod_0("KŲɪͱѱձ٧\u073c")))
				{
					string_1 = text2.Substring(8);
					if (string_1 == GClass4.smethod_0("iţɰͰѱգ٭"))
					{
						string_1 = string.Empty;
					}
				}
				else if (text2.StartsWith(GClass4.smethod_0("_Żɯ\u0360Ѣթقݭ\u087e\u0952੪୯౦൬\u0e3c")))
				{
					string_2 = text2.Substring(15);
					if (string_2 == GClass4.smethod_0("jŶɮ\u036d"))
					{
						string_2 = string.Empty;
					}
				}
				else
				{
					string_0 = text2;
				}
			}
		}
	}

	internal const string string_0 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int int_0 = 4;

	private static Hashtable hashtable_0 = new Hashtable();

	internal static bool IsWebApplication
	{
		get
		{
			try
			{
				string text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
				if (text == GClass4.smethod_0("\u007fĴɱ\u0375Ъզٺݤ"))
				{
					return true;
				}
				if (text == GClass4.smethod_0("lſɻ\u0364Ѭռ\u0658ݱ\u0875प੦\u0b7a\u0c64"))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}
	}

	[DllImport("kernel32")]
	private static extern bool MoveFileEx(string string_1, string string_2, int int_1);

	internal static void smethod_0()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += smethod_1;
		}
		catch
		{
		}
	}

	internal static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Struct8 @struct = new Struct8(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = GClass4.smethod_0("ÇƓ\u02e5άӑ\u05caە\u07ae\u08d4৴\u0ad6\u0bfe\u0cdaශ\u0ecd\u0febოᇆዙᏻᓀᗊᛉ៲ᣅ᧚\u1ab8᮲\u1cdc\u1dd1ỠῨ\u20ce⇖⋕⍋\u2433┪☺✗⠵⤽⨱⬏ⰸⴏ⸱⽇〿ㄹ㉀㌜㐧㔨㘢㝚㠈㤡㨺㭖㰅㴈㸱㽚䀀䄌䈶䍮䐺䔕䘖䜳䠸䤚䨯䬰䰃䴝丂伺倰儖刼匥吝啿嘚坾堜夎婱嬵尜崒幰彺怏慳戕挎摰敗晱朊桷楽橡欂汻洇湭漀灿煋牥猞瑴畼瘑眖砆祲穒筺籝紒繁缗耕脒舙荻葺蔰蘫蜨蠯西訵謣谢赱踧輾遳鄣鉲鍪鐣镫陭霿頲餺驩鬴鰳鴰鹦鼰ꀷꅼ").Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			lock (hashtable_0)
			{
				if (hashtable_0.ContainsKey(text2))
				{
					return (Assembly)hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class19.smethod_1(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = string.Format(GClass4.smethod_0("|ĶɸͿвտ\u065d"), Path.GetTempPath(), text2);
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + GClass4.smethod_0("*ŧɮ\u036d");
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								MoveFileEx(text5, null, 4);
								MoveFileEx(text4, null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}
}
