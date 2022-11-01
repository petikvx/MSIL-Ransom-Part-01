using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;
using VirusTotalNET.Exceptions;
using VirusTotalNET.Objects;

namespace com.poweriwb.PowerDesk.VirusTotalNET;

public class VirusTotal
{
	public const long FileSizeLimit = 33553369L;

	private readonly RestClient _client = new RestClient();

	private readonly string _apiKey;

	private bool _useTls;

	private int _retryCounter;

	private int _retry;

	private bool bUseDemoLicense;

	public bool UseTLS
	{
		get
		{
			return _useTls;
		}
		set
		{
			_useTls = value;
			string text = ApiUrl;
			if (!string.IsNullOrWhiteSpace(text))
			{
				if (text.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase))
				{
					text = text.Substring(8);
				}
				else if (text.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase))
				{
					text = text.Substring(7);
				}
				_client.set_BaseUrl(_useTls ? new Uri("https://" + text) : new Uri("http://" + text));
			}
		}
	}

	public IWebProxy Proxy
	{
		get
		{
			return _client.get_Proxy();
		}
		set
		{
			_client.set_Proxy(value);
		}
	}

	public int Retry
	{
		get
		{
			return _retry;
		}
		set
		{
			_retry = value;
			_retryCounter = value;
		}
	}

	public int Timeout
	{
		get
		{
			return _client.get_Timeout();
		}
		set
		{
			_client.set_Timeout(value);
		}
	}

	public string ApiUrl
	{
		get
		{
			return _client.get_BaseUrl().ToString();
		}
		set
		{
			string text = value.Trim();
			if (!string.IsNullOrWhiteSpace(text))
			{
				if (text.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase))
				{
					_useTls = true;
					text = text.Substring(8);
				}
				else if (text.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase))
				{
					_useTls = false;
					text = text.Substring(7);
				}
				else
				{
					_useTls = true;
				}
				_client.set_BaseUrl(_useTls ? new Uri("https://" + text) : new Uri("http://" + text));
			}
		}
	}

	public VirusTotal(string apiKey)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		if (string.IsNullOrEmpty(apiKey) || apiKey.Length < 64)
		{
			throw new ArgumentException("You have to set an API key.", "apiKey");
		}
		ApiUrl = "www.virustotal.com/vtapi/v2/";
		_useTls = true;
		_apiKey = apiKey;
		_client.set_FollowRedirects(false);
		Retry = 3;
	}

	public ScanResult ScanFile(FileInfo file)
	{
		if (!file.Exists)
		{
			throw new FileNotFoundException("The file was not found.", file.Name);
		}
		byte[] file2 = File.ReadAllBytes(file.FullName);
		return ScanFile(file2, file.Name);
	}

	public ScanResult ScanFile(byte[] file, string filename)
	{
		if (file == null || file.Length <= 0)
		{
			throw new ArgumentException("You must provide a file", "file");
		}
		if (file.Length > 33553369L)
		{
			throw new SizeLimitException($"The filesize limit on VirusTotal is {32766L} KB. Your file is {file.Length / 1024} KB");
		}
		if (string.IsNullOrWhiteSpace(filename))
		{
			throw new ArgumentException("You must provide a filename. Preferably the original filename.");
		}
		RestRequest val = PrepareRequest("file/scan", (Method)1);
		val.AddFile("file", file, filename);
		return GetResults<ScanResult>(val);
	}

	public IEnumerable<ScanResult> ScanFiles(IEnumerable<Tuple<byte[], string>> files)
	{
		foreach (Tuple<byte[], string> fileInfo in files)
		{
			yield return ScanFile(fileInfo.Item1, fileInfo.Item2);
		}
	}

	public IEnumerable<ScanResult> ScanFiles(IEnumerable<FileInfo> files)
	{
		foreach (FileInfo fileInfo in files)
		{
			yield return ScanFile(fileInfo);
		}
	}

	public ScanResult RescanFile(string resource)
	{
		return RescanFiles(new string[1] { resource }).FirstOrDefault();
	}

	public ScanResult RescanFile(FileInfo file)
	{
		return RescanFiles(new FileInfo[1] { file }).FirstOrDefault();
	}

	public ScanResult RescanFile(byte[] file)
	{
		return RescanFiles(new byte[1][] { file }).FirstOrDefault();
	}

	public List<ScanResult> RescanFiles(IEnumerable<FileInfo> files)
	{
		return RescanFiles(GetResourcesFromFiles(files));
	}

	public List<ScanResult> RescanFiles(IEnumerable<byte[]> files)
	{
		return RescanFiles(GetResourcesFromFiles(files));
	}

	public List<ScanResult> RescanFiles(IEnumerable<string> resourceList)
	{
		string[] array = (resourceList as string[]) ?? resourceList.ToArray();
		if (!array.Any())
		{
			throw new Exception("You have to supply a resource.");
		}
		if (array.Length > 25)
		{
			throw new Exception("Too many hashes. There is a maximum of 25 hashes.");
		}
		for (int i = 0; i < array.Length; i++)
		{
			ValidateResource(array[i]);
		}
		RestRequest val = PrepareRequest("file/rescan", (Method)1);
		val.AddParameter("resource", (object)string.Join(",", array));
		return GetResults<List<ScanResult>>(val);
	}

	public FileReport GetFileReport(byte[] file)
	{
		return GetFileReport(HashHelper.GetSHA256(file));
	}

	public FileReport GetFileReport(FileInfo file)
	{
		return GetFileReport(HashHelper.GetSHA256(file));
	}

	public FileReport GetFileReport(string resource)
	{
		return GetFileReports(new string[1] { resource }).First();
	}

	public List<FileReport> GetFileReports(IEnumerable<byte[]> files)
	{
		return GetFileReports(GetResourcesFromFiles(files));
	}

	public List<FileReport> GetFileReports(IEnumerable<FileInfo> files)
	{
		return GetFileReports(GetResourcesFromFiles(files));
	}

	public List<FileReport> GetFileReports(IEnumerable<string> resourceList)
	{
		string[] array = (resourceList as string[]) ?? resourceList.ToArray();
		if (!array.Any())
		{
			throw new ArgumentException("You have to supply a resource.");
		}
		for (int i = 0; i < array.Length; i++)
		{
			ValidateResource(array[i]);
		}
		RestRequest val = PrepareRequest("file/report", (Method)1);
		val.AddParameter("resource", (object)string.Join(",", array));
		return GetResults<List<FileReport>>(val, applyHack: true);
	}

	public ScanResult ScanUrl(string url)
	{
		return ScanUrls(UrlToUri(new string[1] { url })).FirstOrDefault();
	}

	public ScanResult ScanUrl(Uri url)
	{
		return ScanUrls(new Uri[1] { url }).FirstOrDefault();
	}

	public List<ScanResult> ScanUrls(IEnumerable<string> urlList)
	{
		return ScanUrls(UrlToUri(urlList));
	}

	public List<ScanResult> ScanUrls(IEnumerable<Uri> urlList)
	{
		IEnumerable<Uri> enumerable = (urlList as Uri[]) ?? urlList.ToArray();
		if (!enumerable.Any())
		{
			throw new Exception("You have to supply an URL.");
		}
		RestRequest val = PrepareRequest("url/scan", (Method)1);
		val.AddParameter("url", (object)string.Join(Environment.NewLine, enumerable));
		return GetResults<List<ScanResult>>(val);
	}

	public UrlReport GetUrlReport(string url, bool scanIfNoReport = false)
	{
		return GetUrlReports(UrlToUri(new string[1] { url }), scanIfNoReport).FirstOrDefault();
	}

	public UrlReport GetUrlReport(Uri url, bool scanIfNoReport = false)
	{
		return GetUrlReports(new Uri[1] { url }, scanIfNoReport).First();
	}

	public List<UrlReport> GetUrlReports(IEnumerable<string> urlList, bool scanIfNoReport = false)
	{
		return GetUrlReports(UrlToUri(urlList), scanIfNoReport);
	}

	public List<UrlReport> GetUrlReports(IEnumerable<Uri> urlList, bool scanIfNoReport = false)
	{
		IEnumerable<Uri> enumerable = (urlList as Uri[]) ?? urlList.ToArray();
		if (!enumerable.Any())
		{
			throw new Exception("You have to supply an URL.");
		}
		RestRequest val = PrepareRequest("url/report", (Method)1);
		val.AddParameter("resource", (object)string.Join(Environment.NewLine, enumerable));
		if (scanIfNoReport)
		{
			val.AddParameter("scan", (object)1);
		}
		return GetResults<List<UrlReport>>(val, applyHack: true);
	}

	public IPReport GetIPReport(string ip)
	{
		return GetIPReport(IPAddress.Parse(ip));
	}

	public IPReport GetIPReport(IPAddress ip)
	{
		if (ip == null)
		{
			throw new Exception("You have to supply an IP.");
		}
		if (ip.AddressFamily != AddressFamily.InterNetwork)
		{
			throw new Exception("Only IPv4 addresses are supported");
		}
		RestRequest val = PrepareRequest("ip-address/report", (Method)0);
		val.AddParameter("ip", (object)ip.ToString());
		return GetResults<IPReport>(val);
	}

	public DomainReport GetDomainReport(string domain)
	{
		if (string.IsNullOrWhiteSpace(domain))
		{
			throw new Exception("You have to supply a domain.");
		}
		RestRequest val = PrepareRequest("domain/report", (Method)0);
		val.AddParameter("domain", (object)domain);
		return GetResults<DomainReport>(val);
	}

	public ScanResult CreateComment(byte[] file, string comment)
	{
		return CreateComment(HashHelper.GetSHA256(file), comment);
	}

	public ScanResult CreateComment(FileInfo file, string comment)
	{
		return CreateComment(HashHelper.GetSHA256(file), comment);
	}

	public ScanResult CreateComment(string resource, string comment)
	{
		ValidateResource(resource);
		if (string.IsNullOrWhiteSpace(comment))
		{
			throw new ArgumentException("Comment must not be null or whitespace", "comment");
		}
		RestRequest val = PrepareRequest("comments/put", (Method)1);
		val.AddParameter("resource", (object)resource);
		val.AddParameter("comment", (object)comment);
		return GetResults<ScanResult>(val);
	}

	public string GetPublicFileScanLink(string resource)
	{
		ValidateResource(resource);
		return string.Format("{0}://www.virustotal.com/file/{1}/analysis/", UseTLS ? "https" : "http", resource);
	}

	public string GetPublicFileScanLink(FileInfo file)
	{
		return GetPublicFileScanLink(HashHelper.GetSHA256(file));
	}

	public string GetPublicUrlScanLink(string url)
	{
		return string.Format("{0}://www.virustotal.com/#/url/{1}/detection", UseTLS ? "https" : "http", HashHelper.GetSHA256(NormalizeUrl(url)));
	}

	private RestRequest PrepareRequest(string path, Method methodType = 1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		RestRequest val = new RestRequest(path, methodType);
		val.AddParameter("apikey", (object)_apiKey);
		return val;
	}

	private T GetResults<T>(RestRequest request, bool applyHack = false)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		if (bUseDemoLicense)
		{
			delay25sec();
		}
		RestResponse val = (RestResponse)_client.Execute((IRestRequest)(object)request);
		while (((RestResponseBase)val).get_StatusCode() == HttpStatusCode.NoContent)
		{
			bUseDemoLicense = true;
			delay25sec();
			val = (RestResponse)_client.Execute((IRestRequest)(object)request);
		}
		if (((RestResponseBase)val).get_StatusCode() == HttpStatusCode.Forbidden)
		{
			throw new AccessDeniedException("You don't have access to the service. Make sure your API key is working correctly.");
		}
		if (((RestResponseBase)val).get_ErrorException() != null)
		{
			throw ((RestResponseBase)val).get_ErrorException();
		}
		if (((RestResponseBase)val).get_StatusCode() != HttpStatusCode.OK)
		{
			throw new Exception("API gave error code " + ((RestResponseBase)val).get_StatusCode());
		}
		if (string.IsNullOrWhiteSpace(((RestResponseBase)val).get_Content()))
		{
			throw new Exception("There were no content in the response.");
		}
		if (applyHack)
		{
			((RestResponseBase)val).set_Content(Regex.Replace(((RestResponseBase)val).get_Content(), "\"([\\w\\d -\\._]+)\": \\{\"detected\":", "{\"name\": \"$1\", \"detected\":", RegexOptions.Compiled | RegexOptions.CultureInvariant));
			((RestResponseBase)val).set_Content(((RestResponseBase)val).get_Content().Replace("scans\": {", "scans\": ["));
			((RestResponseBase)val).set_Content(((RestResponseBase)val).get_Content().Replace("}}", "}]"));
		}
		IDeserializer val2 = (IDeserializer)new JsonDeserializer();
		T result;
		try
		{
			result = val2.Deserialize<T>((IRestResponse)(object)val);
		}
		catch (SerializationException)
		{
			try
			{
				_retryCounter--;
				if (_retryCounter <= 0)
				{
					_retryCounter = Retry;
					return default(T);
				}
				result = GetResults<T>(request, applyHack);
			}
			catch (SerializationException innerException)
			{
				throw new Exception("Failed to deserialize request.", innerException);
			}
		}
		_retryCounter = Retry;
		return result;
	}

	private static void delay25sec()
	{
		int num = Environment.TickCount + 25000;
		for (int i = 0; i < 100; i++)
		{
			CNativeWIN32.Sleep(100);
			Application.DoEvents();
			if (num < Environment.TickCount)
			{
				break;
			}
		}
	}

	private string NormalizeUrl(string url)
	{
		if (!url.ToLower().StartsWith("http://") && !url.ToLower().StartsWith("https://"))
		{
			url = "http://" + url;
		}
		return new Uri(url).ToString();
	}

	private IEnumerable<string> GetResourcesFromFiles(IEnumerable<FileInfo> files)
	{
		foreach (FileInfo fileInfo in files)
		{
			yield return HashHelper.GetSHA256(fileInfo);
		}
	}

	private IEnumerable<string> GetResourcesFromFiles(IEnumerable<byte[]> files)
	{
		foreach (byte[] fileBytes in files)
		{
			yield return HashHelper.GetSHA256(fileBytes);
		}
	}

	private IEnumerable<Uri> UrlToUri(IEnumerable<string> urls)
	{
		foreach (string url in urls)
		{
			Uri uri;
			try
			{
				string text = url.Trim();
				if (!text.StartsWith("http://") && !text.StartsWith("https://"))
				{
					text = "http://" + text;
				}
				uri = new Uri(text);
			}
			catch (Exception innerException)
			{
				throw new Exception("There was an error converting " + url + " to an uri. See InnerException for details.", innerException);
			}
			yield return uri;
		}
	}

	private void ValidateResource(string resource)
	{
		if (string.IsNullOrWhiteSpace(resource))
		{
			throw new ArgumentException("Resource must not be null or whitespace", "resource");
		}
		if (resource.Length != 32 && resource.Length != 40 && resource.Length != 64 && resource.Length != 75)
		{
			throw new InvalidResourceException("Resource " + resource + " has to be either a MD5, SHA1, SHA256 or scan id");
		}
	}
}
