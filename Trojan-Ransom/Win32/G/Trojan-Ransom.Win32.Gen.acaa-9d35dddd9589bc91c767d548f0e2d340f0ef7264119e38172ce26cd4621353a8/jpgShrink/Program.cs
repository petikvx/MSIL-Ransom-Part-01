using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace jpgShrink;

internal class Program
{
	private static List<string> l = new List<string>();

	private static long triggerSize = 1638400L;

	private static DateTime DaysBack = DateTime.Now.AddDays(-30.0);

	private static bool UseDaysBack = false;

	private static long OriginalSize = 0L;

	private static long ReducedSize = 0L;

	private static void Main(string[] args)
	{
		string text = string.Empty;
		if (isRegistered())
		{
			if (args.Length > 0)
			{
				foreach (string text2 in args)
				{
					if (text2.Contains(":\\") || text2.Contains("\\\\"))
					{
						text = text2;
						if (!text.EndsWith("\\"))
						{
							text += "\\";
						}
					}
					if (text2.Contains("/30"))
					{
						UseDaysBack = true;
						Console.WriteLine("Using 30 days back");
					}
				}
			}
			else
			{
				text = "C:\\";
			}
			text = text.Replace("\"", string.Empty).Trim();
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				DirectoryInfo[] directories = directoryInfo.GetDirectories("*.*", SearchOption.TopDirectoryOnly);
				if (directories.Length > 0)
				{
					if (!skipdir(directoryInfo))
					{
						DirectoryInfo[] array = directories;
						foreach (DirectoryInfo dinfo in array)
						{
							if (!scanDir(dinfo))
							{
								scanFiles(dinfo);
							}
						}
						scanFiles(directoryInfo);
					}
				}
				else if (!skipdir(directoryInfo))
				{
					scanFiles(directoryInfo);
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (l.Count > 0)
				{
					FileStream fileStream = new FileStream(text + "jpgshrink.csv", FileMode.Create, FileAccess.Write);
					StreamWriter streamWriter = new StreamWriter(fileStream);
					streamWriter.WriteLine("\"Path\",\"Original Height\",\"Original Width\",\"New Height\",\"New Width\",\"Original Size\",\"New Size\",\"Bytes Saved\"");
					foreach (string item in l)
					{
						try
						{
							streamWriter.WriteLine(item);
						}
						catch (Exception ex)
						{
							streamWriter.WriteLine($"Error: {ex.Message} on {item}");
						}
					}
					streamWriter.Close();
					fileStream.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine($"Files processed {l.Count}, bytes Saved {OriginalSize - ReducedSize:n0}");
		}
		else
		{
			Console.WriteLine("Not registered!");
		}
	}

	private static bool isRegistered()
	{
		string text = string.Empty;
		bool result = false;
		try
		{
			using WebClient webClient = new WebClient();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(RemoteCertificateValidationCallback));
			text = webClient.DownloadString("https://x.serverandsoftware.com/Greenspan-jpgshrink.html");
		}
		catch (Exception ex)
		{
			if (!ex.Message.Contains("404"))
			{
				Console.WriteLine(ex.Message);
			}
		}
		if (text != string.Empty)
		{
			result = true;
		}
		return result;
	}

	private static bool RemoteCertificateValidationCallback(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors policyErrors)
	{
		bool result = false;
		try
		{
			if (cert.GetName().Contains("serverandsoftware.com"))
			{
				result = true;
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private static bool scanDir(DirectoryInfo dinfo)
	{
		bool result = false;
		try
		{
			DirectoryInfo[] directories = dinfo.GetDirectories("*.*", SearchOption.TopDirectoryOnly);
			if (!skipdir(dinfo))
			{
				DirectoryInfo[] array = directories;
				foreach (DirectoryInfo dinfo2 in array)
				{
					if (!scanDir(dinfo2))
					{
						scanFiles(dinfo2);
					}
				}
				return result;
			}
			Console.WriteLine("Skipping " + dinfo.FullName);
			result = true;
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private static bool skipdir(DirectoryInfo dinfo)
	{
		bool result = false;
		try
		{
			FileInfo[] files = dinfo.GetFiles("jpgshrink.skip", SearchOption.TopDirectoryOnly);
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (fileInfo.Name == "jpgshrink.skip")
				{
					result = true;
				}
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private static void scanFiles(DirectoryInfo dinfo)
	{
		long num = 0L;
		Image val = null;
		bool flag = false;
		try
		{
			FileInfo[] files = dinfo.GetFiles("*.jp*", SearchOption.TopDirectoryOnly);
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				try
				{
					int num2 = 0;
					int num3 = 0;
					double num4 = 0.0;
					int num5 = 0;
					int num6 = 0;
					num = 0L;
					long num7 = 0L;
					long num8 = 0L;
					val = null;
					if (!fileInfo.Extension.ToUpper().EndsWith("JPG") && !fileInfo.Extension.ToUpper().EndsWith("JPEG"))
					{
						continue;
					}
					if (!UseDaysBack || (UseDaysBack && fileInfo.LastWriteTime >= DaysBack))
					{
						num7 = fileInfo.Length;
						val = Image.FromFile($"{fileInfo.Directory}\\{fileInfo.Name}");
						num2 = val.get_Height();
						num3 = val.get_Width();
						num = num2 * num3;
						if (num > triggerSize)
						{
							OriginalSize += num7;
							if (!flag)
							{
								Console.WriteLine(dinfo.FullName);
								flag = true;
							}
							num4 = ((num3 <= num2) ? (1280.0 / (double)num2) : (1280.0 / (double)num3));
							num5 = Convert.ToInt32((double)num2 * num4);
							num6 = Convert.ToInt32((double)num3 * num4);
							try
							{
								Image val2 = resizeImage(val, new Size(num6, num5));
								val.Dispose();
								val2.Save($"{fileInfo.Directory}\\{fileInfo.Name}", ImageFormat.get_Jpeg());
							}
							catch (Exception)
							{
							}
							try
							{
								FileInfo fileInfo2 = new FileInfo($"{fileInfo.Directory}\\{fileInfo.Name}");
								num8 = fileInfo2.Length;
								ReducedSize += num8;
							}
							catch (Exception)
							{
							}
							l.Add($"\"{fileInfo.Directory}\\{fileInfo.Name}\",{num2},{num3},{num5},{num6},\"{num7:n0}\",\"{num8:n0}\",\"{num7 - num8:n0}\"");
							Console.WriteLine(fileInfo);
						}
					}
					if (val != null)
					{
						val.Dispose();
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static Image resizeImage(Image imgToResize, Size size)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		Bitmap val = null;
		int width = imgToResize.get_Width();
		int height = imgToResize.get_Height();
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		try
		{
			num2 = (float)size.Width / (float)width;
			num3 = (float)size.Height / (float)height;
			num = ((!(num3 < num2)) ? num2 : num3);
			int num4 = (int)((float)width * num);
			int num5 = (int)((float)height * num);
			val = new Bitmap(num4, num5);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.set_InterpolationMode((InterpolationMode)2);
			val2.DrawImage(imgToResize, 0, 0, num4, num5);
			val2.Dispose();
		}
		catch (Exception)
		{
		}
		return (Image)(object)val;
	}

	private static byte[] getMD5(string fn)
	{
		byte[] result = new byte[0];
		try
		{
			using FileStream inputStream = new FileStream(fn, FileMode.Open, FileAccess.Read);
			using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = mD5CryptoServiceProvider.ComputeHash(inputStream);
			result = array;
		}
		catch (Exception)
		{
		}
		return result;
	}

	private static string hex(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}
}
