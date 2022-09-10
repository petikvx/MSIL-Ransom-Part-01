using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

public class GClass28
{
	public static string smethod_0(short[] short_0, ProtocolType protocolType_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num3 = default(int);
		while (true)
		{
			int num = 471188629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B8AB011u) % 7u)
				{
				case 6u:
					stringBuilder.Append(", ");
					num = (int)(num2 * 248073132) ^ -943963309;
					continue;
				case 4u:
					num3 = 0;
					num = (int)(num2 * 2019547979) ^ -757232294;
					continue;
				case 2u:
					num3++;
					num = (int)((num2 * 178670859) ^ 0x16E27318);
					continue;
				case 1u:
					stringBuilder.Append(smethod_2(short_0[num3], protocolType_0));
					num = 555912711;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < short_0.Length)
					{
						num = 810607034;
						num4 = 810607034;
					}
					else
					{
						num = 854812610;
						num4 = 854812610;
					}
					continue;
				}
				case 5u:
					break;
				default:
					stringBuilder.Remove(stringBuilder.Length - 2, 2);
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	public static bool smethod_1()
	{
		int platform = (int)Environment.OSVersion.Platform;
		while (true)
		{
			int num = 133214632;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34F70DEEu) % 5u)
				{
				case 2u:
				{
					int num5;
					int num6;
					if (platform != 128)
					{
						num5 = -1596425469;
						num6 = -1596425469;
					}
					else
					{
						num5 = -2040028845;
						num6 = -2040028845;
					}
					num = num5 ^ ((int)num2 * -1160901636);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (platform == 4)
					{
						num3 = -1618163967;
						num4 = -1618163967;
					}
					else
					{
						num3 = -1740972384;
						num4 = -1740972384;
					}
					num = num3 ^ ((int)num2 * -1196443317);
					continue;
				}
				case 3u:
					break;
				default:
					return false;
				case 4u:
					return true;
				}
				break;
			}
		}
	}

	public static string smethod_2(short short_0, ProtocolType protocolType_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		ProtocolType protocolType = default(ProtocolType);
		GEnum0 gEnum = default(GEnum0);
		while (true)
		{
			int num = -2006026612;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8333591u) % 17u)
				{
				case 16u:
					protocolType = protocolType_0;
					num = (int)((num2 * 223458518) ^ 0x458E829A);
					continue;
				case 15u:
					stringBuilder.Append(")");
					num = (int)(num2 * 506787514) ^ -1189719516;
					continue;
				case 14u:
					stringBuilder.Append(short_0);
					num = ((int)num2 * -1390140665) ^ -250953155;
					continue;
				case 13u:
					num = ((int)num2 * -560451567) ^ 0x7472BC5D;
					continue;
				case 12u:
					stringBuilder.Append(")");
					num = ((int)num2 * -987211381) ^ -1468631919;
					continue;
				case 11u:
				{
					GEnum1 gEnum2 = (GEnum1)short_0;
					stringBuilder.Append(gEnum2);
					stringBuilder.Append("(");
					num = -961279633;
					continue;
				}
				case 10u:
					num = ((int)num2 * -1007433144) ^ -755935550;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (protocolType == ProtocolType.Udp)
					{
						num5 = 1802530127;
						num6 = 1802530127;
					}
					else
					{
						num5 = 79173638;
						num6 = 79173638;
					}
					num = num5 ^ ((int)num2 * -1811392292);
					continue;
				}
				case 7u:
					stringBuilder.Append("(");
					num = (int)((num2 * 1324590111) ^ 0x45FA6066);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (protocolType != ProtocolType.Tcp)
					{
						num3 = 271094289;
						num4 = 271094289;
					}
					else
					{
						num3 = 1738774789;
						num4 = 1738774789;
					}
					num = num3 ^ (int)(num2 * 293232441);
					continue;
				}
				case 5u:
					stringBuilder.Append(gEnum);
					num = ((int)num2 * -525483582) ^ -903330779;
					continue;
				case 3u:
					stringBuilder.Append(short_0);
					num = ((int)num2 * -1829338949) ^ -1149287825;
					continue;
				case 2u:
					num = ((int)num2 * -934051648) ^ -1631191113;
					continue;
				case 1u:
					stringBuilder.Append("(");
					stringBuilder.Append(short_0);
					stringBuilder.Append(")");
					num = -1544896521;
					continue;
				case 0u:
					gEnum = (GEnum0)short_0;
					num = -1190730745;
					continue;
				case 4u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	public static string smethod_3()
	{
		if (File.Exists("/etc/resolv.conf"))
		{
			StreamReader streamReader = new StreamReader("/etc/resolv.conf");
			try
			{
				string text = default(string);
				string result = default(string);
				while (true)
				{
					IL_016f:
					int num;
					int num2;
					if (streamReader.EndOfStream)
					{
						num = 1674641001;
						num2 = 1674641001;
					}
					else
					{
						num = 36828327;
						num2 = 36828327;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num ^ 0x6C8EE969u) % 11u)
						{
						case 10u:
							text = streamReader.ReadLine()!.TrimStart(new char[0]);
							num = 1903539031;
							continue;
						case 9u:
							streamReader.Close();
							num = ((int)num3 * -1410998021) ^ 0x6C1D96BE;
							continue;
						case 8u:
						{
							int num6;
							int num7;
							if (text.StartsWith("nameserver"))
							{
								num6 = -1384311170;
								num7 = -1384311170;
							}
							else
							{
								num6 = -1163878554;
								num7 = -1163878554;
							}
							num = num6 ^ ((int)num3 * -745380506);
							continue;
						}
						case 5u:
						{
							int num8;
							int num9;
							if (text.Length > 11)
							{
								num8 = -814219805;
								num9 = -814219805;
							}
							else
							{
								num8 = -805650769;
								num9 = -805650769;
							}
							num = num8 ^ (int)(num3 * 1520397407);
							continue;
						}
						case 4u:
							result = text;
							num = (int)(num3 * 950961877) ^ -190652869;
							continue;
						case 3u:
							num = 36828327;
							continue;
						case 2u:
						{
							text = text.Substring(10).Trim();
							int num4;
							int num5;
							if (!string.IsNullOrEmpty(text))
							{
								num4 = 248439757;
								num5 = 248439757;
							}
							else
							{
								num4 = 773773025;
								num5 = 773773025;
							}
							num = num4 ^ (int)(num3 * 181452709);
							continue;
						}
						case 0u:
							streamReader.Close();
							num = (int)((num3 * 1305221218) ^ 0x2709F9FE);
							continue;
						default:
							goto end_IL_0122;
						case 1u:
							break;
						case 7u:
							goto end_IL_0122;
						case 6u:
							return result;
						}
						goto IL_016f;
						continue;
						end_IL_0122:
						break;
					}
					break;
				}
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_01b5:
						int num10 = 2058254558;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)num10 ^ 0x6C8EE969u) % 3u)
							{
							case 1u:
								goto IL_0185;
							default:
								goto end_IL_0198;
							case 2u:
								break;
							case 0u:
								goto end_IL_0198;
							}
							goto IL_01b5;
							IL_0185:
							((IDisposable)streamReader).Dispose();
							num10 = (int)(num3 * 1888040352) ^ -485946790;
							continue;
							end_IL_0198:
							break;
						}
						break;
					}
				}
			}
		}
		return string.Empty;
	}

	public static IPAddressCollection smethod_4()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array = default(NetworkInterface[]);
		NetworkInterface networkInterface = default(NetworkInterface);
		int num9 = default(int);
		IPAddressCollection dnsAddresses = default(IPAddressCollection);
		bool flag = default(bool);
		IPAddress current = default(IPAddress);
		IPAddressCollection result = default(IPAddressCollection);
		while (true)
		{
			int num = -524816122;
			while (true)
			{
				int num3;
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE4E3358u) % 11u)
				{
				case 10u:
					array = allNetworkInterfaces;
					num = (int)(num2 * 818723132) ^ -567308999;
					continue;
				case 9u:
					if (networkInterface.Speed > 0L)
					{
						num = (int)((num2 * 410890533) ^ 0x216887EE);
						continue;
					}
					goto IL_0083;
				case 7u:
					if (num9 >= array.Length)
					{
						num3 = -1782386667;
						goto IL_0056;
					}
					goto case 0u;
				case 0u:
					networkInterface = array[num9];
					num = -881843876;
					continue;
				case 6u:
					num9 = 0;
					num = ((int)num2 * -413089045) ^ -1303220099;
					continue;
				case 5u:
					if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Tunnel)
					{
						num = (int)((num2 * 879236508) ^ 0x48DA4D27);
						continue;
					}
					goto IL_0083;
				case 4u:
					dnsAddresses = networkInterface.GetIPProperties().DnsAddresses;
					flag = false;
					num = ((int)num2 * -578647577) ^ 0x65A55E08;
					continue;
				default:
				{
					IEnumerator<IPAddress> enumerator = dnsAddresses.GetEnumerator();
					try
					{
						while (true)
						{
							IL_01a1:
							int num4;
							int num5;
							if (!enumerator.MoveNext())
							{
								num4 = -2060979084;
								num5 = -2060979084;
							}
							else
							{
								num4 = -1171009613;
								num5 = -1171009613;
							}
							while (true)
							{
								switch ((num2 = (uint)num4 ^ 0xBE4E3358u) % 6u)
								{
								case 4u:
									flag = true;
									num4 = (int)((num2 * 468284886) ^ 0x486152C1);
									continue;
								case 3u:
								{
									int num6;
									int num7;
									if (current.AddressFamily != AddressFamily.InterNetwork)
									{
										num6 = 310937722;
										num7 = 310937722;
									}
									else
									{
										num6 = 1193240023;
										num7 = 1193240023;
									}
									num4 = num6 ^ (int)(num2 * 1269166543);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num4 = -561946523;
									continue;
								case 0u:
									num4 = -1171009613;
									continue;
								default:
									goto end_IL_0168;
								case 5u:
									break;
								case 2u:
									goto end_IL_0168;
								}
								goto IL_01a1;
								continue;
								end_IL_0168:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								IL_01ea:
								int num8 = -2130427562;
								while (true)
								{
									switch ((num2 = (uint)num8 ^ 0xBE4E3358u) % 3u)
									{
									case 1u:
										goto IL_01b7;
									default:
										goto end_IL_01cc;
									case 2u:
										break;
									case 0u:
										goto end_IL_01cc;
									}
									goto IL_01ea;
									IL_01b7:
									enumerator.Dispose();
									num8 = (int)((num2 * 702449139) ^ 0x1B9A3024);
									continue;
									end_IL_01cc:
									break;
								}
								break;
							}
						}
					}
					if (flag)
					{
						goto IL_0051;
					}
					goto IL_0083;
				}
				case 2u:
					if (networkInterface.OperationalStatus == OperationalStatus.Up)
					{
						num = (int)(num2 * 1722518739) ^ -1133818150;
						continue;
					}
					goto IL_0083;
				case 1u:
					if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
					{
						num = ((int)num2 * -40203851) ^ 0x69F0CFBC;
						continue;
					}
					goto IL_0083;
				case 8u:
					break;
					IL_0056:
					switch ((num2 = (uint)num3 ^ 0xBE4E3358u) % 6u)
					{
					case 4u:
						break;
					case 3u:
						goto IL_0051;
					case 2u:
						goto IL_0083;
					case 1u:
						return dnsAddresses;
					default:
						return result;
					case 5u:
						return null;
					}
					goto case 7u;
					IL_0051:
					num3 = -1838076997;
					goto IL_0056;
					IL_0083:
					num9++;
					num3 = -869571494;
					goto IL_0056;
				}
				break;
			}
		}
	}
}
