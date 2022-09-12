using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Poshmark_tools;

internal class gecko_requirements
{
	private List<string> files_to_download_gecko = new List<string>();

	private void MakeRequests_gecko()
	{
		if (Request_poshmarktools_com_gecko(out var response))
		{
			string input = ReadResponse_gecko(response);
			files_to_download_gecko = Regex.Split(input, "\n").ToList();
			response.Close();
		}
	}

	private static string ReadResponse_gecko(HttpWebResponse response)
	{
		using Stream stream = response.GetResponseStream();
		Stream stream2 = stream;
		if (response.ContentEncoding.ToLower().Contains("gzip"))
		{
			stream2 = new GZipStream(stream2, CompressionMode.Decompress);
		}
		else if (response.ContentEncoding.ToLower().Contains("deflate"))
		{
			stream2 = new DeflateStream(stream2, CompressionMode.Decompress);
		}
		using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}

	private bool Request_poshmarktools_com_gecko(out HttpWebResponse response)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://poshmarktools.com/support/mpt/geckofx/geckofx_files.txt");
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.109 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public void main_gecko()
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string sourceArchiveFileName = Directory.GetCurrentDirectory() + "\\Firefox.zip";
			string text = Directory.GetCurrentDirectory() + "\\Firefox";
			if (!Directory.Exists(text))
			{
				if (!File.Exists("Firefox.zip"))
				{
					using WebClient webClient = new WebClient();
					webClient.DownloadFile("http://poshmarktools.com/support/mpt/geckofx/Firefox.zip", Directory.GetCurrentDirectory() + "\\Firefox.zip");
				}
				if (File.Exists("Firefox.zip"))
				{
					ZipFile.ExtractToDirectory(sourceArchiveFileName, text);
					try
					{
					}
					catch
					{
					}
				}
			}
			try
			{
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("as_gecko3" + ex.ToString());
		}
	}

	public static void test_threading_gecko(object data)
	{
		string text = (string)data;
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\" + text))
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile("http://poshmarktools.com/support/mpt/geckofx/dlls/" + text, Directory.GetCurrentDirectory() + "\\" + text);
					return;
				}
			}
		}
		catch
		{
		}
	}
}
