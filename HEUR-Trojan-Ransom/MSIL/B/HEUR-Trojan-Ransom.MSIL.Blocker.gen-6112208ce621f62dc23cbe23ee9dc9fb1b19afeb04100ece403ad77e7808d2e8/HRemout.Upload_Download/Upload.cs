using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HRemout.Upload_Download;

internal class Upload
{
	public static string GET(string Url, string Data)
	{
		StreamReader streamReader = new StreamReader(WebRequest.Create(Url + "?" + Data).GetResponse().GetResponseStream());
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		return result;
	}

	public static void PostRequest(string url, string dat)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		string s = "message=1";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		httpWebRequest.KeepAlive = true;
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application / x - www - form - urlencoded";
		httpWebRequest.ContentLength = bytes.Length;
		using (Stream stream = httpWebRequest.GetRequestStream())
		{
			stream.Write(bytes, 0, bytes.Length);
		}
		string text = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()).ReadToEnd();
		Console.WriteLine(text);
		if (text.Contains("Авторизация прошла успешно"))
		{
			MessageBox.Show("Авторизованы!");
		}
		else
		{
			MessageBox.Show("Не удалось авторизоваться!");
		}
	}

	public static void sndData(string url, string mes)
	{
		try
		{
			byte[] bytes = new ASCIIEncoding().GetBytes(mes);
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = "POST";
			webRequest.ContentType = "application/x-www-form-urlencoded";
			webRequest.ContentLength = bytes.Length;
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			Stream responseStream = webRequest.GetResponse().GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			Console.WriteLine(streamReader.ReadToEnd());
			streamReader.Close();
			responseStream.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
