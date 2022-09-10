using System.Data;
using System.IO;
using System.Net;

namespace Target;

public class geoLocation
{
	internal class IPdetalis
	{
		public string City = "";

		public string CountryCode = "";

		public string CountryName = "";

		public string IP = "";

		public string Latitude = "";

		public string Longitude = "";

		public string MetroCode = "";

		public string RegionCode = "";

		public string ZipCode = "";
	}

	public string GetMyIP()
	{
		string text = string.Empty;
		string text2 = null;
		try
		{
			WebRequest webRequest = WebRequest.Create("http://ipv4.test-ipv6.com/ip/?callback=_jqjsp&asn=1&testdomain=test-ipv6.com&testname=test_asn4");
			webRequest.Method = "GET";
			using (StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
			{
				text = streamReader.ReadToEnd();
			}
			text2 = text.Split(new char[1] { ',' })[0].Split(new char[1] { ':' })[1].Replace("\"", "") + "\n";
			text2 += text.Split(new char[1] { ',' })[6].Replace("\"", "");
		}
		catch
		{
			text2 = null;
		}
		if (string.IsNullOrEmpty(text2))
		{
			try
			{
				WebRequest webRequest2 = WebRequest.Create("http://gd.geobytes.com/GetCityDetails?callback=?");
				webRequest2.Method = "GET";
				using (StreamReader streamReader2 = new StreamReader(webRequest2.GetResponse().GetResponseStream()))
				{
					text = streamReader2.ReadToEnd();
				}
				text2 = text.Split(new char[1] { ',' })[1].Split(new char[1] { ':' })[1].Replace("\"", "") + "\n";
				text2 += text.Split(new char[1] { ',' })[4].Split(new char[1] { ':' })[1].Replace("\"", "");
			}
			catch
			{
				text2 = null;
			}
		}
		if (string.IsNullOrEmpty(text2))
		{
			try
			{
				WebRequest webRequest3 = WebRequest.Create("http://www.geoplugin.net/json.gp?jsoncallback=?");
				webRequest3.Method = "GET";
				using (StreamReader streamReader3 = new StreamReader(webRequest3.GetResponse().GetResponseStream()))
				{
					text = streamReader3.ReadToEnd();
				}
				text2 = text.Split(new char[1] { ',' })[0].Split(new char[1] { ':' })[1].Replace("\"", "") + "\n";
				text2 += text.Split(new char[1] { ',' })[8].Split(new char[1] { ':' })[1].Replace("\"", "");
			}
			catch
			{
				text2 = null;
			}
		}
		if (string.IsNullOrEmpty(text2))
		{
			try
			{
				DataSet dataSet = new DataSet();
				try
				{
					WebClient webClient = new WebClient();
					MemoryStream stream = new MemoryStream(webClient.DownloadData("http://freegeoip.net/xml/"));
					dataSet.ReadXml((Stream?)stream);
				}
				catch
				{
				}
				new IPdetalis();
				if (dataSet.Tables[0].Rows.Count > 0)
				{
					text2 = dataSet.Tables[0].Rows[0]["Ip"].ToString() + "\n";
					text2 += dataSet.Tables[0].Rows[0]["CountryCode"].ToString();
				}
			}
			catch
			{
				text2 = null;
			}
		}
		return text2;
	}
}
