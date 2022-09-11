using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using Microsoft.VisualBasic.Devices;

namespace C3904355907;

public class C1801730948
{
	[Serializable]
	[CompilerGenerated]
	private sealed class C3554254475
	{
		public static readonly C3554254475 C3554254475 = new C3554254475();

		public static Func<ManagementObject, object> C3554254475;

		public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> C3554254475;

		public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> C3904355907;

		public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> C1255198513;

		internal object C3554254475(ManagementObject managementObject_0)
		{
			return ((ManagementBaseObject)managementObject_0).GetPropertyValue(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kt());
		}

		internal bool C3554254475(HttpRequestMessage httpRequestMessage_0, X509Certificate2 x509Certificate2_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}

		internal bool C3904355907(HttpRequestMessage httpRequestMessage_0, X509Certificate2 x509Certificate2_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}

		internal bool C1255198513(HttpRequestMessage httpRequestMessage_0, X509Certificate2 x509Certificate2_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private readonly string m_C3554254475;

	public static string C3904355907;

	public static string C1255198513;

	public static string C1908338681;

	public static string C1037565863;

	private static HttpClient m_C3554254475;

	private string C112844655 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jS();

	private static string C2746444292 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jS();

	public static string C2564639436;

	[SpecialName]
	[CompilerGenerated]
	public string C3554254475()
	{
		return this.m_C3554254475;
	}

	public C1801730948(string string_0)
	{
		this.m_C3554254475 = string_0;
		C2746444292 = C112844655;
	}

	public static string C3904355907()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ComputerInfo val = new ComputerInfo();
		ulong num = ulong.Parse(val.get_TotalPhysicalMemory().ToString());
		return (num / 1048576uL + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BA()).ToString();
	}

	public static string C1255198513()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		object obj = (from ManagementObject managementObject_0 in (IEnumerable)new ManagementObjectSearcher(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.js()).Get()
			select ((ManagementBaseObject)managementObject_0).GetPropertyValue(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kt())).FirstOrDefault();
		return (obj != null) ? obj.ToString() : DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jT();
	}

	public static void C3554254475(string string_0)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0129: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		C1801730948.C1037565863 = string_0;
		if (string.IsNullOrEmpty(C1801730948.C3904355907) || string.IsNullOrEmpty(C2746444292))
		{
			throw new ApplicationException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jt());
		}
		HttpClientHandler val = new HttpClientHandler();
		val.set_ServerCertificateCustomValidationCallback((Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>)((HttpRequestMessage httpRequestMessage_0, X509Certificate2 x509Certificate2_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true));
		HttpClient val2 = new HttpClient((HttpMessageHandler)val);
		val2.set_BaseAddress(new Uri(C2746444292));
		C1801730948.m_C3554254475 = val2;
		((HttpHeaders)C1801730948.m_C3554254475.get_DefaultRequestHeaders()).Add(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jU(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ju());
		HttpRequestMessage val3 = new HttpRequestMessage(HttpMethod.get_Post(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
		val3.set_Content((HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)new Dictionary<string, string>
		{
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jV(),
				C1801730948.C3904355907
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jv(),
				Environment.MachineName
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jW(),
				C1801730948.C1255198513
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jw(),
				C1801730948.C1908338681
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jX(),
				C1801730948.C1037565863
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jx(),
				C2564639436
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jY(),
				C3904355907()
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jy(),
				C1255198513()
			}
		}));
		HttpRequestMessage val4 = val3;
		Task<HttpResponseMessage> task = C1801730948.m_C3554254475.SendAsync(val4);
		if (!task.Result.get_IsSuccessStatusCode())
		{
			throw new HttpRequestException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jZ());
		}
		string result = task.Result.get_Content().ReadAsStringAsync().Result;
		DataContractJsonSerializer val5 = new DataContractJsonSerializer(typeof(C655174618));
		using MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(result));
		C655174618 c = (C655174618)((XmlObjectSerializer)val5).ReadObject((Stream)memoryStream);
		if (c.C3554254475())
		{
		}
	}

	public async Task<C655174618> C1908338681()
	{
		if (string.IsNullOrEmpty(C1801730948.C3904355907) || string.IsNullOrEmpty(C112844655))
		{
			throw new ApplicationException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jt());
		}
		HttpClientHandler val = new HttpClientHandler();
		val.set_ServerCertificateCustomValidationCallback((Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>)((HttpRequestMessage httpRequestMessage_0, X509Certificate2 x509Certificate2_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true));
		HttpClient val2 = new HttpClient((HttpMessageHandler)val);
		val2.set_BaseAddress(new Uri(C112844655));
		C1801730948.m_C3554254475 = val2;
		((HttpHeaders)C1801730948.m_C3554254475.get_DefaultRequestHeaders()).Add(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jU(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ju());
		HttpRequestMessage val3 = new HttpRequestMessage(HttpMethod.get_Post(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
		val3.set_Content((HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)new Dictionary<string, string>
		{
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jV(),
				C1801730948.C3904355907
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jv(),
				Environment.MachineName
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jW(),
				C1801730948.C1255198513
			},
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jw(),
				C1801730948.C1908338681
			}
		}));
		HttpRequestMessage val4 = val3;
		HttpResponseMessage val5 = await C1801730948.m_C3554254475.SendAsync(val4);
		if (!val5.get_IsSuccessStatusCode())
		{
			throw new HttpRequestException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jZ());
		}
		string s = await val5.get_Content().ReadAsStringAsync();
		DataContractJsonSerializer val6 = new DataContractJsonSerializer(typeof(C655174618));
		using MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(s));
		C655174618 c = (C655174618)((XmlObjectSerializer)val6).ReadObject((Stream)memoryStream);
		C2564639436 = c.C1037565863();
		return c;
	}

	public static string C1037565863()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(C1801730948.C3904355907) || string.IsNullOrEmpty(C2746444292))
		{
			throw new ApplicationException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jt());
		}
		HttpClientHandler val = new HttpClientHandler();
		val.set_ServerCertificateCustomValidationCallback((Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>)((HttpRequestMessage httpRequestMessage_0, X509Certificate2 x509Certificate2_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true));
		HttpClient val2 = new HttpClient((HttpMessageHandler)val);
		val2.set_BaseAddress(new Uri(C2746444292.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jz(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KA())));
		C1801730948.m_C3554254475 = val2;
		((HttpHeaders)C1801730948.m_C3554254475.get_DefaultRequestHeaders()).Add(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jU(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ju());
		HttpRequestMessage val3 = new HttpRequestMessage(HttpMethod.get_Get(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
		Task<HttpResponseMessage> task = C1801730948.m_C3554254475.SendAsync(val3);
		if (!task.Result.get_IsSuccessStatusCode())
		{
			throw new HttpRequestException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jZ());
		}
		string result = task.Result.get_Content().ReadAsStringAsync().Result;
		string s = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ka();
		SHA256 sHA = SHA256.Create();
		byte[] byte_ = sHA.ComputeHash(Encoding.ASCII.GetBytes(s));
		byte[] byte_2 = new byte[16];
		string[] array = C3463352047.C3554254475(result, byte_, byte_2).Split(new char[1] { '-' });
		C1801730948.C1255198513 = array[0];
		C1801730948.C1908338681 = array[1];
		return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz();
	}
}
