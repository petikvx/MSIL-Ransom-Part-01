using System;
using System.IO;
using System.Net;

namespace stockChartUserUpdate;

internal class FTPClient
{
	public void DownloadFile(string url, string fileName)
	{
		Stream stream = null;
		FileStream fileStream = null;
		StreamReader streamReader = null;
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
			FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
			stream = ftpWebResponse.GetResponseStream();
			if (fileName.Length == 0)
			{
				streamReader = new StreamReader(stream);
				Console.WriteLine(streamReader.ReadToEnd());
			}
			else
			{
				fileStream = File.Create(fileName);
				byte[] array = new byte[1024];
				while (true)
				{
					int num = stream.Read(array, 0, array.Length);
					if (num == 0)
					{
						break;
					}
					fileStream.Write(array, 0, num);
				}
			}
			stream?.Close();
			Console.WriteLine("完成下載檔案.");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.StackTrace!.ToString());
		}
		finally
		{
			streamReader?.Close();
			stream?.Close();
			fileStream?.Close();
		}
	}

	public void UploadFile(string fileName, string url)
	{
		FtpWebResponse ftpWebResponse = null;
		Stream stream = null;
		FileStream fileStream = null;
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
			ftpWebRequest.Method = "STOR";
			stream = ftpWebRequest.GetRequestStream();
			fileStream = File.Open(fileName, FileMode.Open);
			byte[] array = new byte[1024];
			while (true)
			{
				int num = fileStream.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				stream.Write(array, 0, num);
			}
			stream.Close();
			Console.WriteLine("完成上傳檔案.");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.StackTrace!.ToString());
		}
		finally
		{
			ftpWebResponse?.Close();
			stream?.Close();
			fileStream?.Close();
		}
	}

	public string ListDirectory(string url)
	{
		StreamReader streamReader = null;
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
			ftpWebRequest.Method = "NLST";
			FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
			streamReader = new StreamReader(ftpWebResponse.GetResponseStream());
			string result = streamReader.ReadToEnd();
			streamReader?.Close();
			return result;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.StackTrace!.ToString());
			return null;
		}
	}
}
