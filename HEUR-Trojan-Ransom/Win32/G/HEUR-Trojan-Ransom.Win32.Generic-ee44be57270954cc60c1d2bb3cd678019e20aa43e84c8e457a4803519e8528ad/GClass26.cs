#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security;
using System.Security.Permissions;
using System.Text;

public class GClass26 : GClass25
{
	private static Random random_0 = new Random();

	private DnsPermission dnsPermission_0;

	private int int_0;

	private int int_1 = 5000;

	public int Int32_0 => int_0;

	public int Int32_1
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	public GClass26()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		while (true)
		{
			int num = 1187107958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4274FB41u) % 6u)
				{
				case 5u:
					dnsPermission_0 = new DnsPermission(PermissionState.Unrestricted);
					num = (int)(num2 * 1903200344) ^ -148883033;
					continue;
				case 4u:
					ushort_0 = (ushort)random_0.Next();
					num = ((int)num2 * -622067179) ^ -864815127;
					continue;
				case 2u:
					genum5_0 = GEnum5.Query;
					genum6_0 = GEnum6.QUERY;
					genum7_0 = GEnum7.RD;
					num = ((int)num2 * -288744602) ^ -45975150;
					continue;
				case 0u:
					ushort_1 = 0;
					num = (int)(num2 * 1391393) ^ -1633724335;
					continue;
				case 3u:
					break;
				default:
					ushort_2 = 1;
					return;
				}
				break;
			}
		}
	}

	private byte[] method_0(string string_1)
	{
		int num = 0;
		int num6 = default(int);
		char[] array = default(char[]);
		char[] separator = default(char[]);
		MemoryStream memoryStream = default(MemoryStream);
		char[] array3 = default(char[]);
		string text = default(string);
		byte b = default(byte);
		string[] array2 = default(string[]);
		while (true)
		{
			int num2 = 1696072725;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x29CE49C2u) % 19u)
				{
				case 18u:
					num6 = num + 1;
					num2 = (int)(num3 * 974306532) ^ -1256045186;
					continue;
				case 16u:
					array[0] = '.';
					separator = array;
					num2 = (int)((num3 * 299493574) ^ 0x22DA32AD);
					continue;
				case 15u:
					memoryStream.Write(Encoding.ASCII.GetBytes(array3, 0, array3.Length), 0, array3.Length);
					num2 = (int)((num3 * 355207436) ^ 0x7086C890);
					continue;
				case 14u:
				{
					int num7;
					if (num6 >= text.Length)
					{
						num2 = 1591703080;
						num7 = 1591703080;
					}
					else
					{
						num2 = 1097023339;
						num7 = 1097023339;
					}
					continue;
				}
				case 13u:
					string_1 = string_1.Trim();
					num2 = (int)((num3 * 563347082) ^ 0x144DE919);
					continue;
				case 12u:
				{
					num = text.IndexOf(".", num6);
					int num8;
					if (num != -1)
					{
						num2 = 523648086;
						num8 = 523648086;
					}
					else
					{
						num2 = 643795207;
						num8 = 643795207;
					}
					continue;
				}
				case 11u:
					array3 = text.Substring(num6, b).ToCharArray();
					memoryStream.WriteByte(b);
					num2 = ((int)num3 * -698643362) ^ 0x3272966A;
					continue;
				case 10u:
					text = string_1;
					num2 = 218095382;
					continue;
				case 8u:
					array2 = string_1.Split(separator, 4);
					num2 = (int)(num3 * 309595958) ^ -1050737775;
					continue;
				case 7u:
					b = (byte)(num - num6);
					num2 = 1017600725;
					continue;
				case 6u:
					array = new char[1];
					num2 = (int)(num3 * 1135661349) ^ -1379203859;
					continue;
				case 5u:
					num2 = (int)((num3 * 651700231) ^ 0x2DDFB91A);
					continue;
				case 4u:
					text = $"{array2[3]}.{array2[2]}.{array2[1]}.{array2[0]}.in-addr.arpa";
					num2 = ((int)num3 * -1203909928) ^ -1426853266;
					continue;
				case 3u:
					IPAddress.Parse(string_1);
					num2 = ((int)num3 * -656845540) ^ -773945940;
					continue;
				case 2u:
					num6 = 0;
					memoryStream = new MemoryStream();
					num2 = ((int)num3 * -2099952742) ^ 0x710B4586;
					continue;
				case 1u:
				{
					GEnum2 gEnum = genum2_0;
					int num4;
					int num5;
					if (gEnum != GEnum2.PTR)
					{
						num4 = 1372325633;
						num5 = 1372325633;
					}
					else
					{
						num4 = 1150788738;
						num5 = 1150788738;
					}
					num2 = num4 ^ ((int)num3 * -201963499);
					continue;
				}
				case 0u:
					num = text.Length;
					num2 = (int)(num3 * 142450593) ^ -2036094285;
					continue;
				case 17u:
					break;
				default:
					memoryStream.WriteByte(0);
					return memoryStream.ToArray();
				}
				break;
			}
		}
	}

	public GClass27 method_1(string string_1, GEnum2 genum2_1, GEnum4 genum4_1, ProtocolType protocolType_0)
	{
		return method_2(string_1, genum2_1, genum4_1, protocolType_0, null);
	}

	public GClass27 method_2(string string_1, GEnum2 genum2_1, GEnum4 genum4_1, ProtocolType protocolType_0, GClass29 gclass29_0)
	{
		string text = string.Empty;
		IPAddressCollection iPAddressCollection = default(IPAddressCollection);
		while (true)
		{
			int num = 1061772588;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CB55E65u) % 10u)
				{
				case 9u:
					num = (int)(num2 * 386149087) ^ -794829313;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (!GClass28.smethod_1())
					{
						num4 = 10680136;
						num5 = 10680136;
					}
					else
					{
						num4 = 839583487;
						num5 = 839583487;
					}
					num = num4 ^ (int)(num2 * 1519238847);
					continue;
				}
				case 3u:
				{
					int num6;
					if (!string.IsNullOrEmpty(text))
					{
						num = 1308834397;
						num6 = 1308834397;
					}
					else
					{
						num = 1345500287;
						num6 = 1345500287;
					}
					continue;
				}
				case 2u:
					text = iPAddressCollection[0].ToString();
					num = 933590084;
					continue;
				case 1u:
					text = GClass28.smethod_3();
					num = ((int)num2 * -695257033) ^ 0xD2F2F2B;
					continue;
				case 0u:
				{
					iPAddressCollection = GClass28.smethod_4();
					int num3;
					if (iPAddressCollection.Count == 0)
					{
						num = 904951489;
						num3 = 904951489;
					}
					else
					{
						num = 334098829;
						num3 = 334098829;
					}
					continue;
				}
				case 5u:
					break;
				case 4u:
					throw new Exception("Couldn't detect local DNS Server.");
				case 8u:
					throw new Exception("Couldn't detect local DNS Server.");
				default:
					return method_3(text, string_1, genum2_1, genum4_1, protocolType_0, gclass29_0);
				}
				break;
			}
		}
	}

	public GClass27 method_3(string string_1, string string_2, GEnum2 genum2_1, GEnum4 genum4_1, ProtocolType protocolType_0, GInterface1 ginterface1_0)
	{
		((CodeAccessPermission)dnsPermission_0).Demand();
		IPEndPoint ipendPoint_ = default(IPEndPoint);
		IPAddress address = default(IPAddress);
		byte[] byte_ = default(byte[]);
		ProtocolType protocolType = default(ProtocolType);
		byte[] array = default(byte[]);
		GClass27 gClass = default(GClass27);
		while (true)
		{
			int num = -771260803;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5B2459Eu) % 15u)
				{
				case 12u:
					num = (int)((num2 * 1315306356) ^ 0xE83338C);
					continue;
				case 11u:
					ipendPoint_ = new IPEndPoint(address, 53);
					num = (int)(num2 * 1544942585) ^ -127096925;
					continue;
				case 10u:
					byte_ = method_5(string_2, genum2_1, genum4_1, protocolType_0, ginterface1_0);
					num = ((int)num2 * -216099764) ^ -718984949;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (protocolType != ProtocolType.Udp)
					{
						num5 = 1260115154;
						num6 = 1260115154;
					}
					else
					{
						num5 = 698424213;
						num6 = 698424213;
					}
					num = num5 ^ ((int)num2 * -799131458);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1808900564) ^ 0x33B1DC8A;
					continue;
				case 7u:
					array = smethod_0(byte_, ipendPoint_);
					num = -1084626170;
					continue;
				case 6u:
					Trace.Assert(array != null, "Failed to retrieve data from the remote DNS server.");
					gClass = new GClass27();
					gClass.method_1(array, protocolType_0);
					num = -1579738347;
					continue;
				case 5u:
				{
					IPHostEntry hostEntry = Dns.GetHostEntry(string_1);
					address = hostEntry.AddressList[0];
					num = ((int)num2 * -787267821) ^ 0x464ACD7F;
					continue;
				}
				case 4u:
					num = (int)((num2 * 1812676613) ^ 0x1EB2A37D);
					continue;
				case 3u:
					array = method_4(byte_, ipendPoint_);
					num = -1377203019;
					continue;
				case 2u:
					array = null;
					protocolType = protocolType_0;
					num = ((int)num2 * -1971099557) ^ -313504535;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (protocolType != ProtocolType.Tcp)
					{
						num3 = -2026639570;
						num4 = -2026639570;
					}
					else
					{
						num3 = -721723132;
						num4 = -721723132;
					}
					num = num3 ^ (int)(num2 * 640719564);
					continue;
				}
				case 13u:
					break;
				case 0u:
					throw new InvalidOperationException("Invalid Protocol: " + protocolType_0);
				default:
					return gClass;
				}
				break;
			}
		}
	}

	private byte[] method_4(byte[] byte_0, IPEndPoint ipendPoint_0)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = null;
		try
		{
			udpClient.Client.ReceiveTimeout = int_1;
			udpClient.Connect(ipendPoint_0);
			udpClient.Send(byte_0, byte_0.Length);
			return udpClient.Receive(ref ipendPoint_0);
		}
		finally
		{
			udpClient.Close();
		}
	}

	private static byte[] smethod_0(byte[] byte_0, IPEndPoint ipendPoint_0)
	{
		TcpClient tcpClient = new TcpClient();
		byte[] array = null;
		try
		{
			tcpClient.Connect(ipendPoint_0);
			NetworkStream stream = default(NetworkStream);
			ushort num3 = default(ushort);
			byte[] array2 = default(byte[]);
			while (true)
			{
				int num = -426620389;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBA2BFF8Bu) % 11u)
					{
					case 10u:
					{
						int num6;
						int num7;
						if (stream.DataAvailable)
						{
							num6 = -877960871;
							num7 = -877960871;
						}
						else
						{
							num6 = -1511281682;
							num7 = -1511281682;
						}
						num = num6 ^ (int)(num2 * 2034361384);
						continue;
					}
					case 9u:
						stream.Read(array, 0, num3);
						num = (int)((num2 * 2112110508) ^ 0x1CDBF12A);
						continue;
					case 8u:
					{
						int num8;
						if (stream.DataAvailable)
						{
							num = -1550139069;
							num8 = -1550139069;
						}
						else
						{
							num = -1587652461;
							num8 = -1587652461;
						}
						continue;
					}
					case 7u:
						stream = tcpClient.GetStream();
						num = (int)((num2 * 75102337) ^ 0x104CFB67);
						continue;
					case 6u:
						array2[0] = (byte)stream.ReadByte();
						num = (int)((num2 * 1651270137) ^ 0x677213D7);
						continue;
					case 4u:
						new BinaryReader(stream);
						stream.Write(byte_0, 0, byte_0.Length);
						num = ((int)num2 * -232616509) ^ -1772024345;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (tcpClient.Connected)
						{
							num4 = 1835290461;
							num5 = 1835290461;
						}
						else
						{
							num4 = 1299651318;
							num5 = 1299651318;
						}
						num = num4 ^ (int)(num2 * 390467549);
						continue;
					}
					case 2u:
						array2 = new byte[2]
						{
							0,
							(byte)stream.ReadByte()
						};
						num = (int)((num2 * 283437049) ^ 0xE3CDA40);
						continue;
					case 1u:
						num3 = BitConverter.ToUInt16(array2, 0);
						array = new byte[num3];
						num = (int)((num2 * 1959074829) ^ 0x5168C275);
						continue;
					case 0u:
						break;
					default:
						return array;
					case 5u:
						return array;
					}
					break;
				}
			}
		}
		finally
		{
			tcpClient.Close();
		}
	}

	private byte[] method_5(string string_1, GEnum2 genum2_1, GEnum4 genum4_1, ProtocolType protocolType_0, GInterface1 ginterface1_0)
	{
		ushort num = (ushort_1 = (ushort)((uint)genum5_0 | (uint)genum6_0 | (uint)genum7_0));
		byte[] array = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			int num2 = -2143698764;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x88539DBCu) % 13u)
				{
				case 12u:
					string_0 = string_1;
					num2 = ((int)num3 * -1635855809) ^ -1974693327;
					continue;
				case 11u:
					array[0] = (byte)((uint)(num4 >> 8) & 0xFFu);
					num2 = (int)(num3 * 1609960984) ^ -1375419251;
					continue;
				case 10u:
					array = method_6();
					num2 = -1067890050;
					continue;
				case 9u:
					genum4_0 = genum4_1;
					num2 = ((int)num3 * -1706340675) ^ -1648102020;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (protocolType_0 != ProtocolType.Tcp)
					{
						num7 = -996082891;
						num8 = -996082891;
					}
					else
					{
						num7 = -779332996;
						num8 = -779332996;
					}
					num2 = num7 ^ ((int)num3 * -1831193842);
					continue;
				}
				case 7u:
				{
					int num5;
					int num6;
					if (ginterface1_0 == null)
					{
						num5 = 434179520;
						num6 = 434179520;
					}
					else
					{
						num5 = 597934573;
						num6 = 597934573;
					}
					num2 = num5 ^ ((int)num3 * -1757825612);
					continue;
				}
				case 5u:
					Array.Resize(ref array, num4 + 2);
					Array.Copy(array, 0, array, 2, num4);
					num2 = ((int)num3 * -1741789848) ^ -1535302042;
					continue;
				case 3u:
					ginterface1_0.imethod_0(this);
					num2 = (int)((num3 * 123610298) ^ 0x6662CDD6);
					continue;
				case 2u:
					array[1] = (byte)((uint)num4 & 0xFFu);
					num2 = (int)((num3 * 284657341) ^ 0x764A4A94);
					continue;
				case 1u:
					genum2_0 = genum2_1;
					num2 = ((int)num3 * -949845160) ^ -464674616;
					continue;
				case 0u:
					num4 = array.Length;
					num2 = ((int)num3 * -169873394) ^ -1996805583;
					continue;
				case 4u:
					break;
				default:
					return array;
				}
				break;
			}
		}
	}

	internal byte[] method_6()
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = default(byte[]);
		while (true)
		{
			int num = -821569704;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0BD171Du) % 15u)
				{
				case 14u:
					array = new byte[2];
					num = (int)((num2 * 269774348) ^ 0x4190B333);
					continue;
				case 13u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(ushort_2) >> 16));
					num = ((int)num2 * -724647274) ^ -854439033;
					continue;
				case 12u:
					memoryStream.Write(array, 0, array.Length);
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(ushort_4) >> 16));
					num = (int)((num2 * 1480946282) ^ 0x4D4D2D36);
					continue;
				case 10u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(list_0.Count) >> 16));
					num = (int)((num2 * 1042257711) ^ 0x32D06838);
					continue;
				case 9u:
					memoryStream.Write(array, 0, array.Length);
					num = ((int)num2 * -817104174) ^ 0x7F761A15;
					continue;
				case 8u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(ushort_0) >> 16));
					num = ((int)num2 * -1504476985) ^ -214005555;
					continue;
				case 7u:
					memoryStream.Write(array, 0, array.Length);
					num = ((int)num2 * -1312792731) ^ -963834914;
					continue;
				case 5u:
					memoryStream.Write(array, 0, array.Length);
					num = ((int)num2 * -473797203) ^ 0x957AE94;
					continue;
				case 4u:
					array = Class10.smethod_0(string_0, bool_0: false);
					memoryStream.Write(array, 0, array.Length);
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((ushort)genum2_0) >> 16));
					num = (int)((num2 * 1526370173) ^ 0x569E712);
					continue;
				case 3u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(ushort_3) >> 16));
					num = (int)((num2 * 1450890139) ^ 0x2B483594);
					continue;
				case 2u:
					memoryStream.Write(array, 0, array.Length);
					num = ((int)num2 * -1571590569) ^ 0x1BBBEA16;
					continue;
				case 1u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(ushort_1) >> 16));
					memoryStream.Write(array, 0, array.Length);
					num = (int)(num2 * 1855572819) ^ -1460346694;
					continue;
				case 0u:
					memoryStream.Write(array, 0, array.Length);
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((int)genum4_0) >> 16));
					memoryStream.Write(array, 0, array.Length);
					num = (int)(num2 * 503698193) ^ -9960438;
					continue;
				case 11u:
					break;
				default:
				{
					using (List<GInterface0>.Enumerator enumerator = base.List_0.GetEnumerator())
					{
						while (true)
						{
							IL_02e2:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -965697813;
								num4 = -965697813;
							}
							else
							{
								num3 = -1297972615;
								num4 = -1297972615;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE0BD171Du) % 4u)
								{
								case 3u:
									num3 = -965697813;
									continue;
								case 2u:
								{
									GInterface0 current = enumerator.Current;
									array = current.imethod_2();
									memoryStream.Write(array, 0, array.Length);
									num3 = -1819615196;
									continue;
								}
								default:
									goto end_IL_02b4;
								case 1u:
									break;
								case 0u:
									goto end_IL_02b4;
								}
								goto IL_02e2;
								continue;
								end_IL_02b4:
								break;
							}
							break;
						}
					}
					Trace.WriteLine($"The message bytes: {Class10.smethod_1(memoryStream.ToArray())}");
					return memoryStream.ToArray();
				}
				}
				break;
			}
		}
	}
}
