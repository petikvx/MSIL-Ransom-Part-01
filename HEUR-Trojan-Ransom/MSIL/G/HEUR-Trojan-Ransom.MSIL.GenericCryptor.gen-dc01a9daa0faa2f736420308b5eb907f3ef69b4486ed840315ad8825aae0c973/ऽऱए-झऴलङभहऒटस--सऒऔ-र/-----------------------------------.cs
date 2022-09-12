using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Automation.Text;
using System.Windows.Input;
using ATGTestInput;
using InternalHelper;
using InternalHelper.Tests;
using MS.Win32;
using Microsoft.Data.Entity.Design;
using Microsoft.Data.Entity.Design.VisualStudio;
using Microsoft.Data.Entity.Design.VisualStudio.Package;
using Microsoft.Test.UIAutomation.Core;
using Microsoft.Test.UIAutomation.Logging;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace ऽऱए_093Eझऴलङभहऒटस_0940_093Cसऒऔ_093Aर;

internal static class _2303_2313_22ED_22FE_231A_2315_2324_231E_2306_231A_22FF_22F6_2306_231B_2302_22ED_231F_22F9_2314_2317_2321_2324_2305_22F3_22F8_2306_22FA_230F_22FF_2304_22FF_2322_22F6_22F9_2314
{
	private static IEdmPackage 〼_3023_3013_3010い_3036_3015_3012_3020〲_3019_3037_3014う_3037_3023〼_3039ぁ;

	public const string 셩셫셛셥셓셯셷셆셶셐셻셫셒셲셖셋셰셗셩셪셛셧셓셾셮셊셬셵셪셩셋셰셉셞셊셫셝셉 = null;

	public const string _2F46_2F2A_2F40_2F46_2F41_2F21_2F1F_2F50_2F4D_2F21_2F1C_2F23_2F4F_2F40_2F47_2F48_2F3C_2F4D_2F51_2F2B = null;

	public const string 昄昃昗明昆昍旣旰早旬旪早昇旵昒旳旲旪旵旧昌旱旫日昗昍昇易旮日旰旤旯日昊旯旫旺昃 = null;

	public const string 較軧軫軶軴輂輐輌軷輖輌軪 = null;

	public const string 搎揽搑搖揵揷搊損搆搇揺搊揷揥揯揦搋揵揪搜揧搉揲揮搘揹揷搙搔搖搈揽揦揨揹搙揶搋搒揶揨揫揽揱搋揱揤搘搒 = null;

	public const string 㕧㕨㕋㕺㕬㕇㕫㕺㕛㕰㕒㕏㕕㕪㕴㕛㕓㕪㕳㕍㕽 = null;

	public const string _0952ॠॿ_0957फ़ॴ_0970ॺ२३ॠ = null;

	public const string 펍펌펠펅펊펂펢펙펛펊펍펠퍾 = null;

	public const string ꡘꡒ_A875ꡠꡒꡋꡛꡟ_A87Fꡒꡖꡲꡗꡛꡖꡑꡔꡗꡳ_A87Dꡗꡪ_A876ꡍꡠ_A876ꡱꡎꡭꡉꡎ_A878_A87D_A87A = null;

	public const string ԝԳԽՇԱԧԚԳՉԐՅԷԿԹԸՂՄ_0530ԘԩՃԛԿԙՀՂԸԷԤԞՆԻ = null;

	public const string ೠഓഋഄഒ_0CFEೲഄ_0CFFഒ೭ = null;

	public const string _E8B2_E897_E8B3_E8AF_E896_E8A1_E8B2_E89A_E88F_E88A_E883_E8A9_E8B2_E887_E8B3 = null;

	public const string 欣欒欙欦欣欼欐欗欮欸欤欗欜欼欻歃欕欧 = null;

	public const string 갱갵갻갯걇걎갹갸걋갴갳갮걅걐갣갮갷걉걄걖갫걏갬걆걗걑갻걗걑갯갬갩갸걇걄갦갹갵 = null;

	public const string 㒾㒠㒨㒭㓎㓀㓆㒡㓕㒨㒜㒳㒽㓂㒡㓋㒥㒲㓈㒞㒣㓑㓄 = null;

	public const string 㚀㚈㚝㚇㙿㚒㚩㚑㚀㚇㚦㚢㚊 = null;

	public const string _33D5_33CB_33D3_33D9_33F7_33F4_33D4_33E0_33E4㐂_33F9_33F4_33D7_33DA_33ED_33F0㐀 = null;

	public const string _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD = null;

	public const string 숽숭숕숨숭숤순숕숦술숿 = null;

	public const string 薯薾藅藂薮藀藋薰藀薫藅薪薧薮藋藎薡薨薞藁藆藉藊藑 = null;

	public const string 囘圆囷固囕囿四圇圁囸因囔囘囸圇囱囟圄囟囝囹囶囐 = null;

	public const string _EB13_EB24_EB28_EB24_EB02_EB0A_EB12_EB08_EB2B_EB2F_EB0D_EB06_EB0D_EB23_EB0E_EB1D_EB28_EB34_EB20_EB36_EB14_EB1E_EB2D_EB02_EB22_EB32_EB0E_EB32_EB02_EB2D_EAFE = null;

	public const string 輻都侮福炙見宅鶴嗀廓飼行茶﨩益逸﨏宅﨏度隷降 = null;

	public const string ꁝꁌꀺꁱꁢꁍꁱꁝꁐꁈꁌꁋꀸꀿꁅꁭꁪꁂꀿꀻꁛꀿꁱꁏꁅꁬꀻꁮꁊꁪꁉꁯꁐꁨꁫꁡꁚꁫꀻꀸꁮꁆꁭꁘꁅꁱꀾꁣꁩ = null;

	public const string 쓿쓯씎쓴씗씔쓣쓫쓮씐씁씌쓤쓸씕쓳씉씌쓢씒쓷씅씆씅씍씊씗씈씌쓳쓶씊쓟쓪쓯쓦쓨씔쓴쓬씖쓦 = null;

	public const string 峬峷峅峔峥峴峈峳峷峋峛峋峗峌峬峊峰峛峸峼峘峸峕峐峘峬峓峯峒峵峓峚峵 = null;

	public const string 눦눚눛뉃뉅눡눗눓눒눑눐눲눤눦눏눜눖눞눰눷눡눛눐눜눣눠눏뉁눎눯눟눯눾눏 = null;

	public const string _EC48_EC25_EC24_EC4C_EC14_EC22_EC41_EC23_EC40_EC3D_EC23_EC3E_EC23_EC1C_EC33_EC1C_EC2C_EC26_EC3B_EC4C_EC3D_EC3C_EC2C_EC4C_EC17_EC45_EC42_EC38_EC15_EC1E_EC13_EC20_EC48_EC41_EC38 = null;

	public const string ⵗ_2D76ⵇ_2D79ⵊⵝ_2D75ⵊ_2D6Bⵍⵐⵏⵆ_2D78ⵘ_2D6E_2D6Dⵧ_2D7F_2D71ⵙ_2D77ⵛ = null;

	public const string 햄해핸핌핔항핚핍핏핯 = null;

	public const string 楽榧榃榉榢榉榪榩榌楽楺榟榈榧楻榨榄榈榗極榪榦榉 = null;

	public const string 帡带帬帻帩帿帽幍帘幂帧 = null;

	public const string 핒핖한핣핂핃픫픿픯핍픳핛할픸픵핌핛하핋픿핤픮핐픫핛핑픫핔픵픳픭하핗픮픬픮핢피핋 = null;

	public const string ꇎꇭꇋꇏꇽꇼꇻꇱꇞꇗꈀꇏꇴꇟ = null;

	public const string ꁱꂀꂓꂔꂒꁹꁮꂈꂉꂘꁭꁰꂉꁴꁨꁷꁹꁷꁨꁪꂅꂆꁯꁠꁬꁭꁮꁤꁵꂏꁦꁶꁥꁱ = null;

	internal const string 鯜鯔鯌鮵鯟鯒鯐鯑鮻鯜鯌鮬鮪鮿鮰鯒鯆鮽鯍鮺鯓 = null;

	internal const string _E7E3_E7FE_E7F2_E804_E7D5_E7FF_E7E4_E7E3_E7E2_E7FC_E803_E7FE_E7FC_E7DA_E7E4_E7F8_E7FA_E809_E7E6 = null;

	internal const string ᰕ_1C25ᰈ_1C29_1C2Cᰇ_1C2C_1C25ᰇᰚ_1C39ᰙ_1C34ᰒ_1C37ᰕᰐ = null;

	internal const string 쎪쎸쏓쏅쎦쎶쏐쏒쎯쏃쏔쎴쎰쎪쎻쏔쎮쎰쎨쎶쏋쎺쏅쎱쏎쎴 = null;

	internal const string 녔넴녔녍녀녓년넰넸넣넯녙넫넲넴넱녉넫넬녊넯넷녀년넦녌넴넶넩넳넡넱넫녆넳녕녓넭녑녙 = null;

	public const int 伶佄伳伺体伹佅佒佋伷佈佝伬似佛伸 = default(int);

	public const int 咾哅哰哞哛哘哏哄咻哐哯哬哪哤咷哎哢哟哨 = default(int);

	public const int ߡߖߐߨࠅࠀ_07F2_07F7ࠅߐ_07F2ߵߒߨߑߙߥߜߦߑ_07FF_07F0ߟߘࠇߚߺ_07F7 = default(int);

	public const int 䥰䥀䥞䥦䥮䤽䤷䤼䥜䤼䤽䥁䥭䤺䥎䥬 = default(int);

	public const int ゴビソパテポハゴヅザシウグナズニセシズサニプテナサヌフザジボシヒ = default(int);

	public const int 쥩쥪쥼쥢즋쥽쥩쥓즉쥢쥛쥠쥗쥧쥔쥢즂쥚쥸즌즊쥛쥨쥩쥺쥽즃쥦쥪쥹즆쥫쥗즄 = default(int);

	internal static string ᒉᑬᒒᒘᑨᑺᒑᑫᑤᒓᒒᒍᒎᑰᒃᑥᑱᑮᑯᑬᒎᒂᒎᑨᒏᑵᒄᑤᒐᒖᑫᒉᒍᒆᒔᒄᑸᒊᒙᑡᒈᑹᒓᑤᑰᑸᒃ;

	public const string 絢結絑絹絞絓絏絴綅絘絷絛絤絚綂絵絖絷絮絶綄給絕絔絽絼絒絼絗絠絾絟絧絗絛絠 = null;

	public const string ꃆꂜꂘꃂꂛꃂꂵꂟꂙꃊꂙꂿꂪꂚꂬꂩꂜꂪꂫꂪꂗꂶꃂꃋꂢꂧꂫꂸꂛꃄꂾꂦꃇꂙꂾꃇꃈ = null;

	public const string _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD = null;

	public const int 覤覷覺覦觚覺覦觐覯觔覦观覮觎觓覡覹觙覰觃覱覭覥觃觙覯覧覴觋角覧觌覸覭覮覵観覰覩覰觃规觉 = default(int);

	public const int _F4CD_F4B3_F4B8_F4C9_F4CC_F4C9_F4A9_F4B8_F4A9_F4B7_F4C9_F4B7_F4D8_F4BD_F4CE_F4B1_F4DA_F4B2_F4CB_F4DE_F4B3_F4DB_F4CB_F4C7_F4A7_F4DF_F4AE_F4D0_F4B6_F4C7_F4B3_F4AA_F4C9_F4BD_F4B3 = default(int);

	[STAThread]
	private static void 뿯쀆뿤뿹뿢뿑뿏뿯뿼쀀쀄뿰뿯뿴뿭뿮()
	{
		//Discarded unreachable code: IL_0008, IL_0018, IL_0028, IL_0047, IL_0061, IL_0062, IL_0063, IL_0069, IL_006f, IL_0070, IL_0071, IL_0077, IL_007d, IL_0097, IL_00c0, IL_00e4, IL_014e, IL_01e0, IL_01e6, IL_01f1, IL_022e, IL_027a, IL_0280
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		_E3D4_E3FD_E3CF_E3E4_E3EE_E3E4_E3D2_E3F3_E3D4_E3EE_E3CD_E3E3_E3FB_E3DF_E3FF_E3F7_E3F3_E3CE_E3E0_E3EF_E3D6_E404_E3F6_E3CF_E3D1_E402._104E_1059၄_104Cၸၛၰ၈ၯၺ_104A_1058ၥၶၯၻၺ၇_106B၉ၮ_106Aၚၛ၉_104A_106Aၛၕ_106Aၜၵ၈_1068_1058ၯ_106Bၶ_106Aၜ();
	}

	internal static void 耣耤耔耀耑耚耡耤耎耡耣者耙耒翺耣翾翺老耛翼老耜耡翲耛耄翻翽耟耂耛翴耄耔耟翴翽()
	{
		if (〼_3023_3013_3010い_3036_3015_3012_3020〲_3019_3037_3014う_3037_3023〼_3039ぁ == null)
		{
			object globalService = Package.GetGlobalService(typeof(SVsShell));
			_E010_FFFD_FFFD_E011_E020_FFFD_E01B_E015_E018_FFFD_FFFD_E01F_E011_E016((IVsShell)((globalService is IVsShell) ? globalService : null));
		}
	}

	internal static void 鲔鲨鱶鲁鲟鲔鲠鲞鱴鲞鲚鲕鲦鱵鱲鲛鱲鱸鱷鲕鲥鱷鲜鱳鲒鲇鲦鱾鲝鲧鲔鲓鱾鱺鲤鲝鲧鲔鱯鲇鱸鲙鱯(IServiceProvider P_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		if (〼_3023_3013_3010い_3036_3015_3012_3020〲_3019_3037_3014う_3037_3023〼_3039ぁ == null)
		{
			IVsShell val = (IVsShell)P_0.GetService(typeof(SVsShell));
			if (val != null)
			{
				_E010_FFFD_FFFD_E011_E020_FFFD_E01B_E015_E018_FFFD_FFFD_E01F_E011_E016(val);
			}
			else
			{
				耣耤耔耀耑耚耡耤耎耡耣者耙耒翺耣翾翺老耛翼老耜耡翲耛耄翻翽耟耂耛翴耄耔耟翴翽();
			}
		}
	}

	private static void _E010_FFFD_FFFD_E011_E020_FFFD_E01B_E015_E018_FFFD_FFFD_E01F_E011_E016(IVsShell P_0)
	{
		IVsPackage val = null;
		if (P_0 == null)
		{
			return;
		}
		Guid guidEscherPkg = PackageConstants.guidEscherPkg;
		int num = P_0.IsPackageLoaded(ref guidEscherPkg, ref val);
		if (NativeMethods.Failed(num) || val == null)
		{
			num = P_0.LoadPackage(ref guidEscherPkg, ref val);
			if (NativeMethods.Failed(num))
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Resources.get_PackageLoadFailureExceptionMessage(), num));
			}
		}
	}

	public static AutomationElement 눦눯눮눰눹눛뉉눽눧(AutomationElement P_0, object P_1, bool P_2)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		Library.ValidateArgumentNonNull((object)P_0, "愷愐愑愷愐愰愋愽愴愷愊愷愇愭愷愔愑愫愵愾愨愲愮愰愷愒愙愸愎愘愾愺愘愻愆愱愘愌愘愿愽愸");
		Library.ValidateArgumentNonNull(P_1, "칀칥칹칠칈칢칤칄칊칮칹칒칤칂칀칠칗칱칭칏칵칒칪칹칦칇칥칖칥칬");
		if (P_2)
		{
			UIVerifyLogger.LogComment(string.Concat("ᗡᗊᗔᗈᗦᗒᗍᗬᗰᗅᗯᗏᗧᗳᗃᗶᗉᗲᗆᗕᗩᗫᗄᗙᗉᗖᗡᗔᗡᗗᗩᗹᗸᗹᗺᗩᗫᗖᗶᗩᗬᗦᗘᗫᗧ", P_1, "徺徼徙忁忌徚忏忈徜徦徼徫微徿徦徨忁忉忋徥忆徝復忊忁徣徬忍徟徹忂忈徧徚徦循忆徥忏徚徯徻徧從徸必徬忁忈"), new object[0]);
		}
		AutomationElement obj = P_0.FindFirst((TreeScope)6, (Condition)new PropertyCondition(AutomationElement.AutomationIdProperty, P_1));
		if (obj == (AutomationElement)null)
		{
			throw new ArgumentException("\uf01b\uf00a\uf016\uf037\uf014\uf03d\uf033\uf030\uf027\uf010\uf00e\uf029\uf00f\uf00a\uf014\uf02a\uf03b\uf039\uf01d\uf009\uf03c\uf01a\uf018\uf017\uf032\uf017\uf031\uf038\uf01c\uf017\uf011\uf02b\uf036\uf030\uf010\uf00a\uf007\uf017\uf03b\uf00e\uf02d\uf015\uf017");
		}
		return obj;
	}

	public static void 潥潔潳潘澋潤澄潶潳澁澃潴潵潼潜潵澁澆潚潠潣澊潒澄澅潜潪潻潪潫潷澈潟潝潹澁潵潾潕(AutomationElement P_0, ref string P_1, ref string P_2)
	{
		TextLibraryCount.GetClassName(P_0, ref P_1, ref P_2);
	}

	public static string 蒘蓊蓀蓍蒢蒪蒡蓃蒮蓃蒷蒠蒼蒫蒷蒸(AutomationElement P_0)
	{
		return TextLibraryCount.GetClassName(P_0);
	}

	public static int ጡጘጚጧገ_1316ጢጟዹጣጫዶጀጟ(TextUnit P_0, TextPatternRange P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return TextLibraryCount.CountTextUnit(P_0, P_1);
	}

	public static int 쬼쭘쭖쭢쭙쭎쬱쭤쭃쬵쭕쬵쭂쭟쭚쬼쬵쭏쬺(AutomationElement P_0)
	{
		return TextLibraryCount.Win32CountLines(P_0);
	}

	public static int _FAF9_FB08_FAF5_FADBﬅ_FAE8_FAFF_FAFA𧻓ﬁ_FADD_FAFE_FAF5_FAEC_FAE7_FAE8_FADE龎_FAE3_FB0B_FADB龎_FAFD_FADD_FADEﬆﬅ_FAE5ﬄ_FB0C_FAE1䀘_FAEB_FB0A_FAE9_FB08_FAFD𥉉_FAF7ﬄ_FAE2_FB0B_FAE6_FADC(string P_0)
	{
		return TextLibraryCount.CountParagraphs(P_0);
	}

	internal static int 뺥뺔뺥뻆뻀뺳뺱뺻뺾뺴뺎뺹뺿뺤뺦뺑뻁뺝뺳뻇뺸뺻뺒뺰뻇뺙뺷뺏뻆뺗뺸(TextUnit P_0, TextPatternRange P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return 뺥뺔뺥뻆뻀뺳뺱뺻뺾뺴뺎뺹뺿뺤뺦뺑뻁뺝뺳뻇뺸뺻뺒뺰뻇뺙뺷뺏뻆뺗뺸(P_0, P_1);
	}

	public static void ꈳꈽꉀꈿꉧꉥꉋꉥꈽꉟꈺꉢꉨꉛꉄꈸꉘꉀꉨꈺꉀꉛꉀꈼꉔꉇꉊ(AutomationElement P_0, ref TextUnit[] P_1)
	{
		TextLibraryCount.IdentifySupportedTextUnits(P_0, ref P_1);
	}

	internal static TextUnit 沘沃沐沉沘沏沋沇沩沭沩沛沒沍沐沙沆沰沇沱沕沅(AutomationElement P_0, TextUnit P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return TextLibraryCount.win32_IdentifySupportedTextUnits(P_0, P_1);
	}

	public static bool ᗭᘏᗤᗻᘔᗺᘆᗭᗣᘘᘕᘚᘌᘛᘄᘗᗬᗣᘏᘛᗷᗩᘙᗵᘅᘘᗳᘉᗱᘒᗬᗰᘕᘈ(AutomationElement P_0)
	{
		switch (ᒉᑬᒒᒘᑨᑺᒑᑫᑤᒓᒒᒍᒎᑰᒃᑥᑱᑮᑯᑬᒎᒂᒎᑨᒏᑵᒄᑤᒐᒖᑫᒉᒍᒆᒔᒄᑸᒊᒙᑡᒈᑹᒓᑤᑰᑸᒃ)
		{
		case "葰葃葏葬葸葔葪葃葉葑葭葢葖葠葩葟葉葠葇葶葀葭葯葁葳葖":
		case "䝹䝸䝬䝼䝘䝔䝓䝭䝕䝖䝊䝨䝭䝜䝙䝷䝌䝮䝏䝱䝔䝒䝼䝶䝾䝓䝦䝩䝳":
			return ᄧᄝჵᄩჲᄃᄆჿჶᄔჰᄓᄀჸᄅᄆᄗᄇᄆᄚ_10FBჴᄕ(P_0, 4);
		case "怡怐恂怠怹怒恄恃怼怷怡恂怸怢恅怓怾怓恂性怤怺总怽怒怔怗怴":
			TestObject.Comment("棺棧棾棜棛棱棻棢椈棤椉棯椄棭棚椋植棜棬棭椑", new object[0]);
			return false;
		default:
			throw new ArgumentException("쁱삖삙쁮삗삌삖쁭쁽삗삊삕삞쁷쁺쁰쁾삝쁾삉쁼삍삋쁴삚" + ᒉᑬᒒᒘᑨᑺᒑᑫᑤᒓᒒᒍᒎᑰᒃᑥᑱᑮᑯᑬᒎᒂᒎᑨᒏᑵᒄᑤᒐᒖᑫᒉᒍᒆᒔᒄᑸᒊᒙᑡᒈᑹᒓᑤᑰᑸᒃ);
		}
	}

	internal static bool ᄧᄝჵᄩჲᄃᄆჿჶᄔჰᄓᄀჸᄅᄆᄗᄇᄆᄚ_10FBჴᄕ(AutomationElement P_0, int P_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		int windowLong = SafeNativeMethods.GetWindowLong(HWND.Cast(Helpers.CastNativeWindowHandleToIntPtr(P_0)), -16);
		if (windowLong == 0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if ((windowLong & P_1) > 0)
		{
			return true;
		}
		return false;
	}

	public static void 虵虈虚處虩虅虵虚虒虵虏虑虲虄處虴虔虨虮虅虡虄虍虔虶(Key P_0, string P_1, int P_2)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(P_2);
		Library.ValidateArgumentNonNull((object)P_1, "ꏯꏲꏳꏋꏏꏱꏋꏰꏦꏐ");
		if (P_1.Length > 0)
		{
			P_1 += "➎➌➠➮➤➋❾➍➴➋➴➏➋➝➴➡➂➰➯➠➀";
		}
		UIVerifyLogger.LogComment(P_1 + "廎庣庸廁庠庹廅庴廈庴庭庮廔廖廀庤廀庪廋廕庭庯廗庢庨廏廊廃庳庫庩庢廍庨庯庮廉庮廁庱" + ((object)(Key)(ref P_0)).ToString(), new object[0]);
		Input.SendKeyboardInput(P_0, true);
		Input.SendKeyboardInput(P_0, false);
	}

	public static void ਵ_0A12_0A46ਢ_0A37ਐਲ਼ਤਣ_0A31ਖ(Key P_0, Key P_1, string P_2, int P_3)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(P_3);
		Library.ValidateArgumentNonNull((object)P_2, "鏤鏲鐂鏛鏰鏙鏱鏩鐂鏢鐄鏺鏲鏬鏝鐋鐑鏚鐁鏧鏨鏿鏹鐉鏙鏯鏡鐇鏫鏙鏽鏝鏾鏽鐇");
		if (P_2.Length > 0)
		{
			P_2 += "\uef9e\uef8e\uefa0\uefbd\uefc3\uef92\uef9d\uefb1\uefad\uef9d\uefa2\uef9d\uefc4\uefb9\uef98\uefc1\uef9f\uefa0\uefc4\uef91\uefa5\uef9f\uefae\uef9f\uef97\uefa4\uef95\uef92\uef94\uefa2\uef91\uefae\uef8e\uefa4\uef95\uef9f\uefbf\uefb6\uefbd";
		}
		UIVerifyLogger.LogComment(P_2 + "\ue709\ue6e4\ue6fa\ue6eb\ue6e0\ue6e9\ue6e4\ue6e6\ue705\ue6e1\ue6e3\ue6df\ue6f2\ue713\ue6eb\ue711\ue6e5\ue6e1\ue702\ue712\ue70c\ue6ee\ue6f3\ue705\ue710\ue6e4\ue6e8\ue6e6\ue6fa\ue6db\ue707\ue708\ue6fb\ue6dc\ue70b\ue6fb\ue6fa\ue6ed\ue70b\ue6ec\ue6ee\ue6e4\ue708" + ((object)(Key)(ref P_0)).ToString() + "ѶуѸёѵчтѨѸїёѡчѵіѢљэыѴѶфѶѩёѷѓѱѰхѹѫьѱѡѩѱіцѕэѧхцс" + ((object)(Key)(ref P_1)).ToString(), new object[0]);
		Input.SendKeyboardInput(P_0, true);
		Thread.Sleep(300);
		Input.SendKeyboardInput(P_1, true);
		Thread.Sleep(P_3);
		Input.SendKeyboardInput(P_1, false);
		Input.SendKeyboardInput(P_0, false);
		Thread.Sleep(P_3);
	}

	public static void 䚜䚸䚶䚪䚿䚹䚸䚡䛆䚴䚢䚣䛉䚣䛊䛅䚶䚾䚲䚞䚵(Key P_0, Key P_1, Key P_2, string P_3, int P_4)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(P_4);
		Library.ValidateArgumentNonNull((object)P_3, "쵉쵘쵡쵊쵘쵅쵧쵖쵌쵡촻쵫쵘촿쵟촿쵗쵝촾촴쵟쵫쵃쵉쵩쵥촾쵓쵚촶쵤쵌쵆쵓쵪쵝쵟");
		if (P_3.Length > 0)
		{
			P_3 += "易昡昕昣旲旸昤昨昚昀春旿昛旷昂旸旼旹昪昒旺旲旺昔昃旼昣昫昞昖昡昔旲映昛昧昪昇昉昜时昋昛昉旹昦";
		}
		UIVerifyLogger.LogComment(P_3 + "ǑǮǲǵǖǑǱǬǇǍǦǿǖǴǙǰǩǿǶǳǚǼǺǮǕǏǴǼǏǶǑǻǽǵǋǶ" + ((object)(Key)(ref P_0)).ToString() + "䠶䡠䡘䡕䡏䠯䠵䡟䡝䡎䠼䠱䠶䡍䡟䡗䡍䠧䡕䠵䡊䠧䡎䡞䠵䡞䡑䠼䠫䡈䠧䠰䠪䡐" + ((object)(Key)(ref P_1)).ToString() + "ĖĕĉċĂćİþİĈĐħĪġĮČĮþēīįđĶćĴďĐıăĩĤĂĎĵįĥĊĶĥİĤĂĠā" + ((object)(Key)(ref P_2)).ToString(), new object[0]);
		Input.SendKeyboardInput(P_0, true);
		Thread.Sleep(300);
		Input.SendKeyboardInput(P_1, true);
		Thread.Sleep(300);
		Input.SendKeyboardInput(P_2, true);
		Thread.Sleep(P_4);
		Input.SendKeyboardInput(P_2, false);
		Input.SendKeyboardInput(P_0, false);
		Input.SendKeyboardInput(P_1, false);
		Thread.Sleep(P_4);
	}

	public static bool 뤘뤉뤟뤈뤌뤵뤳뤎뤠뤸뤳뤬뤊뤿뤝뤋뤿뤒뤵뤒뤈뤍뤨뤼뤸뤪(AutomationElement P_0)
	{
		return TextLibraryCount.IsRichEdit(P_0);
	}

	public static int 酈鄿酘酋酏酭酥鄸酗酂鄸酉(AutomationElement P_0, TextPatternRange P_1)
	{
		int result = 0;
		Library.ValidateArgumentNonNull((object)P_0, "ᰙ᯼\u1c26ᰇ\u1c2cᰊ\u1c25ᰝ\u1c24\u1c2bᰌᰈᰝᰀᰛ\u1bf5\u1bf7ᰟ\u1bf3\u1c26ᰇᰢᰙ\u1bf3\u1bf6ᰆᰊᰖᰝᰙᰟ\u1bf8\u1c25\u1c2bᰕᰄ᯼ᰃᰅᰉ\u1c2aᰃᰂ");
		Library.ValidateArgumentNonNull((object)P_1, "꤉꤈ꤗꤜꤤꤘꤢꣻꤍ꤈ꤡ\ua92aꤢ\ua92aꤋꤚꤏꤤꤖꤡ\ua929꣸꤂꤁\ua927꤈꤄\ua929꣹ꤋꤙꣶꤗ꣼꤀꤇꤆꤄ꤝꤊꣽꣾꣶꤢ");
		if (뤘뤉뤟뤈뤌뤵뤳뤎뤠뤸뤳뤬뤊뤿뤝뤋뤿뤒뤵뤒뤈뤍뤨뤼뤸뤪(P_0))
		{
			result = 늟늼늽늒닇닂늢늷늴늙늯늱늧닅늶닁늛늰늯늹닃늢늙늠닄(P_1.GetText(-1));
		}
		return result;
	}

	public static void 艧艞芉艙艦艫艙艵艘芁艚艵艩艞艻艿艽艹艢艴艨艴艸艴艽艗艤艡艔艵艼艹艾芋芊艗艩(AutomationElement P_0, TextPatternRange P_1)
	{
		Library.ValidateArgumentNonNull((object)P_0, "\ud989\ud980\ud966\ud97b\ud984\ud986\ud95b\ud976\ud988\ud987\ud976\ud961\ud968\ud958\ud980\ud958\ud982\ud95e\ud957\ud96f\ud958\ud97e\ud969\ud987\ud969\ud956\ud988");
		Library.ValidateArgumentNonNull((object)P_0, "匝勴化勰勺匛匂匞匑匌匙匃勴匛");
		if (뤘뤉뤟뤈뤌뤵뤳뤎뤠뤸뤳뤬뤊뤿뤝뤋뤿뤒뤵뤒뤈뤍뤨뤼뤸뤪(P_0))
		{
			int num = 0;
			int num2 = 0;
			num2 = 늟늼늽늒닇닂늢늷늴늙늯늱늧닅늶닁늛늰늯늹닃늢늙늠닄(P_1.GetText(-1));
			num = P_1.MoveEndpointByUnit((TextPatternRangeEndpoint)1, (TextUnit)0, num2);
			if (num != num2)
			{
				throw new InvalidOperationException("쑮쑱쒛쑰쒟쒏쒞쑺쑩쑾쒌쑰쒒쒘쒡쒓쑵쑿" + num2 + "ႶႷეუჄႱႴႿქლტႲჟლჁნႶშჁჃႹჄႿႹႸႺႶႻ" + num);
			}
			UIVerifyLogger.LogComment("ꚨꚱꚢꛂꚷꚪꚩꚣꛐꛙꛈꚴꛒꛂ" + num2 + "霴霿霚靃霿霰霞霘霢霰霯霙霞靂霘霷霢霠霚霜靂霠霏靁霐霷霘霿霮霘霯靁霢霶霏霽霤霷靀霦霛霰", new object[0]);
		}
	}

	private static int 늟늼늽늒닇닂늢늷늴늙늯늱늧닅늶닁늛늰늯늹닃늢늙늠닄(string P_0)
	{
		int num = 0;
		int result = 0;
		int num2 = 0;
		if (P_0 == null || P_0.Length == 0)
		{
			return 0;
		}
		num2 = P_0.Length;
		num = P_0.LastIndexOf("\uf19d\uf199\uf19e\uf17d\uf196\uf18c\uf18d\uf189\uf17a\uf17b\uf1a5\uf18b\uf182\uf1a3\uf19f\uf185\uf18a\uf17c\uf1a0\uf178\uf1a2\uf184\uf19a\uf1ac\uf187\uf183\uf196\uf1ac\uf185");
		if (num >= 0 && num == num2 - 2)
		{
			result = -2;
		}
		else
		{
			num = P_0.LastIndexOf('\r');
			if (num >= 0 && num == P_0.Length - 1)
			{
				result = -1;
			}
			else
			{
				num = P_0.LastIndexOf('\n');
				if (num >= 0 && num == P_0.Length - 1)
				{
					result = -1;
				}
			}
		}
		return result;
	}

	internal static void 踐踖跲踋踐践踗踊踇踖跥踑踀跬踇跷跢跫跧跨跩跥跡跭踐踀踖跤跨踈践跢跲踒跳跱跦跣踀踅跢踅跩踇跭跶(string P_0)
	{
		ᒉᑬᒒᒘᑨᑺᒑᑫᑤᒓᒒᒍᒎᑰᒃᑥᑱᑮᑯᑬᒎᒂᒎᑨᒏᑵᒄᑤᒐᒖᑫᒉᒍᒆᒔᒄᑸᒊᒙᑡᒈᑹᒓᑤᑰᑸᒃ = P_0.ToLower(CultureInfo.InvariantCulture);
	}

	public static SupportedTextSelection _EC3F_EC38_EC42_EC19_EC2D_EC32_EC23_EC11_EC1C_EC3B_EC30_EC20_EC3B_EC43_EC1E_EC0C_EC24_EC0B_EC2D_EC44_EC12_EC1D_EC3A_EC3C_EC23_EC16_EC0D_EC31_EC0E_EC20_EC3E_EC2B_EC3E_EC44_EC2F_EC3D_EC38_EC41_EC1F_EC41()
	{
		switch (ᒉᑬᒒᒘᑨᑺᒑᑫᑤᒓᒒᒍᒎᑰᒃᑥᑱᑮᑯᑬᒎᒂᒎᑨᒏᑵᒄᑤᒐᒖᑫᒉᒍᒆᒔᒄᑸᒊᒙᑡᒈᑹᒓᑤᑰᑸᒃ)
		{
		case "띰띇띜띨뜽띀띝띱띇띛뜼띈띂띳띟띳뜿뜾띂띮띅띩띅뜾띊띫띰띦띐띟띈띋띭띞띲띆띩띓띚뜺뜼띉띰띛띏띉띈띒띋":
		case "递逩逬進适逤速逶逵逩逧逎迾逆逪选逳适速週逧逃送逥透途逑逈逆逞":
		case "챿챻챲챱챊챉챟챇챹챑챘챈":
		case "痧痂痤痄痟痩痠痍痮疷痤疽痝疹疽痣痧病痭疾痁痬痥痭疿痟":
			return (SupportedTextSelection)1;
		default:
			throw new ArgumentException("内兪兩冓冄兯兰円兩円其冚全冔兡其八其具冕关内冓冃内冈內" + ᒉᑬᒒᒘᑨᑺᒑᑫᑤᒓᒒᒍᒎᑰᒃᑥᑱᑮᑯᑬᒎᒂᒎᑨᒏᑵᒄᑤᒐᒖᑫᒉᒍᒆᒔᒄᑸᒊᒙᑡᒈᑹᒓᑤᑰᑸᒃ);
		}
	}
}
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class _F2C1_F2CC_F2E6_F2CC_F2CD_F2C7_F2E5_F2C8_F2D4_F2C0_F2D4_F2C6_F2D6_F2F3_F2EE_F2D6_F2C9_F2CD_F2CA_F2C5_F2CF_F2C0_F2C4_F2F2_F2F0_F2DF_F2C0_F2CD_F2ED_F2EB_F2EC_F2DE_F2F2_F2CA_F2CE
{
	private static ResourceManager 噺噭噻噯噼嚕器噺噰噥噶噩噯噳噶嚒嚏嚉嚋嚅嚌噲嚛噳嚌;

	private static CultureInfo 鳙鲭鳒鲻鳒鳑鲪鳘鳇鳈鲷鳆鲯鲥鲽鲰鲮鲶鳏鲼鳊鲦鳚鳆鲴鳔鲪鲴鳍鳑鳍鲨鲪鲺鲭鲴鳑鲩鲽鳕鲰鲳鳙鳍鳙;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager 퐆퐚퐈폨퐍퐏폶퐐퐊폼폪폴폧폸
	{
		get
		{
			if (噺噭噻噯噼嚕器噺噰噥噶噩噯噳噶嚒嚏嚉嚋嚅嚌噲嚛噳嚌 == null)
			{
				ResourceManager resourceManager = (噺噭噻噯噼嚕器噺噰噥噶噩噯噳噶嚒嚏嚉嚋嚅嚌噲嚛噳嚌 = new ResourceManager("WindowsFormsApp1.Properties.Resources", typeof(_F2C1_F2CC_F2E6_F2CC_F2CD_F2C7_F2E5_F2C8_F2D4_F2C0_F2D4_F2C6_F2D6_F2F3_F2EE_F2D6_F2C9_F2CD_F2CA_F2C5_F2CF_F2C0_F2C4_F2F2_F2F0_F2DF_F2C0_F2CD_F2ED_F2EB_F2EC_F2DE_F2F2_F2CA_F2CE).Assembly));
			}
			return 噺噭噻噯噼嚕器噺噰噥噶噩噯噳噶嚒嚏嚉嚋嚅嚌噲嚛噳嚌;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo 鰨鱗鱃鰣鱂鱁鰳鰣鰤鰸鰭鰯鰦鰥鰦鰳鰿鰫鱒鱂鰦鰣鱒鱓鱂鰧鱕鰧鱍鰷鱇鰬鰯鰶鰪鰨鱏鰿鰸鱒鱉鰸鰷鱉鱕鱁鰤
	{
		get
		{
			return 鳙鲭鳒鲻鳒鳑鲪鳘鳇鳈鲷鳆鲯鲥鲽鲰鲮鲶鳏鲼鳊鲦鳚鳆鲴鳔鲪鲴鳍鳑鳍鲨鲪鲺鲭鲴鳑鲩鲽鳕鲰鲳鳙鳍鳙;
		}
		set
		{
			鳙鲭鳒鲻鳒鳑鲪鳘鳇鳈鲷鳆鲯鲥鲽鲰鲮鲶鳏鲼鳊鲦鳚鳆鲴鳔鲪鲴鳍鳑鳍鲨鲪鲺鲭鲴鳑鲩鲽鳕鲰鲳鳙鳍鳙 = value;
		}
	}

	internal _F2C1_F2CC_F2E6_F2CC_F2CD_F2C7_F2E5_F2C8_F2D4_F2C0_F2D4_F2C6_F2D6_F2F3_F2EE_F2D6_F2C9_F2CD_F2CA_F2C5_F2CF_F2C0_F2C4_F2F2_F2F0_F2DF_F2C0_F2CD_F2ED_F2EB_F2EC_F2DE_F2F2_F2CA_F2CE()
	{
	}
}
