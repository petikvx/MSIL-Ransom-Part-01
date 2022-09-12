using System;
using Renci.SshNet.Security.Chaos.NaCl.Internal;

namespace Renci.SshNet.Security.Chaos.NaCl;

internal class Sha512
{
	private Array8<ulong> _state;

	private readonly byte[] _buffer;

	private ulong _totalBytes;

	public const int BlockSize = 128;

	private static readonly byte[] _padding = new byte[1] { 128 };

	public Sha512()
	{
		_buffer = new byte[128];
		Init();
	}

	public void Init()
	{
		Sha512Internal.Sha512Init(out _state);
		_totalBytes = 0uL;
	}

	public void Update(ArraySegment<byte> data)
	{
		if (data.Array == null)
		{
			throw new ArgumentNullException("data.Array");
		}
		Update(data.Array, data.Offset, data.Count);
	}

	public void Update(byte[] data, int offset, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (data.Length - offset < count)
		{
			throw new ArgumentException("Requires offset + count <= data.Length");
		}
		int num = (int)_totalBytes & 0x7F;
		_totalBytes += (uint)count;
		if (_totalBytes >= 2305843009213693951L)
		{
			throw new InvalidOperationException("Too much data");
		}
		Array16<ulong> output;
		if (num != 0)
		{
			int num2 = Math.Min(128 - num, count);
			Buffer.BlockCopy(data, offset, _buffer, num, num2);
			offset += num2;
			count -= num2;
			num += num2;
			if (num == 128)
			{
				ByteIntegerConverter.Array16LoadBigEndian64(out output, _buffer, 0);
				Sha512Internal.Core(out _state, ref _state, ref output);
				CryptoBytes.InternalWipe(_buffer, 0, _buffer.Length);
				num = 0;
			}
		}
		while (count >= 128)
		{
			ByteIntegerConverter.Array16LoadBigEndian64(out output, data, offset);
			Sha512Internal.Core(out _state, ref _state, ref output);
			offset += 128;
			count -= 128;
		}
		if (count > 0)
		{
			Buffer.BlockCopy(data, offset, _buffer, num, count);
		}
	}

	public void Finish(ArraySegment<byte> output)
	{
		if (output.Array == null)
		{
			throw new ArgumentNullException("output.Array");
		}
		if (output.Count != 64)
		{
			throw new ArgumentException("output.Count must be 64");
		}
		Update(_padding, 0, _padding.Length);
		ByteIntegerConverter.Array16LoadBigEndian64(out var output2, _buffer, 0);
		CryptoBytes.InternalWipe(_buffer, 0, _buffer.Length);
		if (((int)_totalBytes & 0x7F) > 112)
		{
			Sha512Internal.Core(out _state, ref _state, ref output2);
			output2 = default(Array16<ulong>);
		}
		output2.x15 = (_totalBytes - 1L) * 8L;
		Sha512Internal.Core(out _state, ref _state, ref output2);
		ByteIntegerConverter.StoreBigEndian64(output.Array, output.Offset, _state.x0);
		ByteIntegerConverter.StoreBigEndian64(output.Array, output.Offset + 8, _state.x1);
		ByteIntegerConverter.StoreBigEndian64(output.Array, output.Offset + 16, _state.x2);
		ByteIntegerConverter.StoreBigEndian64(output.Array, output.Offset + 24, _state.x3);
		ByteIntegerConverter.StoreBigEndian64(output.Array, output.Offset + 32, _state.x4);
		ByteIntegerConverter.StoreBigEndian64(output.Array, output.Offset + 40, _state.x5);
		ByteIntegerConverter.StoreBigEndian64(output.Array, output.Offset + 48, _state.x6);
		ByteIntegerConverter.StoreBigEndian64(output.Array, output.Offset + 56, _state.x7);
		_state = default(Array8<ulong>);
	}

	public byte[] Finish()
	{
		byte[] array = new byte[64];
		Finish(new ArraySegment<byte>(array));
		return array;
	}

	internal static byte[] Hash(byte[] data)
	{
		return Hash(data, 0, data.Length);
	}

	internal static byte[] Hash(byte[] data, int offset, int count)
	{
		Sha512 sha = new Sha512();
		sha.Update(data, offset, count);
		return sha.Finish();
	}
}
