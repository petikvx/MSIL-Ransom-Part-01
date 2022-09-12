using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;

namespace HtmlAgilityPack;

public class HtmlEntity
{
	private enum ParseState
	{
		Text,
		EntityStart
	}

	private static readonly int _maxEntitySize;

	private static Dictionary<int, string> _entityName;

	private static Dictionary<string, int> _entityValue;

	public static bool UseWebUtility { get; set; }

	public static Dictionary<int, string> EntityName => _entityName;

	public static Dictionary<string, int> EntityValue => _entityValue;

	static HtmlEntity()
	{
		_entityName = new Dictionary<int, string>();
		_entityValue = new Dictionary<string, int>();
		_entityValue.Add("quot", 34);
		_entityName.Add(34, "quot");
		_entityValue.Add("amp", 38);
		_entityName.Add(38, "amp");
		_entityValue.Add("apos", 39);
		_entityName.Add(39, "apos");
		_entityValue.Add("lt", 60);
		_entityName.Add(60, "lt");
		_entityValue.Add("gt", 62);
		_entityName.Add(62, "gt");
		_entityValue.Add("nbsp", 160);
		_entityName.Add(160, "nbsp");
		_entityValue.Add("iexcl", 161);
		_entityName.Add(161, "iexcl");
		_entityValue.Add("cent", 162);
		_entityName.Add(162, "cent");
		_entityValue.Add("pound", 163);
		_entityName.Add(163, "pound");
		_entityValue.Add("curren", 164);
		_entityName.Add(164, "curren");
		_entityValue.Add("yen", 165);
		_entityName.Add(165, "yen");
		_entityValue.Add("brvbar", 166);
		_entityName.Add(166, "brvbar");
		_entityValue.Add("sect", 167);
		_entityName.Add(167, "sect");
		_entityValue.Add("uml", 168);
		_entityName.Add(168, "uml");
		_entityValue.Add("copy", 169);
		_entityName.Add(169, "copy");
		_entityValue.Add("ordf", 170);
		_entityName.Add(170, "ordf");
		_entityValue.Add("laquo", 171);
		_entityName.Add(171, "laquo");
		_entityValue.Add("not", 172);
		_entityName.Add(172, "not");
		_entityValue.Add("shy", 173);
		_entityName.Add(173, "shy");
		_entityValue.Add("reg", 174);
		_entityName.Add(174, "reg");
		_entityValue.Add("macr", 175);
		_entityName.Add(175, "macr");
		_entityValue.Add("deg", 176);
		_entityName.Add(176, "deg");
		_entityValue.Add("plusmn", 177);
		_entityName.Add(177, "plusmn");
		_entityValue.Add("sup2", 178);
		_entityName.Add(178, "sup2");
		_entityValue.Add("sup3", 179);
		_entityName.Add(179, "sup3");
		_entityValue.Add("acute", 180);
		_entityName.Add(180, "acute");
		_entityValue.Add("micro", 181);
		_entityName.Add(181, "micro");
		_entityValue.Add("para", 182);
		_entityName.Add(182, "para");
		_entityValue.Add("middot", 183);
		_entityName.Add(183, "middot");
		_entityValue.Add("cedil", 184);
		_entityName.Add(184, "cedil");
		_entityValue.Add("sup1", 185);
		_entityName.Add(185, "sup1");
		_entityValue.Add("ordm", 186);
		_entityName.Add(186, "ordm");
		_entityValue.Add("raquo", 187);
		_entityName.Add(187, "raquo");
		_entityValue.Add("frac14", 188);
		_entityName.Add(188, "frac14");
		_entityValue.Add("frac12", 189);
		_entityName.Add(189, "frac12");
		_entityValue.Add("frac34", 190);
		_entityName.Add(190, "frac34");
		_entityValue.Add("iquest", 191);
		_entityName.Add(191, "iquest");
		_entityValue.Add("Agrave", 192);
		_entityName.Add(192, "Agrave");
		_entityValue.Add("Aacute", 193);
		_entityName.Add(193, "Aacute");
		_entityValue.Add("Acirc", 194);
		_entityName.Add(194, "Acirc");
		_entityValue.Add("Atilde", 195);
		_entityName.Add(195, "Atilde");
		_entityValue.Add("Auml", 196);
		_entityName.Add(196, "Auml");
		_entityValue.Add("Aring", 197);
		_entityName.Add(197, "Aring");
		_entityValue.Add("AElig", 198);
		_entityName.Add(198, "AElig");
		_entityValue.Add("Ccedil", 199);
		_entityName.Add(199, "Ccedil");
		_entityValue.Add("Egrave", 200);
		_entityName.Add(200, "Egrave");
		_entityValue.Add("Eacute", 201);
		_entityName.Add(201, "Eacute");
		_entityValue.Add("Ecirc", 202);
		_entityName.Add(202, "Ecirc");
		_entityValue.Add("Euml", 203);
		_entityName.Add(203, "Euml");
		_entityValue.Add("Igrave", 204);
		_entityName.Add(204, "Igrave");
		_entityValue.Add("Iacute", 205);
		_entityName.Add(205, "Iacute");
		_entityValue.Add("Icirc", 206);
		_entityName.Add(206, "Icirc");
		_entityValue.Add("Iuml", 207);
		_entityName.Add(207, "Iuml");
		_entityValue.Add("ETH", 208);
		_entityName.Add(208, "ETH");
		_entityValue.Add("Ntilde", 209);
		_entityName.Add(209, "Ntilde");
		_entityValue.Add("Ograve", 210);
		_entityName.Add(210, "Ograve");
		_entityValue.Add("Oacute", 211);
		_entityName.Add(211, "Oacute");
		_entityValue.Add("Ocirc", 212);
		_entityName.Add(212, "Ocirc");
		_entityValue.Add("Otilde", 213);
		_entityName.Add(213, "Otilde");
		_entityValue.Add("Ouml", 214);
		_entityName.Add(214, "Ouml");
		_entityValue.Add("times", 215);
		_entityName.Add(215, "times");
		_entityValue.Add("Oslash", 216);
		_entityName.Add(216, "Oslash");
		_entityValue.Add("Ugrave", 217);
		_entityName.Add(217, "Ugrave");
		_entityValue.Add("Uacute", 218);
		_entityName.Add(218, "Uacute");
		_entityValue.Add("Ucirc", 219);
		_entityName.Add(219, "Ucirc");
		_entityValue.Add("Uuml", 220);
		_entityName.Add(220, "Uuml");
		_entityValue.Add("Yacute", 221);
		_entityName.Add(221, "Yacute");
		_entityValue.Add("THORN", 222);
		_entityName.Add(222, "THORN");
		_entityValue.Add("szlig", 223);
		_entityName.Add(223, "szlig");
		_entityValue.Add("agrave", 224);
		_entityName.Add(224, "agrave");
		_entityValue.Add("aacute", 225);
		_entityName.Add(225, "aacute");
		_entityValue.Add("acirc", 226);
		_entityName.Add(226, "acirc");
		_entityValue.Add("atilde", 227);
		_entityName.Add(227, "atilde");
		_entityValue.Add("auml", 228);
		_entityName.Add(228, "auml");
		_entityValue.Add("aring", 229);
		_entityName.Add(229, "aring");
		_entityValue.Add("aelig", 230);
		_entityName.Add(230, "aelig");
		_entityValue.Add("ccedil", 231);
		_entityName.Add(231, "ccedil");
		_entityValue.Add("egrave", 232);
		_entityName.Add(232, "egrave");
		_entityValue.Add("eacute", 233);
		_entityName.Add(233, "eacute");
		_entityValue.Add("ecirc", 234);
		_entityName.Add(234, "ecirc");
		_entityValue.Add("euml", 235);
		_entityName.Add(235, "euml");
		_entityValue.Add("igrave", 236);
		_entityName.Add(236, "igrave");
		_entityValue.Add("iacute", 237);
		_entityName.Add(237, "iacute");
		_entityValue.Add("icirc", 238);
		_entityName.Add(238, "icirc");
		_entityValue.Add("iuml", 239);
		_entityName.Add(239, "iuml");
		_entityValue.Add("eth", 240);
		_entityName.Add(240, "eth");
		_entityValue.Add("ntilde", 241);
		_entityName.Add(241, "ntilde");
		_entityValue.Add("ograve", 242);
		_entityName.Add(242, "ograve");
		_entityValue.Add("oacute", 243);
		_entityName.Add(243, "oacute");
		_entityValue.Add("ocirc", 244);
		_entityName.Add(244, "ocirc");
		_entityValue.Add("otilde", 245);
		_entityName.Add(245, "otilde");
		_entityValue.Add("ouml", 246);
		_entityName.Add(246, "ouml");
		_entityValue.Add("divide", 247);
		_entityName.Add(247, "divide");
		_entityValue.Add("oslash", 248);
		_entityName.Add(248, "oslash");
		_entityValue.Add("ugrave", 249);
		_entityName.Add(249, "ugrave");
		_entityValue.Add("uacute", 250);
		_entityName.Add(250, "uacute");
		_entityValue.Add("ucirc", 251);
		_entityName.Add(251, "ucirc");
		_entityValue.Add("uuml", 252);
		_entityName.Add(252, "uuml");
		_entityValue.Add("yacute", 253);
		_entityName.Add(253, "yacute");
		_entityValue.Add("thorn", 254);
		_entityName.Add(254, "thorn");
		_entityValue.Add("yuml", 255);
		_entityName.Add(255, "yuml");
		_entityValue.Add("fnof", 402);
		_entityName.Add(402, "fnof");
		_entityValue.Add("Alpha", 913);
		_entityName.Add(913, "Alpha");
		_entityValue.Add("Beta", 914);
		_entityName.Add(914, "Beta");
		_entityValue.Add("Gamma", 915);
		_entityName.Add(915, "Gamma");
		_entityValue.Add("Delta", 916);
		_entityName.Add(916, "Delta");
		_entityValue.Add("Epsilon", 917);
		_entityName.Add(917, "Epsilon");
		_entityValue.Add("Zeta", 918);
		_entityName.Add(918, "Zeta");
		_entityValue.Add("Eta", 919);
		_entityName.Add(919, "Eta");
		_entityValue.Add("Theta", 920);
		_entityName.Add(920, "Theta");
		_entityValue.Add("Iota", 921);
		_entityName.Add(921, "Iota");
		_entityValue.Add("Kappa", 922);
		_entityName.Add(922, "Kappa");
		_entityValue.Add("Lambda", 923);
		_entityName.Add(923, "Lambda");
		_entityValue.Add("Mu", 924);
		_entityName.Add(924, "Mu");
		_entityValue.Add("Nu", 925);
		_entityName.Add(925, "Nu");
		_entityValue.Add("Xi", 926);
		_entityName.Add(926, "Xi");
		_entityValue.Add("Omicron", 927);
		_entityName.Add(927, "Omicron");
		_entityValue.Add("Pi", 928);
		_entityName.Add(928, "Pi");
		_entityValue.Add("Rho", 929);
		_entityName.Add(929, "Rho");
		_entityValue.Add("Sigma", 931);
		_entityName.Add(931, "Sigma");
		_entityValue.Add("Tau", 932);
		_entityName.Add(932, "Tau");
		_entityValue.Add("Upsilon", 933);
		_entityName.Add(933, "Upsilon");
		_entityValue.Add("Phi", 934);
		_entityName.Add(934, "Phi");
		_entityValue.Add("Chi", 935);
		_entityName.Add(935, "Chi");
		_entityValue.Add("Psi", 936);
		_entityName.Add(936, "Psi");
		_entityValue.Add("Omega", 937);
		_entityName.Add(937, "Omega");
		_entityValue.Add("alpha", 945);
		_entityName.Add(945, "alpha");
		_entityValue.Add("beta", 946);
		_entityName.Add(946, "beta");
		_entityValue.Add("gamma", 947);
		_entityName.Add(947, "gamma");
		_entityValue.Add("delta", 948);
		_entityName.Add(948, "delta");
		_entityValue.Add("epsilon", 949);
		_entityName.Add(949, "epsilon");
		_entityValue.Add("zeta", 950);
		_entityName.Add(950, "zeta");
		_entityValue.Add("eta", 951);
		_entityName.Add(951, "eta");
		_entityValue.Add("theta", 952);
		_entityName.Add(952, "theta");
		_entityValue.Add("iota", 953);
		_entityName.Add(953, "iota");
		_entityValue.Add("kappa", 954);
		_entityName.Add(954, "kappa");
		_entityValue.Add("lambda", 955);
		_entityName.Add(955, "lambda");
		_entityValue.Add("mu", 956);
		_entityName.Add(956, "mu");
		_entityValue.Add("nu", 957);
		_entityName.Add(957, "nu");
		_entityValue.Add("xi", 958);
		_entityName.Add(958, "xi");
		_entityValue.Add("omicron", 959);
		_entityName.Add(959, "omicron");
		_entityValue.Add("pi", 960);
		_entityName.Add(960, "pi");
		_entityValue.Add("rho", 961);
		_entityName.Add(961, "rho");
		_entityValue.Add("sigmaf", 962);
		_entityName.Add(962, "sigmaf");
		_entityValue.Add("sigma", 963);
		_entityName.Add(963, "sigma");
		_entityValue.Add("tau", 964);
		_entityName.Add(964, "tau");
		_entityValue.Add("upsilon", 965);
		_entityName.Add(965, "upsilon");
		_entityValue.Add("phi", 966);
		_entityName.Add(966, "phi");
		_entityValue.Add("chi", 967);
		_entityName.Add(967, "chi");
		_entityValue.Add("psi", 968);
		_entityName.Add(968, "psi");
		_entityValue.Add("omega", 969);
		_entityName.Add(969, "omega");
		_entityValue.Add("thetasym", 977);
		_entityName.Add(977, "thetasym");
		_entityValue.Add("upsih", 978);
		_entityName.Add(978, "upsih");
		_entityValue.Add("piv", 982);
		_entityName.Add(982, "piv");
		_entityValue.Add("bull", 8226);
		_entityName.Add(8226, "bull");
		_entityValue.Add("hellip", 8230);
		_entityName.Add(8230, "hellip");
		_entityValue.Add("prime", 8242);
		_entityName.Add(8242, "prime");
		_entityValue.Add("Prime", 8243);
		_entityName.Add(8243, "Prime");
		_entityValue.Add("oline", 8254);
		_entityName.Add(8254, "oline");
		_entityValue.Add("frasl", 8260);
		_entityName.Add(8260, "frasl");
		_entityValue.Add("weierp", 8472);
		_entityName.Add(8472, "weierp");
		_entityValue.Add("image", 8465);
		_entityName.Add(8465, "image");
		_entityValue.Add("real", 8476);
		_entityName.Add(8476, "real");
		_entityValue.Add("trade", 8482);
		_entityName.Add(8482, "trade");
		_entityValue.Add("alefsym", 8501);
		_entityName.Add(8501, "alefsym");
		_entityValue.Add("larr", 8592);
		_entityName.Add(8592, "larr");
		_entityValue.Add("uarr", 8593);
		_entityName.Add(8593, "uarr");
		_entityValue.Add("rarr", 8594);
		_entityName.Add(8594, "rarr");
		_entityValue.Add("darr", 8595);
		_entityName.Add(8595, "darr");
		_entityValue.Add("harr", 8596);
		_entityName.Add(8596, "harr");
		_entityValue.Add("crarr", 8629);
		_entityName.Add(8629, "crarr");
		_entityValue.Add("lArr", 8656);
		_entityName.Add(8656, "lArr");
		_entityValue.Add("uArr", 8657);
		_entityName.Add(8657, "uArr");
		_entityValue.Add("rArr", 8658);
		_entityName.Add(8658, "rArr");
		_entityValue.Add("dArr", 8659);
		_entityName.Add(8659, "dArr");
		_entityValue.Add("hArr", 8660);
		_entityName.Add(8660, "hArr");
		_entityValue.Add("forall", 8704);
		_entityName.Add(8704, "forall");
		_entityValue.Add("part", 8706);
		_entityName.Add(8706, "part");
		_entityValue.Add("exist", 8707);
		_entityName.Add(8707, "exist");
		_entityValue.Add("empty", 8709);
		_entityName.Add(8709, "empty");
		_entityValue.Add("nabla", 8711);
		_entityName.Add(8711, "nabla");
		_entityValue.Add("isin", 8712);
		_entityName.Add(8712, "isin");
		_entityValue.Add("notin", 8713);
		_entityName.Add(8713, "notin");
		_entityValue.Add("ni", 8715);
		_entityName.Add(8715, "ni");
		_entityValue.Add("prod", 8719);
		_entityName.Add(8719, "prod");
		_entityValue.Add("sum", 8721);
		_entityName.Add(8721, "sum");
		_entityValue.Add("minus", 8722);
		_entityName.Add(8722, "minus");
		_entityValue.Add("lowast", 8727);
		_entityName.Add(8727, "lowast");
		_entityValue.Add("radic", 8730);
		_entityName.Add(8730, "radic");
		_entityValue.Add("prop", 8733);
		_entityName.Add(8733, "prop");
		_entityValue.Add("infin", 8734);
		_entityName.Add(8734, "infin");
		_entityValue.Add("ang", 8736);
		_entityName.Add(8736, "ang");
		_entityValue.Add("and", 8743);
		_entityName.Add(8743, "and");
		_entityValue.Add("or", 8744);
		_entityName.Add(8744, "or");
		_entityValue.Add("cap", 8745);
		_entityName.Add(8745, "cap");
		_entityValue.Add("cup", 8746);
		_entityName.Add(8746, "cup");
		_entityValue.Add("int", 8747);
		_entityName.Add(8747, "int");
		_entityValue.Add("there4", 8756);
		_entityName.Add(8756, "there4");
		_entityValue.Add("sim", 8764);
		_entityName.Add(8764, "sim");
		_entityValue.Add("cong", 8773);
		_entityName.Add(8773, "cong");
		_entityValue.Add("asymp", 8776);
		_entityName.Add(8776, "asymp");
		_entityValue.Add("ne", 8800);
		_entityName.Add(8800, "ne");
		_entityValue.Add("equiv", 8801);
		_entityName.Add(8801, "equiv");
		_entityValue.Add("le", 8804);
		_entityName.Add(8804, "le");
		_entityValue.Add("ge", 8805);
		_entityName.Add(8805, "ge");
		_entityValue.Add("sub", 8834);
		_entityName.Add(8834, "sub");
		_entityValue.Add("sup", 8835);
		_entityName.Add(8835, "sup");
		_entityValue.Add("nsub", 8836);
		_entityName.Add(8836, "nsub");
		_entityValue.Add("sube", 8838);
		_entityName.Add(8838, "sube");
		_entityValue.Add("supe", 8839);
		_entityName.Add(8839, "supe");
		_entityValue.Add("oplus", 8853);
		_entityName.Add(8853, "oplus");
		_entityValue.Add("otimes", 8855);
		_entityName.Add(8855, "otimes");
		_entityValue.Add("perp", 8869);
		_entityName.Add(8869, "perp");
		_entityValue.Add("sdot", 8901);
		_entityName.Add(8901, "sdot");
		_entityValue.Add("lceil", 8968);
		_entityName.Add(8968, "lceil");
		_entityValue.Add("rceil", 8969);
		_entityName.Add(8969, "rceil");
		_entityValue.Add("lfloor", 8970);
		_entityName.Add(8970, "lfloor");
		_entityValue.Add("rfloor", 8971);
		_entityName.Add(8971, "rfloor");
		_entityValue.Add("lang", 9001);
		_entityName.Add(9001, "lang");
		_entityValue.Add("rang", 9002);
		_entityName.Add(9002, "rang");
		_entityValue.Add("loz", 9674);
		_entityName.Add(9674, "loz");
		_entityValue.Add("spades", 9824);
		_entityName.Add(9824, "spades");
		_entityValue.Add("clubs", 9827);
		_entityName.Add(9827, "clubs");
		_entityValue.Add("hearts", 9829);
		_entityName.Add(9829, "hearts");
		_entityValue.Add("diams", 9830);
		_entityName.Add(9830, "diams");
		_entityValue.Add("OElig", 338);
		_entityName.Add(338, "OElig");
		_entityValue.Add("oelig", 339);
		_entityName.Add(339, "oelig");
		_entityValue.Add("Scaron", 352);
		_entityName.Add(352, "Scaron");
		_entityValue.Add("scaron", 353);
		_entityName.Add(353, "scaron");
		_entityValue.Add("Yuml", 376);
		_entityName.Add(376, "Yuml");
		_entityValue.Add("circ", 710);
		_entityName.Add(710, "circ");
		_entityValue.Add("tilde", 732);
		_entityName.Add(732, "tilde");
		_entityValue.Add("ensp", 8194);
		_entityName.Add(8194, "ensp");
		_entityValue.Add("emsp", 8195);
		_entityName.Add(8195, "emsp");
		_entityValue.Add("thinsp", 8201);
		_entityName.Add(8201, "thinsp");
		_entityValue.Add("zwnj", 8204);
		_entityName.Add(8204, "zwnj");
		_entityValue.Add("zwj", 8205);
		_entityName.Add(8205, "zwj");
		_entityValue.Add("lrm", 8206);
		_entityName.Add(8206, "lrm");
		_entityValue.Add("rlm", 8207);
		_entityName.Add(8207, "rlm");
		_entityValue.Add("ndash", 8211);
		_entityName.Add(8211, "ndash");
		_entityValue.Add("mdash", 8212);
		_entityName.Add(8212, "mdash");
		_entityValue.Add("lsquo", 8216);
		_entityName.Add(8216, "lsquo");
		_entityValue.Add("rsquo", 8217);
		_entityName.Add(8217, "rsquo");
		_entityValue.Add("sbquo", 8218);
		_entityName.Add(8218, "sbquo");
		_entityValue.Add("ldquo", 8220);
		_entityName.Add(8220, "ldquo");
		_entityValue.Add("rdquo", 8221);
		_entityName.Add(8221, "rdquo");
		_entityValue.Add("bdquo", 8222);
		_entityName.Add(8222, "bdquo");
		_entityValue.Add("dagger", 8224);
		_entityName.Add(8224, "dagger");
		_entityValue.Add("Dagger", 8225);
		_entityName.Add(8225, "Dagger");
		_entityValue.Add("permil", 8240);
		_entityName.Add(8240, "permil");
		_entityValue.Add("lsaquo", 8249);
		_entityName.Add(8249, "lsaquo");
		_entityValue.Add("rsaquo", 8250);
		_entityName.Add(8250, "rsaquo");
		_entityValue.Add("euro", 8364);
		_entityName.Add(8364, "euro");
		_maxEntitySize = 9;
	}

	private HtmlEntity()
	{
	}

	public static string DeEntitize(string text)
	{
		if (text == null)
		{
			return null;
		}
		if (text.Length == 0)
		{
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder(text.Length);
		ParseState parseState = ParseState.Text;
		StringBuilder stringBuilder2 = new StringBuilder(10);
		for (int i = 0; i < text.Length; i++)
		{
			switch (parseState)
			{
			case ParseState.EntityStart:
				switch (text[i])
				{
				case ';':
					if (stringBuilder2.Length == 0)
					{
						stringBuilder.Append("&;");
					}
					else
					{
						int value2;
						if (stringBuilder2[0] == '#')
						{
							string text2 = stringBuilder2.ToString();
							try
							{
								string text3 = text2.Substring(1).Trim();
								int fromBase;
								if (text3.StartsWith("x", StringComparison.OrdinalIgnoreCase))
								{
									fromBase = 16;
									text3 = text3.Substring(1);
								}
								else
								{
									fromBase = 10;
								}
								int value = Convert.ToInt32(text3, fromBase);
								stringBuilder.Append(Convert.ToChar(value));
							}
							catch
							{
								stringBuilder.Append("&#" + text2 + ";");
							}
						}
						else if (!_entityValue.TryGetValue(stringBuilder2.ToString(), out value2))
						{
							stringBuilder.Append("&" + stringBuilder2?.ToString() + ";");
						}
						else
						{
							stringBuilder.Append(Convert.ToChar(value2));
						}
						stringBuilder2.Remove(0, stringBuilder2.Length);
					}
					parseState = ParseState.Text;
					break;
				default:
					stringBuilder2.Append(text[i]);
					if (stringBuilder2.Length > _maxEntitySize)
					{
						parseState = ParseState.Text;
						stringBuilder.Append("&" + stringBuilder2);
						stringBuilder2.Remove(0, stringBuilder2.Length);
					}
					break;
				case '&':
					stringBuilder.Append("&" + stringBuilder2);
					stringBuilder2.Remove(0, stringBuilder2.Length);
					break;
				}
				break;
			case ParseState.Text:
				if (text[i] == '&')
				{
					parseState = ParseState.EntityStart;
				}
				else
				{
					stringBuilder.Append(text[i]);
				}
				break;
			}
		}
		if (parseState == ParseState.EntityStart)
		{
			stringBuilder.Append("&" + stringBuilder2);
		}
		return stringBuilder.ToString();
	}

	public static HtmlNode Entitize(HtmlNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		HtmlNode htmlNode = node.CloneNode(deep: true);
		if (htmlNode.HasAttributes)
		{
			Entitize(htmlNode.Attributes);
		}
		if (htmlNode.HasChildNodes)
		{
			Entitize(htmlNode.ChildNodes);
		}
		else if (htmlNode.NodeType == HtmlNodeType.Text)
		{
			((HtmlTextNode)htmlNode).Text = Entitize(((HtmlTextNode)htmlNode).Text, useNames: true, entitizeQuotAmpAndLtGt: true);
		}
		return htmlNode;
	}

	public static string Entitize(string text)
	{
		return Entitize(text, useNames: true);
	}

	public static string Entitize(string text, bool useNames)
	{
		return Entitize(text, useNames, entitizeQuotAmpAndLtGt: false);
	}

	public static string Entitize(string text, bool useNames, bool entitizeQuotAmpAndLtGt)
	{
		if (text == null)
		{
			return null;
		}
		if (text.Length == 0)
		{
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder(text.Length);
		if (UseWebUtility)
		{
			TextElementEnumerator textElementEnumerator = StringInfo.GetTextElementEnumerator(text);
			while (textElementEnumerator.MoveNext())
			{
				stringBuilder.Append(WebUtility.HtmlEncode(textElementEnumerator.GetTextElement()));
			}
		}
		else
		{
			for (int i = 0; i < text.Length; i++)
			{
				int num = text[i];
				if (num <= 127 && (!entitizeQuotAmpAndLtGt || (num != 34 && num != 38 && num != 60 && num != 62)))
				{
					stringBuilder.Append(text[i]);
					continue;
				}
				string value = null;
				if (useNames)
				{
					EntityName.TryGetValue(num, out value);
				}
				if (value == null)
				{
					stringBuilder.Append("&#" + num + ";");
				}
				else
				{
					stringBuilder.Append("&" + value + ";");
				}
			}
		}
		return stringBuilder.ToString();
	}

	private static void Entitize(HtmlAttributeCollection collection)
	{
		foreach (HtmlAttribute item in (IEnumerable<HtmlAttribute>)collection)
		{
			if (item.Value != null)
			{
				item.Value = Entitize(item.Value);
			}
		}
	}

	private static void Entitize(HtmlNodeCollection collection)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)collection)
		{
			if (item.HasAttributes)
			{
				Entitize(item.Attributes);
			}
			if (item.HasChildNodes)
			{
				Entitize(item.ChildNodes);
			}
			else if (item.NodeType == HtmlNodeType.Text)
			{
				((HtmlTextNode)item).Text = Entitize(((HtmlTextNode)item).Text, useNames: true, entitizeQuotAmpAndLtGt: true);
			}
		}
	}
}
