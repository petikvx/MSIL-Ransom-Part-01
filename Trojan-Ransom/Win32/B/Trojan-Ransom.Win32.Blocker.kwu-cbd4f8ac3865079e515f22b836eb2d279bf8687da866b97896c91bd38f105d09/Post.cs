using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class Post
{
	public enum RequestMethods
	{
		Post,
		Get,
		Request
	}

	public class RandomText
	{
		public static string GenerateRandomString(int length)
		{
			VBMath.Randomize();
			Random random = new Random();
			string text = "";
			checked
			{
				int num = length - 1;
				for (int i = 0; i <= num; i++)
				{
					byte b = (byte)random.Next(65, 122);
					if (b <= 96 && b >= 91)
					{
						i--;
						continue;
					}
					text += Encoding.ASCII.GetString(new byte[1] { b });
				}
				return text;
			}
		}
	}

	public enum RequestUserAgent
	{
		MozillaFireFox,
		InternetExplorer
	}

	public static string UploadImage(string uri, string filePath)
	{
		string text = RandomText.GenerateRandomString(20);
		try
		{
			string randomFileName = Path.GetRandomFileName();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("--" + randomFileName);
			stringBuilder.Append("Content-Disposition: form-data; name=\"uploadedfile\";");
			stringBuilder.AppendFormat("filename=\"{0}\"", text + ".png");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Content-Type: application/octet-stream");
			stringBuilder.AppendLine();
			byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
			byte[] bytes2 = Encoding.ASCII.GetBytes("\r\n--" + randomFileName + "--\r\n");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + randomFileName;
			httpWebRequest.ContentLength = checked(bytes.Length + new FileInfo(filePath).Length + bytes2.Length);
			httpWebRequest.Method = "POST";
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			byte[] array = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(filePath);
			requestStream.Write(array, 0, array.Length);
			requestStream.Write(bytes2, 0, bytes2.Length);
			requestStream.Close();
			httpWebRequest.Abort();
			requestStream.Dispose();
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "An error has occured uploading the image.";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object SendData(Uri url, RequestMethods method, StringBuilder data, RequestUserAgent agent = RequestUserAgent.MozillaFireFox)
	{
		WebRequest webRequest = WebRequest.Create(url);
		byte[] bytes = Encoding.ASCII.GetBytes(data.ToString());
		switch (method)
		{
		default:
			return new Exception("Unknown request method.");
		case RequestMethods.Post:
			webRequest.Method = "POST";
			break;
		case RequestMethods.Get:
			webRequest.Method = "GET";
			break;
		case RequestMethods.Request:
			webRequest.Method = "REQUEST";
			break;
		}
		switch (agent)
		{
		default:
			return new Exception("Unknown user agent.");
		case RequestUserAgent.MozillaFireFox:
			((HttpWebRequest)webRequest).UserAgent = "Mozilla/5.0 (Windows; U; MSIE 7.0; Windows NT 6.0; en-US)";
			break;
		case RequestUserAgent.InternetExplorer:
			((HttpWebRequest)webRequest).UserAgent = "Mozilla/5.0 (Windows; U; MSIE 7.0; Windows NT 6.0; en-US)";
			break;
		}
		webRequest.ContentLength = bytes.Length;
		webRequest.ContentType = "application/x-www-form-urlencoded";
		Stream requestStream = webRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = webRequest.GetResponse();
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd();
	}
}
