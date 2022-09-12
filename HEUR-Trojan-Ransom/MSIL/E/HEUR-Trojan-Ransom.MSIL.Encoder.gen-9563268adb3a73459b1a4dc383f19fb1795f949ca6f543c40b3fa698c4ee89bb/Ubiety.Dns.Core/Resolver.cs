using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Ubiety.Dns.Core.Common;

namespace Ubiety.Dns.Core;

public class Resolver
{
	public delegate void VerboseEventHandler(object sender, VerboseEventArgs e);

	private readonly Dictionary<string, Response> _responseCache;

	private int _retries;

	private int _timeout;

	private ushort _unique;

	private bool _useCache;

	public static string Version => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;

	public static List<IPEndPoint> DefaultDnsServers => new List<IPEndPoint>
	{
		new IPEndPoint(IPAddress.Parse("208.67.222.222"), DefaultPort),
		new IPEndPoint(IPAddress.Parse("208.67.220.220"), DefaultPort)
	};

	public static int DefaultPort { get; set; } = 53;


	public int Timeout
	{
		get
		{
			return _timeout;
		}
		set
		{
			_timeout = value * 1000;
		}
	}

	public int Retries
	{
		get
		{
			return _retries;
		}
		set
		{
			if (value >= 1)
			{
				_retries = value;
			}
		}
	}

	public bool Recursion { get; set; }

	public TransportType TransportType { get; set; }

	public List<IPEndPoint> DnsServers { get; }

	public string DnsServer
	{
		get
		{
			return DnsServers[0].Address.ToString();
		}
		set
		{
			if (IPAddress.TryParse(value, out var address))
			{
				DnsServers.Clear();
				DnsServers.Add(new IPEndPoint(address, DefaultPort));
				return;
			}
			Response response = Query(value, QuestionType.A);
			if (response.RecordA.Count > 0)
			{
				DnsServers.Clear();
				DnsServers.Add(new IPEndPoint(response.RecordA[0].Address, DefaultPort));
			}
		}
	}

	public bool UseCache
	{
		get
		{
			return _useCache;
		}
		set
		{
			_useCache = value;
			if (!_useCache)
			{
				lock (_responseCache)
				{
					_responseCache.Clear();
				}
			}
		}
	}

	public event VerboseEventHandler OnVerbose;

	public Resolver(IEnumerable<IPEndPoint> dnsServers)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[16];
		rNGCryptoServiceProvider.GetBytes(array);
		_responseCache = new Dictionary<string, Response>();
		DnsServers = new List<IPEndPoint>();
		DnsServers.AddRange(dnsServers);
		_unique = BitConverter.ToUInt16(array, 0);
		_retries = 3;
		_timeout = 1;
		Recursion = true;
		_useCache = true;
		TransportType = TransportType.Udp;
		rNGCryptoServiceProvider.Dispose();
	}

	public Resolver(IPEndPoint dnsServer)
		: this(new IPEndPoint[1] { dnsServer })
	{
	}

	public Resolver(IPAddress serverIpAddress, int serverPortNumber)
		: this(new IPEndPoint(serverIpAddress, serverPortNumber))
	{
	}

	public Resolver(string serverIpAddress, int serverPortNumber)
		: this(IPAddress.Parse(serverIpAddress), serverPortNumber)
	{
	}

	public Resolver(string serverIpAddress)
		: this(IPAddress.Parse(serverIpAddress), DefaultPort)
	{
	}

	public Resolver()
		: this(GetSystemDnsServers())
	{
	}

	public static IEnumerable<IPEndPoint> GetSystemDnsServers()
	{
		List<IPEndPoint> list = new List<IPEndPoint>();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (networkInterface.OperationalStatus != OperationalStatus.Up)
			{
				continue;
			}
			IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
			foreach (IPAddress dnsAddress in iPProperties.DnsAddresses)
			{
				IPEndPoint item = new IPEndPoint(dnsAddress, DefaultPort);
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		return list.ToArray();
	}

	public static string GetArpaFromIp(IPAddress ip)
	{
		switch (ip.AddressFamily)
		{
		default:
			return "?";
		case AddressFamily.InterNetworkV6:
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("ip6.arpa.");
			byte[] addressBytes2 = ip.GetAddressBytes();
			foreach (byte b2 in addressBytes2)
			{
				stringBuilder2.Insert(0, $"{(b2 >> 4) & 0xF:x}.");
				stringBuilder2.Insert(0, $"{b2 & 0xF:x}.");
			}
			return stringBuilder2.ToString();
		}
		case AddressFamily.InterNetwork:
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("in-addr.arpa.");
			byte[] addressBytes = ip.GetAddressBytes();
			foreach (byte b in addressBytes)
			{
				stringBuilder.Insert(0, $"{b}.");
			}
			return stringBuilder.ToString();
		}
		}
	}

	public static string GetArpaFromEnum(string enumerator)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = Regex.Replace(enumerator, "[^0-9]", string.Empty);
		stringBuilder.Append("e164.arpa.");
		string text2 = text;
		foreach (char c in text2)
		{
			stringBuilder.Insert(0, $"{c}.");
		}
		return stringBuilder.ToString();
	}

	public void ClearCache()
	{
		lock (_responseCache)
		{
			_responseCache.Clear();
		}
	}

	public Response Query(string name, QuestionType qtype, QuestionClass qclass)
	{
		Question question = new Question(name, qtype, qclass);
		Response response = SearchInCache(question);
		if (response != null)
		{
			return response;
		}
		Request request = new Request();
		request.AddQuestion(question);
		return GetResponse(request);
	}

	public Response Query(string name, QuestionType qtype)
	{
		Question question = new Question(name, qtype, QuestionClass.IN);
		Response response = SearchInCache(question);
		if (response != null)
		{
			return response;
		}
		Request request = new Request();
		request.AddQuestion(question);
		return GetResponse(request);
	}

	private static void WriteRequest(Stream stream, Request request)
	{
		byte[] data = request.GetData();
		stream.WriteByte((byte)((uint)(data.Length >> 8) & 0xFFu));
		stream.WriteByte((byte)((uint)data.Length & 0xFFu));
		stream.Write(data, 0, data.Length);
		stream.Flush();
	}

	private Response GetResponse(Request request)
	{
		request.Header.Id = _unique;
		request.Header.Recursion = Recursion;
		return TransportType switch
		{
			TransportType.Tcp => TcpRequest(request), 
			TransportType.Udp => UdpRequest(request), 
			_ => new Response
			{
				Error = "Unknown TransportType"
			}, 
		};
	}

	private void Verbose(string format, params object[] args)
	{
		this.OnVerbose?.Invoke(this, new VerboseEventArgs(string.Format(CultureInfo.CurrentCulture, format, args)));
	}

	private Response SearchInCache(Question question)
	{
		if (!_useCache)
		{
			return null;
		}
		string key = question.QuestionClass.ToString() + "-" + question.QuestionType.ToString() + "-" + question.QuestionName;
		Response response;
		lock (_responseCache)
		{
			if (!_responseCache.ContainsKey(key))
			{
				return null;
			}
			response = _responseCache[key];
		}
		int timeLived = (int)((DateTime.Now.Ticks - response.TimeStamp.Ticks) / 10000000L);
		foreach (ResourceRecord resourceRecord in response.ResourceRecords)
		{
			resourceRecord.TimeLived = timeLived;
			if (resourceRecord.Ttl == 0)
			{
				return null;
			}
		}
		return response;
	}

	private void AddToCache(Response response)
	{
		if (!_useCache || response.Questions.Count == 0 || response.Header.ResponseCode != 0)
		{
			return;
		}
		Question question = response.Questions[0];
		string key = question.QuestionClass.ToString() + "-" + question.QuestionType.ToString() + "-" + question.QuestionName;
		lock (_responseCache)
		{
			if (_responseCache.ContainsKey(key))
			{
				_responseCache.Remove(key);
			}
			_responseCache.Add(key, response);
		}
	}

	private Response UdpRequest(Request request)
	{
		byte[] array = new byte[512];
		for (int i = 0; i < _retries; i++)
		{
			for (int j = 0; j < DnsServers.Count; j++)
			{
				Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, Timeout);
				try
				{
					socket.SendTo(request.GetData(), DnsServers[j]);
					int num = socket.Receive(array);
					byte[] array2 = new byte[num];
					Array.Copy(array, array2, num);
					Response response = new Response(DnsServers[j], array2);
					AddToCache(response);
					return response;
				}
				catch (SocketException)
				{
					Verbose($";; Connection to nameserver {j + 1} failed");
				}
				finally
				{
					_unique++;
					socket.Close();
				}
			}
		}
		return new Response
		{
			Error = "Timeout Error"
		};
	}

	private Response TcpRequest(Request request)
	{
		for (int i = 0; i < _retries; i++)
		{
			for (int j = 0; j < DnsServers.Count; j++)
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.ReceiveTimeout = Timeout * 1000;
				try
				{
					IAsyncResult asyncResult = tcpClient.BeginConnect(DnsServers[5].Address, DnsServers[j].Port, null, null);
					if (!asyncResult.AsyncWaitHandle.WaitOne(Timeout * 1000, exitContext: true) || !tcpClient.Connected)
					{
						tcpClient.Close();
						Verbose($";; Connection to nameserver {j + 1} failed");
						continue;
					}
					BufferedStream bufferedStream = new BufferedStream(tcpClient.GetStream());
					byte[] data = request.GetData();
					bufferedStream.WriteByte((byte)((uint)(data.Length >> 8) & 0xFFu));
					bufferedStream.WriteByte((byte)((uint)data.Length & 0xFFu));
					bufferedStream.Write(data, 0, data.Length);
					bufferedStream.Flush();
					Response response = new Response();
					int num = 0;
					int num2 = 0;
					do
					{
						int num3 = (bufferedStream.ReadByte() << 8) | bufferedStream.ReadByte();
						if (num3 > 0)
						{
							num2 += num3;
							data = new byte[num3];
							bufferedStream.Read(data, 0, num3);
							Response response2 = new Response(DnsServers[j], data);
							if (response2.Header.ResponseCode == ResponseCode.NoError)
							{
								if (response2.Questions[0].QuestionType == QuestionType.AXFR)
								{
									if (response.Questions.Count == 0)
									{
										response.Questions.AddRange(response2.Questions);
									}
									response.Answers.AddRange(response2.Answers);
									response.Authorities.AddRange(response2.Authorities);
									response.Additionals.AddRange(response2.Additionals);
									if (response2.Answers[0].Type == RecordType.SOA)
									{
										num++;
									}
									continue;
								}
								AddToCache(response2);
								return response2;
							}
							return response2;
						}
						tcpClient.Close();
						Verbose($";; Connection to nameserver {j + 1} failed");
						throw new SocketException();
					}
					while (num != 2);
					response.Header.QuestionCount = (ushort)response.Questions.Count;
					response.Header.AnswerCount = (ushort)response.Answers.Count;
					response.Header.AdditionalRecordsCount = (ushort)response.Additionals.Count;
					response.MessageSize = num2;
					return response;
				}
				catch (SocketException)
				{
				}
				finally
				{
					_unique++;
					tcpClient.Close();
				}
			}
		}
		Response response3 = new Response();
		response3.Error = "Timeout Error";
		return response3;
	}

	private Response ReceiveResponse(Stream stream, IPEndPoint server)
	{
		Response response = new Response();
		int num = 0;
		int num2 = 0;
		do
		{
			int num3 = (stream.ReadByte() << 8) | stream.ReadByte();
			if (num3 > 0)
			{
				num2 += num3;
				byte[] array = new byte[num3];
				stream.Read(array, 0, num3);
				Response response2 = new Response(server, array);
				if (response2.Header.ResponseCode == ResponseCode.NoError)
				{
					if (response2.Questions[0].QuestionType == QuestionType.AXFR)
					{
						if (response.Questions.Count == 0)
						{
							response.Questions.AddRange(response2.Questions);
						}
						response.Answers.AddRange(response2.Answers);
						response.Authorities.AddRange(response2.Authorities);
						response.Additionals.AddRange(response2.Additionals);
						if (response2.Answers[0].Type == RecordType.SOA)
						{
							num++;
						}
						continue;
					}
					AddToCache(response2);
					return response2;
				}
				return response2;
			}
			Verbose($"Connection to nameserver {server.Address} failed");
			throw new SocketException();
		}
		while (num != 2);
		response.Header.QuestionCount = (ushort)response.Questions.Count;
		response.Header.AnswerCount = (ushort)response.Answers.Count;
		response.Header.NameserverCount = (ushort)response.Authorities.Count;
		response.Header.AdditionalRecordsCount = (ushort)response.Additionals.Count;
		response.MessageSize = num2;
		return response;
	}
}
