using System;
using System.Globalization;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security.Cryptography;

internal class SshDataSignature : SshData
{
	private int _signature_size;

	private byte[] _signature_r;

	private byte[] _signature_s;

	public byte[] Signature
	{
		get
		{
			byte[] array = new byte[_signature_size];
			Buffer.BlockCopy(_signature_r, 0, array, 0, _signature_r.Length);
			Buffer.BlockCopy(_signature_s, 0, array, _signature_r.Length, _signature_s.Length);
			return array;
		}
		set
		{
			byte[] array = new byte[_signature_size / 2];
			Buffer.BlockCopy(value, 0, array, 0, array.Length);
			_signature_r = array.ToBigInteger2().ToByteArray().Reverse();
			byte[] array2 = new byte[_signature_size / 2];
			Buffer.BlockCopy(value, array.Length, array2, 0, array2.Length);
			_signature_s = array2.ToBigInteger2().ToByteArray().Reverse();
		}
	}

	protected override int BufferCapacity => base.BufferCapacity + 4 + _signature_r.Length + 4 + _signature_s.Length;

	public SshDataSignature(int sig_size)
	{
		_signature_size = sig_size;
	}

	public SshDataSignature(byte[] data, int sig_size)
	{
		_signature_size = sig_size;
		Load(data);
	}

	protected override void LoadData()
	{
		_signature_r = ReadBinary().TrimLeadingZeros().Pad(_signature_size / 2);
		_signature_s = ReadBinary().TrimLeadingZeros().Pad(_signature_size / 2);
	}

	protected override void SaveData()
	{
		WriteBinaryString(_signature_r.ToBigInteger2().ToByteArray().Reverse());
		WriteBinaryString(_signature_s.ToBigInteger2().ToByteArray().Reverse());
	}

	public new byte[] ReadBinary()
	{
		uint num = ReadUInt32();
		if (num > int.MaxValue)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Strings longer than {0} is not supported.", new object[1] { int.MaxValue }));
		}
		return ReadBytes((int)num);
	}
}
