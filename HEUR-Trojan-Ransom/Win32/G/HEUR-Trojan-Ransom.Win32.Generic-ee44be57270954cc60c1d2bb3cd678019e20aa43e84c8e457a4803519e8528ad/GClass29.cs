#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;

public class GClass29 : GInterface1
{
	private const string string_0 = "hmac-sha256.";

	private readonly string string_1;

	private readonly string string_2;

	private readonly ushort ushort_0;

	private readonly byte[] byte_0;

	private readonly HMACSHA256 hmacsha256_0;

	public GClass29(string string_3, string string_4, ushort ushort_1)
	{
		string_1 = string_3;
		ushort_0 = ushort_1;
		byte_0 = Convert.FromBase64String(string_4);
		if (byte_0 == null)
		{
			throw new ArgumentException("Argument is not a valid base64 string", "sharedKey");
		}
		hmacsha256_0 = new HMACSHA256(byte_0);
		string_2 = "hmac-sha256.";
	}

	public GClass26 imethod_0(GClass26 gclass26_0)
	{
		DateTime now = DateTime.Now;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array2 = default(byte[]);
		long long_ = default(long);
		int int_ = default(int);
		byte[] array = default(byte[]);
		byte[] buffer = default(byte[]);
		while (true)
		{
			int num = 1545729380;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1020A2FAu) % 19u)
				{
				case 18u:
					memoryStream.Write(array, 0, array.Length);
					num = ((int)num2 * -96983581) ^ 0x5A2F805A;
					continue;
				case 17u:
					memoryStream.Write(array, 0, array.Length);
					num = (int)((num2 * 270453849) ^ 0x6B7456F0);
					continue;
				case 15u:
					array2 = gclass26_0.method_6();
					num = ((int)num2 * -88746101) ^ -389578588;
					continue;
				case 14u:
					memoryStream.Write(array, 0, array.Length);
					num = ((int)num2 * -545426356) ^ 0x619E10A5;
					continue;
				case 13u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(0) >> 16));
					memoryStream.Write(array, 0, array.Length);
					num = (int)((num2 * 179992904) ^ 0x68E501E);
					continue;
				case 12u:
					array = BitConverter.GetBytes((uint)(IPAddress.HostToNetworkOrder((uint)long_) >> 32));
					num = ((int)num2 * -672482363) ^ 0x23BA4F39;
					continue;
				case 11u:
					array = Class10.smethod_0(string_2, bool_0: true);
					num = ((int)num2 * -1015644324) ^ 0x30479350;
					continue;
				case 10u:
					Class10.smethod_2(now.ToUniversalTime(), out int_, out long_);
					num = (int)((num2 * 890574140) ^ 0x5ED0DA72);
					continue;
				case 9u:
					memoryStream.Write(array, 0, array.Length);
					num = (int)(num2 * 294347239) ^ -27081351;
					continue;
				case 8u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(255) >> 16));
					memoryStream.Write(array, 0, array.Length);
					array = BitConverter.GetBytes((uint)(IPAddress.HostToNetworkOrder(0L) >> 32));
					num = (int)(num2 * 1384106383) ^ -1206553111;
					continue;
				case 7u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(0) >> 16));
					num = ((int)num2 * -1318587900) ^ 0x4CEBA72F;
					continue;
				case 6u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(ushort_0) >> 16));
					memoryStream.Write(array, 0, array.Length);
					num = (int)((num2 * 2044285574) ^ 0x5B38803D);
					continue;
				case 5u:
					array = Class10.smethod_0(string_1, bool_0: false);
					num = ((int)num2 * -2077597377) ^ 0x66DA44C2;
					continue;
				case 4u:
					Trace.WriteLine($"Message Header Bytes: {Class10.smethod_1(array2)}");
					memoryStream = new MemoryStream();
					memoryStream.Write(array2, 0, array2.Length);
					num = ((int)num2 * -711051585) ^ 0x5C54AE9F;
					continue;
				case 2u:
					memoryStream.Write(array, 0, array.Length);
					num = (int)((num2 * 260575476) ^ 0x7D7403D9);
					continue;
				case 1u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((ushort)int_) >> 16));
					memoryStream.Write(array, 0, array.Length);
					num = (int)((num2 * 194373750) ^ 0x4AA3BA88);
					continue;
				case 0u:
					buffer = memoryStream.ToArray();
					num = ((int)num2 * -1211227203) ^ -656268741;
					continue;
				case 3u:
					break;
				default:
				{
					Trace.WriteLine($"Data to hash: {Class10.smethod_1(buffer)}");
					byte[] byte_ = hmacsha256_0.ComputeHash(buffer);
					Trace.WriteLine($"hash: {Class10.smethod_1(byte_)}");
					gclass26_0.List_0.Add(new GClass23(string_1, string_2, GEnum8.NoError, ushort_0, gclass26_0.UInt16_0, new byte[0], byte_, now));
					return gclass26_0;
				}
				}
				break;
			}
		}
	}
}
